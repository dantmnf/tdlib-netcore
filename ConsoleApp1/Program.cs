using System;
using System.Threading.Tasks;
using System.IO;
using TDLib.Api;
using TDLib.Api.Types;
using System.Linq;
using System.Text;
using TDLib.ClientExtensions;
using System.Threading;

namespace ConsoleApp1
{
    public class ScriptingGlobals
    {
        public TDLib.Client client;
    }

    class Program
    {
        private static TaskCompletionSource<bool> waitAuthReady;

        private static async void AuthHandler(object sender, Update u)
        {
            var client = (TDLib.Client) sender;
            if (u is UpdateAuthorizationState uas)
            {
                var state = uas.AuthorizationState;
                if (state is AuthorizationStateWaitTdlibParameters)
                {
                    await client.SetTdlibParameters(
                        new TdlibParameters
                        {
                            UseTestDc = false,
                            DatabaseDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "td", "db"),
                            FilesDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "td", "files"),
                            UseFileDatabase = false,
                            UseChatInfoDatabase = true,
                            UseMessageDatabase = true,
                            UseSecretChats = false,
                            ApiId = 25655,
                            ApiHash = "3359e75d6827a3ad0561cd38811a6864",
                            SystemLanguageCode = "C",
                            DeviceModel = "ruby-tdlib",
                            SystemVersion = "system",
                            ApplicationVersion = "0",
                            EnableStorageOptimizer = true,
                            IgnoreFileNames = false
                        }
                    );
                }
                else if (state is AuthorizationStateWaitEncryptionKey)
                {
                    await client.CheckDatabaseEncryptionKey();
                }
                else if (state is AuthorizationStateWaitPhoneNumber)
                {
                    Console.Write("Phone number/bot token: ");
                    var input = Console.ReadLine().Trim();
                    if (input.Contains(':'))
                    {
                        await client.CheckAuthenticationBotToken(input);
                    }
                    else
                    {
                        await client.SetAuthenticationPhoneNumber(input);
                    }
                }
                else if (state is AuthorizationStateWaitCode swc)
                {
                    Console.Write("Code from {0}: ", swc.CodeInfo.Type.GetType().Name);
                    var code = Console.ReadLine().Trim();
                    await client.CheckAuthenticationCode(code);
                }
                else if (state is AuthorizationStateWaitPassword)
                {
                    Console.Write("Password: ");
                    var input = Console.ReadLine().Trim();
                    await client.CheckAuthenticationPassword(input);
                }
                else if (state is AuthorizationStateReady)
                {
                    client.Update -= AuthHandler;
                    waitAuthReady.SetResult(true);
                }
            }
        }

        public static async Task Main()
        {
            TDLib.Logging.LogLevel = 1;
            var eval = new ScriptEvaluator();
            var cts = new CancellationTokenSource();
            var ct = cts.Token;
            var canceltasksrc = new TaskCompletionSource<bool>();
            ct.Register(() => canceltasksrc.SetResult(true));
            Console.CancelKeyPress += (sender, e) => {
                Console.WriteLine("stopping...");
                cts.Cancel();
                e.Cancel = true;
            };

            using (var client = new TDLib.Client())
            {
                waitAuthReady = new TaskCompletionSource<bool>();
                client.Update += AuthHandler;
                client.Update += (sender, u) => { Console.WriteLine(eval.FormatObject(u)); };
                var loop = client.Run();
                
                await waitAuthReady.Task;
                var me = await client.GetMe();
                // await client.SendMessage(73399058, input_message_content: new InputMessageText { text = "啊啊啊后唱戏" });
                // await client.ParseTextEntities("aaa", new TextParseModeMarkdown());
                Console.WriteLine(eval.FormatObject(me));
                await Task.Run(async () =>
                {
                    await eval.Initialize(new ScriptingGlobals { client = client });
                    await eval.StartInteractive();
                });

                await client.StopAsync();
            }
        }
    }
}
