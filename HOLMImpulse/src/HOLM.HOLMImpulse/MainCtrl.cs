using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using HOLM.Filter;
using HOLM.Graphics;
using HOLM.GuiHelper;
using HOLM.HOLMImpulse.Conf;
using HOLM.Measure;
using HOLM.MeasureGraphics;
using HOLM.PAudioII;
using HOLM.Version;
using std;

namespace HOLM.HOLMImpulse;

internal class MainCtrl : IDisposable
{
	public static Form1 mainForm;

	public Dialog dialog;

	public Updater updater;

	public ListMeasurementContainer container;

	public MeasurementPresentersImExport pImExport;

	public NumericTextBox phaseHideNumTextBox;

	public NumericTextBox hdHideNumTextBox;

	public NumericTextBox ampMinNumTextBox;

	public NumericTextBox ampMaxNumTextBox;

	public NumericTextBox ampTicNumTextBox;

	public NumericTextBox freqMinNumTextBox;

	public NumericTextBox freqMaxNumTextBox;

	public NumericTextBox freqTicNumTextBox;

	public FreqGraph freqGraph;

	public ImpulseGraph impulseGraph;

	private FormSplashScreen splashScreen;

	private FormAbcStitch formAbcStitch;

	private FormMatchAToB formMatchAToB;

	private FormAbcCalib formAbcCalib;

	private FormQBox formQBox;

	private bool fReactOnGuiChanges;

	private ColorCtrl[] colorCtrls;

	private int presenterIndex;

	private string presenterMeasString;

	private AudioHelper audio;

	public MainCtrl()
	{
		splashScreen = new FormSplashScreen();
		string text = Application.ProductVersion.Replace(", ", ".");
		splashScreen.versionLabel.Text = "HOLMImpulse v" + text;
		splashScreen.statusLabel.Text = "";
		((Control)splashScreen).Show();
		((Control)splashScreen).Refresh();
		updater = new Updater("http://www.holmacoustics.com/downloads/HOLMImpulse/", "HOLMImpulse", dialog = new Dialog("HOLMImpulse"));
	}

	private void _007EMainCtrl()
	{
		((IDisposable)formAbcStitch)?.Dispose();
		((IDisposable)formAbcCalib)?.Dispose();
		((IDisposable)formMatchAToB)?.Dispose();
		((IDisposable)pImExport)?.Dispose();
		global::_003CModule_003E.DeleteCliArray(colorCtrls);
		((IDisposable)container)?.Dispose();
		((IDisposable)audio)?.Dispose();
		((IDisposable)updater)?.Dispose();
		((IDisposable)dialog)?.Dispose();
		((IDisposable)impulseGraph)?.Dispose();
		((IDisposable)freqGraph)?.Dispose();
		((IDisposable)mainForm)?.Dispose();
		global::_003CModule_003E.HOLM_002EFilter_002ECleanUp();
		global::_003CModule_003E.HOLM_002EPAudioII_002ECleanUp();
	}

