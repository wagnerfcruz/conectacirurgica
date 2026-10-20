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

internal class FreqGraph : MouseZoomGraph
{
	public Graph phaseGraph;

	public double HidePhaseAmpLimit;

	public double HideHDAmpLimit;

	public bool fPlotPhase;

	public bool fPlotTarget;

	public bool fPlotHD;

	public PlotHD plotHD;

	public bool fPlotAmplitude;

	public bool fPlotNextChannel;

	public bool fPlotWindowFrequency;

	public bool fPlotMainChannel;

	public ImpulseGraph impulseGraphFriend;

	public DashStyle dashStyleAmplitude;

	public DashStyle dashStyleAmplitudeNext;

	private AbstractFilterPresenterContainer filterContainer;

	private BasicPresenterContainer measurementContainer;

	private ControlFrequencyGraph freqGraph;

	public FreqGraph(ControlFrequencyGraph plotArea, double xminin, double xmaxin, double yminin, double ymaxin)
		: base((Control)(object)plotArea, xminin, xmaxin, yminin, ymaxin)
	{
		try
		{
			phaseGraph = new Graph((Control)(object)plotArea, xminin, xmaxin, -180.0, 180.0);
			freqGraph = plotArea;
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

	public FreqGraph(ControlFrequencyGraph plotArea)
		: base((Control)(object)plotArea, 10.0, 22050.0, global::_003CModule_003E.HOLM_002EMath_002EDBToAmplitude_003Cdouble_003E(-60.0), global::_003CModule_003E.HOLM_002EMath_002EDBToAmplitude_003Cdouble_003E(20.0))
	{
		try
		{
			phaseGraph = new Graph((Control)(object)plotArea, 10.0, 22050.0, -180.0, 180.0);
			freqGraph = plotArea;
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

	private void _007EFreqGraph()
	{
		((IDisposable)phaseGraph)?.Dispose();
	}

	public void AssignMeasurements(BasicPresenterContainer container)
	{
		measurementContainer = container;
	}

	public void AssignFilters(AbstractFilterPresenterContainer container)
	{
		filterContainer = container;
	}

	public void AssignToolTip(ToolTip tooltip)
	{
		tooltip.SetToolTip(plotArea, "Zoom In:   Hold left cursor button down and define area\r\n" + "Zoom Back: Right-click");
	}

	public void PrintLabels()
	{
		Color foreColor = plotArea.ForeColor;
		SetDrawColor(foreColor);
		PrintXLabel("Frequency [Hz]");
		if (fPlotAmplitude || fPlotTarget || fPlotHD)
		{
			if (yAxisMode == (AxisMode)2)
			{
				PrintYLabel("Amplitude [dB]");
			}
			else
			{
				PrintYLabel("Amplitude");
			}
		}
		PrintTitel("Frequency Response", 100);
	}

	public unsafe override void UpdatePlot()
	{
		//IL_02e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_0deb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b77: Unknown result type (might be due to invalid IL or missing references)
		int num = pixxMax + (1 - pixxMin);
		Point[] array = new Point[num];
		Point[] array2 = new Point[num];
		PrintLabels();
		if (!fPlotAmplitude && !fPlotTarget && !fPlotHD)
		{
			((Control)freqGraph.minUpDown).Visible = false;
		}
		else
		{
			DrawAxis(fDrawArrows: false, fDrawGrid: true);
			((Control)freqGraph.minUpDown).Visible = true;
		}
		freqGraph.minUpDown.Value = global::_003CModule_003E.HOLM_002EMath_002EAmplitudeToDB_003Cdouble_003E(GetYMin());
		if (phaseGraph != null && fPlotPhase)
		{
			Color foreColor = plotArea.ForeColor;
			phaseGraph.SetDrawColor(foreColor);
			phaseGraph.SetPlotWidth(2);
			if (!fPlotAmplitude && !fPlotTarget && !fPlotHD)
			{
				phaseGraph.PrintYLabel("Phase [Degrees]");
				phaseGraph.DrawAxis(fDrawArrows: false, fDrawGrid: true);
			}
			else
			{
				phaseGraph.PrintYRightLabel("Phase [Degrees]");
				phaseGraph.DrawYGrid(fLeftSide: false);
			}
		}
		AbstractFilterPresenterContainer abstractFilterPresenterContainer = filterContainer;
		if (abstractFilterPresenterContainer != null)
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E obj);
			abstractFilterPresenterContainer.GetPlotVector(&obj);
			try
			{
				uint num2 = 0u;
				int num3 = System.Runtime.CompilerServices.Unsafe.As<vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 16)) - System.Runtime.CompilerServices.Unsafe.As<vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 12)) >> 2;
				if (0u < (uint)num3)
				{
					System.Runtime.CompilerServices.Unsafe.SkipInit(out complex_003Cdouble_003E complex_003Cdouble_003E);
					System.Runtime.CompilerServices.Unsafe.SkipInit(out complex_003Cdouble_003E complex_003Cdouble_003E2);
					System.Runtime.CompilerServices.Unsafe.SkipInit(out complex_003Cdouble_003E complex_003Cdouble_003E3);
					System.Runtime.CompilerServices.Unsafe.SkipInit(out complex_003Cdouble_003E complex_003Cdouble_003E4);
					do
					{
						if (num2 >= (uint)num3)
						{
							global::_003CModule_003E._invalid_parameter_noinfo();
						}
						int* ptr = (int*)(int)(num2 * 4 + (uint)System.Runtime.CompilerServices.Unsafe.As<vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 12)));
						AbstractFilterPresenter abstractFilterPresenter = filterContainer.GetPresenters()[*ptr];
						if (fPlotMainChannel || !abstractFilterPresenter.HasNextChannel())
						{
							double num4 = 0.0;
							double num5 = 0.0;
							global::_003CModule_003E.std_002Ecomplex_003Cdouble_003E_002E_007Bctor_007D(&complex_003Cdouble_003E, &num5, &num4);
							int num6 = pixxMin;
							if (num6 <= pixxMax)
							{
								do
								{
									complex_003Cdouble_003E* freqResponse = abstractFilterPresenter.GetFreqResponse(&complex_003Cdouble_003E2, PixXToX(num6));
									// IL cpblk instruction
									System.Runtime.CompilerServices.Unsafe.CopyBlock(ref complex_003Cdouble_003E, freqResponse, 16);
									double num7 = global::_003CModule_003E.std_002Eabs_003Cdouble_003E(&complex_003Cdouble_003E);
									double num8 = global::_003CModule_003E.HOLM_002EMath_002EPhase_003Cdouble_003E(&complex_003Cdouble_003E);
									Point point = new Point(num6, YToPixY(num7));
									array[num6 - pixxMin] = point;
									double num9 = ((!(num7 < HidePhaseAmpLimit)) ? (num8 * 180.0 / global::_003CModule_003E.HOLM_002EMath_002E_003FA0x49785d99_002EPI) : (-1000.0));
									Point point2 = new Point(num6, phaseGraph.YToPixY(num9));
									array2[num6 - pixxMin] = point2;
									num6++;
								}
								while (num6 <= pixxMax);
							}
							if (fPlotPhase)
							{
								phaseGraph.gpen.DashStyle = (DashStyle)1;
								Color freqColor = abstractFilterPresenter.GetFreqColor();
								phaseGraph.SetDrawColor(freqColor);
								phaseGraph.SetPlotWidth(abstractFilterPresenter.FreqLineWidth);
								phaseGraph.DrawLinesInsideHideJump(array2, 0.7);
							}
							if (fPlotAmplitude)
							{
								gpen.DashStyle = dashStyleAmplitude;
								Color freqColor2 = abstractFilterPresenter.GetFreqColor();
								SetDrawColor(freqColor2);
								SetPlotWidth(abstractFilterPresenter.FreqLineWidth);
								DrawLinesInside(array);
							}
						}
						if (fPlotNextChannel && abstractFilterPresenter.HasNextChannel())
						{
							double num10 = 0.0;
							double num11 = 0.0;
							global::_003CModule_003E.std_002Ecomplex_003Cdouble_003E_002E_007Bctor_007D(&complex_003Cdouble_003E3, &num11, &num10);
							int num12 = pixxMin;
							if (num12 <= pixxMax)
							{
								do
								{
									complex_003Cdouble_003E* freqResponseNext = abstractFilterPresenter.GetFreqResponseNext(&complex_003Cdouble_003E4, PixXToX(num12));
									// IL cpblk instruction
									System.Runtime.CompilerServices.Unsafe.CopyBlock(ref complex_003Cdouble_003E3, freqResponseNext, 16);
									double num13 = global::_003CModule_003E.std_002Eabs_003Cdouble_003E(&complex_003Cdouble_003E3);
									Point point3 = new Point(num12, YToPixY(num13));
									array[num12 - pixxMin] = point3;
									num12++;
								}
								while (num12 <= pixxMax);
							}
							if (fPlotAmplitude)
							{
								gpen.DashStyle = dashStyleAmplitudeNext;
								Color freqColor3 = abstractFilterPresenter.GetFreqColor();
								SetDrawColor(freqColor3);
								SetPlotWidth(abstractFilterPresenter.FreqLineWidth);
								DrawLinesInside(array);
							}
						}
						num2++;
						num3 = System.Runtime.CompilerServices.Unsafe.As<vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 16)) - System.Runtime.CompilerServices.Unsafe.As<vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 12)) >> 2;
					}
					while (num2 < (uint)num3);
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
		BasicPresenterContainer basicPresenterContainer = measurementContainer;
		if (basicPresenterContainer == null)
		{
			return;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E obj2);
		basicPresenterContainer.GetPlotVector(&obj2);
		try
		{
			uint num14 = 0u;
			int num15 = System.Runtime.CompilerServices.Unsafe.As<vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj2, 16)) - System.Runtime.CompilerServices.Unsafe.As<vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj2, 12)) >> 2;
			if (0u < (uint)num15)
			{
				uint num16 = 0u;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out complex_003Cdouble_003E complex_003Cdouble_003E5);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out complex_003Cdouble_003E complex_003Cdouble_003E6);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj3);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out complex_003Cdouble_003E complex_003Cdouble_003E7);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out complex_003Cdouble_003E complex_003Cdouble_003E8);
				do
				{
					if (num14 >= (uint)num15)
					{
						global::_003CModule_003E._invalid_parameter_noinfo();
					}
					int* ptr2 = (int*)(int)(num14 * 4 + (uint)System.Runtime.CompilerServices.Unsafe.As<vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj2, 12)));
					BasicMeasurementPresenter basicMeasurementPresenter = measurementContainer.GetPresenters()[*ptr2];
					Measurement* measPtr = basicMeasurementPresenter.measPtr;
					double num17 = 0.0;
					double num18 = 0.0;
					global::_003CModule_003E.std_002Ecomplex_003Cdouble_003E_002E_007Bctor_007D(&complex_003Cdouble_003E5, &num18, &num17);
					double num19 = 0.0;
					double num20 = 0.0;
					global::_003CModule_003E.std_002Ecomplex_003Cdouble_003E_002E_007Bctor_007D(&complex_003Cdouble_003E6, &num20, &num19);
					if (fPlotHD)
					{
						Color foreColor2 = plotArea.ForeColor;
						sBrush.Color = foreColor2;
						uint num21 = (uint)(System.Runtime.CompilerServices.Unsafe.As<vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj2, 16)) - System.Runtime.CompilerServices.Unsafe.As<vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj2, 12)) >> 2);
						int num22 = (int)this.plotHD;
						basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* ptr3 = global::_003CModule_003E.HOLM_002EMeasure_002EDistortionIndexToString(&obj3, num22);
						string text;
						try
						{
							text = new string(global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002Ec_str(ptr3));
						}
						catch
						{
							//try-fault
							global::_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), &obj3);
							throw;
						}
						global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D(&obj3);
						bitmapGraphics.DrawString(text + ":", boldFont, (Brush)(object)sBrush, (float)(uint)(plotArea.Width + (-40 - (int)(num21 * 25))), (float)(pixyMax + 35));
						PlotHD plotHD = this.plotHD;
						string text2;
						if (global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementCore_002EGetHDSize((MeasurementCore*)measPtr) > (int)plotHD)
						{
							int num23 = *(int*)((byte*)measPtr + 368);
							double num24 = *(int*)((byte*)measPtr + 64);
							double num25 = (double)num23 * 2.0 / num24;
							text2 = "OK";
							int num26 = plotHD switch
							{
								(PlotHD)0 => XToPixX(num24 * 0.5 / 3.0), 
								(PlotHD)1 => XToPixX(num24 * 0.5), 
								_ => XToPixX(num24 * 0.5 / (double)plotHD), 
							};
							int num27 = pixxMax;
							int num28 = ((num26 >= num27) ? num27 : num26);
							double* ptr4 = global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementCore_002EGetA((MeasurementCore*)measPtr);
							float* ptr5 = global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementCore_002EGetHDSmooth((MeasurementCore*)measPtr, (int)this.plotHD);
							int num29 = pixxMin;
							if (num29 <= num28)
							{
								int num30 = num29 + 1;
								do
								{
									double num31 = PixXToX(num29);
									double num32 = PixXToX(num30);
									int num33 = global::_003CModule_003E.HOLM_002EMath_002EToIntFloor(num31 * num25);
									int num34 = global::_003CModule_003E.HOLM_002EMath_002EToIntFloor(num32 * num25);
									if (num33 >= num23)
									{
										num33 = num23 - 1;
										num31 = (double)num33 / num25;
									}
									if (num34 >= num23)
									{
										num34 = num23 - 1;
									}
									double num39;
									if (num34 > num33 + 1)
									{
										double num35 = 0.0;
										int num36 = num33;
										if (num33 < num34)
										{
											Measurement* ptr6 = (Measurement*)((byte*)measPtr + 32);
											Measurement* ptr7 = (Measurement*)((byte*)measPtr + 52);
											do
											{
												int num37 = global::_003CModule_003E.HOLM_002EMath_002EToIntRound((double)num36 / num25 * *(double*)ptr6);
												int num38 = *(int*)ptr7;
												if (num37 > num38)
												{
													num37 = num38;
												}
												num35 = ((!(*(double*)(num37 * 8 + (byte*)ptr4) > HideHDAmpLimit)) ? (-100000.0) : ((double)(*(float*)(num36 * 4 + (byte*)ptr5)) + num35));
												num36++;
											}
											while (num36 < num34);
										}
										num39 = num35 / (double)(num34 - num33);
									}
									else
									{
										int num40 = global::_003CModule_003E.HOLM_002EMath_002EToIntRound(*(double*)((byte*)measPtr + 32) * num31);
										int num38 = *(int*)((byte*)measPtr + 52);
										if (num40 > num38)
										{
											num40 = num38;
										}
										num39 = ((!(*(double*)(num40 * 8 + (byte*)ptr4) > HideHDAmpLimit)) ? (-100000.0) : ((double)global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementCore_002EGetHDSmoothInterpolated((MeasurementCore*)measPtr, (int)this.plotHD, (float)num31)));
									}
									Point point4 = new Point(num29, YToPixY(num39));
									array[num29 - pixxMin] = point4;
									num29++;
									num30++;
								}
								while (num29 <= num28);
							}
							SetDrawColor(basicMeasurementPresenter.AmpColor);
							gpen.DashStyle = (DashStyle)0;
							SetPlotWidth(basicMeasurementPresenter.FreqLineWidth);
							DrawLinesInsideOnly(array, num26 - pixxMin);
						}
						else
						{
							text2 = "NA";
						}
						if (num14 != 0)
						{
							text2 += ",";
						}
						sBrush.Color = basicMeasurementPresenter.TargetAmpColor;
						bitmapGraphics.DrawString(text2, boldFont, (Brush)(object)sBrush, (float)(uint)(plotArea.Width + (-25 - (int)num16)), (float)(pixyMax + 35));
					}
					if (fPlotWindowFrequency && global::_003CModule_003E.HOLM_002EMeasure_002EConfigCtrl_002EGetEnabled((ConfigCtrl*)((byte*)measPtr + 136), (EnabledEnum)1))
					{
						int num41 = XToPixX(global::_003CModule_003E.HOLM_002EMeasure_002EMeasurement_002EFrequencyValidityWithWindow(measPtr));
						if (num41 > pixxMin && num41 < pixxMax)
						{
							sBrush.Color = basicMeasurementPresenter.AmpColor;
							Point[] array3 = new Point[3];
							Point point5 = new Point(num41 - 10, pixyMax - 5);
							array3[0] = point5;
							Point point6 = new Point(num41, pixyMax);
							array3[1] = point6;
							Point point7 = new Point(num41 - 10, pixyMax + 5);
							array3[2] = point7;
							bitmapGraphics.FillPolygon((Brush)(object)sBrush, array3);
							float width = bitmapGraphics.MeasureString("Gating", boldFont).Width;
							bitmapGraphics.DrawString("Gating", boldFont, (Brush)(object)sBrush, (float)(num41 - 13), (float)((double)(float)pixyMax - (double)width - 5.0), stringFormatVertical);
						}
					}
					if (fPlotNextChannel)
					{
						uint num42 = *(uint*)((byte*)measPtr + 416);
						if (num42 != 0 && *(bool*)(int)(num42 + 28))
						{
							double* ptr8 = global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementCore_002EGetA((MeasurementCore*)(int)num42);
							int num43 = *(int*)(*(int*)((byte*)measPtr + 416) + 52);
							int num44 = pixxMin;
							if (num44 <= pixxMax)
							{
								do
								{
									double num45 = num44;
									int num46 = global::_003CModule_003E.HOLM_002EMath_002EToIntFloor(PixXToX(num45 - 0.5) * *(double*)(*(int*)((byte*)measPtr + 416) + 32));
									int num47 = global::_003CModule_003E.HOLM_002EMath_002EToIntFloor(PixXToX(num45 + 0.5) * *(double*)(*(int*)((byte*)measPtr + 416) + 32));
									if (num46 < 0)
									{
										num46 = 0;
									}
									else if (num46 >= num43)
									{
										num46 = num43 - 1;
									}
									if (num47 < 0)
									{
										num47 = 0;
									}
									else if (num47 >= num43)
									{
										num47 = num43 - 1;
									}
									double num39;
									if (num47 > num46 + 1)
									{
										double num35 = 0.0;
										int num48 = num46;
										if (num46 < num47)
										{
											do
											{
												num35 = *(double*)(num48 * 8 + (byte*)ptr8) + num35;
												num48++;
											}
											while (num48 < num47);
										}
										num39 = num35 / (double)(num47 - num46);
										global::_003CModule_003E.HOLM_002EMath_002EPhase_003Cdouble_003E(&complex_003Cdouble_003E5);
									}
									else
									{
										int num49 = *(int*)((byte*)measPtr + 416);
										double num50 = PixXToX(num45) * *(double*)(num49 + 32);
										complex_003Cdouble_003E* ptr9 = global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementCore_002EGetFInterpolatedK((MeasurementCore*)num49, &complex_003Cdouble_003E7, num50);
										// IL cpblk instruction
										System.Runtime.CompilerServices.Unsafe.CopyBlock(ref complex_003Cdouble_003E6, ptr9, 16);
										num39 = global::_003CModule_003E.std_002Eabs_003Cdouble_003E(&complex_003Cdouble_003E6);
									}
									Point point8 = new Point(num44, YToPixY(num39));
									array[num44 - pixxMin] = point8;
									SetDrawColor(basicMeasurementPresenter.AmpColor);
									gpen.DashStyle = dashStyleAmplitudeNext;
									SetPlotWidth(basicMeasurementPresenter.FreqLineWidth);
									num44++;
								}
								while (num44 <= pixxMax);
							}
							DrawLinesInside(array);
						}
					}
					if (fPlotMainChannel)
					{
						double* ptr10 = global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementCore_002EGetA((MeasurementCore*)measPtr);
						complex_003Cdouble_003E* ptr11 = global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementCore_002EGetF((MeasurementCore*)measPtr);
						int num51 = *(int*)((byte*)measPtr + 52);
						int num52 = pixxMin;
						if (num52 <= pixxMax)
						{
							do
							{
								double num53 = num52;
								int num54 = global::_003CModule_003E.HOLM_002EMath_002EToIntFloor(PixXToX(num53 - 0.5) * *(double*)((byte*)measPtr + 32));
								int num55 = global::_003CModule_003E.HOLM_002EMath_002EToIntFloor(PixXToX(num53 + 0.5) * *(double*)((byte*)measPtr + 32));
								if (num54 < 0)
								{
									num54 = 0;
								}
								else if (num54 >= num51)
								{
									num54 = num51 - 1;
								}
								if (num55 < 0)
								{
									num55 = 0;
								}
								else if (num55 >= num51)
								{
									num55 = num51 - 1;
								}
								double num39;
								double num58;
								if (num55 > num54 + 1)
								{
									double num35 = 0.0;
									double num56 = 0.0;
									global::_003CModule_003E.std_002Ecomplex_003Cdouble_003E_002E_003D(&complex_003Cdouble_003E5, &num56);
									int num57 = num54;
									if (num54 < num55)
									{
										complex_003Cdouble_003E* ptr12 = (complex_003Cdouble_003E*)(num54 * 16 + (byte*)ptr11);
										do
										{
											num35 = *(double*)(num57 * 8 + (byte*)ptr10) + num35;
											global::_003CModule_003E.std_002Ecomplex_003Cdouble_003E_002E_002B_003D(&complex_003Cdouble_003E5, ptr12);
											num57++;
											ptr12 = (complex_003Cdouble_003E*)((byte*)ptr12 + 16);
										}
										while (num57 < num55);
									}
									num39 = num35 / (double)(num55 - num54);
									num58 = global::_003CModule_003E.HOLM_002EMath_002EPhase_003Cdouble_003E(&complex_003Cdouble_003E5);
								}
								else
								{
									double num50 = PixXToX(num53) * *(double*)((byte*)measPtr + 32);
									complex_003Cdouble_003E* ptr13 = global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementCore_002EGetFInterpolatedK((MeasurementCore*)measPtr, &complex_003Cdouble_003E8, num50);
									// IL cpblk instruction
									System.Runtime.CompilerServices.Unsafe.CopyBlock(ref complex_003Cdouble_003E6, ptr13, 16);
									num39 = global::_003CModule_003E.std_002Eabs_003Cdouble_003E(&complex_003Cdouble_003E6);
									num58 = global::_003CModule_003E.HOLM_002EMath_002EPhase_003Cdouble_003E(&complex_003Cdouble_003E6);
								}
								Point point9 = new Point(num52, YToPixY(num39));
								array[num52 - pixxMin] = point9;
								double num59 = ((!(num39 < HidePhaseAmpLimit)) ? (num58 * global::_003CModule_003E.HOLM_002EMath_002E_003FA0x49785d99_002ERadToDeg) : ((double)(global::_003CModule_003E.HOLM_002EMath_002ESign_003Cdouble_003E(num58) * 1000)));
								Point point10 = new Point(num52, phaseGraph.YToPixY(num59));
								array2[num52 - pixxMin] = point10;
								num52++;
							}
							while (num52 <= pixxMax);
						}
						if (fPlotPhase)
						{
							phaseGraph.gpen.DashStyle = (DashStyle)1;
							phaseGraph.SetDrawColor(basicMeasurementPresenter.AmpColor);
							phaseGraph.SetPlotWidth(basicMeasurementPresenter.PhaseLineWidth);
							phaseGraph.DrawLinesInsideHideJump(array2, 0.7);
						}
						if (fPlotAmplitude)
						{
							gpen.DashStyle = dashStyleAmplitude;
							SetDrawColor(basicMeasurementPresenter.AmpColor);
							SetPlotWidth(basicMeasurementPresenter.FreqLineWidth);
							DrawLinesInside(array);
						}
					}
					num14++;
					num16 += 25;
					num15 = System.Runtime.CompilerServices.Unsafe.As<vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj2, 16)) - System.Runtime.CompilerServices.Unsafe.As<vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj2, 12)) >> 2;
				}
				while (num14 < (uint)num15);
			}
		}
		catch
		{
			//try-fault
			global::_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E*, void>)(&global::_003CModule_003E.std_002Evector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E_002E_007Bdtor_007D), &obj2);
			throw;
		}
		global::_003CModule_003E.std_002Evector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E_002E_007Bdtor_007D(&obj2);
	}

	public override void ChildMouseMove(MouseEventArgs e)
	{
		string text = "; ";
		if (statusLabel == null)
		{
			return;
		}
		double num = PixXToX(e.X);
		double num2 = PixYToY(e.Y);
		double num3 = num;
		string text2 = num3.ToString("F0") + "Hz";
		string text3;
		if (yAxisMode == (AxisMode)2)
		{
			text3 = global::_003CModule_003E.HOLM_002EMath_002EAmplitudeToDB_003Cdouble_003E(num2).ToString("F1") + " dB";
		}
		else
		{
			double num4 = num2;
			text3 = num4.ToString("F4");
		}
		if (phaseGraph != null && fPlotPhase)
		{
			double num5 = phaseGraph.PixYToY(e.Y);
			if (num5 < -180.0)
			{
				num5 = -180.0;
			}
			else if (num5 > 180.0)
			{
				num5 = 180.0;
			}
			double num6 = num5 / -180.0 / num * 0.5 * 1000.0;
			double num7 = num5;
			string text4 = string.Concat(num7.ToString("F0") + " Deg", text);
			ImpulseGraph impulseGraph = impulseGraphFriend;
			if (impulseGraph != null)
			{
				switch (impulseGraph.GetMode())
				{
				default:
				{
					double num9 = num6;
					text4 = string.Concat(text4, num9.ToString("F2") + "ms");
					break;
				}
				case (ImpulseGraphMode)2:
					text4 = string.Concat(text4, (num6 * 34.4).ToString("F1") + "cm");
					break;
				case (ImpulseGraphMode)1:
				{
					double num8 = num6;
					text4 = string.Concat(text4, num8.ToString("F2") + "ms");
					break;
				}
				case (ImpulseGraphMode)0:
					text4 = string.Concat(text4, (num6 * 44.1).ToString("F1") + " samples");
					break;
				}
			}
			else
			{
				double num10 = num6;
				text4 = string.Concat(text4, num10.ToString("F2") + "ms");
			}
			if (!fPlotAmplitude && !fPlotTarget && !fPlotHD)
			{
				statusLabel.Text = string.Concat(string.Concat(string.Concat("(" + text2, text), text4), ")");
			}
			else
			{
				statusLabel.Text = string.Concat(string.Concat(string.Concat(string.Concat(string.Concat("(" + text2, text), text3), text), text4), ")");
			}
		}
		else if (fPlotAmplitude || fPlotTarget || fPlotHD)
		{
			statusLabel.Text = string.Concat(string.Concat(string.Concat("(" + text2, text), text3), ")");
		}
	}

	public override void ChildMouseLeave()
	{
		statusLabel.Text = "";
	}

	public void SetGridWith2ndAxis([MarshalAs(UnmanagedType.U1)] bool flag)
	{
		if (flag)
		{
			SetBorders(borderXLeft, borderXRight + 20, borderYTop, borderYBot);
		}
		else
		{
			SetBorders(borderXLeft, borderXRight - 20, borderYTop, borderYBot);
		}
	}

	public void SaveBitmapDialog([MarshalAs(UnmanagedType.U1)] bool showlegends)
	{
		if (showlegends)
		{
			PrintLegends();
		}
		SaveBitmapDialog();
	}

	public void SaveBitmapDialogWithImpulseFriend([MarshalAs(UnmanagedType.U1)] bool showlegends)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Invalid comparison between Unknown and I4
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected O, but got Unknown
		if (impulseGraphFriend == null)
		{
			return;
		}
		SaveFileDialog val = new SaveFileDialog();
		((FileDialog)val).Filter = string.Concat(string.Concat("Compressed Bitmap (*.png)|*.png|" + "Compressed Bitmap (*.jpg)|*.jpg|", "Bitmap (*.bmp)|*.bmp|"), "All Files (*.*)|*.*");
		((FileDialog)val).Title = "Save graphs as one image";
		if ((int)((CommonDialog)val).ShowDialog() == 1)
		{
			int height = ((Image)bitmap).Height;
			int num = ((Image)impulseGraphFriend.bitmap).Height + height;
			Bitmap val2 = new Bitmap(((Image)bitmap).Width, num + 2);
			Graphics val3 = Graphics.FromImage((Image)(object)val2);
			Color foreColor = plotArea.ForeColor;
			val3.Clear(foreColor);
			if (showlegends)
			{
				PrintLegends();
			}
			Point point = new Point(0, 0);
			val3.DrawImageUnscaled((Image)(object)bitmap, point);
			Point point2 = new Point(0, height + 2);
			val3.DrawImageUnscaled((Image)(object)impulseGraphFriend.bitmap, point2);
			global::_003CModule_003E.HOLM_002EGraphics_002ESaveBitmap(val2, ((FileDialog)val).FileName);
			((IDisposable)val3)?.Dispose();
			((IDisposable)val2)?.Dispose();
		}
		((IDisposable)val)?.Dispose();
	}

	public void CopyToClipBoardWithImpulseFriend([MarshalAs(UnmanagedType.U1)] bool showlegends)
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected O, but got Unknown
		int height = ((Image)bitmap).Height;
		int num = ((Image)impulseGraphFriend.bitmap).Height + height;
		Bitmap val = new Bitmap(((Image)bitmap).Width, num + 2);
		Graphics val2 = Graphics.FromImage((Image)(object)val);
		Color foreColor = plotArea.ForeColor;
		val2.Clear(foreColor);
		if (showlegends)
		{
			PrintLegends();
		}
		Point point = new Point(0, 0);
		val2.DrawImageUnscaled((Image)(object)bitmap, point);
		Point point2 = new Point(0, height + 2);
		val2.DrawImageUnscaled((Image)(object)impulseGraphFriend.bitmap, point2);
		Clipboard.SetImage((Image)(object)val);
		((IDisposable)val2)?.Dispose();
		((IDisposable)val)?.Dispose();
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

	private unsafe void Action_YAxisMin(object sender, EventArgs e)
	{
		double num = Math.Floor(freqGraph.minUpDown.Value / 10.0) * 10.0;
		*(double*)((byte*)ranges + 16) = global::_003CModule_003E.HOLM_002EMath_002EDBToAmplitude_003Cdouble_003E(num);
		CalculateScaleFactors();
		UpdatePlotArea();
	}

	private void Initialize()
	{
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		SetXTics(20);
		SetYTics(20);
		SetBorders(borderXLeft, borderXRight + 20, borderYTop, borderYBot);
		HidePhaseAmpLimit = global::_003CModule_003E.HOLM_002EMath_002EDBToAmplitude_003Cdouble_003E(-30.0);
		HideHDAmpLimit = global::_003CModule_003E.HOLM_002EMath_002EDBToAmplitude_003Cdouble_003E(-10.0);
		fPlotPhase = true;
		fPlotTarget = false;
		fPlotAmplitude = true;
		fPlotNextChannel = true;
		fPlotMainChannel = true;
		fPlotHD = false;
		fPlotWindowFrequency = true;
		plotHD = (PlotHD)0;
		impulseGraphFriend = null;
		Graph graph = phaseGraph;
		graph.bitmapGraphics = bitmapGraphics;
		HostParasite(graph, fZoomY: true);
		phaseGraph.SetBorders(borderXLeft, borderXRight, borderYTop, borderYBot);
		measurementContainer = null;
		filterContainer = null;
		dashStyleAmplitude = (DashStyle)0;
		dashStyleAmplitudeNext = (DashStyle)1;
		freqGraph.minUpDown.ValueChangedByUpDown += Action_YAxisMin;
		SetStatusLabel(freqGraph.coordsLabel);
	}

	protected override void Dispose([MarshalAs(UnmanagedType.U1)] bool P_0)
	{
		if (P_0)
		{
			try
			{
				_007EFreqGraph();
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
