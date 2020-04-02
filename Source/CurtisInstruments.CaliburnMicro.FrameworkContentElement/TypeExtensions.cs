// -----------------------------------------------------------------------
// <copyright file="TypeExtensions.cs" company="Curtis Instruments">
// Copyright (c) Curtis Instruments. All rights reserved.
// </copyright>
// <author>willsont</author>
// -----------------------------------------------------------------------

namespace Caliburn.Micro.FrameworkContentElement
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal static class TypeExtensions
    {
        public static IEnumerable<T> GetAttributes<T>(this Type type, bool inherit)
            => type.GetCustomAttributes(typeof(T), inherit)
                   .OfType<T>();
    }
}