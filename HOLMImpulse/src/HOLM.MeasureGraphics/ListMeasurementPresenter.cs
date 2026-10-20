using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using HOLM.Measure;
using std;

namespace HOLM.MeasureGraphics;

internal class ListMeasurementPresenter : BasicMeasurementPresenter
{
	private EventHandler _003Cbacking_store_003EComboBoxTextChangedEvent;

	public ComboBox comboBox;

	public NumericUpDown slotUpDown;

	public Label infoLabel;

	public Label info2Label;

	public bool fShowSignalInfo;

	public bool fShowdBInfo;

	public unsafe MeasurementList* list;

	protected bool fAcceptGuiEvents;

	protected int slotNumber;

	protected NumericUpDown infoPreGainUpDown;

	protected bool fIndexOnTheMove;

	protected int indexOnTheMove;

	[SpecialName]
	public event EventHandler ComboBoxTextChangedEvent
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			_003Cbacking_store_003EComboBoxTextChangedEvent = (EventHandler)Delegate.Combine(_003Cbacking_store_003EComboBoxTextChangedEvent, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			_003Cbacking_store_003EComboBoxTextChangedEvent = (EventHandler)Delegate.Remove(_003Cbacking_store_003EComboBoxTextChangedEvent, value);
		}
	}

	public unsafe ListMeasurementPresenter(MeasurementList* listIn)
	{
		try
		{
			list = listIn;
			slotNumber = -10;
			slotUpDown = null;
			comboBox = null;
			infoLabel = null;
			infoPreGainUpDown = null;
			SetSlotNumber(0);
			fAcceptGuiEvents = true;
			Measurement* ptr = global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementList_002ENo(list, slotNumber);
			measPtr = ptr;
			fDataAssigned = true;
			return;
		}
		catch
		{
			//try-fault
			base.Dispose(true);
			throw;
		}
	}

	private void _007EListMeasurementPresenter()
	{
	}

	public void AssignClearButton(Button button)
	{
		((Control)button).Click += Action_ClearButtonClick;
	}

	public unsafe void AssignSlotUpDown(NumericUpDown updown)
	{
		slotUpDown = updown;
		decimal value = new decimal(slotNumber);
		slotUpDown.Value = value;
		decimal minimum = 0;
		slotUpDown.Minimum = minimum;
		decimal maximum = new decimal(global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementList_002EGetSize(list) - 1);
		slotUpDown.Maximum = maximum;
		updown.ValueChanged += Action_SlotUpDownChanged;
	}

	public unsafe void AssignComboBox(ComboBox comboBoxIn)
	{
		comboBox = comboBoxIn;
		object[] array = new object[global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementList_002EGetSize(list)];
		int num = 0;
		if (0 < global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementList_002EGetSize(list))
		{
			do
			{
				string text = new string(global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002Ec_str((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementList_002ENo(list, num)));
				array[num] = text;
				num++;
			}
			while (num < global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementList_002EGetSize(list));
		}
		comboBox.Items.Clear();
		comboBox.Items.AddRange(array);
		comboBox.SelectedIndex = slotNumber;
		((Control)comboBox).LostFocus += Action_ComboBoxTextChanged;
		comboBox.DropDown += Action_ComboBoxTextChanged;
		comboBox.SelectedIndexChanged += Action_ComboBoxIndexChanged;
	}

	public int GetSlotNumber()
	{
		return slotNumber;
	}

	[return: MarshalAs(UnmanagedType.U1)]
	public unsafe bool SetSlotNumber(int newSLotNo)
	{
		if (slotNumber != newSLotNo)
		{
			fAcceptGuiEvents = false;
			slotNumber = newSLotNo;
			measPtr = global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementList_002ENo(list, newSLotNo);
			if (slotUpDown != null)
			{
				decimal value = new decimal(slotNumber);
				slotUpDown.Value = value;
			}
			UpdateInfo();
			if (fPlot)
			{
				raise_UpdatePlotEvent(this, null);
			}
			fAcceptGuiEvents = true;
			return true;
		}
		return false;
	}

	[SpecialName]
	protected void raise_ComboBoxTextChangedEvent(object value0, EventArgs value1)
	{
		_003Cbacking_store_003EComboBoxTextChangedEvent?.Invoke(value0, value1);
	}

	public unsafe void NewListPtr(MeasurementList* ListIn, int slotNo)
	{
		list = ListIn;
		slotNumber = -10;
		measPtr = global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementList_002ENo(ListIn, -10);
		fDataAssigned = true;
		SetSlotNumber(slotNo);
	}

	public unsafe void NewListPtr(MeasurementList* ListIn)
	{
		list = ListIn;
		measPtr = global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementList_002ENo(ListIn, slotNumber);
		fDataAssigned = true;
		UpdateComboBox();
	}

	public unsafe void SetText(string text)
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj);
		basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* ptr = global::_003CModule_003E.HOLM_002EMiscHelper_002EStringToStd(&obj, text);
		try
		{
			global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_003D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)measPtr, ptr);
		}
		catch
		{
			//try-fault
			global::_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), &obj);
			throw;
		}
		global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D(&obj);
		ComboBox val = comboBox;
		if (val != null)
		{
			bool flag = fAcceptGuiEvents;
			fAcceptGuiEvents = false;
			val.Text = text;
			_003Cbacking_store_003EComboBoxTextChangedEvent?.Invoke(this, null);
			fAcceptGuiEvents = flag;
		}
	}

	public unsafe virtual void UpdateInfo()
	{
		if (measPtr != null)
		{
			fAcceptGuiEvents = false;
			Label val = infoLabel;
			if (val != null)
			{
				((Control)val).Enabled = ((byte*)measPtr)[28] != 0;
				Measurement* ptr = measPtr;
				if (((byte*)ptr)[28] != 0)
				{
					switch (*(int*)((byte*)ptr + 152))
					{
					case 0:
						infoLabel.Text = "";
						break;
					case 1:
						infoLabel.Text = "Left";
						break;
					case 2:
						infoLabel.Text = "Right";
						break;
					case 3:
						infoLabel.Text = "L && R";
						break;
					default:
						infoLabel.Text = "Na.";
						break;
					}
					if (fShowSignalInfo)
					{
						SignalType signalType = *(SignalType*)((byte*)measPtr + 176);
						System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj);
						basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* ptr2 = global::_003CModule_003E.HOLM_002EMeasure_002ESignalTypeToString(&obj, signalType);
						try
						{
							string text = new string(global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002Ec_str(ptr2));
							infoLabel.Text = string.Concat(infoLabel.Text, string.Concat(" (" + text, ")"));
						}
						catch
						{
							//try-fault
							global::_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), &obj);
							throw;
						}
						global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D(&obj);
					}
					if (fShowdBInfo)
					{
						double num = *(double*)((byte*)measPtr + 200);
						double num2 = global::_003CModule_003E.HOLM_002EMath_002EAmplitudeToDB_003Cdouble_003E(num);
						double num3 = num2;
						string text2 = ((!(num2 < 0.0)) ? " +" : " ");
						infoLabel.Text = string.Concat(infoLabel.Text, string.Concat(text2 + num3.ToString("F1"), "dB"));
					}
				}
				else
				{
					infoLabel.Text = "";
				}
			}
			fAcceptGuiEvents = true;
		}
		UpdateComboBox();
	}

	public unsafe void UpdateComboBox()
	{
		if (comboBox == null)
		{
			return;
		}
		fAcceptGuiEvents = false;
		int num = 0;
		if (0 < global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementList_002EGetSize(list))
		{
			do
			{
				string text = new string(global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002Ec_str((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementList_002ENo(list, num)));
				comboBox.Items[num] = text;
				num++;
			}
			while (num < global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementList_002EGetSize(list));
		}
		comboBox.SelectedIndex = slotNumber;
		fAcceptGuiEvents = true;
	}

	protected unsafe void Action_ComboBoxTextChanged(object sender, EventArgs e)
	{
		if (fAcceptGuiEvents)
		{
			int num = ((comboBox.SelectedIndex >= 0) ? comboBox.SelectedIndex : slotNumber);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj);
			basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* ptr = global::_003CModule_003E.HOLM_002EMiscHelper_002EStringToStd(&obj, comboBox.Text);
			try
			{
				global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_003D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementList_002ENo(list, num), ptr);
			}
			catch
			{
				//try-fault
				global::_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), &obj);
				throw;
			}
			global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D(&obj);
			comboBox.Items[num] = comboBox.Text;
			_003Cbacking_store_003EComboBoxTextChangedEvent?.Invoke(this, null);
		}
	}

	protected unsafe void Action_ClearButtonClick(object sender, EventArgs e)
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj);
		global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D(&obj, (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref global::_003CModule_003E._003F_003F_C_0040_05LGDANENA_0040Empty_003F_0024AA_0040));
		try
		{
			global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementCore_002EReset((MeasurementCore*)measPtr, &obj);
		}
		catch
		{
			//try-fault
			global::_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), &obj);
			throw;
		}
		global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D(&obj);
		UpdateInfo();
		_003Cbacking_store_003EComboBoxTextChangedEvent?.Invoke(this, null);
		if (fPlot)
		{
			raise_UpdatePlotEvent(this, null);
		}
	}

	protected void Action_SlotUpDownChanged(object sender, EventArgs e)
	{
		if (fAcceptGuiEvents)
		{
			fAcceptGuiEvents = false;
			decimal value = slotUpDown.Value;
			SetSlotNumber(decimal.ToInt32(value));
			ComboBox val = comboBox;
			if (val != null)
			{
				val.SelectedIndex = slotNumber;
			}
			fAcceptGuiEvents = true;
		}
	}

	protected void Action_ComboBoxIndexChanged(object sender, EventArgs e)
	{
		if (fAcceptGuiEvents)
		{
			fAcceptGuiEvents = false;
			decimal value = new decimal(comboBox.SelectedIndex);
			slotUpDown.Value = value;
			decimal value2 = slotUpDown.Value;
			SetSlotNumber(decimal.ToInt32(value2));
			fAcceptGuiEvents = true;
		}
	}

	protected override void Dispose([MarshalAs(UnmanagedType.U1)] bool P_0)
	{
		if (P_0)
		{
			try
			{
				return;
			}
			finally
			{
				base.Dispose(true);
			}
		}
		base.Dispose(false);
	}
}
