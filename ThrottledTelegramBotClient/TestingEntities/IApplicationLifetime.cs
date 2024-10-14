using System;

namespace ThrottledTelegramBotClient.TestingEntities;

public interface IApplicationLifetime
{
    /// <inheritdoc cref="Environment.Exit"/>>
    void Exit(int exitCode);
}