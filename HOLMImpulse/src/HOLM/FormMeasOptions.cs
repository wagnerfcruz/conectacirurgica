using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace HOLM;

public class FormMeasOptions : Form
{
	public NumericUpDown frSmoothNUpDown;

	public NumericUpDown shiftDBUpDown;

	public Label label5;

	public GroupBox timeWindowGroupBox;

	public RadioButton frSmoothRadioButton;

	public RadioButton timeWindowRadioButton;

	public Button timeWindowAutoButton;

	public Label label1;

	public NumericUpDown timeWindowEndUpDown;

	public GroupBox normGroupBox;

	private GroupBox groupBox2;

	public TextBox noteTextBox;

	public GroupBox timeOffsetGroupBox;

	public GroupBox frSmoothGroupBox;

	public NumericUpDown timeWindowStartUpDown;

	public Label label3;

	public Label timeWindowUnitLabel;

	public Label totalRespSmoothFactorLabel;

	public Button closeButton;

	public Panel colorPanel;

	public CheckBox timeStartLockedCheckBox;

	public Button clearButton;

	public GroupBox passGroupBox;

	public NumericUpDown lowpassUpDown;

	public CheckBox lowpassCheckBox;

	public CheckBox highpassCheckBox;

	public NumericUpDown highpassUpDown;

	public Button timeZeroAutoDetectButton;

	public NumericUpDown timeOffsetUpDown;

	public Label label7;

	public Panel modifyPanel;

	public NumericUpDown lowpassLUpDown;

	public NumericUpDown highpassLUpDown;

	public Label label6;

	public Label label4;

	public DomainUpDown timeOffsetIncDomain;

	public Label label8;

	public ComboBox timeZeroMethodComboBox;

	public Button infoButton;

	public RadioButton frSmoothAmpRadioButton;

	public RadioButton frSmoothComplexRadioButton;

	public RadioButton rawResponseRadioButton;

	public CheckBox ampInvertedCheckBox;

	private Container components;

	public FormMeasOptions()
	{
		try
		{
			InitializeComponent();
			timeOffsetIncDomain.SelectedIndex = 3;
			timeZeroMethodComboBox.SelectedIndex = 4;
			return;
		}
		catch
		{
			//try-fault
			((Form)this).Dispose(true);
			throw;
		}
	}

