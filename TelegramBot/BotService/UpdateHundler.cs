
using Telegram.Bot;
using Telegram.Bot.Polling;
using Telegram.Bot.Types;
using TelegramBot.Bottons;

namespace TelegramBot.BotService
{
    public class UpdateHundler : IUpdateHandler
    {
        public Task HandlePollingErrorAsync(ITelegramBotClient botClient, Exception exception, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task HandleUpdateAsync(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken)
        {
            BottonService.PassMenu(botClient,update);
            string salom = update!.Message!.Text!;
            botClient.SendTextMessageAsync(update.Message!.Chat.Id.ToString(), "dosim nima gap e");
            return Task.CompletedTask;
        }
    }
}
