using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace HOLM.HOLMImpulse;

public class ControlMeasurements : UserControl
{
	private GroupBox groupBox5;

	private Label label11;

	private Label label18;

	public TextBox recLevelAmpTextBox;

	public TextBox recLevelDBTextBox;

	private GroupBox groupBox17;

	private Label label19;

	public NumericUpDown nofTapsUpDown;

	private Label label35;

	public NumericUpDown freqWindowHighpassUpDown;

	public CheckBox freqWindowHighpassCheckBox;

	private Label label4;

	public NumericUpDown freqWindowLowpassUpDown;

	public CheckBox freqWindowLowpassCheckBox;

	public SplitContainer splitContainer;

	public ControlMeasPresenter mA;

	public ControlMeasPresenter mB;

	public ControlMeasPresenter mC;

	public GroupBox plotGroupBox;

	public Panel plotPhasePanel;

	public CheckBox plotPhaseCheckBox;

	public Panel plotAmpPanel;

	public CheckBox plotAmpCheckBox;

	public CheckBox plotHdCheckBox;

	public ComboBox plotHdComboBox;

	public ToolTip toolTip;

	private TableLayoutPanel tableLayoutPanel2;

	public Panel colorSignalPanel;

	public CheckBox plotSignalCheckBox;

	public Panel plotDistortionPanel;

	public ControlFrequencyGraph freqGraph;

	public ControlImpulseGraph impGraph;

	public Button organizeButton;

	private IContainer components;

	public ControlMeasurements()
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

	private void _007EControlMeasurements()
	{
		components?.Dispose();
	}

