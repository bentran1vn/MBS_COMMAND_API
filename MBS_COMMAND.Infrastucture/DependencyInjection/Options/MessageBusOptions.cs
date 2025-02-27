﻿using System.ComponentModel.DataAnnotations;

namespace MBS_COMMAND.Infrastucture.DependencyInjection.Options;

public class MessageBusOptions
{
    [Required, Range(1, 10)] public int RetryLimit { get; init; }
    [Required, Timestamp] public TimeSpan InitialInterval { get; init; }
    [Required, Timestamp] public TimeSpan IntervalIncrement { get; init; }
}