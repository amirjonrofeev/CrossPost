using System.Threading.Tasks;
using Telegram.Bot.Types;

namespace Telegram.Test.API.Services
{
    public interface IUpdateService
    {
        Task EchoAsync(Update update);
    }
}