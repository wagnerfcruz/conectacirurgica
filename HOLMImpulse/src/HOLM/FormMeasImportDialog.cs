using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace HOLM;

public class FormMeasImportDialog : Form
{
	public bool fFreqImport;

	public CheckBox impAutoOffsetCheckBox;

	private TabPage tabPage1;

	public GroupBox logSweepGroupBox;

	private Label label11;

	public NumericUpDown logSweepStartFreqUpDown;

	public TextBox signalSamplesTextBox;

	private Label label6;

	public NumericUpDown signalMUpDown;

	public bool fImpImport;

	public CheckBox logsweepCheckBox;

	public ControlFilename freqFilename;

	public ControlFilename impFilename;

	public ControlFilename sigFilename;

	public ControlFilename recFilename;

	private GroupBox groupBox4;

	public NumericUpDown recClockPercentUpDown;

	private Label label3;

	private Label label2;

	public Button speedZeroButton;

	private GroupBox groupBox5;

	public TextBox sigrecImpLengthTextBox;

	private Label label4;

	public NumericUpDown sigrecImpMUpDown;

	public bool fSignalRecImport;

	private GroupBox groupBox1;

	public CheckBox phaseImportCheckBox;

	public RadioButton phaseRadRadioButton;

	public RadioButton phaseDegressRadioButton;

	public Button cancelButton;

	private GroupBox groupBox2;

	private RichTextBox richTextBox1;

	public TabControl tabControl;

	private TabPage freqTextTabPage;

	public TabPage impulseTabPage;

	private GroupBox groupBox11;

	public RadioButton impulseWaveRadioButton;

	public RadioButton impulseTextRadioButton;

	public GroupBox impTextfileRulesGroupBox;

	private RichTextBox richTextBox2;

	public GroupBox impTextfileGroupBox;

	private GroupBox groupBox3;

	private Label label1;

	public NumericUpDown impSampleRateUpDown;

	private Container components;

	public FormMeasImportDialog()
	{
		try
		{
			InitializeComponent();
			fFreqImport = false;
			fImpImport = false;
			fSignalRecImport = false;
			return;
		}
		catch
		{
			//try-fault
			((Form)this).Dispose(true);
			throw;
		}
	}

	private void _007EFormMeasImportDialog()
	{
		((IDisposable)components)?.Dispose();
	}

