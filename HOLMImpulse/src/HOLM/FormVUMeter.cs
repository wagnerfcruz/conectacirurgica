using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace HOLM;

public class FormVUMeter : Form
{
	public Panel scalePanel;

	public Button closeButton;

	private Label label5;

	public Button resetButton;

	private Label label6;

	public TextBox sourceTextBox;

	public Panel[] panels;

	public Label label1;

	public NumericUpDown minDBUpDown;

	public Panel panel1;

	public Panel panel2;

	public Label label2;

	public Panel panel3;

	public Label label3;

	public Panel panel4;

	public Label label4;

	private Container components;

	public FormVUMeter()
	{
		try
		{
			InitializeComponent();
			(panels = (Panel[])(object)new Panel[4])[0] = panel1;
			panels[1] = panel2;
			panels[2] = panel3;
			panels[3] = panel4;
			return;
		}
		catch
		{
			//try-fault
			((Form)this).Dispose(true);
			throw;
		}
	}

	private void _007EFormVUMeter()
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
		//IL_054d: Unknown result type (might be due to invalid IL or missing references)
		//IL_076b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0775: Expected O, but got Unknown
		label1 = new Label();
		minDBUpDown = new NumericUpDown();
		panel1 = new Panel();
		panel2 = new Panel();
		label2 = new Label();
		panel3 = new Panel();
		label3 = new Label();
		panel4 = new Panel();
		label4 = new Label();
		scalePanel = new Panel();
		closeButton = new Button();
		label5 = new Label();
		resetButton = new Button();
		label6 = new Label();
		sourceTextBox = new TextBox();
		((ISupportInitialize)minDBUpDown).BeginInit();
		((Control)this).SuspendLayout();
		label1.AutoSize = true;
		Point location = new Point(0, 57);
		((Control)label1).Location = location;
		((Control)label1).Name = "label1";
		Size size = new Size(28, 13);
		((Control)label1).Size = size;
		((Control)label1).TabIndex = 10;
		label1.Text = "Left:";
		decimal increment = new decimal(new int[4] { 10, 0, 0, 0 });
		minDBUpDown.Increment = increment;
		Point location2 = new Point(49, 5);
		((Control)minDBUpDown).Location = location2;
		decimal maximum = new decimal(new int[4] { 10, 0, 0, -2147483648 });
		minDBUpDown.Maximum = maximum;
		decimal minimum = new decimal(new int[4] { 200, 0, 0, -2147483648 });
		minDBUpDown.Minimum = minimum;
		((Control)minDBUpDown).Name = "minDBUpDown";
		Size size2 = new Size(47, 20);
		((Control)minDBUpDown).Size = size2;
		((Control)minDBUpDown).TabIndex = 0;
		((UpDownBase)minDBUpDown).TextAlign = (HorizontalAlignment)1;
		decimal value = new decimal(new int[4] { 60, 0, 0, -2147483648 });
		minDBUpDown.Value = value;
		((Control)panel1).Anchor = (AnchorStyles)13;
		panel1.BorderStyle = (BorderStyle)1;
		Point location3 = new Point(40, 55);
		((Control)panel1).Location = location3;
		((Control)panel1).Name = "panel1";
		Size size3 = new Size(380, 20);
		((Control)panel1).Size = size3;
		((Control)panel1).TabIndex = 10;
		((Control)panel2).Anchor = (AnchorStyles)13;
		panel2.BorderStyle = (BorderStyle)1;
		Point location4 = new Point(40, 81);
		((Control)panel2).Location = location4;
		((Control)panel2).Name = "panel2";
		Size size4 = new Size(380, 20);
		((Control)panel2).Size = size4;
		((Control)panel2).TabIndex = 12;
		label2.AutoSize = true;
		Point location5 = new Point(0, 83);
		((Control)label2).Location = location5;
		((Control)label2).Name = "label2";
		Size size5 = new Size(35, 13);
		((Control)label2).Size = size5;
		((Control)label2).TabIndex = 11;
		label2.Text = "Right:";
		((Control)panel3).Anchor = (AnchorStyles)13;
		panel3.BorderStyle = (BorderStyle)1;
		Point location6 = new Point(40, 107);
		((Control)panel3).Location = location6;
		((Control)panel3).Name = "panel3";
		Size size6 = new Size(380, 20);
		((Control)panel3).Size = size6;
		((Control)panel3).TabIndex = 14;
		label3.AutoSize = true;
		Point location7 = new Point(0, 111);
		((Control)label3).Location = location7;
		((Control)label3).Name = "label3";
		Size size7 = new Size(35, 13);
		((Control)label3).Size = size7;
		((Control)label3).TabIndex = 13;
		label3.Text = "Ch. 3:";
		((Control)panel4).Anchor = (AnchorStyles)13;
		panel4.BorderStyle = (BorderStyle)1;
		Point location8 = new Point(40, 133);
		((Control)panel4).Location = location8;
		((Control)panel4).Name = "panel4";
		Size size8 = new Size(380, 20);
		((Control)panel4).Size = size8;
		((Control)panel4).TabIndex = 16;
		label4.AutoSize = true;
		Point location9 = new Point(0, 136);
		((Control)label4).Location = location9;
		((Control)label4).Name = "label4";
		Size size9 = new Size(35, 13);
		((Control)label4).Size = size9;
		((Control)label4).TabIndex = 15;
		label4.Text = "Ch. 4:";
		((Control)scalePanel).Anchor = (AnchorStyles)13;
		Point location10 = new Point(20, 30);
		((Control)scalePanel).Location = location10;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Padding margin);
		((Padding)(ref margin))._002Ector(0);
		((Control)scalePanel).Margin = margin;
		((Control)scalePanel).Name = "scalePanel";
		Size size10 = new Size(420, 20);
		((Control)scalePanel).Size = size10;
		((Control)scalePanel).TabIndex = 17;
		Point location11 = new Point(185, 4);
		((Control)closeButton).Location = location11;
		((Control)closeButton).Name = "closeButton";
		Size size11 = new Size(58, 21);
		((Control)closeButton).Size = size11;
		((Control)closeButton).TabIndex = 4;
		((ButtonBase)closeButton).Text = "&Close";
		((ButtonBase)closeButton).UseVisualStyleBackColor = true;
		((Control)closeButton).Click += closeButton_Click;
		label5.AutoSize = true;
		Point location12 = new Point(0, 9);
		((Control)label5).Location = location12;
		((Control)label5).Name = "label5";
		Size size12 = new Size(49, 13);
		((Control)label5).Size = size12;
		((Control)label5).TabIndex = 19;
		label5.Text = "Min [dB]:";
		Point location13 = new Point(102, 4);
		((Control)resetButton).Location = location13;
		((Control)resetButton).Name = "resetButton";
		Size size13 = new Size(77, 21);
		((Control)resetButton).Size = size13;
		((Control)resetButton).TabIndex = 2;
		((ButtonBase)resetButton).Text = "&Reset Peaks";
		((ButtonBase)resetButton).UseVisualStyleBackColor = true;
		label6.AutoSize = true;
		Point location14 = new Point(0, 33);
		((Control)label6).Location = location14;
		((Control)label6).Name = "label6";
		Size size14 = new Size(23, 13);
		((Control)label6).Size = size14;
		((Control)label6).TabIndex = 21;
		label6.Text = "dB:";
		Color window = SystemColors.Window;
		((TextBoxBase)sourceTextBox).BackColor = window;
		((Control)sourceTextBox).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		Point location15 = new Point(250, 4);
		((Control)sourceTextBox).Location = location15;
		((Control)sourceTextBox).Name = "sourceTextBox";
		((TextBoxBase)sourceTextBox).ReadOnly = true;
		Size size15 = new Size(140, 20);
		((Control)sourceTextBox).Size = size15;
		((Control)sourceTextBox).TabIndex = 22;
		sourceTextBox.Text = "-----";
		((Control)sourceTextBox).Visible = false;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		Size clientSize = new Size(442, 103);
		((Form)this).ClientSize = clientSize;
		((Control)this).Controls.Add((Control)(object)sourceTextBox);
		((Control)this).Controls.Add((Control)(object)label6);
		((Control)this).Controls.Add((Control)(object)resetButton);
		((Control)this).Controls.Add((Control)(object)label5);
		((Control)this).Controls.Add((Control)(object)closeButton);
		((Control)this).Controls.Add((Control)(object)panel4);
		((Control)this).Controls.Add((Control)(object)label4);
		((Control)this).Controls.Add((Control)(object)panel3);
		((Control)this).Controls.Add((Control)(object)label3);
		((Control)this).Controls.Add((Control)(object)panel2);
		((Control)this).Controls.Add((Control)(object)panel1);
		((Control)this).Controls.Add((Control)(object)label2);
		((Control)this).Controls.Add((Control)(object)minDBUpDown);
		((Control)this).Controls.Add((Control)(object)label1);
		((Control)this).Controls.Add((Control)(object)scalePanel);
		Size minimumSize = new Size(300, 130);
		((Form)this).MinimumSize = minimumSize;
		((Control)this).Name = "FormVUMeter";
		((Form)this).ShowIcon = false;
		((Form)this).SizeGripStyle = (SizeGripStyle)1;
		((Form)this).Text = "Recording meter";
		((Form)this).TopMost = true;
		((ISupportInitialize)minDBUpDown).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void closeButton_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	protected override void Dispose([MarshalAs(UnmanagedType.U1)] bool P_0)
	{
		if (P_0)
		{
			try
			{
				_007EFormVUMeter();
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
