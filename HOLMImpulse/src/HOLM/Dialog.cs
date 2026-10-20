using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace HOLM;

internal class Dialog : IDisposable
{
	public Form mainForm;

	private string htmlurl;

	private string appName;

	private FormHTMLReader formHTMLReader;

	public Dialog(string appNameIn)
	{
		appName = appNameIn;
		mainForm = null;
		formHTMLReader = null;
	}

	public Dialog(string appNameIn, Form mainFormIn)
	{
		appName = appNameIn;
		mainForm = mainFormIn;
		formHTMLReader = null;
		htmlurl = "";
	}

	private void _007EDialog()
	{
		((IDisposable)formHTMLReader)?.Dispose();
	}

	public void ShowInfo(string info)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show(info, appName + " Information", (MessageBoxButtons)0, (MessageBoxIcon)64);
	}

	[return: MarshalAs(UnmanagedType.U1)]
	public bool ShowQuestionOKCancel(string question)
	{
		return ShowQuestionOKCancelHolm(question);
	}

	[return: MarshalAs(UnmanagedType.U1)]
	public bool ShowQuestionYesNo(string question)
	{
		return ShowQuestionYesNoHolm(question);
	}

	public void ShowInfoHolm(string info)
	{
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		FormHolmDialog formHolmDialog = new FormHolmDialog();
		((Form)formHolmDialog).Text = appName + " Information";
		formHolmDialog.textBox.Text = info;
		formHolmDialog.ResizeFromText();
		((ButtonBase)formHolmDialog.cancelButton).Text = "Ok";
		((Control)formHolmDialog.okButton).Visible = false;
		Form val = mainForm;
		if (val != null)
		{
			((Form)formHolmDialog).ShowDialog((IWin32Window)(object)val);
		}
		else
		{
			((Form)formHolmDialog).ShowDialog();
		}
		((IDisposable)formHolmDialog)?.Dispose();
	}

	[return: MarshalAs(UnmanagedType.U1)]
	public bool ShowQuestionOKCancelHolm(string question)
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		FormHolmDialog formHolmDialog = new FormHolmDialog();
		((Form)formHolmDialog).Text = appName + " Question";
		formHolmDialog.textBox.Text = question;
		formHolmDialog.ResizeFromText();
		Form val = mainForm;
		DialogResult val2 = ((val == null) ? ((Form)formHolmDialog).ShowDialog() : ((Form)formHolmDialog).ShowDialog((IWin32Window)(object)val));
		((IDisposable)formHolmDialog)?.Dispose();
		return (int)val2 == 1;
	}

	[return: MarshalAs(UnmanagedType.U1)]
	public bool ShowQuestionYesNoHolm(string question)
	{
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		FormHolmDialog formHolmDialog = new FormHolmDialog();
		((Form)formHolmDialog).Text = appName + " Question";
		formHolmDialog.textBox.Text = question;
		formHolmDialog.ResizeFromText();
		((ButtonBase)formHolmDialog.okButton).Text = "&Yes";
		((ButtonBase)formHolmDialog.cancelButton).Text = "No";
		Form val = mainForm;
		DialogResult val2 = ((val == null) ? ((Form)formHolmDialog).ShowDialog() : ((Form)formHolmDialog).ShowDialog((IWin32Window)(object)val));
		((IDisposable)formHolmDialog)?.Dispose();
		return (int)val2 == 1;
	}

	[return: MarshalAs(UnmanagedType.U1)]
	public bool ShowWarningOKCancel(string question)
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Invalid comparison between I4 and Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Invalid comparison between I4 and Unknown
		if (mainForm != null)
		{
			return 1 == (int)MessageBox.Show((IWin32Window)(object)mainForm, question, appName + " Warning", (MessageBoxButtons)1, (MessageBoxIcon)48);
		}
		return 1 == (int)MessageBox.Show(question, appName + " Warning", (MessageBoxButtons)1, (MessageBoxIcon)48);
	}

	public void ShowWarning(string warning)
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		if (mainForm != null)
		{
			MessageBox.Show((IWin32Window)(object)mainForm, warning, appName + " Warning", (MessageBoxButtons)0, (MessageBoxIcon)48);
		}
		else
		{
			MessageBox.Show(warning, appName + " Warning", (MessageBoxButtons)0, (MessageBoxIcon)48);
		}
	}

	public void HtmlReaderShow(string url)
	{
		HtmlReaderSetUrl(url);
		HtmlReaderShow();
	}

	public void HtmlReaderShow()
	{
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		if (formHTMLReader == null)
		{
			formHTMLReader = new FormHTMLReader();
			((Form)formHTMLReader).Text = appName + " Info";
			((Form)formHTMLReader).FormClosing += new FormClosingEventHandler(Action_HTMLReaderClosing);
			formHTMLReader.webBrowser.Navigate(htmlurl);
		}
		((Control)formHTMLReader).Show();
	}

	public void HtmlReaderHide()
	{
		FormHTMLReader formHTMLReader = this.formHTMLReader;
		if (formHTMLReader != null)
		{
			((Control)formHTMLReader).Hide();
		}
	}

	public void HtmlReaderSetUrl(string url)
	{
		if (htmlurl != url)
		{
			htmlurl = url;
			FormHTMLReader formHTMLReader = this.formHTMLReader;
			if (formHTMLReader != null)
			{
				formHTMLReader.webBrowser.Navigate(url);
			}
		}
	}

	public void HtmlReaderToggle()
	{
		FormHTMLReader formHTMLReader = this.formHTMLReader;
		if (formHTMLReader != null && ((Control)formHTMLReader).Visible)
		{
			formHTMLReader = this.formHTMLReader;
			if (formHTMLReader != null)
			{
				((Control)formHTMLReader).Hide();
			}
		}
		else
		{
			HtmlReaderShow();
		}
	}

	private void Action_HTMLReaderClosing(object sender, FormClosingEventArgs e)
	{
		((CancelEventArgs)(object)e).Cancel = true;
		FormHTMLReader formHTMLReader = this.formHTMLReader;
		if (formHTMLReader != null)
		{
			((Control)formHTMLReader).Hide();
		}
	}

	protected virtual void Dispose([MarshalAs(UnmanagedType.U1)] bool P_0)
	{
		if (P_0)
		{
			((IDisposable)formHTMLReader)?.Dispose();
		}
		else
		{
			base.Finalize();
		}
	}

	public virtual sealed void Dispose()
	{
		Dispose(true);
		GC.SuppressFinalize(this);
	}
}