	private void InitializeComponent()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected O, but got Unknown
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected O, but got Unknown
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected O, but got Unknown
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected O, but got Unknown
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Expected O, but got Unknown
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Expected O, but got Unknown
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected O, but got Unknown
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Expected O, but got Unknown
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Expected O, but got Unknown
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Expected O, but got Unknown
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Expected O, but got Unknown
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Expected O, but got Unknown
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Expected O, but got Unknown
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Expected O, but got Unknown
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Expected O, but got Unknown
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Expected O, but got Unknown
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Expected O, but got Unknown
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Expected O, but got Unknown
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Expected O, but got Unknown
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Expected O, but got Unknown
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Expected O, but got Unknown
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Expected O, but got Unknown
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01be: Expected O, but got Unknown
		//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Expected O, but got Unknown
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Expected O, but got Unknown
		//IL_0784: Unknown result type (might be due to invalid IL or missing references)
		//IL_0924: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f26: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fbe: Unknown result type (might be due to invalid IL or missing references)
		//IL_10e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_16a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_16b0: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(FormMeasImportDialog));
		groupBox1 = new GroupBox();
		phaseImportCheckBox = new CheckBox();
		phaseRadRadioButton = new RadioButton();
		phaseDegressRadioButton = new RadioButton();
		cancelButton = new Button();
		groupBox2 = new GroupBox();
		richTextBox1 = new RichTextBox();
		tabControl = new TabControl();
		freqTextTabPage = new TabPage();
		freqFilename = new ControlFilename();
		impulseTabPage = new TabPage();
		impFilename = new ControlFilename();
		groupBox3 = new GroupBox();
		impAutoOffsetCheckBox = new CheckBox();
		impTextfileGroupBox = new GroupBox();
		label1 = new Label();
		impSampleRateUpDown = new NumericUpDown();
		impTextfileRulesGroupBox = new GroupBox();
		richTextBox2 = new RichTextBox();
		groupBox11 = new GroupBox();
		impulseWaveRadioButton = new RadioButton();
		impulseTextRadioButton = new RadioButton();
		tabPage1 = new TabPage();
		groupBox5 = new GroupBox();
		sigrecImpLengthTextBox = new TextBox();
		label4 = new Label();
		sigrecImpMUpDown = new NumericUpDown();
		groupBox4 = new GroupBox();
		speedZeroButton = new Button();
		label3 = new Label();
		recClockPercentUpDown = new NumericUpDown();
		label2 = new Label();
		recFilename = new ControlFilename();
		sigFilename = new ControlFilename();
		logsweepCheckBox = new CheckBox();
		logSweepGroupBox = new GroupBox();
		signalSamplesTextBox = new TextBox();
		label6 = new Label();
		signalMUpDown = new NumericUpDown();
		label11 = new Label();
		logSweepStartFreqUpDown = new NumericUpDown();
		((Control)groupBox1).SuspendLayout();
		((Control)groupBox2).SuspendLayout();
		((Control)tabControl).SuspendLayout();
		((Control)freqTextTabPage).SuspendLayout();
		((Control)impulseTabPage).SuspendLayout();
		((Control)groupBox3).SuspendLayout();
		((Control)impTextfileGroupBox).SuspendLayout();
		((ISupportInitialize)impSampleRateUpDown).BeginInit();
		((Control)impTextfileRulesGroupBox).SuspendLayout();
		((Control)groupBox11).SuspendLayout();
		((Control)tabPage1).SuspendLayout();
		((Control)groupBox5).SuspendLayout();
		((ISupportInitialize)sigrecImpMUpDown).BeginInit();
		((Control)groupBox4).SuspendLayout();
		((ISupportInitialize)recClockPercentUpDown).BeginInit();
		((Control)logSweepGroupBox).SuspendLayout();
		((ISupportInitialize)signalMUpDown).BeginInit();
		((ISupportInitialize)logSweepStartFreqUpDown).BeginInit();
		((Control)this).SuspendLayout();
		((Control)groupBox1).Controls.Add((Control)(object)phaseImportCheckBox);
		((Control)groupBox1).Controls.Add((Control)(object)phaseRadRadioButton);
		((Control)groupBox1).Controls.Add((Control)(object)phaseDegressRadioButton);
		Point location = new Point(4, 76);
		((Control)groupBox1).Location = location;
		((Control)groupBox1).Name = "groupBox1";
		Size size = new Size(151, 49);
		((Control)groupBox1).Size = size;
		((Control)groupBox1).TabIndex = 4;
		groupBox1.TabStop = false;
		((ButtonBase)phaseImportCheckBox).AutoSize = true;
		phaseImportCheckBox.Checked = true;
		phaseImportCheckBox.CheckState = (CheckState)1;
		Point location2 = new Point(9, -1);
		((Control)phaseImportCheckBox).Location = location2;
		((Control)phaseImportCheckBox).Name = "phaseImportCheckBox";
		Size size2 = new Size(88, 17);
		((Control)phaseImportCheckBox).Size = size2;
		((Control)phaseImportCheckBox).TabIndex = 2;
		((ButtonBase)phaseImportCheckBox).Text = "Import Phase";
		((ButtonBase)phaseImportCheckBox).UseVisualStyleBackColor = true;
		((ButtonBase)phaseRadRadioButton).AutoSize = true;
		Point location3 = new Point(80, 22);
		((Control)phaseRadRadioButton).Location = location3;
		((Control)phaseRadRadioButton).Name = "phaseRadRadioButton";
		Size size3 = new Size(64, 17);
		((Control)phaseRadRadioButton).Size = size3;
		((Control)phaseRadRadioButton).TabIndex = 1;
		((ButtonBase)phaseRadRadioButton).Text = "Radians";
		((ButtonBase)phaseRadRadioButton).UseVisualStyleBackColor = true;
		((ButtonBase)phaseDegressRadioButton).AutoSize = true;
		phaseDegressRadioButton.Checked = true;
		Point location4 = new Point(9, 22);
		((Control)phaseDegressRadioButton).Location = location4;
		((Control)phaseDegressRadioButton).Name = "phaseDegressRadioButton";
		Size size4 = new Size(65, 17);
		((Control)phaseDegressRadioButton).Size = size4;
		((Control)phaseDegressRadioButton).TabIndex = 0;
		phaseDegressRadioButton.TabStop = true;
		((ButtonBase)phaseDegressRadioButton).Text = "Degrees";
		((ButtonBase)phaseDegressRadioButton).UseVisualStyleBackColor = true;
		cancelButton.DialogResult = (DialogResult)2;
		Point location5 = new Point(267, 406);
		((Control)cancelButton).Location = location5;
		((Control)cancelButton).Name = "cancelButton";
		Size size5 = new Size(66, 21);
		((Control)cancelButton).Size = size5;
		((Control)cancelButton).TabIndex = 5;
		((ButtonBase)cancelButton).Text = "&Cancel";
		((ButtonBase)cancelButton).UseVisualStyleBackColor = true;
		((Control)cancelButton).Click += cancelButton_Click;
		((Control)groupBox2).Controls.Add((Control)(object)richTextBox1);
		Point location6 = new Point(4, 131);
		((Control)groupBox2).Location = location6;
		((Control)groupBox2).Name = "groupBox2";
		Size size6 = new Size(309, 132);
		((Control)groupBox2).Size = size6;
		((Control)groupBox2).TabIndex = 6;
		groupBox2.TabStop = false;
		groupBox2.Text = "Rules for import";
		Color control = SystemColors.Control;
		((TextBoxBase)richTextBox1).BackColor = control;
		((Control)richTextBox1).Dock = (DockStyle)5;
		Point location7 = new Point(3, 16);
		((Control)richTextBox1).Location = location7;
		((Control)richTextBox1).Name = "richTextBox1";
		Size size7 = new Size(303, 113);
		((Control)richTextBox1).Size = size7;
		((Control)richTextBox1).TabIndex = 0;
		richTextBox1.Text = componentResourceManager.GetString("richTextBox1.Text");
		((Control)tabControl).Controls.Add((Control)(object)freqTextTabPage);
		((Control)tabControl).Controls.Add((Control)(object)impulseTabPage);
		((Control)tabControl).Controls.Add((Control)(object)tabPage1);
		((Control)tabControl).Dock = (DockStyle)1;
		Point location8 = new Point(0, 0);
		((Control)tabControl).Location = location8;
		((Control)tabControl).Name = "tabControl";
		tabControl.SelectedIndex = 0;
		Size size8 = new Size(334, 401);
		((Control)tabControl).Size = size8;
		((Control)tabControl).TabIndex = 7;
		((Control)freqTextTabPage).Controls.Add((Control)(object)freqFilename);
		((Control)freqTextTabPage).Controls.Add((Control)(object)groupBox1);
		((Control)freqTextTabPage).Controls.Add((Control)(object)groupBox2);
		Point location9 = new Point(4, 22);
		freqTextTabPage.Location = location9;
		((Control)freqTextTabPage).Name = "freqTextTabPage";
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Padding padding);
		((Padding)(ref padding))._002Ector(3);
		((Control)freqTextTabPage).Padding = padding;
		Size size9 = new Size(326, 375);
		((Control)freqTextTabPage).Size = size9;
		freqTextTabPage.TabIndex = 0;
		freqTextTabPage.Text = "Frequency";
		freqTextTabPage.UseVisualStyleBackColor = true;
		freqFilename.ActionText = "Import";
		((Control)freqFilename).Dock = (DockStyle)1;
		freqFilename.Filter = "Txt Files (*.txt)|*.txt|All Files (*.*)|*.*";
		freqFilename.Label = "Text-file to import";
		Point location10 = new Point(3, 3);
		((Control)freqFilename).Location = location10;
		((Control)freqFilename).Name = "freqFilename";
		freqFilename.Path = "";
		Size size10 = new Size(320, 67);
		((Control)freqFilename).Size = size10;
		((Control)freqFilename).TabIndex = 7;
		freqFilename.ActionEvent += ImportButton_Click;
		((Control)impulseTabPage).Controls.Add((Control)(object)impFilename);
		((Control)impulseTabPage).Controls.Add((Control)(object)groupBox3);
		((Control)impulseTabPage).Controls.Add((Control)(object)impTextfileGroupBox);
		((Control)impulseTabPage).Controls.Add((Control)(object)impTextfileRulesGroupBox);
		((Control)impulseTabPage).Controls.Add((Control)(object)groupBox11);
		Point location11 = new Point(4, 22);
		impulseTabPage.Location = location11;
		((Control)impulseTabPage).Name = "impulseTabPage";
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Padding padding2);
		((Padding)(ref padding2))._002Ector(3);
		((Control)impulseTabPage).Padding = padding2;
		Size size11 = new Size(326, 375);
		((Control)impulseTabPage).Size = size11;
		impulseTabPage.TabIndex = 1;
		impulseTabPage.Text = "Impulse";
		impulseTabPage.UseVisualStyleBackColor = true;
		impFilename.ActionText = "Import";
		((Control)impFilename).Dock = (DockStyle)1;
		impFilename.Filter = "Wav files (*.wav)|*.wav|Txt Files (*.txt)|*.txt|All Files (*.*)|*.*";
		impFilename.Label = "Impulse file to import";
		Point location12 = new Point(3, 3);
		((Control)impFilename).Location = location12;
		((Control)impFilename).Name = "impFilename";
		impFilename.Path = "";
		Size size12 = new Size(320, 67);
		((Control)impFilename).Size = size12;
		((Control)impFilename).TabIndex = 10;
		impFilename.ActionEvent += ImportButton_Click;
		((Control)groupBox3).Controls.Add((Control)(object)impAutoOffsetCheckBox);
		Point location13 = new Point(3, 149);
		((Control)groupBox3).Location = location13;
		((Control)groupBox3).Name = "groupBox3";
		Size size13 = new Size(262, 46);
		((Control)groupBox3).Size = size13;
		((Control)groupBox3).TabIndex = 9;
		groupBox3.TabStop = false;
		groupBox3.Text = "Options";
		((ButtonBase)impAutoOffsetCheckBox).AutoSize = true;
		impAutoOffsetCheckBox.Checked = true;
		impAutoOffsetCheckBox.CheckState = (CheckState)1;
		Point location14 = new Point(6, 19);
		((Control)impAutoOffsetCheckBox).Location = location14;
		((Control)impAutoOffsetCheckBox).Name = "impAutoOffsetCheckBox";
		Size size14 = new Size(161, 17);
		((Control)impAutoOffsetCheckBox).Size = size14;
		((Control)impAutoOffsetCheckBox).TabIndex = 1;
		((ButtonBase)impAutoOffsetCheckBox).Text = "Auto detect offset (time zero)";
		((ButtonBase)impAutoOffsetCheckBox).UseVisualStyleBackColor = true;
		((Control)impTextfileGroupBox).Controls.Add((Control)(object)label1);
		((Control)impTextfileGroupBox).Controls.Add((Control)(object)impSampleRateUpDown);
		((Control)impTextfileGroupBox).Enabled = false;
		Point location15 = new Point(3, 201);
		((Control)impTextfileGroupBox).Location = location15;
		((Control)impTextfileGroupBox).Name = "impTextfileGroupBox";
		Size size15 = new Size(262, 49);
		((Control)impTextfileGroupBox).Size = size15;
		((Control)impTextfileGroupBox).TabIndex = 8;
		impTextfileGroupBox.TabStop = false;
		impTextfileGroupBox.Text = "Textfile options";
		label1.AutoSize = true;
		Point location16 = new Point(7, 21);
		((Control)label1).Location = location16;
		((Control)label1).Name = "label1";
		Size size16 = new Size(96, 13);
		((Control)label1).Size = size16;
		((Control)label1).TabIndex = 1;
		label1.Text = "Samplerate in kHz:";
		impSampleRateUpDown.DecimalPlaces = 1;
		Point location17 = new Point(107, 19);
		((Control)impSampleRateUpDown).Location = location17;
		decimal maximum = new decimal(new int[4] { 192, 0, 0, 0 });
		impSampleRateUpDown.Maximum = maximum;
		decimal minimum = new decimal(new int[4] { 8, 0, 0, 0 });
		impSampleRateUpDown.Minimum = minimum;
		((Control)impSampleRateUpDown).Name = "impSampleRateUpDown";
		Size size17 = new Size(71, 20);
		((Control)impSampleRateUpDown).Size = size17;
		((Control)impSampleRateUpDown).TabIndex = 0;
		((UpDownBase)impSampleRateUpDown).TextAlign = (HorizontalAlignment)1;
		decimal value = new decimal(new int[4] { 441, 0, 0, 65536 });
		impSampleRateUpDown.Value = value;
		((Control)impTextfileRulesGroupBox).Controls.Add((Control)(object)richTextBox2);
		((Control)impTextfileRulesGroupBox).Enabled = false;
		Point location18 = new Point(3, 256);
		((Control)impTextfileRulesGroupBox).Location = location18;
		((Control)impTextfileRulesGroupBox).Name = "impTextfileRulesGroupBox";
		Size size18 = new Size(262, 115);
		((Control)impTextfileRulesGroupBox).Size = size18;
		((Control)impTextfileRulesGroupBox).TabIndex = 7;
		impTextfileRulesGroupBox.TabStop = false;
		impTextfileRulesGroupBox.Text = "Rules for text-file import";
		Color control2 = SystemColors.Control;
		((TextBoxBase)richTextBox2).BackColor = control2;
		((Control)richTextBox2).Dock = (DockStyle)5;
		Point location19 = new Point(3, 16);
		((Control)richTextBox2).Location = location19;
		((Control)richTextBox2).Name = "richTextBox2";
		Size size19 = new Size(256, 96);
		((Control)richTextBox2).Size = size19;
		((Control)richTextBox2).TabIndex = 0;
		richTextBox2.Text = "- Expects data in columns: \nvalue1\nvalue2\n...\n\n- Ignores lines not starting with a number\n- Accepts , and/or . as decimal point";
		((Control)groupBox11).Controls.Add((Control)(object)impulseWaveRadioButton);
		((Control)groupBox11).Controls.Add((Control)(object)impulseTextRadioButton);
		Point location20 = new Point(3, 76);
		((Control)groupBox11).Location = location20;
		((Control)groupBox11).Name = "groupBox11";
		Size size20 = new Size(262, 67);
		((Control)groupBox11).Size = size20;
		((Control)groupBox11).TabIndex = 3;
		groupBox11.TabStop = false;
		groupBox11.Text = "File Format ";
		((ButtonBase)impulseWaveRadioButton).AutoSize = true;
		impulseWaveRadioButton.Checked = true;
		Point location21 = new Point(6, 17);
		((Control)impulseWaveRadioButton).Location = location21;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Padding margin);
		((Padding)(ref margin))._002Ector(1);
		((Control)impulseWaveRadioButton).Margin = margin;
		((Control)impulseWaveRadioButton).Name = "impulseWaveRadioButton";
		Size size21 = new Size(174, 17);
		((Control)impulseWaveRadioButton).Size = size21;
		((Control)impulseWaveRadioButton).TabIndex = 16;
		impulseWaveRadioButton.TabStop = true;
		((ButtonBase)impulseWaveRadioButton).Text = "Wave file (Data in 1st channel) ";
		((ButtonBase)impulseWaveRadioButton).UseVisualStyleBackColor = true;
		((ButtonBase)impulseTextRadioButton).AutoSize = true;
		Point location22 = new Point(6, 41);
		((Control)impulseTextRadioButton).Location = location22;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Padding margin2);
		((Padding)(ref margin2))._002Ector(1);
		((Control)impulseTextRadioButton).Margin = margin2;
		((Control)impulseTextRadioButton).Name = "impulseTextRadioButton";
		Size size22 = new Size(88, 17);
		((Control)impulseTextRadioButton).Size = size22;
		((Control)impulseTextRadioButton).TabIndex = 17;
		((ButtonBase)impulseTextRadioButton).Text = "ASCII text-file";
		((ButtonBase)impulseTextRadioButton).UseVisualStyleBackColor = true;
		impulseTextRadioButton.CheckedChanged += impulseTextRadioButton_CheckedChanged;
		((Control)tabPage1).Controls.Add((Control)(object)groupBox5);
		((Control)tabPage1).Controls.Add((Control)(object)groupBox4);
		((Control)tabPage1).Controls.Add((Control)(object)recFilename);
		((Control)tabPage1).Controls.Add((Control)(object)sigFilename);
		((Control)tabPage1).Controls.Add((Control)(object)logsweepCheckBox);
		((Control)tabPage1).Controls.Add((Control)(object)logSweepGroupBox);
		Point location23 = new Point(4, 22);
		tabPage1.Location = location23;
		((Control)tabPage1).Name = "tabPage1";
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Padding padding3);
		((Padding)(ref padding3))._002Ector(3);
		((Control)tabPage1).Padding = padding3;
		Size size23 = new Size(326, 375);
		((Control)tabPage1).Size = size23;
		tabPage1.TabIndex = 2;
		tabPage1.Text = "Signal && Recording";
		tabPage1.UseVisualStyleBackColor = true;
		((Control)groupBox5).Controls.Add((Control)(object)sigrecImpLengthTextBox);
		((Control)groupBox5).Controls.Add((Control)(object)label4);
		((Control)groupBox5).Controls.Add((Control)(object)sigrecImpMUpDown);
		Point location24 = new Point(3, 300);
		((Control)groupBox5).Location = location24;
		((Control)groupBox5).Name = "groupBox5";
		Size size24 = new Size(320, 49);
		((Control)groupBox5).Size = size24;
		((Control)groupBox5).TabIndex = 17;
		groupBox5.TabStop = false;
		groupBox5.Text = "Maximum length for the resulting impulse response";
		Point location25 = new Point(115, 22);
		((Control)sigrecImpLengthTextBox).Location = location25;
		((Control)sigrecImpLengthTextBox).Name = "sigrecImpLengthTextBox";
		((TextBoxBase)sigrecImpLengthTextBox).ReadOnly = true;
		((Control)sigrecImpLengthTextBox).RightToLeft = (RightToLeft)1;
		Size size25 = new Size(60, 20);
		((Control)sigrecImpLengthTextBox).Size = size25;
		((Control)sigrecImpLengthTextBox).TabIndex = 15;
		((Control)sigrecImpLengthTextBox).TabStop = false;
		sigrecImpLengthTextBox.Text = "1048,576";
		label4.AutoSize = true;
		Point location26 = new Point(12, 25);
		((Control)label4).Location = location26;
		((Control)label4).Name = "label4";
		Size size26 = new Size(99, 13);
		((Control)label4).Size = size26;
		((Control)label4).TabIndex = 13;
		label4.Text = "Length  [ksamples]:";
		Point location27 = new Point(181, 22);
		((Control)sigrecImpMUpDown).Location = location27;
		decimal maximum2 = new decimal(new int[4] { 22, 0, 0, 0 });
		sigrecImpMUpDown.Maximum = maximum2;
		decimal minimum2 = new decimal(new int[4] { 14, 0, 0, 0 });
		sigrecImpMUpDown.Minimum = minimum2;
		((Control)sigrecImpMUpDown).Name = "sigrecImpMUpDown";
		Size size27 = new Size(41, 20);
		((Control)sigrecImpMUpDown).Size = size27;
		((Control)sigrecImpMUpDown).TabIndex = 14;
		decimal value2 = new decimal(new int[4] { 20, 0, 0, 0 });
		sigrecImpMUpDown.Value = value2;
		sigrecImpMUpDown.ValueChanged += sigrecImpMUpDown_ValueChanged;
		((Control)groupBox4).Controls.Add((Control)(object)speedZeroButton);
		((Control)groupBox4).Controls.Add((Control)(object)label3);
		((Control)groupBox4).Controls.Add((Control)(object)recClockPercentUpDown);
		((Control)groupBox4).Controls.Add((Control)(object)label2);
		Point location28 = new Point(3, 236);
		((Control)groupBox4).Location = location28;
		((Control)groupBox4).Name = "groupBox4";
		Size size28 = new Size(320, 49);
		((Control)groupBox4).Size = size28;
		((Control)groupBox4).TabIndex = 16;
		groupBox4.TabStop = false;
		groupBox4.Text = "Clock adjust";
		Point location29 = new Point(275, 21);
		((Control)speedZeroButton).Location = location29;
		((Control)speedZeroButton).Name = "speedZeroButton";
		Size size29 = new Size(40, 21);
		((Control)speedZeroButton).Size = size29;
		((Control)speedZeroButton).TabIndex = 8;
		((ButtonBase)speedZeroButton).Text = "Zero";
		((ButtonBase)speedZeroButton).UseVisualStyleBackColor = true;
		((Control)speedZeroButton).Click += speedZeroButton_Click;
		label3.AutoSize = true;
		Point location30 = new Point(12, 23);
		((Control)label3).Location = location30;
		((Control)label3).Name = "label3";
		Size size30 = new Size(168, 13);
		((Control)label3).Size = size30;
		((Control)label3).TabIndex = 2;
		label3.Text = "Recorded wave speed difference:";
		recClockPercentUpDown.DecimalPlaces = 6;
		decimal increment = new decimal(new int[4] { 1, 0, 0, 131072 });
		recClockPercentUpDown.Increment = increment;
		Point location31 = new Point(183, 21);
		((Control)recClockPercentUpDown).Location = location31;
		decimal maximum3 = new decimal(new int[4] { 9, 0, 0, 0 });
		recClockPercentUpDown.Maximum = maximum3;
		decimal minimum3 = new decimal(new int[4] { 9, 0, 0, -2147483648 });
		recClockPercentUpDown.Minimum = minimum3;
		((Control)recClockPercentUpDown).Name = "recClockPercentUpDown";
		Size size31 = new Size(74, 20);
		((Control)recClockPercentUpDown).Size = size31;
		((Control)recClockPercentUpDown).TabIndex = 0;
		((UpDownBase)recClockPercentUpDown).TextAlign = (HorizontalAlignment)1;
		label2.AutoSize = true;
		((Control)label2).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		Point location32 = new Point(256, 25);
		((Control)label2).Location = location32;
		((Control)label2).Name = "label2";
		Size size32 = new Size(16, 13);
		((Control)label2).Size = size32;
		((Control)label2).TabIndex = 1;
		label2.Text = "%";
		recFilename.ActionText = "Import";
		((Control)recFilename).Dock = (DockStyle)1;
		recFilename.Filter = "Wav files (*.wav)|*.wav|All Files (*.*)|*.*";
		recFilename.Label = "Recorded wave-file (Data in 1st channel) ";
		Point location33 = new Point(3, 70);
		((Control)recFilename).Location = location33;
		((Control)recFilename).Name = "recFilename";
		recFilename.Path = "";
		Size size33 = new Size(320, 67);
		((Control)recFilename).Size = size33;
		((Control)recFilename).TabIndex = 15;
		recFilename.ActionEvent += ImportButton_Click;
		((Control)sigFilename).Dock = (DockStyle)1;
		sigFilename.Filter = "Wav files (*.wav)|*.wav|All Files (*.*)|*.*";
		sigFilename.Label = "Signal wave-file (Data in 1st channel) ";
		Point location34 = new Point(3, 3);
		((Control)sigFilename).Location = location34;
		((Control)sigFilename).Name = "sigFilename";
		sigFilename.Path = "";
		Size size34 = new Size(320, 67);
		((Control)sigFilename).Size = size34;
		((Control)sigFilename).TabIndex = 14;
		((ButtonBase)logsweepCheckBox).AutoSize = true;
		Point location35 = new Point(15, 141);
		((Control)logsweepCheckBox).Location = location35;
		((Control)logsweepCheckBox).Name = "logsweepCheckBox";
		Size size35 = new Size(282, 30);
		((Control)logsweepCheckBox).Size = size35;
		((Control)logsweepCheckBox).TabIndex = 13;
		((ButtonBase)logsweepCheckBox).Text = "Signal is Logsweep\r\n(Information is needed to calculate harmonic distortion)";
		((ButtonBase)logsweepCheckBox).UseVisualStyleBackColor = true;
		logsweepCheckBox.CheckedChanged += logsweepCheckBox_CheckedChanged;
		((Control)logSweepGroupBox).Controls.Add((Control)(object)signalSamplesTextBox);
		((Control)logSweepGroupBox).Controls.Add((Control)(object)label6);
		((Control)logSweepGroupBox).Controls.Add((Control)(object)signalMUpDown);
		((Control)logSweepGroupBox).Controls.Add((Control)(object)label11);
		((Control)logSweepGroupBox).Controls.Add((Control)(object)logSweepStartFreqUpDown);
		((Control)logSweepGroupBox).Enabled = false;
		Point location36 = new Point(3, 149);
		((Control)logSweepGroupBox).Location = location36;
		((Control)logSweepGroupBox).Name = "logSweepGroupBox";
		Size size36 = new Size(320, 80);
		((Control)logSweepGroupBox).Size = size36;
		((Control)logSweepGroupBox).TabIndex = 12;
		logSweepGroupBox.TabStop = false;
		Point location37 = new Point(115, 54);
		((Control)signalSamplesTextBox).Location = location37;
		((Control)signalSamplesTextBox).Name = "signalSamplesTextBox";
		((TextBoxBase)signalSamplesTextBox).ReadOnly = true;
		((Control)signalSamplesTextBox).RightToLeft = (RightToLeft)1;
		Size size37 = new Size(60, 20);
		((Control)signalSamplesTextBox).Size = size37;
		((Control)signalSamplesTextBox).TabIndex = 12;
		((Control)signalSamplesTextBox).TabStop = false;
		signalSamplesTextBox.Text = "131,072";
		label6.AutoSize = true;
		Point location38 = new Point(9, 58);
		((Control)label6).Location = location38;
		((Control)label6).Name = "label6";
		Size size38 = new Size(99, 13);
		((Control)label6).Size = size38;
		((Control)label6).TabIndex = 10;
		label6.Text = "Length  [ksamples]:";
		Point location39 = new Point(181, 54);
		((Control)signalMUpDown).Location = location39;
		decimal maximum4 = new decimal(new int[4] { 20, 0, 0, 0 });
		signalMUpDown.Maximum = maximum4;
		decimal minimum4 = new decimal(new int[4] { 14, 0, 0, 0 });
		signalMUpDown.Minimum = minimum4;
		((Control)signalMUpDown).Name = "signalMUpDown";
		Size size39 = new Size(41, 20);
		((Control)signalMUpDown).Size = size39;
		((Control)signalMUpDown).TabIndex = 11;
		decimal value3 = new decimal(new int[4] { 17, 0, 0, 0 });
		signalMUpDown.Value = value3;
		signalMUpDown.ValueChanged += signalMUpDown_ValueChanged;
		label11.AutoSize = true;
		Point location40 = new Point(9, 30);
		((Control)label11).Location = location40;
		((Control)label11).Name = "label11";
		Size size40 = new Size(104, 13);
		((Control)label11).Size = size40;
		((Control)label11).TabIndex = 9;
		label11.Text = "Start frequency [Hz]:";
		Point location41 = new Point(115, 28);
		((Control)logSweepStartFreqUpDown).Location = location41;
		decimal maximum5 = new decimal(new int[4] { 1000, 0, 0, 0 });
		logSweepStartFreqUpDown.Maximum = maximum5;
		decimal minimum5 = new decimal(new int[4] { 1, 0, 0, 0 });
		logSweepStartFreqUpDown.Minimum = minimum5;
		((Control)logSweepStartFreqUpDown).Name = "logSweepStartFreqUpDown";
		((Control)logSweepStartFreqUpDown).RightToLeft = (RightToLeft)0;
		Size size41 = new Size(60, 20);
		((Control)logSweepStartFreqUpDown).Size = size41;
		((Control)logSweepStartFreqUpDown).TabIndex = 8;
		((UpDownBase)logSweepStartFreqUpDown).TextAlign = (HorizontalAlignment)1;
		decimal value4 = new decimal(new int[4] { 10, 0, 0, 0 });
		logSweepStartFreqUpDown.Value = value4;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		Size clientSize = new Size(334, 429);
		((Form)this).ClientSize = clientSize;
		((Control)this).Controls.Add((Control)(object)tabControl);
		((Control)this).Controls.Add((Control)(object)cancelButton);
		((Form)this).FormBorderStyle = (FormBorderStyle)5;
		Point location42 = new Point(63, 64);
		((Form)this).Location = location42;
		((Control)this).Name = "FormMeasImportDialog";
		((Form)this).ShowInTaskbar = false;
		((Form)this).Text = "Import response from file";
		((Form)this).TopMost = true;
		((Form)this).Shown += FormMeasImportDialog_Shown;
		((Control)groupBox1).ResumeLayout(false);
		((Control)groupBox1).PerformLayout();
		((Control)groupBox2).ResumeLayout(false);
		((Control)tabControl).ResumeLayout(false);
		((Control)freqTextTabPage).ResumeLayout(false);
		((Control)impulseTabPage).ResumeLayout(false);
		((Control)groupBox3).ResumeLayout(false);
		((Control)groupBox3).PerformLayout();
		((Control)impTextfileGroupBox).ResumeLayout(false);
		((Control)impTextfileGroupBox).PerformLayout();
		((ISupportInitialize)impSampleRateUpDown).EndInit();
		((Control)impTextfileRulesGroupBox).ResumeLayout(false);
		((Control)groupBox11).ResumeLayout(false);
		((Control)groupBox11).PerformLayout();
		((Control)tabPage1).ResumeLayout(false);
		((Control)tabPage1).PerformLayout();
		((Control)groupBox5).ResumeLayout(false);
		((Control)groupBox5).PerformLayout();
		((ISupportInitialize)sigrecImpMUpDown).EndInit();
		((Control)groupBox4).ResumeLayout(false);
		((Control)groupBox4).PerformLayout();
		((ISupportInitialize)recClockPercentUpDown).EndInit();
		((Control)logSweepGroupBox).ResumeLayout(false);
		((Control)logSweepGroupBox).PerformLayout();
		((ISupportInitialize)signalMUpDown).EndInit();
		((ISupportInitialize)logSweepStartFreqUpDown).EndInit();
		((Control)this).ResumeLayout(false);
	}

	private void cancelButton_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void ImportButton_Click(object sender, EventArgs e)
	{
		int num = ((sender == freqFilename) ? 1 : 0);
		fFreqImport = (byte)num != 0;
		int num2 = ((sender == recFilename) ? 1 : 0);
		fSignalRecImport = (byte)num2 != 0;
		int num3 = ((sender == impFilename) ? 1 : 0);
		fImpImport = (byte)num3 != 0;
		((Form)this).Close();
	}

	private void impulseTextRadioButton_CheckedChanged(object sender, EventArgs e)
	{
		((Control)impTextfileGroupBox).Enabled = impulseTextRadioButton.Checked;
		((Control)impTextfileRulesGroupBox).Enabled = impulseTextRadioButton.Checked;
	}

	private void FormMeasImportDialog_Shown(object sender, EventArgs e)
	{
		fFreqImport = false;
		fImpImport = false;
		fSignalRecImport = false;
	}

	private void logsweepCheckBox_CheckedChanged(object sender, EventArgs e)
	{
		((Control)logSweepGroupBox).Enabled = logsweepCheckBox.Checked;
	}

	private void signalMUpDown_ValueChanged(object sender, EventArgs e)
	{
		decimal value = signalMUpDown.Value;
		double num = Math.Pow(2.0, decimal.ToDouble(value)) / 1000.0;
		signalSamplesTextBox.Text = num.ToString("F3");
	}

	private void speedZeroButton_Click(object sender, EventArgs e)
	{
		decimal value = 0;
		recClockPercentUpDown.Value = value;
	}

	private void sigrecImpMUpDown_ValueChanged(object sender, EventArgs e)
	{
		decimal value = sigrecImpMUpDown.Value;
		double num = Math.Pow(2.0, decimal.ToDouble(value)) / 1000.0;
		sigrecImpLengthTextBox.Text = num.ToString("F3");
	}

	protected override void Dispose([MarshalAs(UnmanagedType.U1)] bool P_0)
	{
		if (P_0)
		{
			try
			{
				_007EFormMeasImportDialog();
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
