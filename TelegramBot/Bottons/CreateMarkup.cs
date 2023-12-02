using Application.Common.Interfaces.ServiceInterfaces;
using Domain.Entities;

namespace TelegramBot.Bottons;

public class CreateMarkup
{
    public static ICategoryService? _categoryService;
    public static IFoodService? _foodService;
    public CreateMarkup(ICategoryService categoryService,IFoodService foodService)
    {
        _categoryService = categoryService;
        _foodService = foodService;
    }
    public static ReplyKeyboardMarkup PassMenuMarkup()
    {
        ReplyKeyboardMarkup markup = new(
                                          new[]
                                          {
                                                  new KeyboardButton[] { "🛍 Buyurtma berish" },
                                                  new KeyboardButton[] { "✍️ Fikr bildirish","☎️ Biz bilan aloqa" },
                                                  new KeyboardButton[] { "ℹ️ Ma'lumot","⚙️ Sozlamalar" },
                                           })
        {
            ResizeKeyboard = true
        };
        return markup;
    }

    public static ReplyKeyboardMarkup GiveOrder()
    {
        ReplyKeyboardMarkup markup = new(
                                          new[]
                                          {
                                                  new KeyboardButton[] { "🚖 Yetkazib berish","🏃 Olib ketish" },
                                                  new KeyboardButton[] { "⬅️ Ortga" },
                                           })
        {
            ResizeKeyboard = true,

        };
        return markup;
    }

    public static ReplyKeyboardMarkup Commention()
    {
        ReplyKeyboardMarkup markup = new(
                                        new[]
                                        {
                                                  new KeyboardButton[] { "Hammasi yoqdi ♥️" },
                                                  new KeyboardButton[] { "Yaxshi ⭐️⭐️⭐️⭐️" },
                                                  new KeyboardButton[] { "Yoqmadi ⭐️⭐️⭐️" },
                                                  new KeyboardButton[] { "Yomon ⭐️⭐️" },
                                         })
        {
            ResizeKeyboard = true,

        };
        return markup;

    }
    public static ReplyKeyboardMarkup Settings()
    {
        ReplyKeyboardMarkup markup = new(
                                      new[]
                                      {
                                                  new KeyboardButton[] { "Ismni o'zgartirish","Raqamni o'zgartirish" },
                                                  new KeyboardButton[] { "🇺🇿 Tilni tanlang" },
                                                  new KeyboardButton[] { "⬅️ Ortga "}
                                       })
        {
            ResizeKeyboard = true,

        };
        return markup;

    }
    public static ReplyKeyboardMarkup Delivery()
    {
        ReplyKeyboardMarkup markup = new(
                                     new[]
                                     {
                                                  new KeyboardButton[] { "Eng yaqin filialni aniqlash" },
                                                  new KeyboardButton[] { "⬅️ Ortga "}
                                      })
        {
            ResizeKeyboard = true,

        };
        return markup;
    }
    public static ReplyKeyboardMarkup IdentifyBranch()
    {
        ReplyKeyboardMarkup markup = new(
                                  new[]
                                  {
                                                  new KeyboardButton[] { "Joylashuvni qayta jo'natish 📍" },
                                                  new KeyboardButton[] { "✅ Tasdiqlash " },
                                                  new KeyboardButton[] { "⬅️ Ortga "}
                                   })
        {
            ResizeKeyboard = true,

        };
        return markup;
    }
    public static ReplyKeyboardMarkup GetAllCategory()
    {
        List<Category> categories = _categoryService!.GetAll().Result;

        List<KeyboardButton[]> keyboard = new List<KeyboardButton[]>()
                              {
                                  new KeyboardButton[] { "📥 Savat","🚖 Buyurtuma berish" },
                               };

        for (int i = 0; i < categories.Count - 1; i += 2)
        {
            keyboard.Add(new KeyboardButton[] { categories[i].Name, categories[i + 1].Name });
        }
        if (categories.Count % 2 == 0)
            keyboard.Add(new KeyboardButton[] { "⬅️ Ortga " });
        else
            keyboard.Add(new KeyboardButton[] { categories[categories.Count - 1].Name, "⬅️ Ortga " });
        ReplyKeyboardMarkup markup = new(keyboard: keyboard)
        {
            ResizeKeyboard = true,

        };
        return markup;
    }
    public static ReplyKeyboardMarkup GetAllFood()
    {
        List<Food> foods = _foodService!.GetAll().Result;

        List<KeyboardButton[]> keyboard = new List<KeyboardButton[]>()
                              {
                                  new KeyboardButton[] { "📥 Savat","🚖 Buyurtuma berish" },
                               };

        for (int i = 0; i < foods.Count - 1; i += 2)
        {
            keyboard.Add(new KeyboardButton[] { foods[i].Name, foods[i + 1].Name });
        }
        if (foods.Count % 2 == 0)
            keyboard.Add(new KeyboardButton[] { "⬅️ Ortga " });
        else
            keyboard.Add(new KeyboardButton[] { foods[foods.Count - 1].Name, "⬅️ Ortga " });
        ReplyKeyboardMarkup markup = new(keyboard: keyboard)
        {
            ResizeKeyboard = true,

        };
        return markup;
    }
}
