namespace TelegramBot.Bottons
{
    public class CreateMarkup
    {
        public static ReplyKeyboardMarkup PassMenuMarkup(ITelegramBotClient botClient, Update update)
        {
            ReplyKeyboardMarkup markup = new(
                                                         new[]
                                                         {
                                                      new KeyboardButton[] { "🛍 Buyurtma berish" },
                                                      new KeyboardButton[] { "✍️ Fikr bildirish" },
                                                      new KeyboardButton[] { "ℹ️ Ma'lumot" },
                                                         })
            {
                ResizeKeyboard = true
            };
            return markup;
        }
    }
}
