using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using HOLM.Analyze;
using HOLM.GuiHelper;
using HOLM.Measure;
using std;

namespace HOLM.MeasureGraphics;

internal class ControlMeasPresenterPresenter : ListMeasurementPresenter
{
	public FormMeasOptions optionsForm;

	public ControlMeasPresenter mForm;

	protected bool fHideOptionsforExtMeasurements;

	protected ImpulseGraph impulseGraph;

	public unsafe ControlMeasPresenterPresenter(MeasurementList* listIn)
		: base(listIn)
	{
		try
		{
			optionsForm = null;
			impulseGraph = null;
			mForm = null;
			colorCtrl = null;
			fShowSignalInfo = false;
			fShowdBInfo = false;
			fHideOptionsforExtMeasurements = false;
			return;
		}
		catch
		{
			//try-fault
			base.Dispose(true);
			throw;
		}
	}

	private void _007EControlMeasPresenterPresenter()
	{
		FormMeasOptions formMeasOptions = optionsForm;
		if (formMeasOptions != null)
		{
			((IDisposable)formMeasOptions).Dispose();
			optionsForm = null;
		}
	}

	public override void UpdateInfo()
	{
		base.UpdateInfo();
		UpdateOptionsForm();
	}

	public void AssignImpulseGraph(ImpulseGraph impulseGraphIn)
	{
		impulseGraph = impulseGraphIn;
		impulseGraph.Event_Parameters += Action_OptionsUpdateOptionsForm;
	}

	public void AssignOptionsButton(Button button)
	{
		if (optionsForm == null)
		{
			FormMeasOptions formMeasOptions = (optionsForm = new FormMeasOptions());
			colorCtrl?.AssignControl((Control)(object)formMeasOptions.colorPanel, fBg: true, fBright: false);
			((Control)optionsForm.ampInvertedCheckBox).Click += Action_OptionsInvertClick;
			optionsForm.timeWindowRadioButton.CheckedChanged += Action_OptionsGuiChanged;
			optionsForm.timeWindowStartUpDown.ValueChanged += Action_OptionsGuiChanged;
			optionsForm.timeWindowEndUpDown.ValueChanged += Action_OptionsGuiChanged;
			((Control)optionsForm.timeWindowAutoButton).Click += Action_OptionsImpulseWindowAutoClick;
			((Control)optionsForm.timeZeroAutoDetectButton).Click += Action_OptionsTimeOffsetAutodetect;
			optionsForm.timeOffsetUpDown.ValueChanged += Action_OptionsSampleOffsetChanged;
			optionsForm.frSmoothNUpDown.ValueChanged += Action_OptionsGuiChanged;
			((Control)optionsForm.frSmoothAmpRadioButton).Click += Action_OptionsGuiChanged;
			((Control)optionsForm.frSmoothComplexRadioButton).Click += Action_OptionsGuiChanged;
			((Control)optionsForm.frSmoothRadioButton).Click += Action_OptionsGuiChanged;
			((Control)optionsForm.rawResponseRadioButton).Click += Action_OptionsGuiChanged;
			optionsForm.shiftDBUpDown.ValueChanged += Action_OptionsAmplifyFactorChanged;
			((Control)optionsForm).VisibleChanged += Action_OptionsVisibleChanged;
			optionsForm.lowpassCheckBox.CheckedChanged += Action_OptionsGuiChanged;
			optionsForm.lowpassUpDown.ValueChanged += Action_OptionsGuiChanged;
			optionsForm.lowpassLUpDown.ValueChanged += Action_OptionsGuiChanged;
			optionsForm.highpassCheckBox.CheckedChanged += Action_OptionsGuiChanged;
			optionsForm.highpassUpDown.ValueChanged += Action_OptionsGuiChanged;
			optionsForm.highpassLUpDown.ValueChanged += Action_OptionsGuiChanged;
			((Control)optionsForm.infoButton).Click += Action_Info;
		}
		((Control)button).Click += Action_OptionsButtonClick;
	}

	public void AssignMeasurementForm(ControlMeasPresenter formIn)
	{
		mForm = formIn;
		if (formIn.OptionsToClearButton)
		{
			AssignClearButton(mForm.optionsButton);
		}
		else
		{
			AssignOptionsButton(mForm.optionsButton);
			AssignClearButton(optionsForm.clearButton);
		}
		AssignComboBox(mForm.listComboBox);
		AssignSlotUpDown(mForm.slotUpDown);
		infoLabel = mForm.infoLabel;
		info2Label = mForm.info2Label;
	}

