using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDLib.Api;
using TDLib.Api.Types;
using Newtonsoft.Json;
using System.Text;
using System;

namespace test
{
    [TestClass]
    public class TestSerialization
    {
        [TestMethod]
        public void TestMultidimensionalArray()
        {
            //var setting = new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore };
            //var converter = new TLObjectConverter();

            var json = @"{""@type"":""replyMarkupInlineKeyboard"",""rows"":[[{""@type"":""inlineKeyboardButton"",""text"":""111"",""type"":{""@type"":""inlineKeyboardButtonTypeUrl"",""url"":""example.com""}}],[{""@type"":""inlineKeyboardButton"",""text"":""333"",""type"":{""@type"":""inlineKeyboardButtonTypeUrl"",""url"":""example.com""}},{""@type"":""inlineKeyboardButton"",""text"":""444"",""type"":{""@type"":""inlineKeyboardButtonTypeUrl"",""url"":""example.com""}}]]}\0";
            ArraySegment<byte> bytes = Encoding.UTF8.GetBytes(json);
            //var obj = JsonConvert.DeserializeObject<TLObject>(json, converter);
            var obj = TDLib.Client.CStringToTLObject(bytes);
            Assert.IsTrue(obj is ReplyMarkupInlineKeyboard);
            var kb = (ReplyMarkupInlineKeyboard)obj;
            Assert.AreEqual("111", kb.rows[0][0].text);
            Assert.IsInstanceOfType(kb.rows[0][0].type, typeof(InlineKeyboardButtonTypeUrl));
            Assert.AreEqual("333", kb.rows[1][0].text);
            Assert.AreEqual("444", kb.rows[1][1].text);

            //json = JsonConvert.SerializeObject(kb, Formatting.None, setting);
            //obj = JsonConvert.DeserializeObject<TLObject>(json, converter);

            bytes = TDLib.Client.TLObjectToBytes(obj);
            obj = TDLib.Client.CStringToTLObject(bytes);

            Assert.IsTrue(obj is ReplyMarkupInlineKeyboard);
            kb = (ReplyMarkupInlineKeyboard)obj;
            Assert.AreEqual("111", kb.rows[0][0].text);
            Assert.IsInstanceOfType(kb.rows[0][0].type, typeof(InlineKeyboardButtonTypeUrl));
            Assert.AreEqual("333", kb.rows[1][0].text);
            Assert.AreEqual("444", kb.rows[1][1].text);
        }
    }
}
