using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using HOLM.PAudioII;

namespace HOLM;

internal class VUMeterCtrl : IDisposable
{
	private static VUMeterCtrl instance;

	private FormVUMeter form;

	private int form2CHH;

	private string baseText;

	private string postText;

	private unsafe VUMeterInBuffer* vuInBuffer;

	[return: MarshalAs(UnmanagedType.U1)]
	public static bool Visible()
	{
		int num = ((instance != null && ((Control)instance.form).Visible) ? 1 : 0);
		return (byte)num != 0;
	}

	public unsafe static void Show()
	{
		if (instance == null)
		{
			instance = new VUMeterCtrl();
		}
		if ((byte)((global::_003CModule_003E._003Finstance_0040StreamInitializer_0040PAudioII_0040HOLM_0040_00400PAV123_0040A != null) ? 1u : 0u) != 0)
		{
			global::_003CModule_003E.HOLM_002EPAudioII_002EStreamInitializer_002EAddStatusCallback(global::_003CModule_003E.HOLM_002EPAudioII_002EStream(), (delegate* unmanaged[Cdecl, Cdecl]<StreamStatus, void>)global::_003CModule_003E.__unep_0040_003FStatusCallback_0040HOLM_0040_0040_0024_0024FYAXW4StreamStatus_0040PAudioII_00401_0040_0040Z);
			NewStreamStatus(*(StreamStatus*)((byte*)global::_003CModule_003E.HOLM_002EPAudioII_002EStream() + 12));
		}
		((Control)instance.form).Show();
	}

	public unsafe static void Hide()
	{
		if (instance == null)
		{
			return;
		}
		((Control)instance.form).Hide();
		if (instance.vuInBuffer != null)
		{
			VUMeterInBuffer* ptr = instance.vuInBuffer;
			if (ptr != null)
			{
				global::_003CModule_003E.HOLM_002EPAudioII_002EVUMeterInBuffer_002E_007Bdtor_007D(ptr);
				global::_003CModule_003E.delete(ptr);
			}
			instance.vuInBuffer = null;
		}
		if ((byte)((global::_003CModule_003E._003Finstance_0040StreamInitializer_0040PAudioII_0040HOLM_0040_00400PAV123_0040A != null) ? 1u : 0u) != 0)
		{
			global::_003CModule_003E.HOLM_002EPAudioII_002EStreamInitializer_002ERemoveStatusCallback(global::_003CModule_003E.HOLM_002EPAudioII_002EStream(), (delegate* unmanaged[Cdecl, Cdecl]<StreamStatus, void>)global::_003CModule_003E.__unep_0040_003FStatusCallback_0040HOLM_0040_0040_0024_0024FYAXW4StreamStatus_0040PAudioII_00401_0040_0040Z);
		}
	}

	public static void Toggle()
	{
		int num = ((instance != null && ((Control)instance.form).Visible) ? 1 : 0);
		if ((byte)num != 0)
		{
			Hide();
		}
		else
		{
			Show();
		}
	}

	public unsafe static void NewStreamStatus(StreamStatus status)
	{
		EnsureInstance();
		int num2;
		int height;
		if (status == (StreamStatus)0)
		{
			if (instance.vuInBuffer != null)
			{
				VUMeterInBuffer* ptr = instance.vuInBuffer;
				if (ptr != null)
				{
					global::_003CModule_003E.HOLM_002EPAudioII_002EVUMeterInBuffer_002E_007Bdtor_007D(ptr);
					global::_003CModule_003E.delete(ptr);
				}
			}
			VUMeterInBuffer* ptr2 = (VUMeterInBuffer*)global::_003CModule_003E.@new(88u);
			VUMeterInBuffer* ptr3;
			try
			{
				ptr3 = ((ptr2 == null) ? null : global::_003CModule_003E.HOLM_002EPAudioII_002EVUMeterInBuffer_002E_007Bctor_007D(ptr2, global::_003CModule_003E.HOLM_002EPAudioII_002EStream(), 0.1f, 1f));
			}
			catch
			{
				//try-fault
				global::_003CModule_003E.delete(ptr2);
				throw;
			}
			instance.vuInBuffer = ptr3;
			*(int*)((byte*)instance.vuInBuffer + 48) = (int)global::_003CModule_003E.__unep_0040_003FCallback_0040HOLM_0040_0040_0024_0024FYAXPBM00H_0040Z;
			instance.postText = "Running";
			uint num = *(uint*)((byte*)global::_003CModule_003E.HOLM_002EPAudioII_002EStream() + 56);
			if (num != 0)
			{
				num2 = *(int*)(int)(num + 4);
				if (num2 > 2)
				{
					height = ((Control)instance.form.panel1).Height * 3 + instance.form2CHH;
					goto IL_00e1;
				}
			}
			else
			{
				num2 = 0;
			}
			height = instance.form2CHH;
			goto IL_00e1;
		}
		if (instance.vuInBuffer != null)
		{
			VUMeterInBuffer* ptr4 = instance.vuInBuffer;
			if (ptr4 != null)
			{
				global::_003CModule_003E.HOLM_002EPAudioII_002EVUMeterInBuffer_002E_007Bdtor_007D(ptr4);
				global::_003CModule_003E.delete(ptr4);
			}
			instance.vuInBuffer = null;
		}
		instance.postText = "Stopped";
		goto IL_01a7;
		IL_00e1:
		Size minimumSize = new Size(200, height);
		((Form)instance.form).MinimumSize = minimumSize;
		Size maximumSize = new Size(800, height);
		((Form)instance.form).MaximumSize = maximumSize;
		((Control)instance.form).Height = height;
		byte visible = ((num2 > 2) ? ((byte)1) : ((byte)0));
		((Control)instance.form.panel3).Visible = visible != 0;
		byte visible2 = ((num2 > 2) ? ((byte)1) : ((byte)0));
		((Control)instance.form.panel4).Visible = visible2 != 0;
		goto IL_01a7;
		IL_01a7:
		((Form)instance.form).Text = string.Concat(instance.baseText + " - ", instance.postText);
	}

