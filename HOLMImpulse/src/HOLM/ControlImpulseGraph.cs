using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace HOLM;

public class ControlImpulseGraph : UserControl
{
	public Button zoomOutButton;

	public Button reverberationButton;

	public Label coordsLabel;

	public Button autoZoomButton;

	public CheckBox dBNormCheckBox;

	public ControlVerticalUpDown dB0UpDown;

	private Container components;

	[DefaultValue(false)]
	[Category("Layout")]
	public bool ReverbdBVisible
	{
		[return: MarshalAs(UnmanagedType.U1)]
		get
		{
			return ((Control)reverberationButton).Visible;
		}
		[param: MarshalAs(UnmanagedType.U1)]
		set
		{
			((Control)reverberationButton).Visible = value;
			((Control)dBNormCheckBox).Visible = value;
		}
	}

	[Category("Layout")]
	[DefaultValue(true)]
	public bool ZoomOutVisible
	{
		[return: MarshalAs(UnmanagedType.U1)]
		get
		{
			return ((Control)zoomOutButton).Visible;
		}
		[param: MarshalAs(UnmanagedType.U1)]
		set
		{
			((Control)zoomOutButton).Visible = value;
			int x;
			if (value)
			{
				Point location = ((Control)zoomOutButton).Location;
				x = ((Control)zoomOutButton).Width + location.X;
			}
			else
			{
				Point location2 = ((Control)autoZoomButton).Location;
				x = ((Control)autoZoomButton).Width + location2.X;
			}
			Point location3 = new Point(x, ((Control)coordsLabel).Location.Y);
			((Control)coordsLabel).Location = location3;
		}
	}

	public ControlImpulseGraph()
	{
		try
		{
			InitializeComponent();
			return;
		}
		catch
		{
			//try-fault
			((ContainerControl)this).Dispose(true);
			throw;
		}
	}

	private void _007EControlImpulseGraph()
	{
		((IDisposable)components)?.Dispose();
	}

