using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace HOLM;

public class FormHTMLReader : Form
{
	public WebBrowser webBrowser;

	private Container components;

	public FormHTMLReader()
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

	private void _007EFormHTMLReader()
	{
		((IDisposable)components)?.Dispose();
	}

	private void InitializeComponent()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(FormHTMLReader));
		webBrowser = new WebBrowser();
		((Control)this).SuspendLayout();
		((Control)webBrowser).Dock = (DockStyle)5;
		Point location = new Point(0, 0);
		((Control)webBrowser).Location = location;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Padding margin);
		((Padding)(ref margin))._002Ector(0);
		((Control)webBrowser).Margin = margin;
		Size minimumSize = new Size(20, 20);
		((Control)webBrowser).MinimumSize = minimumSize;
		((Control)webBrowser).Name = "webBrowser";
		Size size = new Size(692, 473);
		((Control)webBrowser).Size = size;
		((Control)webBrowser).TabIndex = 0;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		Size clientSize = new Size(692, 473);
		((Form)this).ClientSize = clientSize;
		((Control)this).Controls.Add((Control)(object)webBrowser);
		((Form)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		Size maximumSize = new Size(700, 2000);
		((Form)this).MaximumSize = maximumSize;
		Size minimumSize2 = new Size(300, 200);
		((Form)this).MinimumSize = minimumSize2;
		((Control)this).Name = "FormHTMLReader";
		((Form)this).Text = "HTMLReader";
		((Form)this).WindowState = (FormWindowState)2;
		((Control)this).ResumeLayout(false);
	}

	protected override void Dispose([MarshalAs(UnmanagedType.U1)] bool P_0)
	{
		if (P_0)
		{
			try
			{
				_007EFormHTMLReader();
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
