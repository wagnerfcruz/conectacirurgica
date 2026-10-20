using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using std;

namespace HOLM.HOLMImpulse.Conf;

public class PlotOptions
{
	public double PlotFreqMin;

	public double PlotFreqMax;

	public double PlotDbMin;

	public double PlotDbMax;

	public double PlotImpulseDBMin;

	public int GraphicsNumberOfXTics;

	public int GraphicsNumberOfYTics;

	public int LineWidth;

	public int ImpulseGraphMode;

	public double HidePhaseWhenBelowDB;

	public double HideHDWhenBelowDB;

	public bool FreqLogAxis;

	public bool AmpDBAxis;

	public bool PlotPhase;

	public bool PlotAmplitude;

	public bool PlotHD;

	public bool ImpulseInterpolate;

	public bool ImpulseShowHD;

	public bool FreqShowGating;

	[XmlElement(IsNullable = false)]
	public string ColorFgString;

	[XmlElement(IsNullable = false)]
	public string ColorBgString;

	[XmlElement(IsNullable = false)]
	public string ColorMeasAString;

	[XmlElement(IsNullable = false)]
	public string ColorMeasBString;

	[XmlElement(IsNullable = false)]
	public string ColorMeasCString;

	[XmlElement(IsNullable = false)]
	public string ColorSignalString;

	[XmlIgnore]
	public Color ColorFg;

	[XmlIgnore]
	public Color ColorBg;

	[XmlIgnore]
	public Color ColorMeasA;

	[XmlIgnore]
	public Color ColorMeasB;

	[XmlIgnore]
	public Color ColorMeasC;

	[XmlIgnore]
	public Color ColorSignal;

	public int[] CustomColors;

	public PlotOptions()
	{
		Reset();
	}

	public void Reset()
	{
		LineWidth = 2;
		PlotFreqMin = 20.0;
		PlotFreqMax = 22000.0;
		PlotDbMin = -70.0;
		PlotDbMax = 10.0;
		PlotImpulseDBMin = -70.0;
		HidePhaseWhenBelowDB = -50.0;
		HideHDWhenBelowDB = -50.0;
		ImpulseGraphMode = 2;
		FreqLogAxis = true;
		AmpDBAxis = true;
		PlotPhase = true;
		PlotAmplitude = true;
		PlotHD = false;
		ImpulseShowHD = true;
		FreqShowGating = true;
		ImpulseInterpolate = true;
		GraphicsNumberOfXTics = 30;
		GraphicsNumberOfYTics = 20;
		Color black = Color.Black;
		ColorFg = black;
		Color colorBg = Color.FromArgb(240, 240, 240);
		ColorBg = colorBg;
		Color darkBlue = Color.DarkBlue;
		ColorMeasA = darkBlue;
		Color darkRed = Color.DarkRed;
		ColorMeasB = darkRed;
		Color darkGreen = Color.DarkGreen;
		ColorMeasC = darkGreen;
		Color colorSignal = Color.FromArgb(50, 50, 50);
		ColorSignal = colorSignal;
		int[] customColors = (CustomColors = new int[0]);
		Options.colorDialog.CustomColors = customColors;
		SaveColors();
	}

	public unsafe void PostLoad()
	{
		try
		{
			LoadColors();
		}
		catch (Exception ex)
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj);
			global::_003CModule_003E.std_002Ebasic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D(&obj, 3, 1);
			try
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj2);
				basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* ptr = global::_003CModule_003E.HOLM_002EMiscHelper_002EStringToStd(&obj2, ex.ToString());
				try
				{
					global::_003CModule_003E.std_002Eoperator_003C_003C_003Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_0020_003E(global::_003CModule_003E.std_002Eoperator_003C_003C_003Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_0020_003E(global::_003CModule_003E.std_002Eoperator_003C_003C_003Cchar_002Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_002Cclass_0020std_003A_003Aallocator_003Cchar_003E_0020_003E(global::_003CModule_003E.std_002Eoperator_003C_003C_003Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_0020_003E(global::_003CModule_003E.std_002Eoperator_003C_003C_003Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_0020_003E((basic_ostream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 8)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref global::_003CModule_003E._003F_003F_C_0040_08KFJDDMMO_0040WARNING_003F5_003F_0024AA_0040)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref global::_003CModule_003E._003F_003F_C_0040_0CF_0040EBDHKAIO_0040PlotOptions_003F3_003F3PostLoad_003F_0024CI_003F_0024CJ_003F5Exceptio_0040)), ptr), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref global::_003CModule_003E._003F_003F_C_0040_0BH_0040FHJFJEHI_0040_003F6_003F5Using_003F5default_003F5colors_003F_0024AA_0040)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref global::_003CModule_003E._003F_003F_C_0040_01EEMJAFIK_0040_003F6_003F_0024AA_0040));
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
			Reset();
		}
		if (HideHDWhenBelowDB > -1.0)
		{
			HideHDWhenBelowDB = -10.0;
		}
		if (PlotImpulseDBMin > -20.0)
		{
			PlotImpulseDBMin = -70.0;
		}
	}

	public void LoadColors()
	{
		ColorConverter colorConverter = new ColorConverter();
		ref Color colorFg = ref ColorFg;
		colorFg = (Color)colorConverter.ConvertFromString(ColorFgString);
		ref Color colorBg = ref ColorBg;
		colorBg = (Color)colorConverter.ConvertFromString(ColorBgString);
		ref Color colorMeasA = ref ColorMeasA;
		colorMeasA = (Color)colorConverter.ConvertFromString(ColorMeasAString);
		ref Color colorMeasB = ref ColorMeasB;
		colorMeasB = (Color)colorConverter.ConvertFromString(ColorMeasBString);
		ref Color colorMeasC = ref ColorMeasC;
		colorMeasC = (Color)colorConverter.ConvertFromString(ColorMeasCString);
		ref Color colorSignal = ref ColorSignal;
		colorSignal = (Color)colorConverter.ConvertFromString(ColorSignalString);
		if (colorConverter is IDisposable disposable)
		{
			disposable.Dispose();
		}
		Options.colorDialog.CustomColors = CustomColors;
	}

	public void SaveColors()
	{
		ColorConverter colorConverter = new ColorConverter();
		ColorFgString = colorConverter.ConvertToString(ColorFg);
		ColorBgString = colorConverter.ConvertToString(ColorBg);
		ColorMeasAString = colorConverter.ConvertToString(ColorMeasA);
		ColorMeasBString = colorConverter.ConvertToString(ColorMeasB);
		ColorMeasCString = colorConverter.ConvertToString(ColorMeasC);
		ColorSignalString = colorConverter.ConvertToString(ColorSignal);
		if (colorConverter is IDisposable disposable)
		{
			disposable.Dispose();
		}
		CustomColors = Options.colorDialog.CustomColors;
	}
}
