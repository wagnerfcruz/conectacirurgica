namespace HOLM.MeasureGraphics;

public class ImExportOptions
{
	public bool ExportPhase;

	public bool PhaseUnwrap;

	public int PhaseMode;

	public bool IncludeHeader;

	public string CommentString;

	public int DecimalSep;

	public int Separator;

	public int ExportMode;

	public double LinearStepsHz;

	public double LogNofSteps;

	public double NonEqDbChange;

	public double NonEqPhaseChange;

	public ImExportOptions()
	{
		ExportPhase = true;
		PhaseUnwrap = true;
		PhaseMode = 0;
		IncludeHeader = true;
		CommentString = "#";
		DecimalSep = 46;
		Separator = 59;
		ExportMode = 2;
		LinearStepsHz = 5.0;
		LogNofSteps = 1000.0;
		NonEqDbChange = 0.1;
		NonEqPhaseChange = 1.0;
	}
}
