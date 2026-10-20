using System;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using HOLM.Filter;
using HOLM.GuiHelper;
using HOLM.HOLMImpulse.Conf;
using HOLM.Measure;
using HOLM.MeasureGraphics;
using HOLM.PAudioII;
using HOLM.WaveImExport;
using std;

namespace HOLM.HOLMImpulse;

internal class AudioHelper : IDisposable
{
	public unsafe ResponseSaveOpenWave* response;

	private MainCtrl mainCtrl;

	private Form1 mainForm;

	private bool fReactOnGuiChanges;

	private unsafe vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E* inputDevs;

	private unsafe vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E* outputDevs;

	private unsafe SineSweepSingle* chirp;

	private unsafe SquareNoise* sqNoise;

	private unsafe SineLogSweep* logSweep;

	private unsafe PCMGenerator* pcmGenerator;

	private int m;

	private int L;

	private double offsetCalibration;

	private double currentOffsetMilliSec;

	private unsafe complex_003Cdouble_003E* freq;

	private unsafe Calibrator* calMic;

	private unsafe Calibrator* calDacAdc;

	public AudioHelper(MainCtrl mainCtrlIn)
	{
		mainCtrl = mainCtrlIn;
		mainForm = MainCtrl.mainForm;
		Initialize();
	}

