using System.Threading.Tasks;
using Discord.Commands;
using Discord.WebSocket;
using FallProject.Models;
using Microsoft.EntityFrameworkCore;

namespace FallProject.Handlers {
    public static class MessageCreateHandler {
        public static async Task CreateMessage(SocketMessage message, DiscordSocketClient client) {
            await StoreMessage(message, client);
        }

        // Log all messages in a database for the future :).
        private static async Task StoreMessage(SocketMessage message, DiscordSocketClient client) {
            SocketCommandContext context = new SocketCommandContext(client, message as SocketUserMessage);
            await Message.Create(context);
            await GuildMember.CreateOrUpdate(context.Guild.CurrentUser);
        }
    }
}