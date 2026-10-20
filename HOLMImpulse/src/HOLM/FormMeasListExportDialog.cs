using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace HOLM;

public class FormMeasListExportDialog : Form
{
	public Button cancelButton;

	public Button exportFreqButton;

	private GroupBox groupBox1;

	public CheckBox phaseExportCheckBox;

	public RadioButton phaseRadRadioButton;

	public RadioButton phaseDegressRadioButton;

	private GroupBox filenameGroupBox;

	public TextBox filenameTextBox;

	public Button browseButton;

	private GroupBox groupBox2;

	public RadioButton freqLogRadioButton;

	private GroupBox groupBox4;

	private Label label2;

	public NumericUpDown freqLinUpDown;

	public RadioButton freqLinRadioButton;

	private GroupBox groupBox3;

	private Label label1;

	public NumericUpDown freqLogNofUpDown;

	private GroupBox groupBox5;

	private Label label4;

	public NumericUpDown freqNonEqPhaseUpDown;

	private Label label3;

	public NumericUpDown freqNonEqDbUpDown;

	public RadioButton freqNonEqRadioButton;

	private GroupBox groupBox7;

	public TextBox commentTextBox;

	private Label label10;

	public CheckBox infoCheckBox;

	public RadioButton freqFFTRadioButton;

	public GroupBox freqRangeGroupBox;

	public NumericUpDown freq1;

	private Label label5;

	private Label label6;

	public NumericUpDown freq0;

	public RadioButton freqCustomRadioButton;

	public RadioButton freqFullrangeRadioButton;

	public Panel customPanel;

	public TabControl tabControl;

	public TabPage freqTabPage;

	public TabPage impulseTabPage;

	public GroupBox groupBox9;

	public NumericUpDown impulseToUpDown;

	private Label label7;

	private Label label8;

	public NumericUpDown impulseFromUpDown;

	private TabPage textOptionsTabPage;

	public Button exportImpulseButton;

	public GroupBox impulseTextOptionsGroupBox;

	public CheckBox impulseSampleNumbersCheckBox;

	public CheckBox phaseExtendCheckBox;

	private GroupBox groupBox8;

	public RadioButton sepCommaRadioButton;

	public RadioButton sepTabRadioButton;

	public RadioButton sepSemicolonRadioButton;

	public RadioButton sepSpaceRadioButton;

	private GroupBox groupBox6;

	public RadioButton decSepDotRadioButton;

	public RadioButton decSepCommaRadioButton;

	private Container components;

	public FormMeasListExportDialog()
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

