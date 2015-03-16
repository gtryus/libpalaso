﻿using System.Collections.Generic;
using SIL.WritingSystems;

namespace SIL.Windows.Forms.WritingSystems
{
	public class LookupIsoCodeModel
	{
		private EthnologueLookup _ethnologueLookup;

		/// <summary>Force the dialog to return 3 letter iso codes even if a 2 letter code is available</summary>
		public bool Force3LetterCodes { get; set; }

		public LookupIsoCodeModel()
		{
			Force3LetterCodes = false;
		}

		/// <summary>
		/// Maybe this doesn't belong here... using it in Bloom which is more concerned with language than writing system
		/// </summary>
		/// <param name="iso639Code"></param>
		/// <returns></returns>
		public LanguageSubtag GetExactLanguageMatch(string iso639Code)
		{
			LanguageSubtag language;
			if (StandardSubtags.TryGetLanguageFromIso3Code(iso639Code, out language) && language.Code != language.Iso3Code)
				return language;
			return null;
		}

		public IEnumerable<LanguageInfo> GetMatchingLanguages(string typedText)
		{
			if (_ethnologueLookup == null)
				_ethnologueLookup = new EthnologueLookup { Force3LetterCodes = Force3LetterCodes };

			return _ethnologueLookup.SuggestLanguages(typedText);
		}

		public LanguageInfo LanguageInfo;

		public string IsoCode
		{
			get
			{
				if (LanguageInfo == null)
					return string.Empty;
				return LanguageInfo.Code;
			}
		}
	}
}