using ConsoleApp1.Bot;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.RegularExpressions;
using TDLib.Api;

namespace TDLib.Test
{
    [TestClass]
    public class TestDispatchers
    {
        [TestMethod]
        public void TestCommandDispatcher()
        {
            var user = new User { Username = "testbot" };
            var disp = new MessageCommandDispatcher(user);
            var matched = false;
            disp.Add("testcmd", m => { matched = true; });
            disp.Dispatch(new UpdateNewMessage { Message = new Message { Content = new MessageText { Text = new FormattedText { Text = "/testcmd@otherbot", Entities = new[] { new TextEntity { Offset = 0, Length = 17, Type = new TextEntityTypeBotCommand() } } } } } });
            Assert.IsFalse(matched);
            disp.Dispatch(new UpdateNewMessage { Message = new Message { Content = new MessageText { Text = new FormattedText { Text = "/nullcmd@testbot", Entities = new[] { new TextEntity { Offset = 0, Length = 16, Type = new TextEntityTypeBotCommand() } } } } } });
            Assert.IsFalse(matched);
            disp.Dispatch(new UpdateNewMessage { Message = new Message { Content = new MessageText { Text = new FormattedText { Text = "/nullcmd", Entities = new[] { new TextEntity { Offset = 0, Length = 8, Type = new TextEntityTypeBotCommand() } } } } } });
            Assert.IsFalse(matched);
            disp.Dispatch(new UpdateNewMessage { Message = new Message { Content = new MessageText { Text = new FormattedText { Text = "/testcmd@testbot", Entities = new[] { new TextEntity { Offset = 0, Length = 16, Type = new TextEntityTypeBotCommand() } } } } } });
            Assert.IsTrue(matched);
            matched = false;
            disp.Dispatch(new UpdateNewMessage { Message = new Message { Content = new MessageText { Text = new FormattedText { Text = "/testcmd", Entities = new[] { new TextEntity { Offset = 0, Length = 8, Type = new TextEntityTypeBotCommand() } } } } } });
            Assert.IsTrue(matched);
        }

        [TestMethod]
        public void TestRegexDispatcher()
        {
            var user = new User { Username = "testbot" };
            var disp = new MessageRegexDispatcher(user);
            var matched = false;
            disp.Add(@"\d+", RegexOptions.None, (m, _) => { matched = true; });
            disp.Dispatch(new UpdateNewMessage { Message = new Message { Content = new MessageText { Text = new FormattedText { Text = "foo", Entities = new TextEntity[0] } } } });
            Assert.IsFalse(matched);
            disp.Dispatch(new UpdateNewMessage { Message = new Message { Content = new MessageText { Text = new FormattedText { Text = "foo114514foo", Entities = new TextEntity[0] } } } });
            Assert.IsTrue(matched);
        }

        [TestMethod]
        public void TestUpdateTypeDispatcher()
        {
            var user = new User { Username = "testbot" };
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
