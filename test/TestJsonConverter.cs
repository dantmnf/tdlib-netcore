using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
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

            var json = @"{""@type"":""replyMarkupInlineKeyboard"",""rows"":[[{""@type"":""inlineKeyboardButton"",""text"":""111"",""type"":{""@type"":""inlineKeyboardButtonTypeUrl"",""url"":""example.com""}}],[{""@type"":""inlineKeyboardButton"",""text"":""333"",""type"":{""@type"":""inlineKeyboardButtonTypeUrl"",""url"":""example.com""}},{""@type"":""inlineKeyboardButton"",""text"":""444"",""type"":{""@type"":""inlineKeyboardButtonTypeUrl"",""url"":""example.com""}}]]}\0";
            ReadOnlySpan<byte> bytes = Encoding.UTF8.GetBytes(json);
            //var obj = JsonConvert.DeserializeObject<TLObject>(json, converter);
            TLObject obj;
            fixed (byte* ptr = bytes)
                obj = TDLib.JsonClient.JsonClient.CStringToTLObject(ptr).TLObject;
            Assert.IsTrue(obj is ReplyMarkupInlineKeyboard);
            var kb = (ReplyMarkupInlineKeyboard)obj;
            Assert.AreEqual("111", kb.Rows[0][0].Text);
            Assert.IsInstanceOfType(kb.Rows[0][0].Type, typeof(InlineKeyboardButtonTypeUrl));
            Assert.AreEqual("333", kb.Rows[1][0].Text);
            Assert.AreEqual("444", kb.Rows[1][1].Text);

            //json = JsonConvert.SerializeObject(kb, Formatting.None, setting);
            //obj = JsonConvert.DeserializeObject<TLObject>(json, converter);

            bytes = TDLib.JsonClient.JsonClient.TLObjectToBytes(new TLObjectWithExtra() { TLObject = obj }, null, 0);
            fixed (byte* ptr = bytes)
                obj = TDLib.JsonClient.JsonClient.CStringToTLObject(ptr).TLObject;

            Assert.IsTrue(obj is ReplyMarkupInlineKeyboard);
            kb = (ReplyMarkupInlineKeyboard)obj;
            Assert.AreEqual("111", kb.Rows[0][0].Text);
            Assert.IsInstanceOfType(kb.Rows[0][0].Type, typeof(InlineKeyboardButtonTypeUrl));
            Assert.AreEqual("333", kb.Rows[1][0].Text);
            Assert.AreEqual("444", kb.Rows[1][1].Text);
        }
    }
}
