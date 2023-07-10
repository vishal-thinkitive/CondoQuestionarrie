﻿// <copyright file="DictionaryLoader.cs" company="Stubble Authors">
// Copyright (c) Stubble Authors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Stubble.Core.Interfaces;

namespace Stubble.Core.Loaders
{
    /// <summary>
    /// An <see cref="IStubbleLoader"/> for mapping strings to templates
    /// </summary>
    public class DictionaryLoader : IStubbleLoader
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DictionaryLoader"/> class.
        /// </summary>
        /// <param name="templates">The templates to cache</param>
        public DictionaryLoader(IDictionary<string, string> templates)
        {
            TemplateCache = new Dictionary<string, string>(templates);
        }

        /// <summary>
        /// Gets the template cache for the loader
        /// </summary>
        internal IDictionary<string, string> TemplateCache { get; }

        /// <inheritdoc/>
        public IStubbleLoader Clone()
        {
            return new DictionaryLoader(new Dictionary<string, string>(TemplateCache));
        }

        /// <summary>
        /// Loads the template from the dictionary cache
        /// </summary>
        /// <param name="name">The name of the template</param>
        /// <returns>The template or null if not found</returns>
        public string Load(string name)
        {
            return TemplateCache.TryGetValue(name, out string outValue) ? outValue : null;
        }

        /// <summary>
        /// Loads the template from a local dictionary cache
        /// </summary>
        /// <param name="name">The name of the template to load</param>
        /// <returns>The template or null if not found</returns>
        public ValueTask<string> LoadAsync(string name)
        {
            return new ValueTask<string>(Load(name));
        }
    }
}
