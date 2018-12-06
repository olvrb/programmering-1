using System;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;
using Discord;
using Discord.Addons.Interactive;
using Discord.Commands;
using Discord.WebSocket;
using FallProject.Handlers;
using Microsoft.Extensions.DependencyInjection;

namespace FallProject {
    public class Program {
        private const string              Prefix = "!";
        private       CommandService      _commands;
        private       IServiceProvider    _services;
        public        DiscordSocketClient Client;
        private       string              Token { get; set; }

        /* SimpleList tests */
        // public static void Main(string[] args) {
        //     SimpleList list = new SimpleList(SimpleList.GetListFromBase64SimpleList("b2w=,b2wy,b2wyMw=="));
        //     list.Add("test3");
        //     list.Remove("test1");
        //     Console.WriteLine(list.GetRawList());
        //     foreach (string l in list.GetList()) {
        //         Console.WriteLine(l);
        //     }
        // }


        // ReSharper disable once UnusedParameter.Local
        private static void Main(string[] args) => new Program().RunBotAsync()
                                                                .GetAwaiter()
                                                                .GetResult();

        public async Task RunBotAsync() {
            // Load the Discord token from token.txt.
            // I know there are better ways to do configuration files, but this was the fastest and easiest I could think of
            // (same goes for the database connection string).
            Token     = File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "token.txt")).Trim();
            Client    = new DiscordSocketClient();
            _commands = new CommandService();
            _services = new ServiceCollection()
                        .AddSingleton(Client)
                        .AddSingleton(_commands)
                        .AddSingleton<InteractiveService>()
                        .BuildServiceProvider();

            // Bind event listeners.
            Client.Log            += Log;
            Client.MessageUpdated += MessageEdit;

            await RegisterCommandsAsync();

            await Client.LoginAsync(TokenType.Bot, Token);

            await Client.StartAsync();

            // Don't, stop me now...
            await Task.Delay(-1);
        }

        private Task Log(LogMessage arg) {
            Console.WriteLine(arg);
            return Task.CompletedTask;
        }

        private async Task RegisterCommandsAsync() {
            Client.MessageReceived += HandleCommandAsync;
            await _commands.AddModulesAsync(Assembly.GetEntryAssembly());
        }


        private async Task HandleCommandAsync(SocketMessage arg) {
            await MessageCreateHandler.CreateMessage(arg, Client);
            if (!(arg is SocketUserMessage message) || message.Author.IsBot || message.Author.IsWebhook) {
                return;
            }

            // Where the arguments start.
            int argPos = 0;

            // Make sure the message starts with the prefix, or mentions the CurrentUser
            if (message.HasStringPrefix(Prefix, ref argPos) ||
                message.HasMentionPrefix(Client.CurrentUser, ref argPos)) {
                SocketCommandContext context = new SocketCommandContext(Client, message);

                IResult res = await _commands.ExecuteAsync(context, argPos, _services);
                if (!res.IsSuccess) {
                    Console.WriteLine(res.ErrorReason);
                }
            }
        }

        private async Task MessageEdit(Cacheable<IMessage, ulong> before, SocketMessage message,
                                       ISocketMessageChannel      channel) {
            await MessageEditHandler.EditMessage(message, Client);
        }
    }
}