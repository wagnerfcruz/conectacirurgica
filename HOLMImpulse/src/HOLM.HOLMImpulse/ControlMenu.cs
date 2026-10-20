using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace HOLM.HOLMImpulse;

public class ControlMenu : UserControl
{
	public MenuStrip mainMenuStrip;

	public ToolStripMenuItem fileToolStripMenuItem;

	private ToolStripMenuItem toolStripMenuItem2;

	public ToolStripMenuItem saveMeasurementsWav;

	public ToolStripMenuItem openMenuItem;

	public ToolStripMenuItem openAppendMenuItem;

	public ToolStripMenuItem clearMenuItem;

	public ToolStripMenuItem rearangeMenuItem;

	private ToolStripSeparator toolStripSeparator1;

	private ToolStripMenuItem toolStripMenuItem8;

	public ToolStripMenuItem freqSaveBitmapMenuItem;

	public ToolStripMenuItem impulseSaveBitmapMenuItem;

	private ToolStripSeparator toolStripSeparator2;

	public ToolStripMenuItem exitMenuItem;

	public ToolStripMenuItem optionsMenu;

	private ToolStripMenuItem toolStripMenuItem9;

	public ToolStripMenuItem colorFgMenuItem;

	public ToolStripMenuItem colorBgMenuItem;

	public ToolStripMenuItem toolStripMenuItem10;

	public ToolStripComboBox lineWidthComboBox;

	private ToolStripSeparator toolStripSeparator8;

	private ToolStripMenuItem toolStripMenuItem3;

	private ToolStripSeparator toolStripSeparator3;

	private ToolStripMenuItem toolStripMenuItem4;

	public ToolStripMenuItem decibelAmpMenuItem;

	public ToolStripMenuItem linAmpMenuItem;

	private ToolStripSeparator toolStripSeparator4;

	private ToolStripMenuItem toolStripMenuItem6;

	public ToolStripMenuItem impulseAsSamplesMenuItem;

	public ToolStripMenuItem impulseAsTimeMenuItem;

	public ToolStripMenuItem impulseAsDistanceMenuItem;

	private ToolStripSeparator toolStripSeparator5;

	private ToolStripMenuItem toolStripMenuItem5;

	public ToolStripMenuItem hidePhaseWhenAmpMenuItem;

	public ToolStripTextBox plotPhaseHideDB;

	private ToolStripSeparator toolStripSeparator6;

	private ToolStripMenuItem toolStripMenuItem7;

	public ToolStripMenuItem resetSettingsMenuItem;

	public ToolStripMenuItem saveSettingsMenuItem;

	public ToolStripMenuItem loadSettingsMenuItem;

	public ToolStripMenuItem manipulateMenu;

	private ToolStripMenuItem toolStripMenuItem1;

	public ToolStripMenuItem manipulateMeasDiffMenuItem;

	public ToolStripMenuItem manipulateMeasSumMenuItem;

	public ToolStripMenuItem manipulateMeasProductMenuItem;

	public ToolStripMenuItem manipulateMeasDivMenuItem;

	private ToolStripSeparator toolStripSeparator11;

	public ToolStripMenuItem manipulateCopyAToBMenuItem;

	private ToolStripSeparator toolStripSeparator12;

	public ToolStripMenuItem manipulateWindowAToBMenuItem;

	public ToolStripMenuItem manipulateWindowAToBAndCMenuItem;

	public ToolStripMenuItem helpTopMenuItem;

	public ToolStripMenuItem aboutMenuItem;

	public ToolStripMenuItem showToolTipsMenuItem;

	public ToolStripMenuItem helpMenuItem;

	public ToolStripMenuItem plotAmpDBMinMenu;

	public ToolStripTextBox plotAmpDBMin;

	public ToolStripMenuItem plotAmpDBMaxMenu;

	public ToolStripTextBox plotAmpDBMax;

	public ToolStripMenuItem plotAmpTicsMenu;

	public ToolStripTextBox plotAmpTics;

	public ToolStripMenuItem browseApplicationData;

	private ToolStripSeparator toolStripSeparator7;

	private ToolStripMenuItem toolStripMenuItem11;

	public ToolStripMenuItem manipulateAbcStitch;

	public ToolStripMenuItem checkforUpdateAtStart;

	private ToolStripSeparator toolStripSeparator9;

	public ToolStripMenuItem checkforUpdate;

	private ToolStripSeparator toolStripSeparator10;

	public ToolStripMenuItem manipulateMeasInvert;

	public ToolStripMenuItem manipulateMatchAB;

	public ToolStripMenuItem manipulateAbcMicCal;

	public ToolStripMenuItem organizeMeasurements;

	private ToolStripSeparator toolStripSeparator13;

	public ToolStripMenuItem toolStripMenuItem12;

	public ToolStripTextBox plotHDHideDB;

	public ToolStripTextBox plotHdHideDB;

	public ToolStripMenuItem bitmapLegends;

	private ToolStripSeparator toolStripSeparator14;

	private ToolStripMenuItem toolStripMenuItem13;

	public ToolStripMenuItem qboxSlotC;

	public ToolStripMenuItem optionsImpulseShowHD;

	public ToolStripMenuItem logFreqMenuItem;

	public ToolStripMenuItem linFreqMenuItem;

	public ToolStripMenuItem frequencyMinMenu;

	public ToolStripTextBox plotFreqMin;

	public ToolStripMenuItem frequencyMaxMenu;

	public ToolStripTextBox plotFreqMax;

	public ToolStripMenuItem plotFreqTicsMenu;

	public ToolStripTextBox plotFreqTics;

	public ToolStripMenuItem optionFreqShowGating;

	private ToolStripSeparator toolStripSeparator15;

	public ToolStripMenuItem freqImpSaveBitmapMenuItem;

	public ToolStripMenuItem settingsMenu;

	public ToolStripComboBox waveFormatComboBox;

	private ToolStripMenuItem waveFileFormatToolStripMenuItem;

	private ToolStripSeparator toolStripSeparator16;

	public ToolStripMenuItem impulseInterpolate;

	private ToolStripSeparator toolStripSeparator17;

	public ToolStripMenuItem imageResizeGraph;

	public ToolStripMenuItem exportAllMeasurements;

	private ToolStripSeparator toolStripSeparator18;

	public ToolStripMenuItem saveMeasurementsFlac;

	private ToolStripSeparator toolStripSeparator19;

	public ToolStripMenuItem freqImpToClipBoard;

	public ToolStripMenuItem freqToClipBoard;

	public ToolStripMenuItem impToClipBoard;

	public ToolStripMenuItem toolsMenu;

	public ToolStripMenuItem recordMeter;

	private ToolStripSeparator toolStripSeparator20;

	public ToolStripMenuItem helpUserGuide;

	public ToolStripMenuItem manipulateCopyAToCMenuItem;

	private Container components;

	public ControlMenu()
	{
		try
		{
			InitializeComponent();
			waveFormatComboBox.SelectedIndex = 0;
			return;
		}
		catch
		{
			//try-fault
			((ContainerControl)this).Dispose(true);
			throw;
		}
	}

	private void _007EControlMenu()
	{
		((IDisposable)components)?.Dispose();
	}

