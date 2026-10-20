using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using std;

namespace HOLM.Graphics;

internal class Graph : IDisposable
{
	public Pen gpen;

	public SolidBrush sBrush;

	public Control plotArea;

	public Graphics plotareaGraphics;

	public Graphics bitmapGraphics;

	public Bitmap bitmap;

	public Font boldFont;

	public StringFormat stringFormatCenter;

	public StringFormat stringFormatVertical;

	public bool fXAxisUseDPrefix;

	protected bool fParasite;

	protected bool fParasiteZoomY;

	protected Graph parasite;

	protected double yAxisModedBMirror0DB;

	protected int borderXLeft;

	protected int borderXRight;

	protected int borderYTop;

	protected int borderYBot;

	protected int plot_height;

	protected int plot_witdh;

	protected int xaxisnumberspace;

	protected bool bitmap_constructed;

	protected AxisMode xAxisMode;

	protected AxisMode yAxisMode;

	protected int current_pixx;

	protected int current_pixy;

	protected int xtrans;

	protected int ytrans;

	protected int pixxMin;

	protected int pixyMin;

	protected int pixxMax;

	protected int pixyMax;

	protected unsafe Ranges* ranges;

	protected double plot_xmin;

	protected double plot_xmax;

	protected double plot_ymin;

	protected double plot_ymax;

	protected int nof_xtics;

	protected int nof_ytics;

	protected double scalex;

	protected double scaley;

