namespace HOLM.HOLMImpulse.Conf;

public class AnalysisOptions
{
	public bool NormalizeTo0dB;

	public bool TimeWindowAutoApply;

	public int TimeZeroMethod;

	public bool TimeZeroInterpolate;

	public bool MicCalibration;

	public bool DacAdcCalibration;

	public bool HighpassResult;

	public bool ExtendToNyquist;

	public double ExtendToNyquistFreq;

	public int MAnalysis;

	public AnalysisOptions()
	{
		NormalizeTo0dB = false;
		TimeWindowAutoApply = true;
		TimeZeroMethod = 2;
		TimeZeroInterpolate = true;
		MicCalibration = false;
		DacAdcCalibration = false;
		HighpassResult = true;
		ExtendToNyquist = false;
		ExtendToNyquistFreq = 20000.0;
		MAnalysis = 16;
	}
}
