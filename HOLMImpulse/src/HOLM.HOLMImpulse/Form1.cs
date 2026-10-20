using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace HOLM.HOLMImpulse;

public class Form1 : Form
{
	public StatusStrip lowerStatusStrip;

	public ToolStripStatusLabel toolStripStatusLabel1;

	public TabControl mainTabControl;

	public ToolTip toolTip;

	private CheckBox checkBox1;

	private ToolStripSeparator toolStripSeparator10;

	public ToolStripMenuItem manipulateLowpassMenuItem;

	public TabPage measurementTab;

	public ControlMenu menu;

	public ControlMeasurements meas;

	public TabPage devSignalTab;

	public TabPage analysisTab;

	public ControlDevSignal dev;

	public ControlDataAnalysis analysis;

	private IContainer components;

	public Form1()
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

	private void _007EForm1()
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
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected O, but got Unknown
		//IL_0206: Unknown result type (might be due to invalid IL or missing references)
		//IL_029e: Unknown result type (might be due to invalid IL or missing references)
		//IL_030f: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0473: Unknown result type (might be due to invalid IL or missing references)
		//IL_0500: Unknown result type (might be due to invalid IL or missing references)
		//IL_0571: Unknown result type (might be due to invalid IL or missing references)
		//IL_062d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0637: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		lowerStatusStrip = new StatusStrip();
		toolStripStatusLabel1 = new ToolStripStatusLabel();
		mainTabControl = new TabControl();
		devSignalTab = new TabPage();
		dev = new ControlDevSignal();
		analysisTab = new TabPage();
		analysis = new ControlDataAnalysis();
		measurementTab = new TabPage();
		meas = new ControlMeasurements();
		toolTip = new ToolTip(components);
		menu = new ControlMenu();
		((Control)lowerStatusStrip).SuspendLayout();
		((Control)mainTabControl).SuspendLayout();
		((Control)devSignalTab).SuspendLayout();
		((Control)analysisTab).SuspendLayout();
		((Control)measurementTab).SuspendLayout();
		((Control)this).SuspendLayout();
		ToolStripItem[] array = (ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)toolStripStatusLabel1 };
		((ToolStrip)lowerStatusStrip).Items.AddRange(array);
		Point location = new Point(0, 551);
		((Control)lowerStatusStrip).Location = location;
		((Control)lowerStatusStrip).Name = "lowerStatusStrip";
		Size size = new Size(792, 22);
		((Control)lowerStatusStrip).Size = size;
		((Control)lowerStatusStrip).TabIndex = 1;
		((Control)lowerStatusStrip).Text = "No status";
		((ToolStripItem)toolStripStatusLabel1).Name = "toolStripStatusLabel1";
		Size size2 = new Size(54, 17);
		((ToolStripItem)toolStripStatusLabel1).Size = size2;
		((ToolStripItem)toolStripStatusLabel1).Text = "No Status";
		((Control)mainTabControl).Anchor = (AnchorStyles)15;
		((Control)mainTabControl).Controls.Add((Control)(object)devSignalTab);
		((Control)mainTabControl).Controls.Add((Control)(object)analysisTab);
		((Control)mainTabControl).Controls.Add((Control)(object)measurementTab);
		Point location2 = new Point(0, 23);
		((Control)mainTabControl).Location = location2;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Padding margin);
		((Padding)(ref margin))._002Ector(0);
		((Control)mainTabControl).Margin = margin;
		((Control)mainTabControl).Name = "mainTabControl";
		mainTabControl.SelectedIndex = 0;
		Size size3 = new Size(792, 528);
		((Control)mainTabControl).Size = size3;
		((Control)mainTabControl).TabIndex = 0;
		((Control)devSignalTab).Controls.Add((Control)(object)dev);
		Point location3 = new Point(4, 22);
		devSignalTab.Location = location3;
		((Control)devSignalTab).Name = "devSignalTab";
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Padding padding);
		((Padding)(ref padding))._002Ector(3);
		((Control)devSignalTab).Padding = padding;
		Size size4 = new Size(784, 502);
		((Control)devSignalTab).Size = size4;
		devSignalTab.TabIndex = 2;
		devSignalTab.Text = "Device && Signal";
		devSignalTab.UseVisualStyleBackColor = true;
		Point location4 = new Point(0, 0);
		((Control)dev).Location = location4;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Padding margin2);
		((Padding)(ref margin2))._002Ector(0);
		((Control)dev).Margin = margin2;
		((Control)dev).Name = "dev";
		Size size5 = new Size(784, 498);
		((Control)dev).Size = size5;
		((Control)dev).TabIndex = 0;
		((Control)analysisTab).Controls.Add((Control)(object)analysis);
		Point location5 = new Point(4, 22);
		analysisTab.Location = location5;
		((Control)analysisTab).Name = "analysisTab";
		Size size6 = new Size(784, 502);
		((Control)analysisTab).Size = size6;
		analysisTab.TabIndex = 3;
		analysisTab.Text = "Data analysis";
		analysisTab.UseVisualStyleBackColor = true;
		Point location6 = new Point(0, 0);
		((Control)analysis).Location = location6;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Padding margin3);
		((Padding)(ref margin3))._002Ector(0);
		((Control)analysis).Margin = margin3;
		((Control)analysis).Name = "analysis";
		Size size7 = new Size(784, 498);
		((Control)analysis).Size = size7;
		((Control)analysis).TabIndex = 0;
		((Control)measurementTab).Controls.Add((Control)(object)meas);
		Point location7 = new Point(4, 22);
		measurementTab.Location = location7;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Padding margin4);
		((Padding)(ref margin4))._002Ector(0);
		((Control)measurementTab).Margin = margin4;
		((Control)measurementTab).Name = "measurementTab";
		Size size8 = new Size(784, 502);
		((Control)measurementTab).Size = size8;
		measurementTab.TabIndex = 1;
		measurementTab.Text = "Measurements";
		measurementTab.UseVisualStyleBackColor = true;
		((Control)meas).Dock = (DockStyle)5;
		Point location8 = new Point(0, 0);
		((Control)meas).Location = location8;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Padding margin5);
		((Padding)(ref margin5))._002Ector(0);
		((Control)meas).Margin = margin5;
		((Control)meas).Name = "meas";
		Size size9 = new Size(784, 502);
		((Control)meas).Size = size9;
		((Control)meas).TabIndex = 0;
		((Control)menu).Dock = (DockStyle)1;
		Point location9 = new Point(0, 0);
		((Control)menu).Location = location9;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Padding margin6);
		((Padding)(ref margin6))._002Ector(0);
		((Control)menu).Margin = margin6;
		((Control)menu).Name = "menu";
		Size size10 = new Size(792, 23);
		((Control)menu).Size = size10;
		((Control)menu).TabIndex = 2;
		((Control)this).AllowDrop = true;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		Size clientSize = new Size(792, 573);
		((Form)this).ClientSize = clientSize;
		((Control)this).Controls.Add((Control)(object)menu);
		((Control)this).Controls.Add((Control)(object)lowerStatusStrip);
		((Control)this).Controls.Add((Control)(object)mainTabControl);
		((Form)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		Size minimumSize = new Size(800, 600);
		((Form)this).MinimumSize = minimumSize;
		((Control)this).Name = "Form1";
		((Form)this).Text = "HOLMImpulse";
		((Form)this).Shown += Form1_Shown;
		((Control)lowerStatusStrip).ResumeLayout(false);
		((Control)lowerStatusStrip).PerformLayout();
		((Control)mainTabControl).ResumeLayout(false);
		((Control)devSignalTab).ResumeLayout(false);
		((Control)analysisTab).ResumeLayout(false);
		((Control)measurementTab).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void Form1_Shown(object sender, EventArgs e)
	{
		((Form)this).Activate();
	}

	protected override void Dispose([MarshalAs(UnmanagedType.U1)] bool P_0)
	{
		if (P_0)
		{
			try
			{
				_007EForm1();
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
