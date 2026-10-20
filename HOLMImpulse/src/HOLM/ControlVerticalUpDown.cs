using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace HOLM;

public class ControlVerticalUpDown : UserControl
{
	private double _Value;

	private double _Increment;

	private double _Min;

	private double _Max;

	private EventHandler _003Cbacking_store_003EValueChangedByUpDown;

	public Button upButton;

	public Button downButton;

	private Container components;

	[Category("Data")]
	[DefaultValue(10)]
	public double Max
	{
		get
		{
			return _Max;
		}
		set
		{
			_Max = value;
		}
	}

	[DefaultValue(-10)]
	[Category("Data")]
	public double Min
	{
		get
		{
			return _Min;
		}
		set
		{
			_Min = value;
		}
	}

	[DefaultValue(1)]
	[Category("Data")]
	public double Increment
	{
		get
		{
			return _Increment;
		}
		set
		{
			_Increment = value;
		}
	}

	[DefaultValue(0)]
	[Category("Data")]
	public double Value
	{
		get
		{
			return _Value;
		}
		set
		{
			_Value = value;
		}
	}

	[Category("Layout")]
	[DefaultValue(false)]
	public bool SideBySide
	{
		[return: MarshalAs(UnmanagedType.U1)]
		get
		{
			return ((Control)this).Height == 15;
		}
		[param: MarshalAs(UnmanagedType.U1)]
		set
		{
			if (value)
			{
				((Control)this).Height = 15;
				((Control)this).Width = 30;
				Point location = new Point(15, 0);
				((Control)downButton).Location = location;
			}
			else
			{
				((Control)this).Height = 30;
				((Control)this).Width = 15;
				Point location2 = new Point(0, 15);
				((Control)downButton).Location = location2;
			}
		}
	}

	[SpecialName]
	public event EventHandler ValueChangedByUpDown
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			_003Cbacking_store_003EValueChangedByUpDown = (EventHandler)Delegate.Combine(_003Cbacking_store_003EValueChangedByUpDown, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			_003Cbacking_store_003EValueChangedByUpDown = (EventHandler)Delegate.Remove(_003Cbacking_store_003EValueChangedByUpDown, value);
		}
	}

	public ControlVerticalUpDown()
	{
		try
		{
			InitializeComponent();
			_Value = 0.0;
			_Increment = 1.0;
			_Min = -10.0;
			_Max = 10.0;
			return;
		}
		catch
		{
			//try-fault
			((ContainerControl)this).Dispose(true);
			throw;
		}
	}

	private void _007EControlVerticalUpDown()
	{
		((IDisposable)components)?.Dispose();
	}

	[SpecialName]
	protected void raise_ValueChangedByUpDown(object value0, EventArgs value1)
	{
		_003Cbacking_store_003EValueChangedByUpDown?.Invoke(value0, value1);
	}

	private void InitializeComponent()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected O, but got Unknown
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(ControlVerticalUpDown));
		upButton = new Button();
		downButton = new Button();
		((Control)this).SuspendLayout();
		Color transparent = Color.Transparent;
		((ButtonBase)upButton).BackColor = transparent;
		((Control)upButton).BackgroundImage = (Image)componentResourceManager.GetObject("upButton.BackgroundImage");
		((Control)upButton).BackgroundImageLayout = (ImageLayout)2;
		Point location = new Point(0, 0);
		((Control)upButton).Location = location;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Padding margin);
		((Padding)(ref margin))._002Ector(0);
		((Control)upButton).Margin = margin;
		((Control)upButton).Name = "upButton";
		Size size = new Size(15, 15);
		((Control)upButton).Size = size;
		((Control)upButton).TabIndex = 0;
		((ButtonBase)upButton).UseVisualStyleBackColor = false;
		((Control)upButton).Click += upButton_Click;
		Color transparent2 = Color.Transparent;
		((ButtonBase)downButton).BackColor = transparent2;
		((Control)downButton).BackgroundImage = (Image)componentResourceManager.GetObject("downButton.BackgroundImage");
		((Control)downButton).BackgroundImageLayout = (ImageLayout)2;
		Point location2 = new Point(0, 15);
		((Control)downButton).Location = location2;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Padding margin2);
		((Padding)(ref margin2))._002Ector(0);
		((Control)downButton).Margin = margin2;
		((Control)downButton).Name = "downButton";
		Size size2 = new Size(15, 15);
		((Control)downButton).Size = size2;
		((Control)downButton).TabIndex = 1;
		((ButtonBase)downButton).UseVisualStyleBackColor = false;
		((Control)downButton).Click += downButton_Click;
		Color transparent3 = Color.Transparent;
		((Control)this).BackColor = transparent3;
		((Control)this).Controls.Add((Control)(object)downButton);
		((Control)this).Controls.Add((Control)(object)upButton);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Padding margin3);
		((Padding)(ref margin3))._002Ector(0);
		((Control)this).Margin = margin3;
		((Control)this).Name = "ControlVerticalUpDown";
		Size size3 = new Size(15, 30);
		((Control)this).Size = size3;
		((Control)this).ResumeLayout(false);
	}

	private void upButton_Click(object sender, EventArgs e)
	{
		if (_Value < _Max)
		{
			_Value = _Increment + _Value;
			raise_ValueChangedByUpDown(this, e);
		}
	}

	private void downButton_Click(object sender, EventArgs e)
	{
		if (_Value > _Min)
		{
			_Value -= _Increment;
			raise_ValueChangedByUpDown(this, e);
		}
	}

	protected override void Dispose([MarshalAs(UnmanagedType.U1)] bool P_0)
	{
		if (P_0)
		{
			try
			{
				_007EControlVerticalUpDown();
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
