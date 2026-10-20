using System.Xml.Serialization;
using HOLM.MeasureGraphics;

namespace HOLM.HOLMImpulse.Conf;

[XmlRoot("HOLMImpulseOptions", IsNullable = false)]
public class OptionsField
{
	[XmlElement(IsNullable = false)]
	public string WriterProductVersion;

	[XmlElement(IsNullable = false)]
	public string Comment;

	[XmlElement(IsNullable = false)]
	public PlotOptions Plot;

	[XmlElement(IsNullable = false)]
	public MiscOptions Misc;

	[XmlElement(IsNullable = false)]
	public DevOptions Dev;

	[XmlElement(IsNullable = false)]
	public SignalOptions Signal;

	[XmlElement(IsNullable = false)]
	public AnalysisOptions Analysis;

	[XmlElement(IsNullable = false)]
	public ImExportOptions ImExport;

	[XmlElement(IsNullable = false)]
	public FilterOptions Filter;

	[XmlElement(IsNullable = false)]
	public MakeMicCalOptions MakeMicCal;

	public void Init()
	{
		Plot = new PlotOptions();
		Misc = new MiscOptions();
		Dev = new DevOptions();
		ImExport = new ImExportOptions();
		Filter = new FilterOptions();
		MakeMicCal = new MakeMicCalOptions();
		Signal = new SignalOptions();
		Analysis = new AnalysisOptions();
	}

	public void PostLoad()
	{
		Plot.PostLoad();
		if (Filter == null)
		{
			Filter = new FilterOptions();
		}
		if (MakeMicCal == null)
		{
			MakeMicCal = new MakeMicCalOptions();
		}
		if (Signal == null)
		{
			Signal = new SignalOptions();
		}
		if (Analysis == null)
		{
			Analysis = new AnalysisOptions();
		}
		if (ImExport == null)
		{
			ImExport = new ImExportOptions();
		}
		AnalysisOptions analysis = Analysis;
		if (analysis.MAnalysis < 10)
		{
			analysis.MAnalysis = 16;
		}
		int num = (int)global::_003CModule_003E.HOLM_002EHOLMImpulse_002EConf_002EProductVersionNumber(WriterProductVersion);
		if (num < 1010502)
		{
			Plot.ImpulseShowHD = true;
			Plot.FreqShowGating = true;
		}
		if (num < 1010909)
		{
			Dev.KeepStreamActive = true;
			Dev.DelayMS = 1500.0;
		}
		if (num < 1020004)
		{
			Analysis.ExtendToNyquist = false;
			Analysis.ExtendToNyquistFreq = 20000.0;
		}
		Misc.PostLoad();
	}
}
