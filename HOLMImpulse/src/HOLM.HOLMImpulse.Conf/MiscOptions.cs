using System.IO;
using System.Windows.Forms;

namespace HOLM.HOLMImpulse.Conf;

public class MiscOptions
{
	public bool ShowToolTips;

	public bool CheckForUpdate;

	public bool SaveMeasureWaves;

	public int ASlotNr;

	public int BSlotNr;

	public int CSlotNr;

	public int WaveFormat;

	public string SaveMeasureOutput;

	public string SaveMeasureRec;

	public string SaveMeasureCorr;

	public MiscOptions()
	{
		ShowToolTips = true;
		CheckForUpdate = true;
		ASlotNr = 0;
		BSlotNr = 1;
		CSlotNr = 2;
		WaveFormat = 0;
		SaveMeasureWaves = false;
		string fullName = Directory.GetParent(Application.UserAppDataPath).FullName;
		SaveMeasureOutput = fullName + "\\Output.wav";
		string fullName2 = Directory.GetParent(Application.UserAppDataPath).FullName;
		SaveMeasureRec = fullName2 + "\\Recording.wav";
		string fullName3 = Directory.GetParent(Application.UserAppDataPath).FullName;
		SaveMeasureCorr = fullName3 + "\\Correlation.wav";
	}

	public void PostLoad()
	{
		if (SaveMeasureOutput == null || SaveMeasureOutput.Length < 1)
		{
			string fullName = Directory.GetParent(Application.UserAppDataPath).FullName;
			SaveMeasureOutput = fullName + "\\Output.wav";
		}
		if (SaveMeasureRec == null || SaveMeasureRec.Length < 1)
		{
			string fullName2 = Directory.GetParent(Application.UserAppDataPath).FullName;
			SaveMeasureRec = fullName2 + "\\Recording.wav";
		}
		if (SaveMeasureCorr == null || SaveMeasureCorr.Length < 1)
		{
			string fullName3 = Directory.GetParent(Application.UserAppDataPath).FullName;
			SaveMeasureCorr = fullName3 + "\\Correlation.wav";
		}
	}
}
