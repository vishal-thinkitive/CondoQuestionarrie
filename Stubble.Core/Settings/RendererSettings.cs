﻿// <copyright file="RendererSettings.cs" company="Stubble Authors">
// Copyright (c) Stubble Authors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using Stubble.Core.Classes;
using Stubble.Core.Contexts;
using Stubble.Core.Interfaces;
using Stubble.Core.Parser;
using Stubble.Core.Parser.Interfaces;
using Stubble.Core.Renderers;
using static Stubble.Core.Settings.RendererSettingsDefaults;

namespace Stubble.Core.Settings
{
    /// <summary>
    /// Contains all of the immutable settings for the renderer
    /// </summary>
    public class RendererSettings : BaseSettings
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RendererSettings"/> class.
        /// </summary>
        /// <param name="valueGetters">The value getters</param>
        /// <param name="truthyChecks">The truthy checks</param>
        /// <param name="templateLoader">The template loader</param>
        /// <param name="partialLoader">The partial loader</param>
        /// <param name="maxRecursionDepth">The max recursion depth</param>
        /// <param name="renderSettings">The render settings</param>
        /// <param name="enumerationConverters">The enumeration converters</param>
        /// <param name="ignoreCaseOnLookup">Should case be ignored on lookup</param>
        /// <param name="parser">The mustache parser to use</param>
        /// <param name="rendererPipeline">The renderer pipeline to use</param>
        /// <param name="defaultTags">The default tags to use during parsing</param>
        /// <param name="parserPipeline">The parser pipeline to use during parsing</param>
        /// <param name="sectionBlacklistTypes">The blacklisted section types</param>
        /// <param name="encodingFunction">A function for encoding strings</param>
        public RendererSettings(
            Dictionary<Type, ValueGetterDelegate> valueGetters,
            Dictionary<Type, List<Func<object, bool>>> truthyChecks,
            IStubbleLoader templateLoader,
            IStubbleLoader partialLoader,
            uint maxRecursionDepth,
            RenderSettings renderSettings,
            Dictionary<Type, Func<object, IEnumerable>> enumerationConverters,
            bool ignoreCaseOnLookup,
            IMustacheParser parser,
            TokenRendererPipeline<Context> rendererPipeline,
            Tags defaultTags,
            ParserPipeline parserPipeline,
            HashSet<Type> sectionBlacklistTypes,
            Func<string, string> encodingFunction)
            : base(
                  templateLoader,
                  partialLoader,
                  maxRecursionDepth,
                  ignoreCaseOnLookup,
                  parser,
                  defaultTags,
                  parserPipeline,
                  sectionBlacklistTypes)
        {
            OrderedValueGetters = valueGetters.Keys.OrderBy(t => t, TypeBySubclassAndAssignableImpl.Default).ToImmutableArray();
            ValueGetters = valueGetters.ToImmutableDictionary();
            TruthyChecks = truthyChecks.ToImmutableDictionary(k => k.Key, v => v.Value.ToImmutableArray());
            RenderSettings = renderSettings;
            EnumerationConverters = enumerationConverters.ToImmutableDictionary();
            RendererPipeline = rendererPipeline;
            EncodingFuction = encodingFunction;
        }

        /// <summary>
        /// Gets an array of value getters ordered by lookup order
        /// </summary>
        public ImmutableArray<Type> OrderedValueGetters { get; }

        /// <summary>
        /// Gets a map of Types to Value getter functions
        /// </summary>
        public ImmutableDictionary<Type, ValueGetterDelegate> ValueGetters { get; }

        /// <summary>
        /// Gets a map of types to truthy checks
        /// </summary>
        public ImmutableDictionary<Type, ImmutableArray<Func<object, bool>>> TruthyChecks { get; }

        /// <summary>
        /// Gets the RenderSettings
        /// </summary>
        public RenderSettings RenderSettings { get; }

        /// <summary>
        /// Gets a map of Types to Enumeration convert functions
        /// </summary>
        public ImmutableDictionary<Type, Func<object, IEnumerable>> EnumerationConverters { get; }

        /// <summary>
        /// Gets the renderer pipeline to be used when rendering
        /// </summary>
        public TokenRendererPipeline<Context> RendererPipeline { get; }

        /// <summary>
        /// Gets the encoding function used by the renderer
        /// </summary>
        public Func<string, string> EncodingFuction { get; }
    }
}
