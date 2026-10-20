using System;
using System.ComponentModel;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace HOLM.Network;

internal class Downloader : IDisposable
{
	private EventHandler _003Cbacking_store_003EDownloadCompletedEvent;

	public string Title;

	private bool fDownloading;

	private bool fSuccess;

	private string source;

	private string dest;

	private FormDownloader form;

	private WebClient wc;

	[SpecialName]
	public event EventHandler DownloadCompletedEvent
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			_003Cbacking_store_003EDownloadCompletedEvent = (EventHandler)Delegate.Combine(_003Cbacking_store_003EDownloadCompletedEvent, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			_003Cbacking_store_003EDownloadCompletedEvent = (EventHandler)Delegate.Remove(_003Cbacking_store_003EDownloadCompletedEvent, value);
		}
	}

	public Downloader()
	{
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		form = new FormDownloader();
		wc = new WebClient();
		((Control)form.cancelButton).Click += Action_Cancel;
		((Form)form).FormClosing += new FormClosingEventHandler(Action_Closing);
		wc.DownloadProgressChanged += Action_UpdateProgress;
		wc.DownloadFileCompleted += Action_Completed;
		fDownloading = false;
		string text = (Title = "Downloading...");
		((Form)form).Text = text;
	}

	private void _007EDownloader()
	{
		if (fDownloading)
		{
			do
			{
				global::_003CModule_003E.Sleep(100u);
			}
			while (fDownloading);
		}
		((IDisposable)wc)?.Dispose();
		((IDisposable)form)?.Dispose();
	}

	public void Download(string source, string dest)
	{
		this.source = source;
		this.dest = dest;
		form.sourceTextBox.Text = source;
		form.destTextBox.Text = this.dest;
		form.progressBar.Value = 0;
		fSuccess = false;
		fDownloading = true;
		((Control)form).Show();
		wc.DownloadFileAsync(new Uri(this.source), this.dest);
	}

	[SpecialName]
	protected void raise_DownloadCompletedEvent(object value0, EventArgs value1)
	{
		_003Cbacking_store_003EDownloadCompletedEvent?.Invoke(value0, value1);
	}

	[return: MarshalAs(UnmanagedType.U1)]
	public bool WaitForDownload()
	{
		if (fDownloading)
		{
			do
			{
				global::_003CModule_003E.Sleep(100u);
				Application.DoEvents();
			}
			while (fDownloading);
		}
		return fSuccess;
	}

	private void Action_Cancel(object sender, EventArgs e)
	{
		if (fDownloading)
		{
			fDownloading = false;
			wc.CancelAsync();
			fSuccess = false;
			WebClient webClient = wc;
			if (webClient != null)
			{
				((IDisposable)webClient).Dispose();
				wc = null;
			}
			global::_003CModule_003E.Sleep(100u);
			File.Delete(dest);
		}
		((IDisposable)this)?.Dispose();
	}

	private void Action_Closing(object sender, FormClosingEventArgs e)
	{
		Action_Cancel(this, null);
	}

	private void Action_Completed(object sender, AsyncCompletedEventArgs e)
	{
		fDownloading = false;
		if (!e.Cancelled && e.Error == null)
		{
			fDownloading = false;
			fSuccess = true;
			_003Cbacking_store_003EDownloadCompletedEvent?.Invoke(this, null);
			((Form)form).Close();
			((IDisposable)this)?.Dispose();
		}
	}

	private void Action_UpdateProgress(object sender, DownloadProgressChangedEventArgs e)
	{
		int progressPercentage = e.ProgressPercentage;
		((Form)form).Text = string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(Title + "  ", global::_003CModule_003E.HOLM_002ENetwork_002EIntBytesSizeToString((int)e.BytesReceived)), " / "), global::_003CModule_003E.HOLM_002ENetwork_002EIntBytesSizeToString((int)e.TotalBytesToReceive)), " = "), progressPercentage.ToString()), "%");
		form.progressBar.Value = e.ProgressPercentage;
	}

	protected virtual void Dispose([MarshalAs(UnmanagedType.U1)] bool P_0)
	{
		if (P_0)
		{
			_007EDownloader();
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
