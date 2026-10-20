using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using HOLM.Measure;

namespace HOLM.MeasureGraphics;

internal class ResponseGui : IDisposable
{
	public static FormResponseGui form;

	private unsafe static Response* response;

	public unsafe ResponseGui(Form mainForm, Response* responseIn, [MarshalAs(UnmanagedType.U1)] bool fShow, [MarshalAs(UnmanagedType.U1)] bool fWarning)
	{
		PreMeasure(mainForm, responseIn, fShow, fWarning);
	}

	public unsafe ResponseGui(Form mainForm, Response* responseIn)
	{
		PreMeasure(mainForm, responseIn, fShow: true, fWarning: true);
	}

	public unsafe ResponseGui()
	{
		form = null;
		response = null;
	}

	private void _007EResponseGui()
	{
		PostMeasure();
	}

	public unsafe static void PreMeasure(Form mainForm, Response* responseIn, [MarshalAs(UnmanagedType.U1)] bool fShow, [MarshalAs(UnmanagedType.U1)] bool fWarning)
	{
		response = responseIn;
		form = new FormResponseGui();
		form.statusLabel.Text = "";
		((Form)form).Text = "Measurement is Active";
		((Control)form.abortButton).Click += Action_Abort;
		if (fShow && form != null)
		{
			((Control)form.warningPanel).Visible = fWarning;
			((Form)form).Show((IWin32Window)(object)mainForm);
		}
		*(int*)((byte*)response + 44) = (int)global::_003CModule_003E.__unep_0040_003FResponseGuiCallback_0040MeasureGraphics_0040HOLM_0040_0040_0024_0024FYAXABV_003F_0024basic_string_0040DU_003F_0024char_traits_0040D_0040std_0040_0040V_003F_0024allocator_0040D_00402_0040_0040std_0040_0040_0040Z;
		global::_003CModule_003E.HOLM_002EMeasureGraphics_002E_003FA0x42c1a45b_002EfResponseGuiCallbackReset = true;
		global::_003CModule_003E.HOLM_002EMeasureGraphics_002E_003FA0x42c1a45b_002EfResponseGuiCallbackDoEvents = true;
	}

	public unsafe static void PreMeasure(Form mainForm, Response* responseIn)
	{
		PreMeasure(mainForm, responseIn, fShow: true, fWarning: true);
	}

	public unsafe static void PostMeasure()
	{
		if (response != null)
		{
			*(int*)((byte*)response + 44) = 0;
			response = null;
		}
		if (form != null)
		{
			((Form)form).Close();
			form = null;
		}
	}

	public static void Show(Form mainForm, [MarshalAs(UnmanagedType.U1)] bool fWarning)
	{
		if (form != null)
		{
			((Control)form.warningPanel).Visible = fWarning;
			((Form)form).Show((IWin32Window)(object)mainForm);
		}
	}

	public static void Reset(string text, [MarshalAs(UnmanagedType.U1)] bool fWarning)
	{
		global::_003CModule_003E.HOLM_002EMeasureGraphics_002E_003FA0x42c1a45b_002EfResponseGuiCallbackReset = false;
		((Form)form).Text = text + " - Measurement is Active";
		form.statusLabel.Text = "";
		((Control)form.warningPanel).Visible = fWarning;
	}

	public static void SetDoEvents([MarshalAs(UnmanagedType.U1)] bool flag)
	{
		if (form != null)
		{
			((Control)form.abortButton).Visible = flag;
		}
		global::_003CModule_003E.HOLM_002EMeasureGraphics_002E_003FA0x42c1a45b_002EfResponseGuiCallbackDoEvents = flag;
	}

	private unsafe static void Action_Abort(object sender, EventArgs e)
	{
		if (response != null)
		{
			global::_003CModule_003E.HOLM_002EMeasure_002EResponse_002EAbort(response);
		}
	}

	protected virtual void Dispose([MarshalAs(UnmanagedType.U1)] bool P_0)
	{
		if (P_0)
		{
			PostMeasure();
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
