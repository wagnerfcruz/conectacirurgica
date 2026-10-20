using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace HOLM.HOLMImpulse;

public class FormSplashScreen : Form
{
	public Label versionLabel;

	public Label statusLabel;

	private Container components;

	public FormSplashScreen()
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

	private void _007EFormSplashScreen()
	{
		((IDisposable)components)?.Dispose();
	}

	private void InitializeComponent()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Expected O, but got Unknown
		//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c7: Expected O, but got Unknown
		//IL_022d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0237: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(FormSplashScreen));
		versionLabel = new Label();
		statusLabel = new Label();
		((Control)this).SuspendLayout();
		versionLabel.AutoSize = true;
		Color transparent = Color.Transparent;
		((Control)versionLabel).BackColor = transparent;
		((Control)versionLabel).Font = new Font("Arial", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		Color black = Color.Black;
		((Control)versionLabel).ForeColor = black;
		Point location = new Point(12, 171);
		((Control)versionLabel).Location = location;
		((Control)versionLabel).Name = "versionLabel";
		Size size = new Size(255, 19);
		((Control)versionLabel).Size = size;
		((Control)versionLabel).TabIndex = 1;
		versionLabel.Text = "HOLMImpulse-vx.y.z.w loading...";
		((Control)versionLabel).UseWaitCursor = true;
		statusLabel.AutoSize = true;
		Color transparent2 = Color.Transparent;
		((Control)statusLabel).BackColor = transparent2;
		((Control)statusLabel).Font = new Font("Arial", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		Color black2 = Color.Black;
		((Control)statusLabel).ForeColor = black2;
		Point location2 = new Point(13, 200);
		((Control)statusLabel).Location = location2;
		((Control)statusLabel).Name = "statusLabel";
		Size size2 = new Size(130, 16);
		((Control)statusLabel).Size = size2;
		((Control)statusLabel).TabIndex = 2;
		statusLabel.Text = "Loading configuration";
		((Control)statusLabel).UseWaitCursor = true;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)0;
		((Control)this).BackgroundImage = (Image)componentResourceManager.GetObject("$this.BackgroundImage");
		((Control)this).BackgroundImageLayout = (ImageLayout)0;
		Size clientSize = new Size(500, 250);
		((Form)this).ClientSize = clientSize;
		((Form)this).ControlBox = false;
		((Control)this).Controls.Add((Control)(object)statusLabel);
		((Control)this).Controls.Add((Control)(object)versionLabel);
		((Control)this).Cursor = Cursors.WaitCursor;
		((Form)this).FormBorderStyle = (FormBorderStyle)0;
		((Form)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		((Form)this).MaximizeBox = false;
		Size maximumSize = new Size(500, 250);
		((Form)this).MaximumSize = maximumSize;
		Size minimumSize = new Size(500, 250);
		((Form)this).MinimumSize = minimumSize;
		((Control)this).Name = "FormSplashScreen";
		((Form)this).ShowIcon = false;
		((Form)this).ShowInTaskbar = false;
		((Form)this).SizeGripStyle = (SizeGripStyle)2;
		((Form)this).StartPosition = (FormStartPosition)1;
		((Form)this).Text = "FormSplashScreen";
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
				_007EFormSplashScreen();
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