	private void _007EFormMeasOptions()
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
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected O, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected O, but got Unknown
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected O, but got Unknown
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected O, but got Unknown
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected O, but got Unknown
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected O, but got Unknown
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected O, but got Unknown
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Expected O, but got Unknown
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected O, but got Unknown
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Expected O, but got Unknown
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Expected O, but got Unknown
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Expected O, but got Unknown
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Expected O, but got Unknown
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Expected O, but got Unknown
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Expected O, but got Unknown
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Expected O, but got Unknown
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Expected O, but got Unknown
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Expected O, but got Unknown
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Expected O, but got Unknown
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Expected O, but got Unknown
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Expected O, but got Unknown
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Expected O, but got Unknown
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Expected O, but got Unknown
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Expected O, but got Unknown
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Expected O, but got Unknown
		//IL_0433: Unknown result type (might be due to invalid IL or missing references)
		//IL_0561: Unknown result type (might be due to invalid IL or missing references)
		//IL_0687: Unknown result type (might be due to invalid IL or missing references)
		//IL_0726: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0869: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a3e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ac8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ca0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d51: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e2f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eba: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f62: Unknown result type (might be due to invalid IL or missing references)
		//IL_1006: Unknown result type (might be due to invalid IL or missing references)
		//IL_1152: Unknown result type (might be due to invalid IL or missing references)
		//IL_1313: Unknown result type (might be due to invalid IL or missing references)
		//IL_13a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_1431: Unknown result type (might be due to invalid IL or missing references)
		//IL_164a: Unknown result type (might be due to invalid IL or missing references)
		//IL_16c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_175d: Unknown result type (might be due to invalid IL or missing references)
		//IL_17f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a14: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a94: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b12: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bc6: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ce1: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e80: Unknown result type (might be due to invalid IL or missing references)
		//IL_2019: Unknown result type (might be due to invalid IL or missing references)
		//IL_21c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_2243: Unknown result type (might be due to invalid IL or missing references)
		//IL_23c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_23d2: Expected O, but got Unknown
		frSmoothNUpDown = new NumericUpDown();
		shiftDBUpDown = new NumericUpDown();
		label5 = new Label();
		timeWindowGroupBox = new GroupBox();
		timeStartLockedCheckBox = new CheckBox();
		timeWindowAutoButton = new Button();
		timeWindowUnitLabel = new Label();
		timeWindowStartUpDown = new NumericUpDown();
		label3 = new Label();
		label1 = new Label();
		timeWindowEndUpDown = new NumericUpDown();
		timeWindowRadioButton = new RadioButton();
		frSmoothRadioButton = new RadioButton();
		normGroupBox = new GroupBox();
		ampInvertedCheckBox = new CheckBox();
		groupBox2 = new GroupBox();
		colorPanel = new Panel();
		noteTextBox = new TextBox();
		timeOffsetGroupBox = new GroupBox();
		timeZeroMethodComboBox = new ComboBox();
		timeOffsetIncDomain = new DomainUpDown();
		timeZeroAutoDetectButton = new Button();
		timeOffsetUpDown = new NumericUpDown();
		label7 = new Label();
		label8 = new Label();
		frSmoothGroupBox = new GroupBox();
		frSmoothComplexRadioButton = new RadioButton();
		frSmoothAmpRadioButton = new RadioButton();
		totalRespSmoothFactorLabel = new Label();
		closeButton = new Button();
		clearButton = new Button();
		passGroupBox = new GroupBox();
		label6 = new Label();
		label4 = new Label();
		lowpassLUpDown = new NumericUpDown();
		highpassLUpDown = new NumericUpDown();
		highpassCheckBox = new CheckBox();
		highpassUpDown = new NumericUpDown();
		lowpassCheckBox = new CheckBox();
		lowpassUpDown = new NumericUpDown();
		modifyPanel = new Panel();
		rawResponseRadioButton = new RadioButton();
		infoButton = new Button();
		((ISupportInitialize)frSmoothNUpDown).BeginInit();
		((ISupportInitialize)shiftDBUpDown).BeginInit();
		((Control)timeWindowGroupBox).SuspendLayout();
		((ISupportInitialize)timeWindowStartUpDown).BeginInit();
		((ISupportInitialize)timeWindowEndUpDown).BeginInit();
		((Control)normGroupBox).SuspendLayout();
		((Control)groupBox2).SuspendLayout();
		((Control)timeOffsetGroupBox).SuspendLayout();
		((ISupportInitialize)timeOffsetUpDown).BeginInit();
		((Control)frSmoothGroupBox).SuspendLayout();
		((Control)passGroupBox).SuspendLayout();
		((ISupportInitialize)lowpassLUpDown).BeginInit();
		((ISupportInitialize)highpassLUpDown).BeginInit();
		((ISupportInitialize)highpassUpDown).BeginInit();
		((ISupportInitialize)lowpassUpDown).BeginInit();
		((Control)modifyPanel).SuspendLayout();
		((Control)this).SuspendLayout();
		frSmoothNUpDown.DecimalPlaces = 1;
		Point location = new Point(141, 15);
		((Control)frSmoothNUpDown).Location = location;
		decimal maximum = new decimal(new int[4] { 50, 0, 0, 0 });
		frSmoothNUpDown.Maximum = maximum;
		decimal minimum = new decimal(new int[4] { 5, 0, 0, 65536 });
		frSmoothNUpDown.Minimum = minimum;
		((Control)frSmoothNUpDown).Name = "frSmoothNUpDown";
		((Control)frSmoothNUpDown).RightToLeft = (RightToLeft)0;
		Size size = new Size(45, 20);
		((Control)frSmoothNUpDown).Size = size;
		((Control)frSmoothNUpDown).TabIndex = 8;
		((Control)frSmoothNUpDown).TabStop = false;
		((UpDownBase)frSmoothNUpDown).TextAlign = (HorizontalAlignment)1;
		decimal value = new decimal(new int[4] { 10, 0, 0, 0 });
		frSmoothNUpDown.Value = value;
		shiftDBUpDown.DecimalPlaces = 1;
		decimal increment = new decimal(new int[4] { 5, 0, 0, 65536 });
		shiftDBUpDown.Increment = increment;
		Point location2 = new Point(162, 20);
		((Control)shiftDBUpDown).Location = location2;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Padding margin);
		((Padding)(ref margin))._002Ector(0);
		((Control)shiftDBUpDown).Margin = margin;
		decimal maximum2 = new decimal(new int[4] { 99, 0, 0, 0 });
		shiftDBUpDown.Maximum = maximum2;
		decimal minimum2 = new decimal(new int[4] { 99, 0, 0, -2147483648 });
		shiftDBUpDown.Minimum = minimum2;
		((Control)shiftDBUpDown).Name = "shiftDBUpDown";
		Size size2 = new Size(53, 20);
		((Control)shiftDBUpDown).Size = size2;
		((Control)shiftDBUpDown).TabIndex = 2;
		((UpDownBase)shiftDBUpDown).TextAlign = (HorizontalAlignment)1;
		decimal value2 = new decimal(new int[4] { 88, 0, 0, 0 });
		shiftDBUpDown.Value = value2;
		label5.AutoSize = true;
		Point location3 = new Point(103, 24);
		((Control)label5).Location = location3;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Padding margin2);
		((Padding)(ref margin2))._002Ector(0);
		((Control)label5).Margin = margin2;
		((Control)label5).Name = "label5";
		Size size3 = new Size(60, 13);
		((Control)label5).Size = size3;
		((Control)label5).TabIndex = 75;
		label5.Text = "Offset [dB]:";
		((Control)timeWindowGroupBox).Controls.Add((Control)(object)timeStartLockedCheckBox);
		((Control)timeWindowGroupBox).Controls.Add((Control)(object)timeWindowAutoButton);
		((Control)timeWindowGroupBox).Controls.Add((Control)(object)timeWindowUnitLabel);
		((Control)timeWindowGroupBox).Controls.Add((Control)(object)timeWindowStartUpDown);
		((Control)timeWindowGroupBox).Controls.Add((Control)(object)label3);
		((Control)timeWindowGroupBox).Controls.Add((Control)(object)label1);
		((Control)timeWindowGroupBox).Controls.Add((Control)(object)timeWindowEndUpDown);
		((Control)timeWindowGroupBox).Enabled = false;
		Point location4 = new Point(0, 171);
		((Control)timeWindowGroupBox).Location = location4;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Padding margin3);
		((Padding)(ref margin3))._002Ector(1);
		((Control)timeWindowGroupBox).Margin = margin3;
		((Control)timeWindowGroupBox).Name = "timeWindowGroupBox";
		Size size4 = new Size(220, 75);
		((Control)timeWindowGroupBox).Size = size4;
		((Control)timeWindowGroupBox).TabIndex = 6;
		timeWindowGroupBox.TabStop = false;
		((ButtonBase)timeStartLockedCheckBox).AutoSize = true;
		timeStartLockedCheckBox.Checked = true;
		timeStartLockedCheckBox.CheckState = (CheckState)1;
		Point location5 = new Point(7, 27);
		((Control)timeStartLockedCheckBox).Location = location5;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Padding margin4);
		((Padding)(ref margin4))._002Ector(1);
		((Control)timeStartLockedCheckBox).Margin = margin4;
		((Control)timeStartLockedCheckBox).Name = "timeStartLockedCheckBox";
		Size size5 = new Size(84, 17);
		((Control)timeStartLockedCheckBox).Size = size5;
		((Control)timeStartLockedCheckBox).TabIndex = 4;
		((ButtonBase)timeStartLockedCheckBox).Text = "From locked";
		((ButtonBase)timeStartLockedCheckBox).UseVisualStyleBackColor = true;
		((Control)timeStartLockedCheckBox).Visible = false;
		((Control)timeStartLockedCheckBox).Click += timeStartLockedCheckBox_Click;
		Point location6 = new Point(7, 49);
		((Control)timeWindowAutoButton).Location = location6;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Padding margin5);
		((Padding)(ref margin5))._002Ector(1);
		((Control)timeWindowAutoButton).Margin = margin5;
		((Control)timeWindowAutoButton).Name = "timeWindowAutoButton";
		Size size6 = new Size(80, 21);
		((Control)timeWindowAutoButton).Size = size6;
		((Control)timeWindowAutoButton).TabIndex = 6;
		((ButtonBase)timeWindowAutoButton).Text = "Auto detect";
		((ButtonBase)timeWindowAutoButton).UseVisualStyleBackColor = true;
		timeWindowUnitLabel.AutoSize = true;
		Point location7 = new Point(160, 10);
		((Control)timeWindowUnitLabel).Location = location7;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Padding margin6);
		((Padding)(ref margin6))._002Ector(1);
		((Control)timeWindowUnitLabel).Margin = margin6;
		((Control)timeWindowUnitLabel).Name = "timeWindowUnitLabel";
		Size size7 = new Size(51, 13);
		((Control)timeWindowUnitLabel).Size = size7;
		((Control)timeWindowUnitLabel).TabIndex = 66;
		timeWindowUnitLabel.Text = "[samples]";
		decimal increment2 = new decimal(new int[4] { 5, 0, 0, 0 });
		timeWindowStartUpDown.Increment = increment2;
		Point location8 = new Point(132, 27);
		((Control)timeWindowStartUpDown).Location = location8;
		decimal maximum3 = new decimal(new int[4] { 9999999, 0, 0, 0 });
		timeWindowStartUpDown.Maximum = maximum3;
		decimal minimum3 = new decimal(new int[4] { 9999999, 0, 0, -2147483648 });
		timeWindowStartUpDown.Minimum = minimum3;
		((Control)timeWindowStartUpDown).Name = "timeWindowStartUpDown";
		Size size8 = new Size(80, 20);
		((Control)timeWindowStartUpDown).Size = size8;
		((Control)timeWindowStartUpDown).TabIndex = 8;
		((UpDownBase)timeWindowStartUpDown).TextAlign = (HorizontalAlignment)1;
		decimal value3 = new decimal(new int[4] { 12345, 0, 0, 0 });
		timeWindowStartUpDown.Value = value3;
		label3.AutoSize = true;
		Point location9 = new Point(93, 53);
		((Control)label3).Location = location9;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Padding margin7);
		((Padding)(ref margin7))._002Ector(1);
		((Control)label3).Margin = margin7;
		((Control)label3).Name = "label3";
		Size size9 = new Size(23, 13);
		((Control)label3).Size = size9;
		((Control)label3).TabIndex = 67;
		label3.Text = "To:";
		label1.AutoSize = true;
		Point location10 = new Point(93, 29);
		((Control)label1).Location = location10;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Padding margin8);
		((Padding)(ref margin8))._002Ector(1);
		((Control)label1).Margin = margin8;
		((Control)label1).Name = "label1";
		Size size10 = new Size(33, 13);
		((Control)label1).Size = size10;
		((Control)label1).TabIndex = 60;
		label1.Text = "From:";
		decimal increment3 = new decimal(new int[4] { 5, 0, 0, 0 });
		timeWindowEndUpDown.Increment = increment3;
		Point location11 = new Point(132, 51);
		((Control)timeWindowEndUpDown).Location = location11;
		decimal maximum4 = new decimal(new int[4] { 9999999, 0, 0, 0 });
		timeWindowEndUpDown.Maximum = maximum4;
		decimal minimum4 = new decimal(new int[4] { 9999999, 0, 0, -2147483648 });
		timeWindowEndUpDown.Minimum = minimum4;
		((Control)timeWindowEndUpDown).Name = "timeWindowEndUpDown";
		Size size11 = new Size(80, 20);
		((Control)timeWindowEndUpDown).Size = size11;
		((Control)timeWindowEndUpDown).TabIndex = 10;
		((UpDownBase)timeWindowEndUpDown).TextAlign = (HorizontalAlignment)1;
		decimal value4 = new decimal(new int[4] { 12345, 0, 0, 0 });
		timeWindowEndUpDown.Value = value4;
		((ButtonBase)timeWindowRadioButton).AutoSize = true;
		Point location12 = new Point(3, 168);
		((Control)timeWindowRadioButton).Location = location12;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Padding margin9);
		((Padding)(ref margin9))._002Ector(1);
		((Control)timeWindowRadioButton).Margin = margin9;
		((Control)timeWindowRadioButton).Name = "timeWindowRadioButton";
		Size size12 = new Size(160, 17);
		((Control)timeWindowRadioButton).Size = size12;
		((Control)timeWindowRadioButton).TabIndex = 7;
		((ButtonBase)timeWindowRadioButton).Text = "Impulse time-window (gating)";
		((ButtonBase)timeWindowRadioButton).UseVisualStyleBackColor = true;
		timeWindowRadioButton.CheckedChanged += timeWindowRadioButton_CheckedChanged;
		((ButtonBase)frSmoothRadioButton).AutoSize = true;
		Point location13 = new Point(3, 250);
		((Control)frSmoothRadioButton).Location = location13;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Padding margin10);
		((Padding)(ref margin10))._002Ector(1);
		((Control)frSmoothRadioButton).Margin = margin10;
		((Control)frSmoothRadioButton).Name = "frSmoothRadioButton";
		Size size13 = new Size(172, 17);
		((Control)frSmoothRadioButton).Size = size13;
		((Control)frSmoothRadioButton).TabIndex = 8;
		((ButtonBase)frSmoothRadioButton).Text = "Frequency response smoothing";
		((ButtonBase)frSmoothRadioButton).UseVisualStyleBackColor = true;
		frSmoothRadioButton.CheckedChanged += frSmoothRadioButton_CheckedChanged;
		((Control)normGroupBox).Controls.Add((Control)(object)ampInvertedCheckBox);
		((Control)normGroupBox).Controls.Add((Control)(object)shiftDBUpDown);
		((Control)normGroupBox).Controls.Add((Control)(object)label5);
		Point location14 = new Point(0, 23);
		((Control)normGroupBox).Location = location14;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Padding margin11);
		((Padding)(ref margin11))._002Ector(1);
		((Control)normGroupBox).Margin = margin11;
		((Control)normGroupBox).Name = "normGroupBox";
		Size size14 = new Size(220, 47);
		((Control)normGroupBox).Size = size14;
		((Control)normGroupBox).TabIndex = 2;
		normGroupBox.TabStop = false;
		normGroupBox.Text = "Normalization";
		((ButtonBase)ampInvertedCheckBox).AutoSize = true;
		Point location15 = new Point(7, 20);
		((Control)ampInvertedCheckBox).Location = location15;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Padding margin12);
		((Padding)(ref margin12))._002Ector(1);
		((Control)ampInvertedCheckBox).Margin = margin12;
		((Control)ampInvertedCheckBox).Name = "ampInvertedCheckBox";
		Size size15 = new Size(53, 17);
		((Control)ampInvertedCheckBox).Size = size15;
		((Control)ampInvertedCheckBox).TabIndex = 76;
		((ButtonBase)ampInvertedCheckBox).Text = "Invert";
		((ButtonBase)ampInvertedCheckBox).UseVisualStyleBackColor = true;
		((Control)groupBox2).Controls.Add((Control)(object)colorPanel);
		((Control)groupBox2).Controls.Add((Control)(object)noteTextBox);
		Point location16 = new Point(2, 1);
		((Control)groupBox2).Location = location16;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Padding margin13);
		((Padding)(ref margin13))._002Ector(1);
		((Control)groupBox2).Margin = margin13;
		((Control)groupBox2).Name = "groupBox2";
		Size size16 = new Size(220, 42);
		((Control)groupBox2).Size = size16;
		((Control)groupBox2).TabIndex = 78;
		groupBox2.TabStop = false;
		groupBox2.Text = "Identification";
		Color red = Color.Red;
		((Control)colorPanel).BackColor = red;
		colorPanel.BorderStyle = (BorderStyle)2;
		Point location17 = new Point(193, 15);
		((Control)colorPanel).Location = location17;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Padding margin14);
		((Padding)(ref margin14))._002Ector(0);
		((Control)colorPanel).Margin = margin14;
		((Control)colorPanel).Name = "colorPanel";
		Size size17 = new Size(20, 21);
		((Control)colorPanel).Size = size17;
		((Control)colorPanel).TabIndex = 81;
		Point location18 = new Point(8, 16);
		((Control)noteTextBox).Location = location18;
		((Control)noteTextBox).Name = "noteTextBox";
		((TextBoxBase)noteTextBox).ReadOnly = true;
		Size size18 = new Size(181, 20);
		((Control)noteTextBox).Size = size18;
		((Control)noteTextBox).TabIndex = 80;
		((Control)noteTextBox).TabStop = false;
		((Control)timeOffsetGroupBox).Controls.Add((Control)(object)timeZeroMethodComboBox);
		((Control)timeOffsetGroupBox).Controls.Add((Control)(object)timeOffsetIncDomain);
		((Control)timeOffsetGroupBox).Controls.Add((Control)(object)timeZeroAutoDetectButton);
		((Control)timeOffsetGroupBox).Controls.Add((Control)(object)timeOffsetUpDown);
		((Control)timeOffsetGroupBox).Controls.Add((Control)(object)label7);
		((Control)timeOffsetGroupBox).Controls.Add((Control)(object)label8);
		Point location19 = new Point(0, 70);
		((Control)timeOffsetGroupBox).Location = location19;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Padding margin15);
		((Padding)(ref margin15))._002Ector(1);
		((Control)timeOffsetGroupBox).Margin = margin15;
		((Control)timeOffsetGroupBox).Name = "timeOffsetGroupBox";
		Size size19 = new Size(220, 75);
		((Control)timeOffsetGroupBox).Size = size19;
		((Control)timeOffsetGroupBox).TabIndex = 4;
		timeOffsetGroupBox.TabStop = false;
		timeOffsetGroupBox.Text = "Time zero";
		timeZeroMethodComboBox.DropDownStyle = (ComboBoxStyle)2;
		((ListControl)timeZeroMethodComboBox).FormattingEnabled = true;
		object[] array = new object[5] { "First postive peak", "Highest postive peak", "First peak", "Largest Peak", "Causal Impulse" };
		timeZeroMethodComboBox.Items.AddRange(array);
		Point location20 = new Point(4, 50);
		((Control)timeZeroMethodComboBox).Location = location20;
		((Control)timeZeroMethodComboBox).Name = "timeZeroMethodComboBox";
		Size size20 = new Size(112, 21);
		((Control)timeZeroMethodComboBox).Size = size20;
		((Control)timeZeroMethodComboBox).TabIndex = 19;
		timeOffsetIncDomain.Items.Add((object)"1000,000");
		timeOffsetIncDomain.Items.Add((object)"100,000");
		timeOffsetIncDomain.Items.Add((object)"10,000");
		timeOffsetIncDomain.Items.Add((object)"1,000");
		timeOffsetIncDomain.Items.Add((object)"0,100");
		timeOffsetIncDomain.Items.Add((object)"0,010");
		timeOffsetIncDomain.Items.Add((object)"0,001");
		Point location21 = new Point(141, 51);
		((Control)timeOffsetIncDomain).Location = location21;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Padding margin16);
		((Padding)(ref margin16))._002Ector(1);
		((Control)timeOffsetIncDomain).Margin = margin16;
		((Control)timeOffsetIncDomain).Name = "timeOffsetIncDomain";
		Size size21 = new Size(70, 20);
		((Control)timeOffsetIncDomain).Size = size21;
		((Control)timeOffsetIncDomain).TabIndex = 17;
		((UpDownBase)timeOffsetIncDomain).Text = "1,000";
		((UpDownBase)timeOffsetIncDomain).TextAlign = (HorizontalAlignment)1;
		timeOffsetIncDomain.SelectedItemChanged += timeOffsetIncDomain_SelectedItemChanged;
		Point location22 = new Point(7, 25);
		((Control)timeZeroAutoDetectButton).Location = location22;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Padding margin17);
		((Padding)(ref margin17))._002Ector(1);
		((Control)timeZeroAutoDetectButton).Margin = margin17;
		((Control)timeZeroAutoDetectButton).Name = "timeZeroAutoDetectButton";
		Size size22 = new Size(80, 21);
		((Control)timeZeroAutoDetectButton).Size = size22;
		((Control)timeZeroAutoDetectButton).TabIndex = 12;
		((ButtonBase)timeZeroAutoDetectButton).Text = "Auto detect";
		((ButtonBase)timeZeroAutoDetectButton).UseVisualStyleBackColor = true;
		timeOffsetUpDown.DecimalPlaces = 3;
		Point location23 = new Point(120, 28);
		((Control)timeOffsetUpDown).Location = location23;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Padding margin18);
		((Padding)(ref margin18))._002Ector(1);
		((Control)timeOffsetUpDown).Margin = margin18;
		decimal maximum5 = new decimal(new int[4] { 1000000, 0, 0, 0 });
		timeOffsetUpDown.Maximum = maximum5;
		decimal minimum5 = new decimal(new int[4] { 1000000, 0, 0, -2147483648 });
		timeOffsetUpDown.Minimum = minimum5;
		((Control)timeOffsetUpDown).Name = "timeOffsetUpDown";
		Size size23 = new Size(92, 20);
		((Control)timeOffsetUpDown).Size = size23;
		((Control)timeOffsetUpDown).TabIndex = 13;
		((UpDownBase)timeOffsetUpDown).TextAlign = (HorizontalAlignment)1;
		label7.AutoSize = true;
		Point location24 = new Point(129, 10);
		((Control)label7).Location = location24;
		((Control)label7).Name = "label7";
		Size size24 = new Size(82, 13);
		((Control)label7).Size = size24;
		((Control)label7).TabIndex = 14;
		label7.Text = "Offset [samples]";
		label8.AutoSize = true;
		Point location25 = new Point(117, 53);
		((Control)label8).Location = location25;
		((Control)label8).Name = "label8";
		Size size25 = new Size(25, 13);
		((Control)label8).Size = size25;
		((Control)label8).TabIndex = 18;
		label8.Text = "Inc:";
		((Control)frSmoothGroupBox).Controls.Add((Control)(object)frSmoothComplexRadioButton);
		((Control)frSmoothGroupBox).Controls.Add((Control)(object)frSmoothAmpRadioButton);
		((Control)frSmoothGroupBox).Controls.Add((Control)(object)totalRespSmoothFactorLabel);
		((Control)frSmoothGroupBox).Controls.Add((Control)(object)frSmoothNUpDown);
		((Control)frSmoothGroupBox).Enabled = false;
		Point location26 = new Point(0, 253);
		((Control)frSmoothGroupBox).Location = location26;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Padding margin19);
		((Padding)(ref margin19))._002Ector(1);
		((Control)frSmoothGroupBox).Margin = margin19;
		((Control)frSmoothGroupBox).Name = "frSmoothGroupBox";
		Size size26 = new Size(220, 90);
		((Control)frSmoothGroupBox).Size = size26;
		((Control)frSmoothGroupBox).TabIndex = 5;
		frSmoothGroupBox.TabStop = false;
		((ButtonBase)frSmoothComplexRadioButton).AutoSize = true;
		Point location27 = new Point(7, 56);
		((Control)frSmoothComplexRadioButton).Location = location27;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Padding margin20);
		((Padding)(ref margin20))._002Ector(1);
		((Control)frSmoothComplexRadioButton).Margin = margin20;
		((Control)frSmoothComplexRadioButton).Name = "frSmoothComplexRadioButton";
		Size size27 = new Size(190, 30);
		((Control)frSmoothComplexRadioButton).Size = size27;
		((Control)frSmoothComplexRadioButton).TabIndex = 12;
		((ButtonBase)frSmoothComplexRadioButton).Text = "Complex smoothing\r\n(Frequency dependent time-window)";
		((ButtonBase)frSmoothComplexRadioButton).UseVisualStyleBackColor = true;
		((ButtonBase)frSmoothAmpRadioButton).AutoSize = true;
		frSmoothAmpRadioButton.Checked = true;
		Point location28 = new Point(7, 37);
		((Control)frSmoothAmpRadioButton).Location = location28;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Padding margin21);
		((Padding)(ref margin21))._002Ector(1);
		((Control)frSmoothAmpRadioButton).Margin = margin21;
		((Control)frSmoothAmpRadioButton).Name = "frSmoothAmpRadioButton";
		Size size28 = new Size(201, 17);
		((Control)frSmoothAmpRadioButton).Size = size28;
		((Control)frSmoothAmpRadioButton).TabIndex = 10;
		frSmoothAmpRadioButton.TabStop = true;
		((ButtonBase)frSmoothAmpRadioButton).Text = "Amplitude smoothing (Total response)";
		((ButtonBase)frSmoothAmpRadioButton).UseVisualStyleBackColor = true;
		totalRespSmoothFactorLabel.AutoSize = true;
		Point location29 = new Point(4, 18);
		((Control)totalRespSmoothFactorLabel).Location = location29;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Padding margin22);
		((Padding)(ref margin22))._002Ector(1);
		((Control)totalRespSmoothFactorLabel).Margin = margin22;
		((Control)totalRespSmoothFactorLabel).Name = "totalRespSmoothFactorLabel";
		Size size29 = new Size(133, 13);
		((Control)totalRespSmoothFactorLabel).Size = size29;
		((Control)totalRespSmoothFactorLabel).TabIndex = 67;
		totalRespSmoothFactorLabel.Text = "1/N octave smoothing, N=";
		((Control)closeButton).Anchor = (AnchorStyles)6;
		Point location30 = new Point(2, 463);
		((Control)closeButton).Location = location30;
		((Control)closeButton).Name = "closeButton";
		Size size30 = new Size(220, 21);
		((Control)closeButton).Size = size30;
		((Control)closeButton).TabIndex = 12;
		((ButtonBase)closeButton).Text = "&Close";
		((ButtonBase)closeButton).UseVisualStyleBackColor = true;
		((Control)closeButton).Click += closeButton_Click;
		Point location31 = new Point(108, 3);
		((Control)clearButton).Location = location31;
		((Control)clearButton).Name = "clearButton";
		Size size31 = new Size(110, 21);
		((Control)clearButton).Size = size31;
		((Control)clearButton).TabIndex = 0;
		((ButtonBase)clearButton).Text = "Clear Measurement";
		((ButtonBase)clearButton).UseVisualStyleBackColor = true;
		((Control)passGroupBox).Controls.Add((Control)(object)label6);
		((Control)passGroupBox).Controls.Add((Control)(object)label4);
		((Control)passGroupBox).Controls.Add((Control)(object)lowpassLUpDown);
		((Control)passGroupBox).Controls.Add((Control)(object)highpassLUpDown);
		((Control)passGroupBox).Controls.Add((Control)(object)highpassCheckBox);
		((Control)passGroupBox).Controls.Add((Control)(object)highpassUpDown);
		((Control)passGroupBox).Controls.Add((Control)(object)lowpassCheckBox);
		((Control)passGroupBox).Controls.Add((Control)(object)lowpassUpDown);
		Point location32 = new Point(0, 343);
		((Control)passGroupBox).Location = location32;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Padding margin23);
		((Padding)(ref margin23))._002Ector(1);
		((Control)passGroupBox).Margin = margin23;
		((Control)passGroupBox).Name = "passGroupBox";
		Size size32 = new Size(220, 72);
		((Control)passGroupBox).Size = size32;
		((Control)passGroupBox).TabIndex = 10;
		passGroupBox.TabStop = false;
		label6.AutoSize = true;
		Point location33 = new Point(147, 12);
		((Control)label6).Location = location33;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Padding margin24);
		((Padding)(ref margin24))._002Ector(1);
		((Control)label6).Margin = margin24;
		((Control)label6).Name = "label6";
		Size size33 = new Size(62, 13);
		((Control)label6).Size = size33;
		((Control)label6).TabIndex = 69;
		label6.Text = "Length [Hz]";
		label4.AutoSize = true;
		Point location34 = new Point(87, 12);
		((Control)label4).Location = location34;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Padding margin25);
		((Padding)(ref margin25))._002Ector(1);
		((Control)label4).Margin = margin25;
		((Control)label4).Name = "label4";
		Size size34 = new Size(51, 13);
		((Control)label4).Size = size34;
		((Control)label4).TabIndex = 68;
		label4.Text = "Start [Hz]";
		((Control)lowpassLUpDown).Enabled = false;
		decimal increment4 = new decimal(new int[4] { 10, 0, 0, 0 });
		lowpassLUpDown.Increment = increment4;
		Point location35 = new Point(149, 49);
		((Control)lowpassLUpDown).Location = location35;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Padding margin26);
		((Padding)(ref margin26))._002Ector(1);
		((Control)lowpassLUpDown).Margin = margin26;
		decimal maximum6 = new decimal(new int[4] { 99999, 0, 0, 0 });
		lowpassLUpDown.Maximum = maximum6;
		((Control)lowpassLUpDown).Name = "lowpassLUpDown";
		Size size35 = new Size(55, 20);
		((Control)lowpassLUpDown).Size = size35;
		((Control)lowpassLUpDown).TabIndex = 6;
		((UpDownBase)lowpassLUpDown).TextAlign = (HorizontalAlignment)1;
		decimal value5 = new decimal(new int[4] { 10000, 0, 0, 0 });
		lowpassLUpDown.Value = value5;
		((Control)highpassLUpDown).Enabled = false;
		decimal increment5 = new decimal(new int[4] { 10, 0, 0, 0 });
		highpassLUpDown.Increment = increment5;
		Point location36 = new Point(149, 27);
		((Control)highpassLUpDown).Location = location36;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Padding margin27);
		((Padding)(ref margin27))._002Ector(1);
		((Control)highpassLUpDown).Margin = margin27;
		decimal maximum7 = new decimal(new int[4] { 99999, 0, 0, 0 });
		highpassLUpDown.Maximum = maximum7;
		((Control)highpassLUpDown).Name = "highpassLUpDown";
		Size size36 = new Size(55, 20);
		((Control)highpassLUpDown).Size = size36;
		((Control)highpassLUpDown).TabIndex = 3;
		((UpDownBase)highpassLUpDown).TextAlign = (HorizontalAlignment)1;
		decimal value6 = new decimal(new int[4] { 100, 0, 0, 0 });
		highpassLUpDown.Value = value6;
		((ButtonBase)highpassCheckBox).AutoSize = true;
		Point location37 = new Point(7, 27);
		((Control)highpassCheckBox).Location = location37;
		((Control)highpassCheckBox).Name = "highpassCheckBox";
		Size size37 = new Size(73, 17);
		((Control)highpassCheckBox).Size = size37;
		((Control)highpassCheckBox).TabIndex = 1;
		((ButtonBase)highpassCheckBox).Text = "Highpass:";
		((ButtonBase)highpassCheckBox).UseVisualStyleBackColor = true;
		highpassCheckBox.CheckedChanged += highpassCheckBox_CheckedChanged;
		((Control)highpassUpDown).Enabled = false;
		decimal increment6 = new decimal(new int[4] { 10, 0, 0, 0 });
		highpassUpDown.Increment = increment6;
		Point location38 = new Point(85, 27);
		((Control)highpassUpDown).Location = location38;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Padding margin28);
		((Padding)(ref margin28))._002Ector(1);
		((Control)highpassUpDown).Margin = margin28;
		decimal maximum8 = new decimal(new int[4] { 99999, 0, 0, 0 });
		highpassUpDown.Maximum = maximum8;
		((Control)highpassUpDown).Name = "highpassUpDown";
		Size size38 = new Size(55, 20);
		((Control)highpassUpDown).Size = size38;
		((Control)highpassUpDown).TabIndex = 2;
		((UpDownBase)highpassUpDown).TextAlign = (HorizontalAlignment)1;
		decimal value7 = new decimal(new int[4] { 100, 0, 0, 0 });
		highpassUpDown.Value = value7;
		((ButtonBase)lowpassCheckBox).AutoSize = true;
		Point location39 = new Point(7, 50);
		((Control)lowpassCheckBox).Location = location39;
		((Control)lowpassCheckBox).Name = "lowpassCheckBox";
		Size size39 = new Size(71, 17);
		((Control)lowpassCheckBox).Size = size39;
		((Control)lowpassCheckBox).TabIndex = 4;
		((ButtonBase)lowpassCheckBox).Text = "Lowpass:";
		((ButtonBase)lowpassCheckBox).UseVisualStyleBackColor = true;
		lowpassCheckBox.CheckedChanged += lowpassCheckBox_CheckedChanged;
		((Control)lowpassUpDown).Enabled = false;
		decimal increment7 = new decimal(new int[4] { 10, 0, 0, 0 });
		lowpassUpDown.Increment = increment7;
		Point location40 = new Point(85, 49);
		((Control)lowpassUpDown).Location = location40;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Padding margin29);
		((Padding)(ref margin29))._002Ector(1);
		((Control)lowpassUpDown).Margin = margin29;
		decimal maximum9 = new decimal(new int[4] { 99999, 0, 0, 0 });
		lowpassUpDown.Maximum = maximum9;
		((Control)lowpassUpDown).Name = "lowpassUpDown";
		Size size40 = new Size(55, 20);
		((Control)lowpassUpDown).Size = size40;
		((Control)lowpassUpDown).TabIndex = 5;
		((UpDownBase)lowpassUpDown).TextAlign = (HorizontalAlignment)1;
		decimal value8 = new decimal(new int[4] { 10000, 0, 0, 0 });
		lowpassUpDown.Value = value8;
		((Control)modifyPanel).Controls.Add((Control)(object)rawResponseRadioButton);
		((Control)modifyPanel).Controls.Add((Control)(object)infoButton);
		((Control)modifyPanel).Controls.Add((Control)(object)timeWindowRadioButton);
		((Control)modifyPanel).Controls.Add((Control)(object)clearButton);
		((Control)modifyPanel).Controls.Add((Control)(object)passGroupBox);
		((Control)modifyPanel).Controls.Add((Control)(object)timeOffsetGroupBox);
		((Control)modifyPanel).Controls.Add((Control)(object)frSmoothRadioButton);
		((Control)modifyPanel).Controls.Add((Control)(object)timeWindowGroupBox);
		((Control)modifyPanel).Controls.Add((Control)(object)frSmoothGroupBox);
		((Control)modifyPanel).Controls.Add((Control)(object)normGroupBox);
		Point location41 = new Point(2, 44);
		((Control)modifyPanel).Location = location41;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Padding margin30);
		((Padding)(ref margin30))._002Ector(0);
		((Control)modifyPanel).Margin = margin30;
		((Control)modifyPanel).Name = "modifyPanel";
		Size size41 = new Size(220, 415);
		((Control)modifyPanel).Size = size41;
		((Control)modifyPanel).TabIndex = 79;
		((ButtonBase)rawResponseRadioButton).AutoSize = true;
		rawResponseRadioButton.Checked = true;
		Point location42 = new Point(3, 147);
		((Control)rawResponseRadioButton).Location = location42;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Padding margin31);
		((Padding)(ref margin31))._002Ector(1);
		((Control)rawResponseRadioButton).Margin = margin31;
		((Control)rawResponseRadioButton).Name = "rawResponseRadioButton";
		Size size42 = new Size(93, 17);
		((Control)rawResponseRadioButton).Size = size42;
		((Control)rawResponseRadioButton).TabIndex = 6;
		rawResponseRadioButton.TabStop = true;
		((ButtonBase)rawResponseRadioButton).Text = "Raw response";
		((ButtonBase)rawResponseRadioButton).UseVisualStyleBackColor = true;
		Point location43 = new Point(7, 3);
		((Control)infoButton).Location = location43;
		((Control)infoButton).Name = "infoButton";
		Size size43 = new Size(80, 21);
		((Control)infoButton).Size = size43;
		((Control)infoButton).TabIndex = 11;
		((ButtonBase)infoButton).Text = "Info";
		((ButtonBase)infoButton).UseVisualStyleBackColor = true;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		Size clientSize = new Size(224, 485);
		((Form)this).ClientSize = clientSize;
		((Control)this).Controls.Add((Control)(object)modifyPanel);
		((Control)this).Controls.Add((Control)(object)closeButton);
		((Control)this).Controls.Add((Control)(object)groupBox2);
		((Form)this).FormBorderStyle = (FormBorderStyle)5;
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = "FormMeasOptions";
		((Form)this).ShowIcon = false;
		((Form)this).ShowInTaskbar = false;
		((Form)this).StartPosition = (FormStartPosition)4;
		((Form)this).Text = "Measurement Options";
		((Form)this).TopMost = true;
		((Form)this).FormClosing += new FormClosingEventHandler(FormMeasOptions_FormClosing);
		((ISupportInitialize)frSmoothNUpDown).EndInit();
		((ISupportInitialize)shiftDBUpDown).EndInit();
		((Control)timeWindowGroupBox).ResumeLayout(false);
		((Control)timeWindowGroupBox).PerformLayout();
		((ISupportInitialize)timeWindowStartUpDown).EndInit();
		((ISupportInitialize)timeWindowEndUpDown).EndInit();
		((Control)normGroupBox).ResumeLayout(false);
		((Control)normGroupBox).PerformLayout();
		((Control)groupBox2).ResumeLayout(false);
		((Control)groupBox2).PerformLayout();
		((Control)timeOffsetGroupBox).ResumeLayout(false);
		((Control)timeOffsetGroupBox).PerformLayout();
		((ISupportInitialize)timeOffsetUpDown).EndInit();
		((Control)frSmoothGroupBox).ResumeLayout(false);
		((Control)frSmoothGroupBox).PerformLayout();
		((Control)passGroupBox).ResumeLayout(false);
		((Control)passGroupBox).PerformLayout();
		((ISupportInitialize)lowpassLUpDown).EndInit();
		((ISupportInitialize)highpassLUpDown).EndInit();
		((ISupportInitialize)highpassUpDown).EndInit();
		((ISupportInitialize)lowpassUpDown).EndInit();
		((Control)modifyPanel).ResumeLayout(false);
		((Control)modifyPanel).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	private void closeButton_Click(object sender, EventArgs e)
	{
		((Control)this).Hide();
	}

	private void FormMeasOptions_FormClosing(object sender, FormClosingEventArgs e)
	{
		((CancelEventArgs)(object)e).Cancel = true;
		((Control)this).Hide();
	}

	private void timeWindowRadioButton_CheckedChanged(object sender, EventArgs e)
	{
		((Control)timeWindowGroupBox).Enabled = timeWindowRadioButton.Checked;
	}

	public void ShowPassGroupBox([MarshalAs(UnmanagedType.U1)] bool flag)
	{
		if (((Control)passGroupBox).Visible != flag)
		{
			((Control)passGroupBox).Visible = flag;
			if (flag)
			{
				((Control)this).Height = ((Control)passGroupBox).Height + ((Control)this).Height;
			}
			else
			{
				((Control)this).Height = ((Control)this).Height - ((Control)passGroupBox).Height;
			}
		}
	}

	public void ShowFRSmooth([MarshalAs(UnmanagedType.U1)] bool flag)
	{
		if (((Control)frSmoothGroupBox).Visible != flag)
		{
			((Control)frSmoothGroupBox).Visible = flag;
			if (flag)
			{
				((Control)this).Height = ((Control)frSmoothGroupBox).Height + ((Control)this).Height;
			}
			else
			{
				((Control)this).Height = ((Control)this).Height - ((Control)frSmoothGroupBox).Height;
			}
		}
	}

	private void timeStartLockedCheckBox_Click(object sender, EventArgs e)
	{
		byte enabled = ((!timeStartLockedCheckBox.Checked) ? ((byte)1) : ((byte)0));
		((Control)timeWindowStartUpDown).Enabled = enabled != 0;
	}

	private void timeOffsetIncDomain_SelectedItemChanged(object sender, EventArgs e)
	{
		int y = decimal.ToInt32(3 - timeOffsetIncDomain.SelectedIndex);
		decimal increment = new decimal(global::_003CModule_003E._Pow_int_003Cdouble_003E(10.0, y));
		timeOffsetUpDown.Increment = increment;
	}

	private void highpassCheckBox_CheckedChanged(object sender, EventArgs e)
	{
		((Control)highpassUpDown).Enabled = highpassCheckBox.Checked;
		((Control)highpassLUpDown).Enabled = highpassCheckBox.Checked;
	}

	private void lowpassCheckBox_CheckedChanged(object sender, EventArgs e)
	{
		((Control)lowpassUpDown).Enabled = lowpassCheckBox.Checked;
		((Control)lowpassLUpDown).Enabled = lowpassCheckBox.Checked;
	}

	private void frSmoothRadioButton_CheckedChanged(object sender, EventArgs e)
	{
		((Control)frSmoothGroupBox).Enabled = frSmoothRadioButton.Checked;
	}

	protected override void Dispose([MarshalAs(UnmanagedType.U1)] bool P_0)
	{
		if (P_0)
		{
			try
			{
				_007EFormMeasOptions();
				return;
			}
			finally
			{
				((Form)this).Dispose(true);
			}
		}
		((Form)this).Dispose(false);
	}
}
