using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace HOLM.HOLMImpulse;

public class FormMatchAToB : Form
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

	public FormMatchAToB()
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

	private void _007EFormMatchAToB()
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
		//IL_06a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ae: Expected O, but got Unknown
		//IL_06ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f9: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(FormMatchAToB));
		groupBox1 = new GroupBox();
		lengthUpDown = new NumericUpDown();
		label2 = new Label();
		label1 = new Label();
		centerUpDown = new NumericUpDown();
		cancelButton = new Button();
		updateButton = new Button();
		undoButton = new Button();
		matchPhaseCheckBox = new CheckBox();
		((Control)groupBox1).SuspendLayout();
		((ISupportInitialize)lengthUpDown).BeginInit();
		((ISupportInitialize)centerUpDown).BeginInit();
		((Control)this).SuspendLayout();
		((Control)groupBox1).Controls.Add((Control)(object)matchPhaseCheckBox);
		((Control)groupBox1).Controls.Add((Control)(object)lengthUpDown);
		((Control)groupBox1).Controls.Add((Control)(object)label2);
		((Control)groupBox1).Controls.Add((Control)(object)label1);
		((Control)groupBox1).Controls.Add((Control)(object)centerUpDown);
		Point location = new Point(5, 3);
		((Control)groupBox1).Location = location;
		((Control)groupBox1).Name = "groupBox1";
		Size size = new Size(225, 94);
		((Control)groupBox1).Size = size;
		((Control)groupBox1).TabIndex = 2;
		groupBox1.TabStop = false;
		groupBox1.Text = "Options";
		decimal increment = new decimal(new int[4] { 5, 0, 0, 0 });
		lengthUpDown.Increment = increment;
		Point location2 = new Point(95, 40);
		((Control)lengthUpDown).Location = location2;
		decimal maximum = new decimal(new int[4] { 10000, 0, 0, 0 });
		lengthUpDown.Maximum = maximum;
		((Control)lengthUpDown).Name = "lengthUpDown";
		((Control)lengthUpDown).RightToLeft = (RightToLeft)1;
		Size size2 = new Size(59, 20);
		((Control)lengthUpDown).Size = size2;
		((Control)lengthUpDown).TabIndex = 2;
		((UpDownBase)lengthUpDown).UpDownAlign = (LeftRightAlignment)0;
		decimal value = new decimal(new int[4] { 100, 0, 0, 0 });
		lengthUpDown.Value = value;
		label2.AutoSize = true;
		Point location3 = new Point(7, 42);
		((Control)label2).Location = location3;
		((Control)label2).Name = "label2";
		Size size3 = new Size(60, 13);
		((Control)label2).Size = size3;
		((Control)label2).TabIndex = 2;
		label2.Text = "Width [Hz]:";
		label1.AutoSize = true;
		Point location4 = new Point(7, 16);
		((Control)label1).Location = location4;
		((Control)label1).Name = "label1";
		Size size4 = new Size(82, 13);
		((Control)label1).Size = size4;
		((Control)label1).TabIndex = 1;
		label1.Text = "Frequency [Hz]:";
		decimal increment2 = new decimal(new int[4] { 10, 0, 0, 0 });
		centerUpDown.Increment = increment2;
		Point location5 = new Point(95, 14);
		((Control)centerUpDown).Location = location5;
		decimal maximum2 = new decimal(new int[4] { 96000, 0, 0, 0 });
		centerUpDown.Maximum = maximum2;
		((Control)centerUpDown).Name = "centerUpDown";
		((Control)centerUpDown).RightToLeft = (RightToLeft)1;
		Size size5 = new Size(59, 20);
		((Control)centerUpDown).Size = size5;
		((Control)centerUpDown).TabIndex = 0;
		((UpDownBase)centerUpDown).UpDownAlign = (LeftRightAlignment)0;
		decimal value2 = new decimal(new int[4] { 2000, 0, 0, 0 });
		centerUpDown.Value = value2;
		cancelButton.DialogResult = (DialogResult)2;
		Point location6 = new Point(164, 103);
		((Control)cancelButton).Location = location6;
		((Control)cancelButton).Name = "cancelButton";
		Size size6 = new Size(66, 23);
		((Control)cancelButton).Size = size6;
		((Control)cancelButton).TabIndex = 6;
		((ButtonBase)cancelButton).Text = "&Close";
		((ButtonBase)cancelButton).UseVisualStyleBackColor = true;
		((Control)cancelButton).Click += cancelButton_Click;
		Point location7 = new Point(75, 103);
		((Control)updateButton).Location = location7;
		((Control)updateButton).Name = "updateButton";
		Size size7 = new Size(83, 23);
		((Control)updateButton).Size = size7;
		((Control)updateButton).TabIndex = 0;
		((ButtonBase)updateButton).Text = "&Update";
		((ButtonBase)updateButton).UseVisualStyleBackColor = true;
		Point location8 = new Point(5, 103);
		((Control)undoButton).Location = location8;
		((Control)undoButton).Name = "undoButton";
		Size size8 = new Size(64, 23);
		((Control)undoButton).Size = size8;
		((Control)undoButton).TabIndex = 7;
		((ButtonBase)undoButton).Text = "Undo";
		((ButtonBase)undoButton).UseVisualStyleBackColor = true;
		((ButtonBase)matchPhaseCheckBox).AutoSize = true;
		matchPhaseCheckBox.Checked = true;
		matchPhaseCheckBox.CheckState = (CheckState)1;
		Point location9 = new Point(10, 66);
		((Control)matchPhaseCheckBox).Location = location9;
		((Control)matchPhaseCheckBox).Name = "matchPhaseCheckBox";
		Size size9 = new Size(88, 17);
		((Control)matchPhaseCheckBox).Size = size9;
		((Control)matchPhaseCheckBox).TabIndex = 6;
		((ButtonBase)matchPhaseCheckBox).Text = "Match phase";
		((ButtonBase)matchPhaseCheckBox).UseVisualStyleBackColor = true;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		Size clientSize = new Size(234, 129);
		((Form)this).ClientSize = clientSize;
		((Control)this).Controls.Add((Control)(object)undoButton);
		((Control)this).Controls.Add((Control)(object)updateButton);
		((Control)this).Controls.Add((Control)(object)cancelButton);
		((Control)this).Controls.Add((Control)(object)groupBox1);
		((Form)this).FormBorderStyle = (FormBorderStyle)5;
		((Form)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = "FormMatchAToB";
		((Form)this).ShowIcon = false;
		((Form)this).StartPosition = (FormStartPosition)1;
		((Form)this).Text = "Match Maesurement ( A -> B)";
		((Form)this).TopMost = true;
		((Form)this).FormClosing += new FormClosingEventHandler(FormMatchAToB_FormClosing);
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

	private void FormMatchAToB_FormClosing(object sender, FormClosingEventArgs e)
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
				_007EFormMatchAToB();
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