	public unsafe void SetSplashScreenStatusString(string statusString)
	{
		if (splashScreen == null)
		{
			return;
		}
		splashScreen.statusLabel.Text = string.Concat("(" + statusString, ")");
		splashScreen.versionLabel.Text = splashScreen.versionLabel.Text + ".";
		((Control)splashScreen).Refresh();
		System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj);
		global::_003CModule_003E.std_002Ebasic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D(&obj, 3, 1);
		try
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj2);
			basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* ptr = global::_003CModule_003E.HOLM_002EMiscHelper_002EStringToStd(&obj2, statusString);
			try
			{
				global::_003CModule_003E.std_002Eoperator_003C_003C_003Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_0020_003E(global::_003CModule_003E.std_002Eoperator_003C_003C_003Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_0020_003E(global::_003CModule_003E.std_002Eoperator_003C_003C_003Cchar_002Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_002Cclass_0020std_003A_003Aallocator_003Cchar_003E_0020_003E(global::_003CModule_003E.std_002Eoperator_003C_003C_003Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_0020_003E(global::_003CModule_003E.std_002Eoperator_003C_003C_003Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_0020_003E((basic_ostream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 8)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref global::_003CModule_003E._003F_003F_C_0040_08ECDPJEFA_0040INFO_003F5_003F5_003F5_003F5_003F_0024AA_0040)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref global::_003CModule_003E._003F_003F_C_0040_0CH_0040BIAOOJID_0040MainCtrl_003F3_003F3SetSplashScreenStatusS_0040)), ptr), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref global::_003CModule_003E._003F_003F_C_0040_01PKGAHCOL_0040_003F_0024CJ_003F_0024AA_0040)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref global::_003CModule_003E._003F_003F_C_0040_01EEMJAFIK_0040_003F6_003F_0024AA_0040));
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

	public unsafe void Run(string filename)
	{
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		Exception ex = null;
		SetSplashScreenStatusString("Loading options");
		Options.LoadAutoSaved(showWarningIfError: false);
		if (Options.Field.Misc.CheckForUpdate)
		{
			SetSplashScreenStatusString("Checking for update online");
			updater.CheckForUpdate(fShowError: false, fShowUpToDate: false);
		}
		SetSplashScreenStatusString("Constructing main form");
		mainForm = new Form1();
		dialog.mainForm = (Form)(object)mainForm;
		SetSplashScreenStatusString("Initializing");
		System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E obj);
		basic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E* ptr = &obj;
		basic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E* filename2 = global::_003CModule_003E.HOLM_002EMiscHelper_002EStringToStdW(&obj, filename);
		Initialize(filename2);
		audio.LoadFromOptions();
		LoadConfSlotNumbers();
		ApplyGraphicOptions(fNewFreqRange: true);
		SetSplashScreenStatusString("Starting the Application");
		((IDisposable)splashScreen)?.Dispose();
		splashScreen = null;
		try
		{
			Application.Run((Form)(object)mainForm);
		}
		catch (Exception ex2)
		{
			MessageBox.Show(string.Concat(string.Concat(string.Concat("The application crashed - We apologize\n" + "The configuration and measurements will be autosaved\n", "Please restart the application\n\n"), "Details: "), ex2.ToString()), "Information", (MessageBoxButtons)0, (MessageBoxIcon)48);
			global::_003CModule_003E.HOLM_002EPAudioII_002EStreamInitializer_002EStop(global::_003CModule_003E.HOLM_002EPAudioII_002EStream());
			SaveToOptions();
			Options.AutoSave();
			System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E obj2);
			basic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E* ptr2 = &obj2;
			basic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E* fileName = global::_003CModule_003E.std_002Ebasic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E_002E_007Bctor_007D(&obj2, (basic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref global::_003CModule_003E.HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x316290b9_002EAUTOSAVE_MEAS_FILENAME));
			System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E obj3);
			basic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E* filename3 = global::_003CModule_003E.HOLM_002EHOLMImpulse_002EConf_002EFilePath(&obj3, fileName);
			try
			{
				container.Save(filename3);
			}
			catch
			{
				//try-fault
				global::_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E*, void>)(&global::_003CModule_003E.std_002Ebasic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E_002E_007Bdtor_007D), &obj3);
				throw;
			}
			global::_003CModule_003E.std_002Ebasic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E_002E_007Bdtor_007D(&obj3);
		}
	}

	public unsafe void SetSamplerate(int samplerate)
	{
		StreamInitializer* ptr = global::_003CModule_003E.HOLM_002EPAudioII_002EStream();
		if (Options.Field.Plot.PlotFreqMax < (double)(*(int*)((byte*)ptr + 16)) * 0.8 * 0.5)
		{
			double num = *(int*)((byte*)global::_003CModule_003E.HOLM_002EPAudioII_002EStream() + 16) / 2;
			Options.Field.Plot.PlotFreqMax = num;
			freqMaxNumTextBox.SetValue(num);
			while (freqGraph.ZoomOut())
			{
			}
			PlotOptions plot = Options.Field.Plot;
			freqGraph.ZoomOutToNewRange(plot.PlotFreqMin, plot.PlotFreqMax);
		}
		UpdateSignal();
		impulseGraph.SetSamplerate(samplerate);
		impulseGraph.AutoZoom(fTime: true);
		freqGraph.UpdatePlotArea();
		impulseGraph.UpdatePlotArea();
	}

	public void UpdatePlot([MarshalAs(UnmanagedType.U1)] bool fRescaleImpulse)
	{
		if (fRescaleImpulse)
		{
			impulseGraph.AutoZoom(fTime: false);
		}
		impulseGraph.UpdatePlotArea();
		freqGraph.UpdatePlotArea();
	}

	public unsafe void UpdateSignal()
	{
		decimal value = mainForm.meas.nofTapsUpDown.Value;
		global::_003CModule_003E.HOLM_002EMeasure_002EResponse_002ESetNofFilterTaps((Response*)audio.response, decimal.ToInt32(value));
		if (mainForm.meas.freqWindowHighpassCheckBox.Checked)
		{
			decimal value2 = mainForm.meas.freqWindowHighpassUpDown.Value;
			global::_003CModule_003E.HOLM_002EMeasure_002EResponse_002ESetFilterHighpass((Response*)audio.response, decimal.ToDouble(value2));
		}
		else
		{
			global::_003CModule_003E.HOLM_002EMeasure_002EResponse_002EDisableFilterHighpass((Response*)audio.response);
		}
		if (mainForm.meas.freqWindowLowpassCheckBox.Checked)
		{
			decimal value3 = mainForm.meas.freqWindowLowpassUpDown.Value;
			global::_003CModule_003E.HOLM_002EMeasure_002EResponse_002ESetFilterLowpass((Response*)audio.response, decimal.ToDouble(value3));
		}
		else
		{
			global::_003CModule_003E.HOLM_002EMeasure_002EResponse_002EDisableFilterLowpass((Response*)audio.response);
		}
		int num = ((mainForm.meas.freqWindowHighpassCheckBox.Checked || mainForm.meas.freqWindowLowpassCheckBox.Checked) ? 1 : 0);
		bool flag = (byte)num != 0;
		((Control)mainForm.meas.freqWindowHighpassUpDown).Enabled = mainForm.meas.freqWindowHighpassCheckBox.Checked;
		((Control)mainForm.meas.freqWindowLowpassUpDown).Enabled = mainForm.meas.freqWindowLowpassCheckBox.Checked;
		mainForm.meas.plotSignalCheckBox.Checked = mainForm.meas.plotSignalCheckBox.Checked || flag;
		((Control)mainForm.meas.nofTapsUpDown).Enabled = flag;
		global::_003CModule_003E.HOLM_002EMeasure_002EMeasurement_002EInitializeFilter(container.presenter[3].measPtr, (FilterBasic*)(int)(*(uint*)((byte*)audio.response + 52)));
	}

	private void ApplyGraphicOptions([MarshalAs(UnmanagedType.U1)] bool fNewFreqRange)
	{
		fReactOnGuiChanges = false;
		colorCtrls[0].SetColor(Options.Field.Plot.ColorMeasA);
		colorCtrls[1].SetColor(Options.Field.Plot.ColorMeasB);
		colorCtrls[2].SetColor(Options.Field.Plot.ColorMeasC);
		colorCtrls[3].SetColor(Options.Field.Plot.ColorSignal);
		UpdateFgBgColors();
		freqMinNumTextBox.SetValue(Options.Field.Plot.PlotFreqMin);
		freqMaxNumTextBox.SetValue(Options.Field.Plot.PlotFreqMax);
		freqTicNumTextBox.SetValue((double)Options.Field.Plot.GraphicsNumberOfXTics);
		ampMinNumTextBox.SetValue(Options.Field.Plot.PlotDbMin);
		ampMaxNumTextBox.SetValue(Options.Field.Plot.PlotDbMax);
		ampTicNumTextBox.SetValue((double)Options.Field.Plot.GraphicsNumberOfYTics);
		phaseHideNumTextBox.SetValue(Options.Field.Plot.HidePhaseWhenBelowDB);
		hdHideNumTextBox.SetValue(Options.Field.Plot.HideHDWhenBelowDB);
		mainForm.meas.impGraph.dB0UpDown.Value = Options.Field.Plot.PlotImpulseDBMin;
		mainForm.menu.logFreqMenuItem.Checked = Options.Field.Plot.FreqLogAxis;
		byte @checked = ((!Options.Field.Plot.FreqLogAxis) ? ((byte)1) : ((byte)0));
		mainForm.menu.linFreqMenuItem.Checked = @checked != 0;
		mainForm.meas.plotPhaseCheckBox.Checked = Options.Field.Plot.PlotPhase;
		mainForm.meas.plotHdCheckBox.Checked = Options.Field.Plot.PlotHD;
		((Control)mainForm.meas.plotHdComboBox).Enabled = Options.Field.Plot.PlotHD;
		mainForm.meas.plotAmpCheckBox.Checked = Options.Field.Plot.PlotAmplitude;
		mainForm.menu.decibelAmpMenuItem.Checked = Options.Field.Plot.AmpDBAxis;
		byte checked2 = ((!Options.Field.Plot.AmpDBAxis) ? ((byte)1) : ((byte)0));
		mainForm.menu.linAmpMenuItem.Checked = checked2 != 0;
		mainForm.menu.optionsImpulseShowHD.Checked = Options.Field.Plot.ImpulseShowHD;
		mainForm.menu.optionFreqShowGating.Checked = Options.Field.Plot.FreqShowGating;
		mainForm.menu.impulseInterpolate.Checked = Options.Field.Plot.ImpulseInterpolate;
		if (Options.Field.Plot.FreqLogAxis)
		{
			freqGraph.SetXAxisMode((AxisMode)1);
			freqGraph.phaseGraph.SetXAxisMode((AxisMode)1);
			mainForm.menu.logFreqMenuItem.Checked = true;
			mainForm.menu.linAmpMenuItem.Checked = false;
		}
		else
		{
			freqGraph.SetXAxisMode((AxisMode)0);
			freqGraph.phaseGraph.SetXAxisMode((AxisMode)0);
			mainForm.menu.logFreqMenuItem.Checked = false;
			mainForm.menu.linAmpMenuItem.Checked = true;
		}
		if (Options.Field.Plot.AmpDBAxis)
		{
			freqGraph.SetYAxisMode((AxisMode)2);
			mainForm.menu.decibelAmpMenuItem.Checked = true;
			mainForm.menu.linAmpMenuItem.Checked = false;
		}
		else
		{
			freqGraph.SetYAxisMode((AxisMode)0);
			mainForm.menu.decibelAmpMenuItem.Checked = false;
			mainForm.menu.linAmpMenuItem.Checked = true;
		}
		freqGraph.fPlotAmplitude = Options.Field.Plot.PlotAmplitude;
		freqGraph.fPlotPhase = Options.Field.Plot.PlotPhase;
		freqGraph.fPlotHD = Options.Field.Plot.PlotHD;
		freqGraph.fPlotWindowFrequency = Options.Field.Plot.FreqShowGating;
		freqGraph.SetXTics(Options.Field.Plot.GraphicsNumberOfXTics);
		freqGraph.SetYTics(Options.Field.Plot.GraphicsNumberOfYTics);
		freqGraph.phaseGraph.SetXTics(Options.Field.Plot.GraphicsNumberOfXTics);
		freqGraph.phaseGraph.SetYTics(Options.Field.Plot.GraphicsNumberOfYTics);
		if (fNewFreqRange)
		{
			PlotOptions plot = Options.Field.Plot;
			freqGraph.ZoomOutToNewRange(plot.PlotFreqMin, plot.PlotFreqMax, global::_003CModule_003E.HOLM_002EMath_002EDBToAmplitude_003Cdouble_003E(Options.Field.Plot.PlotDbMin), global::_003CModule_003E.HOLM_002EMath_002EDBToAmplitude_003Cdouble_003E(Options.Field.Plot.PlotDbMax));
		}
		freqGraph.HidePhaseAmpLimit = global::_003CModule_003E.HOLM_002EMath_002EDBToAmplitude_003Cdouble_003E(Options.Field.Plot.HidePhaseWhenBelowDB);
		freqGraph.HideHDAmpLimit = global::_003CModule_003E.HOLM_002EMath_002EDBToAmplitude_003Cdouble_003E(Options.Field.Plot.HideHDWhenBelowDB);
		impulseGraph.SetXTics(20);
		impulseGraph.SetYTics(10);
		impulseGraph.fShowHDPreTops = Options.Field.Plot.ImpulseShowHD;
		impulseGraph.fInterpolateSamples = Options.Field.Plot.ImpulseInterpolate;
		impulseGraph.SetYAxisModedBMirror0DB(Options.Field.Plot.PlotImpulseDBMin);
		UpdatePlotSettings();
		mainForm.menu.showToolTipsMenuItem.Checked = Options.Field.Misc.ShowToolTips;
		mainForm.menu.checkforUpdateAtStart.Checked = Options.Field.Misc.CheckForUpdate;
		mainForm.toolTip.Active = Options.Field.Misc.ShowToolTips;
		switch (Options.Field.Plot.ImpulseGraphMode)
		{
		default:
			mainForm.menu.impulseAsTimeMenuItem.Checked = true;
			mainForm.menu.impulseAsSamplesMenuItem.Checked = false;
			mainForm.menu.impulseAsDistanceMenuItem.Checked = false;
			impulseGraph.SetMode((ImpulseGraphMode)1);
			break;
		case 2:
			mainForm.menu.impulseAsTimeMenuItem.Checked = false;
			mainForm.menu.impulseAsSamplesMenuItem.Checked = false;
			mainForm.menu.impulseAsDistanceMenuItem.Checked = true;
			impulseGraph.SetMode((ImpulseGraphMode)2);
			break;
		case 1:
			mainForm.menu.impulseAsTimeMenuItem.Checked = true;
			mainForm.menu.impulseAsSamplesMenuItem.Checked = false;
			mainForm.menu.impulseAsDistanceMenuItem.Checked = false;
			impulseGraph.SetMode((ImpulseGraphMode)1);
			break;
		case 0:
			mainForm.menu.impulseAsTimeMenuItem.Checked = false;
			mainForm.menu.impulseAsSamplesMenuItem.Checked = true;
			impulseGraph.SetMode((ImpulseGraphMode)0);
			mainForm.menu.impulseAsDistanceMenuItem.Checked = false;
			break;
		}
		container.SetLineWidth(Options.Field.Plot.LineWidth);
		((Control)mainForm.meas.plotAmpPanel).Height = Options.Field.Plot.LineWidth;
		((Control)mainForm.meas.plotPhasePanel).Height = Options.Field.Plot.LineWidth;
		((Control)mainForm.meas.plotDistortionPanel).Height = Options.Field.Plot.LineWidth;
		mainForm.menu.lineWidthComboBox.SelectedIndex = Options.Field.Plot.LineWidth - 1;
		impulseGraph.UpdatePlotArea();
		freqGraph.UpdatePlotArea();
		fReactOnGuiChanges = true;
	}

	private void SaveToOptions()
	{
		audio.SaveToOptions();
		Options.Field.Plot.ImpulseGraphMode = (int)impulseGraph.GetMode();
		Color color = colorCtrls[0].GetColor();
		Options.Field.Plot.ColorMeasA = color;
		Color color2 = colorCtrls[1].GetColor();
		Options.Field.Plot.ColorMeasB = color2;
		Color color3 = colorCtrls[2].GetColor();
		Options.Field.Plot.ColorMeasC = color3;
		Color color4 = colorCtrls[3].GetColor();
		Options.Field.Plot.ColorSignal = color4;
		Options.Field.Plot.HidePhaseWhenBelowDB = global::_003CModule_003E.HOLM_002EMath_002EAmplitudeToDB_003Cdouble_003E(freqGraph.HidePhaseAmpLimit);
		Options.Field.Plot.HideHDWhenBelowDB = global::_003CModule_003E.HOLM_002EMath_002EAmplitudeToDB_003Cdouble_003E(freqGraph.HideHDAmpLimit);
		Options.Field.Plot.FreqLogAxis = mainForm.menu.logFreqMenuItem.Checked;
		Options.Field.Plot.AmpDBAxis = mainForm.menu.decibelAmpMenuItem.Checked;
		Options.Field.Plot.PlotImpulseDBMin = impulseGraph.GetYAxisModedBMirror0DB();
		Options.Field.Misc.ShowToolTips = mainForm.menu.showToolTipsMenuItem.Checked;
		Options.Field.Misc.ASlotNr = container.formpresenter[0].GetSlotNumber();
		Options.Field.Misc.BSlotNr = container.formpresenter[1].GetSlotNumber();
		Options.Field.Misc.CSlotNr = container.formpresenter[2].GetSlotNumber();
	}

	private void UpdatePlotSettings()
	{
		container.presenter[0].fPlot = mainForm.meas.mA.plotCheckBox.Checked;
		container.presenter[1].fPlot = mainForm.meas.mB.plotCheckBox.Checked;
		container.presenter[2].fPlot = mainForm.meas.mC.plotCheckBox.Checked;
		container.presenter[3].fPlot = mainForm.meas.plotSignalCheckBox.Checked;
	}

	private unsafe void Initialize(basic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E* filename)
	{
		//IL_040f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0419: Expected O, but got Unknown
		//IL_0425: Unknown result type (might be due to invalid IL or missing references)
		//IL_042f: Expected O, but got Unknown
		//IL_0a85: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a8f: Expected O, but got Unknown
		//IL_0f42: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f4c: Expected O, but got Unknown
		try
		{
			SetSplashScreenStatusString("Initilizing components");
			WaitingCtrl.AssignMainCtrl((Control)(object)mainForm);
			WaitingCtrl.AssignStatusItem((ToolStripItem)(object)mainForm.toolStripStatusLabel1);
			audio = new AudioHelper(this);
			global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_003D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)((byte*)(container = new ListMeasurementContainer(3, 50, 1)).list + 8), (basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref global::_003CModule_003E.HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x316290b9_002ETMP_PATH_MEASLIST));
			string path = new string(global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002Ec_str((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref global::_003CModule_003E.HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x316290b9_002ETMP_PATH_MEASLIST)));
			if (Directory.Exists(path))
			{
				Directory.Delete(path, recursive: true);
			}
			Directory.CreateDirectory(path);
			(pImExport = new MeasurementPresentersImExport()).options = Options.Field.ImExport;
			formAbcStitch = null;
			formMatchAToB = null;
			formAbcCalib = null;
			colorCtrls = new ColorCtrl[4];
			int num = 0;
			do
			{
				colorCtrls[num] = new ColorCtrl(Options.colorDialog, mainForm.toolTip);
				num++;
			}
			while (num < 4);
			container.formpresenter[0].AssignMeasurementForm(mainForm.meas.mA);
			container.formpresenter[1].AssignMeasurementForm(mainForm.meas.mB);
			container.formpresenter[2].AssignMeasurementForm(mainForm.meas.mC);
			int num2 = 0;
			do
			{
				container.formpresenter[num2].SetColorCtrl(colorCtrls[num2]);
				container.formpresenter[num2].OptionsShowTimeStartLocked();
				pImExport.AddControlPresenter(container.formpresenter[num2]);
				container.formpresenter[num2].fShowSignalInfo = true;
				container.formpresenter[num2].fShowdBInfo = true;
				num2++;
			}
			while (num2 < 3);
			container.presenter[3].SetColorCtrl(colorCtrls[3]);
			colorCtrls[3].AssignClickControl((Control)(object)mainForm.meas.colorSignalPanel, fBg: true, fBright: false);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj);
			basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* ptr = global::_003CModule_003E.HOLM_002ELogging_002EGetDebugFlags(&obj);
			string text;
			try
			{
				text = new string(global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002Ec_str(ptr));
			}
			catch
			{
				//try-fault
				global::_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), &obj);
				throw;
			}
			global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D(&obj);
			string text2 = Application.ProductVersion.Replace(", ", ".");
			if (text != "")
			{
				text2 = string.Concat(text2, " + " + text);
			}
			Form1 form = mainForm;
			((Form)form).Text = string.Concat(((Form)form).Text + "  v", text2);
			fReactOnGuiChanges = true;
			mainForm.meas.plotHdComboBox.SelectedIndex = 0;
			ampMinNumTextBox = new NumericTextBox(mainForm.menu.plotAmpDBMin, -200.0, 20.0, 0);
			ampMaxNumTextBox = new NumericTextBox(mainForm.menu.plotAmpDBMax, -200.0, 20.0, 0);
			ampTicNumTextBox = new NumericTextBox(mainForm.menu.plotAmpTics, 0.0, 100.0, 0);
			freqMinNumTextBox = new NumericTextBox(mainForm.menu.plotFreqMin, 1.0, 96000.0, 0);
			freqMaxNumTextBox = new NumericTextBox(mainForm.menu.plotFreqMax, 1.0, 96000.0, 0);
			freqTicNumTextBox = new NumericTextBox(mainForm.menu.plotFreqTics, 0.0, 100.0, 0);
			phaseHideNumTextBox = new NumericTextBox(mainForm.menu.plotPhaseHideDB, -200.0, 20.0, 0);
			hdHideNumTextBox = new NumericTextBox(mainForm.menu.plotHDHideDB, -200.0, 20.0, 0);
			((Control)mainForm).DragDrop += new DragEventHandler(Action_DragAndDrop);
			((Control)mainForm).DragEnter += new DragEventHandler(Action_DragEnter);
			((Control)mainForm.meas.plotPhaseCheckBox).Click += Action_PlotOptionsChanged;
			((Control)mainForm.meas.plotAmpCheckBox).Click += Action_PlotOptionsChanged;
			((Control)mainForm.meas.plotSignalCheckBox).Click += Action_PlotSettingsChanged;
			((Control)mainForm.meas.plotHdCheckBox).Click += Action_PlotOptionsChanged;
			mainForm.meas.plotHdComboBox.SelectedIndexChanged += Action_PlotOptionsChanged;
			((Control)mainForm.analysis.normalize0dBCheckBox).Click += Action_PlotOptionsChanged;
			((ToolStripItem)mainForm.menu.linAmpMenuItem).Click += Action_PlotOptionsChanged;
			((ToolStripItem)mainForm.menu.decibelAmpMenuItem).Click += Action_PlotOptionsChanged;
			((ToolStripItem)mainForm.menu.linFreqMenuItem).Click += Action_PlotOptionsChanged;
			((ToolStripItem)mainForm.menu.logFreqMenuItem).Click += Action_PlotOptionsChanged;
			((ToolStripItem)mainForm.menu.optionFreqShowGating).Click += Action_PlotOptionsChanged;
			((ToolStripItem)mainForm.menu.optionsImpulseShowHD).Click += Action_PlotOptionsChanged;
			((ToolStripItem)mainForm.menu.impulseInterpolate).Click += Action_PlotOptionsChanged;
			((ToolStripItem)mainForm.menu.colorBgMenuItem).Click += Action_ColorFgBgClick;
			((ToolStripItem)mainForm.menu.colorFgMenuItem).Click += Action_ColorFgBgClick;
			((ToolStripItem)mainForm.menu.openMenuItem).Click += Action_OpenFile;
			((ToolStripItem)mainForm.menu.clearMenuItem).Click += Action_ClearMeasurements;
			((ToolStripItem)mainForm.menu.saveMeasurementsFlac).Click += Action_SaveFile;
			((ToolStripItem)mainForm.menu.saveMeasurementsWav).Click += Action_SaveFile;
			((ToolStripItem)mainForm.menu.openAppendMenuItem).Click += Action_OpenAppendFile;
			((ToolStripItem)mainForm.menu.rearangeMenuItem).Click += Action_Rearange;
			((ToolStripItem)mainForm.menu.organizeMeasurements).Click += Action_Rearange;
			((Control)mainForm.meas.organizeButton).Click += Action_Rearange;
			((ToolStripItem)mainForm.menu.impulseAsDistanceMenuItem).Click += Action_ImpulseModeChanged;
			((ToolStripItem)mainForm.menu.impulseAsSamplesMenuItem).Click += Action_ImpulseModeChanged;
			((ToolStripItem)mainForm.menu.impulseAsTimeMenuItem).Click += Action_ImpulseModeChanged;
			((ToolStripItem)mainForm.menu.freqImpSaveBitmapMenuItem).Click += Action_SaveBitmap;
			((ToolStripItem)mainForm.menu.freqSaveBitmapMenuItem).Click += Action_SaveBitmap;
			((ToolStripItem)mainForm.menu.impulseSaveBitmapMenuItem).Click += Action_SaveBitmap;
			((ToolStripItem)mainForm.menu.freqImpToClipBoard).Click += Action_ToClipBoard;
			((ToolStripItem)mainForm.menu.freqToClipBoard).Click += Action_ToClipBoard;
			((ToolStripItem)mainForm.menu.impToClipBoard).Click += Action_ToClipBoard;
			((ToolStripItem)mainForm.menu.imageResizeGraph).Click += Action_ImageGraphResize;
			((Control)mainForm.meas.freqWindowHighpassCheckBox).Click += Action_FreqWindowEnabled;
			((Control)mainForm.meas.freqWindowLowpassCheckBox).Click += Action_FreqWindowEnabled;
			mainForm.meas.freqWindowHighpassUpDown.ValueChanged += Action_FreqWindowChanged;
			mainForm.meas.freqWindowLowpassUpDown.ValueChanged += Action_FreqWindowChanged;
			mainForm.meas.nofTapsUpDown.ValueChanged += Action_FreqWindowChanged;
			mainForm.menu.lineWidthComboBox.SelectedIndexChanged += Action_LineWidthChanged;
			((ToolStripItem)mainForm.menu.loadSettingsMenuItem).Click += Action_OptionsLoad;
			((ToolStripItem)mainForm.menu.saveSettingsMenuItem).Click += Action_OptionsSave;
			((ToolStripItem)mainForm.menu.resetSettingsMenuItem).Click += Action_OptionsReset;
			((ToolStripItem)mainForm.menu.showToolTipsMenuItem).Click += Action_ShowToolTips;
			((ToolStripItem)mainForm.menu.aboutMenuItem).Click += Action_HelpAbout;
			((ToolStripItem)mainForm.menu.helpMenuItem).Click += Action_HelpAbout;
			((ToolStripItem)mainForm.menu.exitMenuItem).Click += Action_Exit;
			((ToolStripItem)mainForm.menu.browseApplicationData).Click += Action_BrowseAppData;
			((ToolStripItem)mainForm.menu.checkforUpdate).Click += updater.Action_CheckForUpdate;
			((ToolStripItem)mainForm.menu.helpUserGuide).Click += updater.Action_ShowUserGuide;
			((ToolStripItem)mainForm.menu.checkforUpdateAtStart).Click += Action_CheckForUpdateAtStartup;
			((Form)mainForm).FormClosing += new FormClosingEventHandler(Action_MainFormClosing);
			freqMinNumTextBox.NewValue += Action_PlotOptionsChanged;
			freqMaxNumTextBox.NewValue += Action_PlotOptionsChanged;
			freqTicNumTextBox.NewValue += Action_PlotOptionsChanged;
			ampMinNumTextBox.NewValue += Action_PlotOptionsChanged;
			ampMaxNumTextBox.NewValue += Action_PlotOptionsChanged;
			ampTicNumTextBox.NewValue += Action_PlotOptionsChanged;
			phaseHideNumTextBox.NewValue += Action_PlotOptionsChanged;
			hdHideNumTextBox.NewValue += Action_PlotOptionsChanged;
			((Control)mainForm.meas.mA.plotCheckBox).Click += Action_PlotSettingsChanged;
			((Control)mainForm.meas.mB.plotCheckBox).Click += Action_PlotSettingsChanged;
			((Control)mainForm.meas.mC.plotCheckBox).Click += Action_PlotSettingsChanged;
			((Control)mainForm.meas.mA.measureButton).Click += Action_MeasStart;
			((Control)mainForm.meas.mB.measureButton).Click += Action_MeasStart;
			((Control)mainForm.meas.mC.measureButton).Click += Action_MeasStart;
			((ToolStripItem)mainForm.menu.exportAllMeasurements).Click += Action_MeasListExport;
			((ToolStripItem)mainForm.menu.manipulateMeasDivMenuItem).Click += Action_MeasOperationABC;
			((ToolStripItem)mainForm.menu.manipulateMeasProductMenuItem).Click += Action_MeasOperationABC;
			((ToolStripItem)mainForm.menu.manipulateMeasDiffMenuItem).Click += Action_MeasOperationABC;
			((ToolStripItem)mainForm.menu.manipulateMeasSumMenuItem).Click += Action_MeasOperationABC;
			((ToolStripItem)mainForm.menu.manipulateMeasInvert).Click += Action_MeasOperationAB;
			((ToolStripItem)mainForm.menu.manipulateCopyAToBMenuItem).Click += Action_MeasCopyABC;
			((ToolStripItem)mainForm.menu.manipulateCopyAToCMenuItem).Click += Action_MeasCopyABC;
			((ToolStripItem)mainForm.menu.manipulateWindowAToBMenuItem).Click += Action_MeasCopyABC;
			((ToolStripItem)mainForm.menu.manipulateWindowAToBAndCMenuItem).Click += Action_MeasCopyABC;
			((ToolStripItem)mainForm.menu.manipulateAbcStitch).Click += Action_AbcStitch;
			((ToolStripItem)mainForm.menu.manipulateAbcMicCal).Click += Action_AbcCalib;
			((ToolStripItem)mainForm.menu.manipulateMatchAB).Click += Action_MatchAToB;
			((ToolStripItem)mainForm.menu.qboxSlotC).Click += Action_QBox;
			(freqGraph = new FreqGraph(mainForm.meas.freqGraph)).SetXAxisMode((AxisMode)1);
			freqGraph.SetYAxisMode((AxisMode)2);
			freqGraph.SetYTics(15);
			freqGraph.SetXTics(25);
			freqGraph.SetPlotWidth(2);
			freqGraph.phaseGraph.SetYTics(20);
			freqGraph.phaseGraph.SetPlotWidth(2);
			freqGraph.phaseGraph.SetXTics(25);
			freqGraph.AssignMeasurements(container);
			freqGraph.AssignToolTip(mainForm.toolTip);
			int samplerateIn = *(int*)((byte*)global::_003CModule_003E.HOLM_002EPAudioII_002EStream() + 16);
			(impulseGraph = new ImpulseGraph(mainForm.meas.impGraph, samplerateIn)).SetXAxisMode((AxisMode)0);
			impulseGraph.SetYAxisMode((AxisMode)0);
			impulseGraph.AssignToolTip(mainForm.toolTip);
			impulseGraph.fShowHDPreTops = true;
			impulseGraph.AssignMeasurements(container);
			impulseGraph.Event_Parameters += Action_ImpulseGraphParemetersChange;
			freqGraph.impulseGraphFriend = impulseGraph;
			((Control)mainForm.mainTabControl).KeyDown += new KeyEventHandler(Action_KeyDown);
			SetSplashScreenStatusString("Opening measurement file");
			if (global::_003CModule_003E.std_002Eoperator_003D_003D_003Cwchar_t_002Cstruct_0020std_003A_003Achar_traits_003Cwchar_t_003E_002Cclass_0020std_003A_003Aallocator_003Cwchar_t_003E_0020_003E(filename, (char*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref global::_003CModule_003E._003F_003F_C_0040_11LOCGONAA_0040_003F_0024AA_003F_0024AA_0040)) || !container.Open(filename))
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E obj2);
				basic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E* ptr2 = &obj2;
				basic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E* fileName = global::_003CModule_003E.std_002Ebasic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E_002E_007Bctor_007D(&obj2, (basic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref global::_003CModule_003E.HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x316290b9_002EAUTOSAVE_MEAS_FILENAME));
				System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E obj3);
				basic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E* filename2 = global::_003CModule_003E.HOLM_002EHOLMImpulse_002EConf_002EFilePath(&obj3, fileName);
				bool flag;
				try
				{
					flag = !container.Open(filename2);
				}
				catch
				{
					//try-fault
					global::_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E*, void>)(&global::_003CModule_003E.std_002Ebasic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E_002E_007Bdtor_007D), &obj3);
					throw;
				}
				global::_003CModule_003E.std_002Ebasic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E_002E_007Bdtor_007D(&obj3);
				if (flag)
				{
					System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj4);
					basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* ptr3 = global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D(&obj4, (basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref global::_003CModule_003E.HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x316290b9_002EAUTOSAVE_MEAS_OBSOLETE));
					string text3;
					try
					{
						System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj5);
						basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* ptr4 = &obj5;
						basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* fileName2 = global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D(&obj5, ptr3);
						text3 = global::_003CModule_003E.HOLM_002EHOLMImpulse_002EConf_002EFilePathString(fileName2, fSystem: false);
					}
					catch
					{
						//try-fault
						global::_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), ptr3);
						throw;
					}
					global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D(ptr3);
					if (File.Exists(text3))
					{
						System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj6);
						basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* ptr5 = global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D(&obj6, (basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref global::_003CModule_003E.HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x316290b9_002EAUTOSAVE_MEAS_OBSOLETE_DIR));
						string text4;
						try
						{
							System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj7);
							basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* ptr6 = &obj7;
							basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* fileName3 = global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D(&obj7, ptr5);
							text4 = global::_003CModule_003E.HOLM_002EHOLMImpulse_002EConf_002EFilePathString(fileName3, fSystem: false);
						}
						catch
						{
							//try-fault
							global::_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), ptr5);
							throw;
						}
						global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D(ptr5);
						if (!Directory.Exists(text4))
						{
							Directory.CreateDirectory(text4);
						}
						string text5 = new string(global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002Ec_str((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref global::_003CModule_003E.HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x316290b9_002EAUTOSAVE_MEAS_OBSOLETE)));
						string text6 = string.Concat(text4 + "/", text5);
						File.Move(text3, text6);
						System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E obj8);
						basic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E* filename3 = global::_003CModule_003E.HOLM_002EMiscHelper_002EStringToStdW(&obj8, text6);
						try
						{
							container.Open(filename3);
						}
						catch
						{
							//try-fault
							global::_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E*, void>)(&global::_003CModule_003E.std_002Ebasic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E_002E_007Bdtor_007D), &obj8);
							throw;
						}
						global::_003CModule_003E.std_002Ebasic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E_002E_007Bdtor_007D(&obj8);
					}
				}
			}
			int num3 = 0;
			do
			{
				container.presenter[num3].UpdatePlotEvent += Action_UpdatePlot;
				num3++;
			}
			while (num3 < 4);
			int num4 = 0;
			do
			{
				container.formpresenter[num4].AssignImpulseGraph(impulseGraph);
				num4++;
			}
			while (num4 < 3);
			BasicMeasurementPresenter[] presenter = container.presenter;
			if (((byte*)presenter[0].measPtr)[28] != 0 || ((byte*)presenter[1].measPtr)[28] != 0 || ((byte*)presenter[2].measPtr)[28] != 0)
			{
				mainForm.mainTabControl.SelectedTab = mainForm.measurementTab;
			}
			audio.InitializeGuiObjects();
			UpdateSignal();
		}
		catch
		{
			//try-fault
			global::_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E*, void>)(&global::_003CModule_003E.std_002Ebasic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E_002E_007Bdtor_007D), filename);
			throw;
		}
		global::_003CModule_003E.std_002Ebasic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E_002E_007Bdtor_007D(filename);
	}

	private void UpdateFgBgColors()
	{
		freqGraph.SetForeColor(Options.Field.Plot.ColorFg);
		impulseGraph.SetForeColor(Options.Field.Plot.ColorFg);
		freqGraph.plotArea.BackColor = Options.Field.Plot.ColorBg;
		impulseGraph.plotArea.BackColor = Options.Field.Plot.ColorBg;
	}

	private unsafe void Action_MeasListExport(object sender, EventArgs e)
	{
		pImExport.ShowExportListDialog(container.list);
	}

	private unsafe void Action_MeasStart(object sender, EventArgs e)
	{
		fReactOnGuiChanges = false;
		ControlMeasurements meas = mainForm.meas;
		if (sender == meas.mA.measureButton)
		{
			presenterIndex = 0;
			presenterMeasString = "A";
		}
		else if (sender == meas.mB.measureButton)
		{
			presenterIndex = 1;
			presenterMeasString = "B";
		}
		else if (sender == meas.mC.measureButton)
		{
			presenterIndex = 2;
			presenterMeasString = "C";
		}
		BasicMeasurementPresenter basicMeasurementPresenter = container.presenter[presenterIndex];
		if (!basicMeasurementPresenter.fPlot)
		{
			basicMeasurementPresenter.fPlot = true;
			container.formpresenter[presenterIndex].mForm.plotCheckBox.Checked = true;
		}
		bool flag = audio.PerformMeasurement(container.presenter[presenterIndex].measPtr, presenterMeasString);
		container.formpresenter[presenterIndex].UpdateInfo();
		if (flag)
		{
			UpdatePlotSettings();
			impulseGraph.AutoZoom(fTime: false);
			freqGraph.UpdatePlotArea();
			impulseGraph.UpdatePlotArea();
		}
		((Control)mainForm).Refresh();
		if (flag && container.formpresenter[presenterIndex].comboBox.Text.StartsWith("Empty"))
		{
			int selectedIndex = container.formpresenter[presenterIndex].comboBox.SelectedIndex;
			container.formpresenter[presenterIndex].SetText("Unnamed-" + selectedIndex);
		}
		fReactOnGuiChanges = true;
	}

	private unsafe void Action_DragAndDrop(object sender, DragEventArgs e)
	{
		Exception ex = null;
		string[] array = (string[])e.Data.GetData(DataFormats.FileDrop);
		((Form)mainForm).Activate();
		string question = string.Concat("Open file as measurements?\n\n" + "File: ", array[0]);
		if (!dialog.ShowQuestionOKCancelHolm(question))
		{
			return;
		}
		bool flag = false;
		try
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E obj);
			basic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E* filename = global::_003CModule_003E.HOLM_002EMiscHelper_002EStringToStdW(&obj, array[0]);
			try
			{
				flag = container.Open(filename);
			}
			catch
			{
				//try-fault
				global::_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E*, void>)(&global::_003CModule_003E.std_002Ebasic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E_002E_007Bdtor_007D), &obj);
				throw;
			}
			global::_003CModule_003E.std_002Ebasic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E_002E_007Bdtor_007D(&obj);
			ResetSlotNumbers();
			UpdatePlot(fRescaleImpulse: true);
		}
		catch (Exception ex2)
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj2);
			global::_003CModule_003E.std_002Ebasic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D(&obj2, 3, 1);
			try
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj3);
				basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* ptr = global::_003CModule_003E.HOLM_002EMiscHelper_002EStringToStd(&obj3, ex2.ToString());
				try
				{
					global::_003CModule_003E.std_002Eoperator_003C_003C_003Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_0020_003E(global::_003CModule_003E.std_002Eoperator_003C_003C_003Cchar_002Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_002Cclass_0020std_003A_003Aallocator_003Cchar_003E_0020_003E(global::_003CModule_003E.std_002Eoperator_003C_003C_003Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_0020_003E(global::_003CModule_003E.std_002Eoperator_003C_003C_003Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_0020_003E((basic_ostream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj2, 8)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref global::_003CModule_003E._003F_003F_C_0040_08KFJDDMMO_0040WARNING_003F5_003F_0024AA_0040)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref global::_003CModule_003E._003F_003F_C_0040_0CJ_0040NIJFOCKC_0040MainCtrl_003F3_003F3Action_DragAndDrop_003F5Exc_0040)), ptr), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref global::_003CModule_003E._003F_003F_C_0040_01EEMJAFIK_0040_003F6_003F_0024AA_0040));
				}
				catch
				{
					//try-fault
					global::_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), &obj3);
					throw;
				}
				global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D(&obj3);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj4);
				basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* ptr2 = global::_003CModule_003E.std_002Ebasic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002Estr(&obj2, &obj4);
				try
				{
					global::_003CModule_003E.HOLM_002ELogging_002EHolmLogger_002ELogText(ptr2);
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
				global::_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&global::_003CModule_003E.std_002Ebasic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E__vbaseDtor), &obj2);
				throw;
			}
			global::_003CModule_003E.std_002Ebasic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E__vbaseDtor(&obj2);
			WaitingCtrl.DoNotWaitOverride();
		}
		if (!flag)
		{
			dialog.ShowInfo(string.Concat(string.Concat("Failed to open file:\n" + array[0], "\nException:\n"), ((object)e).ToString()));
		}
	}

	private void Action_DragEnter(object sender, DragEventArgs e)
	{
		e.Effect = (DragDropEffects)1;
	}

	private void Action_BrowseAppData(object sender, EventArgs e)
	{
		string fullName = Directory.GetParent(Application.UserAppDataPath).FullName;
		Process.Start("explorer", fullName);
	}

	private void Action_Exit(object sender, EventArgs e)
	{
		((Form)mainForm).Close();
	}

	private void Action_PlotSettingsChanged(object sender, EventArgs e)
	{
		UpdatePlotSettings();
		freqGraph.UpdatePlotArea();
		impulseGraph.UpdatePlotArea();
	}

	private void Action_PlotOptionsChanged(object sender, EventArgs e)
	{
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Invalid comparison between Unknown and I4
		if (sender == mainForm.analysis.normalize0dBCheckBox)
		{
			FormNormalizationDialog formNormalizationDialog = new FormNormalizationDialog();
			if (mainForm.analysis.normalize0dBCheckBox.Checked)
			{
				decimal value = 20;
				formNormalizationDialog.maxDBUpDown.Value = value;
				decimal value2 = -20;
				formNormalizationDialog.phaseHideDBUpDown.Value = value2;
				decimal value3 = -20;
				formNormalizationDialog.distortionHideDBUpDown.Value = value3;
			}
			else
			{
				decimal value4 = 5;
				formNormalizationDialog.maxDBUpDown.Value = value4;
				decimal value5 = -50;
				formNormalizationDialog.phaseHideDBUpDown.Value = value5;
				decimal value6 = -50;
				formNormalizationDialog.distortionHideDBUpDown.Value = value6;
			}
			if ((int)((Form)formNormalizationDialog).ShowDialog() == 6)
			{
				decimal value7 = formNormalizationDialog.maxDBUpDown.Value;
				ampMaxNumTextBox.SetValue(value7);
				decimal value8 = formNormalizationDialog.phaseHideDBUpDown.Value;
				phaseHideNumTextBox.SetValue(value8);
				decimal value9 = formNormalizationDialog.distortionHideDBUpDown.Value;
				hdHideNumTextBox.SetValue(value9);
				sender = ampMaxNumTextBox;
			}
			((IDisposable)formNormalizationDialog)?.Dispose();
		}
		WaitingCtrl.Wait("MainCtrl::Action_PlotOptionsChanged", "Updating graphics");
		if (fReactOnGuiChanges)
		{
			fReactOnGuiChanges = false;
			PlotOptions plot = Options.Field.Plot;
			plot.PlotFreqMin = freqMinNumTextBox.GetValue();
			plot.PlotFreqMax = freqMaxNumTextBox.GetValue();
			plot.GraphicsNumberOfXTics = freqTicNumTextBox.GetValueInt();
			PlotOptions plot2 = Options.Field.Plot;
			plot2.PlotDbMin = ampMinNumTextBox.GetValue();
			plot2.PlotDbMax = ampMaxNumTextBox.GetValue();
			plot2.PlotImpulseDBMin = mainForm.meas.impGraph.dB0UpDown.Value;
			plot2.GraphicsNumberOfYTics = ampTicNumTextBox.GetValueInt();
			PlotOptions plot3 = Options.Field.Plot;
			plot3.HidePhaseWhenBelowDB = phaseHideNumTextBox.GetValue();
			plot3.HideHDWhenBelowDB = hdHideNumTextBox.GetValue();
			Options.Field.Plot.ImpulseShowHD = mainForm.menu.optionsImpulseShowHD.Checked;
			Options.Field.Plot.FreqShowGating = mainForm.menu.optionFreqShowGating.Checked;
			Options.Field.Plot.PlotPhase = mainForm.meas.plotPhaseCheckBox.Checked;
			Options.Field.Plot.PlotAmplitude = mainForm.meas.plotAmpCheckBox.Checked;
			Options.Field.Plot.PlotHD = mainForm.meas.plotHdCheckBox.Checked;
			Options.Field.Plot.ImpulseInterpolate = mainForm.menu.impulseInterpolate.Checked;
			((Control)mainForm.meas.plotHdComboBox).Enabled = mainForm.meas.plotHdCheckBox.Checked;
			freqGraph.plotHD = (PlotHD)mainForm.meas.plotHdComboBox.SelectedIndex;
			ControlMenu menu = mainForm.menu;
			if (sender == menu.linFreqMenuItem)
			{
				Options.Field.Plot.FreqLogAxis = false;
			}
			else if (sender == menu.logFreqMenuItem)
			{
				Options.Field.Plot.FreqLogAxis = true;
			}
			else if (sender == menu.linAmpMenuItem)
			{
				Options.Field.Plot.AmpDBAxis = false;
			}
			else if (sender == menu.decibelAmpMenuItem)
			{
				Options.Field.Plot.AmpDBAxis = true;
			}
			int num = ((sender == freqMinNumTextBox || sender == freqMaxNumTextBox || sender == ampMinNumTextBox || sender == ampMaxNumTextBox) ? 1 : 0);
			ApplyGraphicOptions((byte)num != 0);
			fReactOnGuiChanges = true;
		}
		WaitingCtrl.DoNotWait("MainCtrl::Action_PlotOptionsChanged");
	}

	private void Action_UpdatePlot(object sender, EventArgs e)
	{
		if (fReactOnGuiChanges)
		{
			impulseGraph.UpdatePlotArea();
			freqGraph.UpdatePlotArea();
		}
	}

	private void Action_OpenFile(object sender, EventArgs e)
	{
		if (container.OpenDialog())
		{
			ResetSlotNumbers();
			impulseGraph.AutoZoom(fTime: false);
			impulseGraph.UpdatePlotArea();
			freqGraph.UpdatePlotArea();
		}
	}

	private void Action_OpenAppendFile(object sender, EventArgs e)
	{
		container.OpenAppendDialog();
		impulseGraph.UpdatePlotArea();
		freqGraph.UpdatePlotArea();
	}

	private void Action_ClearMeasurements(object sender, EventArgs e)
	{
		container.Clear();
		impulseGraph.UpdatePlotArea();
		freqGraph.UpdatePlotArea();
	}

	private unsafe void Action_SaveFile(object sender, EventArgs e)
	{
		byte b = ((sender == mainForm.menu.saveMeasurementsWav) ? ((byte)1) : ((byte)0));
		((byte*)container.list)[4] = b;
		container.SaveDialog();
		((byte*)container.list)[4] = 0;
	}

	private void Action_Rearange(object sender, EventArgs e)
	{
		ControlMenu menu = mainForm.menu;
		if (sender == menu.rearangeMenuItem)
		{
			container.Rearange();
			impulseGraph.AutoZoom(fTime: false);
			impulseGraph.UpdatePlotArea();
			freqGraph.UpdatePlotArea();
		}
		else if (sender == menu.organizeMeasurements || sender == mainForm.meas.organizeButton)
		{
			container.OrganizeDialog();
			impulseGraph.AutoZoom(fTime: false);
			impulseGraph.UpdatePlotArea();
			freqGraph.UpdatePlotArea();
		}
	}

	private void Action_ImpulseModeChanged(object sender, EventArgs e)
	{
		if (fReactOnGuiChanges)
		{
			ControlMenu menu = mainForm.menu;
			if (sender == menu.impulseAsSamplesMenuItem)
			{
				menu.impulseAsSamplesMenuItem.Checked = true;
				mainForm.menu.impulseAsTimeMenuItem.Checked = false;
				mainForm.menu.impulseAsDistanceMenuItem.Checked = false;
				impulseGraph.SetMode((ImpulseGraphMode)0);
			}
			else if (sender == menu.impulseAsTimeMenuItem)
			{
				menu.impulseAsSamplesMenuItem.Checked = false;
				mainForm.menu.impulseAsTimeMenuItem.Checked = true;
				mainForm.menu.impulseAsDistanceMenuItem.Checked = false;
				impulseGraph.SetMode((ImpulseGraphMode)1);
			}
			else if (sender == menu.impulseAsDistanceMenuItem)
			{
				menu.impulseAsSamplesMenuItem.Checked = false;
				mainForm.menu.impulseAsTimeMenuItem.Checked = false;
				mainForm.menu.impulseAsDistanceMenuItem.Checked = true;
				impulseGraph.SetMode((ImpulseGraphMode)2);
			}
		}
	}

	private void Action_ToClipBoard(object sender, EventArgs e)
	{
		ControlMenu menu = mainForm.menu;
		if (sender == menu.freqToClipBoard)
		{
			freqGraph.CopyToClipBoard();
		}
		else if (sender == menu.freqImpToClipBoard)
		{
			freqGraph.CopyToClipBoardWithImpulseFriend(menu.bitmapLegends.Checked);
		}
		else if (sender == menu.impToClipBoard)
		{
			impulseGraph.CopyToClipBoard();
		}
	}

	private void Action_SaveBitmap(object sender, EventArgs e)
	{
		ControlMenu menu = mainForm.menu;
		if (sender == menu.freqSaveBitmapMenuItem)
		{
			bool @checked = menu.bitmapLegends.Checked;
			FreqGraph freqGraph = this.freqGraph;
			if (@checked)
			{
				freqGraph.PrintLegends();
			}
			freqGraph.SaveBitmapDialog();
		}
		else if (sender == menu.freqImpSaveBitmapMenuItem)
		{
			this.freqGraph.SaveBitmapDialogWithImpulseFriend(menu.bitmapLegends.Checked);
		}
		else if (sender == menu.impulseSaveBitmapMenuItem)
		{
			bool checked2 = menu.bitmapLegends.Checked;
			ImpulseGraph impulseGraph = this.impulseGraph;
			if (checked2)
			{
				impulseGraph.PrintLegends();
			}
			impulseGraph.SaveBitmapDialog();
		}
	}

	private void Action_ImageGraphResize(object sender, EventArgs e)
	{
		int num = 800 - ((Control)mainForm.meas.freqGraph).Width;
		int num2 = 598 - ((Control)mainForm.meas.freqGraph).Height - ((Control)mainForm.meas.impGraph).Height;
		Form1 form = mainForm;
		((Control)form).Width = ((Control)form).Width + num;
		Form1 form2 = mainForm;
		((Control)form2).Height = ((Control)form2).Height + num2;
	}

	private void Action_ImpulseGraphParemetersChange(object sender, EventArgs e)
	{
		if (fReactOnGuiChanges)
		{
			impulseGraph.UpdatePlotArea();
			freqGraph.UpdatePlotArea();
		}
	}

	private void Action_FreqWindowEnabled(object sender, EventArgs e)
	{
		UpdateSignal();
		UpdatePlotSettings();
		impulseGraph.UpdatePlotArea();
		freqGraph.UpdatePlotArea();
	}

	private void Action_FreqWindowChanged(object sender, EventArgs e)
	{
		UpdateSignal();
		impulseGraph.UpdatePlotArea();
		freqGraph.UpdatePlotArea();
	}

	private void Action_ColorFgBgClick(object sender, EventArgs e)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Invalid comparison between Unknown and I4
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Invalid comparison between Unknown and I4
		ControlMenu menu = mainForm.menu;
		if (sender == menu.colorBgMenuItem)
		{
			if ((int)((CommonDialog)Options.colorDialog).ShowDialog() == 1)
			{
				Color color = Options.colorDialog.Color;
				Options.Field.Plot.ColorBg = color;
			}
		}
		else if (sender == menu.colorFgMenuItem && (int)((CommonDialog)Options.colorDialog).ShowDialog() == 1)
		{
			Color color2 = Options.colorDialog.Color;
			Options.Field.Plot.ColorFg = color2;
		}
		UpdateFgBgColors();
		impulseGraph.UpdatePlotArea();
		freqGraph.UpdatePlotArea();
	}

	private void Action_LineWidthChanged(object sender, EventArgs e)
	{
		if (fReactOnGuiChanges)
		{
			Options.Field.Plot.LineWidth = mainForm.menu.lineWidthComboBox.SelectedIndex + 1;
			((ToolStripDropDownItem)mainForm.menu.optionsMenu).HideDropDown();
			ApplyGraphicOptions(fNewFreqRange: false);
		}
	}

	private void Action_KeyDown(object sender, KeyEventArgs e)
	{
		_ = mainForm.mainTabControl.SelectedIndex;
	}

	private void Action_OptionsReset(object sender, EventArgs e)
	{
		Options.Reset();
		audio.LoadFromOptions();
		ResetSlotNumbers();
		ApplyGraphicOptions(fNewFreqRange: true);
	}

	private void Action_OptionsLoad(object sender, EventArgs e)
	{
		if (Options.LoadAsDialog())
		{
			audio.LoadFromOptions();
			ApplyGraphicOptions(fNewFreqRange: true);
		}
	}

	private void Action_OptionsSave(object sender, EventArgs e)
	{
		Options.SaveAsDialog();
	}

	private void Action_ShowToolTips(object sender, EventArgs e)
	{
		byte active = ((!mainForm.toolTip.Active) ? ((byte)1) : ((byte)0));
		mainForm.toolTip.Active = active != 0;
		mainForm.menu.showToolTipsMenuItem.Checked = mainForm.toolTip.Active;
	}

	private unsafe void Action_MeasOperationABC(object sender, EventArgs e)
	{
		ControlMenu menu = mainForm.menu;
		if (sender == menu.manipulateMeasDiffMenuItem)
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj);
			basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* ptr = &obj;
			basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* op = global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D(&obj, (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref global::_003CModule_003E._003F_003F_C_0040_01JOAMLHOP_0040_003F9_003F_0024AA_0040));
			ABCOperation(op);
		}
		else if (sender == menu.manipulateMeasSumMenuItem)
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj2);
			basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* ptr2 = &obj2;
			basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* op2 = global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D(&obj2, (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref global::_003CModule_003E._003F_003F_C_0040_01MIFGBAGJ_0040_003F_0024CL_003F_0024AA_0040));
			ABCOperation(op2);
		}
		else if (sender == menu.manipulateMeasDivMenuItem)
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj3);
			basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* ptr3 = &obj3;
			basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* op3 = global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D(&obj3, (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref global::_003CModule_003E._003F_003F_C_0040_01KMDKNFGN_0040_003F1_003F_0024AA_0040));
			ABCOperation(op3);
		}
		else if (sender == menu.manipulateMeasProductMenuItem)
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj4);
			basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* ptr4 = &obj4;
			basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* op4 = global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D(&obj4, (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref global::_003CModule_003E._003F_003F_C_0040_01NBENCBCI_0040_003F_0024CK_003F_0024AA_0040));
			ABCOperation(op4);
		}
	}

	private unsafe void Action_MeasOperationAB(object sender, EventArgs e)
	{
		if (sender == mainForm.menu.manipulateMeasInvert)
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj);
			basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* ptr = &obj;
			basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* op = global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D(&obj, (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref global::_003CModule_003E._003F_003F_C_0040_03EMFPMALO_00401_003F1A_003F_0024AA_0040));
			ABOperation(op);
		}
	}

	private unsafe void Action_MeasCopyABC(object sender, EventArgs e)
	{
		BasicMeasurementPresenter[] presenter = container.presenter;
		Measurement* measPtr = presenter[0].measPtr;
		Measurement* measPtr2 = presenter[1].measPtr;
		Measurement* measPtr3 = presenter[2].measPtr;
		if (measPtr == measPtr2 || ((byte*)measPtr)[28] == 0)
		{
			return;
		}
		ControlMenu menu = mainForm.menu;
		if (sender == menu.manipulateCopyAToBMenuItem)
		{
			global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementCore_002ECopyAllFrom((MeasurementCore*)measPtr2, (MeasurementCore*)measPtr);
			container.formpresenter[1].UpdateComboBox();
		}
		else if (sender == menu.manipulateCopyAToCMenuItem)
		{
			global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementCore_002ECopyAllFrom((MeasurementCore*)measPtr3, (MeasurementCore*)measPtr);
			container.formpresenter[2].UpdateComboBox();
		}
		else if (sender == menu.manipulateWindowAToBMenuItem)
		{
			global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementCore_002ECopyImpulseWindowFrom((MeasurementCore*)measPtr2, (MeasurementCore*)measPtr);
		}
		else if (sender == menu.manipulateWindowAToBAndCMenuItem)
		{
			global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementCore_002ECopyImpulseWindowFrom((MeasurementCore*)measPtr2, (MeasurementCore*)measPtr);
			if (measPtr != measPtr3)
			{
				global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementCore_002ECopyImpulseWindowFrom((MeasurementCore*)measPtr3, (MeasurementCore*)measPtr);
			}
		}
		impulseGraph.UpdatePlotArea();
		freqGraph.UpdatePlotArea();
	}

	private unsafe void Action_AbcStitch(object sender, EventArgs e)
	{
		BasicMeasurementPresenter[] presenter = container.presenter;
		Measurement* measPtr = presenter[0].measPtr;
		Measurement* measPtr2 = presenter[1].measPtr;
		Measurement* measPtr3 = presenter[2].measPtr;
		if (((byte*)measPtr)[28] != 0 && ((byte*)measPtr2)[28] != 0)
		{
			int num = *(int*)((byte*)measPtr + 52);
			if (num == *(int*)((byte*)measPtr2 + 52))
			{
				int num2 = *(int*)((byte*)measPtr + 64);
				if (num2 == *(int*)((byte*)measPtr2 + 64))
				{
					if (((byte*)measPtr3)[28] == 0 || *(int*)((byte*)measPtr3 + 52) != num)
					{
						global::_003CModule_003E.HOLM_002EMeasure_002EMeasurement_002EInitializeDirac(measPtr3, *(int*)((byte*)measPtr + 60), num2, 1.0);
					}
					global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementCore_002ESetImpulseWindowEnabled((MeasurementCore*)measPtr3, false);
					global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementCore_002ESetSmoothingEnabled((MeasurementCore*)measPtr3, false);
					if (formAbcStitch == null)
					{
						formAbcStitch = new FormAbcStitch();
						((Control)formAbcStitch.updateButton).Click += Action_AbcStitchUpdate;
						((Control)formAbcStitch.undoButton).Click += Action_AReset;
					}
					mainForm.meas.mC.plotCheckBox.Checked = true;
					UpdatePlotSettings();
					container.formpresenter[2].SetText(string.Concat(string.Concat(string.Concat("(" + container.formpresenter[0].comboBox.Text, ") -> ("), container.formpresenter[1].comboBox.Text), ")"));
					((Control)formAbcStitch).Show();
					return;
				}
			}
		}
		dialog.ShowInfo(string.Concat(string.Concat("Can only stitch measurement A to measurement B when:\n" + "- A & B are both not empty\n", "- A & B have the same samplerate\n"), "- A & B have the same signal length\n"));
	}

	private unsafe void Action_AbcStitchUpdate(object sender, EventArgs e)
	{
		BasicMeasurementPresenter[] presenter = container.presenter;
		Measurement* measPtr = presenter[0].measPtr;
		Measurement* measPtr2 = presenter[1].measPtr;
		Measurement* measPtr3 = presenter[2].measPtr;
		double num = decimal.ToDouble(formAbcStitch.centerUpDown.Value);
		double num2 = decimal.ToDouble(formAbcStitch.lengthUpDown.Value);
		bool @checked = formAbcStitch.matchPhaseCheckBox.Checked;
		global::_003CModule_003E.HOLM_002EMeasure_002EStitch(measPtr, measPtr2, measPtr3, num, num2, @checked);
		impulseGraph.UpdatePlotArea();
		freqGraph.UpdatePlotArea();
		freqGraph.SetPlotWidth(2);
		Color foreColor = freqGraph.plotArea.ForeColor;
		freqGraph.SetDrawColor(foreColor);
		double num3 = num2 * 0.5;
		freqGraph.DrawLineVertical(num - num3);
		freqGraph.DrawLineVertical(num3 + num);
		freqGraph.DisplayBitmap();
	}

	private unsafe void Action_MatchAToB(object sender, EventArgs e)
	{
		BasicMeasurementPresenter[] presenter = container.presenter;
		if (((byte*)presenter[0].measPtr)[28] != 0 && ((byte*)presenter[1].measPtr)[28] != 0)
		{
			if (formMatchAToB == null)
			{
				formMatchAToB = new FormMatchAToB();
				((Control)formMatchAToB.updateButton).Click += Action_MatchAToBUpdate;
				((Control)formMatchAToB.undoButton).Click += Action_AReset;
			}
			((Control)formMatchAToB).Show();
		}
		else
		{
			dialog.ShowInfo("Can only stitch measurement A to measurement B when:\n" + "- A & B are both not empty\n");
		}
	}

	private void Action_QBox(object sender, EventArgs e)
	{
		if (formQBox == null)
		{
			formQBox = new FormQBox();
			((Control)formQBox.updateButton).Click += Action_QBoxUpdate;
			((Control)formQBox.autoCheckBox).Click += Action_QBoxUpdate;
			((Control)formQBox.fitAButton).Click += Action_QBoxUpdate;
			((Control)formQBox.fitBButton).Click += Action_QBoxUpdate;
			formQBox.range0UpDown.ValueChanged += Action_QBoxUpdate;
			formQBox.range1UpDown.ValueChanged += Action_QBoxUpdate;
			formQBox.qtcUpDown.ValueChanged += Action_QBoxUpdate;
			formQBox.fbUpDown.ValueChanged += Action_QBoxUpdate;
		}
		formQBox.autoCheckBox.Checked = false;
		((Control)formQBox).Show();
	}

	private unsafe void Action_QBoxUpdate(object sender, EventArgs e)
	{
		if (!global::_003CModule_003E._003FA0x316290b9_002E_003FfReactOnQboxGui_0040_003F1_003F_003FAction_QBoxUpdate_0040MainCtrl_0040HOLMImpulse_0040HOLM_0040_0040A_0024AAMXP_0024AAVObject_0040System_0040_0040P_0024AAVEventArgs_00406_0040_0040Z_00404_NA)
		{
			return;
		}
		global::_003CModule_003E._003FA0x316290b9_002E_003FfReactOnQboxGui_0040_003F1_003F_003FAction_QBoxUpdate_0040MainCtrl_0040HOLMImpulse_0040HOLM_0040_0040A_0024AAMXP_0024AAVObject_0040System_0040_0040P_0024AAVEventArgs_00406_0040_0040Z_00404_NA = false;
		double num = decimal.ToDouble(this.formQBox.range0UpDown.Value);
		double num2 = decimal.ToDouble(this.formQBox.range1UpDown.Value);
		double num3 = (num2 + num) * 0.5;
		double num4 = num2 - num;
		Measurement* ptr = null;
		FormQBox formQBox = this.formQBox;
		int num5 = ((sender != formQBox.range0UpDown && sender != formQBox.range1UpDown) ? 1 : 0);
		this.formQBox.autoCheckBox.Checked = (byte)((formQBox.autoCheckBox.Checked ? 1u : 0u) & (uint)num5) != 0;
		FormQBox formQBox2 = this.formQBox;
		if (sender == formQBox2.fitAButton || sender == formQBox2.fitBButton)
		{
			Measurement* ptr2 = ((sender != formQBox2.fitAButton) ? container.formpresenter[1].measPtr : container.formpresenter[0].measPtr);
			ptr = ptr2;
			double value = decimal.ToDouble(formQBox2.qtcUpDown.Value);
			double value2 = decimal.ToDouble(this.formQBox.fbUpDown.Value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out double num6);
			global::_003CModule_003E.HOLM_002EMeasure_002EQBoxFit(ptr2, &value, &value2, &num6, num, num2);
			decimal value3 = new decimal(value);
			this.formQBox.qtcUpDown.Value = value3;
			decimal value4 = new decimal(value2);
			this.formQBox.fbUpDown.Value = value4;
		}
		if (!this.formQBox.autoCheckBox.Checked)
		{
			formQBox2 = this.formQBox;
			if (sender != formQBox2.updateButton && sender != formQBox2.fitAButton && sender != formQBox2.fitBButton)
			{
				goto IL_0369;
			}
		}
		double num7 = *(int*)((byte*)global::_003CModule_003E.HOLM_002EPAudioII_002EStream() + 16);
		int num8 = 1 << global::_003CModule_003E.HOLM_002EMath_002EToIntRound(num7 / 40000.0) + 14;
		Measurement* measPtr = container.formpresenter[2].measPtr;
		double num9 = decimal.ToDouble(this.formQBox.qtcUpDown.Value);
		double num10 = decimal.ToDouble(this.formQBox.fbUpDown.Value);
		complex_003Cdouble_003E* ptr3 = global::_003CModule_003E.Mem_002EAllocateArray_003Cclass_0020std_003A_003Acomplex_003Cdouble_003E_0020_003E((uint)(num8 + 1));
		double num11 = num7 / ((double)num8 * 2.0);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out QBox qBox);
		global::_003CModule_003E.HOLM_002EFilter_002EQBox_002E_007Bctor_007D(&qBox, num9, num10);
		int num12 = 0;
		if (0 <= num8)
		{
			int num13 = 0;
			do
			{
				double num14 = global::_003CModule_003E.HOLM_002EFilter_002EQBox_002EAmplitude(&qBox, (double)num12 * num11);
				global::_003CModule_003E.std_002Ecomplex_003Cdouble_003E_002E_003D((complex_003Cdouble_003E*)(num13 + (byte*)ptr3), &num14);
				num12++;
				num13 += 16;
			}
			while (num12 <= num8);
		}
		global::_003CModule_003E.HOLM_002EMeasure_002EApplyMinimumPhase(ptr3, num8, true, 1E-10);
		global::_003CModule_003E.HOLM_002EMeasure_002EMeasurement_002EInitializeFreq(measPtr, ptr3, num8, (int)num7, num8, (SignalType)4, num9, num10, false);
		global::_003CModule_003E.Mem_002EFreeArray_003Cclass_0020std_003A_003Acomplex_003Cdouble_003E_0020_003E(&ptr3, 0u);
		formQBox2 = this.formQBox;
		if (sender == formQBox2.fitAButton || sender == formQBox2.fitBButton)
		{
			global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementCore_002ECopyImpulseWindowFrom((MeasurementCore*)measPtr, (MeasurementCore*)ptr);
			if (((byte*)ptr)[217] != 0)
			{
				global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementCore_002ECopyFilterFrom((MeasurementCore*)measPtr, (MeasurementCore*)ptr);
			}
			global::_003CModule_003E.HOLM_002EMeasure_002EMatch(measPtr, ptr, num3, num4, true);
		}
		double num15 = num10;
		double num16 = num9;
		container.formpresenter[2].SetText(string.Concat(string.Concat("QBox: Qtc = " + num16.ToString("F3"), " Fb = "), num15.ToString("F0")));
		container.formpresenter[2].UpdateInfo();
		mainForm.meas.mC.plotCheckBox.Checked = true;
		container.formpresenter[2].fPlot = true;
		impulseGraph.UpdatePlotArea();
		freqGraph.UpdatePlotArea();
		goto IL_0369;
		IL_0369:
		FormQBox formQBox3 = this.formQBox;
		if (sender == formQBox3.range0UpDown || sender == formQBox3.range1UpDown || sender == formQBox3.fitAButton || sender == formQBox3.fitBButton)
		{
			freqGraph.UpdatePlotArea();
			freqGraph.SetPlotWidth(2);
			Color foreColor = freqGraph.plotArea.ForeColor;
			freqGraph.SetDrawColor(foreColor);
			freqGraph.DrawLineVertical(num);
			freqGraph.DrawLineVertical(num2);
			freqGraph.DisplayBitmap();
		}
		global::_003CModule_003E._003FA0x316290b9_002E_003FfReactOnQboxGui_0040_003F1_003F_003FAction_QBoxUpdate_0040MainCtrl_0040HOLMImpulse_0040HOLM_0040_0040A_0024AAMXP_0024AAVObject_0040System_0040_0040P_0024AAVEventArgs_00406_0040_0040Z_00404_NA = true;
	}

	private unsafe void Action_MatchAToBUpdate(object sender, EventArgs e)
	{
		BasicMeasurementPresenter[] presenter = container.presenter;
		Measurement* measPtr = presenter[0].measPtr;
		Measurement* measPtr2 = presenter[1].measPtr;
		double num = decimal.ToDouble(formMatchAToB.centerUpDown.Value);
		double num2 = decimal.ToDouble(formMatchAToB.lengthUpDown.Value);
		bool @checked = formMatchAToB.matchPhaseCheckBox.Checked;
		global::_003CModule_003E.HOLM_002EMeasure_002EMatch(measPtr, measPtr2, num, num2, @checked);
		freqGraph.UpdatePlotArea();
		freqGraph.SetPlotWidth(2);
		Color foreColor = freqGraph.plotArea.ForeColor;
		freqGraph.SetDrawColor(foreColor);
		double num3 = num2 * 0.5;
		freqGraph.DrawLineVertical(num - num3);
		freqGraph.DrawLineVertical(num3 + num);
		freqGraph.DisplayBitmap();
	}

	private unsafe void Action_AReset(object sender, EventArgs e)
	{
		Measurement* measPtr = container.presenter[0].measPtr;
		global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementCore_002EAmplifyAbsolute((MeasurementCore*)measPtr, 1.0);
		global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementCore_002EOffsetAbsolute((MeasurementCore*)measPtr, 0.0);
		impulseGraph.UpdatePlotArea();
		freqGraph.UpdatePlotArea();
	}

	private unsafe void Action_HelpAbout(object sender, EventArgs e)
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj);
		basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* ptr = &obj;
		basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* fileName = global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D(&obj, (basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref global::_003CModule_003E.HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x316290b9_002ELICENSE));
		string text = global::_003CModule_003E.HOLM_002EHOLMImpulse_002EConf_002EFilePathString(fileName, fSystem: true);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj2);
		basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* ptr2 = &obj2;
		basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* fileName2 = global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D(&obj2, (basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref global::_003CModule_003E.HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x316290b9_002EISSUES));
		string text2 = global::_003CModule_003E.HOLM_002EHOLMImpulse_002EConf_002EFilePathString(fileName2, fSystem: true);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj3);
		basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* pThis = &obj3;
		basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* fileName3 = global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D(&obj3, (basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref global::_003CModule_003E.HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x316290b9_002ECHANGELOG));
		string text4;
		try
		{
			string text3 = "\n";
			text4 = "\n";
		}
		catch
		{
			//try-fault
			global::_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), pThis);
			throw;
		}
		dialog.ShowInfoHolm(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat("This HOLMImpulse version: " + Application.ProductVersion.Replace(", ", "."), text4), text4), "ChangeLog: "), global::_003CModule_003E.HOLM_002EHOLMImpulse_002EConf_002EFilePathString(fileName3, fSystem: true)), text4), "Issues:    "), text2), text4), "License:   "), text), text4), text4), "Online: http://www.holmacoustics.com/downloads/HOLMImpulse/ChangeLog.txt\n"), text4), "HOLMImpulse is Freeware with no limitations.\n"), text4), "The purpose of the application is to:\n"), "- Make bandwitdh limited measurements with no phase-errors\n"), "- Measure the impulse-response\n"), "- Measure the phase-response\n"), "- Measure the frequency-response\n"), "- Measure THD using log-sweep\n"), "- Compare measurements\n\n"), "http://www.holmacoustics.com/holmimpulse.php"));
	}

	private void Action_CheckForUpdateAtStartup(object sender, EventArgs e)
	{
		MiscOptions misc = Options.Field.Misc;
		int checkForUpdate = ((!misc.CheckForUpdate) ? 1 : 0);
		misc.CheckForUpdate = (byte)checkForUpdate != 0;
		mainForm.menu.checkforUpdateAtStart.Checked = Options.Field.Misc.CheckForUpdate;
	}

	private unsafe void Action_AbcCalib(object sender, EventArgs e)
	{
		BasicMeasurementPresenter[] presenter = container.presenter;
		Measurement* measPtr = presenter[0].measPtr;
		Measurement* measPtr2 = presenter[1].measPtr;
		if (((byte*)measPtr)[28] != 0 && ((byte*)measPtr2)[28] != 0 && *(int*)((byte*)measPtr + 52) == *(int*)((byte*)measPtr2 + 52) && *(int*)((byte*)measPtr + 64) == *(int*)((byte*)measPtr2 + 64))
		{
			if (formAbcCalib == null)
			{
				formAbcCalib = new FormAbcCalib();
				AbcCalibUpdateForm();
				((Control)formAbcCalib.updateButton).Click += Action_AbcCalibUpdate;
				((Control)formAbcCalib.resetButton).Click += Action_AbcCalibUpdate;
				formAbcCalib.refCalSlotUpDown.ValueChanged += Action_AbcCalibRefChanged;
				formAbcCalib.refLowSlotUpDown.ValueChanged += Action_AbcCalibRefChanged;
				formAbcCalib.refHighSlotUpDown.ValueChanged += Action_AbcCalibRefChanged;
			}
			Action_AbcCalibRefChanged(this, null);
			mainForm.meas.mC.plotCheckBox.Checked = true;
			UpdatePlotSettings();
			((Control)formAbcCalib).Show();
		}
		else
		{
			dialog.ShowInfo(string.Concat(string.Concat("Can only make calibration when:\n" + "- A & B are both not empty\n", "- A & B have the same samplerate\n"), "- A & B have the same signal length\n"));
		}
	}

	private unsafe void Action_AbcCalibUpdate(object sender, EventArgs e)
	{
		uint num = 0u;
		WaitingCtrl.Wait("MainCtrl::Action_AbcCalibUpdate", "Updating calibration");
		if (sender == formAbcCalib.resetButton)
		{
			Options.Field.MakeMicCal = new MakeMicCalOptions();
			AbcCalibUpdateForm();
		}
		decimal value = formAbcCalib.winHighUpDown.Value;
		Options.Field.MakeMicCal.winHighcm = decimal.ToDouble(value);
		decimal value2 = formAbcCalib.winMidUpDown.Value;
		Options.Field.MakeMicCal.winMidcm = decimal.ToDouble(value2);
		decimal value3 = formAbcCalib.winLowUpDown.Value;
		Options.Field.MakeMicCal.winLowcm = decimal.ToDouble(value3);
		decimal value4 = formAbcCalib.stitchHighCenterUpDown.Value;
		Options.Field.MakeMicCal.stitchHighCenter = decimal.ToDouble(value4);
		decimal value5 = formAbcCalib.stitchHighWidthUpDown.Value;
		Options.Field.MakeMicCal.stitchHighWidth = decimal.ToDouble(value5);
		decimal value6 = formAbcCalib.stitchLowCenterUpDown.Value;
		Options.Field.MakeMicCal.stitchLowCenter = decimal.ToDouble(value6);
		decimal value7 = formAbcCalib.stitchLowWidthUpDown.Value;
		MakeMicCalOptions makeMicCal = Options.Field.MakeMicCal;
		makeMicCal.stitchLowWidth = decimal.ToDouble(value7);
		ListMeasurementContainer listMeasurementContainer = container;
		BasicMeasurementPresenter[] presenter = listMeasurementContainer.presenter;
		Measurement* measPtr = presenter[0].measPtr;
		Measurement* measPtr2 = presenter[1].measPtr;
		Measurement* measPtr3 = presenter[2].measPtr;
		int refHighSlot = makeMicCal.refHighSlot;
		Measurement* ptr = global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementList_002ENo(listMeasurementContainer.list, refHighSlot);
		Measurement* ptr2 = container.op_Subscript(Options.Field.MakeMicCal.refLowSlot);
		Measurement* ptr3 = container.op_Subscript(Options.Field.MakeMicCal.refCalSlot);
		global::_003CModule_003E.HOLM_002EMeasure_002EMeasurement_002EInitializeDirac(measPtr3, *(int*)((byte*)measPtr + 60), *(int*)((byte*)measPtr + 64), 1.0);
		global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementCore_002ESetImpulseWindowEnabled((MeasurementCore*)measPtr3, false);
		global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementCore_002ESetSmoothingEnabled((MeasurementCore*)measPtr3, true);
		global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementCore_002ESetSmoothNOct((MeasurementCore*)measPtr3, 6.0);
		global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementCore_002ESetImpulseWindowEnabled((MeasurementCore*)measPtr, true);
		global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementCore_002ESetSmoothingEnabled((MeasurementCore*)measPtr, false);
		global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementCore_002ESetImpulseWindowEnabled((MeasurementCore*)measPtr2, true);
		global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementCore_002ESetSmoothingEnabled((MeasurementCore*)measPtr2, false);
		global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementCore_002ESetImpulseWindowEnabled((MeasurementCore*)ptr, true);
		global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementCore_002ESetSmoothingEnabled((MeasurementCore*)ptr, false);
		global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementCore_002ESetImpulseWindowEnabled((MeasurementCore*)ptr2, true);
		global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementCore_002ESetSmoothingEnabled((MeasurementCore*)ptr2, false);
		Measurement* ptr4 = (Measurement*)global::_003CModule_003E.@new(424u);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj);
		Measurement* ptr5;
		try
		{
			if (ptr4 != null)
			{
				global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D(&obj, (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref global::_003CModule_003E._003F_003F_C_0040_02JDNIPIGD_0040NA_003F_0024AA_0040));
				try
				{
					num = 1u;
					ptr5 = global::_003CModule_003E.HOLM_002EMeasure_002EMeasurement_002E_007Bctor_007D(ptr4, &obj);
				}
				catch
				{
					//try-fault
					if ((num & (true ? 1u : 0u)) != 0)
					{
						num &= 0xFFFFFFFEu;
						global::_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), &obj);
					}
					throw;
				}
			}
			else
			{
				ptr5 = null;
			}
		}
		catch
		{
			//try-fault
			global::_003CModule_003E.delete(ptr4);
			throw;
		}
		if ((num & (true ? 1u : 0u)) != 0)
		{
			num &= 0xFFFFFFFEu;
			global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D(&obj);
		}
		Measurement* ptr6 = (Measurement*)global::_003CModule_003E.@new(424u);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj2);
		Measurement* ptr7;
		try
		{
			if (ptr6 != null)
			{
				global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D(&obj2, (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref global::_003CModule_003E._003F_003F_C_0040_02JDNIPIGD_0040NA_003F_0024AA_0040));
				try
				{
					num |= 2u;
					ptr7 = global::_003CModule_003E.HOLM_002EMeasure_002EMeasurement_002E_007Bctor_007D(ptr6, &obj2);
				}
				catch
				{
					//try-fault
					if ((num & 2u) != 0)
					{
						num &= 0xFFFFFFFDu;
						global::_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), &obj2);
					}
					throw;
				}
			}
			else
			{
				ptr7 = null;
			}
		}
		catch
		{
			//try-fault
			global::_003CModule_003E.delete(ptr6);
			throw;
		}
		if ((num & 2u) != 0)
		{
			num &= 0xFFFFFFFDu;
			global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D(&obj2);
		}
		Measurement* ptr8 = (Measurement*)global::_003CModule_003E.@new(424u);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj3);
		Measurement* ptr9;
		try
		{
			if (ptr8 != null)
			{
				global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D(&obj3, (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref global::_003CModule_003E._003F_003F_C_0040_02JDNIPIGD_0040NA_003F_0024AA_0040));
				try
				{
					num |= 4u;
					ptr9 = global::_003CModule_003E.HOLM_002EMeasure_002EMeasurement_002E_007Bctor_007D(ptr8, &obj3);
				}
				catch
				{
					//try-fault
					if ((num & 4u) != 0)
					{
						num &= 0xFFFFFFFBu;
						global::_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), &obj3);
					}
					throw;
				}
			}
			else
			{
				ptr9 = null;
			}
		}
		catch
		{
			//try-fault
			global::_003CModule_003E.delete(ptr8);
			throw;
		}
		if ((num & 4u) != 0)
		{
			num &= 0xFFFFFFFBu;
			global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D(&obj3);
		}
		Measurement* ptr10 = (Measurement*)global::_003CModule_003E.@new(424u);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj4);
		Measurement* ptr11;
		try
		{
			if (ptr10 != null)
			{
				global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D(&obj4, (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref global::_003CModule_003E._003F_003F_C_0040_02JDNIPIGD_0040NA_003F_0024AA_0040));
				try
				{
					num |= 8u;
					ptr11 = global::_003CModule_003E.HOLM_002EMeasure_002EMeasurement_002E_007Bctor_007D(ptr10, &obj4);
				}
				catch
				{
					//try-fault
					if ((num & 8u) != 0)
					{
						num &= 0xFFFFFFF7u;
						global::_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), &obj4);
					}
					throw;
				}
			}
			else
			{
				ptr11 = null;
			}
		}
		catch
		{
			//try-fault
			global::_003CModule_003E.delete(ptr10);
			throw;
		}
		if ((num & 8u) != 0)
		{
			num &= 0xFFFFFFF7u;
			global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D(&obj4);
		}
		Measurement* ptr12 = (Measurement*)global::_003CModule_003E.@new(424u);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj5);
		Measurement* ptr13;
		try
		{
			if (ptr12 != null)
			{
				global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D(&obj5, (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref global::_003CModule_003E._003F_003F_C_0040_02JDNIPIGD_0040NA_003F_0024AA_0040));
				try
				{
					num |= 0x10u;
					ptr13 = global::_003CModule_003E.HOLM_002EMeasure_002EMeasurement_002E_007Bctor_007D(ptr12, &obj5);
				}
				catch
				{
					//try-fault
					if ((num & 0x10u) != 0)
					{
						num &= 0xFFFFFFEFu;
						global::_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), &obj5);
					}
					throw;
				}
			}
			else
			{
				ptr13 = null;
			}
		}
		catch
		{
			//try-fault
			global::_003CModule_003E.delete(ptr12);
			throw;
		}
		if ((num & 0x10u) != 0)
		{
			num &= 0xFFFFFFEFu;
			global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D(&obj5);
		}
		int num2 = global::_003CModule_003E.HOLM_002EMath_002EToIntRound(Options.Field.MakeMicCal.winLowcm * ((double)(*(int*)((byte*)measPtr + 64)) * global::_003CModule_003E.HOLM_002EMeasure_002E_003FA0x316290b9_002ECM_TO_SEC));
		global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementCore_002ESetImpulseWindowEnd((MeasurementCore*)measPtr, num2);
		global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementCore_002ESetImpulseWindowEnd((MeasurementCore*)ptr2, num2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj6);
		basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* ptr14 = &obj6;
		basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* ptr15 = global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D(&obj6, (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref global::_003CModule_003E._003F_003F_C_0040_01KMDKNFGN_0040_003F1_003F_0024AA_0040));
		global::_003CModule_003E.HOLM_002EMeasure_002EOperation(ptr15, measPtr, ptr2, ptr5);
		int num3 = global::_003CModule_003E.HOLM_002EMath_002EToIntRound(Options.Field.MakeMicCal.winMidcm * ((double)(*(int*)((byte*)measPtr + 64)) * global::_003CModule_003E.HOLM_002EMeasure_002E_003FA0x316290b9_002ECM_TO_SEC));
		global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementCore_002ESetImpulseWindowEnd((MeasurementCore*)measPtr, num3);
		global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementCore_002ESetImpulseWindowEnd((MeasurementCore*)ptr2, num3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj7);
		basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* ptr16 = &obj7;
		basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* ptr17 = global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D(&obj7, (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref global::_003CModule_003E._003F_003F_C_0040_01KMDKNFGN_0040_003F1_003F_0024AA_0040));
		global::_003CModule_003E.HOLM_002EMeasure_002EOperation(ptr17, measPtr, ptr2, ptr7);
		int num4 = global::_003CModule_003E.HOLM_002EMath_002EToIntRound(Options.Field.MakeMicCal.winHighcm * ((double)(*(int*)((byte*)measPtr + 64)) * global::_003CModule_003E.HOLM_002EMeasure_002E_003FA0x316290b9_002ECM_TO_SEC));
		global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementCore_002ESetImpulseWindowEnd((MeasurementCore*)measPtr2, num4);
		global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementCore_002ESetImpulseWindowEnd((MeasurementCore*)ptr, num4);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj8);
		basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* ptr18 = &obj8;
		basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* ptr19 = global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D(&obj8, (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref global::_003CModule_003E._003F_003F_C_0040_01KMDKNFGN_0040_003F1_003F_0024AA_0040));
		global::_003CModule_003E.HOLM_002EMeasure_002EOperation(ptr19, measPtr2, ptr, ptr9);
		MakeMicCalOptions makeMicCal2 = Options.Field.MakeMicCal;
		global::_003CModule_003E.HOLM_002EMeasure_002EStitch(ptr5, ptr7, ptr11, makeMicCal2.stitchLowCenter, makeMicCal2.stitchLowWidth, true);
		MakeMicCalOptions makeMicCal3 = Options.Field.MakeMicCal;
		global::_003CModule_003E.HOLM_002EMeasure_002EStitch(ptr11, ptr9, ptr13, makeMicCal3.stitchHighCenter, makeMicCal3.stitchHighWidth, true);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj9);
		basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* ptr20 = &obj9;
		basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* ptr21 = global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D(&obj9, (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref global::_003CModule_003E._003F_003F_C_0040_01NBENCBCI_0040_003F_0024CK_003F_0024AA_0040));
		global::_003CModule_003E.HOLM_002EMeasure_002EOperation(ptr21, ptr3, ptr13, measPtr3);
		global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementCore_002ESetImpulseWindowEnabled((MeasurementCore*)measPtr3, false);
		global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementCore_002ESetSmoothingEnabled((MeasurementCore*)measPtr3, true);
		global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementCore_002ESetSmoothNOct((MeasurementCore*)measPtr3, 6.0);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj10);
		basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* ptr22 = global::_003CModule_003E.std_002Eoperator_002B_003Cchar_002Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_002Cclass_0020std_003A_003Aallocator_003Cchar_003E_0020_003E(&obj10, (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref global::_003CModule_003E._003F_003F_C_0040_0O_0040EDGJGDIK_0040Calibration_003F5_003F_0024CI_003F_0024AA_0040), (basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)measPtr);
		try
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj11);
			basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* ptr23 = global::_003CModule_003E.std_002Eoperator_002B_003Cchar_002Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_002Cclass_0020std_003A_003Aallocator_003Cchar_003E_0020_003E(&obj11, ptr22, (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref global::_003CModule_003E._003F_003F_C_0040_02KEGNLNML_0040_003F0_003F5_003F_0024AA_0040));
			try
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj12);
				basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* ptr24 = global::_003CModule_003E.std_002Eoperator_002B_003Cchar_002Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_002Cclass_0020std_003A_003Aallocator_003Cchar_003E_0020_003E(&obj12, ptr23, (basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)measPtr2);
				try
				{
					System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj13);
					basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* ptr25 = global::_003CModule_003E.std_002Eoperator_002B_003Cchar_002Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_002Cclass_0020std_003A_003Aallocator_003Cchar_003E_0020_003E(&obj13, ptr24, (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref global::_003CModule_003E._003F_003F_C_0040_01PKGAHCOL_0040_003F_0024CJ_003F_0024AA_0040));
					try
					{
						global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_003D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)measPtr3, ptr25);
					}
					catch
					{
						//try-fault
						global::_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), &obj13);
						throw;
					}
					global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D(&obj13);
				}
				catch
				{
					//try-fault
					global::_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), &obj12);
					throw;
				}
				global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D(&obj12);
			}
			catch
			{
				//try-fault
				global::_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), &obj11);
				throw;
			}
			global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D(&obj11);
		}
		catch
		{
			//try-fault
			global::_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), &obj10);
			throw;
		}
		global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D(&obj10);
		container.formpresenter[2].UpdateInfo();
		impulseGraph.UpdatePlotArea();
		freqGraph.UpdatePlotArea();
		Measurement* ptr26 = ptr5;
		if (ptr5 != null)
		{
			global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementCore_002E_007Bdtor_007D((MeasurementCore*)ptr5);
			global::_003CModule_003E.delete(ptr5);
		}
		Measurement* ptr27 = ptr7;
		if (ptr7 != null)
		{
			global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementCore_002E_007Bdtor_007D((MeasurementCore*)ptr7);
			global::_003CModule_003E.delete(ptr7);
		}
		Measurement* ptr28 = ptr9;
		if (ptr9 != null)
		{
			global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementCore_002E_007Bdtor_007D((MeasurementCore*)ptr9);
			global::_003CModule_003E.delete(ptr9);
		}
		Measurement* ptr29 = ptr11;
		if (ptr11 != null)
		{
			global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementCore_002E_007Bdtor_007D((MeasurementCore*)ptr11);
			global::_003CModule_003E.delete(ptr11);
		}
		Measurement* ptr30 = ptr13;
		if (ptr13 != null)
		{
			global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementCore_002E_007Bdtor_007D((MeasurementCore*)ptr13);
			global::_003CModule_003E.delete(ptr13);
		}
		WaitingCtrl.DoNotWait("MainCtrl::Action_AbcCalibUpdate");
	}

	private unsafe void Action_AbcCalibRefChanged(object sender, EventArgs e)
	{
		decimal value = formAbcCalib.refCalSlotUpDown.Value;
		Options.Field.MakeMicCal.refCalSlot = decimal.ToInt32(value);
		decimal value2 = formAbcCalib.refLowSlotUpDown.Value;
		Options.Field.MakeMicCal.refLowSlot = decimal.ToInt32(value2);
		decimal value3 = formAbcCalib.refHighSlotUpDown.Value;
		Options.Field.MakeMicCal.refHighSlot = decimal.ToInt32(value3);
		int refCalSlot = Options.Field.MakeMicCal.refCalSlot;
		string text = new string(global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002Ec_str((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementList_002ENo(container.list, refCalSlot)));
		formAbcCalib.refCalNoteTextBox.Text = text;
		int refLowSlot = Options.Field.MakeMicCal.refLowSlot;
		string text2 = new string(global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002Ec_str((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementList_002ENo(container.list, refLowSlot)));
		formAbcCalib.refLowNoteTextBox.Text = text2;
		int refHighSlot = Options.Field.MakeMicCal.refHighSlot;
		string text3 = new string(global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002Ec_str((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementList_002ENo(container.list, refHighSlot)));
		formAbcCalib.refHighNoteTextBox.Text = text3;
	}

	private unsafe void Action_MainFormClosing(object sender, FormClosingEventArgs e)
	{
		WaitingCtrl.Wait("MainCtrl::Action_MainFormClosing", "Closing HOLMImpulse (Autosaving)");
		global::_003CModule_003E.HOLM_002EPAudioII_002EStreamInitializer_002EStop(global::_003CModule_003E.HOLM_002EPAudioII_002EStream());
		SaveToOptions();
		Options.AutoSave();
		System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E obj);
		basic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E* ptr = &obj;
		basic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E* fileName = global::_003CModule_003E.std_002Ebasic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E_002E_007Bctor_007D(&obj, (basic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref global::_003CModule_003E.HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x316290b9_002EAUTOSAVE_MEAS_FILENAME));
		System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E obj2);
		basic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E* filename = global::_003CModule_003E.HOLM_002EHOLMImpulse_002EConf_002EFilePath(&obj2, fileName);
		try
		{
			container.Save(filename);
		}
		catch
		{
			//try-fault
			global::_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E*, void>)(&global::_003CModule_003E.std_002Ebasic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E_002E_007Bdtor_007D), &obj2);
			throw;
		}
		global::_003CModule_003E.std_002Ebasic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E_002E_007Bdtor_007D(&obj2);
	}

	private void AbcCalibUpdateForm()
	{
		global::_003CModule_003E.HOLM_002EGuiHelper_002ESetNumericUpDownValue(formAbcCalib.refCalSlotUpDown, Options.Field.MakeMicCal.refCalSlot);
		global::_003CModule_003E.HOLM_002EGuiHelper_002ESetNumericUpDownValue(formAbcCalib.refLowSlotUpDown, Options.Field.MakeMicCal.refLowSlot);
		global::_003CModule_003E.HOLM_002EGuiHelper_002ESetNumericUpDownValue(formAbcCalib.refHighSlotUpDown, Options.Field.MakeMicCal.refHighSlot);
		global::_003CModule_003E.HOLM_002EGuiHelper_002ESetNumericUpDownValue(formAbcCalib.winHighUpDown, Options.Field.MakeMicCal.winHighcm);
		global::_003CModule_003E.HOLM_002EGuiHelper_002ESetNumericUpDownValue(formAbcCalib.winMidUpDown, Options.Field.MakeMicCal.winMidcm);
		global::_003CModule_003E.HOLM_002EGuiHelper_002ESetNumericUpDownValue(formAbcCalib.winLowUpDown, Options.Field.MakeMicCal.winLowcm);
		global::_003CModule_003E.HOLM_002EGuiHelper_002ESetNumericUpDownValue(formAbcCalib.stitchHighCenterUpDown, Options.Field.MakeMicCal.stitchHighCenter);
		global::_003CModule_003E.HOLM_002EGuiHelper_002ESetNumericUpDownValue(formAbcCalib.stitchHighWidthUpDown, Options.Field.MakeMicCal.stitchHighWidth);
		global::_003CModule_003E.HOLM_002EGuiHelper_002ESetNumericUpDownValue(formAbcCalib.stitchLowCenterUpDown, Options.Field.MakeMicCal.stitchLowCenter);
		global::_003CModule_003E.HOLM_002EGuiHelper_002ESetNumericUpDownValue(formAbcCalib.stitchLowWidthUpDown, Options.Field.MakeMicCal.stitchLowWidth);
	}

	private unsafe void ABCOperation(basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* op)
	{
		try
		{
			BasicMeasurementPresenter[] presenter = container.presenter;
			Measurement* measPtr = presenter[0].measPtr;
			Measurement* measPtr2 = presenter[1].measPtr;
			Measurement* measPtr3 = presenter[2].measPtr;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj);
			basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* ptr = &obj;
			basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* ptr2 = global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D(&obj, op);
			if (global::_003CModule_003E.HOLM_002EMeasure_002EOperation(ptr2, measPtr, measPtr2, measPtr3))
			{
				mainForm.meas.mC.plotCheckBox.Checked = true;
				UpdatePlotSettings();
				string text = new string(global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002Ec_str((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)measPtr3));
				container.formpresenter[2].comboBox.Text = text;
				impulseGraph.UpdatePlotArea();
				freqGraph.UpdatePlotArea();
			}
		}
		catch
		{
			//try-fault
			global::_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), op);
			throw;
		}
		global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D(op);
	}

	private unsafe void ABOperation(basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* op)
	{
		try
		{
			BasicMeasurementPresenter[] presenter = container.presenter;
			Measurement* measPtr = presenter[0].measPtr;
			Measurement* measPtr2 = presenter[1].measPtr;
			if (((byte*)measPtr)[28] != 0)
			{
				complex_003Cdouble_003E* ptr = global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementCore_002EGetF0((MeasurementCore*)measPtr);
				global::_003CModule_003E.HOLM_002EMeasure_002EMeasurement_002EInitializeDirac(measPtr2, *(int*)((byte*)measPtr + 60), *(int*)((byte*)measPtr + 64), 1.0);
				complex_003Cdouble_003E* ptr2 = global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementCore_002EGetF0Writeable((MeasurementCore*)measPtr2);
				if (global::_003CModule_003E.std_002Eoperator_003D_003D_003Cchar_002Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_002Cclass_0020std_003A_003Aallocator_003Cchar_003E_0020_003E(op, (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref global::_003CModule_003E._003F_003F_C_0040_03EMFPMALO_00401_003F1A_003F_0024AA_0040)))
				{
					int num = 0;
					if (0 <= *(int*)((byte*)measPtr2 + 52))
					{
						complex_003Cdouble_003E* ptr3 = ptr2;
						int num2 = (int)((byte*)ptr - (nuint)ptr2);
						System.Runtime.CompilerServices.Unsafe.SkipInit(out complex_003Cdouble_003E complex_003Cdouble_003E);
						do
						{
							if (global::_003CModule_003E.std_002Eabs_003Cdouble_003E((complex_003Cdouble_003E*)((byte*)ptr3 + num2)) > 1E-10)
							{
								complex_003Cdouble_003E* ptr4 = global::_003CModule_003E.HOLM_002EMath_002EInverse_003Cdouble_003E(&complex_003Cdouble_003E, (complex_003Cdouble_003E*)((byte*)ptr3 + num2));
								// IL cpblk instruction
								System.Runtime.CompilerServices.Unsafe.CopyBlock(ptr3, ptr4, 16);
							}
							else
							{
								double num3 = 10000000000.0;
								global::_003CModule_003E.std_002Ecomplex_003Cdouble_003E_002E_003D(ptr3, &num3);
							}
							num++;
							ptr3 = (complex_003Cdouble_003E*)((byte*)ptr3 + 16);
						}
						while (num <= *(int*)((byte*)measPtr2 + 52));
					}
					container.formpresenter[1].SetText(string.Concat("1/(" + container.formpresenter[0].comboBox.Text, ")"));
				}
				global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementCore_002EF0Written((MeasurementCore*)measPtr2);
				global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementCore_002ECopyImpulseWindowFrom((MeasurementCore*)measPtr2, (MeasurementCore*)measPtr);
				global::_003CModule_003E.HOLM_002EMeasure_002EMeasurementCore_002ECopyFilterFrom((MeasurementCore*)measPtr2, (MeasurementCore*)measPtr);
				mainForm.meas.mB.plotCheckBox.Checked = true;
				UpdatePlotSettings();
				impulseGraph.UpdatePlotArea();
				freqGraph.UpdatePlotArea();
			}
		}
		catch
		{
			//try-fault
			global::_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), op);
			throw;
		}
		global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D(op);
	}

	private void ResetSlotNumbers()
	{
		Options.Field.Misc.ASlotNr = 0;
		Options.Field.Misc.BSlotNr = 1;
		Options.Field.Misc.CSlotNr = 2;
		container.formpresenter[0].SetSlotNumber(Options.Field.Misc.ASlotNr);
		container.formpresenter[1].SetSlotNumber(Options.Field.Misc.BSlotNr);
		container.formpresenter[2].SetSlotNumber(Options.Field.Misc.CSlotNr);
	}

	private void LoadConfSlotNumbers()
	{
		container.formpresenter[0].SetSlotNumber(Options.Field.Misc.ASlotNr);
		container.formpresenter[1].SetSlotNumber(Options.Field.Misc.BSlotNr);
		container.formpresenter[2].SetSlotNumber(Options.Field.Misc.CSlotNr);
	}

	protected virtual void Dispose([MarshalAs(UnmanagedType.U1)] bool P_0)
	{
		if (P_0)
		{
			_007EMainCtrl();
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
