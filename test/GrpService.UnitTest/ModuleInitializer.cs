using System.Runtime.CompilerServices;
using VerifyTests.DiffPlex;

namespace GrpService.UnitTest;

public static class ModuleInitializer
{
	[ModuleInitializer]
	public static void Initialize()
	{
		// Don't dump full content in output for Failed Test
		VerifyDiffPlex.Initialize(OutputType.Minimal);

		// Leave Diff Tool On for now
		//DiffRunner.Disabled = true;

		VerifierSettings.DontScrubGuids();
		VerifierSettings.DontScrubDateTimes();

		VerifierSettings.ScrubMember("CreatedOn");
		VerifierSettings.ScrubMember("UpdatedOn");
	}
}
