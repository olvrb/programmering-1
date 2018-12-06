using System.Threading.Tasks;
using Discord.Commands;
using Discord.WebSocket;
using FallProject.Models;

namespace FallProject.Handlers {
    public static class MessageEditHandler {
        public static async Task EditMessage(SocketMessage       message,
                                             DiscordSocketClient client) {
            // We can do this inline since we won't use the context anymore.
            await Message.Update(new SocketCommandContext(client, message as SocketUserMessage));
        }
    }
}