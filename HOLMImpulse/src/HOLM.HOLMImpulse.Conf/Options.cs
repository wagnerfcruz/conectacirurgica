using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Xml.Serialization;
using std;

namespace HOLM.HOLMImpulse.Conf;

public class Options
{
	public static ColorDialog colorDialog = new ColorDialog();

	public static OptionsField Field = new OptionsField();

	public static OptionsTestField TestField = new OptionsTestField();

	static Options()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		Field.Init();
		LoadAutoSaved(showWarningIfError: false);
	}

	[return: MarshalAs(UnmanagedType.U1)]
	public unsafe static bool VerifyProductVersion(string filename)
	{
		if ((global::_003CModule_003E._003FA0x11566818_002E_003F_0024S3_0040_003F1_003F_003FVerifyProductVersion_0040Options_0040Conf_0040HOLMImpulse_0040HOLM_0040_0040SM_NP_0024AAVString_0040System_0040_0040_0040Z_00404IA & 1) == 0)
		{
			global::_003CModule_003E._003FA0x11566818_002E_003F_0024S3_0040_003F1_003F_003FVerifyProductVersion_0040Options_0040Conf_0040HOLMImpulse_0040HOLM_0040_0040SM_NP_0024AAVString_0040System_0040_0040_0040Z_00404IA |= 1u;
			try
			{
				global::_003CModule_003E._003FA0x11566818_002E_003FOPTIONS_COMPAT_START_NUMBER_0040_003F1_003F_003FVerifyProductVersion_0040Options_0040Conf_0040HOLMImpulse_0040HOLM_0040_0040SM_NP_0024AAVString_0040System_0040_0040_0040Z_00404IB = global::_003CModule_003E.HOLM_002EHOLMImpulse_002EConf_002EProductVersionNumber(new string(global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002Ec_str((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref global::_003CModule_003E.HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x11566818_002EOPTIONS_COMPAT_START))));
			}
			catch
			{
				//try-fault
				global::_003CModule_003E._003FA0x11566818_002E_003F_0024S3_0040_003F1_003F_003FVerifyProductVersion_0040Options_0040Conf_0040HOLMImpulse_0040HOLM_0040_0040SM_NP_0024AAVString_0040System_0040_0040_0040Z_00404IA &= 4294967294u;
				throw;
			}
		}
		if ((global::_003CModule_003E._003FA0x11566818_002E_003F_0024S3_0040_003F1_003F_003FVerifyProductVersion_0040Options_0040Conf_0040HOLMImpulse_0040HOLM_0040_0040SM_NP_0024AAVString_0040System_0040_0040_0040Z_00404IA & 2) == 0)
		{
			global::_003CModule_003E._003FA0x11566818_002E_003F_0024S3_0040_003F1_003F_003FVerifyProductVersion_0040Options_0040Conf_0040HOLMImpulse_0040HOLM_0040_0040SM_NP_0024AAVString_0040System_0040_0040_0040Z_00404IA |= 2u;
			try
			{
				global::_003CModule_003E._003FA0x11566818_002E_003FOPTIONS_COMPAT_END_NUMBER_0040_003F1_003F_003FVerifyProductVersion_0040Options_0040Conf_0040HOLMImpulse_0040HOLM_0040_0040SM_NP_0024AAVString_0040System_0040_0040_0040Z_00404IB = global::_003CModule_003E.HOLM_002EHOLMImpulse_002EConf_002EProductVersionNumber(Application.ProductVersion.Replace(", ", "."));
			}
			catch
			{
				//try-fault
				global::_003CModule_003E._003FA0x11566818_002E_003F_0024S3_0040_003F1_003F_003FVerifyProductVersion_0040Options_0040Conf_0040HOLMImpulse_0040HOLM_0040_0040SM_NP_0024AAVString_0040System_0040_0040_0040Z_00404IA &= 4294967293u;
				throw;
			}
		}
		try
		{
			XmlSerializer xmlSerializer = new XmlSerializer(typeof(OptionsTestField));
			TextReader textReader = new StreamReader(filename);
			TestField.WriterProductVersion = "";
			TestField = xmlSerializer.Deserialize(textReader) as OptionsTestField;
			uint num = global::_003CModule_003E.HOLM_002EHOLMImpulse_002EConf_002EProductVersionNumber(TestField.WriterProductVersion);
			textReader.Close();
			TextReader textReader2 = textReader;
			IDisposable disposable = textReader;
			((IDisposable)textReader)?.Dispose();
			XmlSerializer xmlSerializer2 = xmlSerializer;
			if (xmlSerializer is IDisposable disposable2)
			{
				disposable2.Dispose();
			}
			if (global::_003CModule_003E._003FA0x11566818_002E_003FOPTIONS_COMPAT_START_NUMBER_0040_003F1_003F_003FVerifyProductVersion_0040Options_0040Conf_0040HOLMImpulse_0040HOLM_0040_0040SM_NP_0024AAVString_0040System_0040_0040_0040Z_00404IB <= num && num <= global::_003CModule_003E._003FA0x11566818_002E_003FOPTIONS_COMPAT_END_NUMBER_0040_003F1_003F_003FVerifyProductVersion_0040Options_0040Conf_0040HOLMImpulse_0040HOLM_0040_0040SM_NP_0024AAVString_0040System_0040_0040_0040Z_00404IB)
			{
				return true;
			}
			return false;
		}
		catch (Exception)
		{
			TestField.WriterProductVersion = "Unknown";
			return false;
		}
	}

	public unsafe static void AutoSave()
	{
		Field.Plot.SaveColors();
		System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj);
		basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* ptr = global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D(&obj, (basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref global::_003CModule_003E.HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x11566818_002EOPTIONS_AUTOSAVE_FILENAME));
		string filename;
		try
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj2);
			basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* ptr2 = &obj2;
			basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* fileName = global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D(&obj2, ptr);
			filename = global::_003CModule_003E.HOLM_002EHOLMImpulse_002EConf_002EFilePathString(fileName, fSystem: false);
		}
		catch
		{
			//try-fault
			global::_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), ptr);
			throw;
		}
		global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D(ptr);
		SaveData(filename);
	}

	[return: MarshalAs(UnmanagedType.U1)]
	public unsafe static bool LoadAutoSaved([MarshalAs(UnmanagedType.U1)] bool showWarningIfError)
	{
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		bool result = false;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj);
		basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* ptr = global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D(&obj, (basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref global::_003CModule_003E.HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x11566818_002EOPTIONS_AUTOSAVE_FILENAME));
		string path;
		try
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj2);
			basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* ptr2 = &obj2;
			basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* fileName = global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D(&obj2, ptr);
			path = global::_003CModule_003E.HOLM_002EHOLMImpulse_002EConf_002EFilePathString(fileName, fSystem: false);
		}
		catch
		{
			//try-fault
			global::_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), ptr);
			throw;
		}
		global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D(ptr);
		if (File.Exists(path))
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj3);
			basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* pThis = &obj3;
			basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* ptr3 = global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D(&obj3, (basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref global::_003CModule_003E.HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x11566818_002EOPTIONS_AUTOSAVE_FILENAME));
			string filename;
			try
			{
				try
				{
					System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj4);
					basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* ptr4 = &obj4;
					basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* fileName2 = global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D(&obj4, ptr3);
					filename = global::_003CModule_003E.HOLM_002EHOLMImpulse_002EConf_002EFilePathString(fileName2, fSystem: false);
				}
				catch
				{
					//try-fault
					global::_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), ptr3);
					throw;
				}
				global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D(ptr3);
			}
			catch
			{
				//try-fault
				global::_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), pThis);
				throw;
			}
			result = LoadData(filename, showWarningIfError);
		}
		else if (showWarningIfError)
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj5);
			basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* ptr5 = &obj5;
			basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* fileName3 = global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D(&obj5, (basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref global::_003CModule_003E.HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x11566818_002EOPTIONS_AUTOSAVE_FILENAME));
			MessageBox.Show(string.Concat("Warning! Cannot find the autosaved options\n\n" + "Details : The following file does not exist\n", global::_003CModule_003E.HOLM_002EHOLMImpulse_002EConf_002EFilePathString(fileName3)), "HOLMImpulse - Warning", (MessageBoxButtons)0, (MessageBoxIcon)48);
		}
		return result;
	}

	public static void SaveData(string filename)
	{
		Field.Plot.SaveColors();
		XmlSerializer xmlSerializer = new XmlSerializer(typeof(OptionsField));
		TextWriter textWriter = new StreamWriter(filename);
		string writerProductVersion = Application.ProductVersion.Replace(", ", ".");
		Field.WriterProductVersion = writerProductVersion;
		xmlSerializer.Serialize(textWriter, Field);
		textWriter.Close();
		((IDisposable)textWriter)?.Dispose();
		if (xmlSerializer is IDisposable disposable)
		{
			disposable.Dispose();
		}
	}

	[return: MarshalAs(UnmanagedType.U1)]
	public unsafe static bool LoadData(string filename, [MarshalAs(UnmanagedType.U1)] bool fShow)
	{
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		bool result = false;
		if (File.Exists(filename))
		{
			if (VerifyProductVersion(filename))
			{
				XmlSerializer xmlSerializer = new XmlSerializer(typeof(OptionsField));
				TextReader textReader = new StreamReader(filename);
				Field = xmlSerializer.Deserialize(textReader) as OptionsField;
				textReader.Close();
				Field.PostLoad();
				result = true;
				textReader.Close();
				((IDisposable)textReader)?.Dispose();
				if (xmlSerializer is IDisposable disposable)
				{
					disposable.Dispose();
				}
			}
			else if (fShow)
			{
				string text = Application.ProductVersion.Replace(", ", ".");
				MessageBox.Show(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat("The version of the selected file is not compatible with this application.\n" + "The options cannot be loaded automatically.\n\n", "File:    "), filename), "\n"), "Version: "), TestField.WriterProductVersion), "\n\n"), "Version of this application: "), text), "Warning", (MessageBoxButtons)0, (MessageBoxIcon)48);
			}
		}
		else
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj);
			global::_003CModule_003E.std_002Ebasic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D(&obj, 3, 1);
			try
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj2);
				basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* ptr = global::_003CModule_003E.HOLM_002EMiscHelper_002EStringToStd(&obj2, string.Concat(string.Concat("Options::LoadData - File Does not exist: " + filename, " In "), Directory.GetCurrentDirectory()));
				try
				{
					global::_003CModule_003E.std_002Eoperator_003C_003C_003Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_0020_003E(global::_003CModule_003E.std_002Eoperator_003C_003C_003Cchar_002Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_002Cclass_0020std_003A_003Aallocator_003Cchar_003E_0020_003E(global::_003CModule_003E.std_002Eoperator_003C_003C_003Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_0020_003E((basic_ostream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 8)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref global::_003CModule_003E._003F_003F_C_0040_08KFJDDMMO_0040WARNING_003F5_003F_0024AA_0040)), ptr), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref global::_003CModule_003E._003F_003F_C_0040_01EEMJAFIK_0040_003F6_003F_0024AA_0040));
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
		if (Field.Misc == null)
		{
			Field.Misc = new MiscOptions();
		}
		return result;
	}

	[return: MarshalAs(UnmanagedType.U1)]
	public static bool LoadData(string filename)
	{
		return LoadData(filename, fShow: true);
	}

	public static void Reset()
	{
		if (Field is IDisposable disposable)
		{
			disposable.Dispose();
		}
		Field = new OptionsField();
		Field.Init();
	}

	public static void SaveAsDialog()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Invalid comparison between Unknown and I4
		SaveFileDialog val = new SaveFileDialog();
		((FileDialog)val).Filter = "XML (*.xml)|*.xml|" + "All Files (*.*)|*.*";
		((FileDialog)val).Title = "Save Options to file";
		if ((int)((CommonDialog)val).ShowDialog() == 1)
		{
			SaveData(((FileDialog)val).FileName);
		}
		((IDisposable)val)?.Dispose();
	}

	[return: MarshalAs(UnmanagedType.U1)]
	public static bool LoadAsDialog()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Invalid comparison between Unknown and I4
		OpenFileDialog val = new OpenFileDialog();
		((FileDialog)val).Filter = "XML (*.xml)|*.xml|" + "All Files (*.*)|*.*";
		((FileDialog)val).Title = "Load Options";
		bool result = false;
		if ((int)((CommonDialog)val).ShowDialog() == 1)
		{
			result = LoadData(((FileDialog)val).FileName, fShow: true);
		}
		((IDisposable)val)?.Dispose();
		return result;
	}
}
