﻿using System;

namespace FT.Common.Mvc
{
    public class ServiceId : IServiceId
    {
        private static readonly string _id = $"{Guid.NewGuid():N}";

        public string Id => _id;
    }
}