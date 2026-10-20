using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace HOLM.HOLMImpulse;

public class ControlDataAnalysis : UserControl
{
	public TableLayoutPanel devTableLayoutPanel;

	public ToolTip toolTip;

	public Panel panel1;

	public GroupBox groupBox8;

	public CheckBox timeWindowAutoCheckBox;

	public CheckBox normalize0dBCheckBox;

	public GroupBox timeZeroDetectGroupBox;

	public CheckBox timeDetectInterpolate;

	public GroupBox groupBox5;

	private Label label15;

	public TextBox saveSamplesTextBox;

	private Label label16;

	public NumericUpDown saveMUpDown;

	public CheckBox postHighpassCheckBox;

	private Label label2;

	private Label label9;

	private Panel panel2;

	public GroupBox timeZeroLockedGroupBox;

	private Label label17;

	public TextBox timeZeroLockDetectTextBox;

	public RadioButton timeZeroLockedRadioButton;

	public Button timeZeroLockUseButton;

	private Label label1;

	public RadioButton timeZeroDetectRadioButton;

	public NumericUpDown timeZeroLockUpDown;

	public Button timeZeroLockHelpButton;

	public Label timeLockedUnitLabel;

	public CheckBox nyquistExtCheckBox;

	public GroupBox nyquistExtGroupBox;

	private Label label3;

	public NumericUpDown nyquistExtUpDown;

	public ComboBox timeDetectMethodComboBox;

	public CheckBox saveMeasWavesCheckBox;

	public GroupBox debugInOutGroupBox;

	private Label label21;

	public Button debugCorrBrowseButton;

	public TextBox debugCorrTextBox;

	private Label label23;

	public Button debugRecordingBrowseButton;

	public TextBox debugRecordingTextBox;

	public Button debugOutputBrowseButton;

	private Label label22;

	public TextBox debugOutputTextBox;

	private Label label4;

	public TextBox fftSizeResHzTextBox;

	private Label label5;

	private Label label6;

	private IContainer components;

	public ControlDataAnalysis()
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

	private void _007EControlDataAnalysis()
	{
		components?.Dispose();
	}

