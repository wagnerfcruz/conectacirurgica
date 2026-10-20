using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace HOLM;

public class FormUploader : Form
{
	private Label label1;

	private TextBox textBox1;

	private Label label2;

	public TextBox sourceTextBox;

	public TextBox destTextBox;

	private Label label3;

	public ProgressBar progressBar;

	public Button cancelButton;

	private Container components;

	public FormUploader()
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

	private void _007EFormUploader()
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
		//IL_045a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0464: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(FormUploader));
		label1 = new Label();
		textBox1 = new TextBox();
		label2 = new Label();
		sourceTextBox = new TextBox();
		destTextBox = new TextBox();
		label3 = new Label();
		progressBar = new ProgressBar();
		cancelButton = new Button();
		((Control)this).SuspendLayout();
		Point location = new Point(0, 0);
		((Control)label1).Location = location;
		((Control)label1).Name = "label1";
		Size size = new Size(100, 23);
		((Control)label1).Size = size;
		((Control)label1).TabIndex = 0;
		Point location2 = new Point(0, 0);
		((Control)textBox1).Location = location2;
		((Control)textBox1).Name = "textBox1";
		Size size2 = new Size(100, 20);
		((Control)textBox1).Size = size2;
		((Control)textBox1).TabIndex = 0;
		label2.AutoSize = true;
		Point location3 = new Point(2, 9);
		((Control)label2).Location = location3;
		((Control)label2).Name = "label2";
		Size size3 = new Size(44, 13);
		((Control)label2).Size = size3;
		((Control)label2).TabIndex = 0;
		label2.Text = "Source:";
		((Control)sourceTextBox).Anchor = (AnchorStyles)13;
		Color window = SystemColors.Window;
		((TextBoxBase)sourceTextBox).BackColor = window;
		Point location4 = new Point(62, 6);
		((Control)sourceTextBox).Location = location4;
		((Control)sourceTextBox).Name = "sourceTextBox";
		((TextBoxBase)sourceTextBox).ReadOnly = true;
		Size size4 = new Size(426, 20);
		((Control)sourceTextBox).Size = size4;
		((Control)sourceTextBox).TabIndex = 1;
		((Control)destTextBox).Anchor = (AnchorStyles)13;
		Color window2 = SystemColors.Window;
		((TextBoxBase)destTextBox).BackColor = window2;
		Point location5 = new Point(62, 32);
		((Control)destTextBox).Location = location5;
		((Control)destTextBox).Name = "destTextBox";
		((TextBoxBase)destTextBox).ReadOnly = true;
		Size size5 = new Size(426, 20);
		((Control)destTextBox).Size = size5;
		((Control)destTextBox).TabIndex = 3;
		label3.AutoSize = true;
		Point location6 = new Point(2, 36);
		((Control)label3).Location = location6;
		((Control)label3).Name = "label3";
		Size size6 = new Size(63, 13);
		((Control)label3).Size = size6;
		((Control)label3).TabIndex = 1;
		label3.Text = "Destination:";
		Point location7 = new Point(5, 58);
		((Control)progressBar).Location = location7;
		((Control)progressBar).Name = "progressBar";
		Size size7 = new Size(400, 23);
		((Control)progressBar).Size = size7;
		progressBar.Step = 1;
		progressBar.Style = (ProgressBarStyle)1;
		((Control)progressBar).TabIndex = 4;
		cancelButton.DialogResult = (DialogResult)2;
		Point location8 = new Point(411, 58);
		((Control)cancelButton).Location = location8;
		((Control)cancelButton).Name = "cancelButton";
		Size size8 = new Size(50, 23);
		((Control)cancelButton).Size = size8;
		((Control)cancelButton).TabIndex = 0;
		((ButtonBase)cancelButton).Text = "&Cancel";
		((ButtonBase)cancelButton).UseVisualStyleBackColor = true;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		Size clientSize = new Size(492, 86);
		((Form)this).ClientSize = clientSize;
		((Form)this).ControlBox = false;
		((Control)this).Controls.Add((Control)(object)cancelButton);
		((Control)this).Controls.Add((Control)(object)progressBar);
		((Control)this).Controls.Add((Control)(object)destTextBox);
		((Control)this).Controls.Add((Control)(object)label3);
		((Control)this).Controls.Add((Control)(object)sourceTextBox);
		((Control)this).Controls.Add((Control)(object)label2);
		((Form)this).FormBorderStyle = (FormBorderStyle)6;
		((Form)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		Size maximumSize = new Size(800, 110);
		((Form)this).MaximumSize = maximumSize;
		Size minimumSize = new Size(300, 110);
		((Form)this).MinimumSize = minimumSize;
		((Control)this).Name = "FormUploader";
		((Form)this).StartPosition = (FormStartPosition)4;
		((Form)this).Text = "Uploading";
		((Form)this).TopMost = true;
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	protected override void Dispose([MarshalAs(UnmanagedType.U1)] bool P_0)
	{
		if (P_0)
		{
			try
			{
				_007EFormUploader();
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
