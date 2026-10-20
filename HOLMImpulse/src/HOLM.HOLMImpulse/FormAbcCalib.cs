using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace HOLM.HOLMImpulse;

public class FormAbcCalib : Form
{
	public NumericUpDown refLowSlotUpDown;

	public TextBox refLowNoteTextBox;

	private GroupBox groupBox1;

	private Label label3;

	public NumericUpDown refCalSlotUpDown;

	public TextBox refCalNoteTextBox;

	private Label label2;

	public NumericUpDown refHighSlotUpDown;

	public TextBox refHighNoteTextBox;

	private Label label1;

	public Button updateButton;

	public Button cancelButton;

	private GroupBox groupBox2;

	public NumericUpDown stitchHighWidthUpDown;

	private Label label4;

	private Label label5;

	public NumericUpDown stitchHighCenterUpDown;

	private GroupBox groupBox3;

	private Label label10;

	private Label label11;

	public NumericUpDown winLowUpDown;

	private Label label8;

	private Label label9;

	public NumericUpDown winMidUpDown;

	private Label label6;

	private Label label7;

	public NumericUpDown winHighUpDown;

	private Label label12;

	private Label label13;

	private GroupBox groupBox4;

	private Label label14;

	public NumericUpDown stitchLowWidthUpDown;

	private Label label15;

	private Label label16;

	public NumericUpDown stitchLowCenterUpDown;

	private Label label17;

	public Button resetButton;

	private Container components;

	public FormAbcCalib()
	{
		try
		{
			InitializeComponent();
			return;
		}
		catch
		{
			//try-fault
			((Form)this).Dispose(true);
			throw;
		}
	}

