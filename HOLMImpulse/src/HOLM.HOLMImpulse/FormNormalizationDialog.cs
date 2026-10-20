using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace HOLM.HOLMImpulse;

public class FormNormalizationDialog : Form
{
	private Label label1;

	public NumericUpDown phaseHideDBUpDown;

	public NumericUpDown distortionHideDBUpDown;

	private Label label2;

	public Button yesButton;

	public Button noButton;

	public NumericUpDown maxDBUpDown;

	private Label label3;

	private Container components;

	public FormNormalizationDialog()
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

	private void _007EFormNormalizationDialog()
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
		label1 = new Label();
		phaseHideDBUpDown = new NumericUpDown();
		distortionHideDBUpDown = new NumericUpDown();
		label2 = new Label();
		yesButton = new Button();
		noButton = new Button();
		maxDBUpDown = new NumericUpDown();
		label3 = new Label();
		((ISupportInitialize)phaseHideDBUpDown).BeginInit();
		((ISupportInitialize)distortionHideDBUpDown).BeginInit();
		((ISupportInitialize)maxDBUpDown).BeginInit();
		((Control)this).SuspendLayout();
		label1.AutoSize = true;
		Point location = new Point(3, 36);
		((Control)label1).Location = location;
		((Control)label1).Name = "label1";
		Size size = new Size(204, 13);
		((Control)label1).Size = size;
		((Control)label1).TabIndex = 0;
		label1.Text = "Hide phase when amplitude is below [dB]:";
		Point location2 = new Point(226, 34);
		((Control)phaseHideDBUpDown).Location = location2;
		decimal maximum = new decimal(new int[4] { 20, 0, 0, 0 });
		phaseHideDBUpDown.Maximum = maximum;
		decimal minimum = new decimal(new int[4] { 200, 0, 0, -2147483648 });
		phaseHideDBUpDown.Minimum = minimum;
		((Control)phaseHideDBUpDown).Name = "phaseHideDBUpDown";
		Size size2 = new Size(49, 20);
		((Control)phaseHideDBUpDown).Size = size2;
		((Control)phaseHideDBUpDown).TabIndex = 3;
		((UpDownBase)phaseHideDBUpDown).TextAlign = (HorizontalAlignment)1;
		Point location3 = new Point(226, 61);
		((Control)distortionHideDBUpDown).Location = location3;
		decimal maximum2 = new decimal(new int[4] { 20, 0, 0, 0 });
		distortionHideDBUpDown.Maximum = maximum2;
		decimal minimum2 = new decimal(new int[4] { 200, 0, 0, -2147483648 });
		distortionHideDBUpDown.Minimum = minimum2;
		((Control)distortionHideDBUpDown).Name = "distortionHideDBUpDown";
		Size size3 = new Size(49, 20);
		((Control)distortionHideDBUpDown).Size = size3;
		((Control)distortionHideDBUpDown).TabIndex = 4;
		((UpDownBase)distortionHideDBUpDown).TextAlign = (HorizontalAlignment)1;
		label2.AutoSize = true;
		Point location4 = new Point(3, 63);
		((Control)label2).Location = location4;
		((Control)label2).Name = "label2";
		Size size4 = new Size(217, 13);
		((Control)label2).Size = size4;
		((Control)label2).TabIndex = 2;
		label2.Text = "Hide distortion when amplitude is below [dB]:";
		yesButton.DialogResult = (DialogResult)6;
		Point location5 = new Point(127, 88);
		((Control)yesButton).Location = location5;
		((Control)yesButton).Name = "yesButton";
		Size size5 = new Size(70, 23);
		((Control)yesButton).Size = size5;
		((Control)yesButton).TabIndex = 1;
		((ButtonBase)yesButton).Text = "&Yes";
		((ButtonBase)yesButton).UseVisualStyleBackColor = true;
		noButton.DialogResult = (DialogResult)7;
		Point location6 = new Point(203, 88);
		((Control)noButton).Location = location6;
		((Control)noButton).Name = "noButton";
		Size size6 = new Size(70, 23);
		((Control)noButton).Size = size6;
		((Control)noButton).TabIndex = 2;
		((ButtonBase)noButton).Text = "&No";
		((ButtonBase)noButton).UseVisualStyleBackColor = true;
		Point location7 = new Point(226, 7);
		((Control)maxDBUpDown).Location = location7;
		decimal maximum3 = new decimal(new int[4] { 20, 0, 0, 0 });
		maxDBUpDown.Maximum = maximum3;
		decimal minimum3 = new decimal(new int[4] { 200, 0, 0, -2147483648 });
		maxDBUpDown.Minimum = minimum3;
		((Control)maxDBUpDown).Name = "maxDBUpDown";
		Size size7 = new Size(49, 20);
		((Control)maxDBUpDown).Size = size7;
		((Control)maxDBUpDown).TabIndex = 6;
		((UpDownBase)maxDBUpDown).TextAlign = (HorizontalAlignment)1;
		label3.AutoSize = true;
		Point location8 = new Point(3, 9);
		((Control)label3).Location = location8;
		((Control)label3).Name = "label3";
		Size size8 = new Size(129, 13);
		((Control)label3).Size = size8;
		((Control)label3).TabIndex = 5;
		label3.Text = "Graph amplitude limit [dB]:";
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		Size clientSize = new Size(276, 115);
		((Form)this).ClientSize = clientSize;
		((Control)this).Controls.Add((Control)(object)maxDBUpDown);
		((Control)this).Controls.Add((Control)(object)label3);
		((Control)this).Controls.Add((Control)(object)noButton);
		((Control)this).Controls.Add((Control)(object)yesButton);
		((Control)this).Controls.Add((Control)(object)distortionHideDBUpDown);
		((Control)this).Controls.Add((Control)(object)label2);
		((Control)this).Controls.Add((Control)(object)phaseHideDBUpDown);
		((Control)this).Controls.Add((Control)(object)label1);
		((Form)this).FormBorderStyle = (FormBorderStyle)5;
		((Control)this).Name = "FormNormalizationDialog";
		((Form)this).StartPosition = (FormStartPosition)1;
		((Form)this).Text = "Change limits when changing normalization?";
		((Form)this).TopMost = true;
		((ISupportInitialize)phaseHideDBUpDown).EndInit();
		((ISupportInitialize)distortionHideDBUpDown).EndInit();
		((ISupportInitialize)maxDBUpDown).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	protected override void Dispose([MarshalAs(UnmanagedType.U1)] bool P_0)
	{
		if (P_0)
		{
			try
			{
				_007EFormNormalizationDialog();
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
