using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace HOLM;

public class ControlFrequencyGraph : UserControl
{
	public Label coordsLabel;

	public ControlVerticalUpDown minUpDown;

	private Container components;

	public ControlFrequencyGraph()
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

	private void _007EControlFrequencyGraph()
	{
		((IDisposable)components)?.Dispose();
	}

	private void InitializeComponent()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		coordsLabel = new Label();
		minUpDown = new ControlVerticalUpDown();
		((Control)this).SuspendLayout();
		((Control)coordsLabel).Anchor = (AnchorStyles)6;
		coordsLabel.AutoSize = true;
		Point location = new Point(15, 185);
		((Control)coordsLabel).Location = location;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Padding margin);
		((Padding)(ref margin))._002Ector(1);
		((Control)coordsLabel).Margin = margin;
		((Control)coordsLabel).Name = "coordsLabel";
		Size size = new Size(63, 13);
		((Control)coordsLabel).Size = size;
		((Control)coordsLabel).TabIndex = 10;
		coordsLabel.Text = "Coordinates";
		((Control)minUpDown).Anchor = (AnchorStyles)6;
		Color transparent = Color.Transparent;
		((Control)minUpDown).BackColor = transparent;
		((Control)minUpDown).Cursor = Cursors.Default;
		minUpDown.Increment = 10.0;
		Point location2 = new Point(0, 170);
		((Control)minUpDown).Location = location2;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Padding margin2);
		((Padding)(ref margin2))._002Ector(0);
		((Control)minUpDown).Margin = margin2;
		minUpDown.Max = -10.0;
		minUpDown.Min = -200.0;
		((Control)minUpDown).Name = "minUpDown";
		Size size2 = new Size(15, 30);
		((Control)minUpDown).Size = size2;
		((Control)minUpDown).TabIndex = 11;
		minUpDown.Value = -70.0;
		Color lightGray = Color.LightGray;
		((Control)this).BackColor = lightGray;
		((Control)this).Controls.Add((Control)(object)minUpDown);
		((Control)this).Controls.Add((Control)(object)coordsLabel);
		((Control)this).Cursor = Cursors.Cross;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Padding margin3);
		((Padding)(ref margin3))._002Ector(0);
		((Control)this).Margin = margin3;
		((Control)this).Name = "ControlFrequencyGraph";
		Size size3 = new Size(500, 200);
		((Control)this).Size = size3;
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	protected override void Dispose([MarshalAs(UnmanagedType.U1)] bool P_0)
	{
		if (P_0)
		{
			try
			{
				_007EControlFrequencyGraph();
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