	public void OptionsShowTimeStartLocked()
	{
		FormMeasOptions formMeasOptions = optionsForm;
		if (formMeasOptions != null)
		{
			((Control)formMeasOptions.timeStartLockedCheckBox).Visible = true;
			((Control)optionsForm.timeStartLockedCheckBox).Click += Action_OptionsGuiChanged;
		}
	}

	public void OptionsShowFRSmooth([MarshalAs(UnmanagedType.U1)] bool flag)
	{
		optionsForm?.ShowFRSmooth(flag);
	}

	public new void SetColorCtrl(ColorCtrl colorCtrlIn)
	{
		base.SetColorCtrl(colorCtrlIn);
		ControlMeasPresenter controlMeasPresenter = mForm;
		if (controlMeasPresenter != null)
		{
			colorCtrl.AssignClickControl((Control)(object)controlMeasPresenter.colorPanel, fBg: true, fBright: false);
		}
	}

	public void SetHideOptionsforExtMeasurements([MarshalAs(UnmanagedType.U1)] bool flag)
	{
		fHideOptionsforExtMeasurements = flag;
	}

	public void InvokeUpdatePlotAndWait()
	{
		if (optionsForm != null)
		{
			((Control)optionsForm).Cursor = Cursors.WaitCursor;
			WaitingCtrl.Wait("ControlMeasPresenterPresenter::InvokeUpdatePlotAndWait()", "Updating response");
		}
		base.UpdateInfo();
		if (fPlot)
		{
			raise_UpdatePlotEvent(this, null);
		}
		if (optionsForm != null)
		{
			((Control)optionsForm).Cursor = Cursors.Default;
			WaitingCtrl.DoNotWait("ControlMeasPresenterPresenter::InvokeUpdatePlotAndWait()");
		}
	}

	protected unsafe void UpdateOptionsForm()
	{
		FormMeasOptions formMeasOptions = optionsForm;
		if (formMeasOptions != null && ((Control)formMeasOptions).Visible)
		{
			fAcceptGuiEvents = false;
			((Control)optionsForm.colorPanel).BackColor = AmpColor;
			optionsForm.noteTextBox.Text = comboBox.Text;
			if (((byte*)measPtr)[28] != 0)
			{
				((Control)optionsForm.modifyPanel).Enabled = true;
				global::_003CModule_003E.HOLM_002EGuiHelper_002ESetNumericUpDownValue(optionsForm.timeOffsetUpDown, *(double*)((byte*)measPtr + 208));
				global::_003CModule_003E.HOLM_002EGuiHelper_002ESetNumericUpDownValue(optionsForm.timeWindowStartUpDown, *(int*)((byte*)measPtr + 80));
				global::_003CModule_003E.HOLM_002EGuiHelper_002ESetNumericUpDownValue(optionsForm.timeWindowEndUpDown, *(int*)((byte*)measPtr + 84));
				double num = *(double*)((byte*)measPtr + 200);
				global::_003CModule_003E.HOLM_002EGuiHelper_002ESetNumericUpDownValue(optionsForm.shiftDBUpDown, global::_003CModule_003E.HOLM_002EMath_002EAmplitudeToDB_003Cdouble_003E(num));
				global::_003CModule_003E.HOLM_002EGuiHelper_002ESetNumericUpDownValue(optionsForm.frSmoothNUpDown, *(double*)((byte*)measPtr + 264));
				optionsForm.timeStartLockedCheckBox.Checked = ((byte*)measPtr)[90] != 0;
				byte enabled = ((((byte*)measPtr)[90] == 0) ? ((byte)1) : ((byte)0));
				((Control)optionsForm.timeWindowStartUpDown).Enabled = enabled != 0;
				byte @checked = (global::_003CModule_003E.HOLM_002EMeasure_002EConfigCtrl_002EGetEnabled((ConfigCtrl*)((byte*)measPtr + 136), (EnabledEnum)1) ? ((byte)1) : ((byte)0));
				optionsForm.timeWindowRadioButton.Checked = @checked != 0;
				byte checked2 = (byte)((!global::_003CModule_003E.HOLM_002EMeasure_002EConfigCtrl_002EGetEnabled((ConfigCtrl*)((byte*)measPtr + 136), (EnabledEnum)1) && global::_003CModule_003E.HOLM_002EMeasure_002EConfigCtrl_002EGetEnabled((ConfigCtrl*)((byte*)measPtr + 136), (EnabledEnum)2)) ? 1 : 0);
				optionsForm.frSmoothRadioButton.Checked = checked2 != 0;
				byte checked3 = ((!global::_003CModule_003E.HOLM_002EMeasure_002EConfigCtrl_002EGetEnabled((ConfigCtrl*)((byte*)measPtr + 136), (EnabledEnum)3)) ? ((byte)1) : ((byte)0));
				optionsForm.frSmoothAmpRadioButton.Checked = checked3 != 0;
				byte checked4 = (global::_003CModule_003E.HOLM_002EMeasure_002EConfigCtrl_002EGetEnabled((ConfigCtrl*)((byte*)measPtr + 136), (EnabledEnum)3) ? ((byte)1) : ((byte)0));
				optionsForm.frSmoothComplexRadioButton.Checked = checked4 != 0;
				optionsForm.lowpassCheckBox.Checked = ((byte*)measPtr)[217] != 0;
				optionsForm.ampInvertedCheckBox.Checked = ((byte*)measPtr)[216] != 0;
				global::_003CModule_003E.HOLM_002EGuiHelper_002ESetNumericUpDownValue(optionsForm.lowpassUpDown, *(double*)((byte*)measPtr + 232));
				global::_003CModule_003E.HOLM_002EGuiHelper_002ESetNumericUpDownValue(optionsForm.lowpassLUpDown, *(double*)((byte*)measPtr + 224));
				optionsForm.highpassCheckBox.Checked = ((byte*)measPtr)[240] != 0;
				global::_003CModule_003E.HOLM_002EGuiHelper_002ESetNumericUpDownValue(optionsForm.highpassUpDown, *(double*)((byte*)measPtr + 256));
				global::_003CModule_003E.HOLM_002EGuiHelper_002ESetNumericUpDownValue(optionsForm.highpassLUpDown, *(double*)((byte*)measPtr + 248));
				optionsForm.timeZeroMethodComboBox.SelectedIndex = *(int*)((byte*)measPtr + 408);
			}
			else
			{
				((Control)optionsForm.modifyPanel).Enabled = false;
				decimal value = 0;
				optionsForm.timeOffsetUpDown.Value = value;
				decimal value2 = -100;
				optionsForm.timeWindowStartUpDown.Value = value2;
				decimal value3 = 100;
				optionsForm.timeWindowEndUpDown.Value = value3;
				decimal value4 = 0;
				optionsForm.shiftDBUpDown.Value = value4;
			}
			fAcceptGuiEvents = true;
		}
	}

