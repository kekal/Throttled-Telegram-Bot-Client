﻿using System;

namespace ThrottledTelegramBotClient.TestingEntities;

public class ApplicationLifetime : IApplicationLifetime
{
    /// <inheritdoc />>
    public void Exit(int exitCode)
    {
        Environment.Exit(exitCode);
    }
}