	private void InitializeComponent()
	{
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
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected O, but got Unknown
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected O, but got Unknown
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected O, but got Unknown
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected O, but got Unknown
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
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Expected O, but got Unknown
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected O, but got Unknown
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Expected O, but got Unknown
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Expected O, but got Unknown
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Expected O, but got Unknown
		//IL_028e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b22: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c2e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cc3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dd1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0df6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f0b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f65: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f6f: Expected O, but got Unknown
		//IL_0fa4: Unknown result type (might be due to invalid IL or missing references)
		//IL_100f: Unknown result type (might be due to invalid IL or missing references)
		//IL_108e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1098: Expected O, but got Unknown
		//IL_10c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_1145: Unknown result type (might be due to invalid IL or missing references)
		//IL_11ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_11b8: Expected O, but got Unknown
		//IL_11ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_126d: Unknown result type (might be due to invalid IL or missing references)
		//IL_12ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_12f7: Expected O, but got Unknown
		//IL_1309: Unknown result type (might be due to invalid IL or missing references)
		//IL_1313: Expected O, but got Unknown
		//IL_131f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1329: Expected O, but got Unknown
		//IL_1385: Unknown result type (might be due to invalid IL or missing references)
		//IL_13b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_13c3: Expected O, but got Unknown
		//IL_1427: Unknown result type (might be due to invalid IL or missing references)
		//IL_1492: Unknown result type (might be due to invalid IL or missing references)
		//IL_1530: Unknown result type (might be due to invalid IL or missing references)
		//IL_15b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_1639: Unknown result type (might be due to invalid IL or missing references)
		//IL_16a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_17a0: Unknown result type (might be due to invalid IL or missing references)
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(ControlMeasurements));
		groupBox5 = new GroupBox();
		label11 = new Label();
		label18 = new Label();
		recLevelAmpTextBox = new TextBox();
		recLevelDBTextBox = new TextBox();
		groupBox17 = new GroupBox();
		label19 = new Label();
		nofTapsUpDown = new NumericUpDown();
		label35 = new Label();
		freqWindowHighpassUpDown = new NumericUpDown();
		freqWindowHighpassCheckBox = new CheckBox();
		label4 = new Label();
		freqWindowLowpassUpDown = new NumericUpDown();
		freqWindowLowpassCheckBox = new CheckBox();
		splitContainer = new SplitContainer();
		freqGraph = new ControlFrequencyGraph();
		impGraph = new ControlImpulseGraph();
		plotGroupBox = new GroupBox();
		plotHdComboBox = new ComboBox();
		plotDistortionPanel = new Panel();
		plotHdCheckBox = new CheckBox();
		plotPhasePanel = new Panel();
		plotPhaseCheckBox = new CheckBox();
		plotAmpPanel = new Panel();
		plotAmpCheckBox = new CheckBox();
		toolTip = new ToolTip(components);
		tableLayoutPanel2 = new TableLayoutPanel();
		colorSignalPanel = new Panel();
		plotSignalCheckBox = new CheckBox();
		mC = new ControlMeasPresenter();
		mB = new ControlMeasPresenter();
		mA = new ControlMeasPresenter();
		organizeButton = new Button();
		((Control)groupBox5).SuspendLayout();
		((Control)groupBox17).SuspendLayout();
		((ISupportInitialize)nofTapsUpDown).BeginInit();
		((ISupportInitialize)freqWindowHighpassUpDown).BeginInit();
		((ISupportInitialize)freqWindowLowpassUpDown).BeginInit();
		((Control)splitContainer.Panel1).SuspendLayout();
		((Control)splitContainer.Panel2).SuspendLayout();
		((Control)splitContainer).SuspendLayout();
		((Control)plotGroupBox).SuspendLayout();
		((Control)tableLayoutPanel2).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)groupBox5).Controls.Add((Control)(object)label11);
		((Control)groupBox5).Controls.Add((Control)(object)label18);
		((Control)groupBox5).Controls.Add((Control)(object)recLevelAmpTextBox);
		((Control)groupBox5).Controls.Add((Control)(object)recLevelDBTextBox);
		Point location = new Point(1, 457);
		((Control)groupBox5).Location = location;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Padding margin);
		((Padding)(ref margin))._002Ector(3, 0, 3, 0);
		((Control)groupBox5).Margin = margin;
		((Control)groupBox5).Name = "groupBox5";
		Size size = new Size(230, 35);
		((Control)groupBox5).Size = size;
		((Control)groupBox5).TabIndex = 10;
		groupBox5.TabStop = false;
		groupBox5.Text = "Peak pcm";
		label11.AutoSize = true;
		Point location2 = new Point(123, 14);
		((Control)label11).Location = location2;
		((Control)label11).Name = "label11";
		Size size2 = new Size(13, 13);
		((Control)label11).Size = size2;
		((Control)label11).TabIndex = 17;
		label11.Text = "=";
		label18.AutoSize = true;
		Point location3 = new Point(186, 13);
		((Control)label18).Location = location3;
		((Control)label18).Name = "label18";
		Size size3 = new Size(20, 13);
		((Control)label18).Size = size3;
		((Control)label18).TabIndex = 16;
		label18.Text = "dB";
		Color controlLight = SystemColors.ControlLight;
		((TextBoxBase)recLevelAmpTextBox).BackColor = controlLight;
		Point location4 = new Point(84, 10);
		((Control)recLevelAmpTextBox).Location = location4;
		((Control)recLevelAmpTextBox).Name = "recLevelAmpTextBox";
		((TextBoxBase)recLevelAmpTextBox).ReadOnly = true;
		Size size4 = new Size(34, 20);
		((Control)recLevelAmpTextBox).Size = size4;
		((Control)recLevelAmpTextBox).TabIndex = 29;
		((Control)recLevelAmpTextBox).TabStop = false;
		recLevelAmpTextBox.Text = "0.76";
		Color controlLight2 = SystemColors.ControlLight;
		((TextBoxBase)recLevelDBTextBox).BackColor = controlLight2;
		Point location5 = new Point(142, 10);
		((Control)recLevelDBTextBox).Location = location5;
		((Control)recLevelDBTextBox).Name = "recLevelDBTextBox";
		((TextBoxBase)recLevelDBTextBox).ReadOnly = true;
		Size size5 = new Size(41, 20);
		((Control)recLevelDBTextBox).Size = size5;
		((Control)recLevelDBTextBox).TabIndex = 30;
		((Control)recLevelDBTextBox).TabStop = false;
		recLevelDBTextBox.Text = "-10.2";
		((Control)groupBox17).Controls.Add((Control)(object)label19);
		((Control)groupBox17).Controls.Add((Control)(object)nofTapsUpDown);
		((Control)groupBox17).Controls.Add((Control)(object)label35);
		((Control)groupBox17).Controls.Add((Control)(object)freqWindowHighpassUpDown);
		((Control)groupBox17).Controls.Add((Control)(object)freqWindowHighpassCheckBox);
		((Control)groupBox17).Controls.Add((Control)(object)label4);
		((Control)groupBox17).Controls.Add((Control)(object)freqWindowLowpassUpDown);
		((Control)groupBox17).Controls.Add((Control)(object)freqWindowLowpassCheckBox);
		Point location6 = new Point(1, 376);
		((Control)groupBox17).Location = location6;
		((Control)groupBox17).Name = "groupBox17";
		Size size6 = new Size(230, 73);
		((Control)groupBox17).Size = size6;
		((Control)groupBox17).TabIndex = 12;
		groupBox17.TabStop = false;
		label19.AutoSize = true;
		Point location7 = new Point(21, 53);
		((Control)label19).Location = location7;
		((Control)label19).Name = "label19";
		Size size7 = new Size(83, 13);
		((Control)label19).Size = size7;
		((Control)label19).TabIndex = 13;
		label19.Text = "Number of Taps";
		((Control)nofTapsUpDown).Enabled = false;
		decimal increment = new decimal(new int[4] { 2, 0, 0, 0 });
		nofTapsUpDown.Increment = increment;
		Point location8 = new Point(115, 51);
		((Control)nofTapsUpDown).Location = location8;
		decimal maximum = new decimal(new int[4] { 4001, 0, 0, 0 });
		nofTapsUpDown.Maximum = maximum;
		decimal minimum = new decimal(new int[4] { 5, 0, 0, 0 });
		nofTapsUpDown.Minimum = minimum;
		((Control)nofTapsUpDown).Name = "nofTapsUpDown";
		((Control)nofTapsUpDown).RightToLeft = (RightToLeft)0;
		Size size8 = new Size(61, 20);
		((Control)nofTapsUpDown).Size = size8;
		((Control)nofTapsUpDown).TabIndex = 12;
		((Control)nofTapsUpDown).TabStop = false;
		((UpDownBase)nofTapsUpDown).TextAlign = (HorizontalAlignment)1;
		decimal value = new decimal(new int[4] { 501, 0, 0, 0 });
		nofTapsUpDown.Value = value;
		label35.AutoSize = true;
		Point location9 = new Point(182, 14);
		((Control)label35).Location = location9;
		((Control)label35).Name = "label35";
		Size size9 = new Size(20, 13);
		((Control)label35).Size = size9;
		((Control)label35).TabIndex = 6;
		label35.Text = "Hz";
		((Control)freqWindowHighpassUpDown).Enabled = false;
		Point location10 = new Point(115, 11);
		((Control)freqWindowHighpassUpDown).Location = location10;
		decimal maximum2 = new decimal(new int[4] { 100000, 0, 0, 0 });
		freqWindowHighpassUpDown.Maximum = maximum2;
		((Control)freqWindowHighpassUpDown).Name = "freqWindowHighpassUpDown";
		Size size10 = new Size(61, 20);
		((Control)freqWindowHighpassUpDown).Size = size10;
		((Control)freqWindowHighpassUpDown).TabIndex = 3;
		((UpDownBase)freqWindowHighpassUpDown).TextAlign = (HorizontalAlignment)1;
		decimal value2 = new decimal(new int[4] { 500, 0, 0, 0 });
		freqWindowHighpassUpDown.Value = value2;
		((ButtonBase)freqWindowHighpassCheckBox).AutoSize = true;
		Point location11 = new Point(6, 13);
		((Control)freqWindowHighpassCheckBox).Location = location11;
		((Control)freqWindowHighpassCheckBox).Name = "freqWindowHighpassCheckBox";
		Size size11 = new Size(102, 17);
		((Control)freqWindowHighpassCheckBox).Size = size11;
		((Control)freqWindowHighpassCheckBox).TabIndex = 1;
		((ButtonBase)freqWindowHighpassCheckBox).Text = "Highpass (From)";
		((ButtonBase)freqWindowHighpassCheckBox).UseVisualStyleBackColor = true;
		label4.AutoSize = true;
		Point location12 = new Point(182, 34);
		((Control)label4).Location = location12;
		((Control)label4).Name = "label4";
		Size size12 = new Size(20, 13);
		((Control)label4).Size = size12;
		((Control)label4).TabIndex = 3;
		label4.Text = "Hz";
		((Control)freqWindowLowpassUpDown).Enabled = false;
		Point location13 = new Point(115, 31);
		((Control)freqWindowLowpassUpDown).Location = location13;
		decimal maximum3 = new decimal(new int[4] { 100000, 0, 0, 0 });
		freqWindowLowpassUpDown.Maximum = maximum3;
		((Control)freqWindowLowpassUpDown).Name = "freqWindowLowpassUpDown";
		Size size13 = new Size(61, 20);
		((Control)freqWindowLowpassUpDown).Size = size13;
		((Control)freqWindowLowpassUpDown).TabIndex = 4;
		((UpDownBase)freqWindowLowpassUpDown).TextAlign = (HorizontalAlignment)1;
		decimal value3 = new decimal(new int[4] { 5000, 0, 0, 0 });
		freqWindowLowpassUpDown.Value = value3;
		((ButtonBase)freqWindowLowpassCheckBox).AutoSize = true;
		Point location14 = new Point(6, 31);
		((Control)freqWindowLowpassCheckBox).Location = location14;
		((Control)freqWindowLowpassCheckBox).Name = "freqWindowLowpassCheckBox";
		Size size14 = new Size(90, 17);
		((Control)freqWindowLowpassCheckBox).Size = size14;
		((Control)freqWindowLowpassCheckBox).TabIndex = 2;
		((ButtonBase)freqWindowLowpassCheckBox).Text = "Lowpass (To)";
		((ButtonBase)freqWindowLowpassCheckBox).UseVisualStyleBackColor = true;
		((Control)splitContainer).Anchor = (AnchorStyles)15;
		splitContainer.BorderStyle = (BorderStyle)2;
		Point location15 = new Point(235, 3);
		((Control)splitContainer).Location = location15;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Padding margin2);
		((Padding)(ref margin2))._002Ector(2);
		((Control)splitContainer).Margin = margin2;
		((Control)splitContainer).Name = "splitContainer";
		splitContainer.Orientation = (Orientation)0;
		((Control)splitContainer.Panel1).Controls.Add((Control)(object)freqGraph);
		splitContainer.Panel1MinSize = 0;
		((Control)splitContainer.Panel2).Controls.Add((Control)(object)impGraph);
		splitContainer.Panel2MinSize = 0;
		Size size15 = new Size(547, 489);
		((Control)splitContainer).Size = size15;
		splitContainer.SplitterDistance = 279;
		splitContainer.SplitterWidth = 6;
		((Control)splitContainer).TabIndex = 13;
		Color lightGray = Color.LightGray;
		((Control)freqGraph).BackColor = lightGray;
		((Control)freqGraph).Cursor = Cursors.Cross;
		((Control)freqGraph).Dock = (DockStyle)5;
		Point location16 = new Point(0, 0);
		((Control)freqGraph).Location = location16;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Padding margin3);
		((Padding)(ref margin3))._002Ector(0);
		((Control)freqGraph).Margin = margin3;
		((Control)freqGraph).Name = "freqGraph";
		Size size16 = new Size(543, 275);
		((Control)freqGraph).Size = size16;
		((Control)freqGraph).TabIndex = 0;
		Color lightGray2 = Color.LightGray;
		((Control)impGraph).BackColor = lightGray2;
		((Control)impGraph).Cursor = Cursors.Cross;
		((Control)impGraph).Dock = (DockStyle)5;
		Point location17 = new Point(0, 0);
		((Control)impGraph).Location = location17;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Padding margin4);
		((Padding)(ref margin4))._002Ector(0);
		((Control)impGraph).Margin = margin4;
		((Control)impGraph).Name = "impGraph";
		impGraph.ReverbdBVisible = true;
		Size size17 = new Size(543, 200);
		((Control)impGraph).Size = size17;
		((Control)impGraph).TabIndex = 0;
		((Control)plotGroupBox).Controls.Add((Control)(object)plotHdComboBox);
		((Control)plotGroupBox).Controls.Add((Control)(object)plotDistortionPanel);
		((Control)plotGroupBox).Controls.Add((Control)(object)plotHdCheckBox);
		((Control)plotGroupBox).Controls.Add((Control)(object)plotPhasePanel);
		((Control)plotGroupBox).Controls.Add((Control)(object)plotPhaseCheckBox);
		((Control)plotGroupBox).Controls.Add((Control)(object)plotAmpPanel);
		((Control)plotGroupBox).Controls.Add((Control)(object)plotAmpCheckBox);
		Point location18 = new Point(2, 3);
		((Control)plotGroupBox).Location = location18;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Padding margin5);
		((Padding)(ref margin5))._002Ector(1, 5, 1, 5);
		((Control)plotGroupBox).Margin = margin5;
		((Control)plotGroupBox).Name = "plotGroupBox";
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Padding padding);
		((Padding)(ref padding))._002Ector(0);
		((Control)plotGroupBox).Padding = padding;
		Size size18 = new Size(229, 66);
		((Control)plotGroupBox).Size = size18;
		((Control)plotGroupBox).TabIndex = 72;
		plotGroupBox.TabStop = false;
		plotGroupBox.Text = "Frequency components to plot";
		plotHdComboBox.DropDownStyle = (ComboBoxStyle)2;
		((Control)plotHdComboBox).Enabled = false;
		((ListControl)plotHdComboBox).FormattingEnabled = true;
		plotHdComboBox.ItemHeight = 13;
		object[] array = new object[11]
		{
			"THD", "Noise", "2nd HD", "3rd HD", "4th HD", "5th HD", "6th HD", "7th HD", "8th HD", "9th HD",
			"10th HD"
		};
		plotHdComboBox.Items.AddRange(array);
		Point location19 = new Point(78, 38);
		((Control)plotHdComboBox).Location = location19;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Padding margin6);
		((Padding)(ref margin6))._002Ector(0);
		((Control)plotHdComboBox).Margin = margin6;
		plotHdComboBox.MaxDropDownItems = 10;
		((Control)plotHdComboBox).Name = "plotHdComboBox";
		Size size19 = new Size(68, 21);
		((Control)plotHdComboBox).Size = size19;
		((Control)plotHdComboBox).TabIndex = 3;
		((Control)plotDistortionPanel).BackgroundImage = (Image)componentResourceManager.GetObject("plotDistortionPanel.BackgroundImage");
		((Control)plotDistortionPanel).BackgroundImageLayout = (ImageLayout)3;
		Point location20 = new Point(164, 49);
		((Control)plotDistortionPanel).Location = location20;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Padding margin7);
		((Padding)(ref margin7))._002Ector(0);
		((Control)plotDistortionPanel).Margin = margin7;
		((Control)plotDistortionPanel).Name = "plotDistortionPanel";
		Size size20 = new Size(50, 2);
		((Control)plotDistortionPanel).Size = size20;
		((Control)plotDistortionPanel).TabIndex = 8;
		((ButtonBase)plotHdCheckBox).AutoSize = true;
		Point location21 = new Point(7, 40);
		((Control)plotHdCheckBox).Location = location21;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Padding margin8);
		((Padding)(ref margin8))._002Ector(1);
		((Control)plotHdCheckBox).Margin = margin8;
		((Control)plotHdCheckBox).Name = "plotHdCheckBox";
		Size size21 = new Size(70, 17);
		((Control)plotHdCheckBox).Size = size21;
		((Control)plotHdCheckBox).TabIndex = 5;
		((ButtonBase)plotHdCheckBox).Text = "Distortion";
		toolTip.SetToolTip((Control)(object)plotHdCheckBox, "Harmonic Distortion \r\n(Only availbale when using LogSweep)");
		((ButtonBase)plotHdCheckBox).UseVisualStyleBackColor = true;
		((Control)plotPhasePanel).BackgroundImage = (Image)componentResourceManager.GetObject("plotPhasePanel.BackgroundImage");
		Point location22 = new Point(184, 25);
		((Control)plotPhasePanel).Location = location22;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Padding margin9);
		((Padding)(ref margin9))._002Ector(0);
		((Control)plotPhasePanel).Margin = margin9;
		((Control)plotPhasePanel).Name = "plotPhasePanel";
		Size size22 = new Size(30, 3);
		((Control)plotPhasePanel).Size = size22;
		((Control)plotPhasePanel).TabIndex = 4;
		((ButtonBase)plotPhaseCheckBox).AutoSize = true;
		plotPhaseCheckBox.Checked = true;
		plotPhaseCheckBox.CheckState = (CheckState)1;
		Point location23 = new Point(124, 17);
		((Control)plotPhaseCheckBox).Location = location23;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Padding margin10);
		((Padding)(ref margin10))._002Ector(1);
		((Control)plotPhaseCheckBox).Margin = margin10;
		((Control)plotPhaseCheckBox).Name = "plotPhaseCheckBox";
		Size size23 = new Size(56, 17);
		((Control)plotPhaseCheckBox).Size = size23;
		((Control)plotPhaseCheckBox).TabIndex = 1;
		((ButtonBase)plotPhaseCheckBox).Text = "Phase";
		((ButtonBase)plotPhaseCheckBox).UseVisualStyleBackColor = true;
		((Control)plotAmpPanel).BackgroundImage = (Image)componentResourceManager.GetObject("plotAmpPanel.BackgroundImage");
		((Control)plotAmpPanel).BackgroundImageLayout = (ImageLayout)3;
		Point location24 = new Point(77, 25);
		((Control)plotAmpPanel).Location = location24;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Padding margin11);
		((Padding)(ref margin11))._002Ector(0);
		((Control)plotAmpPanel).Margin = margin11;
		((Control)plotAmpPanel).Name = "plotAmpPanel";
		Size size24 = new Size(30, 3);
		((Control)plotAmpPanel).Size = size24;
		((Control)plotAmpPanel).TabIndex = 3;
		((ButtonBase)plotAmpCheckBox).AutoSize = true;
		plotAmpCheckBox.Checked = true;
		plotAmpCheckBox.CheckState = (CheckState)1;
		Point location25 = new Point(7, 17);
		((Control)plotAmpCheckBox).Location = location25;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Padding margin12);
		((Padding)(ref margin12))._002Ector(1);
		((Control)plotAmpCheckBox).Margin = margin12;
		((Control)plotAmpCheckBox).Name = "plotAmpCheckBox";
		Size size25 = new Size(72, 17);
		((Control)plotAmpCheckBox).Size = size25;
		((Control)plotAmpCheckBox).TabIndex = 2;
		((ButtonBase)plotAmpCheckBox).Text = "Amplitude";
		((ButtonBase)plotAmpCheckBox).UseVisualStyleBackColor = true;
		tableLayoutPanel2.CellBorderStyle = (TableLayoutPanelCellBorderStyle)2;
		tableLayoutPanel2.ColumnCount = 3;
		tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle((SizeType)2, 100f));
		tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle((SizeType)1, 19f));
		tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
		tableLayoutPanel2.Controls.Add((Control)(object)colorSignalPanel, 1, 0);
		tableLayoutPanel2.Controls.Add((Control)(object)plotSignalCheckBox, 0, 0);
		Point location26 = new Point(1, 359);
		((Control)tableLayoutPanel2).Location = location26;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Padding margin13);
		((Padding)(ref margin13))._002Ector(1, 5, 1, 5);
		((Control)tableLayoutPanel2).Margin = margin13;
		((Control)tableLayoutPanel2).Name = "tableLayoutPanel2";
		tableLayoutPanel2.RowCount = 1;
		tableLayoutPanel2.RowStyles.Add(new RowStyle((SizeType)1, 209f));
		Size size26 = new Size(230, 24);
		((Control)tableLayoutPanel2).Size = size26;
		((Control)tableLayoutPanel2).TabIndex = 8;
		Color darkGreen = Color.DarkGreen;
		((Control)colorSignalPanel).BackColor = darkGreen;
		Point location27 = new Point(207, 2);
		((Control)colorSignalPanel).Location = location27;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Padding margin14);
		((Padding)(ref margin14))._002Ector(0);
		((Control)colorSignalPanel).Margin = margin14;
		((Control)colorSignalPanel).Name = "colorSignalPanel";
		Size size27 = new Size(19, 21);
		((Control)colorSignalPanel).Size = size27;
		((Control)colorSignalPanel).TabIndex = 0;
		((ButtonBase)plotSignalCheckBox).AutoSize = true;
		Point location28 = new Point(4, 4);
		((Control)plotSignalCheckBox).Location = location28;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Padding margin15);
		((Padding)(ref margin15))._002Ector(2);
		((Control)plotSignalCheckBox).Margin = margin15;
		((Control)plotSignalCheckBox).Name = "plotSignalCheckBox";
		Size size28 = new Size(122, 17);
		((Control)plotSignalCheckBox).Size = size28;
		((Control)plotSignalCheckBox).TabIndex = 1;
		((ButtonBase)plotSignalCheckBox).Text = "Measurement Signal";
		((ButtonBase)plotSignalCheckBox).UseVisualStyleBackColor = true;
		mC.Identifier = "C";
		mC.ImportExportButtons = true;
		Point location29 = new Point(1, 239);
		((Control)mC).Location = location29;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Padding margin16);
		((Padding)(ref margin16))._002Ector(1, 5, 1, 5);
		((Control)mC).Margin = margin16;
		((Control)mC).Name = "mC";
		Size size29 = new Size(230, 70);
		((Control)mC).Size = size29;
		((Control)mC).TabIndex = 72;
		mB.Identifier = "B";
		mB.ImportExportButtons = true;
		Point location30 = new Point(1, 159);
		((Control)mB).Location = location30;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Padding margin17);
		((Padding)(ref margin17))._002Ector(1, 5, 1, 5);
		((Control)mB).Margin = margin17;
		((Control)mB).Name = "mB";
		Size size30 = new Size(230, 70);
		((Control)mB).Size = size30;
		((Control)mB).TabIndex = 71;
		mA.Identifier = "A";
		mA.ImportExportButtons = true;
		Point location31 = new Point(1, 79);
		((Control)mA).Location = location31;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Padding margin18);
		((Padding)(ref margin18))._002Ector(1, 5, 1, 5);
		((Control)mA).Margin = margin18;
		((Control)mA).Name = "mA";
		Size size31 = new Size(230, 70);
		((Control)mA).Size = size31;
		((Control)mA).TabIndex = 70;
		Point location32 = new Point(1, 321);
		((Control)organizeButton).Location = location32;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Padding margin19);
		((Padding)(ref margin19))._002Ector(1, 5, 1, 5);
		((Control)organizeButton).Margin = margin19;
		((Control)organizeButton).Name = "organizeButton";
		Size size32 = new Size(230, 21);
		((Control)organizeButton).Size = size32;
		((Control)organizeButton).TabIndex = 73;
		((ButtonBase)organizeButton).Text = "Organize measurements";
		((ButtonBase)organizeButton).UseVisualStyleBackColor = true;
		((Control)this).Controls.Add((Control)(object)organizeButton);
		((Control)this).Controls.Add((Control)(object)tableLayoutPanel2);
		((Control)this).Controls.Add((Control)(object)plotGroupBox);
		((Control)this).Controls.Add((Control)(object)groupBox17);
		((Control)this).Controls.Add((Control)(object)mC);
		((Control)this).Controls.Add((Control)(object)mB);
		((Control)this).Controls.Add((Control)(object)mA);
		((Control)this).Controls.Add((Control)(object)groupBox5);
		((Control)this).Controls.Add((Control)(object)splitContainer);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Padding margin20);
		((Padding)(ref margin20))._002Ector(0);
		((Control)this).Margin = margin20;
		((Control)this).Name = "ControlMeasurements";
		Size size33 = new Size(784, 495);
		((Control)this).Size = size33;
		((Control)groupBox5).ResumeLayout(false);
		((Control)groupBox5).PerformLayout();
		((Control)groupBox17).ResumeLayout(false);
		((Control)groupBox17).PerformLayout();
		((ISupportInitialize)nofTapsUpDown).EndInit();
		((ISupportInitialize)freqWindowHighpassUpDown).EndInit();
		((ISupportInitialize)freqWindowLowpassUpDown).EndInit();
		((Control)splitContainer.Panel1).ResumeLayout(false);
		((Control)splitContainer.Panel2).ResumeLayout(false);
		((Control)splitContainer).ResumeLayout(false);
		((Control)plotGroupBox).ResumeLayout(false);
		((Control)plotGroupBox).PerformLayout();
		((Control)tableLayoutPanel2).ResumeLayout(false);
		((Control)tableLayoutPanel2).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	protected override void Dispose([MarshalAs(UnmanagedType.U1)] bool P_0)
	{
		if (P_0)
		{
			try
			{
				_007EControlMeasurements();
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
