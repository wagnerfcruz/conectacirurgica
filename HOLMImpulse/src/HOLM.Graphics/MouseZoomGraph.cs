using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using std;

namespace HOLM.Graphics;

internal class MouseZoomGraph : Graph
{
	protected Point zoomStartPixPoint;

	protected Point zoomEndPixPoint;

	protected Pen zoompen;

	protected bool fZoomConfigured;

	protected bool fLeftMouseZoomDownStatus;

	protected Cursor normalCursor;

	protected Label statusLabel;

	protected bool fEnableMouseZoomIn;

	public MouseZoomGraph(Control control, double xminin, double xmaxin, double yminin, double ymaxin)
		: base(control, xminin, xmaxin, yminin, ymaxin)
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected O, but got Unknown
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected O, but got Unknown
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Expected O, but got Unknown
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Expected O, but got Unknown
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected O, but got Unknown
		try
		{
			statusLabel = null;
			fZoomConfigured = false;
			fLeftMouseZoomDownStatus = false;
			(zoompen = new Pen(plotArea.ForeColor)).Width = 2f;
			fEnableMouseZoomIn = true;
			normalCursor = plotArea.Cursor;
			plotArea.Resize += Action_ResizePlotArea;
			plotArea.Paint += new PaintEventHandler(Action_RepaintPlotArea);
			plotArea.MouseDown += new MouseEventHandler(Action_MouseDown);
			plotArea.MouseUp += new MouseEventHandler(Action_MouseUp);
			plotArea.MouseMove += new MouseEventHandler(Action_MouseMove);
			plotArea.MouseClick += new MouseEventHandler(Action_MouseClick);
			plotArea.MouseLeave += Action_MouseLeave;
			return;
		}
		catch
		{
			//try-fault
			base.Dispose(true);
			throw;
		}
	}

	private void _007EMouseZoomGraph()
	{
		((IDisposable)zoompen)?.Dispose();
	}

	[return: MarshalAs(UnmanagedType.U1)]
	public bool ZoomInMouse()
	{
		bool result = false;
		if (fZoomConfigured)
		{
			int num = ((zoomStartPixPoint.X >= zoomEndPixPoint.X) ? zoomEndPixPoint.X : zoomStartPixPoint.X);
			int num2 = ((zoomStartPixPoint.X <= zoomEndPixPoint.X) ? zoomEndPixPoint.X : zoomStartPixPoint.X);
			int num3 = ((zoomStartPixPoint.Y >= zoomEndPixPoint.Y) ? zoomEndPixPoint.Y : zoomStartPixPoint.Y);
			int num4 = ((zoomStartPixPoint.Y <= zoomEndPixPoint.Y) ? zoomEndPixPoint.Y : zoomStartPixPoint.Y);
			ZoomIn(PixXToX(num), PixXToX(num2), PixYToY(num4), PixYToY(num3));
			fZoomConfigured = false;
			result = true;
		}
		return result;
	}

	public void UpdatePlotArea()
	{
		ClearBitmap();
		UpdatePlot();
		DisplayBitmap();
	}

	public void SetForeColor(Color color)
	{
		zoompen.Color = color;
		plotArea.ForeColor = color;
		SetDrawColor(color);
	}

	public void SaveBitmapDialog()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Invalid comparison between Unknown and I4
		SaveFileDialog val = new SaveFileDialog();
		((FileDialog)val).Filter = string.Concat(string.Concat("Compressed Bitmap (*.png)|*.png|" + "Compressed Bitmap (*.jpg)|*.jpg|", "Bitmap (*.bmp)|*.bmp|"), "All Files (*.*)|*.*");
		((FileDialog)val).Title = "Save Graph as Bitmap";
		if ((int)((CommonDialog)val).ShowDialog() == 1)
		{
			string fileName = ((FileDialog)val).FileName;
			global::_003CModule_003E.HOLM_002EGraphics_002ESaveBitmap(bitmap, fileName);
		}
		((IDisposable)val)?.Dispose();
	}

	public void SetStatusLabel(Label statusLabelIn)
	{
		statusLabel = statusLabelIn;
		statusLabelIn.Text = "";
	}

	protected virtual void UpdatePlot()
	{
	}

	protected virtual void ChildMouseMove(MouseEventArgs e)
	{
	}

	protected virtual void ChildMouseDown(MouseEventArgs e)
	{
	}

	protected virtual void ChildMouseUp(MouseEventArgs e)
	{
	}

	protected virtual void ChildMouseLeave()
	{
	}

	protected void SetEnableMouseZoomIn([MarshalAs(UnmanagedType.U1)] bool value)
	{
		fEnableMouseZoomIn = value;
	}

	protected void Action_ResizePlotArea(object sender, EventArgs e)
	{
		ResizePlotArea();
		if (fParasite)
		{
			parasite.ResizePlotArea();
			parasite.bitmapGraphics = bitmapGraphics;
		}
		ClearBitmap();
		UpdatePlot();
		DisplayBitmap();
	}

	protected void Action_RepaintPlotArea(object sender, PaintEventArgs e)
	{
		DisplayBitmap();
	}

	protected unsafe void Action_MouseDown(object sender, MouseEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I4
		if ((int)e.Button == 1048576)
		{
			if (fEnableMouseZoomIn)
			{
				Point location = e.Location;
				Point point = ConstrainPoint(&location);
				zoomStartPixPoint = point;
				fZoomConfigured = false;
				fLeftMouseZoomDownStatus = true;
			}
			else
			{
				ChildMouseDown(e);
			}
		}
	}

	protected unsafe void Action_MouseUp(object sender, MouseEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I4
		if ((int)e.Button == 1048576 && fLeftMouseZoomDownStatus)
		{
			Point location = e.Location;
			Point point = ConstrainPoint(&location);
			zoomEndPixPoint = point;
			if (Math.Abs(zoomEndPixPoint.X - zoomStartPixPoint.X) > 9 && Math.Abs(zoomEndPixPoint.Y - zoomStartPixPoint.Y) > 9)
			{
				fZoomConfigured = true;
				ZoomInMouse();
				ClearBitmap();
				UpdatePlot();
				DisplayBitmap();
			}
			fLeftMouseZoomDownStatus = false;
		}
		ChildMouseUp(e);
	}

	protected unsafe void Action_MouseMove(object sender, MouseEventArgs e)
	{
		_ = e.X;
		double num = PixYToY(e.Y);
		global::_003CModule_003E.HOLM_002EMath_002EAmplitudeToDB_003Cdouble_003E(num);
		if (e.X >= pixxMin && e.X <= pixxMax)
		{
			ChildMouseMove(e);
		}
		if (fLeftMouseZoomDownStatus)
		{
			DisplayBitmap();
			Point location = e.Location;
			Point point = ConstrainPoint(&location);
			zoomEndPixPoint = point;
			int num2 = ((zoomStartPixPoint.Y >= zoomEndPixPoint.Y) ? zoomEndPixPoint.Y : zoomStartPixPoint.Y);
			int num3 = ((zoomStartPixPoint.X >= zoomEndPixPoint.X) ? zoomEndPixPoint.X : zoomStartPixPoint.X);
			plotareaGraphics.DrawRectangle(zoompen, num3, num2, Math.Abs(zoomEndPixPoint.X - zoomStartPixPoint.X), Math.Abs(zoomEndPixPoint.Y - zoomStartPixPoint.Y));
		}
	}

	protected unsafe void Action_MouseClick(object sender, MouseEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I4
		if ((int)e.Button == 2097152)
		{
			vector_003CHOLM_003A_003AGraphics_003A_003ARange_002Cstd_003A_003Aallocator_003CHOLM_003A_003AGraphics_003A_003ARange_003E_0020_003E* ptr = (vector_003CHOLM_003A_003AGraphics_003A_003ARange_002Cstd_003A_003Aallocator_003CHOLM_003A_003AGraphics_003A_003ARange_003E_0020_003E*)((byte*)ranges + 64);
			if (!(((*(int*)((byte*)ptr + 16) - *(int*)((byte*)ptr + 12)) & -32) == 0))
			{
				ZoomOut();
				ChildMouseUp(e);
				ClearBitmap();
				UpdatePlot();
				DisplayBitmap();
			}
			else
			{
				ZoomAllOut();
				ChildMouseUp(e);
				ClearBitmap();
				UpdatePlot();
				DisplayBitmap();
			}
		}
	}

	protected void Action_MouseLeave(object sender, EventArgs e)
	{
		ChildMouseLeave();
	}

	protected unsafe Point ConstrainPoint(Point* point)
	{
		Point result = *point;
		int num = pixxMin;
		if (point->X < num)
		{
			result.X = pixxMin;
		}
		else
		{
			int num2 = pixxMax;
			if (point->X > num2)
			{
				result.X = pixxMax;
			}
		}
		int num3 = pixyMin;
		if (point->Y < num3)
		{
			result.Y = pixyMin;
		}
		else
		{
			int num4 = pixyMax;
			if (point->Y > num4)
			{
				result.Y = pixyMax;
			}
		}
		return result;
	}

	[return: MarshalAs(UnmanagedType.U1)]
	protected unsafe bool IsPointInside(Point* point)
	{
		int num = pixxMin;
		int num3;
		if (point->X >= num)
		{
			int num2 = pixxMax;
			if (point->X <= num2)
			{
				num3 = 1;
				goto IL_002a;
			}
		}
		num3 = 0;
		goto IL_002a;
		IL_005e:
		int num4 = 0;
		goto IL_0060;
		IL_0060:
		return (byte)num4 != 0;
		IL_0056:
		int num5;
		if ((byte)num5 == 0)
		{
			goto IL_005e;
		}
		num4 = 1;
		goto IL_0060;
		IL_002a:
		if ((byte)num3 != 0)
		{
			int num6 = pixyMin;
			if (point->Y >= num6)
			{
				int num7 = pixyMax;
				if (point->Y <= num7)
				{
					num5 = 1;
					goto IL_0056;
				}
			}
			num5 = 0;
			goto IL_0056;
		}
		goto IL_005e;
	}

	[return: MarshalAs(UnmanagedType.U1)]
	protected unsafe bool IsXInside(int* X)
	{
		int num = *X;
		int num2 = ((num >= pixxMin && num <= pixxMax) ? 1 : 0);
		return (byte)num2 != 0;
	}

	[return: MarshalAs(UnmanagedType.U1)]
	protected unsafe bool IsXInside(Point* point)
	{
		int num = pixxMin;
		int num3;
		if (point->X >= num)
		{
			int num2 = pixxMax;
			if (point->X <= num2)
			{
				num3 = 1;
				goto IL_0026;
			}
		}
		num3 = 0;
		goto IL_0026;
		IL_0026:
		return (byte)num3 != 0;
	}

	[return: MarshalAs(UnmanagedType.U1)]
	protected unsafe bool IsYInside(int* Y)
	{
		int num = *Y;
		int num2 = ((num >= pixyMin && num <= pixyMax) ? 1 : 0);
		return (byte)num2 != 0;
	}

	[return: MarshalAs(UnmanagedType.U1)]
	protected unsafe bool IsYInside(Point* point)
	{
		int num = pixyMin;
		int num3;
		if (point->Y >= num)
		{
			int num2 = pixyMax;
			if (point->Y <= num2)
			{
				num3 = 1;
				goto IL_0026;
			}
		}
		num3 = 0;
		goto IL_0026;
		IL_0026:
		return (byte)num3 != 0;
	}

	protected override void Dispose([MarshalAs(UnmanagedType.U1)] bool P_0)
	{
		if (P_0)
		{
			try
			{
				_007EMouseZoomGraph();
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
