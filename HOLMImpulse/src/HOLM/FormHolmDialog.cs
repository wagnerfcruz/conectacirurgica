using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace HOLM;

public class FormHolmDialog : Form
{
	public Button cancelButton;

	public Button okButton;

	public GroupBox infoGroupBox;

	public RichTextBox textBox;

	private Container components;

	public FormHolmDialog()
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

	private void _007EFormHolmDialog()
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
		//IL_0212: Unknown result type (might be due to invalid IL or missing references)
		//IL_0278: Unknown result type (might be due to invalid IL or missing references)
		//IL_0282: Expected O, but got Unknown
		cancelButton = new Button();
		okButton = new Button();
		infoGroupBox = new GroupBox();
		textBox = new RichTextBox();
		((Control)infoGroupBox).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)cancelButton).Anchor = (AnchorStyles)10;
		cancelButton.DialogResult = (DialogResult)2;
		Point location = new Point(142, 60);
		((Control)cancelButton).Location = location;
		((Control)cancelButton).Name = "cancelButton";
		Size size = new Size(75, 23);
		((Control)cancelButton).Size = size;
		((Control)cancelButton).TabIndex = 2;
		((ButtonBase)cancelButton).Text = "&Cancel";
		((ButtonBase)cancelButton).UseVisualStyleBackColor = true;
		((Control)okButton).Anchor = (AnchorStyles)10;
		okButton.DialogResult = (DialogResult)1;
		Point location2 = new Point(61, 60);
		((Control)okButton).Location = location2;
		((Control)okButton).Name = "okButton";
		Size size2 = new Size(75, 23);
		((Control)okButton).Size = size2;
		((Control)okButton).TabIndex = 0;
		((ButtonBase)okButton).Text = "&Ok";
		((ButtonBase)okButton).UseVisualStyleBackColor = true;
		((Control)infoGroupBox).Anchor = (AnchorStyles)15;
		((Control)infoGroupBox).Controls.Add((Control)(object)textBox);
		Point location3 = new Point(2, 4);
		((Control)infoGroupBox).Location = location3;
		((Control)infoGroupBox).Name = "infoGroupBox";
		Size size3 = new Size(247, 50);
		((Control)infoGroupBox).Size = size3;
		((Control)infoGroupBox).TabIndex = 8;
		infoGroupBox.TabStop = false;
		Color control = SystemColors.Control;
		((TextBoxBase)textBox).BackColor = control;
		((TextBoxBase)textBox).BorderStyle = (BorderStyle)0;
		((Control)textBox).Dock = (DockStyle)5;
		Point location4 = new Point(3, 16);
		((Control)textBox).Location = location4;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Padding margin);
		((Padding)(ref margin))._002Ector(3, 0, 3, 0);
		((Control)textBox).Margin = margin;
		((Control)textBox).Name = "textBox";
		Size size4 = new Size(241, 31);
		((Control)textBox).Size = size4;
		((Control)textBox).TabIndex = 0;
		((Control)textBox).TabStop = false;
		textBox.Text = "Information1";
		textBox.LinkClicked += new LinkClickedEventHandler(textBox_LinkClicked);
		((Form)this).AcceptButton = (IButtonControl)(object)okButton;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).CancelButton = (IButtonControl)(object)cancelButton;
		Size clientSize = new Size(252, 86);
		((Form)this).ClientSize = clientSize;
		((Control)this).Controls.Add((Control)(object)infoGroupBox);
		((Control)this).Controls.Add((Control)(object)okButton);
		((Control)this).Controls.Add((Control)(object)cancelButton);
		((Control)this).Cursor = Cursors.Default;
		((Form)this).FormBorderStyle = (FormBorderStyle)6;
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		Size minimumSize = new Size(260, 110);
		((Form)this).MinimumSize = minimumSize;
		((Control)this).Name = "FormHolmDialog";
		((Form)this).ShowIcon = false;
		((Form)this).ShowInTaskbar = false;
		((Form)this).StartPosition = (FormStartPosition)4;
		((Form)this).Text = "HOLM Dialog";
		((Form)this).TopMost = true;
		((Control)infoGroupBox).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
	}

	public void ResizeFromText()
	{
		int num = ((TextBoxBase)textBox).Lines.Length;
		int num2 = textBox.Font.Height + 2;
		if (num < 30)
		{
			if (num > 1)
			{
				((Control)this).Height = num2 * num + 100;
			}
			else
			{
				((Control)this).Height = 100;
			}
		}
		else
		{
			((Control)this).Height = num2 * 30 + 100;
		}
		int num3 = 0;
		int num4 = 0;
		if (0 >= num)
		{
			return;
		}
		do
		{
			if (((TextBoxBase)textBox).Lines[num4].Length > num3)
			{
				num3 = ((TextBoxBase)textBox).Lines[num4].Length;
			}
			num4++;
		}
		while (num4 < num);
		if (num3 > 40)
		{
			if (num3 < 80)
			{
				((Control)this).Width = ((Control)this).Width + (num3 - 40) * 6;
				return;
			}
		}
		else if (num3 < 80)
		{
			return;
		}
		((Control)this).Width = ((Control)this).Width + 240;
	}

	private void textBox_LinkClicked(object sender, LinkClickedEventArgs e)
	{
		((IDisposable)Process.Start(new ProcessStartInfo(e.LinkText)))?.Dispose();
	}

	protected override void Dispose([MarshalAs(UnmanagedType.U1)] bool P_0)
	{
		if (P_0)
		{
			try
			{
				_007EFormHolmDialog();
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
