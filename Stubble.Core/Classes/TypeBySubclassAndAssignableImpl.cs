﻿// <copyright file="TypeBySubclassAndAssignableImpl.cs" company="Stubble Authors">
// Copyright (c) Stubble Authors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

using System;
using System.Collections.Generic;
using System.Reflection;

namespace Stubble.Core.Classes
{
    /// <summary>
    /// TypeBySubclassAndAssignable Comparer for Type
    /// </summary>
    internal class TypeBySubclassAndAssignableImpl : Comparer<Type>
    {
        private static readonly Type ObjectType = typeof(object);

        /// <summary>
        /// Gets an instance of TypeBySubclassAndAssignable Comparer for Type.
        /// </summary>
        /// <returns>an IComparer</returns>
        public static IComparer<Type> Default { get; } = new TypeBySubclassAndAssignableImpl();

        /// <summary>
        /// Compares two types using standard comparisions,
        /// subclass and assignable from
        /// </summary>
        /// <param name="x">The first type to compare</param>
        /// <param name="y">The second type</param>
        /// <returns>If an element is the same, before or after another</returns>
        public override int Compare(Type x, Type y)
        {
            // Standard Comparision Checks
            if (x == null && y == null)
            {
                return 0;
            }

            if (x == null)
            {
                return 1; // x is after y
            }

            if (y == null)
            {
                return -1; // x is before y
            }

            if (x == y)
            {
                return 0;
            }

            if (x == ObjectType)
            {
                return 1;
            }

            if (y == ObjectType)
            {
                return -1;
            }

            var result = 0;
            if (x.IsSubclassOf(y))
            {
                result = -1;
            }
            else if (y.IsSubclassOf(x))
            {
                result = 1;
            }
            else if (x.IsAssignableFrom(y))
            {
                result = 1;
            }
            else if (y.IsAssignableFrom(x))
            {
                result = -1;
            }
            else if (!x.IsInterface && y.IsInterface)
            {
                result = -1;
            }
            else if (x.IsInterface && !y.IsInterface)
            {
                result = 1;
            }

            return result;
        }
    }
}
