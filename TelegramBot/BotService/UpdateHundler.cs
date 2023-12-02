using Telegram.Bot.Polling;
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
           var markup = CreateMarkup.GetAllFood();
            botClient.SendTextMessageAsync(chatId: update.Message!.Chat.Id.ToString(),
                                    text: "Bosh Admin sahifasi:",
                                     replyMarkup: markup);
            return Task.CompletedTask;
        }
    }
}
