using Microsoft.Extensions.Options;
using Telegram.Bot;
using Telegram.Test.API.Configurations;

namespace Telegram.Test.API.Services
{
    public class BotService : IBotService
    {
        private readonly BotConfiguration _config;

        public BotService(IOptions<BotConfiguration> config)
        {
            _config = config.Value;
            Client = new TelegramBotClient("1722387018:AAGoMaLwaVV_e_StBjHGoObpDqBbZStz3fQ");
        }

        public TelegramBotClient Client { get; }
    }
}