	public unsafe static void DeleteInstance()
	{
		if (instance != null)
		{
			global::_003CModule_003E.HOLM_002EPAudioII_002EStream();
			if ((byte)((global::_003CModule_003E._003Finstance_0040StreamInitializer_0040PAudioII_0040HOLM_0040_00400PAV123_0040A != null) ? 1u : 0u) != 0)
			{
				global::_003CModule_003E.HOLM_002EPAudioII_002EStreamInitializer_002ERemoveStatusCallback(global::_003CModule_003E.HOLM_002EPAudioII_002EStream(), (delegate* unmanaged[Cdecl, Cdecl]<StreamStatus, void>)global::_003CModule_003E.__unep_0040_003FStatusCallback_0040HOLM_0040_0040_0024_0024FYAXW4StreamStatus_0040PAudioII_00401_0040_0040Z);
			}
			((IDisposable)instance)?.Dispose();
			instance = null;
		}
	}

	public static FormVUMeter GetVUForm()
	{
		EnsureInstance();
		return instance.form;
	}

	public static void SetBaseText(string text)
	{
		if (instance == null)
		{
			instance = new VUMeterCtrl();
		}
		instance.baseText = text;
		((Form)instance.form).Text = string.Concat(instance.baseText + " - ", instance.postText);
	}

	public static void SetSourceText(string text)
	{
		if (instance == null)
		{
			instance = new VUMeterCtrl();
		}
		((Control)instance.form.sourceTextBox).Visible = true;
		instance.form.sourceTextBox.Text = text;
	}

	private static void EnsureInstance()
	{
		if (instance == null)
		{
			instance = new VUMeterCtrl();
		}
	}

	private unsafe VUMeterCtrl()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		form = new FormVUMeter();
		((Form)form).FormClosing += new FormClosingEventHandler(Action_FormClosing);
		((Control)form.resetButton).Click += Action_ResetPeak;
		form2CHH = ((Control)form).Height;
		vuInBuffer = null;
		baseText = "Recording Meter";
	}

	private unsafe void _007EVUMeterCtrl()
	{
		VUMeterInBuffer* ptr = vuInBuffer;
		if (ptr != null)
		{
			VUMeterInBuffer* ptr2 = ptr;
			global::_003CModule_003E.HOLM_002EPAudioII_002EVUMeterInBuffer_002E_007Bdtor_007D(ptr2);
			global::_003CModule_003E.delete(ptr2);
			vuInBuffer = null;
		}
		FormVUMeter formVUMeter = form;
		if (formVUMeter != null)
		{
			((IDisposable)formVUMeter).Dispose();
			form = null;
		}
	}

	private void Action_FormClosing(object sender, FormClosingEventArgs e)
	{
		((CancelEventArgs)(object)e).Cancel = true;
		Hide();
	}

	private unsafe void Action_ResetPeak(object sender, EventArgs e)
	{
		VUMeterInBuffer* ptr = vuInBuffer;
		if (ptr != null)
		{
			global::_003CModule_003E.HOLM_002EPAudioII_002EVUMeterInBuffer_002EResetPeak(ptr);
		}
	}

	protected virtual void Dispose([MarshalAs(UnmanagedType.U1)] bool P_0)
	{
		if (P_0)
		{
			_007EVUMeterCtrl();
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
