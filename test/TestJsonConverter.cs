using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Buffers;
using System.Text;
using TDLib.Api;
using TDLib.JsonClient;

namespace TDLib.Test
{
    [TestClass]
    public class TestJsonConverter
    {
        [TestMethod]
        public unsafe void Run()
        {

            var json = @"{""@type"":""replyMarkupInlineKeyboard"",""rows"":[[{""@type"":""inlineKeyboardButton"",""text"":""\b\f\n\r\t\\\""\ud83d\udc34"",""type"":{""@type"":""inlineKeyboardButtonTypeUrl"",""url"":""example.com""}}],[{""@type"":""inlineKeyboardButton"",""text"":""333"",""type"":{""@type"":""inlineKeyboardButtonTypeUrl"",""url"":""example.com""}},{""@type"":""inlineKeyboardButton"",""text"":""444"",""type"":{""@type"":""inlineKeyboardButtonTypeUrl"",""url"":""example.com""}}]]}\0";
            ReadOnlySpan<byte> bytes = Encoding.UTF8.GetBytes(json);
            //var obj = JsonConvert.DeserializeObject<TLObject>(json, converter);
            TLObject obj;
            fixed (byte* ptr = bytes)
                obj = TDLib.JsonClient.JsonClient.FetchObject(ptr).TLObject;
            Assert.IsTrue(obj is ReplyMarkupInlineKeyboard);
            var kb = (ReplyMarkupInlineKeyboard)obj;
            Assert.AreEqual("\b\f\n\r\t\\\"\ud83d\udc34", kb.Rows[0][0].Text);
            Assert.IsInstanceOfType(kb.Rows[0][0].Type, typeof(InlineKeyboardButtonTypeUrl));
            Assert.AreEqual("333", kb.Rows[1][0].Text);
            Assert.AreEqual("444", kb.Rows[1][1].Text);

            //json = JsonConvert.SerializeObject(kb, Formatting.None, setting);
            //obj = JsonConvert.DeserializeObject<TLObject>(json, converter);
            var buffer = new ArrayBufferWriter<byte>(512);
            TDLib.JsonClient.JsonClient.DumpObject(new TLObjectWithExtra(obj), buffer);
            bytes = buffer.WrittenSpan;
            fixed (byte* ptr = bytes)
                obj = TDLib.JsonClient.JsonClient.FetchObject(ptr).TLObject;

            Assert.IsTrue(obj is ReplyMarkupInlineKeyboard);
            kb = (ReplyMarkupInlineKeyboard)obj;
            Assert.AreEqual("\b\f\n\r\t\\\"\ud83d\udc34", kb.Rows[0][0].Text);
            Assert.IsInstanceOfType(kb.Rows[0][0].Type, typeof(InlineKeyboardButtonTypeUrl));
            Assert.AreEqual("333", kb.Rows[1][0].Text);
            Assert.AreEqual("444", kb.Rows[1][1].Text);
        }
    }
}
