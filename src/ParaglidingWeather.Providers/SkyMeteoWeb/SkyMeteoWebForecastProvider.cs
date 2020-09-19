﻿// <copyright file="SkyMeteoWebForecastProvider.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace ParaglidingWeather.Providers.SkyMeteoWeb
{
    using System.Threading.Tasks;
    using ParaglidingWeather.Core;

    /// <summary>
    /// Provides a weather forecast by fetching a data from a web page of SkyMeteo service.
    /// </summary>
    public class SkyMeteoWebForecastProvider : IForecastProvider
    {
        /// <inheritdoc/>
        public IForecast GetForecast(Coordinate coordinate)
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc/>
        public Task<IForecast> GetForecastAsync(Coordinate coordinate)
        {
            throw new System.NotImplementedException();
        }
    }
}