	protected unsafe void UpdateFromOptionsForm()
	{
		global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementCore_002ESetImpulseWindowLockStart((MeasurementCore*)measPtr, optionsForm.timeStartLockedCheckBox.Checked);
		global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementCore_002ESetImpulseWindowEnabled((MeasurementCore*)measPtr, optionsForm.timeWindowRadioButton.Checked);
		decimal value = optionsForm.timeWindowEndUpDown.Value;
		global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementCore_002ESetImpulseWindowEnd((MeasurementCore*)measPtr, decimal.ToInt32(value));
		global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementCore_002ESetSmoothingEnabled((MeasurementCore*)measPtr, optionsForm.frSmoothRadioButton.Checked);
		decimal value2 = optionsForm.timeWindowStartUpDown.Value;
		global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementCore_002ESetImpulseWindowStart((MeasurementCore*)measPtr, decimal.ToInt32(value2), true);
		decimal value3 = optionsForm.frSmoothNUpDown.Value;
		global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementCore_002ESetSmoothNOct((MeasurementCore*)measPtr, decimal.ToDouble(value3));
		global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementCore_002ESetSmoothingComplex((MeasurementCore*)measPtr, optionsForm.frSmoothComplexRadioButton.Checked);
		global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementCore_002ESetLowpassEnabled((MeasurementCore*)measPtr, optionsForm.lowpassCheckBox.Checked);
		double num = decimal.ToDouble(optionsForm.lowpassUpDown.Value);
		double num2 = decimal.ToDouble(optionsForm.lowpassLUpDown.Value);
		global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementCore_002ESetLowpass((MeasurementCore*)measPtr, num, num2);
		global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementCore_002ESetHighpassEnabled((MeasurementCore*)measPtr, optionsForm.highpassCheckBox.Checked);
		num = decimal.ToDouble(optionsForm.highpassUpDown.Value);
		num2 = decimal.ToDouble(optionsForm.highpassLUpDown.Value);
		global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementCore_002ESetHighpass((MeasurementCore*)measPtr, num, num2);
		InvokeUpdatePlotAndWait();
	}

