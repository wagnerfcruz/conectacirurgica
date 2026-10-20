namespace HOLM.HOLMImpulse.Conf;

public class FilterOptions
{
	public bool HighpassEnabled;

	public bool LowpassEnabled;

	public double HighpassFreq;

	public double LowpassFreq;

	public int NofTaps;

	public FilterOptions()
	{
		HighpassEnabled = false;
		LowpassEnabled = false;
		HighpassFreq = 500.0;
		LowpassFreq = 5000.0;
		NofTaps = 501;
	}
}
