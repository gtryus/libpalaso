﻿using System;
using System.Collections.Generic;
using SIL.Archiving.IMDI.Schema;

namespace SIL.Archiving.Generic
{
	/// <summary>Contains the materials being archived, and their metadata</summary>
	public interface IArchivingSession : IArchivingGenericObject
	{
		/// <summary></summary>
		IIMDISessionFile AddFile(ArchivingFile file);

		/// <summary></summary>
		List<string> Files { get; }

		/// <summary>Set session date with DateTime object</summary>
		void SetDate(DateTime date);

		/// <summary>Set session date with a string. Can be a date range</summary>
		void SetDate(string date);

		/// <summary>Set session date with just the year</summary>
		void SetDate(int year);

		/// <summary></summary>
		void AddProject(Project project);

		/// <summary></summary>
		void AddActor(ArchivingActor actor);

		/// <summary></summary>
		void AddKeyValuePair(string key, string value);

		/// <summary></summary>
		void AddContentDescription(LanguageString item);

		/// <summary></summary>
		void AddLanguage(ArchivingLanguage language, LanguageString description);

		/// <summary></summary>
		string Genre { get; set; }

		/// <summary></summary>
		string SubGenre { get; set; }

		/// <summary></summary>
		string Interactivity { get; set; }

		/// <summary></summary>
		string Involvement { get; set; }

		/// <summary></summary>
		string PlanningType { get; set; }

		/// <summary></summary>
		string SocialContext { get; set; }

		/// <summary></summary>
		string Task { get; set; }
	}
}
