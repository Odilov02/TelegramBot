namespace TelegramBot.Bottons;

public class BottonService
{
    public static void PassMenu(ITelegramBotClient botClient, Update update)
    {
        ReplyKeyboardMarkup replyKeyboardMarkup = new(
                                                     new[]
                                                     {
                                                      new KeyboardButton[] { "🛍 Buyurtma berish" },
                                                      new KeyboardButton[] { "✍️ Fikr bildirish" },
                                                      new KeyboardButton[] { "ℹ️ Ma'lumot" },
                                                     })
        {
            ResizeKeyboard = true
        };
        ReplyKeyboardMarkup markup = new(
                                        new[]
           {
                    new KeyboardButton[]  {  KeyboardButton.WithRequestContact("Contact yuborish") },
                    new KeyboardButton[] { "Orqaga" }
           })
        {
            ResizeKeyboard = true
        };
        botClient.SendTextMessageAsync(chatId: update.Message!.Chat.Id,
                                           text: "Qanday Amal Bajarmoqchisiz!",
                                           replyMarkup: replyKeyboardMarkup
                                           );
    }
}
