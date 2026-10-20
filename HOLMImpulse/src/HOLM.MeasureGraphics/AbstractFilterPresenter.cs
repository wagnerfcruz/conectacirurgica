using System.Drawing;
using System.Runtime.InteropServices;
using std;

namespace HOLM.MeasureGraphics;

internal abstract class AbstractFilterPresenter
{
	public bool fPlot;

	public bool fBehind;

	public bool fFilterAssigned;

	public int FreqLineWidth;

	public ColorCtrl colorCtrl;

	protected bool fHasNextChannel;

	protected Color color;

	public unsafe virtual complex_003Cdouble_003E* GetFreqResponse(complex_003Cdouble_003E* P_0, double freqHz)
	{
		double num = 0.0;
		double num2 = 1.0;
		global::_003CModule_003E.std_002Ecomplex_003Cdouble_003E_002E_007Bctor_007D(P_0, &num2, &num);
		return P_0;
	}

	public unsafe virtual complex_003Cdouble_003E* GetFreqResponseNext(complex_003Cdouble_003E* P_0, double freqHz)
	{
		double num = 0.0;
		double num2 = 1.0;
		global::_003CModule_003E.std_002Ecomplex_003Cdouble_003E_002E_007Bctor_007D(P_0, &num2, &num);
		return P_0;
	}

	public Color GetFreqColor()
	{
		return colorCtrl?.GetColor() ?? color;
	}

	public void AssignColorCtrl(ColorCtrl colorCtrlIn)
	{
		colorCtrl = colorCtrlIn;
	}

	[return: MarshalAs(UnmanagedType.U1)]
	public bool HasNextChannel()
	{
		return fHasNextChannel;
	}

	protected AbstractFilterPresenter()
	{
		fFilterAssigned = false;
		fPlot = false;
		fBehind = false;
		fHasNextChannel = false;
		FreqLineWidth = 3;
		Color darkBlue = Color.DarkBlue;
		color = darkBlue;
		colorCtrl = null;
	}
}