	private void _007EFormAbcCalib()
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
		//IL_0269: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a48: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a52: Expected O, but got Unknown
		refLowSlotUpDown = new NumericUpDown();
		refLowNoteTextBox = new TextBox();
		groupBox1 = new GroupBox();
		label3 = new Label();
		label2 = new Label();
		refCalSlotUpDown = new NumericUpDown();
		refCalNoteTextBox = new TextBox();
		refHighSlotUpDown = new NumericUpDown();
		refHighNoteTextBox = new TextBox();
		label1 = new Label();
		updateButton = new Button();
		cancelButton = new Button();
		groupBox2 = new GroupBox();
		label13 = new Label();
		stitchHighWidthUpDown = new NumericUpDown();
		label4 = new Label();
		label5 = new Label();
		stitchHighCenterUpDown = new NumericUpDown();
		label12 = new Label();
		groupBox3 = new GroupBox();
		label10 = new Label();
		label11 = new Label();
		winLowUpDown = new NumericUpDown();
		label8 = new Label();
		label9 = new Label();
		winMidUpDown = new NumericUpDown();
		label6 = new Label();
		label7 = new Label();
		winHighUpDown = new NumericUpDown();
		groupBox4 = new GroupBox();
		label14 = new Label();
		stitchLowWidthUpDown = new NumericUpDown();
		label15 = new Label();
		label16 = new Label();
		stitchLowCenterUpDown = new NumericUpDown();
		label17 = new Label();
		resetButton = new Button();
		((ISupportInitialize)refLowSlotUpDown).BeginInit();
		((Control)groupBox1).SuspendLayout();
		((ISupportInitialize)refCalSlotUpDown).BeginInit();
		((ISupportInitialize)refHighSlotUpDown).BeginInit();
		((Control)groupBox2).SuspendLayout();
		((ISupportInitialize)stitchHighWidthUpDown).BeginInit();
		((ISupportInitialize)stitchHighCenterUpDown).BeginInit();
		((Control)groupBox3).SuspendLayout();
		((ISupportInitialize)winLowUpDown).BeginInit();
		((ISupportInitialize)winMidUpDown).BeginInit();
		((ISupportInitialize)winHighUpDown).BeginInit();
		((Control)groupBox4).SuspendLayout();
		((ISupportInitialize)stitchLowWidthUpDown).BeginInit();
		((ISupportInitialize)stitchLowCenterUpDown).BeginInit();
		((Control)this).SuspendLayout();
		Point location = new Point(256, 45);
		((Control)refLowSlotUpDown).Location = location;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Padding margin);
		((Padding)(ref margin))._002Ector(0, 1, 0, 1);
		((Control)refLowSlotUpDown).Margin = margin;
		decimal maximum = new decimal(new int[4] { 99, 0, 0, 0 });
		refLowSlotUpDown.Maximum = maximum;
		((Control)refLowSlotUpDown).Name = "refLowSlotUpDown";
		Size size = new Size(37, 20);
		((Control)refLowSlotUpDown).Size = size;
		((Control)refLowSlotUpDown).TabIndex = 13;
		((UpDownBase)refLowSlotUpDown).TextAlign = (HorizontalAlignment)1;
		decimal value = new decimal(new int[4] { 1, 0, 0, 0 });
		refLowSlotUpDown.Value = value;
		Point location2 = new Point(68, 44);
		((Control)refLowNoteTextBox).Location = location2;
		((Control)refLowNoteTextBox).Name = "refLowNoteTextBox";
		((TextBoxBase)refLowNoteTextBox).ReadOnly = true;
		Size size2 = new Size(181, 20);
		((Control)refLowNoteTextBox).Size = size2;
		((Control)refLowNoteTextBox).TabIndex = 81;
		((Control)groupBox1).Controls.Add((Control)(object)label3);
		((Control)groupBox1).Controls.Add((Control)(object)label2);
		((Control)groupBox1).Controls.Add((Control)(object)refCalSlotUpDown);
		((Control)groupBox1).Controls.Add((Control)(object)refCalNoteTextBox);
		((Control)groupBox1).Controls.Add((Control)(object)refHighSlotUpDown);
		((Control)groupBox1).Controls.Add((Control)(object)refHighNoteTextBox);
		((Control)groupBox1).Controls.Add((Control)(object)label1);
		((Control)groupBox1).Controls.Add((Control)(object)refLowSlotUpDown);
		((Control)groupBox1).Controls.Add((Control)(object)refLowNoteTextBox);
		Point location3 = new Point(3, 3);
		((Control)groupBox1).Location = location3;
		((Control)groupBox1).Name = "groupBox1";
		Size size3 = new Size(299, 100);
		((Control)groupBox1).Size = size3;
		((Control)groupBox1).TabIndex = 82;
		groupBox1.TabStop = false;
		groupBox1.Text = "Reference";
		label3.AutoSize = true;
		Point location4 = new Point(7, 20);
		((Control)label3).Location = location4;
		((Control)label3).Name = "label3";
		Size size4 = new Size(59, 13);
		((Control)label3).Size = size4;
		((Control)label3).TabIndex = 85;
		label3.Text = "Calibration:";
		label2.AutoSize = true;
		Point location5 = new Point(7, 75);
		((Control)label2).Location = location5;
		((Control)label2).Name = "label2";
		Size size5 = new Size(32, 13);
		((Control)label2).Size = size5;
		((Control)label2).TabIndex = 82;
		label2.Text = "High:";
		Point location6 = new Point(256, 17);
		((Control)refCalSlotUpDown).Location = location6;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Padding margin2);
		((Padding)(ref margin2))._002Ector(0, 1, 0, 1);
		((Control)refCalSlotUpDown).Margin = margin2;
		decimal maximum2 = new decimal(new int[4] { 99, 0, 0, 0 });
		refCalSlotUpDown.Maximum = maximum2;
		((Control)refCalSlotUpDown).Name = "refCalSlotUpDown";
		Size size6 = new Size(37, 20);
		((Control)refCalSlotUpDown).Size = size6;
		((Control)refCalSlotUpDown).TabIndex = 86;
		((UpDownBase)refCalSlotUpDown).TextAlign = (HorizontalAlignment)1;
		Point location7 = new Point(68, 17);
		((Control)refCalNoteTextBox).Location = location7;
		((Control)refCalNoteTextBox).Name = "refCalNoteTextBox";
		((TextBoxBase)refCalNoteTextBox).ReadOnly = true;
		Size size7 = new Size(181, 20);
		((Control)refCalNoteTextBox).Size = size7;
		((Control)refCalNoteTextBox).TabIndex = 87;
		Point location8 = new Point(256, 72);
		((Control)refHighSlotUpDown).Location = location8;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Padding margin3);
		((Padding)(ref margin3))._002Ector(0, 1, 0, 1);
		((Control)refHighSlotUpDown).Margin = margin3;
		decimal maximum3 = new decimal(new int[4] { 99, 0, 0, 0 });
		refHighSlotUpDown.Maximum = maximum3;
		((Control)refHighSlotUpDown).Name = "refHighSlotUpDown";
		Size size8 = new Size(37, 20);
		((Control)refHighSlotUpDown).Size = size8;
		((Control)refHighSlotUpDown).TabIndex = 83;
		((UpDownBase)refHighSlotUpDown).TextAlign = (HorizontalAlignment)1;
		decimal value2 = new decimal(new int[4] { 2, 0, 0, 0 });
		refHighSlotUpDown.Value = value2;
		Point location9 = new Point(68, 71);
		((Control)refHighNoteTextBox).Location = location9;
		((Control)refHighNoteTextBox).Name = "refHighNoteTextBox";
		((TextBoxBase)refHighNoteTextBox).ReadOnly = true;
		Size size9 = new Size(181, 20);
		((Control)refHighNoteTextBox).Size = size9;
		((Control)refHighNoteTextBox).TabIndex = 84;
		label1.AutoSize = true;
		Point location10 = new Point(7, 48);
		((Control)label1).Location = location10;
		((Control)label1).Name = "label1";
		Size size10 = new Size(30, 13);
		((Control)label1).Size = size10;
		((Control)label1).TabIndex = 0;
		label1.Text = "Low:";
		Point location11 = new Point(147, 303);
		((Control)updateButton).Location = location11;
		((Control)updateButton).Name = "updateButton";
		Size size11 = new Size(83, 23);
		((Control)updateButton).Size = size11;
		((Control)updateButton).TabIndex = 83;
		((ButtonBase)updateButton).Text = "&Update";
		((ButtonBase)updateButton).UseVisualStyleBackColor = true;
		cancelButton.DialogResult = (DialogResult)2;
		Point location12 = new Point(236, 303);
		((Control)cancelButton).Location = location12;
		((Control)cancelButton).Name = "cancelButton";
		Size size12 = new Size(66, 23);
		((Control)cancelButton).Size = size12;
		((Control)cancelButton).TabIndex = 84;
		((ButtonBase)cancelButton).Text = "&Close";
		((ButtonBase)cancelButton).UseVisualStyleBackColor = true;
		((Control)cancelButton).Click += cancelButton_Click;
		((Control)groupBox2).Controls.Add((Control)(object)label13);
		((Control)groupBox2).Controls.Add((Control)(object)stitchHighWidthUpDown);
		((Control)groupBox2).Controls.Add((Control)(object)label4);
		((Control)groupBox2).Controls.Add((Control)(object)label5);
		((Control)groupBox2).Controls.Add((Control)(object)stitchHighCenterUpDown);
		((Control)groupBox2).Controls.Add((Control)(object)label12);
		Point location13 = new Point(3, 207);
		((Control)groupBox2).Location = location13;
		((Control)groupBox2).Name = "groupBox2";
		Size size13 = new Size(299, 42);
		((Control)groupBox2).Size = size13;
		((Control)groupBox2).TabIndex = 85;
		groupBox2.TabStop = false;
		groupBox2.Text = "High stitch";
		label13.AutoSize = true;
		Point location14 = new Point(261, 16);
		((Control)label13).Location = location14;
		((Control)label13).Name = "label13";
		Size size14 = new Size(20, 13);
		((Control)label13).Size = size14;
		((Control)label13).TabIndex = 10;
		label13.Text = "Hz";
		decimal increment = new decimal(new int[4] { 5, 0, 0, 0 });
		stitchHighWidthUpDown.Increment = increment;
		Point location15 = new Point(199, 14);
		((Control)stitchHighWidthUpDown).Location = location15;
		decimal maximum4 = new decimal(new int[4] { 10000, 0, 0, 0 });
		stitchHighWidthUpDown.Maximum = maximum4;
		((Control)stitchHighWidthUpDown).Name = "stitchHighWidthUpDown";
		((Control)stitchHighWidthUpDown).RightToLeft = (RightToLeft)1;
		Size size15 = new Size(59, 20);
		((Control)stitchHighWidthUpDown).Size = size15;
		((Control)stitchHighWidthUpDown).TabIndex = 2;
		((UpDownBase)stitchHighWidthUpDown).UpDownAlign = (LeftRightAlignment)0;
		decimal value3 = new decimal(new int[4] { 150, 0, 0, 0 });
		stitchHighWidthUpDown.Value = value3;
		label4.AutoSize = true;
		Point location16 = new Point(158, 18);
		((Control)label4).Location = location16;
		((Control)label4).Name = "label4";
		Size size16 = new Size(38, 13);
		((Control)label4).Size = size16;
		((Control)label4).TabIndex = 2;
		label4.Text = "Width:";
		label5.AutoSize = true;
		Point location17 = new Point(9, 16);
		((Control)label5).Location = location17;
		((Control)label5).Name = "label5";
		Size size17 = new Size(60, 13);
		((Control)label5).Size = size17;
		((Control)label5).TabIndex = 1;
		label5.Text = "Frequency:";
		decimal increment2 = new decimal(new int[4] { 10, 0, 0, 0 });
		stitchHighCenterUpDown.Increment = increment2;
		Point location18 = new Point(72, 14);
		((Control)stitchHighCenterUpDown).Location = location18;
		decimal maximum5 = new decimal(new int[4] { 96000, 0, 0, 0 });
		stitchHighCenterUpDown.Maximum = maximum5;
		((Control)stitchHighCenterUpDown).Name = "stitchHighCenterUpDown";
		((Control)stitchHighCenterUpDown).RightToLeft = (RightToLeft)1;
		Size size18 = new Size(59, 20);
		((Control)stitchHighCenterUpDown).Size = size18;
		((Control)stitchHighCenterUpDown).TabIndex = 0;
		((UpDownBase)stitchHighCenterUpDown).UpDownAlign = (LeftRightAlignment)0;
		decimal value4 = new decimal(new int[4] { 1500, 0, 0, 0 });
		stitchHighCenterUpDown.Value = value4;
		label12.AutoSize = true;
		Point location19 = new Point(132, 18);
		((Control)label12).Location = location19;
		((Control)label12).Name = "label12";
		Size size19 = new Size(20, 13);
		((Control)label12).Size = size19;
		((Control)label12).TabIndex = 9;
		label12.Text = "Hz";
		((Control)groupBox3).Controls.Add((Control)(object)label10);
		((Control)groupBox3).Controls.Add((Control)(object)label11);
		((Control)groupBox3).Controls.Add((Control)(object)winLowUpDown);
		((Control)groupBox3).Controls.Add((Control)(object)label8);
		((Control)groupBox3).Controls.Add((Control)(object)label9);
		((Control)groupBox3).Controls.Add((Control)(object)winMidUpDown);
		((Control)groupBox3).Controls.Add((Control)(object)label6);
		((Control)groupBox3).Controls.Add((Control)(object)label7);
		((Control)groupBox3).Controls.Add((Control)(object)winHighUpDown);
		Point location20 = new Point(3, 109);
		((Control)groupBox3).Location = location20;
		((Control)groupBox3).Name = "groupBox3";
		Size size20 = new Size(299, 92);
		((Control)groupBox3).Size = size20;
		((Control)groupBox3).TabIndex = 86;
		groupBox3.TabStop = false;
		groupBox3.Text = "Impulse Domain Windows";
		label10.AutoSize = true;
		Point location21 = new Point(109, 69);
		((Control)label10).Location = location21;
		((Control)label10).Name = "label10";
		Size size21 = new Size(21, 13);
		((Control)label10).Size = size21;
		((Control)label10).TabIndex = 8;
		label10.Text = "cm";
		label11.AutoSize = true;
		Point location22 = new Point(10, 68);
		((Control)label11).Location = location22;
		((Control)label11).Name = "label11";
		Size size22 = new Size(30, 13);
		((Control)label11).Size = size22;
		((Control)label11).TabIndex = 7;
		label11.Text = "Low:";
		decimal increment3 = new decimal(new int[4] { 10, 0, 0, 0 });
		winLowUpDown.Increment = increment3;
		Point location23 = new Point(48, 66);
		((Control)winLowUpDown).Location = location23;
		decimal maximum6 = new decimal(new int[4] { 96000, 0, 0, 0 });
		winLowUpDown.Maximum = maximum6;
		((Control)winLowUpDown).Name = "winLowUpDown";
		((Control)winLowUpDown).RightToLeft = (RightToLeft)1;
		Size size23 = new Size(59, 20);
		((Control)winLowUpDown).Size = size23;
		((Control)winLowUpDown).TabIndex = 6;
		((UpDownBase)winLowUpDown).UpDownAlign = (LeftRightAlignment)0;
		decimal value5 = new decimal(new int[4] { 2000, 0, 0, 0 });
		winLowUpDown.Value = value5;
		label8.AutoSize = true;
		Point location24 = new Point(109, 46);
		((Control)label8).Location = location24;
		((Control)label8).Name = "label8";
		Size size24 = new Size(21, 13);
		((Control)label8).Size = size24;
		((Control)label8).TabIndex = 5;
		label8.Text = "cm";
		label9.AutoSize = true;
		Point location25 = new Point(10, 45);
		((Control)label9).Location = location25;
		((Control)label9).Name = "label9";
		Size size25 = new Size(27, 13);
		((Control)label9).Size = size25;
		((Control)label9).TabIndex = 4;
		label9.Text = "Mid:";
		decimal increment4 = new decimal(new int[4] { 10, 0, 0, 0 });
		winMidUpDown.Increment = increment4;
		Point location26 = new Point(48, 43);
		((Control)winMidUpDown).Location = location26;
		decimal maximum7 = new decimal(new int[4] { 96000, 0, 0, 0 });
		winMidUpDown.Maximum = maximum7;
		((Control)winMidUpDown).Name = "winMidUpDown";
		((Control)winMidUpDown).RightToLeft = (RightToLeft)1;
		Size size26 = new Size(59, 20);
		((Control)winMidUpDown).Size = size26;
		((Control)winMidUpDown).TabIndex = 3;
		((UpDownBase)winMidUpDown).UpDownAlign = (LeftRightAlignment)0;
		decimal value6 = new decimal(new int[4] { 150, 0, 0, 0 });
		winMidUpDown.Value = value6;
		label6.AutoSize = true;
		Point location27 = new Point(109, 22);
		((Control)label6).Location = location27;
		((Control)label6).Name = "label6";
		Size size27 = new Size(21, 13);
		((Control)label6).Size = size27;
		((Control)label6).TabIndex = 2;
		label6.Text = "cm";
		label7.AutoSize = true;
		Point location28 = new Point(10, 21);
		((Control)label7).Location = location28;
		((Control)label7).Name = "label7";
		Size size28 = new Size(32, 13);
		((Control)label7).Size = size28;
		((Control)label7).TabIndex = 1;
		label7.Text = "High:";
		decimal increment5 = new decimal(new int[4] { 10, 0, 0, 0 });
		winHighUpDown.Increment = increment5;
		Point location29 = new Point(48, 19);
		((Control)winHighUpDown).Location = location29;
		decimal maximum8 = new decimal(new int[4] { 96000, 0, 0, 0 });
		winHighUpDown.Maximum = maximum8;
		((Control)winHighUpDown).Name = "winHighUpDown";
		((Control)winHighUpDown).RightToLeft = (RightToLeft)1;
		Size size29 = new Size(59, 20);
		((Control)winHighUpDown).Size = size29;
		((Control)winHighUpDown).TabIndex = 0;
		((UpDownBase)winHighUpDown).UpDownAlign = (LeftRightAlignment)0;
		decimal value7 = new decimal(new int[4] { 50, 0, 0, 0 });
		winHighUpDown.Value = value7;
		((Control)groupBox4).Controls.Add((Control)(object)label14);
		((Control)groupBox4).Controls.Add((Control)(object)stitchLowWidthUpDown);
		((Control)groupBox4).Controls.Add((Control)(object)label15);
		((Control)groupBox4).Controls.Add((Control)(object)label16);
		((Control)groupBox4).Controls.Add((Control)(object)stitchLowCenterUpDown);
		((Control)groupBox4).Controls.Add((Control)(object)label17);
		Point location30 = new Point(3, 255);
		((Control)groupBox4).Location = location30;
		((Control)groupBox4).Name = "groupBox4";
		Size size30 = new Size(299, 42);
		((Control)groupBox4).Size = size30;
		((Control)groupBox4).TabIndex = 86;
		groupBox4.TabStop = false;
		groupBox4.Text = "Low  stitch";
		label14.AutoSize = true;
		Point location31 = new Point(261, 16);
		((Control)label14).Location = location31;
		((Control)label14).Name = "label14";
		Size size31 = new Size(20, 13);
		((Control)label14).Size = size31;
		((Control)label14).TabIndex = 10;
		label14.Text = "Hz";
		decimal increment6 = new decimal(new int[4] { 5, 0, 0, 0 });
		stitchLowWidthUpDown.Increment = increment6;
		Point location32 = new Point(199, 14);
		((Control)stitchLowWidthUpDown).Location = location32;
		decimal maximum9 = new decimal(new int[4] { 10000, 0, 0, 0 });
		stitchLowWidthUpDown.Maximum = maximum9;
		((Control)stitchLowWidthUpDown).Name = "stitchLowWidthUpDown";
		((Control)stitchLowWidthUpDown).RightToLeft = (RightToLeft)1;
		Size size32 = new Size(59, 20);
		((Control)stitchLowWidthUpDown).Size = size32;
		((Control)stitchLowWidthUpDown).TabIndex = 2;
		((UpDownBase)stitchLowWidthUpDown).UpDownAlign = (LeftRightAlignment)0;
		decimal value8 = new decimal(new int[4] { 10, 0, 0, 0 });
		stitchLowWidthUpDown.Value = value8;
		label15.AutoSize = true;
		Point location33 = new Point(158, 18);
		((Control)label15).Location = location33;
		((Control)label15).Name = "label15";
		Size size33 = new Size(38, 13);
		((Control)label15).Size = size33;
		((Control)label15).TabIndex = 2;
		label15.Text = "Width:";
		label16.AutoSize = true;
		Point location34 = new Point(9, 16);
		((Control)label16).Location = location34;
		((Control)label16).Name = "label16";
		Size size34 = new Size(60, 13);
		((Control)label16).Size = size34;
		((Control)label16).TabIndex = 1;
		label16.Text = "Frequency:";
		decimal increment7 = new decimal(new int[4] { 10, 0, 0, 0 });
		stitchLowCenterUpDown.Increment = increment7;
		Point location35 = new Point(72, 14);
		((Control)stitchLowCenterUpDown).Location = location35;
		decimal maximum10 = new decimal(new int[4] { 96000, 0, 0, 0 });
		stitchLowCenterUpDown.Maximum = maximum10;
		((Control)stitchLowCenterUpDown).Name = "stitchLowCenterUpDown";
		((Control)stitchLowCenterUpDown).RightToLeft = (RightToLeft)1;
		Size size35 = new Size(59, 20);
		((Control)stitchLowCenterUpDown).Size = size35;
		((Control)stitchLowCenterUpDown).TabIndex = 0;
		((UpDownBase)stitchLowCenterUpDown).UpDownAlign = (LeftRightAlignment)0;
		decimal value9 = new decimal(new int[4] { 100, 0, 0, 0 });
		stitchLowCenterUpDown.Value = value9;
		label17.AutoSize = true;
		Point location36 = new Point(132, 18);
		((Control)label17).Location = location36;
		((Control)label17).Name = "label17";
		Size size36 = new Size(20, 13);
		((Control)label17).Size = size36;
		((Control)label17).TabIndex = 9;
		label17.Text = "Hz";
		Point location37 = new Point(94, 303);
		((Control)resetButton).Location = location37;
		((Control)resetButton).Name = "resetButton";
		Size size37 = new Size(47, 23);
		((Control)resetButton).Size = size37;
		((Control)resetButton).TabIndex = 87;
		((ButtonBase)resetButton).Text = "Reset";
		((ButtonBase)resetButton).UseVisualStyleBackColor = true;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		Size clientSize = new Size(305, 331);
		((Form)this).ClientSize = clientSize;
		((Control)this).Controls.Add((Control)(object)resetButton);
		((Control)this).Controls.Add((Control)(object)groupBox4);
		((Control)this).Controls.Add((Control)(object)groupBox3);
		((Control)this).Controls.Add((Control)(object)groupBox2);
		((Control)this).Controls.Add((Control)(object)updateButton);
		((Control)this).Controls.Add((Control)(object)cancelButton);
		((Control)this).Controls.Add((Control)(object)groupBox1);
		((Form)this).FormBorderStyle = (FormBorderStyle)5;
		((Control)this).Name = "FormAbcCalib";
		((Form)this).ShowIcon = false;
		((Form)this).ShowInTaskbar = false;
		((Form)this).StartPosition = (FormStartPosition)1;
		((Form)this).Text = "Make  C = Calibration(A, B)";
		((Form)this).TopMost = true;
		((Form)this).FormClosing += new FormClosingEventHandler(FormAbcCalib_FormClosing);
		((ISupportInitialize)refLowSlotUpDown).EndInit();
		((Control)groupBox1).ResumeLayout(false);
		((Control)groupBox1).PerformLayout();
		((ISupportInitialize)refCalSlotUpDown).EndInit();
		((ISupportInitialize)refHighSlotUpDown).EndInit();
		((Control)groupBox2).ResumeLayout(false);
		((Control)groupBox2).PerformLayout();
		((ISupportInitialize)stitchHighWidthUpDown).EndInit();
		((ISupportInitialize)stitchHighCenterUpDown).EndInit();
		((Control)groupBox3).ResumeLayout(false);
		((Control)groupBox3).PerformLayout();
		((ISupportInitialize)winLowUpDown).EndInit();
		((ISupportInitialize)winMidUpDown).EndInit();
		((ISupportInitialize)winHighUpDown).EndInit();
		((Control)groupBox4).ResumeLayout(false);
		((Control)groupBox4).PerformLayout();
		((ISupportInitialize)stitchLowWidthUpDown).EndInit();
		((ISupportInitialize)stitchLowCenterUpDown).EndInit();
		((Control)this).ResumeLayout(false);
	}

	private void cancelButton_Click(object sender, EventArgs e)
	{
		((Control)this).Hide();
	}

	private void FormAbcCalib_FormClosing(object sender, FormClosingEventArgs e)
	{
		((CancelEventArgs)(object)e).Cancel = true;
		((Control)this).Hide();
	}

	protected override void Dispose([MarshalAs(UnmanagedType.U1)] bool P_0)
	{
		if (P_0)
		{
			try
			{
				_007EFormAbcCalib();
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
