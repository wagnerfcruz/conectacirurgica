using System.Runtime.CompilerServices;
using System.Windows.Forms;
using std;

namespace HOLM.GuiHelper;

internal class WaitingCtrl
{
	private static WaitingCtrl instance;

	private bool fWaiting;

	private string waitid;

	private string prewaittext1;

	private string prewaittext2;

	private Control mainctrl;

	private Control statusctrl;

	private ToolStripItem statusitem;

	public unsafe static void Wait(string id, string message)
	{
		if (instance == null)
		{
			instance = new WaitingCtrl();
		}
		if (instance.fWaiting)
		{
			if (instance.waitid == id)
			{
				if (instance.statusctrl != null)
				{
					instance.statusctrl.Text = string.Concat(instance.statusctrl.Text, string.Concat("   " + message, " - Please wait..."));
				}
				if (instance.statusitem != null)
				{
					instance.statusitem.Text = message + " - Please wait...";
					((Control)instance.statusitem.GetCurrentParent()).Refresh();
				}
			}
			return;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj);
		global::_003CModule_003E.std_002Ebasic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D(&obj, 3, 1);
		try
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj2);
			basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* ptr = global::_003CModule_003E.HOLM_002EMiscHelper_002EStringToStd(&obj2, id);
			try
			{
				global::_003CModule_003E.std_002Eoperator_003C_003C_003Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_0020_003E(global::_003CModule_003E.std_002Eoperator_003C_003C_003Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_0020_003E(global::_003CModule_003E.std_002Eoperator_003C_003C_003Cchar_002Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_002Cclass_0020std_003A_003Aallocator_003Cchar_003E_0020_003E(global::_003CModule_003E.std_002Eoperator_003C_003C_003Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_0020_003E(global::_003CModule_003E.std_002Eoperator_003C_003C_003Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_0020_003E((basic_ostream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 8)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref global::_003CModule_003E._003F_003F_C_0040_08ECDPJEFA_0040INFO_003F5_003F5_003F5_003F5_003F_0024AA_0040)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref global::_003CModule_003E._003F_003F_C_0040_0BE_0040MBNOEGIB_0040WaitingCtrl_003F3_003F3Wait_003F_0024CI_003F5_003F_0024AA_0040)), ptr), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref global::_003CModule_003E._003F_003F_C_0040_02HMLFPPOG_0040_003F5_003F_0024CJ_003F_0024AA_0040)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref global::_003CModule_003E._003F_003F_C_0040_01EEMJAFIK_0040_003F6_003F_0024AA_0040));
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
		instance.waitid = id;
		instance.fWaiting = true;
		if (instance.statusctrl != null)
		{
			WaitingCtrl waitingCtrl = instance;
			waitingCtrl.prewaittext1 = waitingCtrl.statusctrl.Text;
			instance.statusctrl.Text = string.Concat(instance.statusctrl.Text, string.Concat("   " + message, " - Please wait..."));
		}
		if (instance.statusitem != null)
		{
			WaitingCtrl waitingCtrl2 = instance;
			waitingCtrl2.prewaittext2 = waitingCtrl2.statusitem.Text;
			instance.statusitem.Text = message + " - Please wait...";
			((Control)instance.statusitem.GetCurrentParent()).Refresh();
		}
		Application.UseWaitCursor = true;
		if (instance.mainctrl != null)
		{
			instance.mainctrl.UseWaitCursor = true;
			instance.mainctrl.Cursor = Cursors.WaitCursor;
		}
	}

	public static void Wait(string id)
	{
		Wait(id, "Waiting for " + id);
	}

	public unsafe static void DoNotWait(string id)
	{
		if (instance == null)
		{
			instance = new WaitingCtrl();
		}
		if (!(instance.waitid == id))
		{
			return;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj);
		global::_003CModule_003E.std_002Ebasic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D(&obj, 3, 1);
		try
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj2);
			basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* ptr = global::_003CModule_003E.HOLM_002EMiscHelper_002EStringToStd(&obj2, id);
			try
			{
				global::_003CModule_003E.std_002Eoperator_003C_003C_003Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_0020_003E(global::_003CModule_003E.std_002Eoperator_003C_003C_003Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_0020_003E(global::_003CModule_003E.std_002Eoperator_003C_003C_003Cchar_002Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_002Cclass_0020std_003A_003Aallocator_003Cchar_003E_0020_003E(global::_003CModule_003E.std_002Eoperator_003C_003C_003Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_0020_003E(global::_003CModule_003E.std_002Eoperator_003C_003C_003Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_0020_003E((basic_ostream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 8)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref global::_003CModule_003E._003F_003F_C_0040_08ECDPJEFA_0040INFO_003F5_003F5_003F5_003F5_003F_0024AA_0040)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref global::_003CModule_003E._003F_003F_C_0040_0BJ_0040PGKAHFCH_0040WaitingCtrl_003F3_003F3DoNotWait_003F_0024CI_003F5_003F_0024AA_0040)), ptr), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref global::_003CModule_003E._003F_003F_C_0040_02HMLFPPOG_0040_003F5_003F_0024CJ_003F_0024AA_0040)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref global::_003CModule_003E._003F_003F_C_0040_01EEMJAFIK_0040_003F6_003F_0024AA_0040));
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
		instance.waitid = "";
		instance.fWaiting = false;
		Application.UseWaitCursor = false;
		if (instance.mainctrl != null)
		{
			instance.mainctrl.UseWaitCursor = false;
			instance.mainctrl.Cursor = Cursors.Default;
		}
		if (instance.statusctrl != null)
		{
			instance.statusctrl.Text = instance.prewaittext1;
		}
		if (instance.statusitem != null)
		{
			instance.statusitem.Text = instance.prewaittext2;
		}
	}

	public static void DoNotWaitOverride()
	{
		if (instance == null)
		{
			instance = new WaitingCtrl();
		}
		if (instance.fWaiting)
		{
			instance.waitid = "DoNotWaitOverride";
			DoNotWait(instance.waitid);
		}
	}

	public unsafe static void AssignMainCtrl(Control ctrl)
	{
		if (instance == null)
		{
			instance = new WaitingCtrl();
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj);
		global::_003CModule_003E.std_002Ebasic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D(&obj, 3, 1);
		try
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj2);
			basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* ptr = global::_003CModule_003E.HOLM_002EMiscHelper_002EStringToStd(&obj2, string.Concat("WaitingCtrl::AssignMainCtrl( " + ctrl.Name, " )"));
			try
			{
				global::_003CModule_003E.std_002Eoperator_003C_003C_003Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_0020_003E(global::_003CModule_003E.std_002Eoperator_003C_003C_003Cchar_002Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_002Cclass_0020std_003A_003Aallocator_003Cchar_003E_0020_003E(global::_003CModule_003E.std_002Eoperator_003C_003C_003Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_0020_003E((basic_ostream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 8)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref global::_003CModule_003E._003F_003F_C_0040_08ECDPJEFA_0040INFO_003F5_003F5_003F5_003F5_003F_0024AA_0040)), ptr), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref global::_003CModule_003E._003F_003F_C_0040_01EEMJAFIK_0040_003F6_003F_0024AA_0040));
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
		instance.mainctrl = ctrl;
	}

	public unsafe static void AssignStatusCtrl(Control ctrl)
	{
		if (instance == null)
		{
			instance = new WaitingCtrl();
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj);
		global::_003CModule_003E.std_002Ebasic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D(&obj, 3, 1);
		try
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj2);
			basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* ptr = global::_003CModule_003E.HOLM_002EMiscHelper_002EStringToStd(&obj2, string.Concat("WaitingCtrl::AssignStatusCtrl( " + ctrl.Name, " )"));
			try
			{
				global::_003CModule_003E.std_002Eoperator_003C_003C_003Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_0020_003E(global::_003CModule_003E.std_002Eoperator_003C_003C_003Cchar_002Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_002Cclass_0020std_003A_003Aallocator_003Cchar_003E_0020_003E(global::_003CModule_003E.std_002Eoperator_003C_003C_003Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_0020_003E((basic_ostream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 8)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref global::_003CModule_003E._003F_003F_C_0040_08ECDPJEFA_0040INFO_003F5_003F5_003F5_003F5_003F_0024AA_0040)), ptr), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref global::_003CModule_003E._003F_003F_C_0040_01EEMJAFIK_0040_003F6_003F_0024AA_0040));
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
		instance.statusctrl = ctrl;
	}

	public unsafe static void AssignStatusItem(ToolStripItem ctrl)
	{
		if (instance == null)
		{
			instance = new WaitingCtrl();
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj);
		global::_003CModule_003E.std_002Ebasic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D(&obj, 3, 1);
		try
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj2);
			basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* ptr = global::_003CModule_003E.HOLM_002EMiscHelper_002EStringToStd(&obj2, string.Concat("WaitingCtrl::AssignStatusCtrl( " + ctrl.Name, " )"));
			try
			{
				global::_003CModule_003E.std_002Eoperator_003C_003C_003Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_0020_003E(global::_003CModule_003E.std_002Eoperator_003C_003C_003Cchar_002Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_002Cclass_0020std_003A_003Aallocator_003Cchar_003E_0020_003E(global::_003CModule_003E.std_002Eoperator_003C_003C_003Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_0020_003E((basic_ostream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 8)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref global::_003CModule_003E._003F_003F_C_0040_08ECDPJEFA_0040INFO_003F5_003F5_003F5_003F5_003F_0024AA_0040)), ptr), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref global::_003CModule_003E._003F_003F_C_0040_01EEMJAFIK_0040_003F6_003F_0024AA_0040));
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
		instance.statusitem = ctrl;
	}

	private static void EnsureInstance()
	{
		if (instance == null)
		{
			instance = new WaitingCtrl();
		}
	}

	private unsafe WaitingCtrl()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj);
		global::_003CModule_003E.std_002Ebasic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D(&obj, 3, 1);
		try
		{
			global::_003CModule_003E.std_002Eoperator_003C_003C_003Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_0020_003E(global::_003CModule_003E.std_002Eoperator_003C_003C_003Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_0020_003E(global::_003CModule_003E.std_002Eoperator_003C_003C_003Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_0020_003E((basic_ostream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 8)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref global::_003CModule_003E._003F_003F_C_0040_08ECDPJEFA_0040INFO_003F5_003F5_003F5_003F5_003F_0024AA_0040)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref global::_003CModule_003E._003F_003F_C_0040_0CI_0040MEAGNAMK_0040WaitingCtrl_003F3_003F3WaitingCtrl_003F_0024CI_003F_0024CJ_003F5CONST_0040)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref global::_003CModule_003E._003F_003F_C_0040_01EEMJAFIK_0040_003F6_003F_0024AA_0040));
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
		mainctrl = null;
		statusctrl = null;
		statusitem = null;
		fWaiting = false;
	}
}