	private void _007EFormMeasListExportDialog()
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
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Expected O, but got Unknown
		//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Expected O, but got Unknown
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Expected O, but got Unknown
		//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0205: Expected O, but got Unknown
		//IL_0206: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Expected O, but got Unknown
		//IL_0211: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Expected O, but got Unknown
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0226: Expected O, but got Unknown
		//IL_0227: Unknown result type (might be due to invalid IL or missing references)
		//IL_0231: Expected O, but got Unknown
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		//IL_023c: Expected O, but got Unknown
		//IL_023d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Expected O, but got Unknown
		//IL_0248: Unknown result type (might be due to invalid IL or missing references)
		//IL_0252: Expected O, but got Unknown
		//IL_0253: Unknown result type (might be due to invalid IL or missing references)
		//IL_025d: Expected O, but got Unknown
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0268: Expected O, but got Unknown
		//IL_0269: Unknown result type (might be due to invalid IL or missing references)
		//IL_0273: Expected O, but got Unknown
		//IL_0274: Unknown result type (might be due to invalid IL or missing references)
		//IL_027e: Expected O, but got Unknown
		//IL_1c2f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cf4: Unknown result type (might be due to invalid IL or missing references)
		//IL_1db8: Unknown result type (might be due to invalid IL or missing references)
		//IL_23ec: Unknown result type (might be due to invalid IL or missing references)
		cancelButton = new Button();
		exportFreqButton = new Button();
		groupBox1 = new GroupBox();
		phaseExtendCheckBox = new CheckBox();
		phaseExportCheckBox = new CheckBox();
		phaseRadRadioButton = new RadioButton();
		phaseDegressRadioButton = new RadioButton();
		filenameGroupBox = new GroupBox();
		filenameTextBox = new TextBox();
		browseButton = new Button();
		groupBox2 = new GroupBox();
		freqFFTRadioButton = new RadioButton();
		groupBox5 = new GroupBox();
		label4 = new Label();
		freqNonEqPhaseUpDown = new NumericUpDown();
		label3 = new Label();
		freqNonEqDbUpDown = new NumericUpDown();
		freqNonEqRadioButton = new RadioButton();
		groupBox4 = new GroupBox();
		label2 = new Label();
		freqLinUpDown = new NumericUpDown();
		freqLinRadioButton = new RadioButton();
		groupBox3 = new GroupBox();
		label1 = new Label();
		freqLogNofUpDown = new NumericUpDown();
		freqLogRadioButton = new RadioButton();
		groupBox7 = new GroupBox();
		commentTextBox = new TextBox();
		label10 = new Label();
		infoCheckBox = new CheckBox();
		freqRangeGroupBox = new GroupBox();
		freqCustomRadioButton = new RadioButton();
		freqFullrangeRadioButton = new RadioButton();
		freq1 = new NumericUpDown();
		label5 = new Label();
		label6 = new Label();
		freq0 = new NumericUpDown();
		customPanel = new Panel();
		tabControl = new TabControl();
		freqTabPage = new TabPage();
		impulseTabPage = new TabPage();
		impulseTextOptionsGroupBox = new GroupBox();
		impulseSampleNumbersCheckBox = new CheckBox();
		exportImpulseButton = new Button();
		groupBox9 = new GroupBox();
		impulseToUpDown = new NumericUpDown();
		label7 = new Label();
		label8 = new Label();
		impulseFromUpDown = new NumericUpDown();
		textOptionsTabPage = new TabPage();
		groupBox8 = new GroupBox();
		sepCommaRadioButton = new RadioButton();
		sepTabRadioButton = new RadioButton();
		sepSemicolonRadioButton = new RadioButton();
		sepSpaceRadioButton = new RadioButton();
		groupBox6 = new GroupBox();
		decSepDotRadioButton = new RadioButton();
		decSepCommaRadioButton = new RadioButton();
		((Control)groupBox1).SuspendLayout();
		((Control)filenameGroupBox).SuspendLayout();
		((Control)groupBox2).SuspendLayout();
		((Control)groupBox5).SuspendLayout();
		((ISupportInitialize)freqNonEqPhaseUpDown).BeginInit();
		((ISupportInitialize)freqNonEqDbUpDown).BeginInit();
		((Control)groupBox4).SuspendLayout();
		((ISupportInitialize)freqLinUpDown).BeginInit();
		((Control)groupBox3).SuspendLayout();
		((ISupportInitialize)freqLogNofUpDown).BeginInit();
		((Control)groupBox7).SuspendLayout();
		((Control)freqRangeGroupBox).SuspendLayout();
		((ISupportInitialize)freq1).BeginInit();
		((ISupportInitialize)freq0).BeginInit();
		((Control)customPanel).SuspendLayout();
		((Control)tabControl).SuspendLayout();
		((Control)freqTabPage).SuspendLayout();
		((Control)impulseTabPage).SuspendLayout();
		((Control)impulseTextOptionsGroupBox).SuspendLayout();
		((Control)groupBox9).SuspendLayout();
		((ISupportInitialize)impulseToUpDown).BeginInit();
		((ISupportInitialize)impulseFromUpDown).BeginInit();
		((Control)textOptionsTabPage).SuspendLayout();
		((Control)groupBox8).SuspendLayout();
		((Control)groupBox6).SuspendLayout();
		((Control)this).SuspendLayout();
		cancelButton.DialogResult = (DialogResult)2;
		Point location = new Point(288, 84);
		((Control)cancelButton).Location = location;
		((Control)cancelButton).Name = "cancelButton";
		Size size = new Size(58, 25);
		((Control)cancelButton).Size = size;
		((Control)cancelButton).TabIndex = 9;
		((ButtonBase)cancelButton).Text = "&Close";
		((ButtonBase)cancelButton).UseVisualStyleBackColor = true;
		exportFreqButton.DialogResult = (DialogResult)1;
		((Control)exportFreqButton).Enabled = false;
		Point location2 = new Point(4, 3);
		((Control)exportFreqButton).Location = location2;
		((Control)exportFreqButton).Name = "exportFreqButton";
		Size size2 = new Size(262, 25);
		((Control)exportFreqButton).Size = size2;
		((Control)exportFreqButton).TabIndex = 6;
		((ButtonBase)exportFreqButton).Text = "&Export Frequency Response";
		((ButtonBase)exportFreqButton).UseVisualStyleBackColor = true;
		((Control)groupBox1).Controls.Add((Control)(object)phaseExtendCheckBox);
		((Control)groupBox1).Controls.Add((Control)(object)phaseExportCheckBox);
		((Control)groupBox1).Controls.Add((Control)(object)phaseRadRadioButton);
		((Control)groupBox1).Controls.Add((Control)(object)phaseDegressRadioButton);
		Point location3 = new Point(1, 2);
		((Control)groupBox1).Location = location3;
		((Control)groupBox1).Name = "groupBox1";
		Size size3 = new Size(262, 40);
		((Control)groupBox1).Size = size3;
		((Control)groupBox1).TabIndex = 8;
		groupBox1.TabStop = false;
		((ButtonBase)phaseExtendCheckBox).AutoSize = true;
		phaseExtendCheckBox.Checked = true;
		phaseExtendCheckBox.CheckState = (CheckState)1;
		Point location4 = new Point(163, 18);
		((Control)phaseExtendCheckBox).Location = location4;
		((Control)phaseExtendCheckBox).Name = "phaseExtendCheckBox";
		Size size4 = new Size(95, 17);
		((Control)phaseExtendCheckBox).Size = size4;
		((Control)phaseExtendCheckBox).TabIndex = 4;
		((ButtonBase)phaseExtendCheckBox).Text = "Unwrap phase";
		((ButtonBase)phaseExtendCheckBox).UseVisualStyleBackColor = true;
		((ButtonBase)phaseExportCheckBox).AutoSize = true;
		phaseExportCheckBox.Checked = true;
		phaseExportCheckBox.CheckState = (CheckState)1;
		Point location5 = new Point(9, -1);
		((Control)phaseExportCheckBox).Location = location5;
		((Control)phaseExportCheckBox).Name = "phaseExportCheckBox";
		Size size5 = new Size(89, 17);
		((Control)phaseExportCheckBox).Size = size5;
		((Control)phaseExportCheckBox).TabIndex = 2;
		((ButtonBase)phaseExportCheckBox).Text = "Export Phase";
		((ButtonBase)phaseExportCheckBox).UseVisualStyleBackColor = true;
		((ButtonBase)phaseRadRadioButton).AutoSize = true;
		Point location6 = new Point(79, 19);
		((Control)phaseRadRadioButton).Location = location6;
		((Control)phaseRadRadioButton).Name = "phaseRadRadioButton";
		Size size6 = new Size(64, 17);
		((Control)phaseRadRadioButton).Size = size6;
		((Control)phaseRadRadioButton).TabIndex = 1;
		((ButtonBase)phaseRadRadioButton).Text = "Radians";
		((ButtonBase)phaseRadRadioButton).UseVisualStyleBackColor = true;
		((ButtonBase)phaseDegressRadioButton).AutoSize = true;
		phaseDegressRadioButton.Checked = true;
		Point location7 = new Point(9, 19);
		((Control)phaseDegressRadioButton).Location = location7;
		((Control)phaseDegressRadioButton).Name = "phaseDegressRadioButton";
		Size size7 = new Size(65, 17);
		((Control)phaseDegressRadioButton).Size = size7;
		((Control)phaseDegressRadioButton).TabIndex = 0;
		phaseDegressRadioButton.TabStop = true;
		((ButtonBase)phaseDegressRadioButton).Text = "Degrees";
		((ButtonBase)phaseDegressRadioButton).UseVisualStyleBackColor = true;
		((Control)filenameGroupBox).Controls.Add((Control)(object)filenameTextBox);
		Point location8 = new Point(0, 3);
		((Control)filenameGroupBox).Location = location8;
		((Control)filenameGroupBox).Name = "filenameGroupBox";
		Size size8 = new Size(346, 45);
		((Control)filenameGroupBox).Size = size8;
		((Control)filenameGroupBox).TabIndex = 7;
		filenameGroupBox.TabStop = false;
		filenameGroupBox.Text = "Filename";
		((Control)filenameTextBox).Dock = (DockStyle)5;
		Point location9 = new Point(3, 16);
		((Control)filenameTextBox).Location = location9;
		((Control)filenameTextBox).Name = "filenameTextBox";
		Size size9 = new Size(340, 20);
		((Control)filenameTextBox).Size = size9;
		((Control)filenameTextBox).TabIndex = 1;
		((Control)filenameTextBox).TextChanged += filenameTextBox_TextChanged;
		Point location10 = new Point(288, 54);
		((Control)browseButton).Location = location10;
		((Control)browseButton).Name = "browseButton";
		Size size10 = new Size(58, 25);
		((Control)browseButton).Size = size10;
		((Control)browseButton).TabIndex = 0;
		((ButtonBase)browseButton).Text = "Browse";
		((ButtonBase)browseButton).UseVisualStyleBackColor = true;
		((Control)browseButton).Click += browseButton_Click;
		((Control)groupBox2).Controls.Add((Control)(object)freqFFTRadioButton);
		((Control)groupBox2).Controls.Add((Control)(object)groupBox5);
		((Control)groupBox2).Controls.Add((Control)(object)groupBox4);
		((Control)groupBox2).Controls.Add((Control)(object)groupBox3);
		Point location11 = new Point(2, 47);
		((Control)groupBox2).Location = location11;
		((Control)groupBox2).Name = "groupBox2";
		Size size11 = new Size(262, 210);
		((Control)groupBox2).Size = size11;
		((Control)groupBox2).TabIndex = 10;
		groupBox2.TabStop = false;
		groupBox2.Text = "Frequency increments";
		((ButtonBase)freqFFTRadioButton).AutoSize = true;
		freqFFTRadioButton.Checked = true;
		Point location12 = new Point(12, 19);
		((Control)freqFFTRadioButton).Location = location12;
		((Control)freqFFTRadioButton).Name = "freqFFTRadioButton";
		Size size12 = new Size(105, 17);
		((Control)freqFFTRadioButton).Size = size12;
		((Control)freqFFTRadioButton).TabIndex = 6;
		freqFFTRadioButton.TabStop = true;
		((ButtonBase)freqFFTRadioButton).Text = "FFT-Frequencies";
		((ButtonBase)freqFFTRadioButton).UseVisualStyleBackColor = true;
		((Control)freqFFTRadioButton).Click += Action_ExportModeClick;
		((Control)groupBox5).Controls.Add((Control)(object)label4);
		((Control)groupBox5).Controls.Add((Control)(object)freqNonEqPhaseUpDown);
		((Control)groupBox5).Controls.Add((Control)(object)label3);
		((Control)groupBox5).Controls.Add((Control)(object)freqNonEqDbUpDown);
		((Control)groupBox5).Controls.Add((Control)(object)freqNonEqRadioButton);
		Point location13 = new Point(6, 43);
		((Control)groupBox5).Location = location13;
		((Control)groupBox5).Name = "groupBox5";
		Size size13 = new Size(250, 65);
		((Control)groupBox5).Size = size13;
		((Control)groupBox5).TabIndex = 5;
		groupBox5.TabStop = false;
		label4.AutoSize = true;
		Point location14 = new Point(6, 41);
		((Control)label4).Location = location14;
		((Control)label4).Name = "label4";
		Size size14 = new Size(139, 13);
		((Control)label4).Size = size14;
		((Control)label4).TabIndex = 5;
		label4.Text = "Max change in phase [deg]:";
		freqNonEqPhaseUpDown.DecimalPlaces = 1;
		Point location15 = new Point(162, 39);
		((Control)freqNonEqPhaseUpDown).Location = location15;
		decimal maximum = new decimal(new int[4] { 10, 0, 0, 0 });
		freqNonEqPhaseUpDown.Maximum = maximum;
		decimal minimum = new decimal(new int[4] { 1, 0, 0, 65536 });
		freqNonEqPhaseUpDown.Minimum = minimum;
		((Control)freqNonEqPhaseUpDown).Name = "freqNonEqPhaseUpDown";
		Size size15 = new Size(52, 20);
		((Control)freqNonEqPhaseUpDown).Size = size15;
		((Control)freqNonEqPhaseUpDown).TabIndex = 4;
		((UpDownBase)freqNonEqPhaseUpDown).TextAlign = (HorizontalAlignment)1;
		decimal value = new decimal(new int[4] { 1, 0, 0, 0 });
		freqNonEqPhaseUpDown.Value = value;
		label3.AutoSize = true;
		Point location16 = new Point(6, 20);
		((Control)label3).Location = location16;
		((Control)label3).Name = "label3";
		Size size16 = new Size(150, 13);
		((Control)label3).Size = size16;
		((Control)label3).TabIndex = 3;
		label3.Text = "Max change in amplitude [dB]:";
		freqNonEqDbUpDown.DecimalPlaces = 2;
		decimal increment = new decimal(new int[4] { 1, 0, 0, 65536 });
		freqNonEqDbUpDown.Increment = increment;
		Point location17 = new Point(162, 18);
		((Control)freqNonEqDbUpDown).Location = location17;
		decimal maximum2 = new decimal(new int[4] { 10, 0, 0, 0 });
		freqNonEqDbUpDown.Maximum = maximum2;
		decimal minimum2 = new decimal(new int[4] { 1, 0, 0, 131072 });
		freqNonEqDbUpDown.Minimum = minimum2;
		((Control)freqNonEqDbUpDown).Name = "freqNonEqDbUpDown";
		Size size17 = new Size(52, 20);
		((Control)freqNonEqDbUpDown).Size = size17;
		((Control)freqNonEqDbUpDown).TabIndex = 2;
		((UpDownBase)freqNonEqDbUpDown).TextAlign = (HorizontalAlignment)1;
		decimal value2 = new decimal(new int[4] { 1, 0, 0, 65536 });
		freqNonEqDbUpDown.Value = value2;
		((ButtonBase)freqNonEqRadioButton).AutoSize = true;
		Point location18 = new Point(6, 0);
		((Control)freqNonEqRadioButton).Location = location18;
		((Control)freqNonEqRadioButton).Name = "freqNonEqRadioButton";
		Size size18 = new Size(100, 17);
		((Control)freqNonEqRadioButton).Size = size18;
		((Control)freqNonEqRadioButton).TabIndex = 0;
		((ButtonBase)freqNonEqRadioButton).Text = "Non-Equidistant";
		((ButtonBase)freqNonEqRadioButton).UseVisualStyleBackColor = true;
		((Control)freqNonEqRadioButton).Click += Action_ExportModeClick;
		((Control)groupBox4).Controls.Add((Control)(object)label2);
		((Control)groupBox4).Controls.Add((Control)(object)freqLinUpDown);
		((Control)groupBox4).Controls.Add((Control)(object)freqLinRadioButton);
		Point location19 = new Point(6, 112);
		((Control)groupBox4).Location = location19;
		((Control)groupBox4).Name = "groupBox4";
		Size size19 = new Size(250, 43);
		((Control)groupBox4).Size = size19;
		((Control)groupBox4).TabIndex = 4;
		groupBox4.TabStop = false;
		label2.AutoSize = true;
		Point location20 = new Point(6, 20);
		((Control)label2).Location = location20;
		((Control)label2).Name = "label2";
		Size size20 = new Size(79, 13);
		((Control)label2).Size = size20;
		((Control)label2).TabIndex = 3;
		label2.Text = "Increment [Hz]:";
		Point location21 = new Point(87, 18);
		((Control)freqLinUpDown).Location = location21;
		decimal maximum3 = new decimal(new int[4] { 10, 0, 0, 0 });
		freqLinUpDown.Maximum = maximum3;
		decimal minimum3 = new decimal(new int[4] { 1, 0, 0, 0 });
		freqLinUpDown.Minimum = minimum3;
		((Control)freqLinUpDown).Name = "freqLinUpDown";
		Size size21 = new Size(52, 20);
		((Control)freqLinUpDown).Size = size21;
		((Control)freqLinUpDown).TabIndex = 2;
		((UpDownBase)freqLinUpDown).TextAlign = (HorizontalAlignment)1;
		decimal value3 = new decimal(new int[4] { 10, 0, 0, 0 });
		freqLinUpDown.Value = value3;
		((ButtonBase)freqLinRadioButton).AutoSize = true;
		Point location22 = new Point(6, 0);
		((Control)freqLinRadioButton).Location = location22;
		((Control)freqLinRadioButton).Name = "freqLinRadioButton";
		Size size22 = new Size(54, 17);
		((Control)freqLinRadioButton).Size = size22;
		((Control)freqLinRadioButton).TabIndex = 0;
		((ButtonBase)freqLinRadioButton).Text = "Linear";
		((ButtonBase)freqLinRadioButton).UseVisualStyleBackColor = true;
		((Control)freqLinRadioButton).Click += Action_ExportModeClick;
		((Control)groupBox3).Controls.Add((Control)(object)label1);
		((Control)groupBox3).Controls.Add((Control)(object)freqLogNofUpDown);
		((Control)groupBox3).Controls.Add((Control)(object)freqLogRadioButton);
		Point location23 = new Point(6, 161);
		((Control)groupBox3).Location = location23;
		((Control)groupBox3).Name = "groupBox3";
		Size size23 = new Size(250, 43);
		((Control)groupBox3).Size = size23;
		((Control)groupBox3).TabIndex = 3;
		groupBox3.TabStop = false;
		label1.AutoSize = true;
		Point location24 = new Point(6, 20);
		((Control)label1).Location = location24;
		((Control)label1).Name = "label1";
		Size size24 = new Size(90, 13);
		((Control)label1).Size = size24;
		((Control)label1).TabIndex = 3;
		label1.Text = "Number of points:";
		Point location25 = new Point(99, 18);
		((Control)freqLogNofUpDown).Location = location25;
		decimal maximum4 = new decimal(new int[4] { 10000, 0, 0, 0 });
		freqLogNofUpDown.Maximum = maximum4;
		decimal minimum4 = new decimal(new int[4] { 10, 0, 0, 0 });
		freqLogNofUpDown.Minimum = minimum4;
		((Control)freqLogNofUpDown).Name = "freqLogNofUpDown";
		Size size25 = new Size(52, 20);
		((Control)freqLogNofUpDown).Size = size25;
		((Control)freqLogNofUpDown).TabIndex = 2;
		((UpDownBase)freqLogNofUpDown).TextAlign = (HorizontalAlignment)1;
		decimal value4 = new decimal(new int[4] { 1000, 0, 0, 0 });
		freqLogNofUpDown.Value = value4;
		((ButtonBase)freqLogRadioButton).AutoSize = true;
		Point location26 = new Point(6, 0);
		((Control)freqLogRadioButton).Location = location26;
		((Control)freqLogRadioButton).Name = "freqLogRadioButton";
		Size size26 = new Size(79, 17);
		((Control)freqLogRadioButton).Size = size26;
		((Control)freqLogRadioButton).TabIndex = 0;
		((ButtonBase)freqLogRadioButton).Text = "Logarithmic";
		((ButtonBase)freqLogRadioButton).UseVisualStyleBackColor = true;
		((Control)freqLogRadioButton).Click += Action_ExportModeClick;
		((Control)groupBox7).Controls.Add((Control)(object)commentTextBox);
		((Control)groupBox7).Controls.Add((Control)(object)label10);
		((Control)groupBox7).Controls.Add((Control)(object)infoCheckBox);
		Point location27 = new Point(4, 7);
		((Control)groupBox7).Location = location27;
		((Control)groupBox7).Name = "groupBox7";
		Size size27 = new Size(262, 45);
		((Control)groupBox7).Size = size27;
		((Control)groupBox7).TabIndex = 11;
		groupBox7.TabStop = false;
		Point location28 = new Point(141, 19);
		((Control)commentTextBox).Location = location28;
		((TextBoxBase)commentTextBox).MaxLength = 5;
		((Control)commentTextBox).Name = "commentTextBox";
		Size size28 = new Size(36, 20);
		((Control)commentTextBox).Size = size28;
		((Control)commentTextBox).TabIndex = 2;
		commentTextBox.Text = "#";
		commentTextBox.TextAlign = (HorizontalAlignment)1;
		label10.AutoSize = true;
		Point location29 = new Point(6, 22);
		((Control)label10).Location = location29;
		((Control)label10).Name = "label10";
		Size size29 = new Size(136, 13);
		((Control)label10).Size = size29;
		((Control)label10).TabIndex = 1;
		label10.Text = "Comment start character(s):";
		((ButtonBase)infoCheckBox).AutoSize = true;
		infoCheckBox.Checked = true;
		infoCheckBox.CheckState = (CheckState)1;
		Point location30 = new Point(6, 0);
		((Control)infoCheckBox).Location = location30;
		((Control)infoCheckBox).Name = "infoCheckBox";
		Size size30 = new Size(141, 17);
		((Control)infoCheckBox).Size = size30;
		((Control)infoCheckBox).TabIndex = 0;
		((ButtonBase)infoCheckBox).Text = "Information header in file";
		((ButtonBase)infoCheckBox).UseVisualStyleBackColor = true;
		((Control)freqRangeGroupBox).Controls.Add((Control)(object)freqCustomRadioButton);
		((Control)freqRangeGroupBox).Controls.Add((Control)(object)freqFullrangeRadioButton);
		((Control)freqRangeGroupBox).Controls.Add((Control)(object)freq1);
		((Control)freqRangeGroupBox).Controls.Add((Control)(object)label5);
		((Control)freqRangeGroupBox).Controls.Add((Control)(object)label6);
		((Control)freqRangeGroupBox).Controls.Add((Control)(object)freq0);
		Point location31 = new Point(4, 34);
		((Control)freqRangeGroupBox).Location = location31;
		((Control)freqRangeGroupBox).Name = "freqRangeGroupBox";
		Size size31 = new Size(262, 55);
		((Control)freqRangeGroupBox).Size = size31;
		((Control)freqRangeGroupBox).TabIndex = 13;
		freqRangeGroupBox.TabStop = false;
		freqRangeGroupBox.Text = "Frequency range";
		((ButtonBase)freqCustomRadioButton).AutoSize = true;
		Point location32 = new Point(189, 10);
		((Control)freqCustomRadioButton).Location = location32;
		((Control)freqCustomRadioButton).Name = "freqCustomRadioButton";
		Size size32 = new Size(60, 17);
		((Control)freqCustomRadioButton).Size = size32;
		((Control)freqCustomRadioButton).TabIndex = 7;
		((ButtonBase)freqCustomRadioButton).Text = "Custom";
		((ButtonBase)freqCustomRadioButton).UseVisualStyleBackColor = true;
		((ButtonBase)freqFullrangeRadioButton).AutoSize = true;
		freqFullrangeRadioButton.Checked = true;
		Point location33 = new Point(134, 10);
		((Control)freqFullrangeRadioButton).Location = location33;
		((Control)freqFullrangeRadioButton).Name = "freqFullrangeRadioButton";
		Size size33 = new Size(41, 17);
		((Control)freqFullrangeRadioButton).Size = size33;
		((Control)freqFullrangeRadioButton).TabIndex = 6;
		freqFullrangeRadioButton.TabStop = true;
		((ButtonBase)freqFullrangeRadioButton).Text = "Full";
		((ButtonBase)freqFullrangeRadioButton).UseVisualStyleBackColor = true;
		freqFullrangeRadioButton.CheckedChanged += freqFullrangeRadioButton_CheckedChanged;
		((Control)freq1).Enabled = false;
		decimal increment2 = new decimal(new int[4] { 10, 0, 0, 0 });
		freq1.Increment = increment2;
		Point location34 = new Point(184, 29);
		((Control)freq1).Location = location34;
		decimal maximum5 = new decimal(new int[4] { 192000, 0, 0, 0 });
		freq1.Maximum = maximum5;
		decimal minimum5 = new decimal(new int[4] { 100, 0, 0, 0 });
		freq1.Minimum = minimum5;
		((Control)freq1).Name = "freq1";
		Size size34 = new Size(64, 20);
		((Control)freq1).Size = size34;
		((Control)freq1).TabIndex = 5;
		((UpDownBase)freq1).TextAlign = (HorizontalAlignment)1;
		decimal value5 = new decimal(new int[4] { 22050, 0, 0, 0 });
		freq1.Value = value5;
		label5.AutoSize = true;
		Point location35 = new Point(137, 31);
		((Control)label5).Location = location35;
		((Control)label5).Name = "label5";
		Size size35 = new Size(41, 13);
		((Control)label5).Size = size35;
		((Control)label5).TabIndex = 4;
		label5.Text = "to [Hz]:";
		label6.AutoSize = true;
		Point location36 = new Point(12, 31);
		((Control)label6).Location = location36;
		((Control)label6).Name = "label6";
		Size size36 = new Size(55, 13);
		((Control)label6).Size = size36;
		((Control)label6).TabIndex = 3;
		label6.Text = "From [Hz]:";
		((Control)freq0).Enabled = false;
		Point location37 = new Point(66, 29);
		((Control)freq0).Location = location37;
		decimal maximum6 = new decimal(new int[4] { 100000, 0, 0, 0 });
		freq0.Maximum = maximum6;
		((Control)freq0).Name = "freq0";
		Size size37 = new Size(65, 20);
		((Control)freq0).Size = size37;
		((Control)freq0).TabIndex = 2;
		((UpDownBase)freq0).TextAlign = (HorizontalAlignment)1;
		decimal value6 = new decimal(new int[4] { 10, 0, 0, 0 });
		freq0.Value = value6;
		((Control)customPanel).Controls.Add((Control)(object)groupBox1);
		((Control)customPanel).Controls.Add((Control)(object)groupBox2);
		Point location38 = new Point(4, 95);
		((Control)customPanel).Location = location38;
		((Control)customPanel).Name = "customPanel";
		Size size38 = new Size(268, 260);
		((Control)customPanel).Size = size38;
		((Control)customPanel).TabIndex = 14;
		((Control)tabControl).Controls.Add((Control)(object)freqTabPage);
		((Control)tabControl).Controls.Add((Control)(object)impulseTabPage);
		((Control)tabControl).Controls.Add((Control)(object)textOptionsTabPage);
		Point location39 = new Point(0, 54);
		((Control)tabControl).Location = location39;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Padding margin);
		((Padding)(ref margin))._002Ector(1);
		((Control)tabControl).Margin = margin;
		((Control)tabControl).Name = "tabControl";
		tabControl.SelectedIndex = 0;
		Size size39 = new Size(280, 374);
		((Control)tabControl).Size = size39;
		((Control)tabControl).TabIndex = 15;
		((Control)freqTabPage).Controls.Add((Control)(object)customPanel);
		((Control)freqTabPage).Controls.Add((Control)(object)freqRangeGroupBox);
		((Control)freqTabPage).Controls.Add((Control)(object)exportFreqButton);
		Point location40 = new Point(4, 22);
		freqTabPage.Location = location40;
		((Control)freqTabPage).Name = "freqTabPage";
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Padding padding);
		((Padding)(ref padding))._002Ector(3);
		((Control)freqTabPage).Padding = padding;
		Size size40 = new Size(272, 348);
		((Control)freqTabPage).Size = size40;
		freqTabPage.TabIndex = 0;
		freqTabPage.Text = "Frequency";
		freqTabPage.UseVisualStyleBackColor = true;
		((Control)impulseTabPage).Controls.Add((Control)(object)impulseTextOptionsGroupBox);
		((Control)impulseTabPage).Controls.Add((Control)(object)exportImpulseButton);
		((Control)impulseTabPage).Controls.Add((Control)(object)groupBox9);
		Point location41 = new Point(4, 22);
		impulseTabPage.Location = location41;
		((Control)impulseTabPage).Name = "impulseTabPage";
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Padding padding2);
		((Padding)(ref padding2))._002Ector(3);
		((Control)impulseTabPage).Padding = padding2;
		Size size41 = new Size(272, 348);
		((Control)impulseTabPage).Size = size41;
		impulseTabPage.TabIndex = 1;
		impulseTabPage.Text = "Impulse";
		impulseTabPage.UseVisualStyleBackColor = true;
		((Control)impulseTextOptionsGroupBox).Controls.Add((Control)(object)impulseSampleNumbersCheckBox);
		Point location42 = new Point(5, 123);
		((Control)impulseTextOptionsGroupBox).Location = location42;
		((Control)impulseTextOptionsGroupBox).Name = "impulseTextOptionsGroupBox";
		Size size42 = new Size(262, 48);
		((Control)impulseTextOptionsGroupBox).Size = size42;
		((Control)impulseTextOptionsGroupBox).TabIndex = 4;
		impulseTextOptionsGroupBox.TabStop = false;
		impulseTextOptionsGroupBox.Text = "Text file options";
		((ButtonBase)impulseSampleNumbersCheckBox).AutoSize = true;
		impulseSampleNumbersCheckBox.Checked = true;
		impulseSampleNumbersCheckBox.CheckState = (CheckState)1;
		Point location43 = new Point(22, 20);
		((Control)impulseSampleNumbersCheckBox).Location = location43;
		((Control)impulseSampleNumbersCheckBox).Name = "impulseSampleNumbersCheckBox";
		Size size43 = new Size(187, 17);
		((Control)impulseSampleNumbersCheckBox).Size = size43;
		((Control)impulseSampleNumbersCheckBox).TabIndex = 0;
		((ButtonBase)impulseSampleNumbersCheckBox).Text = "Include sample numbers in text-file";
		((ButtonBase)impulseSampleNumbersCheckBox).UseVisualStyleBackColor = true;
		exportImpulseButton.DialogResult = (DialogResult)1;
		((Control)exportImpulseButton).Enabled = false;
		Point location44 = new Point(5, 6);
		((Control)exportImpulseButton).Location = location44;
		((Control)exportImpulseButton).Name = "exportImpulseButton";
		Size size44 = new Size(262, 25);
		((Control)exportImpulseButton).Size = size44;
		((Control)exportImpulseButton).TabIndex = 1;
		((ButtonBase)exportImpulseButton).Text = "Export impulse responses as text file";
		((ButtonBase)exportImpulseButton).UseVisualStyleBackColor = true;
		((Control)groupBox9).Controls.Add((Control)(object)impulseToUpDown);
		((Control)groupBox9).Controls.Add((Control)(object)label7);
		((Control)groupBox9).Controls.Add((Control)(object)label8);
		((Control)groupBox9).Controls.Add((Control)(object)impulseFromUpDown);
		Point location45 = new Point(5, 37);
		((Control)groupBox9).Location = location45;
		((Control)groupBox9).Name = "groupBox9";
		Size size45 = new Size(262, 80);
		((Control)groupBox9).Size = size45;
		((Control)groupBox9).TabIndex = 3;
		groupBox9.TabStop = false;
		groupBox9.Text = "Time window";
		decimal increment3 = new decimal(new int[4] { 10, 0, 0, 0 });
		impulseToUpDown.Increment = increment3;
		Point location46 = new Point(97, 48);
		((Control)impulseToUpDown).Location = location46;
		decimal maximum7 = new decimal(new int[4] { 600000, 0, 0, 0 });
		impulseToUpDown.Maximum = maximum7;
		decimal minimum6 = new decimal(new int[4] { 600000, 0, 0, -2147483648 });
		impulseToUpDown.Minimum = minimum6;
		((Control)impulseToUpDown).Name = "impulseToUpDown";
		Size size46 = new Size(85, 20);
		((Control)impulseToUpDown).Size = size46;
		((Control)impulseToUpDown).TabIndex = 5;
		((UpDownBase)impulseToUpDown).TextAlign = (HorizontalAlignment)1;
		decimal value7 = new decimal(new int[4] { 10000, 0, 0, 0 });
		impulseToUpDown.Value = value7;
		label7.AutoSize = true;
		Point location47 = new Point(19, 49);
		((Control)label7).Location = location47;
		((Control)label7).Name = "label7";
		Size size47 = new Size(58, 13);
		((Control)label7).Size = size47;
		((Control)label7).TabIndex = 4;
		label7.Text = "to [sample]";
		label8.AutoSize = true;
		Point location48 = new Point(19, 25);
		((Control)label8).Location = location48;
		((Control)label8).Name = "label8";
		Size size48 = new Size(72, 13);
		((Control)label8).Size = size48;
		((Control)label8).TabIndex = 3;
		label8.Text = "From [sample]";
		decimal increment4 = new decimal(new int[4] { 10, 0, 0, 0 });
		impulseFromUpDown.Increment = increment4;
		Point location49 = new Point(97, 22);
		((Control)impulseFromUpDown).Location = location49;
		decimal maximum8 = new decimal(new int[4] { 600000, 0, 0, 0 });
		impulseFromUpDown.Maximum = maximum8;
		decimal minimum7 = new decimal(new int[4] { 600000, 0, 0, -2147483648 });
		impulseFromUpDown.Minimum = minimum7;
		((Control)impulseFromUpDown).Name = "impulseFromUpDown";
		Size size49 = new Size(85, 20);
		((Control)impulseFromUpDown).Size = size49;
		((Control)impulseFromUpDown).TabIndex = 2;
		((UpDownBase)impulseFromUpDown).TextAlign = (HorizontalAlignment)1;
		decimal value8 = new decimal(new int[4] { 10000, 0, 0, -2147483648 });
		impulseFromUpDown.Value = value8;
		((Control)textOptionsTabPage).Controls.Add((Control)(object)groupBox8);
		((Control)textOptionsTabPage).Controls.Add((Control)(object)groupBox6);
		((Control)textOptionsTabPage).Controls.Add((Control)(object)groupBox7);
		Point location50 = new Point(4, 22);
		textOptionsTabPage.Location = location50;
		((Control)textOptionsTabPage).Name = "textOptionsTabPage";
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Padding padding3);
		((Padding)(ref padding3))._002Ector(3);
		((Control)textOptionsTabPage).Padding = padding3;
		Size size50 = new Size(272, 348);
		((Control)textOptionsTabPage).Size = size50;
		textOptionsTabPage.TabIndex = 2;
		textOptionsTabPage.Text = "Text Options";
		textOptionsTabPage.UseVisualStyleBackColor = true;
		((Control)groupBox8).Controls.Add((Control)(object)sepCommaRadioButton);
		((Control)groupBox8).Controls.Add((Control)(object)sepTabRadioButton);
		((Control)groupBox8).Controls.Add((Control)(object)sepSemicolonRadioButton);
		((Control)groupBox8).Controls.Add((Control)(object)sepSpaceRadioButton);
		Point location51 = new Point(4, 58);
		((Control)groupBox8).Location = location51;
		((Control)groupBox8).Name = "groupBox8";
		Size size51 = new Size(262, 66);
		((Control)groupBox8).Size = size51;
		((Control)groupBox8).TabIndex = 13;
		groupBox8.TabStop = false;
		groupBox8.Text = "Column separator";
		((ButtonBase)sepCommaRadioButton).AutoSize = true;
		Point location52 = new Point(6, 38);
		((Control)sepCommaRadioButton).Location = location52;
		((Control)sepCommaRadioButton).Name = "sepCommaRadioButton";
		Size size52 = new Size(72, 17);
		((Control)sepCommaRadioButton).Size = size52;
		((Control)sepCommaRadioButton).TabIndex = 7;
		((ButtonBase)sepCommaRadioButton).Text = ", (Comma)";
		((ButtonBase)sepCommaRadioButton).UseVisualStyleBackColor = true;
		((ButtonBase)sepTabRadioButton).AutoSize = true;
		Point location53 = new Point(93, 38);
		((Control)sepTabRadioButton).Location = location53;
		((Control)sepTabRadioButton).Name = "sepTabRadioButton";
		Size size53 = new Size(61, 17);
		((Control)sepTabRadioButton).Size = size53;
		((Control)sepTabRadioButton).TabIndex = 6;
		((ButtonBase)sepTabRadioButton).Text = "Tabular";
		((ButtonBase)sepTabRadioButton).UseVisualStyleBackColor = true;
		((ButtonBase)sepSemicolonRadioButton).AutoSize = true;
		sepSemicolonRadioButton.Checked = true;
		Point location54 = new Point(6, 15);
		((Control)sepSemicolonRadioButton).Location = location54;
		((Control)sepSemicolonRadioButton).Name = "sepSemicolonRadioButton";
		Size size54 = new Size(86, 17);
		((Control)sepSemicolonRadioButton).Size = size54;
		((Control)sepSemicolonRadioButton).TabIndex = 5;
		sepSemicolonRadioButton.TabStop = true;
		((ButtonBase)sepSemicolonRadioButton).Text = "; (Semicolon)";
		((ButtonBase)sepSemicolonRadioButton).UseVisualStyleBackColor = true;
		((ButtonBase)sepSpaceRadioButton).AutoSize = true;
		Point location55 = new Point(93, 15);
		((Control)sepSpaceRadioButton).Location = location55;
		((Control)sepSpaceRadioButton).Name = "sepSpaceRadioButton";
		Size size55 = new Size(56, 17);
		((Control)sepSpaceRadioButton).Size = size55;
		((Control)sepSpaceRadioButton).TabIndex = 4;
		((ButtonBase)sepSpaceRadioButton).Text = "Space";
		((ButtonBase)sepSpaceRadioButton).UseVisualStyleBackColor = true;
		((Control)groupBox6).Controls.Add((Control)(object)decSepDotRadioButton);
		((Control)groupBox6).Controls.Add((Control)(object)decSepCommaRadioButton);
		Point location56 = new Point(4, 130);
		((Control)groupBox6).Location = location56;
		((Control)groupBox6).Name = "groupBox6";
		Size size56 = new Size(262, 34);
		((Control)groupBox6).Size = size56;
		((Control)groupBox6).TabIndex = 12;
		groupBox6.TabStop = false;
		groupBox6.Text = "Decimal separator";
		((ButtonBase)decSepDotRadioButton).AutoSize = true;
		decSepDotRadioButton.Checked = true;
		Point location57 = new Point(9, 12);
		((Control)decSepDotRadioButton).Location = location57;
		((Control)decSepDotRadioButton).Name = "decSepDotRadioButton";
		Size size57 = new Size(54, 17);
		((Control)decSepDotRadioButton).Size = size57;
		((Control)decSepDotRadioButton).TabIndex = 5;
		decSepDotRadioButton.TabStop = true;
		((ButtonBase)decSepDotRadioButton).Text = ". (Dot)";
		((ButtonBase)decSepDotRadioButton).UseVisualStyleBackColor = true;
		((ButtonBase)decSepCommaRadioButton).AutoSize = true;
		Point location58 = new Point(69, 12);
		((Control)decSepCommaRadioButton).Location = location58;
		((Control)decSepCommaRadioButton).Name = "decSepCommaRadioButton";
		Size size58 = new Size(72, 17);
		((Control)decSepCommaRadioButton).Size = size58;
		((Control)decSepCommaRadioButton).TabIndex = 4;
		((ButtonBase)decSepCommaRadioButton).Text = ", (Comma)";
		((ButtonBase)decSepCommaRadioButton).UseVisualStyleBackColor = true;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		Size clientSize = new Size(348, 431);
		((Form)this).ClientSize = clientSize;
		((Control)this).Controls.Add((Control)(object)tabControl);
		((Control)this).Controls.Add((Control)(object)browseButton);
		((Control)this).Controls.Add((Control)(object)cancelButton);
		((Control)this).Controls.Add((Control)(object)filenameGroupBox);
		((Form)this).FormBorderStyle = (FormBorderStyle)5;
		((Control)this).Name = "FormMeasListExportDialog";
		((Form)this).ShowInTaskbar = false;
		((Form)this).Text = "Export all responses to file";
		((Form)this).TopMost = true;
		((Control)groupBox1).ResumeLayout(false);
		((Control)groupBox1).PerformLayout();
		((Control)filenameGroupBox).ResumeLayout(false);
		((Control)filenameGroupBox).PerformLayout();
		((Control)groupBox2).ResumeLayout(false);
		((Control)groupBox2).PerformLayout();
		((Control)groupBox5).ResumeLayout(false);
		((Control)groupBox5).PerformLayout();
		((ISupportInitialize)freqNonEqPhaseUpDown).EndInit();
		((ISupportInitialize)freqNonEqDbUpDown).EndInit();
		((Control)groupBox4).ResumeLayout(false);
		((Control)groupBox4).PerformLayout();
		((ISupportInitialize)freqLinUpDown).EndInit();
		((Control)groupBox3).ResumeLayout(false);
		((Control)groupBox3).PerformLayout();
		((ISupportInitialize)freqLogNofUpDown).EndInit();
		((Control)groupBox7).ResumeLayout(false);
		((Control)groupBox7).PerformLayout();
		((Control)freqRangeGroupBox).ResumeLayout(false);
		((Control)freqRangeGroupBox).PerformLayout();
		((ISupportInitialize)freq1).EndInit();
		((ISupportInitialize)freq0).EndInit();
		((Control)customPanel).ResumeLayout(false);
		((Control)tabControl).ResumeLayout(false);
		((Control)freqTabPage).ResumeLayout(false);
		((Control)impulseTabPage).ResumeLayout(false);
		((Control)impulseTextOptionsGroupBox).ResumeLayout(false);
		((Control)impulseTextOptionsGroupBox).PerformLayout();
		((Control)groupBox9).ResumeLayout(false);
		((Control)groupBox9).PerformLayout();
		((ISupportInitialize)impulseToUpDown).EndInit();
		((ISupportInitialize)impulseFromUpDown).EndInit();
		((Control)textOptionsTabPage).ResumeLayout(false);
		((Control)groupBox8).ResumeLayout(false);
		((Control)groupBox8).PerformLayout();
		((Control)groupBox6).ResumeLayout(false);
		((Control)groupBox6).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	private void browseButton_Click(object sender, EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Invalid comparison between Unknown and I4
		SaveFileDialog val = new SaveFileDialog();
		if (tabControl.SelectedTab != impulseTabPage)
		{
			((FileDialog)val).Filter = "ASCII text file (*.txt)|*.txt|" + "All Files (*.*)|*.*";
			((FileDialog)val).Title = "Save responses as text file";
		}
		if ((int)((CommonDialog)val).ShowDialog() == 1)
		{
			filenameTextBox.Text = ((FileDialog)val).FileName;
		}
		((IDisposable)val)?.Dispose();
	}

	private void Action_ExportModeClick(object sender, EventArgs e)
	{
		RadioButton val = freqFFTRadioButton;
		byte @checked = ((sender == val) ? ((byte)1) : ((byte)0));
		val.Checked = @checked != 0;
		RadioButton val2 = freqLinRadioButton;
		byte checked2 = ((sender == val2) ? ((byte)1) : ((byte)0));
		val2.Checked = checked2 != 0;
		RadioButton val3 = freqLogRadioButton;
		byte checked3 = ((sender == val3) ? ((byte)1) : ((byte)0));
		val3.Checked = checked3 != 0;
		RadioButton val4 = freqNonEqRadioButton;
		byte checked4 = ((sender == val4) ? ((byte)1) : ((byte)0));
		val4.Checked = checked4 != 0;
	}

	private void freqFullrangeRadioButton_CheckedChanged(object sender, EventArgs e)
	{
		((Control)freq0).Enabled = freqCustomRadioButton.Checked;
		((Control)freq1).Enabled = freqCustomRadioButton.Checked;
	}

	private void filenameTextBox_TextChanged(object sender, EventArgs e)
	{
		byte enabled = ((filenameTextBox.Text.Length > 1) ? ((byte)1) : ((byte)0));
		((Control)exportFreqButton).Enabled = enabled != 0;
		((Control)exportImpulseButton).Enabled = ((Control)exportFreqButton).Enabled;
	}

	protected override void Dispose([MarshalAs(UnmanagedType.U1)] bool P_0)
	{
		if (P_0)
		{
			try
			{
				_007EFormMeasListExportDialog();
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
