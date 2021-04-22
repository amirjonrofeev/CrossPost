using CrossPost.Services.API.Telegram.Enums;
using CrossPost.Telegram.API.Configurations;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System.Collections.Generic;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace CrossPost.Telegram.API.Services
{
    public class BotService
    {
        private readonly BotConfiguration _configs;
        private readonly ILogger<BotService> _logger;

        public TelegramBotClient Client { get; set; }
        public BotService(IOptions<BotConfiguration> config, ILogger<BotService> logger)
        {
            _configs = config.Value;
            _logger = logger;

            _logger.LogInformation("Client was set with the token.");

            Client = new TelegramBotClient(_configs.BotToken);
        }

        public async Task SendPostAsync(string chatName, string caption, PostType type , string photo = null)
        {
            ChatId chatId = new ChatId(chatName);

            if (type is PostType.TextOnly)
            {
                await Client.SendTextMessageAsync(chatId, caption);
            }
            //if (type is PostType.TextWithMediaGroup)
            //{
            //    Client.SendPhotoAsync(chatId, null, caption)
            //}
        }
    }
}
