// Copyright (c) 2015 SIL International
// This software is licensed under the MIT License (http://opensource.org/licenses/MIT)

using SIL.WritingSystems;

namespace Palaso.UI.WindowsForms.Widgets
{
	public interface IControlThatKnowsWritingSystem
	{
		string Name { get; }
		WritingSystemDefinition WritingSystem { get; }
		string Text { get; set; }
	}
}
