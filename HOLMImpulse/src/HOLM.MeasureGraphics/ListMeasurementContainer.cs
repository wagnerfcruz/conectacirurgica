using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using HOLM.GuiHelper;
using HOLM.Measure;
using std;

namespace HOLM.MeasureGraphics;

internal class ListMeasurementContainer : BasicPresenterContainer, IDisposable
{
	public BasicMeasurementPresenter[] presenter;

	public ControlMeasPresenterPresenter[] formpresenter;

	private EventHandler _003Cbacking_store_003EUpdatePlotEvent;

	public unsafe MeasurementList* list;

	public unsafe MeasurementList* basiclist;

	protected bool fListConstructedHere;

	[SpecialName]
	public event EventHandler UpdatePlotEvent
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			_003Cbacking_store_003EUpdatePlotEvent = (EventHandler)Delegate.Combine(_003Cbacking_store_003EUpdatePlotEvent, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			_003Cbacking_store_003EUpdatePlotEvent = (EventHandler)Delegate.Remove(_003Cbacking_store_003EUpdatePlotEvent, value);
		}
	}

	public unsafe ListMeasurementContainer(int nofFormPresenters, int nofControlMeasurements, int nofBasicPresenters)
	{
		fListConstructedHere = true;
		formpresenter = new ControlMeasPresenterPresenter[nofFormPresenters];
		MeasurementList* ptr = (MeasurementList*)global::_003CModule_003E.@new(44u);
		MeasurementList* ptr2;
		try
		{
			ptr2 = ((ptr == null) ? null : global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementList_002E_007Bctor_007D(ptr, nofBasicPresenters));
		}
		catch
		{
			//try-fault
			global::_003CModule_003E.delete(ptr);
			throw;
		}
		basiclist = ptr2;
		MeasurementList* ptr3 = (MeasurementList*)global::_003CModule_003E.@new(44u);
		MeasurementList* ptr4;
		try
		{
			ptr4 = ((ptr3 == null) ? null : global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementList_002E_007Bctor_007D(ptr3, nofControlMeasurements));
		}
		catch
		{
			//try-fault
			global::_003CModule_003E.delete(ptr3);
			throw;
		}
		list = ptr4;
		presenter = new BasicMeasurementPresenter[nofFormPresenters + nofBasicPresenters];
		int num = 0;
		if (0 < nofBasicPresenters)
		{
			do
			{
				presenter[num + nofFormPresenters] = new BasicMeasurementPresenter(global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementList_002ENo(basiclist, num));
				num++;
			}
			while (num < nofBasicPresenters);
		}
		int num2 = 0;
		if (0 < nofControlMeasurements)
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj2);
			do
			{
				int num3 = num2;
				basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* ptr5 = global::_003CModule_003E.HOLM_002EMiscHelper_002EStringToStd(&obj, num3.ToString());
				try
				{
					basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* ptr6 = global::_003CModule_003E.std_002Eoperator_002B_003Cchar_002Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_002Cclass_0020std_003A_003Aallocator_003Cchar_003E_0020_003E(&obj2, (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref global::_003CModule_003E._003F_003F_C_0040_08ELCHFLBO_0040Empty_003F5_003F9_003F5_003F_0024AA_0040), ptr5);
					try
					{
						global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_003D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementList_002ENo(list, num2), ptr6);
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
					global::_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), &obj);
					throw;
				}
				global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D(&obj);
				num2++;
			}
			while (num2 < nofControlMeasurements);
		}
		int num4 = 0;
		if (0 < nofFormPresenters)
		{
			do
			{
				formpresenter[num4] = new ControlMeasPresenterPresenter(list);
				presenter[num4] = formpresenter[num4];
				formpresenter[num4].SetSlotNumber(num4);
				formpresenter[num4].ComboBoxTextChangedEvent += Action_ComboBoxUpdate;
				formpresenter[num4].UpdatePlotEvent += Action_UpdatePlot;
				num4++;
			}
			while (num4 < nofFormPresenters);
		}
	}

	private unsafe void _007EListMeasurementContainer()
	{
		global::_003CModule_003E.DeleteCliArray(presenter);
		global::_003CModule_003E.DeleteCliArray(formpresenter);
		if (fListConstructedHere)
		{
			MeasurementList* ptr = basiclist;
			if (ptr != null)
			{
				global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementList_002E_007Bdtor_007D(ptr);
				global::_003CModule_003E.delete(ptr);
			}
			MeasurementList* ptr2 = list;
			if (ptr2 != null)
			{
				global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementList_002E_007Bdtor_007D(ptr2);
				global::_003CModule_003E.delete(ptr2);
			}
		}
		else
		{
			basiclist = null;
			list = null;
		}
	}

	public unsafe void Rearange()
	{
		global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementList_002ERearange(list);
		int num = 0;
		ControlMeasPresenterPresenter[] array = formpresenter;
		if (0 < (nint)array.LongLength)
		{
			do
			{
				array[num].UpdateInfo();
				num++;
				array = formpresenter;
			}
			while (num < (nint)array.LongLength);
		}
	}

	public unsafe virtual void Save(basic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E* filename)
	{
		WaitingCtrl.Wait("ListMeasurementContainer::Save", "Saving measurements");
		global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementList_002ESave(list, filename);
		WaitingCtrl.DoNotWait("ListMeasurementContainer::Save");
	}

	[return: MarshalAs(UnmanagedType.U1)]
	public unsafe virtual bool Open(basic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E* filename)
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_stringstream_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E obj);
		global::_003CModule_003E.std_002Ebasic_stringstream_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E_002E_007Bctor_007D(&obj, 3, 1);
		try
		{
			global::_003CModule_003E.std_002Eoperator_003C_003C_003Cwchar_t_002Cstruct_0020std_003A_003Achar_traits_003Cwchar_t_003E_0020_003E(global::_003CModule_003E.std_002Eoperator_003C_003C_003Cwchar_t_002Cstruct_0020std_003A_003Achar_traits_003Cwchar_t_003E_0020_003E(global::_003CModule_003E.std_002Eoperator_003C_003C_003Cwchar_t_002Cstruct_0020std_003A_003Achar_traits_003Cwchar_t_003E_002Cclass_0020std_003A_003Aallocator_003Cwchar_t_003E_0020_003E(global::_003CModule_003E.std_002Eoperator_003C_003C_003Cwchar_t_002Cstruct_0020std_003A_003Achar_traits_003Cwchar_t_003E_0020_003E(global::_003CModule_003E.std_002Eoperator_003C_003C_003Cwchar_t_002Cstruct_0020std_003A_003Achar_traits_003Cwchar_t_003E_0020_003E((basic_ostream_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 8)), (char*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref global::_003CModule_003E._003F_003F_C_0040_1BC_0040DOKPAHCG_0040_003F_0024AAI_003F_0024AAN_003F_0024AAF_003F_0024AAO_003F_0024AA_003F5_003F_0024AA_003F5_003F_0024AA_003F5_003F_0024AA_003F5_003F_0024AA_003F_0024AA_0040)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref global::_003CModule_003E._003F_003F_C_0040_0CB_0040DDHDKKGA_0040ListMeasurementContainer_003F3_003F3Open_003F_0024CI_003F5_0040)), filename), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref global::_003CModule_003E._003F_003F_C_0040_02HMLFPPOG_0040_003F5_003F_0024CJ_003F_0024AA_0040)), (char*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref global::_003CModule_003E._003F_003F_C_0040_13LBAGMAIH_0040_003F_0024AA_003F6_003F_0024AA_003F_0024AA_0040));
			System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E obj2);
			basic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E* ptr = global::_003CModule_003E.std_002Ebasic_stringstream_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E_002Estr(&obj, &obj2);
			try
			{
				global::_003CModule_003E.HOLM_002ELogging_002EHolmLogger_002ELogText(ptr);
			}
			catch
			{
				//try-fault
				global::_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E*, void>)(&global::_003CModule_003E.std_002Ebasic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E_002E_007Bdtor_007D), &obj2);
				throw;
			}
			global::_003CModule_003E.std_002Ebasic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E_002E_007Bdtor_007D(&obj2);
		}
		catch
		{
			//try-fault
			global::_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_stringstream_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E*, void>)(&global::_003CModule_003E.std_002Ebasic_stringstream_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E_002E__vbaseDtor), &obj);
			throw;
		}
		global::_003CModule_003E.std_002Ebasic_stringstream_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E_002E__vbaseDtor(&obj);
		WaitingCtrl.Wait("ListMeasurementContainer::Open", "Opening measurements");
		bool flag = global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementList_002EOpenTry(list, filename, false);
		if (flag)
		{
			int num = 0;
			ControlMeasPresenterPresenter[] array = formpresenter;
			if (0 < (nint)array.LongLength)
			{
				do
				{
					array[num].UpdateInfo();
					num++;
					array = formpresenter;
				}
				while (num < (nint)array.LongLength);
			}
			flag = true;
		}
		WaitingCtrl.DoNotWait("ListMeasurementContainer::Open");
		return flag;
	}

	public unsafe void OpenAppend(basic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E* filename)
	{
		if (!global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementList_002EOpenTryAppend(list, filename))
		{
			return;
		}
		int num = 0;
		ControlMeasPresenterPresenter[] array = formpresenter;
		if (0 < (nint)array.LongLength)
		{
			do
			{
				array[num].UpdateInfo();
				num++;
				array = formpresenter;
			}
			while (num < (nint)array.LongLength);
		}
	}

	public unsafe virtual void Clear()
	{
		global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementList_002EClear(list);
		int num = 0;
		ControlMeasPresenterPresenter[] array = formpresenter;
		if (0 >= (nint)array.LongLength)
		{
			return;
		}
		do
		{
			if (!array[num].SetSlotNumber(num))
			{
				formpresenter[num].UpdateInfo();
			}
			num++;
			array = formpresenter;
		}
		while (num < (nint)array.LongLength);
	}

	public unsafe void SaveDialog()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Invalid comparison between Unknown and I4
		SaveFileDialog val = new SaveFileDialog();
		((FileDialog)val).Filter = "HOLM Response package (*.zip)|*.zip|" + "All Files (*.*)|*.*";
		((FileDialog)val).Title = "Save responses as package";
		if ((int)((CommonDialog)val).ShowDialog() == 1)
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E obj);
			basic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E* filename = global::_003CModule_003E.HOLM_002EMiscHelper_002EStringToStdW(&obj, ((FileDialog)val).FileName);
			try
			{
				Save(filename);
			}
			catch
			{
				//try-fault
				global::_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E*, void>)(&global::_003CModule_003E.std_002Ebasic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E_002E_007Bdtor_007D), &obj);
				throw;
			}
			global::_003CModule_003E.std_002Ebasic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E_002E_007Bdtor_007D(&obj);
		}
		((IDisposable)val)?.Dispose();
	}

	[return: MarshalAs(UnmanagedType.U1)]
	public unsafe bool OpenDialog()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected O, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Invalid comparison between Unknown and I4
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		bool result = false;
		OpenFileDialog val = new OpenFileDialog();
		((FileDialog)val).Filter = string.Concat("HOLM Respons package (*.zip)|*.zip|" + "Obsolete HOLM Binary Responses file (*.hlm)|*.hlm|", "All Files (*.*)|*.*");
		((FileDialog)val).Title = "Load responses";
		if ((int)((CommonDialog)val).ShowDialog() == 1)
		{
			try
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E obj);
				basic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E* filename = global::_003CModule_003E.HOLM_002EMiscHelper_002EStringToStdW(&obj, ((FileDialog)val).FileName);
				try
				{
					result = Open(filename);
				}
				catch
				{
					//try-fault
					global::_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E*, void>)(&global::_003CModule_003E.std_002Ebasic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E_002E_007Bdtor_007D), &obj);
					throw;
				}
				global::_003CModule_003E.std_002Ebasic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E_002E_007Bdtor_007D(&obj);
			}
			catch (Exception ex)
			{
				MessageBox.Show(string.Concat("File is invalid and can not be loaded.\n\n" + "Details:\n", ex.ToString()), "HOLMImpulse Warning", (MessageBoxButtons)0, (MessageBoxIcon)48);
			}
		}
		((IDisposable)val)?.Dispose();
		return result;
	}

	public unsafe void OpenAppendDialog()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Invalid comparison between Unknown and I4
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			OpenFileDialog val = new OpenFileDialog();
			((FileDialog)val).Filter = string.Concat("HOLM Respons package (*.zip)|*.zip|" + "Obsolete HOLM Binary Responses file (*.hlm)|*.hlm|", "All Files (*.*)|*.*");
			((FileDialog)val).Title = "Appened Measurements to the current collection";
			if ((int)((CommonDialog)val).ShowDialog() == 1)
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E obj);
				basic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E* filename = global::_003CModule_003E.HOLM_002EMiscHelper_002EStringToStdW(&obj, ((FileDialog)val).FileName);
				try
				{
					OpenAppend(filename);
				}
				catch
				{
					//try-fault
					global::_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E*, void>)(&global::_003CModule_003E.std_002Ebasic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E_002E_007Bdtor_007D), &obj);
					throw;
				}
				global::_003CModule_003E.std_002Ebasic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E_002E_007Bdtor_007D(&obj);
			}
			OpenFileDialog val2 = val;
			IDisposable disposable = (IDisposable)val;
			((IDisposable)val)?.Dispose();
		}
		catch (Exception ex)
		{
			MessageBox.Show(string.Concat("File is invalid and can not be loaded.\n\n" + "Details:\n", ex.ToString()), "HOLMImpulse Warning", (MessageBoxButtons)0, (MessageBoxIcon)48);
		}
	}

	public void SetLineWidth(int w)
	{
		int num = 0;
		BasicMeasurementPresenter[] array = presenter;
		if (0 < (nint)array.LongLength)
		{
			double num2 = (double)w * 0.6;
			do
			{
				array[num].FreqLineWidth = w;
				presenter[num].PhaseLineWidth = w;
				presenter[num].ImpulseLineWidth = w;
				presenter[num].TargetLineWidth = global::_003CModule_003E.HOLM_002EMath_002EToIntRound(num2);
				num++;
				array = presenter;
			}
			while (num < (nint)array.LongLength);
		}
	}

	[SpecialName]
	protected void raise_UpdatePlotEvent(object value0, EventArgs value1)
	{
		_003Cbacking_store_003EUpdatePlotEvent?.Invoke(value0, value1);
	}

	public override BasicMeasurementPresenter[] GetPresenters()
	{
		return presenter;
	}

	public unsafe void OrganizeDialog()
	{
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Invalid comparison between Unknown and I4
		FormOrganizeSlotsDialog formOrganizeSlotsDialog = new FormOrganizeSlotsDialog();
		((ObjectCollection)formOrganizeSlotsDialog.listBox.Items).Clear();
		int num = global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementList_002EGetSize(list);
		int num2 = 0;
		if (0 < num)
		{
			do
			{
				string text = new string(global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002Ec_str((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementList_002ENo(list, num2)));
				formOrganizeSlotsDialog.listBox.Items.Add((object)text, false);
				num2++;
			}
			while (num2 < num);
		}
		formOrganizeSlotsDialog.InitializeLists();
		if ((int)((Form)formOrganizeSlotsDialog).ShowDialog() == 1)
		{
			Measurement** ptr = (Measurement**)global::_003CModule_003E.new_005B_005D(((uint)num > 1073741823u) ? uint.MaxValue : ((uint)(num << 2)));
			int num3 = 0;
			if (0 < num)
			{
				do
				{
					if (formOrganizeSlotsDialog.clearList[num3])
					{
						global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementCore_002EUninitialize((MeasurementCore*)global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementList_002ENo(list, num3));
					}
					*(int*)(num3 * 4 + (byte*)ptr) = (int)global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementList_002ENo(list, num3);
					num3++;
				}
				while (num3 < num);
			}
			int num4 = 0;
			if (0 < num)
			{
				do
				{
					int num5 = 0;
					while (formOrganizeSlotsDialog.orgList[num5] != ((ObjectCollection)formOrganizeSlotsDialog.listBox.Items)[num4])
					{
						num5++;
						if (num5 >= num)
						{
							break;
						}
					}
					global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementList_002ESetNo(list, (Measurement*)(int)(*(uint*)(num5 * 4 + (byte*)ptr)), num4);
					num4++;
				}
				while (num4 < num);
			}
			int num6 = 0;
			ControlMeasPresenterPresenter[] array = formpresenter;
			if (0 < (nint)array.LongLength)
			{
				do
				{
					array[num6].UpdateInfo();
					num6++;
					array = formpresenter;
				}
				while (num6 < (nint)array.LongLength);
			}
			global::_003CModule_003E.delete_005B_005D(ptr);
		}
		((IDisposable)formOrganizeSlotsDialog)?.Dispose();
		int num7 = 0;
		ControlMeasPresenterPresenter[] array2 = formpresenter;
		if (0 < (nint)array2.LongLength)
		{
			do
			{
				array2[num7].NewListPtr(list);
				formpresenter[num7].UpdateInfo();
				num7++;
				array2 = formpresenter;
			}
			while (num7 < (nint)array2.LongLength);
		}
		_003Cbacking_store_003EUpdatePlotEvent?.Invoke(this, null);
	}

	public unsafe void NewLists(MeasurementList* listIn, MeasurementList* basiclistIn)
	{
		if (fListConstructedHere)
		{
			MeasurementList* ptr = basiclist;
			if (ptr != null)
			{
				global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementList_002E_007Bdtor_007D(ptr);
				global::_003CModule_003E.delete(ptr);
			}
			MeasurementList* ptr2 = list;
			if (ptr2 != null)
			{
				global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementList_002E_007Bdtor_007D(ptr2);
				global::_003CModule_003E.delete(ptr2);
			}
		}
		fListConstructedHere = false;
		basiclist = basiclistIn;
		list = listIn;
		int num = formpresenter.Length;
		int num2 = global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementList_002EGetSize(basiclistIn);
		int num3 = 0;
		if (0 < num2)
		{
			do
			{
				Measurement* measPtr = global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementList_002ENo(basiclist, num3);
				BasicMeasurementPresenter basicMeasurementPresenter = presenter[num3 + num];
				basicMeasurementPresenter.measPtr = measPtr;
				basicMeasurementPresenter.fDataAssigned = true;
				num3++;
			}
			while (num3 < num2);
		}
		int num4 = 0;
		if (0 < num)
		{
			do
			{
				formpresenter[num4].NewListPtr(list);
				num4++;
			}
			while (num4 < num);
		}
		_003Cbacking_store_003EUpdatePlotEvent?.Invoke(this, null);
	}

	[SpecialName]
	public unsafe Measurement* op_Subscript(int pos)
	{
		return global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementList_002ENo(list, pos);
	}

	public void InvokeUpdatePlotEvent()
	{
		_003Cbacking_store_003EUpdatePlotEvent?.Invoke(this, null);
	}

	protected void Action_ComboBoxUpdate(object sender, EventArgs e)
	{
		int num = 0;
		ControlMeasPresenterPresenter[] array = formpresenter;
		if (0 >= (nint)array.LongLength)
		{
			return;
		}
		do
		{
			if (sender != array[num])
			{
				array[num].UpdateComboBox();
			}
			num++;
			array = formpresenter;
		}
		while (num < (nint)array.LongLength);
	}

	protected void Action_UpdatePlot(object sender, EventArgs e)
	{
		_003Cbacking_store_003EUpdatePlotEvent?.Invoke(this, null);
	}

	protected virtual void Dispose([MarshalAs(UnmanagedType.U1)] bool P_0)
	{
		if (P_0)
		{
			_007EListMeasurementContainer();
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
