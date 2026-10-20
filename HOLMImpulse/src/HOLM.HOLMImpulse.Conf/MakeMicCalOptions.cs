namespace HOLM.HOLMImpulse.Conf;

public class MakeMicCalOptions
{
	public int refCalSlot;

	public int refLowSlot;

	public int refHighSlot;

	public double winHighcm;

	public double winMidcm;

	public double winLowcm;

	public double stitchHighCenter;

	public double stitchHighWidth;

	public double stitchLowCenter;

	public double stitchLowWidth;

	public MakeMicCalOptions()
	{
		refCalSlot = 0;
		refLowSlot = 1;
		refHighSlot = 2;
		winHighcm = 60.0;
		winMidcm = 400.0;
		winLowcm = 2000.0;
		stitchHighCenter = 600.0;
		stitchHighWidth = 60.0;
		stitchLowCenter = 100.0;
		stitchLowWidth = 10.0;
	}
}
