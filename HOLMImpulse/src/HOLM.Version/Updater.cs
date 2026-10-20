using System;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using HOLM.Network;
using std;

namespace HOLM.Version;

internal class Updater : IDisposable
{
	private EventHandler _003Cbacking_store_003EUpdateStarted;

	public Dialog dialog;

	private Downloader downloader;

	private string rootUrl;

	private string appName;

	[SpecialName]
	public event EventHandler UpdateStarted
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			_003Cbacking_store_003EUpdateStarted = (EventHandler)Delegate.Combine(_003Cbacking_store_003EUpdateStarted, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			_003Cbacking_store_003EUpdateStarted = (EventHandler)Delegate.Remove(_003Cbacking_store_003EUpdateStarted, value);
		}
	}

	public Updater(string rootUrlIn, string appNameIn, Dialog dialogIn)
	{
		rootUrl = rootUrlIn;
		appName = appNameIn;
		dialog = dialogIn;
		downloader = null;
	}

	private void _007EUpdater()
	{
		((IDisposable)downloader)?.Dispose();
	}

	public unsafe void CheckForUpdate([MarshalAs(UnmanagedType.U1)] bool fShowError, [MarshalAs(UnmanagedType.U1)] bool fShowUpToDate)
	{
		int num = global::_003CModule_003E.HOLM_002EVersion_002EWWWVersion(rootUrl + "latest.php");
		System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj);
		global::_003CModule_003E.std_002Ebasic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D(&obj, 3, 1);
		try
		{
			global::_003CModule_003E.std_002Eoperator_003C_003C_003Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_0020_003E(global::_003CModule_003E.std_002Ebasic_ostream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E_002E_003C_003C(global::_003CModule_003E.std_002Eoperator_003C_003C_003Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_0020_003E(global::_003CModule_003E.std_002Eoperator_003C_003C_003Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_0020_003E((basic_ostream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 8)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref global::_003CModule_003E._003F_003F_C_0040_08ECDPJEFA_0040INFO_003F5_003F5_003F5_003F5_003F_0024AA_0040)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref global::_003CModule_003E._003F_003F_C_0040_0BK_0040KOANBOKG_0040Updater_003F3_003F3CheckForUpdate_003F3_003F5_003F_0024AA_0040)), num), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref global::_003CModule_003E._003F_003F_C_0040_01EEMJAFIK_0040_003F6_003F_0024AA_0040));
			System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj2);
			basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* ptr = global::_003CModule_003E.std_002Ebasic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002Estr(&obj, &obj2);
			try
			{
				global::_003CModule_003E.HOLM_002ELogging_002EHolmLogger_002ELogText(ptr);
			}
			catch
			{
				//try-fault
				global::_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), &obj2);
				throw;
			}
			global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D(&obj2);
		}
		catch
		{
			//try-fault
			global::_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&global::_003CModule_003E.std_002Ebasic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E__vbaseDtor), &obj);
			throw;
		}
		global::_003CModule_003E.std_002Ebasic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E__vbaseDtor(&obj);
		if (num > 0)
		{
			string text = string.Concat(string.Concat(appName + "-", global::_003CModule_003E.HOLM_002EVersion_002EVersionString(num)), ".msi");
			string text2 = rootUrl + text;
			if (num > global::_003CModule_003E.HOLM_002EVersion_002EApplicationVersion())
			{
				string text3 = Application.ProductVersion.ToString().Replace(", ", ".");
				string text4 = "\n";
				string text5 = appName;
				string question = string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(text5 + "\n\n", "There is a new version of "), text5), " available!\n\n"), "Current Version: "), text3), "\n"), "Online Version:  "), global::_003CModule_003E.HOLM_002EVersion_002EVersionString(num)), text4), "\nWhat's new in this release (ChangeLog):\n"), rootUrl), "ChangeLog.txt"), text4), "File to be downloaded:\n"), text2), "\n\n"), "Update the application?");
				if (dialog.ShowQuestionYesNoHolm(question))
				{
					downloader = new Downloader();
					string text6 = Path.GetTempPath() + text;
					downloader.Download(text2, text6);
					if (downloader.WaitForDownload())
					{
						global::_003CModule_003E.HOLM_002EMiscHelper_002EOpenFileWithProcess(text6);
						raise_UpdateStarted(this, null);
						dialog.mainForm.Close();
						((IDisposable)dialog.mainForm)?.Dispose();
					}
				}
			}
			else if (fShowUpToDate)
			{
				string text7 = "\n\n";
				string info = string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(appName + "\n\nCurrent Version: ", global::_003CModule_003E.HOLM_002EVersion_002EApplicationVersionString()), "\n"), "Online Version:  "), global::_003CModule_003E.HOLM_002EVersion_002EVersionString(num)), "\n"), "\nChangeLog: "), rootUrl), "ChangeLog.txt"), text7), "File: "), text2), text7), "The application is already updated.");
				dialog.ShowInfoHolm(info);
			}
		}
		else if (fShowError)
		{
			dialog.ShowInfoHolm(string.Concat("Could not retrieve information online:\n" + rootUrl, "latest.php"));
		}
	}

	[SpecialName]
	protected void raise_UpdateStarted(object value0, EventArgs value1)
	{
		_003Cbacking_store_003EUpdateStarted?.Invoke(value0, value1);
	}

	public void Action_CheckForUpdate(object sender, EventArgs e)
	{
		CheckForUpdate(fShowError: true, fShowUpToDate: true);
	}

	public void Action_ShowUserGuide(object sender, EventArgs e)
	{
		string text = rootUrl + "latestuserguide.php";
		string text2 = string.Concat(rootUrl + appName, "UserGuide.pdf");
		string path = string.Concat(string.Concat(Directory.GetParent(Application.UserAppDataPath).FullName + "\\", appName), "UserGuide.txt");
		string path2 = string.Concat(string.Concat(Directory.GetParent(Application.UserAppDataPath).FullName + "\\", appName), "UserGuide.pdf");
		int num = global::_003CModule_003E.HOLM_002EVersion_002EWWWVersion(text);
		int num2 = global::_003CModule_003E.HOLM_002EVersion_002EFileVersion(path);
		if (!File.Exists(path2))
		{
			num2 = -1;
		}
		if (num < 0 && num2 < 0)
		{
			string text3 = appName;
			string text4 = "\n";
			dialog.ShowInfoHolm(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat("The " + text3, "UserGuide is currently not present locally\n"), "You have no connection to the files: \n"), text), text4), text2), text4), "Sorry, but the "), text3), " User Guide is not available locally or online..."));
		}
		else if (num2 >= num)
		{
			ShowLocalUserGuide();
		}
		else
		{
			if (num <= 0)
			{
				return;
			}
			if (num2 < 0)
			{
				if (dialog.ShowQuestionYesNoHolm(string.Concat(string.Concat("The " + appName, "UserGuide is currently not present locally\n"), "Download file from www.holmacoustics.com now?\n")))
				{
					DownloadUserGuideAndShow();
				}
			}
			else if (num2 > 0)
			{
				if (dialog.ShowQuestionYesNoHolm(string.Concat(string.Concat("The " + appName, "UserGuide exists in a newer version\n"), "Download file from www.holmacoustics.com now?\n")))
				{
					DownloadUserGuideAndShow();
				}
				else
				{
					ShowLocalUserGuide();
				}
			}
		}
	}

	public unsafe void Action_UserGuideDownloaded(object sender, EventArgs e)
	{
		try
		{
			string address = rootUrl + "latestuserguide.php";
			string fileName = string.Concat(string.Concat(global::_003CModule_003E.HOLM_002EMiscHelper_002EGetAppDataDirectory() + "\\", appName), "UserGuide.txt");
			WebClient webClient = new WebClient();
			webClient.DownloadFile(address, fileName);
			WebClient webClient2 = webClient;
			IDisposable disposable = webClient;
			((IDisposable)webClient)?.Dispose();
			Action_ShowUserGuide(this, null);
		}
		catch (Exception ex)
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj);
			global::_003CModule_003E.std_002Ebasic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D(&obj, 3, 1);
			try
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj2);
				basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* ptr = global::_003CModule_003E.HOLM_002EMiscHelper_002EStringToStd(&obj2, ex.ToString());
				try
				{
					global::_003CModule_003E.std_002Eoperator_003C_003C_003Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_0020_003E(global::_003CModule_003E.std_002Eoperator_003C_003C_003Cchar_002Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_002Cclass_0020std_003A_003Aallocator_003Cchar_003E_0020_003E(global::_003CModule_003E.std_002Eoperator_003C_003C_003Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_0020_003E(global::_003CModule_003E.std_002Eoperator_003C_003C_003Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_0020_003E(global::_003CModule_003E.std_002Eoperator_003C_003C_003Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_0020_003E((basic_ostream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 8)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref global::_003CModule_003E._003F_003F_C_0040_08KFJDDMMO_0040WARNING_003F5_003F_0024AA_0040)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref global::_003CModule_003E._003F_003F_C_0040_0CE_0040GGJENNFG_0040Updater_003F3_003F3Action_UserGuideDownloa_0040)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref global::_003CModule_003E._003F_003F_C_0040_0BE_0040MAEGOEPB_0040_003F5System_003F3_003F3Exception_003F3_003F_0024AA_0040)), ptr), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref global::_003CModule_003E._003F_003F_C_0040_01EEMJAFIK_0040_003F6_003F_0024AA_0040));
				}
				catch
				{
					//try-fault
					global::_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), &obj2);
					throw;
				}
				global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D(&obj2);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj3);
				basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* ptr2 = global::_003CModule_003E.std_002Ebasic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002Estr(&obj, &obj3);
				try
				{
					global::_003CModule_003E.HOLM_002ELogging_002EHolmLogger_002ELogText(ptr2);
				}
				catch
				{
					//try-fault
					global::_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), &obj3);
					throw;
				}
				global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D(&obj3);
			}
			catch
			{
				//try-fault
				global::_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&global::_003CModule_003E.std_002Ebasic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E__vbaseDtor), &obj);
				throw;
			}
			global::_003CModule_003E.std_002Ebasic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E__vbaseDtor(&obj);
		}
	}

	private void ShowLocalUserGuide()
	{
		global::_003CModule_003E.HOLM_002EMiscHelper_002EOpenFileWithProcess(string.Concat(string.Concat(Directory.GetParent(Application.UserAppDataPath).FullName + "\\", appName), "UserGuide.pdf"));
	}

	private void DownloadUserGuideAndShow()
	{
		string text = rootUrl + "latestuserguide.php";
		string text2 = string.Concat(rootUrl + appName, "UserGuide.pdf");
		string.Concat(string.Concat(Directory.GetParent(Application.UserAppDataPath).FullName + "\\", appName), "UserGuide.txt");
		string dest = string.Concat(string.Concat(Directory.GetParent(Application.UserAppDataPath).FullName + "\\", appName), "UserGuide.pdf");
		try
		{
			Downloader downloader = new Downloader();
			downloader.Download(text2, dest);
			downloader.Title = string.Concat("Downloading " + appName, " UserGuide...");
			downloader.DownloadCompletedEvent += Action_UserGuideDownloaded;
		}
		catch (Exception ex)
		{
			string text3 = "\n";
			dialog.ShowInfo(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat("Failed to download files:\n" + text, text3), text2), text3), "Details:\n"), ex.ToString()));
		}
	}

	protected virtual void Dispose([MarshalAs(UnmanagedType.U1)] bool P_0)
	{
		if (P_0)
		{
			((IDisposable)downloader)?.Dispose();
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
