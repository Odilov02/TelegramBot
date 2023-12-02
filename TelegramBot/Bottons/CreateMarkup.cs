﻿namespace TelegramBot.Bottons
{
    public class CreateMarkup
    {
        public static void PassMenuMarkup(ITelegramBotClient botClient, Update update)
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
            botClient.SendTextMessageAsync(chatId: update.Message!.Chat.Id,
                                               text: "Qanday Amal Bajarmoqchisiz!",
                                               replyMarkup: replyKeyboardMarkup
                                               );
        }
    }
}
