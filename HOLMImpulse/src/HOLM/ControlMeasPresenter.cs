using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace HOLM;

public class ControlMeasPresenter : UserControl
{
	private bool _ImportExportButtons;

	public Label infoLabel;

	public Panel colorPanel;

	public CheckBox plotCheckBox;

	public ComboBox listComboBox;

	public Button optionsButton;

	public NumericUpDown slotUpDown;

	public Button measureButton;

	public Button importButton;

	public Button exportButton;

	public Button corrBasisButton;

	public Label info2Label;

	public TableLayoutPanel tableLayoutPanel;

	public Panel panel;

	private Container components;

	[DefaultValue(false)]
	[Category("Layout")]
	public bool OptionsToClearButton
	{
		[return: MarshalAs(UnmanagedType.U1)]
		get
		{
			return ((ButtonBase)optionsButton).Text == "Clear";
		}
		[param: MarshalAs(UnmanagedType.U1)]
		set
		{
			if (value)
			{
				((ButtonBase)optionsButton).Text = "Clear";
				((Control)optionsButton).Width = ((Control)optionsButton).Width - 20;
				Point location = ((Control)optionsButton).Location;
				Point location2 = new Point(((Control)optionsButton).Location.X + 20, location.Y);
				((Control)optionsButton).Location = location2;
				((Control)measureButton).Width = ((Control)measureButton).Width + 20;
			}
		}
	}

	[Category("Layout")]
	[DefaultValue(false)]
	public bool ImportExportButtons
	{
		[return: MarshalAs(UnmanagedType.U1)]
		get
		{
			return _ImportExportButtons;
		}
		[param: MarshalAs(UnmanagedType.U1)]
		set
		{
			_ImportExportButtons = value;
			((Control)importButton).Visible = value;
			((Control)exportButton).Visible = value;
		}
	}

	[Category("Layout")]
	[DefaultValue("")]
	public string Identifier
	{
		get
		{
			return ((ButtonBase)plotCheckBox).Text;
		}
		set
		{
			((ButtonBase)plotCheckBox).Text = value;
			Point location = ((Control)listComboBox).Location;
			int num = ((Control)plotCheckBox).Width - location.X;
			Point location2 = new Point(location.X + num, location.Y);
			((Control)listComboBox).Location = location2;
			((Control)listComboBox).Width = ((Control)listComboBox).Width - num;
		}
	}

	public ControlMeasPresenter()
	{
		try
		{
			InitializeComponent();
			_ImportExportButtons = false;
			return;
		}
		catch
		{
			//try-fault
			((ContainerControl)this).Dispose(true);
			throw;
		}
	}

