using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace HOLM;

public class ControlFilename : UserControl
{
	public GroupBox groupBox;

	private string _Filter;

	private EventHandler _003Cbacking_store_003EActionEvent;

	public Button browseButton;

	public TextBox textBox;

	public Button actionButton;

	private Container components;

	[Category("Layout")]
	[DefaultValue("")]
	public string ActionText
	{
		get
		{
			return ((ButtonBase)actionButton).Text;
		}
		set
		{
			((ButtonBase)actionButton).Text = value;
			((Control)actionButton).Visible = value != "";
		}
	}

	[DefaultValue("<Filename>")]
	[Category("Layout")]
	public string Path
	{
		get
		{
			return textBox.Text;
		}
		set
		{
			textBox.Text = value;
		}
	}

	[Category("Layout")]
	[DefaultValue("Filename")]
	public string Label
	{
		get
		{
			return groupBox.Text;
		}
		set
		{
			groupBox.Text = value;
		}
	}

	[Category("Data")]
	[DefaultValue("All Files (*.*)|*.*")]
	public string Filter
	{
		get
		{
			return _Filter;
		}
		set
		{
			_Filter = value;
		}
	}

	[SpecialName]
	[Category("Action")]
	public event EventHandler ActionEvent
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			_003Cbacking_store_003EActionEvent = (EventHandler)Delegate.Combine(_003Cbacking_store_003EActionEvent, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			_003Cbacking_store_003EActionEvent = (EventHandler)Delegate.Remove(_003Cbacking_store_003EActionEvent, value);
		}
	}

	public ControlFilename()
	{
		try
		{
			InitializeComponent();
			_Filter = "All Files (*.*)|*.*";
			return;
		}
		catch
		{
			//try-fault
			((ContainerControl)this).Dispose(true);
			throw;
		}
	}

	private void _007EControlFilename()
	{
		((IDisposable)components)?.Dispose();
	}

	[SpecialName]
	protected void raise_ActionEvent(object value0, EventArgs value1)
	{
		_003Cbacking_store_003EActionEvent?.Invoke(value0, value1);
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
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		groupBox = new GroupBox();
		actionButton = new Button();
		browseButton = new Button();
		textBox = new TextBox();
		((Control)groupBox).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)groupBox).Controls.Add((Control)(object)actionButton);
		((Control)groupBox).Controls.Add((Control)(object)browseButton);
		((Control)groupBox).Controls.Add((Control)(object)textBox);
		((Control)groupBox).Dock = (DockStyle)5;
		Point location = new Point(0, 0);
		((Control)groupBox).Location = location;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Padding margin);
		((Padding)(ref margin))._002Ector(0);
		((Control)groupBox).Margin = margin;
		((Control)groupBox).Name = "groupBox";
		Size size = new Size(331, 67);
		((Control)groupBox).Size = size;
		((Control)groupBox).TabIndex = 1;
		groupBox.TabStop = false;
		groupBox.Text = "Filename";
		((Control)actionButton).Anchor = (AnchorStyles)9;
		Point location2 = new Point(176, 40);
		((Control)actionButton).Location = location2;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Padding margin2);
		((Padding)(ref margin2))._002Ector(1);
		((Control)actionButton).Margin = margin2;
		((Control)actionButton).Name = "actionButton";
		Size size2 = new Size(80, 21);
		((Control)actionButton).Size = size2;
		((Control)actionButton).TabIndex = 4;
		((ButtonBase)actionButton).UseVisualStyleBackColor = true;
		((Control)actionButton).Visible = false;
		((Control)actionButton).Click += actionButton_Click;
		((Control)browseButton).Anchor = (AnchorStyles)9;
		Point location3 = new Point(261, 40);
		((Control)browseButton).Location = location3;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Padding margin3);
		((Padding)(ref margin3))._002Ector(1);
		((Control)browseButton).Margin = margin3;
		((Control)browseButton).Name = "browseButton";
		Size size3 = new Size(66, 21);
		((Control)browseButton).Size = size3;
		((Control)browseButton).TabIndex = 3;
		((ButtonBase)browseButton).Text = "Browse";
		((ButtonBase)browseButton).UseVisualStyleBackColor = true;
		((Control)browseButton).Click += browseButton_Click;
		((Control)textBox).Dock = (DockStyle)1;
		Point location4 = new Point(3, 16);
		((Control)textBox).Location = location4;
		((Control)textBox).Name = "textBox";
		Size size4 = new Size(325, 20);
		((Control)textBox).Size = size4;
		((Control)textBox).TabIndex = 2;
		((Control)this).Controls.Add((Control)(object)groupBox);
		((Control)this).Name = "ControlFilename";
		Size size5 = new Size(331, 67);
		((Control)this).Size = size5;
		((Control)groupBox).ResumeLayout(false);
		((Control)groupBox).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	private void browseButton_Click(object sender, EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Invalid comparison between Unknown and I4
		OpenFileDialog val = new OpenFileDialog();
		((FileDialog)val).Filter = _Filter;
		((FileDialog)val).Title = groupBox.Text;
		if ((int)((CommonDialog)val).ShowDialog() == 1)
		{
			textBox.Text = ((FileDialog)val).FileName;
			((TextBoxBase)textBox).SelectAll();
		}
		((IDisposable)val)?.Dispose();
	}

	private void actionButton_Click(object sender, EventArgs e)
	{
		raise_ActionEvent(this, e);
	}

	protected override void Dispose([MarshalAs(UnmanagedType.U1)] bool P_0)
	{
		if (P_0)
		{
			try
			{
				_007EControlFilename();
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