	private void InitializeComponent()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0225: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_039d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0471: Unknown result type (might be due to invalid IL or missing references)
		//IL_0587: Unknown result type (might be due to invalid IL or missing references)
		zoomOutButton = new Button();
		reverberationButton = new Button();
		coordsLabel = new Label();
		autoZoomButton = new Button();
		dBNormCheckBox = new CheckBox();
		dB0UpDown = new ControlVerticalUpDown();
		((Control)this).SuspendLayout();
		((Control)zoomOutButton).Anchor = (AnchorStyles)6;
		Color transparent = Color.Transparent;
		((ButtonBase)zoomOutButton).BackColor = transparent;
		((Control)zoomOutButton).Cursor = Cursors.Default;
		Color controlText = SystemColors.ControlText;
		((Control)zoomOutButton).ForeColor = controlText;
		Point location = new Point(66, 180);
		((Control)zoomOutButton).Location = location;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Padding margin);
		((Padding)(ref margin))._002Ector(0);
		((Control)zoomOutButton).Margin = margin;
		((Control)zoomOutButton).Name = "zoomOutButton";
		Size size = new Size(62, 20);
		((Control)zoomOutButton).Size = size;
		((Control)zoomOutButton).TabIndex = 7;
		((ButtonBase)zoomOutButton).Text = "Zoom Out";
		((ButtonBase)zoomOutButton).UseVisualStyleBackColor = false;
		((Control)reverberationButton).Anchor = (AnchorStyles)10;
		Color transparent2 = Color.Transparent;
		((ButtonBase)reverberationButton).BackColor = transparent2;
		((Control)reverberationButton).Cursor = Cursors.Default;
		Color controlText2 = SystemColors.ControlText;
		((Control)reverberationButton).ForeColor = controlText2;
		Point location2 = new Point(418, 180);
		((Control)reverberationButton).Location = location2;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Padding margin2);
		((Padding)(ref margin2))._002Ector(0);
		((Control)reverberationButton).Margin = margin2;
		((Control)reverberationButton).Name = "reverberationButton";
		Size size2 = new Size(82, 20);
		((Control)reverberationButton).Size = size2;
		((Control)reverberationButton).TabIndex = 9;
		((ButtonBase)reverberationButton).Text = "Reverberation";
		((ButtonBase)reverberationButton).UseVisualStyleBackColor = false;
		((Control)reverberationButton).Visible = false;
		((Control)coordsLabel).Anchor = (AnchorStyles)6;
		coordsLabel.AutoSize = true;
		Point location3 = new Point(128, 184);
		((Control)coordsLabel).Location = location3;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Padding margin3);
		((Padding)(ref margin3))._002Ector(1);
		((Control)coordsLabel).Margin = margin3;
		((Control)coordsLabel).Name = "coordsLabel";
		Size size3 = new Size(63, 13);
		((Control)coordsLabel).Size = size3;
		((Control)coordsLabel).TabIndex = 10;
		coordsLabel.Text = "Coordinates";
		((Control)autoZoomButton).Anchor = (AnchorStyles)6;
		Color transparent3 = Color.Transparent;
		((ButtonBase)autoZoomButton).BackColor = transparent3;
		((Control)autoZoomButton).Cursor = Cursors.Default;
		Color controlText3 = SystemColors.ControlText;
		((Control)autoZoomButton).ForeColor = controlText3;
		Point location4 = new Point(0, 180);
		((Control)autoZoomButton).Location = location4;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Padding margin4);
		((Padding)(ref margin4))._002Ector(0);
		((Control)autoZoomButton).Margin = margin4;
		((Control)autoZoomButton).Name = "autoZoomButton";
		Size size4 = new Size(67, 20);
		((Control)autoZoomButton).Size = size4;
		((Control)autoZoomButton).TabIndex = 6;
		((ButtonBase)autoZoomButton).Text = "Auto Zoom";
		((ButtonBase)autoZoomButton).UseVisualStyleBackColor = false;
		((Control)dBNormCheckBox).Anchor = (AnchorStyles)10;
		((ButtonBase)dBNormCheckBox).AutoSize = true;
		Color transparent4 = Color.Transparent;
		((ButtonBase)dBNormCheckBox).BackColor = transparent4;
		((Control)dBNormCheckBox).Cursor = Cursors.Default;
		Point location5 = new Point(376, 183);
		((Control)dBNormCheckBox).Location = location5;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Padding margin5);
		((Padding)(ref margin5))._002Ector(0);
		((Control)dBNormCheckBox).Margin = margin5;
		((Control)dBNormCheckBox).Name = "dBNormCheckBox";
		Size size5 = new Size(45, 17);
		((Control)dBNormCheckBox).Size = size5;
		((Control)dBNormCheckBox).TabIndex = 8;
		((ButtonBase)dBNormCheckBox).Text = "[dB]";
		((ButtonBase)dBNormCheckBox).UseVisualStyleBackColor = false;
		((Control)dBNormCheckBox).Visible = false;
		((Control)dB0UpDown).Anchor = (AnchorStyles)10;
		Color transparent5 = Color.Transparent;
		((Control)dB0UpDown).BackColor = transparent5;
		((Control)dB0UpDown).Cursor = Cursors.Default;
		dB0UpDown.Increment = 10.0;
		Point location6 = new Point(342, 183);
		((Control)dB0UpDown).Location = location6;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Padding margin6);
		((Padding)(ref margin6))._002Ector(0);
		((Control)dB0UpDown).Margin = margin6;
		dB0UpDown.Max = -10.0;
		dB0UpDown.Min = -200.0;
		((Control)dB0UpDown).Name = "dB0UpDown";
		dB0UpDown.SideBySide = true;
		Size size6 = new Size(30, 15);
		((Control)dB0UpDown).Size = size6;
		((Control)dB0UpDown).TabIndex = 11;
		dB0UpDown.Value = -70.0;
		((Control)dB0UpDown).Visible = false;
		Color lightGray = Color.LightGray;
		((Control)this).BackColor = lightGray;
		((Control)this).Controls.Add((Control)(object)dB0UpDown);
		((Control)this).Controls.Add((Control)(object)zoomOutButton);
		((Control)this).Controls.Add((Control)(object)reverberationButton);
		((Control)this).Controls.Add((Control)(object)coordsLabel);
		((Control)this).Controls.Add((Control)(object)autoZoomButton);
		((Control)this).Controls.Add((Control)(object)dBNormCheckBox);
		((Control)this).Cursor = Cursors.Cross;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Padding margin7);
		((Padding)(ref margin7))._002Ector(0);
		((Control)this).Margin = margin7;
		((Control)this).Name = "ControlImpulseGraph";
		Size size7 = new Size(500, 200);
		((Control)this).Size = size7;
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	protected override void Dispose([MarshalAs(UnmanagedType.U1)] bool P_0)
	{
		if (P_0)
		{
			try
			{
				_007EControlImpulseGraph();
				return;
			}
			finally
			{
				((ContainerControl)this).Dispose(true);
			}
		}
		((ContainerControl)this).Dispose(false);
	}
}