	protected void Action_OptionsUpdateOptionsForm(object sender, EventArgs e)
	{
		UpdateOptionsForm();
	}

	protected void Action_OptionsButtonClick(object sender, EventArgs e)
	{
		((Control)optionsForm).Show();
	}

	protected void Action_OptionsVisibleChanged(object sender, EventArgs e)
	{
		UpdateOptionsForm();
	}

	protected unsafe void Action_OptionsInvertClick(object sender, EventArgs e)
	{
		global::_003CModule_003E.HOLM_002EMeasure_002EMeasurement_002EInvert(measPtr);
		InvokeUpdatePlotAndWait();
	}

	protected unsafe void Action_OptionsImpulseWindowAutoClick(object sender, EventArgs e)
	{
		global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementCore_002ESetImpulseWindowEnabled((MeasurementCore*)measPtr, true);
		global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementCore_002ESetSmoothingEnabled((MeasurementCore*)measPtr, false);
		global::_003CModule_003E.HOLM_002EMeasure_002EMeasurement_002EUseSuggestedImpulseWindowEnd(measPtr);
		UpdateOptionsForm();
		InvokeUpdatePlotAndWait();
	}

	protected unsafe void Action_OptionsSampleOffsetChanged(object sender, EventArgs e)
	{
		if (fAcceptGuiEvents)
		{
			double num = decimal.ToDouble(optionsForm.timeOffsetUpDown.Value);
			global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementCore_002EOffsetAbsolute((MeasurementCore*)measPtr, num);
			InvokeUpdatePlotAndWait();
		}
	}

	protected void Action_OptionsGuiChanged(object sender, EventArgs e)
	{
		if (fAcceptGuiEvents)
		{
			fAcceptGuiEvents = false;
			FormMeasOptions formMeasOptions = optionsForm;
			if (sender == formMeasOptions.highpassUpDown)
			{
				decimal value = formMeasOptions.highpassUpDown.Value;
				optionsForm.highpassLUpDown.Value = value;
			}
			FormMeasOptions formMeasOptions2 = optionsForm;
			if (sender == formMeasOptions2.lowpassUpDown)
			{
				decimal value2 = formMeasOptions2.lowpassUpDown.Value;
				optionsForm.lowpassLUpDown.Value = value2;
			}
			UpdateFromOptionsForm();
			fAcceptGuiEvents = true;
		}
	}

	protected unsafe void Action_OptionsAmplifyFactorChanged(object sender, EventArgs e)
	{
		if (fAcceptGuiEvents)
		{
			fAcceptGuiEvents = false;
			if (((byte*)measPtr)[28] != 0)
			{
				double num = global::_003CModule_003E.HOLM_002EMath_002EDBToAmplitude_003Cdouble_003E(decimal.ToDouble(optionsForm.shiftDBUpDown.Value));
				global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementCore_002EAmplifyAbsolute((MeasurementCore*)measPtr, num);
				InvokeUpdatePlotAndWait();
			}
			base.UpdateInfo();
			fAcceptGuiEvents = true;
		}
	}

	protected unsafe void Action_OptionsTimeOffsetAutodetect(object sender, EventArgs e)
	{
		TZM selectedIndex = (TZM)optionsForm.timeZeroMethodComboBox.SelectedIndex;
		*(TZM*)((byte*)measPtr + 408) = selectedIndex;
		global::_003CModule_003E.HOLM_002EMeasure_002EMeasurement_002ELocateImpulse(measPtr);
		UpdateInfo();
		InvokeUpdatePlotAndWait();
	}

	protected unsafe void Action_Info(object sender, EventArgs e)
	{
		Measurement* ptr = measPtr;
		string info;
		if (((byte*)ptr)[28] != 0)
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj);
			basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* ptr2 = global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementCore_002EGetInfo((MeasurementCore*)ptr, &obj);
			try
			{
				info = new string(global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002Ec_str(ptr2));
			}
			catch
			{
				//try-fault
				global::_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), &obj);
				throw;
			}
			global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D(&obj);
		}
		else
		{
			info = "Not initialized";
		}
		Dialog dialog = new Dialog("Measurement Info");
		dialog.ShowInfoHolm(info);
		((IDisposable)dialog)?.Dispose();
	}

	protected override void Dispose([MarshalAs(UnmanagedType.U1)] bool P_0)
	{
		if (P_0)
		{
			try
			{
				_007EControlMeasPresenterPresenter();
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