	public Graph(Control P_0, double P_1, double P_2, double P_3, double P_4)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected O, but got Unknown
		bitmap = new Bitmap(P_0.Width, P_0.Height, (PixelFormat)137224);
		bitmap_constructed = true;
		InitializeCommon(P_0, P_1, P_2, P_3, P_4);
	}

	public Graph(Control P_0, Bitmap P_1, double P_2, double P_3, double P_4, double P_5)
	{
		bitmap = P_1;
		bitmap_constructed = false;
		InitializeCommon(P_0, P_2, P_3, P_4, P_5);
	}

	public Graph(Control P_0)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected O, but got Unknown
		bitmap = new Bitmap(P_0.Width, P_0.Height, (PixelFormat)137224);
		bitmap_constructed = true;
		InitializeCommon(P_0, 0.0, 10.0, 0.0, 10.0);
	}

	private unsafe void _007EGraph()
	{
		((IDisposable)plotareaGraphics)?.Dispose();
		((IDisposable)bitmapGraphics)?.Dispose();
		((IDisposable)gpen)?.Dispose();
		((IDisposable)sBrush)?.Dispose();
		Ranges* ptr = ranges;
		if (ptr != null)
		{
			global::_003CModule_003E.HOLM_002EGraphics_002ERanges_002E_007Bdtor_007D(ptr);
			global::_003CModule_003E.delete(ptr);
		}
		((IDisposable)boldFont)?.Dispose();
		((IDisposable)stringFormatCenter)?.Dispose();
		((IDisposable)stringFormatVertical)?.Dispose();
		if (bitmap_constructed)
		{
			((IDisposable)bitmap)?.Dispose();
		}
	}

	public unsafe void SetPlotRange(double xMin, double xMax, double yMin, double yMax)
	{
		Ranges* ptr = ranges;
		*(double*)ptr = xMin;
		*(double*)((byte*)ptr + 8) = xMax;
		*(double*)((byte*)ptr + 16) = yMin;
		*(double*)((byte*)ptr + 24) = yMax;
		CalculateScaleFactors();
	}

	public void SetBorders(int XLeft, int XRight, int YTop, int YBot)
	{
		borderXLeft = XLeft;
		borderXRight = XRight;
		borderYTop = YTop;
		borderYBot = YBot;
		CalculateScaleFactors();
	}

	public void DrawLineTo(double P_0, double P_1)
	{
		int num = XToPixX(P_0);
		int num2 = YToPixY(P_1);
		int num3 = pixyMax;
		if (num2 > num3)
		{
			num2 = num3;
		}
		if (num2 <= num3)
		{
			int num4 = current_pixy;
			if (num4 <= num3)
			{
				bitmapGraphics.DrawLine(gpen, current_pixx, num4, num, num2);
			}
		}
		current_pixx = num;
		current_pixy = num2;
	}

	public void DrawLine(double x1, double y1, double x2, double y2)
	{
		bitmapGraphics.DrawLine(gpen, XToPixX(x1), YToPixY(y1), XToPixX(x2), YToPixY(y2));
	}

	public void DrawLineVertical(double x)
	{
		int num = XToPixX(x);
		bitmapGraphics.DrawLine(gpen, num, pixyMin, num, pixyMax);
	}

	public void DrawLinesInside(Point[] points)
	{
		int num = points.Length;
		Point[] array = new Point[num];
		int num2 = 0;
		int num3 = 0;
		if (0 >= num)
		{
			return;
		}
		do
		{
			if (pixyMin <= points[num3].Y && points[num3].Y <= pixyMax)
			{
				ref Point reference = ref array[num2];
				reference = points[num3];
				num2++;
			}
			else if (num2 > 1)
			{
				int num4 = pixyMin;
				if (num4 > points[num3].Y)
				{
					Point point = new Point(points[num3].X, num4);
					array[num2] = point;
				}
				int num5 = pixyMax;
				if (num5 < points[num3].Y)
				{
					Point point2 = new Point(points[num3].X, num5);
					array[num2] = point2;
				}
				Array.Resize(ref array, num2 + 1);
				bitmapGraphics.DrawLines(gpen, array);
				num2 = 0;
				Array.Resize(ref array, (int)((nint)points.LongLength - num3));
			}
			else
			{
				int num4 = pixyMin;
				if (num4 > points[num3].Y)
				{
					Point point3 = new Point(points[num3].X, num4);
					array[0] = point3;
				}
				int num5 = pixyMax;
				if (num5 < points[num3].Y)
				{
					Point point4 = new Point(points[num3].X, num5);
					array[0] = point4;
				}
				num2 = 1;
			}
			num3++;
		}
		while (num3 < (nint)points.LongLength);
		if (num2 > 1)
		{
			Array.Resize(ref array, num2);
			bitmapGraphics.DrawLines(gpen, array);
		}
	}

	public void DrawLinesInsideOnly(Point[] points, int pointsToPlot)
	{
		int num = points.Length;
		Point[] array = new Point[num];
		int num2 = 0;
		int num3 = num;
		int num4 = (num3 >= pointsToPlot ? ref pointsToPlot : ref num3);
		int num5 = 0;
		if (0 >= num4)
		{
			return;
		}
		do
		{
			if (pixyMin <= points[num5].Y && points[num5].Y <= pixyMax)
			{
				ref Point reference = ref array[num2];
				reference = points[num5];
				num2++;
			}
			else
			{
				if (num2 > 1)
				{
					Array.Resize(ref array, num2);
					bitmapGraphics.DrawLines(gpen, array);
					Array.Resize(ref array, (int)((nint)points.LongLength - num5));
				}
				num2 = 0;
			}
			num5++;
		}
		while (num5 < num4);
		if (num2 > 1)
		{
			Array.Resize(ref array, num2);
			bitmapGraphics.DrawLines(gpen, array);
		}
	}

	public void DrawLinesInsideHideJump(Point[] points, double dHideLimit)
	{
		Point[] array = null;
		int num = ((pixyMin <= points[0].Y && points[0].Y <= pixyMax) ? 1 : 0);
		bool flag = (byte)num != 0;
		int num2 = (int)((double)(pixyMax - pixyMin) * dHideLimit);
		int num3 = points.Length;
		array = new Point[num3];
		int num4 = 0;
		int num5 = 1;
		if (1 >= num3)
		{
			return;
		}
		do
		{
			bool flag2 = flag;
			int num6 = ((pixyMin <= points[num5].Y && points[num5].Y <= pixyMax) ? 1 : 0);
			flag = (byte)num6 != 0;
			if (flag && flag2 && Math.Abs(points[num5 - 1].Y - points[num5].Y) < num2)
			{
				ref Point reference = ref array[num4];
				reference = points[num5];
				num4++;
			}
			else if (num4 > 1)
			{
				Array.Resize(ref array, num4);
				bitmapGraphics.DrawLines(gpen, array);
				num4 = 0;
				Array.Resize(ref array, (int)((nint)points.LongLength - num5));
			}
			else
			{
				num4 = 0;
			}
			num5++;
		}
		while (num5 < (nint)points.LongLength);
		if (num4 > 1)
		{
			Array.Resize(ref array, num4);
			bitmapGraphics.DrawLines(gpen, array);
		}
	}

	public void DrawCircle(double __unnamed000, double __unnamed001, int pixels)
	{
		int num = pixels * 2;
		bitmapGraphics.DrawEllipse(gpen, XToPixX(__unnamed000) - pixels, YToPixY(__unnamed001) - pixels, num, num);
	}

	public void DrawCirclePixX(int __unnamed000, double __unnamed001, int pixels)
	{
		int num = pixels * 2;
		bitmapGraphics.DrawEllipse(gpen, __unnamed000 - pixels, YToPixY(__unnamed001) - pixels, num, num);
	}

	public void GoToPoint(double P_0, double P_1)
	{
		current_pixx = XToPixX(P_0);
		int num = YToPixY(P_1);
		int num2 = pixyMax;
		if (num > num2)
		{
			current_pixy = num2;
		}
		else
		{
			current_pixy = num;
		}
	}

	public void GoToPixXPixY(int P_0, int P_1)
	{
		int num = pixyMax;
		if (P_1 > num)
		{
			current_pixy = num;
		}
		else
		{
			current_pixy = P_1;
		}
		current_pixx = P_0;
	}

	public void DrawPixXPixYLineTo(int P_0, int P_1)
	{
		int num = pixyMax;
		if (P_1 > num)
		{
			P_1 = num;
		}
		if (P_1 != num || current_pixy != num)
		{
			bitmapGraphics.DrawLine(gpen, current_pixx, current_pixy, P_0, P_1);
		}
		current_pixx = P_0;
		current_pixy = P_1;
	}

	public void DrawPixXPixYLine(int P_0, int P_1, int P_2, int P_3)
	{
		int num = pixyMax;
		if (P_1 > num)
		{
			P_1 = num;
		}
		if (P_3 > num)
		{
			P_3 = num;
		}
		if (P_1 != num || P_3 != num)
		{
			bitmapGraphics.DrawLine(gpen, P_0, P_1, P_2, P_3);
		}
	}

	public void SetDrawColor(Color P_0)
	{
		gpen.Color = P_0;
		sBrush.Color = P_0;
	}

	public void SetPlotWidth(int P_0)
	{
		gpen.Width = P_0;
	}

	public double PixXToX(double dpixel)
	{
		if (xAxisMode == (AxisMode)1)
		{
			return Math.Pow(10.0, (dpixel - (double)xtrans - (double)borderXLeft) / scalex);
		}
		return (dpixel - (double)xtrans - (double)borderXLeft) / scalex;
	}

	public double PixYToY(int P_0)
	{
		double num = (double)(plot_height - P_0 - ytrans + borderYTop) / scaley;
		switch (yAxisMode)
		{
		default:
			return num;
		case (AxisMode)3:
			if (num >= 0.0)
			{
				return global::_003CModule_003E.HOLM_002EMath_002EDBToAmplitude_003Cdouble_003E(yAxisModedBMirror0DB + num);
			}
			return 0.0 - global::_003CModule_003E.HOLM_002EMath_002EDBToAmplitude_003Cdouble_003E(yAxisModedBMirror0DB - num);
		case (AxisMode)2:
			return global::_003CModule_003E.HOLM_002EMath_002EDBToAmplitude_003Cdouble_003E(num);
		case (AxisMode)1:
			return Math.Pow(10.0, num);
		}
	}

	public void DrawPixXLineTo(int P_0, double P_1)
	{
		int num = YToPixY(P_1);
		int num2 = pixyMax;
		if (num > num2)
		{
			num = num2;
		}
		if (num != num2 || current_pixy != num2)
		{
			bitmapGraphics.DrawLine(gpen, current_pixx, current_pixy, P_0, num);
		}
		current_pixx = P_0;
		current_pixy = num;
	}

	public unsafe void DrawPixXTap(int P_0, double P_1)
	{
		int num = YToPixY(P_1);
		int num2 = pixyMax;
		if (num > num2)
		{
			num = num2;
		}
		Ranges* ptr = (Ranges*)((byte*)ranges + 16);
		if (*(double*)ptr < 0.0)
		{
			bitmapGraphics.DrawLine(gpen, P_0, YToPixY(0.0), P_0, num);
			return;
		}
		double num3 = *(double*)ptr;
		bitmapGraphics.DrawLine(gpen, P_0, YToPixY(num3), P_0, num);
	}

	public int GetPlotWidth()
	{
		return plot_witdh;
	}

	public int GetPlotHeight()
	{
		return plot_height;
	}

	public void ResizePlotArea()
	{
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		if (plotArea.Width != 0 && plotArea.Height != 0)
		{
			if (bitmap_constructed)
			{
				((IDisposable)bitmap)?.Dispose();
				bitmap = new Bitmap(plotArea.Width, plotArea.Height, (PixelFormat)137224);
			}
			plotareaGraphics = plotArea.CreateGraphics();
			bitmapGraphics = Graphics.FromImage((Image)(object)bitmap);
			Color backColor = plotArea.BackColor;
			bitmapGraphics.Clear(backColor);
			CalculateScaleFactors();
		}
	}

	public void SetYAxisMode(AxisMode axisMode)
	{
		yAxisMode = axisMode;
		CalculateScaleFactors();
	}

	public void SetXAxisMode(AxisMode axisMode)
	{
		xAxisMode = axisMode;
		CalculateScaleFactors();
	}

	public void DrawAxis([MarshalAs(UnmanagedType.U1)] bool fDrawArrows, [MarshalAs(UnmanagedType.U1)] bool fDrawGrid)
	{
		Color foreColor = plotArea.ForeColor;
		gpen.Color = foreColor;
		sBrush.Color = foreColor;
		gpen.Width = 2f;
		gpen.DashStyle = (DashStyle)0;
		int num = borderXLeft;
		bitmapGraphics.DrawLine(gpen, num, pixyMax, num, pixyMin - 5);
		if (fDrawArrows)
		{
			draw_uparrow(borderXLeft, pixyMin - 5);
		}
		int num2 = pixyMax;
		bitmapGraphics.DrawLine(gpen, borderXLeft, num2, pixxMax + 15, num2);
		if (fDrawArrows)
		{
			draw_rightarrow(pixxMax + 15, pixyMax);
		}
		if (fDrawGrid)
		{
			gpen.Width = 1f;
			DrawXGrid(1.0);
			DrawYGrid(fLeftSide: true);
		}
	}

	public void DrawAxis([MarshalAs(UnmanagedType.U1)] bool fDrawArrows)
	{
		DrawAxis(fDrawArrows, fDrawGrid: true);
	}

	public unsafe void DrawXGrid(double factor)
	{
		gpen.DashStyle = (DashStyle)1;
		if (xAxisMode == (AxisMode)1)
		{
			int num = (pixxMax - pixxMin) / nof_xtics;
			if (num < 25)
			{
				num = 25;
			}
			gpen.DashStyle = (DashStyle)1;
			double d = *(double*)((byte*)ranges + 8);
			int num2 = global::_003CModule_003E.HOLM_002EMath_002EToIntFloor(Math.Log10(d));
			double num3 = *(double*)ranges;
			double num4 = global::_003CModule_003E.HOLM_002EMath_002EToIntFloor(num3);
			int num5 = -1000;
			int num6 = 0;
			if (0 <= num2)
			{
				int num7 = 1;
				do
				{
					double num8 = global::_003CModule_003E.HOLM_002EMath_002EPow10(num6);
					int num9 = global::_003CModule_003E.HOLM_002EMath_002EToIntFloor(num4 / num8);
					int num10 = (num9 >= 1 ? ref num9 : ref num7);
					int num11 = 10;
					Ranges* ptr = (Ranges*)((byte*)ranges + 8);
					double num12 = *(double*)ptr;
					double num13 = *(double*)ptr;
					if (XToPixX(num12) - XToPixX(num13 - num8) >= num)
					{
						double num14 = *(double*)((byte*)ranges + 8);
						num11 = global::_003CModule_003E.HOLM_002EMath_002EToIntRound(num14 / num8) + 1;
					}
					else if (XToPixX(num8 * 11.0) - XToPixX(num8 * 10.0) > num)
					{
						do
						{
							num11 *= 10;
						}
						while (XToPixX((double)(num11 + 1) * num8) - XToPixX((double)num11 * num8) > num);
					}
					num4 = (double)num10 * num8;
					if (num10 < num11)
					{
						int num15 = num10 + 1;
						while (num4 <= *(double*)((byte*)ranges + 8))
						{
							num4 = (double)num10 * num8;
							int num16 = XToPixX(num4);
							if (num4 >= *(double*)ranges)
							{
								if (num16 - num5 >= num && (num15 % 5 != 0 || XToPixX(num8 + num4) - num16 >= num) && (num15 % 10 != 0 || XToPixX(num8 + num4) - num16 >= num) && ((num15 + 1) % 10 != 0 || XToPixX(num8 * 2.0 + num4) - num16 >= num) && ((num15 + 2) % 10 != 0 || XToPixX(num8 * 3.0 + num4) - num16 >= num) && ((num15 + 3) % 10 != 0 || XToPixX(num8 * 4.0 + num4) - num16 >= num))
								{
									DrawXGridLine(num4, num16, fDecPrefix: true);
									num5 = num16;
								}
								else
								{
									bitmapGraphics.DrawLine(gpen, num16, pixyMax + 5, num16, pixyMin);
								}
							}
							num10++;
							num15++;
							if (num10 >= num11)
							{
								break;
							}
						}
					}
					num6++;
				}
				while (num6 <= num2);
			}
		}
		else
		{
			Ranges* ptr2 = ranges;
			double num17 = (*(double*)((byte*)ptr2 + 8) - *(double*)ptr2) * factor / (double)nof_xtics;
			if (XToPixX(num17 / factor) < 30)
			{
				num17 = (PixXToX(30.0) - PixXToX(0.0)) * factor;
			}
			double num18 = global::_003CModule_003E.HOLM_002EMath_002ENegPow10(global::_003CModule_003E.HOLM_002EMath_002EToIntFloor(Math.Log10(num17)));
			double num19;
			if (num17 <= num18)
			{
				num19 = num18;
			}
			else
			{
				double num20 = num18 * 2.0;
				if (num17 <= num20)
				{
					num19 = num20;
				}
				else
				{
					double num21 = num18 * 5.0;
					num19 = ((!(num17 <= num21)) ? (num18 * 10.0) : num21);
				}
			}
			double num22 = *(double*)ranges;
			int num23 = global::_003CModule_003E.HOLM_002EMath_002EToIntFloor(num22 * factor / num19);
			double num24 = (double)num23 * num19;
			if (num24 <= *(double*)((byte*)ranges + 8) * factor)
			{
				do
				{
					int pixx = XToPixX(num24 / factor);
					DrawXGridLine(num24, pixx, fDecPrefix: true);
					num23++;
					num24 = (double)num23 * num19;
				}
				while (num24 <= *(double*)((byte*)ranges + 8) * factor);
			}
		}
		gpen.DashStyle = (DashStyle)0;
	}

	public void DrawXGrid()
	{
		DrawXGrid(1.0);
	}

	public unsafe void DrawYGrid([MarshalAs(UnmanagedType.U1)] bool fLeftSide)
	{
		if (fLeftSide)
		{
			gpen.DashStyle = (DashStyle)1;
		}
		else
		{
			gpen.DashStyle = (DashStyle)0;
		}
		switch (yAxisMode)
		{
		case (AxisMode)2:
		{
			double num21 = plot_ymax - plot_ymin;
			if (num21 < 0.01)
			{
				num21 = 0.01;
			}
			double d3 = num21 / (double)nof_ytics;
			double num22 = global::_003CModule_003E.HOLM_002EMath_002ENegPow10(global::_003CModule_003E.HOLM_002EMath_002EToIntFloor(Math.Log10(d3)));
			int num23 = global::_003CModule_003E.HOLM_002EMath_002EToIntFloor(num21 / num22);
			int num24 = nof_ytics;
			d3 = ((num23 <= num24) ? num22 : ((num23 <= num24 << 1) ? (num22 * 2.0) : ((num23 > num24 * 5) ? (num22 * 10.0) : (num22 * 5.0))));
			double num25 = Math.Floor(plot_ymin / d3) * d3;
			int num26 = -100;
			if (!(num25 <= plot_ymax + 1.0))
			{
				break;
			}
			do
			{
				int num27 = YToPixY(global::_003CModule_003E.HOLM_002EMath_002EDBToAmplitude_003Cdouble_003E(num25));
				if (Math.Abs(num26 - num27) > 10 && DrawYGridLine(num25, num27, fLeftSide))
				{
					num26 = num27;
				}
				num25 += d3;
			}
			while (num25 <= plot_ymax + 1.0);
			break;
		}
		case (AxisMode)3:
		{
			double num13 = plot_ymax - plot_ymin;
			double d2 = num13 / (double)nof_ytics;
			double num14 = global::_003CModule_003E.HOLM_002EMath_002ENegPow10(global::_003CModule_003E.HOLM_002EMath_002EToIntFloor(Math.Log10(d2)));
			int num15 = global::_003CModule_003E.HOLM_002EMath_002EToIntFloor(num13 / num14);
			int num16 = nof_ytics;
			d2 = ((num15 <= num16) ? num14 : ((num15 <= num16 << 1) ? (num14 * 2.0) : ((num15 > num16 * 5) ? (num14 * 10.0) : (num14 * 5.0))));
			double num17 = yAxisModedBMirror0DB;
			int num18 = -100;
			if (num17 <= plot_ymax + 1.0)
			{
				do
				{
					int num19 = YToPixY(global::_003CModule_003E.HOLM_002EMath_002EDBToAmplitude_003Cdouble_003E(num17));
					if (Math.Abs(num18 - num19) > 10 && DrawYGridLine(num17, num19, fLeftSide))
					{
						num18 = num19;
						num19 = YToPixY(0.0 - global::_003CModule_003E.HOLM_002EMath_002EDBToAmplitude_003Cdouble_003E(num17));
						DrawYGridLine(num17, num19, fLeftSide);
					}
					num17 += d2;
				}
				while (num17 <= plot_ymax + 1.0);
			}
			Color foreColor = plotArea.ForeColor;
			gpen.Color = foreColor;
			sBrush.Color = foreColor;
			gpen.Width = 3f;
			gpen.DashStyle = (DashStyle)0;
			int num20 = YToPixY(0.0);
			bitmapGraphics.DrawLine(gpen, borderXLeft - 10, num20, pixxMax + 15, num20);
			gpen.Width = 1f;
			break;
		}
		default:
		{
			Ranges* ptr = ranges;
			double num = *(double*)((byte*)ptr + 24) - *(double*)((byte*)ptr + 16);
			double d = num / (double)nof_ytics;
			double num2 = global::_003CModule_003E.HOLM_002EMath_002ENegPow10((int)Math.Floor(Math.Log10(d)));
			int num3 = (int)Math.Floor(num / num2);
			int num4 = nof_ytics;
			d = ((num3 <= num4) ? num2 : ((num3 <= num4 << 1) ? (num2 * 2.0) : ((num3 > num4 * 5) ? (num2 * 10.0) : (num2 * 5.0))));
			int num5 = -100;
			int num6 = YToPixY(0.0);
			Ranges* ptr2 = ranges;
			Ranges* ptr3 = (Ranges*)((byte*)ptr2 + 16);
			int num7 = ((*(double*)ptr3 < 0.0 && *(double*)((byte*)ptr2 + 24) > 0.0) ? 1 : 0);
			double num8;
			if ((byte)num7 != 0)
			{
				num8 = d;
				DrawYGridLine(0.0, num6, fLeftSide);
				while (true)
				{
					ptr2 = ranges;
					if (!(num8 <= *(double*)((byte*)ptr2 + 24)) && !(num8 <= 0.0 - *(double*)((byte*)ptr2 + 16)))
					{
						break;
					}
					int num9 = YToPixY(num8);
					double num10 = 0.0 - num8;
					int pixy = YToPixY(num10);
					if (Math.Abs(num9 - num5) > 10 && Math.Abs(num9 - num6) > 10)
					{
						uint num11 = (DrawYGridLine(num10, pixy, fLeftSide) ? 1u : 0u);
						if ((byte)((DrawYGridLine(num8, num9, fLeftSide) ? 1u : 0u) | num11) != 0)
						{
							num5 = num9;
						}
					}
					num8 += d;
				}
				break;
			}
			num8 = Math.Floor(*(double*)ptr3 / d) * d;
			if (!(num8 <= *(double*)((byte*)ptr2 + 24)))
			{
				break;
			}
			do
			{
				int num12 = YToPixY(num8);
				if (Math.Abs(num12 - num5) > 10 && DrawYGridLine(num8, num12, fLeftSide))
				{
					DrawYGridLine(num8, num12, fLeftSide);
					num5 = num12;
				}
				num8 += d;
			}
			while (num8 <= *(double*)((byte*)ranges + 24));
			break;
		}
		case (AxisMode)1:
			break;
		}
		gpen.DashStyle = (DashStyle)0;
	}

	public void DrawYGrid()
	{
		DrawYGrid(fLeftSide: true);
	}

	public void DrawYRightGrid()
	{
		DrawYGrid(fLeftSide: false);
	}

	public void DrawStringBoldPixXY(string s, int pixx, int pixy)
	{
		bitmapGraphics.DrawString(s, boldFont, (Brush)(object)sBrush, (float)pixx, (float)pixy);
	}

	public void DrawStringVertBoldPixXY(string s, int pixx, int pixy)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		StringFormat val = new StringFormat((StringFormatFlags)2);
		bitmapGraphics.DrawString(s, boldFont, (Brush)(object)sBrush, (float)pixx, (float)pixy, val);
		((IDisposable)val)?.Dispose();
	}

	public void DrawStringPixXY(string s, int pixx, int pixy)
	{
		bitmapGraphics.DrawString(s, plotArea.Font, (Brush)(object)sBrush, (float)pixx, (float)pixy);
	}

	public void PrintXLabel(string P_0)
	{
		bitmapGraphics.DrawString(P_0, plotArea.Font, (Brush)(object)sBrush, (float)(borderXLeft + plot_witdh / 2 - 50), (float)(pixyMax + 25));
	}

	public void PrintYLabel(string P_0)
	{
		bitmapGraphics.DrawString(P_0, plotArea.Font, (Brush)(object)sBrush, (float)(borderXLeft - 25), (float)(pixyMin - 25));
	}

	public void PrintTitel(string __unnamed000, int leftOffset)
	{
		int num = pixxMin;
		bitmapGraphics.DrawString(__unnamed000, boldFont, (Brush)(object)sBrush, (float)((pixxMax - num) / 2 - leftOffset + num), (float)(pixyMin - 20));
	}

	public void PrintYRightLabel(string P_0)
	{
		bitmapGraphics.DrawString(P_0, plotArea.Font, (Brush)(object)sBrush, (float)(pixxMax - 75), (float)(pixyMin - 25));
	}

	public void SaveBitmap(string filename)
	{
		global::_003CModule_003E.HOLM_002EGraphics_002ESaveBitmap(bitmap, filename);
	}

	public void CopyToClipBoard()
	{
		Clipboard.SetImage((Image)(object)bitmap);
	}

	public void PrintLegend(string text, Color color, int w, int number, int ntotal)
	{
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		gpen.Width = w;
		gpen.Color = color;
		sBrush.Color = color;
		if (ntotal > 2)
		{
			int num = plotArea.Height + (-1 - number * 11);
			int num2 = num + 6;
			bitmapGraphics.DrawLine(gpen, 5, num2, 15, num2);
			Font val = new Font(plotArea.Font.FontFamily, 7f, (FontStyle)0);
			Color foreColor = plotArea.ForeColor;
			gpen.Color = foreColor;
			sBrush.Color = foreColor;
			bitmapGraphics.DrawString(text, val, (Brush)(object)sBrush, 17f, (float)num);
			((IDisposable)val)?.Dispose();
		}
		else
		{
			int num3 = plotArea.Height + (-1 - number * 13);
			int num4 = num3 + 6;
			bitmapGraphics.DrawLine(gpen, 5, num4, 15, num4);
			Color foreColor2 = plotArea.ForeColor;
			gpen.Color = foreColor2;
			sBrush.Color = foreColor2;
			bitmapGraphics.DrawString(text, plotArea.Font, (Brush)(object)sBrush, 17f, (float)num3);
		}
	}

	public int GetPixXMin()
	{
		return pixxMin;
	}

	public int GetPixXMax()
	{
		return pixxMax;
	}

	public int GetPixYMin()
	{
		return pixyMin;
	}

	public int GetPixYMax()
	{
		return pixyMax;
	}

	public unsafe double GetXMin()
	{
		return *(double*)ranges;
	}

	public unsafe double GetXMax()
	{
		return *(double*)((byte*)ranges + 8);
	}

	public unsafe double GetYMin()
	{
		return *(double*)((byte*)ranges + 16);
	}

	public unsafe double GetYMax()
	{
		return *(double*)((byte*)ranges + 24);
	}

	public void SetXTics(int nOfTics)
	{
		nof_xtics = nOfTics;
	}

	public void SetYTics(int nOfTics)
	{
		nof_ytics = nOfTics;
	}

	public void DisplayBitmap()
	{
		plotareaGraphics.DrawImage((Image)(object)bitmap, 0, 0);
	}

	public void ClearBitmap()
	{
		Color backColor = plotArea.BackColor;
		bitmapGraphics.Clear(backColor);
	}

	public unsafe void ZoomIn(double x1, double x2)
	{
		Ranges* ptr = ranges;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Range range);
		*(double*)(&range) = x1;
		System.Runtime.CompilerServices.Unsafe.As<Range, double>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref range, 8)) = x2;
		System.Runtime.CompilerServices.Unsafe.As<Range, double>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref range, 16)) = *(double*)((byte*)ptr + 16);
		System.Runtime.CompilerServices.Unsafe.As<Range, double>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref range, 24)) = *(double*)((byte*)ptr + 24);
		global::_003CModule_003E.std_002Evector_003CHOLM_003A_003AGraphics_003A_003ARange_002Cstd_003A_003Aallocator_003CHOLM_003A_003AGraphics_003A_003ARange_003E_0020_003E_002Epush_back((vector_003CHOLM_003A_003AGraphics_003A_003ARange_002Cstd_003A_003Aallocator_003CHOLM_003A_003AGraphics_003A_003ARange_003E_0020_003E*)((byte*)ptr + 64), (Range*)ptr);
		// IL cpblk instruction
		System.Runtime.CompilerServices.Unsafe.CopyBlock(ptr, ref range, 32);
		if (fParasite)
		{
			parasite.ZoomIn(x1, x2);
		}
		CalculateScaleFactors();
	}

	public unsafe void ZoomIn(double x1, double x2, double y1, double y2)
	{
		Ranges* ptr = ranges;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Range range);
		*(double*)(&range) = x1;
		System.Runtime.CompilerServices.Unsafe.As<Range, double>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref range, 8)) = x2;
		System.Runtime.CompilerServices.Unsafe.As<Range, double>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref range, 16)) = y1;
		System.Runtime.CompilerServices.Unsafe.As<Range, double>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref range, 24)) = y2;
		global::_003CModule_003E.std_002Evector_003CHOLM_003A_003AGraphics_003A_003ARange_002Cstd_003A_003Aallocator_003CHOLM_003A_003AGraphics_003A_003ARange_003E_0020_003E_002Epush_back((vector_003CHOLM_003A_003AGraphics_003A_003ARange_002Cstd_003A_003Aallocator_003CHOLM_003A_003AGraphics_003A_003ARange_003E_0020_003E*)((byte*)ptr + 64), (Range*)ptr);
		// IL cpblk instruction
		System.Runtime.CompilerServices.Unsafe.CopyBlock(ptr, ref range, 32);
		if (fParasite)
		{
			if (fParasiteZoomY)
			{
				double y3 = parasite.PixYToY(YToPixY(y1));
				double y4 = parasite.PixYToY(YToPixY(y2));
				parasite.ZoomIn(x1, x2, y3, y4);
			}
			else
			{
				parasite.ZoomIn(x1, x2);
			}
		}
		CalculateScaleFactors();
	}

	public unsafe void SetZoomOut(double xMin, double xMax, double yMin, double yMax)
	{
		Ranges* num = ranges;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Range range);
		*(double*)(&range) = xMin;
		System.Runtime.CompilerServices.Unsafe.As<Range, double>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref range, 8)) = xMax;
		System.Runtime.CompilerServices.Unsafe.As<Range, double>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref range, 16)) = yMin;
		System.Runtime.CompilerServices.Unsafe.As<Range, double>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref range, 24)) = yMax;
		Ranges* ptr = (Ranges*)((byte*)num + 64);
		global::_003CModule_003E.std_002Evector_003CHOLM_003A_003AGraphics_003A_003ARange_002Cstd_003A_003Aallocator_003CHOLM_003A_003AGraphics_003A_003ARange_003E_0020_003E_002Eclear((vector_003CHOLM_003A_003AGraphics_003A_003ARange_002Cstd_003A_003Aallocator_003CHOLM_003A_003AGraphics_003A_003ARange_003E_0020_003E*)ptr);
		global::_003CModule_003E.std_002Evector_003CHOLM_003A_003AGraphics_003A_003ARange_002Cstd_003A_003Aallocator_003CHOLM_003A_003AGraphics_003A_003ARange_003E_0020_003E_002Epush_back((vector_003CHOLM_003A_003AGraphics_003A_003ARange_002Cstd_003A_003Aallocator_003CHOLM_003A_003AGraphics_003A_003ARange_003E_0020_003E*)ptr, &range);
	}

	public unsafe void ZoomOutToNewRange(double x1, double x2)
	{
		global::_003CModule_003E.HOLM_002EGraphics_002ERanges_002EZoomOutToNewRange(ranges, x1, x2);
		CalculateScaleFactors();
		if (fParasite)
		{
			do
			{
				this = parasite;
				global::_003CModule_003E.HOLM_002EGraphics_002ERanges_002EZoomOutToNewRange(ranges, x1, x2);
				CalculateScaleFactors();
			}
			while (fParasite);
		}
	}

	public unsafe void ZoomOutToNewRange(double x1, double x2, double y1, double y2)
	{
		Ranges* ptr = ranges;
		global::_003CModule_003E.std_002Evector_003CHOLM_003A_003AGraphics_003A_003ARange_002Cstd_003A_003Aallocator_003CHOLM_003A_003AGraphics_003A_003ARange_003E_0020_003E_002Eclear((vector_003CHOLM_003A_003AGraphics_003A_003ARange_002Cstd_003A_003Aallocator_003CHOLM_003A_003AGraphics_003A_003ARange_003E_0020_003E*)((byte*)ptr + 64));
		*(double*)ptr = x1;
		*(double*)((byte*)ptr + 8) = x2;
		*(double*)((byte*)ptr + 16) = y1;
		*(double*)((byte*)ptr + 24) = y2;
		// IL cpblk instruction
		System.Runtime.CompilerServices.Unsafe.CopyBlock((byte*)ptr + 32, ptr, 32);
		if (fParasite)
		{
			parasite.ZoomOutToNewRange(x1, x2);
		}
		CalculateScaleFactors();
	}

	[return: MarshalAs(UnmanagedType.U1)]
	public unsafe bool ZoomOut()
	{
		bool flag = global::_003CModule_003E.HOLM_002EGraphics_002ERanges_002EZoomOut(ranges);
		if (flag)
		{
			CalculateScaleFactors();
			if (fParasite)
			{
				parasite.ZoomOut();
			}
		}
		return flag;
	}

	public unsafe void ZoomAllOut()
	{
		global::_003CModule_003E.HOLM_002EGraphics_002ERanges_002EZoomAllOut(ranges);
		if (fParasite)
		{
			parasite.ZoomAllOut();
		}
		CalculateScaleFactors();
	}

	[return: MarshalAs(UnmanagedType.U1)]
	public unsafe bool ZoomedIn()
	{
		vector_003CHOLM_003A_003AGraphics_003A_003ARange_002Cstd_003A_003Aallocator_003CHOLM_003A_003AGraphics_003A_003ARange_003E_0020_003E* ptr = (vector_003CHOLM_003A_003AGraphics_003A_003ARange_002Cstd_003A_003Aallocator_003CHOLM_003A_003AGraphics_003A_003ARange_003E_0020_003E*)((byte*)ranges + 64);
		return !(((*(int*)((byte*)ptr + 16) - *(int*)((byte*)ptr + 12)) & -32) == 0);
	}

	public int XToPixX(double P_0)
	{
		if (xAxisMode == (AxisMode)1)
		{
			return global::_003CModule_003E.HOLM_002EMath_002EToIntRound(global::_003CModule_003E.HOLM_002EMath_002ELog10Safe_003Cdouble_003E(P_0) * scalex) + borderXLeft + xtrans;
		}
		return global::_003CModule_003E.HOLM_002EMath_002EToIntRound(scalex * P_0) + borderXLeft + xtrans;
	}

	public int YToPixY(double P_0)
	{
		double num;
		switch (yAxisMode)
		{
		default:
			num = P_0;
			break;
		case (AxisMode)3:
		{
			double num2 = global::_003CModule_003E.HOLM_002EMath_002EAmplitudeToDB_003Cdouble_003E(Math.Abs(P_0));
			num = ((!(num2 < yAxisModedBMirror0DB)) ? ((!(P_0 > 0.0)) ? (yAxisModedBMirror0DB - num2) : (num2 - yAxisModedBMirror0DB)) : 0.0);
			break;
		}
		case (AxisMode)2:
			num = global::_003CModule_003E.HOLM_002EMath_002EAmplitudeToDB_003Cdouble_003E(P_0);
			break;
		case (AxisMode)1:
			num = global::_003CModule_003E.HOLM_002EMath_002ELog10Safe_003Cdouble_003E(P_0);
			break;
		}
		return plot_height - global::_003CModule_003E.HOLM_002EMath_002EToIntRound(scaley * num) - ytrans + borderYTop;
	}

	public void SetAsParasite(Graph host, [MarshalAs(UnmanagedType.U1)] bool fZoomY)
	{
		bitmapGraphics = host.bitmapGraphics;
		host.parasite = this;
		host.fParasiteZoomY = fZoomY;
		host.fParasite = true;
	}

	public void HostParasite(Graph parasiteIn, [MarshalAs(UnmanagedType.U1)] bool fZoomY)
	{
		parasite = parasiteIn;
		fParasiteZoomY = fZoomY;
		fParasite = true;
	}

	public void SetYAxisModedBMirror0DB(double val)
	{
		yAxisModedBMirror0DB = val;
		if (yAxisMode == (AxisMode)3)
		{
			CalculateScaleFactors();
		}
	}

	public double GetYAxisModedBMirror0DB()
	{
		return yAxisModedBMirror0DB;
	}

	public AxisMode GetXAxisMode()
	{
		return xAxisMode;
	}

	public AxisMode GetYAxisMode()
	{
		return yAxisMode;
	}

	[return: MarshalAs(UnmanagedType.U1)]
	protected bool DrawYGridLine(double yval, int pixy, [MarshalAs(UnmanagedType.U1)] bool fLeftSide)
	{
		if (pixy <= pixyMax && pixy >= pixyMin)
		{
			if (fLeftSide)
			{
				bitmapGraphics.DrawLine(gpen, pixxMin, pixy, pixxMax, pixy);
				bitmapGraphics.DrawString(global::_003CModule_003E.HOLM_002EGraphics_002Eto_nice_String(yval), plotArea.Font, (Brush)(object)sBrush, 2f, (float)(pixy - 8));
			}
			else
			{
				int num = pixxMax;
				bitmapGraphics.DrawLine(gpen, num - 5, pixy, num + 15, pixy);
				bitmapGraphics.DrawString(global::_003CModule_003E.HOLM_002EGraphics_002Eto_nice_String(yval), plotArea.Font, (Brush)(object)sBrush, (float)(pixxMax + 18), (float)(pixy - 8));
			}
			return true;
		}
		return false;
	}

	[return: MarshalAs(UnmanagedType.U1)]
	protected bool DrawXGridLine(double xval, int pixx, [MarshalAs(UnmanagedType.U1)] bool fDecPrefix)
	{
		if (pixx <= pixxMax && pixx >= pixxMin)
		{
			string text2;
			if (fDecPrefix)
			{
				string text;
				if (Math.Abs(xval) >= 1000.0)
				{
					text = (xval / 1000.0).ToString("G") + "k";
				}
				else
				{
					double num = xval;
					text = num.ToString("G");
				}
				text2 = text;
			}
			else
			{
				double num2 = xval;
				text2 = num2.ToString("G");
			}
			float width = bitmapGraphics.MeasureString(text2, plotArea.Font).Width;
			bitmapGraphics.DrawLine(gpen, pixx, pixyMax + 5, pixx, pixyMin);
			bitmapGraphics.DrawString(text2, plotArea.Font, (Brush)(object)sBrush, (float)((double)(float)pixx - (double)width * 0.5), (float)(xaxisnumberspace + pixyMax));
			return true;
		}
		return false;
	}

	protected unsafe void InitializeCommon(Control P_0, double P_1, double P_2, double P_3, double P_4)
	{
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected O, but got Unknown
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Expected O, but got Unknown
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected O, but got Unknown
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected O, but got Unknown
		fParasite = false;
		xAxisMode = (AxisMode)0;
		yAxisMode = (AxisMode)0;
		yAxisModedBMirror0DB = -70.0;
		borderXRight = 30;
		borderXLeft = 35;
		borderYTop = 25;
		borderYBot = 50;
		xaxisnumberspace = 6;
		fXAxisUseDPrefix = false;
		plotArea = P_0;
		Color foreColor = P_0.ForeColor;
		gpen = new Pen(foreColor);
		Color foreColor2 = plotArea.ForeColor;
		sBrush = new SolidBrush(foreColor2);
		boldFont = new Font(plotArea.Font, (FontStyle)1);
		stringFormatCenter = new StringFormat();
		stringFormatVertical = new StringFormat();
		stringFormatCenter.Alignment = (StringAlignment)1;
		stringFormatVertical.FormatFlags = (StringFormatFlags)2;
		plotareaGraphics = plotArea.CreateGraphics();
		bitmapGraphics = Graphics.FromImage((Image)(object)bitmap);
		Ranges* ptr = (Ranges*)global::_003CModule_003E.@new(88u);
		Ranges* ptr3;
		try
		{
			if (ptr != null)
			{
				global::_003CModule_003E.std_002Evector_003CHOLM_003A_003AGraphics_003A_003ARange_002Cstd_003A_003Aallocator_003CHOLM_003A_003AGraphics_003A_003ARange_003E_0020_003E_002E_007Bctor_007D((vector_003CHOLM_003A_003AGraphics_003A_003ARange_002Cstd_003A_003Aallocator_003CHOLM_003A_003AGraphics_003A_003ARange_003E_0020_003E*)((byte*)ptr + 64));
				try
				{
					Ranges* ptr2 = (Ranges*)((byte*)ptr + 32);
					*(double*)ptr2 = P_1;
					*(double*)((byte*)ptr + 40) = P_2;
					*(double*)((byte*)ptr + 48) = P_3;
					*(double*)((byte*)ptr + 56) = P_4;
					// IL cpblk instruction
					System.Runtime.CompilerServices.Unsafe.CopyBlock(ptr, ptr2, 32);
				}
				catch
				{
					//try-fault
					global::_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<vector_003CHOLM_003A_003AGraphics_003A_003ARange_002Cstd_003A_003Aallocator_003CHOLM_003A_003AGraphics_003A_003ARange_003E_0020_003E*, void>)(&global::_003CModule_003E.std_002Evector_003CHOLM_003A_003AGraphics_003A_003ARange_002Cstd_003A_003Aallocator_003CHOLM_003A_003AGraphics_003A_003ARange_003E_0020_003E_002E_007Bdtor_007D), (byte*)ptr + 64);
					throw;
				}
				ptr3 = ptr;
			}
			else
			{
				ptr3 = null;
			}
		}
		catch
		{
			//try-fault
			global::_003CModule_003E.delete(ptr);
			throw;
		}
		ranges = ptr3;
		*(double*)ptr3 = P_1;
		*(double*)((byte*)ptr3 + 8) = P_2;
		*(double*)((byte*)ptr3 + 16) = P_3;
		*(double*)((byte*)ptr3 + 24) = P_4;
		CalculateScaleFactors();
		current_pixx = 0;
		current_pixy = 0;
		nof_xtics = 30;
		nof_ytics = 10;
	}

	protected unsafe void CalculateScaleFactors()
	{
		if (xAxisMode != (AxisMode)1)
		{
			Ranges* ptr = ranges;
			plot_xmin = *(double*)ptr;
			plot_xmax = *(double*)((byte*)ptr + 8);
		}
		else
		{
			double num = *(double*)ranges;
			plot_xmin = global::_003CModule_003E.HOLM_002EMath_002ELog10Safe_003Cdouble_003E(num);
			double num2 = *(double*)((byte*)ranges + 8);
			plot_xmax = global::_003CModule_003E.HOLM_002EMath_002ELog10Safe_003Cdouble_003E(num2);
		}
		plot_witdh = plotArea.Width - borderXLeft - borderXRight;
		pixxMax = plotArea.Width - borderXRight;
		pixxMin = borderXLeft;
		double num3 = (scalex = (double)plot_witdh / (plot_xmax - plot_xmin));
		xtrans = -global::_003CModule_003E.HOLM_002EMath_002EToIntRound(plot_xmin * num3);
		switch (yAxisMode)
		{
		default:
		{
			Ranges* ptr5 = ranges;
			plot_ymin = *(double*)((byte*)ptr5 + 16);
			plot_ymax = *(double*)((byte*)ptr5 + 24);
			break;
		}
		case (AxisMode)3:
		{
			Ranges* ptr2 = ranges;
			double num8 = Math.Abs(*(double*)((byte*)ptr2 + 24));
			double num9 = Math.Abs(*(double*)((byte*)ptr2 + 16));
			double* ptr3 = ((!(num9 < num8)) ? (&num9) : (&num8));
			*(double*)((byte*)ptr2 + 24) = *ptr3;
			Ranges* ptr4 = ranges;
			*(double*)((byte*)ptr4 + 16) = 0.0 - *(double*)((byte*)ptr4 + 24);
			double num10 = *(double*)((byte*)ranges + 24);
			plot_ymax = global::_003CModule_003E.HOLM_002EMath_002EAmplitudeToDB_003Cdouble_003E(num10);
			plot_ymin = yAxisModedBMirror0DB;
			break;
		}
		case (AxisMode)2:
		{
			double num6 = *(double*)((byte*)ranges + 16);
			plot_ymin = global::_003CModule_003E.HOLM_002EMath_002EAmplitudeToDB_003Cdouble_003E(num6);
			double num7 = *(double*)((byte*)ranges + 24);
			plot_ymax = global::_003CModule_003E.HOLM_002EMath_002EAmplitudeToDB_003Cdouble_003E(num7);
			break;
		}
		case (AxisMode)1:
		{
			double num4 = *(double*)((byte*)ranges + 16);
			plot_ymin = global::_003CModule_003E.HOLM_002EMath_002ELog10Safe_003Cdouble_003E(num4);
			double num5 = *(double*)((byte*)ranges + 24);
			plot_ymax = global::_003CModule_003E.HOLM_002EMath_002ELog10Safe_003Cdouble_003E(num5);
			break;
		}
		}
		plot_height = plotArea.Height - borderYTop - borderYBot;
		pixyMax = plotArea.Height - borderYBot;
		pixyMin = borderYTop;
		double num11 = (scaley = (double)plot_height / (plot_ymax - plot_ymin));
		ytrans = -global::_003CModule_003E.HOLM_002EMath_002EToIntRound(plot_ymin * num11);
		if (yAxisMode == (AxisMode)3)
		{
			double num12 = (scaley *= 0.5);
			ytrans = global::_003CModule_003E.HOLM_002EMath_002EToIntRound((plot_ymax - plot_ymin) * num12);
		}
	}

	protected void draw_uparrow(int P_0, int P_1)
	{
		int num = P_0 - 1;
		bitmapGraphics.DrawLine(gpen, num, P_1, P_0 + 4, P_1 + 8);
		bitmapGraphics.DrawLine(gpen, num, P_1, P_0 - 6, P_1 + 8);
	}

	protected void draw_rightarrow(int P_0, int P_1)
	{
		int num = P_0 - 8;
		bitmapGraphics.DrawLine(gpen, P_0, P_1, num, P_1 - 5);
		bitmapGraphics.DrawLine(gpen, P_0, P_1, num, P_1 + 5);
	}

	protected virtual void Dispose([MarshalAs(UnmanagedType.U1)] bool P_0)
	{
		if (P_0)
		{
			_007EGraph();
		}
		else
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
