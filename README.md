# Throttled TelegramBot Client

ThrottledTelegramBotClient is a library that wraps the Telegram Bot API client. It provides automatic throttling to prevent overloading the Telegram API with requests. It ensures a delay between API calls and maintains thread safety with semaphore control.

Bot based on the popular [Telegram.Bot](https://github.com/TelegramBots/Telegram.Bot) library.

## 📋 Prerequisites

- .NETStandard 2.1 SDK
- An active Telegram bot token ([Create bot](https://t.me/BotFather))

## 📘 Usage
Initialize your standard TelegramBotClient:
```csharp
var client = new ThrottledTelegramBotClient(new TelegramBotWrapper(botToken), TimeSpan.FromSeconds(ThrottlingTimeout))
```
## ↓
```csharp
await client.SendTextMessageAsync(message.Chat.Id, "dummy");
```
## 🤝 Contributing

Contributions are welcome! Please submit a pull request or raise an issue to discuss any changes or feature requests.

## ➕ Additional
- [Telegram bots API book](https://telegrambots.github.io/book/)
- [Introduction to bots](https://core.telegram.org/bots)
- [Bot API](https://core.telegram.org/bots/api)
