using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using TDLib;
using TDLib.Api.Types;
using ConsoleApp1.Bot;
using System.Text.RegularExpressions;

namespace test
{
    [TestClass]
    public class TestDispatchers
    {
        [TestMethod]
        public void TestCommandDispatcher()
        {
            var user = new User {  username = "testbot" };
            var disp = new MessageCommandDispatcher(user);
            var matched = false;
            disp.Add("testcmd", m => { matched = true; });
            disp.Dispatch(new UpdateNewMessage { message = new Message { content = new MessageText { text = new FormattedText { text = "/testcmd@otherbot", entities = new [] { new TextEntity { offset = 0, length = 17, type = new TextEntityTypeBotCommand() } } } } } });
            Assert.IsFalse(matched);
            disp.Dispatch(new UpdateNewMessage { message = new Message { content = new MessageText { text = new FormattedText { text = "/nullcmd@testbot", entities = new[] { new TextEntity { offset = 0, length = 16, type = new TextEntityTypeBotCommand() } } } } } });
            Assert.IsFalse(matched);
            disp.Dispatch(new UpdateNewMessage { message = new Message { content = new MessageText { text = new FormattedText { text = "/nullcmd", entities = new[] { new TextEntity { offset = 0, length = 8, type = new TextEntityTypeBotCommand() } } } } } });
            Assert.IsFalse(matched);
            disp.Dispatch(new UpdateNewMessage { message = new Message { content = new MessageText { text = new FormattedText { text = "/testcmd@testbot", entities = new[] { new TextEntity { offset = 0, length = 16, type = new TextEntityTypeBotCommand() } } } } } });
            Assert.IsTrue(matched);
            matched = false;
            disp.Dispatch(new UpdateNewMessage { message = new Message { content = new MessageText { text = new FormattedText { text = "/testcmd", entities = new[] { new TextEntity { offset = 0, length = 8, type = new TextEntityTypeBotCommand() } } } } } });
            Assert.IsTrue(matched);
        }

        [TestMethod]
        public void TestRegexDispatcher()
        {
            var user = new User { username = "testbot" };
            var disp = new MessageRegexDispatcher(user);
            var matched = false;
            disp.Add(@"\d+", RegexOptions.None, (m, _) => { matched = true; });
            disp.Dispatch(new UpdateNewMessage { message = new Message { content = new MessageText { text = new FormattedText { text = "foo", entities = new TextEntity[0] } } } });
            Assert.IsFalse(matched);
            disp.Dispatch(new UpdateNewMessage { message = new Message { content = new MessageText { text = new FormattedText { text = "foo114514foo", entities = new TextEntity[0] } } } });
            Assert.IsTrue(matched);
        }

        [TestMethod]
        public void TestUpdateTypeDispatcher()
        {
            var user = new User { username = "testbot" };
            var disp = new UpdateTypeDispatcher(user);
            var matched = false;
            disp.Add(typeof(UpdateChatTitle), u => { matched = true; });
            disp.Dispatch(new UpdateBasicGroupFullInfo());
            Assert.IsFalse(matched);
            disp.Dispatch(new UpdateChatTitle());
            Assert.IsTrue(matched);

        }
    }
}