	private void _007EControlMeasPresenter()
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
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_033c: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0452: Unknown result type (might be due to invalid IL or missing references)
		//IL_045c: Expected O, but got Unknown
		//IL_0480: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_057d: Unknown result type (might be due to invalid IL or missing references)
		//IL_060e: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0765: Unknown result type (might be due to invalid IL or missing references)
		//IL_076f: Expected O, but got Unknown
		//IL_07b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f6: Expected O, but got Unknown
		//IL_0941: Unknown result type (might be due to invalid IL or missing references)
		//IL_099d: Unknown result type (might be due to invalid IL or missing references)
		info2Label = new Label();
		corrBasisButton = new Button();
		importButton = new Button();
		exportButton = new Button();
		infoLabel = new Label();
		colorPanel = new Panel();
		plotCheckBox = new CheckBox();
		listComboBox = new ComboBox();
		optionsButton = new Button();
		slotUpDown = new NumericUpDown();
		measureButton = new Button();
		tableLayoutPanel = new TableLayoutPanel();
		panel = new Panel();
		((ISupportInitialize)slotUpDown).BeginInit();
		((Control)tableLayoutPanel).SuspendLayout();
		((Control)panel).SuspendLayout();
		((Control)this).SuspendLayout();
		info2Label.AutoSize = true;
		Point location = new Point(72, 48);
		((Control)info2Label).Location = location;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Padding margin);
		((Padding)(ref margin))._002Ector(0);
		((Control)info2Label).Margin = margin;
		((Control)info2Label).Name = "info2Label";
		Size size = new Size(39, 13);
		((Control)info2Label).Size = size;
		((Control)info2Label).TabIndex = 79;
		info2Label.Text = "(L && R)";
		((Control)info2Label).Visible = false;
		((Control)corrBasisButton).Anchor = (AnchorStyles)9;
		Point location2 = new Point(111, 45);
		((Control)corrBasisButton).Location = location2;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Padding margin2);
		((Padding)(ref margin2))._002Ector(0);
		((Control)corrBasisButton).Margin = margin2;
		((Control)corrBasisButton).Name = "corrBasisButton";
		Size size2 = new Size(94, 21);
		((Control)corrBasisButton).Size = size2;
		((Control)corrBasisButton).TabIndex = 18;
		((ButtonBase)corrBasisButton).Text = "Correction basis";
		((ButtonBase)corrBasisButton).UseVisualStyleBackColor = true;
		((Control)corrBasisButton).Visible = false;
		((Control)importButton).Anchor = (AnchorStyles)9;
		Point location3 = new Point(110, 45);
		((Control)importButton).Location = location3;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Padding margin3);
		((Padding)(ref margin3))._002Ector(0);
		((Control)importButton).Margin = margin3;
		((Control)importButton).Name = "importButton";
		Size size3 = new Size(48, 21);
		((Control)importButton).Size = size3;
		((Control)importButton).TabIndex = 14;
		((ButtonBase)importButton).Text = "Import";
		((ButtonBase)importButton).UseVisualStyleBackColor = true;
		((Control)importButton).Visible = false;
		((Control)exportButton).Anchor = (AnchorStyles)9;
		Point location4 = new Point(158, 45);
		((Control)exportButton).Location = location4;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Padding margin4);
		((Padding)(ref margin4))._002Ector(0);
		((Control)exportButton).Margin = margin4;
		((Control)exportButton).Name = "exportButton";
		Size size4 = new Size(48, 21);
		((Control)exportButton).Size = size4;
		((Control)exportButton).TabIndex = 16;
		((ButtonBase)exportButton).Text = "Export";
		((ButtonBase)exportButton).UseVisualStyleBackColor = true;
		((Control)exportButton).Visible = false;
		infoLabel.AutoSize = true;
		Point location5 = new Point(2, 48);
		((Control)infoLabel).Location = location5;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Padding margin5);
		((Padding)(ref margin5))._002Ector(0, 1, 0, 1);
		((Control)infoLabel).Margin = margin5;
		((Control)infoLabel).Name = "infoLabel";
		Size size5 = new Size(24, 13);
		((Control)infoLabel).Size = size5;
		((Control)infoLabel).TabIndex = 71;
		infoLabel.Text = "Na.";
		((Control)colorPanel).Anchor = (AnchorStyles)9;
		Color red = Color.Red;
		((Control)colorPanel).BackColor = red;
		colorPanel.BorderStyle = (BorderStyle)1;
		Point location6 = new Point(185, 1);
		((Control)colorPanel).Location = location6;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Padding margin6);
		((Padding)(ref margin6))._002Ector(0, 1, 0, 1);
		((Control)colorPanel).Margin = margin6;
		((Control)colorPanel).Name = "colorPanel";
		Size size6 = new Size(20, 20);
		((Control)colorPanel).Size = size6;
		((Control)colorPanel).TabIndex = 3;
		((ButtonBase)plotCheckBox).AutoSize = true;
		plotCheckBox.Checked = true;
		plotCheckBox.CheckState = (CheckState)1;
		((Control)plotCheckBox).Font = new Font("Arial", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		Point location7 = new Point(2, 2);
		((Control)plotCheckBox).Location = location7;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Padding margin7);
		((Padding)(ref margin7))._002Ector(0);
		((Control)plotCheckBox).Margin = margin7;
		((Control)plotCheckBox).Name = "plotCheckBox";
		Size size7 = new Size(15, 14);
		((Control)plotCheckBox).Size = size7;
		((Control)plotCheckBox).TabIndex = 1;
		((ButtonBase)plotCheckBox).UseVisualStyleBackColor = true;
		((Control)listComboBox).Anchor = (AnchorStyles)13;
		Point location8 = new Point(17, 1);
		((Control)listComboBox).Location = location8;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Padding margin8);
		((Padding)(ref margin8))._002Ector(0, 1, 0, 1);
		((Control)listComboBox).Margin = margin8;
		listComboBox.MaxDropDownItems = 20;
		((Control)listComboBox).Name = "listComboBox";
		Size size8 = new Size(168, 21);
		((Control)listComboBox).Size = size8;
		((Control)listComboBox).TabIndex = 4;
		((Control)optionsButton).Anchor = (AnchorStyles)9;
		Point location9 = new Point(111, 23);
		((Control)optionsButton).Location = location9;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Padding margin9);
		((Padding)(ref margin9))._002Ector(0, 1, 0, 1);
		((Control)optionsButton).Margin = margin9;
		((Control)optionsButton).Name = "optionsButton";
		Size size9 = new Size(59, 21);
		((Control)optionsButton).Size = size9;
		((Control)optionsButton).TabIndex = 10;
		((ButtonBase)optionsButton).Text = "Options";
		((ButtonBase)optionsButton).UseVisualStyleBackColor = true;
		((Control)slotUpDown).Anchor = (AnchorStyles)9;
		Point location10 = new Point(170, 23);
		((Control)slotUpDown).Location = location10;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Padding margin10);
		((Padding)(ref margin10))._002Ector(0, 1, 0, 1);
		((Control)slotUpDown).Margin = margin10;
		decimal maximum = new decimal(new int[4] { 99, 0, 0, 0 });
		slotUpDown.Maximum = maximum;
		((Control)slotUpDown).Name = "slotUpDown";
		Size size10 = new Size(37, 20);
		((Control)slotUpDown).Size = size10;
		((Control)slotUpDown).TabIndex = 12;
		((UpDownBase)slotUpDown).TextAlign = (HorizontalAlignment)1;
		decimal value = new decimal(new int[4] { 12, 0, 0, 0 });
		slotUpDown.Value = value;
		((Control)measureButton).Anchor = (AnchorStyles)13;
		Point location11 = new Point(0, 23);
		((Control)measureButton).Location = location11;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Padding margin11);
		((Padding)(ref margin11))._002Ector(0, 1, 0, 1);
		((Control)measureButton).Margin = margin11;
		((Control)measureButton).Name = "measureButton";
		Size size11 = new Size(111, 21);
		((Control)measureButton).Size = size11;
		((Control)measureButton).TabIndex = 6;
		((ButtonBase)measureButton).Text = "Measure";
		((ButtonBase)measureButton).UseVisualStyleBackColor = true;
		tableLayoutPanel.CellBorderStyle = (TableLayoutPanelCellBorderStyle)2;
		tableLayoutPanel.ColumnCount = 1;
		tableLayoutPanel.ColumnStyles.Add(new ColumnStyle((SizeType)2, 50f));
		tableLayoutPanel.Controls.Add((Control)(object)panel, 0, 0);
		((Control)tableLayoutPanel).Dock = (DockStyle)5;
		Point location12 = new Point(0, 0);
		((Control)tableLayoutPanel).Location = location12;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Padding margin12);
		((Padding)(ref margin12))._002Ector(0);
		((Control)tableLayoutPanel).Margin = margin12;
		((Control)tableLayoutPanel).Name = "tableLayoutPanel";
		tableLayoutPanel.RowCount = 1;
		tableLayoutPanel.RowStyles.Add(new RowStyle((SizeType)2, 50f));
		Size size12 = new Size(210, 70);
		((Control)tableLayoutPanel).Size = size12;
		((Control)tableLayoutPanel).TabIndex = 72;
		((Control)panel).Controls.Add((Control)(object)corrBasisButton);
		((Control)panel).Controls.Add((Control)(object)infoLabel);
		((Control)panel).Controls.Add((Control)(object)exportButton);
		((Control)panel).Controls.Add((Control)(object)info2Label);
		((Control)panel).Controls.Add((Control)(object)measureButton);
		((Control)panel).Controls.Add((Control)(object)importButton);
		((Control)panel).Controls.Add((Control)(object)slotUpDown);
		((Control)panel).Controls.Add((Control)(object)optionsButton);
		((Control)panel).Controls.Add((Control)(object)listComboBox);
		((Control)panel).Controls.Add((Control)(object)colorPanel);
		((Control)panel).Controls.Add((Control)(object)plotCheckBox);
		((Control)panel).Dock = (DockStyle)5;
		Point location13 = new Point(2, 2);
		((Control)panel).Location = location13;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Padding margin13);
		((Padding)(ref margin13))._002Ector(0);
		((Control)panel).Margin = margin13;
		((Control)panel).Name = "panel";
		Size size13 = new Size(206, 66);
		((Control)panel).Size = size13;
		((Control)panel).TabIndex = 73;
		((Control)this).Controls.Add((Control)(object)tableLayoutPanel);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Padding margin14);
		((Padding)(ref margin14))._002Ector(1, 5, 1, 5);
		((Control)this).Margin = margin14;
		((Control)this).Name = "ControlMeasPresenter";
		Size size14 = new Size(210, 70);
		((Control)this).Size = size14;
		((ISupportInitialize)slotUpDown).EndInit();
		((Control)tableLayoutPanel).ResumeLayout(false);
		((Control)panel).ResumeLayout(false);
		((Control)panel).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	protected override void Dispose([MarshalAs(UnmanagedType.U1)] bool P_0)
	{
		if (P_0)
		{
			try
			{
				_007EControlMeasPresenter();
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
