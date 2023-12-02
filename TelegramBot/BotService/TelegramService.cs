using Telegram.Bot;

namespace TelegramBot.BotService;

public static class TelegramService
{
    private static TelegramBotClient? BotClient { get; set; }
    public static void AddTelegramBot(this IServiceCollection services,IConfiguration configuration)
    {
        BotClient = new TelegramBotClient(configuration["TelegramToken"]!);
        BotClient.ReceiveAsync<UpdateHundler>();
    }
}
