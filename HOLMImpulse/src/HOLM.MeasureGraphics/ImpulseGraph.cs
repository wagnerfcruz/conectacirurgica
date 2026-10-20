using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using HOLM.Graphics;
using HOLM.Measure;
using std;

namespace HOLM.MeasureGraphics;

internal class ImpulseGraph : MouseZoomGraph
{
	private EventHandler _003Cbacking_store_003EEvent_Parameters;

	public Graph windowGraph;

	public bool fPlotTarget;

	public bool fShowHDPreTops;

	public bool fInterpolateSamples;

	private ImpulseMouseMode impulseMouseMode;

	private bool fImpulseWindowOntheMove;

	private unsafe Measurement* measOntheMove;

	private double SamplesToTime;

	private double SamplesToCM;

	private double SamplesToM;

	private ImpulseGraphMode mode;

	private int samplerate;

	private double minval;

	private double maxval;

	private bool fImpulseWindowDefined;

	private int nofMeas;

	private BasicPresenterContainer measurementContainer;

	private ControlImpulseGraph impGraph;

	[SpecialName]
	public event EventHandler Event_Parameters
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			_003Cbacking_store_003EEvent_Parameters = (EventHandler)Delegate.Combine(_003Cbacking_store_003EEvent_Parameters, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			_003Cbacking_store_003EEvent_Parameters = (EventHandler)Delegate.Remove(_003Cbacking_store_003EEvent_Parameters, value);
		}
	}

	public ImpulseGraph(ControlImpulseGraph __unnamed000, int samplerateIn)
		: base((Control)(object)__unnamed000, -8820.0, 8820.0, -1.0, 1.0)
	{
		try
		{
			impGraph = __unnamed000;
			samplerate = samplerateIn;
			Initialize();
			return;
		}
		catch
		{
			//try-fault
			base.Dispose(true);
			throw;
		}
	}

	private void _007EImpulseGraph()
	{
		((IDisposable)windowGraph)?.Dispose();
	}

	public void PrintLabels()
	{
		string text = null;
		switch (mode)
		{
		case (ImpulseGraphMode)2:
			fXAxisUseDPrefix = false;
			if ((GetXMax() - GetXMin()) * SamplesToCM < 1000.0)
			{
				text = "Distance [cm]";
				DrawXGrid(SamplesToCM);
			}
			else
			{
				text = "Distance [m]";
				DrawXGrid(SamplesToM);
			}
			break;
		case (ImpulseGraphMode)1:
			fXAxisUseDPrefix = false;
			DrawXGrid(SamplesToTime);
			text = "Time [millisec]";
			break;
		case (ImpulseGraphMode)0:
			fXAxisUseDPrefix = true;
			DrawXGrid(1.0);
			text = string.Concat("Sample No. ( " + ((double)samplerate / 1000.0).ToString("F1"), "k/sec. )");
			break;
		}
		PrintXLabel(text);
		if (yAxisMode == (AxisMode)3)
		{
			((Control)impGraph.dB0UpDown).Visible = true;
			PrintYLabel("Normalized Value [dB]");
		}
		else
		{
			((Control)impGraph.dB0UpDown).Visible = false;
			PrintYLabel("Value");
		}
		PrintTitel("Impulse Response", 100);
	}

	public void AssignMeasurements(BasicPresenterContainer container)
	{
		measurementContainer = container;
	}

	public unsafe override void UpdatePlot()
	{
		DrawAxis(fDrawArrows: false, fDrawGrid: false);
		Color foreColor = plotArea.ForeColor;
		SetDrawColor(foreColor);
		SetPlotWidth(2);
		int num = pixxMax;
		bitmapGraphics.DrawLine(gpen, num, pixyMax, num, pixyMin - 5);
		SetPlotWidth(1);
		DrawYGrid(fLeftSide: true);
		PrintLabels();
		if (windowGraph != null)
		{
			Color foreColor2 = plotArea.ForeColor;
			windowGraph.SetDrawColor(foreColor2);
			windowGraph.SetPlotWidth(2);
			windowGraph.PrintYRightLabel("Time window");
			windowGraph.DrawYRightGrid();
		}
		BasicPresenterContainer basicPresenterContainer = measurementContainer;
		if (basicPresenterContainer == null)
		{
			return;
		}
		int num2 = 1 - pixxMin + pixxMax;
		Point[] array = new Point[num2];
		Point[] array2 = new Point[num2 << 1];
		System.Runtime.CompilerServices.Unsafe.SkipInit(out vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E obj);
		basicPresenterContainer.GetPlotVector(&obj);
		try
		{
			uint num3 = 0u;
			int num4 = System.Runtime.CompilerServices.Unsafe.As<vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 16)) - System.Runtime.CompilerServices.Unsafe.As<vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 12)) >> 2;
			if (0u < (uint)num4)
			{
				do
				{
					if (num3 >= (uint)num4)
					{
						global::_003CModule_003E._invalid_parameter_noinfo();
					}
					int* ptr = (int*)(int)(num3 * 4 + (uint)System.Runtime.CompilerServices.Unsafe.As<vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 12)));
					BasicMeasurementPresenter basicMeasurementPresenter = measurementContainer.GetPresenters()[*ptr];
					Measurement* measPtr = basicMeasurementPresenter.measPtr;
					double num5 = (double)(*(int*)((byte*)measPtr + 64)) / (double)samplerate;
					if (global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementCore_002EGetImpulseWindowEnabled((MeasurementCore*)measPtr))
					{
						windowGraph.SetDrawColor(basicMeasurementPresenter.ImpulseColor);
						windowGraph.SetPlotWidth(basicMeasurementPresenter.ImpulseLineWidth);
						if (global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementCore_002EGetImpulseWindowLockStart((MeasurementCore*)measPtr))
						{
							int num6 = pixxMax;
							int num7 = ((XToPixX(0.0) >= num6) ? num6 : XToPixX(0.0));
							if (num7 > pixxMin)
							{
								windowGraph.gpen.DashStyle = (DashStyle)2;
								int num8 = pixxMin;
								Point[] array3 = new Point[num7 - num8];
								int num9 = num8;
								if (num9 < num7)
								{
									do
									{
										Point point = new Point(num9, windowGraph.YToPixY(global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementCore_002EWindowAmplitude((MeasurementCore*)measPtr, windowGraph.PixXToX(num9) * num5)));
										array3[num9 - pixxMin] = point;
										num9++;
									}
									while (num9 < num7);
								}
								windowGraph.DrawLinesInside(array3);
							}
							windowGraph.gpen.DashStyle = (DashStyle)1;
							num = pixxMax;
							if (num > num7)
							{
								Point[] array4 = new Point[num - num7 + 1];
								int num10 = num7;
								if (num7 <= num)
								{
									int num11 = 0;
									do
									{
										Point point2 = new Point(num10, windowGraph.YToPixY(global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementCore_002EWindowAmplitude((MeasurementCore*)measPtr, windowGraph.PixXToX(num10) * num5)));
										array4[num11] = point2;
										num10++;
										num11++;
									}
									while (num10 <= pixxMax);
								}
								windowGraph.DrawLinesInside(array4);
							}
						}
						else
						{
							windowGraph.gpen.DashStyle = (DashStyle)1;
							int num12 = pixxMin;
							if (num12 <= pixxMax)
							{
								do
								{
									Point point3 = new Point(num12, windowGraph.YToPixY(global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementCore_002EWindowAmplitude((MeasurementCore*)measPtr, windowGraph.PixXToX(num12) * num5)));
									array[num12 - pixxMin] = point3;
									num12++;
								}
								while (num12 <= pixxMax);
							}
							windowGraph.SetDrawColor(basicMeasurementPresenter.ImpulseWindowColor);
							windowGraph.SetPlotWidth(basicMeasurementPresenter.ImpulseLineWidth);
							windowGraph.DrawLinesInside(array);
						}
					}
					else if (global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementCore_002EGetSmoothingEnabled((MeasurementCore*)measPtr) && global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementCore_002EGetSmoothingComplex((MeasurementCore*)measPtr))
					{
						windowGraph.gpen.DashStyle = (DashStyle)2;
						windowGraph.SetDrawColor(basicMeasurementPresenter.ImpulseWindowColor);
						windowGraph.SetPlotWidth(basicMeasurementPresenter.ImpulseLineWidth);
						SmoothingImpulseWindow* ptr2 = (SmoothingImpulseWindow*)global::_003CModule_003E.@new(40u);
						SmoothingImpulseWindow* ptr3;
						try
						{
							ptr3 = ((ptr2 == null) ? null : global::_003CModule_003E.HOLM_002EMeasure_002ESmoothingImpulseWindow_002E_007Bctor_007D(ptr2, global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementCore_002EGetSmoothNOct((MeasurementCore*)measPtr), global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementCore_002EGetSamplerate((MeasurementCore*)measPtr), 1000.0));
						}
						catch
						{
							//try-fault
							global::_003CModule_003E.delete(ptr2);
							throw;
						}
						int num13 = 10;
						do
						{
							global::_003CModule_003E.HOLM_002EMeasure_002ESmoothingImpulseWindow_002ESetFrequency(ptr3, num13);
							int num14 = pixxMin;
							if (num14 <= pixxMax)
							{
								do
								{
									Point point4 = new Point(num14, windowGraph.YToPixY(global::_003CModule_003E.HOLM_002EMeasure_002ESmoothingImpulseWindow_002EAmplitude(ptr3, windowGraph.PixXToX(num14) * num5)));
									array[num14 - pixxMin] = point4;
									num14++;
								}
								while (num14 <= pixxMax);
							}
							windowGraph.DrawLinesInside(array);
							int num15 = windowGraph.XToPixX(0.0);
							int num16 = windowGraph.YToPixY(0.5);
							int num17 = windowGraph.XToPixX(global::_003CModule_003E.HOLM_002EMeasure_002ESmoothingImpulseWindow_002EGetMiddle(ptr3));
							global::_003CModule_003E.HOLM_002EMeasure_002ESmoothingImpulseWindow_002ESetFrequency(ptr3, num13 / 10);
							if (windowGraph.XToPixX(global::_003CModule_003E.HOLM_002EMeasure_002ESmoothingImpulseWindow_002EGetMiddle(ptr3)) - num17 > 50 && num17 < windowGraph.GetPixXMax())
							{
								string text;
								if (num13 < 1000)
								{
									int num18 = num13;
									text = num18.ToString();
								}
								else
								{
									text = num13 / 1000 + "k";
								}
								string s = text + "Hz";
								if (num17 - num15 > num16)
								{
									windowGraph.DrawStringBoldPixXY(s, num17, num16 - 10);
								}
								else
								{
									windowGraph.DrawStringVertBoldPixXY(s, num17, num16 - 30);
								}
							}
							num13 *= 10;
						}
						while (num13 < 100000);
						global::_003CModule_003E.delete(ptr3);
					}
					int num19 = (int)(PixXToX(pixxMin) * num5);
					int num20 = (int)(PixXToX(pixxMax) * num5) - num19 + 1;
					SetDrawColor(basicMeasurementPresenter.ImpulseColor);
					SetPlotWidth(basicMeasurementPresenter.ImpulseLineWidth);
					double num21 = ((yAxisMode != (AxisMode)3) ? 1.0 : (1.0 / global::_003CModule_003E.HOLM_002EMeasure_002EMeasurement_002EGetMaxAbsImpulse(measPtr)));
					if (num20 >= num2)
					{
						double* ptr4 = global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementCore_002EGetI((MeasurementCore*)measPtr);
						int num22 = pixxMin;
						if (num22 <= pixxMax)
						{
							do
							{
								double num23 = num22;
								int num24 = global::_003CModule_003E.HOLM_002EMath_002EToIntFloor(PixXToX(num23 - 0.5) * num5 + global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementCore_002EGetIFracOffset((MeasurementCore*)measPtr));
								int num25 = global::_003CModule_003E.HOLM_002EMath_002EToIntFloor(PixXToX(num23 + 0.5) * num5 + global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementCore_002EGetIFracOffset((MeasurementCore*)measPtr));
								int num26 = num22 - pixxMin;
								if (global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementCore_002ESafeN((MeasurementCore*)measPtr, num24) && global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementCore_002ESafeN((MeasurementCore*)measPtr, num25))
								{
									double num27 = *(double*)(num24 * 8 + (byte*)ptr4);
									double num28 = *(double*)(num24 * 8 + (byte*)ptr4);
									int num29 = num24 + 1;
									if (num29 < num25)
									{
										do
										{
											if (*(double*)(num29 * 8 + (byte*)ptr4) < num27)
											{
												num27 = *(double*)(num29 * 8 + (byte*)ptr4);
											}
											if (*(double*)(num29 * 8 + (byte*)ptr4) > num28)
											{
												num28 = *(double*)(num29 * 8 + (byte*)ptr4);
											}
											num29++;
										}
										while (num29 < num25);
									}
									if (*(double*)(num25 * 8 + (byte*)ptr4 - 8) > *(double*)(num24 * 8 + (byte*)ptr4))
									{
										Point point5 = new Point(num22, YToPixY(num27 * num5 * num21));
										array2[num26 * 2] = point5;
										Point point6 = new Point(num22, YToPixY(num28 * num5 * num21));
										array2[num26 * 2 + 1] = point6;
									}
									else
									{
										Point point7 = new Point(num22, YToPixY(num28 * num5 * num21));
										array2[num26 * 2] = point7;
										Point point8 = new Point(num22, YToPixY(num27 * num5 * num21));
										array2[num26 * 2 + 1] = point8;
									}
								}
								else
								{
									Point point9 = new Point(num22, YToPixY(0.0));
									array2[num26 * 2] = point9;
									Point point10 = new Point(num22, YToPixY(0.0));
									array2[num26 * 2 + 1] = point10;
								}
								num22++;
							}
							while (num22 <= pixxMax);
						}
						DrawLinesInside(array2);
					}
					else
					{
						double* ptr5 = global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementCore_002EGetI((MeasurementCore*)measPtr);
						int num30 = pixxMin;
						if (num30 <= pixxMax)
						{
							do
							{
								double num31 = PixXToX(num30) * num5;
								if (global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementCore_002ESafeN((MeasurementCore*)measPtr, num31))
								{
									double num32 = ((!fInterpolateSamples) ? (*(double*)(global::_003CModule_003E.HOLM_002EMath_002EToIntRound(global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementCore_002EGetIFracOffset((MeasurementCore*)measPtr) + num31) * 8 + (byte*)ptr5)) : global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementCore_002EGetIInterpolated((MeasurementCore*)measPtr, num31));
									Point point11 = new Point(num30, YToPixY(num32 * num5 * num21));
									array[num30 - pixxMin] = point11;
								}
								else
								{
									Point point12 = new Point(num30, YToPixY(0.0));
									array[num30 - pixxMin] = point12;
								}
								num30++;
							}
							while (num30 <= pixxMax);
						}
						DrawLinesInside(array);
					}
					if (fShowHDPreTops && global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementCore_002EGetSignalType((MeasurementCore*)measPtr) == (SignalType)1)
					{
						int num33 = 2;
						do
						{
							double num34 = global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementCore_002EGetSignalTypeFactor1((MeasurementCore*)measPtr) * Math.Log(num33) * (double)(*(int*)((byte*)measPtr + 64));
							if (global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementCore_002EGetHDSize((MeasurementCore*)measPtr) >= num33)
							{
								int num35 = XToPixX(0.0 - num34 / num5);
								if (num35 > pixxMin && num35 < pixxMax)
								{
									sBrush.Color = basicMeasurementPresenter.AmpColor;
									int num36 = pixyMax - boldFont.Height - 1;
									Point[] array5 = new Point[3];
									Point point13 = new Point(num35 - 5, num36);
									array5[0] = point13;
									Point point14 = new Point(num35, num36 - 10);
									array5[1] = point14;
									Point point15 = new Point(num35 + 5, num36);
									array5[2] = point15;
									bitmapGraphics.FillPolygon((Brush)(object)sBrush, array5);
									int num37 = num33;
									bitmapGraphics.DrawString(num37 + ".", boldFont, (Brush)(object)sBrush, (float)num35, (float)num36, stringFormatCenter);
								}
							}
							num33++;
						}
						while (num33 < 30);
					}
					num3++;
					num4 = System.Runtime.CompilerServices.Unsafe.As<vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 16)) - System.Runtime.CompilerServices.Unsafe.As<vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 12)) >> 2;
				}
				while (num3 < (uint)num4);
			}
		}
		catch
		{
			//try-fault
			global::_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E*, void>)(&global::_003CModule_003E.std_002Evector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E_002E_007Bdtor_007D), &obj);
			throw;
		}
		global::_003CModule_003E.std_002Evector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E_002E_007Bdtor_007D(&obj);
	}

	public unsafe void AutoZoom([MarshalAs(UnmanagedType.U1)] bool fTime)
	{
		double num = 100.0;
		double num2 = -100.0;
		int num3 = (int)PixXToX(pixxMin);
		int num4 = (int)PixXToX(pixxMax);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E obj);
		measurementContainer.GetPlotVector(&obj);
		try
		{
			if (fTime)
			{
				int num5 = System.Runtime.CompilerServices.Unsafe.As<vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 16)) - System.Runtime.CompilerServices.Unsafe.As<vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 12)) >> 2;
				if (num5 != 0)
				{
					num3 = -25;
					num4 = 100;
					double num6 = 0.0;
					double num7 = 0.0;
					double num8 = 0.0;
					uint num9 = 0u;
					if (0u < (uint)num5)
					{
						do
						{
							if (num9 >= (uint)num5)
							{
								global::_003CModule_003E._invalid_parameter_noinfo();
							}
							int* ptr = (int*)(int)(num9 * 4 + (uint)System.Runtime.CompilerServices.Unsafe.As<vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 12)));
							Measurement* measPtr = measurementContainer.GetPresenters()[*ptr].measPtr;
							double num10 = (double)(*(int*)((byte*)measPtr + 64)) / (double)samplerate;
							double num11 = global::_003CModule_003E.HOLM_002EMeasure_002EMeasurement_002EGetMaxAbsImpulse(measPtr) * num10;
							if (num11 > num6)
							{
								num6 = num11;
							}
							if (global::_003CModule_003E.HOLM_002EMeasure_002EConfigCtrl_002EGetEnabled((ConfigCtrl*)((byte*)measPtr + 136), (EnabledEnum)1))
							{
								int num12 = *(int*)((byte*)measPtr + 84);
								double num13 = *(int*)((byte*)measPtr + 64);
								if ((double)num12 > num13 * num7)
								{
									num7 = (double)num12 / num13;
								}
								if (((byte*)measPtr)[90] == 0)
								{
									int num14 = *(int*)((byte*)measPtr + 80);
									if ((double)num14 < num13 * num8)
									{
										num8 = (double)num14 / num13;
									}
								}
							}
							num9++;
							num5 = System.Runtime.CompilerServices.Unsafe.As<vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 16)) - System.Runtime.CompilerServices.Unsafe.As<vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 12)) >> 2;
						}
						while (num9 < (uint)num5);
					}
					double num15 = -0.0002 / num6;
					double num16 = 0.0005 / num6;
					double num17 = num7 * 2.0;
					if (num16 < num17)
					{
						num16 = num17;
					}
					double num18 = num8 * 1.5;
					if (num15 > num18)
					{
						num15 = num18;
					}
					double num19 = (double)samplerate * num15;
					if (num19 < -25.0)
					{
						num3 = global::_003CModule_003E.HOLM_002EMath_002EToIntRound(num19);
					}
					double num20 = (double)samplerate * num16;
					if (num20 > 100.0)
					{
						num4 = global::_003CModule_003E.HOLM_002EMath_002EToIntRound(num20);
					}
				}
			}
			uint num21 = 0u;
			int num22 = System.Runtime.CompilerServices.Unsafe.As<vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 16)) - System.Runtime.CompilerServices.Unsafe.As<vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 12)) >> 2;
			if (0u < (uint)num22)
			{
				double num23 = num3;
				double num24 = num4;
				do
				{
					if (num21 >= (uint)num22)
					{
						global::_003CModule_003E._invalid_parameter_noinfo();
					}
					int* ptr2 = (int*)(int)(num21 * 4 + (uint)System.Runtime.CompilerServices.Unsafe.As<vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 12)));
					Measurement* measPtr2 = measurementContainer.GetPresenters()[*ptr2].measPtr;
					double num10 = (double)(*(int*)((byte*)measPtr2 + 64)) / (double)samplerate;
					int num25 = *(int*)((byte*)measPtr2 + 52);
					int num26 = 1 - num25;
					int num27 = (int)(num23 * num10);
					int num28 = ((num27 <= num26) ? num26 : num27);
					int num29 = (int)(num24 * num10);
					int num30 = ((num29 >= num25 - 1) ? (num25 - 1) : num29);
					double* ptr3 = global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementCore_002EGetI((MeasurementCore*)measPtr2);
					int num31 = num28;
					if (num28 <= num30)
					{
						do
						{
							double num32 = *(double*)(num31 * 8 + (byte*)ptr3) * num10;
							if (num32 > num2)
							{
								num2 = num32;
							}
							if (num32 < num)
							{
								num = num32;
							}
							num31++;
						}
						while (num31 <= num30);
					}
					if (num28 < 0 && num30 > 0)
					{
						int num33 = -2;
						do
						{
							double num32 = global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementCore_002EGetIInterpolated((MeasurementCore*)measPtr2, (double)num33 + 0.5) * num10;
							if (num32 > num2)
							{
								num2 = num32;
							}
							if (num32 < num)
							{
								num = num32;
							}
							num33++;
						}
						while (num33 < 2);
					}
					num21++;
					num22 = System.Runtime.CompilerServices.Unsafe.As<vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 16)) - System.Runtime.CompilerServices.Unsafe.As<vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 12)) >> 2;
				}
				while (num21 < (uint)num22);
			}
			if (System.Runtime.CompilerServices.Unsafe.As<vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 16)) - System.Runtime.CompilerServices.Unsafe.As<vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 12)) >> 2 != 0)
			{
				double num34 = (num2 - num) * 0.2;
				if (yAxisMode == (AxisMode)3)
				{
					num = -1.0;
					num2 = 1.0;
					num34 = 0.9;
				}
				if (fTime)
				{
					ZoomAllOut();
					ZoomIn(num3, num4, num - num34, num34 + num2);
				}
				else
				{
					SetPlotRange(GetXMin(), GetXMax(), num - num34, num34 + num2);
				}
			}
		}
		catch
		{
			//try-fault
			global::_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E*, void>)(&global::_003CModule_003E.std_002Evector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E_002E_007Bdtor_007D), &obj);
			throw;
		}
		try
		{
			if (System.Runtime.CompilerServices.Unsafe.As<vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 12)) != 0)
			{
				global::_003CModule_003E.delete((void*)(int)System.Runtime.CompilerServices.Unsafe.As<vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E, uint>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 12)));
			}
			System.Runtime.CompilerServices.Unsafe.As<vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 12)) = 0;
			System.Runtime.CompilerServices.Unsafe.As<vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 16)) = 0;
			System.Runtime.CompilerServices.Unsafe.As<vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 20)) = 0;
		}
		catch
		{
			//try-fault
			global::_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<_Vector_val_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E*, void>)(&global::_003CModule_003E.std_002E_Vector_val_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E_002E_007Bdtor_007D), &obj);
			throw;
		}
		global::_003CModule_003E.delete((void*)(int)(*(uint*)(&obj)));
	}

	public void SetMode(ImpulseGraphMode newMode)
	{
		if (mode != newMode)
		{
			mode = newMode;
			_003Cbacking_store_003EEvent_Parameters?.Invoke(this, null);
			UpdatePlotArea();
		}
	}

	public unsafe override void ChildMouseMove(MouseEventArgs e)
	{
		string text = "; ";
		if (statusLabel != null)
		{
			double num = PixXToX(e.X);
			double num2 = PixYToY(e.Y);
			string text2;
			if (yAxisMode == (AxisMode)3)
			{
				double num3 = Math.Abs(num2);
				text2 = global::_003CModule_003E.HOLM_002EMath_002EAmplitudeToDB_003Cdouble_003E(num3).ToString("F0") + "dB";
			}
			else
			{
				double num4 = num2;
				text2 = num4.ToString("F3");
			}
			switch (mode)
			{
			case (ImpulseGraphMode)2:
			{
				double num7 = SamplesToCM * num;
				double value = num7;
				if (Math.Abs(value) < 500.0)
				{
					double num8 = num7;
					statusLabel.Text = string.Concat(string.Concat(string.Concat(string.Concat("(" + num8.ToString("F1"), "cm"), text), text2), ")");
				}
				else
				{
					double num9 = SamplesToM * num;
					statusLabel.Text = string.Concat(string.Concat(string.Concat(string.Concat("(" + num9.ToString("F2"), "m"), text), text2), ")");
				}
				break;
			}
			case (ImpulseGraphMode)1:
			{
				double num6 = SamplesToTime * num;
				statusLabel.Text = string.Concat(string.Concat(string.Concat(string.Concat("(" + num6.ToString("F2"), "ms"), text), text2), ")");
				break;
			}
			case (ImpulseGraphMode)0:
			{
				double num5 = num;
				statusLabel.Text = string.Concat(string.Concat(string.Concat("(" + num5.ToString("F1"), text), text2), ")");
				break;
			}
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E obj);
		measurementContainer.GetPlotWindowsVector(&obj);
		try
		{
			int num10 = System.Runtime.CompilerServices.Unsafe.As<vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 16)) - System.Runtime.CompilerServices.Unsafe.As<vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 12)) >> 2;
			if (num10 != 0 && !fLeftMouseZoomDownStatus)
			{
				if (fImpulseWindowOntheMove)
				{
					HighlightWindow(impulseMouseMode, e);
				}
				else
				{
					bool flag = false;
					int num11 = num10 - 1;
					if (num11 >= 0)
					{
						while (!flag)
						{
							if ((uint)num11 >= (uint)(System.Runtime.CompilerServices.Unsafe.As<vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 16)) - System.Runtime.CompilerServices.Unsafe.As<vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 12)) >> 2))
							{
								global::_003CModule_003E._invalid_parameter_noinfo();
							}
							int* ptr = (int*)(num11 * 4 + System.Runtime.CompilerServices.Unsafe.As<vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 12)));
							Measurement* measPtr = measurementContainer.GetPresenters()[*ptr].measPtr;
							double num12 = (double)samplerate / (double)(*(int*)((byte*)measPtr + 64));
							int num13 = windowGraph.YToPixY(0.0);
							int num14 = windowGraph.YToPixY(1.0);
							if (num14 == num13)
							{
								num14++;
							}
							int num15 = *(int*)((byte*)measPtr + 80);
							int num16 = *(int*)((byte*)measPtr + 92);
							int num17 = XToPixX((double)(num15 - num16 / 3) * num12);
							int num18 = *(int*)((byte*)measPtr + 80);
							int num19 = *(int*)((byte*)measPtr + 92);
							int num20 = XToPixX((double)(num19 / 3 + num18) * num12);
							if (e.Y <= windowGraph.GetPixYMax() && e.Y >= windowGraph.GetPixYMin())
							{
								if (!global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementCore_002EGetImpulseWindowLockStart((MeasurementCore*)measPtr) && Math.Abs(num17 + (e.Y - num13) * (num20 - num17) / (num14 - num13) - e.X) < 15)
								{
									measOntheMove = measPtr;
									flag = true;
									HighlightWindow((ImpulseMouseMode)0, e);
								}
								else
								{
									int num21 = *(int*)((byte*)measPtr + 84);
									int num22 = *(int*)((byte*)measPtr + 96);
									num17 = XToPixX((double)(num22 / 3 + num21) * num12);
									num20 = XToPixX((double)(global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementCore_002EGetImpulseWindowEnd((MeasurementCore*)measPtr) - global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementCore_002EGetImpulseWindowEndDelta((MeasurementCore*)measPtr) / 3) * num12);
									if (Math.Abs(num17 + (e.Y - num13) * (num20 - num17) / (num14 - num13) - e.X) < 15)
									{
										measOntheMove = measPtr;
										flag = true;
										HighlightWindow((ImpulseMouseMode)1, e);
									}
									else
									{
										HighlightWindow((ImpulseMouseMode)2, e);
									}
								}
							}
							else if (impulseMouseMode != (ImpulseMouseMode)2)
							{
								impulseMouseMode = (ImpulseMouseMode)2;
								SetEnableMouseZoomIn(value: true);
								plotArea.Cursor = Cursors.Cross;
							}
							num11--;
							if (num11 < 0)
							{
								break;
							}
						}
					}
				}
			}
		}
		catch
		{
			//try-fault
			global::_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E*, void>)(&global::_003CModule_003E.std_002Evector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E_002E_007Bdtor_007D), &obj);
			throw;
		}
		try
		{
			if (System.Runtime.CompilerServices.Unsafe.As<vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 12)) != 0)
			{
				global::_003CModule_003E.delete((void*)(int)System.Runtime.CompilerServices.Unsafe.As<vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E, uint>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 12)));
			}
			System.Runtime.CompilerServices.Unsafe.As<vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 12)) = 0;
			System.Runtime.CompilerServices.Unsafe.As<vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 16)) = 0;
			System.Runtime.CompilerServices.Unsafe.As<vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 20)) = 0;
		}
		catch
		{
			//try-fault
			global::_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<_Vector_val_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E*, void>)(&global::_003CModule_003E.std_002E_Vector_val_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E_002E_007Bdtor_007D), &obj);
			throw;
		}
		global::_003CModule_003E.delete((void*)(int)(*(uint*)(&obj)));
	}

	public override void ChildMouseLeave()
	{
		statusLabel.Text = "";
		if (impulseMouseMode != (ImpulseMouseMode)2)
		{
			fImpulseWindowOntheMove = false;
		}
	}

	public unsafe override void ChildMouseDown(MouseEventArgs e)
	{
		ImpulseMouseMode impulseMouseMode = this.impulseMouseMode;
		if (impulseMouseMode != (ImpulseMouseMode)2)
		{
			fImpulseWindowOntheMove = true;
			Measurement* ptr = measOntheMove;
			double num = (double)samplerate / (double)(*(int*)((byte*)ptr + 64));
			switch (impulseMouseMode)
			{
			case (ImpulseMouseMode)0:
			{
				_ = plotArea.Cursor;
				int num3 = *(int*)((byte*)ptr + 80);
				Point point2 = new Point(XToPixX((double)num3 * num), windowGraph.YToPixY(0.5));
				Cursor.Position = plotArea.PointToScreen(point2);
				break;
			}
			case (ImpulseMouseMode)1:
			{
				_ = plotArea.Cursor;
				int num2 = *(int*)((byte*)ptr + 84);
				Point point = new Point(XToPixX((double)num2 * num), windowGraph.YToPixY(0.5));
				Cursor.Position = plotArea.PointToScreen(point);
				break;
			}
			}
		}
	}

	public override void ChildMouseUp(MouseEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I4
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Invalid comparison between Unknown and I4
		if ((int)e.Button == 1048576 && impulseMouseMode != (ImpulseMouseMode)2)
		{
			fImpulseWindowOntheMove = false;
		}
		if ((int)e.Button == 2097152)
		{
			AutoZoom(fTime: false);
		}
	}

	public unsafe void HighlightWindow(ImpulseMouseMode mode, MouseEventArgs e)
	{
		if (mode == (ImpulseMouseMode)2)
		{
			if (this.impulseMouseMode != (ImpulseMouseMode)2)
			{
				this.impulseMouseMode = (ImpulseMouseMode)2;
				SetEnableMouseZoomIn(value: true);
				plotArea.Cursor = Cursors.Cross;
			}
			return;
		}
		ImpulseMouseMode impulseMouseMode = this.impulseMouseMode;
		if (impulseMouseMode == mode && !fImpulseWindowOntheMove)
		{
			return;
		}
		Measurement* ptr = measOntheMove;
		double num = (double)samplerate / (double)(*(int*)((byte*)ptr + 64));
		if (impulseMouseMode != mode)
		{
			SetEnableMouseZoomIn(value: false);
			plotArea.Cursor = Cursors.NoMoveHoriz;
			this.impulseMouseMode = mode;
		}
		if (!fImpulseWindowOntheMove)
		{
			return;
		}
		switch (this.impulseMouseMode)
		{
		case (ImpulseMouseMode)0:
		{
			int num4 = (int)(PixXToX(e.X) / num);
			int num5 = *(int*)((byte*)ptr + 84);
			if (num4 >= num5)
			{
				num4 = num5 - 1;
			}
			global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementCore_002ESetImpulseWindowStart((MeasurementCore*)ptr, num4, false);
			_003Cbacking_store_003EEvent_Parameters?.Invoke(this, null);
			break;
		}
		case (ImpulseMouseMode)1:
		{
			int num2 = (int)(PixXToX(e.X) / num);
			int num3 = *(int*)((byte*)ptr + 80);
			if (num2 <= num3)
			{
				num2 = num3 + 1;
			}
			if (num2 < 0)
			{
				num2 = 0;
			}
			if (*(int*)((byte*)ptr + 84) != num2)
			{
				global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementCore_002ESetImpulseWindowEnd((MeasurementCore*)ptr, num2);
				raise_Event_Parameters(this, null);
			}
			break;
		}
		}
	}

	public void SetSamplerate(int samplerateIn)
	{
		double num = (double)samplerateIn / (double)samplerate;
		samplerate = samplerateIn;
		while (ZoomOut())
		{
		}
		SetPlotRange(GetXMin() * num, GetXMax() * num, GetYMin(), GetYMax());
		Graph graph = windowGraph;
		graph.SetPlotRange(GetXMin(), GetXMax(), graph.GetYMin(), graph.GetYMax());
		SamplesToM = (SamplesToCM = (SamplesToTime = 1000.0 / (double)samplerate) * 34.4) / 100.0;
	}

	[SpecialName]
	protected void raise_Event_Parameters(object value0, EventArgs value1)
	{
		_003Cbacking_store_003EEvent_Parameters?.Invoke(value0, value1);
	}

	public void AssignToolTip(ToolTip tooltip)
	{
		tooltip.SetToolTip(plotArea, string.Concat(string.Concat(string.Concat("Zoom In:   Hold left cursor button down and define area\r\n" + "Zoom Back: Right-click\r\n", "\r\n"), "Change the Time Window:\r\n"), "Move cursor over window-edge and hold Left-button down while moving to the left or right"));
	}

	public void Action_AutoZoom(object sender, EventArgs e)
	{
		AutoZoom(fTime: true);
		UpdatePlotArea();
	}

	public unsafe void Action_ZoomOut(object sender, EventArgs e)
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E obj);
		measurementContainer.GetPlotVector(&obj);
		try
		{
			int num = System.Runtime.CompilerServices.Unsafe.As<vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 16)) - System.Runtime.CompilerServices.Unsafe.As<vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 12)) >> 2;
			if (num != 0)
			{
				int num2 = 1;
				int num3 = -1;
				double num4 = 0.0;
				double num5 = 0.0;
				uint num6 = 0u;
				if (0u < (uint)num)
				{
					do
					{
						if (num6 >= (uint)num)
						{
							global::_003CModule_003E._invalid_parameter_noinfo();
						}
						int* ptr = (int*)(int)(num6 * 4 + (uint)System.Runtime.CompilerServices.Unsafe.As<vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 12)));
						Measurement* measPtr = measurementContainer.GetPresenters()[*ptr].measPtr;
						double num7 = (double)(*(int*)((byte*)measPtr + 64)) / (double)samplerate;
						double num8 = ((yAxisMode != (AxisMode)3) ? 1.0 : (1.0 / global::_003CModule_003E.HOLM_002EMeasure_002EMeasurement_002EGetMaxAbsImpulse(measPtr)));
						int num9 = global::_003CModule_003E.HOLM_002EMath_002EToIntFloor((double)(-(*(int*)((byte*)measPtr + 396))) / num7);
						int num10 = global::_003CModule_003E.HOLM_002EMath_002EToIntFloor((double)(*(int*)((byte*)measPtr + 144) - *(int*)((byte*)measPtr + 396)) / num7);
						if (num9 < num3)
						{
							num3 = num9;
						}
						if (num10 > num2)
						{
							num2 = num10;
						}
						double num11 = num8 * num7;
						if (global::_003CModule_003E.HOLM_002EMeasure_002EMeasurement_002EGetMinImpulse(measPtr) * num11 < num4)
						{
							num4 = global::_003CModule_003E.HOLM_002EMeasure_002EMeasurement_002EGetMinImpulse(measPtr) * num11;
						}
						if (global::_003CModule_003E.HOLM_002EMeasure_002EMeasurement_002EGetMaxImpulse(measPtr) * num11 > num5)
						{
							num5 = global::_003CModule_003E.HOLM_002EMeasure_002EMeasurement_002EGetMaxImpulse(measPtr) * num11;
						}
						num6++;
						num = System.Runtime.CompilerServices.Unsafe.As<vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 16)) - System.Runtime.CompilerServices.Unsafe.As<vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 12)) >> 2;
					}
					while (num6 < (uint)num);
				}
				ZoomAllOut();
				double num12 = (num5 - num4) * 0.2;
				ZoomOutToNewRange(num3, num2, num4 - num12, num12 + num5);
				UpdatePlotArea();
			}
		}
		catch
		{
			//try-fault
			global::_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E*, void>)(&global::_003CModule_003E.std_002Evector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E_002E_007Bdtor_007D), &obj);
			throw;
		}
		try
		{
			if (System.Runtime.CompilerServices.Unsafe.As<vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 12)) != 0)
			{
				global::_003CModule_003E.delete((void*)(int)System.Runtime.CompilerServices.Unsafe.As<vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E, uint>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 12)));
			}
			System.Runtime.CompilerServices.Unsafe.As<vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 12)) = 0;
			System.Runtime.CompilerServices.Unsafe.As<vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 16)) = 0;
			System.Runtime.CompilerServices.Unsafe.As<vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 20)) = 0;
		}
		catch
		{
			//try-fault
			global::_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<_Vector_val_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E*, void>)(&global::_003CModule_003E.std_002E_Vector_val_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E_002E_007Bdtor_007D), &obj);
			throw;
		}
		global::_003CModule_003E.delete((void*)(int)(*(uint*)(&obj)));
	}

	public int GetSamplerate()
	{
		return samplerate;
	}

	public ImpulseGraphMode GetMode()
	{
		return mode;
	}

	public void Action_DBMirrorCheckBox(object sender, EventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		if (((CheckBox)sender).Checked)
		{
			SetYAxisMode((AxisMode)3);
		}
		else
		{
			SetYAxisMode((AxisMode)0);
		}
		AutoZoom(fTime: false);
		UpdatePlotArea();
	}

	public unsafe void Action_ReverberationButton(object sender, EventArgs e)
	{
		impGraph.dBNormCheckBox.Checked = true;
		SetYAxisMode((AxisMode)3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E obj);
		measurementContainer.GetPlotVector(&obj);
		try
		{
			double num = (double)samplerate * 0.01;
			uint num2 = 0u;
			int num3 = System.Runtime.CompilerServices.Unsafe.As<vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 16)) - System.Runtime.CompilerServices.Unsafe.As<vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 12)) >> 2;
			if (0u < (uint)num3)
			{
				do
				{
					if (num2 >= (uint)num3)
					{
						global::_003CModule_003E._invalid_parameter_noinfo();
					}
					int* ptr = (int*)(int)(num2 * 4 + (uint)System.Runtime.CompilerServices.Unsafe.As<vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 12)));
					BasicMeasurementPresenter basicMeasurementPresenter = measurementContainer.GetPresenters()[*ptr];
					Measurement* measPtr = basicMeasurementPresenter.measPtr;
					double num4 = (double)(*(int*)((byte*)measPtr + 64)) / (double)samplerate;
					double* ptr2 = global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementCore_002EGetI((MeasurementCore*)measPtr);
					double num5 = 0.0;
					double num6 = 1.0 / global::_003CModule_003E.HOLM_002EMeasure_002EMeasurement_002EGetMaxAbsImpulse(basicMeasurementPresenter.measPtr);
					int num7 = global::_003CModule_003E.HOLM_002EMath_002EToIntRound((double)(*(int*)((byte*)basicMeasurementPresenter.measPtr + 64)) / 1000.0);
					double num8 = global::_003CModule_003E.HOLM_002EMath_002EDBToAmplitude_003Cdouble_003E(-65.0) * (double)num7;
					int num9 = *(int*)((byte*)basicMeasurementPresenter.measPtr + 52) - 100;
					if (num9 >= num7)
					{
						int num10 = num7 * 8;
						double* ptr3 = (double*)(num9 * 8 + (byte*)ptr2);
						while (num5 < num8)
						{
							num9 -= num7;
							ptr3 = (double*)((byte*)ptr3 - num10);
							num5 = 0.0;
							if (0 < num7)
							{
								double* ptr4 = ptr3;
								int num11 = num7;
								do
								{
									double value = *ptr4;
									num5 = Math.Abs(value) + num5;
									ptr4++;
									num11--;
								}
								while (num11 != 0);
							}
							num5 = num6 * num5;
							if (num9 < num7)
							{
								break;
							}
						}
					}
					double num12 = (double)num9 / num4;
					if (num12 > num)
					{
						num = num12;
					}
					num2++;
					num3 = System.Runtime.CompilerServices.Unsafe.As<vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 16)) - System.Runtime.CompilerServices.Unsafe.As<vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 12)) >> 2;
				}
				while (num2 < (uint)num3);
			}
			num *= 2.0;
			ZoomAllOut();
			double num13 = samplerate;
			if (num > num13)
			{
				num = num13;
			}
			ZoomIn(num13 * -0.01, num);
			AutoZoom(fTime: false);
			UpdatePlotArea();
		}
		catch
		{
			//try-fault
			global::_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E*, void>)(&global::_003CModule_003E.std_002Evector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E_002E_007Bdtor_007D), &obj);
			throw;
		}
		try
		{
			if (System.Runtime.CompilerServices.Unsafe.As<vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 12)) != 0)
			{
				global::_003CModule_003E.delete((void*)(int)System.Runtime.CompilerServices.Unsafe.As<vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E, uint>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 12)));
			}
			System.Runtime.CompilerServices.Unsafe.As<vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 12)) = 0;
			System.Runtime.CompilerServices.Unsafe.As<vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 16)) = 0;
			System.Runtime.CompilerServices.Unsafe.As<vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 20)) = 0;
		}
		catch
		{
			//try-fault
			global::_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<_Vector_val_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E*, void>)(&global::_003CModule_003E.std_002E_Vector_val_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E_002E_007Bdtor_007D), &obj);
			throw;
		}
		global::_003CModule_003E.delete((void*)(int)(*(uint*)(&obj)));
	}

	public void Action_YAxisModedBMirror0DBChanged(object sender, EventArgs e)
	{
		SetYAxisModedBMirror0DB(impGraph.dB0UpDown.Value);
		UpdatePlotArea();
	}

	public void SaveBitmapDialog([MarshalAs(UnmanagedType.U1)] bool showlegends)
	{
		if (showlegends)
		{
			PrintLegends();
		}
		SaveBitmapDialog();
	}

	public unsafe void PrintLegends()
	{
		BasicPresenterContainer basicPresenterContainer = measurementContainer;
		if (basicPresenterContainer == null)
		{
			return;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E obj);
		basicPresenterContainer.GetPlotVector(&obj);
		try
		{
			uint num = 0u;
			int num2 = System.Runtime.CompilerServices.Unsafe.As<vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 16)) - System.Runtime.CompilerServices.Unsafe.As<vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 12)) >> 2;
			if (0u < (uint)num2)
			{
				do
				{
					if (num >= (uint)num2)
					{
						global::_003CModule_003E._invalid_parameter_noinfo();
					}
					int* ptr = (int*)(int)(num * 4 + (uint)System.Runtime.CompilerServices.Unsafe.As<vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 12)));
					BasicMeasurementPresenter basicMeasurementPresenter = measurementContainer.GetPresenters()[*ptr];
					uint ntotal = (uint)(System.Runtime.CompilerServices.Unsafe.As<vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 16)) - System.Runtime.CompilerServices.Unsafe.As<vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 12)) >> 2);
					string text = new string(global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002Ec_str((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)basicMeasurementPresenter.measPtr));
					uint num3 = num + 1;
					PrintLegend(text, basicMeasurementPresenter.AmpColor, basicMeasurementPresenter.FreqLineWidth, (int)num3, (int)ntotal);
					num = num3;
					num2 = System.Runtime.CompilerServices.Unsafe.As<vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 16)) - System.Runtime.CompilerServices.Unsafe.As<vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 12)) >> 2;
				}
				while (num < (uint)num2);
			}
		}
		catch
		{
			//try-fault
			global::_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E*, void>)(&global::_003CModule_003E.std_002Evector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E_002E_007Bdtor_007D), &obj);
			throw;
		}
		try
		{
			if (System.Runtime.CompilerServices.Unsafe.As<vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 12)) != 0)
			{
				global::_003CModule_003E.delete((void*)(int)System.Runtime.CompilerServices.Unsafe.As<vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E, uint>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 12)));
			}
			System.Runtime.CompilerServices.Unsafe.As<vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 12)) = 0;
			System.Runtime.CompilerServices.Unsafe.As<vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 16)) = 0;
			System.Runtime.CompilerServices.Unsafe.As<vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 20)) = 0;
		}
		catch
		{
			//try-fault
			global::_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<_Vector_val_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E*, void>)(&global::_003CModule_003E.std_002E_Vector_val_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E_002E_007Bdtor_007D), &obj);
			throw;
		}
		global::_003CModule_003E.delete((void*)(int)(*(uint*)(&obj)));
	}

	private void Initialize()
	{
		windowGraph = new Graph((Control)(object)impGraph, -8820.0, 8820.0, 0.0, 1.0);
		SamplesToM = (SamplesToCM = (SamplesToTime = 1000.0 / (double)samplerate) * 34.4) / 100.0;
		mode = (ImpulseGraphMode)0;
		impulseMouseMode = (ImpulseMouseMode)2;
		fImpulseWindowOntheMove = false;
		fPlotTarget = false;
		fShowHDPreTops = false;
		fInterpolateSamples = true;
		minval = -1.0;
		maxval = 1.0;
		SetXTics(20);
		SetYTics(8);
		SetBorders(borderXLeft, borderXRight + 20, borderYTop, borderYBot);
		Graph graph = windowGraph;
		graph.bitmapGraphics = bitmapGraphics;
		HostParasite(graph, fZoomY: false);
		windowGraph.SetYTics(4);
		windowGraph.SetBorders(borderXLeft, borderXRight, borderYTop, borderYBot);
		windowGraph.SetPlotRange(GetXMin(), GetXMax(), 0.0, 1.0);
		SetStatusLabel(impGraph.coordsLabel);
		((Control)impGraph.dBNormCheckBox).Click += Action_DBMirrorCheckBox;
		((Control)impGraph.reverberationButton).Click += Action_ReverberationButton;
		((Control)impGraph.autoZoomButton).Click += Action_AutoZoom;
		((Control)impGraph.zoomOutButton).Click += Action_ZoomOut;
		impGraph.dB0UpDown.ValueChangedByUpDown += Action_YAxisModedBMirror0DBChanged;
		yAxisModedBMirror0DB = impGraph.dB0UpDown.Value;
	}

	protected override void Dispose([MarshalAs(UnmanagedType.U1)] bool P_0)
	{
		if (P_0)
		{
			try
			{
				_007EImpulseGraph();
				return;
			}
			finally
			{
				base.Dispose(true);
			}
		}
		base.Dispose(false);
	}
}
