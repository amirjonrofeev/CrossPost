using Telegram.Bot;

namespace Telegram.Test.API.Services
{
    public interface IBotService
    {
        public TelegramBotClient Client { get; }
    }
}