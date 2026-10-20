using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace HOLM.HOLMImpulse;

public class ControlDevSignal : UserControl
{
	public TableLayoutPanel devTableLayoutPanel;

	public Panel panel3;

	private GroupBox groupBox11;

	private Label label1;

	public Button deviceRestartStreamButton;

	public ComboBox sampleRateComboBox;

	public CheckBox deviceKeepStreamCheckBox;

	public ToolTip toolTip;

	public GroupBox inputDevGroupBox;

	public RadioButton input2RadioButton;

	public RadioButton input1RadioButton;

	public CheckBox inputInvertCheckBox;

	private Label label2;

	public ComboBox inputDevComboBox;

	public GroupBox outputDevGroupBox;

	public Button asioControlButton;

	private Label label3;

	public CheckBox output2CheckBox;

	public CheckBox output1CheckBox;

	public ComboBox outputDevComboBox;

	private Label label10;

	public Panel panel2;

	private GroupBox groupBox6;

	public CheckBox signalSaveExtendZeroesCheckBox;

	public Button signalSaveButton;

	public Button signalInverseSaveButton;

	public RadioButton outputLogSweepRadioButton;

	public RadioButton outputSqRadioButton;

	public GroupBox sqNoiseGroupBox;

	private Label label28;

	public NumericUpDown outputAmpUpDown;

	private Label label13;

	public NumericUpDown sqNoiseUpDown;

	public GroupBox groupBox3;

	private Label label8;

	public TextBox signalMsTextBox;

	private Label SamplesLabel;

	public TextBox signalSamplesTextBox;

	private Label label6;

	public NumericUpDown signalMUpDown;

	public GroupBox logSweepGroupBox;

	public CheckBox signalFadeOutCheckBox;

	public CheckBox signalFadeInCheckBox;

	public NumericUpDown signalFadeOutUpDown;

	public NumericUpDown signalFadeInUpDown;

	private Label label11;

	public NumericUpDown logSweepStartFreqUpDown;

	public RadioButton outputChirpRadioButton;

	public GroupBox chirpGroupBox;

	private Label label12;

	public NumericUpDown chirpPotensUpDown;

	private Label label9;

	public GroupBox groupBox4;

	private Label label17;

	public TextBox devDelaymsCalTextBox;

	private Label label7;

	public NumericUpDown recMaxDelayUpDown;

	private Label label24;

	public NumericUpDown chirpStartFreqUpDown;

	private GroupBox fadingGroupBox;

	private Panel panel1;

	private Label label4;

	public NumericUpDown outputDBUpDown;

	private Label label14;

	private Label label15;

	public NumericUpDown sqNoiseAmpUpDown;

	private Label label16;

	public Button devReinitialize;

	private GroupBox groupBox5;

	public Button devShowInfoButton;

	public GroupBox groupBox10;

	public Button calDacAdcMakeButton;

	public Button calDacAdcImportButton;

	public CheckBox calDacAdcCheckBox;

	public Button calMicImportButton;

	public CheckBox calMicCheckBox;

	public RadioButton input4RadioButton;

	public RadioButton input3RadioButton;

	public CheckBox output4CheckBox;

	public CheckBox output3CheckBox;

	public ComboBox apiComboBox;

	private Label label18;

	public Button recordMeterButton;

	private IContainer components;

	public ControlDevSignal()
	{
		try
		{
			InitializeComponent();
			apiComboBox.SelectedIndex = 0;
			return;
		}
		catch
		{
			//try-fault
			((ContainerControl)this).Dispose(true);
			throw;
		}
	}

	private void _007EControlDevSignal()
	{
		components?.Dispose();
	}

