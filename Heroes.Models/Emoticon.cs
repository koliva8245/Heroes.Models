﻿using System;
using System.Collections.Generic;

namespace Heroes.Models
{
    /// <summary>
    /// Contains the information for emoticon data.
    /// </summary>
    public class Emoticon : ExtractableBase<Emoticon>, IExtractable
    {
        private readonly HashSet<string> _universalAliasList = new HashSet<string>();
        private readonly HashSet<string> _localizedAliasList = new HashSet<string>();
        private readonly HashSet<string> _searchTextList = new HashSet<string>();

        /// <summary>
        /// Gets or sets the description text.
        /// </summary>
        public TooltipDescription? Description { get; set; }

        /// <summary>
        /// Gets a collection of universal aliases for the emoticon.
        /// </summary>
        public IEnumerable<string> UniversalAliases => _universalAliasList;

        /// <summary>
        /// Gets a collection of localized aliases for the emoticon.
        /// </summary>
        public IEnumerable<string> LocalizedAliases => _localizedAliasList;

        /// <summary>
        /// Gets a collection of search texts for the emoticon.
        /// </summary>
        public IEnumerable<string> SearchTexts => _searchTextList;

        /// <summary>
        /// Gets or sets a value indicating whether the aliases are case sensitive.
        /// </summary>
        public bool IsAliasCaseSensitive { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the emoticon is hidden.
        /// </summary>
        public bool IsHidden { get; set; }

        /// <summary>
        /// Gets or sets the hero id associated with the emoticon.
        /// </summary>
        public string HeroId { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the hero skin id assoicated with the emoticon.
        /// </summary>
        public string? HeroSkinId { get; set; }

        /// <summary>
        /// Gets or sets the texture sheet associated with the emoticon.
        /// </summary>
        public TextureSheet TextureSheet { get; set; } = new TextureSheet();

        /// <summary>
        /// Gets or sets the image properties of the emoticon.
        /// </summary>
        public EmoticonImage Image { get; set; } = new EmoticonImage();

        /// <summary>
        /// Adds a universal aliase value. Replaces if value already exists in collection.
        /// </summary>
        /// <param name="value">A universal alias value.</param>
        public void AddUniversalAlias(string value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            _universalAliasList.Add(value);
        }

        /// <summary>
        /// Determines whether the value exists.
        /// </summary>
        /// <param name="value">A universal alias value.</param>
        /// <returns></returns>
        public bool ContainsUniversalAlias(string value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            return _universalAliasList.Contains(value);
        }

        /// <summary>
        /// Adds a localized aliase value. Replaces if value already exists in collection.
        /// </summary>
        /// <param name="value">A localized alias value.</param>
        public void AddLocalizedAlias(string value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            _localizedAliasList.Add(value);
        }

        /// <summary>
        /// Determines whether the value exists.
        /// </summary>
        /// <param name="value">A localized alias value.</param>
        /// <returns></returns>
        public bool ContainsLocalizedAlias(string value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            return _localizedAliasList.Contains(value);
        }

        /// <summary>
        /// Adds a search text value. Replaces if value already exists in collection.
        /// </summary>
        /// <param name="value">A search text value.</param>
        public void AddSearchText(string value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            _searchTextList.Add(value);
        }

        /// <summary>
        /// Determines whether the value exists.
        /// </summary>
        /// <param name="value">A search text value.</param>
        /// <returns></returns>
        public bool ContainsSearchText(string value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            return _searchTextList.Contains(value);
        }
    }
}
