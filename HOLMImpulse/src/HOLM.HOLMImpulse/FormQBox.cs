using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace HOLM.HOLMImpulse;

public class FormQBox : Form
{
	public GroupBox groupBox1;

	private Label label5;

	private Label label6;

	public NumericUpDown fbUpDown;

	public NumericUpDown qtcUpDown;

	public CheckBox autoCheckBox;

	public Button updateButton;

	public Button closeButton;

	public Button fitAButton;

	private GroupBox groupBox2;

	private Label label3;

	public NumericUpDown range1UpDown;

	private Label label1;

	public NumericUpDown range0UpDown;

	public Button fitBButton;

	private Container components;

	public FormQBox()
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

	private void _007EFormQBox()
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
		//IL_0b7f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b89: Expected O, but got Unknown
		groupBox1 = new GroupBox();
		label5 = new Label();
		label6 = new Label();
		fbUpDown = new NumericUpDown();
		qtcUpDown = new NumericUpDown();
		autoCheckBox = new CheckBox();
		updateButton = new Button();
		closeButton = new Button();
		fitAButton = new Button();
		groupBox2 = new GroupBox();
		range1UpDown = new NumericUpDown();
		range0UpDown = new NumericUpDown();
		label1 = new Label();
		label3 = new Label();
		fitBButton = new Button();
		((Control)groupBox1).SuspendLayout();
		((ISupportInitialize)fbUpDown).BeginInit();
		((ISupportInitialize)qtcUpDown).BeginInit();
		((Control)groupBox2).SuspendLayout();
		((ISupportInitialize)range1UpDown).BeginInit();
		((ISupportInitialize)range0UpDown).BeginInit();
		((Control)this).SuspendLayout();
		((Control)groupBox1).Controls.Add((Control)(object)label5);
		((Control)groupBox1).Controls.Add((Control)(object)label6);
		((Control)groupBox1).Controls.Add((Control)(object)fbUpDown);
		((Control)groupBox1).Controls.Add((Control)(object)qtcUpDown);
		Point location = new Point(3, 1);
		((Control)groupBox1).Location = location;
		((Control)groupBox1).Name = "groupBox1";
		Size size = new Size(123, 76);
		((Control)groupBox1).Size = size;
		((Control)groupBox1).TabIndex = 2;
		groupBox1.TabStop = false;
		((Control)groupBox1).Tag = "";
		groupBox1.Text = "Parameters";
		label5.AutoSize = true;
		Point location2 = new Point(6, 48);
		((Control)label5).Location = location2;
		((Control)label5).Name = "label5";
		Size size2 = new Size(41, 13);
		((Control)label5).Size = size2;
		((Control)label5).TabIndex = 7;
		label5.Text = "Fb [Hz]";
		label6.AutoSize = true;
		Point location3 = new Point(6, 20);
		((Control)label6).Location = location3;
		((Control)label6).Name = "label6";
		Size size3 = new Size(27, 13);
		((Control)label6).Size = size3;
		((Control)label6).TabIndex = 6;
		label6.Text = "Qtc:";
		fbUpDown.DecimalPlaces = 1;
		Point location4 = new Point(59, 45);
		((Control)fbUpDown).Location = location4;
		decimal maximum = new decimal(new int[4] { 900, 0, 0, 0 });
		fbUpDown.Maximum = maximum;
		decimal minimum = new decimal(new int[4] { 1, 0, 0, 0 });
		fbUpDown.Minimum = minimum;
		((Control)fbUpDown).Name = "fbUpDown";
		Size size4 = new Size(54, 20);
		((Control)fbUpDown).Size = size4;
		((Control)fbUpDown).TabIndex = 3;
		((UpDownBase)fbUpDown).TextAlign = (HorizontalAlignment)1;
		decimal value = new decimal(new int[4] { 50, 0, 0, 0 });
		fbUpDown.Value = value;
		qtcUpDown.DecimalPlaces = 3;
		decimal increment = new decimal(new int[4] { 1, 0, 0, 131072 });
		qtcUpDown.Increment = increment;
		Point location5 = new Point(59, 18);
		((Control)qtcUpDown).Location = location5;
		decimal maximum2 = new decimal(new int[4] { 9, 0, 0, 0 });
		qtcUpDown.Maximum = maximum2;
		decimal minimum2 = new decimal(new int[4] { 1, 0, 0, 131072 });
		qtcUpDown.Minimum = minimum2;
		((Control)qtcUpDown).Name = "qtcUpDown";
		Size size5 = new Size(54, 20);
		((Control)qtcUpDown).Size = size5;
		((Control)qtcUpDown).TabIndex = 2;
		((Control)qtcUpDown).Tag = "";
		((UpDownBase)qtcUpDown).TextAlign = (HorizontalAlignment)1;
		decimal value2 = new decimal(new int[4] { 700, 0, 0, 196608 });
		qtcUpDown.Value = value2;
		((ButtonBase)autoCheckBox).AutoSize = true;
		Point location6 = new Point(132, 19);
		((Control)autoCheckBox).Location = location6;
		((Control)autoCheckBox).Name = "autoCheckBox";
		Size size6 = new Size(84, 17);
		((Control)autoCheckBox).Size = size6;
		((Control)autoCheckBox).TabIndex = 4;
		((ButtonBase)autoCheckBox).Text = "Auto update";
		((ButtonBase)autoCheckBox).UseVisualStyleBackColor = true;
		autoCheckBox.CheckedChanged += autoCheckBox_CheckedChanged;
		Point location7 = new Point(132, 46);
		((Control)updateButton).Location = location7;
		((Control)updateButton).Name = "updateButton";
		Size size7 = new Size(75, 21);
		((Control)updateButton).Size = size7;
		((Control)updateButton).TabIndex = 6;
		((ButtonBase)updateButton).Text = "Update";
		((ButtonBase)updateButton).UseVisualStyleBackColor = true;
		Point location8 = new Point(132, 139);
		((Control)closeButton).Location = location8;
		((Control)closeButton).Name = "closeButton";
		Size size8 = new Size(75, 21);
		((Control)closeButton).Size = size8;
		((Control)closeButton).TabIndex = 8;
		((ButtonBase)closeButton).Text = "Close";
		((ButtonBase)closeButton).UseVisualStyleBackColor = true;
		((Control)closeButton).Click += closeButton_Click;
		Point location9 = new Point(132, 86);
		((Control)fitAButton).Location = location9;
		((Control)fitAButton).Name = "fitAButton";
		Size size9 = new Size(75, 21);
		((Control)fitAButton).Size = size9;
		((Control)fitAButton).TabIndex = 9;
		((ButtonBase)fitAButton).Text = "Fit Slot A";
		((ButtonBase)fitAButton).UseVisualStyleBackColor = true;
		((Control)groupBox2).Controls.Add((Control)(object)range1UpDown);
		((Control)groupBox2).Controls.Add((Control)(object)range0UpDown);
		((Control)groupBox2).Controls.Add((Control)(object)label1);
		((Control)groupBox2).Controls.Add((Control)(object)label3);
		Point location10 = new Point(3, 80);
		((Control)groupBox2).Location = location10;
		((Control)groupBox2).Name = "groupBox2";
		Size size10 = new Size(123, 83);
		((Control)groupBox2).Size = size10;
		((Control)groupBox2).TabIndex = 10;
		groupBox2.TabStop = false;
		groupBox2.Text = "Fit with curve";
		Point location11 = new Point(59, 47);
		((Control)range1UpDown).Location = location11;
		decimal maximum3 = new decimal(new int[4] { 10000, 0, 0, 0 });
		range1UpDown.Maximum = maximum3;
		decimal minimum3 = new decimal(new int[4] { 1, 0, 0, 0 });
		range1UpDown.Minimum = minimum3;
		((Control)range1UpDown).Name = "range1UpDown";
		Size size11 = new Size(54, 20);
		((Control)range1UpDown).Size = size11;
		((Control)range1UpDown).TabIndex = 12;
		((UpDownBase)range1UpDown).TextAlign = (HorizontalAlignment)1;
		decimal value3 = new decimal(new int[4] { 150, 0, 0, 0 });
		range1UpDown.Value = value3;
		Point location12 = new Point(59, 20);
		((Control)range0UpDown).Location = location12;
		decimal maximum4 = new decimal(new int[4] { 10000, 0, 0, 0 });
		range0UpDown.Maximum = maximum4;
		decimal minimum4 = new decimal(new int[4] { 1, 0, 0, 0 });
		range0UpDown.Minimum = minimum4;
		((Control)range0UpDown).Name = "range0UpDown";
		Size size12 = new Size(54, 20);
		((Control)range0UpDown).Size = size12;
		((Control)range0UpDown).TabIndex = 10;
		((UpDownBase)range0UpDown).TextAlign = (HorizontalAlignment)1;
		decimal value4 = new decimal(new int[4] { 25, 0, 0, 0 });
		range0UpDown.Value = value4;
		label1.AutoSize = true;
		Point location13 = new Point(6, 50);
		((Control)label1).Location = location13;
		((Control)label1).Name = "label1";
		Size size13 = new Size(45, 13);
		((Control)label1).Size = size13;
		((Control)label1).TabIndex = 11;
		label1.Text = "To [Hz]:";
		label3.AutoSize = true;
		Point location14 = new Point(6, 23);
		((Control)label3).Location = location14;
		((Control)label3).Name = "label3";
		Size size14 = new Size(55, 13);
		((Control)label3).Size = size14;
		((Control)label3).TabIndex = 14;
		label3.Text = "From [Hz]:";
		Point location15 = new Point(132, 112);
		((Control)fitBButton).Location = location15;
		((Control)fitBButton).Name = "fitBButton";
		Size size15 = new Size(75, 21);
		((Control)fitBButton).Size = size15;
		((Control)fitBButton).TabIndex = 15;
		((ButtonBase)fitBButton).Text = "Fit Slot B";
		((ButtonBase)fitBButton).UseVisualStyleBackColor = true;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		Size clientSize = new Size(214, 168);
		((Form)this).ClientSize = clientSize;
		((Control)this).Controls.Add((Control)(object)fitBButton);
		((Control)this).Controls.Add((Control)(object)closeButton);
		((Control)this).Controls.Add((Control)(object)updateButton);
		((Control)this).Controls.Add((Control)(object)autoCheckBox);
		((Control)this).Controls.Add((Control)(object)fitAButton);
		((Control)this).Controls.Add((Control)(object)groupBox1);
		((Control)this).Controls.Add((Control)(object)groupBox2);
		((Form)this).FormBorderStyle = (FormBorderStyle)3;
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = "FormQBox";
		((Form)this).StartPosition = (FormStartPosition)1;
		((Form)this).Text = "QBox Simulate (Slot C)";
		((Form)this).TopMost = true;
		((Form)this).FormClosing += new FormClosingEventHandler(FormQBox_FormClosing);
		((Control)groupBox1).ResumeLayout(false);
		((Control)groupBox1).PerformLayout();
		((ISupportInitialize)fbUpDown).EndInit();
		((ISupportInitialize)qtcUpDown).EndInit();
		((Control)groupBox2).ResumeLayout(false);
		((Control)groupBox2).PerformLayout();
		((ISupportInitialize)range1UpDown).EndInit();
		((ISupportInitialize)range0UpDown).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void autoCheckBox_CheckedChanged(object sender, EventArgs e)
	{
		byte enabled = ((!autoCheckBox.Checked) ? ((byte)1) : ((byte)0));
		((Control)updateButton).Enabled = enabled != 0;
	}

	private void FormQBox_FormClosing(object sender, FormClosingEventArgs e)
	{
		((CancelEventArgs)(object)e).Cancel = true;
		((Control)this).Hide();
	}

	private void closeButton_Click(object sender, EventArgs e)
	{
		((Control)this).Hide();
	}

	protected override void Dispose([MarshalAs(UnmanagedType.U1)] bool P_0)
	{
		if (P_0)
		{
			try
			{
				_007EFormQBox();
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
