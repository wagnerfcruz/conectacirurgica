using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace HOLM.MeasureGraphics;

internal class ColorCtrl : IDisposable
{
	private EventHandler _003Cbacking_store_003EColorChanged;

	private ToolTip toolTip;

	private ColorDialog cD;

	private bool fcDAssigned;

	private Color color;

	private Color brightColor;

	private Control[] ctrlList;

	private bool[] bgList;

	private bool[] brighterList;

	[SpecialName]
	public event EventHandler ColorChanged
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			_003Cbacking_store_003EColorChanged = (EventHandler)Delegate.Combine(_003Cbacking_store_003EColorChanged, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			_003Cbacking_store_003EColorChanged = (EventHandler)Delegate.Remove(_003Cbacking_store_003EColorChanged, value);
		}
	}

	public ColorCtrl(ColorDialog colorDialog, ToolTip toolTip)
	{
		ctrlList = (Control[])(object)new Control[0];
		bgList = new bool[0];
		brighterList = new bool[0];
		cD = colorDialog;
		fcDAssigned = true;
		this.toolTip = toolTip;
	}

	public ColorCtrl(ColorDialog colorDialog)
	{
		ctrlList = (Control[])(object)new Control[0];
		bgList = new bool[0];
		brighterList = new bool[0];
		cD = colorDialog;
		fcDAssigned = true;
		toolTip = null;
	}

	public ColorCtrl()
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected O, but got Unknown
		ctrlList = (Control[])(object)new Control[0];
		bgList = new bool[0];
		brighterList = new bool[0];
		cD = new ColorDialog();
		fcDAssigned = false;
		toolTip = null;
	}

	private void _007EColorCtrl()
	{
		global::_003CModule_003E.DeleteCliArray(ctrlList);
		bgList = null;
		brighterList = null;
		if (!fcDAssigned)
		{
			((IDisposable)cD)?.Dispose();
		}
	}

	public void AssignControl(Control control, [MarshalAs(UnmanagedType.U1)] bool fBg, [MarshalAs(UnmanagedType.U1)] bool fBright)
	{
		Array.Resize(ref ctrlList, (int)((nint)ctrlList.LongLength + 1));
		Array.Resize(ref bgList, ctrlList.Length);
		Array.Resize(ref brighterList, ctrlList.Length);
		Control[] array = ctrlList;
		array[(nint)array.LongLength - 1] = control;
		bgList[(nint)ctrlList.LongLength - 1] = fBg;
		brighterList[(nint)ctrlList.LongLength - 1] = fBright;
	}

	public void AssignClickControl(Control control, [MarshalAs(UnmanagedType.U1)] bool fBg, [MarshalAs(UnmanagedType.U1)] bool fBright)
	{
		AssignControl(control, fBg, fBright);
		control.Click += Action_ColorClick;
		control.Cursor = Cursors.Hand;
		ToolTip val = toolTip;
		if (val != null)
		{
			val.SetToolTip(control, "Click here to change the color");
		}
	}

	[SpecialName]
	protected void raise_ColorChanged(object value0, EventArgs value1)
	{
		_003Cbacking_store_003EColorChanged?.Invoke(value0, value1);
	}

	public void SetColor(Color color)
	{
		this.color = color;
		Color color2 = global::_003CModule_003E.HOLM_002EMeasureGraphics_002EBrighter(this.color);
		brightColor = color2;
		int num = 0;
		Control[] array = ctrlList;
		if (0 < (nint)array.LongLength)
		{
			do
			{
				if (bgList[num])
				{
					Color backColor = ((!brighterList[num]) ? this.color : brightColor);
					array[num].BackColor = backColor;
				}
				else
				{
					Color foreColor = ((!brighterList[num]) ? this.color : brightColor);
					array[num].ForeColor = foreColor;
				}
				num++;
				array = ctrlList;
			}
			while (num < (nint)array.LongLength);
		}
		_003Cbacking_store_003EColorChanged?.Invoke(this, null);
	}

	public Color GetColor()
	{
		return color;
	}

	public Color GetBrightColor()
	{
		return brightColor;
	}

	private void Action_ColorClick(object sender, EventArgs e)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Invalid comparison between Unknown and I4
		if ((int)((CommonDialog)cD).ShowDialog() == 1)
		{
			Color color = cD.Color;
			SetColor(color);
		}
	}

	protected virtual void Dispose([MarshalAs(UnmanagedType.U1)] bool P_0)
	{
		if (P_0)
		{
			_007EColorCtrl();
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