	private void InitializeComponent()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected O, but got Unknown
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected O, but got Unknown
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected O, but got Unknown
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected O, but got Unknown
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected O, but got Unknown
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected O, but got Unknown
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected O, but got Unknown
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected O, but got Unknown
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected O, but got Unknown
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected O, but got Unknown
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Expected O, but got Unknown
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected O, but got Unknown
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Expected O, but got Unknown
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Expected O, but got Unknown
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Expected O, but got Unknown
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Expected O, but got Unknown
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Expected O, but got Unknown
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Expected O, but got Unknown
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Expected O, but got Unknown
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Expected O, but got Unknown
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Expected O, but got Unknown
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Expected O, but got Unknown
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Expected O, but got Unknown
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Expected O, but got Unknown
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Expected O, but got Unknown
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Expected O, but got Unknown
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Expected O, but got Unknown
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Expected O, but got Unknown
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Expected O, but got Unknown
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Expected O, but got Unknown
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Expected O, but got Unknown
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Expected O, but got Unknown
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Expected O, but got Unknown
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d6: Expected O, but got Unknown
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e1: Expected O, but got Unknown
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ec: Expected O, but got Unknown
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f7: Expected O, but got Unknown
		//IL_01f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Expected O, but got Unknown
		//IL_0203: Unknown result type (might be due to invalid IL or missing references)
		//IL_020d: Expected O, but got Unknown
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Expected O, but got Unknown
		//IL_0219: Unknown result type (might be due to invalid IL or missing references)
		//IL_0223: Expected O, but got Unknown
		//IL_0224: Unknown result type (might be due to invalid IL or missing references)
		//IL_022e: Expected O, but got Unknown
		//IL_022f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0239: Expected O, but got Unknown
		//IL_023a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0244: Expected O, but got Unknown
		//IL_0245: Unknown result type (might be due to invalid IL or missing references)
		//IL_024f: Expected O, but got Unknown
		//IL_0250: Unknown result type (might be due to invalid IL or missing references)
		//IL_025a: Expected O, but got Unknown
		//IL_025b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0265: Expected O, but got Unknown
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_0270: Expected O, but got Unknown
		//IL_0271: Unknown result type (might be due to invalid IL or missing references)
		//IL_027b: Expected O, but got Unknown
		//IL_027c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0286: Expected O, but got Unknown
		//IL_0287: Unknown result type (might be due to invalid IL or missing references)
		//IL_0291: Expected O, but got Unknown
		//IL_0292: Unknown result type (might be due to invalid IL or missing references)
		//IL_029c: Expected O, but got Unknown
		//IL_029d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a7: Expected O, but got Unknown
		//IL_02a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b2: Expected O, but got Unknown
		//IL_02b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bd: Expected O, but got Unknown
		//IL_02be: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c8: Expected O, but got Unknown
		//IL_02c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d3: Expected O, but got Unknown
		//IL_02d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02de: Expected O, but got Unknown
		//IL_02df: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e9: Expected O, but got Unknown
		//IL_02ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f4: Expected O, but got Unknown
		//IL_02f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ff: Expected O, but got Unknown
		//IL_0300: Unknown result type (might be due to invalid IL or missing references)
		//IL_030a: Expected O, but got Unknown
		//IL_030b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0315: Expected O, but got Unknown
		//IL_0316: Unknown result type (might be due to invalid IL or missing references)
		//IL_0320: Expected O, but got Unknown
		//IL_0321: Unknown result type (might be due to invalid IL or missing references)
		//IL_032b: Expected O, but got Unknown
		//IL_032c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0336: Expected O, but got Unknown
		//IL_0337: Unknown result type (might be due to invalid IL or missing references)
		//IL_0341: Expected O, but got Unknown
		//IL_0342: Unknown result type (might be due to invalid IL or missing references)
		//IL_034c: Expected O, but got Unknown
		//IL_034d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0357: Expected O, but got Unknown
		//IL_0358: Unknown result type (might be due to invalid IL or missing references)
		//IL_0362: Expected O, but got Unknown
		//IL_0363: Unknown result type (might be due to invalid IL or missing references)
		//IL_036d: Expected O, but got Unknown
		//IL_036e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0378: Expected O, but got Unknown
		//IL_0379: Unknown result type (might be due to invalid IL or missing references)
		//IL_0383: Expected O, but got Unknown
		//IL_0384: Unknown result type (might be due to invalid IL or missing references)
		//IL_038e: Expected O, but got Unknown
		//IL_038f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0399: Expected O, but got Unknown
		//IL_039a: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a4: Expected O, but got Unknown
		//IL_03ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b5: Expected O, but got Unknown
		//IL_050d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0517: Expected O, but got Unknown
		//IL_0529: Unknown result type (might be due to invalid IL or missing references)
		//IL_0533: Expected O, but got Unknown
		//IL_0545: Unknown result type (might be due to invalid IL or missing references)
		//IL_054f: Expected O, but got Unknown
		//IL_0633: Unknown result type (might be due to invalid IL or missing references)
		//IL_063d: Expected O, but got Unknown
		//IL_064f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0659: Expected O, but got Unknown
		//IL_06b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_06be: Expected O, but got Unknown
		//IL_07c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_12e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_138c: Unknown result type (might be due to invalid IL or missing references)
		//IL_142d: Unknown result type (might be due to invalid IL or missing references)
		//IL_14da: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f87: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f91: Expected O, but got Unknown
		//IL_20f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_22a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_2343: Unknown result type (might be due to invalid IL or missing references)
		//IL_2540: Unknown result type (might be due to invalid IL or missing references)
		//IL_25f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_383b: Unknown result type (might be due to invalid IL or missing references)
		//IL_3845: Expected O, but got Unknown
		//IL_38ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_3a30: Unknown result type (might be due to invalid IL or missing references)
		//IL_3c8f: Unknown result type (might be due to invalid IL or missing references)
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(ControlDevSignal));
		devTableLayoutPanel = new TableLayoutPanel();
		label4 = new Label();
		panel3 = new Panel();
		groupBox5 = new GroupBox();
		label18 = new Label();
		apiComboBox = new ComboBox();
		devShowInfoButton = new Button();
		devReinitialize = new Button();
		groupBox4 = new GroupBox();
		label17 = new Label();
		devDelaymsCalTextBox = new TextBox();
		label7 = new Label();
		recMaxDelayUpDown = new NumericUpDown();
		groupBox11 = new GroupBox();
		label1 = new Label();
		deviceRestartStreamButton = new Button();
		sampleRateComboBox = new ComboBox();
		deviceKeepStreamCheckBox = new CheckBox();
		inputDevGroupBox = new GroupBox();
		recordMeterButton = new Button();
		input4RadioButton = new RadioButton();
		input3RadioButton = new RadioButton();
		input2RadioButton = new RadioButton();
		input1RadioButton = new RadioButton();
		inputInvertCheckBox = new CheckBox();
		label2 = new Label();
		inputDevComboBox = new ComboBox();
		outputDevGroupBox = new GroupBox();
		output4CheckBox = new CheckBox();
		asioControlButton = new Button();
		output3CheckBox = new CheckBox();
		outputDBUpDown = new NumericUpDown();
		outputAmpUpDown = new NumericUpDown();
		label28 = new Label();
		label3 = new Label();
		output2CheckBox = new CheckBox();
		output1CheckBox = new CheckBox();
		outputDevComboBox = new ComboBox();
		label14 = new Label();
		label15 = new Label();
		label10 = new Label();
		panel2 = new Panel();
		groupBox6 = new GroupBox();
		signalSaveExtendZeroesCheckBox = new CheckBox();
		signalSaveButton = new Button();
		signalInverseSaveButton = new Button();
		outputSqRadioButton = new RadioButton();
		fadingGroupBox = new GroupBox();
		signalFadeOutCheckBox = new CheckBox();
		signalFadeInCheckBox = new CheckBox();
		signalFadeInUpDown = new NumericUpDown();
		signalFadeOutUpDown = new NumericUpDown();
		outputLogSweepRadioButton = new RadioButton();
		sqNoiseGroupBox = new GroupBox();
		sqNoiseAmpUpDown = new NumericUpDown();
		label16 = new Label();
		label13 = new Label();
		sqNoiseUpDown = new NumericUpDown();
		groupBox3 = new GroupBox();
		label8 = new Label();
		signalMsTextBox = new TextBox();
		SamplesLabel = new Label();
		signalSamplesTextBox = new TextBox();
		label6 = new Label();
		signalMUpDown = new NumericUpDown();
		logSweepGroupBox = new GroupBox();
		label11 = new Label();
		logSweepStartFreqUpDown = new NumericUpDown();
		outputChirpRadioButton = new RadioButton();
		chirpGroupBox = new GroupBox();
		chirpStartFreqUpDown = new NumericUpDown();
		label24 = new Label();
		label12 = new Label();
		chirpPotensUpDown = new NumericUpDown();
		label9 = new Label();
		panel1 = new Panel();
		groupBox10 = new GroupBox();
		calDacAdcMakeButton = new Button();
		calDacAdcImportButton = new Button();
		calDacAdcCheckBox = new CheckBox();
		calMicImportButton = new Button();
		calMicCheckBox = new CheckBox();
		toolTip = new ToolTip(components);
		((Control)devTableLayoutPanel).SuspendLayout();
		((Control)panel3).SuspendLayout();
		((Control)groupBox5).SuspendLayout();
		((Control)groupBox4).SuspendLayout();
		((ISupportInitialize)recMaxDelayUpDown).BeginInit();
		((Control)groupBox11).SuspendLayout();
		((Control)inputDevGroupBox).SuspendLayout();
		((Control)outputDevGroupBox).SuspendLayout();
		((ISupportInitialize)outputDBUpDown).BeginInit();
		((ISupportInitialize)outputAmpUpDown).BeginInit();
		((Control)panel2).SuspendLayout();
		((Control)groupBox6).SuspendLayout();
		((Control)fadingGroupBox).SuspendLayout();
		((ISupportInitialize)signalFadeInUpDown).BeginInit();
		((ISupportInitialize)signalFadeOutUpDown).BeginInit();
		((Control)sqNoiseGroupBox).SuspendLayout();
		((ISupportInitialize)sqNoiseAmpUpDown).BeginInit();
		((ISupportInitialize)sqNoiseUpDown).BeginInit();
		((Control)groupBox3).SuspendLayout();
		((ISupportInitialize)signalMUpDown).BeginInit();
		((Control)logSweepGroupBox).SuspendLayout();
		((ISupportInitialize)logSweepStartFreqUpDown).BeginInit();
		((Control)chirpGroupBox).SuspendLayout();
		((ISupportInitialize)chirpStartFreqUpDown).BeginInit();
		((ISupportInitialize)chirpPotensUpDown).BeginInit();
		((Control)panel1).SuspendLayout();
		((Control)groupBox10).SuspendLayout();
		((Control)this).SuspendLayout();
		devTableLayoutPanel.CellBorderStyle = (TableLayoutPanelCellBorderStyle)4;
		devTableLayoutPanel.ColumnCount = 3;
		devTableLayoutPanel.ColumnStyles.Add(new ColumnStyle((SizeType)2, 33.33333f));
		devTableLayoutPanel.ColumnStyles.Add(new ColumnStyle((SizeType)2, 33.33333f));
		devTableLayoutPanel.ColumnStyles.Add(new ColumnStyle((SizeType)2, 33.33333f));
		devTableLayoutPanel.Controls.Add((Control)(object)label4, 2, 0);
		devTableLayoutPanel.Controls.Add((Control)(object)panel3, 0, 1);
		devTableLayoutPanel.Controls.Add((Control)(object)label10, 0, 0);
		devTableLayoutPanel.Controls.Add((Control)(object)panel2, 1, 1);
		devTableLayoutPanel.Controls.Add((Control)(object)label9, 1, 0);
		devTableLayoutPanel.Controls.Add((Control)(object)panel1, 2, 1);
		((Control)devTableLayoutPanel).Dock = (DockStyle)5;
		Point location = new Point(0, 0);
		((Control)devTableLayoutPanel).Location = location;
		((Control)devTableLayoutPanel).Name = "devTableLayoutPanel";
		devTableLayoutPanel.RowCount = 2;
		devTableLayoutPanel.RowStyles.Add(new RowStyle((SizeType)1, 20f));
		devTableLayoutPanel.RowStyles.Add(new RowStyle((SizeType)1, 20f));
		Size size = new Size(784, 495);
		((Control)devTableLayoutPanel).Size = size;
		((Control)devTableLayoutPanel).TabIndex = 11;
		((Control)label4).Anchor = (AnchorStyles)0;
		label4.AutoSize = true;
		((Control)label4).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		Point location2 = new Point(618, 5);
		((Control)label4).Location = location2;
		((Control)label4).Name = "label4";
		Size size2 = new Size(67, 13);
		((Control)label4).Size = size2;
		((Control)label4).TabIndex = 7;
		label4.Text = "Calibration";
		((Control)panel3).Controls.Add((Control)(object)groupBox5);
		((Control)panel3).Controls.Add((Control)(object)groupBox4);
		((Control)panel3).Controls.Add((Control)(object)groupBox11);
		((Control)panel3).Controls.Add((Control)(object)inputDevGroupBox);
		((Control)panel3).Controls.Add((Control)(object)outputDevGroupBox);
		((Control)panel3).Dock = (DockStyle)5;
		Point location3 = new Point(2, 24);
		((Control)panel3).Location = location3;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Padding margin);
		((Padding)(ref margin))._002Ector(0);
		((Control)panel3).Margin = margin;
		((Control)panel3).Name = "panel3";
		Size size3 = new Size(258, 469);
		((Control)panel3).Size = size3;
		((Control)panel3).TabIndex = 2;
		((Control)groupBox5).Controls.Add((Control)(object)label18);
		((Control)groupBox5).Controls.Add((Control)(object)apiComboBox);
		((Control)groupBox5).Controls.Add((Control)(object)devShowInfoButton);
		((Control)groupBox5).Controls.Add((Control)(object)devReinitialize);
		Point location4 = new Point(3, 6);
		((Control)groupBox5).Location = location4;
		((Control)groupBox5).Name = "groupBox5";
		Size size4 = new Size(250, 70);
		((Control)groupBox5).Size = size4;
		((Control)groupBox5).TabIndex = 11;
		groupBox5.TabStop = false;
		groupBox5.Text = "Audio library";
		label18.AutoSize = true;
		Point location5 = new Point(7, 49);
		((Control)label18).Location = location5;
		((Control)label18).Name = "label18";
		Size size5 = new Size(27, 13);
		((Control)label18).Size = size5;
		((Control)label18).TabIndex = 3;
		label18.Text = "API:";
		apiComboBox.DropDownStyle = (ComboBoxStyle)2;
		((ListControl)apiComboBox).FormattingEnabled = true;
		object[] array = new object[3] { "MME", "Direct Sound", "ASIO" };
		apiComboBox.Items.AddRange(array);
		Point location6 = new Point(36, 44);
		((Control)apiComboBox).Location = location6;
		((Control)apiComboBox).Name = "apiComboBox";
		Size size6 = new Size(115, 21);
		((Control)apiComboBox).Size = size6;
		((Control)apiComboBox).TabIndex = 2;
		Point location7 = new Point(159, 17);
		((Control)devShowInfoButton).Location = location7;
		((Control)devShowInfoButton).Name = "devShowInfoButton";
		Size size7 = new Size(85, 21);
		((Control)devShowInfoButton).Size = size7;
		((Control)devShowInfoButton).TabIndex = 1;
		((ButtonBase)devShowInfoButton).Text = "Show info";
		((ButtonBase)devShowInfoButton).UseVisualStyleBackColor = true;
		Point location8 = new Point(6, 17);
		((Control)devReinitialize).Location = location8;
		((Control)devReinitialize).Name = "devReinitialize";
		Size size8 = new Size(145, 21);
		((Control)devReinitialize).Size = size8;
		((Control)devReinitialize).TabIndex = 0;
		((ButtonBase)devReinitialize).Text = "Reinitialize and refresh";
		((ButtonBase)devReinitialize).UseVisualStyleBackColor = true;
		((Control)groupBox4).Controls.Add((Control)(object)label17);
		((Control)groupBox4).Controls.Add((Control)(object)devDelaymsCalTextBox);
		((Control)groupBox4).Controls.Add((Control)(object)label7);
		((Control)groupBox4).Controls.Add((Control)(object)recMaxDelayUpDown);
		Point location9 = new Point(3, 398);
		((Control)groupBox4).Location = location9;
		((Control)groupBox4).Name = "groupBox4";
		Size size9 = new Size(250, 68);
		((Control)groupBox4).Size = size9;
		((Control)groupBox4).TabIndex = 10;
		groupBox4.TabStop = false;
		groupBox4.Text = "Recording delay";
		label17.AutoSize = true;
		Point location10 = new Point(7, 42);
		((Control)label17).Location = location10;
		((Control)label17).Name = "label17";
		Size size10 = new Size(139, 13);
		((Control)label17).Size = size10;
		((Control)label17).TabIndex = 18;
		label17.Text = "Last recording delay [msec]:";
		Color controlLight = SystemColors.ControlLight;
		((TextBoxBase)devDelaymsCalTextBox).BackColor = controlLight;
		Point location11 = new Point(162, 40);
		((Control)devDelaymsCalTextBox).Location = location11;
		((Control)devDelaymsCalTextBox).Name = "devDelaymsCalTextBox";
		((TextBoxBase)devDelaymsCalTextBox).ReadOnly = true;
		Size size11 = new Size(51, 20);
		((Control)devDelaymsCalTextBox).Size = size11;
		((Control)devDelaymsCalTextBox).TabIndex = 16;
		((Control)devDelaymsCalTextBox).TabStop = false;
		devDelaymsCalTextBox.Text = "243";
		devDelaymsCalTextBox.TextAlign = (HorizontalAlignment)1;
		label7.AutoSize = true;
		Point location12 = new Point(7, 18);
		((Control)label7).Location = location12;
		((Control)label7).Name = "label7";
		Size size12 = new Size(127, 13);
		((Control)label7).Size = size12;
		((Control)label7).TabIndex = 4;
		label7.Text = "Record extra time [msec]:";
		Point location13 = new Point(162, 14);
		((Control)recMaxDelayUpDown).Location = location13;
		decimal maximum = new decimal(new int[4] { 5000, 0, 0, 0 });
		recMaxDelayUpDown.Maximum = maximum;
		((Control)recMaxDelayUpDown).Name = "recMaxDelayUpDown";
		Size size13 = new Size(51, 20);
		((Control)recMaxDelayUpDown).Size = size13;
		((Control)recMaxDelayUpDown).TabIndex = 1;
		((UpDownBase)recMaxDelayUpDown).TextAlign = (HorizontalAlignment)1;
		decimal value = new decimal(new int[4] { 1500, 0, 0, 0 });
		recMaxDelayUpDown.Value = value;
		((Control)groupBox11).Controls.Add((Control)(object)label1);
		((Control)groupBox11).Controls.Add((Control)(object)deviceRestartStreamButton);
		((Control)groupBox11).Controls.Add((Control)(object)sampleRateComboBox);
		((Control)groupBox11).Controls.Add((Control)(object)deviceKeepStreamCheckBox);
		Point location14 = new Point(3, 322);
		((Control)groupBox11).Location = location14;
		((Control)groupBox11).Name = "groupBox11";
		Size size14 = new Size(250, 70);
		((Control)groupBox11).Size = size14;
		((Control)groupBox11).TabIndex = 8;
		groupBox11.TabStop = false;
		groupBox11.Text = "Stream";
		label1.AutoSize = true;
		Point location15 = new Point(9, 21);
		((Control)label1).Location = location15;
		((Control)label1).Name = "label1";
		Size size15 = new Size(127, 13);
		((Control)label1).Size = size15;
		((Control)label1).TabIndex = 2;
		label1.Text = "In/out stream samplerate:";
		Point location16 = new Point(159, 44);
		((Control)deviceRestartStreamButton).Location = location16;
		((Control)deviceRestartStreamButton).Name = "deviceRestartStreamButton";
		Size size16 = new Size(85, 21);
		((Control)deviceRestartStreamButton).Size = size16;
		((Control)deviceRestartStreamButton).TabIndex = 7;
		((ButtonBase)deviceRestartStreamButton).Text = "Restart stream";
		((ButtonBase)deviceRestartStreamButton).UseVisualStyleBackColor = true;
		sampleRateComboBox.DropDownStyle = (ComboBoxStyle)2;
		((ListControl)sampleRateComboBox).FormattingEnabled = true;
		object[] array2 = new object[6] { "44.1 kHz", "48.0 kHz", "88.2 kHz", "96.0 kHz", "176.4 kHz", "192.0 kHz" };
		sampleRateComboBox.Items.AddRange(array2);
		Point location17 = new Point(159, 18);
		((Control)sampleRateComboBox).Location = location17;
		((Control)sampleRateComboBox).Name = "sampleRateComboBox";
		Size size17 = new Size(85, 21);
		((Control)sampleRateComboBox).Size = size17;
		((Control)sampleRateComboBox).TabIndex = 1;
		((ButtonBase)deviceKeepStreamCheckBox).AutoSize = true;
		deviceKeepStreamCheckBox.Checked = true;
		deviceKeepStreamCheckBox.CheckState = (CheckState)1;
		Point location18 = new Point(12, 45);
		((Control)deviceKeepStreamCheckBox).Location = location18;
		((Control)deviceKeepStreamCheckBox).Name = "deviceKeepStreamCheckBox";
		Size size18 = new Size(148, 17);
		((Control)deviceKeepStreamCheckBox).Size = size18;
		((Control)deviceKeepStreamCheckBox).TabIndex = 2;
		((ButtonBase)deviceKeepStreamCheckBox).Text = "Keep in/out stream active";
		toolTip.SetToolTip((Control)(object)deviceKeepStreamCheckBox, componentResourceManager.GetString("deviceKeepStreamCheckBox.ToolTip"));
		((ButtonBase)deviceKeepStreamCheckBox).UseVisualStyleBackColor = true;
		((Control)inputDevGroupBox).Controls.Add((Control)(object)recordMeterButton);
		((Control)inputDevGroupBox).Controls.Add((Control)(object)input4RadioButton);
		((Control)inputDevGroupBox).Controls.Add((Control)(object)input3RadioButton);
		((Control)inputDevGroupBox).Controls.Add((Control)(object)input2RadioButton);
		((Control)inputDevGroupBox).Controls.Add((Control)(object)input1RadioButton);
		((Control)inputDevGroupBox).Controls.Add((Control)(object)inputInvertCheckBox);
		((Control)inputDevGroupBox).Controls.Add((Control)(object)label2);
		((Control)inputDevGroupBox).Controls.Add((Control)(object)inputDevComboBox);
		Point location19 = new Point(3, 89);
		((Control)inputDevGroupBox).Location = location19;
		((Control)inputDevGroupBox).Name = "inputDevGroupBox";
		Size size19 = new Size(250, 90);
		((Control)inputDevGroupBox).Size = size19;
		((Control)inputDevGroupBox).TabIndex = 2;
		inputDevGroupBox.TabStop = false;
		inputDevGroupBox.Text = "Input device (Record)";
		Point location20 = new Point(159, 66);
		((Control)recordMeterButton).Location = location20;
		((Control)recordMeterButton).Name = "recordMeterButton";
		Size size20 = new Size(85, 20);
		((Control)recordMeterButton).Size = size20;
		((Control)recordMeterButton).TabIndex = 9;
		((ButtonBase)recordMeterButton).Text = "Record Meter";
		((ButtonBase)recordMeterButton).UseVisualStyleBackColor = true;
		((ButtonBase)input4RadioButton).AutoSize = true;
		Point location21 = new Point(189, 44);
		((Control)input4RadioButton).Location = location21;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Padding margin2);
		((Padding)(ref margin2))._002Ector(0);
		((Control)input4RadioButton).Margin = margin2;
		((Control)input4RadioButton).Name = "input4RadioButton";
		Size size21 = new Size(31, 17);
		((Control)input4RadioButton).Size = size21;
		((Control)input4RadioButton).TabIndex = 8;
		((ButtonBase)input4RadioButton).Text = "4";
		((ButtonBase)input4RadioButton).UseVisualStyleBackColor = true;
		((Control)input4RadioButton).Visible = false;
		((ButtonBase)input3RadioButton).AutoSize = true;
		Point location22 = new Point(158, 44);
		((Control)input3RadioButton).Location = location22;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Padding margin3);
		((Padding)(ref margin3))._002Ector(0);
		((Control)input3RadioButton).Margin = margin3;
		((Control)input3RadioButton).Name = "input3RadioButton";
		Size size22 = new Size(31, 17);
		((Control)input3RadioButton).Size = size22;
		((Control)input3RadioButton).TabIndex = 7;
		((ButtonBase)input3RadioButton).Text = "3";
		((ButtonBase)input3RadioButton).UseVisualStyleBackColor = true;
		((Control)input3RadioButton).Visible = false;
		((ButtonBase)input2RadioButton).AutoSize = true;
		Point location23 = new Point(108, 44);
		((Control)input2RadioButton).Location = location23;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Padding margin4);
		((Padding)(ref margin4))._002Ector(0);
		((Control)input2RadioButton).Margin = margin4;
		((Control)input2RadioButton).Name = "input2RadioButton";
		Size size23 = new Size(50, 17);
		((Control)input2RadioButton).Size = size23;
		((Control)input2RadioButton).TabIndex = 2;
		((ButtonBase)input2RadioButton).Text = "Right";
		((ButtonBase)input2RadioButton).UseVisualStyleBackColor = true;
		((Control)input2RadioButton).Visible = false;
		((ButtonBase)input1RadioButton).AutoSize = true;
		input1RadioButton.Checked = true;
		Point location24 = new Point(61, 44);
		((Control)input1RadioButton).Location = location24;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Padding margin5);
		((Padding)(ref margin5))._002Ector(0);
		((Control)input1RadioButton).Margin = margin5;
		((Control)input1RadioButton).Name = "input1RadioButton";
		Size size24 = new Size(43, 17);
		((Control)input1RadioButton).Size = size24;
		((Control)input1RadioButton).TabIndex = 1;
		input1RadioButton.TabStop = true;
		((ButtonBase)input1RadioButton).Text = "Left";
		((ButtonBase)input1RadioButton).UseVisualStyleBackColor = true;
		((ButtonBase)inputInvertCheckBox).AutoSize = true;
		Point location25 = new Point(11, 67);
		((Control)inputInvertCheckBox).Location = location25;
		((Control)inputInvertCheckBox).Name = "inputInvertCheckBox";
		((Control)inputInvertCheckBox).RightToLeft = (RightToLeft)0;
		Size size25 = new Size(128, 17);
		((Control)inputInvertCheckBox).Size = size25;
		((Control)inputInvertCheckBox).TabIndex = 4;
		((ButtonBase)inputInvertCheckBox).Text = "Invert recorded signal";
		((ButtonBase)inputInvertCheckBox).UseVisualStyleBackColor = true;
		label2.AutoSize = true;
		Point location26 = new Point(9, 46);
		((Control)label2).Location = location26;
		((Control)label2).Name = "label2";
		Size size26 = new Size(49, 13);
		((Control)label2).Size = size26;
		((Control)label2).TabIndex = 6;
		label2.Text = "Channel:";
		inputDevComboBox.DropDownStyle = (ComboBoxStyle)2;
		((ListControl)inputDevComboBox).FormattingEnabled = true;
		Point location27 = new Point(6, 19);
		((Control)inputDevComboBox).Location = location27;
		((Control)inputDevComboBox).Name = "inputDevComboBox";
		Size size27 = new Size(238, 21);
		((Control)inputDevComboBox).Size = size27;
		((Control)inputDevComboBox).TabIndex = 0;
		((Control)outputDevGroupBox).Controls.Add((Control)(object)output4CheckBox);
		((Control)outputDevGroupBox).Controls.Add((Control)(object)asioControlButton);
		((Control)outputDevGroupBox).Controls.Add((Control)(object)output3CheckBox);
		((Control)outputDevGroupBox).Controls.Add((Control)(object)outputDBUpDown);
		((Control)outputDevGroupBox).Controls.Add((Control)(object)outputAmpUpDown);
		((Control)outputDevGroupBox).Controls.Add((Control)(object)label28);
		((Control)outputDevGroupBox).Controls.Add((Control)(object)label3);
		((Control)outputDevGroupBox).Controls.Add((Control)(object)output2CheckBox);
		((Control)outputDevGroupBox).Controls.Add((Control)(object)output1CheckBox);
		((Control)outputDevGroupBox).Controls.Add((Control)(object)outputDevComboBox);
		((Control)outputDevGroupBox).Controls.Add((Control)(object)label14);
		((Control)outputDevGroupBox).Controls.Add((Control)(object)label15);
		Point location28 = new Point(3, 189);
		((Control)outputDevGroupBox).Location = location28;
		((Control)outputDevGroupBox).Name = "outputDevGroupBox";
		Size size28 = new Size(250, 120);
		((Control)outputDevGroupBox).Size = size28;
		((Control)outputDevGroupBox).TabIndex = 3;
		outputDevGroupBox.TabStop = false;
		outputDevGroupBox.Text = "Output Device (Play)";
		((ButtonBase)output4CheckBox).AutoSize = true;
		Point location29 = new Point(189, 45);
		((Control)output4CheckBox).Location = location29;
		((Control)output4CheckBox).Name = "output4CheckBox";
		Size size29 = new Size(32, 17);
		((Control)output4CheckBox).Size = size29;
		((Control)output4CheckBox).TabIndex = 22;
		((ButtonBase)output4CheckBox).Text = "4";
		((ButtonBase)output4CheckBox).UseVisualStyleBackColor = true;
		((Control)output4CheckBox).Visible = false;
		((Control)asioControlButton).Enabled = false;
		Point location30 = new Point(7, 92);
		((Control)asioControlButton).Location = location30;
		((Control)asioControlButton).Name = "asioControlButton";
		Size size30 = new Size(85, 20);
		((Control)asioControlButton).Size = size30;
		((Control)asioControlButton).TabIndex = 20;
		((ButtonBase)asioControlButton).Text = "ASIO control";
		toolTip.SetToolTip((Control)(object)asioControlButton, "Invoke the ASIO control panel");
		((ButtonBase)asioControlButton).UseVisualStyleBackColor = true;
		((ButtonBase)output3CheckBox).AutoSize = true;
		Point location31 = new Point(154, 45);
		((Control)output3CheckBox).Location = location31;
		((Control)output3CheckBox).Name = "output3CheckBox";
		Size size31 = new Size(32, 17);
		((Control)output3CheckBox).Size = size31;
		((Control)output3CheckBox).TabIndex = 21;
		((ButtonBase)output3CheckBox).Text = "3";
		((ButtonBase)output3CheckBox).UseVisualStyleBackColor = true;
		((Control)output3CheckBox).Visible = false;
		Point location32 = new Point(151, 66);
		((Control)outputDBUpDown).Location = location32;
		decimal maximum2 = new decimal(new int[4] { 0, 0, 0, 0 });
		outputDBUpDown.Maximum = maximum2;
		decimal minimum = new decimal(new int[4] { 40, 0, 0, -2147483648 });
		outputDBUpDown.Minimum = minimum;
		((Control)outputDBUpDown).Name = "outputDBUpDown";
		((Control)outputDBUpDown).RightToLeft = (RightToLeft)0;
		Size size32 = new Size(45, 20);
		((Control)outputDBUpDown).Size = size32;
		((Control)outputDBUpDown).TabIndex = 10;
		((UpDownBase)outputDBUpDown).TextAlign = (HorizontalAlignment)1;
		outputAmpUpDown.DecimalPlaces = 2;
		decimal increment = new decimal(new int[4] { 1, 0, 0, 65536 });
		outputAmpUpDown.Increment = increment;
		Point location33 = new Point(89, 66);
		((Control)outputAmpUpDown).Location = location33;
		decimal maximum3 = new decimal(new int[4] { 1, 0, 0, 0 });
		outputAmpUpDown.Maximum = maximum3;
		decimal minimum2 = new decimal(new int[4] { 1, 0, 0, 131072 });
		outputAmpUpDown.Minimum = minimum2;
		((Control)outputAmpUpDown).Name = "outputAmpUpDown";
		((Control)outputAmpUpDown).RightToLeft = (RightToLeft)0;
		Size size33 = new Size(50, 20);
		((Control)outputAmpUpDown).Size = size33;
		((Control)outputAmpUpDown).TabIndex = 6;
		((UpDownBase)outputAmpUpDown).TextAlign = (HorizontalAlignment)1;
		decimal value2 = new decimal(new int[4] { 1, 0, 0, 0 });
		outputAmpUpDown.Value = value2;
		label28.AutoSize = true;
		Point location34 = new Point(5, 69);
		((Control)label28).Location = location34;
		((Control)label28).Name = "label28";
		Size size34 = new Size(82, 13);
		((Control)label28).Size = size34;
		((Control)label28).TabIndex = 7;
		label28.Text = "PCM-Amplitude:";
		label3.AutoSize = true;
		Point location35 = new Point(6, 46);
		((Control)label3).Location = location35;
		((Control)label3).Name = "label3";
		Size size35 = new Size(49, 13);
		((Control)label3).Size = size35;
		((Control)label3).TabIndex = 6;
		label3.Text = "Channel:";
		((ButtonBase)output2CheckBox).AutoSize = true;
		Point location36 = new Point(100, 45);
		((Control)output2CheckBox).Location = location36;
		((Control)output2CheckBox).Name = "output2CheckBox";
		Size size36 = new Size(51, 17);
		((Control)output2CheckBox).Size = size36;
		((Control)output2CheckBox).TabIndex = 3;
		((ButtonBase)output2CheckBox).Text = "Right";
		((ButtonBase)output2CheckBox).UseVisualStyleBackColor = true;
		((Control)output2CheckBox).Visible = false;
		((ButtonBase)output1CheckBox).AutoSize = true;
		output1CheckBox.Checked = true;
		output1CheckBox.CheckState = (CheckState)1;
		Point location37 = new Point(55, 45);
		((Control)output1CheckBox).Location = location37;
		((Control)output1CheckBox).Name = "output1CheckBox";
		Size size37 = new Size(44, 17);
		((Control)output1CheckBox).Size = size37;
		((Control)output1CheckBox).TabIndex = 2;
		((ButtonBase)output1CheckBox).Text = "Left";
		((ButtonBase)output1CheckBox).UseVisualStyleBackColor = true;
		outputDevComboBox.DropDownStyle = (ComboBoxStyle)2;
		((ListControl)outputDevComboBox).FormattingEnabled = true;
		Point location38 = new Point(6, 19);
		((Control)outputDevComboBox).Location = location38;
		((Control)outputDevComboBox).Name = "outputDevComboBox";
		Size size38 = new Size(238, 21);
		((Control)outputDevComboBox).Size = size38;
		((Control)outputDevComboBox).TabIndex = 1;
		label14.AutoSize = true;
		Point location39 = new Point(136, 69);
		((Control)label14).Location = location39;
		((Control)label14).Name = "label14";
		Size size39 = new Size(13, 13);
		((Control)label14).Size = size39;
		((Control)label14).TabIndex = 9;
		label14.Text = "=";
		label15.AutoSize = true;
		Point location40 = new Point(195, 69);
		((Control)label15).Location = location40;
		((Control)label15).Name = "label15";
		Size size40 = new Size(33, 13);
		((Control)label15).Size = size40;
		((Control)label15).TabIndex = 11;
		label15.Text = "dBFS";
		((Control)label10).Anchor = (AnchorStyles)0;
		label10.AutoSize = true;
		((Control)label10).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		Point location41 = new Point(66, 5);
		((Control)label10).Location = location41;
		((Control)label10).Name = "label10";
		Size size41 = new Size(130, 13);
		((Control)label10).Size = size41;
		((Control)label10).TabIndex = 5;
		label10.Text = "Playing and recording";
		((Control)panel2).Controls.Add((Control)(object)groupBox6);
		((Control)panel2).Controls.Add((Control)(object)outputSqRadioButton);
		((Control)panel2).Controls.Add((Control)(object)fadingGroupBox);
		((Control)panel2).Controls.Add((Control)(object)outputLogSweepRadioButton);
		((Control)panel2).Controls.Add((Control)(object)sqNoiseGroupBox);
		((Control)panel2).Controls.Add((Control)(object)groupBox3);
		((Control)panel2).Controls.Add((Control)(object)logSweepGroupBox);
		((Control)panel2).Controls.Add((Control)(object)outputChirpRadioButton);
		((Control)panel2).Controls.Add((Control)(object)chirpGroupBox);
		((Control)panel2).Dock = (DockStyle)5;
		Point location42 = new Point(262, 24);
		((Control)panel2).Location = location42;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Padding margin6);
		((Padding)(ref margin6))._002Ector(0);
		((Control)panel2).Margin = margin6;
		((Control)panel2).Name = "panel2";
		Size size42 = new Size(258, 469);
		((Control)panel2).Size = size42;
		((Control)panel2).TabIndex = 1;
		((Control)groupBox6).Controls.Add((Control)(object)signalSaveExtendZeroesCheckBox);
		((Control)groupBox6).Controls.Add((Control)(object)signalSaveButton);
		((Control)groupBox6).Controls.Add((Control)(object)signalInverseSaveButton);
		Point location43 = new Point(3, 375);
		((Control)groupBox6).Location = location43;
		((Control)groupBox6).Name = "groupBox6";
		Size size43 = new Size(250, 91);
		((Control)groupBox6).Size = size43;
		((Control)groupBox6).TabIndex = 13;
		groupBox6.TabStop = false;
		groupBox6.Text = "Save measurement signal as wave file";
		((ButtonBase)signalSaveExtendZeroesCheckBox).AutoSize = true;
		Point location44 = new Point(12, 14);
		((Control)signalSaveExtendZeroesCheckBox).Location = location44;
		((Control)signalSaveExtendZeroesCheckBox).Name = "signalSaveExtendZeroesCheckBox";
		Size size44 = new Size(115, 17);
		((Control)signalSaveExtendZeroesCheckBox).Size = size44;
		((Control)signalSaveExtendZeroesCheckBox).TabIndex = 11;
		((ButtonBase)signalSaveExtendZeroesCheckBox).Text = "Extend with zeroes";
		((ButtonBase)signalSaveExtendZeroesCheckBox).UseVisualStyleBackColor = true;
		Point location45 = new Point(12, 35);
		((Control)signalSaveButton).Location = location45;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Padding margin7);
		((Padding)(ref margin7))._002Ector(1);
		((Control)signalSaveButton).Margin = margin7;
		((Control)signalSaveButton).Name = "signalSaveButton";
		Size size45 = new Size(190, 21);
		((Control)signalSaveButton).Size = size45;
		((Control)signalSaveButton).TabIndex = 10;
		((ButtonBase)signalSaveButton).Text = "Save signal";
		toolTip.SetToolTip((Control)(object)signalSaveButton, "Save the signal to wave-file");
		((ButtonBase)signalSaveButton).UseVisualStyleBackColor = true;
		Point location46 = new Point(12, 59);
		((Control)signalInverseSaveButton).Location = location46;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Padding margin8);
		((Padding)(ref margin8))._002Ector(1);
		((Control)signalInverseSaveButton).Margin = margin8;
		((Control)signalInverseSaveButton).Name = "signalInverseSaveButton";
		Size size46 = new Size(190, 21);
		((Control)signalInverseSaveButton).Size = size46;
		((Control)signalInverseSaveButton).TabIndex = 10;
		((ButtonBase)signalInverseSaveButton).Text = "Save inverse signal (normalized)";
		((ButtonBase)signalInverseSaveButton).UseVisualStyleBackColor = true;
		((ButtonBase)outputSqRadioButton).AutoSize = true;
		Point location47 = new Point(15, 197);
		((Control)outputSqRadioButton).Location = location47;
		((Control)outputSqRadioButton).Name = "outputSqRadioButton";
		Size size47 = new Size(167, 17);
		((Control)outputSqRadioButton).Size = size47;
		((Control)outputSqRadioButton).TabIndex = 3;
		((ButtonBase)outputSqRadioButton).Text = "Square Noise (Improved MLS)";
		((ButtonBase)outputSqRadioButton).UseVisualStyleBackColor = true;
		outputSqRadioButton.CheckedChanged += outputSqRadioButton_CheckedChanged;
		((Control)fadingGroupBox).Controls.Add((Control)(object)signalFadeOutCheckBox);
		((Control)fadingGroupBox).Controls.Add((Control)(object)signalFadeInCheckBox);
		((Control)fadingGroupBox).Controls.Add((Control)(object)signalFadeInUpDown);
		((Control)fadingGroupBox).Controls.Add((Control)(object)signalFadeOutUpDown);
		Point location48 = new Point(3, 123);
		((Control)fadingGroupBox).Location = location48;
		((Control)fadingGroupBox).Name = "fadingGroupBox";
		Size size48 = new Size(250, 65);
		((Control)fadingGroupBox).Size = size48;
		((Control)fadingGroupBox).TabIndex = 14;
		fadingGroupBox.TabStop = false;
		fadingGroupBox.Text = "Fading (chirp && logsweep)";
		((ButtonBase)signalFadeOutCheckBox).AutoSize = true;
		Point location49 = new Point(17, 39);
		((Control)signalFadeOutCheckBox).Location = location49;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Padding margin9);
		((Padding)(ref margin9))._002Ector(1);
		((Control)signalFadeOutCheckBox).Margin = margin9;
		((Control)signalFadeOutCheckBox).Name = "signalFadeOutCheckBox";
		((Control)signalFadeOutCheckBox).RightToLeft = (RightToLeft)0;
		Size size49 = new Size(105, 17);
		((Control)signalFadeOutCheckBox).Size = size49;
		((Control)signalFadeOutCheckBox).TabIndex = 16;
		((ButtonBase)signalFadeOutCheckBox).Text = "Fade out [msec]:";
		((ButtonBase)signalFadeOutCheckBox).UseVisualStyleBackColor = true;
		signalFadeOutCheckBox.CheckedChanged += signalFadeOutCheckBox_CheckedChanged;
		((ButtonBase)signalFadeInCheckBox).AutoSize = true;
		Point location50 = new Point(17, 17);
		((Control)signalFadeInCheckBox).Location = location50;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Padding margin10);
		((Padding)(ref margin10))._002Ector(1);
		((Control)signalFadeInCheckBox).Margin = margin10;
		((Control)signalFadeInCheckBox).Name = "signalFadeInCheckBox";
		((Control)signalFadeInCheckBox).RightToLeft = (RightToLeft)0;
		Size size50 = new Size(98, 17);
		((Control)signalFadeInCheckBox).Size = size50;
		((Control)signalFadeInCheckBox).TabIndex = 15;
		((ButtonBase)signalFadeInCheckBox).Text = "Fade in [msec]:";
		((ButtonBase)signalFadeInCheckBox).UseVisualStyleBackColor = true;
		signalFadeInCheckBox.CheckedChanged += signalFadeInCheckBox_CheckedChanged;
		signalFadeInUpDown.DecimalPlaces = 1;
		((Control)signalFadeInUpDown).Enabled = false;
		Point location51 = new Point(133, 15);
		((Control)signalFadeInUpDown).Location = location51;
		decimal maximum4 = new decimal(new int[4] { 1000, 0, 0, 0 });
		signalFadeInUpDown.Maximum = maximum4;
		((Control)signalFadeInUpDown).Name = "signalFadeInUpDown";
		((Control)signalFadeInUpDown).RightToLeft = (RightToLeft)0;
		Size size51 = new Size(60, 20);
		((Control)signalFadeInUpDown).Size = size51;
		((Control)signalFadeInUpDown).TabIndex = 11;
		((UpDownBase)signalFadeInUpDown).TextAlign = (HorizontalAlignment)1;
		toolTip.SetToolTip((Control)(object)signalFadeInUpDown, "Number of milliseconds to fade in\r\nDefault value: 10");
		decimal value3 = new decimal(new int[4] { 10, 0, 0, 0 });
		signalFadeInUpDown.Value = value3;
		signalFadeOutUpDown.DecimalPlaces = 1;
		((Control)signalFadeOutUpDown).Enabled = false;
		decimal increment2 = new decimal(new int[4] { 1, 0, 0, 65536 });
		signalFadeOutUpDown.Increment = increment2;
		Point location52 = new Point(133, 38);
		((Control)signalFadeOutUpDown).Location = location52;
		decimal maximum5 = new decimal(new int[4] { 1000, 0, 0, 0 });
		signalFadeOutUpDown.Maximum = maximum5;
		((Control)signalFadeOutUpDown).Name = "signalFadeOutUpDown";
		((Control)signalFadeOutUpDown).RightToLeft = (RightToLeft)0;
		Size size52 = new Size(60, 20);
		((Control)signalFadeOutUpDown).Size = size52;
		((Control)signalFadeOutUpDown).TabIndex = 13;
		((UpDownBase)signalFadeOutUpDown).TextAlign = (HorizontalAlignment)1;
		toolTip.SetToolTip((Control)(object)signalFadeOutUpDown, "Number of milliseconds to fade in\r\nDefault value: 1");
		decimal value4 = new decimal(new int[4] { 1, 0, 0, 0 });
		signalFadeOutUpDown.Value = value4;
		((ButtonBase)outputLogSweepRadioButton).AutoSize = true;
		outputLogSweepRadioButton.Checked = true;
		Point location53 = new Point(15, 3);
		((Control)outputLogSweepRadioButton).Location = location53;
		((Control)outputLogSweepRadioButton).Name = "outputLogSweepRadioButton";
		Size size53 = new Size(135, 17);
		((Control)outputLogSweepRadioButton).Size = size53;
		((Control)outputLogSweepRadioButton).TabIndex = 1;
		outputLogSweepRadioButton.TabStop = true;
		((ButtonBase)outputLogSweepRadioButton).Text = "Logarithmic sine sweep";
		((ButtonBase)outputLogSweepRadioButton).UseVisualStyleBackColor = true;
		outputLogSweepRadioButton.CheckedChanged += outputLogSweepRadioButton_CheckedChanged;
		((Control)sqNoiseGroupBox).Controls.Add((Control)(object)sqNoiseAmpUpDown);
		((Control)sqNoiseGroupBox).Controls.Add((Control)(object)label16);
		((Control)sqNoiseGroupBox).Controls.Add((Control)(object)label13);
		((Control)sqNoiseGroupBox).Controls.Add((Control)(object)sqNoiseUpDown);
		((Control)sqNoiseGroupBox).Enabled = false;
		Point location54 = new Point(3, 200);
		((Control)sqNoiseGroupBox).Location = location54;
		((Control)sqNoiseGroupBox).Name = "sqNoiseGroupBox";
		Size size54 = new Size(250, 68);
		((Control)sqNoiseGroupBox).Size = size54;
		((Control)sqNoiseGroupBox).TabIndex = 5;
		sqNoiseGroupBox.TabStop = false;
		sqNoiseAmpUpDown.DecimalPlaces = 2;
		decimal increment3 = new decimal(new int[4] { 1, 0, 0, 65536 });
		sqNoiseAmpUpDown.Increment = increment3;
		Point location55 = new Point(133, 42);
		((Control)sqNoiseAmpUpDown).Location = location55;
		decimal maximum6 = new decimal(new int[4] { 1, 0, 0, 0 });
		sqNoiseAmpUpDown.Maximum = maximum6;
		((Control)sqNoiseAmpUpDown).Name = "sqNoiseAmpUpDown";
		((Control)sqNoiseAmpUpDown).RightToLeft = (RightToLeft)0;
		Size size55 = new Size(60, 20);
		((Control)sqNoiseAmpUpDown).Size = size55;
		((Control)sqNoiseAmpUpDown).TabIndex = 8;
		((UpDownBase)sqNoiseAmpUpDown).TextAlign = (HorizontalAlignment)1;
		decimal value5 = new decimal(new int[4] { 5, 0, 0, 65536 });
		sqNoiseAmpUpDown.Value = value5;
		label16.AutoSize = true;
		Point location56 = new Point(14, 44);
		((Control)label16).Location = location56;
		((Control)label16).Name = "label16";
		Size size56 = new Size(56, 13);
		((Control)label16).Size = size56;
		((Control)label16).TabIndex = 9;
		label16.Text = "Amplitude:";
		label13.AutoSize = true;
		Point location57 = new Point(14, 22);
		((Control)label13).Location = location57;
		((Control)label13).Name = "label13";
		Size size57 = new Size(76, 13);
		((Control)label13).Size = size57;
		((Control)label13).TabIndex = 5;
		label13.Text = "Flip frequency:";
		sqNoiseUpDown.DecimalPlaces = 3;
		decimal increment4 = new decimal(new int[4] { 1, 0, 0, 65536 });
		sqNoiseUpDown.Increment = increment4;
		Point location58 = new Point(133, 18);
		((Control)sqNoiseUpDown).Location = location58;
		decimal maximum7 = new decimal(new int[4] { 999, 0, 0, 196608 });
		sqNoiseUpDown.Maximum = maximum7;
		decimal minimum3 = new decimal(new int[4] { 1, 0, 0, 131072 });
		sqNoiseUpDown.Minimum = minimum3;
		((Control)sqNoiseUpDown).Name = "sqNoiseUpDown";
		((Control)sqNoiseUpDown).RightToLeft = (RightToLeft)0;
		Size size58 = new Size(60, 20);
		((Control)sqNoiseUpDown).Size = size58;
		((Control)sqNoiseUpDown).TabIndex = 5;
		((UpDownBase)sqNoiseUpDown).TextAlign = (HorizontalAlignment)1;
		toolTip.SetToolTip((Control)(object)sqNoiseUpDown, "1:         DC (Pink Noise)\r\n0,99:  (Pink Noise  to 100 hz)\r\n0,5:     (MLS flat frequency response)\r\n\r\n");
		decimal value6 = new decimal(new int[4] { 9, 0, 0, 65536 });
		sqNoiseUpDown.Value = value6;
		((Control)groupBox3).Controls.Add((Control)(object)label8);
		((Control)groupBox3).Controls.Add((Control)(object)signalMsTextBox);
		((Control)groupBox3).Controls.Add((Control)(object)SamplesLabel);
		((Control)groupBox3).Controls.Add((Control)(object)signalSamplesTextBox);
		((Control)groupBox3).Controls.Add((Control)(object)label6);
		((Control)groupBox3).Controls.Add((Control)(object)signalMUpDown);
		Point location59 = new Point(3, 277);
		((Control)groupBox3).Location = location59;
		((Control)groupBox3).Name = "groupBox3";
		Size size59 = new Size(250, 68);
		((Control)groupBox3).Size = size59;
		((Control)groupBox3).TabIndex = 6;
		groupBox3.TabStop = false;
		groupBox3.Text = "Signal length";
		toolTip.SetToolTip((Control)(object)groupBox3, "Signal length\r\nDefault value: 18");
		label8.AutoSize = true;
		Point location60 = new Point(140, 18);
		((Control)label8).Location = location60;
		((Control)label8).Name = "label8";
		Size size60 = new Size(32, 13);
		((Control)label8).Size = size60;
		((Control)label8).TabIndex = 7;
		label8.Text = "msec";
		Point location61 = new Point(143, 39);
		((Control)signalMsTextBox).Location = location61;
		((Control)signalMsTextBox).Name = "signalMsTextBox";
		((TextBoxBase)signalMsTextBox).ReadOnly = true;
		((Control)signalMsTextBox).RightToLeft = (RightToLeft)1;
		Size size61 = new Size(51, 20);
		((Control)signalMsTextBox).Size = size61;
		((Control)signalMsTextBox).TabIndex = 6;
		((Control)signalMsTextBox).TabStop = false;
		signalMsTextBox.Text = "743";
		SamplesLabel.AutoSize = true;
		Point location62 = new Point(79, 19);
		((Control)SamplesLabel).Location = location62;
		((Control)SamplesLabel).Name = "SamplesLabel";
		Size size62 = new Size(47, 13);
		((Control)SamplesLabel).Size = size62;
		((Control)SamplesLabel).TabIndex = 3;
		SamplesLabel.Text = "Samples";
		Point location63 = new Point(78, 39);
		((Control)signalSamplesTextBox).Location = location63;
		((Control)signalSamplesTextBox).Name = "signalSamplesTextBox";
		((TextBoxBase)signalSamplesTextBox).ReadOnly = true;
		((Control)signalSamplesTextBox).RightToLeft = (RightToLeft)1;
		Size size63 = new Size(51, 20);
		((Control)signalSamplesTextBox).Size = size63;
		((Control)signalSamplesTextBox).TabIndex = 2;
		((Control)signalSamplesTextBox).TabStop = false;
		signalSamplesTextBox.Text = "32768";
		label6.AutoSize = true;
		Point location64 = new Point(14, 19);
		((Control)label6).Location = location64;
		((Control)label6).Name = "label6";
		Size size64 = new Size(28, 13);
		((Control)label6).Size = size64;
		((Control)label6).TabIndex = 1;
		label6.Text = "2^M";
		Point location65 = new Point(14, 39);
		((Control)signalMUpDown).Location = location65;
		decimal maximum8 = new decimal(new int[4] { 22, 0, 0, 0 });
		signalMUpDown.Maximum = maximum8;
		decimal minimum4 = new decimal(new int[4] { 14, 0, 0, 0 });
		signalMUpDown.Minimum = minimum4;
		((Control)signalMUpDown).Name = "signalMUpDown";
		Size size65 = new Size(41, 20);
		((Control)signalMUpDown).Size = size65;
		((Control)signalMUpDown).TabIndex = 1;
		decimal value7 = new decimal(new int[4] { 17, 0, 0, 0 });
		signalMUpDown.Value = value7;
		((Control)logSweepGroupBox).Controls.Add((Control)(object)label11);
		((Control)logSweepGroupBox).Controls.Add((Control)(object)logSweepStartFreqUpDown);
		Point location66 = new Point(3, 6);
		((Control)logSweepGroupBox).Location = location66;
		((Control)logSweepGroupBox).Name = "logSweepGroupBox";
		Size size66 = new Size(250, 42);
		((Control)logSweepGroupBox).Size = size66;
		((Control)logSweepGroupBox).TabIndex = 11;
		logSweepGroupBox.TabStop = false;
		label11.AutoSize = true;
		Point location67 = new Point(9, 17);
		((Control)label11).Location = location67;
		((Control)label11).Name = "label11";
		Size size67 = new Size(104, 13);
		((Control)label11).Size = size67;
		((Control)label11).TabIndex = 9;
		label11.Text = "Start frequency [Hz]:";
		toolTip.SetToolTip((Control)(object)label11, "Frequency = A *T^P\r\n\r\nA =  Proportinality constant\r\nT = Time\r\nP = Potens");
		Point location68 = new Point(133, 15);
		((Control)logSweepStartFreqUpDown).Location = location68;
		decimal maximum9 = new decimal(new int[4] { 1000, 0, 0, 0 });
		logSweepStartFreqUpDown.Maximum = maximum9;
		decimal minimum5 = new decimal(new int[4] { 1, 0, 0, 0 });
		logSweepStartFreqUpDown.Minimum = minimum5;
		((Control)logSweepStartFreqUpDown).Name = "logSweepStartFreqUpDown";
		((Control)logSweepStartFreqUpDown).RightToLeft = (RightToLeft)0;
		Size size68 = new Size(60, 20);
		((Control)logSweepStartFreqUpDown).Size = size68;
		((Control)logSweepStartFreqUpDown).TabIndex = 8;
		((UpDownBase)logSweepStartFreqUpDown).TextAlign = (HorizontalAlignment)1;
		toolTip.SetToolTip((Control)(object)logSweepStartFreqUpDown, "Starting frequency\r\nDefault value: 10");
		decimal value8 = new decimal(new int[4] { 10, 0, 0, 0 });
		logSweepStartFreqUpDown.Value = value8;
		((ButtonBase)outputChirpRadioButton).AutoSize = true;
		Point location69 = new Point(16, 53);
		((Control)outputChirpRadioButton).Location = location69;
		((Control)outputChirpRadioButton).Name = "outputChirpRadioButton";
		Size size69 = new Size(49, 17);
		((Control)outputChirpRadioButton).Size = size69;
		((Control)outputChirpRadioButton).TabIndex = 2;
		((ButtonBase)outputChirpRadioButton).Text = "Chirp";
		((ButtonBase)outputChirpRadioButton).UseVisualStyleBackColor = true;
		outputChirpRadioButton.CheckedChanged += outputChirpRadioButton_CheckedChanged;
		((Control)chirpGroupBox).Controls.Add((Control)(object)chirpStartFreqUpDown);
		((Control)chirpGroupBox).Controls.Add((Control)(object)label24);
		((Control)chirpGroupBox).Controls.Add((Control)(object)label12);
		((Control)chirpGroupBox).Controls.Add((Control)(object)chirpPotensUpDown);
		((Control)chirpGroupBox).Enabled = false;
		Point location70 = new Point(3, 54);
		((Control)chirpGroupBox).Location = location70;
		((Control)chirpGroupBox).Name = "chirpGroupBox";
		Size size70 = new Size(250, 63);
		((Control)chirpGroupBox).Size = size70;
		((Control)chirpGroupBox).TabIndex = 12;
		chirpGroupBox.TabStop = false;
		Point location71 = new Point(133, 15);
		((Control)chirpStartFreqUpDown).Location = location71;
		decimal maximum10 = new decimal(new int[4] { 1000, 0, 0, 0 });
		chirpStartFreqUpDown.Maximum = maximum10;
		decimal minimum6 = new decimal(new int[4] { 1, 0, 0, 0 });
		chirpStartFreqUpDown.Minimum = minimum6;
		((Control)chirpStartFreqUpDown).Name = "chirpStartFreqUpDown";
		((Control)chirpStartFreqUpDown).RightToLeft = (RightToLeft)0;
		Size size71 = new Size(60, 20);
		((Control)chirpStartFreqUpDown).Size = size71;
		((Control)chirpStartFreqUpDown).TabIndex = 13;
		((UpDownBase)chirpStartFreqUpDown).TextAlign = (HorizontalAlignment)1;
		toolTip.SetToolTip((Control)(object)chirpStartFreqUpDown, "Starting frequency\r\nDefault value: 10");
		decimal value9 = new decimal(new int[4] { 10, 0, 0, 0 });
		chirpStartFreqUpDown.Value = value9;
		label24.AutoSize = true;
		Point location72 = new Point(10, 19);
		((Control)label24).Location = location72;
		((Control)label24).Name = "label24";
		Size size72 = new Size(104, 13);
		((Control)label24).Size = size72;
		((Control)label24).TabIndex = 12;
		label24.Text = "Start frequency [Hz]:";
		toolTip.SetToolTip((Control)(object)label24, "Frequency = A *T^P\r\n\r\nA =  Proportinality constant\r\nT = Time\r\nP = Potens");
		label12.AutoSize = true;
		Point location73 = new Point(10, 42);
		((Control)label12).Location = location73;
		((Control)label12).Name = "label12";
		Size size73 = new Size(68, 13);
		((Control)label12).Size = size73;
		((Control)label12).TabIndex = 4;
		label12.Text = "Time potens:";
		toolTip.SetToolTip((Control)(object)label12, "Frequency = A *T^P\r\n\r\nA =  Proportinality constant\r\nT = Time\r\nP = Potens");
		chirpPotensUpDown.DecimalPlaces = 1;
		Point location74 = new Point(133, 38);
		((Control)chirpPotensUpDown).Location = location74;
		decimal maximum11 = new decimal(new int[4] { 10, 0, 0, 0 });
		chirpPotensUpDown.Maximum = maximum11;
		decimal minimum7 = new decimal(new int[4] { 1, 0, 0, 65536 });
		chirpPotensUpDown.Minimum = minimum7;
		((Control)chirpPotensUpDown).Name = "chirpPotensUpDown";
		((Control)chirpPotensUpDown).RightToLeft = (RightToLeft)0;
		Size size74 = new Size(60, 20);
		((Control)chirpPotensUpDown).Size = size74;
		((Control)chirpPotensUpDown).TabIndex = 4;
		((UpDownBase)chirpPotensUpDown).TextAlign = (HorizontalAlignment)1;
		toolTip.SetToolTip((Control)(object)chirpPotensUpDown, "Frequency = A *T^P\r\n\r\nA =  Proportinality constant\r\nT = Time\r\nP = Potens");
		decimal value10 = new decimal(new int[4] { 2, 0, 0, 0 });
		chirpPotensUpDown.Value = value10;
		((Control)label9).Anchor = (AnchorStyles)0;
		label9.AutoSize = true;
		((Control)label9).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		Point location75 = new Point(331, 5);
		((Control)label9).Location = location75;
		((Control)label9).Name = "label9";
		Size size75 = new Size(119, 13);
		((Control)label9).Size = size75;
		((Control)label9).TabIndex = 4;
		label9.Text = "Measurement signal";
		((Control)panel1).Controls.Add((Control)(object)groupBox10);
		((Control)panel1).Dock = (DockStyle)5;
		Point location76 = new Point(522, 24);
		((Control)panel1).Location = location76;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Padding margin11);
		((Padding)(ref margin11))._002Ector(0);
		((Control)panel1).Margin = margin11;
		((Control)panel1).Name = "panel1";
		Size size76 = new Size(260, 469);
		((Control)panel1).Size = size76;
		((Control)panel1).TabIndex = 6;
		((Control)groupBox10).Controls.Add((Control)(object)calDacAdcMakeButton);
		((Control)groupBox10).Controls.Add((Control)(object)calDacAdcImportButton);
		((Control)groupBox10).Controls.Add((Control)(object)calDacAdcCheckBox);
		((Control)groupBox10).Controls.Add((Control)(object)calMicImportButton);
		((Control)groupBox10).Controls.Add((Control)(object)calMicCheckBox);
		Point location77 = new Point(5, 6);
		((Control)groupBox10).Location = location77;
		((Control)groupBox10).Name = "groupBox10";
		Size size77 = new Size(250, 74);
		((Control)groupBox10).Size = size77;
		((Control)groupBox10).TabIndex = 10;
		groupBox10.TabStop = false;
		groupBox10.Text = "Active calibrations";
		Point location78 = new Point(134, 44);
		((Control)calDacAdcMakeButton).Location = location78;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Padding margin12);
		((Padding)(ref margin12))._002Ector(1);
		((Control)calDacAdcMakeButton).Margin = margin12;
		((Control)calDacAdcMakeButton).Name = "calDacAdcMakeButton";
		Size size78 = new Size(45, 21);
		((Control)calDacAdcMakeButton).Size = size78;
		((Control)calDacAdcMakeButton).TabIndex = 9;
		((ButtonBase)calDacAdcMakeButton).Text = "Make";
		((ButtonBase)calDacAdcMakeButton).UseVisualStyleBackColor = true;
		Point location79 = new Point(185, 44);
		((Control)calDacAdcImportButton).Location = location79;
		((Control)calDacAdcImportButton).Name = "calDacAdcImportButton";
		Size size79 = new Size(45, 21);
		((Control)calDacAdcImportButton).Size = size79;
		((Control)calDacAdcImportButton).TabIndex = 8;
		((ButtonBase)calDacAdcImportButton).Text = "Import";
		((ButtonBase)calDacAdcImportButton).UseVisualStyleBackColor = true;
		((ButtonBase)calDacAdcCheckBox).AutoSize = true;
		Point location80 = new Point(12, 47);
		((Control)calDacAdcCheckBox).Location = location80;
		((Control)calDacAdcCheckBox).Name = "calDacAdcCheckBox";
		((Control)calDacAdcCheckBox).RightToLeft = (RightToLeft)0;
		Size size80 = new Size(124, 17);
		((Control)calDacAdcCheckBox).Size = size80;
		((Control)calDacAdcCheckBox).TabIndex = 7;
		((ButtonBase)calDacAdcCheckBox).Text = "DAC-ADC calibration";
		((ButtonBase)calDacAdcCheckBox).UseVisualStyleBackColor = true;
		Point location81 = new Point(185, 17);
		((Control)calMicImportButton).Location = location81;
		((Control)calMicImportButton).Name = "calMicImportButton";
		Size size81 = new Size(45, 21);
		((Control)calMicImportButton).Size = size81;
		((Control)calMicImportButton).TabIndex = 6;
		((ButtonBase)calMicImportButton).Text = "Import";
		((ButtonBase)calMicImportButton).UseVisualStyleBackColor = true;
		((ButtonBase)calMicCheckBox).AutoSize = true;
		Point location82 = new Point(12, 19);
		((Control)calMicCheckBox).Location = location82;
		((Control)calMicCheckBox).Name = "calMicCheckBox";
		Size size82 = new Size(133, 17);
		((Control)calMicCheckBox).Size = size82;
		((Control)calMicCheckBox).TabIndex = 5;
		((ButtonBase)calMicCheckBox).Text = "Microphone calibration";
		((ButtonBase)calMicCheckBox).UseVisualStyleBackColor = true;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Control)this).Controls.Add((Control)(object)devTableLayoutPanel);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Padding margin13);
		((Padding)(ref margin13))._002Ector(0);
		((Control)this).Margin = margin13;
		((Control)this).Name = "ControlDevSignal";
		Size size83 = new Size(784, 495);
		((Control)this).Size = size83;
		((Control)devTableLayoutPanel).ResumeLayout(false);
		((Control)devTableLayoutPanel).PerformLayout();
		((Control)panel3).ResumeLayout(false);
		((Control)groupBox5).ResumeLayout(false);
		((Control)groupBox5).PerformLayout();
		((Control)groupBox4).ResumeLayout(false);
		((Control)groupBox4).PerformLayout();
		((ISupportInitialize)recMaxDelayUpDown).EndInit();
		((Control)groupBox11).ResumeLayout(false);
		((Control)groupBox11).PerformLayout();
		((Control)inputDevGroupBox).ResumeLayout(false);
		((Control)inputDevGroupBox).PerformLayout();
		((Control)outputDevGroupBox).ResumeLayout(false);
		((Control)outputDevGroupBox).PerformLayout();
		((ISupportInitialize)outputDBUpDown).EndInit();
		((ISupportInitialize)outputAmpUpDown).EndInit();
		((Control)panel2).ResumeLayout(false);
		((Control)panel2).PerformLayout();
		((Control)groupBox6).ResumeLayout(false);
		((Control)groupBox6).PerformLayout();
		((Control)fadingGroupBox).ResumeLayout(false);
		((Control)fadingGroupBox).PerformLayout();
		((ISupportInitialize)signalFadeInUpDown).EndInit();
		((ISupportInitialize)signalFadeOutUpDown).EndInit();
		((Control)sqNoiseGroupBox).ResumeLayout(false);
		((Control)sqNoiseGroupBox).PerformLayout();
		((ISupportInitialize)sqNoiseAmpUpDown).EndInit();
		((ISupportInitialize)sqNoiseUpDown).EndInit();
		((Control)groupBox3).ResumeLayout(false);
		((Control)groupBox3).PerformLayout();
		((ISupportInitialize)signalMUpDown).EndInit();
		((Control)logSweepGroupBox).ResumeLayout(false);
		((Control)logSweepGroupBox).PerformLayout();
		((ISupportInitialize)logSweepStartFreqUpDown).EndInit();
		((Control)chirpGroupBox).ResumeLayout(false);
		((Control)chirpGroupBox).PerformLayout();
		((ISupportInitialize)chirpStartFreqUpDown).EndInit();
		((ISupportInitialize)chirpPotensUpDown).EndInit();
		((Control)panel1).ResumeLayout(false);
		((Control)groupBox10).ResumeLayout(false);
		((Control)groupBox10).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	private void outputLogSweepRadioButton_CheckedChanged(object sender, EventArgs e)
	{
		((Control)logSweepGroupBox).Enabled = outputLogSweepRadioButton.Checked;
	}

	private void outputChirpRadioButton_CheckedChanged(object sender, EventArgs e)
	{
		((Control)chirpGroupBox).Enabled = outputChirpRadioButton.Checked;
	}

	private void outputSqRadioButton_CheckedChanged(object sender, EventArgs e)
	{
		((Control)sqNoiseGroupBox).Enabled = outputSqRadioButton.Checked;
		byte enabled = ((!outputSqRadioButton.Checked) ? ((byte)1) : ((byte)0));
		((Control)fadingGroupBox).Enabled = enabled != 0;
	}

	private void signalFadeInCheckBox_CheckedChanged(object sender, EventArgs e)
	{
		((Control)signalFadeInUpDown).Enabled = signalFadeInCheckBox.Checked;
	}

	private void signalFadeOutCheckBox_CheckedChanged(object sender, EventArgs e)
	{
		((Control)signalFadeOutUpDown).Enabled = signalFadeOutCheckBox.Checked;
	}

	protected override void Dispose([MarshalAs(UnmanagedType.U1)] bool P_0)
	{
		if (P_0)
		{
			try
			{
				_007EControlDevSignal();
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
