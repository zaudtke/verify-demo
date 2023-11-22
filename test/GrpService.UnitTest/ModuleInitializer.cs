using System.Runtime.CompilerServices;
using DiffEngine;
using VerifyTests.DiffPlex;

namespace GrpService.UnitTest;

public static class ModuleInitializer
{
	[ModuleInitializer]
	public static void Initialize()
	{
		// Don't dump full content in output for Failed Test
		VerifyDiffPlex.Initialize(OutputType.Minimal);

		// Don't launch Diff Tool
		// I"m using either Rider Plugin for Test Window or
		// dotnet-verify review (global dotnet tool)
		DiffRunner.Disabled = true;

		VerifierSettings.DontScrubGuids();
		VerifierSettings.DontScrubDateTimes();

		VerifierSettings.ScrubMember("CreatedOn");
		VerifierSettings.ScrubMember("UpdatedOn");
	}
}