	private void InitializeComponent()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected O, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected O, but got Unknown
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected O, but got Unknown
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected O, but got Unknown
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected O, but got Unknown
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected O, but got Unknown
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected O, but got Unknown
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Expected O, but got Unknown
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected O, but got Unknown
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Expected O, but got Unknown
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Expected O, but got Unknown
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Expected O, but got Unknown
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Expected O, but got Unknown
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Expected O, but got Unknown
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Expected O, but got Unknown
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Expected O, but got Unknown
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Expected O, but got Unknown
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Expected O, but got Unknown
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Expected O, but got Unknown
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Expected O, but got Unknown
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Expected O, but got Unknown
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Expected O, but got Unknown
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Expected O, but got Unknown
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Expected O, but got Unknown
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Expected O, but got Unknown
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Expected O, but got Unknown
		//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Expected O, but got Unknown
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Expected O, but got Unknown
		//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0205: Expected O, but got Unknown
		//IL_0206: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Expected O, but got Unknown
		//IL_0211: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Expected O, but got Unknown
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0226: Expected O, but got Unknown
		//IL_0227: Unknown result type (might be due to invalid IL or missing references)
		//IL_0231: Expected O, but got Unknown
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		//IL_023c: Expected O, but got Unknown
		//IL_023d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Expected O, but got Unknown
		//IL_0248: Unknown result type (might be due to invalid IL or missing references)
		//IL_0252: Expected O, but got Unknown
		//IL_0253: Unknown result type (might be due to invalid IL or missing references)
		//IL_025d: Expected O, but got Unknown
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0268: Expected O, but got Unknown
		//IL_0269: Unknown result type (might be due to invalid IL or missing references)
		//IL_0273: Expected O, but got Unknown
		//IL_0274: Unknown result type (might be due to invalid IL or missing references)
		//IL_027e: Expected O, but got Unknown
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0289: Expected O, but got Unknown
		//IL_028a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0294: Expected O, but got Unknown
		//IL_0295: Unknown result type (might be due to invalid IL or missing references)
		//IL_029f: Expected O, but got Unknown
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02aa: Expected O, but got Unknown
		//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b5: Expected O, but got Unknown
		//IL_02b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c0: Expected O, but got Unknown
		//IL_02c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cb: Expected O, but got Unknown
		//IL_02cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d6: Expected O, but got Unknown
		//IL_02d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e1: Expected O, but got Unknown
		//IL_02e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ec: Expected O, but got Unknown
		//IL_02ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f7: Expected O, but got Unknown
		//IL_02f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0302: Expected O, but got Unknown
		//IL_0303: Unknown result type (might be due to invalid IL or missing references)
		//IL_030d: Expected O, but got Unknown
		//IL_030e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0318: Expected O, but got Unknown
		//IL_0319: Unknown result type (might be due to invalid IL or missing references)
		//IL_0323: Expected O, but got Unknown
		//IL_0324: Unknown result type (might be due to invalid IL or missing references)
		//IL_032e: Expected O, but got Unknown
		//IL_032f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0339: Expected O, but got Unknown
		//IL_033a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0344: Expected O, but got Unknown
		//IL_0345: Unknown result type (might be due to invalid IL or missing references)
		//IL_034f: Expected O, but got Unknown
		//IL_0350: Unknown result type (might be due to invalid IL or missing references)
		//IL_035a: Expected O, but got Unknown
		//IL_035b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0365: Expected O, but got Unknown
		//IL_0366: Unknown result type (might be due to invalid IL or missing references)
		//IL_0370: Expected O, but got Unknown
		//IL_0371: Unknown result type (might be due to invalid IL or missing references)
		//IL_037b: Expected O, but got Unknown
		//IL_037c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0386: Expected O, but got Unknown
		//IL_0387: Unknown result type (might be due to invalid IL or missing references)
		//IL_0391: Expected O, but got Unknown
		//IL_0392: Unknown result type (might be due to invalid IL or missing references)
		//IL_039c: Expected O, but got Unknown
		//IL_039d: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a7: Expected O, but got Unknown
		//IL_03a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b2: Expected O, but got Unknown
		//IL_03b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bd: Expected O, but got Unknown
		//IL_03be: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c8: Expected O, but got Unknown
		//IL_03c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d3: Expected O, but got Unknown
		//IL_03d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03de: Expected O, but got Unknown
		//IL_03df: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e9: Expected O, but got Unknown
		//IL_03ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f4: Expected O, but got Unknown
		//IL_03f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ff: Expected O, but got Unknown
		//IL_0400: Unknown result type (might be due to invalid IL or missing references)
		//IL_040a: Expected O, but got Unknown
		//IL_040b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0415: Expected O, but got Unknown
		//IL_0416: Unknown result type (might be due to invalid IL or missing references)
		//IL_0420: Expected O, but got Unknown
		//IL_0421: Unknown result type (might be due to invalid IL or missing references)
		//IL_042b: Expected O, but got Unknown
		//IL_042c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0436: Expected O, but got Unknown
		//IL_0437: Unknown result type (might be due to invalid IL or missing references)
		//IL_0441: Expected O, but got Unknown
		//IL_0442: Unknown result type (might be due to invalid IL or missing references)
		//IL_044c: Expected O, but got Unknown
		//IL_044d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0457: Expected O, but got Unknown
		//IL_0458: Unknown result type (might be due to invalid IL or missing references)
		//IL_0462: Expected O, but got Unknown
		//IL_0463: Unknown result type (might be due to invalid IL or missing references)
		//IL_046d: Expected O, but got Unknown
		//IL_046e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0478: Expected O, but got Unknown
		//IL_0479: Unknown result type (might be due to invalid IL or missing references)
		//IL_0483: Expected O, but got Unknown
		//IL_0484: Unknown result type (might be due to invalid IL or missing references)
		//IL_048e: Expected O, but got Unknown
		//IL_048f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0499: Expected O, but got Unknown
		//IL_049a: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a4: Expected O, but got Unknown
		//IL_04a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04af: Expected O, but got Unknown
		//IL_04b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ba: Expected O, but got Unknown
		//IL_04bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c5: Expected O, but got Unknown
		//IL_06fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0706: Expected O, but got Unknown
		//IL_09cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d6: Expected O, but got Unknown
		//IL_0f06: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f10: Expected O, but got Unknown
		//IL_10da: Unknown result type (might be due to invalid IL or missing references)
		//IL_10e4: Expected O, but got Unknown
		//IL_1460: Unknown result type (might be due to invalid IL or missing references)
		//IL_146a: Expected O, but got Unknown
		//IL_181e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1828: Expected O, but got Unknown
		//IL_1a79: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a83: Expected O, but got Unknown
		//IL_1b90: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b9a: Expected O, but got Unknown
		//IL_1d9d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1da7: Expected O, but got Unknown
		//IL_1ff5: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fff: Expected O, but got Unknown
		//IL_218b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2195: Expected O, but got Unknown
		//IL_2282: Unknown result type (might be due to invalid IL or missing references)
		//IL_228c: Expected O, but got Unknown
		//IL_26b9: Unknown result type (might be due to invalid IL or missing references)
		mainMenuStrip = new MenuStrip();
		fileToolStripMenuItem = new ToolStripMenuItem();
		toolStripMenuItem2 = new ToolStripMenuItem();
		toolStripSeparator18 = new ToolStripSeparator();
		saveMeasurementsFlac = new ToolStripMenuItem();
		saveMeasurementsWav = new ToolStripMenuItem();
		openMenuItem = new ToolStripMenuItem();
		openAppendMenuItem = new ToolStripMenuItem();
		clearMenuItem = new ToolStripMenuItem();
		exportAllMeasurements = new ToolStripMenuItem();
		toolStripSeparator13 = new ToolStripSeparator();
		organizeMeasurements = new ToolStripMenuItem();
		rearangeMenuItem = new ToolStripMenuItem();
		toolStripSeparator1 = new ToolStripSeparator();
		toolStripMenuItem8 = new ToolStripMenuItem();
		freqImpSaveBitmapMenuItem = new ToolStripMenuItem();
		freqSaveBitmapMenuItem = new ToolStripMenuItem();
		impulseSaveBitmapMenuItem = new ToolStripMenuItem();
		toolStripSeparator19 = new ToolStripSeparator();
		freqImpToClipBoard = new ToolStripMenuItem();
		freqToClipBoard = new ToolStripMenuItem();
		impToClipBoard = new ToolStripMenuItem();
		toolStripSeparator17 = new ToolStripSeparator();
		imageResizeGraph = new ToolStripMenuItem();
		bitmapLegends = new ToolStripMenuItem();
		toolStripSeparator2 = new ToolStripSeparator();
		browseApplicationData = new ToolStripMenuItem();
		toolStripSeparator7 = new ToolStripSeparator();
		exitMenuItem = new ToolStripMenuItem();
		optionsMenu = new ToolStripMenuItem();
		toolStripMenuItem9 = new ToolStripMenuItem();
		colorFgMenuItem = new ToolStripMenuItem();
		colorBgMenuItem = new ToolStripMenuItem();
		toolStripMenuItem10 = new ToolStripMenuItem();
		lineWidthComboBox = new ToolStripComboBox();
		toolStripSeparator8 = new ToolStripSeparator();
		toolStripMenuItem3 = new ToolStripMenuItem();
		logFreqMenuItem = new ToolStripMenuItem();
		linFreqMenuItem = new ToolStripMenuItem();
		frequencyMinMenu = new ToolStripMenuItem();
		plotFreqMin = new ToolStripTextBox();
		frequencyMaxMenu = new ToolStripMenuItem();
		plotFreqMax = new ToolStripTextBox();
		plotFreqTicsMenu = new ToolStripMenuItem();
		plotFreqTics = new ToolStripTextBox();
		optionFreqShowGating = new ToolStripMenuItem();
		toolStripSeparator3 = new ToolStripSeparator();
		toolStripMenuItem4 = new ToolStripMenuItem();
		decibelAmpMenuItem = new ToolStripMenuItem();
		linAmpMenuItem = new ToolStripMenuItem();
		plotAmpDBMinMenu = new ToolStripMenuItem();
		plotAmpDBMin = new ToolStripTextBox();
		plotAmpDBMaxMenu = new ToolStripMenuItem();
		plotAmpDBMax = new ToolStripTextBox();
		plotAmpTicsMenu = new ToolStripMenuItem();
		plotAmpTics = new ToolStripTextBox();
		toolStripMenuItem12 = new ToolStripMenuItem();
		plotHDHideDB = new ToolStripTextBox();
		toolStripSeparator4 = new ToolStripSeparator();
		toolStripMenuItem6 = new ToolStripMenuItem();
		impulseAsSamplesMenuItem = new ToolStripMenuItem();
		impulseAsTimeMenuItem = new ToolStripMenuItem();
		impulseAsDistanceMenuItem = new ToolStripMenuItem();
		toolStripSeparator15 = new ToolStripSeparator();
		optionsImpulseShowHD = new ToolStripMenuItem();
		toolStripSeparator16 = new ToolStripSeparator();
		impulseInterpolate = new ToolStripMenuItem();
		toolStripSeparator5 = new ToolStripSeparator();
		toolStripMenuItem5 = new ToolStripMenuItem();
		hidePhaseWhenAmpMenuItem = new ToolStripMenuItem();
		plotPhaseHideDB = new ToolStripTextBox();
		toolStripSeparator6 = new ToolStripSeparator();
		toolStripMenuItem7 = new ToolStripMenuItem();
		resetSettingsMenuItem = new ToolStripMenuItem();
		saveSettingsMenuItem = new ToolStripMenuItem();
		loadSettingsMenuItem = new ToolStripMenuItem();
		manipulateMenu = new ToolStripMenuItem();
		toolStripMenuItem1 = new ToolStripMenuItem();
		manipulateMeasDiffMenuItem = new ToolStripMenuItem();
		manipulateMeasSumMenuItem = new ToolStripMenuItem();
		manipulateMeasProductMenuItem = new ToolStripMenuItem();
		manipulateMeasDivMenuItem = new ToolStripMenuItem();
		manipulateMeasInvert = new ToolStripMenuItem();
		manipulateMatchAB = new ToolStripMenuItem();
		manipulateAbcStitch = new ToolStripMenuItem();
		manipulateAbcMicCal = new ToolStripMenuItem();
		toolStripSeparator11 = new ToolStripSeparator();
		toolStripMenuItem11 = new ToolStripMenuItem();
		manipulateCopyAToBMenuItem = new ToolStripMenuItem();
		manipulateCopyAToCMenuItem = new ToolStripMenuItem();
		toolStripSeparator12 = new ToolStripSeparator();
		manipulateWindowAToBMenuItem = new ToolStripMenuItem();
		manipulateWindowAToBAndCMenuItem = new ToolStripMenuItem();
		toolStripSeparator14 = new ToolStripSeparator();
		toolStripMenuItem13 = new ToolStripMenuItem();
		qboxSlotC = new ToolStripMenuItem();
		settingsMenu = new ToolStripMenuItem();
		waveFileFormatToolStripMenuItem = new ToolStripMenuItem();
		waveFormatComboBox = new ToolStripComboBox();
		toolsMenu = new ToolStripMenuItem();
		recordMeter = new ToolStripMenuItem();
		helpTopMenuItem = new ToolStripMenuItem();
		aboutMenuItem = new ToolStripMenuItem();
		showToolTipsMenuItem = new ToolStripMenuItem();
		toolStripSeparator20 = new ToolStripSeparator();
		helpUserGuide = new ToolStripMenuItem();
		toolStripSeparator10 = new ToolStripSeparator();
		checkforUpdate = new ToolStripMenuItem();
		checkforUpdateAtStart = new ToolStripMenuItem();
		toolStripSeparator9 = new ToolStripSeparator();
		helpMenuItem = new ToolStripMenuItem();
		((Control)mainMenuStrip).SuspendLayout();
		((Control)this).SuspendLayout();
		ToolStripItem[] array = (ToolStripItem[])(object)new ToolStripItem[6]
		{
			(ToolStripItem)fileToolStripMenuItem,
			(ToolStripItem)optionsMenu,
			(ToolStripItem)manipulateMenu,
			(ToolStripItem)settingsMenu,
			(ToolStripItem)toolsMenu,
			(ToolStripItem)helpTopMenuItem
		};
		((ToolStrip)mainMenuStrip).Items.AddRange(array);
		Point location = new Point(0, 0);
		((Control)mainMenuStrip).Location = location;
		((Control)mainMenuStrip).Name = "mainMenuStrip";
		Size size = new Size(800, 24);
		((Control)mainMenuStrip).Size = size;
		((Control)mainMenuStrip).TabIndex = 3;
		((Control)mainMenuStrip).Text = "menuStrip1";
		ToolStripItem[] array2 = (ToolStripItem[])(object)new ToolStripItem[27]
		{
			(ToolStripItem)toolStripMenuItem2,
			(ToolStripItem)toolStripSeparator18,
			(ToolStripItem)saveMeasurementsFlac,
			(ToolStripItem)saveMeasurementsWav,
			(ToolStripItem)openMenuItem,
			(ToolStripItem)openAppendMenuItem,
			(ToolStripItem)clearMenuItem,
			(ToolStripItem)exportAllMeasurements,
			(ToolStripItem)toolStripSeparator13,
			(ToolStripItem)organizeMeasurements,
			(ToolStripItem)rearangeMenuItem,
			(ToolStripItem)toolStripSeparator1,
			(ToolStripItem)toolStripMenuItem8,
			(ToolStripItem)freqImpSaveBitmapMenuItem,
			(ToolStripItem)freqSaveBitmapMenuItem,
			(ToolStripItem)impulseSaveBitmapMenuItem,
			(ToolStripItem)toolStripSeparator19,
			(ToolStripItem)freqImpToClipBoard,
			(ToolStripItem)freqToClipBoard,
			(ToolStripItem)impToClipBoard,
			(ToolStripItem)toolStripSeparator17,
			(ToolStripItem)imageResizeGraph,
			(ToolStripItem)bitmapLegends,
			(ToolStripItem)toolStripSeparator2,
			(ToolStripItem)browseApplicationData,
			(ToolStripItem)toolStripSeparator7,
			(ToolStripItem)exitMenuItem
		};
		((ToolStripDropDownItem)fileToolStripMenuItem).DropDownItems.AddRange(array2);
		((ToolStripItem)fileToolStripMenuItem).Name = "fileToolStripMenuItem";
		Size size2 = new Size(35, 20);
		((ToolStripItem)fileToolStripMenuItem).Size = size2;
		((ToolStripItem)fileToolStripMenuItem).Text = "&File";
		((ToolStripItem)toolStripMenuItem2).Font = new Font("Tahoma", 8.25f, (FontStyle)1);
		((ToolStripItem)toolStripMenuItem2).Name = "toolStripMenuItem2";
		Size size3 = new Size(302, 22);
		((ToolStripItem)toolStripMenuItem2).Size = size3;
		((ToolStripItem)toolStripMenuItem2).Text = "Measurements";
		((ToolStripItem)toolStripSeparator18).Name = "toolStripSeparator18";
		Size size4 = new Size(299, 6);
		((ToolStripItem)toolStripSeparator18).Size = size4;
		((ToolStripItem)saveMeasurementsFlac).Name = "saveMeasurementsFlac";
		saveMeasurementsFlac.ShortcutKeys = (Keys)131155;
		Size size5 = new Size(302, 22);
		((ToolStripItem)saveMeasurementsFlac).Size = size5;
		((ToolStripItem)saveMeasurementsFlac).Text = "&Save Measurements";
		((ToolStripItem)saveMeasurementsWav).Name = "saveMeasurementsWav";
		Size size6 = new Size(302, 22);
		((ToolStripItem)saveMeasurementsWav).Size = size6;
		((ToolStripItem)saveMeasurementsWav).Text = "&Save Measurements (wav-zip-archive)";
		((ToolStripItem)openMenuItem).Name = "openMenuItem";
		openMenuItem.ShortcutKeys = (Keys)131151;
		Size size7 = new Size(302, 22);
		((ToolStripItem)openMenuItem).Size = size7;
		((ToolStripItem)openMenuItem).Text = "&Open Measurements";
		((ToolStripItem)openAppendMenuItem).Name = "openAppendMenuItem";
		Size size8 = new Size(302, 22);
		((ToolStripItem)openAppendMenuItem).Size = size8;
		((ToolStripItem)openAppendMenuItem).Text = "Open (&Append) Measurements";
		((ToolStripItem)clearMenuItem).Name = "clearMenuItem";
		Size size9 = new Size(302, 22);
		((ToolStripItem)clearMenuItem).Size = size9;
		((ToolStripItem)clearMenuItem).Text = "Clear Measurements";
		((ToolStripItem)exportAllMeasurements).Name = "exportAllMeasurements";
		Size size10 = new Size(302, 22);
		((ToolStripItem)exportAllMeasurements).Size = size10;
		((ToolStripItem)exportAllMeasurements).Text = "Export all measurements (dialog)";
		((ToolStripItem)toolStripSeparator13).Name = "toolStripSeparator13";
		Size size11 = new Size(299, 6);
		((ToolStripItem)toolStripSeparator13).Size = size11;
		((ToolStripItem)organizeMeasurements).Name = "organizeMeasurements";
		Size size12 = new Size(302, 22);
		((ToolStripItem)organizeMeasurements).Size = size12;
		((ToolStripItem)organizeMeasurements).Text = "Organize Measurements";
		((ToolStripItem)rearangeMenuItem).Name = "rearangeMenuItem";
		Size size13 = new Size(302, 22);
		((ToolStripItem)rearangeMenuItem).Size = size13;
		((ToolStripItem)rearangeMenuItem).Text = "Sort Measurements (Empty last)";
		((ToolStripItem)toolStripSeparator1).Name = "toolStripSeparator1";
		Size size14 = new Size(299, 6);
		((ToolStripItem)toolStripSeparator1).Size = size14;
		((ToolStripItem)toolStripMenuItem8).Font = new Font("Tahoma", 8.25f, (FontStyle)1);
		((ToolStripItem)toolStripMenuItem8).Name = "toolStripMenuItem8";
		Size size15 = new Size(302, 22);
		((ToolStripItem)toolStripMenuItem8).Size = size15;
		((ToolStripItem)toolStripMenuItem8).Text = "Save bitmap images";
		((ToolStripItem)freqImpSaveBitmapMenuItem).Name = "freqImpSaveBitmapMenuItem";
		Size size16 = new Size(302, 22);
		((ToolStripItem)freqImpSaveBitmapMenuItem).Size = size16;
		((ToolStripItem)freqImpSaveBitmapMenuItem).Text = "Save Frequency- && Impulse-Response";
		((ToolStripItem)freqSaveBitmapMenuItem).Name = "freqSaveBitmapMenuItem";
		Size size17 = new Size(302, 22);
		((ToolStripItem)freqSaveBitmapMenuItem).Size = size17;
		((ToolStripItem)freqSaveBitmapMenuItem).Text = "Save Frequency-Response";
		((ToolStripItem)impulseSaveBitmapMenuItem).Name = "impulseSaveBitmapMenuItem";
		Size size18 = new Size(302, 22);
		((ToolStripItem)impulseSaveBitmapMenuItem).Size = size18;
		((ToolStripItem)impulseSaveBitmapMenuItem).Text = "Save Impulse-Response";
		((ToolStripItem)toolStripSeparator19).Name = "toolStripSeparator19";
		Size size19 = new Size(299, 6);
		((ToolStripItem)toolStripSeparator19).Size = size19;
		((ToolStripItem)freqImpToClipBoard).Name = "freqImpToClipBoard";
		Size size20 = new Size(302, 22);
		((ToolStripItem)freqImpToClipBoard).Size = size20;
		((ToolStripItem)freqImpToClipBoard).Text = "Frequency- && Impulse-Response to ClipBoard";
		((ToolStripItem)freqToClipBoard).Name = "freqToClipBoard";
		Size size21 = new Size(302, 22);
		((ToolStripItem)freqToClipBoard).Size = size21;
		((ToolStripItem)freqToClipBoard).Text = "Frequency-Response to ClipBoard";
		((ToolStripItem)impToClipBoard).Name = "impToClipBoard";
		Size size22 = new Size(302, 22);
		((ToolStripItem)impToClipBoard).Size = size22;
		((ToolStripItem)impToClipBoard).Text = "Impulse-Response to ClipBoard";
		((ToolStripItem)toolStripSeparator17).Name = "toolStripSeparator17";
		Size size23 = new Size(299, 6);
		((ToolStripItem)toolStripSeparator17).Size = size23;
		((ToolStripItem)imageResizeGraph).Name = "imageResizeGraph";
		Size size24 = new Size(302, 22);
		((ToolStripItem)imageResizeGraph).Size = size24;
		((ToolStripItem)imageResizeGraph).Text = "Resize graph area to 800x600";
		bitmapLegends.Checked = true;
		bitmapLegends.CheckOnClick = true;
		bitmapLegends.CheckState = (CheckState)1;
		((ToolStripItem)bitmapLegends).Name = "bitmapLegends";
		Size size25 = new Size(302, 22);
		((ToolStripItem)bitmapLegends).Size = size25;
		((ToolStripItem)bitmapLegends).Text = "Show Legends on images";
		((ToolStripItem)toolStripSeparator2).Name = "toolStripSeparator2";
		Size size26 = new Size(299, 6);
		((ToolStripItem)toolStripSeparator2).Size = size26;
		((ToolStripItem)browseApplicationData).Name = "browseApplicationData";
		Size size27 = new Size(302, 22);
		((ToolStripItem)browseApplicationData).Size = size27;
		((ToolStripItem)browseApplicationData).Text = "Browse Application Data";
		((ToolStripItem)toolStripSeparator7).Name = "toolStripSeparator7";
		Size size28 = new Size(299, 6);
		((ToolStripItem)toolStripSeparator7).Size = size28;
		((ToolStripItem)exitMenuItem).Name = "exitMenuItem";
		exitMenuItem.ShortcutKeys = (Keys)131153;
		Size size29 = new Size(302, 22);
		((ToolStripItem)exitMenuItem).Size = size29;
		((ToolStripItem)exitMenuItem).Text = "E&xit";
		ToolStripItem[] array3 = (ToolStripItem[])(object)new ToolStripItem[37]
		{
			(ToolStripItem)toolStripMenuItem9,
			(ToolStripItem)colorFgMenuItem,
			(ToolStripItem)colorBgMenuItem,
			(ToolStripItem)toolStripMenuItem10,
			(ToolStripItem)toolStripSeparator8,
			(ToolStripItem)toolStripMenuItem3,
			(ToolStripItem)logFreqMenuItem,
			(ToolStripItem)linFreqMenuItem,
			(ToolStripItem)frequencyMinMenu,
			(ToolStripItem)frequencyMaxMenu,
			(ToolStripItem)plotFreqTicsMenu,
			(ToolStripItem)optionFreqShowGating,
			(ToolStripItem)toolStripSeparator3,
			(ToolStripItem)toolStripMenuItem4,
			(ToolStripItem)decibelAmpMenuItem,
			(ToolStripItem)linAmpMenuItem,
			(ToolStripItem)plotAmpDBMinMenu,
			(ToolStripItem)plotAmpDBMaxMenu,
			(ToolStripItem)plotAmpTicsMenu,
			(ToolStripItem)toolStripMenuItem12,
			(ToolStripItem)toolStripSeparator4,
			(ToolStripItem)toolStripMenuItem6,
			(ToolStripItem)impulseAsSamplesMenuItem,
			(ToolStripItem)impulseAsTimeMenuItem,
			(ToolStripItem)impulseAsDistanceMenuItem,
			(ToolStripItem)toolStripSeparator15,
			(ToolStripItem)optionsImpulseShowHD,
			(ToolStripItem)toolStripSeparator16,
			(ToolStripItem)impulseInterpolate,
			(ToolStripItem)toolStripSeparator5,
			(ToolStripItem)toolStripMenuItem5,
			(ToolStripItem)hidePhaseWhenAmpMenuItem,
			(ToolStripItem)toolStripSeparator6,
			(ToolStripItem)toolStripMenuItem7,
			(ToolStripItem)resetSettingsMenuItem,
			(ToolStripItem)saveSettingsMenuItem,
			(ToolStripItem)loadSettingsMenuItem
		};
		((ToolStripDropDownItem)optionsMenu).DropDownItems.AddRange(array3);
		((ToolStripItem)optionsMenu).Name = "optionsMenu";
		Size size30 = new Size(56, 20);
		((ToolStripItem)optionsMenu).Size = size30;
		((ToolStripItem)optionsMenu).Text = "&Options";
		((ToolStripItem)toolStripMenuItem9).Font = new Font("Tahoma", 8.25f, (FontStyle)1);
		((ToolStripItem)toolStripMenuItem9).Name = "toolStripMenuItem9";
		Size size31 = new Size(237, 22);
		((ToolStripItem)toolStripMenuItem9).Size = size31;
		((ToolStripItem)toolStripMenuItem9).Text = "Colors && Linewidth";
		((ToolStripItem)colorFgMenuItem).Name = "colorFgMenuItem";
		Size size32 = new Size(237, 22);
		((ToolStripItem)colorFgMenuItem).Size = size32;
		((ToolStripItem)colorFgMenuItem).Text = "Grid && Text Color";
		((ToolStripItem)colorBgMenuItem).Name = "colorBgMenuItem";
		Size size33 = new Size(237, 22);
		((ToolStripItem)colorBgMenuItem).Size = size33;
		((ToolStripItem)colorBgMenuItem).Text = "Background Color";
		ToolStripItem[] array4 = (ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)lineWidthComboBox };
		((ToolStripDropDownItem)toolStripMenuItem10).DropDownItems.AddRange(array4);
		((ToolStripItem)toolStripMenuItem10).Name = "toolStripMenuItem10";
		Size size34 = new Size(237, 22);
		((ToolStripItem)toolStripMenuItem10).Size = size34;
		((ToolStripItem)toolStripMenuItem10).Text = "Linewidth [pixels]";
		object[] array5 = new object[5] { "1", "2", "3", "4", "5" };
		lineWidthComboBox.Items.AddRange(array5);
		((ToolStripItem)lineWidthComboBox).Name = "lineWidthComboBox";
		Size size35 = new Size(75, 21);
		((ToolStripControlHost)lineWidthComboBox).Size = size35;
		((ToolStripControlHost)lineWidthComboBox).Text = "2";
		((ToolStripItem)toolStripSeparator8).Name = "toolStripSeparator8";
		Size size36 = new Size(234, 6);
		((ToolStripItem)toolStripSeparator8).Size = size36;
		((ToolStripItem)toolStripMenuItem3).Font = new Font("Tahoma", 8.25f, (FontStyle)1);
		((ToolStripItem)toolStripMenuItem3).Name = "toolStripMenuItem3";
		Size size37 = new Size(237, 22);
		((ToolStripItem)toolStripMenuItem3).Size = size37;
		((ToolStripItem)toolStripMenuItem3).Text = "Frequency axis";
		logFreqMenuItem.Checked = true;
		logFreqMenuItem.CheckState = (CheckState)1;
		((ToolStripItem)logFreqMenuItem).Name = "logFreqMenuItem";
		Size size38 = new Size(237, 22);
		((ToolStripItem)logFreqMenuItem).Size = size38;
		((ToolStripItem)logFreqMenuItem).Text = "Logarithmic frequency axis";
		((ToolStripItem)linFreqMenuItem).Name = "linFreqMenuItem";
		Size size39 = new Size(237, 22);
		((ToolStripItem)linFreqMenuItem).Size = size39;
		((ToolStripItem)linFreqMenuItem).Text = "Linear frequency axis";
		ToolStripItem[] array6 = (ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)plotFreqMin };
		((ToolStripDropDownItem)frequencyMinMenu).DropDownItems.AddRange(array6);
		((ToolStripItem)frequencyMinMenu).Name = "frequencyMinMenu";
		Size size40 = new Size(237, 22);
		((ToolStripItem)frequencyMinMenu).Size = size40;
		((ToolStripItem)frequencyMinMenu).Tag = "adv";
		((ToolStripItem)frequencyMinMenu).Text = "Min frequency [Hz]";
		plotFreqMin.MaxLength = 5;
		((ToolStripItem)plotFreqMin).Name = "plotFreqMin";
		Size size41 = new Size(40, 21);
		((ToolStripControlHost)plotFreqMin).Size = size41;
		((ToolStripControlHost)plotFreqMin).Text = "20";
		ToolStripItem[] array7 = (ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)plotFreqMax };
		((ToolStripDropDownItem)frequencyMaxMenu).DropDownItems.AddRange(array7);
		((ToolStripItem)frequencyMaxMenu).Name = "frequencyMaxMenu";
		Size size42 = new Size(237, 22);
		((ToolStripItem)frequencyMaxMenu).Size = size42;
		((ToolStripItem)frequencyMaxMenu).Tag = "adv";
		((ToolStripItem)frequencyMaxMenu).Text = "Max frequency [Hz]";
		plotFreqMax.MaxLength = 5;
		((ToolStripItem)plotFreqMax).Name = "plotFreqMax";
		Size size43 = new Size(40, 21);
		((ToolStripControlHost)plotFreqMax).Size = size43;
		((ToolStripControlHost)plotFreqMax).Text = "20000";
		ToolStripItem[] array8 = (ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)plotFreqTics };
		((ToolStripDropDownItem)plotFreqTicsMenu).DropDownItems.AddRange(array8);
		((ToolStripItem)plotFreqTicsMenu).Name = "plotFreqTicsMenu";
		Size size44 = new Size(237, 22);
		((ToolStripItem)plotFreqTicsMenu).Size = size44;
		((ToolStripItem)plotFreqTicsMenu).Tag = "adv";
		((ToolStripItem)plotFreqTicsMenu).Text = "Number of gridlines (Max)";
		plotFreqTics.MaxLength = 2;
		((ToolStripItem)plotFreqTics).Name = "plotFreqTics";
		Size size45 = new Size(30, 21);
		((ToolStripControlHost)plotFreqTics).Size = size45;
		((ToolStripControlHost)plotFreqTics).Text = "30";
		optionFreqShowGating.Checked = true;
		optionFreqShowGating.CheckOnClick = true;
		optionFreqShowGating.CheckState = (CheckState)1;
		((ToolStripItem)optionFreqShowGating).Name = "optionFreqShowGating";
		Size size46 = new Size(237, 22);
		((ToolStripItem)optionFreqShowGating).Size = size46;
		((ToolStripItem)optionFreqShowGating).Text = "Show gating frequency (If any)";
		((ToolStripItem)toolStripSeparator3).Name = "toolStripSeparator3";
		Size size47 = new Size(234, 6);
		((ToolStripItem)toolStripSeparator3).Size = size47;
		((ToolStripItem)toolStripMenuItem4).Font = new Font("Tahoma", 8.25f, (FontStyle)1);
		((ToolStripItem)toolStripMenuItem4).Name = "toolStripMenuItem4";
		Size size48 = new Size(237, 22);
		((ToolStripItem)toolStripMenuItem4).Size = size48;
		((ToolStripItem)toolStripMenuItem4).Text = "Amplitude axis";
		decibelAmpMenuItem.Checked = true;
		decibelAmpMenuItem.CheckState = (CheckState)1;
		((ToolStripItem)decibelAmpMenuItem).Name = "decibelAmpMenuItem";
		Size size49 = new Size(237, 22);
		((ToolStripItem)decibelAmpMenuItem).Size = size49;
		((ToolStripItem)decibelAmpMenuItem).Text = "Decibel amplitude axis";
		((ToolStripItem)linAmpMenuItem).Name = "linAmpMenuItem";
		Size size50 = new Size(237, 22);
		((ToolStripItem)linAmpMenuItem).Size = size50;
		((ToolStripItem)linAmpMenuItem).Text = "Linear amplitude axis";
		ToolStripItem[] array9 = (ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)plotAmpDBMin };
		((ToolStripDropDownItem)plotAmpDBMinMenu).DropDownItems.AddRange(array9);
		((ToolStripItem)plotAmpDBMinMenu).Name = "plotAmpDBMinMenu";
		Size size51 = new Size(237, 22);
		((ToolStripItem)plotAmpDBMinMenu).Size = size51;
		((ToolStripItem)plotAmpDBMinMenu).Tag = "adv";
		((ToolStripItem)plotAmpDBMinMenu).Text = "Min amplitude [dB]";
		plotAmpDBMin.MaxLength = 4;
		((ToolStripItem)plotAmpDBMin).Name = "plotAmpDBMin";
		Size size52 = new Size(30, 21);
		((ToolStripControlHost)plotAmpDBMin).Size = size52;
		((ToolStripControlHost)plotAmpDBMin).Text = "-60";
		ToolStripItem[] array10 = (ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)plotAmpDBMax };
		((ToolStripDropDownItem)plotAmpDBMaxMenu).DropDownItems.AddRange(array10);
		((ToolStripItem)plotAmpDBMaxMenu).Name = "plotAmpDBMaxMenu";
		Size size53 = new Size(237, 22);
		((ToolStripItem)plotAmpDBMaxMenu).Size = size53;
		((ToolStripItem)plotAmpDBMaxMenu).Tag = "adv";
		((ToolStripItem)plotAmpDBMaxMenu).Text = "Max amplitude [dB]";
		plotAmpDBMax.MaxLength = 4;
		((ToolStripItem)plotAmpDBMax).Name = "plotAmpDBMax";
		Size size54 = new Size(30, 21);
		((ToolStripControlHost)plotAmpDBMax).Size = size54;
		((ToolStripControlHost)plotAmpDBMax).Text = "1";
		ToolStripItem[] array11 = (ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)plotAmpTics };
		((ToolStripDropDownItem)plotAmpTicsMenu).DropDownItems.AddRange(array11);
		((ToolStripItem)plotAmpTicsMenu).Name = "plotAmpTicsMenu";
		Size size55 = new Size(237, 22);
		((ToolStripItem)plotAmpTicsMenu).Size = size55;
		((ToolStripItem)plotAmpTicsMenu).Tag = "adv";
		((ToolStripItem)plotAmpTicsMenu).Text = "Number of gridlines (Max)";
		plotAmpTics.MaxLength = 2;
		((ToolStripItem)plotAmpTics).Name = "plotAmpTics";
		Size size56 = new Size(30, 21);
		((ToolStripControlHost)plotAmpTics).Size = size56;
		((ToolStripControlHost)plotAmpTics).Text = "10";
		ToolStripItem[] array12 = (ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)plotHDHideDB };
		((ToolStripDropDownItem)toolStripMenuItem12).DropDownItems.AddRange(array12);
		((ToolStripItem)toolStripMenuItem12).Name = "toolStripMenuItem12";
		Size size57 = new Size(237, 22);
		((ToolStripItem)toolStripMenuItem12).Size = size57;
		((ToolStripItem)toolStripMenuItem12).Text = "Hide distortion when below [dB]";
		((ToolStripItem)plotHDHideDB).Name = "plotHDHideDB";
		Size size58 = new Size(30, 21);
		((ToolStripControlHost)plotHDHideDB).Size = size58;
		((ToolStripControlHost)plotHDHideDB).Text = "-20";
		((ToolStripItem)toolStripSeparator4).Name = "toolStripSeparator4";
		Size size59 = new Size(234, 6);
		((ToolStripItem)toolStripSeparator4).Size = size59;
		((ToolStripItem)toolStripMenuItem6).Font = new Font("Tahoma", 8.25f, (FontStyle)1);
		((ToolStripItem)toolStripMenuItem6).Name = "toolStripMenuItem6";
		Size size60 = new Size(237, 22);
		((ToolStripItem)toolStripMenuItem6).Size = size60;
		((ToolStripItem)toolStripMenuItem6).Text = "Impulse axis";
		impulseAsSamplesMenuItem.Checked = true;
		impulseAsSamplesMenuItem.CheckState = (CheckState)1;
		((ToolStripItem)impulseAsSamplesMenuItem).Name = "impulseAsSamplesMenuItem";
		Size size61 = new Size(237, 22);
		((ToolStripItem)impulseAsSamplesMenuItem).Size = size61;
		((ToolStripItem)impulseAsSamplesMenuItem).Text = "Impulse as samples";
		((ToolStripItem)impulseAsTimeMenuItem).Name = "impulseAsTimeMenuItem";
		Size size62 = new Size(237, 22);
		((ToolStripItem)impulseAsTimeMenuItem).Size = size62;
		((ToolStripItem)impulseAsTimeMenuItem).Text = "Impulse as time [millisec]";
		((ToolStripItem)impulseAsDistanceMenuItem).Name = "impulseAsDistanceMenuItem";
		Size size63 = new Size(237, 22);
		((ToolStripItem)impulseAsDistanceMenuItem).Size = size63;
		((ToolStripItem)impulseAsDistanceMenuItem).Text = "Impulse as distance [cm]";
		((ToolStripItem)toolStripSeparator15).Name = "toolStripSeparator15";
		Size size64 = new Size(234, 6);
		((ToolStripItem)toolStripSeparator15).Size = size64;
		optionsImpulseShowHD.Checked = true;
		optionsImpulseShowHD.CheckOnClick = true;
		optionsImpulseShowHD.CheckState = (CheckState)1;
		((ToolStripItem)optionsImpulseShowHD).Name = "optionsImpulseShowHD";
		Size size65 = new Size(237, 22);
		((ToolStripItem)optionsImpulseShowHD).Size = size65;
		((ToolStripItem)optionsImpulseShowHD).Text = "Indicate harmonic pre tops";
		((ToolStripItem)toolStripSeparator16).Name = "toolStripSeparator16";
		Size size66 = new Size(234, 6);
		((ToolStripItem)toolStripSeparator16).Size = size66;
		impulseInterpolate.Checked = true;
		impulseInterpolate.CheckOnClick = true;
		impulseInterpolate.CheckState = (CheckState)1;
		((ToolStripItem)impulseInterpolate).Name = "impulseInterpolate";
		Size size67 = new Size(237, 22);
		((ToolStripItem)impulseInterpolate).Size = size67;
		((ToolStripItem)impulseInterpolate).Text = "Interpolate with splines";
		((ToolStripItem)toolStripSeparator5).Name = "toolStripSeparator5";
		Size size68 = new Size(234, 6);
		((ToolStripItem)toolStripSeparator5).Size = size68;
		((ToolStripItem)toolStripMenuItem5).Font = new Font("Tahoma", 8.25f, (FontStyle)1);
		((ToolStripItem)toolStripMenuItem5).Name = "toolStripMenuItem5";
		Size size69 = new Size(237, 22);
		((ToolStripItem)toolStripMenuItem5).Size = size69;
		((ToolStripItem)toolStripMenuItem5).Text = "Phase axis";
		ToolStripItem[] array13 = (ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)plotPhaseHideDB };
		((ToolStripDropDownItem)hidePhaseWhenAmpMenuItem).DropDownItems.AddRange(array13);
		((ToolStripItem)hidePhaseWhenAmpMenuItem).Name = "hidePhaseWhenAmpMenuItem";
		Size size70 = new Size(237, 22);
		((ToolStripItem)hidePhaseWhenAmpMenuItem).Size = size70;
		((ToolStripItem)hidePhaseWhenAmpMenuItem).Text = "Hide phase when below [dB]";
		((ToolStripItem)plotPhaseHideDB).Name = "plotPhaseHideDB";
		Size size71 = new Size(30, 21);
		((ToolStripControlHost)plotPhaseHideDB).Size = size71;
		((ToolStripControlHost)plotPhaseHideDB).Text = "-20";
		((ToolStripItem)toolStripSeparator6).Name = "toolStripSeparator6";
		Size size72 = new Size(234, 6);
		((ToolStripItem)toolStripSeparator6).Size = size72;
		((ToolStripItem)toolStripMenuItem7).Font = new Font("Tahoma", 8.25f, (FontStyle)1);
		((ToolStripItem)toolStripMenuItem7).Name = "toolStripMenuItem7";
		Size size73 = new Size(237, 22);
		((ToolStripItem)toolStripMenuItem7).Size = size73;
		((ToolStripItem)toolStripMenuItem7).Text = "Miscellaneous";
		((ToolStripItem)resetSettingsMenuItem).Name = "resetSettingsMenuItem";
		Size size74 = new Size(237, 22);
		((ToolStripItem)resetSettingsMenuItem).Size = size74;
		((ToolStripItem)resetSettingsMenuItem).Text = "Reset Settings";
		((ToolStripItem)saveSettingsMenuItem).Name = "saveSettingsMenuItem";
		Size size75 = new Size(237, 22);
		((ToolStripItem)saveSettingsMenuItem).Size = size75;
		((ToolStripItem)saveSettingsMenuItem).Text = "Save Settings As...";
		((ToolStripItem)loadSettingsMenuItem).Name = "loadSettingsMenuItem";
		Size size76 = new Size(237, 22);
		((ToolStripItem)loadSettingsMenuItem).Size = size76;
		((ToolStripItem)loadSettingsMenuItem).Text = "Load Settings";
		ToolStripItem[] array14 = (ToolStripItem[])(object)new ToolStripItem[19]
		{
			(ToolStripItem)toolStripMenuItem1,
			(ToolStripItem)manipulateMeasDiffMenuItem,
			(ToolStripItem)manipulateMeasSumMenuItem,
			(ToolStripItem)manipulateMeasProductMenuItem,
			(ToolStripItem)manipulateMeasDivMenuItem,
			(ToolStripItem)manipulateMeasInvert,
			(ToolStripItem)manipulateMatchAB,
			(ToolStripItem)manipulateAbcStitch,
			(ToolStripItem)manipulateAbcMicCal,
			(ToolStripItem)toolStripSeparator11,
			(ToolStripItem)toolStripMenuItem11,
			(ToolStripItem)manipulateCopyAToBMenuItem,
			(ToolStripItem)manipulateCopyAToCMenuItem,
			(ToolStripItem)toolStripSeparator12,
			(ToolStripItem)manipulateWindowAToBMenuItem,
			(ToolStripItem)manipulateWindowAToBAndCMenuItem,
			(ToolStripItem)toolStripSeparator14,
			(ToolStripItem)toolStripMenuItem13,
			(ToolStripItem)qboxSlotC
		};
		((ToolStripDropDownItem)manipulateMenu).DropDownItems.AddRange(array14);
		((ToolStripItem)manipulateMenu).Name = "manipulateMenu";
		Size size77 = new Size(79, 20);
		((ToolStripItem)manipulateMenu).Size = size77;
		((ToolStripItem)manipulateMenu).Text = "Manipulation";
		((ToolStripItem)toolStripMenuItem1).Font = new Font("Tahoma", 8.25f, (FontStyle)1);
		((ToolStripItem)toolStripMenuItem1).Name = "toolStripMenuItem1";
		Size size78 = new Size(266, 22);
		((ToolStripItem)toolStripMenuItem1).Size = size78;
		((ToolStripItem)toolStripMenuItem1).Text = "Frequency domain manipulation";
		((ToolStripItem)manipulateMeasDiffMenuItem).Name = "manipulateMeasDiffMenuItem";
		Size size79 = new Size(266, 22);
		((ToolStripItem)manipulateMeasDiffMenuItem).Size = size79;
		((ToolStripItem)manipulateMeasDiffMenuItem).Text = "Difference (C = A - B)";
		((ToolStripItem)manipulateMeasSumMenuItem).Name = "manipulateMeasSumMenuItem";
		Size size80 = new Size(266, 22);
		((ToolStripItem)manipulateMeasSumMenuItem).Size = size80;
		((ToolStripItem)manipulateMeasSumMenuItem).Text = "Sum (C = A + B)";
		((ToolStripItem)manipulateMeasProductMenuItem).Name = "manipulateMeasProductMenuItem";
		Size size81 = new Size(266, 22);
		((ToolStripItem)manipulateMeasProductMenuItem).Size = size81;
		((ToolStripItem)manipulateMeasProductMenuItem).Text = "Product (C = A * B)";
		((ToolStripItem)manipulateMeasDivMenuItem).Name = "manipulateMeasDivMenuItem";
		Size size82 = new Size(266, 22);
		((ToolStripItem)manipulateMeasDivMenuItem).Size = size82;
		((ToolStripItem)manipulateMeasDivMenuItem).Text = "Division (C = A / B)";
		((ToolStripItem)manipulateMeasInvert).Name = "manipulateMeasInvert";
		Size size83 = new Size(266, 22);
		((ToolStripItem)manipulateMeasInvert).Size = size83;
		((ToolStripItem)manipulateMeasInvert).Text = "Inversion  (B = 1/A)";
		((ToolStripItem)manipulateMatchAB).Name = "manipulateMatchAB";
		Size size84 = new Size(266, 22);
		((ToolStripItem)manipulateMatchAB).Size = size84;
		((ToolStripItem)manipulateMatchAB).Text = "Match  (A -> B)";
		((ToolStripItem)manipulateAbcStitch).Name = "manipulateAbcStitch";
		Size size85 = new Size(266, 22);
		((ToolStripItem)manipulateAbcStitch).Size = size85;
		((ToolStripItem)manipulateAbcStitch).Text = "Stitching  (C = A -> B)";
		((ToolStripItem)manipulateAbcMicCal).Name = "manipulateAbcMicCal";
		Size size86 = new Size(266, 22);
		((ToolStripItem)manipulateAbcMicCal).Size = size86;
		((ToolStripItem)manipulateAbcMicCal).Text = "Mic.  C = Calibration(A -> B)";
		((ToolStripItem)toolStripSeparator11).Name = "toolStripSeparator11";
		Size size87 = new Size(263, 6);
		((ToolStripItem)toolStripSeparator11).Size = size87;
		((ToolStripItem)toolStripMenuItem11).Font = new Font("Tahoma", 8.25f, (FontStyle)1);
		((ToolStripItem)toolStripMenuItem11).Name = "toolStripMenuItem11";
		Size size88 = new Size(266, 22);
		((ToolStripItem)toolStripMenuItem11).Size = size88;
		((ToolStripItem)toolStripMenuItem11).Text = "Other manipulation";
		((ToolStripItem)manipulateCopyAToBMenuItem).Name = "manipulateCopyAToBMenuItem";
		Size size89 = new Size(266, 22);
		((ToolStripItem)manipulateCopyAToBMenuItem).Size = size89;
		((ToolStripItem)manipulateCopyAToBMenuItem).Text = "Copy A to B";
		((ToolStripItem)manipulateCopyAToCMenuItem).Name = "manipulateCopyAToCMenuItem";
		Size size90 = new Size(266, 22);
		((ToolStripItem)manipulateCopyAToCMenuItem).Size = size90;
		((ToolStripItem)manipulateCopyAToCMenuItem).Text = "Copy A to C";
		((ToolStripItem)toolStripSeparator12).Name = "toolStripSeparator12";
		Size size91 = new Size(263, 6);
		((ToolStripItem)toolStripSeparator12).Size = size91;
		((ToolStripItem)manipulateWindowAToBMenuItem).Name = "manipulateWindowAToBMenuItem";
		Size size92 = new Size(266, 22);
		((ToolStripItem)manipulateWindowAToBMenuItem).Size = size92;
		((ToolStripItem)manipulateWindowAToBMenuItem).Text = "Copy time-window from A to B";
		((ToolStripItem)manipulateWindowAToBAndCMenuItem).Name = "manipulateWindowAToBAndCMenuItem";
		Size size93 = new Size(266, 22);
		((ToolStripItem)manipulateWindowAToBAndCMenuItem).Size = size93;
		((ToolStripItem)manipulateWindowAToBAndCMenuItem).Text = "Copy time-window from A to B,C";
		((ToolStripItem)toolStripSeparator14).Name = "toolStripSeparator14";
		Size size94 = new Size(263, 6);
		((ToolStripItem)toolStripSeparator14).Size = size94;
		((ToolStripItem)toolStripMenuItem13).Font = new Font("Tahoma", 8.25f, (FontStyle)1);
		((ToolStripItem)toolStripMenuItem13).Name = "toolStripMenuItem13";
		Size size95 = new Size(266, 22);
		((ToolStripItem)toolStripMenuItem13).Size = size95;
		((ToolStripItem)toolStripMenuItem13).Text = "Generate Responses";
		((ToolStripItem)qboxSlotC).Name = "qboxSlotC";
		Size size96 = new Size(266, 22);
		((ToolStripItem)qboxSlotC).Size = size96;
		((ToolStripItem)qboxSlotC).Text = "QBox Simulation (Slot C)";
		ToolStripItem[] array15 = (ToolStripItem[])(object)new ToolStripItem[2]
		{
			(ToolStripItem)waveFileFormatToolStripMenuItem,
			(ToolStripItem)waveFormatComboBox
		};
		((ToolStripDropDownItem)settingsMenu).DropDownItems.AddRange(array15);
		((ToolStripItem)settingsMenu).Name = "settingsMenu";
		Size size97 = new Size(58, 20);
		((ToolStripItem)settingsMenu).Size = size97;
		((ToolStripItem)settingsMenu).Text = "Settings";
		((ToolStripItem)waveFileFormatToolStripMenuItem).Font = new Font("Tahoma", 8.25f, (FontStyle)1);
		((ToolStripItem)waveFileFormatToolStripMenuItem).Name = "waveFileFormatToolStripMenuItem";
		Size size98 = new Size(211, 22);
		((ToolStripItem)waveFileFormatToolStripMenuItem).Size = size98;
		((ToolStripItem)waveFileFormatToolStripMenuItem).Text = "Save wave file format:";
		waveFormatComboBox.DropDownStyle = (ComboBoxStyle)2;
		waveFormatComboBox.DropDownWidth = 50;
		object[] array16 = new object[4] { "32 bit float", "16 bit PCM", "24 bit PCM", "32 bit PCM" };
		waveFormatComboBox.Items.AddRange(array16);
		((ToolStripItem)waveFormatComboBox).Name = "waveFormatComboBox";
		Size size99 = new Size(121, 21);
		((ToolStripControlHost)waveFormatComboBox).Size = size99;
		ToolStripItem[] array17 = (ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)recordMeter };
		((ToolStripDropDownItem)toolsMenu).DropDownItems.AddRange(array17);
		((ToolStripItem)toolsMenu).Name = "toolsMenu";
		Size size100 = new Size(44, 20);
		((ToolStripItem)toolsMenu).Size = size100;
		((ToolStripItem)toolsMenu).Text = "Tools";
		((ToolStripItem)recordMeter).Name = "recordMeter";
		recordMeter.ShortcutKeys = (Keys)262256;
		Size size101 = new Size(190, 22);
		((ToolStripItem)recordMeter).Size = size101;
		((ToolStripItem)recordMeter).Text = "Record Meter";
		ToolStripItem[] array18 = (ToolStripItem[])(object)new ToolStripItem[9]
		{
			(ToolStripItem)aboutMenuItem,
			(ToolStripItem)showToolTipsMenuItem,
			(ToolStripItem)toolStripSeparator20,
			(ToolStripItem)helpUserGuide,
			(ToolStripItem)toolStripSeparator10,
			(ToolStripItem)checkforUpdate,
			(ToolStripItem)checkforUpdateAtStart,
			(ToolStripItem)toolStripSeparator9,
			(ToolStripItem)helpMenuItem
		};
		((ToolStripDropDownItem)helpTopMenuItem).DropDownItems.AddRange(array18);
		((ToolStripItem)helpTopMenuItem).Name = "helpTopMenuItem";
		Size size102 = new Size(40, 20);
		((ToolStripItem)helpTopMenuItem).Size = size102;
		((ToolStripItem)helpTopMenuItem).Text = "Help";
		((ToolStripItem)aboutMenuItem).Name = "aboutMenuItem";
		Size size103 = new Size(236, 22);
		((ToolStripItem)aboutMenuItem).Size = size103;
		((ToolStripItem)aboutMenuItem).Text = "About";
		showToolTipsMenuItem.Checked = true;
		showToolTipsMenuItem.CheckState = (CheckState)1;
		((ToolStripItem)showToolTipsMenuItem).Name = "showToolTipsMenuItem";
		Size size104 = new Size(236, 22);
		((ToolStripItem)showToolTipsMenuItem).Size = size104;
		((ToolStripItem)showToolTipsMenuItem).Text = "Show ToolTips";
		((ToolStripItem)toolStripSeparator20).Name = "toolStripSeparator20";
		Size size105 = new Size(233, 6);
		((ToolStripItem)toolStripSeparator20).Size = size105;
		((ToolStripItem)helpUserGuide).Name = "helpUserGuide";
		Size size106 = new Size(236, 22);
		((ToolStripItem)helpUserGuide).Size = size106;
		((ToolStripItem)helpUserGuide).Text = "User Guide (Checks for update)";
		((ToolStripItem)toolStripSeparator10).Name = "toolStripSeparator10";
		Size size107 = new Size(233, 6);
		((ToolStripItem)toolStripSeparator10).Size = size107;
		((ToolStripItem)checkforUpdate).Name = "checkforUpdate";
		Size size108 = new Size(236, 22);
		((ToolStripItem)checkforUpdate).Size = size108;
		((ToolStripItem)checkforUpdate).Text = "Check for update online now";
		checkforUpdateAtStart.Checked = true;
		checkforUpdateAtStart.CheckState = (CheckState)1;
		((ToolStripItem)checkforUpdateAtStart).Name = "checkforUpdateAtStart";
		Size size109 = new Size(236, 22);
		((ToolStripItem)checkforUpdateAtStart).Size = size109;
		((ToolStripItem)checkforUpdateAtStart).Text = "Check for update at startup";
		((ToolStripItem)toolStripSeparator9).Name = "toolStripSeparator9";
		Size size110 = new Size(233, 6);
		((ToolStripItem)toolStripSeparator9).Size = size110;
		((ToolStripItem)helpMenuItem).Name = "helpMenuItem";
		Size size111 = new Size(236, 22);
		((ToolStripItem)helpMenuItem).Size = size111;
		((ToolStripItem)helpMenuItem).Text = "Help";
		((Control)this).Controls.Add((Control)(object)mainMenuStrip);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Padding margin);
		((Padding)(ref margin))._002Ector(0);
		((Control)this).Margin = margin;
		((Control)this).Name = "ControlMenu";
		Size size112 = new Size(800, 23);
		((Control)this).Size = size112;
		((Control)mainMenuStrip).ResumeLayout(false);
		((Control)mainMenuStrip).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	protected override void Dispose([MarshalAs(UnmanagedType.U1)] bool P_0)
	{
		if (P_0)
		{
			try
			{
				_007EControlMenu();
				return;
			}
			finally
			{
				((ContainerControl)this).Dispose(true);
			}
		}
		((ContainerControl)this).Dispose(false);
	}
}
