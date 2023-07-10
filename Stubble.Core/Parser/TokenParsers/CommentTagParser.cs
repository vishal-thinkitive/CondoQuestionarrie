﻿// <copyright file="CommentTagParser.cs" company="Stubble Authors">
// Copyright (c) Stubble Authors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

using Stubble.Core.Imported;
using Stubble.Core.Tokens;

namespace Stubble.Core.Parser.TokenParsers
{
    /// <summary>
    /// A parser for <see cref="CommentToken"/>
    /// </summary>
    public class CommentTagParser : Interfaces.InlineParser
    {
        private const char TagId = '!';

        /// <summary>
        /// Tries to match a comment tag from the provided slice
        /// </summary>
        /// <param name="processor">The processor</param>
        /// <param name="slice">The slice</param>
        /// <returns>If a comment tag was matched</returns>
        public override bool Match(Processor processor, ref StringSlice slice)
        {
            var tagStart = slice.Start - processor.CurrentTags.StartTag.Length;
            var index = slice.Start;

            while (slice[index].IsWhitespace())
            {
                index++;
            }

            var match = slice[index];
            if (match == TagId)
            {
                slice.Start = index;
                var startIndex = index + 1;

                var commentTag = new CommentToken
                {
                    TagStartPosition = tagStart,
                    ContentStartPosition = startIndex,
                    IsClosed = false
                };
                processor.CurrentToken = commentTag;

                while (!slice.IsEmpty && !slice.Match(processor.CurrentTags.EndTag))
                {
                    slice.NextChar();
                }

                if (slice.IsEmpty)
                {
                    return false;
                }

                commentTag.TagEndPosition = slice.Start + processor.CurrentTags.EndTag.Length;
                commentTag.ContentEndPosition = slice.Start;
                commentTag.IsClosed = true;
                slice.Start += processor.CurrentTags.EndTag.Length;
                return true;
            }

            return false;
        }
    }
}