	private unsafe void _007EAudioHelper()
	{
		vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E* ptr = inputDevs;
		if (ptr != null)
		{
			try
			{
				vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E* ptr2 = (vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E*)((byte*)ptr + 12);
				uint num = *(uint*)ptr2;
				if (num != 0)
				{
					global::_003CModule_003E.delete((void*)(int)num);
				}
				*(int*)ptr2 = 0;
				*(int*)((byte*)ptr + 16) = 0;
				*(int*)((byte*)ptr + 20) = 0;
			}
			catch
			{
				//try-fault
				global::_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<_Vector_val_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E*, void>)(&global::_003CModule_003E.std_002E_Vector_val_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E_002E_007Bdtor_007D), ptr);
				throw;
			}
			global::_003CModule_003E.delete((void*)(int)(*(uint*)ptr));
			global::_003CModule_003E.delete(ptr);
		}
		vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E* ptr3 = outputDevs;
		if (ptr3 != null)
		{
			try
			{
				vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E* ptr4 = (vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E*)((byte*)ptr3 + 12);
				uint num2 = *(uint*)ptr4;
				if (num2 != 0)
				{
					global::_003CModule_003E.delete((void*)(int)num2);
				}
				*(int*)ptr4 = 0;
				*(int*)((byte*)ptr3 + 16) = 0;
				*(int*)((byte*)ptr3 + 20) = 0;
			}
			catch
			{
				//try-fault
				global::_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<_Vector_val_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E*, void>)(&global::_003CModule_003E.std_002E_Vector_val_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E_002E_007Bdtor_007D), ptr3);
				throw;
			}
			global::_003CModule_003E.delete((void*)(int)(*(uint*)ptr3));
			global::_003CModule_003E.delete(ptr3);
		}
		global::_003CModule_003E.delete(chirp);
		global::_003CModule_003E.delete(sqNoise);
		global::_003CModule_003E.delete(logSweep);
		global::_003CModule_003E.Mem_002EFreeArrayNoRef_003Cclass_0020std_003A_003Acomplex_003Cdouble_003E_0020_003E(freq, 0u);
		ResponseSaveOpenWave* ptr5 = response;
		if (ptr5 != null)
		{
			global::_003CModule_003E.HOLM_002EMeasure_002EResponseSaveOpenWave_002E_007Bdtor_007D(ptr5);
			global::_003CModule_003E.delete(ptr5);
		}
		Calibrator* ptr6 = calMic;
		if (ptr6 != null)
		{
			global::_003CModule_003E.HOLM_002EMeasure_002ECalibrator_002E_007Bdtor_007D(ptr6);
			global::_003CModule_003E.delete(ptr6);
		}
		Calibrator* ptr7 = calDacAdc;
		if (ptr7 != null)
		{
			global::_003CModule_003E.HOLM_002EMeasure_002ECalibrator_002E_007Bdtor_007D(ptr7);
			global::_003CModule_003E.delete(ptr7);
		}
		VUMeterCtrl.DeleteInstance();
	}

	[return: MarshalAs(UnmanagedType.U1)]
	public unsafe bool ValidateMeasAmp(Measurement* meas, TextBox textDB, TextBox textAmp)
	{
		double num = *(double*)((byte*)meas + 160);
		double num2 = global::_003CModule_003E.HOLM_002EMath_002EAmplitudeToDB_003Cdouble_003E(num);
		bool result = false;
		if (textDB != null)
		{
			double num3 = num2;
			textDB.Text = num3.ToString("F2");
		}
		if (textAmp != null)
		{
			double num4 = num;
			textAmp.Text = num4.ToString("F3");
		}
		if (num > global::_003CModule_003E.HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x11fcae0a_002EMEASURE_LOW_REJECT_AMP)
		{
			if (num >= 0.999)
			{
				if (textDB != null)
				{
					Color backColor = Color.FromArgb(250, 50, 50);
					((TextBoxBase)textDB).BackColor = backColor;
				}
				if (textAmp != null)
				{
					Color backColor2 = Color.FromArgb(250, 50, 50);
					((TextBoxBase)textAmp).BackColor = backColor2;
				}
				mainCtrl.dialog.ShowInfoHolm("Recording amplitude indicates digital clipping.\nMeasure at a lower volume to avoid this");
			}
			else if (num < global::_003CModule_003E.HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x11fcae0a_002EMEASURE_LOW_WARN_AMP)
			{
				if (textDB != null)
				{
					Color backColor3 = Color.FromArgb(220, 220, 50);
					((TextBoxBase)textDB).BackColor = backColor3;
				}
				if (textAmp != null)
				{
					Color backColor4 = Color.FromArgb(220, 220, 50);
					((TextBoxBase)textAmp).BackColor = backColor4;
				}
				double num5 = num2;
				mainCtrl.dialog.ShowInfoHolm(string.Concat("Recording amplitude is low: " + num5.ToString("F0"), " dB\nMeasure at a higher volume to avoid this"));
			}
			else
			{
				if (textDB != null)
				{
					Color defaultBackColor = Control.DefaultBackColor;
					((TextBoxBase)textDB).BackColor = defaultBackColor;
				}
				if (textAmp != null)
				{
					Color defaultBackColor2 = Control.DefaultBackColor;
					((TextBoxBase)textAmp).BackColor = defaultBackColor2;
				}
			}
			result = true;
		}
		else
		{
			if (textDB != null)
			{
				Color backColor5 = Color.FromArgb(250, 50, 50);
				((TextBoxBase)textDB).BackColor = backColor5;
			}
			if (textAmp != null)
			{
				Color backColor6 = Color.FromArgb(250, 50, 50);
				((TextBoxBase)textAmp).BackColor = backColor6;
			}
			double num6 = global::_003CModule_003E.HOLM_002EMath_002EAmplitudeToDB_003Cdouble_003E(global::_003CModule_003E.HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x11fcae0a_002EMEASURE_LOW_REJECT_AMP);
			mainCtrl.dialog.ShowInfoHolm(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat("Recording amplitude is to low:! (Below " + num6.ToString("F0"), " dB)\n"), "\n"), "Please make sure that:\n"), "1. The microphone is connected to the input on the soundcard\n"), "2. The windows mixer settings for playing & recording are correct\n"), "3. No other windows application is streaming sound (eg. playning music) to the input soundcard\n"), "4. The microphone is switched on"));
		}
		return result;
	}

	public unsafe void SaveToOptions()
	{
		PrePostMeasureSettings();
		Options.Field.Signal.SignalLength = m;
		decimal value = mainForm.dev.recMaxDelayUpDown.Value;
		Options.Field.Dev.DelayMS = decimal.ToDouble(value);
		Options.Field.Dev.InputInvert = mainForm.dev.inputInvertCheckBox.Checked;
		Options.Field.Dev.SamplerateNo = mainForm.dev.sampleRateComboBox.SelectedIndex;
		Options.Field.Analysis.MicCalibration = ((byte*)calMic)[96] != 0;
		Options.Field.Analysis.DacAdcCalibration = ((byte*)calDacAdc)[96] != 0;
		Options.Field.Filter.HighpassEnabled = mainForm.meas.freqWindowHighpassCheckBox.Checked;
		Options.Field.Filter.LowpassEnabled = mainForm.meas.freqWindowLowpassCheckBox.Checked;
		decimal value2 = mainForm.meas.freqWindowHighpassUpDown.Value;
		Options.Field.Filter.HighpassFreq = decimal.ToDouble(value2);
		decimal value3 = mainForm.meas.freqWindowLowpassUpDown.Value;
		Options.Field.Filter.LowpassFreq = decimal.ToDouble(value3);
		decimal value4 = mainForm.meas.nofTapsUpDown.Value;
		Options.Field.Filter.NofTaps = decimal.ToInt32(value4);
		if (mainForm.dev.outputLogSweepRadioButton.Checked)
		{
			Options.Field.Signal.SignalType = 0;
		}
		else if (mainForm.dev.outputChirpRadioButton.Checked)
		{
			Options.Field.Signal.SignalType = 1;
		}
		else if (mainForm.dev.outputSqRadioButton.Checked)
		{
			Options.Field.Signal.SignalType = 2;
		}
		else
		{
			Options.Field.Signal.SignalType = 0;
		}
		Options.Field.Dev.ApiNumber = mainForm.dev.apiComboBox.SelectedIndex;
		Options.Field.Dev.InputNumber = mainForm.dev.inputDevComboBox.SelectedIndex;
		Options.Field.Dev.OutputNumber = mainForm.dev.outputDevComboBox.SelectedIndex;
		Options.Field.Misc.SaveMeasureOutput = mainForm.analysis.debugOutputTextBox.Text;
		Options.Field.Misc.SaveMeasureRec = mainForm.analysis.debugRecordingTextBox.Text;
		Options.Field.Misc.SaveMeasureCorr = mainForm.analysis.debugCorrTextBox.Text;
	}

	public unsafe void LoadFromOptions()
	{
		fReactOnGuiChanges = false;
		global::_003CModule_003E.HOLM_002EPAudioII_002EStreamInitializer_002EStop(global::_003CModule_003E.HOLM_002EPAudioII_002EStream());
		((ButtonBase)mainForm.dev.deviceRestartStreamButton).Text = "Start stream";
		((ToolStripItem)mainForm.toolStripStatusLabel1).Text = "Audiostream stopped";
		mainForm.dev.deviceKeepStreamCheckBox.Checked = Options.Field.Dev.KeepStreamActive;
		decimal value = new decimal(Options.Field.Dev.DelayMS);
		mainForm.dev.recMaxDelayUpDown.Value = value;
		decimal value2 = new decimal(m = Options.Field.Signal.SignalLength);
		mainForm.dev.signalMUpDown.Value = value2;
		UpdateSignalLength();
		mainForm.dev.sampleRateComboBox.SelectedIndex = Options.Field.Dev.SamplerateNo;
		SetSamplerateNo(Options.Field.Dev.SamplerateNo);
		mainForm.dev.inputInvertCheckBox.Checked = Options.Field.Dev.InputInvert;
		global::_003CModule_003E.HOLM_002EPAudioII_002EStreamInitializer_002ESetInInverted(global::_003CModule_003E.HOLM_002EPAudioII_002EStream(), Options.Field.Dev.InputInvert);
		switch (Options.Field.Signal.SignalType)
		{
		default:
			mainForm.dev.outputLogSweepRadioButton.Checked = true;
			mainForm.dev.outputChirpRadioButton.Checked = false;
			mainForm.dev.outputSqRadioButton.Checked = false;
			pcmGenerator = (PCMGenerator*)logSweep;
			break;
		case 2:
			mainForm.dev.outputLogSweepRadioButton.Checked = false;
			mainForm.dev.outputChirpRadioButton.Checked = false;
			mainForm.dev.outputSqRadioButton.Checked = true;
			pcmGenerator = (PCMGenerator*)sqNoise;
			break;
		case 1:
			mainForm.dev.outputLogSweepRadioButton.Checked = false;
			mainForm.dev.outputChirpRadioButton.Checked = true;
			mainForm.dev.outputSqRadioButton.Checked = false;
			pcmGenerator = (PCMGenerator*)chirp;
			break;
		case 0:
			mainForm.dev.outputLogSweepRadioButton.Checked = true;
			mainForm.dev.outputChirpRadioButton.Checked = false;
			mainForm.dev.outputSqRadioButton.Checked = false;
			pcmGenerator = (PCMGenerator*)logSweep;
			break;
		}
		global::_003CModule_003E.HOLM_002EGuiHelper_002ESetNumericUpDownValue(mainForm.dev.logSweepStartFreqUpDown, Options.Field.Signal.LogSweepStartFreq);
		global::_003CModule_003E.HOLM_002EGuiHelper_002ESetNumericUpDownValue(mainForm.dev.chirpStartFreqUpDown, Options.Field.Signal.ChirpStartFreq);
		global::_003CModule_003E.HOLM_002EGuiHelper_002ESetNumericUpDownValue(mainForm.dev.chirpPotensUpDown, Options.Field.Signal.ChirpPotens);
		global::_003CModule_003E.HOLM_002EGuiHelper_002ESetNumericUpDownValue(mainForm.dev.sqNoiseAmpUpDown, Options.Field.Signal.SqNoiseAmplitude);
		global::_003CModule_003E.HOLM_002EGuiHelper_002ESetNumericUpDownValue(mainForm.dev.sqNoiseUpDown, Options.Field.Signal.SqNoiseFreq);
		global::_003CModule_003E.HOLM_002EGuiHelper_002ESetNumericUpDownValue(mainForm.dev.signalFadeInUpDown, Options.Field.Signal.FadeInms);
		global::_003CModule_003E.HOLM_002EGuiHelper_002ESetNumericUpDownValue(mainForm.dev.signalFadeOutUpDown, Options.Field.Signal.FadeOutms);
		mainForm.dev.signalFadeInCheckBox.Checked = Options.Field.Signal.FadeIn;
		mainForm.dev.signalFadeOutCheckBox.Checked = Options.Field.Signal.FadeOut;
		*(double*)((byte*)logSweep + 72) = Options.Field.Signal.LogSweepStartFreq;
		*(double*)((byte*)chirp + 72) = Options.Field.Signal.ChirpStartFreq;
		*(double*)((byte*)chirp + 88) = Options.Field.Signal.ChirpPotens;
		*(double*)((byte*)sqNoise + 32) = Options.Field.Signal.SqNoiseFreq;
		*(double*)((byte*)sqNoise + 40) = Options.Field.Signal.SqNoiseAmplitude;
		((byte*)logSweep)[28] = (Options.Field.Signal.FadeIn ? ((byte)1) : ((byte)0));
		((byte*)logSweep)[29] = (Options.Field.Signal.FadeOut ? ((byte)1) : ((byte)0));
		*(float*)((byte*)logSweep + 32) = Options.Field.Signal.FadeInms;
		*(float*)((byte*)logSweep + 36) = Options.Field.Signal.FadeOutms;
		((byte*)chirp)[28] = (Options.Field.Signal.FadeIn ? ((byte)1) : ((byte)0));
		((byte*)chirp)[29] = (Options.Field.Signal.FadeOut ? ((byte)1) : ((byte)0));
		*(float*)((byte*)chirp + 32) = Options.Field.Signal.FadeInms;
		*(float*)((byte*)chirp + 36) = Options.Field.Signal.FadeOutms;
		mainForm.meas.freqWindowHighpassCheckBox.Checked = Options.Field.Filter.HighpassEnabled;
		mainForm.meas.freqWindowLowpassCheckBox.Checked = Options.Field.Filter.LowpassEnabled;
		global::_003CModule_003E.HOLM_002EGuiHelper_002ESetNumericUpDownValue(mainForm.meas.freqWindowHighpassUpDown, Options.Field.Filter.HighpassFreq);
		global::_003CModule_003E.HOLM_002EGuiHelper_002ESetNumericUpDownValue(mainForm.meas.freqWindowLowpassUpDown, Options.Field.Filter.LowpassFreq);
		global::_003CModule_003E.HOLM_002EGuiHelper_002ESetNumericUpDownValue(mainForm.meas.nofTapsUpDown, Options.Field.Filter.NofTaps);
		mainCtrl.UpdateSignal();
		SetMicCalibration(Options.Field.Analysis.MicCalibration);
		SetDacAdcCalibration(Options.Field.Analysis.DacAdcCalibration);
		int apiNumber = Options.Field.Dev.ApiNumber;
		if (apiNumber < mainForm.dev.apiComboBox.Items.Count)
		{
			mainForm.dev.apiComboBox.SelectedIndex = apiNumber;
		}
		PopulateDevices();
		int inputNumber = Options.Field.Dev.InputNumber;
		if (inputNumber < mainForm.dev.inputDevComboBox.Items.Count)
		{
			mainForm.dev.inputDevComboBox.SelectedIndex = inputNumber;
		}
		int outputNumber = Options.Field.Dev.OutputNumber;
		if (outputNumber < mainForm.dev.outputDevComboBox.Items.Count)
		{
			mainForm.dev.outputDevComboBox.SelectedIndex = outputNumber;
		}
		mainForm.dev.output1CheckBox.Checked = global::_003CModule_003E.HOLM_002EPAudioII_002EIsChInMask(0, Options.Field.Dev.OutputChMask);
		mainForm.dev.output2CheckBox.Checked = global::_003CModule_003E.HOLM_002EPAudioII_002EIsChInMask(1, Options.Field.Dev.OutputChMask);
		mainForm.dev.output3CheckBox.Checked = global::_003CModule_003E.HOLM_002EPAudioII_002EIsChInMask(2, Options.Field.Dev.OutputChMask);
		mainForm.dev.output4CheckBox.Checked = global::_003CModule_003E.HOLM_002EPAudioII_002EIsChInMask(3, Options.Field.Dev.OutputChMask);
		byte @checked = ((Options.Field.Dev.InputChannel == 0) ? ((byte)1) : ((byte)0));
		mainForm.dev.input1RadioButton.Checked = @checked != 0;
		byte checked2 = ((Options.Field.Dev.InputChannel == 1) ? ((byte)1) : ((byte)0));
		mainForm.dev.input2RadioButton.Checked = checked2 != 0;
		byte checked3 = ((Options.Field.Dev.InputChannel == 2) ? ((byte)1) : ((byte)0));
		mainForm.dev.input3RadioButton.Checked = checked3 != 0;
		byte checked4 = ((Options.Field.Dev.InputChannel == 3) ? ((byte)1) : ((byte)0));
		mainForm.dev.input4RadioButton.Checked = checked4 != 0;
		UpdateDeviceNumbers();
		global::_003CModule_003E.HOLM_002EGuiHelper_002ESetNumericUpDownValue(mainForm.dev.outputAmpUpDown, Options.Field.Dev.OutputPCMAmplitude);
		global::_003CModule_003E.HOLM_002EGuiHelper_002ESetNumericUpDownValue(mainForm.dev.outputDBUpDown, global::_003CModule_003E.HOLM_002EMath_002EAmplitudeToDB_003Cfloat_003E(Options.Field.Dev.OutputPCMAmplitude));
		global::_003CModule_003E.HOLM_002EGuiHelper_002ESetNumericUpDownValue(mainForm.analysis.saveMUpDown, Options.Field.Analysis.MAnalysis);
		global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementList_002ESetMAnalysis(mainCtrl.container.list, Options.Field.Analysis.MAnalysis);
		AnalysisOptions analysis = Options.Field.Analysis;
		if (analysis.TimeZeroMethod < 0)
		{
			analysis.TimeZeroMethod = 0;
		}
		AnalysisOptions analysis2 = Options.Field.Analysis;
		if (analysis2.TimeZeroMethod > 4)
		{
			analysis2.TimeZeroMethod = 0;
		}
		mainForm.analysis.timeDetectMethodComboBox.SelectedIndex = Options.Field.Analysis.TimeZeroMethod;
		mainForm.analysis.timeDetectInterpolate.Checked = Options.Field.Analysis.TimeZeroInterpolate;
		mainForm.analysis.normalize0dBCheckBox.Checked = Options.Field.Analysis.NormalizeTo0dB;
		mainForm.analysis.timeWindowAutoCheckBox.Checked = Options.Field.Analysis.TimeWindowAutoApply;
		mainForm.analysis.postHighpassCheckBox.Checked = Options.Field.Analysis.HighpassResult;
		mainForm.analysis.nyquistExtCheckBox.Checked = Options.Field.Analysis.ExtendToNyquist;
		global::_003CModule_003E.HOLM_002EGuiHelper_002ESetNumericUpDownValue(mainForm.analysis.nyquistExtUpDown, Options.Field.Analysis.ExtendToNyquistFreq / 1000.0);
		mainForm.menu.waveFormatComboBox.SelectedIndex = Options.Field.Misc.WaveFormat;
		mainForm.analysis.saveMeasWavesCheckBox.Checked = Options.Field.Misc.SaveMeasureWaves;
		TextBox debugOutputTextBox = mainForm.analysis.debugOutputTextBox;
		debugOutputTextBox.Text = Options.Field.Misc.SaveMeasureOutput;
		((TextBoxBase)debugOutputTextBox).SelectAll();
		TextBox debugRecordingTextBox = mainForm.analysis.debugRecordingTextBox;
		debugRecordingTextBox.Text = Options.Field.Misc.SaveMeasureRec;
		((TextBoxBase)debugRecordingTextBox).SelectAll();
		TextBox debugCorrTextBox = mainForm.analysis.debugCorrTextBox;
		debugCorrTextBox.Text = Options.Field.Misc.SaveMeasureCorr;
		((TextBoxBase)debugCorrTextBox).SelectAll();
		fReactOnGuiChanges = true;
	}

	public void InitializeGuiObjects()
	{
		mainForm.meas.recLevelAmpTextBox.Text = "---";
		mainForm.meas.recLevelDBTextBox.Text = "---";
		mainForm.dev.devDelaymsCalTextBox.Text = "---";
		mainForm.analysis.timeZeroLockDetectTextBox.Text = "---";
		((Control)mainForm.dev.deviceKeepStreamCheckBox).Click += Action_KeepStreamAliveClick;
		((Control)mainForm.dev.recordMeterButton).Click += Action_RecordMeter;
		((ToolStripItem)mainForm.menu.recordMeter).Click += Action_RecordMeter;
		mainForm.dev.outputDevComboBox.SelectedIndexChanged += Action_DeviceChanged;
		mainForm.dev.inputDevComboBox.SelectedIndexChanged += Action_DeviceChanged;
		mainForm.dev.signalMUpDown.ValueChanged += Action_MChanged;
		mainForm.analysis.saveMUpDown.ValueChanged += Action_AnalysisLength;
		((Control)mainForm.dev.asioControlButton).Click += Action_ASIOControl;
		((Control)mainForm.dev.devReinitialize).Click += Action_AudioReinitialize;
		mainForm.dev.apiComboBox.SelectedIndexChanged += Action_AudioReinitialize;
		((Control)mainForm.dev.devShowInfoButton).Click += Action_AudioDevShow;
		mainForm.dev.outputAmpUpDown.ValueChanged += Action_OutputDBFSChanged;
		mainForm.dev.outputDBUpDown.ValueChanged += Action_OutputDBFSChanged;
		mainForm.menu.waveFormatComboBox.SelectedIndexChanged += Action_SettingsChanged;
		mainForm.dev.sampleRateComboBox.SelectedIndexChanged += Action_SamplerateChanged;
		((Control)mainForm.dev.calMicCheckBox).Click += Action_CalMicClick;
		((Control)mainForm.dev.calMicImportButton).Click += Action_CalMicOpen;
		((Control)mainForm.dev.calDacAdcCheckBox).Click += Action_CalDacAdcClick;
		((Control)mainForm.dev.calDacAdcImportButton).Click += Action_CalDacAdcOpen;
		((Control)mainForm.dev.calDacAdcMakeButton).Click += Action_CalDacAdcMake;
		((Control)mainForm.analysis.timeZeroLockUseButton).Click += Action_TimeZeroLockUseClick;
		((Control)mainForm.analysis.timeZeroLockHelpButton).Click += Action_TimeZeroLockHelpClick;
		((Control)mainForm.dev.deviceRestartStreamButton).Click += Action_StreamRestart;
		((Control)mainForm.dev.signalSaveButton).Click += Action_SaveSignalToWave;
		((Control)mainForm.dev.signalInverseSaveButton).Click += Action_SaveSignalToWave;
		((Control)mainForm.analysis.debugOutputBrowseButton).Click += Action_DebugInOutBrowse;
		((Control)mainForm.analysis.debugRecordingBrowseButton).Click += Action_DebugInOutBrowse;
		((Control)mainForm.analysis.debugCorrBrowseButton).Click += Action_DebugInOutBrowse;
	}

	[return: MarshalAs(UnmanagedType.U1)]
	public unsafe bool PerformMeasurement(Measurement* meas, string infoString)
	{
		PrePostMeasureSettings();
		string text = "";
		global::_003CModule_003E.HOLM_002EPAudioII_002EStreamInitializer_002ESetOutVolume(global::_003CModule_003E.HOLM_002EPAudioII_002EStream(), Options.Field.Dev.OutputPCMAmplitude);
		int outputChMask = Options.Field.Dev.OutputChMask;
		global::_003CModule_003E.HOLM_002EPAudioII_002EStreamInitializer_002ESetOutChMask(global::_003CModule_003E.HOLM_002EPAudioII_002EStream(), outputChMask);
		if (global::_003CModule_003E.HOLM_002EPAudioII_002EIsChInMask(0, outputChMask))
		{
			text += "Left";
		}
		if (global::_003CModule_003E.HOLM_002EPAudioII_002EIsChInMask(1, outputChMask))
		{
			text += "Right";
		}
		if (global::_003CModule_003E.HOLM_002EPAudioII_002EIsChInMask(2, outputChMask))
		{
			text += "CH3";
		}
		if (global::_003CModule_003E.HOLM_002EPAudioII_002EIsChInMask(3, outputChMask))
		{
			text += "CH4";
		}
		WaitingCtrl.Wait("AudioHelper::PerformMeasurement", "Making measurement");
		string text2 = "Unknown";
		int inputChannel = Options.Field.Dev.InputChannel;
		switch (inputChannel)
		{
		case 0:
			text2 = "Left";
			break;
		case 1:
			text2 = "Right";
			break;
		case 2:
			text2 = "Ch. 3";
			break;
		case 3:
			text2 = "Ch. 4";
			break;
		}
		bool flag = false;
		ResponseGui responseGui = new ResponseGui((Form)(object)mainForm, (Response*)response, fShow: false, fWarning: true);
		ResponseGui.Reset(string.Concat(string.Concat(string.Concat(infoString + " - Out: ", text), " - In: "), text2), fWarning: true);
		ResponseGui.Show((Form)(object)mainForm, fWarning: true);
		uint num = decimal.ToUInt32(mainForm.dev.recMaxDelayUpDown.Value);
		int num2 = *(int*)((byte*)global::_003CModule_003E.HOLM_002EPAudioII_002EStream() + 16);
		*(int*)((byte*)response + 8) = num2 / 1000 * (int)num;
		global::_003CModule_003E.HOLM_002EPAudioII_002EStreamInitializer_002ESetInInverted(global::_003CModule_003E.HOLM_002EPAudioII_002EStream(), Options.Field.Dev.InputInvert);
		((byte*)response)[12] = (Options.Field.Analysis.NormalizeTo0dB ? ((byte)1) : ((byte)0));
		*(int*)((byte*)response + 40) = Options.Field.Analysis.TimeZeroMethod;
		((byte*)response)[24] = (Options.Field.Analysis.TimeZeroInterpolate ? ((byte)1) : ((byte)0));
		((byte*)response)[149] = (Options.Field.Misc.SaveMeasureWaves ? ((byte)1) : ((byte)0));
		System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj);
		basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* ptr = global::_003CModule_003E.HOLM_002EMiscHelper_002EStringToStd(&obj, mainForm.analysis.debugOutputTextBox.Text);
		try
		{
			global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_003D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)((byte*)response + 152), ptr);
		}
		catch
		{
			//try-fault
			global::_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), &obj);
			throw;
		}
		global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D(&obj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj2);
		basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* ptr2 = global::_003CModule_003E.HOLM_002EMiscHelper_002EStringToStd(&obj2, mainForm.analysis.debugRecordingTextBox.Text);
		try
		{
			global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_003D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)((byte*)response + 180), ptr2);
		}
		catch
		{
			//try-fault
			global::_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), &obj2);
			throw;
		}
		global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D(&obj2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj3);
		basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* ptr3 = global::_003CModule_003E.HOLM_002EMiscHelper_002EStringToStd(&obj3, mainForm.analysis.debugCorrTextBox.Text);
		try
		{
			global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_003D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)((byte*)response + 208), ptr3);
		}
		catch
		{
			//try-fault
			global::_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), &obj3);
			throw;
		}
		global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D(&obj3);
		*(WaveFormat*)((byte*)response + 144) = global::_003CModule_003E.HOLM_002EWaveImExport_002ENumberToWaveFormat(Options.Field.Misc.WaveFormat);
		((byte*)response)[13] = (mainForm.analysis.timeZeroLockedRadioButton.Checked ? ((byte)1) : ((byte)0));
		decimal value = mainForm.analysis.timeZeroLockUpDown.Value;
		*(double*)((byte*)response + 16) = decimal.ToDouble(value);
		((byte*)response)[25] = (Options.Field.Analysis.ExtendToNyquist ? ((byte)1) : ((byte)0));
		*(double*)((byte*)response + 32) = Options.Field.Analysis.ExtendToNyquistFreq;
		if (Options.Field.Dev.KeepStreamActive)
		{
			UpdateKeepStreamAlive(flag: true);
		}
		bool flag2;
		if (!mainForm.meas.freqWindowHighpassCheckBox.Checked && !mainForm.meas.freqWindowLowpassCheckBox.Checked)
		{
			flag2 = global::_003CModule_003E.HOLM_002EMeasure_002EResponse_002EMeasure((Response*)response, m, freq, inputChannel, pcmGenerator);
		}
		else
		{
			flag = true;
			decimal value2 = mainForm.meas.nofTapsUpDown.Value;
			global::_003CModule_003E.HOLM_002EMeasure_002EResponse_002ESetNofFilterTaps((Response*)response, decimal.ToInt32(value2));
			if (mainForm.meas.freqWindowHighpassCheckBox.Checked)
			{
				decimal value3 = mainForm.meas.freqWindowHighpassUpDown.Value;
				global::_003CModule_003E.HOLM_002EMeasure_002EResponse_002ESetFilterHighpass((Response*)response, decimal.ToDouble(value3));
			}
			else
			{
				global::_003CModule_003E.HOLM_002EMeasure_002EResponse_002EDisableFilterHighpass((Response*)response);
			}
			if (mainForm.meas.freqWindowLowpassCheckBox.Checked)
			{
				decimal value4 = mainForm.meas.freqWindowLowpassUpDown.Value;
				global::_003CModule_003E.HOLM_002EMeasure_002EResponse_002ESetFilterLowpass((Response*)response, decimal.ToDouble(value4));
			}
			else
			{
				global::_003CModule_003E.HOLM_002EMeasure_002EResponse_002EDisableFilterLowpass((Response*)response);
			}
			flag2 = global::_003CModule_003E.HOLM_002EMeasure_002EResponse_002EMeasureFiltered((Response*)response, m, freq, inputChannel, pcmGenerator, meas);
		}
		if (flag2)
		{
			SignalType signalType = (SignalType)0;
			double num3 = 0.0;
			PCMGenerator* ptr4 = pcmGenerator;
			SineLogSweep* ptr5;
			if (ptr4 == chirp)
			{
				signalType = (SignalType)2;
			}
			else
			{
				ptr5 = logSweep;
				if (ptr4 == ptr5)
				{
					signalType = (SignalType)1;
					num3 = global::_003CModule_003E.HOLM_002EPAudioII_002ESineLogSweep_002EGetHDTimeConstant(ptr5);
				}
				else if (ptr4 == sqNoise)
				{
					signalType = (SignalType)3;
				}
			}
			int mAnalysis = Options.Field.Analysis.MAnalysis;
			int num4 = 1 << mAnalysis;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj4);
			global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D(&obj4, (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref global::_003CModule_003E._003F_003F_C_0040_0BO_0040GEJOEDHL_0040Initializing_003F5measurement_003F5data_003F_0024AA_0040));
			try
			{
				((delegate* unmanaged[Cdecl, Cdecl]<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(int)(*(uint*)((byte*)response + 44)))(&obj4);
			}
			catch
			{
				//try-fault
				global::_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), &obj4);
				throw;
			}
			global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D(&obj4);
			int num5 = L / 2;
			int num6 = num4 / 2;
			int num7 = ((num6 >= num5) ? num5 : num6);
			int num8 = *(int*)((byte*)global::_003CModule_003E.HOLM_002EPAudioII_002EStream() + 16);
			global::_003CModule_003E.HOLM_002EMeasure_002EMeasurement_002EInitializeFreq(meas, freq, L / 2, num8, num7, signalType, num3, 0.0, true);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj5);
			global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D(&obj5, (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref global::_003CModule_003E._003F_003F_C_0040_0BH_0040PNNNMCLM_0040Validating_003F5measurement_003F_0024AA_0040));
			try
			{
				((delegate* unmanaged[Cdecl, Cdecl]<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(int)(*(uint*)((byte*)response + 44)))(&obj5);
			}
			catch
			{
				//try-fault
				global::_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), &obj5);
				throw;
			}
			global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D(&obj5);
			global::_003CModule_003E.HOLM_002EMeasure_002EResponse_002EPostInitializeMeasurement((Response*)response, meas);
			int num9;
			if (flag)
			{
				num9 = global::_003CModule_003E.HOLM_002EMeasure_002EResponse_002EGetNofFilterTaps((Response*)response) / -2;
			}
			else if (pcmGenerator == logSweep)
			{
				double num10 = *(int*)((byte*)global::_003CModule_003E.HOLM_002EPAudioII_002EStream() + 16);
				num9 = global::_003CModule_003E.HOLM_002EMath_002EToIntRound(global::_003CModule_003E.HOLM_002EPAudioII_002ESineLogSweep_002EGetHDTimeConstant(logSweep) * Math.Log(2.0) * num10) / -2;
			}
			else
			{
				num9 = -global::_003CModule_003E.HOLM_002EMath_002EToIntRound((double)(*(int*)((byte*)meas + 64)) * 0.1);
			}
			int num11 = global::_003CModule_003E.HOLM_002EMath_002EToIntRound(*(int*)((byte*)meas + 64));
			global::_003CModule_003E.HOLM_002EMeasure_002EMeasurement_002EPostMeasureStandard(meas, num9, 10, num11, (HOLM.Measure.ApplicationId)1, Options.Field.Analysis.TimeWindowAutoApply);
			PCMGenerator* ptr6 = pcmGenerator;
			ptr5 = logSweep;
			if ((ptr6 == ptr5 || ptr6 == chirp) && Options.Field.Analysis.HighpassResult)
			{
				global::_003CModule_003E.HOLM_002EMeasure_002EMeasurement_002EApplyHighpass(meas, (int)(*(double*)((byte*)ptr5 + 72) * 1.5), (int)(*(double*)((byte*)ptr5 + 72)));
			}
			if (Options.Field.Analysis.NormalizeTo0dB)
			{
				double num12 = 20.0;
				double num13 = (double)(*(int*)((byte*)meas + 64)) * 0.5;
				uint num14 = *(uint*)((byte*)response + 52);
				int num15 = ((num14 != 0 && global::_003CModule_003E.HOLM_002EFilter_002EEffect_002EIsEnabled((Effect*)(int)(*(uint*)(int)(num14 + 136)))) ? 1 : 0);
				if ((byte)num15 != 0)
				{
					num12 = global::_003CModule_003E.HOLM_002EFilter_002EEffectPass_002EGetFreqCenter((EffectPass*)(int)(*(uint*)(*(int*)((byte*)response + 52) + 136))) + global::_003CModule_003E.HOLM_002EFilter_002EEffectPass_002EGetFreqBand((EffectPass*)(int)(*(uint*)(*(int*)((byte*)response + 52) + 136)));
				}
				if (global::_003CModule_003E.HOLM_002EMeasure_002EResponse_002EGetFilterLowpass((Response*)response))
				{
					num13 = global::_003CModule_003E.HOLM_002EFilter_002EEffectPass_002EGetFreqCenter((EffectPass*)(int)(*(uint*)(*(int*)((byte*)response + 52) + 144))) - global::_003CModule_003E.HOLM_002EFilter_002EEffectPass_002EGetFreqBand((EffectPass*)(int)(*(uint*)(*(int*)((byte*)response + 52) + 144)));
				}
				double num16 = global::_003CModule_003E.HOLM_002EMeasure_002EMeasurement_002EGetForgAvg(meas, num12, num13, true);
				double num17 = global::_003CModule_003E.HOLM_002EMeasure_002EMeasurement_002EGetFreqPeak(meas, 10, true);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj6);
				global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D(&obj6, (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref global::_003CModule_003E._003F_003F_C_0040_0CA_0040JCAMGIDD_0040Finding_003F5appropriate_003F5normalizing_003F_0024AA_0040));
				try
				{
					((delegate* unmanaged[Cdecl, Cdecl]<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(int)(*(uint*)((byte*)response + 44)))(&obj6);
				}
				catch
				{
					//try-fault
					global::_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), &obj6);
					throw;
				}
				global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D(&obj6);
				if (num17 != 0.0)
				{
					double num18 = ((!(global::_003CModule_003E.HOLM_002EMath_002EAmplitudeToDB_003Cdouble_003E(num17 / num16) > 10.0)) ? (1.0 / num16) : (global::_003CModule_003E.HOLM_002EMath_002EDBToAmplitude_003Cdouble_003E(10.0) / num17));
					global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementCore_002EAmplify((MeasurementCore*)meas, num18);
				}
			}
			int num19 = global::_003CModule_003E.HOLM_002EPAudioII_002EStreamInitializer_002EGetOutChMask(global::_003CModule_003E.HOLM_002EPAudioII_002EStream());
			*(int*)((byte*)meas + 152) = num19;
			global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementCore_002EPostInitSetDateNow((MeasurementCore*)meas);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj7);
			basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* ptr7 = global::_003CModule_003E.HOLM_002EMiscHelper_002EStringToStd(&obj7, ((Form)mainForm).Text);
			try
			{
				global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_003D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)((byte*)meas + 304), ptr7);
			}
			catch
			{
				//try-fault
				global::_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), &obj7);
				throw;
			}
			global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D(&obj7);
			double num20 = *(double*)((byte*)response + 120);
			StreamInitializer* ptr8 = global::_003CModule_003E.HOLM_002EPAudioII_002EStream();
			double num21 = (currentOffsetMilliSec = num20 * 1000.0 / (double)(*(int*)((byte*)ptr8 + 16)));
			mainForm.dev.devDelaymsCalTextBox.Text = num21.ToString("F0");
			double num22 = num20;
			mainForm.analysis.timeZeroLockDetectTextBox.Text = num22.ToString("F3");
			ResponseGui.PostMeasure();
			((IDisposable)responseGui)?.Dispose();
			WaitingCtrl.DoNotWait("AudioHelper::PerformMeasurement");
			ControlMeasurements meas2 = mainForm.meas;
			ValidateMeasAmp(meas, meas2.recLevelDBTextBox, meas2.recLevelAmpTextBox);
			if (global::_003CModule_003E._003FA0x11fcae0a_002E_003FfFirstRun_0040_003F1_003F_003FPerformMeasurement_0040AudioHelper_0040HOLMImpulse_0040HOLM_0040_0040Q_0024AAM_NPAVMeasurement_0040Measure_00404_0040P_0024AAVString_0040System_0040_0040_0040Z_00404_NA)
			{
				global::_003CModule_003E._003FA0x11fcae0a_002E_003FfFirstRun_0040_003F1_003F_003FPerformMeasurement_0040AudioHelper_0040HOLMImpulse_0040HOLM_0040_0040Q_0024AAM_NPAVMeasurement_0040Measure_00404_0040P_0024AAVString_0040System_0040_0040_0040Z_00404_NA = false;
				((Control)mainForm.analysis.timeZeroLockUseButton).Enabled = true;
			}
		}
		else
		{
			ResponseGui.PostMeasure();
			((IDisposable)responseGui)?.Dispose();
		}
		WaitingCtrl.DoNotWait("AudioHelper::PerformMeasurement");
		((Form)mainForm).Activate();
		return flag2;
	}

	private void Action_DeviceChanged(object sender, EventArgs e)
	{
		if (fReactOnGuiChanges)
		{
			Options.Field.Dev.InputNumber = mainForm.dev.inputDevComboBox.SelectedIndex;
			Options.Field.Dev.OutputNumber = mainForm.dev.outputDevComboBox.SelectedIndex;
			UpdateDeviceNumbers();
		}
	}

	private void Action_KeepStreamAliveClick(object sender, EventArgs e)
	{
		if (fReactOnGuiChanges)
		{
			UpdateKeepStreamAlive(mainForm.dev.deviceKeepStreamCheckBox.Checked);
			Options.Field.Dev.KeepStreamActive = mainForm.dev.deviceKeepStreamCheckBox.Checked;
		}
	}

	private unsafe void Action_StreamRestart(object sender, EventArgs e)
	{
		fReactOnGuiChanges = false;
		global::_003CModule_003E.HOLM_002EPAudioII_002EStreamInitializer_002EStop(global::_003CModule_003E.HOLM_002EPAudioII_002EStream());
		Options.Field.Dev.KeepStreamActive = true;
		mainForm.dev.deviceKeepStreamCheckBox.Checked = true;
		UpdateKeepStreamAlive(flag: true);
		fReactOnGuiChanges = true;
	}

	private void Action_MChanged(object sender, EventArgs e)
	{
		decimal value = mainForm.dev.signalMUpDown.Value;
		m = decimal.ToInt32(value);
		UpdateSignalLength();
	}

	private unsafe void Action_ASIOControl(object sender, EventArgs e)
	{
		IntPtr handle = ((Control)mainForm).Handle;
		uint num = *(uint*)((byte*)global::_003CModule_003E.HOLM_002EPAudioII_002EStream() + 24);
		global::_003CModule_003E.PaAsio_ShowControlPanel((num == 0) ? (-1) : (*(int*)(int)num), handle.ToPointer());
	}

	private void Action_RecordMeter(object sender, EventArgs e)
	{
		if (VUMeterCtrl.Visible())
		{
			VUMeterCtrl.Hide();
			return;
		}
		Options.Field.Dev.KeepStreamActive = true;
		mainForm.dev.deviceKeepStreamCheckBox.Checked = true;
		UpdateKeepStreamAlive(flag: true);
		VUMeterCtrl.Show();
	}

	private unsafe void Action_AudioReinitialize(object sender, EventArgs e)
	{
		if (fReactOnGuiChanges)
		{
			global::_003CModule_003E.HOLM_002EPAudioII_002EStream();
			UpdateKeepStreamAlive(flag: false);
			global::_003CModule_003E.HOLM_002EPAudioII_002EPaInitializer_002EReInitialize();
			PopulateDevices();
			UpdateDeviceNumbers();
		}
	}

	private unsafe void Action_AudioDevShow(object sender, EventArgs e)
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj);
		global::_003CModule_003E.std_002Ebasic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D(&obj, 3, 1);
		try
		{
			global::_003CModule_003E.HOLM_002EPAudioII_002EShowDeviceInfo(&obj);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj2);
			basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* ptr = global::_003CModule_003E.std_002Ebasic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002Estr(&obj, &obj2);
			try
			{
				string info = new string(global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002Ec_str(ptr));
				mainCtrl.dialog.ShowInfoHolm(info);
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
	}

	private void Action_CalMicClick(object sender, EventArgs e)
	{
		SetMicCalibration(mainForm.dev.calMicCheckBox.Checked);
	}

	private unsafe void Action_CalMicOpen(object sender, EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Invalid comparison between Unknown and I4
		OpenFileDialog val = new OpenFileDialog();
		((FileDialog)val).Filter = "Calibration (*.cal)|*.cal|Text (*.txt)|*.txt|All Files (*.*)|*.*";
		((FileDialog)val).Title = "Open Microphone Calibration";
		if ((int)((CommonDialog)val).ShowDialog() == 1)
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj);
			global::_003CModule_003E.HOLM_002EMiscHelper_002EStringToStd(&obj, ((FileDialog)val).FileName);
			try
			{
				if (global::_003CModule_003E.HOLM_002EMeasure_002ECalibrator_002EOpen(calMic, &obj))
				{
					global::_003CModule_003E.HOLM_002EMeasure_002ECalibrator_002ESetActive(calMic, true);
					System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj2);
					basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* ptr = &obj2;
					basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* fileName = global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D(&obj2, (basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref global::_003CModule_003E.HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x11fcae0a_002ECAL_MIC_FILENAME));
					System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj3);
					basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* ptr2 = global::_003CModule_003E.HOLM_002EHOLMImpulse_002EConf_002EFilePath(&obj3, fileName, false);
					try
					{
						global::_003CModule_003E.HOLM_002EMeasure_002ECalibrator_002ESave(calMic, ptr2);
					}
					catch
					{
						//try-fault
						global::_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), &obj3);
						throw;
					}
					global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D(&obj3);
					mainCtrl.dialog.ShowInfo("Microphone calibration successfully imported\n" + "(The calibration is actived)");
					Options.Field.Analysis.MicCalibration = true;
					mainForm.dev.calMicCheckBox.Checked = true;
					((Control)mainForm.dev.calMicCheckBox).Enabled = true;
				}
				else
				{
					mainCtrl.dialog.ShowInfo("Microphone calibration could not be imported!");
				}
			}
			catch
			{
				//try-fault
				global::_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), &obj);
				throw;
			}
			global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D(&obj);
		}
		((IDisposable)val)?.Dispose();
	}

	private void Action_CalDacAdcClick(object sender, EventArgs e)
	{
		SetDacAdcCalibration(mainForm.dev.calDacAdcCheckBox.Checked);
	}

	private unsafe void Action_CalDacAdcOpen(object sender, EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Invalid comparison between Unknown and I4
		OpenFileDialog val = new OpenFileDialog();
		((FileDialog)val).Filter = "Calibration (*.cal)|*.cal|Text (*.txt)|*.txt|All Files (*.*)|*.*";
		((FileDialog)val).Title = "Open DAC-ADC Calibration";
		if ((int)((CommonDialog)val).ShowDialog() == 1)
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj);
			global::_003CModule_003E.HOLM_002EMiscHelper_002EStringToStd(&obj, ((FileDialog)val).FileName);
			try
			{
				if (global::_003CModule_003E.HOLM_002EMeasure_002ECalibrator_002EOpen(calDacAdc, &obj))
				{
					System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj2);
					basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* ptr = &obj2;
					basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* fileName = global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D(&obj2, (basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref global::_003CModule_003E.HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x11fcae0a_002ECAL_DACADC_FILENAME));
					System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj3);
					basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* ptr2 = global::_003CModule_003E.HOLM_002EHOLMImpulse_002EConf_002EFilePath(&obj3, fileName, false);
					try
					{
						global::_003CModule_003E.HOLM_002EMeasure_002ECalibrator_002ESave(calDacAdc, ptr2);
					}
					catch
					{
						//try-fault
						global::_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), &obj3);
						throw;
					}
					global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D(&obj3);
					mainCtrl.dialog.ShowInfo("DAC-ADC calibration successfully imported\n" + "(The calibration is actived)");
					Options.Field.Analysis.DacAdcCalibration = true;
					mainForm.dev.calDacAdcCheckBox.Checked = true;
					((Control)mainForm.dev.calDacAdcCheckBox).Enabled = true;
				}
				else
				{
					mainCtrl.dialog.ShowInfo("DAC-ADC calibration could not be imported!");
				}
			}
			catch
			{
				//try-fault
				global::_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), &obj);
				throw;
			}
			global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D(&obj);
		}
		((IDisposable)val)?.Dispose();
	}

	private unsafe void Action_CalDacAdcMake(object sender, EventArgs e)
	{
		mainForm.mainTabControl.SelectedIndex = 1;
		this.mainCtrl.dialog.ShowInfo(string.Concat(string.Concat("Make a Loopback measurement.\n\nConnect the Output of:\n" + mainForm.dev.outputDevComboBox.Text, "\n\nTo the Input of:\n"), mainForm.dev.inputDevComboBox.Text));
		string question = "Measure Loopback now?";
		if (!this.mainCtrl.dialog.ShowQuestionOKCancelHolm(question))
		{
			return;
		}
		SaveToOptions();
		SignalOptions signal = Options.Field.Signal;
		AnalysisOptions analysis = Options.Field.Analysis;
		Options.Field.Signal = new SignalOptions();
		Options.Field.Analysis = new AnalysisOptions();
		Options.Field.Signal.SignalType = 0;
		if (Options.Field.Dev.SamplerateNo > 1)
		{
			Options.Field.Signal.SignalLength = 20;
		}
		else
		{
			Options.Field.Signal.SignalLength = 19;
		}
		Options.Field.Signal.LogSweepStartFreq = 5.0;
		Options.Field.Analysis.NormalizeTo0dB = true;
		Options.Field.Analysis.TimeZeroMethod = 0;
		Options.Field.Analysis.TimeZeroInterpolate = true;
		Options.Field.Analysis.ExtendToNyquist = false;
		mainForm.analysis.timeZeroLockedRadioButton.Checked = false;
		LoadFromOptions();
		Form1 form = mainForm;
		form.mainTabControl.SelectedTab = form.measurementTab;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj2);
		bool flag5;
		do
		{
			global::_003CModule_003E.HOLM_002EMeasure_002ECalibrator_002ESetActive(calDacAdc, false);
			Calibrator* ptr = calMic;
			bool flag = ((byte*)ptr)[96] != 0;
			global::_003CModule_003E.HOLM_002EMeasure_002ECalibrator_002ESetActive(ptr, false);
			bool flag2 = PerformMeasurement(this.mainCtrl.container.presenter[0].measPtr, "A - Loopback");
			global::_003CModule_003E.HOLM_002EMeasure_002ECalibrator_002ESetActive(calMic, flag);
			MainCtrl mainCtrl = this.mainCtrl;
			mainCtrl.impulseGraph.AutoZoom(fTime: false);
			mainCtrl.impulseGraph.UpdatePlotArea();
			mainCtrl.freqGraph.UpdatePlotArea();
			if (flag2)
			{
				this.mainCtrl.container.formpresenter[0].SetText("DAC-ADC Loopback");
				Measurement* measPtr = this.mainCtrl.container.presenter[0].measPtr;
				global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementCore_002ESetImpulseWindowEnabled((MeasurementCore*)measPtr, true);
				Measurement* num = measPtr;
				global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementCore_002ESetImpulseWindowStart((MeasurementCore*)num, -global::_003CModule_003E.HOLM_002EMath_002EToIntRound((double)(*(int*)((byte*)num + 64)) * 0.5), true);
				Measurement* num2 = measPtr;
				global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementCore_002ESetImpulseWindowEnd((MeasurementCore*)num2, global::_003CModule_003E.HOLM_002EMath_002EToIntRound((double)(*(int*)((byte*)num2 + 64)) * 0.5));
				int num3 = 0;
				double* ptr2 = global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementCore_002EGetA((MeasurementCore*)measPtr);
				double num4 = global::_003CModule_003E.HOLM_002EMath_002EDBToAmplitude_003Cdouble_003E(-6.0);
				int num5 = *(int*)((byte*)measPtr + 52);
				int num6 = num5 - 1;
				if (num6 > 0)
				{
					while (num3 == 0)
					{
						if (*(double*)(num6 * 8 + (byte*)ptr2) > num4)
						{
							num3 = num6;
						}
						num6--;
						if (num6 <= 0)
						{
							break;
						}
					}
				}
				int num7 = num3;
				int num8 = 1;
				if (1 < num5)
				{
					while (num7 == num3)
					{
						if (*(double*)(num8 * 8 + (byte*)ptr2) > num4)
						{
							num7 = num8;
						}
						num8++;
						if (num8 >= num5)
						{
							break;
						}
					}
				}
				double num9 = (double)num3 * *(double*)((byte*)measPtr + 40);
				double num10 = (double)num7 * *(double*)((byte*)measPtr + 40);
				double num11 = num9;
				double num12 = num10;
				string question2 = string.Concat(string.Concat(string.Concat(string.Concat(string.Concat("The measurement was valid within +/- 6dB\n" + "From ", num12.ToString("F0")), "Hz to "), num11.ToString("F0")), "Hz\n"), "Use this measurement to generate DAC-ADC calibration?");
				if (this.mainCtrl.dialog.ShowQuestionYesNoHolm(question2))
				{
					global::_003CModule_003E.HOLM_002EMeasure_002ECalibrator_002EImport(calDacAdc, measPtr, num10, num9);
					basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* ptr3 = &obj;
					basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* fileName = global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D(&obj, (basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref global::_003CModule_003E.HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x11fcae0a_002ECAL_DACADC_FILENAME));
					basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* ptr4 = global::_003CModule_003E.HOLM_002EHOLMImpulse_002EConf_002EFilePath(&obj2, fileName, false);
					try
					{
						global::_003CModule_003E.HOLM_002EMeasure_002ECalibrator_002ESave(calDacAdc, ptr4);
					}
					catch
					{
						//try-fault
						global::_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), &obj2);
						throw;
					}
					global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D(&obj2);
					SetDacAdcCalibration(flag: true);
					global::_003CModule_003E.HOLM_002EMeasure_002ECalibrator_002ESetActive(calMic, false);
					bool flag3 = PerformMeasurement(this.mainCtrl.container.presenter[1].measPtr, "B - Loopback");
					global::_003CModule_003E.HOLM_002EMeasure_002ECalibrator_002ESetActive(calMic, flag);
					if (flag3)
					{
						measPtr = this.mainCtrl.container.presenter[1].measPtr;
						global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementCore_002ESetImpulseWindowEnabled((MeasurementCore*)measPtr, true);
						Measurement* num13 = measPtr;
						global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementCore_002ESetImpulseWindowStart((MeasurementCore*)num13, -global::_003CModule_003E.HOLM_002EMath_002EToIntRound((double)(*(int*)((byte*)num13 + 64)) * 0.5), true);
						Measurement* num14 = measPtr;
						global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementCore_002ESetImpulseWindowEnd((MeasurementCore*)num14, global::_003CModule_003E.HOLM_002EMath_002EToIntRound((double)(*(int*)((byte*)num14 + 64)) * 0.5));
						MainCtrl mainCtrl2 = this.mainCtrl;
						mainCtrl2.impulseGraph.UpdatePlotArea();
						mainCtrl2.freqGraph.UpdatePlotArea();
						this.mainCtrl.container.formpresenter[1].SetText("DAC-ADC Loopback Calibrated");
						string question3 = "Enable this DAC-ADC calibration?";
						bool flag4 = this.mainCtrl.dialog.ShowQuestionYesNoHolm(question3);
						global::_003CModule_003E.HOLM_002EMeasure_002ECalibrator_002ESetActive(calDacAdc, flag4);
						analysis.DacAdcCalibration = flag4;
					}
					flag5 = false;
				}
				else
				{
					string question4 = "Measure Loopback again?";
					flag5 = this.mainCtrl.dialog.ShowQuestionOKCancelHolm(question4);
				}
			}
			else
			{
				string question5 = "Measurement failed. for Unknown reason\nTry again?";
				flag5 = this.mainCtrl.dialog.ShowQuestionYesNoHolm(question5);
			}
			if (analysis != null && signal != null)
			{
				Options.Field.Signal = signal;
				Options.Field.Analysis = analysis;
				LoadFromOptions();
			}
		}
		while (flag5);
	}

	private void Action_SamplerateChanged(object sender, EventArgs e)
	{
		if (fReactOnGuiChanges)
		{
			SetSamplerateNo(mainForm.dev.sampleRateComboBox.SelectedIndex);
		}
	}

	private unsafe void Action_AnalysisLength(object sender, EventArgs e)
	{
		if (fReactOnGuiChanges)
		{
			WaitingCtrl.Wait("AudioHelper::Action_AnalysisLength", "Updating FFT size for all measurements");
			decimal value = mainForm.analysis.saveMUpDown.Value;
			Options.Field.Analysis.MAnalysis = decimal.ToInt32(value);
			int num = 1 << Options.Field.Analysis.MAnalysis;
			int num2 = num;
			mainForm.analysis.saveSamplesTextBox.Text = num2.ToString("F0");
			double num3 = (double)(*(int*)((byte*)global::_003CModule_003E.HOLM_002EPAudioII_002EStream() + 16)) / (double)num;
			mainForm.analysis.fftSizeResHzTextBox.Text = num3.ToString("F2");
			global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementList_002ESetMAnalysis(this.mainCtrl.container.list, Options.Field.Analysis.MAnalysis);
			MainCtrl mainCtrl = this.mainCtrl;
			mainCtrl.impulseGraph.UpdatePlotArea();
			mainCtrl.freqGraph.UpdatePlotArea();
			WaitingCtrl.DoNotWait("AudioHelper::Action_AnalysisLength");
		}
	}

	private unsafe void Action_SaveSignalToWave(object sender, EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Invalid comparison between Unknown and I4
		SaveFileDialog val = new SaveFileDialog();
		((FileDialog)val).Filter = "Wave file (*.wav)|*.wav|" + "All Files (*.*)|*.*";
		((FileDialog)val).Title = string.Concat("Save as wave file (Settings > Format: " + ((ToolStripControlHost)mainForm.menu.waveFormatComboBox).Text, ")");
		string fullName = Directory.GetParent(Application.UserAppDataPath).FullName;
		((FileDialog)val).InitialDirectory = fullName;
		bool fInverse = sender == mainForm.dev.signalInverseSaveButton;
		if ((int)((CommonDialog)val).ShowDialog() == 1)
		{
			WaitingCtrl.Wait("AudioHelper::Action_SaveSignalToWave", "Saving signal");
			PrePostMeasureSettings();
			System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj);
			global::_003CModule_003E.HOLM_002EMiscHelper_002EStringToStd(&obj, ((FileDialog)val).FileName);
			try
			{
				WaveFormat waveformat = global::_003CModule_003E.HOLM_002EWaveImExport_002ENumberToWaveFormat(Options.Field.Misc.WaveFormat);
				((byte*)response)[148] = (mainForm.dev.signalSaveExtendZeroesCheckBox.Checked ? ((byte)1) : ((byte)0));
				System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj2);
				basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* pThis = &obj2;
				basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* filename = global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D(&obj2, &obj);
				ResponseSaveOpenWave* ptr;
				int corrM;
				PCMGenerator* pcmgen;
				try
				{
					ptr = response;
					corrM = m;
					pcmgen = pcmGenerator;
				}
				catch
				{
					//try-fault
					global::_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), pThis);
					throw;
				}
				global::_003CModule_003E.HOLM_002EMeasure_002EResponseSaveOpenWave_002ESaveSignal(ptr, corrM, filename, pcmgen, waveformat, fInverse);
				WaitingCtrl.DoNotWait("AudioHelper::Action_SaveSignalToWave");
			}
			catch
			{
				//try-fault
				global::_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), &obj);
				throw;
			}
			global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D(&obj);
		}
		((IDisposable)val)?.Dispose();
	}

	private void Action_SettingsChanged(object sender, EventArgs e)
	{
		if (fReactOnGuiChanges)
		{
			((ToolStripDropDownItem)mainForm.menu.settingsMenu).HideDropDown();
			Options.Field.Misc.WaveFormat = mainForm.menu.waveFormatComboBox.SelectedIndex;
		}
	}

	private void Action_DebugInOutBrowse(object sender, EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Invalid comparison between Unknown and I4
		SaveFileDialog val = new SaveFileDialog();
		((FileDialog)val).Filter = "Wave file (*.wav)|*.wav|" + "All Files (*.*)|*.*";
		((FileDialog)val).Title = string.Concat("Save as wave file (Settings > Format: " + ((ToolStripControlHost)mainForm.menu.waveFormatComboBox).Text, ")");
		string fullName = Directory.GetParent(Application.UserAppDataPath).FullName;
		((FileDialog)val).InitialDirectory = fullName;
		((FileDialog)val).CheckFileExists = false;
		if ((int)((CommonDialog)val).ShowDialog() == 1)
		{
			ControlDataAnalysis analysis = mainForm.analysis;
			if (sender == analysis.debugRecordingBrowseButton)
			{
				string fileName = ((FileDialog)val).FileName;
				TextBox debugRecordingTextBox = mainForm.analysis.debugRecordingTextBox;
				debugRecordingTextBox.Text = fileName;
				((TextBoxBase)debugRecordingTextBox).SelectAll();
			}
			else if (sender == analysis.debugOutputBrowseButton)
			{
				string fileName2 = ((FileDialog)val).FileName;
				TextBox debugOutputTextBox = mainForm.analysis.debugOutputTextBox;
				debugOutputTextBox.Text = fileName2;
				((TextBoxBase)debugOutputTextBox).SelectAll();
			}
			else if (sender == analysis.debugCorrBrowseButton)
			{
				string fileName3 = ((FileDialog)val).FileName;
				TextBox debugCorrTextBox = mainForm.analysis.debugCorrTextBox;
				debugCorrTextBox.Text = fileName3;
				((TextBoxBase)debugCorrTextBox).SelectAll();
			}
		}
	}

	private void Action_OutputDBFSChanged(object sender, EventArgs e)
	{
		if (!fReactOnGuiChanges)
		{
			return;
		}
		fReactOnGuiChanges = false;
		ControlDevSignal dev = mainForm.dev;
		if (sender == dev.outputAmpUpDown)
		{
			double num = global::_003CModule_003E.HOLM_002EMath_002EAmplitudeToDB_003Cdouble_003E(decimal.ToDouble(dev.outputAmpUpDown.Value));
			num = global::_003CModule_003E.HOLM_002EMath_002EToIntRound(num);
			if (num > 0.0)
			{
				num = 0.0;
			}
			global::_003CModule_003E.HOLM_002EGuiHelper_002ESetNumericUpDownValue(mainForm.dev.outputDBUpDown, num);
		}
		double num2 = global::_003CModule_003E.HOLM_002EMath_002EDBToAmplitude_003Cdouble_003E(decimal.ToDouble(mainForm.dev.outputDBUpDown.Value));
		global::_003CModule_003E.HOLM_002EGuiHelper_002ESetNumericUpDownValue(mainForm.dev.outputAmpUpDown, num2);
		Options.Field.Dev.OutputPCMAmplitude = (float)num2;
		fReactOnGuiChanges = true;
	}

	private unsafe void Action_TimeZeroLockUseClick(object sender, EventArgs e)
	{
		global::_003CModule_003E.HOLM_002EGuiHelper_002ESetNumericUpDownValue(mainForm.analysis.timeZeroLockUpDown, *(double*)((byte*)response + 120));
	}

	private void Action_TimeZeroLockHelpClick(object sender, EventArgs e)
	{
		mainCtrl.dialog.ShowInfoHolm(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat("Instructions in how to use 'Time zero locked' (Time alignment)\n\n\n" + "1. 'Device & Signal' > 'Keep in/out stream active' must be checked\n\n", "2. 'Data analysis' > 'Detect time zero' must be checked\n\n"), "3. Make a measurement\n\n"), "4. 'Data analysis' > 'Time zero locked' > Click 'Use'\n\n"), "5. Reproduce mesurement to see that the time lock works\n\n"), "6. Make new measurements for other drivers/positions"));
	}

	private unsafe void PrePostMeasureSettings()
	{
		ref double logSweepStartFreq = ref Options.Field.Signal.LogSweepStartFreq;
		decimal value = mainForm.dev.logSweepStartFreqUpDown.Value;
		logSweepStartFreq = decimal.ToDouble(value);
		ref double chirpStartFreq = ref Options.Field.Signal.ChirpStartFreq;
		decimal value2 = mainForm.dev.chirpStartFreqUpDown.Value;
		chirpStartFreq = decimal.ToDouble(value2);
		ref double chirpPotens = ref Options.Field.Signal.ChirpPotens;
		decimal value3 = mainForm.dev.chirpPotensUpDown.Value;
		chirpPotens = decimal.ToDouble(value3);
		ref double sqNoiseAmplitude = ref Options.Field.Signal.SqNoiseAmplitude;
		decimal value4 = mainForm.dev.sqNoiseAmpUpDown.Value;
		sqNoiseAmplitude = decimal.ToDouble(value4);
		ref double sqNoiseFreq = ref Options.Field.Signal.SqNoiseFreq;
		decimal value5 = mainForm.dev.sqNoiseUpDown.Value;
		sqNoiseFreq = decimal.ToDouble(value5);
		ref float fadeInms = ref Options.Field.Signal.FadeInms;
		decimal value6 = mainForm.dev.signalFadeInUpDown.Value;
		fadeInms = (float)decimal.ToDouble(value6);
		ref float fadeOutms = ref Options.Field.Signal.FadeOutms;
		decimal value7 = mainForm.dev.signalFadeOutUpDown.Value;
		fadeOutms = (float)decimal.ToDouble(value7);
		Options.Field.Signal.FadeIn = mainForm.dev.signalFadeInCheckBox.Checked;
		Options.Field.Signal.FadeOut = mainForm.dev.signalFadeOutCheckBox.Checked;
		*(double*)((byte*)logSweep + 72) = Options.Field.Signal.LogSweepStartFreq;
		*(double*)((byte*)chirp + 72) = Options.Field.Signal.ChirpStartFreq;
		*(double*)((byte*)chirp + 88) = Options.Field.Signal.ChirpPotens;
		*(double*)((byte*)sqNoise + 32) = Options.Field.Signal.SqNoiseFreq;
		*(double*)((byte*)sqNoise + 40) = Options.Field.Signal.SqNoiseAmplitude;
		((byte*)logSweep)[28] = (Options.Field.Signal.FadeIn ? ((byte)1) : ((byte)0));
		((byte*)logSweep)[29] = (Options.Field.Signal.FadeOut ? ((byte)1) : ((byte)0));
		*(float*)((byte*)logSweep + 32) = Options.Field.Signal.FadeInms;
		*(float*)((byte*)logSweep + 36) = Options.Field.Signal.FadeOutms;
		((byte*)chirp)[28] = (Options.Field.Signal.FadeIn ? ((byte)1) : ((byte)0));
		((byte*)chirp)[29] = (Options.Field.Signal.FadeOut ? ((byte)1) : ((byte)0));
		*(float*)((byte*)chirp + 32) = Options.Field.Signal.FadeInms;
		*(float*)((byte*)chirp + 36) = Options.Field.Signal.FadeOutms;
		if (mainForm.dev.input1RadioButton.Checked)
		{
			Options.Field.Dev.InputChannel = 0;
		}
		else if (mainForm.dev.input2RadioButton.Checked)
		{
			Options.Field.Dev.InputChannel = 1;
		}
		else if (mainForm.dev.input3RadioButton.Checked)
		{
			Options.Field.Dev.InputChannel = 2;
		}
		else if (mainForm.dev.input4RadioButton.Checked)
		{
			Options.Field.Dev.InputChannel = 3;
		}
		Options.Field.Dev.InputInvert = mainForm.dev.inputInvertCheckBox.Checked;
		Options.Field.Dev.OutputChMask = 0;
		if (mainForm.dev.output1CheckBox.Checked)
		{
			DevOptions dev = Options.Field.Dev;
			Options.Field.Dev.OutputChMask = global::_003CModule_003E.HOLM_002EPAudioII_002EChToChMask(0) | dev.OutputChMask;
		}
		if (mainForm.dev.output2CheckBox.Checked)
		{
			DevOptions dev2 = Options.Field.Dev;
			Options.Field.Dev.OutputChMask = global::_003CModule_003E.HOLM_002EPAudioII_002EChToChMask(1) | dev2.OutputChMask;
		}
		if (mainForm.dev.output3CheckBox.Checked)
		{
			DevOptions dev3 = Options.Field.Dev;
			Options.Field.Dev.OutputChMask = global::_003CModule_003E.HOLM_002EPAudioII_002EChToChMask(2) | dev3.OutputChMask;
		}
		if (mainForm.dev.output4CheckBox.Checked)
		{
			DevOptions dev4 = Options.Field.Dev;
			Options.Field.Dev.OutputChMask = global::_003CModule_003E.HOLM_002EPAudioII_002EChToChMask(3) | dev4.OutputChMask;
		}
		if (mainForm.dev.outputChirpRadioButton.Checked)
		{
			pcmGenerator = (PCMGenerator*)chirp;
		}
		else if (mainForm.dev.outputSqRadioButton.Checked)
		{
			pcmGenerator = (PCMGenerator*)sqNoise;
		}
		else if (mainForm.dev.outputLogSweepRadioButton.Checked)
		{
			pcmGenerator = (PCMGenerator*)logSweep;
		}
		Options.Field.Analysis.HighpassResult = mainForm.analysis.postHighpassCheckBox.Checked;
		Options.Field.Analysis.NormalizeTo0dB = mainForm.analysis.normalize0dBCheckBox.Checked;
		Options.Field.Analysis.TimeWindowAutoApply = mainForm.analysis.timeWindowAutoCheckBox.Checked;
		Options.Field.Analysis.TimeZeroMethod = mainForm.analysis.timeDetectMethodComboBox.SelectedIndex;
		Options.Field.Analysis.TimeZeroInterpolate = mainForm.analysis.timeDetectInterpolate.Checked;
		Options.Field.Analysis.ExtendToNyquist = mainForm.analysis.nyquistExtCheckBox.Checked;
		decimal value8 = mainForm.analysis.nyquistExtUpDown.Value;
		Options.Field.Analysis.ExtendToNyquistFreq = decimal.ToDouble(value8) * 1000.0;
		Options.Field.Misc.SaveMeasureWaves = mainForm.analysis.saveMeasWavesCheckBox.Checked;
	}

	private unsafe void UpdateASIOAvailable()
	{
		uint num = *(uint*)((byte*)global::_003CModule_003E.HOLM_002EPAudioII_002EStream() + 24);
		int num2 = ((num == 0) ? (-1) : (*(int*)(int)num));
		System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj);
		basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* ptr = global::_003CModule_003E.HOLM_002EPAudioII_002EGetHostApiName(&obj, num2);
		try
		{
			((Control)mainForm.dev.asioControlButton).Enabled = global::_003CModule_003E.std_002Eoperator_003D_003D_003Cchar_002Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_002Cclass_0020std_003A_003Aallocator_003Cchar_003E_0020_003E(ptr, (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref global::_003CModule_003E._003F_003F_C_0040_04INFMDMNC_0040ASIO_003F_0024AA_0040));
		}
		catch
		{
			//try-fault
			global::_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), &obj);
			throw;
		}
		global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D(&obj);
	}

	private unsafe void UpdateDeviceNumbers()
	{
		global::_003CModule_003E.HOLM_002EPAudioII_002EStreamInitializer_002EStop(global::_003CModule_003E.HOLM_002EPAudioII_002EStream());
		((ButtonBase)mainForm.dev.deviceRestartStreamButton).Text = "Start stream";
		((ToolStripItem)mainForm.toolStripStatusLabel1).Text = "Audiostream stopped";
		DevOptions dev = Options.Field.Dev;
		int inputNumber = dev.InputNumber;
		int outputNumber = dev.OutputNumber;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj);
		global::_003CModule_003E.std_002Ebasic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D(&obj, 3, 1);
		try
		{
			global::_003CModule_003E.std_002Eoperator_003C_003C_003Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_0020_003E(global::_003CModule_003E.std_002Ebasic_ostream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E_002E_003C_003C(global::_003CModule_003E.std_002Eoperator_003C_003C_003Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_0020_003E(global::_003CModule_003E.std_002Ebasic_ostream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E_002E_003C_003C(global::_003CModule_003E.std_002Eoperator_003C_003C_003Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_0020_003E(global::_003CModule_003E.std_002Eoperator_003C_003C_003Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_0020_003E((basic_ostream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 8)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref global::_003CModule_003E._003F_003F_C_0040_08ECDPJEFA_0040INFO_003F5_003F5_003F5_003F5_003F_0024AA_0040)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref global::_003CModule_003E._003F_003F_C_0040_0CI_0040GHGIKBJI_0040AudioHelper_003F3_003F3UpdateDeviceNumbers_0040)), inputNumber), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref global::_003CModule_003E._003F_003F_C_0040_07JPFAGAHC_0040_003F5Out_003F5_003F_0024DN_003F5_003F_0024AA_0040)), outputNumber), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref global::_003CModule_003E._003F_003F_C_0040_01EEMJAFIK_0040_003F6_003F_0024AA_0040));
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
		if (inputNumber >= 0)
		{
			vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E* ptr2 = inputDevs;
			vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E* ptr3 = ptr2;
			if ((uint)inputNumber < (uint)(*(int*)((byte*)ptr3 + 16) - *(int*)((byte*)ptr3 + 12) >> 2))
			{
				vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E* ptr4 = ptr2;
				if ((uint)inputNumber >= (uint)(*(int*)((byte*)ptr4 + 16) - *(int*)((byte*)ptr4 + 12) >> 2))
				{
					global::_003CModule_003E._invalid_parameter_noinfo();
				}
				PaDeviceInfo* ptr5 = global::_003CModule_003E.HOLM_002EPAudioII_002EGetDeviceInfo(*(int*)(inputNumber * 4 + *(int*)((byte*)ptr4 + 12)));
				System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj3);
				global::_003CModule_003E.std_002Ebasic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D(&obj3, 3, 1);
				try
				{
					global::_003CModule_003E.std_002Eoperator_003C_003C_003Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_0020_003E(global::_003CModule_003E.std_002Ebasic_ostream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E_002E_003C_003C(global::_003CModule_003E.std_002Eoperator_003C_003C_003Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_0020_003E(global::_003CModule_003E.std_002Eoperator_003C_003C_003Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_0020_003E((basic_ostream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj3, 8)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref global::_003CModule_003E._003F_003F_C_0040_08ECDPJEFA_0040INFO_003F5_003F5_003F5_003F5_003F_0024AA_0040)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref global::_003CModule_003E._003F_003F_C_0040_0DF_0040NIIKCJBB_0040AudioHelper_003F3_003F3UpdateDeviceNumbers_0040)), *(int*)((byte*)ptr5 + 12)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref global::_003CModule_003E._003F_003F_C_0040_01EEMJAFIK_0040_003F6_003F_0024AA_0040));
					System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj4);
					basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* ptr6 = global::_003CModule_003E.std_002Ebasic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002Estr(&obj3, &obj4);
					try
					{
						global::_003CModule_003E.HOLM_002ELogging_002EHolmLogger_002ELogText(ptr6);
					}
					catch
					{
						//try-fault
						global::_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), &obj4);
						throw;
					}
					global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D(&obj4);
				}
				catch
				{
					//try-fault
					global::_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&global::_003CModule_003E.std_002Ebasic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E__vbaseDtor), &obj3);
					throw;
				}
				global::_003CModule_003E.std_002Ebasic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E__vbaseDtor(&obj3);
				byte visible = ((*(int*)((byte*)ptr5 + 12) > 0) ? ((byte)1) : ((byte)0));
				((Control)mainForm.dev.input1RadioButton).Visible = visible != 0;
				byte visible2 = ((*(int*)((byte*)ptr5 + 12) > 1) ? ((byte)1) : ((byte)0));
				((Control)mainForm.dev.input2RadioButton).Visible = visible2 != 0;
				byte visible3 = ((*(int*)((byte*)ptr5 + 12) > 2) ? ((byte)1) : ((byte)0));
				((Control)mainForm.dev.input3RadioButton).Visible = visible3 != 0;
				byte visible4 = ((*(int*)((byte*)ptr5 + 12) > 3) ? ((byte)1) : ((byte)0));
				((Control)mainForm.dev.input4RadioButton).Visible = visible4 != 0;
				if (!mainForm.dev.input2RadioButton.Checked && !mainForm.dev.input3RadioButton.Checked && !mainForm.dev.input4RadioButton.Checked)
				{
					mainForm.dev.input1RadioButton.Checked = true;
				}
				vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E* ptr7 = inputDevs;
				if ((uint)inputNumber >= (uint)(*(int*)((byte*)ptr7 + 16) - *(int*)((byte*)ptr7 + 12) >> 2))
				{
					global::_003CModule_003E._invalid_parameter_noinfo();
				}
				int* ptr8 = (int*)(inputNumber * 4 + *(int*)((byte*)ptr7 + 12));
				global::_003CModule_003E.HOLM_002EPAudioII_002EStreamInitializer_002ESetInDevice(global::_003CModule_003E.HOLM_002EPAudioII_002EStream(), *ptr8, *(int*)((byte*)ptr5 + 12), false);
				goto IL_0335;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj5);
		global::_003CModule_003E.std_002Ebasic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D(&obj5, 3, 1);
		try
		{
			global::_003CModule_003E.std_002Eoperator_003C_003C_003Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_0020_003E(global::_003CModule_003E.std_002Ebasic_ostream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E_002E_003C_003C(global::_003CModule_003E.std_002Eoperator_003C_003C_003Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_0020_003E(global::_003CModule_003E.std_002Eoperator_003C_003C_003Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_0020_003E((basic_ostream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj5, 8)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref global::_003CModule_003E._003F_003F_C_0040_08KFJDDMMO_0040WARNING_003F5_003F_0024AA_0040)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref global::_003CModule_003E._003F_003F_C_0040_0DO_0040IOMKICGF_0040AudioHelper_003F3_003F3UpdateDeviceNumbers_0040)), inputNumber), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref global::_003CModule_003E._003F_003F_C_0040_01EEMJAFIK_0040_003F6_003F_0024AA_0040));
			System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj6);
			basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* ptr9 = global::_003CModule_003E.std_002Ebasic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002Estr(&obj5, &obj6);
			try
			{
				global::_003CModule_003E.HOLM_002ELogging_002EHolmLogger_002ELogText(ptr9);
			}
			catch
			{
				//try-fault
				global::_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), &obj6);
				throw;
			}
			global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D(&obj6);
		}
		catch
		{
			//try-fault
			global::_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&global::_003CModule_003E.std_002Ebasic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E__vbaseDtor), &obj5);
			throw;
		}
		global::_003CModule_003E.std_002Ebasic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E__vbaseDtor(&obj5);
		goto IL_0335;
		IL_0335:
		if (outputNumber >= 0)
		{
			vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E* ptr10 = outputDevs;
			vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E* ptr11 = ptr10;
			if ((uint)outputNumber < (uint)(*(int*)((byte*)ptr11 + 16) - *(int*)((byte*)ptr11 + 12) >> 2))
			{
				vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E* ptr12 = ptr10;
				if ((uint)outputNumber >= (uint)(*(int*)((byte*)ptr12 + 16) - *(int*)((byte*)ptr12 + 12) >> 2))
				{
					global::_003CModule_003E._invalid_parameter_noinfo();
				}
				PaDeviceInfo* ptr13 = global::_003CModule_003E.HOLM_002EPAudioII_002EGetDeviceInfo(*(int*)(outputNumber * 4 + *(int*)((byte*)ptr12 + 12)));
				System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj7);
				global::_003CModule_003E.std_002Ebasic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D(&obj7, 3, 1);
				try
				{
					global::_003CModule_003E.std_002Eoperator_003C_003C_003Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_0020_003E(global::_003CModule_003E.std_002Ebasic_ostream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E_002E_003C_003C(global::_003CModule_003E.std_002Eoperator_003C_003C_003Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_0020_003E(global::_003CModule_003E.std_002Eoperator_003C_003C_003Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_0020_003E((basic_ostream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj7, 8)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref global::_003CModule_003E._003F_003F_C_0040_08ECDPJEFA_0040INFO_003F5_003F5_003F5_003F5_003F_0024AA_0040)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref global::_003CModule_003E._003F_003F_C_0040_0DG_0040EDFBLONJ_0040AudioHelper_003F3_003F3UpdateDeviceNumbers_0040)), *(int*)((byte*)ptr13 + 16)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref global::_003CModule_003E._003F_003F_C_0040_01EEMJAFIK_0040_003F6_003F_0024AA_0040));
					System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj8);
					basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* ptr14 = global::_003CModule_003E.std_002Ebasic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002Estr(&obj7, &obj8);
					try
					{
						global::_003CModule_003E.HOLM_002ELogging_002EHolmLogger_002ELogText(ptr14);
					}
					catch
					{
						//try-fault
						global::_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), &obj8);
						throw;
					}
					global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D(&obj8);
				}
				catch
				{
					//try-fault
					global::_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&global::_003CModule_003E.std_002Ebasic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E__vbaseDtor), &obj7);
					throw;
				}
				global::_003CModule_003E.std_002Ebasic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E__vbaseDtor(&obj7);
				byte visible5 = ((*(int*)((byte*)ptr13 + 16) > 0) ? ((byte)1) : ((byte)0));
				((Control)mainForm.dev.output1CheckBox).Visible = visible5 != 0;
				byte visible6 = ((*(int*)((byte*)ptr13 + 16) > 1) ? ((byte)1) : ((byte)0));
				((Control)mainForm.dev.output2CheckBox).Visible = visible6 != 0;
				byte visible7 = ((*(int*)((byte*)ptr13 + 16) > 2) ? ((byte)1) : ((byte)0));
				((Control)mainForm.dev.output3CheckBox).Visible = visible7 != 0;
				byte visible8 = ((*(int*)((byte*)ptr13 + 16) > 3) ? ((byte)1) : ((byte)0));
				((Control)mainForm.dev.output4CheckBox).Visible = visible8 != 0;
				if (!mainForm.dev.output2CheckBox.Checked && !mainForm.dev.output3CheckBox.Checked && !mainForm.dev.output4CheckBox.Checked)
				{
					mainForm.dev.output1CheckBox.Checked = true;
				}
				vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E* ptr15 = outputDevs;
				if ((uint)outputNumber >= (uint)(*(int*)((byte*)ptr15 + 16) - *(int*)((byte*)ptr15 + 12) >> 2))
				{
					global::_003CModule_003E._invalid_parameter_noinfo();
				}
				int* ptr16 = (int*)(outputNumber * 4 + *(int*)((byte*)ptr15 + 12));
				global::_003CModule_003E.HOLM_002EPAudioII_002EStreamInitializer_002ESetOutDevice(global::_003CModule_003E.HOLM_002EPAudioII_002EStream(), *ptr16, *(int*)((byte*)ptr13 + 16), false);
				UpdateASIOAvailable();
				return;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj9);
		global::_003CModule_003E.std_002Ebasic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D(&obj9, 3, 1);
		try
		{
			global::_003CModule_003E.std_002Eoperator_003C_003C_003Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_0020_003E(global::_003CModule_003E.std_002Ebasic_ostream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E_002E_003C_003C(global::_003CModule_003E.std_002Eoperator_003C_003C_003Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_0020_003E(global::_003CModule_003E.std_002Eoperator_003C_003C_003Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_0020_003E((basic_ostream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj9, 8)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref global::_003CModule_003E._003F_003F_C_0040_08KFJDDMMO_0040WARNING_003F5_003F_0024AA_0040)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref global::_003CModule_003E._003F_003F_C_0040_0DP_0040NEBGIHJJ_0040AudioHelper_003F3_003F3UpdateDeviceNumbers_0040)), outputNumber), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref global::_003CModule_003E._003F_003F_C_0040_01EEMJAFIK_0040_003F6_003F_0024AA_0040));
			System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj10);
			basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* ptr17 = global::_003CModule_003E.std_002Ebasic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002Estr(&obj9, &obj10);
			try
			{
				global::_003CModule_003E.HOLM_002ELogging_002EHolmLogger_002ELogText(ptr17);
			}
			catch
			{
				//try-fault
				global::_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), &obj10);
				throw;
			}
			global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D(&obj10);
		}
		catch
		{
			//try-fault
			global::_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&global::_003CModule_003E.std_002Ebasic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E__vbaseDtor), &obj9);
			throw;
		}
		global::_003CModule_003E.std_002Ebasic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E__vbaseDtor(&obj9);
	}

	private unsafe void Initialize()
	{
		global::_003CModule_003E.HOLM_002EPAudioII_002EPaInitializer_002EEnsureInitialized();
		ResponseSaveOpenWave* ptr = (ResponseSaveOpenWave*)global::_003CModule_003E.@new(240u);
		ResponseSaveOpenWave* ptr2;
		try
		{
			ptr2 = ((ptr == null) ? null : global::_003CModule_003E.HOLM_002EMeasure_002EResponseSaveOpenWave_002E_007Bctor_007D(ptr));
		}
		catch
		{
			//try-fault
			global::_003CModule_003E.delete(ptr);
			throw;
		}
		response = ptr2;
		Calibrator* ptr3 = (Calibrator*)global::_003CModule_003E.@new(120u);
		Calibrator* ptr4;
		try
		{
			ptr4 = ((ptr3 == null) ? null : global::_003CModule_003E.HOLM_002EMeasure_002ECalibrator_002E_007Bctor_007D(ptr3));
		}
		catch
		{
			//try-fault
			global::_003CModule_003E.delete(ptr3);
			throw;
		}
		calMic = ptr4;
		Calibrator* ptr5 = (Calibrator*)global::_003CModule_003E.@new(120u);
		Calibrator* ptr6;
		try
		{
			ptr6 = ((ptr5 == null) ? null : global::_003CModule_003E.HOLM_002EMeasure_002ECalibrator_002E_007Bctor_007D(ptr5));
		}
		catch
		{
			//try-fault
			global::_003CModule_003E.delete(ptr5);
			throw;
		}
		calDacAdc = ptr6;
		global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_003D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)calMic, (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref global::_003CModule_003E._003F_003F_C_0040_0L_0040MJNFINBB_0040Microphone_003F_0024AA_0040));
		global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_003D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)calDacAdc, (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref global::_003CModule_003E._003F_003F_C_0040_06ONELMEEJ_0040DacAdc_003F_0024AA_0040));
		Calibrator* ptr7 = calMic;
		global::_003CModule_003E.std_002Evector_003CHOLM_003A_003AMeasure_003A_003ACalibrator_0020_002A_002Cstd_003A_003Aallocator_003CHOLM_003A_003AMeasure_003A_003ACalibrator_0020_002A_003E_0020_003E_002Epush_back((vector_003CHOLM_003A_003AMeasure_003A_003ACalibrator_0020_002A_002Cstd_003A_003Aallocator_003CHOLM_003A_003AMeasure_003A_003ACalibrator_0020_002A_003E_0020_003E*)((byte*)response + 56), &ptr7);
		Calibrator* ptr8 = calDacAdc;
		global::_003CModule_003E.std_002Evector_003CHOLM_003A_003AMeasure_003A_003ACalibrator_0020_002A_002Cstd_003A_003Aallocator_003CHOLM_003A_003AMeasure_003A_003ACalibrator_0020_002A_003E_0020_003E_002Epush_back((vector_003CHOLM_003A_003AMeasure_003A_003ACalibrator_0020_002A_002Cstd_003A_003Aallocator_003CHOLM_003A_003AMeasure_003A_003ACalibrator_0020_002A_003E_0020_003E*)((byte*)response + 56), &ptr8);
		freq = null;
		fReactOnGuiChanges = true;
		SquareNoise* ptr9 = (SquareNoise*)global::_003CModule_003E.@new(72u);
		SquareNoise* ptr10;
		try
		{
			ptr10 = ((ptr9 == null) ? null : global::_003CModule_003E.HOLM_002EPAudioII_002ESquareNoise_002E_007Bctor_007D(ptr9));
		}
		catch
		{
			//try-fault
			global::_003CModule_003E.delete(ptr9);
			throw;
		}
		sqNoise = ptr10;
		*(double*)((byte*)ptr10 + 32) = 0.9;
		*(double*)((byte*)sqNoise + 40) = 0.5;
		global::_003CModule_003E.HOLM_002EPAudioII_002EPCMGenerator_002ESetTriggerMode((PCMGenerator*)sqNoise, true);
		SineSweepSingle* ptr11 = (SineSweepSingle*)global::_003CModule_003E.@new(144u);
		SineSweepSingle* ptr12;
		try
		{
			ptr12 = ((ptr11 == null) ? null : global::_003CModule_003E.HOLM_002EPAudioII_002ESineSweepSingle_002E_007Bctor_007D(ptr11));
		}
		catch
		{
			//try-fault
			global::_003CModule_003E.delete(ptr11);
			throw;
		}
		chirp = ptr12;
		*(double*)((byte*)ptr12 + 72) = 10.0;
		*(double*)((byte*)chirp + 88) = 2.0;
		global::_003CModule_003E.HOLM_002EPAudioII_002EPCMGenerator_002ESetTriggerMode((PCMGenerator*)chirp, true);
		SineLogSweep* ptr13 = (SineLogSweep*)global::_003CModule_003E.@new(136u);
		SineLogSweep* ptr14;
		try
		{
			ptr14 = ((ptr13 == null) ? null : global::_003CModule_003E.HOLM_002EPAudioII_002ESineLogSweep_002E_007Bctor_007D(ptr13));
		}
		catch
		{
			//try-fault
			global::_003CModule_003E.delete(ptr13);
			throw;
		}
		logSweep = ptr14;
		*(double*)((byte*)ptr14 + 72) = 10.0;
		global::_003CModule_003E.HOLM_002EPAudioII_002EPCMGenerator_002ESetTriggerMode((PCMGenerator*)logSweep, true);
		PopulateDevices();
	}

	private unsafe void UpdateSignalLength()
	{
		L = 1 << m;
		global::_003CModule_003E.Mem_002EFreeArrayNoRef_003Cclass_0020std_003A_003Acomplex_003Cdouble_003E_0020_003E(freq, 0u);
		freq = global::_003CModule_003E.Mem_002EAllocateArray_003Cclass_0020std_003A_003Acomplex_003Cdouble_003E_0020_003E((uint)(L / 2 + 1));
		*(int*)((byte*)chirp + 4) = L;
		*(int*)((byte*)sqNoise + 4) = L;
		*(int*)((byte*)logSweep + 4) = L;
		int num = 1 << m;
		mainForm.dev.signalSamplesTextBox.Text = num.ToString();
		StreamInitializer* ptr = global::_003CModule_003E.HOLM_002EPAudioII_002EStream();
		double num2 = (double)L * 1000.0 / (double)(*(int*)((byte*)ptr + 16));
		mainForm.dev.signalMsTextBox.Text = num2.ToString("F0");
	}

	private unsafe void SetSamplerateNo(int samplerate)
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out int num);
		switch (samplerate)
		{
		case 0:
			num = 44100;
			break;
		case 1:
			num = 48000;
			break;
		case 2:
			num = 88200;
			break;
		case 3:
			num = 96000;
			break;
		case 4:
			num = 176400;
			break;
		case 5:
			num = 192000;
			break;
		}
		float num2 = (float)((double)num * 0.5);
		*(double*)((byte*)chirp + 80) = num2;
		*(double*)((byte*)logSweep + 80) = num2;
		global::_003CModule_003E.HOLM_002EPAudioII_002EStreamInitializer_002EStop(global::_003CModule_003E.HOLM_002EPAudioII_002EStream());
		((ButtonBase)mainForm.dev.deviceRestartStreamButton).Text = "Start stream";
		((ToolStripItem)mainForm.toolStripStatusLabel1).Text = "Audiostream stopped";
		global::_003CModule_003E.HOLM_002EPAudioII_002EStreamInitializer_002ESetSamplerate(global::_003CModule_003E.HOLM_002EPAudioII_002EStream(), num);
		global::_003CModule_003E.HOLM_002EMeasure_002EResponse_002EUpdateFromPAudio((Response*)response);
		StreamInitializer* ptr = global::_003CModule_003E.HOLM_002EPAudioII_002EStream();
		*(double*)((byte*)chirp + 80) = (double)(*(int*)((byte*)ptr + 16)) * 0.5;
		StreamInitializer* ptr2 = global::_003CModule_003E.HOLM_002EPAudioII_002EStream();
		*(double*)((byte*)logSweep + 80) = (double)(*(int*)((byte*)ptr2 + 16)) * 0.5;
		StreamInitializer* ptr3 = global::_003CModule_003E.HOLM_002EPAudioII_002EStream();
		double num3 = (double)L * 1000.0 / (double)(*(int*)((byte*)ptr3 + 16));
		mainForm.dev.signalMsTextBox.Text = num3.ToString("F0");
		mainCtrl.SetSamplerate(num);
	}

	private unsafe void PopulateDevices()
	{
		bool flag = fReactOnGuiChanges;
		fReactOnGuiChanges = false;
		vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E* ptr = inputDevs;
		if (ptr != null)
		{
			try
			{
				vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E* ptr2 = (vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E*)((byte*)ptr + 12);
				uint num = *(uint*)ptr2;
				if (num != 0)
				{
					global::_003CModule_003E.delete((void*)(int)num);
				}
				*(int*)ptr2 = 0;
				*(int*)((byte*)ptr + 16) = 0;
				*(int*)((byte*)ptr + 20) = 0;
			}
			catch
			{
				//try-fault
				global::_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<_Vector_val_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E*, void>)(&global::_003CModule_003E.std_002E_Vector_val_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E_002E_007Bdtor_007D), ptr);
				throw;
			}
			global::_003CModule_003E.delete((void*)(int)(*(uint*)ptr));
			global::_003CModule_003E.delete(ptr);
		}
		vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E* ptr3 = outputDevs;
		if (ptr3 != null)
		{
			try
			{
				vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E* ptr4 = (vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E*)((byte*)ptr3 + 12);
				uint num2 = *(uint*)ptr4;
				if (num2 != 0)
				{
					global::_003CModule_003E.delete((void*)(int)num2);
				}
				*(int*)ptr4 = 0;
				*(int*)((byte*)ptr3 + 16) = 0;
				*(int*)((byte*)ptr3 + 20) = 0;
			}
			catch
			{
				//try-fault
				global::_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<_Vector_val_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E*, void>)(&global::_003CModule_003E.std_002E_Vector_val_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E_002E_007Bdtor_007D), ptr3);
				throw;
			}
			global::_003CModule_003E.delete((void*)(int)(*(uint*)ptr3));
			global::_003CModule_003E.delete(ptr3);
		}
		PaApiType paApiType = (PaApiType)0;
		if (mainForm.dev.apiComboBox.SelectedIndex == 1)
		{
			paApiType = (PaApiType)1;
		}
		else if (mainForm.dev.apiComboBox.SelectedIndex == 2)
		{
			paApiType = (PaApiType)2;
		}
		vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E* ptr5 = (vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E*)global::_003CModule_003E.@new(24u);
		vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E* ptr6;
		try
		{
			ptr6 = ((ptr5 == null) ? null : global::_003CModule_003E.HOLM_002EPAudioII_002EGetInDevices(ptr5, paApiType));
		}
		catch
		{
			//try-fault
			global::_003CModule_003E.delete(ptr5);
			throw;
		}
		inputDevs = ptr6;
		vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E* ptr7 = (vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E*)global::_003CModule_003E.@new(24u);
		vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E* ptr8;
		try
		{
			ptr8 = ((ptr7 == null) ? null : global::_003CModule_003E.HOLM_002EPAudioII_002EGetOutDevices(ptr7, paApiType));
		}
		catch
		{
			//try-fault
			global::_003CModule_003E.delete(ptr7);
			throw;
		}
		outputDevs = ptr8;
		vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E* ptr9 = inputDevs;
		object[] array = new object[*(int*)((byte*)ptr9 + 16) - *(int*)((byte*)ptr9 + 12) >> 2];
		object[] array2 = new object[*(int*)((byte*)ptr8 + 16) - *(int*)((byte*)ptr8 + 12) >> 2];
		System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj);
		global::_003CModule_003E.std_002Ebasic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D(&obj, 3, 1);
		try
		{
			vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E* ptr10 = inputDevs;
			uint num3 = (uint)(*(int*)((byte*)ptr10 + 16) - *(int*)((byte*)ptr10 + 12) >> 2);
			global::_003CModule_003E.std_002Eoperator_003C_003C_003Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_0020_003E(global::_003CModule_003E.std_002Ebasic_ostream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E_002E_003C_003C(global::_003CModule_003E.std_002Eoperator_003C_003C_003Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_0020_003E(global::_003CModule_003E.std_002Eoperator_003C_003C_003Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_0020_003E((basic_ostream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 8)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref global::_003CModule_003E._003F_003F_C_0040_08ECDPJEFA_0040INFO_003F5_003F5_003F5_003F5_003F_0024AA_0040)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref global::_003CModule_003E._003F_003F_C_0040_0CL_0040CLEEOIFI_0040AudioHelper_003F3_003F3PopulateDevices_003F_0024CI_003F_0024CJ_003F5i_0040)), num3), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref global::_003CModule_003E._003F_003F_C_0040_01EEMJAFIK_0040_003F6_003F_0024AA_0040));
			System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj2);
			basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* ptr11 = global::_003CModule_003E.std_002Ebasic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002Estr(&obj, &obj2);
			try
			{
				global::_003CModule_003E.HOLM_002ELogging_002EHolmLogger_002ELogText(ptr11);
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
		uint num4 = 0u;
		vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E* ptr12 = inputDevs;
		if (0u < (uint)(*(int*)((byte*)ptr12 + 16) - *(int*)((byte*)ptr12 + 12) >> 2))
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj3);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj4);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj5);
			do
			{
				vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E* ptr13 = inputDevs;
				if (num4 >= (uint)(*(int*)((byte*)ptr13 + 16) - *(int*)((byte*)ptr13 + 12) >> 2))
				{
					global::_003CModule_003E._invalid_parameter_noinfo();
				}
				int* ptr14 = (int*)(int)(num4 * 4 + (uint)(*(int*)((byte*)ptr13 + 12)));
				global::_003CModule_003E.HOLM_002EPAudioII_002EGetDeviceName(&obj3, *ptr14, false);
				try
				{
					global::_003CModule_003E.std_002Ebasic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D(&obj4, 3, 1);
					try
					{
						global::_003CModule_003E.std_002Eoperator_003C_003C_003Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_0020_003E(global::_003CModule_003E.std_002Eoperator_003C_003C_003Cchar_002Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_002Cclass_0020std_003A_003Aallocator_003Cchar_003E_0020_003E(global::_003CModule_003E.std_002Eoperator_003C_003C_003Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_0020_003E(global::_003CModule_003E.std_002Ebasic_ostream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E_002E_003C_003C(global::_003CModule_003E.std_002Eoperator_003C_003C_003Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_0020_003E(global::_003CModule_003E.std_002Eoperator_003C_003C_003Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_0020_003E((basic_ostream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj4, 8)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref global::_003CModule_003E._003F_003F_C_0040_08ECDPJEFA_0040INFO_003F5_003F5_003F5_003F5_003F_0024AA_0040)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref global::_003CModule_003E._003F_003F_C_0040_0CK_0040LHDKLAJE_0040AudioHelper_003F3_003F3PopulateDevices_003F_0024CI_003F_0024CJ_003F5i_0040)), num4), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref global::_003CModule_003E._003F_003F_C_0040_04OAFLPOMH_0040_003F_0024FN_003F5_003F_0024DN_003F5_003F_0024AA_0040)), &obj3), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref global::_003CModule_003E._003F_003F_C_0040_01EEMJAFIK_0040_003F6_003F_0024AA_0040));
						basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* ptr15 = global::_003CModule_003E.std_002Ebasic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002Estr(&obj4, &obj5);
						try
						{
							global::_003CModule_003E.HOLM_002ELogging_002EHolmLogger_002ELogText(ptr15);
						}
						catch
						{
							//try-fault
							global::_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), &obj5);
							throw;
						}
						global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D(&obj5);
					}
					catch
					{
						//try-fault
						global::_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&global::_003CModule_003E.std_002Ebasic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E__vbaseDtor), &obj4);
						throw;
					}
					global::_003CModule_003E.std_002Ebasic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E__vbaseDtor(&obj4);
					string text = new string(global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002Ec_str(&obj3));
					array[num4] = text;
				}
				catch
				{
					//try-fault
					global::_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), &obj3);
					throw;
				}
				global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D(&obj3);
				num4++;
				ptr12 = inputDevs;
			}
			while (num4 < (uint)(*(int*)((byte*)ptr12 + 16) - *(int*)((byte*)ptr12 + 12) >> 2));
		}
		mainForm.dev.inputDevComboBox.Items.Clear();
		mainForm.dev.inputDevComboBox.Items.AddRange(array);
		vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E* ptr16 = inputDevs;
		vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E* ptr17 = ptr16;
		if (*(int*)((byte*)ptr17 + 16) - *(int*)((byte*)ptr17 + 12) >> 2 != 0)
		{
			DevOptions dev = Options.Field.Dev;
			int inputNumber = dev.InputNumber;
			if (inputNumber < 0)
			{
				dev.InputNumber = 0;
			}
			else
			{
				vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E* ptr18 = ptr16;
				uint num5 = (uint)(*(int*)((byte*)ptr18 + 16) - *(int*)((byte*)ptr18 + 12) >> 2);
				if ((uint)inputNumber > num5 - 1)
				{
					vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E* ptr19 = ptr16;
					uint num6 = (uint)(*(int*)((byte*)ptr19 + 16) - *(int*)((byte*)ptr19 + 12) >> 2);
					dev.InputNumber = (int)(num6 - 1);
				}
			}
			mainForm.dev.inputDevComboBox.SelectedIndex = Options.Field.Dev.InputNumber;
			((Control)mainForm.dev.inputDevGroupBox).Enabled = true;
			mainForm.dev.inputDevGroupBox.Text = "Input device (Record)";
		}
		else
		{
			mainForm.dev.inputDevComboBox.SelectedIndex = -1;
			mainForm.dev.inputDevComboBox.Text = "No input devices found!";
			((Control)mainForm.dev.inputDevGroupBox).Enabled = false;
			mainForm.dev.inputDevGroupBox.Text = "No input devices found!";
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj6);
		global::_003CModule_003E.std_002Ebasic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D(&obj6, 3, 1);
		try
		{
			vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E* ptr20 = outputDevs;
			uint num7 = (uint)(*(int*)((byte*)ptr20 + 16) - *(int*)((byte*)ptr20 + 12) >> 2);
			global::_003CModule_003E.std_002Eoperator_003C_003C_003Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_0020_003E(global::_003CModule_003E.std_002Ebasic_ostream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E_002E_003C_003C(global::_003CModule_003E.std_002Eoperator_003C_003C_003Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_0020_003E(global::_003CModule_003E.std_002Eoperator_003C_003C_003Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_0020_003E((basic_ostream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj6, 8)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref global::_003CModule_003E._003F_003F_C_0040_08ECDPJEFA_0040INFO_003F5_003F5_003F5_003F5_003F_0024AA_0040)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref global::_003CModule_003E._003F_003F_C_0040_0CM_0040DKPDCMCH_0040AudioHelper_003F3_003F3PopulateDevices_003F_0024CI_003F_0024CJ_003F5o_0040)), num7), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref global::_003CModule_003E._003F_003F_C_0040_01EEMJAFIK_0040_003F6_003F_0024AA_0040));
			System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj7);
			basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* ptr21 = global::_003CModule_003E.std_002Ebasic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002Estr(&obj6, &obj7);
			try
			{
				global::_003CModule_003E.HOLM_002ELogging_002EHolmLogger_002ELogText(ptr21);
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
			global::_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&global::_003CModule_003E.std_002Ebasic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E__vbaseDtor), &obj6);
			throw;
		}
		global::_003CModule_003E.std_002Ebasic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E__vbaseDtor(&obj6);
		uint num8 = 0u;
		vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E* ptr22 = outputDevs;
		if (0u < (uint)(*(int*)((byte*)ptr22 + 16) - *(int*)((byte*)ptr22 + 12) >> 2))
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj8);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj9);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj10);
			do
			{
				vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E* ptr23 = outputDevs;
				if (num8 >= (uint)(*(int*)((byte*)ptr23 + 16) - *(int*)((byte*)ptr23 + 12) >> 2))
				{
					global::_003CModule_003E._invalid_parameter_noinfo();
				}
				int* ptr24 = (int*)(int)(num8 * 4 + (uint)(*(int*)((byte*)ptr23 + 12)));
				global::_003CModule_003E.HOLM_002EPAudioII_002EGetDeviceName(&obj8, *ptr24, false);
				try
				{
					global::_003CModule_003E.std_002Ebasic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D(&obj9, 3, 1);
					try
					{
						global::_003CModule_003E.std_002Eoperator_003C_003C_003Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_0020_003E(global::_003CModule_003E.std_002Eoperator_003C_003C_003Cchar_002Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_002Cclass_0020std_003A_003Aallocator_003Cchar_003E_0020_003E(global::_003CModule_003E.std_002Eoperator_003C_003C_003Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_0020_003E(global::_003CModule_003E.std_002Ebasic_ostream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E_002E_003C_003C(global::_003CModule_003E.std_002Eoperator_003C_003C_003Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_0020_003E(global::_003CModule_003E.std_002Eoperator_003C_003C_003Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_0020_003E((basic_ostream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj9, 8)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref global::_003CModule_003E._003F_003F_C_0040_08ECDPJEFA_0040INFO_003F5_003F5_003F5_003F5_003F_0024AA_0040)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref global::_003CModule_003E._003F_003F_C_0040_0CL_0040BPFJDEP_0040AudioHelper_003F3_003F3PopulateDevices_003F_0024CI_003F_0024CJ_003F5o_0040)), num8), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref global::_003CModule_003E._003F_003F_C_0040_04OAFLPOMH_0040_003F_0024FN_003F5_003F_0024DN_003F5_003F_0024AA_0040)), &obj8), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref global::_003CModule_003E._003F_003F_C_0040_01EEMJAFIK_0040_003F6_003F_0024AA_0040));
						basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* ptr25 = global::_003CModule_003E.std_002Ebasic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002Estr(&obj9, &obj10);
						try
						{
							global::_003CModule_003E.HOLM_002ELogging_002EHolmLogger_002ELogText(ptr25);
						}
						catch
						{
							//try-fault
							global::_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), &obj10);
							throw;
						}
						global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D(&obj10);
					}
					catch
					{
						//try-fault
						global::_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&global::_003CModule_003E.std_002Ebasic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E__vbaseDtor), &obj9);
						throw;
					}
					global::_003CModule_003E.std_002Ebasic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E__vbaseDtor(&obj9);
					string text2 = new string(global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002Ec_str(&obj8));
					array2[num8] = text2;
				}
				catch
				{
					//try-fault
					global::_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), &obj8);
					throw;
				}
				global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D(&obj8);
				num8++;
				ptr22 = outputDevs;
			}
			while (num8 < (uint)(*(int*)((byte*)ptr22 + 16) - *(int*)((byte*)ptr22 + 12) >> 2));
		}
		mainForm.dev.outputDevComboBox.Items.Clear();
		mainForm.dev.outputDevComboBox.Items.AddRange(array2);
		vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E* ptr26 = outputDevs;
		vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E* ptr27 = ptr26;
		if (*(int*)((byte*)ptr27 + 16) - *(int*)((byte*)ptr27 + 12) >> 2 != 0)
		{
			DevOptions dev2 = Options.Field.Dev;
			int outputNumber = dev2.OutputNumber;
			if (outputNumber < 0)
			{
				dev2.OutputNumber = 0;
			}
			else
			{
				vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E* ptr28 = ptr26;
				if ((uint)outputNumber > (uint)((*(int*)((byte*)ptr28 + 16) - *(int*)((byte*)ptr28 + 12) >> 2) - 1))
				{
					vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E* ptr29 = ptr26;
					dev2.OutputNumber = (*(int*)((byte*)ptr29 + 16) - *(int*)((byte*)ptr29 + 12) >> 2) - 1;
				}
			}
			mainForm.dev.outputDevComboBox.SelectedIndex = Options.Field.Dev.OutputNumber;
			((Control)mainForm.dev.outputDevGroupBox).Enabled = true;
			mainForm.dev.outputDevGroupBox.Text = "Output device (Play)";
		}
		else
		{
			mainForm.dev.outputDevComboBox.SelectedIndex = -1;
			mainForm.dev.outputDevComboBox.Text = "No output devices found!";
			((Control)mainForm.dev.outputDevGroupBox).Enabled = false;
			mainForm.dev.outputDevGroupBox.Text = "No output devices found!";
		}
		global::_003CModule_003E.DeleteCliArray(array);
		global::_003CModule_003E.DeleteCliArray(array2);
		fReactOnGuiChanges = flag;
	}

	private unsafe void UpdateKeepStreamAlive([MarshalAs(UnmanagedType.U1)] bool flag)
	{
		if (flag)
		{
			if (*(int*)((byte*)global::_003CModule_003E.HOLM_002EPAudioII_002EStream() + 12) != 0)
			{
				global::_003CModule_003E.HOLM_002EPAudioII_002EStreamInitializer_002EStop(global::_003CModule_003E.HOLM_002EPAudioII_002EStream());
				global::_003CModule_003E.HOLM_002EPAudioII_002EStreamInitializer_002EStart(global::_003CModule_003E.HOLM_002EPAudioII_002EStream());
				if (*(int*)((byte*)global::_003CModule_003E.HOLM_002EPAudioII_002EStream() + 12) == 0)
				{
					if (((ButtonBase)mainForm.dev.deviceRestartStreamButton).Text == "Restart stream")
					{
						((ToolStripItem)mainForm.toolStripStatusLabel1).Text = "Audiostream restarted successfully.";
					}
					else
					{
						((ToolStripItem)mainForm.toolStripStatusLabel1).Text = "Audiostream started successfully.";
					}
				}
				else
				{
					System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj);
					basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* ptr = global::_003CModule_003E.HOLM_002EPAudioII_002EStreamInitializer_002EGetPaErrorText(global::_003CModule_003E.HOLM_002EPAudioII_002EStream(), &obj);
					try
					{
						string text = new string(global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002Ec_str(ptr));
						((ToolStripItem)mainForm.toolStripStatusLabel1).Text = "ERROR while starting audiostream: " + text;
					}
					catch
					{
						//try-fault
						global::_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), &obj);
						throw;
					}
					global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D(&obj);
					mainForm.dev.deviceKeepStreamCheckBox.Checked = false;
				}
			}
			((ButtonBase)mainForm.dev.deviceRestartStreamButton).Text = "Restart stream";
		}
		else
		{
			global::_003CModule_003E.HOLM_002EPAudioII_002EStreamInitializer_002EStop(global::_003CModule_003E.HOLM_002EPAudioII_002EStream());
			((ButtonBase)mainForm.dev.deviceRestartStreamButton).Text = "Start stream";
			((ToolStripItem)mainForm.toolStripStatusLabel1).Text = "Audiostream stopped";
		}
	}

	private unsafe void SetMicCalibration([MarshalAs(UnmanagedType.U1)] bool flag)
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj);
		basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* ptr = &obj;
		basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* fileName = global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D(&obj, (basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref global::_003CModule_003E.HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x11fcae0a_002ECAL_MIC_FILENAME));
		System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj2);
		basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* ptr2 = global::_003CModule_003E.HOLM_002EHOLMImpulse_002EConf_002EFilePath(&obj2, fileName);
		bool enabled;
		try
		{
			enabled = global::_003CModule_003E.HOLM_002EMeasure_002ECalibrator_002EOpen(calMic, ptr2);
		}
		catch
		{
			//try-fault
			global::_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), &obj2);
			throw;
		}
		global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D(&obj2);
		((Control)mainForm.dev.calMicCheckBox).Enabled = enabled;
		global::_003CModule_003E.HOLM_002EMeasure_002ECalibrator_002ESetActive(calMic, flag);
		mainForm.dev.calMicCheckBox.Checked = ((byte*)calMic)[96] != 0;
	}

	private unsafe void SetDacAdcCalibration([MarshalAs(UnmanagedType.U1)] bool flag)
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj);
		basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* ptr = &obj;
		basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* fileName = global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D(&obj, (basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref global::_003CModule_003E.HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x11fcae0a_002ECAL_DACADC_FILENAME));
		System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj2);
		basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* ptr2 = global::_003CModule_003E.HOLM_002EHOLMImpulse_002EConf_002EFilePath(&obj2, fileName);
		bool enabled;
		try
		{
			enabled = global::_003CModule_003E.HOLM_002EMeasure_002ECalibrator_002EOpen(calDacAdc, ptr2);
		}
		catch
		{
			//try-fault
			global::_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), &obj2);
			throw;
		}
		global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D(&obj2);
		((Control)mainForm.dev.calDacAdcCheckBox).Enabled = enabled;
		global::_003CModule_003E.HOLM_002EMeasure_002ECalibrator_002ESetActive(calDacAdc, flag);
		mainForm.dev.calDacAdcCheckBox.Checked = ((byte*)calDacAdc)[96] != 0;
	}

	protected virtual void Dispose([MarshalAs(UnmanagedType.U1)] bool P_0)
	{
		if (P_0)
		{
			_007EAudioHelper();
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
