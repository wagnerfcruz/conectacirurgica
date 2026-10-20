using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace HOLM.HOLMImpulse;

public class FormAbcStitch : Form
{
	private GroupBox groupBox1;

	private Label label2;

	private Label label1;

	public NumericUpDown centerUpDown;

	public NumericUpDown lengthUpDown;

	public Button cancelButton;

	public Button updateButton;

	public Button undoButton;

	public CheckBox matchPhaseCheckBox;

	private Container components;

	public FormAbcStitch()
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

	private void _007EFormAbcStitch()
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
		//IL_06ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d4: Expected O, but got Unknown
		groupBox1 = new GroupBox();
		matchPhaseCheckBox = new CheckBox();
		lengthUpDown = new NumericUpDown();
		label2 = new Label();
		label1 = new Label();
		centerUpDown = new NumericUpDown();
		cancelButton = new Button();
		updateButton = new Button();
		undoButton = new Button();
		((Control)groupBox1).SuspendLayout();
		((ISupportInitialize)lengthUpDown).BeginInit();
		((ISupportInitialize)centerUpDown).BeginInit();
		((Control)this).SuspendLayout();
		((Control)groupBox1).Controls.Add((Control)(object)matchPhaseCheckBox);
		((Control)groupBox1).Controls.Add((Control)(object)lengthUpDown);
		((Control)groupBox1).Controls.Add((Control)(object)label2);
		((Control)groupBox1).Controls.Add((Control)(object)label1);
		((Control)groupBox1).Controls.Add((Control)(object)centerUpDown);
		Point location = new Point(5, 1);
		((Control)groupBox1).Location = location;
		((Control)groupBox1).Name = "groupBox1";
		Size size = new Size(225, 90);
		((Control)groupBox1).Size = size;
		((Control)groupBox1).TabIndex = 2;
		groupBox1.TabStop = false;
		groupBox1.Text = "Options";
		((ButtonBase)matchPhaseCheckBox).AutoSize = true;
		matchPhaseCheckBox.Checked = true;
		matchPhaseCheckBox.CheckState = (CheckState)1;
		Point location2 = new Point(10, 66);
		((Control)matchPhaseCheckBox).Location = location2;
		((Control)matchPhaseCheckBox).Name = "matchPhaseCheckBox";
		Size size2 = new Size(163, 17);
		((Control)matchPhaseCheckBox).Size = size2;
		((Control)matchPhaseCheckBox).TabIndex = 4;
		((ButtonBase)matchPhaseCheckBox).Text = "Match phase before stitching";
		((ButtonBase)matchPhaseCheckBox).UseVisualStyleBackColor = true;
		decimal increment = new decimal(new int[4] { 5, 0, 0, 0 });
		lengthUpDown.Increment = increment;
		Point location3 = new Point(95, 40);
		((Control)lengthUpDown).Location = location3;
		decimal maximum = new decimal(new int[4] { 10000, 0, 0, 0 });
		lengthUpDown.Maximum = maximum;
		((Control)lengthUpDown).Name = "lengthUpDown";
		((Control)lengthUpDown).RightToLeft = (RightToLeft)1;
		Size size3 = new Size(59, 20);
		((Control)lengthUpDown).Size = size3;
		((Control)lengthUpDown).TabIndex = 2;
		((UpDownBase)lengthUpDown).UpDownAlign = (LeftRightAlignment)0;
		decimal value = new decimal(new int[4] { 200, 0, 0, 0 });
		lengthUpDown.Value = value;
		label2.AutoSize = true;
		Point location4 = new Point(7, 42);
		((Control)label2).Location = location4;
		((Control)label2).Name = "label2";
		Size size4 = new Size(60, 13);
		((Control)label2).Size = size4;
		((Control)label2).TabIndex = 2;
		label2.Text = "Width [Hz]:";
		label1.AutoSize = true;
		Point location5 = new Point(7, 16);
		((Control)label1).Location = location5;
		((Control)label1).Name = "label1";
		Size size5 = new Size(82, 13);
		((Control)label1).Size = size5;
		((Control)label1).TabIndex = 1;
		label1.Text = "Frequency [Hz]:";
		decimal increment2 = new decimal(new int[4] { 10, 0, 0, 0 });
		centerUpDown.Increment = increment2;
		Point location6 = new Point(95, 14);
		((Control)centerUpDown).Location = location6;
		decimal maximum2 = new decimal(new int[4] { 96000, 0, 0, 0 });
		centerUpDown.Maximum = maximum2;
		((Control)centerUpDown).Name = "centerUpDown";
		((Control)centerUpDown).RightToLeft = (RightToLeft)1;
		Size size6 = new Size(59, 20);
		((Control)centerUpDown).Size = size6;
		((Control)centerUpDown).TabIndex = 0;
		((UpDownBase)centerUpDown).UpDownAlign = (LeftRightAlignment)0;
		decimal value2 = new decimal(new int[4] { 2000, 0, 0, 0 });
		centerUpDown.Value = value2;
		cancelButton.DialogResult = (DialogResult)2;
		Point location7 = new Point(164, 97);
		((Control)cancelButton).Location = location7;
		((Control)cancelButton).Name = "cancelButton";
		Size size7 = new Size(66, 23);
		((Control)cancelButton).Size = size7;
		((Control)cancelButton).TabIndex = 6;
		((ButtonBase)cancelButton).Text = "&Close";
		((ButtonBase)cancelButton).UseVisualStyleBackColor = true;
		((Control)cancelButton).Click += cancelButton_Click;
		Point location8 = new Point(75, 97);
		((Control)updateButton).Location = location8;
		((Control)updateButton).Name = "updateButton";
		Size size8 = new Size(83, 23);
		((Control)updateButton).Size = size8;
		((Control)updateButton).TabIndex = 0;
		((ButtonBase)updateButton).Text = "&Update";
		((ButtonBase)updateButton).UseVisualStyleBackColor = true;
		Point location9 = new Point(5, 97);
		((Control)undoButton).Location = location9;
		((Control)undoButton).Name = "undoButton";
		Size size9 = new Size(64, 23);
		((Control)undoButton).Size = size9;
		((Control)undoButton).TabIndex = 7;
		((ButtonBase)undoButton).Text = "Undo";
		((ButtonBase)undoButton).UseVisualStyleBackColor = true;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		Size clientSize = new Size(234, 123);
		((Form)this).ClientSize = clientSize;
		((Control)this).Controls.Add((Control)(object)undoButton);
		((Control)this).Controls.Add((Control)(object)updateButton);
		((Control)this).Controls.Add((Control)(object)cancelButton);
		((Control)this).Controls.Add((Control)(object)groupBox1);
		((Form)this).FormBorderStyle = (FormBorderStyle)5;
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = "FormAbcStitch";
		((Form)this).ShowInTaskbar = false;
		((Form)this).StartPosition = (FormStartPosition)1;
		((Form)this).Text = "Stitch Maesurements (C = A -> B)";
		((Form)this).TopMost = true;
		((Form)this).FormClosing += new FormClosingEventHandler(FormAbcStitch_FormClosing);
		((Control)groupBox1).ResumeLayout(false);
		((Control)groupBox1).PerformLayout();
		((ISupportInitialize)lengthUpDown).EndInit();
		((ISupportInitialize)centerUpDown).EndInit();
		((Control)this).ResumeLayout(false);
	}

	private void cancelButton_Click(object sender, EventArgs e)
	{
		((Control)this).Hide();
	}

	private void FormAbcStitch_FormClosing(object sender, FormClosingEventArgs e)
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
				_007EFormAbcStitch();
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
