using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace HOLM;

public class FormResponseGui : Form
{
	public Button abortButton;

	public Label statusLabel;

	public Panel warningPanel;

	public Label warningLabel;

	private Container components;

	public FormResponseGui()
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

	private void _007EFormResponseGui()
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
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected O, but got Unknown
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Expected O, but got Unknown
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Expected O, but got Unknown
		//IL_0204: Unknown result type (might be due to invalid IL or missing references)
		//IL_0264: Unknown result type (might be due to invalid IL or missing references)
		//IL_026e: Expected O, but got Unknown
		//IL_0296: Unknown result type (might be due to invalid IL or missing references)
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(FormResponseGui));
		abortButton = new Button();
		statusLabel = new Label();
		warningPanel = new Panel();
		warningLabel = new Label();
		((Control)warningPanel).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)abortButton).Anchor = (AnchorStyles)2;
		((Control)abortButton).Cursor = Cursors.Arrow;
		((Control)abortButton).Enabled = false;
		((Control)abortButton).Font = new Font("Arial", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		Point location = new Point(213, 174);
		((Control)abortButton).Location = location;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Padding margin);
		((Padding)(ref margin))._002Ector(1);
		((Control)abortButton).Margin = margin;
		((Control)abortButton).Name = "abortButton";
		Size size = new Size(154, 23);
		((Control)abortButton).Size = size;
		((Control)abortButton).TabIndex = 3;
		((ButtonBase)abortButton).Text = "Abort";
		((ButtonBase)abortButton).UseVisualStyleBackColor = true;
		statusLabel.AutoSize = true;
		((Control)statusLabel).Font = new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		Point location2 = new Point(12, 9);
		((Control)statusLabel).Location = location2;
		((Control)statusLabel).Name = "statusLabel";
		Size size2 = new Size(43, 13);
		((Control)statusLabel).Size = size2;
		((Control)statusLabel).TabIndex = 5;
		statusLabel.Text = "Status";
		((Control)warningPanel).BackgroundImage = (Image)componentResourceManager.GetObject("warningPanel.BackgroundImage");
		((Control)warningPanel).BackgroundImageLayout = (ImageLayout)0;
		((Control)warningPanel).Controls.Add((Control)(object)warningLabel);
		Point location3 = new Point(212, 0);
		((Control)warningPanel).Location = location3;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Padding margin2);
		((Padding)(ref margin2))._002Ector(0);
		((Control)warningPanel).Margin = margin2;
		((Control)warningPanel).Name = "warningPanel";
		Size size3 = new Size(153, 170);
		((Control)warningPanel).Size = size3;
		((Control)warningPanel).TabIndex = 6;
		warningLabel.AutoSize = true;
		((Control)warningLabel).Font = new Font("Arial", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		Point location4 = new Point(2, 148);
		((Control)warningLabel).Location = location4;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Padding margin3);
		((Padding)(ref margin3))._002Ector(1);
		((Control)warningLabel).Margin = margin3;
		((Control)warningLabel).Name = "warningLabel";
		Size size4 = new Size(148, 19);
		((Control)warningLabel).Size = size4;
		((Control)warningLabel).TabIndex = 7;
		warningLabel.Text = "Protect your ears !";
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		Size clientSize = new Size(367, 198);
		((Form)this).ClientSize = clientSize;
		((Form)this).ControlBox = false;
		((Control)this).Controls.Add((Control)(object)statusLabel);
		((Control)this).Controls.Add((Control)(object)abortButton);
		((Control)this).Controls.Add((Control)(object)warningPanel);
		((Control)this).Cursor = Cursors.AppStarting;
		((Form)this).FormBorderStyle = (FormBorderStyle)5;
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Control)this).Name = "FormResponseGui";
		((Form)this).ShowIcon = false;
		((Form)this).ShowInTaskbar = false;
		((Form)this).StartPosition = (FormStartPosition)1;
		((Form)this).Text = "Active Measurement";
		((Form)this).TopMost = true;
		((Control)warningPanel).ResumeLayout(false);
		((Control)warningPanel).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	protected override void Dispose([MarshalAs(UnmanagedType.U1)] bool P_0)
	{
		if (P_0)
		{
			try
			{
				_007EFormResponseGui();
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