	private void InitializeComponent()
	{
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
		//IL_020c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0216: Expected O, but got Unknown
		//IL_02c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d3: Expected O, but got Unknown
		//IL_02e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ef: Expected O, but got Unknown
		//IL_0301: Unknown result type (might be due to invalid IL or missing references)
		//IL_030b: Expected O, but got Unknown
		//IL_039c: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03da: Expected O, but got Unknown
		//IL_03ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f6: Expected O, but got Unknown
		//IL_044d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0457: Expected O, but got Unknown
		//IL_04e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ea: Expected O, but got Unknown
		//IL_05a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c64: Unknown result type (might be due to invalid IL or missing references)
		//IL_11ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_1292: Unknown result type (might be due to invalid IL or missing references)
		//IL_1342: Unknown result type (might be due to invalid IL or missing references)
		//IL_1525: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ee3: Unknown result type (might be due to invalid IL or missing references)
		components = new Container();
		devTableLayoutPanel = new TableLayoutPanel();
		label9 = new Label();
		label2 = new Label();
		panel1 = new Panel();
		saveMeasWavesCheckBox = new CheckBox();
		debugInOutGroupBox = new GroupBox();
		label21 = new Label();
		debugCorrBrowseButton = new Button();
		debugCorrTextBox = new TextBox();
		label23 = new Label();
		debugRecordingBrowseButton = new Button();
		debugRecordingTextBox = new TextBox();
		debugOutputBrowseButton = new Button();
		label22 = new Label();
		debugOutputTextBox = new TextBox();
		panel2 = new Panel();
		nyquistExtCheckBox = new CheckBox();
		nyquistExtGroupBox = new GroupBox();
		label3 = new Label();
		nyquistExtUpDown = new NumericUpDown();
		timeZeroDetectRadioButton = new RadioButton();
		timeZeroLockHelpButton = new Button();
		timeZeroLockedRadioButton = new RadioButton();
		groupBox8 = new GroupBox();
		timeWindowAutoCheckBox = new CheckBox();
		postHighpassCheckBox = new CheckBox();
		normalize0dBCheckBox = new CheckBox();
		timeZeroDetectGroupBox = new GroupBox();
		timeDetectMethodComboBox = new ComboBox();
		timeDetectInterpolate = new CheckBox();
		groupBox5 = new GroupBox();
		label6 = new Label();
		label5 = new Label();
		label4 = new Label();
		fftSizeResHzTextBox = new TextBox();
		label15 = new Label();
		saveSamplesTextBox = new TextBox();
		label16 = new Label();
		saveMUpDown = new NumericUpDown();
		timeZeroLockedGroupBox = new GroupBox();
		timeLockedUnitLabel = new Label();
		timeZeroLockUpDown = new NumericUpDown();
		label1 = new Label();
		timeZeroLockUseButton = new Button();
		timeZeroLockDetectTextBox = new TextBox();
		label17 = new Label();
		toolTip = new ToolTip(components);
		((Control)devTableLayoutPanel).SuspendLayout();
		((Control)panel1).SuspendLayout();
		((Control)debugInOutGroupBox).SuspendLayout();
		((Control)panel2).SuspendLayout();
		((Control)nyquistExtGroupBox).SuspendLayout();
		((ISupportInitialize)nyquistExtUpDown).BeginInit();
		((Control)groupBox8).SuspendLayout();
		((Control)timeZeroDetectGroupBox).SuspendLayout();
		((Control)groupBox5).SuspendLayout();
		((ISupportInitialize)saveMUpDown).BeginInit();
		((Control)timeZeroLockedGroupBox).SuspendLayout();
		((ISupportInitialize)timeZeroLockUpDown).BeginInit();
		((Control)this).SuspendLayout();
		devTableLayoutPanel.CellBorderStyle = (TableLayoutPanelCellBorderStyle)4;
		devTableLayoutPanel.ColumnCount = 3;
		devTableLayoutPanel.ColumnStyles.Add(new ColumnStyle((SizeType)2, 33.33333f));
		devTableLayoutPanel.ColumnStyles.Add(new ColumnStyle((SizeType)2, 33.33333f));
		devTableLayoutPanel.ColumnStyles.Add(new ColumnStyle((SizeType)2, 33.33333f));
		devTableLayoutPanel.Controls.Add((Control)(object)label9, 0, 0);
		devTableLayoutPanel.Controls.Add((Control)(object)label2, 1, 0);
		devTableLayoutPanel.Controls.Add((Control)(object)panel1, 1, 1);
		devTableLayoutPanel.Controls.Add((Control)(object)panel2, 0, 1);
		((Control)devTableLayoutPanel).Dock = (DockStyle)5;
		Point location = new Point(0, 0);
		((Control)devTableLayoutPanel).Location = location;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Padding margin);
		((Padding)(ref margin))._002Ector(0);
		((Control)devTableLayoutPanel).Margin = margin;
		((Control)devTableLayoutPanel).Name = "devTableLayoutPanel";
		devTableLayoutPanel.RowCount = 2;
		devTableLayoutPanel.RowStyles.Add(new RowStyle((SizeType)1, 20f));
		devTableLayoutPanel.RowStyles.Add(new RowStyle((SizeType)1, 20f));
		Size size = new Size(784, 495);
		((Control)devTableLayoutPanel).Size = size;
		((Control)devTableLayoutPanel).TabIndex = 11;
		((Control)label9).Anchor = (AnchorStyles)0;
		label9.AutoSize = true;
		((Control)label9).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		Point location2 = new Point(65, 5);
		((Control)label9).Location = location2;
		((Control)label9).Name = "label9";
		Size size2 = new Size(131, 13);
		((Control)label9).Size = size2;
		((Control)label9).TabIndex = 5;
		label9.Text = "Measurement analysis";
		((Control)label2).Anchor = (AnchorStyles)0;
		label2.AutoSize = true;
		((Control)label2).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		Point location3 = new Point(347, 5);
		((Control)label2).Location = location3;
		((Control)label2).Name = "label2";
		Size size3 = new Size(87, 13);
		((Control)label2).Size = size3;
		((Control)label2).TabIndex = 7;
		label2.Text = "Miscellaneous";
		((Control)panel1).Controls.Add((Control)(object)saveMeasWavesCheckBox);
		((Control)panel1).Controls.Add((Control)(object)debugInOutGroupBox);
		((Control)panel1).Dock = (DockStyle)5;
		Point location4 = new Point(262, 24);
		((Control)panel1).Location = location4;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Padding margin2);
		((Padding)(ref margin2))._002Ector(0);
		((Control)panel1).Margin = margin2;
		((Control)panel1).Name = "panel1";
		Size size4 = new Size(258, 469);
		((Control)panel1).Size = size4;
		((Control)panel1).TabIndex = 0;
		((ButtonBase)saveMeasWavesCheckBox).AutoSize = true;
		Point location5 = new Point(13, 2);
		((Control)saveMeasWavesCheckBox).Location = location5;
		((Control)saveMeasWavesCheckBox).Name = "saveMeasWavesCheckBox";
		Size size5 = new Size(185, 17);
		((Control)saveMeasWavesCheckBox).Size = size5;
		((Control)saveMeasWavesCheckBox).TabIndex = 10;
		((ButtonBase)saveMeasWavesCheckBox).Text = "Save waveforms when measuring";
		((ButtonBase)saveMeasWavesCheckBox).UseVisualStyleBackColor = true;
		saveMeasWavesCheckBox.CheckedChanged += saveMeasWavesCheckBox_CheckedChanged;
		((Control)debugInOutGroupBox).Controls.Add((Control)(object)label21);
		((Control)debugInOutGroupBox).Controls.Add((Control)(object)debugCorrBrowseButton);
		((Control)debugInOutGroupBox).Controls.Add((Control)(object)debugCorrTextBox);
		((Control)debugInOutGroupBox).Controls.Add((Control)(object)label23);
		((Control)debugInOutGroupBox).Controls.Add((Control)(object)debugRecordingBrowseButton);
		((Control)debugInOutGroupBox).Controls.Add((Control)(object)debugRecordingTextBox);
		((Control)debugInOutGroupBox).Controls.Add((Control)(object)debugOutputBrowseButton);
		((Control)debugInOutGroupBox).Controls.Add((Control)(object)label22);
		((Control)debugInOutGroupBox).Controls.Add((Control)(object)debugOutputTextBox);
		((Control)debugInOutGroupBox).Enabled = false;
		Point location6 = new Point(3, 6);
		((Control)debugInOutGroupBox).Location = location6;
		((Control)debugInOutGroupBox).Name = "debugInOutGroupBox";
		Size size6 = new Size(250, 143);
		((Control)debugInOutGroupBox).Size = size6;
		((Control)debugInOutGroupBox).TabIndex = 11;
		debugInOutGroupBox.TabStop = false;
		label21.AutoSize = true;
		Point location7 = new Point(6, 98);
		((Control)label21).Location = location7;
		((Control)label21).Name = "label21";
		Size size7 = new Size(152, 13);
		((Control)label21).Size = size7;
		((Control)label21).TabIndex = 17;
		label21.Text = "Saving correlation to wave file:";
		Point location8 = new Point(197, 113);
		((Control)debugCorrBrowseButton).Location = location8;
		((Control)debugCorrBrowseButton).Name = "debugCorrBrowseButton";
		Size size8 = new Size(50, 21);
		((Control)debugCorrBrowseButton).Size = size8;
		((Control)debugCorrBrowseButton).TabIndex = 16;
		((ButtonBase)debugCorrBrowseButton).Text = "Browse";
		((ButtonBase)debugCorrBrowseButton).UseVisualStyleBackColor = true;
		Point location9 = new Point(6, 113);
		((Control)debugCorrTextBox).Location = location9;
		((Control)debugCorrTextBox).Name = "debugCorrTextBox";
		Size size9 = new Size(190, 20);
		((Control)debugCorrTextBox).Size = size9;
		((Control)debugCorrTextBox).TabIndex = 15;
		debugCorrTextBox.Text = "Correlation.wav";
		debugCorrTextBox.TextAlign = (HorizontalAlignment)1;
		label23.AutoSize = true;
		Point location10 = new Point(6, 61);
		((Control)label23).Location = location10;
		((Control)label23).Name = "label23";
		Size size10 = new Size(147, 13);
		((Control)label23).Size = size10;
		((Control)label23).TabIndex = 14;
		label23.Text = "Saving recording to wave file:";
		Point location11 = new Point(197, 74);
		((Control)debugRecordingBrowseButton).Location = location11;
		((Control)debugRecordingBrowseButton).Name = "debugRecordingBrowseButton";
		Size size11 = new Size(50, 21);
		((Control)debugRecordingBrowseButton).Size = size11;
		((Control)debugRecordingBrowseButton).TabIndex = 13;
		((ButtonBase)debugRecordingBrowseButton).Text = "Browse";
		((ButtonBase)debugRecordingBrowseButton).UseVisualStyleBackColor = true;
		Point location12 = new Point(6, 75);
		((Control)debugRecordingTextBox).Location = location12;
		((Control)debugRecordingTextBox).Name = "debugRecordingTextBox";
		Size size12 = new Size(190, 20);
		((Control)debugRecordingTextBox).Size = size12;
		((Control)debugRecordingTextBox).TabIndex = 12;
		debugRecordingTextBox.Text = "Recording.wav";
		debugRecordingTextBox.TextAlign = (HorizontalAlignment)1;
		Point location13 = new Point(197, 37);
		((Control)debugOutputBrowseButton).Location = location13;
		((Control)debugOutputBrowseButton).Name = "debugOutputBrowseButton";
		Size size13 = new Size(50, 21);
		((Control)debugOutputBrowseButton).Size = size13;
		((Control)debugOutputBrowseButton).TabIndex = 11;
		((ButtonBase)debugOutputBrowseButton).Text = "Browse";
		((ButtonBase)debugOutputBrowseButton).UseVisualStyleBackColor = true;
		label22.AutoSize = true;
		Point location14 = new Point(6, 22);
		((Control)label22).Location = location14;
		((Control)label22).Name = "label22";
		Size size14 = new Size(133, 13);
		((Control)label22).Size = size14;
		((Control)label22).TabIndex = 10;
		label22.Text = "Saving output to wave file:";
		Point location15 = new Point(6, 38);
		((Control)debugOutputTextBox).Location = location15;
		((Control)debugOutputTextBox).Name = "debugOutputTextBox";
		Size size15 = new Size(190, 20);
		((Control)debugOutputTextBox).Size = size15;
		((Control)debugOutputTextBox).TabIndex = 9;
		debugOutputTextBox.Text = "Output.wav";
		debugOutputTextBox.TextAlign = (HorizontalAlignment)1;
		((Control)panel2).Controls.Add((Control)(object)nyquistExtCheckBox);
		((Control)panel2).Controls.Add((Control)(object)nyquistExtGroupBox);
		((Control)panel2).Controls.Add((Control)(object)timeZeroDetectRadioButton);
		((Control)panel2).Controls.Add((Control)(object)timeZeroLockHelpButton);
		((Control)panel2).Controls.Add((Control)(object)timeZeroLockedRadioButton);
		((Control)panel2).Controls.Add((Control)(object)groupBox8);
		((Control)panel2).Controls.Add((Control)(object)timeZeroDetectGroupBox);
		((Control)panel2).Controls.Add((Control)(object)groupBox5);
		((Control)panel2).Controls.Add((Control)(object)timeZeroLockedGroupBox);
		((Control)panel2).Dock = (DockStyle)5;
		Point location16 = new Point(2, 24);
		((Control)panel2).Location = location16;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Padding margin3);
		((Padding)(ref margin3))._002Ector(0);
		((Control)panel2).Margin = margin3;
		((Control)panel2).Name = "panel2";
		Size size16 = new Size(258, 469);
		((Control)panel2).Size = size16;
		((Control)panel2).TabIndex = 10;
		((ButtonBase)nyquistExtCheckBox).AutoSize = true;
		Point location17 = new Point(11, 279);
		((Control)nyquistExtCheckBox).Location = location17;
		((Control)nyquistExtCheckBox).Name = "nyquistExtCheckBox";
		Size size17 = new Size(159, 17);
		((Control)nyquistExtCheckBox).Size = size17;
		((Control)nyquistExtCheckBox).TabIndex = 8;
		((ButtonBase)nyquistExtCheckBox).Text = "Extend to Nyquist frequency";
		((ButtonBase)nyquistExtCheckBox).UseVisualStyleBackColor = true;
		nyquistExtCheckBox.CheckedChanged += nyquistExtCheckBox_CheckedChanged;
		((Control)nyquistExtGroupBox).Controls.Add((Control)(object)label3);
		((Control)nyquistExtGroupBox).Controls.Add((Control)(object)nyquistExtUpDown);
		((Control)nyquistExtGroupBox).Enabled = false;
		Point location18 = new Point(3, 281);
		((Control)nyquistExtGroupBox).Location = location18;
		((Control)nyquistExtGroupBox).Name = "nyquistExtGroupBox";
		Size size18 = new Size(250, 49);
		((Control)nyquistExtGroupBox).Size = size18;
		((Control)nyquistExtGroupBox).TabIndex = 26;
		nyquistExtGroupBox.TabStop = false;
		label3.AutoSize = true;
		Point location19 = new Point(3, 24);
		((Control)label3).Location = location19;
		((Control)label3).Name = "label3";
		Size size19 = new Size(144, 13);
		((Control)label3).Size = size19;
		((Control)label3).TabIndex = 1;
		label3.Text = "Extend from frequency [kHz]:";
		nyquistExtUpDown.DecimalPlaces = 1;
		Point location20 = new Point(147, 21);
		((Control)nyquistExtUpDown).Location = location20;
		decimal minimum = new decimal(new int[4] { 1, 0, 0, 0 });
		nyquistExtUpDown.Minimum = minimum;
		((Control)nyquistExtUpDown).Name = "nyquistExtUpDown";
		Size size20 = new Size(60, 20);
		((Control)nyquistExtUpDown).Size = size20;
		((Control)nyquistExtUpDown).TabIndex = 0;
		((UpDownBase)nyquistExtUpDown).TextAlign = (HorizontalAlignment)1;
		decimal value = new decimal(new int[4] { 20, 0, 0, 0 });
		nyquistExtUpDown.Value = value;
		((ButtonBase)timeZeroDetectRadioButton).AutoSize = true;
		timeZeroDetectRadioButton.Checked = true;
		Point location21 = new Point(13, 99);
		((Control)timeZeroDetectRadioButton).Location = location21;
		((Control)timeZeroDetectRadioButton).Name = "timeZeroDetectRadioButton";
		Size size21 = new Size(102, 17);
		((Control)timeZeroDetectRadioButton).Size = size21;
		((Control)timeZeroDetectRadioButton).TabIndex = 13;
		timeZeroDetectRadioButton.TabStop = true;
		((ButtonBase)timeZeroDetectRadioButton).Text = "Detect time zero";
		toolTip.SetToolTip((Control)(object)timeZeroDetectRadioButton, "Requieres \"Keep in/out stream active\"\r\nto get valid measurements\r\n\r\n1. Check  \"Keep in/out stream active\" under \"Device\"\r\n2. Measure to get initial delay\r\n ");
		((ButtonBase)timeZeroDetectRadioButton).UseVisualStyleBackColor = true;
		timeZeroDetectRadioButton.CheckedChanged += timeZeroDetectRadioButton_CheckedChanged;
		Point location22 = new Point(179, 220);
		((Control)timeZeroLockHelpButton).Location = location22;
		((Control)timeZeroLockHelpButton).Name = "timeZeroLockHelpButton";
		Size size22 = new Size(48, 21);
		((Control)timeZeroLockHelpButton).Size = size22;
		((Control)timeZeroLockHelpButton).TabIndex = 25;
		((ButtonBase)timeZeroLockHelpButton).Text = "Help";
		((ButtonBase)timeZeroLockHelpButton).UseVisualStyleBackColor = true;
		((ButtonBase)timeZeroLockedRadioButton).AutoSize = true;
		Point location23 = new Point(14, 182);
		((Control)timeZeroLockedRadioButton).Location = location23;
		((Control)timeZeroLockedRadioButton).Name = "timeZeroLockedRadioButton";
		Size size23 = new Size(182, 17);
		((Control)timeZeroLockedRadioButton).Size = size23;
		((Control)timeZeroLockedRadioButton).TabIndex = 12;
		timeZeroLockedRadioButton.TabStop = true;
		((ButtonBase)timeZeroLockedRadioButton).Text = "Time zero locked (time alignment)";
		toolTip.SetToolTip((Control)(object)timeZeroLockedRadioButton, "Requieres \"Keep in/out stream active\"\r\nto get valid measurements\r\n\r\n1. Check  \"Keep in/out stream active\" under \"Device\"\r\n2. Measure to get initial delay\r\n ");
		((ButtonBase)timeZeroLockedRadioButton).UseVisualStyleBackColor = true;
		timeZeroLockedRadioButton.CheckedChanged += timeZeroLockedRadioButton_CheckedChanged;
		((Control)groupBox8).Controls.Add((Control)(object)timeWindowAutoCheckBox);
		((Control)groupBox8).Controls.Add((Control)(object)postHighpassCheckBox);
		((Control)groupBox8).Controls.Add((Control)(object)normalize0dBCheckBox);
		Point location24 = new Point(3, 364);
		((Control)groupBox8).Location = location24;
		((Control)groupBox8).Name = "groupBox8";
		Size size24 = new Size(250, 94);
		((Control)groupBox8).Size = size24;
		((Control)groupBox8).TabIndex = 10;
		groupBox8.TabStop = false;
		groupBox8.Text = "Post measure";
		toolTip.SetToolTip((Control)(object)groupBox8, "Actions after the measurements has finished");
		((ButtonBase)timeWindowAutoCheckBox).AutoSize = true;
		timeWindowAutoCheckBox.Checked = true;
		timeWindowAutoCheckBox.CheckState = (CheckState)1;
		Point location25 = new Point(7, 36);
		((Control)timeWindowAutoCheckBox).Location = location25;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Padding margin4);
		((Padding)(ref margin4))._002Ector(1);
		((Control)timeWindowAutoCheckBox).Margin = margin4;
		((Control)timeWindowAutoCheckBox).Name = "timeWindowAutoCheckBox";
		Size size25 = new Size(134, 17);
		((Control)timeWindowAutoCheckBox).Size = size25;
		((Control)timeWindowAutoCheckBox).TabIndex = 0;
		((ButtonBase)timeWindowAutoCheckBox).Text = "Auto apply timewindow";
		((ButtonBase)timeWindowAutoCheckBox).UseVisualStyleBackColor = true;
		((ButtonBase)postHighpassCheckBox).AutoSize = true;
		postHighpassCheckBox.Checked = true;
		postHighpassCheckBox.CheckState = (CheckState)1;
		Point location26 = new Point(7, 55);
		((Control)postHighpassCheckBox).Location = location26;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Padding margin5);
		((Padding)(ref margin5))._002Ector(1);
		((Control)postHighpassCheckBox).Margin = margin5;
		((Control)postHighpassCheckBox).Name = "postHighpassCheckBox";
		((Control)postHighpassCheckBox).RightToLeft = (RightToLeft)0;
		Size size26 = new Size(183, 30);
		((Control)postHighpassCheckBox).Size = size26;
		((Control)postHighpassCheckBox).TabIndex = 10;
		((ButtonBase)postHighpassCheckBox).Text = "Highpass result to start frequency\r\n(Logsweep and chirp signals)";
		((ButtonBase)postHighpassCheckBox).UseVisualStyleBackColor = true;
		((ButtonBase)normalize0dBCheckBox).AutoSize = true;
		normalize0dBCheckBox.Checked = true;
		normalize0dBCheckBox.CheckState = (CheckState)1;
		Point location27 = new Point(7, 17);
		((Control)normalize0dBCheckBox).Location = location27;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Padding margin6);
		((Padding)(ref margin6))._002Ector(1);
		((Control)normalize0dBCheckBox).Margin = margin6;
		((Control)normalize0dBCheckBox).Name = "normalize0dBCheckBox";
		Size size27 = new Size(109, 17);
		((Control)normalize0dBCheckBox).Size = size27;
		((Control)normalize0dBCheckBox).TabIndex = 0;
		((ButtonBase)normalize0dBCheckBox).Text = "Normalize to 0 dB";
		((ButtonBase)normalize0dBCheckBox).UseVisualStyleBackColor = true;
		((Control)timeZeroDetectGroupBox).Controls.Add((Control)(object)timeDetectMethodComboBox);
		((Control)timeZeroDetectGroupBox).Controls.Add((Control)(object)timeDetectInterpolate);
		Point location28 = new Point(3, 102);
		((Control)timeZeroDetectGroupBox).Location = location28;
		((Control)timeZeroDetectGroupBox).Name = "timeZeroDetectGroupBox";
		Size size28 = new Size(250, 73);
		((Control)timeZeroDetectGroupBox).Size = size28;
		((Control)timeZeroDetectGroupBox).TabIndex = 9;
		timeZeroDetectGroupBox.TabStop = false;
		toolTip.SetToolTip((Control)(object)timeZeroDetectGroupBox, "Detection strategy of time zero\r\n(Time = 0 for the impulse domain)");
		timeDetectMethodComboBox.DropDownStyle = (ComboBoxStyle)2;
		((ListControl)timeDetectMethodComboBox).FormattingEnabled = true;
		object[] array = new object[5] { "First postive peak", "Highest postive peak", "First peak (positive/negative)", "Largest Peak (positive/negative)", "Causal Impulse (Analog / IIR Filters)" };
		timeDetectMethodComboBox.Items.AddRange(array);
		Point location29 = new Point(8, 19);
		((Control)timeDetectMethodComboBox).Location = location29;
		((Control)timeDetectMethodComboBox).Name = "timeDetectMethodComboBox";
		Size size29 = new Size(216, 21);
		((Control)timeDetectMethodComboBox).Size = size29;
		((Control)timeDetectMethodComboBox).TabIndex = 8;
		((ButtonBase)timeDetectInterpolate).AutoSize = true;
		timeDetectInterpolate.Checked = true;
		timeDetectInterpolate.CheckState = (CheckState)1;
		Point location30 = new Point(8, 45);
		((Control)timeDetectInterpolate).Location = location30;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Padding margin7);
		((Padding)(ref margin7))._002Ector(1);
		((Control)timeDetectInterpolate).Margin = margin7;
		((Control)timeDetectInterpolate).Name = "timeDetectInterpolate";
		Size size30 = new Size(163, 17);
		((Control)timeDetectInterpolate).Size = size30;
		((Control)timeDetectInterpolate).TabIndex = 5;
		((ButtonBase)timeDetectInterpolate).Text = "Interpolate (Sample fractions)";
		((ButtonBase)timeDetectInterpolate).UseVisualStyleBackColor = true;
		((Control)groupBox5).Controls.Add((Control)(object)label6);
		((Control)groupBox5).Controls.Add((Control)(object)label5);
		((Control)groupBox5).Controls.Add((Control)(object)label4);
		((Control)groupBox5).Controls.Add((Control)(object)fftSizeResHzTextBox);
		((Control)groupBox5).Controls.Add((Control)(object)label15);
		((Control)groupBox5).Controls.Add((Control)(object)saveSamplesTextBox);
		((Control)groupBox5).Controls.Add((Control)(object)label16);
		((Control)groupBox5).Controls.Add((Control)(object)saveMUpDown);
		Point location31 = new Point(3, 6);
		((Control)groupBox5).Location = location31;
		((Control)groupBox5).Name = "groupBox5";
		Size size31 = new Size(250, 86);
		((Control)groupBox5).Size = size31;
		((Control)groupBox5).TabIndex = 8;
		groupBox5.TabStop = false;
		groupBox5.Text = "Measurement data length (FFT size)";
		toolTip.SetToolTip((Control)(object)groupBox5, "The higher length the longer\r\nimpulse response in the time domain\r\nDefault value: 16\r\n\r\nThe shorter length the faster processing");
		label6.AutoSize = true;
		Point location32 = new Point(157, 65);
		((Control)label6).Location = location32;
		((Control)label6).Name = "label6";
		Size size32 = new Size(83, 13);
		((Control)label6).Size = size32;
		((Control)label6).TabIndex = 7;
		label6.Text = "(Samplerate / L)";
		label5.AutoSize = true;
		Point location33 = new Point(157, 44);
		((Control)label5).Location = location33;
		((Control)label5).Name = "label5";
		Size size33 = new Size(52, 13);
		((Control)label5).Size = size33;
		((Control)label5).TabIndex = 6;
		label5.Text = "(L = 2^M)";
		label4.AutoSize = true;
		Point location34 = new Point(5, 65);
		((Control)label4).Location = location34;
		((Control)label4).Name = "label4";
		Size size34 = new Size(82, 13);
		((Control)label4).Size = size34;
		((Control)label4).TabIndex = 5;
		label4.Text = "Resolution [Hz]:";
		Point location35 = new Point(100, 62);
		((Control)fftSizeResHzTextBox).Location = location35;
		((Control)fftSizeResHzTextBox).Name = "fftSizeResHzTextBox";
		((TextBoxBase)fftSizeResHzTextBox).ReadOnly = true;
		((Control)fftSizeResHzTextBox).RightToLeft = (RightToLeft)1;
		Size size35 = new Size(51, 20);
		((Control)fftSizeResHzTextBox).Size = size35;
		((Control)fftSizeResHzTextBox).TabIndex = 4;
		((Control)fftSizeResHzTextBox).TabStop = false;
		fftSizeResHzTextBox.Text = "131072";
		label15.AutoSize = true;
		Point location36 = new Point(5, 44);
		((Control)label15).Location = location36;
		((Control)label15).Name = "label15";
		Size size36 = new Size(92, 13);
		((Control)label15).Size = size36;
		((Control)label15).TabIndex = 3;
		label15.Text = "Length [Samples]:";
		Point location37 = new Point(100, 41);
		((Control)saveSamplesTextBox).Location = location37;
		((Control)saveSamplesTextBox).Name = "saveSamplesTextBox";
		((TextBoxBase)saveSamplesTextBox).ReadOnly = true;
		((Control)saveSamplesTextBox).RightToLeft = (RightToLeft)1;
		Size size37 = new Size(51, 20);
		((Control)saveSamplesTextBox).Size = size37;
		((Control)saveSamplesTextBox).TabIndex = 2;
		((Control)saveSamplesTextBox).TabStop = false;
		saveSamplesTextBox.Text = "131072";
		label16.AutoSize = true;
		Point location38 = new Point(7, 22);
		((Control)label16).Location = location38;
		((Control)label16).Name = "label16";
		Size size38 = new Size(44, 13);
		((Control)label16).Size = size38;
		((Control)label16).TabIndex = 1;
		label16.Text = "FFT  M:";
		Point location39 = new Point(100, 20);
		((Control)saveMUpDown).Location = location39;
		decimal maximum = new decimal(new int[4] { 20, 0, 0, 0 });
		saveMUpDown.Maximum = maximum;
		decimal minimum2 = new decimal(new int[4] { 14, 0, 0, 0 });
		saveMUpDown.Minimum = minimum2;
		((Control)saveMUpDown).Name = "saveMUpDown";
		Size size39 = new Size(51, 20);
		((Control)saveMUpDown).Size = size39;
		((Control)saveMUpDown).TabIndex = 1;
		((UpDownBase)saveMUpDown).TextAlign = (HorizontalAlignment)1;
		decimal value2 = new decimal(new int[4] { 17, 0, 0, 0 });
		saveMUpDown.Value = value2;
		((Control)timeZeroLockedGroupBox).Controls.Add((Control)(object)timeLockedUnitLabel);
		((Control)timeZeroLockedGroupBox).Controls.Add((Control)(object)timeZeroLockUpDown);
		((Control)timeZeroLockedGroupBox).Controls.Add((Control)(object)label1);
		((Control)timeZeroLockedGroupBox).Controls.Add((Control)(object)timeZeroLockUseButton);
		((Control)timeZeroLockedGroupBox).Controls.Add((Control)(object)timeZeroLockDetectTextBox);
		((Control)timeZeroLockedGroupBox).Controls.Add((Control)(object)label17);
		((Control)timeZeroLockedGroupBox).Enabled = false;
		Point location40 = new Point(3, 184);
		((Control)timeZeroLockedGroupBox).Location = location40;
		((Control)timeZeroLockedGroupBox).Name = "timeZeroLockedGroupBox";
		Size size40 = new Size(250, 90);
		((Control)timeZeroLockedGroupBox).Size = size40;
		((Control)timeZeroLockedGroupBox).TabIndex = 11;
		timeZeroLockedGroupBox.TabStop = false;
		timeLockedUnitLabel.AutoSize = true;
		Point location41 = new Point(84, 19);
		((Control)timeLockedUnitLabel).Location = location41;
		((Control)timeLockedUnitLabel).Name = "timeLockedUnitLabel";
		Size size41 = new Size(51, 13);
		((Control)timeLockedUnitLabel).Size = size41;
		((Control)timeLockedUnitLabel).TabIndex = 26;
		timeLockedUnitLabel.Text = "[samples]";
		timeZeroLockUpDown.DecimalPlaces = 3;
		Point location42 = new Point(85, 36);
		((Control)timeZeroLockUpDown).Location = location42;
		decimal maximum2 = new decimal(new int[4] { 10000000, 0, 0, 0 });
		timeZeroLockUpDown.Maximum = maximum2;
		((Control)timeZeroLockUpDown).Name = "timeZeroLockUpDown";
		((Control)timeZeroLockUpDown).RightToLeft = (RightToLeft)0;
		Size size42 = new Size(85, 20);
		((Control)timeZeroLockUpDown).Size = size42;
		((Control)timeZeroLockUpDown).TabIndex = 24;
		((UpDownBase)timeZeroLockUpDown).TextAlign = (HorizontalAlignment)1;
		decimal value3 = new decimal(new int[4] { 20000, 0, 0, 0 });
		timeZeroLockUpDown.Value = value3;
		label1.AutoSize = true;
		Point location43 = new Point(3, 40);
		((Control)label1).Location = location43;
		((Control)label1).Name = "label1";
		Size size43 = new Size(75, 13);
		((Control)label1).Size = size43;
		((Control)label1).TabIndex = 23;
		label1.Text = "Locked offset:";
		((Control)timeZeroLockUseButton).Enabled = false;
		Point location44 = new Point(176, 63);
		((Control)timeZeroLockUseButton).Location = location44;
		((Control)timeZeroLockUseButton).Name = "timeZeroLockUseButton";
		Size size44 = new Size(48, 21);
		((Control)timeZeroLockUseButton).Size = size44;
		((Control)timeZeroLockUseButton).TabIndex = 22;
		((ButtonBase)timeZeroLockUseButton).Text = "Use";
		((ButtonBase)timeZeroLockUseButton).UseVisualStyleBackColor = true;
		Color controlLight = SystemColors.ControlLight;
		((TextBoxBase)timeZeroLockDetectTextBox).BackColor = controlLight;
		Point location45 = new Point(85, 64);
		((Control)timeZeroLockDetectTextBox).Location = location45;
		((Control)timeZeroLockDetectTextBox).Name = "timeZeroLockDetectTextBox";
		((TextBoxBase)timeZeroLockDetectTextBox).ReadOnly = true;
		Size size45 = new Size(85, 20);
		((Control)timeZeroLockDetectTextBox).Size = size45;
		((Control)timeZeroLockDetectTextBox).TabIndex = 19;
		((Control)timeZeroLockDetectTextBox).TabStop = false;
		timeZeroLockDetectTextBox.Text = "243,123";
		timeZeroLockDetectTextBox.TextAlign = (HorizontalAlignment)1;
		label17.AutoSize = true;
		Point location46 = new Point(3, 67);
		((Control)label17).Location = location46;
		((Control)label17).Name = "label17";
		Size size46 = new Size(75, 13);
		((Control)label17).Size = size46;
		((Control)label17).TabIndex = 20;
		label17.Text = "Last detected:";
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Control)this).Controls.Add((Control)(object)devTableLayoutPanel);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Padding margin8);
		((Padding)(ref margin8))._002Ector(0);
		((Control)this).Margin = margin8;
		((Control)this).Name = "ControlDataAnalysis";
		Size size47 = new Size(784, 495);
		((Control)this).Size = size47;
		((Control)devTableLayoutPanel).ResumeLayout(false);
		((Control)devTableLayoutPanel).PerformLayout();
		((Control)panel1).ResumeLayout(false);
		((Control)panel1).PerformLayout();
		((Control)debugInOutGroupBox).ResumeLayout(false);
		((Control)debugInOutGroupBox).PerformLayout();
		((Control)panel2).ResumeLayout(false);
		((Control)panel2).PerformLayout();
		((Control)nyquistExtGroupBox).ResumeLayout(false);
		((Control)nyquistExtGroupBox).PerformLayout();
		((ISupportInitialize)nyquistExtUpDown).EndInit();
		((Control)groupBox8).ResumeLayout(false);
		((Control)groupBox8).PerformLayout();
		((Control)timeZeroDetectGroupBox).ResumeLayout(false);
		((Control)timeZeroDetectGroupBox).PerformLayout();
		((Control)groupBox5).ResumeLayout(false);
		((Control)groupBox5).PerformLayout();
		((ISupportInitialize)saveMUpDown).EndInit();
		((Control)timeZeroLockedGroupBox).ResumeLayout(false);
		((Control)timeZeroLockedGroupBox).PerformLayout();
		((ISupportInitialize)timeZeroLockUpDown).EndInit();
		((Control)this).ResumeLayout(false);
	}

	private void timeZeroDetectRadioButton_CheckedChanged(object sender, EventArgs e)
	{
		((Control)timeZeroDetectGroupBox).Enabled = timeZeroDetectRadioButton.Checked;
	}

	private void timeZeroLockedRadioButton_CheckedChanged(object sender, EventArgs e)
	{
		((Control)timeZeroLockedGroupBox).Enabled = timeZeroLockedRadioButton.Checked;
	}

	private void nyquistExtCheckBox_CheckedChanged(object sender, EventArgs e)
	{
		((Control)nyquistExtGroupBox).Enabled = nyquistExtCheckBox.Checked;
	}

	private void saveMeasWavesCheckBox_CheckedChanged(object sender, EventArgs e)
	{
		((Control)debugInOutGroupBox).Enabled = saveMeasWavesCheckBox.Checked;
	}

	protected override void Dispose([MarshalAs(UnmanagedType.U1)] bool P_0)
	{
		if (P_0)
		{
			try
			{
				_007EControlDataAnalysis();
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
