using System;
using System.Globalization;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using TDLibCore;
using TDLibCore.Api;
using TDLibCore.ClientExtensions;
using TDLibCore.JsonClient;

namespace example
{
    public class ScriptingGlobals
    {
        public Client client;
    }

    class Program
    {
        private static TaskCompletionSource<bool> waitAuthReady;

        private static async void AuthHandler(object sender, Update u)
        {
            var client = (Client)sender;
            if (u is UpdateAuthorizationState uas)
            {
                try
                {
                    var state = uas.AuthorizationState;
                    string input;
                    switch (state)
                    {
                        case AuthorizationStateWaitTdlibParameters _:
                            await client.SetTdlibParameters(new TdlibParameters
                            {
                                UseTestDc = false,
                                DatabaseDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "td", "db"),
                                FilesDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "td", "files"),
                                UseFileDatabase = false,
                                UseChatInfoDatabase = true,
                                UseMessageDatabase = true,
                                UseSecretChats = false,
                                // api id/hash from https://github.com/tdlib/td/blob/f9a600c401ba20af7e07ee60e12b1de28dd2e14c/example/java/org/drinkless/tdlib/example/Example.java#L107
                                ApiId = 94575,
                                ApiHash = "a3406de8d171bb422bb6ddf3bbd800e2",
                                SystemLanguageCode = CultureInfo.CurrentCulture.Name,
                                DeviceModel = "PC",
                                SystemVersion = "",
                                ApplicationVersion = typeof(Client).Assembly.GetName().Version?.ToString() ?? "0",
                                EnableStorageOptimizer = true,
                                IgnoreFileNames = false
                            });
                            await client.SetOption("ignore_inline_thumbnails", new OptionValueBoolean(true));
                            break;

                        case AuthorizationStateWaitEncryptionKey _:
                            await client.CheckDatabaseEncryptionKey();
                            break;

                        case AuthorizationStateWaitPhoneNumber _:
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write("Phone number/bot token: ");
                            Console.ResetColor();
                            input = Console.ReadLine().Trim();
                            if (input.Contains(':'))
                                await client.CheckAuthenticationBotToken(input);
                            else
                                await client.SetAuthenticationPhoneNumber(input);

                            break;

                        case AuthorizationStateWaitCode swc:
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write(string.Format("Code from {0}: ", swc.CodeInfo.Type.GetType().Name));
                            Console.ResetColor();
                            input = Console.ReadLine().Trim();
                            await client.CheckAuthenticationCode(input);
                            break;

                        case AuthorizationStateWaitPassword _:
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write("Password: ");
                            Console.ResetColor();
                            input = Console.ReadLine().Trim();
                            await client.CheckAuthenticationPassword(input);
                            break;

                        case AuthorizationStateReady _:
                            client.Update -= AuthHandler;
                            waitAuthReady.SetResult(true);
                            break;
                    }
                }
                catch (Exception e)
                {
                    waitAuthReady.SetException(e);
                }
            }
        }

        public static async Task Main()
        {
            JsonClient.Logging.VerbosityLevel = 1;
            var eval = new ScriptEvaluator();
            var cts = new CancellationTokenSource();
            var ct = cts.Token;
            var canceltasksrc = new TaskCompletionSource<bool>();
            ct.Register(canceltasksrc.SetCanceled);
            Console.CancelKeyPress += (sender, e) =>
            {
                Console.WriteLine("stopping...");
                cts.Cancel();
                e.Cancel = true;
            };

            using var client = JsonClient.Create();
            waitAuthReady = new TaskCompletionSource<bool>();
            client.Update += AuthHandler;
            client.Update += (sender, u) => { Console.WriteLine(eval.FormatObject(u)); };
            client.RunEventLoop();


            await Task.WhenAny(waitAuthReady.Task, canceltasksrc.Task);
            if (waitAuthReady.Task.IsCompleted)
            {
                var me = await client.GetMe();
                if (!(me.Type is UserTypeBot))
                {
                    await client.SendMessage(me.Id, inputMessageContent: new InputMessageText("hello from TDLibCore"));
                }
                Console.WriteLine(me.ToJsonString(indented: true));
                Console.WriteLine(eval.FormatObject(me));
                await Task.Run(async () =>
                {
                    await eval.Initialize(new ScriptingGlobals { client = client });
                    await eval.StartInteractive();
                }, cts.Token);
            }
            await client.Close();
        }
    }
}
