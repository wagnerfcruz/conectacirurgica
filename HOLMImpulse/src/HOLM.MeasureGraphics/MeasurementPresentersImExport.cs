using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using HOLM.Analyze;
using HOLM.GuiHelper;
using HOLM.Measure;
using HOLM.WaveImExport;
using std;

namespace HOLM.MeasureGraphics;

internal class MeasurementPresentersImExport : IDisposable
{
	public ImExportOptions options;

	protected FormMeasImportDialog importDialog;

	protected FormMeasExportDialog exportDialog;

	protected FormMeasListExportDialog exportListDialog;

	protected ControlMeasPresenterPresenter[] presenters;

	public MeasurementPresentersImExport()
	{
		importDialog = null;
		exportDialog = null;
		exportListDialog = null;
		options = null;
		presenters = new ControlMeasPresenterPresenter[0];
	}

	private void _007EMeasurementPresentersImExport()
	{
		presenters = null;
		((IDisposable)exportDialog)?.Dispose();
		((IDisposable)importDialog)?.Dispose();
		((IDisposable)exportListDialog)?.Dispose();
	}

	[return: MarshalAs(UnmanagedType.U1)]
	public unsafe bool ShowExportDialog(Measurement* meas)
	{
		//IL_0375: Unknown result type (might be due to invalid IL or missing references)
		//IL_037b: Invalid comparison between Unknown and I4
		if (exportDialog == null)
		{
			exportDialog = new FormMeasExportDialog();
		}
		ImExportOptions imExportOptions = options;
		if (imExportOptions != null)
		{
			exportDialog.phaseExportCheckBox.Checked = imExportOptions.ExportPhase;
			exportDialog.phaseExtendCheckBox.Checked = options.PhaseUnwrap;
			byte @checked = ((options.PhaseMode == 0) ? ((byte)1) : ((byte)0));
			exportDialog.phaseDegressRadioButton.Checked = @checked != 0;
			byte checked2 = ((options.PhaseMode == 1) ? ((byte)1) : ((byte)0));
			exportDialog.phaseRadRadioButton.Checked = checked2 != 0;
			exportDialog.infoCheckBox.Checked = options.IncludeHeader;
			exportDialog.commentTextBox.Text = options.CommentString;
			byte checked3 = ((options.DecimalSep == 46) ? ((byte)1) : ((byte)0));
			exportDialog.decSepDotRadioButton.Checked = checked3 != 0;
			byte checked4 = ((options.DecimalSep == 44) ? ((byte)1) : ((byte)0));
			exportDialog.decSepCommaRadioButton.Checked = checked4 != 0;
			byte checked5 = ((options.Separator == 59) ? ((byte)1) : ((byte)0));
			exportDialog.sepSemicolonRadioButton.Checked = checked5 != 0;
			byte checked6 = ((options.Separator == 9) ? ((byte)1) : ((byte)0));
			exportDialog.sepTabRadioButton.Checked = checked6 != 0;
			byte checked7 = ((options.Separator == 44) ? ((byte)1) : ((byte)0));
			exportDialog.sepCommaRadioButton.Checked = checked7 != 0;
			byte checked8 = ((options.Separator == 32) ? ((byte)1) : ((byte)0));
			exportDialog.sepSpaceRadioButton.Checked = checked8 != 0;
			byte checked9 = ((options.ExportMode == 0) ? ((byte)1) : ((byte)0));
			exportDialog.freqFFTRadioButton.Checked = checked9 != 0;
			byte checked10 = ((options.ExportMode == 2) ? ((byte)1) : ((byte)0));
			exportDialog.freqLinRadioButton.Checked = checked10 != 0;
			byte checked11 = ((options.ExportMode == 3) ? ((byte)1) : ((byte)0));
			exportDialog.freqLogRadioButton.Checked = checked11 != 0;
			byte checked12 = ((options.ExportMode == 1) ? ((byte)1) : ((byte)0));
			exportDialog.freqNonEqRadioButton.Checked = checked12 != 0;
			global::_003CModule_003E.HOLM_002EGuiHelper_002ESetNumericUpDownValue(exportDialog.freqLinUpDown, options.LinearStepsHz);
			global::_003CModule_003E.HOLM_002EGuiHelper_002ESetNumericUpDownValue(exportDialog.freqLogNofUpDown, options.LogNofSteps);
			global::_003CModule_003E.HOLM_002EGuiHelper_002ESetNumericUpDownValue(exportDialog.freqNonEqDbUpDown, options.NonEqDbChange);
			global::_003CModule_003E.HOLM_002EGuiHelper_002ESetNumericUpDownValue(exportDialog.freqNonEqPhaseUpDown, options.NonEqPhaseChange);
		}
		bool result = false;
		decimal minimum = new decimal(-1 - *(int*)((byte*)meas + 52));
		exportDialog.impulseFromUpDown.Minimum = minimum;
		decimal maximum = new decimal(*(int*)((byte*)meas + 52) - 1);
		exportDialog.impulseFromUpDown.Maximum = maximum;
		decimal minimum2 = new decimal(-1 - *(int*)((byte*)meas + 52));
		exportDialog.impulseToUpDown.Minimum = minimum2;
		decimal maximum2 = new decimal(*(int*)((byte*)meas + 52) - 1);
		exportDialog.impulseToUpDown.Maximum = maximum2;
		global::_003CModule_003E.HOLM_002EGuiHelper_002ESetNumericUpDownValue(exportDialog.freq0, 10.0);
		global::_003CModule_003E.HOLM_002EGuiHelper_002ESetNumericUpDownValue(exportDialog.freq1, (double)(*(int*)((byte*)meas + 64)) * 0.5);
		bool flag = true;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj4);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj5);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj6);
		while (flag || !exportDialog.fExportFileOK)
		{
			flag = false;
			if ((int)((Form)exportDialog).ShowDialog() != 1 || exportDialog.filenameTextBox.Text.Length <= 1 || !exportDialog.fExportFileOK)
			{
				continue;
			}
			FormMeasExportDialog formMeasExportDialog = exportDialog;
			if (formMeasExportDialog.tabControl.SelectedTab == formMeasExportDialog.freqTabPage && formMeasExportDialog.formatCalRadioButton.Checked)
			{
				Calibrator* ptr = (Calibrator*)global::_003CModule_003E.@new(120u);
				Calibrator* ptr2;
				try
				{
					ptr2 = ((ptr == null) ? null : global::_003CModule_003E.HOLM_002EMeasure_002ECalibrator_002E_007Bctor_007D(ptr));
				}
				catch
				{
					//try-fault
					global::_003CModule_003E.delete(ptr);
					throw;
				}
				*(double*)((byte*)ptr2 + 56) = 0.02;
				*(double*)((byte*)ptr2 + 64) = 0.2;
				double num;
				double num2;
				if (exportDialog.freqFullrangeRadioButton.Checked)
				{
					num = 1.0;
					num2 = (double)(*(int*)((byte*)meas + 64)) * 0.5;
				}
				else
				{
					num = decimal.ToDouble(exportDialog.freq0.Value);
					num2 = decimal.ToDouble(exportDialog.freq1.Value);
				}
				global::_003CModule_003E.HOLM_002EMeasure_002ECalibrator_002EImport(ptr2, meas, num, num2);
				global::_003CModule_003E.HOLM_002EMiscHelper_002EStringToStd(&obj, exportDialog.filenameTextBox.Text);
				try
				{
					global::_003CModule_003E.HOLM_002EMeasure_002ECalibrator_002ESave(ptr2, &obj);
					global::_003CModule_003E.HOLM_002EMeasure_002ECalibrator_002E__delDtor(ptr2, 1u);
				}
				catch
				{
					//try-fault
					global::_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), &obj);
					throw;
				}
				global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D(&obj);
				continue;
			}
			MeasurementExporter* ptr3 = (MeasurementExporter*)global::_003CModule_003E.@new(88u);
			MeasurementExporter* ptr4;
			try
			{
				ptr4 = ((ptr3 == null) ? null : global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementExporter_002E_007Bctor_007D(ptr3));
			}
			catch
			{
				//try-fault
				global::_003CModule_003E.delete(ptr3);
				throw;
			}
			if (exportDialog.sepSemicolonRadioButton.Checked)
			{
				((byte*)ptr4)[8] = 59;
			}
			else if (exportDialog.sepSpaceRadioButton.Checked)
			{
				((byte*)ptr4)[8] = 32;
			}
			else if (exportDialog.sepTabRadioButton.Checked)
			{
				((byte*)ptr4)[8] = 9;
			}
			else if (exportDialog.sepCommaRadioButton.Checked)
			{
				((byte*)ptr4)[8] = 44;
			}
			if (exportDialog.decSepDotRadioButton.Checked)
			{
				((byte*)ptr4)[40] = 46;
			}
			else
			{
				((byte*)ptr4)[40] = 44;
			}
			basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* ptr5 = global::_003CModule_003E.HOLM_002EMiscHelper_002EStringToStd(&obj2, exportDialog.commentTextBox.Text);
			try
			{
				global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_003D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)((byte*)ptr4 + 12), ptr5);
			}
			catch
			{
				//try-fault
				global::_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), &obj2);
				throw;
			}
			global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D(&obj2);
			*(bool*)ptr4 = exportDialog.phaseExportCheckBox.Checked;
			((byte*)ptr4)[11] = (exportDialog.phaseExtendCheckBox.Checked ? ((byte)1) : ((byte)0));
			PhaseMode phaseMode = ((!exportDialog.phaseDegressRadioButton.Checked) ? ((PhaseMode)1) : ((PhaseMode)0));
			*(PhaseMode*)((byte*)ptr4 + 4) = phaseMode;
			((byte*)ptr4)[9] = (exportDialog.infoCheckBox.Checked ? ((byte)1) : ((byte)0));
			if (exportDialog.formatPSpiceRadioButton.Checked)
			{
				*(int*)((byte*)ptr4 + 48) = 1;
			}
			else
			{
				*(int*)((byte*)ptr4 + 48) = 0;
			}
			if (exportDialog.freqFFTRadioButton.Checked)
			{
				*(int*)((byte*)ptr4 + 44) = 0;
			}
			else if (exportDialog.freqLinRadioButton.Checked)
			{
				*(int*)((byte*)ptr4 + 44) = 2;
			}
			else if (exportDialog.freqLogRadioButton.Checked)
			{
				*(int*)((byte*)ptr4 + 44) = 3;
			}
			else if (exportDialog.freqNonEqRadioButton.Checked)
			{
				*(int*)((byte*)ptr4 + 44) = 1;
			}
			decimal value = exportDialog.freqLinUpDown.Value;
			*(double*)((byte*)ptr4 + 72) = decimal.ToDouble(value);
			decimal value2 = exportDialog.freqLogNofUpDown.Value;
			*(double*)((byte*)ptr4 + 80) = decimal.ToDouble(value2);
			decimal value3 = exportDialog.freqNonEqDbUpDown.Value;
			*(double*)((byte*)ptr4 + 56) = decimal.ToDouble(value3);
			decimal value4 = exportDialog.freqNonEqPhaseUpDown.Value;
			*(double*)((byte*)ptr4 + 64) = decimal.ToDouble(value4) / 360.0 * global::_003CModule_003E.HOLM_002EMath_002E_003FA0x3a8cae5d_002ETWOPI;
			global::_003CModule_003E.HOLM_002EMiscHelper_002EStringToStd(&obj3, exportDialog.filenameTextBox.Text);
			try
			{
				FormMeasExportDialog formMeasExportDialog2 = exportDialog;
				if (exportDialog.tabControl.SelectedTab == formMeasExportDialog2.freqTabPage)
				{
					if (formMeasExportDialog2.freqFullrangeRadioButton.Checked)
					{
						basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* ptr6 = &obj4;
						basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* ptr7 = global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D(&obj4, &obj3);
						global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementExporter_002EExport(ptr4, meas, ptr7);
					}
					else
					{
						double num3 = decimal.ToDouble(exportDialog.freq0.Value);
						double num4 = decimal.ToDouble(exportDialog.freq1.Value);
						basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* ptr8 = &obj5;
						basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* ptr9 = global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D(&obj5, &obj3);
						global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementExporter_002EExport(ptr4, meas, ptr9, num3, num4);
					}
					result = true;
				}
				else
				{
					formMeasExportDialog2 = exportDialog;
					if (formMeasExportDialog2.tabControl.SelectedTab == formMeasExportDialog2.impulseTabPage)
					{
						int num5 = decimal.ToInt32(formMeasExportDialog2.impulseFromUpDown.Value);
						int num6 = decimal.ToInt32(exportDialog.impulseToUpDown.Value);
						((byte*)ptr4)[10] = (exportDialog.impulseSampleNumbersCheckBox.Checked ? ((byte)1) : ((byte)0));
						if (exportDialog.impulseWaveRadioButton.Checked)
						{
							WaveFormat selectedIndex = (WaveFormat)exportDialog.impulseWaveFormatComboBox.SelectedIndex;
							bool checked13 = exportDialog.impulseWaveNormCheckBox.Checked;
							result = global::_003CModule_003E.HOLM_002EWaveImExport_002EImpulseWaveExport(meas, &obj3, num5, num6, checked13, selectedIndex);
						}
						else if (exportDialog.impulseTextRadioButton.Checked)
						{
							basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* ptr10 = &obj6;
							basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* ptr11 = global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D(&obj6, &obj3);
							global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementExporter_002EExportImpulse(ptr4, meas, ptr11, num5, num6);
							result = true;
						}
					}
				}
				MeasurementExporter* ptr12 = ptr4;
				global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)((byte*)ptr4 + 12));
				global::_003CModule_003E.delete(ptr4);
			}
			catch
			{
				//try-fault
				global::_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), &obj3);
				throw;
			}
			global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D(&obj3);
		}
		if (options != null)
		{
			options.ExportPhase = exportDialog.phaseExportCheckBox.Checked;
			options.PhaseUnwrap = exportDialog.phaseExtendCheckBox.Checked;
			PhaseMode phaseMode2 = ((!exportDialog.phaseDegressRadioButton.Checked) ? ((PhaseMode)1) : ((PhaseMode)0));
			options.PhaseMode = (int)phaseMode2;
			options.IncludeHeader = exportDialog.infoCheckBox.Checked;
			options.CommentString = exportDialog.commentTextBox.Text;
			sbyte decimalSep = (sbyte)(exportDialog.decSepDotRadioButton.Checked ? 46 : 44);
			options.DecimalSep = decimalSep;
			if (exportDialog.sepSemicolonRadioButton.Checked)
			{
				options.Separator = 59;
			}
			else if (exportDialog.sepTabRadioButton.Checked)
			{
				options.Separator = 9;
			}
			else if (exportDialog.sepCommaRadioButton.Checked)
			{
				options.Separator = 44;
			}
			else
			{
				options.Separator = 32;
			}
			if (exportDialog.freqFFTRadioButton.Checked)
			{
				options.ExportMode = 0;
			}
			else if (exportDialog.freqLinRadioButton.Checked)
			{
				options.ExportMode = 2;
			}
			else if (exportDialog.freqLogRadioButton.Checked)
			{
				options.ExportMode = 3;
			}
			else
			{
				options.ExportMode = 1;
			}
			decimal value5 = exportDialog.freqLinUpDown.Value;
			options.LinearStepsHz = decimal.ToDouble(value5);
			decimal value6 = exportDialog.freqLogNofUpDown.Value;
			options.LogNofSteps = decimal.ToDouble(value6);
			decimal value7 = exportDialog.freqNonEqDbUpDown.Value;
			options.NonEqDbChange = decimal.ToDouble(value7);
			decimal value8 = exportDialog.freqNonEqPhaseUpDown.Value;
			options.NonEqPhaseChange = decimal.ToDouble(value8);
		}
		return result;
	}

	[return: MarshalAs(UnmanagedType.U1)]
	public unsafe bool ShowImportDialog(Measurement* meas)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_0382: Unknown result type (might be due to invalid IL or missing references)
		//IL_0388: Invalid comparison between Unknown and I4
		bool result = false;
		if (importDialog == null)
		{
			importDialog = new FormMeasImportDialog();
		}
		((Form)importDialog).ShowDialog();
		FormMeasImportDialog formMeasImportDialog = importDialog;
		if (formMeasImportDialog.fFreqImport)
		{
			if (File.Exists(formMeasImportDialog.freqFilename.Path))
			{
				((Control)importDialog).UseWaitCursor = true;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out MeasurementImporter measurementImporter);
				global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementImporter_002E_007Bctor_007D(&measurementImporter);
				try
				{
					System.Runtime.CompilerServices.Unsafe.As<MeasurementImporter, bool>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref measurementImporter, 32)) = importDialog.phaseImportCheckBox.Checked;
					PhaseMode phaseMode = ((importDialog.phaseDegressRadioButton == null) ? ((PhaseMode)1) : ((PhaseMode)0));
					System.Runtime.CompilerServices.Unsafe.As<MeasurementImporter, PhaseMode>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref measurementImporter, 36)) = phaseMode;
					System.Runtime.CompilerServices.Unsafe.As<MeasurementImporter, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref measurementImporter, 40)) = 32768;
					int num = *(int*)((byte*)global::_003CModule_003E.HOLM_002EPAudioII_002EStream() + 16);
					System.Runtime.CompilerServices.Unsafe.As<MeasurementImporter, double>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref measurementImporter, 48)) = num;
					System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj);
					global::_003CModule_003E.HOLM_002EMiscHelper_002EStringToStd(&obj, importDialog.freqFilename.Path);
					try
					{
						System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj2);
						basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* ptr = &obj2;
						basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* ptr2 = global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D(&obj2, &obj);
						global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementImporter_002EImport(&measurementImporter, meas, ptr2, false);
						result = true;
						((Control)importDialog).UseWaitCursor = false;
					}
					catch
					{
						//try-fault
						global::_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), &obj);
						throw;
					}
					global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D(&obj);
				}
				catch
				{
					//try-fault
					global::_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<MeasurementImporter*, void>)(&global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementImporter_002E_007Bdtor_007D), &measurementImporter);
					throw;
				}
				global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref measurementImporter, 4)));
			}
			else
			{
				MessageBox.Show("The file does not exists!\nFile: " + importDialog.freqFilename.Path, "Information", (MessageBoxButtons)0, (MessageBoxIcon)64);
			}
		}
		else if (formMeasImportDialog.fImpImport)
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj3);
			global::_003CModule_003E.HOLM_002EMiscHelper_002EStringToStd(&obj3, formMeasImportDialog.impFilename.Path);
			try
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out ImpulseImporter impulseImporter);
				global::_003CModule_003E.HOLM_002EMeasure_002EImpulseImporter_002E_007Bctor_007D(&impulseImporter);
				*(bool*)(&impulseImporter) = importDialog.impAutoOffsetCheckBox.Checked;
				if (importDialog.impulseTextRadioButton.Checked)
				{
					decimal value = importDialog.impSampleRateUpDown.Value;
					System.Runtime.CompilerServices.Unsafe.As<ImpulseImporter, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref impulseImporter, 4)) = decimal.ToInt32(value) * 1000;
					System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj4);
					basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* ptr3 = &obj4;
					basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* ptr4 = global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D(&obj4, &obj3);
					result = global::_003CModule_003E.HOLM_002EMeasure_002EImpulseImporter_002EImportText(&impulseImporter, meas, ptr4);
				}
				else if (importDialog.impulseWaveRadioButton.Checked)
				{
					System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj5);
					basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* ptr5 = &obj5;
					basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* ptr6 = global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D(&obj5, &obj3);
					result = global::_003CModule_003E.HOLM_002EMeasure_002EImpulseImporter_002EImportWave(&impulseImporter, meas, ptr6);
				}
			}
			catch
			{
				//try-fault
				global::_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), &obj3);
				throw;
			}
			global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D(&obj3);
		}
		else if (formMeasImportDialog.fSignalRecImport)
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj6);
			global::_003CModule_003E.HOLM_002EMiscHelper_002EStringToStd(&obj6, formMeasImportDialog.sigFilename.Path);
			try
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj7);
				global::_003CModule_003E.HOLM_002EMiscHelper_002EStringToStd(&obj7, importDialog.recFilename.Path);
				try
				{
					WaveInfo waveInfo = global::_003CModule_003E.HOLM_002EWaveImExport_002EWaveFileInfo(&obj6);
					WaveInfo waveInfo2 = global::_003CModule_003E.HOLM_002EWaveImExport_002EWaveFileInfo(&obj7);
					double num2 = decimal.ToDouble(importDialog.recClockPercentUpDown.Value);
					double num3 = 1.0 - num2 / 100.0;
					if (*(int*)(&waveInfo2) == *(int*)(&waveInfo) && *(int*)(&waveInfo) > 1)
					{
						int num4 = *(int*)(&waveInfo2);
						int num5 = System.Runtime.CompilerServices.Unsafe.As<WaveInfo, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref waveInfo2, 4));
						int num6 = System.Runtime.CompilerServices.Unsafe.As<WaveInfo, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref waveInfo, 4));
						if ((int)MessageBox.Show(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat("Wave-files have been validated.\n" + "\nSignal    : ", num6.ToString()), " samples = "), System.Runtime.CompilerServices.Unsafe.As<WaveInfo, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref waveInfo, 4)) / *(int*)(&waveInfo)), "sec."), "\nRecording : "), num5.ToString()), " samples = "), System.Runtime.CompilerServices.Unsafe.As<WaveInfo, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref waveInfo2, 4)) / *(int*)(&waveInfo2)), "sec."), "\n"), "\nSamplerate: "), num4.ToString()), "Hz"), "\n\nContinue with the correlation process?"), "Question", (MessageBoxButtons)4, (MessageBoxIcon)64) == 6)
						{
							WaitingCtrl.Wait("ShowImportDialog", "Loading files to memory");
							uint num7 = (uint)global::_003CModule_003E.HOLM_002EAnalyze_002ECommonPow2Length(System.Runtime.CompilerServices.Unsafe.As<WaveInfo, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref waveInfo, 4)), System.Runtime.CompilerServices.Unsafe.As<WaveInfo, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref waveInfo2, 4)));
							double* ptr7 = global::_003CModule_003E.Mem_002EAllocateArrayZeros_003Cdouble_003E(num7);
							double* ptr8 = global::_003CModule_003E.Mem_002EAllocateArrayZeros_003Cdouble_003E(num7);
							double* ptr9 = global::_003CModule_003E.Mem_002EAllocateArray_003Cdouble_003E(num7);
							global::_003CModule_003E.HOLM_002EWaveImExport_002EWaveFileToArray_003Cdouble_003E(&obj6, ptr7, System.Runtime.CompilerServices.Unsafe.As<WaveInfo, uint>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref waveInfo, 4)), 1.0);
							global::_003CModule_003E.HOLM_002EWaveImExport_002EWaveFileToArray_003Cdouble_003E(&obj7, ptr8, System.Runtime.CompilerServices.Unsafe.As<WaveInfo, uint>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref waveInfo2, 4)), 1.0);
							if (num3 == 1.0)
							{
								WaitingCtrl.Wait("ShowImportDialog", "Correlating");
							}
							else
							{
								WaitingCtrl.Wait("ShowImportDialog", "Changing speed of recording and correlating");
							}
							global::_003CModule_003E.HOLM_002EAnalyze_002ECorrelateInTime_003Cdouble_002Cdouble_002Cdouble_003E(ptr7, ptr8, ptr9, (int)num7, num3);
							WaitingCtrl.Wait("ShowImportDialog", "Initializing measurement");
							global::_003CModule_003E.Mem_002EFreeArray_003Cdouble_003E(&ptr8, 0u);
							global::_003CModule_003E.Mem_002EFreeArray_003Cdouble_003E(&ptr7, 0u);
							double num8 = global::_003CModule_003E.HOLM_002EAnalyze_002ELocateImpulse_003Cdouble_003E(ptr9, (int)num7, false, (TZM)3);
							int num9 = global::_003CModule_003E.HOLM_002EMath_002EToIntFloor(num8);
							double num10 = num8 - (double)num9;
							uint num11 = num7 >> 1;
							if ((uint)num9 > num11)
							{
								num9 -= (int)num7;
							}
							global::_003CModule_003E.HOLM_002EMath_002EArrayCircShift_003Cdouble_003E(ptr9, (int)num7, (int)num11 - num9, false);
							double* ptr10 = ptr9;
							int num12 = (int)num7;
							decimal value2 = importDialog.sigrecImpMUpDown.Value;
							int num13 = 1 << decimal.ToInt32(value2);
							if (num7 > (uint)num13)
							{
								num12 = num13;
								ptr10 = (double*)(((int)num7 - num13 >>> 1) * 8 + (byte*)ptr9);
							}
							if (importDialog.logsweepCheckBox.Checked)
							{
								decimal value3 = importDialog.signalMUpDown.Value;
								int num14 = 1 << decimal.ToInt32(value3);
								double num15 = *(int*)(&waveInfo);
								double num16 = (double)num14 / num15;
								double num17 = decimal.ToDouble(importDialog.logSweepStartFreqUpDown.Value);
								double num18 = num16 / Math.Log(num15 * 0.5 / num17);
								double* intPtr = ptr10;
								int num19 = num12;
								global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementCore_002EInitializeImpulse((MeasurementCore*)meas, intPtr, num19, num19 / 2, *(int*)(&waveInfo), 17, (SignalType)1, num18, 0.0, true);
							}
							else
							{
								double* intPtr2 = ptr10;
								int num20 = num12;
								global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementCore_002EInitializeImpulse((MeasurementCore*)meas, intPtr2, num20, num20 / 2, *(int*)(&waveInfo), 17, (SignalType)0, 0.0, 0.0, true);
							}
							global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementCore_002EPostInitSetOffset((MeasurementCore*)meas, num9);
							global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementCore_002EOffset((MeasurementCore*)meas, num10);
							global::_003CModule_003E.Mem_002EFreeArray_003Cdouble_003E(&ptr9, 0u);
							result = true;
							WaitingCtrl.DoNotWait("ShowImportDialog");
						}
					}
					else
					{
						int num21 = *(int*)(&waveInfo2);
						int num22 = *(int*)(&waveInfo);
						MessageBox.Show(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat("Wave-files can not been correlated\n" + "\nSignal Samplerate:    ", num22.ToString()), "Hz"), "\nRecording Samplerate: "), num21.ToString()), "Hz"), "Information", (MessageBoxButtons)0, (MessageBoxIcon)64);
					}
				}
				catch
				{
					//try-fault
					global::_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), &obj7);
					throw;
				}
				global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D(&obj7);
			}
			catch
			{
				//try-fault
				global::_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), &obj6);
				throw;
			}
			global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D(&obj6);
		}
		return result;
	}

	[return: MarshalAs(UnmanagedType.U1)]
	public unsafe bool ShowExportListDialog(MeasurementList* measList)
	{
		//IL_02b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bf: Invalid comparison between Unknown and I4
		bool result = false;
		if (exportListDialog == null)
		{
			FormMeasListExportDialog formMeasListExportDialog = (exportListDialog = new FormMeasListExportDialog());
			formMeasListExportDialog.tabControl.TabPages.Remove(formMeasListExportDialog.freqTabPage);
		}
		ImExportOptions imExportOptions = options;
		if (imExportOptions != null)
		{
			exportListDialog.phaseExportCheckBox.Checked = imExportOptions.ExportPhase;
			exportListDialog.phaseExtendCheckBox.Checked = options.PhaseUnwrap;
			byte @checked = ((options.PhaseMode == 0) ? ((byte)1) : ((byte)0));
			exportListDialog.phaseDegressRadioButton.Checked = @checked != 0;
			byte checked2 = ((options.PhaseMode == 1) ? ((byte)1) : ((byte)0));
			exportListDialog.phaseRadRadioButton.Checked = checked2 != 0;
			exportListDialog.infoCheckBox.Checked = options.IncludeHeader;
			exportListDialog.commentTextBox.Text = options.CommentString;
			byte checked3 = ((options.DecimalSep == 46) ? ((byte)1) : ((byte)0));
			exportListDialog.decSepDotRadioButton.Checked = checked3 != 0;
			byte checked4 = ((options.DecimalSep == 44) ? ((byte)1) : ((byte)0));
			exportListDialog.decSepCommaRadioButton.Checked = checked4 != 0;
			byte checked5 = ((options.Separator == 59) ? ((byte)1) : ((byte)0));
			exportListDialog.sepSemicolonRadioButton.Checked = checked5 != 0;
			byte checked6 = ((options.Separator == 9) ? ((byte)1) : ((byte)0));
			exportListDialog.sepTabRadioButton.Checked = checked6 != 0;
			byte checked7 = ((options.Separator == 44) ? ((byte)1) : ((byte)0));
			exportListDialog.sepCommaRadioButton.Checked = checked7 != 0;
			byte checked8 = ((options.Separator == 32) ? ((byte)1) : ((byte)0));
			exportListDialog.sepSpaceRadioButton.Checked = checked8 != 0;
			byte checked9 = ((options.ExportMode == 0) ? ((byte)1) : ((byte)0));
			exportListDialog.freqFFTRadioButton.Checked = checked9 != 0;
			byte checked10 = ((options.ExportMode == 2) ? ((byte)1) : ((byte)0));
			exportListDialog.freqLinRadioButton.Checked = checked10 != 0;
			byte checked11 = ((options.ExportMode == 3) ? ((byte)1) : ((byte)0));
			exportListDialog.freqLogRadioButton.Checked = checked11 != 0;
			byte checked12 = ((options.ExportMode == 1) ? ((byte)1) : ((byte)0));
			exportListDialog.freqNonEqRadioButton.Checked = checked12 != 0;
			global::_003CModule_003E.HOLM_002EGuiHelper_002ESetNumericUpDownValue(exportListDialog.freqLinUpDown, options.LinearStepsHz);
			global::_003CModule_003E.HOLM_002EGuiHelper_002ESetNumericUpDownValue(exportListDialog.freqLogNofUpDown, options.LogNofSteps);
			global::_003CModule_003E.HOLM_002EGuiHelper_002ESetNumericUpDownValue(exportListDialog.freqNonEqDbUpDown, options.NonEqDbChange);
			global::_003CModule_003E.HOLM_002EGuiHelper_002ESetNumericUpDownValue(exportListDialog.freqNonEqPhaseUpDown, options.NonEqPhaseChange);
		}
		if ((int)((Form)exportListDialog).ShowDialog() == 1 && exportListDialog.filenameTextBox.Text.Length > 1)
		{
			MeasurementExporter* ptr = (MeasurementExporter*)global::_003CModule_003E.@new(88u);
			MeasurementExporter* ptr2;
			try
			{
				ptr2 = ((ptr == null) ? null : global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementExporter_002E_007Bctor_007D(ptr));
			}
			catch
			{
				//try-fault
				global::_003CModule_003E.delete(ptr);
				throw;
			}
			if (exportListDialog.sepSemicolonRadioButton.Checked)
			{
				((byte*)ptr2)[8] = 59;
			}
			else if (exportListDialog.sepSpaceRadioButton.Checked)
			{
				((byte*)ptr2)[8] = 32;
			}
			else if (exportListDialog.sepTabRadioButton.Checked)
			{
				((byte*)ptr2)[8] = 9;
			}
			else if (exportListDialog.sepCommaRadioButton.Checked)
			{
				((byte*)ptr2)[8] = 44;
			}
			if (exportListDialog.decSepDotRadioButton.Checked)
			{
				((byte*)ptr2)[40] = 46;
			}
			else
			{
				((byte*)ptr2)[40] = 44;
			}
			System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj);
			basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* ptr3 = global::_003CModule_003E.HOLM_002EMiscHelper_002EStringToStd(&obj, exportListDialog.commentTextBox.Text);
			try
			{
				global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_003D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)((byte*)ptr2 + 12), ptr3);
			}
			catch
			{
				//try-fault
				global::_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), &obj);
				throw;
			}
			global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D(&obj);
			*(bool*)ptr2 = exportListDialog.phaseExportCheckBox.Checked;
			((byte*)ptr2)[11] = (exportListDialog.phaseExtendCheckBox.Checked ? ((byte)1) : ((byte)0));
			PhaseMode phaseMode = ((!exportListDialog.phaseDegressRadioButton.Checked) ? ((PhaseMode)1) : ((PhaseMode)0));
			*(PhaseMode*)((byte*)ptr2 + 4) = phaseMode;
			((byte*)ptr2)[9] = (exportListDialog.infoCheckBox.Checked ? ((byte)1) : ((byte)0));
			if (exportListDialog.freqLinRadioButton.Checked)
			{
				*(int*)((byte*)ptr2 + 44) = 2;
			}
			else if (exportListDialog.freqLogRadioButton.Checked)
			{
				*(int*)((byte*)ptr2 + 44) = 3;
			}
			else if (exportListDialog.freqNonEqRadioButton.Checked)
			{
				*(int*)((byte*)ptr2 + 44) = 1;
			}
			decimal value = exportListDialog.freqLinUpDown.Value;
			*(double*)((byte*)ptr2 + 72) = decimal.ToDouble(value);
			decimal value2 = exportListDialog.freqLogNofUpDown.Value;
			*(double*)((byte*)ptr2 + 80) = decimal.ToDouble(value2);
			decimal value3 = exportListDialog.freqNonEqDbUpDown.Value;
			*(double*)((byte*)ptr2 + 56) = decimal.ToDouble(value3);
			decimal value4 = exportListDialog.freqNonEqPhaseUpDown.Value;
			*(double*)((byte*)ptr2 + 64) = decimal.ToDouble(value4) / 360.0 * global::_003CModule_003E.HOLM_002EMath_002E_003FA0x3a8cae5d_002ETWOPI;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj2);
			global::_003CModule_003E.HOLM_002EMiscHelper_002EStringToStd(&obj2, exportListDialog.filenameTextBox.Text);
			try
			{
				FormMeasListExportDialog formMeasListExportDialog2 = exportListDialog;
				if (exportListDialog.tabControl.SelectedTab == formMeasListExportDialog2.impulseTabPage)
				{
					int num = decimal.ToInt32(formMeasListExportDialog2.impulseFromUpDown.Value);
					int num2 = decimal.ToInt32(exportListDialog.impulseToUpDown.Value);
					((byte*)ptr2)[10] = (exportListDialog.impulseSampleNumbersCheckBox.Checked ? ((byte)1) : ((byte)0));
					System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj3);
					basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* pThis = &obj3;
					basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* ptr4 = global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D(&obj3, &obj2);
					int num3;
					try
					{
						num3 = *(int*)((byte*)global::_003CModule_003E.HOLM_002EPAudioII_002EStream() + 16);
					}
					catch
					{
						//try-fault
						global::_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), pThis);
						throw;
					}
					global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementExporter_002EExportImpulses(ptr2, measList, ptr4, num, num2, num3);
					result = true;
				}
				MeasurementExporter* ptr5 = ptr2;
				global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)((byte*)ptr2 + 12));
				global::_003CModule_003E.delete(ptr2);
			}
			catch
			{
				//try-fault
				global::_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), &obj2);
				throw;
			}
			global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D(&obj2);
		}
		if (options != null)
		{
			options.ExportPhase = exportListDialog.phaseExportCheckBox.Checked;
			options.PhaseUnwrap = exportListDialog.phaseExtendCheckBox.Checked;
			PhaseMode phaseMode2 = ((!exportListDialog.phaseDegressRadioButton.Checked) ? ((PhaseMode)1) : ((PhaseMode)0));
			options.PhaseMode = (int)phaseMode2;
			options.IncludeHeader = exportListDialog.infoCheckBox.Checked;
			options.CommentString = exportListDialog.commentTextBox.Text;
			sbyte decimalSep = (sbyte)(exportListDialog.decSepDotRadioButton.Checked ? 46 : 44);
			options.DecimalSep = decimalSep;
			if (exportListDialog.sepSemicolonRadioButton.Checked)
			{
				options.Separator = 59;
			}
			else if (exportListDialog.sepTabRadioButton.Checked)
			{
				options.Separator = 9;
			}
			else if (exportListDialog.sepCommaRadioButton.Checked)
			{
				options.Separator = 44;
			}
			else
			{
				options.Separator = 32;
			}
			if (exportListDialog.freqFFTRadioButton.Checked)
			{
				options.ExportMode = 0;
			}
			else if (exportListDialog.freqLinRadioButton.Checked)
			{
				options.ExportMode = 2;
			}
			else if (exportListDialog.freqLogRadioButton.Checked)
			{
				options.ExportMode = 3;
			}
			else
			{
				options.ExportMode = 1;
			}
			decimal value5 = exportListDialog.freqLinUpDown.Value;
			options.LinearStepsHz = decimal.ToDouble(value5);
			decimal value6 = exportListDialog.freqLogNofUpDown.Value;
			options.LogNofSteps = decimal.ToDouble(value6);
			decimal value7 = exportListDialog.freqNonEqDbUpDown.Value;
			options.NonEqDbChange = decimal.ToDouble(value7);
			decimal value8 = exportListDialog.freqNonEqPhaseUpDown.Value;
			options.NonEqPhaseChange = decimal.ToDouble(value8);
		}
		return result;
	}

	public void AddControlPresenter(ControlMeasPresenterPresenter presenter)
	{
		int num = presenters.Length;
		Array.Resize(ref presenters, num + 1);
		presenters[num] = presenter;
		((Control)presenter.mForm.importButton).Click += Action_ImportDialog;
		((Control)presenter.mForm.exportButton).Click += Action_ExportDialog;
	}

	protected unsafe void Action_ImportDialog(object sender, EventArgs e)
	{
		ControlMeasPresenterPresenter controlMeasPresenterPresenter = null;
		int num = 0;
		ControlMeasPresenterPresenter[] array = presenters;
		int num2 = array.Length;
		if (0 < num2)
		{
			do
			{
				ControlMeasPresenterPresenter controlMeasPresenterPresenter2 = array[num];
				if (sender == controlMeasPresenterPresenter2.mForm.importButton)
				{
					controlMeasPresenterPresenter = controlMeasPresenterPresenter2;
				}
				num++;
			}
			while (num < num2);
		}
		if (controlMeasPresenterPresenter != null && ShowImportDialog(controlMeasPresenterPresenter.measPtr))
		{
			string path = "";
			FormMeasImportDialog formMeasImportDialog = importDialog;
			if (formMeasImportDialog.fFreqImport)
			{
				path = formMeasImportDialog.freqFilename.Path;
			}
			else if (formMeasImportDialog.fImpImport)
			{
				path = formMeasImportDialog.impFilename.Path;
			}
			else if (formMeasImportDialog.fSignalRecImport)
			{
				path = formMeasImportDialog.recFilename.Path;
			}
			controlMeasPresenterPresenter.SetText("Import: " + Path.GetFileName(path));
			controlMeasPresenterPresenter.InvokeUpdatePlotEvent();
		}
	}

	protected unsafe void Action_ExportDialog(object sender, EventArgs e)
	{
		ControlMeasPresenterPresenter controlMeasPresenterPresenter = null;
		int num = 0;
		ControlMeasPresenterPresenter[] array = presenters;
		int num2 = array.Length;
		if (0 < num2)
		{
			do
			{
				ControlMeasPresenterPresenter controlMeasPresenterPresenter2 = array[num];
				if (sender == controlMeasPresenterPresenter2.mForm.exportButton)
				{
					controlMeasPresenterPresenter = controlMeasPresenterPresenter2;
				}
				num++;
			}
			while (num < num2);
		}
		if (controlMeasPresenterPresenter != null)
		{
			ShowExportDialog(controlMeasPresenterPresenter.measPtr);
		}
	}

	protected virtual void Dispose([MarshalAs(UnmanagedType.U1)] bool P_0)
	{
		if (P_0)
		{
			_007EMeasurementPresentersImExport();
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
