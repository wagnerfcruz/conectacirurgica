namespace HOLM.HOLMImpulse.Conf;

public class DevOptions
{
	public int SamplerateNo;

	public int InputNumber;

	public int OutputNumber;

	public int ApiNumber;

	public int OutputChMask;

	public int InputChannel;

	public bool InputInvert;

	public double DelayMS;

	public float OutputPCMAmplitude;

	public bool KeepStreamActive;

	public DevOptions()
	{
		SamplerateNo = 0;
		InputNumber = 0;
		InputInvert = false;
		OutputNumber = 0;
		OutputChMask = 0;
		DelayMS = 1500.0;
		InputChannel = 0;
		KeepStreamActive = true;
		OutputPCMAmplitude = 1f;
		ApiNumber = 0;
	}
}
