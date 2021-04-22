using System.Threading.Tasks;
using Telegram.Bot;

namespace CrossPost.Telegram.API.Services
{
    public interface IBotService
    {
        TelegramBotClient Client { get; set; }

        Task SendPostAsync();
    }
}