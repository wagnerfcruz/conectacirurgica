using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using HOLM.Measure;

namespace HOLM.MeasureGraphics;

internal class BasicMeasurementPresenter : IDisposable
{
	public bool fPlot;

	public bool fTargetPlot;

	public bool fBehind;

	public bool fDataAssigned;

	public unsafe Measurement* measPtr;

	public Color AmpColor;

	public Color TargetAmpColor;

	public Color PhaseColor;

	public Color ImpulseColor;

	public Color TargetImpulseColor;

	public Color ImpulseWindowColor;

	public int FreqLineWidth;

	public int TargetLineWidth;

	public int PhaseLineWidth;

	public int ImpulseLineWidth;

	private EventHandler _003Cbacking_store_003EUpdatePlotEvent;

	protected ColorCtrl colorCtrl;

	[SpecialName]
	public event EventHandler UpdatePlotEvent
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			_003Cbacking_store_003EUpdatePlotEvent = (EventHandler)Delegate.Combine(_003Cbacking_store_003EUpdatePlotEvent, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			_003Cbacking_store_003EUpdatePlotEvent = (EventHandler)Delegate.Remove(_003Cbacking_store_003EUpdatePlotEvent, value);
		}
	}

	public unsafe BasicMeasurementPresenter(Measurement* measPtrIn)
	{
		BasicMeasurementPresenter basicMeasurementPresenter = new BasicMeasurementPresenter();
		System.Runtime.CompilerServices.Unsafe.SkipInit(out BasicMeasurementPresenter basicMeasurementPresenter2);
		try
		{
			basicMeasurementPresenter2 = basicMeasurementPresenter;
		}
		catch
		{
			//try-fault
			((IDisposable)basicMeasurementPresenter2).Dispose();
			throw;
		}
		((IDisposable)basicMeasurementPresenter2).Dispose();
		measPtr = measPtrIn;
		fDataAssigned = true;
	}

	public BasicMeasurementPresenter()
	{
		fDataAssigned = false;
		fPlot = false;
		fTargetPlot = false;
		fBehind = false;
		FreqLineWidth = 2;
		PhaseLineWidth = 2;
		ImpulseLineWidth = 2;
		TargetLineWidth = 1;
		Color darkBlue = Color.DarkBlue;
		AmpColor = darkBlue;
		Color lightBlue = Color.LightBlue;
		PhaseColor = lightBlue;
		Color darkBlue2 = Color.DarkBlue;
		ImpulseColor = darkBlue2;
		Color lightBlue2 = Color.LightBlue;
		ImpulseWindowColor = lightBlue2;
		Color red = Color.Red;
		TargetAmpColor = red;
		Color red2 = Color.Red;
		TargetImpulseColor = red2;
	}

	private void _007EBasicMeasurementPresenter()
	{
	}

	public unsafe void AssignDataPtr(Measurement* measPtrIn)
	{
		measPtr = measPtrIn;
		fDataAssigned = true;
	}

	public void SetColorCtrl(ColorCtrl colorCtrlIn)
	{
		colorCtrl = colorCtrlIn;
		colorCtrl.ColorChanged += Action_NewColors;
	}

	public void SetBaseColor(Color color)
	{
		AmpColor = color;
		ImpulseColor = color;
		TargetAmpColor = color;
		TargetImpulseColor = color;
		PhaseColor = color;
		ImpulseWindowColor = color;
	}

	[SpecialName]
	protected void raise_UpdatePlotEvent(object value0, EventArgs value1)
	{
		_003Cbacking_store_003EUpdatePlotEvent?.Invoke(value0, value1);
	}

	public void InvokeUpdatePlotEvent()
	{
		if (fPlot)
		{
			_003Cbacking_store_003EUpdatePlotEvent?.Invoke(this, null);
		}
	}

	protected void Action_NewColors(object sender, EventArgs e)
	{
		Color color = colorCtrl.GetColor();
		SetBaseColor(color);
		if (fPlot)
		{
			_003Cbacking_store_003EUpdatePlotEvent?.Invoke(this, null);
		}
	}

	protected virtual void Dispose([MarshalAs(UnmanagedType.U1)] bool P_0)
	{
		if (!P_0)
		{
			base.Finalize();
		}
	}

	public virtual sealed void Dispose()
	{
		Dispose(true);
		GC.SuppressFinalize(this);
	}
}
