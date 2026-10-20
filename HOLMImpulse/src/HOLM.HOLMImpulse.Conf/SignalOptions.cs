namespace HOLM.HOLMImpulse.Conf;

public class SignalOptions
{
	public int SignalType;

	public int SignalLength;

	public double LogSweepStartFreq;

	public double ChirpStartFreq;

	public double ChirpPotens;

	public double SqNoiseFreq;

	public double SqNoiseAmplitude;

	public float FadeInms;

	public float FadeOutms;

	public bool FadeIn;

	public bool FadeOut;

	public SignalOptions()
	{
		SignalType = 0;
		LogSweepStartFreq = 10.0;
		FadeInms = 10f;
		FadeOutms = 1f;
		FadeIn = true;
		FadeOut = true;
		ChirpStartFreq = 10.0;
		SignalLength = 18;
		SqNoiseFreq = 0.9;
		SqNoiseAmplitude = 0.5;
		ChirpPotens = 2.0;
	}
}
