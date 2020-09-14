﻿// <copyright file="IForecastProvider.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace ParaglidingWeatherBot.Providers
{
    using ParaglidingWeatherBot.Core;

    /// <summary>
    /// Represents a data reader that returns a weather forecast.
    /// </summary>
    public interface IForecastProvider
    {
        /// <summary>
        /// Returns the weather forecast for the week or fewer number available days.
        /// </summary>
        /// <returns>Returns the weather forecast.</returns>
        IForecast GetForecast();
    }
}