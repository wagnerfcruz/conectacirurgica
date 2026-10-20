using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security;
using System.Threading;
using System.Windows.Forms;
using _003CCppImplementationDetails_003E;
using _003CCrtImplementationDetails_003E;
using HOLM;
using HOLM.Analyze;
using HOLM.Filter;
using HOLM.Graphics;
using HOLM.HOLMImpulse;
using HOLM.Measure;
using HOLM.MeasureGraphics;
using HOLM.PAudioII;
using HOLM.WaveImExport;
using std;

internal class _003CModule_003E
{
	internal static _0024ArrayType_0024_0024_0024BY00Q6MPBXXZ _003FA0xf084536d_002E__xc_mp_z/* Not supported: data(00 00 00 00) */;

	[FixedAddressValueType]
	internal static int _003FUninitialized_0040CurrentDomain_0040_003CCrtImplementationDetails_003E_0040_0040_0024_0024Q2HA;

	internal unsafe static delegate*<void> _003FA0xf084536d_002E_003FUninitialized_0024initializer_0024_0040CurrentDomain_0040_003CCrtImplementationDetails_003E_0040_0040_0024_0024Q2P6MXXZA/* Not supported: data(08 00 00 06) */;

	internal static _0024ArrayType_0024_0024_0024BY00Q6MPBXXZ _003FA0xf084536d_002E__xi_vt_a/* Not supported: data(00 00 00 00) */;

	[FixedAddressValueType]
	internal static Progress.State _003FInitializedPerAppDomain_0040CurrentDomain_0040_003CCrtImplementationDetails_003E_0040_0040_0024_0024Q2W4State_0040Progress_00402_0040A;

	internal unsafe static delegate*<void> _003FA0xf084536d_002E_003FInitializedPerAppDomain_0024initializer_0024_0040CurrentDomain_0040_003CCrtImplementationDetails_003E_0040_0040_0024_0024Q2P6MXXZA/* Not supported: data(0D 00 00 06) */;

	[FixedAddressValueType]
	internal static bool _003FIsDefaultDomain_0040CurrentDomain_0040_003CCrtImplementationDetails_003E_0040_0040_0024_0024Q2_NA;

	internal unsafe static delegate*<void> _003FA0xf084536d_002E_003FIsDefaultDomain_0024initializer_0024_0040CurrentDomain_0040_003CCrtImplementationDetails_003E_0040_0040_0024_0024Q2P6MXXZA/* Not supported: data(09 00 00 06) */;

	internal static _0024ArrayType_0024_0024_0024BY00Q6MPBXXZ _003FA0xf084536d_002E__xc_ma_a/* Not supported: data(00 00 00 00) */;

	[FixedAddressValueType]
	internal static Progress.State _003FInitializedNative_0040CurrentDomain_0040_003CCrtImplementationDetails_003E_0040_0040_0024_0024Q2W4State_0040Progress_00402_0040A;

	internal unsafe static delegate*<void> _003FA0xf084536d_002E_003FInitializedNative_0024initializer_0024_0040CurrentDomain_0040_003CCrtImplementationDetails_003E_0040_0040_0024_0024Q2P6MXXZA/* Not supported: data(0B 00 00 06) */;

	[FixedAddressValueType]
	internal static int _003FInitialized_0040CurrentDomain_0040_003CCrtImplementationDetails_003E_0040_0040_0024_0024Q2HA;

	internal unsafe static delegate*<void> _003FA0xf084536d_002E_003FInitialized_0024initializer_0024_0040CurrentDomain_0040_003CCrtImplementationDetails_003E_0040_0040_0024_0024Q2P6MXXZA/* Not supported: data(07 00 00 06) */;

	internal static _0024ArrayType_0024_0024_0024BY00Q6MPBXXZ _003FA0xf084536d_002E__xc_ma_z/* Not supported: data(00 00 00 00) */;

	[FixedAddressValueType]
	internal static Progress.State _003FInitializedVtables_0040CurrentDomain_0040_003CCrtImplementationDetails_003E_0040_0040_0024_0024Q2W4State_0040Progress_00402_0040A;

	internal unsafe static delegate*<void> _003FA0xf084536d_002E_003FInitializedVtables_0024initializer_0024_0040CurrentDomain_0040_003CCrtImplementationDetails_003E_0040_0040_0024_0024Q2P6MXXZA/* Not supported: data(0A 00 00 06) */;

	internal static _0024ArrayType_0024_0024_0024BY00Q6MPBXXZ _003FA0xf084536d_002E__xi_vt_z/* Not supported: data(00 00 00 00) */;

	[FixedAddressValueType]
	internal static Progress.State _003FInitializedPerProcess_0040CurrentDomain_0040_003CCrtImplementationDetails_003E_0040_0040_0024_0024Q2W4State_0040Progress_00402_0040A;

	internal unsafe static delegate*<void> _003FA0xf084536d_002E_003FInitializedPerProcess_0024initializer_0024_0040CurrentDomain_0040_003CCrtImplementationDetails_003E_0040_0040_0024_0024Q2P6MXXZA/* Not supported: data(0C 00 00 06) */;

	internal static bool _003FInitializedPerProcess_0040DefaultDomain_0040_003CCrtImplementationDetails_003E_0040_00402_NA/*Field data (rva=0x1f689f) could not be foundin any section!*/;

	internal static bool _003FEntered_0040DefaultDomain_0040_003CCrtImplementationDetails_003E_0040_00402_NA/*Field data (rva=0x1f689c) could not be foundin any section!*/;

	internal static bool _003FInitializedNative_0040DefaultDomain_0040_003CCrtImplementationDetails_003E_0040_00402_NA/*Field data (rva=0x1f689d) could not be foundin any section!*/;

	internal static int _003FCount_0040AllDomains_0040_003CCrtImplementationDetails_003E_0040_00402HA/*Field data (rva=0x1f6898) could not be foundin any section!*/;

	internal static TriBool.State _003FhasNative_0040DefaultDomain_0040_003CCrtImplementationDetails_003E_0040_00400W4State_0040TriBool_00402_0040A/* Not supported: data() */;

	internal static TriBool.State _003FhasPerProcess_0040DefaultDomain_0040_003CCrtImplementationDetails_003E_0040_00400W4State_0040TriBool_00402_0040A/* Not supported: data() */;

	internal static bool _003FInitializedNativeFromCCTOR_0040DefaultDomain_0040_003CCrtImplementationDetails_003E_0040_00402_NA/*Field data (rva=0x1f689e) could not be foundin any section!*/;

	internal static _0024ArrayType_0024_0024_0024BY00Q6MPBXXZ _003FA0xf084536d_002E__xc_mp_a/* Not supported: data(00 00 00 00) */;

	public unsafe static int** __unep_0040_003FDoNothing_0040DefaultDomain_0040_003CCrtImplementationDetails_003E_0040_0040_0024_0024FCGJPAX_0040Z/* Not supported: data(21 94 4C 00) */;

	public unsafe static int** __unep_0040_003F_UninitializeDefaultDomain_0040LanguageSupport_0040_003CCrtImplementationDetails_003E_0040_0040_0024_0024FCGJPAX_0040Z/* Not supported: data(9D 95 4C 00) */;

	[FixedAddressValueType]
	internal static uint __exit_list_size_app_domain;

	[FixedAddressValueType]
	internal unsafe static delegate*<void>* __onexitbegin_app_domain;

	internal static uint _003FA0xc4f9df4a_002E__exit_list_size/*Field data (rva=0x1f69cc) could not be foundin any section!*/;

	[FixedAddressValueType]
	internal unsafe static delegate*<void>* __onexitend_app_domain;

	internal unsafe static delegate*<void>* _003FA0xc4f9df4a_002E__onexitbegin_m/*Field data (rva=0x1f69c4) could not be foundin any section!*/;

	internal unsafe static delegate*<void>* _003FA0xc4f9df4a_002E__onexitend_m/*Field data (rva=0x1f69c8) could not be foundin any section!*/;

	[FixedAddressValueType]
	internal unsafe static void* _003F_lock_0040AtExitLock_0040_003CCrtImplementationDetails_003E_0040_0040_0024_0024Q0PAXA;

	[FixedAddressValueType]
	internal static int _003F_ref_count_0040AtExitLock_0040_003CCrtImplementationDetails_003E_0040_0040_0024_0024Q0HA;

	internal static _0024ArrayType_0024_0024_0024BY0P_0040_0024_0024CBD _003F_003F_C_0040_0P_0040GHFPNOJB_0040bad_003F5allocation_003F_0024AA_0040/* Not supported: data(62 61 64 20 61 6C 6C 6F 63 61 74 69 6F 6E 00) */;

	internal static _s__RTTICompleteObjectLocator _003F_003F_R4out_of_range_0040std_0040_00406B_0040/* Not supported: data(00 00 00 00 00 00 00 00 00 00 00 00 2C 59 5F 00 98 75 5E 00) */;

	internal static _0024_TypeDescriptor_0024_extraBytes_23 _003F_003F_R0_003FAVout_of_range_0040std_0040_0040_00408/* Not supported: data(9C 12 4F 00 00 00 00 00 2E 3F 41 56 6F 75 74 5F 6F 66 5F 72 61 6E 67 65 40 73 74 64 40 40 00) */;

	internal static _0024ArrayType_0024_0024_0024BY02Q6AXXZ _003F_003F_7bad_alloc_0040std_0040_00406B_0040/* Not supported: data(70 10 40 00 9E 8B 4C 00 84 75 5E 00) */;

	internal static _s__RTTIBaseClassDescriptor2 _003F_003F_R1A_0040_003F0A_0040EA_0040exception_0040std_0040_00408/* Not supported: data(10 59 5F 00 00 00 00 00 00 00 00 00 FF FF FF FF 00 00 00 00 40 00 00 00 6C 76 5E 00) */;

	internal static _s__RTTIBaseClassDescriptor2 _003F_003F_R1A_0040_003F0A_0040EA_0040logic_error_0040std_0040_00408/* Not supported: data(4C 59 5F 00 01 00 00 00 00 00 00 00 FF FF FF FF 00 00 00 00 40 00 00 00 E8 75 5E 00) */;

	internal static _0024_TypeDescriptor_0024_extraBytes_20 _003F_003F_R0_003FAVexception_0040std_0040_0040_00408/* Not supported: data(9C 12 4F 00 00 00 00 00 2E 3F 41 56 65 78 63 65 70 74 69 6F 6E 40 73 74 64 40 40 00) */;

	internal static _0024_s__RTTIBaseClassArray_0024_extraBytes_8 _003F_003F_R2bad_alloc_0040std_0040_00408/* Not supported: data(84 76 5E 00 50 76 5E 00 00) */;

	internal static _s__RTTIBaseClassDescriptor2 _003F_003F_R1A_0040_003F0A_0040EA_0040bad_alloc_0040std_0040_00408/* Not supported: data(6C 59 5F 00 01 00 00 00 00 00 00 00 FF FF FF FF 00 00 00 00 40 00 00 00 34 76 5E 00) */;

	internal static _0024_s__RTTIBaseClassArray_0024_extraBytes_12 _003F_003F_R2out_of_range_0040std_0040_00408/* Not supported: data(B8 75 5E 00 04 76 5E 00 50 76 5E 00 00) */;

	internal static _0024ArrayType_0024_0024_0024BY02Q6AXXZ _003F_003F_7logic_error_0040std_0040_00406B_0040/* Not supported: data(50 11 40 00 D0 D9 43 00 20 76 5E 00) */;

	internal static _s__RTTIClassHierarchyDescriptor _003F_003F_R3bad_alloc_0040std_0040_00408/* Not supported: data(00 00 00 00 00 00 00 00 02 00 00 00 44 76 5E 00) */;

	internal static _0024ArrayType_0024_0024_0024BY02Q6AXXZ _003F_003F_7out_of_range_0040std_0040_00406B_0040/* Not supported: data(40 12 40 00 D0 D9 43 00 FF FF FF FF) */;

	internal static _0024_TypeDescriptor_0024_extraBytes_20 _003F_003F_R0_003FAVbad_alloc_0040std_0040_0040_00408/* Not supported: data(9C 12 4F 00 00 00 00 00 2E 3F 41 56 62 61 64 5F 61 6C 6C 6F 63 40 73 74 64 40 40 00) */;

	internal static _s__RTTICompleteObjectLocator _003F_003F_R4logic_error_0040std_0040_00406B_0040/* Not supported: data(00 00 00 00 00 00 00 00 00 00 00 00 4C 59 5F 00 E8 75 5E 00) */;

	internal static _0024_s__RTTIBaseClassArray_0024_extraBytes_4 _003F_003F_R2exception_0040std_0040_00408/* Not supported: data(50 76 5E 00 00) */;

	internal static _s__RTTIClassHierarchyDescriptor _003F_003F_R3exception_0040std_0040_00408/* Not supported: data(00 00 00 00 00 00 00 00 01 00 00 00 7C 76 5E 00) */;

	internal static _s__RTTIClassHierarchyDescriptor _003F_003F_R3out_of_range_0040std_0040_00408/* Not supported: data(00 00 00 00 00 00 00 00 03 00 00 00 A8 75 5E 00) */;

	internal static _0024_s__RTTIBaseClassArray_0024_extraBytes_8 _003F_003F_R2logic_error_0040std_0040_00408/* Not supported: data(04 76 5E 00 50 76 5E 00 00) */;

	internal static _s__RTTIClassHierarchyDescriptor _003F_003F_R3logic_error_0040std_0040_00408/* Not supported: data(00 00 00 00 00 00 00 00 02 00 00 00 F8 75 5E 00) */;

	internal static _0024_TypeDescriptor_0024_extraBytes_22 _003F_003F_R0_003FAVlogic_error_0040std_0040_0040_00408/* Not supported: data(9C 12 4F 00 00 00 00 00 2E 3F 41 56 6C 6F 67 69 63 5F 65 72 72 6F 72 40 73 74 64 40 40 00) */;

	internal static _s__RTTICompleteObjectLocator _003F_003F_R4bad_alloc_0040std_0040_00406B_0040/* Not supported: data(00 00 00 00 00 00 00 00 00 00 00 00 6C 59 5F 00 34 76 5E 00) */;

	internal unsafe static sbyte* std_002E_003FA0xebe6e0bc_002E_bad_alloc_Message/* Not supported: data(68 13 4F 00) */;

	internal unsafe static _Fac_node* std_002E_003FA0xebe6e0bc_002E_Fac_head/*Field data (rva=0x1f6e34) could not be foundin any section!*/;

	internal static _s__RTTIBaseClassDescriptor2 _003F_003F_R1A_0040_003F0A_0040EA_0040out_of_range_0040std_0040_00408/* Not supported: data(2C 59 5F 00 02 00 00 00 00 00 00 00 FF FF FF FF 00 00 00 00 40 00 00 00 98 75 5E 00) */;

	internal static _0024ArrayType_0024_0024_0024BY01_0024_0024CBD _003F_003F_C_0040_01GFHCPBMG_0040C_003F_0024AA_0040/* Not supported: data(43 00) */;

	internal static _0024ArrayType_0024_0024_0024BY01_0024_0024CBD _003F_003F_C_0040_01GBGANLPD_00400_003F_0024AA_0040/* Not supported: data(30 00) */;

	internal static _0024ArrayType_0024_0024_0024BY01_0024_0024CBD _003F_003F_C_0040_01HIHLOKLC_00401_003F_0024AA_0040/* Not supported: data(31 00) */;

	internal static _0024ArrayType_0024_0024_0024BY01_0024_0024CBD _003F_003F_C_0040_01FDFGLJHB_00402_003F_0024AA_0040/* Not supported: data(32 00) */;

	internal static _0024ArrayType_0024_0024_0024BY01_0024_0024CBD _003F_003F_C_0040_01EKENIIDA_00403_003F_0024AA_0040/* Not supported: data(33 00) */;

	internal static _0024ArrayType_0024_0024_0024BY01_0024_0024CBD _003F_003F_C_0040_01FAMBOPH_00404_003F_0024AA_0040/* Not supported: data(34 00) */;

	internal static _0024ArrayType_0024_0024_0024BY01_0024_0024CBD _003F_003F_C_0040_01BMBHCPLG_00405_003F_0024AA_0040/* Not supported: data(35 00) */;

	internal static _0024ArrayType_0024_0024_0024BY01_0024_0024CBD _003F_003F_C_0040_01DHDKHMHF_00406_003F_0024AA_0040/* Not supported: data(36 00) */;

	internal static _0024ArrayType_0024_0024_0024BY01_0024_0024CBD _003F_003F_C_0040_01COCBENDE_00407_003F_0024AA_0040/* Not supported: data(37 00) */;

	internal static _0024ArrayType_0024_0024_0024BY01_0024_0024CBD _003F_003F_C_0040_01KJLJFBPL_00408_003F_0024AA_0040/* Not supported: data(38 00) */;

	internal static _0024ArrayType_0024_0024_0024BY01_0024_0024CBD _003F_003F_C_0040_01LAKCGALK_00409_003F_0024AA_0040/* Not supported: data(39 00) */;

	internal static _0024ArrayType_0024_0024_0024BY01_0024_0024CBD _003F_003F_C_0040_01FHEEJDEE_0040A_003F_0024AA_0040/* Not supported: data(41 00) */;

	internal static _0024ArrayType_0024_0024_0024BY01_0024_0024CBD _003F_003F_C_0040_01HMGJMAIH_0040B_003F_0024AA_0040/* Not supported: data(42 00) */;

	internal static _0024ArrayType_0024_0024_0024BY01_0024_0024CBD _003F_003F_C_0040_01CKDDGHAB_0040D_003F_0024AA_0040/* Not supported: data(44 00) */;

	internal static _0024ArrayType_0024_0024_0024BY01_0024_0024CBD _003F_003F_C_0040_01DDCIFGEA_0040E_003F_0024AA_0040/* Not supported: data(45 00) */;

	internal static _0024ArrayType_0024_0024_0024BY01_0024_0024CBD _003F_003F_C_0040_01BIAFAFID_0040F_003F_0024AA_0040/* Not supported: data(46 00) */;

	internal static _0024ArrayType_0024_0024_0024BY0BD_0040_0024_0024CBD _003F_003F_C_0040_0BD_0040CPFABDBC_0040HOLMFpgaController_003F_0024AA_0040/* Not supported: data(48 4F 4C 4D 46 70 67 61 43 6F 6E 74 72 6F 6C 6C 65 72 00) */;

	internal static _0024ArrayType_0024_0024_0024BY08_0024_0024CBD _003F_003F_C_0040_08LKNALPII_0040DSPreLab_003F_0024AA_0040/* Not supported: data(44 53 50 72 65 4C 61 62 00) */;

	internal static _0024ArrayType_0024_0024_0024BY0BA_0040_0024_0024CBD _003F_003F_C_0040_0BA_0040MFILEGDE_0040DEMO_003F5_003F9_003F5DSPreLab_003F_0024AA_0040/* Not supported: data(44 45 4D 4F 20 2D 20 44 53 50 72 65 4C 61 62 00) */;

	internal static _0024ArrayType_0024_0024_0024BY01_0024_0024CBD _003F_003F_C_0040_01EEMJAFIK_0040_003F6_003F_0024AA_0040/* Not supported: data(0A 00) */;

	internal static _0024ArrayType_0024_0024_0024BY04_0024_0024CBD _003F_003F_C_0040_04OAFLPOMH_0040_003F_0024FN_003F5_003F_0024DN_003F5_003F_0024AA_0040/* Not supported: data(5D 20 3D 20 00) */;

	internal static _0024ArrayType_0024_0024_0024BY0BI_0040_0024_0024CBD _003F_003F_C_0040_0BI_0040JEOGDFAK_0040HOLMImpulse_003F3_003F3main_003F5args_003F_0024FL_003F_0024AA_0040/* Not supported: data(48 4F 4C 4D 49 6D 70 75 6C 73 65 3A 3A 6D 61 69 6E 20 61 72 67 73 5B 00) */;

	internal static _0024ArrayType_0024_0024_0024BY08_0024_0024CBD _003F_003F_C_0040_08ECDPJEFA_0040INFO_003F5_003F5_003F5_003F5_003F_0024AA_0040/* Not supported: data(49 4E 46 4F 20 20 20 20 00) */;

	internal static _0024ArrayType_0024_0024_0024BY0CK_0040_0024_0024CBD _003F_003F_C_0040_0CK_0040PGEHFPNJ_0040HOLMImpulse_003F3_003F3main_003F5_003F9_003F5Top_003F5Level_003F5Ex_0040/* Not supported: data(48 4F 4C 4D 49 6D 70 75 6C 73 65 3A 3A 6D 61 69 6E 20 2D 20 54 6F 70 20 4C 65 76 65 6C 20 45 78 63 65 70 74 69 6F 6E 3A 0A 00) */;

	internal static _0024ArrayType_0024_0024_0024BY08_0024_0024CBD _003F_003F_C_0040_08KFJDDMMO_0040WARNING_003F5_003F_0024AA_0040/* Not supported: data(57 41 52 4E 49 4E 47 20 00) */;

	internal static double HOLM_002EMeasure_002E_003FA0x2b63ed34_002ESPEED_OF_SOUND/* Not supported: data(00 00 00 00 00 80 75 40) */;

	internal static double HOLM_002EMeasure_002E_003FA0x2b63ed34_002EMILLISEC_TO_CM/*Field data (rva=0x86c990) could not be foundin any section!*/;

	internal static double HOLM_002EMeasure_002E_003FA0x2b63ed34_002ESEC_TO_CM/* Not supported: data(00 00 00 00 00 CC E0 40) */;

	internal static double HOLM_002EMeasure_002E_003FA0x2b63ed34_002ECM_TO_SEC/* Not supported: data(E7 E8 1A 35 5B 7B FE 3E) */;

	internal static double HOLM_002EMeasure_002E_003FA0x2b63ed34_002EMICROSEC_TO_CM/*Field data (rva=0x86c988) could not be foundin any section!*/;

	internal static float HOLM_002EMath_002E_003FA0x2b63ed34_002ERadToDeg_F/*Field data (rva=0x86c980) could not be foundin any section!*/;

	internal static float HOLM_002EMath_002E_003FA0x2b63ed34_002EPI_F/*Field data (rva=0x86c95c) could not be foundin any section!*/;

	internal static double HOLM_002EMath_002E_003FA0x2b63ed34_002EHALFPI/*Field data (rva=0x86c978) could not be foundin any section!*/;

	internal static double HOLM_002EMath_002E_003FA0x2b63ed34_002ERadToDeg/*Field data (rva=0x86c970) could not be foundin any section!*/;

	internal static double HOLM_002EMath_002E_003FA0x2b63ed34_002ESQRT2/*Field data (rva=0x86c968) could not be foundin any section!*/;

	internal static double HOLM_002EMath_002E_003FA0x2b63ed34_002EDegToRad/*Field data (rva=0x86c960) could not be foundin any section!*/;

	internal static float HOLM_002EMath_002E_003FA0x2b63ed34_002EDegToRad_F/*Field data (rva=0x86c958) could not be foundin any section!*/;

	internal static float HOLM_002EMath_002E_003FA0x2b63ed34_002ESQRT2_F/*Field data (rva=0x86c784) could not be foundin any section!*/;

	internal static double HOLM_002EMath_002E_003FA0x2b63ed34_002ETWOPI/*Field data (rva=0x86c950) could not be foundin any section!*/;

	internal static double HOLM_002EMath_002E_003FA0x2b63ed34_002EPI/*Field data (rva=0x86c948) could not be foundin any section!*/;

	internal static _0024ArrayType_0024_0024_0024BY0BA_0040_0024_0024CBV_003F_0024basic_string_0040DU_003F_0024char_traits_0040D_0040std_0040_0040V_003F_0024allocator_0040D_00402_0040_0040std_0040_0040 HOLM_002EMiscHelper_002E_003FA0x2b63ed34_002EHEXSTRINGARRAY/*Field data (rva=0x86c788) could not be foundin any section!*/;

	internal static basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E HOLM_002EMiscHelper_002E_003FA0x2b63ed34_002EHOLM_WINDOW_DSPreLab_DEMO/*Field data (rva=0x86c768) could not be foundin any section!*/;

	internal static basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E HOLM_002EMiscHelper_002E_003FA0x2b63ed34_002EHOLM_WINDOW_FPGA_CTRL/*Field data (rva=0x86c74c) could not be foundin any section!*/;

	internal static basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E HOLM_002EMiscHelper_002E_003FA0x2b63ed34_002EHOLM_WINDOW_DSPreLab/*Field data (rva=0x86c730) could not be foundin any section!*/;

	internal unsafe static delegate*<void> HOLM_002EMiscHelper_002E_003FA0x2b63ed34_002EHOLM_WINDOW_DSPreLab_0024initializer_0024/* Not supported: data(4B 00 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EMath_002E_003FA0x2b63ed34_002EDegToRad_0024initializer_0024/* Not supported: data(57 00 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EMiscHelper_002E_003FA0x2b63ed34_002EHOLM_WINDOW_DSPreLab_DEMO_0024initializer_0024/* Not supported: data(4D 00 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EMath_002E_003FA0x2b63ed34_002ERadToDeg_F_0024initializer_0024/* Not supported: data(56 00 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EMeasure_002E_003FA0x2b63ed34_002EMICROSEC_TO_CM_0024initializer_0024/* Not supported: data(5A 00 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EMath_002E_003FA0x2b63ed34_002ERadToDeg_0024initializer_0024/* Not supported: data(55 00 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EMath_002E_003FA0x2b63ed34_002EDegToRad_F_0024initializer_0024/* Not supported: data(58 00 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EMath_002E_003FA0x2b63ed34_002ESQRT2_F_0024initializer_0024/* Not supported: data(54 00 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EMath_002E_003FA0x2b63ed34_002ETWOPI_0024initializer_0024/* Not supported: data(51 00 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EMiscHelper_002E_003FA0x2b63ed34_002EHOLM_WINDOW_FPGA_CTRL_0024initializer_0024/* Not supported: data(49 00 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EMath_002E_003FA0x2b63ed34_002EHALFPI_0024initializer_0024/* Not supported: data(52 00 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EMath_002E_003FA0x2b63ed34_002ESQRT2_0024initializer_0024/* Not supported: data(53 00 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EMiscHelper_002E_003FA0x2b63ed34_002EHEXSTRINGARRAY_0024initializer_0024/* Not supported: data(47 00 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EMath_002E_003FA0x2b63ed34_002EPI_F_0024initializer_0024/* Not supported: data(50 00 00 06) */;

	internal unsafe static sbyte* std_002E_003FA0x2b63ed34_002E_bad_alloc_Message/* Not supported: data(68 13 4F 00) */;

	internal unsafe static delegate*<void> HOLM_002EMath_002E_003FA0x2b63ed34_002EPI_0024initializer_0024/* Not supported: data(4F 00 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EMeasure_002E_003FA0x2b63ed34_002EMILLISEC_TO_CM_0024initializer_0024/* Not supported: data(59 00 00 06) */;

	internal static _0024ArrayType_0024_0024_0024BY07_0024_0024CBD _003F_003F_C_0040_07EBPGIHEF_00401_003F41_003F41_003F41_003F_0024AA_0040/* Not supported: data(31 2E 31 2E 31 2E 31 00) */;

	internal static _0024ArrayType_0024_0024_0024BY0BH_0040_0024_0024CBD _003F_003F_C_0040_0BH_0040KPHMGOCK_0040HOLMImpulseOptions_003F4xml_003F_0024AA_0040/* Not supported: data(48 4F 4C 4D 49 6D 70 75 6C 73 65 4F 70 74 69 6F 6E 73 2E 78 6D 6C 00) */;

	internal static _0024ArrayType_0024_0024_0024BY0BC_0040_0024_0024CB_W _003F_003F_C_0040_1CE_0040JMJFEPPE_0040_003F_0024AAM_003F_0024AAe_003F_0024AAa_003F_0024AAs_003F_0024AAA_003F_0024AAu_003F_0024AAt_003F_0024AAo_003F_0024AAs_003F_0024AAa_003F_0024AAv_003F_0024AAe_003F_0024AAd_003F_0024AA_003F4_003F_0024AAz_003F_0024AAi_003F_0024AAp_003F_0024AA_003F_0024AA_0040/* Not supported: data(4D 00 65 00 61 00 73 00 41 00 75 00 74 00 6F 00 73 00 61 00 76 00 65 00 64 00 2E 00 7A 00 69 00 70 00 00 00) */;

	internal static _0024ArrayType_0024_0024_0024BY0BC_0040_0024_0024CBD _003F_003F_C_0040_0BC_0040COMDONFP_0040MeasAutosaved_003F4hlm_003F_0024AA_0040/* Not supported: data(4D 65 61 73 41 75 74 6F 73 61 76 65 64 2E 68 6C 6D 00) */;

	internal static _0024ArrayType_0024_0024_0024BY0BC_0040_0024_0024CBD _003F_003F_C_0040_0BC_0040JLNMFMDH_0040AutosavedObsolete_003F_0024AA_0040/* Not supported: data(41 75 74 6F 73 61 76 65 64 4F 62 73 6F 6C 65 74 65 00) */;

	internal static _0024ArrayType_0024_0024_0024BY0BD_0040_0024_0024CBD _003F_003F_C_0040_0BD_0040LOFKOGNA_0040CalibrationMic_003F4cal_003F_0024AA_0040/* Not supported: data(43 61 6C 69 62 72 61 74 69 6F 6E 4D 69 63 2E 63 61 6C 00) */;

	internal static _0024ArrayType_0024_0024_0024BY0BG_0040_0024_0024CBD _003F_003F_C_0040_0BG_0040GMNAFMJF_0040CalibrationDacAdc_003F4cal_003F_0024AA_0040/* Not supported: data(43 61 6C 69 62 72 61 74 69 6F 6E 44 61 63 41 64 63 2E 63 61 6C 00) */;

	internal static _0024ArrayType_0024_0024_0024BY0O_0040_0024_0024CBD _003F_003F_C_0040_0O_0040EONGOMGC_0040ChangeLog_003F4txt_003F_0024AA_0040/* Not supported: data(43 68 61 6E 67 65 4C 6F 67 2E 74 78 74 00) */;

	internal static _0024ArrayType_0024_0024_0024BY0L_0040_0024_0024CBD _003F_003F_C_0040_0L_0040NGLIAIJP_0040Issues_003F4txt_003F_0024AA_0040/* Not supported: data(49 73 73 75 65 73 2E 74 78 74 00) */;

	internal static _0024ArrayType_0024_0024_0024BY0M_0040_0024_0024CBD _003F_003F_C_0040_0M_0040HGMIFPO_0040LICENSE_003F4txt_003F_0024AA_0040/* Not supported: data(4C 49 43 45 4E 53 45 2E 74 78 74 00) */;

	internal static _0024ArrayType_0024_0024_0024BY0N_0040_0024_0024CBD _003F_003F_C_0040_0N_0040ONBJJBCP_0040_003F2MeasTmpList_003F_0024AA_0040/* Not supported: data(5C 4D 65 61 73 54 6D 70 4C 69 73 74 00) */;

	internal static _0024ArrayType_0024_0024_0024BY01_0024_0024CB_W _003F_003F_C_0040_13FPGAJAPJ_0040_003F_0024AA_003F2_003F_0024AA_003F_0024AA_0040/* Not supported: data(5C 00 00 00) */;

	internal static _0024ArrayType_0024_0024_0024BY01_0024_0024CBD _003F_003F_C_0040_01KICIPPFI_0040_003F2_003F_0024AA_0040/* Not supported: data(5C 00) */;

	internal static _0024ArrayType_0024_0024_0024BY01_0024_0024CBD _003F_003F_C_0040_01LFCBOECM_0040_003F4_003F_0024AA_0040/* Not supported: data(2E 00) */;

	internal static _0024ArrayType_0024_0024_0024BY0BH_0040_0024_0024CBD _003F_003F_C_0040_0BH_0040FHJFJEHI_0040_003F6_003F5Using_003F5default_003F5colors_003F_0024AA_0040/* Not supported: data(0A 20 55 73 69 6E 67 20 64 65 66 61 75 6C 74 20 63 6F 6C 6F 72 73 00) */;

	internal static _0024ArrayType_0024_0024_0024BY0CF_0040_0024_0024CBD _003F_003F_C_0040_0CF_0040EBDHKAIO_0040PlotOptions_003F3_003F3PostLoad_003F_0024CI_003F_0024CJ_003F5Exceptio_0040/* Not supported: data(50 6C 6F 74 4F 70 74 69 6F 6E 73 3A 3A 50 6F 73 74 4C 6F 61 64 28 29 20 45 78 63 65 70 74 69 6F 6E 3A 0A 20 00) */;

	internal static double HOLM_002EMeasure_002E_003FA0x11566818_002ESPEED_OF_SOUND/* Not supported: data(00 00 00 00 00 80 75 40) */;

	internal static double HOLM_002EMeasure_002E_003FA0x11566818_002EMILLISEC_TO_CM/*Field data (rva=0x86cd38) could not be foundin any section!*/;

	internal static double HOLM_002EMeasure_002E_003FA0x11566818_002ESEC_TO_CM/* Not supported: data(00 00 00 00 00 CC E0 40) */;

	internal static double HOLM_002EMeasure_002E_003FA0x11566818_002ECM_TO_SEC/* Not supported: data(E7 E8 1A 35 5B 7B FE 3E) */;

	internal static double HOLM_002EMeasure_002E_003FA0x11566818_002EMICROSEC_TO_CM/*Field data (rva=0x86cd30) could not be foundin any section!*/;

	internal static float HOLM_002EMath_002E_003FA0x11566818_002ERadToDeg_F/*Field data (rva=0x86cd2c) could not be foundin any section!*/;

	internal static float HOLM_002EMath_002E_003FA0x11566818_002EPI_F/*Field data (rva=0x86cd28) could not be foundin any section!*/;

	internal static double HOLM_002EMath_002E_003FA0x11566818_002EHALFPI/*Field data (rva=0x86cd20) could not be foundin any section!*/;

	internal static double HOLM_002EMath_002E_003FA0x11566818_002ERadToDeg/*Field data (rva=0x86cd18) could not be foundin any section!*/;

	internal static double HOLM_002EMath_002E_003FA0x11566818_002ESQRT2/*Field data (rva=0x86cd10) could not be foundin any section!*/;

	internal static double HOLM_002EMath_002E_003FA0x11566818_002EDegToRad/*Field data (rva=0x86cd08) could not be foundin any section!*/;

	internal static float HOLM_002EMath_002E_003FA0x11566818_002EDegToRad_F/*Field data (rva=0x86cd04) could not be foundin any section!*/;

	internal static float HOLM_002EMath_002E_003FA0x11566818_002ESQRT2_F/*Field data (rva=0x86cd00) could not be foundin any section!*/;

	internal static double HOLM_002EMath_002E_003FA0x11566818_002ETWOPI/*Field data (rva=0x86ccf8) could not be foundin any section!*/;

	internal static double HOLM_002EMath_002E_003FA0x11566818_002EPI/*Field data (rva=0x86ccf0) could not be foundin any section!*/;

	internal static _0024ArrayType_0024_0024_0024BY0BA_0040_0024_0024CBV_003F_0024basic_string_0040DU_003F_0024char_traits_0040D_0040std_0040_0040V_003F_0024allocator_0040D_00402_0040_0040std_0040_0040 HOLM_002EMiscHelper_002E_003FA0x11566818_002EHEXSTRINGARRAY/*Field data (rva=0x86cb30) could not be foundin any section!*/;

	internal static basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E HOLM_002EMiscHelper_002E_003FA0x11566818_002EHOLM_WINDOW_DSPreLab_DEMO/*Field data (rva=0x86cb14) could not be foundin any section!*/;

	internal static basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E HOLM_002EMiscHelper_002E_003FA0x11566818_002EHOLM_WINDOW_FPGA_CTRL/*Field data (rva=0x86caf8) could not be foundin any section!*/;

	internal static basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E HOLM_002EMiscHelper_002E_003FA0x11566818_002EHOLM_WINDOW_DSPreLab/*Field data (rva=0x86cadc) could not be foundin any section!*/;

	internal static basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x11566818_002ELICENSE/*Field data (rva=0x86cac0) could not be foundin any section!*/;

	internal static basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x11566818_002EOPTIONS_AUTOSAVE_FILENAME/*Field data (rva=0x86caa4) could not be foundin any section!*/;

	internal static basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x11566818_002EAUTOSAVE_MEAS_OBSOLETE/*Field data (rva=0x86ca88) could not be foundin any section!*/;

	internal static basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x11566818_002ECAL_MIC_FILENAME/*Field data (rva=0x86ca6c) could not be foundin any section!*/;

	internal static basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x11566818_002EAUTOSAVE_MEAS_OBSOLETE_DIR/*Field data (rva=0x86ca50) could not be foundin any section!*/;

	internal static double HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x11566818_002EMEASURE_LOW_REJECT_AMP/*Field data (rva=0x86ca48) could not be foundin any section!*/;

	internal static double HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x11566818_002EMEASURE_LOW_WARN_AMP/*Field data (rva=0x86ca40) could not be foundin any section!*/;

	internal static basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x11566818_002ECHANGELOG/*Field data (rva=0x86ca24) could not be foundin any section!*/;

	internal static basic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x11566818_002EAUTOSAVE_MEAS_FILENAME/*Field data (rva=0x86ca08) could not be foundin any section!*/;

	internal static basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x11566818_002ECAL_DACADC_FILENAME/*Field data (rva=0x86c9ec) could not be foundin any section!*/;

	internal static basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x11566818_002EISSUES/*Field data (rva=0x86c9d0) could not be foundin any section!*/;

	internal static basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x11566818_002ETMP_PATH_MEASLIST/*Field data (rva=0x86c9b4) could not be foundin any section!*/;

	internal static basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x11566818_002EOPTIONS_COMPAT_START/*Field data (rva=0x86c998) could not be foundin any section!*/;

	internal static basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E _003FA0x11566818_002E_003FUserDirectory_0040_003F1_003F_003FFilePath_0040Conf_0040HOLMImpulse_0040HOLM_0040_0040YA_003FAV_003F_0024basic_string_0040DU_003F_0024char_traits_0040D_0040std_0040_0040V_003F_0024allocator_0040D_00402_0040_0040std_0040_0040V56_0040_N_0040Z_00404V56_0040B/*Field data (rva=0x86eeac) could not be foundin any section!*/;

	internal static uint _003FA0x11566818_002E_003FOPTIONS_COMPAT_END_NUMBER_0040_003F1_003F_003FVerifyProductVersion_0040Options_0040Conf_0040HOLMImpulse_0040HOLM_0040_0040SM_NP_0024AAVString_0040System_0040_0040_0040Z_00404IB/*Field data (rva=0x86ef34) could not be foundin any section!*/;

	internal unsafe static delegate*<void> HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x11566818_002EMEASURE_LOW_WARN_AMP_0024initializer_0024/* Not supported: data(8B 00 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x11566818_002ECHANGELOG_0024initializer_0024/* Not supported: data(82 00 00 06) */;

	internal static uint _003FA0x11566818_002E_003F_0024S3_0040_003F1_003F_003FVerifyProductVersion_0040Options_0040Conf_0040HOLMImpulse_0040HOLM_0040_0040SM_NP_0024AAVString_0040System_0040_0040_0040Z_00404IA/*Field data (rva=0x86ef3c) could not be foundin any section!*/;

	internal unsafe static delegate*<void> HOLM_002EMiscHelper_002E_003FA0x11566818_002EHOLM_WINDOW_DSPreLab_0024initializer_0024/* Not supported: data(64 00 00 06) */;

	internal static basic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E _003FA0x11566818_002E_003FSystemDirectory_0040_003F1_003F_003FFilePath_0040Conf_0040HOLMImpulse_0040HOLM_0040_0040YA_003FAV_003F_0024basic_string_0040_WU_003F_0024char_traits_0040_W_0040std_0040_0040V_003F_0024allocator_0040_W_00402_0040_0040std_0040_0040V56_0040_N_0040Z_00404V56_0040B/*Field data (rva=0x86ef04) could not be foundin any section!*/;

	internal unsafe static delegate*<void> HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x11566818_002EISSUES_0024initializer_0024/* Not supported: data(84 00 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x11566818_002EOPTIONS_COMPAT_START_0024initializer_0024/* Not supported: data(74 00 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EMath_002E_003FA0x11566818_002EDegToRad_0024initializer_0024/* Not supported: data(70 00 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EMiscHelper_002E_003FA0x11566818_002EHOLM_WINDOW_DSPreLab_DEMO_0024initializer_0024/* Not supported: data(66 00 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x11566818_002ECAL_DACADC_FILENAME_0024initializer_0024/* Not supported: data(80 00 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x11566818_002EOPTIONS_AUTOSAVE_FILENAME_0024initializer_0024/* Not supported: data(76 00 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EMath_002E_003FA0x11566818_002ERadToDeg_F_0024initializer_0024/* Not supported: data(6F 00 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x11566818_002EAUTOSAVE_MEAS_OBSOLETE_0024initializer_0024/* Not supported: data(7A 00 00 06) */;

	internal static basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E _003FA0x11566818_002E_003FSystemDirectory_0040_003F1_003F_003FFilePath_0040Conf_0040HOLMImpulse_0040HOLM_0040_0040YA_003FAV_003F_0024basic_string_0040DU_003F_0024char_traits_0040D_0040std_0040_0040V_003F_0024allocator_0040D_00402_0040_0040std_0040_0040V56_0040_N_0040Z_00404V56_0040B/*Field data (rva=0x86eec8) could not be foundin any section!*/;

	internal unsafe static delegate*<void> HOLM_002EMeasure_002E_003FA0x11566818_002EMICROSEC_TO_CM_0024initializer_0024/* Not supported: data(73 00 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EMath_002E_003FA0x11566818_002ERadToDeg_0024initializer_0024/* Not supported: data(6E 00 00 06) */;

	internal static uint _003FA0x11566818_002E_003FOPTIONS_COMPAT_START_NUMBER_0040_003F1_003F_003FVerifyProductVersion_0040Options_0040Conf_0040HOLMImpulse_0040HOLM_0040_0040SM_NP_0024AAVString_0040System_0040_0040_0040Z_00404IB/*Field data (rva=0x86ef38) could not be foundin any section!*/;

	internal unsafe static delegate*<void> HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x11566818_002EAUTOSAVE_MEAS_FILENAME_0024initializer_0024/* Not supported: data(78 00 00 06) */;

	internal static basic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E _003FA0x11566818_002E_003FUserDirectory_0040_003F1_003F_003FFilePath_0040Conf_0040HOLMImpulse_0040HOLM_0040_0040YA_003FAV_003F_0024basic_string_0040_WU_003F_0024char_traits_0040_W_0040std_0040_0040V_003F_0024allocator_0040_W_00402_0040_0040std_0040_0040V56_0040_N_0040Z_00404V56_0040B/*Field data (rva=0x86eee8) could not be foundin any section!*/;

	internal unsafe static delegate*<void> HOLM_002EMath_002E_003FA0x11566818_002EDegToRad_F_0024initializer_0024/* Not supported: data(71 00 00 06) */;

	internal static uint _003FA0x11566818_002E_003F_0024S2_0040_003F1_003F_003FFilePath_0040Conf_0040HOLMImpulse_0040HOLM_0040_0040YA_003FAV_003F_0024basic_string_0040DU_003F_0024char_traits_0040D_0040std_0040_0040V_003F_0024allocator_0040D_00402_0040_0040std_0040_0040V56_0040_N_0040Z_00404IA/*Field data (rva=0x86eee4) could not be foundin any section!*/;

	internal unsafe static delegate*<void> HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x11566818_002ELICENSE_0024initializer_0024/* Not supported: data(86 00 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EMath_002E_003FA0x11566818_002ESQRT2_F_0024initializer_0024/* Not supported: data(6D 00 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EMath_002E_003FA0x11566818_002ETWOPI_0024initializer_0024/* Not supported: data(6A 00 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x11566818_002ECAL_MIC_FILENAME_0024initializer_0024/* Not supported: data(7E 00 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EMiscHelper_002E_003FA0x11566818_002EHOLM_WINDOW_FPGA_CTRL_0024initializer_0024/* Not supported: data(62 00 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EMath_002E_003FA0x11566818_002EHALFPI_0024initializer_0024/* Not supported: data(6B 00 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EMath_002E_003FA0x11566818_002ESQRT2_0024initializer_0024/* Not supported: data(6C 00 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x11566818_002EMEASURE_LOW_REJECT_AMP_0024initializer_0024/* Not supported: data(8A 00 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EMiscHelper_002E_003FA0x11566818_002EHEXSTRINGARRAY_0024initializer_0024/* Not supported: data(60 00 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x11566818_002ETMP_PATH_MEASLIST_0024initializer_0024/* Not supported: data(88 00 00 06) */;

	internal static uint _003FA0x11566818_002E_003F_0024S1_0040_003F1_003F_003FFilePath_0040Conf_0040HOLMImpulse_0040HOLM_0040_0040YA_003FAV_003F_0024basic_string_0040_WU_003F_0024char_traits_0040_W_0040std_0040_0040V_003F_0024allocator_0040_W_00402_0040_0040std_0040_0040V56_0040_N_0040Z_00404IA/*Field data (rva=0x86ef20) could not be foundin any section!*/;

	internal unsafe static delegate*<void> HOLM_002EMath_002E_003FA0x11566818_002EPI_F_0024initializer_0024/* Not supported: data(69 00 00 06) */;

	internal unsafe static sbyte* std_002E_003FA0x11566818_002E_bad_alloc_Message/* Not supported: data(68 13 4F 00) */;

	internal unsafe static delegate*<void> HOLM_002EMath_002E_003FA0x11566818_002EPI_0024initializer_0024/* Not supported: data(68 00 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EMeasure_002E_003FA0x11566818_002EMILLISEC_TO_CM_0024initializer_0024/* Not supported: data(72 00 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x11566818_002EAUTOSAVE_MEAS_OBSOLETE_DIR_0024initializer_0024/* Not supported: data(7C 00 00 06) */;

	internal static _0024ArrayType_0024_0024_0024BY01_0024_0024CBD _003F_003F_C_0040_01NBENCBCI_0040_003F_0024CK_003F_0024AA_0040/* Not supported: data(2A 00) */;

	internal static _0024ArrayType_0024_0024_0024BY01_0024_0024CBD _003F_003F_C_0040_01PKGAHCOL_0040_003F_0024CJ_003F_0024AA_0040/* Not supported: data(29 00) */;

	internal static _0024ArrayType_0024_0024_0024BY0CH_0040_0024_0024CBD _003F_003F_C_0040_0CH_0040BIAOOJID_0040MainCtrl_003F3_003F3SetSplashScreenStatusS_0040/* Not supported: data(4D 61 69 6E 43 74 72 6C 3A 3A 53 65 74 53 70 6C 61 73 68 53 63 72 65 65 6E 53 74 61 74 75 73 53 74 72 69 6E 67 28 00) */;

	internal static _0024ArrayType_0024_0024_0024BY00_0024_0024CB_W _003F_003F_C_0040_11LOCGONAA_0040_003F_0024AA_003F_0024AA_0040/* Not supported: data(00 00) */;

	internal static _0024ArrayType_0024_0024_0024BY03_0024_0024CBD _003F_003F_C_0040_03EMFPMALO_00401_003F1A_003F_0024AA_0040/* Not supported: data(31 2F 41 00) */;

	internal static _0024ArrayType_0024_0024_0024BY01_0024_0024CBD _003F_003F_C_0040_01JOAMLHOP_0040_003F9_003F_0024AA_0040/* Not supported: data(2D 00) */;

	internal static _0024ArrayType_0024_0024_0024BY01_0024_0024CBD _003F_003F_C_0040_01MIFGBAGJ_0040_003F_0024CL_003F_0024AA_0040/* Not supported: data(2B 00) */;

	internal static _0024ArrayType_0024_0024_0024BY01_0024_0024CBD _003F_003F_C_0040_01KMDKNFGN_0040_003F1_003F_0024AA_0040/* Not supported: data(2F 00) */;

	internal static _0024ArrayType_0024_0024_0024BY02_0024_0024CBD _003F_003F_C_0040_02JDNIPIGD_0040NA_003F_0024AA_0040/* Not supported: data(4E 41 00) */;

	internal static _0024ArrayType_0024_0024_0024BY02_0024_0024CBD _003F_003F_C_0040_02KEGNLNML_0040_003F0_003F5_003F_0024AA_0040/* Not supported: data(2C 20 00) */;

	internal static _0024ArrayType_0024_0024_0024BY0O_0040_0024_0024CBD _003F_003F_C_0040_0O_0040EDGJGDIK_0040Calibration_003F5_003F_0024CI_003F_0024AA_0040/* Not supported: data(43 61 6C 69 62 72 61 74 69 6F 6E 20 28 00) */;

	internal static _0024ArrayType_0024_0024_0024BY0CJ_0040_0024_0024CBD _003F_003F_C_0040_0CJ_0040NIJFOCKC_0040MainCtrl_003F3_003F3Action_DragAndDrop_003F5Exc_0040/* Not supported: data(4D 61 69 6E 43 74 72 6C 3A 3A 41 63 74 69 6F 6E 5F 44 72 61 67 41 6E 64 44 72 6F 70 20 45 78 63 65 70 74 69 6F 6E 3A 0A 00) */;

	internal static int Mem_002E_003FA0x316290b9_002ERunOnceCustomNewHandlerInt/*Field data (rva=0x86d0e8) could not be foundin any section!*/;

	internal unsafe static delegate*<void> Mem_002E_003FA0x316290b9_002ERunOnceCustomNewHandlerInt_0024initializer_0024/* Not supported: data(CA 00 00 06) */;

	internal static double HOLM_002EMeasure_002E_003FA0x316290b9_002ESPEED_OF_SOUND/* Not supported: data(00 00 00 00 00 80 75 40) */;

	internal static double HOLM_002EMeasure_002E_003FA0x316290b9_002EMILLISEC_TO_CM/*Field data (rva=0x86d0e0) could not be foundin any section!*/;

	internal static double HOLM_002EMeasure_002E_003FA0x316290b9_002ESEC_TO_CM/* Not supported: data(00 00 00 00 00 CC E0 40) */;

	internal static double HOLM_002EMeasure_002E_003FA0x316290b9_002ECM_TO_SEC/* Not supported: data(E7 E8 1A 35 5B 7B FE 3E) */;

	internal static double HOLM_002EMeasure_002E_003FA0x316290b9_002EMICROSEC_TO_CM/*Field data (rva=0x86d0d8) could not be foundin any section!*/;

	internal static float HOLM_002EMath_002E_003FA0x316290b9_002ERadToDeg_F/*Field data (rva=0x86d0d4) could not be foundin any section!*/;

	internal static float HOLM_002EMath_002E_003FA0x316290b9_002EPI_F/*Field data (rva=0x86d0d0) could not be foundin any section!*/;

	internal static double HOLM_002EMath_002E_003FA0x316290b9_002EHALFPI/*Field data (rva=0x86d0c8) could not be foundin any section!*/;

	internal static double HOLM_002EMath_002E_003FA0x316290b9_002ERadToDeg/*Field data (rva=0x86d0c0) could not be foundin any section!*/;

	internal static double HOLM_002EMath_002E_003FA0x316290b9_002ESQRT2/*Field data (rva=0x86d0b8) could not be foundin any section!*/;

	internal static double HOLM_002EMath_002E_003FA0x316290b9_002EDegToRad/*Field data (rva=0x86d0b0) could not be foundin any section!*/;

	internal static float HOLM_002EMath_002E_003FA0x316290b9_002EDegToRad_F/*Field data (rva=0x86d0ac) could not be foundin any section!*/;

	internal static float HOLM_002EMath_002E_003FA0x316290b9_002ESQRT2_F/*Field data (rva=0x86d0a8) could not be foundin any section!*/;

	internal static double HOLM_002EMath_002E_003FA0x316290b9_002ETWOPI/*Field data (rva=0x86d0a0) could not be foundin any section!*/;

	internal static double HOLM_002EMath_002E_003FA0x316290b9_002EPI/*Field data (rva=0x86d098) could not be foundin any section!*/;

	internal static _0024ArrayType_0024_0024_0024BY0BA_0040_0024_0024CBV_003F_0024basic_string_0040DU_003F_0024char_traits_0040D_0040std_0040_0040V_003F_0024allocator_0040D_00402_0040_0040std_0040_0040 HOLM_002EMiscHelper_002E_003FA0x316290b9_002EHEXSTRINGARRAY/*Field data (rva=0x86ced8) could not be foundin any section!*/;

	internal static basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E HOLM_002EMiscHelper_002E_003FA0x316290b9_002EHOLM_WINDOW_DSPreLab_DEMO/*Field data (rva=0x86cebc) could not be foundin any section!*/;

	internal static basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E HOLM_002EMiscHelper_002E_003FA0x316290b9_002EHOLM_WINDOW_FPGA_CTRL/*Field data (rva=0x86cea0) could not be foundin any section!*/;

	internal static basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E HOLM_002EMiscHelper_002E_003FA0x316290b9_002EHOLM_WINDOW_DSPreLab/*Field data (rva=0x86ce84) could not be foundin any section!*/;

	internal static double HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x316290b9_002EPLOT_MAX_FREQ/* Not supported: data(00 00 00 00 00 70 F7 40) */;

	internal static basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x316290b9_002ELICENSE/*Field data (rva=0x86ce68) could not be foundin any section!*/;

	internal static basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x316290b9_002EOPTIONS_AUTOSAVE_FILENAME/*Field data (rva=0x86ce4c) could not be foundin any section!*/;

	internal static double HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x316290b9_002EPLOT_MIN_DB/* Not supported: data(00 00 00 00 00 00 69 C0) */;

	internal static basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x316290b9_002EAUTOSAVE_MEAS_OBSOLETE/*Field data (rva=0x86ce30) could not be foundin any section!*/;

	internal static basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x316290b9_002ECAL_MIC_FILENAME/*Field data (rva=0x86ce14) could not be foundin any section!*/;

	internal static basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x316290b9_002EAUTOSAVE_MEAS_OBSOLETE_DIR/*Field data (rva=0x86cdf8) could not be foundin any section!*/;

	internal static double HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x316290b9_002EMEASURE_LOW_REJECT_AMP/*Field data (rva=0x86cdf0) could not be foundin any section!*/;

	internal static double HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x316290b9_002EMEASURE_LOW_WARN_AMP/*Field data (rva=0x86cde8) could not be foundin any section!*/;

	internal static basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x316290b9_002ECHANGELOG/*Field data (rva=0x86cdcc) could not be foundin any section!*/;

	internal static basic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x316290b9_002EAUTOSAVE_MEAS_FILENAME/*Field data (rva=0x86cdb0) could not be foundin any section!*/;

	internal static double HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x316290b9_002EPLOT_MAX_DB/* Not supported: data(00 00 00 00 00 00 34 40) */;

	internal static double HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x316290b9_002EPLOT_MIN_FREQ/* Not supported: data(00 00 00 00 00 00 F0 3F) */;

	internal static basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x316290b9_002ECAL_DACADC_FILENAME/*Field data (rva=0x86cd94) could not be foundin any section!*/;

	internal static basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x316290b9_002EISSUES/*Field data (rva=0x86cd78) could not be foundin any section!*/;

	internal static basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x316290b9_002ETMP_PATH_MEASLIST/*Field data (rva=0x86cd5c) could not be foundin any section!*/;

	internal static basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x316290b9_002EOPTIONS_COMPAT_START/*Field data (rva=0x86cd40) could not be foundin any section!*/;

	internal unsafe static delegate*<void> HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x316290b9_002EMEASURE_LOW_WARN_AMP_0024initializer_0024/* Not supported: data(C9 00 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x316290b9_002ECHANGELOG_0024initializer_0024/* Not supported: data(C0 00 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EMiscHelper_002E_003FA0x316290b9_002EHOLM_WINDOW_DSPreLab_0024initializer_0024/* Not supported: data(A1 00 00 06) */;

	internal static _0024_s__RTTIBaseClassArray_0024_extraBytes_12 _003F_003F_R2length_error_0040std_0040_00408/* Not supported: data(D4 76 5E 00 04 76 5E 00 50 76 5E 00 00) */;

	internal unsafe static delegate*<void> HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x316290b9_002EISSUES_0024initializer_0024/* Not supported: data(C2 00 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x316290b9_002EOPTIONS_COMPAT_START_0024initializer_0024/* Not supported: data(B2 00 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EMath_002E_003FA0x316290b9_002EDegToRad_0024initializer_0024/* Not supported: data(AD 00 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EMiscHelper_002E_003FA0x316290b9_002EHOLM_WINDOW_DSPreLab_DEMO_0024initializer_0024/* Not supported: data(A3 00 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x316290b9_002ECAL_DACADC_FILENAME_0024initializer_0024/* Not supported: data(BE 00 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x316290b9_002EOPTIONS_AUTOSAVE_FILENAME_0024initializer_0024/* Not supported: data(B4 00 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EMath_002E_003FA0x316290b9_002ERadToDeg_F_0024initializer_0024/* Not supported: data(AC 00 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x316290b9_002EAUTOSAVE_MEAS_OBSOLETE_0024initializer_0024/* Not supported: data(B8 00 00 06) */;

	internal static _s__RTTICompleteObjectLocator _003F_003F_R4length_error_0040std_0040_00406B_0040/* Not supported: data(00 00 00 00 00 00 00 00 00 00 00 00 8C 59 5F 00 B4 76 5E 00) */;

	internal unsafe static delegate*<void> HOLM_002EMeasure_002E_003FA0x316290b9_002EMICROSEC_TO_CM_0024initializer_0024/* Not supported: data(B0 00 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EMath_002E_003FA0x316290b9_002ERadToDeg_0024initializer_0024/* Not supported: data(AB 00 00 06) */;

	internal static _0024ArrayType_0024_0024_0024BY02Q6AXXZ _003F_003F_7length_error_0040std_0040_00406B_0040/* Not supported: data(80 0F 41 00 D0 D9 43 00 01 00 00 00) */;

	internal unsafe static delegate*<void> HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x316290b9_002EAUTOSAVE_MEAS_FILENAME_0024initializer_0024/* Not supported: data(B6 00 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EMath_002E_003FA0x316290b9_002EDegToRad_F_0024initializer_0024/* Not supported: data(AE 00 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x316290b9_002ELICENSE_0024initializer_0024/* Not supported: data(C4 00 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EMath_002E_003FA0x316290b9_002ESQRT2_F_0024initializer_0024/* Not supported: data(AA 00 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EMath_002E_003FA0x316290b9_002ETWOPI_0024initializer_0024/* Not supported: data(A7 00 00 06) */;

	internal static bool _003FA0x316290b9_002E_003FfReactOnQboxGui_0040_003F1_003F_003FAction_QBoxUpdate_0040MainCtrl_0040HOLMImpulse_0040HOLM_0040_0040A_0024AAMXP_0024AAVObject_0040System_0040_0040P_0024AAVEventArgs_00406_0040_0040Z_00404_NA/* Not supported: data(01) */;

	internal static _0024_TypeDescriptor_0024_extraBytes_23 _003F_003F_R0_003FAVlength_error_0040std_0040_0040_00408/* Not supported: data(9C 12 4F 00 00 00 00 00 2E 3F 41 56 6C 65 6E 67 74 68 5F 65 72 72 6F 72 40 73 74 64 40 40 00) */;

	internal unsafe static delegate*<void> HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x316290b9_002ECAL_MIC_FILENAME_0024initializer_0024/* Not supported: data(BC 00 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EMiscHelper_002E_003FA0x316290b9_002EHOLM_WINDOW_FPGA_CTRL_0024initializer_0024/* Not supported: data(9F 00 00 06) */;

	internal static _s__RTTIClassHierarchyDescriptor _003F_003F_R3length_error_0040std_0040_00408/* Not supported: data(00 00 00 00 00 00 00 00 03 00 00 00 C4 76 5E 00) */;

	internal unsafe static delegate*<void> HOLM_002EMath_002E_003FA0x316290b9_002EHALFPI_0024initializer_0024/* Not supported: data(A8 00 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EMath_002E_003FA0x316290b9_002ESQRT2_0024initializer_0024/* Not supported: data(A9 00 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x316290b9_002EMEASURE_LOW_REJECT_AMP_0024initializer_0024/* Not supported: data(C8 00 00 06) */;

	internal static _s__RTTIBaseClassDescriptor2 _003F_003F_R1A_0040_003F0A_0040EA_0040length_error_0040std_0040_00408/* Not supported: data(8C 59 5F 00 02 00 00 00 00 00 00 00 FF FF FF FF 00 00 00 00 40 00 00 00 B4 76 5E 00) */;

	internal unsafe static delegate*<void> HOLM_002EMiscHelper_002E_003FA0x316290b9_002EHEXSTRINGARRAY_0024initializer_0024/* Not supported: data(9D 00 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x316290b9_002ETMP_PATH_MEASLIST_0024initializer_0024/* Not supported: data(C6 00 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EMath_002E_003FA0x316290b9_002EPI_F_0024initializer_0024/* Not supported: data(A6 00 00 06) */;

	internal unsafe static sbyte* std_002E_003FA0x316290b9_002E_bad_alloc_Message/* Not supported: data(68 13 4F 00) */;

	internal unsafe static delegate*<void> HOLM_002EMath_002E_003FA0x316290b9_002EPI_0024initializer_0024/* Not supported: data(A5 00 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EMeasure_002E_003FA0x316290b9_002EMILLISEC_TO_CM_0024initializer_0024/* Not supported: data(AF 00 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x316290b9_002EAUTOSAVE_MEAS_OBSOLETE_DIR_0024initializer_0024/* Not supported: data(BA 00 00 06) */;

	internal static _0024ArrayType_0024_0024_0024BY0L_0040_0024_0024CBD _003F_003F_C_0040_0L_0040MJNFINBB_0040Microphone_003F_0024AA_0040/* Not supported: data(4D 69 63 72 6F 70 68 6F 6E 65 00) */;

	internal static _0024ArrayType_0024_0024_0024BY06_0024_0024CBD _003F_003F_C_0040_06ONELMEEJ_0040DacAdc_003F_0024AA_0040/* Not supported: data(44 61 63 41 64 63 00) */;

	internal static _0024ArrayType_0024_0024_0024BY07_0024_0024CBD _003F_003F_C_0040_07JPFAGAHC_0040_003F5Out_003F5_003F_0024DN_003F5_003F_0024AA_0040/* Not supported: data(20 4F 75 74 20 3D 20 00) */;

	internal static _0024ArrayType_0024_0024_0024BY0CI_0040_0024_0024CBD _003F_003F_C_0040_0CI_0040GHGIKBJI_0040AudioHelper_003F3_003F3UpdateDeviceNumbers_0040/* Not supported: data(41 75 64 69 6F 48 65 6C 70 65 72 3A 3A 55 70 64 61 74 65 44 65 76 69 63 65 4E 75 6D 62 65 72 73 3A 20 49 6E 20 3D 20 00) */;

	internal static _0024ArrayType_0024_0024_0024BY0DF_0040_0024_0024CBD _003F_003F_C_0040_0DF_0040NIIKCJBB_0040AudioHelper_003F3_003F3UpdateDeviceNumbers_0040/* Not supported: data(41 75 64 69 6F 48 65 6C 70 65 72 3A 3A 55 70 64 61 74 65 44 65 76 69 63 65 4E 75 6D 62 65 72 73 20 6D 61 78 49 6E 70 75 74 43 68 61 6E 6E 65 6C 73 20 3D 20 00) */;

	internal static _0024ArrayType_0024_0024_0024BY0DO_0040_0024_0024CBD _003F_003F_C_0040_0DO_0040IOMKICGF_0040AudioHelper_003F3_003F3UpdateDeviceNumbers_0040/* Not supported: data(41 75 64 69 6F 48 65 6C 70 65 72 3A 3A 55 70 64 61 74 65 44 65 76 69 63 65 4E 75 6D 62 65 72 73 3A 20 49 6E 70 75 74 20 69 6E 64 65 78 20 6F 75 74 20 6F 66 20 72 61 6E 67 65 20 3D 20 00) */;

	internal static _0024ArrayType_0024_0024_0024BY0DG_0040_0024_0024CBD _003F_003F_C_0040_0DG_0040EDFBLONJ_0040AudioHelper_003F3_003F3UpdateDeviceNumbers_0040/* Not supported: data(41 75 64 69 6F 48 65 6C 70 65 72 3A 3A 55 70 64 61 74 65 44 65 76 69 63 65 4E 75 6D 62 65 72 73 20 6D 61 78 4F 75 74 70 75 74 43 68 61 6E 6E 65 6C 73 20 3D 20 00) */;

	internal static _0024ArrayType_0024_0024_0024BY0DP_0040_0024_0024CBD _003F_003F_C_0040_0DP_0040NEBGIHJJ_0040AudioHelper_003F3_003F3UpdateDeviceNumbers_0040/* Not supported: data(41 75 64 69 6F 48 65 6C 70 65 72 3A 3A 55 70 64 61 74 65 44 65 76 69 63 65 4E 75 6D 62 65 72 73 3A 20 4F 75 74 70 75 74 20 69 6E 64 65 78 20 6F 75 74 20 6F 66 20 72 61 6E 67 65 20 3D 20 00) */;

	internal static _0024ArrayType_0024_0024_0024BY04_0024_0024CBD _003F_003F_C_0040_04INFMDMNC_0040ASIO_003F_0024AA_0040/* Not supported: data(41 53 49 4F 00) */;

	internal static _0024ArrayType_0024_0024_0024BY0BO_0040_0024_0024CBD _003F_003F_C_0040_0BO_0040GEJOEDHL_0040Initializing_003F5measurement_003F5data_003F_0024AA_0040/* Not supported: data(49 6E 69 74 69 61 6C 69 7A 69 6E 67 20 6D 65 61 73 75 72 65 6D 65 6E 74 20 64 61 74 61 00) */;

	internal static _0024ArrayType_0024_0024_0024BY0BH_0040_0024_0024CBD _003F_003F_C_0040_0BH_0040PNNNMCLM_0040Validating_003F5measurement_003F_0024AA_0040/* Not supported: data(56 61 6C 69 64 61 74 69 6E 67 20 6D 65 61 73 75 72 65 6D 65 6E 74 00) */;

	internal static _0024ArrayType_0024_0024_0024BY0CA_0040_0024_0024CBD _003F_003F_C_0040_0CA_0040JCAMGIDD_0040Finding_003F5appropriate_003F5normalizing_003F_0024AA_0040/* Not supported: data(46 69 6E 64 69 6E 67 20 61 70 70 72 6F 70 72 69 61 74 65 20 6E 6F 72 6D 61 6C 69 7A 69 6E 67 00) */;

	internal static _0024ArrayType_0024_0024_0024BY0CL_0040_0024_0024CBD _003F_003F_C_0040_0CL_0040CLEEOIFI_0040AudioHelper_003F3_003F3PopulateDevices_003F_0024CI_003F_0024CJ_003F5i_0040/* Not supported: data(41 75 64 69 6F 48 65 6C 70 65 72 3A 3A 50 6F 70 75 6C 61 74 65 44 65 76 69 63 65 73 28 29 20 69 6E 70 75 74 44 65 76 73 3A 20 00) */;

	internal static _0024ArrayType_0024_0024_0024BY0CK_0040_0024_0024CBD _003F_003F_C_0040_0CK_0040LHDKLAJE_0040AudioHelper_003F3_003F3PopulateDevices_003F_0024CI_003F_0024CJ_003F5i_0040/* Not supported: data(41 75 64 69 6F 48 65 6C 70 65 72 3A 3A 50 6F 70 75 6C 61 74 65 44 65 76 69 63 65 73 28 29 20 69 6E 70 75 74 44 65 76 73 5B 00) */;

	internal static _0024ArrayType_0024_0024_0024BY0CM_0040_0024_0024CBD _003F_003F_C_0040_0CM_0040DKPDCMCH_0040AudioHelper_003F3_003F3PopulateDevices_003F_0024CI_003F_0024CJ_003F5o_0040/* Not supported: data(41 75 64 69 6F 48 65 6C 70 65 72 3A 3A 50 6F 70 75 6C 61 74 65 44 65 76 69 63 65 73 28 29 20 6F 75 74 70 75 74 44 65 76 73 3A 20 00) */;

	internal static _0024ArrayType_0024_0024_0024BY0CL_0040_0024_0024CBD _003F_003F_C_0040_0CL_0040BPFJDEP_0040AudioHelper_003F3_003F3PopulateDevices_003F_0024CI_003F_0024CJ_003F5o_0040/* Not supported: data(41 75 64 69 6F 48 65 6C 70 65 72 3A 3A 50 6F 70 75 6C 61 74 65 44 65 76 69 63 65 73 28 29 20 6F 75 74 70 75 74 44 65 76 73 5B 00) */;

	internal static _0024ArrayType_0024_0024_0024BY0BD_0040_0024_0024CBD _003F_003F_C_0040_0BD_0040OLBABOEK_0040vector_003F_0024DMT_003F_0024DO_003F5too_003F5long_003F_0024AA_0040/* Not supported: data(76 65 63 74 6F 72 3C 54 3E 20 74 6F 6F 20 6C 6F 6E 67 00) */;

	internal static int Mem_002E_003FA0x11fcae0a_002ERunOnceCustomNewHandlerInt/*Field data (rva=0x86d484) could not be foundin any section!*/;

	internal unsafe static delegate*<void> Mem_002E_003FA0x11fcae0a_002ERunOnceCustomNewHandlerInt_0024initializer_0024/* Not supported: data(F8 00 00 06) */;

	internal static double HOLM_002EMeasure_002E_003FA0x11fcae0a_002ESPEED_OF_SOUND/* Not supported: data(00 00 00 00 00 80 75 40) */;

	internal static double HOLM_002EMeasure_002E_003FA0x11fcae0a_002EMILLISEC_TO_CM/*Field data (rva=0x86d490) could not be foundin any section!*/;

	internal static double HOLM_002EMeasure_002E_003FA0x11fcae0a_002ESEC_TO_CM/* Not supported: data(00 00 00 00 00 CC E0 40) */;

	internal static double HOLM_002EMeasure_002E_003FA0x11fcae0a_002ECM_TO_SEC/* Not supported: data(E7 E8 1A 35 5B 7B FE 3E) */;

	internal static double HOLM_002EMeasure_002E_003FA0x11fcae0a_002EMICROSEC_TO_CM/*Field data (rva=0x86d488) could not be foundin any section!*/;

	internal static float HOLM_002EMath_002E_003FA0x11fcae0a_002ERadToDeg_F/*Field data (rva=0x86d480) could not be foundin any section!*/;

	internal static float HOLM_002EMath_002E_003FA0x11fcae0a_002EPI_F/*Field data (rva=0x86d45c) could not be foundin any section!*/;

	internal static double HOLM_002EMath_002E_003FA0x11fcae0a_002EHALFPI/*Field data (rva=0x86d478) could not be foundin any section!*/;

	internal static double HOLM_002EMath_002E_003FA0x11fcae0a_002ERadToDeg/*Field data (rva=0x86d470) could not be foundin any section!*/;

	internal static double HOLM_002EMath_002E_003FA0x11fcae0a_002ESQRT2/*Field data (rva=0x86d468) could not be foundin any section!*/;

	internal static double HOLM_002EMath_002E_003FA0x11fcae0a_002EDegToRad/*Field data (rva=0x86d460) could not be foundin any section!*/;

	internal static float HOLM_002EMath_002E_003FA0x11fcae0a_002EDegToRad_F/*Field data (rva=0x86d458) could not be foundin any section!*/;

	internal static float HOLM_002EMath_002E_003FA0x11fcae0a_002ESQRT2_F/*Field data (rva=0x86d284) could not be foundin any section!*/;

	internal static double HOLM_002EMath_002E_003FA0x11fcae0a_002ETWOPI/*Field data (rva=0x86d450) could not be foundin any section!*/;

	internal static double HOLM_002EMath_002E_003FA0x11fcae0a_002EPI/*Field data (rva=0x86d448) could not be foundin any section!*/;

	internal static _0024ArrayType_0024_0024_0024BY0BA_0040_0024_0024CBV_003F_0024basic_string_0040DU_003F_0024char_traits_0040D_0040std_0040_0040V_003F_0024allocator_0040D_00402_0040_0040std_0040_0040 HOLM_002EMiscHelper_002E_003FA0x11fcae0a_002EHEXSTRINGARRAY/*Field data (rva=0x86d288) could not be foundin any section!*/;

	internal static basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E HOLM_002EMiscHelper_002E_003FA0x11fcae0a_002EHOLM_WINDOW_DSPreLab_DEMO/*Field data (rva=0x86d268) could not be foundin any section!*/;

	internal static basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E HOLM_002EMiscHelper_002E_003FA0x11fcae0a_002EHOLM_WINDOW_FPGA_CTRL/*Field data (rva=0x86d24c) could not be foundin any section!*/;

	internal static basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E HOLM_002EMiscHelper_002E_003FA0x11fcae0a_002EHOLM_WINDOW_DSPreLab/*Field data (rva=0x86d230) could not be foundin any section!*/;

	internal static basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x11fcae0a_002ELICENSE/*Field data (rva=0x86d214) could not be foundin any section!*/;

	internal static basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x11fcae0a_002EOPTIONS_AUTOSAVE_FILENAME/*Field data (rva=0x86d1f8) could not be foundin any section!*/;

	internal static basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x11fcae0a_002EAUTOSAVE_MEAS_OBSOLETE/*Field data (rva=0x86d1dc) could not be foundin any section!*/;

	internal static basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x11fcae0a_002ECAL_MIC_FILENAME/*Field data (rva=0x86d1c0) could not be foundin any section!*/;

	internal static basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x11fcae0a_002EAUTOSAVE_MEAS_OBSOLETE_DIR/*Field data (rva=0x86d194) could not be foundin any section!*/;

	internal static double HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x11fcae0a_002EMEASURE_LOW_REJECT_AMP/*Field data (rva=0x86d1b8) could not be foundin any section!*/;

	internal static double HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x11fcae0a_002EMEASURE_LOW_WARN_AMP/*Field data (rva=0x86d1b0) could not be foundin any section!*/;

	internal static basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x11fcae0a_002ECHANGELOG/*Field data (rva=0x86d178) could not be foundin any section!*/;

	internal static basic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x11fcae0a_002EAUTOSAVE_MEAS_FILENAME/*Field data (rva=0x86d15c) could not be foundin any section!*/;

	internal static basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x11fcae0a_002ECAL_DACADC_FILENAME/*Field data (rva=0x86d140) could not be foundin any section!*/;

	internal static basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x11fcae0a_002EISSUES/*Field data (rva=0x86d124) could not be foundin any section!*/;

	internal static basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x11fcae0a_002ETMP_PATH_MEASLIST/*Field data (rva=0x86d108) could not be foundin any section!*/;

	internal static basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x11fcae0a_002EOPTIONS_COMPAT_START/*Field data (rva=0x86d0ec) could not be foundin any section!*/;

	internal static _s__ThrowInfo _TI3_003FAVlength_error_0040std_0040_0040/* Not supported: data(00 00 00 00 40 DA 43 00 00 00 00 00 78 85 5E 00) */;

	internal unsafe static delegate*<void> HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x11fcae0a_002EMEASURE_LOW_WARN_AMP_0024initializer_0024/* Not supported: data(F6 00 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x11fcae0a_002ECHANGELOG_0024initializer_0024/* Not supported: data(ED 00 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EMiscHelper_002E_003FA0x11fcae0a_002EHOLM_WINDOW_DSPreLab_0024initializer_0024/* Not supported: data(CF 00 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x11fcae0a_002EISSUES_0024initializer_0024/* Not supported: data(EF 00 00 06) */;

	internal static _s__CatchableType _CT_003F_003F_R0_003FAVlength_error_0040std_0040_0040_00408_003F_003F0length_error_0040std_0040_0040_0024_0024FQAE_0040ABV01_0040_0040Z40/* Not supported: data(00 00 00 00 8C 59 5F 00 00 00 00 00 FF FF FF FF 00 00 00 00 28 00 00 00 50 F4 43 00) */;

	internal static _s__CatchableType _CT_003F_003F_R0_003FAVlogic_error_0040std_0040_0040_00408_003F_003F0logic_error_0040std_0040_0040_0024_0024FQAE_0040ABV01_0040_0040Z40/* Not supported: data(00 00 00 00 4C 59 5F 00 00 00 00 00 FF FF FF FF 00 00 00 00 28 00 00 00 A0 DB 43 00) */;

	internal unsafe static delegate*<void> HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x11fcae0a_002EOPTIONS_COMPAT_START_0024initializer_0024/* Not supported: data(DF 00 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EMath_002E_003FA0x11fcae0a_002EDegToRad_0024initializer_0024/* Not supported: data(DB 00 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EMiscHelper_002E_003FA0x11fcae0a_002EHOLM_WINDOW_DSPreLab_DEMO_0024initializer_0024/* Not supported: data(D1 00 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x11fcae0a_002ECAL_DACADC_FILENAME_0024initializer_0024/* Not supported: data(EB 00 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x11fcae0a_002EOPTIONS_AUTOSAVE_FILENAME_0024initializer_0024/* Not supported: data(E1 00 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EMath_002E_003FA0x11fcae0a_002ERadToDeg_F_0024initializer_0024/* Not supported: data(DA 00 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x11fcae0a_002EAUTOSAVE_MEAS_OBSOLETE_0024initializer_0024/* Not supported: data(E5 00 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EMeasure_002E_003FA0x11fcae0a_002EMICROSEC_TO_CM_0024initializer_0024/* Not supported: data(DE 00 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EMath_002E_003FA0x11fcae0a_002ERadToDeg_0024initializer_0024/* Not supported: data(D9 00 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x11fcae0a_002EAUTOSAVE_MEAS_FILENAME_0024initializer_0024/* Not supported: data(E3 00 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EMath_002E_003FA0x11fcae0a_002EDegToRad_F_0024initializer_0024/* Not supported: data(DC 00 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x11fcae0a_002ELICENSE_0024initializer_0024/* Not supported: data(F1 00 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EMath_002E_003FA0x11fcae0a_002ESQRT2_F_0024initializer_0024/* Not supported: data(D8 00 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EMath_002E_003FA0x11fcae0a_002ETWOPI_0024initializer_0024/* Not supported: data(D5 00 00 06) */;

	internal static bool _003FA0x11fcae0a_002E_003FfFirstRun_0040_003F1_003F_003FPerformMeasurement_0040AudioHelper_0040HOLMImpulse_0040HOLM_0040_0040Q_0024AAM_NPAVMeasurement_0040Measure_00404_0040P_0024AAVString_0040System_0040_0040_0040Z_00404_NA/* Not supported: data(01) */;

	internal static _0024_s__CatchableTypeArray_0024_extraBytes_8 _CTA2_003FAVbad_alloc_0040std_0040_0040/* Not supported: data(02 00 00 00 98 85 5E 00 24 85 5E 00) */;

	internal unsafe static delegate*<void> HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x11fcae0a_002ECAL_MIC_FILENAME_0024initializer_0024/* Not supported: data(E9 00 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EMiscHelper_002E_003FA0x11fcae0a_002EHOLM_WINDOW_FPGA_CTRL_0024initializer_0024/* Not supported: data(CD 00 00 06) */;

	internal static _0024_s__CatchableTypeArray_0024_extraBytes_12 _CTA3_003FAVlength_error_0040std_0040_0040/* Not supported: data(03 00 00 00 5C 85 5E 00 40 85 5E 00 24 85 5E 00) */;

	internal unsafe static delegate*<void> HOLM_002EMath_002E_003FA0x11fcae0a_002EHALFPI_0024initializer_0024/* Not supported: data(D6 00 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EMath_002E_003FA0x11fcae0a_002ESQRT2_0024initializer_0024/* Not supported: data(D7 00 00 06) */;

	internal static _s__ThrowInfo _TI2_003FAVbad_alloc_0040std_0040_0040/* Not supported: data(00 00 00 00 B0 D8 43 00 00 00 00 00 B4 85 5E 00) */;

	internal static _s__CatchableType _CT_003F_003F_R0_003FAVexception_0040std_0040_0040_00408_003F_003F0exception_0040std_0040_0040_0024_0024FQAE_0040ABV01_0040_0040Z12/* Not supported: data(00 00 00 00 10 59 5F 00 00 00 00 00 FF FF FF FF 00 00 00 00 0C 00 00 00 F0 8B 4C 00) */;

	internal unsafe static delegate*<void> HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x11fcae0a_002EMEASURE_LOW_REJECT_AMP_0024initializer_0024/* Not supported: data(F5 00 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EMiscHelper_002E_003FA0x11fcae0a_002EHEXSTRINGARRAY_0024initializer_0024/* Not supported: data(CB 00 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x11fcae0a_002ETMP_PATH_MEASLIST_0024initializer_0024/* Not supported: data(F3 00 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EMath_002E_003FA0x11fcae0a_002EPI_F_0024initializer_0024/* Not supported: data(D4 00 00 06) */;

	internal unsafe static sbyte* std_002E_003FA0x11fcae0a_002E_bad_alloc_Message/* Not supported: data(68 13 4F 00) */;

	internal unsafe static delegate*<void> HOLM_002EMath_002E_003FA0x11fcae0a_002EPI_0024initializer_0024/* Not supported: data(D3 00 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EMeasure_002E_003FA0x11fcae0a_002EMILLISEC_TO_CM_0024initializer_0024/* Not supported: data(DD 00 00 06) */;

	internal static _s__CatchableType _CT_003F_003F_R0_003FAVbad_alloc_0040std_0040_0040_00408_003F_003F0bad_alloc_0040std_0040_0040_0024_0024FQAE_0040ABV01_0040_0040Z12/* Not supported: data(00 00 00 00 6C 59 5F 00 00 00 00 00 FF FF FF FF 00 00 00 00 0C 00 00 00 20 00 44 00) */;

	internal unsafe static delegate*<void> HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x11fcae0a_002EAUTOSAVE_MEAS_OBSOLETE_DIR_0024initializer_0024/* Not supported: data(E7 00 00 06) */;

	internal static float HOLM_002EMath_002E_003FA0xac910afd_002ERadToDeg_F/*Field data (rva=0x86d6e8) could not be foundin any section!*/;

	internal static float HOLM_002EMath_002E_003FA0xac910afd_002EPI_F/*Field data (rva=0x86d6c4) could not be foundin any section!*/;

	internal static double HOLM_002EMath_002E_003FA0xac910afd_002EHALFPI/*Field data (rva=0x86d6e0) could not be foundin any section!*/;

	internal static double HOLM_002EMath_002E_003FA0xac910afd_002ERadToDeg/*Field data (rva=0x86d6d8) could not be foundin any section!*/;

	internal static double HOLM_002EMath_002E_003FA0xac910afd_002ESQRT2/*Field data (rva=0x86d6d0) could not be foundin any section!*/;

	internal static double HOLM_002EMath_002E_003FA0xac910afd_002EDegToRad/*Field data (rva=0x86d6c8) could not be foundin any section!*/;

	internal static float HOLM_002EMath_002E_003FA0xac910afd_002EDegToRad_F/*Field data (rva=0x86d6c0) could not be foundin any section!*/;

	internal static float HOLM_002EMath_002E_003FA0xac910afd_002ESQRT2_F/*Field data (rva=0x86d4ec) could not be foundin any section!*/;

	internal static double HOLM_002EMath_002E_003FA0xac910afd_002ETWOPI/*Field data (rva=0x86d6b8) could not be foundin any section!*/;

	internal static double HOLM_002EMath_002E_003FA0xac910afd_002EPI/*Field data (rva=0x86d6b0) could not be foundin any section!*/;

	internal static _0024ArrayType_0024_0024_0024BY0BA_0040_0024_0024CBV_003F_0024basic_string_0040DU_003F_0024char_traits_0040D_0040std_0040_0040V_003F_0024allocator_0040D_00402_0040_0040std_0040_0040 HOLM_002EMiscHelper_002E_003FA0xac910afd_002EHEXSTRINGARRAY/*Field data (rva=0x86d4f0) could not be foundin any section!*/;

	internal static basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E HOLM_002EMiscHelper_002E_003FA0xac910afd_002EHOLM_WINDOW_DSPreLab_DEMO/*Field data (rva=0x86d4d0) could not be foundin any section!*/;

	internal static basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E HOLM_002EMiscHelper_002E_003FA0xac910afd_002EHOLM_WINDOW_FPGA_CTRL/*Field data (rva=0x86d4b4) could not be foundin any section!*/;

	internal static basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E HOLM_002EMiscHelper_002E_003FA0xac910afd_002EHOLM_WINDOW_DSPreLab/*Field data (rva=0x86d498) could not be foundin any section!*/;

	internal unsafe static delegate*<void> HOLM_002EMiscHelper_002E_003FA0xac910afd_002EHOLM_WINDOW_DSPreLab_0024initializer_0024/* Not supported: data(0D 01 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EMath_002E_003FA0xac910afd_002EDegToRad_0024initializer_0024/* Not supported: data(19 01 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EMiscHelper_002E_003FA0xac910afd_002EHOLM_WINDOW_DSPreLab_DEMO_0024initializer_0024/* Not supported: data(0F 01 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EMath_002E_003FA0xac910afd_002ERadToDeg_F_0024initializer_0024/* Not supported: data(18 01 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EMath_002E_003FA0xac910afd_002ERadToDeg_0024initializer_0024/* Not supported: data(17 01 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EMath_002E_003FA0xac910afd_002EDegToRad_F_0024initializer_0024/* Not supported: data(1A 01 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EMath_002E_003FA0xac910afd_002ESQRT2_F_0024initializer_0024/* Not supported: data(16 01 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EMath_002E_003FA0xac910afd_002ETWOPI_0024initializer_0024/* Not supported: data(13 01 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EMiscHelper_002E_003FA0xac910afd_002EHOLM_WINDOW_FPGA_CTRL_0024initializer_0024/* Not supported: data(0B 01 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EMath_002E_003FA0xac910afd_002EHALFPI_0024initializer_0024/* Not supported: data(14 01 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EMath_002E_003FA0xac910afd_002ESQRT2_0024initializer_0024/* Not supported: data(15 01 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EMiscHelper_002E_003FA0xac910afd_002EHEXSTRINGARRAY_0024initializer_0024/* Not supported: data(09 01 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EMath_002E_003FA0xac910afd_002EPI_F_0024initializer_0024/* Not supported: data(12 01 00 06) */;

	internal unsafe static sbyte* std_002E_003FA0xac910afd_002E_bad_alloc_Message/* Not supported: data(68 13 4F 00) */;

	internal unsafe static delegate*<void> HOLM_002EMath_002E_003FA0xac910afd_002EPI_0024initializer_0024/* Not supported: data(11 01 00 06) */;

	internal static _0024ArrayType_0024_0024_0024BY0CI_0040_0024_0024CBD _003F_003F_C_0040_0CI_0040MEAGNAMK_0040WaitingCtrl_003F3_003F3WaitingCtrl_003F_0024CI_003F_0024CJ_003F5CONST_0040/* Not supported: data(57 61 69 74 69 6E 67 43 74 72 6C 3A 3A 57 61 69 74 69 6E 67 43 74 72 6C 28 29 20 43 4F 4E 53 54 52 55 43 54 49 4E 47 00) */;

	internal static _0024ArrayType_0024_0024_0024BY02_0024_0024CBD _003F_003F_C_0040_02HMLFPPOG_0040_003F5_003F_0024CJ_003F_0024AA_0040/* Not supported: data(20 29 00) */;

	internal static _0024ArrayType_0024_0024_0024BY0BE_0040_0024_0024CBD _003F_003F_C_0040_0BE_0040MBNOEGIB_0040WaitingCtrl_003F3_003F3Wait_003F_0024CI_003F5_003F_0024AA_0040/* Not supported: data(57 61 69 74 69 6E 67 43 74 72 6C 3A 3A 57 61 69 74 28 20 00) */;

	internal static _0024ArrayType_0024_0024_0024BY0BJ_0040_0024_0024CBD _003F_003F_C_0040_0BJ_0040PGKAHFCH_0040WaitingCtrl_003F3_003F3DoNotWait_003F_0024CI_003F5_003F_0024AA_0040/* Not supported: data(57 61 69 74 69 6E 67 43 74 72 6C 3A 3A 44 6F 4E 6F 74 57 61 69 74 28 20 00) */;

	internal static float HOLM_002EMath_002E_003FA0x5305ceb3_002ERadToDeg_F/*Field data (rva=0x86d93c) could not be foundin any section!*/;

	internal static float HOLM_002EMath_002E_003FA0x5305ceb3_002EPI_F/*Field data (rva=0x86d938) could not be foundin any section!*/;

	internal static double HOLM_002EMath_002E_003FA0x5305ceb3_002EHALFPI/*Field data (rva=0x86d930) could not be foundin any section!*/;

	internal static double HOLM_002EMath_002E_003FA0x5305ceb3_002ERadToDeg/*Field data (rva=0x86d928) could not be foundin any section!*/;

	internal static double HOLM_002EMath_002E_003FA0x5305ceb3_002ESQRT2/*Field data (rva=0x86d920) could not be foundin any section!*/;

	internal static double HOLM_002EMath_002E_003FA0x5305ceb3_002EDegToRad/*Field data (rva=0x86d918) could not be foundin any section!*/;

	internal static float HOLM_002EMath_002E_003FA0x5305ceb3_002EDegToRad_F/*Field data (rva=0x86d914) could not be foundin any section!*/;

	internal static float HOLM_002EMath_002E_003FA0x5305ceb3_002ESQRT2_F/*Field data (rva=0x86d910) could not be foundin any section!*/;

	internal static double HOLM_002EMath_002E_003FA0x5305ceb3_002ETWOPI/*Field data (rva=0x86d908) could not be foundin any section!*/;

	internal static double HOLM_002EMath_002E_003FA0x5305ceb3_002EPI/*Field data (rva=0x86d900) could not be foundin any section!*/;

	internal static _0024ArrayType_0024_0024_0024BY0BA_0040_0024_0024CBV_003F_0024basic_string_0040DU_003F_0024char_traits_0040D_0040std_0040_0040V_003F_0024allocator_0040D_00402_0040_0040std_0040_0040 HOLM_002EMiscHelper_002E_003FA0x5305ceb3_002EHEXSTRINGARRAY/*Field data (rva=0x86d740) could not be foundin any section!*/;

	internal static basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E HOLM_002EMiscHelper_002E_003FA0x5305ceb3_002EHOLM_WINDOW_DSPreLab_DEMO/*Field data (rva=0x86d724) could not be foundin any section!*/;

	internal static basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E HOLM_002EMiscHelper_002E_003FA0x5305ceb3_002EHOLM_WINDOW_FPGA_CTRL/*Field data (rva=0x86d708) could not be foundin any section!*/;

	internal static basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E HOLM_002EMiscHelper_002E_003FA0x5305ceb3_002EHOLM_WINDOW_DSPreLab/*Field data (rva=0x86d6ec) could not be foundin any section!*/;

	internal unsafe static delegate*<void> HOLM_002EMiscHelper_002E_003FA0x5305ceb3_002EHOLM_WINDOW_DSPreLab_0024initializer_0024/* Not supported: data(37 01 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EMath_002E_003FA0x5305ceb3_002EDegToRad_0024initializer_0024/* Not supported: data(43 01 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EMiscHelper_002E_003FA0x5305ceb3_002EHOLM_WINDOW_DSPreLab_DEMO_0024initializer_0024/* Not supported: data(39 01 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EMath_002E_003FA0x5305ceb3_002ERadToDeg_F_0024initializer_0024/* Not supported: data(42 01 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EMath_002E_003FA0x5305ceb3_002ERadToDeg_0024initializer_0024/* Not supported: data(41 01 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EMath_002E_003FA0x5305ceb3_002EDegToRad_F_0024initializer_0024/* Not supported: data(44 01 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EMath_002E_003FA0x5305ceb3_002ESQRT2_F_0024initializer_0024/* Not supported: data(40 01 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EMath_002E_003FA0x5305ceb3_002ETWOPI_0024initializer_0024/* Not supported: data(3D 01 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EMiscHelper_002E_003FA0x5305ceb3_002EHOLM_WINDOW_FPGA_CTRL_0024initializer_0024/* Not supported: data(35 01 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EMath_002E_003FA0x5305ceb3_002EHALFPI_0024initializer_0024/* Not supported: data(3E 01 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EMath_002E_003FA0x5305ceb3_002ESQRT2_0024initializer_0024/* Not supported: data(3F 01 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EMiscHelper_002E_003FA0x5305ceb3_002EHEXSTRINGARRAY_0024initializer_0024/* Not supported: data(33 01 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EMath_002E_003FA0x5305ceb3_002EPI_F_0024initializer_0024/* Not supported: data(3C 01 00 06) */;

	internal unsafe static sbyte* std_002E_003FA0x5305ceb3_002E_bad_alloc_Message/* Not supported: data(68 13 4F 00) */;

	internal unsafe static delegate*<void> HOLM_002EMath_002E_003FA0x5305ceb3_002EPI_0024initializer_0024/* Not supported: data(3B 01 00 06) */;

	internal static _0024ArrayType_0024_0024_0024BY05_0024_0024CBD _003F_003F_C_0040_05LGDANENA_0040Empty_003F_0024AA_0040/* Not supported: data(45 6D 70 74 79 00) */;

	internal static _0024ArrayType_0024_0024_0024BY08_0024_0024CBD _003F_003F_C_0040_08ELCHFLBO_0040Empty_003F5_003F9_003F5_003F_0024AA_0040/* Not supported: data(45 6D 70 74 79 20 2D 20 00) */;

	internal static _0024ArrayType_0024_0024_0024BY01_0024_0024CB_W _003F_003F_C_0040_13LBAGMAIH_0040_003F_0024AA_003F6_003F_0024AA_003F_0024AA_0040/* Not supported: data(0A 00 00 00) */;

	internal static _0024ArrayType_0024_0024_0024BY0CB_0040_0024_0024CBD _003F_003F_C_0040_0CB_0040DDHDKKGA_0040ListMeasurementContainer_003F3_003F3Open_003F_0024CI_003F5_0040/* Not supported: data(4C 69 73 74 4D 65 61 73 75 72 65 6D 65 6E 74 43 6F 6E 74 61 69 6E 65 72 3A 3A 4F 70 65 6E 28 20 00) */;

	internal static _0024ArrayType_0024_0024_0024BY08_0024_0024CB_W _003F_003F_C_0040_1BC_0040DOKPAHCG_0040_003F_0024AAI_003F_0024AAN_003F_0024AAF_003F_0024AAO_003F_0024AA_003F5_003F_0024AA_003F5_003F_0024AA_003F5_003F_0024AA_003F5_003F_0024AA_003F_0024AA_0040/* Not supported: data(49 00 4E 00 46 00 4F 00 20 00 20 00 20 00 20 00 00 00) */;

	internal static _0024ArrayType_0024_0024_0024BY08_0024_0024CBD _003F_003F_C_0040_08EPJLHIJG_0040bad_003F5cast_003F_0024AA_0040/* Not supported: data(62 61 64 20 63 61 73 74 00) */;

	internal static double HOLM_002EMeasure_002E_003FA0x49785d99_002ESPEED_OF_SOUND/* Not supported: data(00 00 00 00 00 80 75 40) */;

	internal static double HOLM_002EMeasure_002E_003FA0x49785d99_002EMILLISEC_TO_CM/*Field data (rva=0x86dba0) could not be foundin any section!*/;

	internal static double HOLM_002EMeasure_002E_003FA0x49785d99_002ESEC_TO_CM/* Not supported: data(00 00 00 00 00 CC E0 40) */;

	internal static double HOLM_002EMeasure_002E_003FA0x49785d99_002ECM_TO_SEC/* Not supported: data(E7 E8 1A 35 5B 7B FE 3E) */;

	internal static double HOLM_002EMeasure_002E_003FA0x49785d99_002EMICROSEC_TO_CM/*Field data (rva=0x86db98) could not be foundin any section!*/;

	internal static float HOLM_002EMath_002E_003FA0x49785d99_002ERadToDeg_F/*Field data (rva=0x86db90) could not be foundin any section!*/;

	internal static float HOLM_002EMath_002E_003FA0x49785d99_002EPI_F/*Field data (rva=0x86db6c) could not be foundin any section!*/;

	internal static double HOLM_002EMath_002E_003FA0x49785d99_002EHALFPI/*Field data (rva=0x86db88) could not be foundin any section!*/;

	internal static double HOLM_002EMath_002E_003FA0x49785d99_002ERadToDeg/*Field data (rva=0x86db80) could not be foundin any section!*/;

	internal static double HOLM_002EMath_002E_003FA0x49785d99_002ESQRT2/*Field data (rva=0x86db78) could not be foundin any section!*/;

	internal static double HOLM_002EMath_002E_003FA0x49785d99_002EDegToRad/*Field data (rva=0x86db70) could not be foundin any section!*/;

	internal static float HOLM_002EMath_002E_003FA0x49785d99_002EDegToRad_F/*Field data (rva=0x86db68) could not be foundin any section!*/;

	internal static float HOLM_002EMath_002E_003FA0x49785d99_002ESQRT2_F/*Field data (rva=0x86d994) could not be foundin any section!*/;

	internal static double HOLM_002EMath_002E_003FA0x49785d99_002ETWOPI/*Field data (rva=0x86db60) could not be foundin any section!*/;

	internal static double HOLM_002EMath_002E_003FA0x49785d99_002EPI/*Field data (rva=0x86db58) could not be foundin any section!*/;

	internal static _0024ArrayType_0024_0024_0024BY0BA_0040_0024_0024CBV_003F_0024basic_string_0040DU_003F_0024char_traits_0040D_0040std_0040_0040V_003F_0024allocator_0040D_00402_0040_0040std_0040_0040 HOLM_002EMiscHelper_002E_003FA0x49785d99_002EHEXSTRINGARRAY/*Field data (rva=0x86d998) could not be foundin any section!*/;

	internal static basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E HOLM_002EMiscHelper_002E_003FA0x49785d99_002EHOLM_WINDOW_DSPreLab_DEMO/*Field data (rva=0x86d978) could not be foundin any section!*/;

	internal static basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E HOLM_002EMiscHelper_002E_003FA0x49785d99_002EHOLM_WINDOW_FPGA_CTRL/*Field data (rva=0x86d95c) could not be foundin any section!*/;

	internal static basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E HOLM_002EMiscHelper_002E_003FA0x49785d99_002EHOLM_WINDOW_DSPreLab/*Field data (rva=0x86d940) could not be foundin any section!*/;

	internal static _s__ThrowInfo _TI2_003FAVbad_cast_0040std_0040_0040/* Not supported: data(00 00 00 00 F6 8B 4C 00 00 00 00 00 EC 85 5E 00) */;

	internal static _0024_TypeDescriptor_0024_extraBytes_19 _003F_003F_R0_003FAVbad_cast_0040std_0040_0040_00408/* Not supported: data(9C 12 4F 00 00 00 00 00 2E 3F 41 56 62 61 64 5F 63 61 73 74 40 73 74 64 40 40 00) */;

	internal unsafe static delegate*<void> HOLM_002EMiscHelper_002E_003FA0x49785d99_002EHOLM_WINDOW_DSPreLab_0024initializer_0024/* Not supported: data(4C 01 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EMath_002E_003FA0x49785d99_002EDegToRad_0024initializer_0024/* Not supported: data(58 01 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EMiscHelper_002E_003FA0x49785d99_002EHOLM_WINDOW_DSPreLab_DEMO_0024initializer_0024/* Not supported: data(4E 01 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EMath_002E_003FA0x49785d99_002ERadToDeg_F_0024initializer_0024/* Not supported: data(57 01 00 06) */;

	internal static _s__CatchableType _CT_003F_003F_R0_003FAVbad_cast_0040std_0040_0040_00408_003F_003F0bad_cast_0040std_0040_0040_0024_0024FQAE_0040ABV01_0040_0040Z12/* Not supported: data(00 00 00 00 C0 59 5F 00 00 00 00 00 FF FF FF FF 00 00 00 00 0C 00 00 00 FC 8B 4C 00) */;

	internal unsafe static delegate*<void> HOLM_002EMeasure_002E_003FA0x49785d99_002EMICROSEC_TO_CM_0024initializer_0024/* Not supported: data(5B 01 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EMath_002E_003FA0x49785d99_002ERadToDeg_0024initializer_0024/* Not supported: data(56 01 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EMath_002E_003FA0x49785d99_002EDegToRad_F_0024initializer_0024/* Not supported: data(59 01 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EMath_002E_003FA0x49785d99_002ESQRT2_F_0024initializer_0024/* Not supported: data(55 01 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EMath_002E_003FA0x49785d99_002ETWOPI_0024initializer_0024/* Not supported: data(52 01 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EMiscHelper_002E_003FA0x49785d99_002EHOLM_WINDOW_FPGA_CTRL_0024initializer_0024/* Not supported: data(4A 01 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EMath_002E_003FA0x49785d99_002EHALFPI_0024initializer_0024/* Not supported: data(53 01 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EMath_002E_003FA0x49785d99_002ESQRT2_0024initializer_0024/* Not supported: data(54 01 00 06) */;

	internal static int _003Flastindex_0040_003F1_003F_003FlistBox_MouseMove_0040FormOrganizeSlotsDialog_0040HOLM_0040_0040A_0024AAMXP_0024AAVObject_0040System_0040_0040P_0024AAVMouseEventArgs_0040Forms_0040Windows_00405_0040_0040Z_00404HA/* Not supported: data(FF FF FF FF) */;

	internal unsafe static delegate*<void> HOLM_002EMiscHelper_002E_003FA0x49785d99_002EHEXSTRINGARRAY_0024initializer_0024/* Not supported: data(48 01 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EMath_002E_003FA0x49785d99_002EPI_F_0024initializer_0024/* Not supported: data(51 01 00 06) */;

	internal static _0024_s__CatchableTypeArray_0024_extraBytes_8 _CTA2_003FAVbad_cast_0040std_0040_0040/* Not supported: data(02 00 00 00 D0 85 5E 00 24 85 5E 00) */;

	internal unsafe static sbyte* std_002E_003FA0x49785d99_002E_bad_alloc_Message/* Not supported: data(68 13 4F 00) */;

	internal unsafe static locale.facet* _003F_Psave_0040_003F_0024_Facetptr_0040V_003F_0024ctype_0040_W_0040std_0040_0040_0040std_0040_00402PBVfacet_0040locale_00402_0040B/*Field data (rva=0x1f6e98) could not be foundin any section!*/;

	internal unsafe static delegate*<void> HOLM_002EMath_002E_003FA0x49785d99_002EPI_0024initializer_0024/* Not supported: data(50 01 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EMeasure_002E_003FA0x49785d99_002EMILLISEC_TO_CM_0024initializer_0024/* Not supported: data(5A 01 00 06) */;

	internal static _0024ArrayType_0024_0024_0024BY00_0024_0024CBD _003F_003F_C_0040_00CNPNBAHC_0040_003F_0024AA_0040/* Not supported: data(00) */;

	internal static _0024ArrayType_0024_0024_0024BY03_0024_0024CBD _003F_003F_C_0040_03MHLONNLM_0040_003F5_003F_0024DN_003F5_003F_0024AA_0040/* Not supported: data(20 3D 20 00) */;

	internal static _0024ArrayType_0024_0024_0024BY0N_0040_0024_0024CBD _003F_003F_C_0040_0N_0040ONLOMIOH_0040_003F6Exception_003F3_003F5_003F_0024AA_0040/* Not supported: data(0A 45 78 63 65 70 74 69 6F 6E 3A 20 00) */;

	internal static _0024ArrayType_0024_0024_0024BY0N_0040_0024_0024CBD _003F_003F_C_0040_0N_0040FCFFPKBK_0040SafeDelDir_003F3_003F5_003F_0024AA_0040/* Not supported: data(53 61 66 65 44 65 6C 44 69 72 3A 20 00) */;

	internal static _0024ArrayType_0024_0024_0024BY04_0024_0024CBD _003F_003F_C_0040_04BBDFLMDN_0040_003F5_003F9_003F_0024DO_003F5_003F_0024AA_0040/* Not supported: data(20 2D 3E 20 00) */;

	internal static _0024ArrayType_0024_0024_0024BY0BG_0040_0024_0024CBD _003F_003F_C_0040_0BG_0040CKFOKDON_0040OpenFileWithProcess_003F3_003F5_003F_0024AA_0040/* Not supported: data(4F 70 65 6E 46 69 6C 65 57 69 74 68 50 72 6F 63 65 73 73 3A 20 00) */;

	internal static _0024ArrayType_0024_0024_0024BY0DE_0040_0024_0024CBD _003F_003F_C_0040_0DE_0040OKEFBIAF_0040MiscHelper_003F3_003F3RemoveAppVersionDire_0040/* Not supported: data(4D 69 73 63 48 65 6C 70 65 72 3A 3A 52 65 6D 6F 76 65 41 70 70 56 65 72 73 69 6F 6E 44 69 72 65 63 74 6F 72 79 28 29 20 45 78 63 65 70 74 69 6F 6E 3A 20 00) */;

	internal static _0024ArrayType_0024_0024_0024BY0BA_0040_0024_0024CBV_003F_0024basic_string_0040DU_003F_0024char_traits_0040D_0040std_0040_0040V_003F_0024allocator_0040D_00402_0040_0040std_0040_0040 HOLM_002EMiscHelper_002E_003FA0xdb52cc09_002EHEXSTRINGARRAY/*Field data (rva=0x86dc00) could not be foundin any section!*/;

	internal static _0024ArrayType_0024_0024_0024BY0BA_0040_0024_0024CBD HOLM_002EMiscHelper_002E_003FA0xdb52cc09_002EHEXCHARARRAY/* Not supported: data(30 31 32 33 34 35 36 37 38 39 41 42 43 44 45 46) */;

	internal static basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E HOLM_002EMiscHelper_002E_003FA0xdb52cc09_002EHOLM_WINDOW_DSPreLab_DEMO/*Field data (rva=0x86dbe0) could not be foundin any section!*/;

	internal static basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E HOLM_002EMiscHelper_002E_003FA0xdb52cc09_002EHOLM_WINDOW_FPGA_CTRL/*Field data (rva=0x86dbc4) could not be foundin any section!*/;

	internal static _0024ArrayType_0024_0024_0024BY0BA_0040_0024_0024CBD HOLM_002EMiscHelper_002E_003FA0xdb52cc09_002EHEXCHARARRAYLOWER/* Not supported: data(30 31 32 33 34 35 36 37 38 39 61 62 63 64 65 66) */;

	internal static basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E HOLM_002EMiscHelper_002E_003FA0xdb52cc09_002EHOLM_WINDOW_DSPreLab/*Field data (rva=0x86dba8) could not be foundin any section!*/;

	internal unsafe static delegate*<void> HOLM_002EMiscHelper_002E_003FA0xdb52cc09_002EHOLM_WINDOW_DSPreLab_0024initializer_0024/* Not supported: data(7D 01 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EMiscHelper_002E_003FA0xdb52cc09_002EHOLM_WINDOW_DSPreLab_DEMO_0024initializer_0024/* Not supported: data(7F 01 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EMiscHelper_002E_003FA0xdb52cc09_002EHOLM_WINDOW_FPGA_CTRL_0024initializer_0024/* Not supported: data(7B 01 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EMiscHelper_002E_003FA0xdb52cc09_002EHEXSTRINGARRAY_0024initializer_0024/* Not supported: data(79 01 00 06) */;

	internal unsafe static sbyte* std_002E_003FA0xdb52cc09_002E_bad_alloc_Message/* Not supported: data(68 13 4F 00) */;

	internal static _0024ArrayType_0024_0024_0024BY0BA_0040_0024_0024CBV_003F_0024basic_string_0040DU_003F_0024char_traits_0040D_0040std_0040_0040V_003F_0024allocator_0040D_00402_0040_0040std_0040_0040 HOLM_002EMiscHelper_002E_003FA0xf6a6d558_002EHEXSTRINGARRAY/*Field data (rva=0x86de18) could not be foundin any section!*/;

	internal static basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E HOLM_002EMiscHelper_002E_003FA0xf6a6d558_002EHOLM_WINDOW_DSPreLab_DEMO/*Field data (rva=0x86ddf8) could not be foundin any section!*/;

	internal static basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E HOLM_002EMiscHelper_002E_003FA0xf6a6d558_002EHOLM_WINDOW_FPGA_CTRL/*Field data (rva=0x86dddc) could not be foundin any section!*/;

	internal static basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E HOLM_002EMiscHelper_002E_003FA0xf6a6d558_002EHOLM_WINDOW_DSPreLab/*Field data (rva=0x86ddc0) could not be foundin any section!*/;

	internal unsafe static delegate*<void> HOLM_002EMiscHelper_002E_003FA0xf6a6d558_002EHOLM_WINDOW_DSPreLab_0024initializer_0024/* Not supported: data(8E 01 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EMiscHelper_002E_003FA0xf6a6d558_002EHOLM_WINDOW_DSPreLab_DEMO_0024initializer_0024/* Not supported: data(90 01 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EMiscHelper_002E_003FA0xf6a6d558_002EHOLM_WINDOW_FPGA_CTRL_0024initializer_0024/* Not supported: data(8C 01 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EMiscHelper_002E_003FA0xf6a6d558_002EHEXSTRINGARRAY_0024initializer_0024/* Not supported: data(8A 01 00 06) */;

	internal unsafe static sbyte* std_002E_003FA0xf6a6d558_002E_bad_alloc_Message/* Not supported: data(68 13 4F 00) */;

	internal static int Mem_002E_003FA0x3a8cae5d_002ERunOnceCustomNewHandlerInt/*Field data (rva=0x86e22c) could not be foundin any section!*/;

	internal unsafe static delegate*<void> Mem_002E_003FA0x3a8cae5d_002ERunOnceCustomNewHandlerInt_0024initializer_0024/* Not supported: data(A7 01 00 06) */;

	internal static double HOLM_002EMeasure_002E_003FA0x3a8cae5d_002ESPEED_OF_SOUND/* Not supported: data(00 00 00 00 00 80 75 40) */;

	internal static double HOLM_002EMeasure_002E_003FA0x3a8cae5d_002EMILLISEC_TO_CM/*Field data (rva=0x86e238) could not be foundin any section!*/;

	internal static double HOLM_002EMeasure_002E_003FA0x3a8cae5d_002ESEC_TO_CM/* Not supported: data(00 00 00 00 00 CC E0 40) */;

	internal static double HOLM_002EMeasure_002E_003FA0x3a8cae5d_002ECM_TO_SEC/* Not supported: data(E7 E8 1A 35 5B 7B FE 3E) */;

	internal static double HOLM_002EMeasure_002E_003FA0x3a8cae5d_002EMICROSEC_TO_CM/*Field data (rva=0x86e230) could not be foundin any section!*/;

	internal static float HOLM_002EMath_002E_003FA0x3a8cae5d_002ERadToDeg_F/*Field data (rva=0x86e228) could not be foundin any section!*/;

	internal static float HOLM_002EMath_002E_003FA0x3a8cae5d_002EPI_F/*Field data (rva=0x86e204) could not be foundin any section!*/;

	internal static double HOLM_002EMath_002E_003FA0x3a8cae5d_002EHALFPI/*Field data (rva=0x86e220) could not be foundin any section!*/;

	internal static double HOLM_002EMath_002E_003FA0x3a8cae5d_002ERadToDeg/*Field data (rva=0x86e218) could not be foundin any section!*/;

	internal static double HOLM_002EMath_002E_003FA0x3a8cae5d_002ESQRT2/*Field data (rva=0x86e210) could not be foundin any section!*/;

	internal static double HOLM_002EMath_002E_003FA0x3a8cae5d_002EDegToRad/*Field data (rva=0x86e208) could not be foundin any section!*/;

	internal static float HOLM_002EMath_002E_003FA0x3a8cae5d_002EDegToRad_F/*Field data (rva=0x86e200) could not be foundin any section!*/;

	internal static float HOLM_002EMath_002E_003FA0x3a8cae5d_002ESQRT2_F/*Field data (rva=0x86e02c) could not be foundin any section!*/;

	internal static double HOLM_002EMath_002E_003FA0x3a8cae5d_002ETWOPI/*Field data (rva=0x86e1f8) could not be foundin any section!*/;

	internal static double HOLM_002EMath_002E_003FA0x3a8cae5d_002EPI/*Field data (rva=0x86e1f0) could not be foundin any section!*/;

	internal static _0024ArrayType_0024_0024_0024BY0BA_0040_0024_0024CBV_003F_0024basic_string_0040DU_003F_0024char_traits_0040D_0040std_0040_0040V_003F_0024allocator_0040D_00402_0040_0040std_0040_0040 HOLM_002EMiscHelper_002E_003FA0x3a8cae5d_002EHEXSTRINGARRAY/*Field data (rva=0x86e030) could not be foundin any section!*/;

	internal static basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E HOLM_002EMiscHelper_002E_003FA0x3a8cae5d_002EHOLM_WINDOW_DSPreLab_DEMO/*Field data (rva=0x86e010) could not be foundin any section!*/;

	internal static basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E HOLM_002EMiscHelper_002E_003FA0x3a8cae5d_002EHOLM_WINDOW_FPGA_CTRL/*Field data (rva=0x86dff4) could not be foundin any section!*/;

	internal static basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E HOLM_002EMiscHelper_002E_003FA0x3a8cae5d_002EHOLM_WINDOW_DSPreLab/*Field data (rva=0x86dfd8) could not be foundin any section!*/;

	internal unsafe static delegate*<void> HOLM_002EMiscHelper_002E_003FA0x3a8cae5d_002EHOLM_WINDOW_DSPreLab_0024initializer_0024/* Not supported: data(97 01 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EMath_002E_003FA0x3a8cae5d_002EDegToRad_0024initializer_0024/* Not supported: data(A3 01 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EMiscHelper_002E_003FA0x3a8cae5d_002EHOLM_WINDOW_DSPreLab_DEMO_0024initializer_0024/* Not supported: data(99 01 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EMath_002E_003FA0x3a8cae5d_002ERadToDeg_F_0024initializer_0024/* Not supported: data(A2 01 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EMeasure_002E_003FA0x3a8cae5d_002EMICROSEC_TO_CM_0024initializer_0024/* Not supported: data(A6 01 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EMath_002E_003FA0x3a8cae5d_002ERadToDeg_0024initializer_0024/* Not supported: data(A1 01 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EMath_002E_003FA0x3a8cae5d_002EDegToRad_F_0024initializer_0024/* Not supported: data(A4 01 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EMath_002E_003FA0x3a8cae5d_002ESQRT2_F_0024initializer_0024/* Not supported: data(A0 01 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EMath_002E_003FA0x3a8cae5d_002ETWOPI_0024initializer_0024/* Not supported: data(9D 01 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EMiscHelper_002E_003FA0x3a8cae5d_002EHOLM_WINDOW_FPGA_CTRL_0024initializer_0024/* Not supported: data(95 01 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EMath_002E_003FA0x3a8cae5d_002EHALFPI_0024initializer_0024/* Not supported: data(9E 01 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EMath_002E_003FA0x3a8cae5d_002ESQRT2_0024initializer_0024/* Not supported: data(9F 01 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EMiscHelper_002E_003FA0x3a8cae5d_002EHEXSTRINGARRAY_0024initializer_0024/* Not supported: data(93 01 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EMath_002E_003FA0x3a8cae5d_002EPI_F_0024initializer_0024/* Not supported: data(9C 01 00 06) */;

	internal unsafe static sbyte* std_002E_003FA0x3a8cae5d_002E_bad_alloc_Message/* Not supported: data(68 13 4F 00) */;

	internal unsafe static delegate*<void> HOLM_002EMath_002E_003FA0x3a8cae5d_002EPI_0024initializer_0024/* Not supported: data(9B 01 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EMeasure_002E_003FA0x3a8cae5d_002EMILLISEC_TO_CM_0024initializer_0024/* Not supported: data(A5 01 00 06) */;

	internal static _0024ArrayType_0024_0024_0024BY01_0024_0024CBD _003F_003F_C_0040_01EFFIKLCJ_0040n_003F_0024AA_0040/* Not supported: data(6E 00) */;

	internal static _0024ArrayType_0024_0024_0024BY0BH_0040_0024_0024CBD _003F_003F_C_0040_0BH_0040DEIBABBD_0040Playing_003F5and_003F5Recording_003F3_003F_0024AA_0040/* Not supported: data(50 6C 61 79 69 6E 67 20 61 6E 64 20 52 65 63 6F 72 64 69 6E 67 3A 00) */;

	internal static double HOLM_002EMeasure_002E_003FA0x42c1a45b_002ESPEED_OF_SOUND/* Not supported: data(00 00 00 00 00 80 75 40) */;

	internal static double HOLM_002EMeasure_002E_003FA0x42c1a45b_002EMILLISEC_TO_CM/*Field data (rva=0x86e4a0) could not be foundin any section!*/;

	internal static double HOLM_002EMeasure_002E_003FA0x42c1a45b_002ESEC_TO_CM/* Not supported: data(00 00 00 00 00 CC E0 40) */;

	internal static double HOLM_002EMeasure_002E_003FA0x42c1a45b_002ECM_TO_SEC/* Not supported: data(E7 E8 1A 35 5B 7B FE 3E) */;

	internal static double HOLM_002EMeasure_002E_003FA0x42c1a45b_002EMICROSEC_TO_CM/*Field data (rva=0x86e498) could not be foundin any section!*/;

	internal static bool HOLM_002EMeasureGraphics_002E_003FA0x42c1a45b_002EfResponseGuiCallbackReset/*Field data (rva=0x201123) could not be foundin any section!*/;

	internal static bool HOLM_002EMeasureGraphics_002E_003FA0x42c1a45b_002EfResponseGuiCallbackDoEvents/*Field data (rva=0x201336) could not be foundin any section!*/;

	internal static float HOLM_002EMath_002E_003FA0x42c1a45b_002ERadToDeg_F/*Field data (rva=0x86e490) could not be foundin any section!*/;

	internal static float HOLM_002EMath_002E_003FA0x42c1a45b_002EPI_F/*Field data (rva=0x86e46c) could not be foundin any section!*/;

	internal static double HOLM_002EMath_002E_003FA0x42c1a45b_002EHALFPI/*Field data (rva=0x86e488) could not be foundin any section!*/;

	internal static double HOLM_002EMath_002E_003FA0x42c1a45b_002ERadToDeg/*Field data (rva=0x86e480) could not be foundin any section!*/;

	internal static double HOLM_002EMath_002E_003FA0x42c1a45b_002ESQRT2/*Field data (rva=0x86e478) could not be foundin any section!*/;

	internal static double HOLM_002EMath_002E_003FA0x42c1a45b_002EDegToRad/*Field data (rva=0x86e470) could not be foundin any section!*/;

	internal static float HOLM_002EMath_002E_003FA0x42c1a45b_002EDegToRad_F/*Field data (rva=0x86e468) could not be foundin any section!*/;

	internal static float HOLM_002EMath_002E_003FA0x42c1a45b_002ESQRT2_F/*Field data (rva=0x86e294) could not be foundin any section!*/;

	internal static double HOLM_002EMath_002E_003FA0x42c1a45b_002ETWOPI/*Field data (rva=0x86e460) could not be foundin any section!*/;

	internal static double HOLM_002EMath_002E_003FA0x42c1a45b_002EPI/*Field data (rva=0x86e458) could not be foundin any section!*/;

	internal static _0024ArrayType_0024_0024_0024BY0BA_0040_0024_0024CBV_003F_0024basic_string_0040DU_003F_0024char_traits_0040D_0040std_0040_0040V_003F_0024allocator_0040D_00402_0040_0040std_0040_0040 HOLM_002EMiscHelper_002E_003FA0x42c1a45b_002EHEXSTRINGARRAY/*Field data (rva=0x86e298) could not be foundin any section!*/;

	internal static basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E HOLM_002EMiscHelper_002E_003FA0x42c1a45b_002EHOLM_WINDOW_DSPreLab_DEMO/*Field data (rva=0x86e278) could not be foundin any section!*/;

	internal static basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E HOLM_002EMiscHelper_002E_003FA0x42c1a45b_002EHOLM_WINDOW_FPGA_CTRL/*Field data (rva=0x86e25c) could not be foundin any section!*/;

	internal static basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E HOLM_002EMiscHelper_002E_003FA0x42c1a45b_002EHOLM_WINDOW_DSPreLab/*Field data (rva=0x86e240) could not be foundin any section!*/;

	internal unsafe static delegate*<void> HOLM_002EMiscHelper_002E_003FA0x42c1a45b_002EHOLM_WINDOW_DSPreLab_0024initializer_0024/* Not supported: data(AD 01 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EMath_002E_003FA0x42c1a45b_002EDegToRad_0024initializer_0024/* Not supported: data(B9 01 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EMiscHelper_002E_003FA0x42c1a45b_002EHOLM_WINDOW_DSPreLab_DEMO_0024initializer_0024/* Not supported: data(AF 01 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EMath_002E_003FA0x42c1a45b_002ERadToDeg_F_0024initializer_0024/* Not supported: data(B8 01 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EMeasure_002E_003FA0x42c1a45b_002EMICROSEC_TO_CM_0024initializer_0024/* Not supported: data(BC 01 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EMath_002E_003FA0x42c1a45b_002ERadToDeg_0024initializer_0024/* Not supported: data(B7 01 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EMath_002E_003FA0x42c1a45b_002EDegToRad_F_0024initializer_0024/* Not supported: data(BA 01 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EMath_002E_003FA0x42c1a45b_002ESQRT2_F_0024initializer_0024/* Not supported: data(B6 01 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EMath_002E_003FA0x42c1a45b_002ETWOPI_0024initializer_0024/* Not supported: data(B3 01 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EMiscHelper_002E_003FA0x42c1a45b_002EHOLM_WINDOW_FPGA_CTRL_0024initializer_0024/* Not supported: data(AB 01 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EMath_002E_003FA0x42c1a45b_002EHALFPI_0024initializer_0024/* Not supported: data(B4 01 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EMath_002E_003FA0x42c1a45b_002ESQRT2_0024initializer_0024/* Not supported: data(B5 01 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EMiscHelper_002E_003FA0x42c1a45b_002EHEXSTRINGARRAY_0024initializer_0024/* Not supported: data(A9 01 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EMath_002E_003FA0x42c1a45b_002EPI_F_0024initializer_0024/* Not supported: data(B2 01 00 06) */;

	internal unsafe static sbyte* std_002E_003FA0x42c1a45b_002E_bad_alloc_Message/* Not supported: data(68 13 4F 00) */;

	internal unsafe static delegate*<void> HOLM_002EMath_002E_003FA0x42c1a45b_002EPI_0024initializer_0024/* Not supported: data(B1 01 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EMeasure_002E_003FA0x42c1a45b_002EMILLISEC_TO_CM_0024initializer_0024/* Not supported: data(BB 01 00 06) */;

	public unsafe static int** __unep_0040_003FResponseGuiCallback_0040MeasureGraphics_0040HOLM_0040_0040_0024_0024FYAXABV_003F_0024basic_string_0040DU_003F_0024char_traits_0040D_0040std_0040_0040V_003F_0024allocator_0040D_00402_0040_0040std_0040_0040_0040Z/* Not supported: data(C0 AA 43 00) */;

	internal static _0024ArrayType_0024_0024_0024BY0L_0040_0024_0024CBD _003F_003F_C_0040_0L_0040EPCLHKDP_0040Signal_003F4wav_003F_0024AA_0040/* Not supported: data(53 69 67 6E 61 6C 2E 77 61 76 00) */;

	internal static _0024ArrayType_0024_0024_0024BY0O_0040_0024_0024CBD _003F_003F_C_0040_0O_0040CNJLHMKD_0040Recording_003F4wav_003F_0024AA_0040/* Not supported: data(52 65 63 6F 72 64 69 6E 67 2E 77 61 76 00) */;

	internal static _0024ArrayType_0024_0024_0024BY0BA_0040_0024_0024CBD _003F_003F_C_0040_0BA_0040JCHFLDBK_0040Correlation_003F4wav_003F_0024AA_0040/* Not supported: data(43 6F 72 72 65 6C 61 74 69 6F 6E 2E 77 61 76 00) */;

	internal static _0024ArrayType_0024_0024_0024BY0BL_0040_0024_0024CBD _003F_003F_C_0040_0BL_0040PBIMMPON_0040Inverse_003F5measurement_003F5signal_003F_0024AA_0040/* Not supported: data(49 6E 76 65 72 73 65 20 6D 65 61 73 75 72 65 6D 65 6E 74 20 73 69 67 6E 61 6C 00) */;

	internal static _0024ArrayType_0024_0024_0024BY0BD_0040_0024_0024CBD _003F_003F_C_0040_0BD_0040PNKKKLDB_0040Measurement_003F5signal_003F_0024AA_0040/* Not supported: data(4D 65 61 73 75 72 65 6D 65 6E 74 20 73 69 67 6E 61 6C 00) */;

	internal static _0024ArrayType_0024_0024_0024BY0CJ_0040_0024_0024CBD _003F_003F_C_0040_0CJ_0040BNLHIIEM_0040ResponseSaveOpenWave_003F3_003F3DebugRecor_0040/* Not supported: data(52 65 73 70 6F 6E 73 65 53 61 76 65 4F 70 65 6E 57 61 76 65 3A 3A 44 65 62 75 67 52 65 63 6F 72 64 69 6E 67 20 2D 3E 20 00) */;

	internal static _0024ArrayType_0024_0024_0024BY09_0024_0024CBD _003F_003F_C_0040_09JAHJEAMH_0040Recording_003F_0024AA_0040/* Not supported: data(52 65 63 6F 72 64 69 6E 67 00) */;

	internal static _0024ArrayType_0024_0024_0024BY0CG_0040_0024_0024CBD _003F_003F_C_0040_0CG_0040OJEHCAND_0040ResponseSaveOpenWave_003F3_003F3DebugOutpu_0040/* Not supported: data(52 65 73 70 6F 6E 73 65 53 61 76 65 4F 70 65 6E 57 61 76 65 3A 3A 44 65 62 75 67 4F 75 74 70 75 74 20 2D 3E 20 00) */;

	internal static _0024ArrayType_0024_0024_0024BY06_0024_0024CBD _003F_003F_C_0040_06PFDLEJLJ_0040Output_003F_0024AA_0040/* Not supported: data(4F 75 74 70 75 74 00) */;

	internal static _0024ArrayType_0024_0024_0024BY0BD_0040_0024_0024CBD _003F_003F_C_0040_0BD_0040PNGABND_0040Output_003F5with_003F5volume_003F_0024AA_0040/* Not supported: data(4F 75 74 70 75 74 20 77 69 74 68 20 76 6F 6C 75 6D 65 00) */;

	internal static _0024ArrayType_0024_0024_0024BY0CL_0040_0024_0024CBD _003F_003F_C_0040_0CL_0040MIMNMAEA_0040ResponseSaveOpenWave_003F3_003F3DebugCorre_0040/* Not supported: data(52 65 73 70 6F 6E 73 65 53 61 76 65 4F 70 65 6E 57 61 76 65 3A 3A 44 65 62 75 67 43 6F 72 72 65 6C 61 74 69 6F 6E 20 2D 3E 20 00) */;

	internal static _0024ArrayType_0024_0024_0024BY0M_0040_0024_0024CBD _003F_003F_C_0040_0M_0040MJCOOAJL_0040Correlation_003F_0024AA_0040/* Not supported: data(43 6F 72 72 65 6C 61 74 69 6F 6E 00) */;

	internal static double HOLM_002EMeasure_002E_003FA0x6df59541_002ESPEED_OF_SOUND/* Not supported: data(00 00 00 00 00 80 75 40) */;

	internal static double HOLM_002EMeasure_002E_003FA0x6df59541_002EMILLISEC_TO_CM/*Field data (rva=0x86e708) could not be foundin any section!*/;

	internal static double HOLM_002EMeasure_002E_003FA0x6df59541_002ESEC_TO_CM/* Not supported: data(00 00 00 00 00 CC E0 40) */;

	internal static double HOLM_002EMeasure_002E_003FA0x6df59541_002ECM_TO_SEC/* Not supported: data(E7 E8 1A 35 5B 7B FE 3E) */;

	internal static double HOLM_002EMeasure_002E_003FA0x6df59541_002EMICROSEC_TO_CM/*Field data (rva=0x86e700) could not be foundin any section!*/;

	internal static float HOLM_002EMath_002E_003FA0x6df59541_002ERadToDeg_F/*Field data (rva=0x86e6f8) could not be foundin any section!*/;

	internal static float HOLM_002EMath_002E_003FA0x6df59541_002EPI_F/*Field data (rva=0x86e6d4) could not be foundin any section!*/;

	internal static double HOLM_002EMath_002E_003FA0x6df59541_002EHALFPI/*Field data (rva=0x86e6f0) could not be foundin any section!*/;

	internal static double HOLM_002EMath_002E_003FA0x6df59541_002ERadToDeg/*Field data (rva=0x86e6e8) could not be foundin any section!*/;

	internal static double HOLM_002EMath_002E_003FA0x6df59541_002ESQRT2/*Field data (rva=0x86e6e0) could not be foundin any section!*/;

	internal static double HOLM_002EMath_002E_003FA0x6df59541_002EDegToRad/*Field data (rva=0x86e6d8) could not be foundin any section!*/;

	internal static float HOLM_002EMath_002E_003FA0x6df59541_002EDegToRad_F/*Field data (rva=0x86e6d0) could not be foundin any section!*/;

	internal static float HOLM_002EMath_002E_003FA0x6df59541_002ESQRT2_F/*Field data (rva=0x86e4fc) could not be foundin any section!*/;

	internal static double HOLM_002EMath_002E_003FA0x6df59541_002ETWOPI/*Field data (rva=0x86e6c8) could not be foundin any section!*/;

	internal static double HOLM_002EMath_002E_003FA0x6df59541_002EPI/*Field data (rva=0x86e6c0) could not be foundin any section!*/;

	internal static _0024ArrayType_0024_0024_0024BY0BA_0040_0024_0024CBV_003F_0024basic_string_0040DU_003F_0024char_traits_0040D_0040std_0040_0040V_003F_0024allocator_0040D_00402_0040_0040std_0040_0040 HOLM_002EMiscHelper_002E_003FA0x6df59541_002EHEXSTRINGARRAY/*Field data (rva=0x86e500) could not be foundin any section!*/;

	internal static basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E HOLM_002EMiscHelper_002E_003FA0x6df59541_002EHOLM_WINDOW_DSPreLab_DEMO/*Field data (rva=0x86e4e0) could not be foundin any section!*/;

	internal static basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E HOLM_002EMiscHelper_002E_003FA0x6df59541_002EHOLM_WINDOW_FPGA_CTRL/*Field data (rva=0x86e4c4) could not be foundin any section!*/;

	internal static basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E HOLM_002EMiscHelper_002E_003FA0x6df59541_002EHOLM_WINDOW_DSPreLab/*Field data (rva=0x86e4a8) could not be foundin any section!*/;

	internal unsafe static delegate*<void> HOLM_002EMiscHelper_002E_003FA0x6df59541_002EHOLM_WINDOW_DSPreLab_0024initializer_0024/* Not supported: data(CE 01 00 06) */;

	internal static _0024_TypeDescriptor_0024_extraBytes_28 _003F_003F_R0_003FAVResponse_0040Measure_0040HOLM_0040_0040_00408/* Not supported: data(9C 12 4F 00 00 00 00 00 2E 3F 41 56 52 65 73 70 6F 6E 73 65 40 4D 65 61 73 75 72 65 40 48 4F 4C 4D 40 40 00) */;

	internal unsafe static delegate*<void> HOLM_002EMath_002E_003FA0x6df59541_002EDegToRad_0024initializer_0024/* Not supported: data(C6 01 00 06) */;

	internal static _s__RTTIBaseClassDescriptor2 _003F_003F_R1A_0040_003F0A_0040EA_0040ResponseSaveOpenWave_0040Measure_0040HOLM_0040_00408/* Not supported: data(00 5A 5F 00 01 00 00 00 00 00 00 00 FF FF FF FF 00 00 00 00 40 00 00 00 04 77 5E 00) */;

	internal static _s__RTTICompleteObjectLocator _003F_003F_R4ResponseSaveOpenWave_0040Measure_0040HOLM_0040_00406B_0040/* Not supported: data(00 00 00 00 00 00 00 00 00 00 00 00 00 5A 5F 00 04 77 5E 00) */;

	internal unsafe static delegate*<void> HOLM_002EMiscHelper_002E_003FA0x6df59541_002EHOLM_WINDOW_DSPreLab_DEMO_0024initializer_0024/* Not supported: data(D0 01 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EMath_002E_003FA0x6df59541_002ERadToDeg_F_0024initializer_0024/* Not supported: data(C5 01 00 06) */;

	internal static _s__RTTIBaseClassDescriptor2 _003F_003F_R1A_0040_003F0A_0040EA_0040Response_0040Measure_0040HOLM_0040_00408/* Not supported: data(DC 59 5F 00 00 00 00 00 00 00 00 00 FF FF FF FF 00 00 00 00 40 00 00 00 3C 77 5E 00) */;

	internal unsafe static delegate*<void> HOLM_002EMeasure_002E_003FA0x6df59541_002EMICROSEC_TO_CM_0024initializer_0024/* Not supported: data(C9 01 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EMath_002E_003FA0x6df59541_002ERadToDeg_0024initializer_0024/* Not supported: data(C4 01 00 06) */;

	internal static _0024_s__RTTIBaseClassArray_0024_extraBytes_8 _003F_003F_R2ResponseSaveOpenWave_0040Measure_0040HOLM_0040_00408/* Not supported: data(54 77 5E 00 20 77 5E 00 00) */;

	internal unsafe static delegate*<void> HOLM_002EMath_002E_003FA0x6df59541_002EDegToRad_F_0024initializer_0024/* Not supported: data(C7 01 00 06) */;

	internal static _0024_TypeDescriptor_0024_extraBytes_40 _003F_003F_R0_003FAVResponseSaveOpenWave_0040Measure_0040HOLM_0040_0040_00408/* Not supported: data(9C 12 4F 00 00 00 00 00 2E 3F 41 56 52 65 73 70 6F 6E 73 65 53 61 76 65 4F 70 65 6E 57 61 76 65 40 4D 65 61 73 75 72 65 40 48 4F 4C 4D 40 40 00) */;

	internal unsafe static delegate*<void> HOLM_002EMath_002E_003FA0x6df59541_002ESQRT2_F_0024initializer_0024/* Not supported: data(C3 01 00 06) */;

	internal static _s__RTTIClassHierarchyDescriptor _003F_003F_R3Response_0040Measure_0040HOLM_0040_00408/* Not supported: data(00 00 00 00 00 00 00 00 01 00 00 00 4C 77 5E 00) */;

	internal unsafe static delegate*<void> HOLM_002EMath_002E_003FA0x6df59541_002ETWOPI_0024initializer_0024/* Not supported: data(C0 01 00 06) */;

	internal static _0024ArrayType_0024_0024_0024BY03Q6AXXZ _003F_003F_7ResponseSaveOpenWave_0040Measure_0040HOLM_0040_00406B_0040/* Not supported: data(A0 B0 43 00 A0 B2 43 00 D0 B3 43 00 9C 12 4F 00) */;

	internal unsafe static delegate*<void> HOLM_002EMiscHelper_002E_003FA0x6df59541_002EHOLM_WINDOW_FPGA_CTRL_0024initializer_0024/* Not supported: data(CC 01 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EMath_002E_003FA0x6df59541_002EHALFPI_0024initializer_0024/* Not supported: data(C1 01 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EMath_002E_003FA0x6df59541_002ESQRT2_0024initializer_0024/* Not supported: data(C2 01 00 06) */;

	internal static _s__RTTIClassHierarchyDescriptor _003F_003F_R3ResponseSaveOpenWave_0040Measure_0040HOLM_0040_00408/* Not supported: data(00 00 00 00 00 00 00 00 02 00 00 00 14 77 5E 00) */;

	internal unsafe static delegate*<void> HOLM_002EMiscHelper_002E_003FA0x6df59541_002EHEXSTRINGARRAY_0024initializer_0024/* Not supported: data(CA 01 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EMath_002E_003FA0x6df59541_002EPI_F_0024initializer_0024/* Not supported: data(BF 01 00 06) */;

	internal unsafe static sbyte* std_002E_003FA0x6df59541_002E_bad_alloc_Message/* Not supported: data(68 13 4F 00) */;

	internal unsafe static delegate*<void> HOLM_002EMath_002E_003FA0x6df59541_002EPI_0024initializer_0024/* Not supported: data(BE 01 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EMeasure_002E_003FA0x6df59541_002EMILLISEC_TO_CM_0024initializer_0024/* Not supported: data(C8 01 00 06) */;

	internal static _0024_s__RTTIBaseClassArray_0024_extraBytes_4 _003F_003F_R2Response_0040Measure_0040HOLM_0040_00408/* Not supported: data(20 77 5E 00 00) */;

	internal static _0024ArrayType_0024_0024_0024BY0BJ_0040_0024_0024CBD _003F_003F_C_0040_0BJ_0040GMEPPIOJ_0040WWWVersion_003F_0024CI_003F_0024CJ_003F5Exception_003F3_003F6_003F_0024AA_0040/* Not supported: data(57 57 57 56 65 72 73 69 6F 6E 28 29 20 45 78 63 65 70 74 69 6F 6E 3A 0A 00) */;

	internal static _0024ArrayType_0024_0024_0024BY0BK_0040_0024_0024CBD _003F_003F_C_0040_0BK_0040JLCOCJIJ_0040FileVersion_003F_0024CI_003F_0024CJ_003F5Exception_003F3_003F6_003F_0024AA_0040/* Not supported: data(46 69 6C 65 56 65 72 73 69 6F 6E 28 29 20 45 78 63 65 70 74 69 6F 6E 3A 0A 00) */;

	internal static _0024ArrayType_0024_0024_0024BY0BK_0040_0024_0024CBD _003F_003F_C_0040_0BK_0040KOANBOKG_0040Updater_003F3_003F3CheckForUpdate_003F3_003F5_003F_0024AA_0040/* Not supported: data(55 70 64 61 74 65 72 3A 3A 43 68 65 63 6B 46 6F 72 55 70 64 61 74 65 3A 20 00) */;

	internal static _0024ArrayType_0024_0024_0024BY0BE_0040_0024_0024CBD _003F_003F_C_0040_0BE_0040MAEGOEPB_0040_003F5System_003F3_003F3Exception_003F3_003F_0024AA_0040/* Not supported: data(20 53 79 73 74 65 6D 3A 3A 45 78 63 65 70 74 69 6F 6E 3A 00) */;

	internal static _0024ArrayType_0024_0024_0024BY0CE_0040_0024_0024CBD _003F_003F_C_0040_0CE_0040GGJENNFG_0040Updater_003F3_003F3Action_UserGuideDownloa_0040/* Not supported: data(55 70 64 61 74 65 72 3A 3A 41 63 74 69 6F 6E 5F 55 73 65 72 47 75 69 64 65 44 6F 77 6E 6C 6F 61 64 65 64 00) */;

	internal static _0024ArrayType_0024_0024_0024BY0BA_0040_0024_0024CBV_003F_0024basic_string_0040DU_003F_0024char_traits_0040D_0040std_0040_0040V_003F_0024allocator_0040D_00402_0040_0040std_0040_0040 HOLM_002EMiscHelper_002E_003FA0x3d5e82b5_002EHEXSTRINGARRAY/*Field data (rva=0x86e768) could not be foundin any section!*/;

	internal static basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E HOLM_002EMiscHelper_002E_003FA0x3d5e82b5_002EHOLM_WINDOW_DSPreLab_DEMO/*Field data (rva=0x86e748) could not be foundin any section!*/;

	internal static basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E HOLM_002EMiscHelper_002E_003FA0x3d5e82b5_002EHOLM_WINDOW_FPGA_CTRL/*Field data (rva=0x86e72c) could not be foundin any section!*/;

	internal static basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E HOLM_002EMiscHelper_002E_003FA0x3d5e82b5_002EHOLM_WINDOW_DSPreLab/*Field data (rva=0x86e710) could not be foundin any section!*/;

	internal unsafe static delegate*<void> HOLM_002EMiscHelper_002E_003FA0x3d5e82b5_002EHOLM_WINDOW_DSPreLab_0024initializer_0024/* Not supported: data(DB 01 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EMiscHelper_002E_003FA0x3d5e82b5_002EHOLM_WINDOW_DSPreLab_DEMO_0024initializer_0024/* Not supported: data(DD 01 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EMiscHelper_002E_003FA0x3d5e82b5_002EHOLM_WINDOW_FPGA_CTRL_0024initializer_0024/* Not supported: data(D9 01 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EMiscHelper_002E_003FA0x3d5e82b5_002EHEXSTRINGARRAY_0024initializer_0024/* Not supported: data(D7 01 00 06) */;

	internal unsafe static sbyte* std_002E_003FA0x3d5e82b5_002E_bad_alloc_Message/* Not supported: data(68 13 4F 00) */;

	internal static int Mem_002E_003FA0xf2abb64d_002ERunOnceCustomNewHandlerInt/*Field data (rva=0x86eb7c) could not be foundin any section!*/;

	internal unsafe static delegate*<void> Mem_002E_003FA0xf2abb64d_002ERunOnceCustomNewHandlerInt_0024initializer_0024/* Not supported: data(F9 01 00 06) */;

	internal static float HOLM_002EMath_002E_003FA0xf2abb64d_002ERadToDeg_F/*Field data (rva=0x86eb78) could not be foundin any section!*/;

	internal static float HOLM_002EMath_002E_003FA0xf2abb64d_002EPI_F/*Field data (rva=0x86eb54) could not be foundin any section!*/;

	internal static double HOLM_002EMath_002E_003FA0xf2abb64d_002EHALFPI/*Field data (rva=0x86eb70) could not be foundin any section!*/;

	internal static double HOLM_002EMath_002E_003FA0xf2abb64d_002ERadToDeg/*Field data (rva=0x86eb68) could not be foundin any section!*/;

	internal static double HOLM_002EMath_002E_003FA0xf2abb64d_002ESQRT2/*Field data (rva=0x86eb60) could not be foundin any section!*/;

	internal static double HOLM_002EMath_002E_003FA0xf2abb64d_002EDegToRad/*Field data (rva=0x86eb58) could not be foundin any section!*/;

	internal static float HOLM_002EMath_002E_003FA0xf2abb64d_002EDegToRad_F/*Field data (rva=0x86eb50) could not be foundin any section!*/;

	internal static float HOLM_002EMath_002E_003FA0xf2abb64d_002ESQRT2_F/*Field data (rva=0x86e97c) could not be foundin any section!*/;

	internal static double HOLM_002EMath_002E_003FA0xf2abb64d_002ETWOPI/*Field data (rva=0x86eb48) could not be foundin any section!*/;

	internal static double HOLM_002EMath_002E_003FA0xf2abb64d_002EPI/*Field data (rva=0x86eb40) could not be foundin any section!*/;

	internal static _0024ArrayType_0024_0024_0024BY0BA_0040_0024_0024CBV_003F_0024basic_string_0040DU_003F_0024char_traits_0040D_0040std_0040_0040V_003F_0024allocator_0040D_00402_0040_0040std_0040_0040 HOLM_002EMiscHelper_002E_003FA0xf2abb64d_002EHEXSTRINGARRAY/*Field data (rva=0x86e980) could not be foundin any section!*/;

	internal static basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E HOLM_002EMiscHelper_002E_003FA0xf2abb64d_002EHOLM_WINDOW_DSPreLab_DEMO/*Field data (rva=0x86e960) could not be foundin any section!*/;

	internal static basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E HOLM_002EMiscHelper_002E_003FA0xf2abb64d_002EHOLM_WINDOW_FPGA_CTRL/*Field data (rva=0x86e944) could not be foundin any section!*/;

	internal static basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E HOLM_002EMiscHelper_002E_003FA0xf2abb64d_002EHOLM_WINDOW_DSPreLab/*Field data (rva=0x86e928) could not be foundin any section!*/;

	internal unsafe static delegate*<void> HOLM_002EMiscHelper_002E_003FA0xf2abb64d_002EHOLM_WINDOW_DSPreLab_0024initializer_0024/* Not supported: data(F5 01 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EMath_002E_003FA0xf2abb64d_002EDegToRad_0024initializer_0024/* Not supported: data(EF 01 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EMiscHelper_002E_003FA0xf2abb64d_002EHOLM_WINDOW_DSPreLab_DEMO_0024initializer_0024/* Not supported: data(F7 01 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EMath_002E_003FA0xf2abb64d_002ERadToDeg_F_0024initializer_0024/* Not supported: data(EE 01 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EMath_002E_003FA0xf2abb64d_002ERadToDeg_0024initializer_0024/* Not supported: data(ED 01 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EMath_002E_003FA0xf2abb64d_002EDegToRad_F_0024initializer_0024/* Not supported: data(F0 01 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EMath_002E_003FA0xf2abb64d_002ESQRT2_F_0024initializer_0024/* Not supported: data(EC 01 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EMath_002E_003FA0xf2abb64d_002ETWOPI_0024initializer_0024/* Not supported: data(E9 01 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EMiscHelper_002E_003FA0xf2abb64d_002EHOLM_WINDOW_FPGA_CTRL_0024initializer_0024/* Not supported: data(F3 01 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EMath_002E_003FA0xf2abb64d_002EHALFPI_0024initializer_0024/* Not supported: data(EA 01 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EMath_002E_003FA0xf2abb64d_002ESQRT2_0024initializer_0024/* Not supported: data(EB 01 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EMiscHelper_002E_003FA0xf2abb64d_002EHEXSTRINGARRAY_0024initializer_0024/* Not supported: data(F1 01 00 06) */;

	internal unsafe static delegate*<void> HOLM_002EMath_002E_003FA0xf2abb64d_002EPI_F_0024initializer_0024/* Not supported: data(E8 01 00 06) */;

	internal unsafe static sbyte* std_002E_003FA0xf2abb64d_002E_bad_alloc_Message/* Not supported: data(68 13 4F 00) */;

	internal unsafe static delegate*<void> HOLM_002EMath_002E_003FA0xf2abb64d_002EPI_0024initializer_0024/* Not supported: data(E7 01 00 06) */;

	public unsafe static int** __unep_0040_003FCallback_0040HOLM_0040_0040_0024_0024FYAXPBM00H_0040Z/* Not supported: data(20 D4 43 00) */;

	public unsafe static int** __unep_0040_003FStatusCallback_0040HOLM_0040_0040_0024_0024FYAXW4StreamStatus_0040PAudioII_00401_0040_0040Z/* Not supported: data(40 D4 43 00) */;

	public static _0024ArrayType_0024_0024_0024BY0A_0040P6AXXZ __xc_z/* Not supported: data(00) */;

	public static volatile uint __native_vcclrit_reason/* Not supported: data(FF FF FF FF) */;

	public static _0024ArrayType_0024_0024_0024BY0A_0040P6AXXZ __xc_a/* Not supported: data(00) */;

	public static _0024ArrayType_0024_0024_0024BY0A_0040P6AHXZ __xi_a/* Not supported: data(00) */;

	public static volatile __enative_startup_state __native_startup_state/* Not supported: data() */;

	public static _0024ArrayType_0024_0024_0024BY0A_0040P6AHXZ __xi_z/* Not supported: data(00) */;

	public unsafe static volatile void* __native_startup_lock/*Field data (rva=0x86ef44) could not be foundin any section!*/;

	public static volatile uint __native_dllmain_reason/* Not supported: data(FF FF FF FF) */;

	public static _0024ArrayType_0024_0024_0024BY01Q6AXXZ _003F_003F_7type_info_0040_00406B_0040/* Not supported: data(A4 8B 4C 00 78 64 5F 00) */;

	public unsafe static locale.id* __imp__003Fid_0040_003F_0024ctype_0040_W_0040std_0040_00402V0locale_00402_0040A/* Not supported: data(34 C3 1E 00) */;

	public unsafe static StreamInitializer* _003Finstance_0040StreamInitializer_0040PAudioII_0040HOLM_0040_00400PAV123_0040A/*Field data (rva=0x8685a0) could not be foundin any section!*/;

	[return: MarshalAs(UnmanagedType.U1)]
	internal static bool _003CCrtImplementationDetails_003E_002ENativeDll_002EIsSafeForManagedCode()
	{
		if (!(__native_dllmain_reason != uint.MaxValue))
		{
			return true;
		}
		if (__native_vcclrit_reason != uint.MaxValue)
		{
			return true;
		}
		int num = ((!(__native_dllmain_reason == 1) && !(__native_dllmain_reason == 0)) ? 1 : 0);
		return (byte)num != 0;
	}

	internal unsafe static int _003CCrtImplementationDetails_003E_002EDefaultDomain_002EDoNothing(void* cookie)
	{
		GC.KeepAlive(int.MaxValue);
		return 0;
	}

	[return: MarshalAs(UnmanagedType.U1)]
	internal unsafe static bool _003CCrtImplementationDetails_003E_002EDefaultDomain_002EHasPerProcess()
	{
		if (_003FhasPerProcess_0040DefaultDomain_0040_003CCrtImplementationDetails_003E_0040_00400W4State_0040TriBool_00402_0040A == (TriBool.State)2)
		{
			void** ptr = (void**)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003FA0xf084536d_002E__xc_mp_a);
			if (System.Runtime.CompilerServices.Unsafe.IsAddressLessThan(ref _003FA0xf084536d_002E__xc_mp_a, ref _003FA0xf084536d_002E__xc_mp_z))
			{
				do
				{
					if (*(int*)ptr == 0)
					{
						ptr = (void**)((byte*)ptr + 4);
						continue;
					}
					_003FhasPerProcess_0040DefaultDomain_0040_003CCrtImplementationDetails_003E_0040_00400W4State_0040TriBool_00402_0040A = (TriBool.State)(-1);
					return true;
				}
				while (ptr < System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003FA0xf084536d_002E__xc_mp_z));
			}
			_003FhasPerProcess_0040DefaultDomain_0040_003CCrtImplementationDetails_003E_0040_00400W4State_0040TriBool_00402_0040A = (TriBool.State)0;
			return false;
		}
		return _003FhasPerProcess_0040DefaultDomain_0040_003CCrtImplementationDetails_003E_0040_00400W4State_0040TriBool_00402_0040A == (TriBool.State)(-1);
	}

	[return: MarshalAs(UnmanagedType.U1)]
	internal unsafe static bool _003CCrtImplementationDetails_003E_002EDefaultDomain_002EHasNative()
	{
		if (_003FhasNative_0040DefaultDomain_0040_003CCrtImplementationDetails_003E_0040_00400W4State_0040TriBool_00402_0040A == (TriBool.State)2)
		{
			void** ptr = (void**)System.Runtime.CompilerServices.Unsafe.AsPointer(ref __xi_a);
			if (System.Runtime.CompilerServices.Unsafe.IsAddressLessThan(ref __xi_a, ref __xi_z))
			{
				do
				{
					if (*(int*)ptr == 0)
					{
						ptr = (void**)((byte*)ptr + 4);
						continue;
					}
					_003FhasNative_0040DefaultDomain_0040_003CCrtImplementationDetails_003E_0040_00400W4State_0040TriBool_00402_0040A = (TriBool.State)(-1);
					return true;
				}
				while (ptr < System.Runtime.CompilerServices.Unsafe.AsPointer(ref __xi_z));
			}
			void** ptr2 = (void**)System.Runtime.CompilerServices.Unsafe.AsPointer(ref __xc_a);
			if (System.Runtime.CompilerServices.Unsafe.IsAddressLessThan(ref __xc_a, ref __xc_z))
			{
				do
				{
					if (*(int*)ptr2 == 0)
					{
						ptr2 = (void**)((byte*)ptr2 + 4);
						continue;
					}
					_003FhasNative_0040DefaultDomain_0040_003CCrtImplementationDetails_003E_0040_00400W4State_0040TriBool_00402_0040A = (TriBool.State)(-1);
					return true;
				}
				while (ptr2 < System.Runtime.CompilerServices.Unsafe.AsPointer(ref __xc_z));
			}
			_003FhasNative_0040DefaultDomain_0040_003CCrtImplementationDetails_003E_0040_00400W4State_0040TriBool_00402_0040A = (TriBool.State)0;
			return false;
		}
		return _003FhasNative_0040DefaultDomain_0040_003CCrtImplementationDetails_003E_0040_00400W4State_0040TriBool_00402_0040A == (TriBool.State)(-1);
	}

	[return: MarshalAs(UnmanagedType.U1)]
	internal static bool _003CCrtImplementationDetails_003E_002EDefaultDomain_002ENeedsInitialization()
	{
		int num = (((_003CCrtImplementationDetails_003E_002EDefaultDomain_002EHasPerProcess() && !_003FInitializedPerProcess_0040DefaultDomain_0040_003CCrtImplementationDetails_003E_0040_00402_NA) || (_003CCrtImplementationDetails_003E_002EDefaultDomain_002EHasNative() && !_003FInitializedNative_0040DefaultDomain_0040_003CCrtImplementationDetails_003E_0040_00402_NA && __native_startup_state == (__enative_startup_state)0)) ? 1 : 0);
		return (byte)num != 0;
	}

	internal unsafe static void _003CCrtImplementationDetails_003E_002EDefaultDomain_002EInitialize()
	{
		_003CCrtImplementationDetails_003E_002EDoCallBackInDefaultDomain((delegate* unmanaged[Stdcall, Stdcall]<void*, int>)__unep_0040_003FDoNothing_0040DefaultDomain_0040_003CCrtImplementationDetails_003E_0040_0040_0024_0024FCGJPAX_0040Z, null);
	}

	internal static void _003FA0xf084536d_002E_003F_003F__E_003FInitialized_0040CurrentDomain_0040_003CCrtImplementationDetails_003E_0040_0040_0024_0024Q2HA_0040_0040YMXXZ()
	{
		_003FInitialized_0040CurrentDomain_0040_003CCrtImplementationDetails_003E_0040_0040_0024_0024Q2HA = 0;
	}

	internal static void _003FA0xf084536d_002E_003F_003F__E_003FUninitialized_0040CurrentDomain_0040_003CCrtImplementationDetails_003E_0040_0040_0024_0024Q2HA_0040_0040YMXXZ()
	{
		_003FUninitialized_0040CurrentDomain_0040_003CCrtImplementationDetails_003E_0040_0040_0024_0024Q2HA = 0;
	}

	internal static void _003FA0xf084536d_002E_003F_003F__E_003FIsDefaultDomain_0040CurrentDomain_0040_003CCrtImplementationDetails_003E_0040_0040_0024_0024Q2_NA_0040_0040YMXXZ()
	{
		_003FIsDefaultDomain_0040CurrentDomain_0040_003CCrtImplementationDetails_003E_0040_0040_0024_0024Q2_NA = false;
	}

	internal static void _003FA0xf084536d_002E_003F_003F__E_003FInitializedVtables_0040CurrentDomain_0040_003CCrtImplementationDetails_003E_0040_0040_0024_0024Q2W4State_0040Progress_00402_0040A_0040_0040YMXXZ()
	{
		_003FInitializedVtables_0040CurrentDomain_0040_003CCrtImplementationDetails_003E_0040_0040_0024_0024Q2W4State_0040Progress_00402_0040A = (Progress.State)0;
	}

	internal static void _003FA0xf084536d_002E_003F_003F__E_003FInitializedNative_0040CurrentDomain_0040_003CCrtImplementationDetails_003E_0040_0040_0024_0024Q2W4State_0040Progress_00402_0040A_0040_0040YMXXZ()
	{
		_003FInitializedNative_0040CurrentDomain_0040_003CCrtImplementationDetails_003E_0040_0040_0024_0024Q2W4State_0040Progress_00402_0040A = (Progress.State)0;
	}

	internal static void _003FA0xf084536d_002E_003F_003F__E_003FInitializedPerProcess_0040CurrentDomain_0040_003CCrtImplementationDetails_003E_0040_0040_0024_0024Q2W4State_0040Progress_00402_0040A_0040_0040YMXXZ()
	{
		_003FInitializedPerProcess_0040CurrentDomain_0040_003CCrtImplementationDetails_003E_0040_0040_0024_0024Q2W4State_0040Progress_00402_0040A = (Progress.State)0;
	}

	internal static void _003FA0xf084536d_002E_003F_003F__E_003FInitializedPerAppDomain_0040CurrentDomain_0040_003CCrtImplementationDetails_003E_0040_0040_0024_0024Q2W4State_0040Progress_00402_0040A_0040_0040YMXXZ()
	{
		_003FInitializedPerAppDomain_0040CurrentDomain_0040_003CCrtImplementationDetails_003E_0040_0040_0024_0024Q2W4State_0040Progress_00402_0040A = (Progress.State)0;
	}

	[DebuggerStepThrough]
	internal unsafe static void _003CCrtImplementationDetails_003E_002ELanguageSupport_002EInitializeVtables(LanguageSupport* P_0)
	{
		gcroot_003CSystem_003A_003AString_0020_005E_003E_002E_003D((gcroot_003CSystem_003A_003AString_0020_005E_003E*)P_0, "The C++ module failed to load during vtable initialization.\n");
		_003FInitializedVtables_0040CurrentDomain_0040_003CCrtImplementationDetails_003E_0040_0040_0024_0024Q2W4State_0040Progress_00402_0040A = (Progress.State)1;
		_initterm_m((delegate*<void*>*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003FA0xf084536d_002E__xi_vt_a), (delegate*<void*>*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003FA0xf084536d_002E__xi_vt_z));
		_003FInitializedVtables_0040CurrentDomain_0040_003CCrtImplementationDetails_003E_0040_0040_0024_0024Q2W4State_0040Progress_00402_0040A = (Progress.State)2;
	}

	internal unsafe static void _003CCrtImplementationDetails_003E_002ELanguageSupport_002EInitializeDefaultAppDomain(LanguageSupport* P_0)
	{
		gcroot_003CSystem_003A_003AString_0020_005E_003E_002E_003D((gcroot_003CSystem_003A_003AString_0020_005E_003E*)P_0, "The C++ module failed to load while attempting to initialize the default appdomain.\n");
		_003CCrtImplementationDetails_003E_002EDefaultDomain_002EInitialize();
	}

	[DebuggerStepThrough]
	internal unsafe static void _003CCrtImplementationDetails_003E_002ELanguageSupport_002EInitializeNative(LanguageSupport* P_0)
	{
		gcroot_003CSystem_003A_003AString_0020_005E_003E_002E_003D((gcroot_003CSystem_003A_003AString_0020_005E_003E*)P_0, "The C++ module failed to load during native initialization.\n");
		__security_init_cookie();
		_003FInitializedNative_0040DefaultDomain_0040_003CCrtImplementationDetails_003E_0040_00402_NA = true;
		if (!_003CCrtImplementationDetails_003E_002ENativeDll_002EIsSafeForManagedCode())
		{
			_amsg_exit(33);
		}
		if (__native_startup_state == (__enative_startup_state)1)
		{
			_amsg_exit(33);
		}
		else if (__native_startup_state == (__enative_startup_state)0)
		{
			_003FInitializedNative_0040CurrentDomain_0040_003CCrtImplementationDetails_003E_0040_0040_0024_0024Q2W4State_0040Progress_00402_0040A = (Progress.State)1;
			__native_startup_state = (__enative_startup_state)1;
			if (_initterm_e((delegate* unmanaged[Cdecl, Cdecl]<int>*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref __xi_a), (delegate* unmanaged[Cdecl, Cdecl]<int>*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref __xi_z)) != 0)
			{
				_003CCrtImplementationDetails_003E_002EThrowModuleLoadException(gcroot_003CSystem_003A_003AString_0020_005E_003E_002E_002EP_0024AAVString_0040System_0040_0040((gcroot_003CSystem_003A_003AString_0020_005E_003E*)P_0));
			}
			_initterm((delegate* unmanaged[Cdecl, Cdecl]<void>*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref __xc_a), (delegate* unmanaged[Cdecl, Cdecl]<void>*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref __xc_z));
			__native_startup_state = (__enative_startup_state)2;
			_003FInitializedNativeFromCCTOR_0040DefaultDomain_0040_003CCrtImplementationDetails_003E_0040_00402_NA = true;
			_003FInitializedNative_0040CurrentDomain_0040_003CCrtImplementationDetails_003E_0040_0040_0024_0024Q2W4State_0040Progress_00402_0040A = (Progress.State)2;
		}
	}

	[DebuggerStepThrough]
	internal unsafe static void _003CCrtImplementationDetails_003E_002ELanguageSupport_002EInitializePerProcess(LanguageSupport* P_0)
	{
		gcroot_003CSystem_003A_003AString_0020_005E_003E_002E_003D((gcroot_003CSystem_003A_003AString_0020_005E_003E*)P_0, "The C++ module failed to load during process initialization.\n");
		_003FInitializedPerProcess_0040CurrentDomain_0040_003CCrtImplementationDetails_003E_0040_0040_0024_0024Q2W4State_0040Progress_00402_0040A = (Progress.State)1;
		_initatexit_m();
		_initterm_m((delegate*<void*>*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003FA0xf084536d_002E__xc_mp_a), (delegate*<void*>*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003FA0xf084536d_002E__xc_mp_z));
		_003FInitializedPerProcess_0040CurrentDomain_0040_003CCrtImplementationDetails_003E_0040_0040_0024_0024Q2W4State_0040Progress_00402_0040A = (Progress.State)2;
		_003FInitializedPerProcess_0040DefaultDomain_0040_003CCrtImplementationDetails_003E_0040_00402_NA = true;
	}

	[DebuggerStepThrough]
	internal unsafe static void _003CCrtImplementationDetails_003E_002ELanguageSupport_002EInitializePerAppDomain(LanguageSupport* P_0)
	{
		gcroot_003CSystem_003A_003AString_0020_005E_003E_002E_003D((gcroot_003CSystem_003A_003AString_0020_005E_003E*)P_0, "The C++ module failed to load during appdomain initialization.\n");
		_003FInitializedPerAppDomain_0040CurrentDomain_0040_003CCrtImplementationDetails_003E_0040_0040_0024_0024Q2W4State_0040Progress_00402_0040A = (Progress.State)1;
		_initatexit_app_domain();
		_initterm_m((delegate*<void*>*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003FA0xf084536d_002E__xc_ma_a), (delegate*<void*>*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003FA0xf084536d_002E__xc_ma_z));
		_003FInitializedPerAppDomain_0040CurrentDomain_0040_003CCrtImplementationDetails_003E_0040_0040_0024_0024Q2W4State_0040Progress_00402_0040A = (Progress.State)2;
	}

	[DebuggerStepThrough]
	internal unsafe static void _003CCrtImplementationDetails_003E_002ELanguageSupport_002EInitializeUninitializer(LanguageSupport* P_0)
	{
		gcroot_003CSystem_003A_003AString_0020_005E_003E_002E_003D((gcroot_003CSystem_003A_003AString_0020_005E_003E*)P_0, "The C++ module failed to load during registration for the unload events.\n");
		_003CCrtImplementationDetails_003E_002ERegisterModuleUninitializer([ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)] [PrePrepareMethod] (object source, EventArgs arguments) =>
		{
			if (_003FInitialized_0040CurrentDomain_0040_003CCrtImplementationDetails_003E_0040_0040_0024_0024Q2HA != 0 && Interlocked.Exchange(ref _003FUninitialized_0040CurrentDomain_0040_003CCrtImplementationDetails_003E_0040_0040_0024_0024Q2HA, 1) == 0)
			{
				bool num = Interlocked.Decrement(ref _003FCount_0040AllDomains_0040_003CCrtImplementationDetails_003E_0040_00402HA) == 0;
				_app_exit_callback();
				if (num)
				{
					_003CCrtImplementationDetails_003E_002ELanguageSupport_002EUninitializeDefaultDomain();
				}
			}
		});
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	[DebuggerStepThrough]
	internal unsafe static void _003CCrtImplementationDetails_003E_002ELanguageSupport_002E_Initialize(LanguageSupport* P_0)
	{
		_003FIsDefaultDomain_0040CurrentDomain_0040_003CCrtImplementationDetails_003E_0040_0040_0024_0024Q2_NA = AppDomain.CurrentDomain.IsDefaultAppDomain();
		if (_003FIsDefaultDomain_0040CurrentDomain_0040_003CCrtImplementationDetails_003E_0040_0040_0024_0024Q2_NA)
		{
			_003FEntered_0040DefaultDomain_0040_003CCrtImplementationDetails_003E_0040_00402_NA = true;
		}
		_003CCrtImplementationDetails_003E_002EDoDllLanguageSupportValidation();
		void* ptr = _getFiberPtrId();
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
			while (num2 == 0)
			{
				try
				{
				}
				finally
				{
					IntPtr comparand = (IntPtr)0;
					IntPtr value = (IntPtr)ptr;
					void* ptr2 = (void*)Interlocked.CompareExchange(ref System.Runtime.CompilerServices.Unsafe.As<void*, IntPtr>(ref __native_startup_lock), value, comparand);
					if (ptr2 == null)
					{
						num2 = 1;
					}
					else if (ptr2 == ptr)
					{
						num = 1;
						num2 = 1;
					}
				}
				if (num2 == 0)
				{
					Sleep(1000u);
				}
			}
			_003CCrtImplementationDetails_003E_002ELanguageSupport_002EInitializeVtables(P_0);
			if (_003FIsDefaultDomain_0040CurrentDomain_0040_003CCrtImplementationDetails_003E_0040_0040_0024_0024Q2_NA)
			{
				_003CCrtImplementationDetails_003E_002ELanguageSupport_002EInitializeNative(P_0);
				_003CCrtImplementationDetails_003E_002ELanguageSupport_002EInitializePerProcess(P_0);
			}
			else if (_003CCrtImplementationDetails_003E_002EDefaultDomain_002ENeedsInitialization())
			{
				num3 = 1;
			}
		}
		finally
		{
			if (num == 0)
			{
				IntPtr value2 = (IntPtr)0;
				Interlocked.Exchange(ref System.Runtime.CompilerServices.Unsafe.As<void*, IntPtr>(ref __native_startup_lock), value2);
			}
		}
		if (num3 != 0)
		{
			_003CCrtImplementationDetails_003E_002ELanguageSupport_002EInitializeDefaultAppDomain(P_0);
		}
		_003CCrtImplementationDetails_003E_002ELanguageSupport_002EInitializePerAppDomain(P_0);
		_003FInitialized_0040CurrentDomain_0040_003CCrtImplementationDetails_003E_0040_0040_0024_0024Q2HA = 1;
		_003CCrtImplementationDetails_003E_002ELanguageSupport_002EInitializeUninitializer(P_0);
	}

	internal static void _003CCrtImplementationDetails_003E_002ELanguageSupport_002EUninitializeAppDomain()
	{
		_app_exit_callback();
	}

	internal unsafe static int _003CCrtImplementationDetails_003E_002ELanguageSupport_002E_UninitializeDefaultDomain(void* cookie)
	{
		_exit_callback();
		_003FInitializedPerProcess_0040DefaultDomain_0040_003CCrtImplementationDetails_003E_0040_00402_NA = false;
		if (_003FInitializedNativeFromCCTOR_0040DefaultDomain_0040_003CCrtImplementationDetails_003E_0040_00402_NA)
		{
			_cexit();
			__native_startup_state = (__enative_startup_state)0;
			_003FInitializedNativeFromCCTOR_0040DefaultDomain_0040_003CCrtImplementationDetails_003E_0040_00402_NA = false;
		}
		_003FInitializedNative_0040DefaultDomain_0040_003CCrtImplementationDetails_003E_0040_00402_NA = false;
		return 0;
	}

	internal unsafe static void _003CCrtImplementationDetails_003E_002ELanguageSupport_002EUninitializeDefaultDomain()
	{
		if (_003FEntered_0040DefaultDomain_0040_003CCrtImplementationDetails_003E_0040_00402_NA)
		{
			if (AppDomain.CurrentDomain.IsDefaultAppDomain())
			{
				_003CCrtImplementationDetails_003E_002ELanguageSupport_002E_UninitializeDefaultDomain(null);
			}
			else
			{
				_003CCrtImplementationDetails_003E_002EDoCallBackInDefaultDomain((delegate* unmanaged[Stdcall, Stdcall]<void*, int>)__unep_0040_003F_UninitializeDefaultDomain_0040LanguageSupport_0040_003CCrtImplementationDetails_003E_0040_0040_0024_0024FCGJPAX_0040Z, null);
			}
		}
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	[PrePrepareMethod]
	internal static void _003CCrtImplementationDetails_003E_002ELanguageSupport_002EDomainUnload(object source, EventArgs arguments)
	{
		if (_003FInitialized_0040CurrentDomain_0040_003CCrtImplementationDetails_003E_0040_0040_0024_0024Q2HA != 0 && Interlocked.Exchange(ref _003FUninitialized_0040CurrentDomain_0040_003CCrtImplementationDetails_003E_0040_0040_0024_0024Q2HA, 1) == 0)
		{
			bool num = Interlocked.Decrement(ref _003FCount_0040AllDomains_0040_003CCrtImplementationDetails_003E_0040_00402HA) == 0;
			_app_exit_callback();
			if (num)
			{
				_003CCrtImplementationDetails_003E_002ELanguageSupport_002EUninitializeDefaultDomain();
			}
		}
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	[DebuggerStepThrough]
	internal unsafe static void _003CCrtImplementationDetails_003E_002ELanguageSupport_002ECleanup(LanguageSupport* P_0, Exception innerException)
	{
		try
		{
			bool flag = Interlocked.Decrement(ref _003FCount_0040AllDomains_0040_003CCrtImplementationDetails_003E_0040_00402HA) == 0;
			_003CCrtImplementationDetails_003E_002ELanguageSupport_002EUninitializeAppDomain();
			if (flag)
			{
				_003CCrtImplementationDetails_003E_002ELanguageSupport_002EUninitializeDefaultDomain();
			}
		}
		catch (Exception ex)
		{
			_003CCrtImplementationDetails_003E_002EThrowNestedModuleLoadException(innerException, ex);
		}
		catch
		{
			_003CCrtImplementationDetails_003E_002EThrowNestedModuleLoadException(innerException, null);
		}
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	[DebuggerStepThrough]
	internal unsafe static void _003CCrtImplementationDetails_003E_002ELanguageSupport_002EInitialize(LanguageSupport* P_0)
	{
		bool flag = false;
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
			gcroot_003CSystem_003A_003AString_0020_005E_003E_002E_003D((gcroot_003CSystem_003A_003AString_0020_005E_003E*)P_0, "The C++ module failed to load.\n");
			RuntimeHelpers.PrepareConstrainedRegions();
			try
			{
			}
			finally
			{
				Interlocked.Increment(ref _003FCount_0040AllDomains_0040_003CCrtImplementationDetails_003E_0040_00402HA);
				flag = true;
			}
			_003CCrtImplementationDetails_003E_002ELanguageSupport_002E_Initialize(P_0);
		}
		catch (Exception ex)
		{
			if (flag)
			{
				_003CCrtImplementationDetails_003E_002ELanguageSupport_002ECleanup(P_0, ex);
			}
			_003CCrtImplementationDetails_003E_002EThrowModuleLoadException(gcroot_003CSystem_003A_003AString_0020_005E_003E_002E_002EP_0024AAVString_0040System_0040_0040((gcroot_003CSystem_003A_003AString_0020_005E_003E*)P_0), ex);
		}
		catch
		{
			if (flag)
			{
				_003CCrtImplementationDetails_003E_002ELanguageSupport_002ECleanup(P_0, null);
			}
			_003CCrtImplementationDetails_003E_002EThrowModuleLoadException(gcroot_003CSystem_003A_003AString_0020_005E_003E_002E_002EP_0024AAVString_0040System_0040_0040((gcroot_003CSystem_003A_003AString_0020_005E_003E*)P_0), null);
		}
	}

	[DebuggerStepThrough]
	static unsafe _003CModule_003E()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out LanguageSupport languageSupport);
		_003CCrtImplementationDetails_003E_002ELanguageSupport_002E_007Bctor_007D(&languageSupport);
		try
		{
			_003CCrtImplementationDetails_003E_002ELanguageSupport_002EInitialize(&languageSupport);
		}
		catch
		{
			//try-fault
			___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<LanguageSupport*, void>)(&_003CCrtImplementationDetails_003E_002ELanguageSupport_002E_007Bdtor_007D), &languageSupport);
			throw;
		}
		gcroot_003CSystem_003A_003AString_0020_005E_003E_002E_007Bdtor_007D((gcroot_003CSystem_003A_003AString_0020_005E_003E*)(&languageSupport));
	}

	internal unsafe static LanguageSupport* _003CCrtImplementationDetails_003E_002ELanguageSupport_002E_007Bctor_007D(LanguageSupport* P_0)
	{
		gcroot_003CSystem_003A_003AString_0020_005E_003E_002E_007Bctor_007D((gcroot_003CSystem_003A_003AString_0020_005E_003E*)P_0);
		return P_0;
	}

	internal unsafe static void _003CCrtImplementationDetails_003E_002ELanguageSupport_002E_007Bdtor_007D(LanguageSupport* P_0)
	{
		gcroot_003CSystem_003A_003AString_0020_005E_003E_002E_007Bdtor_007D((gcroot_003CSystem_003A_003AString_0020_005E_003E*)P_0);
	}

	[DebuggerStepThrough]
	internal unsafe static gcroot_003CSystem_003A_003AString_0020_005E_003E* gcroot_003CSystem_003A_003AString_0020_005E_003E_002E_007Bctor_007D(gcroot_003CSystem_003A_003AString_0020_005E_003E* P_0)
	{
		*(int*)P_0 = (int)((IntPtr)GCHandle.Alloc(null)).ToPointer();
		return P_0;
	}

	[DebuggerStepThrough]
	internal unsafe static void gcroot_003CSystem_003A_003AString_0020_005E_003E_002E_007Bdtor_007D(gcroot_003CSystem_003A_003AString_0020_005E_003E* P_0)
	{
		IntPtr intPtr = new IntPtr((void*)(int)(*(uint*)P_0));
		((GCHandle)intPtr).Free();
		*(int*)P_0 = 0;
	}

	[DebuggerStepThrough]
	internal unsafe static gcroot_003CSystem_003A_003AString_0020_005E_003E* gcroot_003CSystem_003A_003AString_0020_005E_003E_002E_003D(gcroot_003CSystem_003A_003AString_0020_005E_003E* P_0, string t)
	{
		IntPtr intPtr = new IntPtr((void*)(int)(*(uint*)P_0));
		GCHandle gCHandle = (GCHandle)intPtr;
		gCHandle.Target = t;
		return P_0;
	}

	internal unsafe static string gcroot_003CSystem_003A_003AString_0020_005E_003E_002E_002EP_0024AAVString_0040System_0040_0040(gcroot_003CSystem_003A_003AString_0020_005E_003E* P_0)
	{
		IntPtr intPtr = new IntPtr((void*)(int)(*(uint*)P_0));
		return (string)((GCHandle)intPtr).Target;
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	internal unsafe static void __ehvec_dtor(void* ptr, uint size, int count, delegate*<void*, void> pDtor)
	{
		int num = 0;
		ptr = (int)size * count + (byte*)ptr;
		try
		{
			while (true)
			{
				count--;
				if (count < 0)
				{
					break;
				}
				ptr = (byte*)ptr - (int)size;
				pDtor(ptr);
			}
			num = 1;
		}
		finally
		{
			if (num == 0)
			{
				__ArrayUnwind(ptr, size, count, pDtor);
			}
		}
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	internal unsafe static int _003FA0x978cd4c1_002EArrayUnwindFilter(_EXCEPTION_POINTERS* pExPtrs)
	{
		if (*(int*)(int)(*(uint*)pExPtrs) != -529697949)
		{
			return 0;
		}
		terminate();
		return 0;
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	internal unsafe static void __ArrayUnwind(void* ptr, uint size, int count, delegate*<void*, void> pDtor)
	{
		try
		{
			while (true)
			{
				count--;
				if (count >= 0)
				{
					ptr = (byte*)ptr - (int)size;
					pDtor(ptr);
					continue;
				}
				break;
			}
		}
		catch when (_003FA0x978cd4c1_002EArrayUnwindFilter((_EXCEPTION_POINTERS*)Marshal.GetExceptionPointers()) != 0)
		{
		}
	}

	[DebuggerStepThrough]
	internal unsafe static ValueType _003CCrtImplementationDetails_003E_002EAtExitLock_002E_handle()
	{
		if (_003F_lock_0040AtExitLock_0040_003CCrtImplementationDetails_003E_0040_0040_0024_0024Q0PAXA != null)
		{
			IntPtr value = new IntPtr(_003F_lock_0040AtExitLock_0040_003CCrtImplementationDetails_003E_0040_0040_0024_0024Q0PAXA);
			return GCHandle.FromIntPtr(value);
		}
		return null;
	}

	[DebuggerStepThrough]
	internal unsafe static void _003CCrtImplementationDetails_003E_002EAtExitLock_002E_lock_Set(object value)
	{
		ValueType valueType = _003CCrtImplementationDetails_003E_002EAtExitLock_002E_handle();
		if (valueType == null)
		{
			valueType = GCHandle.Alloc(value);
			_003F_lock_0040AtExitLock_0040_003CCrtImplementationDetails_003E_0040_0040_0024_0024Q0PAXA = GCHandle.ToIntPtr((GCHandle)valueType).ToPointer();
		}
		else
		{
			((GCHandle)valueType).Target = value;
		}
	}

	[DebuggerStepThrough]
	internal static object _003CCrtImplementationDetails_003E_002EAtExitLock_002E_lock_Get()
	{
		ValueType valueType = _003CCrtImplementationDetails_003E_002EAtExitLock_002E_handle();
		if (valueType != null)
		{
			return ((GCHandle)valueType).Target;
		}
		return null;
	}

	[DebuggerStepThrough]
	internal unsafe static void _003CCrtImplementationDetails_003E_002EAtExitLock_002E_lock_Destruct()
	{
		ValueType valueType = _003CCrtImplementationDetails_003E_002EAtExitLock_002E_handle();
		if (valueType != null)
		{
			((GCHandle)valueType).Free();
			_003F_lock_0040AtExitLock_0040_003CCrtImplementationDetails_003E_0040_0040_0024_0024Q0PAXA = null;
		}
	}

	[DebuggerStepThrough]
	[return: MarshalAs(UnmanagedType.U1)]
	internal static bool _003CCrtImplementationDetails_003E_002EAtExitLock_002EIsInitialized()
	{
		return _003CCrtImplementationDetails_003E_002EAtExitLock_002E_lock_Get() != null;
	}

	[DebuggerStepThrough]
	internal unsafe static void _003CCrtImplementationDetails_003E_002EAtExitLock_002EAddRef()
	{
		if (!_003CCrtImplementationDetails_003E_002EAtExitLock_002EIsInitialized())
		{
			object value = new object();
			_003F_lock_0040AtExitLock_0040_003CCrtImplementationDetails_003E_0040_0040_0024_0024Q0PAXA = null;
			_003CCrtImplementationDetails_003E_002EAtExitLock_002E_lock_Set(value);
			_003F_ref_count_0040AtExitLock_0040_003CCrtImplementationDetails_003E_0040_0040_0024_0024Q0HA = 0;
		}
		_003F_ref_count_0040AtExitLock_0040_003CCrtImplementationDetails_003E_0040_0040_0024_0024Q0HA++;
	}

	[DebuggerStepThrough]
	[return: MarshalAs(UnmanagedType.U1)]
	internal static bool _003FA0xc4f9df4a_002E__global_lock()
	{
		bool result = false;
		if (_003CCrtImplementationDetails_003E_002EAtExitLock_002EIsInitialized())
		{
			Monitor.Enter(_003CCrtImplementationDetails_003E_002EAtExitLock_002E_lock_Get());
			result = true;
		}
		return result;
	}

	[DebuggerStepThrough]
	[return: MarshalAs(UnmanagedType.U1)]
	internal static bool _003FA0xc4f9df4a_002E__global_unlock()
	{
		bool result = false;
		if (_003CCrtImplementationDetails_003E_002EAtExitLock_002EIsInitialized())
		{
			Monitor.Exit(_003CCrtImplementationDetails_003E_002EAtExitLock_002E_lock_Get());
			result = true;
		}
		return result;
	}

	[DebuggerStepThrough]
	[return: MarshalAs(UnmanagedType.U1)]
	internal static bool _003FA0xc4f9df4a_002E__alloc_global_lock()
	{
		_003CCrtImplementationDetails_003E_002EAtExitLock_002EAddRef();
		return _003CCrtImplementationDetails_003E_002EAtExitLock_002EIsInitialized();
	}

	[DebuggerStepThrough]
	internal static void _003FA0xc4f9df4a_002E__dealloc_global_lock()
	{
		_003F_ref_count_0040AtExitLock_0040_003CCrtImplementationDetails_003E_0040_0040_0024_0024Q0HA--;
		if (_003F_ref_count_0040AtExitLock_0040_003CCrtImplementationDetails_003E_0040_0040_0024_0024Q0HA == 0)
		{
			_003CCrtImplementationDetails_003E_002EAtExitLock_002E_lock_Destruct();
		}
	}

	internal unsafe static int _atexit_helper(delegate*<void> func, uint* __pexit_list_size, delegate*<void>** __ponexitend_e, delegate*<void>** __ponexitbegin_e)
	{
		delegate*<void> delegate_002A = null;
		if (func == (delegate*<void>)null)
		{
			return -1;
		}
		if (_003FA0xc4f9df4a_002E__global_lock())
		{
			try
			{
				delegate*<void>* ptr = (delegate*<void>*)_decode_pointer((void*)(int)(*(uint*)__ponexitbegin_e));
				delegate*<void>* ptr2 = (delegate*<void>*)_decode_pointer((void*)(int)(*(uint*)__ponexitend_e));
				delegate*<void>* ptr3 = (delegate*<void>*)((byte*)ptr2 - (nuint)ptr);
				if ((nuint)(int)(*__pexit_list_size - 1) < (nuint)ptr3 >> 2)
				{
					try
					{
						uint num = *__pexit_list_size * 4;
						uint num2 = ((num >= 2048) ? 2048u : num);
						IntPtr cb = new IntPtr((int)(num + num2));
						IntPtr pv = new IntPtr(ptr);
						IntPtr intPtr = Marshal.ReAllocHGlobal(pv, cb);
						ptr2 = (delegate*<void>*)((byte*)intPtr.ToPointer() + (nuint)ptr3);
						ptr = (delegate*<void>*)intPtr.ToPointer();
						uint num3 = *__pexit_list_size;
						uint num4 = ((512 >= num3) ? num3 : 512u);
						*__pexit_list_size = num3 + num4;
					}
					catch (OutOfMemoryException)
					{
						IntPtr cb2 = new IntPtr((int)(*__pexit_list_size * 4 + 8));
						IntPtr pv2 = new IntPtr(ptr);
						IntPtr intPtr2 = Marshal.ReAllocHGlobal(pv2, cb2);
						ptr2 = (delegate*<void>*)((byte*)intPtr2.ToPointer() - (nuint)ptr + (nuint)ptr2);
						ptr = (delegate*<void>*)intPtr2.ToPointer();
						*__pexit_list_size += 4u;
					}
				}
				*(int*)ptr2 = (int)func;
				ptr2 = (delegate*<void>*)((byte*)ptr2 + 4);
				delegate_002A = func;
				*(int*)__ponexitbegin_e = (int)_encode_pointer(ptr);
				*(int*)__ponexitend_e = (int)_encode_pointer(ptr2);
			}
			catch (OutOfMemoryException)
			{
			}
			finally
			{
				_003FA0xc4f9df4a_002E__global_unlock();
			}
			if (delegate_002A != (delegate*<void>)null)
			{
				return 0;
			}
		}
		return -1;
	}

	internal unsafe static void _exit_callback()
	{
		if (_003FA0xc4f9df4a_002E__exit_list_size == 0)
		{
			return;
		}
		delegate*<void>* ptr = (delegate*<void>*)_decode_pointer(_003FA0xc4f9df4a_002E__onexitbegin_m);
		delegate*<void>* ptr2 = (delegate*<void>*)_decode_pointer(_003FA0xc4f9df4a_002E__onexitend_m);
		if (ptr != (delegate*<void>*)(-1) && ptr != null && ptr2 != null)
		{
			delegate*<void>* ptr3 = ptr;
			delegate*<void>* ptr4 = ptr2;
			while (true)
			{
				ptr2 = (delegate*<void>*)((byte*)ptr2 - 4);
				if (ptr2 < ptr)
				{
					break;
				}
				if ((void*)(*(int*)ptr2) != _encoded_null())
				{
					void* intPtr = _decode_pointer((void*)(int)(*(uint*)ptr2));
					*(int*)ptr2 = (int)_encoded_null();
					((delegate*<void>)intPtr)();
					delegate*<void>* ptr5 = (delegate*<void>*)_decode_pointer(_003FA0xc4f9df4a_002E__onexitbegin_m);
					delegate*<void>* ptr6 = (delegate*<void>*)_decode_pointer(_003FA0xc4f9df4a_002E__onexitend_m);
					if (ptr3 != ptr5 || ptr4 != ptr6)
					{
						ptr3 = ptr5;
						ptr = ptr5;
						ptr4 = ptr6;
						ptr2 = ptr6;
					}
				}
			}
			IntPtr hglobal = new IntPtr(ptr);
			Marshal.FreeHGlobal(hglobal);
		}
		_003FA0xc4f9df4a_002E__dealloc_global_lock();
	}

	[DebuggerStepThrough]
	internal unsafe static int _initatexit_m()
	{
		int result = 0;
		if (_003FA0xc4f9df4a_002E__alloc_global_lock())
		{
			_003FA0xc4f9df4a_002E__onexitbegin_m = (delegate*<void>*)_encode_pointer(Marshal.AllocHGlobal(128).ToPointer());
			_003FA0xc4f9df4a_002E__onexitend_m = _003FA0xc4f9df4a_002E__onexitbegin_m;
			_003FA0xc4f9df4a_002E__exit_list_size = 32u;
			result = 1;
		}
		return result;
	}

	internal unsafe static int _atexit_m(delegate*<void> func)
	{
		return _atexit_helper((delegate*<void>)_encode_pointer(func), (uint*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003FA0xc4f9df4a_002E__exit_list_size), (delegate*<void>**)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003FA0xc4f9df4a_002E__onexitend_m), (delegate*<void>**)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003FA0xc4f9df4a_002E__onexitbegin_m));
	}

	[DebuggerStepThrough]
	internal unsafe static int _initatexit_app_domain()
	{
		if (_003FA0xc4f9df4a_002E__alloc_global_lock())
		{
			__onexitbegin_app_domain = (delegate*<void>*)_encode_pointer(Marshal.AllocHGlobal(128).ToPointer());
			__onexitend_app_domain = __onexitbegin_app_domain;
			__exit_list_size_app_domain = 32u;
		}
		return 1;
	}

	internal unsafe static void _app_exit_callback()
	{
		if (__exit_list_size_app_domain == 0)
		{
			return;
		}
		delegate*<void>* ptr = (delegate*<void>*)_decode_pointer(__onexitbegin_app_domain);
		delegate*<void>* ptr2 = (delegate*<void>*)_decode_pointer(__onexitend_app_domain);
		try
		{
			if (ptr == (delegate*<void>*)(-1) || ptr == null || ptr2 == null)
			{
				return;
			}
			delegate*<void> delegate_002A = null;
			delegate*<void>* ptr3 = ptr;
			delegate*<void>* ptr4 = ptr2;
			while (true)
			{
				delegate*<void>* ptr5 = null;
				delegate*<void>* ptr6 = null;
				do
				{
					ptr2 = (delegate*<void>*)((byte*)ptr2 - 4);
				}
				while (ptr2 >= ptr && (void*)(*(int*)ptr2) == _encoded_null());
				if (ptr2 >= ptr)
				{
					delegate_002A = (delegate*<void>)_decode_pointer((void*)(int)(*(uint*)ptr2));
					*(int*)ptr2 = (int)_encoded_null();
					delegate_002A();
					delegate*<void>* ptr7 = (delegate*<void>*)_decode_pointer(__onexitbegin_app_domain);
					delegate*<void>* ptr8 = (delegate*<void>*)_decode_pointer(__onexitend_app_domain);
					if (ptr3 != ptr7 || ptr4 != ptr8)
					{
						ptr3 = ptr7;
						ptr = ptr7;
						ptr4 = ptr8;
						ptr2 = ptr8;
					}
					continue;
				}
				break;
			}
		}
		finally
		{
			IntPtr hglobal = new IntPtr(ptr);
			Marshal.FreeHGlobal(hglobal);
			_003FA0xc4f9df4a_002E__dealloc_global_lock();
		}
	}

	[DebuggerStepThrough]
	internal unsafe static int _atexit_m_appdomain(delegate*<void> func)
	{
		return _atexit_helper((delegate*<void>)_encode_pointer(func), (uint*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref __exit_list_size_app_domain), (delegate*<void>**)System.Runtime.CompilerServices.Unsafe.AsPointer(ref __onexitend_app_domain), (delegate*<void>**)System.Runtime.CompilerServices.Unsafe.AsPointer(ref __onexitbegin_app_domain));
	}

	internal unsafe static void std_002Ebad_alloc_002E_007Bdtor_007D(bad_alloc* P_0)
	{
		*(int*)P_0 = (int)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_7bad_alloc_0040std_0040_00406B_0040);
		std_002Eexception_002E_007Bdtor_007D((exception*)P_0);
	}

	internal unsafe static void* std_002Ebad_alloc_002E__vecDelDtor(bad_alloc* P_0, uint P_1)
	{
		if ((P_1 & 2u) != 0)
		{
			bad_alloc* ptr = (bad_alloc*)((byte*)P_0 - 4);
			__ehvec_dtor(P_0, 12u, *(int*)ptr, (delegate*<void*, void>)(delegate*<bad_alloc*, void>)(&std_002Ebad_alloc_002E_007Bdtor_007D));
			if ((P_1 & (true ? 1u : 0u)) != 0)
			{
				delete(ptr);
			}
			return ptr;
		}
		*(int*)P_0 = (int)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_7bad_alloc_0040std_0040_00406B_0040);
		std_002Eexception_002E_007Bdtor_007D((exception*)P_0);
		if ((P_1 & (true ? 1u : 0u)) != 0)
		{
			delete(P_0);
		}
		return P_0;
	}

	internal unsafe static void std_002Elogic_error_002E_007Bdtor_007D(logic_error* P_0)
	{
		*(int*)P_0 = (int)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_7logic_error_0040std_0040_00406B_0040);
		try
		{
			std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)((byte*)P_0 + 12));
		}
		catch
		{
			//try-fault
			___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<exception*, void>)(&std_002Eexception_002E_007Bdtor_007D), P_0);
			throw;
		}
		std_002Eexception_002E_007Bdtor_007D((exception*)P_0);
	}

	internal unsafe static void* std_002Elogic_error_002E__vecDelDtor(logic_error* P_0, uint P_1)
	{
		if ((P_1 & 2u) != 0)
		{
			logic_error* ptr = (logic_error*)((byte*)P_0 - 4);
			__ehvec_dtor(P_0, 40u, *(int*)ptr, (delegate*<void*, void>)(delegate*<logic_error*, void>)(&std_002Elogic_error_002E_007Bdtor_007D));
			if ((P_1 & (true ? 1u : 0u)) != 0)
			{
				delete_005B_005D(ptr);
			}
			return ptr;
		}
		*(int*)P_0 = (int)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_7logic_error_0040std_0040_00406B_0040);
		try
		{
			std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)((byte*)P_0 + 12));
		}
		catch
		{
			//try-fault
			___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<exception*, void>)(&std_002Eexception_002E_007Bdtor_007D), P_0);
			throw;
		}
		std_002Eexception_002E_007Bdtor_007D((exception*)P_0);
		if ((P_1 & (true ? 1u : 0u)) != 0)
		{
			delete(P_0);
		}
		return P_0;
	}

	internal unsafe static void std_002Eout_of_range_002E_007Bdtor_007D(out_of_range* P_0)
	{
		*(int*)P_0 = (int)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_7out_of_range_0040std_0040_00406B_0040);
		*(int*)P_0 = (int)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_7logic_error_0040std_0040_00406B_0040);
		try
		{
			std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)((byte*)P_0 + 12));
		}
		catch
		{
			//try-fault
			___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<exception*, void>)(&std_002Eexception_002E_007Bdtor_007D), P_0);
			throw;
		}
		std_002Eexception_002E_007Bdtor_007D((exception*)P_0);
	}

	internal unsafe static void* std_002Eout_of_range_002E__vecDelDtor(out_of_range* P_0, uint P_1)
	{
		if ((P_1 & 2u) != 0)
		{
			out_of_range* ptr = (out_of_range*)((byte*)P_0 - 4);
			__ehvec_dtor(P_0, 40u, *(int*)ptr, (delegate*<void*, void>)(delegate*<out_of_range*, void>)(&std_002Eout_of_range_002E_007Bdtor_007D));
			if ((P_1 & (true ? 1u : 0u)) != 0)
			{
				delete_005B_005D(ptr);
			}
			return ptr;
		}
		*(int*)P_0 = (int)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_7out_of_range_0040std_0040_00406B_0040);
		*(int*)P_0 = (int)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_7logic_error_0040std_0040_00406B_0040);
		try
		{
			std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)((byte*)P_0 + 12));
		}
		catch
		{
			//try-fault
			___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<exception*, void>)(&std_002Eexception_002E_007Bdtor_007D), P_0);
			throw;
		}
		std_002Eexception_002E_007Bdtor_007D((exception*)P_0);
		if ((P_1 & (true ? 1u : 0u)) != 0)
		{
			delete(P_0);
		}
		return P_0;
	}

	internal unsafe static void _AtModuleExit_m(delegate*<void> pf)
	{
		if (_atexit_m_appdomain(pf) != 0)
		{
			abort();
		}
	}

	internal unsafe static void std_002E_Fac_node_002E_007Bdtor_007D(_Fac_node* P_0)
	{
		locale.facet* ptr = std_002Elocale_002Efacet_002E_Decref((locale.facet*)(int)(*(uint*)((byte*)P_0 + 4)));
		if (ptr != null)
		{
			((delegate* unmanaged[Thiscall, Thiscall]<IntPtr, uint, void*>)(int)(*(uint*)(int)(*(uint*)ptr)))((nint)ptr, 1u);
		}
	}

	internal unsafe static void _Fac_tidy_m()
	{
		bool flag = false;
		int num = 0;
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
			RuntimeHelpers.PrepareConstrainedRegions();
			try
			{
			}
			finally
			{
				std_002E_Lockit_002E_Lockit_ctor(num);
				flag = true;
			}
			while (std_002E_003FA0xebe6e0bc_002E_Fac_head != null)
			{
				_Fac_node* ptr = std_002E_003FA0xebe6e0bc_002E_Fac_head;
				std_002E_003FA0xebe6e0bc_002E_Fac_head = (_Fac_node*)(int)(*(uint*)std_002E_003FA0xebe6e0bc_002E_Fac_head);
				_Fac_node* ptr2 = ptr;
				_Fac_node* ptr3 = ptr;
				void* ptr4 = std_002E_Fac_node_002E__delDtor(ptr, 1u);
			}
		}
		finally
		{
			if (flag)
			{
				std_002E_Lockit_002E_Lockit_dtor(num);
			}
		}
	}

	internal unsafe static void* std_002E_Fac_node_002E__delDtor(_Fac_node* P_0, uint P_1)
	{
		std_002E_Fac_node_002E_007Bdtor_007D(P_0);
		if ((P_1 & (true ? 1u : 0u)) != 0)
		{
			delete(P_0);
		}
		return P_0;
	}

	internal unsafe static void std_002Elocale_002Efacet_002Efacet_Register_m(locale.facet* P_0)
	{
		if (std_002E_003FA0xebe6e0bc_002E_Fac_head == null)
		{
			_AtModuleExit_m((delegate*<void>)(&_Fac_tidy_m));
		}
		_Fac_node* ptr = (_Fac_node*)@new(8u);
		_Fac_node* ptr2;
		try
		{
			if (ptr != null)
			{
				*(int*)ptr = (int)std_002E_003FA0xebe6e0bc_002E_Fac_head;
				*(int*)((byte*)ptr + 4) = (int)P_0;
				ptr2 = ptr;
			}
			else
			{
				ptr2 = null;
			}
		}
		catch
		{
			//try-fault
			delete(ptr);
			throw;
		}
		std_002E_003FA0xebe6e0bc_002E_Fac_head = ptr2;
	}

	[DebuggerStepThrough]
	internal unsafe static int _initterm_e(delegate* unmanaged[Cdecl, Cdecl]<int>* pfbegin, delegate* unmanaged[Cdecl, Cdecl]<int>* pfend)
	{
		int num = 0;
		if (pfbegin < pfend)
		{
			while (num == 0)
			{
				uint num2 = *(uint*)pfbegin;
				if (num2 != 0)
				{
					num = ((delegate* unmanaged[Cdecl, Cdecl]<int>)(int)num2)();
				}
				pfbegin = (delegate* unmanaged[Cdecl, Cdecl]<int>*)((byte*)pfbegin + 4);
				if (pfbegin >= pfend)
				{
					break;
				}
			}
		}
		return num;
	}

	[DebuggerStepThrough]
	internal unsafe static void _initterm(delegate* unmanaged[Cdecl, Cdecl]<void>* pfbegin, delegate* unmanaged[Cdecl, Cdecl]<void>* pfend)
	{
		if (pfbegin >= pfend)
		{
			return;
		}
		do
		{
			uint num = *(uint*)pfbegin;
			if (num != 0)
			{
				((delegate* unmanaged[Cdecl, Cdecl]<void>)(int)num)();
			}
			pfbegin = (delegate* unmanaged[Cdecl, Cdecl]<void>*)((byte*)pfbegin + 4);
		}
		while (pfbegin < pfend);
	}

	[DebuggerStepThrough]
	internal static ModuleHandle _003CCrtImplementationDetails_003E_002EThisModule_002EHandle()
	{
		return typeof(ThisModule).Module.ModuleHandle;
	}

	[DebuggerStepThrough]
	internal unsafe static void _initterm_m(delegate*<void*>* pfbegin, delegate*<void*>* pfend)
	{
		if (pfbegin >= pfend)
		{
			return;
		}
		do
		{
			uint num = *(uint*)pfbegin;
			if (num != 0)
			{
				_003CCrtImplementationDetails_003E_002EThisModule_002EResolveMethod_003Cvoid_0020const_0020_002A_0020__clrcall_0028void_0029_003E((delegate*<void*>)(int)num)();
			}
			pfbegin = (delegate*<void*>*)((byte*)pfbegin + 4);
		}
		while (pfbegin < pfend);
	}

	[DebuggerStepThrough]
	internal unsafe static delegate*<void*> _003CCrtImplementationDetails_003E_002EThisModule_002EResolveMethod_003Cvoid_0020const_0020_002A_0020__clrcall_0028void_0029_003E(delegate*<void*> methodToken)
	{
		return (delegate*<void*>)_003CCrtImplementationDetails_003E_002EThisModule_002EHandle().ResolveMethodHandle((int)methodToken).GetFunctionPointer().ToPointer();
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	internal unsafe static void ___CxxCallUnwindDtor(delegate*<void*, void> pDtor, void* pThis)
	{
		try
		{
			pDtor(pThis);
		}
		catch when (__FrameUnwindFilter((_EXCEPTION_POINTERS*)Marshal.GetExceptionPointers()) != 0)
		{
		}
	}

	internal unsafe static void _003FA0x2b63ed34_002E_003F_003F__E_003FA0x2b63ed34_0040HEXSTRINGARRAY_0040MiscHelper_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EMiscHelper_002E_003FA0x2b63ed34_002EHEXSTRINGARRAY), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01GBGANLPD_00400_003F_0024AA_0040));
		try
		{
			std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x2b63ed34_002EHEXSTRINGARRAY, 28)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01HIHLOKLC_00401_003F_0024AA_0040));
			try
			{
				std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x2b63ed34_002EHEXSTRINGARRAY, 56)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01FDFGLJHB_00402_003F_0024AA_0040));
				try
				{
					std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x2b63ed34_002EHEXSTRINGARRAY, 84)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01EKENIIDA_00403_003F_0024AA_0040));
					try
					{
						std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x2b63ed34_002EHEXSTRINGARRAY, 112)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01FAMBOPH_00404_003F_0024AA_0040));
						try
						{
							std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x2b63ed34_002EHEXSTRINGARRAY, 140)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01BMBHCPLG_00405_003F_0024AA_0040));
							try
							{
								std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x2b63ed34_002EHEXSTRINGARRAY, 168)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01DHDKHMHF_00406_003F_0024AA_0040));
								try
								{
									std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x2b63ed34_002EHEXSTRINGARRAY, 196)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01COCBENDE_00407_003F_0024AA_0040));
									try
									{
										std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x2b63ed34_002EHEXSTRINGARRAY, 224)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01KJLJFBPL_00408_003F_0024AA_0040));
										try
										{
											std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x2b63ed34_002EHEXSTRINGARRAY, 252)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01LAKCGALK_00409_003F_0024AA_0040));
											try
											{
												std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x2b63ed34_002EHEXSTRINGARRAY, 280)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01FHEEJDEE_0040A_003F_0024AA_0040));
												try
												{
													std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x2b63ed34_002EHEXSTRINGARRAY, 308)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01HMGJMAIH_0040B_003F_0024AA_0040));
													try
													{
														std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x2b63ed34_002EHEXSTRINGARRAY, 336)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01GFHCPBMG_0040C_003F_0024AA_0040));
														try
														{
															std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x2b63ed34_002EHEXSTRINGARRAY, 364)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01CKDDGHAB_0040D_003F_0024AA_0040));
															try
															{
																std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x2b63ed34_002EHEXSTRINGARRAY, 392)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01DDCIFGEA_0040E_003F_0024AA_0040));
																try
																{
																	std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x2b63ed34_002EHEXSTRINGARRAY, 420)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01BIAFAFID_0040F_003F_0024AA_0040));
																}
																catch
																{
																	//try-fault
																	___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x2b63ed34_002EHEXSTRINGARRAY, 392)));
																	throw;
																}
															}
															catch
															{
																//try-fault
																___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x2b63ed34_002EHEXSTRINGARRAY, 364)));
																throw;
															}
														}
														catch
														{
															//try-fault
															___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x2b63ed34_002EHEXSTRINGARRAY, 336)));
															throw;
														}
													}
													catch
													{
														//try-fault
														___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x2b63ed34_002EHEXSTRINGARRAY, 308)));
														throw;
													}
												}
												catch
												{
													//try-fault
													___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x2b63ed34_002EHEXSTRINGARRAY, 280)));
													throw;
												}
											}
											catch
											{
												//try-fault
												___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x2b63ed34_002EHEXSTRINGARRAY, 252)));
												throw;
											}
										}
										catch
										{
											//try-fault
											___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x2b63ed34_002EHEXSTRINGARRAY, 224)));
											throw;
										}
									}
									catch
									{
										//try-fault
										___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x2b63ed34_002EHEXSTRINGARRAY, 196)));
										throw;
									}
								}
								catch
								{
									//try-fault
									___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x2b63ed34_002EHEXSTRINGARRAY, 168)));
									throw;
								}
							}
							catch
							{
								//try-fault
								___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x2b63ed34_002EHEXSTRINGARRAY, 140)));
								throw;
							}
						}
						catch
						{
							//try-fault
							___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x2b63ed34_002EHEXSTRINGARRAY, 112)));
							throw;
						}
					}
					catch
					{
						//try-fault
						___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x2b63ed34_002EHEXSTRINGARRAY, 84)));
						throw;
					}
				}
				catch
				{
					//try-fault
					___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x2b63ed34_002EHEXSTRINGARRAY, 56)));
					throw;
				}
			}
			catch
			{
				//try-fault
				___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x2b63ed34_002EHEXSTRINGARRAY, 28)));
				throw;
			}
		}
		catch
		{
			//try-fault
			___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EMiscHelper_002E_003FA0x2b63ed34_002EHEXSTRINGARRAY));
			throw;
		}
		_atexit_m((delegate*<void>)(&_003FA0x2b63ed34_002E_003F_003F__F_003FA0x2b63ed34_0040HEXSTRINGARRAY_0040MiscHelper_0040HOLM_0040_0040YMXXZ));
	}

	internal unsafe static void _003FA0x2b63ed34_002E_003F_003F__F_003FA0x2b63ed34_0040HEXSTRINGARRAY_0040MiscHelper_0040HOLM_0040_0040YMXXZ()
	{
		__ehvec_dtor(System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EMiscHelper_002E_003FA0x2b63ed34_002EHEXSTRINGARRAY), 28u, 16, (delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D));
	}

	internal unsafe static void _003FA0x2b63ed34_002E_003F_003F__E_003FA0x2b63ed34_0040HOLM_WINDOW_FPGA_CTRL_0040MiscHelper_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EMiscHelper_002E_003FA0x2b63ed34_002EHOLM_WINDOW_FPGA_CTRL), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_0BD_0040CPFABDBC_0040HOLMFpgaController_003F_0024AA_0040));
		_atexit_m((delegate*<void>)(&_003FA0x2b63ed34_002E_003F_003F__F_003FA0x2b63ed34_0040HOLM_WINDOW_FPGA_CTRL_0040MiscHelper_0040HOLM_0040_0040YMXXZ));
	}

	internal unsafe static void _003FA0x2b63ed34_002E_003F_003F__F_003FA0x2b63ed34_0040HOLM_WINDOW_FPGA_CTRL_0040MiscHelper_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EMiscHelper_002E_003FA0x2b63ed34_002EHOLM_WINDOW_FPGA_CTRL));
	}

	internal unsafe static void _003FA0x2b63ed34_002E_003F_003F__E_003FA0x2b63ed34_0040HOLM_WINDOW_DSPreLab_0040MiscHelper_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EMiscHelper_002E_003FA0x2b63ed34_002EHOLM_WINDOW_DSPreLab), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_08LKNALPII_0040DSPreLab_003F_0024AA_0040));
		_atexit_m((delegate*<void>)(&_003FA0x2b63ed34_002E_003F_003F__F_003FA0x2b63ed34_0040HOLM_WINDOW_DSPreLab_0040MiscHelper_0040HOLM_0040_0040YMXXZ));
	}

	internal unsafe static void _003FA0x2b63ed34_002E_003F_003F__F_003FA0x2b63ed34_0040HOLM_WINDOW_DSPreLab_0040MiscHelper_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EMiscHelper_002E_003FA0x2b63ed34_002EHOLM_WINDOW_DSPreLab));
	}

	internal unsafe static void _003FA0x2b63ed34_002E_003F_003F__E_003FA0x2b63ed34_0040HOLM_WINDOW_DSPreLab_DEMO_0040MiscHelper_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EMiscHelper_002E_003FA0x2b63ed34_002EHOLM_WINDOW_DSPreLab_DEMO), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_0BA_0040MFILEGDE_0040DEMO_003F5_003F9_003F5DSPreLab_003F_0024AA_0040));
		_atexit_m((delegate*<void>)(&_003FA0x2b63ed34_002E_003F_003F__F_003FA0x2b63ed34_0040HOLM_WINDOW_DSPreLab_DEMO_0040MiscHelper_0040HOLM_0040_0040YMXXZ));
	}

	internal unsafe static void _003FA0x2b63ed34_002E_003F_003F__F_003FA0x2b63ed34_0040HOLM_WINDOW_DSPreLab_DEMO_0040MiscHelper_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EMiscHelper_002E_003FA0x2b63ed34_002EHOLM_WINDOW_DSPreLab_DEMO));
	}

	internal static void _003FA0x2b63ed34_002E_003F_003F__E_003FA0x2b63ed34_0040PI_0040Math_0040HOLM_0040_0040YMXXZ()
	{
		HOLM_002EMath_002E_003FA0x2b63ed34_002EPI = Math.Acos(-1.0);
	}

	internal static void _003FA0x2b63ed34_002E_003F_003F__E_003FA0x2b63ed34_0040PI_F_0040Math_0040HOLM_0040_0040YMXXZ()
	{
		HOLM_002EMath_002E_003FA0x2b63ed34_002EPI_F = (float)Math.Acos(-1.0);
	}

	internal static void _003FA0x2b63ed34_002E_003F_003F__E_003FA0x2b63ed34_0040TWOPI_0040Math_0040HOLM_0040_0040YMXXZ()
	{
		HOLM_002EMath_002E_003FA0x2b63ed34_002ETWOPI = HOLM_002EMath_002E_003FA0x2b63ed34_002EPI * 2.0;
	}

	internal static void _003FA0x2b63ed34_002E_003F_003F__E_003FA0x2b63ed34_0040HALFPI_0040Math_0040HOLM_0040_0040YMXXZ()
	{
		HOLM_002EMath_002E_003FA0x2b63ed34_002EHALFPI = HOLM_002EMath_002E_003FA0x2b63ed34_002EPI * 0.5;
	}

	internal static void _003FA0x2b63ed34_002E_003F_003F__E_003FA0x2b63ed34_0040SQRT2_0040Math_0040HOLM_0040_0040YMXXZ()
	{
		HOLM_002EMath_002E_003FA0x2b63ed34_002ESQRT2 = Math.Sqrt(2.0);
	}

	internal static void _003FA0x2b63ed34_002E_003F_003F__E_003FA0x2b63ed34_0040SQRT2_F_0040Math_0040HOLM_0040_0040YMXXZ()
	{
		HOLM_002EMath_002E_003FA0x2b63ed34_002ESQRT2_F = (float)Math.Sqrt(2.0);
	}

	internal static void _003FA0x2b63ed34_002E_003F_003F__E_003FA0x2b63ed34_0040RadToDeg_0040Math_0040HOLM_0040_0040YMXXZ()
	{
		HOLM_002EMath_002E_003FA0x2b63ed34_002ERadToDeg = 180.0 / HOLM_002EMath_002E_003FA0x2b63ed34_002EPI;
	}

	internal static void _003FA0x2b63ed34_002E_003F_003F__E_003FA0x2b63ed34_0040RadToDeg_F_0040Math_0040HOLM_0040_0040YMXXZ()
	{
		HOLM_002EMath_002E_003FA0x2b63ed34_002ERadToDeg_F = (float)(180.0 / (double)HOLM_002EMath_002E_003FA0x2b63ed34_002EPI_F);
	}

	internal static void _003FA0x2b63ed34_002E_003F_003F__E_003FA0x2b63ed34_0040DegToRad_0040Math_0040HOLM_0040_0040YMXXZ()
	{
		HOLM_002EMath_002E_003FA0x2b63ed34_002EDegToRad = HOLM_002EMath_002E_003FA0x2b63ed34_002EPI / 180.0;
	}

	internal static void _003FA0x2b63ed34_002E_003F_003F__E_003FA0x2b63ed34_0040DegToRad_F_0040Math_0040HOLM_0040_0040YMXXZ()
	{
		HOLM_002EMath_002E_003FA0x2b63ed34_002EDegToRad_F = HOLM_002EMath_002E_003FA0x2b63ed34_002EPI_F / 180f;
	}

	internal static void _003FA0x2b63ed34_002E_003F_003F__E_003FA0x2b63ed34_0040MILLISEC_TO_CM_0040Measure_0040HOLM_0040_0040YMXXZ()
	{
		HOLM_002EMeasure_002E_003FA0x2b63ed34_002EMILLISEC_TO_CM = HOLM_002EMeasure_002E_003FA0x2b63ed34_002ESEC_TO_CM / 1000.0;
	}

	internal static void _003FA0x2b63ed34_002E_003F_003F__E_003FA0x2b63ed34_0040MICROSEC_TO_CM_0040Measure_0040HOLM_0040_0040YMXXZ()
	{
		HOLM_002EMeasure_002E_003FA0x2b63ed34_002EMICROSEC_TO_CM = HOLM_002EMeasure_002E_003FA0x2b63ed34_002EMILLISEC_TO_CM / 1000.0;
	}

	[STAThread]
	internal unsafe static int HOLM_002EHOLMImpulse_002Emain(string[] args)
	{
		Application.SetCompatibleTextRenderingDefault(false);
		string fullName = Directory.GetParent(Application.UserAppDataPath).FullName;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj);
		basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* ptr = HOLM_002EMiscHelper_002EStringToStd(&obj, fullName + "\\HOLMLogging.txt");
		try
		{
			HOLM_002ELogging_002EHolmLogger_002EInitialize(ptr);
		}
		catch
		{
			//try-fault
			___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), &obj);
			throw;
		}
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D(&obj);
		try
		{
			HOLM_002EMiscHelper_002EMigrateAppDataDir_CommonToUser("HOLMImpulse");
			System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj2);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj3);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj4);
			for (int i = 0; i < (nint)args.LongLength; i++)
			{
				std_002Ebasic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D(&obj2, 3, 1);
				try
				{
					basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* ptr2 = HOLM_002EMiscHelper_002EStringToStd(&obj3, args[i]);
					try
					{
						std_002Eoperator_003C_003C_003Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_0020_003E(std_002Eoperator_003C_003C_003Cchar_002Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_002Cclass_0020std_003A_003Aallocator_003Cchar_003E_0020_003E(std_002Eoperator_003C_003C_003Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_0020_003E(std_002Ebasic_ostream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E_002E_003C_003C(std_002Eoperator_003C_003C_003Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_0020_003E(std_002Eoperator_003C_003C_003Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_0020_003E((basic_ostream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj2, 8)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_08ECDPJEFA_0040INFO_003F5_003F5_003F5_003F5_003F_0024AA_0040)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_0BI_0040JEOGDFAK_0040HOLMImpulse_003F3_003F3main_003F5args_003F_0024FL_003F_0024AA_0040)), i), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_04OAFLPOMH_0040_003F_0024FN_003F5_003F_0024DN_003F5_003F_0024AA_0040)), ptr2), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01EEMJAFIK_0040_003F6_003F_0024AA_0040));
					}
					catch
					{
						//try-fault
						___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), &obj3);
						throw;
					}
					std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D(&obj3);
					basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* ptr3 = std_002Ebasic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002Estr(&obj2, &obj4);
					try
					{
						HOLM_002ELogging_002EHolmLogger_002ELogText(ptr3);
					}
					catch
					{
						//try-fault
						___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), &obj4);
						throw;
					}
					std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D(&obj4);
				}
				catch
				{
					//try-fault
					___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E__vbaseDtor), &obj2);
					throw;
				}
				std_002Ebasic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E__vbaseDtor(&obj2);
			}
			MainCtrl mainCtrl = new MainCtrl();
			if ((nint)args.LongLength > 0)
			{
				mainCtrl.Run(args[0]);
			}
			else
			{
				mainCtrl.Run("");
			}
			MainCtrl mainCtrl2 = mainCtrl;
			IDisposable disposable = mainCtrl;
			((IDisposable)mainCtrl)?.Dispose();
		}
		catch (Exception ex)
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj5);
			std_002Ebasic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D(&obj5, 3, 1);
			try
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj6);
				basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* ptr4 = HOLM_002EMiscHelper_002EStringToStd(&obj6, ex.ToString());
				try
				{
					std_002Eoperator_003C_003C_003Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_0020_003E(std_002Eoperator_003C_003C_003Cchar_002Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_002Cclass_0020std_003A_003Aallocator_003Cchar_003E_0020_003E(std_002Eoperator_003C_003C_003Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_0020_003E(std_002Eoperator_003C_003C_003Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_0020_003E((basic_ostream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj5, 8)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_08KFJDDMMO_0040WARNING_003F5_003F_0024AA_0040)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_0CK_0040PGEHFPNJ_0040HOLMImpulse_003F3_003F3main_003F5_003F9_003F5Top_003F5Level_003F5Ex_0040)), ptr4), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01EEMJAFIK_0040_003F6_003F_0024AA_0040));
				}
				catch
				{
					//try-fault
					___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), &obj6);
					throw;
				}
				std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D(&obj6);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj7);
				basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* ptr5 = std_002Ebasic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002Estr(&obj5, &obj7);
				try
				{
					HOLM_002ELogging_002EHolmLogger_002ELogText(ptr5);
				}
				catch
				{
					//try-fault
					___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), &obj7);
					throw;
				}
				std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D(&obj7);
			}
			catch
			{
				//try-fault
				___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E__vbaseDtor), &obj5);
				throw;
			}
			std_002Ebasic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E__vbaseDtor(&obj5);
		}
		HOLM_002EMiscHelper_002ERemoveAppVersionDirectory();
		return 0;
	}

	internal unsafe static basic_ostream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E.sentry* std_002Ebasic_ostream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E_002Esentry_002E_007Bctor_007D(basic_ostream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E.sentry* P_0, basic_ostream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E* _Ostr)
	{
		*(int*)P_0 = (int)_Ostr;
		if (std_002Ebasic_ios_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E_002Erdbuf((basic_ios_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E*)(*(int*)(*(int*)_Ostr + 4) + (byte*)_Ostr)) != null)
		{
			int num = *(int*)P_0;
			std_002Ebasic_streambuf_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E_002E_Lock(std_002Ebasic_ios_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E_002Erdbuf((basic_ios_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E*)(*(int*)(*(int*)num + 4) + num)));
		}
		try
		{
			if (std_002Eios_base_002Egood((ios_base*)(*(int*)(*(int*)_Ostr + 4) + (byte*)_Ostr)) && std_002Ebasic_ios_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E_002Etie((basic_ios_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E*)(*(int*)(*(int*)_Ostr + 4) + (byte*)_Ostr)) != null)
			{
				std_002Ebasic_ostream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E_002Eflush(std_002Ebasic_ios_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E_002Etie((basic_ios_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E*)(*(int*)(*(int*)_Ostr + 4) + (byte*)_Ostr)));
			}
			((byte*)P_0)[4] = (std_002Eios_base_002Egood((ios_base*)(*(int*)(*(int*)_Ostr + 4) + (byte*)_Ostr)) ? ((byte)1) : ((byte)0));
			return P_0;
		}
		catch
		{
			//try-fault
			___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_ostream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E._Sentry_base*, void>)(&std_002Ebasic_ostream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E_002E_Sentry_base_002E_007Bdtor_007D), P_0);
			throw;
		}
	}

	internal unsafe static void std_002Ebasic_ostream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E_002Esentry_002E_007Bdtor_007D(basic_ostream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E.sentry* P_0)
	{
		try
		{
			if (!std_002Euncaught_exception())
			{
				std_002Ebasic_ostream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E_002E_Osfx((basic_ostream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E*)(int)(*(uint*)P_0));
			}
		}
		catch
		{
			//try-fault
			___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_ostream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E._Sentry_base*, void>)(&std_002Ebasic_ostream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E_002E_Sentry_base_002E_007Bdtor_007D), P_0);
			throw;
		}
		int num = *(int*)P_0;
		if (std_002Ebasic_ios_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E_002Erdbuf((basic_ios_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E*)(*(int*)(*(int*)num + 4) + num)) != null)
		{
			num = *(int*)P_0;
			std_002Ebasic_streambuf_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E_002E_Unlock(std_002Ebasic_ios_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E_002Erdbuf((basic_ios_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E*)(*(int*)(*(int*)num + 4) + num)));
		}
	}

	internal unsafe static void std_002Ebasic_ostream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E_002E_Sentry_base_002E_007Bdtor_007D(basic_ostream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E._Sentry_base* P_0)
	{
		int num = *(int*)P_0;
		if (std_002Ebasic_ios_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E_002Erdbuf((basic_ios_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E*)(*(int*)(*(int*)num + 4) + num)) != null)
		{
			num = *(int*)P_0;
			std_002Ebasic_streambuf_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E_002E_Unlock(std_002Ebasic_ios_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E_002Erdbuf((basic_ios_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E*)(*(int*)(*(int*)num + 4) + num)));
		}
	}

	internal unsafe static basic_ostream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E* std_002Eoperator_003C_003C_003Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_0020_003E(basic_ostream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E* _Ostr, sbyte* _Val)
	{
		int num = (int)stackalloc byte[__CxxQueryExceptionSize()];
		int num2 = 0;
		int num3 = (int)std_002Echar_traits_003Cchar_003E_002Elength(_Val);
		int num4 = ((std_002Eios_base_002Ewidth((ios_base*)(*(int*)(*(int*)_Ostr + 4) + (byte*)_Ostr)) > 0 && std_002Eios_base_002Ewidth((ios_base*)(*(int*)(*(int*)_Ostr + 4) + (byte*)_Ostr)) > num3) ? (std_002Eios_base_002Ewidth((ios_base*)(*(int*)(*(int*)_Ostr + 4) + (byte*)_Ostr)) - num3) : 0);
		int num5 = num4;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_ostream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E.sentry sentry);
		std_002Ebasic_ostream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E_002Esentry_002E_007Bctor_007D(&sentry, _Ostr);
		try
		{
			if (System.Runtime.CompilerServices.Unsafe.As<basic_ostream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E.sentry, byte>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref sentry, 4)) == 0)
			{
				num2 = 4;
			}
			else
			{
				try
				{
					if ((std_002Eios_base_002Eflags((ios_base*)(*(int*)(*(int*)_Ostr + 4) + (byte*)_Ostr)) & 0x1C0) != 64)
					{
						while (0 < num5)
						{
							int num6 = std_002Ebasic_streambuf_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E_002Esputc(std_002Ebasic_ios_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E_002Erdbuf((basic_ios_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E*)(*(int*)(*(int*)_Ostr + 4) + (byte*)_Ostr)), std_002Ebasic_ios_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E_002Efill((basic_ios_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E*)(*(int*)(*(int*)_Ostr + 4) + (byte*)_Ostr)));
							int num7 = -1;
							if (std_002Echar_traits_003Cchar_003E_002Eeq_int_type(&num7, &num6))
							{
								num2 |= 4;
								break;
							}
							num5--;
						}
						if (num2 != 0)
						{
							goto IL_010f;
						}
					}
					if (std_002Ebasic_streambuf_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E_002Esputn(std_002Ebasic_ios_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E_002Erdbuf((basic_ios_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E*)(*(int*)(*(int*)_Ostr + 4) + (byte*)_Ostr)), _Val, num3) != num3)
					{
						num2 = 4;
					}
					else
					{
						while (0 < num5)
						{
							int num8 = std_002Ebasic_streambuf_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E_002Esputc(std_002Ebasic_ios_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E_002Erdbuf((basic_ios_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E*)(*(int*)(*(int*)_Ostr + 4) + (byte*)_Ostr)), std_002Ebasic_ios_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E_002Efill((basic_ios_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E*)(*(int*)(*(int*)_Ostr + 4) + (byte*)_Ostr)));
							int num9 = -1;
							if (std_002Echar_traits_003Cchar_003E_002Eeq_int_type(&num9, &num8))
							{
								num2 |= 4;
								break;
							}
							num5--;
						}
					}
					goto IL_010f;
					IL_010f:
					std_002Eios_base_002Ewidth((ios_base*)(*(int*)(*(int*)_Ostr + 4) + (byte*)_Ostr), 0);
				}
				catch when (((Func<bool>)delegate
				{
					// Could not convert BlockContainer to single expression
					uint exceptionCode = (uint)Marshal.GetExceptionCode();
					return (byte)__CxxExceptionFilter((void*)Marshal.GetExceptionPointers(), null, 0, null) != 0;
				}).Invoke())
				{
					uint num10 = 0u;
					__CxxRegisterExceptionObject((void*)Marshal.GetExceptionPointers(), (void*)num);
					try
					{
						try
						{
							std_002Ebasic_ios_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E_002Esetstate((basic_ios_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E*)(*(int*)(*(int*)_Ostr + 4) + (byte*)_Ostr), 4, true);
							goto end_IL_0146;
						}
						catch when (((Func<bool>)delegate
						{
							// Could not convert BlockContainer to single expression
							num10 = (uint)__CxxDetectRethrow((void*)Marshal.GetExceptionPointers());
							return (byte)num10 != 0;
						}).Invoke())
						{
						}
						if (num10 != 0)
						{
							throw;
						}
						end_IL_0146:;
					}
					finally
					{
						__CxxUnregisterExceptionObject((void*)num, (int)num10);
					}
				}
			}
			std_002Ebasic_ios_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E_002Esetstate((basic_ios_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E*)(*(int*)(*(int*)_Ostr + 4) + (byte*)_Ostr), num2, false);
		}
		catch
		{
			//try-fault
			___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_ostream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E.sentry*, void>)(&std_002Ebasic_ostream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E_002Esentry_002E_007Bdtor_007D), &sentry);
			throw;
		}
		try
		{
			if (!std_002Euncaught_exception())
			{
				std_002Ebasic_ostream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E_002E_Osfx((basic_ostream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E*)(int)(*(uint*)(&sentry)));
			}
		}
		catch
		{
			//try-fault
			___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_ostream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E._Sentry_base*, void>)(&std_002Ebasic_ostream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E_002E_Sentry_base_002E_007Bdtor_007D), &sentry);
			throw;
		}
		if (std_002Ebasic_ios_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E_002Erdbuf((basic_ios_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E*)(*(int*)(*(int*)(int)(*(uint*)(&sentry)) + 4) + *(int*)(&sentry))) != null)
		{
			std_002Ebasic_streambuf_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E_002E_Unlock(std_002Ebasic_ios_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E_002Erdbuf((basic_ios_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E*)(*(int*)(*(int*)(int)(*(uint*)(&sentry)) + 4) + *(int*)(&sentry))));
		}
		return _Ostr;
	}

	internal unsafe static void _003FA0x11566818_002E_003F_003F__E_003FA0x11566818_0040HEXSTRINGARRAY_0040MiscHelper_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EMiscHelper_002E_003FA0x11566818_002EHEXSTRINGARRAY), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01GBGANLPD_00400_003F_0024AA_0040));
		try
		{
			std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x11566818_002EHEXSTRINGARRAY, 28)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01HIHLOKLC_00401_003F_0024AA_0040));
			try
			{
				std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x11566818_002EHEXSTRINGARRAY, 56)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01FDFGLJHB_00402_003F_0024AA_0040));
				try
				{
					std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x11566818_002EHEXSTRINGARRAY, 84)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01EKENIIDA_00403_003F_0024AA_0040));
					try
					{
						std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x11566818_002EHEXSTRINGARRAY, 112)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01FAMBOPH_00404_003F_0024AA_0040));
						try
						{
							std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x11566818_002EHEXSTRINGARRAY, 140)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01BMBHCPLG_00405_003F_0024AA_0040));
							try
							{
								std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x11566818_002EHEXSTRINGARRAY, 168)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01DHDKHMHF_00406_003F_0024AA_0040));
								try
								{
									std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x11566818_002EHEXSTRINGARRAY, 196)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01COCBENDE_00407_003F_0024AA_0040));
									try
									{
										std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x11566818_002EHEXSTRINGARRAY, 224)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01KJLJFBPL_00408_003F_0024AA_0040));
										try
										{
											std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x11566818_002EHEXSTRINGARRAY, 252)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01LAKCGALK_00409_003F_0024AA_0040));
											try
											{
												std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x11566818_002EHEXSTRINGARRAY, 280)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01FHEEJDEE_0040A_003F_0024AA_0040));
												try
												{
													std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x11566818_002EHEXSTRINGARRAY, 308)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01HMGJMAIH_0040B_003F_0024AA_0040));
													try
													{
														std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x11566818_002EHEXSTRINGARRAY, 336)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01GFHCPBMG_0040C_003F_0024AA_0040));
														try
														{
															std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x11566818_002EHEXSTRINGARRAY, 364)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01CKDDGHAB_0040D_003F_0024AA_0040));
															try
															{
																std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x11566818_002EHEXSTRINGARRAY, 392)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01DDCIFGEA_0040E_003F_0024AA_0040));
																try
																{
																	std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x11566818_002EHEXSTRINGARRAY, 420)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01BIAFAFID_0040F_003F_0024AA_0040));
																}
																catch
																{
																	//try-fault
																	___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x11566818_002EHEXSTRINGARRAY, 392)));
																	throw;
																}
															}
															catch
															{
																//try-fault
																___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x11566818_002EHEXSTRINGARRAY, 364)));
																throw;
															}
														}
														catch
														{
															//try-fault
															___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x11566818_002EHEXSTRINGARRAY, 336)));
															throw;
														}
													}
													catch
													{
														//try-fault
														___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x11566818_002EHEXSTRINGARRAY, 308)));
														throw;
													}
												}
												catch
												{
													//try-fault
													___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x11566818_002EHEXSTRINGARRAY, 280)));
													throw;
												}
											}
											catch
											{
												//try-fault
												___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x11566818_002EHEXSTRINGARRAY, 252)));
												throw;
											}
										}
										catch
										{
											//try-fault
											___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x11566818_002EHEXSTRINGARRAY, 224)));
											throw;
										}
									}
									catch
									{
										//try-fault
										___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x11566818_002EHEXSTRINGARRAY, 196)));
										throw;
									}
								}
								catch
								{
									//try-fault
									___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x11566818_002EHEXSTRINGARRAY, 168)));
									throw;
								}
							}
							catch
							{
								//try-fault
								___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x11566818_002EHEXSTRINGARRAY, 140)));
								throw;
							}
						}
						catch
						{
							//try-fault
							___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x11566818_002EHEXSTRINGARRAY, 112)));
							throw;
						}
					}
					catch
					{
						//try-fault
						___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x11566818_002EHEXSTRINGARRAY, 84)));
						throw;
					}
				}
				catch
				{
					//try-fault
					___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x11566818_002EHEXSTRINGARRAY, 56)));
					throw;
				}
			}
			catch
			{
				//try-fault
				___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x11566818_002EHEXSTRINGARRAY, 28)));
				throw;
			}
		}
		catch
		{
			//try-fault
			___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EMiscHelper_002E_003FA0x11566818_002EHEXSTRINGARRAY));
			throw;
		}
		_atexit_m((delegate*<void>)(&_003FA0x11566818_002E_003F_003F__F_003FA0x11566818_0040HEXSTRINGARRAY_0040MiscHelper_0040HOLM_0040_0040YMXXZ));
	}

	internal unsafe static void _003FA0x11566818_002E_003F_003F__F_003FA0x11566818_0040HEXSTRINGARRAY_0040MiscHelper_0040HOLM_0040_0040YMXXZ()
	{
		__ehvec_dtor(System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EMiscHelper_002E_003FA0x11566818_002EHEXSTRINGARRAY), 28u, 16, (delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D));
	}

	internal unsafe static void _003FA0x11566818_002E_003F_003F__E_003FA0x11566818_0040HOLM_WINDOW_FPGA_CTRL_0040MiscHelper_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EMiscHelper_002E_003FA0x11566818_002EHOLM_WINDOW_FPGA_CTRL), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_0BD_0040CPFABDBC_0040HOLMFpgaController_003F_0024AA_0040));
		_atexit_m((delegate*<void>)(&_003FA0x11566818_002E_003F_003F__F_003FA0x11566818_0040HOLM_WINDOW_FPGA_CTRL_0040MiscHelper_0040HOLM_0040_0040YMXXZ));
	}

	internal unsafe static void _003FA0x11566818_002E_003F_003F__F_003FA0x11566818_0040HOLM_WINDOW_FPGA_CTRL_0040MiscHelper_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EMiscHelper_002E_003FA0x11566818_002EHOLM_WINDOW_FPGA_CTRL));
	}

	internal unsafe static void _003FA0x11566818_002E_003F_003F__E_003FA0x11566818_0040HOLM_WINDOW_DSPreLab_0040MiscHelper_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EMiscHelper_002E_003FA0x11566818_002EHOLM_WINDOW_DSPreLab), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_08LKNALPII_0040DSPreLab_003F_0024AA_0040));
		_atexit_m((delegate*<void>)(&_003FA0x11566818_002E_003F_003F__F_003FA0x11566818_0040HOLM_WINDOW_DSPreLab_0040MiscHelper_0040HOLM_0040_0040YMXXZ));
	}

	internal unsafe static void _003FA0x11566818_002E_003F_003F__F_003FA0x11566818_0040HOLM_WINDOW_DSPreLab_0040MiscHelper_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EMiscHelper_002E_003FA0x11566818_002EHOLM_WINDOW_DSPreLab));
	}

	internal unsafe static void _003FA0x11566818_002E_003F_003F__E_003FA0x11566818_0040HOLM_WINDOW_DSPreLab_DEMO_0040MiscHelper_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EMiscHelper_002E_003FA0x11566818_002EHOLM_WINDOW_DSPreLab_DEMO), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_0BA_0040MFILEGDE_0040DEMO_003F5_003F9_003F5DSPreLab_003F_0024AA_0040));
		_atexit_m((delegate*<void>)(&_003FA0x11566818_002E_003F_003F__F_003FA0x11566818_0040HOLM_WINDOW_DSPreLab_DEMO_0040MiscHelper_0040HOLM_0040_0040YMXXZ));
	}

	internal unsafe static void _003FA0x11566818_002E_003F_003F__F_003FA0x11566818_0040HOLM_WINDOW_DSPreLab_DEMO_0040MiscHelper_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EMiscHelper_002E_003FA0x11566818_002EHOLM_WINDOW_DSPreLab_DEMO));
	}

	internal static void _003FA0x11566818_002E_003F_003F__E_003FA0x11566818_0040PI_0040Math_0040HOLM_0040_0040YMXXZ()
	{
		HOLM_002EMath_002E_003FA0x11566818_002EPI = Math.Acos(-1.0);
	}

	internal static void _003FA0x11566818_002E_003F_003F__E_003FA0x11566818_0040PI_F_0040Math_0040HOLM_0040_0040YMXXZ()
	{
		HOLM_002EMath_002E_003FA0x11566818_002EPI_F = (float)Math.Acos(-1.0);
	}

	internal static void _003FA0x11566818_002E_003F_003F__E_003FA0x11566818_0040TWOPI_0040Math_0040HOLM_0040_0040YMXXZ()
	{
		HOLM_002EMath_002E_003FA0x11566818_002ETWOPI = HOLM_002EMath_002E_003FA0x11566818_002EPI * 2.0;
	}

	internal static void _003FA0x11566818_002E_003F_003F__E_003FA0x11566818_0040HALFPI_0040Math_0040HOLM_0040_0040YMXXZ()
	{
		HOLM_002EMath_002E_003FA0x11566818_002EHALFPI = HOLM_002EMath_002E_003FA0x11566818_002EPI * 0.5;
	}

	internal static void _003FA0x11566818_002E_003F_003F__E_003FA0x11566818_0040SQRT2_0040Math_0040HOLM_0040_0040YMXXZ()
	{
		HOLM_002EMath_002E_003FA0x11566818_002ESQRT2 = Math.Sqrt(2.0);
	}

	internal static void _003FA0x11566818_002E_003F_003F__E_003FA0x11566818_0040SQRT2_F_0040Math_0040HOLM_0040_0040YMXXZ()
	{
		HOLM_002EMath_002E_003FA0x11566818_002ESQRT2_F = (float)Math.Sqrt(2.0);
	}

	internal static void _003FA0x11566818_002E_003F_003F__E_003FA0x11566818_0040RadToDeg_0040Math_0040HOLM_0040_0040YMXXZ()
	{
		HOLM_002EMath_002E_003FA0x11566818_002ERadToDeg = 180.0 / HOLM_002EMath_002E_003FA0x11566818_002EPI;
	}

	internal static void _003FA0x11566818_002E_003F_003F__E_003FA0x11566818_0040RadToDeg_F_0040Math_0040HOLM_0040_0040YMXXZ()
	{
		HOLM_002EMath_002E_003FA0x11566818_002ERadToDeg_F = (float)(180.0 / (double)HOLM_002EMath_002E_003FA0x11566818_002EPI_F);
	}

	internal static void _003FA0x11566818_002E_003F_003F__E_003FA0x11566818_0040DegToRad_0040Math_0040HOLM_0040_0040YMXXZ()
	{
		HOLM_002EMath_002E_003FA0x11566818_002EDegToRad = HOLM_002EMath_002E_003FA0x11566818_002EPI / 180.0;
	}

	internal static void _003FA0x11566818_002E_003F_003F__E_003FA0x11566818_0040DegToRad_F_0040Math_0040HOLM_0040_0040YMXXZ()
	{
		HOLM_002EMath_002E_003FA0x11566818_002EDegToRad_F = HOLM_002EMath_002E_003FA0x11566818_002EPI_F / 180f;
	}

	internal static void _003FA0x11566818_002E_003F_003F__E_003FA0x11566818_0040MILLISEC_TO_CM_0040Measure_0040HOLM_0040_0040YMXXZ()
	{
		HOLM_002EMeasure_002E_003FA0x11566818_002EMILLISEC_TO_CM = HOLM_002EMeasure_002E_003FA0x11566818_002ESEC_TO_CM / 1000.0;
	}

	internal static void _003FA0x11566818_002E_003F_003F__E_003FA0x11566818_0040MICROSEC_TO_CM_0040Measure_0040HOLM_0040_0040YMXXZ()
	{
		HOLM_002EMeasure_002E_003FA0x11566818_002EMICROSEC_TO_CM = HOLM_002EMeasure_002E_003FA0x11566818_002EMILLISEC_TO_CM / 1000.0;
	}

	internal unsafe static void _003FA0x11566818_002E_003F_003F__E_003FA0x11566818_0040OPTIONS_COMPAT_START_0040Constants_0040HOLMImpulse_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x11566818_002EOPTIONS_COMPAT_START), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_07EBPGIHEF_00401_003F41_003F41_003F41_003F_0024AA_0040));
		_atexit_m((delegate*<void>)(&_003FA0x11566818_002E_003F_003F__F_003FA0x11566818_0040OPTIONS_COMPAT_START_0040Constants_0040HOLMImpulse_0040HOLM_0040_0040YMXXZ));
	}

	internal unsafe static void _003FA0x11566818_002E_003F_003F__F_003FA0x11566818_0040OPTIONS_COMPAT_START_0040Constants_0040HOLMImpulse_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x11566818_002EOPTIONS_COMPAT_START));
	}

	internal unsafe static void _003FA0x11566818_002E_003F_003F__E_003FA0x11566818_0040OPTIONS_AUTOSAVE_FILENAME_0040Constants_0040HOLMImpulse_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x11566818_002EOPTIONS_AUTOSAVE_FILENAME), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_0BH_0040KPHMGOCK_0040HOLMImpulseOptions_003F4xml_003F_0024AA_0040));
		_atexit_m((delegate*<void>)(&_003FA0x11566818_002E_003F_003F__F_003FA0x11566818_0040OPTIONS_AUTOSAVE_FILENAME_0040Constants_0040HOLMImpulse_0040HOLM_0040_0040YMXXZ));
	}

	internal unsafe static void _003FA0x11566818_002E_003F_003F__F_003FA0x11566818_0040OPTIONS_AUTOSAVE_FILENAME_0040Constants_0040HOLMImpulse_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x11566818_002EOPTIONS_AUTOSAVE_FILENAME));
	}

	internal unsafe static void _003FA0x11566818_002E_003F_003F__E_003FA0x11566818_0040AUTOSAVE_MEAS_FILENAME_0040Constants_0040HOLMImpulse_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x11566818_002EAUTOSAVE_MEAS_FILENAME), (char*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_1CE_0040JMJFEPPE_0040_003F_0024AAM_003F_0024AAe_003F_0024AAa_003F_0024AAs_003F_0024AAA_003F_0024AAu_003F_0024AAt_003F_0024AAo_003F_0024AAs_003F_0024AAa_003F_0024AAv_003F_0024AAe_003F_0024AAd_003F_0024AA_003F4_003F_0024AAz_003F_0024AAi_003F_0024AAp_003F_0024AA_003F_0024AA_0040));
		_atexit_m((delegate*<void>)(&_003FA0x11566818_002E_003F_003F__F_003FA0x11566818_0040AUTOSAVE_MEAS_FILENAME_0040Constants_0040HOLMImpulse_0040HOLM_0040_0040YMXXZ));
	}

	internal unsafe static void _003FA0x11566818_002E_003F_003F__F_003FA0x11566818_0040AUTOSAVE_MEAS_FILENAME_0040Constants_0040HOLMImpulse_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E_002E_007Bdtor_007D((basic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x11566818_002EAUTOSAVE_MEAS_FILENAME));
	}

	internal unsafe static void _003FA0x11566818_002E_003F_003F__E_003FA0x11566818_0040AUTOSAVE_MEAS_OBSOLETE_0040Constants_0040HOLMImpulse_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x11566818_002EAUTOSAVE_MEAS_OBSOLETE), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_0BC_0040COMDONFP_0040MeasAutosaved_003F4hlm_003F_0024AA_0040));
		_atexit_m((delegate*<void>)(&_003FA0x11566818_002E_003F_003F__F_003FA0x11566818_0040AUTOSAVE_MEAS_OBSOLETE_0040Constants_0040HOLMImpulse_0040HOLM_0040_0040YMXXZ));
	}

	internal unsafe static void _003FA0x11566818_002E_003F_003F__F_003FA0x11566818_0040AUTOSAVE_MEAS_OBSOLETE_0040Constants_0040HOLMImpulse_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x11566818_002EAUTOSAVE_MEAS_OBSOLETE));
	}

	internal unsafe static void _003FA0x11566818_002E_003F_003F__E_003FA0x11566818_0040AUTOSAVE_MEAS_OBSOLETE_DIR_0040Constants_0040HOLMImpulse_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x11566818_002EAUTOSAVE_MEAS_OBSOLETE_DIR), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_0BC_0040JLNMFMDH_0040AutosavedObsolete_003F_0024AA_0040));
		_atexit_m((delegate*<void>)(&_003FA0x11566818_002E_003F_003F__F_003FA0x11566818_0040AUTOSAVE_MEAS_OBSOLETE_DIR_0040Constants_0040HOLMImpulse_0040HOLM_0040_0040YMXXZ));
	}

	internal unsafe static void _003FA0x11566818_002E_003F_003F__F_003FA0x11566818_0040AUTOSAVE_MEAS_OBSOLETE_DIR_0040Constants_0040HOLMImpulse_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x11566818_002EAUTOSAVE_MEAS_OBSOLETE_DIR));
	}

	internal unsafe static void _003FA0x11566818_002E_003F_003F__E_003FA0x11566818_0040CAL_MIC_FILENAME_0040Constants_0040HOLMImpulse_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x11566818_002ECAL_MIC_FILENAME), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_0BD_0040LOFKOGNA_0040CalibrationMic_003F4cal_003F_0024AA_0040));
		_atexit_m((delegate*<void>)(&_003FA0x11566818_002E_003F_003F__F_003FA0x11566818_0040CAL_MIC_FILENAME_0040Constants_0040HOLMImpulse_0040HOLM_0040_0040YMXXZ));
	}

	internal unsafe static void _003FA0x11566818_002E_003F_003F__F_003FA0x11566818_0040CAL_MIC_FILENAME_0040Constants_0040HOLMImpulse_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x11566818_002ECAL_MIC_FILENAME));
	}

	internal unsafe static void _003FA0x11566818_002E_003F_003F__E_003FA0x11566818_0040CAL_DACADC_FILENAME_0040Constants_0040HOLMImpulse_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x11566818_002ECAL_DACADC_FILENAME), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_0BG_0040GMNAFMJF_0040CalibrationDacAdc_003F4cal_003F_0024AA_0040));
		_atexit_m((delegate*<void>)(&_003FA0x11566818_002E_003F_003F__F_003FA0x11566818_0040CAL_DACADC_FILENAME_0040Constants_0040HOLMImpulse_0040HOLM_0040_0040YMXXZ));
	}

	internal unsafe static void _003FA0x11566818_002E_003F_003F__F_003FA0x11566818_0040CAL_DACADC_FILENAME_0040Constants_0040HOLMImpulse_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x11566818_002ECAL_DACADC_FILENAME));
	}

	internal unsafe static void _003FA0x11566818_002E_003F_003F__E_003FA0x11566818_0040CHANGELOG_0040Constants_0040HOLMImpulse_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x11566818_002ECHANGELOG), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_0O_0040EONGOMGC_0040ChangeLog_003F4txt_003F_0024AA_0040));
		_atexit_m((delegate*<void>)(&_003FA0x11566818_002E_003F_003F__F_003FA0x11566818_0040CHANGELOG_0040Constants_0040HOLMImpulse_0040HOLM_0040_0040YMXXZ));
	}

	internal unsafe static void _003FA0x11566818_002E_003F_003F__F_003FA0x11566818_0040CHANGELOG_0040Constants_0040HOLMImpulse_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x11566818_002ECHANGELOG));
	}

	internal unsafe static void _003FA0x11566818_002E_003F_003F__E_003FA0x11566818_0040ISSUES_0040Constants_0040HOLMImpulse_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x11566818_002EISSUES), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_0L_0040NGLIAIJP_0040Issues_003F4txt_003F_0024AA_0040));
		_atexit_m((delegate*<void>)(&_003FA0x11566818_002E_003F_003F__F_003FA0x11566818_0040ISSUES_0040Constants_0040HOLMImpulse_0040HOLM_0040_0040YMXXZ));
	}

	internal unsafe static void _003FA0x11566818_002E_003F_003F__F_003FA0x11566818_0040ISSUES_0040Constants_0040HOLMImpulse_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x11566818_002EISSUES));
	}

	internal unsafe static void _003FA0x11566818_002E_003F_003F__E_003FA0x11566818_0040LICENSE_0040Constants_0040HOLMImpulse_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x11566818_002ELICENSE), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_0M_0040HGMIFPO_0040LICENSE_003F4txt_003F_0024AA_0040));
		_atexit_m((delegate*<void>)(&_003FA0x11566818_002E_003F_003F__F_003FA0x11566818_0040LICENSE_0040Constants_0040HOLMImpulse_0040HOLM_0040_0040YMXXZ));
	}

	internal unsafe static void _003FA0x11566818_002E_003F_003F__F_003FA0x11566818_0040LICENSE_0040Constants_0040HOLMImpulse_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x11566818_002ELICENSE));
	}

	internal unsafe static void _003FA0x11566818_002E_003F_003F__E_003FA0x11566818_0040TMP_PATH_MEASLIST_0040Constants_0040HOLMImpulse_0040HOLM_0040_0040YMXXZ()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj);
		basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* ptr = HOLM_002EMiscHelper_002EGetTmpDirSimple(&obj);
		try
		{
			std_002Eoperator_002B_003Cchar_002Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_002Cclass_0020std_003A_003Aallocator_003Cchar_003E_0020_003E((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x11566818_002ETMP_PATH_MEASLIST), ptr, (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_0N_0040ONBJJBCP_0040_003F2MeasTmpList_003F_0024AA_0040));
		}
		catch
		{
			//try-fault
			___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), &obj);
			throw;
		}
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D(&obj);
		_atexit_m((delegate*<void>)(&_003FA0x11566818_002E_003F_003F__F_003FA0x11566818_0040TMP_PATH_MEASLIST_0040Constants_0040HOLMImpulse_0040HOLM_0040_0040YMXXZ));
	}

	internal unsafe static void _003FA0x11566818_002E_003F_003F__F_003FA0x11566818_0040TMP_PATH_MEASLIST_0040Constants_0040HOLMImpulse_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x11566818_002ETMP_PATH_MEASLIST));
	}

	internal static void _003FA0x11566818_002E_003F_003F__E_003FA0x11566818_0040MEASURE_LOW_REJECT_AMP_0040Constants_0040HOLMImpulse_0040HOLM_0040_0040YMXXZ()
	{
		HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x11566818_002EMEASURE_LOW_REJECT_AMP = HOLM_002EMath_002EDBToAmplitude_003Cdouble_003E(-70.0);
	}

	internal static void _003FA0x11566818_002E_003F_003F__E_003FA0x11566818_0040MEASURE_LOW_WARN_AMP_0040Constants_0040HOLMImpulse_0040HOLM_0040_0040YMXXZ()
	{
		HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x11566818_002EMEASURE_LOW_WARN_AMP = HOLM_002EMath_002EDBToAmplitude_003Cdouble_003E(-40.0);
	}

	internal unsafe static basic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E* HOLM_002EHOLMImpulse_002EConf_002EFilePath(basic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E* P_0, basic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E* fileName, [MarshalAs(UnmanagedType.U1)] bool fSystem)
	{
		uint num = 0u;
		try
		{
			try
			{
				if ((_003FA0x11566818_002E_003F_0024S1_0040_003F1_003F_003FFilePath_0040Conf_0040HOLMImpulse_0040HOLM_0040_0040YA_003FAV_003F_0024basic_string_0040_WU_003F_0024char_traits_0040_W_0040std_0040_0040V_003F_0024allocator_0040_W_00402_0040_0040std_0040_0040V56_0040_N_0040Z_00404IA & 1) == 0)
				{
					_003FA0x11566818_002E_003F_0024S1_0040_003F1_003F_003FFilePath_0040Conf_0040HOLMImpulse_0040HOLM_0040_0040YA_003FAV_003F_0024basic_string_0040_WU_003F_0024char_traits_0040_W_0040std_0040_0040V_003F_0024allocator_0040_W_00402_0040_0040std_0040_0040V56_0040_N_0040Z_00404IA |= 1u;
					try
					{
						HOLM_002EMiscHelper_002EStringToStdW((basic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003FA0x11566818_002E_003FSystemDirectory_0040_003F1_003F_003FFilePath_0040Conf_0040HOLMImpulse_0040HOLM_0040_0040YA_003FAV_003F_0024basic_string_0040_WU_003F_0024char_traits_0040_W_0040std_0040_0040V_003F_0024allocator_0040_W_00402_0040_0040std_0040_0040V56_0040_N_0040Z_00404V56_0040B), Application.StartupPath);
						_atexit_m((delegate*<void>)(&_003FA0x11566818_002E_003F_003F__FSystemDirectory_0040_003F1_003F_003FFilePath_0040Conf_0040HOLMImpulse_0040HOLM_0040_0040YA_003FAV_003F_0024basic_string_0040_WU_003F_0024char_traits_0040_W_0040std_0040_0040V_003F_0024allocator_0040_W_00402_0040_0040std_0040_0040V45_0040_N_0040Z_0040YMXXZ));
					}
					catch
					{
						//try-fault
						_003FA0x11566818_002E_003F_0024S1_0040_003F1_003F_003FFilePath_0040Conf_0040HOLMImpulse_0040HOLM_0040_0040YA_003FAV_003F_0024basic_string_0040_WU_003F_0024char_traits_0040_W_0040std_0040_0040V_003F_0024allocator_0040_W_00402_0040_0040std_0040_0040V56_0040_N_0040Z_00404IA &= 4294967294u;
						throw;
					}
				}
				if ((_003FA0x11566818_002E_003F_0024S1_0040_003F1_003F_003FFilePath_0040Conf_0040HOLMImpulse_0040HOLM_0040_0040YA_003FAV_003F_0024basic_string_0040_WU_003F_0024char_traits_0040_W_0040std_0040_0040V_003F_0024allocator_0040_W_00402_0040_0040std_0040_0040V56_0040_N_0040Z_00404IA & 2) == 0)
				{
					_003FA0x11566818_002E_003F_0024S1_0040_003F1_003F_003FFilePath_0040Conf_0040HOLMImpulse_0040HOLM_0040_0040YA_003FAV_003F_0024basic_string_0040_WU_003F_0024char_traits_0040_W_0040std_0040_0040V_003F_0024allocator_0040_W_00402_0040_0040std_0040_0040V56_0040_N_0040Z_00404IA |= 2u;
					try
					{
						string fullName = Directory.GetParent(Application.UserAppDataPath).FullName;
						HOLM_002EMiscHelper_002EStringToStdW((basic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003FA0x11566818_002E_003FUserDirectory_0040_003F1_003F_003FFilePath_0040Conf_0040HOLMImpulse_0040HOLM_0040_0040YA_003FAV_003F_0024basic_string_0040_WU_003F_0024char_traits_0040_W_0040std_0040_0040V_003F_0024allocator_0040_W_00402_0040_0040std_0040_0040V56_0040_N_0040Z_00404V56_0040B), fullName);
						_atexit_m((delegate*<void>)(&_003FA0x11566818_002E_003F_003F__FUserDirectory_0040_003F1_003F_003FFilePath_0040Conf_0040HOLMImpulse_0040HOLM_0040_0040YA_003FAV_003F_0024basic_string_0040_WU_003F_0024char_traits_0040_W_0040std_0040_0040V_003F_0024allocator_0040_W_00402_0040_0040std_0040_0040V45_0040_N_0040Z_0040YMXXZ));
					}
					catch
					{
						//try-fault
						_003FA0x11566818_002E_003F_0024S1_0040_003F1_003F_003FFilePath_0040Conf_0040HOLMImpulse_0040HOLM_0040_0040YA_003FAV_003F_0024basic_string_0040_WU_003F_0024char_traits_0040_W_0040std_0040_0040V_003F_0024allocator_0040_W_00402_0040_0040std_0040_0040V56_0040_N_0040Z_00404IA &= 4294967293u;
						throw;
					}
				}
				if (fSystem)
				{
					System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E obj);
					basic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E* ptr = std_002Eoperator_002B_003Cwchar_t_002Cstruct_0020std_003A_003Achar_traits_003Cwchar_t_003E_002Cclass_0020std_003A_003Aallocator_003Cwchar_t_003E_0020_003E(&obj, (basic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003FA0x11566818_002E_003FSystemDirectory_0040_003F1_003F_003FFilePath_0040Conf_0040HOLMImpulse_0040HOLM_0040_0040YA_003FAV_003F_0024basic_string_0040_WU_003F_0024char_traits_0040_W_0040std_0040_0040V_003F_0024allocator_0040_W_00402_0040_0040std_0040_0040V56_0040_N_0040Z_00404V56_0040B), (char*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_13FPGAJAPJ_0040_003F_0024AA_003F2_003F_0024AA_003F_0024AA_0040));
					try
					{
						std_002Eoperator_002B_003Cwchar_t_002Cstruct_0020std_003A_003Achar_traits_003Cwchar_t_003E_002Cclass_0020std_003A_003Aallocator_003Cwchar_t_003E_0020_003E(P_0, ptr, fileName);
						num = 1u;
					}
					catch
					{
						//try-fault
						___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E_002E_007Bdtor_007D), &obj);
						throw;
					}
					std_002Ebasic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E_002E_007Bdtor_007D(&obj);
					goto IL_00da;
				}
			}
			catch
			{
				//try-fault
				___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E_002E_007Bdtor_007D), fileName);
				throw;
			}
			try
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E obj2);
				basic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E* ptr2 = std_002Eoperator_002B_003Cwchar_t_002Cstruct_0020std_003A_003Achar_traits_003Cwchar_t_003E_002Cclass_0020std_003A_003Aallocator_003Cwchar_t_003E_0020_003E(&obj2, (basic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003FA0x11566818_002E_003FUserDirectory_0040_003F1_003F_003FFilePath_0040Conf_0040HOLMImpulse_0040HOLM_0040_0040YA_003FAV_003F_0024basic_string_0040_WU_003F_0024char_traits_0040_W_0040std_0040_0040V_003F_0024allocator_0040_W_00402_0040_0040std_0040_0040V56_0040_N_0040Z_00404V56_0040B), (char*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_13FPGAJAPJ_0040_003F_0024AA_003F2_003F_0024AA_003F_0024AA_0040));
				try
				{
					std_002Eoperator_002B_003Cwchar_t_002Cstruct_0020std_003A_003Achar_traits_003Cwchar_t_003E_002Cclass_0020std_003A_003Aallocator_003Cwchar_t_003E_0020_003E(P_0, ptr2, fileName);
					num = 1u;
				}
				catch
				{
					//try-fault
					___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E_002E_007Bdtor_007D), &obj2);
					throw;
				}
				std_002Ebasic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E_002E_007Bdtor_007D(&obj2);
			}
			catch
			{
				//try-fault
				___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E_002E_007Bdtor_007D), fileName);
				throw;
			}
			std_002Ebasic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E_002E_007Bdtor_007D(fileName);
			return P_0;
			IL_00da:
			std_002Ebasic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E_002E_007Bdtor_007D(fileName);
			return P_0;
		}
		catch
		{
			//try-fault
			if ((num & (true ? 1u : 0u)) != 0)
			{
				num &= 0xFFFFFFFEu;
				___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E_002E_007Bdtor_007D), P_0);
			}
			throw;
		}
	}

	internal unsafe static void _003FA0x11566818_002E_003F_003F__FUserDirectory_0040_003F1_003F_003FFilePath_0040Conf_0040HOLMImpulse_0040HOLM_0040_0040YA_003FAV_003F_0024basic_string_0040_WU_003F_0024char_traits_0040_W_0040std_0040_0040V_003F_0024allocator_0040_W_00402_0040_0040std_0040_0040V45_0040_N_0040Z_0040YMXXZ()
	{
		std_002Ebasic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E_002E_007Bdtor_007D((basic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003FA0x11566818_002E_003FUserDirectory_0040_003F1_003F_003FFilePath_0040Conf_0040HOLMImpulse_0040HOLM_0040_0040YA_003FAV_003F_0024basic_string_0040_WU_003F_0024char_traits_0040_W_0040std_0040_0040V_003F_0024allocator_0040_W_00402_0040_0040std_0040_0040V56_0040_N_0040Z_00404V56_0040B));
	}

	internal unsafe static void _003FA0x11566818_002E_003F_003F__FSystemDirectory_0040_003F1_003F_003FFilePath_0040Conf_0040HOLMImpulse_0040HOLM_0040_0040YA_003FAV_003F_0024basic_string_0040_WU_003F_0024char_traits_0040_W_0040std_0040_0040V_003F_0024allocator_0040_W_00402_0040_0040std_0040_0040V45_0040_N_0040Z_0040YMXXZ()
	{
		std_002Ebasic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E_002E_007Bdtor_007D((basic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003FA0x11566818_002E_003FSystemDirectory_0040_003F1_003F_003FFilePath_0040Conf_0040HOLMImpulse_0040HOLM_0040_0040YA_003FAV_003F_0024basic_string_0040_WU_003F_0024char_traits_0040_W_0040std_0040_0040V_003F_0024allocator_0040_W_00402_0040_0040std_0040_0040V56_0040_N_0040Z_00404V56_0040B));
	}

	internal unsafe static basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* HOLM_002EHOLMImpulse_002EConf_002EFilePath(basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* P_0, basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* fileName, [MarshalAs(UnmanagedType.U1)] bool fSystem)
	{
		uint num = 0u;
		try
		{
			try
			{
				if ((_003FA0x11566818_002E_003F_0024S2_0040_003F1_003F_003FFilePath_0040Conf_0040HOLMImpulse_0040HOLM_0040_0040YA_003FAV_003F_0024basic_string_0040DU_003F_0024char_traits_0040D_0040std_0040_0040V_003F_0024allocator_0040D_00402_0040_0040std_0040_0040V56_0040_N_0040Z_00404IA & 1) == 0)
				{
					_003FA0x11566818_002E_003F_0024S2_0040_003F1_003F_003FFilePath_0040Conf_0040HOLMImpulse_0040HOLM_0040_0040YA_003FAV_003F_0024basic_string_0040DU_003F_0024char_traits_0040D_0040std_0040_0040V_003F_0024allocator_0040D_00402_0040_0040std_0040_0040V56_0040_N_0040Z_00404IA |= 1u;
					try
					{
						HOLM_002EMiscHelper_002EStringToStd((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003FA0x11566818_002E_003FSystemDirectory_0040_003F1_003F_003FFilePath_0040Conf_0040HOLMImpulse_0040HOLM_0040_0040YA_003FAV_003F_0024basic_string_0040DU_003F_0024char_traits_0040D_0040std_0040_0040V_003F_0024allocator_0040D_00402_0040_0040std_0040_0040V56_0040_N_0040Z_00404V56_0040B), Application.StartupPath);
						_atexit_m((delegate*<void>)(&_003FA0x11566818_002E_003F_003F__FSystemDirectory_0040_003F1_003F_003FFilePath_0040Conf_0040HOLMImpulse_0040HOLM_0040_0040YA_003FAV_003F_0024basic_string_0040DU_003F_0024char_traits_0040D_0040std_0040_0040V_003F_0024allocator_0040D_00402_0040_0040std_0040_0040V45_0040_N_0040Z_0040YMXXZ));
					}
					catch
					{
						//try-fault
						_003FA0x11566818_002E_003F_0024S2_0040_003F1_003F_003FFilePath_0040Conf_0040HOLMImpulse_0040HOLM_0040_0040YA_003FAV_003F_0024basic_string_0040DU_003F_0024char_traits_0040D_0040std_0040_0040V_003F_0024allocator_0040D_00402_0040_0040std_0040_0040V56_0040_N_0040Z_00404IA &= 4294967294u;
						throw;
					}
				}
				if ((_003FA0x11566818_002E_003F_0024S2_0040_003F1_003F_003FFilePath_0040Conf_0040HOLMImpulse_0040HOLM_0040_0040YA_003FAV_003F_0024basic_string_0040DU_003F_0024char_traits_0040D_0040std_0040_0040V_003F_0024allocator_0040D_00402_0040_0040std_0040_0040V56_0040_N_0040Z_00404IA & 2) == 0)
				{
					_003FA0x11566818_002E_003F_0024S2_0040_003F1_003F_003FFilePath_0040Conf_0040HOLMImpulse_0040HOLM_0040_0040YA_003FAV_003F_0024basic_string_0040DU_003F_0024char_traits_0040D_0040std_0040_0040V_003F_0024allocator_0040D_00402_0040_0040std_0040_0040V56_0040_N_0040Z_00404IA |= 2u;
					try
					{
						string fullName = Directory.GetParent(Application.UserAppDataPath).FullName;
						HOLM_002EMiscHelper_002EStringToStd((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003FA0x11566818_002E_003FUserDirectory_0040_003F1_003F_003FFilePath_0040Conf_0040HOLMImpulse_0040HOLM_0040_0040YA_003FAV_003F_0024basic_string_0040DU_003F_0024char_traits_0040D_0040std_0040_0040V_003F_0024allocator_0040D_00402_0040_0040std_0040_0040V56_0040_N_0040Z_00404V56_0040B), fullName);
						_atexit_m((delegate*<void>)(&_003FA0x11566818_002E_003F_003F__FUserDirectory_0040_003F1_003F_003FFilePath_0040Conf_0040HOLMImpulse_0040HOLM_0040_0040YA_003FAV_003F_0024basic_string_0040DU_003F_0024char_traits_0040D_0040std_0040_0040V_003F_0024allocator_0040D_00402_0040_0040std_0040_0040V45_0040_N_0040Z_0040YMXXZ));
					}
					catch
					{
						//try-fault
						_003FA0x11566818_002E_003F_0024S2_0040_003F1_003F_003FFilePath_0040Conf_0040HOLMImpulse_0040HOLM_0040_0040YA_003FAV_003F_0024basic_string_0040DU_003F_0024char_traits_0040D_0040std_0040_0040V_003F_0024allocator_0040D_00402_0040_0040std_0040_0040V56_0040_N_0040Z_00404IA &= 4294967293u;
						throw;
					}
				}
				if (fSystem)
				{
					System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj);
					basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* ptr = std_002Eoperator_002B_003Cchar_002Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_002Cclass_0020std_003A_003Aallocator_003Cchar_003E_0020_003E(&obj, (basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003FA0x11566818_002E_003FSystemDirectory_0040_003F1_003F_003FFilePath_0040Conf_0040HOLMImpulse_0040HOLM_0040_0040YA_003FAV_003F_0024basic_string_0040DU_003F_0024char_traits_0040D_0040std_0040_0040V_003F_0024allocator_0040D_00402_0040_0040std_0040_0040V56_0040_N_0040Z_00404V56_0040B), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01KICIPPFI_0040_003F2_003F_0024AA_0040));
					try
					{
						std_002Eoperator_002B_003Cchar_002Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_002Cclass_0020std_003A_003Aallocator_003Cchar_003E_0020_003E(P_0, ptr, fileName);
						num = 1u;
					}
					catch
					{
						//try-fault
						___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), &obj);
						throw;
					}
					std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D(&obj);
					goto IL_00da;
				}
			}
			catch
			{
				//try-fault
				___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), fileName);
				throw;
			}
			try
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj2);
				basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* ptr2 = std_002Eoperator_002B_003Cchar_002Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_002Cclass_0020std_003A_003Aallocator_003Cchar_003E_0020_003E(&obj2, (basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003FA0x11566818_002E_003FUserDirectory_0040_003F1_003F_003FFilePath_0040Conf_0040HOLMImpulse_0040HOLM_0040_0040YA_003FAV_003F_0024basic_string_0040DU_003F_0024char_traits_0040D_0040std_0040_0040V_003F_0024allocator_0040D_00402_0040_0040std_0040_0040V56_0040_N_0040Z_00404V56_0040B), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01KICIPPFI_0040_003F2_003F_0024AA_0040));
				try
				{
					std_002Eoperator_002B_003Cchar_002Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_002Cclass_0020std_003A_003Aallocator_003Cchar_003E_0020_003E(P_0, ptr2, fileName);
					num = 1u;
				}
				catch
				{
					//try-fault
					___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), &obj2);
					throw;
				}
				std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D(&obj2);
			}
			catch
			{
				//try-fault
				___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), fileName);
				throw;
			}
			std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D(fileName);
			return P_0;
			IL_00da:
			std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D(fileName);
			return P_0;
		}
		catch
		{
			//try-fault
			if ((num & (true ? 1u : 0u)) != 0)
			{
				num &= 0xFFFFFFFEu;
				___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), P_0);
			}
			throw;
		}
	}

	internal unsafe static void _003FA0x11566818_002E_003F_003F__FUserDirectory_0040_003F1_003F_003FFilePath_0040Conf_0040HOLMImpulse_0040HOLM_0040_0040YA_003FAV_003F_0024basic_string_0040DU_003F_0024char_traits_0040D_0040std_0040_0040V_003F_0024allocator_0040D_00402_0040_0040std_0040_0040V45_0040_N_0040Z_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003FA0x11566818_002E_003FUserDirectory_0040_003F1_003F_003FFilePath_0040Conf_0040HOLMImpulse_0040HOLM_0040_0040YA_003FAV_003F_0024basic_string_0040DU_003F_0024char_traits_0040D_0040std_0040_0040V_003F_0024allocator_0040D_00402_0040_0040std_0040_0040V56_0040_N_0040Z_00404V56_0040B));
	}

	internal unsafe static void _003FA0x11566818_002E_003F_003F__FSystemDirectory_0040_003F1_003F_003FFilePath_0040Conf_0040HOLMImpulse_0040HOLM_0040_0040YA_003FAV_003F_0024basic_string_0040DU_003F_0024char_traits_0040D_0040std_0040_0040V_003F_0024allocator_0040D_00402_0040_0040std_0040_0040V45_0040_N_0040Z_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003FA0x11566818_002E_003FSystemDirectory_0040_003F1_003F_003FFilePath_0040Conf_0040HOLMImpulse_0040HOLM_0040_0040YA_003FAV_003F_0024basic_string_0040DU_003F_0024char_traits_0040D_0040std_0040_0040V_003F_0024allocator_0040D_00402_0040_0040std_0040_0040V56_0040_N_0040Z_00404V56_0040B));
	}

	internal unsafe static string HOLM_002EHOLMImpulse_002EConf_002EFilePathString(basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* fileName, [MarshalAs(UnmanagedType.U1)] bool fSystem)
	{
		string result;
		try
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj);
			basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* ptr = &obj;
			basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* fileName2 = std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D(&obj, fileName);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj2);
			basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* ptr2 = HOLM_002EHOLMImpulse_002EConf_002EFilePath(&obj2, fileName2, fSystem);
			try
			{
				result = new string(std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002Ec_str(ptr2));
			}
			catch
			{
				//try-fault
				___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), &obj2);
				throw;
			}
			std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D(&obj2);
		}
		catch
		{
			//try-fault
			___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), fileName);
			throw;
		}
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D(fileName);
		return result;
	}

	internal unsafe static basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* HOLM_002EHOLMImpulse_002EConf_002EFilePath(basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* P_0, basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* fileName)
	{
		uint num = 0u;
		try
		{
			try
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj);
				basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* ptr = &obj;
				basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* fileName2 = std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D(&obj, fileName);
				HOLM_002EHOLMImpulse_002EConf_002EFilePath(P_0, fileName2, false);
				num = 1u;
			}
			catch
			{
				//try-fault
				___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), fileName);
				throw;
			}
			std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D(fileName);
			return P_0;
		}
		catch
		{
			//try-fault
			if ((num & (true ? 1u : 0u)) != 0)
			{
				num &= 0xFFFFFFFEu;
				___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), P_0);
			}
			throw;
		}
	}

	internal unsafe static basic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E* HOLM_002EHOLMImpulse_002EConf_002EFilePath(basic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E* P_0, basic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E* fileName)
	{
		uint num = 0u;
		try
		{
			try
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E obj);
				basic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E* ptr = &obj;
				basic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E* fileName2 = std_002Ebasic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E_002E_007Bctor_007D(&obj, fileName);
				HOLM_002EHOLMImpulse_002EConf_002EFilePath(P_0, fileName2, false);
				num = 1u;
			}
			catch
			{
				//try-fault
				___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E_002E_007Bdtor_007D), fileName);
				throw;
			}
			std_002Ebasic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E_002E_007Bdtor_007D(fileName);
			return P_0;
		}
		catch
		{
			//try-fault
			if ((num & (true ? 1u : 0u)) != 0)
			{
				num &= 0xFFFFFFFEu;
				___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E_002E_007Bdtor_007D), P_0);
			}
			throw;
		}
	}

	internal unsafe static string HOLM_002EHOLMImpulse_002EConf_002EFilePathString(basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* fileName)
	{
		string result;
		try
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj);
			basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* ptr = &obj;
			basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* fileName2 = std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D(&obj, fileName);
			result = HOLM_002EHOLMImpulse_002EConf_002EFilePathString(fileName2, fSystem: false);
		}
		catch
		{
			//try-fault
			___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), fileName);
			throw;
		}
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D(fileName);
		return result;
	}

	internal unsafe static uint HOLM_002EHOLMImpulse_002EConf_002EProductVersionNumber(string versionString)
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj);
		HOLM_002EMiscHelper_002EStringToStd(&obj, versionString);
		uint num;
		try
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj2);
			std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D(&obj2, (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01LFCBOECM_0040_003F4_003F_0024AA_0040));
			System.Runtime.CompilerServices.Unsafe.SkipInit(out vector_003Cstd_003A_003Abasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002Cstd_003A_003Aallocator_003Cstd_003A_003Abasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_0020_003E_0020_003E obj4);
			try
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj3);
				std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D(&obj3, std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002Edata(&obj));
				try
				{
					HOLM_002ETokenize(&obj4, &obj3, &obj2);
				}
				catch
				{
					//try-fault
					___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), &obj3);
					throw;
				}
				try
				{
					std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D(&obj3);
				}
				catch
				{
					//try-fault
					___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<vector_003Cstd_003A_003Abasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002Cstd_003A_003Aallocator_003Cstd_003A_003Abasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_0020_003E_0020_003E*, void>)(&std_002Evector_003Cstd_003A_003Abasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002Cstd_003A_003Aallocator_003Cstd_003A_003Abasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_0020_003E_0020_003E_002E_007Bdtor_007D), &obj4);
					throw;
				}
			}
			catch
			{
				//try-fault
				___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), &obj2);
				throw;
			}
			try
			{
				std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D(&obj2);
				num = 0u;
				uint num2 = 1000000u;
				basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* ptr = (basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)(int)System.Runtime.CompilerServices.Unsafe.As<vector_003Cstd_003A_003Abasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002Cstd_003A_003Aallocator_003Cstd_003A_003Abasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_0020_003E_0020_003E, uint>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj4, 12));
				if ((uint)System.Runtime.CompilerServices.Unsafe.As<vector_003Cstd_003A_003Abasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002Cstd_003A_003Aallocator_003Cstd_003A_003Abasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_0020_003E_0020_003E, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj4, 12)) > (uint)System.Runtime.CompilerServices.Unsafe.As<vector_003Cstd_003A_003Abasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002Cstd_003A_003Aallocator_003Cstd_003A_003Abasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_0020_003E_0020_003E, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj4, 16)))
				{
					_invalid_parameter_noinfo();
				}
				System.Runtime.CompilerServices.Unsafe.SkipInit(out _Vector_iterator_003Cstd_003A_003Abasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002Cstd_003A_003Aallocator_003Cstd_003A_003Abasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_0020_003E_0020_003E obj5);
				*(int*)(&obj5) = *(int*)(&obj4);
				System.Runtime.CompilerServices.Unsafe.As<_Vector_iterator_003Cstd_003A_003Abasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002Cstd_003A_003Aallocator_003Cstd_003A_003Abasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_0020_003E_0020_003E, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj5, 4)) = (int)ptr;
				_Vector_const_iterator_003Cstd_003A_003Abasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002Cstd_003A_003Aallocator_003Cstd_003A_003Abasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_0020_003E_0020_003E obj6 = (_Vector_const_iterator_003Cstd_003A_003Abasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002Cstd_003A_003Aallocator_003Cstd_003A_003Abasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_0020_003E_0020_003E)obj5;
				while (true)
				{
					basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* ptr2 = (basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)(int)System.Runtime.CompilerServices.Unsafe.As<vector_003Cstd_003A_003Abasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002Cstd_003A_003Aallocator_003Cstd_003A_003Abasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_0020_003E_0020_003E, uint>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj4, 16));
					if ((uint)System.Runtime.CompilerServices.Unsafe.As<vector_003Cstd_003A_003Abasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002Cstd_003A_003Aallocator_003Cstd_003A_003Abasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_0020_003E_0020_003E, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj4, 12)) > (uint)System.Runtime.CompilerServices.Unsafe.As<vector_003Cstd_003A_003Abasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002Cstd_003A_003Aallocator_003Cstd_003A_003Abasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_0020_003E_0020_003E, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj4, 16)))
					{
						_invalid_parameter_noinfo();
					}
					if ((byte)((*(int*)(&obj6) != 0) ? 1 : 0) == 0 || !(*(int*)(&obj6) == *(int*)(&obj4)))
					{
						_invalid_parameter_noinfo();
					}
					if (!((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.As<_Vector_const_iterator_003Cstd_003A_003Abasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002Cstd_003A_003Aallocator_003Cstd_003A_003Abasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_0020_003E_0020_003E, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj6, 4)) == ptr2))
					{
						if ((byte)((*(int*)(&obj6) != 0) ? 1 : 0) == 0)
						{
							_invalid_parameter_noinfo();
						}
						_Container_base_aux* ptr3 = (_Container_base_aux*)((*(int*)(&obj6) == 0) ? 0 : ((int)(*(uint*)(int)(*(uint*)(&obj6)))));
						if ((uint)System.Runtime.CompilerServices.Unsafe.As<_Vector_const_iterator_003Cstd_003A_003Abasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002Cstd_003A_003Aallocator_003Cstd_003A_003Abasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_0020_003E_0020_003E, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj6, 4)) >= (uint)(*(int*)((byte*)ptr3 + 16)))
						{
							_invalid_parameter_noinfo();
						}
						num = (uint)(atoi(std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002Edata((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)(int)System.Runtime.CompilerServices.Unsafe.As<_Vector_const_iterator_003Cstd_003A_003Abasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002Cstd_003A_003Aallocator_003Cstd_003A_003Abasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_0020_003E_0020_003E, uint>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj6, 4)))) * (int)num2) + num;
						num2 /= 100;
						if ((byte)((*(int*)(&obj6) != 0) ? 1 : 0) == 0)
						{
							_invalid_parameter_noinfo();
						}
						_Container_base_aux* ptr4 = (_Container_base_aux*)((*(int*)(&obj6) == 0) ? 0 : ((int)(*(uint*)(int)(*(uint*)(&obj6)))));
						if ((uint)System.Runtime.CompilerServices.Unsafe.As<_Vector_const_iterator_003Cstd_003A_003Abasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002Cstd_003A_003Aallocator_003Cstd_003A_003Abasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_0020_003E_0020_003E, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj6, 4)) >= (uint)(*(int*)((byte*)ptr4 + 16)))
						{
							_invalid_parameter_noinfo();
						}
						System.Runtime.CompilerServices.Unsafe.As<_Vector_const_iterator_003Cstd_003A_003Abasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002Cstd_003A_003Aallocator_003Cstd_003A_003Abasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_0020_003E_0020_003E, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj6, 4)) += 28;
						continue;
					}
					break;
				}
			}
			catch
			{
				//try-fault
				___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<vector_003Cstd_003A_003Abasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002Cstd_003A_003Aallocator_003Cstd_003A_003Abasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_0020_003E_0020_003E*, void>)(&std_002Evector_003Cstd_003A_003Abasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002Cstd_003A_003Aallocator_003Cstd_003A_003Abasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_0020_003E_0020_003E_002E_007Bdtor_007D), &obj4);
				throw;
			}
			try
			{
				if (System.Runtime.CompilerServices.Unsafe.As<vector_003Cstd_003A_003Abasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002Cstd_003A_003Aallocator_003Cstd_003A_003Abasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_0020_003E_0020_003E, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj4, 12)) != 0)
				{
					basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* ptr5 = (basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)(int)System.Runtime.CompilerServices.Unsafe.As<vector_003Cstd_003A_003Abasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002Cstd_003A_003Aallocator_003Cstd_003A_003Abasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_0020_003E_0020_003E, uint>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj4, 16));
					basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* ptr6 = (basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)(int)System.Runtime.CompilerServices.Unsafe.As<vector_003Cstd_003A_003Abasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002Cstd_003A_003Aallocator_003Cstd_003A_003Abasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_0020_003E_0020_003E, uint>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj4, 12));
					if (System.Runtime.CompilerServices.Unsafe.As<vector_003Cstd_003A_003Abasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002Cstd_003A_003Aallocator_003Cstd_003A_003Abasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_0020_003E_0020_003E, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj4, 12)) != System.Runtime.CompilerServices.Unsafe.As<vector_003Cstd_003A_003Abasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002Cstd_003A_003Aallocator_003Cstd_003A_003Abasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_0020_003E_0020_003E, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj4, 16)))
					{
						do
						{
							std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D(ptr6);
							ptr6 = (basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)((byte*)ptr6 + 28);
						}
						while (ptr6 != ptr5);
					}
					delete((void*)(int)System.Runtime.CompilerServices.Unsafe.As<vector_003Cstd_003A_003Abasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002Cstd_003A_003Aallocator_003Cstd_003A_003Abasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_0020_003E_0020_003E, uint>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj4, 12)));
				}
				System.Runtime.CompilerServices.Unsafe.As<vector_003Cstd_003A_003Abasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002Cstd_003A_003Aallocator_003Cstd_003A_003Abasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_0020_003E_0020_003E, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj4, 12)) = 0;
				System.Runtime.CompilerServices.Unsafe.As<vector_003Cstd_003A_003Abasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002Cstd_003A_003Aallocator_003Cstd_003A_003Abasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_0020_003E_0020_003E, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj4, 16)) = 0;
				System.Runtime.CompilerServices.Unsafe.As<vector_003Cstd_003A_003Abasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002Cstd_003A_003Aallocator_003Cstd_003A_003Abasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_0020_003E_0020_003E, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj4, 20)) = 0;
			}
			catch
			{
				//try-fault
				___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<_Vector_val_003Cstd_003A_003Abasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002Cstd_003A_003Aallocator_003Cstd_003A_003Abasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_0020_003E_0020_003E*, void>)(&std_002E_Vector_val_003Cstd_003A_003Abasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002Cstd_003A_003Aallocator_003Cstd_003A_003Abasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_0020_003E_0020_003E_002E_007Bdtor_007D), &obj4);
				throw;
			}
			delete((void*)(int)(*(uint*)(&obj4)));
		}
		catch
		{
			//try-fault
			___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), &obj);
			throw;
		}
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D(&obj);
		return num;
	}

	internal unsafe static void std_002Evector_003Cstd_003A_003Abasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002Cstd_003A_003Aallocator_003Cstd_003A_003Abasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_0020_003E_0020_003E_002E_007Bdtor_007D(vector_003Cstd_003A_003Abasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002Cstd_003A_003Aallocator_003Cstd_003A_003Abasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_0020_003E_0020_003E* P_0)
	{
		try
		{
			std_002Evector_003Cstd_003A_003Abasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002Cstd_003A_003Aallocator_003Cstd_003A_003Abasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_0020_003E_0020_003E_002E_Tidy(P_0);
		}
		catch
		{
			//try-fault
			___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<_Vector_val_003Cstd_003A_003Abasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002Cstd_003A_003Aallocator_003Cstd_003A_003Abasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_0020_003E_0020_003E*, void>)(&std_002E_Vector_val_003Cstd_003A_003Abasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002Cstd_003A_003Aallocator_003Cstd_003A_003Abasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_0020_003E_0020_003E_002E_007Bdtor_007D), P_0);
			throw;
		}
		delete((void*)(int)(*(uint*)P_0));
	}

	internal unsafe static void std_002E_Vector_val_003Cstd_003A_003Abasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002Cstd_003A_003Aallocator_003Cstd_003A_003Abasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_0020_003E_0020_003E_002E_007Bdtor_007D(_Vector_val_003Cstd_003A_003Abasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002Cstd_003A_003Aallocator_003Cstd_003A_003Abasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_0020_003E_0020_003E* P_0)
	{
		delete((void*)(int)(*(uint*)P_0));
	}

	internal unsafe static void std_002Evector_003Cstd_003A_003Abasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002Cstd_003A_003Aallocator_003Cstd_003A_003Abasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_0020_003E_0020_003E_002E_Tidy(vector_003Cstd_003A_003Abasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002Cstd_003A_003Aallocator_003Cstd_003A_003Abasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_0020_003E_0020_003E* P_0)
	{
		uint num = *(uint*)((byte*)P_0 + 12);
		if (num != 0)
		{
			basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* ptr = (basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)(int)(*(uint*)((byte*)P_0 + 16));
			basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* ptr2 = (basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)(int)num;
			if (ptr2 != ptr)
			{
				do
				{
					std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D(ptr2);
					ptr2 = (basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)((byte*)ptr2 + 28);
				}
				while (ptr2 != ptr);
			}
			delete((void*)(int)(*(uint*)((byte*)P_0 + 12)));
		}
		*(int*)((byte*)P_0 + 12) = 0;
		*(int*)((byte*)P_0 + 16) = 0;
		*(int*)((byte*)P_0 + 20) = 0;
	}

	internal static double _Pow_int_003Cdouble_003E(double _X, int _Y)
	{
		uint num = (uint)((_Y < 0) ? (-_Y) : _Y);
		double num2 = 1.0;
		while (true)
		{
			if ((num & (true ? 1u : 0u)) != 0)
			{
				num2 *= _X;
			}
			num >>= 1;
			if (num == 0)
			{
				break;
			}
			double num3 = _X;
			_X = num3 * num3;
		}
		if (_Y < 0)
		{
			return 1.0 / num2;
		}
		return num2;
	}

	internal unsafe static void std_002Elength_error_002E_007Bdtor_007D(length_error* P_0)
	{
		*(int*)P_0 = (int)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_7length_error_0040std_0040_00406B_0040);
		*(int*)P_0 = (int)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_7logic_error_0040std_0040_00406B_0040);
		try
		{
			std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)((byte*)P_0 + 12));
		}
		catch
		{
			//try-fault
			___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<exception*, void>)(&std_002Eexception_002E_007Bdtor_007D), P_0);
			throw;
		}
		std_002Eexception_002E_007Bdtor_007D((exception*)P_0);
	}

	internal unsafe static void* std_002Elength_error_002E__vecDelDtor(length_error* P_0, uint P_1)
	{
		if ((P_1 & 2u) != 0)
		{
			length_error* ptr = (length_error*)((byte*)P_0 - 4);
			__ehvec_dtor(P_0, 40u, *(int*)ptr, (delegate*<void*, void>)(delegate*<length_error*, void>)(&std_002Elength_error_002E_007Bdtor_007D));
			if ((P_1 & (true ? 1u : 0u)) != 0)
			{
				delete_005B_005D(ptr);
			}
			return ptr;
		}
		*(int*)P_0 = (int)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_7length_error_0040std_0040_00406B_0040);
		*(int*)P_0 = (int)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_7logic_error_0040std_0040_00406B_0040);
		try
		{
			std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)((byte*)P_0 + 12));
		}
		catch
		{
			//try-fault
			___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<exception*, void>)(&std_002Eexception_002E_007Bdtor_007D), P_0);
			throw;
		}
		std_002Eexception_002E_007Bdtor_007D((exception*)P_0);
		if ((P_1 & (true ? 1u : 0u)) != 0)
		{
			delete(P_0);
		}
		return P_0;
	}

	internal unsafe static void _003FA0x316290b9_002E_003F_003F__E_003FA0x316290b9_0040HEXSTRINGARRAY_0040MiscHelper_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EMiscHelper_002E_003FA0x316290b9_002EHEXSTRINGARRAY), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01GBGANLPD_00400_003F_0024AA_0040));
		try
		{
			std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x316290b9_002EHEXSTRINGARRAY, 28)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01HIHLOKLC_00401_003F_0024AA_0040));
			try
			{
				std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x316290b9_002EHEXSTRINGARRAY, 56)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01FDFGLJHB_00402_003F_0024AA_0040));
				try
				{
					std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x316290b9_002EHEXSTRINGARRAY, 84)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01EKENIIDA_00403_003F_0024AA_0040));
					try
					{
						std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x316290b9_002EHEXSTRINGARRAY, 112)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01FAMBOPH_00404_003F_0024AA_0040));
						try
						{
							std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x316290b9_002EHEXSTRINGARRAY, 140)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01BMBHCPLG_00405_003F_0024AA_0040));
							try
							{
								std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x316290b9_002EHEXSTRINGARRAY, 168)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01DHDKHMHF_00406_003F_0024AA_0040));
								try
								{
									std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x316290b9_002EHEXSTRINGARRAY, 196)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01COCBENDE_00407_003F_0024AA_0040));
									try
									{
										std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x316290b9_002EHEXSTRINGARRAY, 224)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01KJLJFBPL_00408_003F_0024AA_0040));
										try
										{
											std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x316290b9_002EHEXSTRINGARRAY, 252)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01LAKCGALK_00409_003F_0024AA_0040));
											try
											{
												std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x316290b9_002EHEXSTRINGARRAY, 280)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01FHEEJDEE_0040A_003F_0024AA_0040));
												try
												{
													std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x316290b9_002EHEXSTRINGARRAY, 308)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01HMGJMAIH_0040B_003F_0024AA_0040));
													try
													{
														std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x316290b9_002EHEXSTRINGARRAY, 336)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01GFHCPBMG_0040C_003F_0024AA_0040));
														try
														{
															std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x316290b9_002EHEXSTRINGARRAY, 364)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01CKDDGHAB_0040D_003F_0024AA_0040));
															try
															{
																std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x316290b9_002EHEXSTRINGARRAY, 392)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01DDCIFGEA_0040E_003F_0024AA_0040));
																try
																{
																	std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x316290b9_002EHEXSTRINGARRAY, 420)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01BIAFAFID_0040F_003F_0024AA_0040));
																}
																catch
																{
																	//try-fault
																	___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x316290b9_002EHEXSTRINGARRAY, 392)));
																	throw;
																}
															}
															catch
															{
																//try-fault
																___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x316290b9_002EHEXSTRINGARRAY, 364)));
																throw;
															}
														}
														catch
														{
															//try-fault
															___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x316290b9_002EHEXSTRINGARRAY, 336)));
															throw;
														}
													}
													catch
													{
														//try-fault
														___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x316290b9_002EHEXSTRINGARRAY, 308)));
														throw;
													}
												}
												catch
												{
													//try-fault
													___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x316290b9_002EHEXSTRINGARRAY, 280)));
													throw;
												}
											}
											catch
											{
												//try-fault
												___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x316290b9_002EHEXSTRINGARRAY, 252)));
												throw;
											}
										}
										catch
										{
											//try-fault
											___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x316290b9_002EHEXSTRINGARRAY, 224)));
											throw;
										}
									}
									catch
									{
										//try-fault
										___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x316290b9_002EHEXSTRINGARRAY, 196)));
										throw;
									}
								}
								catch
								{
									//try-fault
									___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x316290b9_002EHEXSTRINGARRAY, 168)));
									throw;
								}
							}
							catch
							{
								//try-fault
								___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x316290b9_002EHEXSTRINGARRAY, 140)));
								throw;
							}
						}
						catch
						{
							//try-fault
							___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x316290b9_002EHEXSTRINGARRAY, 112)));
							throw;
						}
					}
					catch
					{
						//try-fault
						___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x316290b9_002EHEXSTRINGARRAY, 84)));
						throw;
					}
				}
				catch
				{
					//try-fault
					___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x316290b9_002EHEXSTRINGARRAY, 56)));
					throw;
				}
			}
			catch
			{
				//try-fault
				___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x316290b9_002EHEXSTRINGARRAY, 28)));
				throw;
			}
		}
		catch
		{
			//try-fault
			___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EMiscHelper_002E_003FA0x316290b9_002EHEXSTRINGARRAY));
			throw;
		}
		_atexit_m((delegate*<void>)(&_003FA0x316290b9_002E_003F_003F__F_003FA0x316290b9_0040HEXSTRINGARRAY_0040MiscHelper_0040HOLM_0040_0040YMXXZ));
	}

	internal unsafe static void _003FA0x316290b9_002E_003F_003F__F_003FA0x316290b9_0040HEXSTRINGARRAY_0040MiscHelper_0040HOLM_0040_0040YMXXZ()
	{
		__ehvec_dtor(System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EMiscHelper_002E_003FA0x316290b9_002EHEXSTRINGARRAY), 28u, 16, (delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D));
	}

	internal unsafe static void _003FA0x316290b9_002E_003F_003F__E_003FA0x316290b9_0040HOLM_WINDOW_FPGA_CTRL_0040MiscHelper_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EMiscHelper_002E_003FA0x316290b9_002EHOLM_WINDOW_FPGA_CTRL), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_0BD_0040CPFABDBC_0040HOLMFpgaController_003F_0024AA_0040));
		_atexit_m((delegate*<void>)(&_003FA0x316290b9_002E_003F_003F__F_003FA0x316290b9_0040HOLM_WINDOW_FPGA_CTRL_0040MiscHelper_0040HOLM_0040_0040YMXXZ));
	}

	internal unsafe static void _003FA0x316290b9_002E_003F_003F__F_003FA0x316290b9_0040HOLM_WINDOW_FPGA_CTRL_0040MiscHelper_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EMiscHelper_002E_003FA0x316290b9_002EHOLM_WINDOW_FPGA_CTRL));
	}

	internal unsafe static void _003FA0x316290b9_002E_003F_003F__E_003FA0x316290b9_0040HOLM_WINDOW_DSPreLab_0040MiscHelper_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EMiscHelper_002E_003FA0x316290b9_002EHOLM_WINDOW_DSPreLab), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_08LKNALPII_0040DSPreLab_003F_0024AA_0040));
		_atexit_m((delegate*<void>)(&_003FA0x316290b9_002E_003F_003F__F_003FA0x316290b9_0040HOLM_WINDOW_DSPreLab_0040MiscHelper_0040HOLM_0040_0040YMXXZ));
	}

	internal unsafe static void _003FA0x316290b9_002E_003F_003F__F_003FA0x316290b9_0040HOLM_WINDOW_DSPreLab_0040MiscHelper_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EMiscHelper_002E_003FA0x316290b9_002EHOLM_WINDOW_DSPreLab));
	}

	internal unsafe static void _003FA0x316290b9_002E_003F_003F__E_003FA0x316290b9_0040HOLM_WINDOW_DSPreLab_DEMO_0040MiscHelper_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EMiscHelper_002E_003FA0x316290b9_002EHOLM_WINDOW_DSPreLab_DEMO), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_0BA_0040MFILEGDE_0040DEMO_003F5_003F9_003F5DSPreLab_003F_0024AA_0040));
		_atexit_m((delegate*<void>)(&_003FA0x316290b9_002E_003F_003F__F_003FA0x316290b9_0040HOLM_WINDOW_DSPreLab_DEMO_0040MiscHelper_0040HOLM_0040_0040YMXXZ));
	}

	internal unsafe static void _003FA0x316290b9_002E_003F_003F__F_003FA0x316290b9_0040HOLM_WINDOW_DSPreLab_DEMO_0040MiscHelper_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EMiscHelper_002E_003FA0x316290b9_002EHOLM_WINDOW_DSPreLab_DEMO));
	}

	internal static void _003FA0x316290b9_002E_003F_003F__E_003FA0x316290b9_0040PI_0040Math_0040HOLM_0040_0040YMXXZ()
	{
		HOLM_002EMath_002E_003FA0x316290b9_002EPI = Math.Acos(-1.0);
	}

	internal static void _003FA0x316290b9_002E_003F_003F__E_003FA0x316290b9_0040PI_F_0040Math_0040HOLM_0040_0040YMXXZ()
	{
		HOLM_002EMath_002E_003FA0x316290b9_002EPI_F = (float)Math.Acos(-1.0);
	}

	internal static void _003FA0x316290b9_002E_003F_003F__E_003FA0x316290b9_0040TWOPI_0040Math_0040HOLM_0040_0040YMXXZ()
	{
		HOLM_002EMath_002E_003FA0x316290b9_002ETWOPI = HOLM_002EMath_002E_003FA0x316290b9_002EPI * 2.0;
	}

	internal static void _003FA0x316290b9_002E_003F_003F__E_003FA0x316290b9_0040HALFPI_0040Math_0040HOLM_0040_0040YMXXZ()
	{
		HOLM_002EMath_002E_003FA0x316290b9_002EHALFPI = HOLM_002EMath_002E_003FA0x316290b9_002EPI * 0.5;
	}

	internal static void _003FA0x316290b9_002E_003F_003F__E_003FA0x316290b9_0040SQRT2_0040Math_0040HOLM_0040_0040YMXXZ()
	{
		HOLM_002EMath_002E_003FA0x316290b9_002ESQRT2 = Math.Sqrt(2.0);
	}

	internal static void _003FA0x316290b9_002E_003F_003F__E_003FA0x316290b9_0040SQRT2_F_0040Math_0040HOLM_0040_0040YMXXZ()
	{
		HOLM_002EMath_002E_003FA0x316290b9_002ESQRT2_F = (float)Math.Sqrt(2.0);
	}

	internal static void _003FA0x316290b9_002E_003F_003F__E_003FA0x316290b9_0040RadToDeg_0040Math_0040HOLM_0040_0040YMXXZ()
	{
		HOLM_002EMath_002E_003FA0x316290b9_002ERadToDeg = 180.0 / HOLM_002EMath_002E_003FA0x316290b9_002EPI;
	}

	internal static void _003FA0x316290b9_002E_003F_003F__E_003FA0x316290b9_0040RadToDeg_F_0040Math_0040HOLM_0040_0040YMXXZ()
	{
		HOLM_002EMath_002E_003FA0x316290b9_002ERadToDeg_F = (float)(180.0 / (double)HOLM_002EMath_002E_003FA0x316290b9_002EPI_F);
	}

	internal static void _003FA0x316290b9_002E_003F_003F__E_003FA0x316290b9_0040DegToRad_0040Math_0040HOLM_0040_0040YMXXZ()
	{
		HOLM_002EMath_002E_003FA0x316290b9_002EDegToRad = HOLM_002EMath_002E_003FA0x316290b9_002EPI / 180.0;
	}

	internal static void _003FA0x316290b9_002E_003F_003F__E_003FA0x316290b9_0040DegToRad_F_0040Math_0040HOLM_0040_0040YMXXZ()
	{
		HOLM_002EMath_002E_003FA0x316290b9_002EDegToRad_F = HOLM_002EMath_002E_003FA0x316290b9_002EPI_F / 180f;
	}

	internal static void _003FA0x316290b9_002E_003F_003F__E_003FA0x316290b9_0040MILLISEC_TO_CM_0040Measure_0040HOLM_0040_0040YMXXZ()
	{
		HOLM_002EMeasure_002E_003FA0x316290b9_002EMILLISEC_TO_CM = HOLM_002EMeasure_002E_003FA0x316290b9_002ESEC_TO_CM / 1000.0;
	}

	internal static void _003FA0x316290b9_002E_003F_003F__E_003FA0x316290b9_0040MICROSEC_TO_CM_0040Measure_0040HOLM_0040_0040YMXXZ()
	{
		HOLM_002EMeasure_002E_003FA0x316290b9_002EMICROSEC_TO_CM = HOLM_002EMeasure_002E_003FA0x316290b9_002EMILLISEC_TO_CM / 1000.0;
	}

	internal unsafe static Measurement* HOLM_002EMeasure_002EMeasurement_002E_007Bctor_007D(Measurement* P_0, basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* labelIn)
	{
		HOLM_002EMeasure_002EMeasurementCore_002E_007Bctor_007D((MeasurementCore*)P_0, labelIn);
		try
		{
			*(int*)((byte*)P_0 + 416) = 0;
			return P_0;
		}
		catch
		{
			//try-fault
			___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<MeasurementCore*, void>)(&HOLM_002EMeasure_002EMeasurementCore_002E_007Bdtor_007D), P_0);
			throw;
		}
	}

	internal unsafe static void _003FA0x316290b9_002E_003F_003F__E_003FA0x316290b9_0040OPTIONS_COMPAT_START_0040Constants_0040HOLMImpulse_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x316290b9_002EOPTIONS_COMPAT_START), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_07EBPGIHEF_00401_003F41_003F41_003F41_003F_0024AA_0040));
		_atexit_m((delegate*<void>)(&_003FA0x316290b9_002E_003F_003F__F_003FA0x316290b9_0040OPTIONS_COMPAT_START_0040Constants_0040HOLMImpulse_0040HOLM_0040_0040YMXXZ));
	}

	internal unsafe static void _003FA0x316290b9_002E_003F_003F__F_003FA0x316290b9_0040OPTIONS_COMPAT_START_0040Constants_0040HOLMImpulse_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x316290b9_002EOPTIONS_COMPAT_START));
	}

	internal unsafe static void _003FA0x316290b9_002E_003F_003F__E_003FA0x316290b9_0040OPTIONS_AUTOSAVE_FILENAME_0040Constants_0040HOLMImpulse_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x316290b9_002EOPTIONS_AUTOSAVE_FILENAME), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_0BH_0040KPHMGOCK_0040HOLMImpulseOptions_003F4xml_003F_0024AA_0040));
		_atexit_m((delegate*<void>)(&_003FA0x316290b9_002E_003F_003F__F_003FA0x316290b9_0040OPTIONS_AUTOSAVE_FILENAME_0040Constants_0040HOLMImpulse_0040HOLM_0040_0040YMXXZ));
	}

	internal unsafe static void _003FA0x316290b9_002E_003F_003F__F_003FA0x316290b9_0040OPTIONS_AUTOSAVE_FILENAME_0040Constants_0040HOLMImpulse_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x316290b9_002EOPTIONS_AUTOSAVE_FILENAME));
	}

	internal unsafe static void _003FA0x316290b9_002E_003F_003F__E_003FA0x316290b9_0040AUTOSAVE_MEAS_FILENAME_0040Constants_0040HOLMImpulse_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x316290b9_002EAUTOSAVE_MEAS_FILENAME), (char*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_1CE_0040JMJFEPPE_0040_003F_0024AAM_003F_0024AAe_003F_0024AAa_003F_0024AAs_003F_0024AAA_003F_0024AAu_003F_0024AAt_003F_0024AAo_003F_0024AAs_003F_0024AAa_003F_0024AAv_003F_0024AAe_003F_0024AAd_003F_0024AA_003F4_003F_0024AAz_003F_0024AAi_003F_0024AAp_003F_0024AA_003F_0024AA_0040));
		_atexit_m((delegate*<void>)(&_003FA0x316290b9_002E_003F_003F__F_003FA0x316290b9_0040AUTOSAVE_MEAS_FILENAME_0040Constants_0040HOLMImpulse_0040HOLM_0040_0040YMXXZ));
	}

	internal unsafe static void _003FA0x316290b9_002E_003F_003F__F_003FA0x316290b9_0040AUTOSAVE_MEAS_FILENAME_0040Constants_0040HOLMImpulse_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E_002E_007Bdtor_007D((basic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x316290b9_002EAUTOSAVE_MEAS_FILENAME));
	}

	internal unsafe static void _003FA0x316290b9_002E_003F_003F__E_003FA0x316290b9_0040AUTOSAVE_MEAS_OBSOLETE_0040Constants_0040HOLMImpulse_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x316290b9_002EAUTOSAVE_MEAS_OBSOLETE), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_0BC_0040COMDONFP_0040MeasAutosaved_003F4hlm_003F_0024AA_0040));
		_atexit_m((delegate*<void>)(&_003FA0x316290b9_002E_003F_003F__F_003FA0x316290b9_0040AUTOSAVE_MEAS_OBSOLETE_0040Constants_0040HOLMImpulse_0040HOLM_0040_0040YMXXZ));
	}

	internal unsafe static void _003FA0x316290b9_002E_003F_003F__F_003FA0x316290b9_0040AUTOSAVE_MEAS_OBSOLETE_0040Constants_0040HOLMImpulse_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x316290b9_002EAUTOSAVE_MEAS_OBSOLETE));
	}

	internal unsafe static void _003FA0x316290b9_002E_003F_003F__E_003FA0x316290b9_0040AUTOSAVE_MEAS_OBSOLETE_DIR_0040Constants_0040HOLMImpulse_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x316290b9_002EAUTOSAVE_MEAS_OBSOLETE_DIR), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_0BC_0040JLNMFMDH_0040AutosavedObsolete_003F_0024AA_0040));
		_atexit_m((delegate*<void>)(&_003FA0x316290b9_002E_003F_003F__F_003FA0x316290b9_0040AUTOSAVE_MEAS_OBSOLETE_DIR_0040Constants_0040HOLMImpulse_0040HOLM_0040_0040YMXXZ));
	}

	internal unsafe static void _003FA0x316290b9_002E_003F_003F__F_003FA0x316290b9_0040AUTOSAVE_MEAS_OBSOLETE_DIR_0040Constants_0040HOLMImpulse_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x316290b9_002EAUTOSAVE_MEAS_OBSOLETE_DIR));
	}

	internal unsafe static void _003FA0x316290b9_002E_003F_003F__E_003FA0x316290b9_0040CAL_MIC_FILENAME_0040Constants_0040HOLMImpulse_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x316290b9_002ECAL_MIC_FILENAME), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_0BD_0040LOFKOGNA_0040CalibrationMic_003F4cal_003F_0024AA_0040));
		_atexit_m((delegate*<void>)(&_003FA0x316290b9_002E_003F_003F__F_003FA0x316290b9_0040CAL_MIC_FILENAME_0040Constants_0040HOLMImpulse_0040HOLM_0040_0040YMXXZ));
	}

	internal unsafe static void _003FA0x316290b9_002E_003F_003F__F_003FA0x316290b9_0040CAL_MIC_FILENAME_0040Constants_0040HOLMImpulse_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x316290b9_002ECAL_MIC_FILENAME));
	}

	internal unsafe static void _003FA0x316290b9_002E_003F_003F__E_003FA0x316290b9_0040CAL_DACADC_FILENAME_0040Constants_0040HOLMImpulse_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x316290b9_002ECAL_DACADC_FILENAME), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_0BG_0040GMNAFMJF_0040CalibrationDacAdc_003F4cal_003F_0024AA_0040));
		_atexit_m((delegate*<void>)(&_003FA0x316290b9_002E_003F_003F__F_003FA0x316290b9_0040CAL_DACADC_FILENAME_0040Constants_0040HOLMImpulse_0040HOLM_0040_0040YMXXZ));
	}

	internal unsafe static void _003FA0x316290b9_002E_003F_003F__F_003FA0x316290b9_0040CAL_DACADC_FILENAME_0040Constants_0040HOLMImpulse_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x316290b9_002ECAL_DACADC_FILENAME));
	}

	internal unsafe static void _003FA0x316290b9_002E_003F_003F__E_003FA0x316290b9_0040CHANGELOG_0040Constants_0040HOLMImpulse_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x316290b9_002ECHANGELOG), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_0O_0040EONGOMGC_0040ChangeLog_003F4txt_003F_0024AA_0040));
		_atexit_m((delegate*<void>)(&_003FA0x316290b9_002E_003F_003F__F_003FA0x316290b9_0040CHANGELOG_0040Constants_0040HOLMImpulse_0040HOLM_0040_0040YMXXZ));
	}

	internal unsafe static void _003FA0x316290b9_002E_003F_003F__F_003FA0x316290b9_0040CHANGELOG_0040Constants_0040HOLMImpulse_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x316290b9_002ECHANGELOG));
	}

	internal unsafe static void _003FA0x316290b9_002E_003F_003F__E_003FA0x316290b9_0040ISSUES_0040Constants_0040HOLMImpulse_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x316290b9_002EISSUES), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_0L_0040NGLIAIJP_0040Issues_003F4txt_003F_0024AA_0040));
		_atexit_m((delegate*<void>)(&_003FA0x316290b9_002E_003F_003F__F_003FA0x316290b9_0040ISSUES_0040Constants_0040HOLMImpulse_0040HOLM_0040_0040YMXXZ));
	}

	internal unsafe static void _003FA0x316290b9_002E_003F_003F__F_003FA0x316290b9_0040ISSUES_0040Constants_0040HOLMImpulse_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x316290b9_002EISSUES));
	}

	internal unsafe static void _003FA0x316290b9_002E_003F_003F__E_003FA0x316290b9_0040LICENSE_0040Constants_0040HOLMImpulse_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x316290b9_002ELICENSE), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_0M_0040HGMIFPO_0040LICENSE_003F4txt_003F_0024AA_0040));
		_atexit_m((delegate*<void>)(&_003FA0x316290b9_002E_003F_003F__F_003FA0x316290b9_0040LICENSE_0040Constants_0040HOLMImpulse_0040HOLM_0040_0040YMXXZ));
	}

	internal unsafe static void _003FA0x316290b9_002E_003F_003F__F_003FA0x316290b9_0040LICENSE_0040Constants_0040HOLMImpulse_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x316290b9_002ELICENSE));
	}

	internal unsafe static void _003FA0x316290b9_002E_003F_003F__E_003FA0x316290b9_0040TMP_PATH_MEASLIST_0040Constants_0040HOLMImpulse_0040HOLM_0040_0040YMXXZ()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj);
		basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* ptr = HOLM_002EMiscHelper_002EGetTmpDirSimple(&obj);
		try
		{
			std_002Eoperator_002B_003Cchar_002Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_002Cclass_0020std_003A_003Aallocator_003Cchar_003E_0020_003E((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x316290b9_002ETMP_PATH_MEASLIST), ptr, (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_0N_0040ONBJJBCP_0040_003F2MeasTmpList_003F_0024AA_0040));
		}
		catch
		{
			//try-fault
			___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), &obj);
			throw;
		}
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D(&obj);
		_atexit_m((delegate*<void>)(&_003FA0x316290b9_002E_003F_003F__F_003FA0x316290b9_0040TMP_PATH_MEASLIST_0040Constants_0040HOLMImpulse_0040HOLM_0040_0040YMXXZ));
	}

	internal unsafe static void _003FA0x316290b9_002E_003F_003F__F_003FA0x316290b9_0040TMP_PATH_MEASLIST_0040Constants_0040HOLMImpulse_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x316290b9_002ETMP_PATH_MEASLIST));
	}

	internal static void _003FA0x316290b9_002E_003F_003F__E_003FA0x316290b9_0040MEASURE_LOW_REJECT_AMP_0040Constants_0040HOLMImpulse_0040HOLM_0040_0040YMXXZ()
	{
		HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x316290b9_002EMEASURE_LOW_REJECT_AMP = HOLM_002EMath_002EDBToAmplitude_003Cdouble_003E(-70.0);
	}

	internal static void _003FA0x316290b9_002E_003F_003F__E_003FA0x316290b9_0040MEASURE_LOW_WARN_AMP_0040Constants_0040HOLMImpulse_0040HOLM_0040_0040YMXXZ()
	{
		HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x316290b9_002EMEASURE_LOW_WARN_AMP = HOLM_002EMath_002EDBToAmplitude_003Cdouble_003E(-40.0);
	}

	internal static void _003FA0x316290b9_002E_003F_003F__E_003FA0x316290b9_0040RunOnceCustomNewHandlerInt_0040Mem_0040_0040YMXXZ()
	{
		Mem_002E_003FA0x316290b9_002ERunOnceCustomNewHandlerInt = Mem_002ECustomNewHandlerInt();
	}

	internal unsafe static void _003FA0x11fcae0a_002E_003F_003F__E_003FA0x11fcae0a_0040HEXSTRINGARRAY_0040MiscHelper_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EMiscHelper_002E_003FA0x11fcae0a_002EHEXSTRINGARRAY), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01GBGANLPD_00400_003F_0024AA_0040));
		try
		{
			std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x11fcae0a_002EHEXSTRINGARRAY, 28)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01HIHLOKLC_00401_003F_0024AA_0040));
			try
			{
				std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x11fcae0a_002EHEXSTRINGARRAY, 56)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01FDFGLJHB_00402_003F_0024AA_0040));
				try
				{
					std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x11fcae0a_002EHEXSTRINGARRAY, 84)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01EKENIIDA_00403_003F_0024AA_0040));
					try
					{
						std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x11fcae0a_002EHEXSTRINGARRAY, 112)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01FAMBOPH_00404_003F_0024AA_0040));
						try
						{
							std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x11fcae0a_002EHEXSTRINGARRAY, 140)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01BMBHCPLG_00405_003F_0024AA_0040));
							try
							{
								std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x11fcae0a_002EHEXSTRINGARRAY, 168)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01DHDKHMHF_00406_003F_0024AA_0040));
								try
								{
									std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x11fcae0a_002EHEXSTRINGARRAY, 196)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01COCBENDE_00407_003F_0024AA_0040));
									try
									{
										std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x11fcae0a_002EHEXSTRINGARRAY, 224)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01KJLJFBPL_00408_003F_0024AA_0040));
										try
										{
											std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x11fcae0a_002EHEXSTRINGARRAY, 252)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01LAKCGALK_00409_003F_0024AA_0040));
											try
											{
												std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x11fcae0a_002EHEXSTRINGARRAY, 280)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01FHEEJDEE_0040A_003F_0024AA_0040));
												try
												{
													std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x11fcae0a_002EHEXSTRINGARRAY, 308)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01HMGJMAIH_0040B_003F_0024AA_0040));
													try
													{
														std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x11fcae0a_002EHEXSTRINGARRAY, 336)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01GFHCPBMG_0040C_003F_0024AA_0040));
														try
														{
															std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x11fcae0a_002EHEXSTRINGARRAY, 364)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01CKDDGHAB_0040D_003F_0024AA_0040));
															try
															{
																std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x11fcae0a_002EHEXSTRINGARRAY, 392)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01DDCIFGEA_0040E_003F_0024AA_0040));
																try
																{
																	std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x11fcae0a_002EHEXSTRINGARRAY, 420)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01BIAFAFID_0040F_003F_0024AA_0040));
																}
																catch
																{
																	//try-fault
																	___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x11fcae0a_002EHEXSTRINGARRAY, 392)));
																	throw;
																}
															}
															catch
															{
																//try-fault
																___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x11fcae0a_002EHEXSTRINGARRAY, 364)));
																throw;
															}
														}
														catch
														{
															//try-fault
															___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x11fcae0a_002EHEXSTRINGARRAY, 336)));
															throw;
														}
													}
													catch
													{
														//try-fault
														___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x11fcae0a_002EHEXSTRINGARRAY, 308)));
														throw;
													}
												}
												catch
												{
													//try-fault
													___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x11fcae0a_002EHEXSTRINGARRAY, 280)));
													throw;
												}
											}
											catch
											{
												//try-fault
												___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x11fcae0a_002EHEXSTRINGARRAY, 252)));
												throw;
											}
										}
										catch
										{
											//try-fault
											___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x11fcae0a_002EHEXSTRINGARRAY, 224)));
											throw;
										}
									}
									catch
									{
										//try-fault
										___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x11fcae0a_002EHEXSTRINGARRAY, 196)));
										throw;
									}
								}
								catch
								{
									//try-fault
									___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x11fcae0a_002EHEXSTRINGARRAY, 168)));
									throw;
								}
							}
							catch
							{
								//try-fault
								___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x11fcae0a_002EHEXSTRINGARRAY, 140)));
								throw;
							}
						}
						catch
						{
							//try-fault
							___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x11fcae0a_002EHEXSTRINGARRAY, 112)));
							throw;
						}
					}
					catch
					{
						//try-fault
						___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x11fcae0a_002EHEXSTRINGARRAY, 84)));
						throw;
					}
				}
				catch
				{
					//try-fault
					___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x11fcae0a_002EHEXSTRINGARRAY, 56)));
					throw;
				}
			}
			catch
			{
				//try-fault
				___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x11fcae0a_002EHEXSTRINGARRAY, 28)));
				throw;
			}
		}
		catch
		{
			//try-fault
			___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EMiscHelper_002E_003FA0x11fcae0a_002EHEXSTRINGARRAY));
			throw;
		}
		_atexit_m((delegate*<void>)(&_003FA0x11fcae0a_002E_003F_003F__F_003FA0x11fcae0a_0040HEXSTRINGARRAY_0040MiscHelper_0040HOLM_0040_0040YMXXZ));
	}

	internal unsafe static void _003FA0x11fcae0a_002E_003F_003F__F_003FA0x11fcae0a_0040HEXSTRINGARRAY_0040MiscHelper_0040HOLM_0040_0040YMXXZ()
	{
		__ehvec_dtor(System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EMiscHelper_002E_003FA0x11fcae0a_002EHEXSTRINGARRAY), 28u, 16, (delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D));
	}

	internal unsafe static void _003FA0x11fcae0a_002E_003F_003F__E_003FA0x11fcae0a_0040HOLM_WINDOW_FPGA_CTRL_0040MiscHelper_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EMiscHelper_002E_003FA0x11fcae0a_002EHOLM_WINDOW_FPGA_CTRL), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_0BD_0040CPFABDBC_0040HOLMFpgaController_003F_0024AA_0040));
		_atexit_m((delegate*<void>)(&_003FA0x11fcae0a_002E_003F_003F__F_003FA0x11fcae0a_0040HOLM_WINDOW_FPGA_CTRL_0040MiscHelper_0040HOLM_0040_0040YMXXZ));
	}

	internal unsafe static void _003FA0x11fcae0a_002E_003F_003F__F_003FA0x11fcae0a_0040HOLM_WINDOW_FPGA_CTRL_0040MiscHelper_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EMiscHelper_002E_003FA0x11fcae0a_002EHOLM_WINDOW_FPGA_CTRL));
	}

	internal unsafe static void _003FA0x11fcae0a_002E_003F_003F__E_003FA0x11fcae0a_0040HOLM_WINDOW_DSPreLab_0040MiscHelper_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EMiscHelper_002E_003FA0x11fcae0a_002EHOLM_WINDOW_DSPreLab), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_08LKNALPII_0040DSPreLab_003F_0024AA_0040));
		_atexit_m((delegate*<void>)(&_003FA0x11fcae0a_002E_003F_003F__F_003FA0x11fcae0a_0040HOLM_WINDOW_DSPreLab_0040MiscHelper_0040HOLM_0040_0040YMXXZ));
	}

	internal unsafe static void _003FA0x11fcae0a_002E_003F_003F__F_003FA0x11fcae0a_0040HOLM_WINDOW_DSPreLab_0040MiscHelper_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EMiscHelper_002E_003FA0x11fcae0a_002EHOLM_WINDOW_DSPreLab));
	}

	internal unsafe static void _003FA0x11fcae0a_002E_003F_003F__E_003FA0x11fcae0a_0040HOLM_WINDOW_DSPreLab_DEMO_0040MiscHelper_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EMiscHelper_002E_003FA0x11fcae0a_002EHOLM_WINDOW_DSPreLab_DEMO), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_0BA_0040MFILEGDE_0040DEMO_003F5_003F9_003F5DSPreLab_003F_0024AA_0040));
		_atexit_m((delegate*<void>)(&_003FA0x11fcae0a_002E_003F_003F__F_003FA0x11fcae0a_0040HOLM_WINDOW_DSPreLab_DEMO_0040MiscHelper_0040HOLM_0040_0040YMXXZ));
	}

	internal unsafe static void _003FA0x11fcae0a_002E_003F_003F__F_003FA0x11fcae0a_0040HOLM_WINDOW_DSPreLab_DEMO_0040MiscHelper_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EMiscHelper_002E_003FA0x11fcae0a_002EHOLM_WINDOW_DSPreLab_DEMO));
	}

	internal static void _003FA0x11fcae0a_002E_003F_003F__E_003FA0x11fcae0a_0040PI_0040Math_0040HOLM_0040_0040YMXXZ()
	{
		HOLM_002EMath_002E_003FA0x11fcae0a_002EPI = Math.Acos(-1.0);
	}

	internal static void _003FA0x11fcae0a_002E_003F_003F__E_003FA0x11fcae0a_0040PI_F_0040Math_0040HOLM_0040_0040YMXXZ()
	{
		HOLM_002EMath_002E_003FA0x11fcae0a_002EPI_F = (float)Math.Acos(-1.0);
	}

	internal static void _003FA0x11fcae0a_002E_003F_003F__E_003FA0x11fcae0a_0040TWOPI_0040Math_0040HOLM_0040_0040YMXXZ()
	{
		HOLM_002EMath_002E_003FA0x11fcae0a_002ETWOPI = HOLM_002EMath_002E_003FA0x11fcae0a_002EPI * 2.0;
	}

	internal static void _003FA0x11fcae0a_002E_003F_003F__E_003FA0x11fcae0a_0040HALFPI_0040Math_0040HOLM_0040_0040YMXXZ()
	{
		HOLM_002EMath_002E_003FA0x11fcae0a_002EHALFPI = HOLM_002EMath_002E_003FA0x11fcae0a_002EPI * 0.5;
	}

	internal static void _003FA0x11fcae0a_002E_003F_003F__E_003FA0x11fcae0a_0040SQRT2_0040Math_0040HOLM_0040_0040YMXXZ()
	{
		HOLM_002EMath_002E_003FA0x11fcae0a_002ESQRT2 = Math.Sqrt(2.0);
	}

	internal static void _003FA0x11fcae0a_002E_003F_003F__E_003FA0x11fcae0a_0040SQRT2_F_0040Math_0040HOLM_0040_0040YMXXZ()
	{
		HOLM_002EMath_002E_003FA0x11fcae0a_002ESQRT2_F = (float)Math.Sqrt(2.0);
	}

	internal static void _003FA0x11fcae0a_002E_003F_003F__E_003FA0x11fcae0a_0040RadToDeg_0040Math_0040HOLM_0040_0040YMXXZ()
	{
		HOLM_002EMath_002E_003FA0x11fcae0a_002ERadToDeg = 180.0 / HOLM_002EMath_002E_003FA0x11fcae0a_002EPI;
	}

	internal static void _003FA0x11fcae0a_002E_003F_003F__E_003FA0x11fcae0a_0040RadToDeg_F_0040Math_0040HOLM_0040_0040YMXXZ()
	{
		HOLM_002EMath_002E_003FA0x11fcae0a_002ERadToDeg_F = (float)(180.0 / (double)HOLM_002EMath_002E_003FA0x11fcae0a_002EPI_F);
	}

	internal static void _003FA0x11fcae0a_002E_003F_003F__E_003FA0x11fcae0a_0040DegToRad_0040Math_0040HOLM_0040_0040YMXXZ()
	{
		HOLM_002EMath_002E_003FA0x11fcae0a_002EDegToRad = HOLM_002EMath_002E_003FA0x11fcae0a_002EPI / 180.0;
	}

	internal static void _003FA0x11fcae0a_002E_003F_003F__E_003FA0x11fcae0a_0040DegToRad_F_0040Math_0040HOLM_0040_0040YMXXZ()
	{
		HOLM_002EMath_002E_003FA0x11fcae0a_002EDegToRad_F = HOLM_002EMath_002E_003FA0x11fcae0a_002EPI_F / 180f;
	}

	internal static void _003FA0x11fcae0a_002E_003F_003F__E_003FA0x11fcae0a_0040MILLISEC_TO_CM_0040Measure_0040HOLM_0040_0040YMXXZ()
	{
		HOLM_002EMeasure_002E_003FA0x11fcae0a_002EMILLISEC_TO_CM = HOLM_002EMeasure_002E_003FA0x11fcae0a_002ESEC_TO_CM / 1000.0;
	}

	internal static void _003FA0x11fcae0a_002E_003F_003F__E_003FA0x11fcae0a_0040MICROSEC_TO_CM_0040Measure_0040HOLM_0040_0040YMXXZ()
	{
		HOLM_002EMeasure_002E_003FA0x11fcae0a_002EMICROSEC_TO_CM = HOLM_002EMeasure_002E_003FA0x11fcae0a_002EMILLISEC_TO_CM / 1000.0;
	}

	internal unsafe static void _003FA0x11fcae0a_002E_003F_003F__E_003FA0x11fcae0a_0040OPTIONS_COMPAT_START_0040Constants_0040HOLMImpulse_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x11fcae0a_002EOPTIONS_COMPAT_START), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_07EBPGIHEF_00401_003F41_003F41_003F41_003F_0024AA_0040));
		_atexit_m((delegate*<void>)(&_003FA0x11fcae0a_002E_003F_003F__F_003FA0x11fcae0a_0040OPTIONS_COMPAT_START_0040Constants_0040HOLMImpulse_0040HOLM_0040_0040YMXXZ));
	}

	internal unsafe static void _003FA0x11fcae0a_002E_003F_003F__F_003FA0x11fcae0a_0040OPTIONS_COMPAT_START_0040Constants_0040HOLMImpulse_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x11fcae0a_002EOPTIONS_COMPAT_START));
	}

	internal unsafe static void _003FA0x11fcae0a_002E_003F_003F__E_003FA0x11fcae0a_0040OPTIONS_AUTOSAVE_FILENAME_0040Constants_0040HOLMImpulse_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x11fcae0a_002EOPTIONS_AUTOSAVE_FILENAME), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_0BH_0040KPHMGOCK_0040HOLMImpulseOptions_003F4xml_003F_0024AA_0040));
		_atexit_m((delegate*<void>)(&_003FA0x11fcae0a_002E_003F_003F__F_003FA0x11fcae0a_0040OPTIONS_AUTOSAVE_FILENAME_0040Constants_0040HOLMImpulse_0040HOLM_0040_0040YMXXZ));
	}

	internal unsafe static void _003FA0x11fcae0a_002E_003F_003F__F_003FA0x11fcae0a_0040OPTIONS_AUTOSAVE_FILENAME_0040Constants_0040HOLMImpulse_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x11fcae0a_002EOPTIONS_AUTOSAVE_FILENAME));
	}

	internal unsafe static void _003FA0x11fcae0a_002E_003F_003F__E_003FA0x11fcae0a_0040AUTOSAVE_MEAS_FILENAME_0040Constants_0040HOLMImpulse_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x11fcae0a_002EAUTOSAVE_MEAS_FILENAME), (char*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_1CE_0040JMJFEPPE_0040_003F_0024AAM_003F_0024AAe_003F_0024AAa_003F_0024AAs_003F_0024AAA_003F_0024AAu_003F_0024AAt_003F_0024AAo_003F_0024AAs_003F_0024AAa_003F_0024AAv_003F_0024AAe_003F_0024AAd_003F_0024AA_003F4_003F_0024AAz_003F_0024AAi_003F_0024AAp_003F_0024AA_003F_0024AA_0040));
		_atexit_m((delegate*<void>)(&_003FA0x11fcae0a_002E_003F_003F__F_003FA0x11fcae0a_0040AUTOSAVE_MEAS_FILENAME_0040Constants_0040HOLMImpulse_0040HOLM_0040_0040YMXXZ));
	}

	internal unsafe static void _003FA0x11fcae0a_002E_003F_003F__F_003FA0x11fcae0a_0040AUTOSAVE_MEAS_FILENAME_0040Constants_0040HOLMImpulse_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E_002E_007Bdtor_007D((basic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x11fcae0a_002EAUTOSAVE_MEAS_FILENAME));
	}

	internal unsafe static void _003FA0x11fcae0a_002E_003F_003F__E_003FA0x11fcae0a_0040AUTOSAVE_MEAS_OBSOLETE_0040Constants_0040HOLMImpulse_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x11fcae0a_002EAUTOSAVE_MEAS_OBSOLETE), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_0BC_0040COMDONFP_0040MeasAutosaved_003F4hlm_003F_0024AA_0040));
		_atexit_m((delegate*<void>)(&_003FA0x11fcae0a_002E_003F_003F__F_003FA0x11fcae0a_0040AUTOSAVE_MEAS_OBSOLETE_0040Constants_0040HOLMImpulse_0040HOLM_0040_0040YMXXZ));
	}

	internal unsafe static void _003FA0x11fcae0a_002E_003F_003F__F_003FA0x11fcae0a_0040AUTOSAVE_MEAS_OBSOLETE_0040Constants_0040HOLMImpulse_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x11fcae0a_002EAUTOSAVE_MEAS_OBSOLETE));
	}

	internal unsafe static void _003FA0x11fcae0a_002E_003F_003F__E_003FA0x11fcae0a_0040AUTOSAVE_MEAS_OBSOLETE_DIR_0040Constants_0040HOLMImpulse_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x11fcae0a_002EAUTOSAVE_MEAS_OBSOLETE_DIR), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_0BC_0040JLNMFMDH_0040AutosavedObsolete_003F_0024AA_0040));
		_atexit_m((delegate*<void>)(&_003FA0x11fcae0a_002E_003F_003F__F_003FA0x11fcae0a_0040AUTOSAVE_MEAS_OBSOLETE_DIR_0040Constants_0040HOLMImpulse_0040HOLM_0040_0040YMXXZ));
	}

	internal unsafe static void _003FA0x11fcae0a_002E_003F_003F__F_003FA0x11fcae0a_0040AUTOSAVE_MEAS_OBSOLETE_DIR_0040Constants_0040HOLMImpulse_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x11fcae0a_002EAUTOSAVE_MEAS_OBSOLETE_DIR));
	}

	internal unsafe static void _003FA0x11fcae0a_002E_003F_003F__E_003FA0x11fcae0a_0040CAL_MIC_FILENAME_0040Constants_0040HOLMImpulse_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x11fcae0a_002ECAL_MIC_FILENAME), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_0BD_0040LOFKOGNA_0040CalibrationMic_003F4cal_003F_0024AA_0040));
		_atexit_m((delegate*<void>)(&_003FA0x11fcae0a_002E_003F_003F__F_003FA0x11fcae0a_0040CAL_MIC_FILENAME_0040Constants_0040HOLMImpulse_0040HOLM_0040_0040YMXXZ));
	}

	internal unsafe static void _003FA0x11fcae0a_002E_003F_003F__F_003FA0x11fcae0a_0040CAL_MIC_FILENAME_0040Constants_0040HOLMImpulse_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x11fcae0a_002ECAL_MIC_FILENAME));
	}

	internal unsafe static void _003FA0x11fcae0a_002E_003F_003F__E_003FA0x11fcae0a_0040CAL_DACADC_FILENAME_0040Constants_0040HOLMImpulse_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x11fcae0a_002ECAL_DACADC_FILENAME), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_0BG_0040GMNAFMJF_0040CalibrationDacAdc_003F4cal_003F_0024AA_0040));
		_atexit_m((delegate*<void>)(&_003FA0x11fcae0a_002E_003F_003F__F_003FA0x11fcae0a_0040CAL_DACADC_FILENAME_0040Constants_0040HOLMImpulse_0040HOLM_0040_0040YMXXZ));
	}

	internal unsafe static void _003FA0x11fcae0a_002E_003F_003F__F_003FA0x11fcae0a_0040CAL_DACADC_FILENAME_0040Constants_0040HOLMImpulse_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x11fcae0a_002ECAL_DACADC_FILENAME));
	}

	internal unsafe static void _003FA0x11fcae0a_002E_003F_003F__E_003FA0x11fcae0a_0040CHANGELOG_0040Constants_0040HOLMImpulse_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x11fcae0a_002ECHANGELOG), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_0O_0040EONGOMGC_0040ChangeLog_003F4txt_003F_0024AA_0040));
		_atexit_m((delegate*<void>)(&_003FA0x11fcae0a_002E_003F_003F__F_003FA0x11fcae0a_0040CHANGELOG_0040Constants_0040HOLMImpulse_0040HOLM_0040_0040YMXXZ));
	}

	internal unsafe static void _003FA0x11fcae0a_002E_003F_003F__F_003FA0x11fcae0a_0040CHANGELOG_0040Constants_0040HOLMImpulse_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x11fcae0a_002ECHANGELOG));
	}

	internal unsafe static void _003FA0x11fcae0a_002E_003F_003F__E_003FA0x11fcae0a_0040ISSUES_0040Constants_0040HOLMImpulse_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x11fcae0a_002EISSUES), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_0L_0040NGLIAIJP_0040Issues_003F4txt_003F_0024AA_0040));
		_atexit_m((delegate*<void>)(&_003FA0x11fcae0a_002E_003F_003F__F_003FA0x11fcae0a_0040ISSUES_0040Constants_0040HOLMImpulse_0040HOLM_0040_0040YMXXZ));
	}

	internal unsafe static void _003FA0x11fcae0a_002E_003F_003F__F_003FA0x11fcae0a_0040ISSUES_0040Constants_0040HOLMImpulse_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x11fcae0a_002EISSUES));
	}

	internal unsafe static void _003FA0x11fcae0a_002E_003F_003F__E_003FA0x11fcae0a_0040LICENSE_0040Constants_0040HOLMImpulse_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x11fcae0a_002ELICENSE), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_0M_0040HGMIFPO_0040LICENSE_003F4txt_003F_0024AA_0040));
		_atexit_m((delegate*<void>)(&_003FA0x11fcae0a_002E_003F_003F__F_003FA0x11fcae0a_0040LICENSE_0040Constants_0040HOLMImpulse_0040HOLM_0040_0040YMXXZ));
	}

	internal unsafe static void _003FA0x11fcae0a_002E_003F_003F__F_003FA0x11fcae0a_0040LICENSE_0040Constants_0040HOLMImpulse_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x11fcae0a_002ELICENSE));
	}

	internal unsafe static void _003FA0x11fcae0a_002E_003F_003F__E_003FA0x11fcae0a_0040TMP_PATH_MEASLIST_0040Constants_0040HOLMImpulse_0040HOLM_0040_0040YMXXZ()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj);
		basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* ptr = HOLM_002EMiscHelper_002EGetTmpDirSimple(&obj);
		try
		{
			std_002Eoperator_002B_003Cchar_002Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_002Cclass_0020std_003A_003Aallocator_003Cchar_003E_0020_003E((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x11fcae0a_002ETMP_PATH_MEASLIST), ptr, (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_0N_0040ONBJJBCP_0040_003F2MeasTmpList_003F_0024AA_0040));
		}
		catch
		{
			//try-fault
			___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), &obj);
			throw;
		}
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D(&obj);
		_atexit_m((delegate*<void>)(&_003FA0x11fcae0a_002E_003F_003F__F_003FA0x11fcae0a_0040TMP_PATH_MEASLIST_0040Constants_0040HOLMImpulse_0040HOLM_0040_0040YMXXZ));
	}

	internal unsafe static void _003FA0x11fcae0a_002E_003F_003F__F_003FA0x11fcae0a_0040TMP_PATH_MEASLIST_0040Constants_0040HOLMImpulse_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x11fcae0a_002ETMP_PATH_MEASLIST));
	}

	internal static void _003FA0x11fcae0a_002E_003F_003F__E_003FA0x11fcae0a_0040MEASURE_LOW_REJECT_AMP_0040Constants_0040HOLMImpulse_0040HOLM_0040_0040YMXXZ()
	{
		HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x11fcae0a_002EMEASURE_LOW_REJECT_AMP = HOLM_002EMath_002EDBToAmplitude_003Cdouble_003E(-70.0);
	}

	internal static void _003FA0x11fcae0a_002E_003F_003F__E_003FA0x11fcae0a_0040MEASURE_LOW_WARN_AMP_0040Constants_0040HOLMImpulse_0040HOLM_0040_0040YMXXZ()
	{
		HOLM_002EHOLMImpulse_002EConstants_002E_003FA0x11fcae0a_002EMEASURE_LOW_WARN_AMP = HOLM_002EMath_002EDBToAmplitude_003Cdouble_003E(-40.0);
	}

	[return: MarshalAs(UnmanagedType.U1)]
	internal unsafe static bool HOLM_002EMeasure_002EResponse_002EGetFilterLowpass(Response* P_0)
	{
		uint num = *(uint*)((byte*)P_0 + 52);
		int num2 = ((num != 0 && HOLM_002EFilter_002EEffect_002EIsEnabled((Effect*)(int)(*(uint*)(int)(num + 144)))) ? 1 : 0);
		return (byte)num2 != 0;
	}

	internal static void _003FA0x11fcae0a_002E_003F_003F__E_003FA0x11fcae0a_0040RunOnceCustomNewHandlerInt_0040Mem_0040_0040YMXXZ()
	{
		Mem_002E_003FA0x11fcae0a_002ERunOnceCustomNewHandlerInt = Mem_002ECustomNewHandlerInt();
	}

	internal unsafe static void* HOLM_002EMeasure_002ECalibrator_002E__delDtor(Calibrator* P_0, uint P_1)
	{
		HOLM_002EMeasure_002ECalibrator_002E_007Bdtor_007D(P_0);
		if ((P_1 & (true ? 1u : 0u)) != 0)
		{
			delete(P_0);
		}
		return P_0;
	}

	internal unsafe static void HOLM_002EMeasure_002EResponseSaveOpenWave_002E_007Bdtor_007D(ResponseSaveOpenWave* P_0)
	{
		try
		{
			try
			{
				try
				{
					std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)((byte*)P_0 + 208));
				}
				catch
				{
					//try-fault
					___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), (byte*)P_0 + 180);
					throw;
				}
				std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)((byte*)P_0 + 180));
			}
			catch
			{
				//try-fault
				___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), (byte*)P_0 + 152);
				throw;
			}
			std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)((byte*)P_0 + 152));
		}
		catch
		{
			//try-fault
			___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Response*, void>)(&HOLM_002EMeasure_002EResponse_002E_007Bdtor_007D), P_0);
			throw;
		}
		HOLM_002EMeasure_002EResponse_002E_007Bdtor_007D((Response*)P_0);
	}

	internal unsafe static void std_002Evector_003CHOLM_003A_003AMeasure_003A_003ACalibrator_0020_002A_002Cstd_003A_003Aallocator_003CHOLM_003A_003AMeasure_003A_003ACalibrator_0020_002A_003E_0020_003E_002Epush_back(vector_003CHOLM_003A_003AMeasure_003A_003ACalibrator_0020_002A_002Cstd_003A_003Aallocator_003CHOLM_003A_003AMeasure_003A_003ACalibrator_0020_002A_003E_0020_003E* P_0, Calibrator** _Val)
	{
		uint num = *(uint*)((byte*)P_0 + 12);
		int num2 = ((num != 0) ? (*(int*)((byte*)P_0 + 20) - (int)num >> 2) : 0);
		int num3 = *(int*)((byte*)P_0 + 16);
		if ((uint)(num3 - (int)num >> 2) < (uint)num2)
		{
			Calibrator** ptr = (Calibrator**)num3;
			*(int*)ptr = *(int*)_Val;
			*(int*)((byte*)P_0 + 16) = (int)((byte*)ptr + 4);
			return;
		}
		Calibrator** ptr2 = (Calibrator**)num3;
		if ((nuint)(int)num > (nuint)ptr2)
		{
			_invalid_parameter_noinfo();
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _Vector_iterator_003CHOLM_003A_003AMeasure_003A_003ACalibrator_0020_002A_002Cstd_003A_003Aallocator_003CHOLM_003A_003AMeasure_003A_003ACalibrator_0020_002A_003E_0020_003E obj);
		*(int*)(&obj) = *(int*)P_0;
		System.Runtime.CompilerServices.Unsafe.As<_Vector_iterator_003CHOLM_003A_003AMeasure_003A_003ACalibrator_0020_002A_002Cstd_003A_003Aallocator_003CHOLM_003A_003AMeasure_003A_003ACalibrator_0020_002A_003E_0020_003E, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 4)) = (int)ptr2;
		_Vector_const_iterator_003CHOLM_003A_003AMeasure_003A_003ACalibrator_0020_002A_002Cstd_003A_003Aallocator_003CHOLM_003A_003AMeasure_003A_003ACalibrator_0020_002A_003E_0020_003E where = (_Vector_const_iterator_003CHOLM_003A_003AMeasure_003A_003ACalibrator_0020_002A_002Cstd_003A_003Aallocator_003CHOLM_003A_003AMeasure_003A_003ACalibrator_0020_002A_003E_0020_003E)obj;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _Vector_iterator_003CHOLM_003A_003AMeasure_003A_003ACalibrator_0020_002A_002Cstd_003A_003Aallocator_003CHOLM_003A_003AMeasure_003A_003ACalibrator_0020_002A_003E_0020_003E obj2);
		std_002Evector_003CHOLM_003A_003AMeasure_003A_003ACalibrator_0020_002A_002Cstd_003A_003Aallocator_003CHOLM_003A_003AMeasure_003A_003ACalibrator_0020_002A_003E_0020_003E_002Einsert(P_0, &obj2, where, _Val);
	}

	internal unsafe static void std_002Evector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E_002E_007Bdtor_007D(vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E* P_0)
	{
		try
		{
			vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E* ptr = (vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E*)((byte*)P_0 + 12);
			uint num = *(uint*)ptr;
			if (num != 0)
			{
				delete((void*)(int)num);
			}
			*(int*)ptr = 0;
			*(int*)((byte*)P_0 + 16) = 0;
			*(int*)((byte*)P_0 + 20) = 0;
		}
		catch
		{
			//try-fault
			___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<_Vector_val_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E*, void>)(&std_002E_Vector_val_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E_002E_007Bdtor_007D), P_0);
			throw;
		}
		delete((void*)(int)(*(uint*)P_0));
	}

	internal unsafe static void std_002E_Vector_val_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E_002E_007Bdtor_007D(_Vector_val_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E* P_0)
	{
		delete((void*)(int)(*(uint*)P_0));
	}

	internal unsafe static _Vector_iterator_003CHOLM_003A_003AMeasure_003A_003ACalibrator_0020_002A_002Cstd_003A_003Aallocator_003CHOLM_003A_003AMeasure_003A_003ACalibrator_0020_002A_003E_0020_003E* std_002Evector_003CHOLM_003A_003AMeasure_003A_003ACalibrator_0020_002A_002Cstd_003A_003Aallocator_003CHOLM_003A_003AMeasure_003A_003ACalibrator_0020_002A_003E_0020_003E_002Einsert(vector_003CHOLM_003A_003AMeasure_003A_003ACalibrator_0020_002A_002Cstd_003A_003Aallocator_003CHOLM_003A_003AMeasure_003A_003ACalibrator_0020_002A_003E_0020_003E* P_0, _Vector_iterator_003CHOLM_003A_003AMeasure_003A_003ACalibrator_0020_002A_002Cstd_003A_003Aallocator_003CHOLM_003A_003AMeasure_003A_003ACalibrator_0020_002A_003E_0020_003E* P_1, _Vector_const_iterator_003CHOLM_003A_003AMeasure_003A_003ACalibrator_0020_002A_002Cstd_003A_003Aallocator_003CHOLM_003A_003AMeasure_003A_003ACalibrator_0020_002A_003E_0020_003E _Where, Calibrator** _Val)
	{
		int num = *(int*)((byte*)P_0 + 16);
		int num2 = *(int*)((byte*)P_0 + 12);
		int off;
		if (((num - num2) & -4) == 0)
		{
			off = 0;
		}
		else
		{
			Calibrator** ptr = (Calibrator**)num2;
			if ((nuint)ptr > (nuint)num)
			{
				_invalid_parameter_noinfo();
			}
			System.Runtime.CompilerServices.Unsafe.SkipInit(out _Vector_iterator_003CHOLM_003A_003AMeasure_003A_003ACalibrator_0020_002A_002Cstd_003A_003Aallocator_003CHOLM_003A_003AMeasure_003A_003ACalibrator_0020_002A_003E_0020_003E obj);
			*(int*)(&obj) = *(int*)P_0;
			if ((byte)((*(int*)(&_Where) != 0) ? 1 : 0) == 0 || !(*(int*)(&_Where) == *(int*)(&obj)))
			{
				_invalid_parameter_noinfo();
			}
			off = (int)((nint)System.Runtime.CompilerServices.Unsafe.As<_Vector_const_iterator_003CHOLM_003A_003AMeasure_003A_003ACalibrator_0020_002A_002Cstd_003A_003Aallocator_003CHOLM_003A_003AMeasure_003A_003ACalibrator_0020_002A_003E_0020_003E, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref _Where, 4)) - (nint)ptr >> 2);
		}
		std_002Evector_003CHOLM_003A_003AMeasure_003A_003ACalibrator_0020_002A_002Cstd_003A_003Aallocator_003CHOLM_003A_003AMeasure_003A_003ACalibrator_0020_002A_003E_0020_003E_002E_Insert_n(P_0, _Where, 1u, _Val);
		Calibrator** ptr2 = (Calibrator**)(int)(*(uint*)((byte*)P_0 + 12));
		if ((nuint)ptr2 > (nuint)(*(int*)((byte*)P_0 + 16)))
		{
			_invalid_parameter_noinfo();
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _Vector_iterator_003CHOLM_003A_003AMeasure_003A_003ACalibrator_0020_002A_002Cstd_003A_003Aallocator_003CHOLM_003A_003AMeasure_003A_003ACalibrator_0020_002A_003E_0020_003E obj2);
		*(int*)(&obj2) = *(int*)P_0;
		System.Runtime.CompilerServices.Unsafe.As<_Vector_iterator_003CHOLM_003A_003AMeasure_003A_003ACalibrator_0020_002A_002Cstd_003A_003Aallocator_003CHOLM_003A_003AMeasure_003A_003ACalibrator_0020_002A_003E_0020_003E, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj2, 4)) = (int)ptr2;
		_Vector_iterator_003CHOLM_003A_003AMeasure_003A_003ACalibrator_0020_002A_002Cstd_003A_003Aallocator_003CHOLM_003A_003AMeasure_003A_003ACalibrator_0020_002A_003E_0020_003E obj3 = obj2;
		std_002E_Vector_const_iterator_003CHOLM_003A_003AMeasure_003A_003ACalibrator_0020_002A_002Cstd_003A_003Aallocator_003CHOLM_003A_003AMeasure_003A_003ACalibrator_0020_002A_003E_0020_003E_002E_002B_003D((_Vector_const_iterator_003CHOLM_003A_003AMeasure_003A_003ACalibrator_0020_002A_002Cstd_003A_003Aallocator_003CHOLM_003A_003AMeasure_003A_003ACalibrator_0020_002A_003E_0020_003E*)(&obj3), off);
		// IL cpblk instruction
		System.Runtime.CompilerServices.Unsafe.CopyBlock(P_1, ref obj3, 8);
		return P_1;
	}

	internal unsafe static Calibrator** std_002Evector_003CHOLM_003A_003AMeasure_003A_003ACalibrator_0020_002A_002Cstd_003A_003Aallocator_003CHOLM_003A_003AMeasure_003A_003ACalibrator_0020_002A_003E_0020_003E_002E_Ufill(vector_003CHOLM_003A_003AMeasure_003A_003ACalibrator_0020_002A_002Cstd_003A_003Aallocator_003CHOLM_003A_003AMeasure_003A_003ACalibrator_0020_002A_003E_0020_003E* P_0, Calibrator** _Ptr, uint _Count, Calibrator** _Val)
	{
		uint num = _Count;
		Calibrator** ptr = _Ptr;
		if (0 < _Count)
		{
			do
			{
				*(int*)ptr = *(int*)_Val;
				num--;
				ptr = (Calibrator**)((byte*)ptr + 4);
			}
			while (num != 0);
		}
		return (Calibrator**)((int)(_Count * 4) + (byte*)_Ptr);
	}

	internal unsafe static void std_002Eallocator_003Cint_003E_002Edeallocate(allocator_003Cint_003E* P_0, int* _Ptr, uint __unnamed001)
	{
		delete(_Ptr);
	}

	internal unsafe static void std_002Evector_003CHOLM_003A_003AMeasure_003A_003ACalibrator_0020_002A_002Cstd_003A_003Aallocator_003CHOLM_003A_003AMeasure_003A_003ACalibrator_0020_002A_003E_0020_003E_002E_Insert_n(vector_003CHOLM_003A_003AMeasure_003A_003ACalibrator_0020_002A_002Cstd_003A_003Aallocator_003CHOLM_003A_003AMeasure_003A_003ACalibrator_0020_002A_003E_0020_003E* P_0, _Vector_const_iterator_003CHOLM_003A_003AMeasure_003A_003ACalibrator_0020_002A_002Cstd_003A_003Aallocator_003CHOLM_003A_003AMeasure_003A_003ACalibrator_0020_002A_003E_0020_003E _Where, uint _Count, Calibrator** _Val)
	{
		int num = (int)stackalloc byte[__CxxQueryExceptionSize()];
		uint num2 = *(uint*)((byte*)P_0 + 12);
		int num3 = ((num2 != 0) ? (*(int*)((byte*)P_0 + 20) - (int)num2 >> 2) : 0);
		if (_Count == 0)
		{
			return;
		}
		int num4 = *(int*)((byte*)P_0 + 16);
		int num5 = num4 - (int)num2 >> 2;
		if ((uint)(1073741823 - num5) < _Count)
		{
			std_002Evector_003CHOLM_003A_003AMeasure_003A_003ACalibrator_0020_002A_002Cstd_003A_003Aallocator_003CHOLM_003A_003AMeasure_003A_003ACalibrator_0020_002A_003E_0020_003E_002E_Xlen();
		}
		if ((uint)num3 < (uint)((int)_Count + num5))
		{
			uint num6 = (uint)num3 >> 1;
			uint num7 = ((1073741823 - num6 >= (uint)num3) ? (num6 + (uint)num3) : 0u);
			uint num8 = num7;
			if (num7 < (uint)((int)_Count + num5))
			{
				num8 = _Count + (uint)num5;
			}
			Calibrator** ptr = std_002Eallocator_003CHOLM_003A_003AMeasure_003A_003ACalibrator_0020_002A_003E_002Eallocate((allocator_003CHOLM_003A_003AMeasure_003A_003ACalibrator_0020_002A_003E*)((byte*)P_0 + 8), num8);
			uint num9 = (uint)(System.Runtime.CompilerServices.Unsafe.As<_Vector_const_iterator_003CHOLM_003A_003AMeasure_003A_003ACalibrator_0020_002A_002Cstd_003A_003Aallocator_003CHOLM_003A_003AMeasure_003A_003ACalibrator_0020_002A_003E_0020_003E, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref _Where, 4)) - *(int*)((byte*)P_0 + 12) >> 2);
			int num10 = 0;
			try
			{
				std_002Evector_003CHOLM_003A_003AMeasure_003A_003ACalibrator_0020_002A_002Cstd_003A_003Aallocator_003CHOLM_003A_003AMeasure_003A_003ACalibrator_0020_002A_003E_0020_003E_002E_Ufill(P_0, (Calibrator**)((int)(num9 * 4) + (byte*)ptr), _Count, _Val);
				num10 = 1;
				std_002Evector_003CHOLM_003A_003AMeasure_003A_003ACalibrator_0020_002A_002Cstd_003A_003Aallocator_003CHOLM_003A_003AMeasure_003A_003ACalibrator_0020_002A_003E_0020_003E_002E_Umove_003Cclass_0020HOLM_003A_003AMeasure_003A_003ACalibrator_0020_002A_0020_002A_003E(P_0, (Calibrator**)(int)(*(uint*)((byte*)P_0 + 12)), (Calibrator**)(int)System.Runtime.CompilerServices.Unsafe.As<_Vector_const_iterator_003CHOLM_003A_003AMeasure_003A_003ACalibrator_0020_002A_002Cstd_003A_003Aallocator_003CHOLM_003A_003AMeasure_003A_003ACalibrator_0020_002A_003E_0020_003E, uint>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref _Where, 4)), ptr);
				num10 = 2;
				std_002Evector_003CHOLM_003A_003AMeasure_003A_003ACalibrator_0020_002A_002Cstd_003A_003Aallocator_003CHOLM_003A_003AMeasure_003A_003ACalibrator_0020_002A_003E_0020_003E_002E_Umove_003Cclass_0020HOLM_003A_003AMeasure_003A_003ACalibrator_0020_002A_0020_002A_003E(P_0, (Calibrator**)(int)System.Runtime.CompilerServices.Unsafe.As<_Vector_const_iterator_003CHOLM_003A_003AMeasure_003A_003ACalibrator_0020_002A_002Cstd_003A_003Aallocator_003CHOLM_003A_003AMeasure_003A_003ACalibrator_0020_002A_003E_0020_003E, uint>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref _Where, 4)), (Calibrator**)(int)(*(uint*)((byte*)P_0 + 16)), (Calibrator**)((int)((num9 + _Count) * 4) + (byte*)ptr));
			}
			catch when (((Func<bool>)delegate
			{
				// Could not convert BlockContainer to single expression
				uint exceptionCode = (uint)Marshal.GetExceptionCode();
				return (byte)__CxxExceptionFilter((void*)Marshal.GetExceptionPointers(), null, 0, null) != 0;
			}).Invoke())
			{
				uint num11 = 0u;
				__CxxRegisterExceptionObject((void*)Marshal.GetExceptionPointers(), (void*)num);
				try
				{
					try
					{
						if (1 < num10)
						{
						}
						if (0 < num10)
						{
						}
						std_002Eallocator_003CHOLM_003A_003AMeasure_003A_003ACalibrator_0020_002A_003E_002Edeallocate((allocator_003CHOLM_003A_003AMeasure_003A_003ACalibrator_0020_002A_003E*)((byte*)P_0 + 8), ptr, num8);
						_CxxThrowException(null, null);
					}
					catch when (((Func<bool>)delegate
					{
						// Could not convert BlockContainer to single expression
						num11 = (uint)__CxxDetectRethrow((void*)Marshal.GetExceptionPointers());
						return (byte)num11 != 0;
					}).Invoke())
					{
					}
					if (num11 != 0)
					{
						throw;
					}
				}
				finally
				{
					__CxxUnregisterExceptionObject((void*)num, (int)num11);
				}
			}
			num2 = *(uint*)((byte*)P_0 + 12);
			_Count = (uint)(*(int*)((byte*)P_0 + 16) - (int)num2 >> 2) + _Count;
			if (num2 != 0)
			{
				delete((void*)(int)num2);
			}
			*(int*)((byte*)P_0 + 20) = (int)((int)(num8 * 4) + (byte*)ptr);
			*(int*)((byte*)P_0 + 16) = (int)((int)(_Count * 4) + (byte*)ptr);
			*(int*)((byte*)P_0 + 12) = (int)ptr;
			return;
		}
		if ((uint)(num4 - System.Runtime.CompilerServices.Unsafe.As<_Vector_const_iterator_003CHOLM_003A_003AMeasure_003A_003ACalibrator_0020_002A_002Cstd_003A_003Aallocator_003CHOLM_003A_003AMeasure_003A_003ACalibrator_0020_002A_003E_0020_003E, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref _Where, 4)) >> 2) < _Count)
		{
			Calibrator* ptr2 = (Calibrator*)(int)(*(uint*)_Val);
			std_002Evector_003CHOLM_003A_003AMeasure_003A_003ACalibrator_0020_002A_002Cstd_003A_003Aallocator_003CHOLM_003A_003AMeasure_003A_003ACalibrator_0020_002A_003E_0020_003E_002E_Umove_003Cclass_0020HOLM_003A_003AMeasure_003A_003ACalibrator_0020_002A_0020_002A_003E(P_0, (Calibrator**)(int)System.Runtime.CompilerServices.Unsafe.As<_Vector_const_iterator_003CHOLM_003A_003AMeasure_003A_003ACalibrator_0020_002A_002Cstd_003A_003Aallocator_003CHOLM_003A_003AMeasure_003A_003ACalibrator_0020_002A_003E_0020_003E, uint>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref _Where, 4)), (Calibrator**)num4, (Calibrator**)(int)(_Count * 4 + (uint)System.Runtime.CompilerServices.Unsafe.As<_Vector_const_iterator_003CHOLM_003A_003AMeasure_003A_003ACalibrator_0020_002A_002Cstd_003A_003Aallocator_003CHOLM_003A_003AMeasure_003A_003ACalibrator_0020_002A_003E_0020_003E, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref _Where, 4))));
			try
			{
				num4 = *(int*)((byte*)P_0 + 16);
				std_002Evector_003CHOLM_003A_003AMeasure_003A_003ACalibrator_0020_002A_002Cstd_003A_003Aallocator_003CHOLM_003A_003AMeasure_003A_003ACalibrator_0020_002A_003E_0020_003E_002E_Ufill(P_0, (Calibrator**)num4, _Count - (uint)(num4 - System.Runtime.CompilerServices.Unsafe.As<_Vector_const_iterator_003CHOLM_003A_003AMeasure_003A_003ACalibrator_0020_002A_002Cstd_003A_003Aallocator_003CHOLM_003A_003AMeasure_003A_003ACalibrator_0020_002A_003E_0020_003E, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref _Where, 4)) >> 2), &ptr2);
			}
			catch when (((Func<bool>)delegate
			{
				// Could not convert BlockContainer to single expression
				uint exceptionCode = (uint)Marshal.GetExceptionCode();
				return (byte)__CxxExceptionFilter((void*)Marshal.GetExceptionPointers(), null, 0, null) != 0;
			}).Invoke())
			{
				uint num11 = 0u;
				__CxxRegisterExceptionObject((void*)Marshal.GetExceptionPointers(), (void*)num);
				try
				{
					try
					{
						_CxxThrowException(null, null);
					}
					catch when (((Func<bool>)delegate
					{
						// Could not convert BlockContainer to single expression
						num11 = (uint)__CxxDetectRethrow((void*)Marshal.GetExceptionPointers());
						return (byte)num11 != 0;
					}).Invoke())
					{
					}
					if (num11 != 0)
					{
						throw;
					}
				}
				finally
				{
					__CxxUnregisterExceptionObject((void*)num, (int)num11);
				}
			}
			int num12 = (int)(_Count * 4);
			*(int*)((byte*)P_0 + 16) += num12;
			Calibrator** ptr3 = (Calibrator**)(*(int*)((byte*)P_0 + 16) - num12);
			Calibrator** ptr4 = (Calibrator**)(int)System.Runtime.CompilerServices.Unsafe.As<_Vector_const_iterator_003CHOLM_003A_003AMeasure_003A_003ACalibrator_0020_002A_002Cstd_003A_003Aallocator_003CHOLM_003A_003AMeasure_003A_003ACalibrator_0020_002A_003E_0020_003E, uint>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref _Where, 4));
			if ((Calibrator**)System.Runtime.CompilerServices.Unsafe.As<_Vector_const_iterator_003CHOLM_003A_003AMeasure_003A_003ACalibrator_0020_002A_002Cstd_003A_003Aallocator_003CHOLM_003A_003AMeasure_003A_003ACalibrator_0020_002A_003E_0020_003E, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref _Where, 4)) != ptr3)
			{
				do
				{
					*(int*)ptr4 = (int)ptr2;
					ptr4 = (Calibrator**)((byte*)ptr4 + 4);
				}
				while (ptr4 != ptr3);
			}
			return;
		}
		Calibrator* ptr5 = (Calibrator*)(int)(*(uint*)_Val);
		Calibrator** ptr6 = (Calibrator**)num4;
		int num13 = (int)(_Count * 4);
		Calibrator** ptr7 = (Calibrator**)((byte*)ptr6 - num13);
		*(int*)((byte*)P_0 + 16) = (int)std_002Evector_003CHOLM_003A_003AMeasure_003A_003ACalibrator_0020_002A_002Cstd_003A_003Aallocator_003CHOLM_003A_003AMeasure_003A_003ACalibrator_0020_002A_003E_0020_003E_002E_Umove_003Cclass_0020HOLM_003A_003AMeasure_003A_003ACalibrator_0020_002A_0020_002A_003E(P_0, ptr7, ptr6, (Calibrator**)num4);
		stdext_002E_Unchecked_move_backward_003Cclass_0020HOLM_003A_003AMeasure_003A_003ACalibrator_0020_002A_0020_002A_002Cclass_0020HOLM_003A_003AMeasure_003A_003ACalibrator_0020_002A_0020_002A_003E((Calibrator**)(int)System.Runtime.CompilerServices.Unsafe.As<_Vector_const_iterator_003CHOLM_003A_003AMeasure_003A_003ACalibrator_0020_002A_002Cstd_003A_003Aallocator_003CHOLM_003A_003AMeasure_003A_003ACalibrator_0020_002A_003E_0020_003E, uint>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref _Where, 4)), ptr7, ptr6);
		Calibrator** ptr8 = (Calibrator**)(num13 + System.Runtime.CompilerServices.Unsafe.As<_Vector_const_iterator_003CHOLM_003A_003AMeasure_003A_003ACalibrator_0020_002A_002Cstd_003A_003Aallocator_003CHOLM_003A_003AMeasure_003A_003ACalibrator_0020_002A_003E_0020_003E, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref _Where, 4)));
		Calibrator** ptr9 = (Calibrator**)(int)System.Runtime.CompilerServices.Unsafe.As<_Vector_const_iterator_003CHOLM_003A_003AMeasure_003A_003ACalibrator_0020_002A_002Cstd_003A_003Aallocator_003CHOLM_003A_003AMeasure_003A_003ACalibrator_0020_002A_003E_0020_003E, uint>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref _Where, 4));
		if ((Calibrator**)System.Runtime.CompilerServices.Unsafe.As<_Vector_const_iterator_003CHOLM_003A_003AMeasure_003A_003ACalibrator_0020_002A_002Cstd_003A_003Aallocator_003CHOLM_003A_003AMeasure_003A_003ACalibrator_0020_002A_003E_0020_003E, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref _Where, 4)) != ptr8)
		{
			do
			{
				*(int*)ptr9 = (int)ptr5;
				ptr9 = (Calibrator**)((byte*)ptr9 + 4);
			}
			while (ptr9 != ptr8);
		}
	}

	internal unsafe static void std_002Evector_003CHOLM_003A_003AMeasure_003A_003ACalibrator_0020_002A_002Cstd_003A_003Aallocator_003CHOLM_003A_003AMeasure_003A_003ACalibrator_0020_002A_003E_0020_003E_002E_Xlen()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj);
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D(&obj, (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_0BD_0040OLBABOEK_0040vector_003F_0024DMT_003F_0024DO_003F5too_003F5long_003F_0024AA_0040));
		try
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out length_error length_error);
			std_002Eexception_002E_007Bctor_007D((exception*)(&length_error));
			try
			{
				*(int*)(&length_error) = (int)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_7logic_error_0040std_0040_00406B_0040);
				std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref length_error, 12)), &obj);
			}
			catch
			{
				//try-fault
				___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<exception*, void>)(&std_002Eexception_002E_007Bdtor_007D), &length_error);
				throw;
			}
			try
			{
				*(int*)(&length_error) = (int)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_7length_error_0040std_0040_00406B_0040);
			}
			catch
			{
				//try-fault
				___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<logic_error*, void>)(&std_002Elogic_error_002E_007Bdtor_007D), &length_error);
				throw;
			}
			_CxxThrowException(&length_error, (_s__ThrowInfo*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _TI3_003FAVlength_error_0040std_0040_0040));
			return;
		}
		catch
		{
			//try-fault
			___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), &obj);
			throw;
		}
	}

	internal unsafe static void std_002Eallocator_003CHOLM_003A_003AMeasure_003A_003ACalibrator_0020_002A_003E_002Edeallocate(allocator_003CHOLM_003A_003AMeasure_003A_003ACalibrator_0020_002A_003E* P_0, Calibrator** _Ptr, uint __unnamed001)
	{
		delete(_Ptr);
	}

	internal unsafe static Calibrator** std_002Eallocator_003CHOLM_003A_003AMeasure_003A_003ACalibrator_0020_002A_003E_002Eallocate(allocator_003CHOLM_003A_003AMeasure_003A_003ACalibrator_0020_002A_003E* P_0, uint _Count)
	{
		uint num = _Count;
		if (_Count == 0)
		{
			num = 0u;
		}
		else if (uint.MaxValue / _Count < 4)
		{
			sbyte* ptr = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out bad_alloc bad_alloc);
			std_002Eexception_002E_007Bctor_007D((exception*)(&bad_alloc), &ptr);
			try
			{
				*(int*)(&bad_alloc) = (int)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_7bad_alloc_0040std_0040_00406B_0040);
			}
			catch
			{
				//try-fault
				___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<exception*, void>)(&std_002Eexception_002E_007Bdtor_007D), &bad_alloc);
				throw;
			}
			_CxxThrowException(&bad_alloc, (_s__ThrowInfo*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _TI2_003FAVbad_alloc_0040std_0040_0040));
		}
		return (Calibrator**)@new(num << 2);
	}

	internal unsafe static _Vector_const_iterator_003CHOLM_003A_003AMeasure_003A_003ACalibrator_0020_002A_002Cstd_003A_003Aallocator_003CHOLM_003A_003AMeasure_003A_003ACalibrator_0020_002A_003E_0020_003E* std_002E_Vector_const_iterator_003CHOLM_003A_003AMeasure_003A_003ACalibrator_0020_002A_002Cstd_003A_003Aallocator_003CHOLM_003A_003AMeasure_003A_003ACalibrator_0020_002A_003E_0020_003E_002E_002B_003D(_Vector_const_iterator_003CHOLM_003A_003AMeasure_003A_003ACalibrator_0020_002A_002Cstd_003A_003Aallocator_003CHOLM_003A_003AMeasure_003A_003ACalibrator_0020_002A_003E_0020_003E* P_0, int _Off)
	{
		if ((byte)((*(int*)P_0 != 0) ? 1 : 0) == 0)
		{
			_invalid_parameter_noinfo();
		}
		uint num = *(uint*)P_0;
		_Container_base_aux* ptr = (_Container_base_aux*)((num == 0) ? 0 : ((int)(*(uint*)(int)num)));
		uint num2 = (uint)(_Off * 4);
		uint num3 = (uint)(*(int*)((byte*)P_0 + 4)) + num2;
		if (num3 <= (uint)(*(int*)((byte*)ptr + 16)))
		{
			_Container_base_aux* ptr2 = (_Container_base_aux*)((num == 0) ? 0 : ((int)(*(uint*)(int)num)));
			if (num3 >= (uint)(*(int*)((byte*)ptr2 + 12)))
			{
				goto IL_004b;
			}
		}
		_invalid_parameter_noinfo();
		goto IL_004b;
		IL_004b:
		*(int*)((byte*)P_0 + 4) += (int)num2;
		return P_0;
	}

	internal unsafe static Calibrator** std_002Evector_003CHOLM_003A_003AMeasure_003A_003ACalibrator_0020_002A_002Cstd_003A_003Aallocator_003CHOLM_003A_003AMeasure_003A_003ACalibrator_0020_002A_003E_0020_003E_002E_Umove_003Cclass_0020HOLM_003A_003AMeasure_003A_003ACalibrator_0020_002A_0020_002A_003E(vector_003CHOLM_003A_003AMeasure_003A_003ACalibrator_0020_002A_002Cstd_003A_003Aallocator_003CHOLM_003A_003AMeasure_003A_003ACalibrator_0020_002A_003E_0020_003E* P_0, Calibrator** _First, Calibrator** _Last, Calibrator** _Ptr)
	{
		uint num = (uint)((nint)((byte*)_Last - (nuint)_First) >> 2);
		int num2 = (int)(num * 4);
		byte* result = num2 + (byte*)_Ptr;
		if (num != 0)
		{
			memmove_s(_Ptr, (uint)num2, _First, (uint)num2);
		}
		return (Calibrator**)result;
	}

	internal unsafe static Calibrator** stdext_002E_Unchecked_move_backward_003Cclass_0020HOLM_003A_003AMeasure_003A_003ACalibrator_0020_002A_0020_002A_002Cclass_0020HOLM_003A_003AMeasure_003A_003ACalibrator_0020_002A_0020_002A_003E(Calibrator** _First, Calibrator** _Last, Calibrator** _Dest)
	{
		int num = (int)((nint)((byte*)_Last - (nuint)_First) >> 2);
		int num2 = num * 4;
		Calibrator** ptr = (Calibrator**)((byte*)_Dest - num2);
		if (num > 0)
		{
			memmove_s(ptr, (uint)num2, _First, (uint)num2);
		}
		return ptr;
	}

	internal unsafe static void delete(void* P_0, void* P_1)
	{
	}

	internal unsafe static void _003FA0xac910afd_002E_003F_003F__E_003FA0xac910afd_0040HEXSTRINGARRAY_0040MiscHelper_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EMiscHelper_002E_003FA0xac910afd_002EHEXSTRINGARRAY), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01GBGANLPD_00400_003F_0024AA_0040));
		try
		{
			std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0xac910afd_002EHEXSTRINGARRAY, 28)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01HIHLOKLC_00401_003F_0024AA_0040));
			try
			{
				std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0xac910afd_002EHEXSTRINGARRAY, 56)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01FDFGLJHB_00402_003F_0024AA_0040));
				try
				{
					std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0xac910afd_002EHEXSTRINGARRAY, 84)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01EKENIIDA_00403_003F_0024AA_0040));
					try
					{
						std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0xac910afd_002EHEXSTRINGARRAY, 112)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01FAMBOPH_00404_003F_0024AA_0040));
						try
						{
							std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0xac910afd_002EHEXSTRINGARRAY, 140)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01BMBHCPLG_00405_003F_0024AA_0040));
							try
							{
								std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0xac910afd_002EHEXSTRINGARRAY, 168)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01DHDKHMHF_00406_003F_0024AA_0040));
								try
								{
									std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0xac910afd_002EHEXSTRINGARRAY, 196)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01COCBENDE_00407_003F_0024AA_0040));
									try
									{
										std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0xac910afd_002EHEXSTRINGARRAY, 224)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01KJLJFBPL_00408_003F_0024AA_0040));
										try
										{
											std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0xac910afd_002EHEXSTRINGARRAY, 252)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01LAKCGALK_00409_003F_0024AA_0040));
											try
											{
												std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0xac910afd_002EHEXSTRINGARRAY, 280)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01FHEEJDEE_0040A_003F_0024AA_0040));
												try
												{
													std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0xac910afd_002EHEXSTRINGARRAY, 308)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01HMGJMAIH_0040B_003F_0024AA_0040));
													try
													{
														std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0xac910afd_002EHEXSTRINGARRAY, 336)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01GFHCPBMG_0040C_003F_0024AA_0040));
														try
														{
															std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0xac910afd_002EHEXSTRINGARRAY, 364)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01CKDDGHAB_0040D_003F_0024AA_0040));
															try
															{
																std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0xac910afd_002EHEXSTRINGARRAY, 392)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01DDCIFGEA_0040E_003F_0024AA_0040));
																try
																{
																	std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0xac910afd_002EHEXSTRINGARRAY, 420)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01BIAFAFID_0040F_003F_0024AA_0040));
																}
																catch
																{
																	//try-fault
																	___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0xac910afd_002EHEXSTRINGARRAY, 392)));
																	throw;
																}
															}
															catch
															{
																//try-fault
																___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0xac910afd_002EHEXSTRINGARRAY, 364)));
																throw;
															}
														}
														catch
														{
															//try-fault
															___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0xac910afd_002EHEXSTRINGARRAY, 336)));
															throw;
														}
													}
													catch
													{
														//try-fault
														___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0xac910afd_002EHEXSTRINGARRAY, 308)));
														throw;
													}
												}
												catch
												{
													//try-fault
													___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0xac910afd_002EHEXSTRINGARRAY, 280)));
													throw;
												}
											}
											catch
											{
												//try-fault
												___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0xac910afd_002EHEXSTRINGARRAY, 252)));
												throw;
											}
										}
										catch
										{
											//try-fault
											___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0xac910afd_002EHEXSTRINGARRAY, 224)));
											throw;
										}
									}
									catch
									{
										//try-fault
										___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0xac910afd_002EHEXSTRINGARRAY, 196)));
										throw;
									}
								}
								catch
								{
									//try-fault
									___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0xac910afd_002EHEXSTRINGARRAY, 168)));
									throw;
								}
							}
							catch
							{
								//try-fault
								___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0xac910afd_002EHEXSTRINGARRAY, 140)));
								throw;
							}
						}
						catch
						{
							//try-fault
							___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0xac910afd_002EHEXSTRINGARRAY, 112)));
							throw;
						}
					}
					catch
					{
						//try-fault
						___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0xac910afd_002EHEXSTRINGARRAY, 84)));
						throw;
					}
				}
				catch
				{
					//try-fault
					___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0xac910afd_002EHEXSTRINGARRAY, 56)));
					throw;
				}
			}
			catch
			{
				//try-fault
				___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0xac910afd_002EHEXSTRINGARRAY, 28)));
				throw;
			}
		}
		catch
		{
			//try-fault
			___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EMiscHelper_002E_003FA0xac910afd_002EHEXSTRINGARRAY));
			throw;
		}
		_atexit_m((delegate*<void>)(&_003FA0xac910afd_002E_003F_003F__F_003FA0xac910afd_0040HEXSTRINGARRAY_0040MiscHelper_0040HOLM_0040_0040YMXXZ));
	}

	internal unsafe static void _003FA0xac910afd_002E_003F_003F__F_003FA0xac910afd_0040HEXSTRINGARRAY_0040MiscHelper_0040HOLM_0040_0040YMXXZ()
	{
		__ehvec_dtor(System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EMiscHelper_002E_003FA0xac910afd_002EHEXSTRINGARRAY), 28u, 16, (delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D));
	}

	internal unsafe static void _003FA0xac910afd_002E_003F_003F__E_003FA0xac910afd_0040HOLM_WINDOW_FPGA_CTRL_0040MiscHelper_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EMiscHelper_002E_003FA0xac910afd_002EHOLM_WINDOW_FPGA_CTRL), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_0BD_0040CPFABDBC_0040HOLMFpgaController_003F_0024AA_0040));
		_atexit_m((delegate*<void>)(&_003FA0xac910afd_002E_003F_003F__F_003FA0xac910afd_0040HOLM_WINDOW_FPGA_CTRL_0040MiscHelper_0040HOLM_0040_0040YMXXZ));
	}

	internal unsafe static void _003FA0xac910afd_002E_003F_003F__F_003FA0xac910afd_0040HOLM_WINDOW_FPGA_CTRL_0040MiscHelper_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EMiscHelper_002E_003FA0xac910afd_002EHOLM_WINDOW_FPGA_CTRL));
	}

	internal unsafe static void _003FA0xac910afd_002E_003F_003F__E_003FA0xac910afd_0040HOLM_WINDOW_DSPreLab_0040MiscHelper_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EMiscHelper_002E_003FA0xac910afd_002EHOLM_WINDOW_DSPreLab), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_08LKNALPII_0040DSPreLab_003F_0024AA_0040));
		_atexit_m((delegate*<void>)(&_003FA0xac910afd_002E_003F_003F__F_003FA0xac910afd_0040HOLM_WINDOW_DSPreLab_0040MiscHelper_0040HOLM_0040_0040YMXXZ));
	}

	internal unsafe static void _003FA0xac910afd_002E_003F_003F__F_003FA0xac910afd_0040HOLM_WINDOW_DSPreLab_0040MiscHelper_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EMiscHelper_002E_003FA0xac910afd_002EHOLM_WINDOW_DSPreLab));
	}

	internal unsafe static void _003FA0xac910afd_002E_003F_003F__E_003FA0xac910afd_0040HOLM_WINDOW_DSPreLab_DEMO_0040MiscHelper_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EMiscHelper_002E_003FA0xac910afd_002EHOLM_WINDOW_DSPreLab_DEMO), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_0BA_0040MFILEGDE_0040DEMO_003F5_003F9_003F5DSPreLab_003F_0024AA_0040));
		_atexit_m((delegate*<void>)(&_003FA0xac910afd_002E_003F_003F__F_003FA0xac910afd_0040HOLM_WINDOW_DSPreLab_DEMO_0040MiscHelper_0040HOLM_0040_0040YMXXZ));
	}

	internal unsafe static void _003FA0xac910afd_002E_003F_003F__F_003FA0xac910afd_0040HOLM_WINDOW_DSPreLab_DEMO_0040MiscHelper_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EMiscHelper_002E_003FA0xac910afd_002EHOLM_WINDOW_DSPreLab_DEMO));
	}

	internal static void _003FA0xac910afd_002E_003F_003F__E_003FA0xac910afd_0040PI_0040Math_0040HOLM_0040_0040YMXXZ()
	{
		HOLM_002EMath_002E_003FA0xac910afd_002EPI = Math.Acos(-1.0);
	}

	internal static void _003FA0xac910afd_002E_003F_003F__E_003FA0xac910afd_0040PI_F_0040Math_0040HOLM_0040_0040YMXXZ()
	{
		HOLM_002EMath_002E_003FA0xac910afd_002EPI_F = (float)Math.Acos(-1.0);
	}

	internal static void _003FA0xac910afd_002E_003F_003F__E_003FA0xac910afd_0040TWOPI_0040Math_0040HOLM_0040_0040YMXXZ()
	{
		HOLM_002EMath_002E_003FA0xac910afd_002ETWOPI = HOLM_002EMath_002E_003FA0xac910afd_002EPI * 2.0;
	}

	internal static void _003FA0xac910afd_002E_003F_003F__E_003FA0xac910afd_0040HALFPI_0040Math_0040HOLM_0040_0040YMXXZ()
	{
		HOLM_002EMath_002E_003FA0xac910afd_002EHALFPI = HOLM_002EMath_002E_003FA0xac910afd_002EPI * 0.5;
	}

	internal static void _003FA0xac910afd_002E_003F_003F__E_003FA0xac910afd_0040SQRT2_0040Math_0040HOLM_0040_0040YMXXZ()
	{
		HOLM_002EMath_002E_003FA0xac910afd_002ESQRT2 = Math.Sqrt(2.0);
	}

	internal static void _003FA0xac910afd_002E_003F_003F__E_003FA0xac910afd_0040SQRT2_F_0040Math_0040HOLM_0040_0040YMXXZ()
	{
		HOLM_002EMath_002E_003FA0xac910afd_002ESQRT2_F = (float)Math.Sqrt(2.0);
	}

	internal static void _003FA0xac910afd_002E_003F_003F__E_003FA0xac910afd_0040RadToDeg_0040Math_0040HOLM_0040_0040YMXXZ()
	{
		HOLM_002EMath_002E_003FA0xac910afd_002ERadToDeg = 180.0 / HOLM_002EMath_002E_003FA0xac910afd_002EPI;
	}

	internal static void _003FA0xac910afd_002E_003F_003F__E_003FA0xac910afd_0040RadToDeg_F_0040Math_0040HOLM_0040_0040YMXXZ()
	{
		HOLM_002EMath_002E_003FA0xac910afd_002ERadToDeg_F = (float)(180.0 / (double)HOLM_002EMath_002E_003FA0xac910afd_002EPI_F);
	}

	internal static void _003FA0xac910afd_002E_003F_003F__E_003FA0xac910afd_0040DegToRad_0040Math_0040HOLM_0040_0040YMXXZ()
	{
		HOLM_002EMath_002E_003FA0xac910afd_002EDegToRad = HOLM_002EMath_002E_003FA0xac910afd_002EPI / 180.0;
	}

	internal static void _003FA0xac910afd_002E_003F_003F__E_003FA0xac910afd_0040DegToRad_F_0040Math_0040HOLM_0040_0040YMXXZ()
	{
		HOLM_002EMath_002E_003FA0xac910afd_002EDegToRad_F = HOLM_002EMath_002E_003FA0xac910afd_002EPI_F / 180f;
	}

	internal static string HOLM_002EGraphics_002Eto_nice_String(double @in)
	{
		double num = HOLM_002EMath_002ENegPow10((int)(Math.Floor(Math.Log10(Math.Abs(@in))) - 2.0));
		return (Math.Floor(@in / num + 0.5) * num).ToString("G");
	}

	internal unsafe static void HOLM_002EGraphics_002ERanges_002E_007Bdtor_007D(Ranges* P_0)
	{
		vector_003CHOLM_003A_003AGraphics_003A_003ARange_002Cstd_003A_003Aallocator_003CHOLM_003A_003AGraphics_003A_003ARange_003E_0020_003E* ptr = (vector_003CHOLM_003A_003AGraphics_003A_003ARange_002Cstd_003A_003Aallocator_003CHOLM_003A_003AGraphics_003A_003ARange_003E_0020_003E*)((byte*)P_0 + 64);
		try
		{
			vector_003CHOLM_003A_003AGraphics_003A_003ARange_002Cstd_003A_003Aallocator_003CHOLM_003A_003AGraphics_003A_003ARange_003E_0020_003E* ptr2 = (vector_003CHOLM_003A_003AGraphics_003A_003ARange_002Cstd_003A_003Aallocator_003CHOLM_003A_003AGraphics_003A_003ARange_003E_0020_003E*)((byte*)ptr + 12);
			uint num = *(uint*)ptr2;
			if (num != 0)
			{
				delete((void*)(int)num);
			}
			*(int*)ptr2 = 0;
			*(int*)((byte*)ptr + 16) = 0;
			*(int*)((byte*)ptr + 20) = 0;
		}
		catch
		{
			//try-fault
			___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<_Vector_val_003CHOLM_003A_003AGraphics_003A_003ARange_002Cstd_003A_003Aallocator_003CHOLM_003A_003AGraphics_003A_003ARange_003E_0020_003E*, void>)(&std_002E_Vector_val_003CHOLM_003A_003AGraphics_003A_003ARange_002Cstd_003A_003Aallocator_003CHOLM_003A_003AGraphics_003A_003ARange_003E_0020_003E_002E_007Bdtor_007D), ptr);
			throw;
		}
		delete((void*)(int)(*(uint*)ptr));
	}

	[return: MarshalAs(UnmanagedType.U1)]
	internal unsafe static bool HOLM_002EGraphics_002ERanges_002EZoomOut(Ranges* P_0)
	{
		Ranges* ptr = (Ranges*)((byte*)P_0 + 64);
		vector_003CHOLM_003A_003AGraphics_003A_003ARange_002Cstd_003A_003Aallocator_003CHOLM_003A_003AGraphics_003A_003ARange_003E_0020_003E* ptr2 = (vector_003CHOLM_003A_003AGraphics_003A_003ARange_002Cstd_003A_003Aallocator_003CHOLM_003A_003AGraphics_003A_003ARange_003E_0020_003E*)ptr;
		if (!(((*(int*)((byte*)ptr2 + 16) - *(int*)((byte*)ptr2 + 12)) & -32) == 0))
		{
			vector_003CHOLM_003A_003AGraphics_003A_003ARange_002Cstd_003A_003Aallocator_003CHOLM_003A_003AGraphics_003A_003ARange_003E_0020_003E* ptr3 = (vector_003CHOLM_003A_003AGraphics_003A_003ARange_002Cstd_003A_003Aallocator_003CHOLM_003A_003AGraphics_003A_003ARange_003E_0020_003E*)ptr;
			uint num = (uint)((*(int*)((byte*)ptr3 + 16) - *(int*)((byte*)ptr3 + 12) >> 5) - 1);
			vector_003CHOLM_003A_003AGraphics_003A_003ARange_002Cstd_003A_003Aallocator_003CHOLM_003A_003AGraphics_003A_003ARange_003E_0020_003E* ptr4 = (vector_003CHOLM_003A_003AGraphics_003A_003ARange_002Cstd_003A_003Aallocator_003CHOLM_003A_003AGraphics_003A_003ARange_003E_0020_003E*)ptr;
			if (num >= (uint)(*(int*)((byte*)ptr4 + 16) - *(int*)((byte*)ptr4 + 12) >> 5))
			{
				_invalid_parameter_noinfo();
			}
			// IL cpblk instruction
			System.Runtime.CompilerServices.Unsafe.CopyBlock(P_0, (int)(num * 32) + *(int*)((byte*)ptr4 + 12), 32);
			vector_003CHOLM_003A_003AGraphics_003A_003ARange_002Cstd_003A_003Aallocator_003CHOLM_003A_003AGraphics_003A_003ARange_003E_0020_003E* ptr5 = (vector_003CHOLM_003A_003AGraphics_003A_003ARange_002Cstd_003A_003Aallocator_003CHOLM_003A_003AGraphics_003A_003ARange_003E_0020_003E*)ptr;
			int num2 = *(int*)((byte*)ptr5 + 16);
			if (!(((num2 - *(int*)((byte*)ptr5 + 12)) & -32) == 0))
			{
				*(int*)((byte*)ptr5 + 16) = num2 - 32;
			}
			return true;
		}
		return false;
	}

	internal unsafe static void HOLM_002EGraphics_002ERanges_002EZoomOutToNewRange(Ranges* P_0, double x1, double x2)
	{
		Ranges* ptr = (Ranges*)((byte*)P_0 + 64);
		vector_003CHOLM_003A_003AGraphics_003A_003ARange_002Cstd_003A_003Aallocator_003CHOLM_003A_003AGraphics_003A_003ARange_003E_0020_003E* ptr2 = (vector_003CHOLM_003A_003AGraphics_003A_003ARange_002Cstd_003A_003Aallocator_003CHOLM_003A_003AGraphics_003A_003ARange_003E_0020_003E*)ptr;
		double num;
		double num2;
		if (*(int*)((byte*)ptr2 + 16) - *(int*)((byte*)ptr2 + 12) >> 5 != 0)
		{
			vector_003CHOLM_003A_003AGraphics_003A_003ARange_002Cstd_003A_003Aallocator_003CHOLM_003A_003AGraphics_003A_003ARange_003E_0020_003E* ptr3 = (vector_003CHOLM_003A_003AGraphics_003A_003ARange_002Cstd_003A_003Aallocator_003CHOLM_003A_003AGraphics_003A_003ARange_003E_0020_003E*)ptr;
			if (0u >= (uint)(*(int*)((byte*)ptr3 + 16) - *(int*)((byte*)ptr3 + 12) >> 5))
			{
				_invalid_parameter_noinfo();
			}
			num = *(double*)(*(int*)((byte*)ptr3 + 12) + 16);
			vector_003CHOLM_003A_003AGraphics_003A_003ARange_002Cstd_003A_003Aallocator_003CHOLM_003A_003AGraphics_003A_003ARange_003E_0020_003E* ptr4 = (vector_003CHOLM_003A_003AGraphics_003A_003ARange_002Cstd_003A_003Aallocator_003CHOLM_003A_003AGraphics_003A_003ARange_003E_0020_003E*)ptr;
			if (0u >= (uint)(*(int*)((byte*)ptr4 + 16) - *(int*)((byte*)ptr4 + 12) >> 5))
			{
				_invalid_parameter_noinfo();
			}
			num2 = *(double*)(*(int*)((byte*)ptr4 + 12) + 24);
		}
		else
		{
			num = *(double*)((byte*)P_0 + 16);
			num2 = *(double*)((byte*)P_0 + 24);
		}
		std_002Evector_003CHOLM_003A_003AGraphics_003A_003ARange_002Cstd_003A_003Aallocator_003CHOLM_003A_003AGraphics_003A_003ARange_003E_0020_003E_002Eclear((vector_003CHOLM_003A_003AGraphics_003A_003ARange_002Cstd_003A_003Aallocator_003CHOLM_003A_003AGraphics_003A_003ARange_003E_0020_003E*)ptr);
		*(double*)P_0 = x1;
		*(double*)((byte*)P_0 + 8) = x2;
		*(double*)((byte*)P_0 + 16) = num;
		*(double*)((byte*)P_0 + 24) = num2;
		// IL cpblk instruction
		System.Runtime.CompilerServices.Unsafe.CopyBlock((byte*)P_0 + 32, P_0, 32);
	}

	internal unsafe static void HOLM_002EGraphics_002ERanges_002EZoomAllOut(Ranges* P_0)
	{
		Ranges* ptr = (Ranges*)((byte*)P_0 + 64);
		vector_003CHOLM_003A_003AGraphics_003A_003ARange_002Cstd_003A_003Aallocator_003CHOLM_003A_003AGraphics_003A_003ARange_003E_0020_003E* ptr2 = (vector_003CHOLM_003A_003AGraphics_003A_003ARange_002Cstd_003A_003Aallocator_003CHOLM_003A_003AGraphics_003A_003ARange_003E_0020_003E*)ptr;
		if (!(((*(int*)((byte*)ptr2 + 16) - *(int*)((byte*)ptr2 + 12)) & -32) == 0))
		{
			vector_003CHOLM_003A_003AGraphics_003A_003ARange_002Cstd_003A_003Aallocator_003CHOLM_003A_003AGraphics_003A_003ARange_003E_0020_003E* ptr3 = (vector_003CHOLM_003A_003AGraphics_003A_003ARange_002Cstd_003A_003Aallocator_003CHOLM_003A_003AGraphics_003A_003ARange_003E_0020_003E*)ptr;
			if (0u >= (uint)(*(int*)((byte*)ptr3 + 16) - *(int*)((byte*)ptr3 + 12) >> 5))
			{
				_invalid_parameter_noinfo();
			}
			System.Runtime.CompilerServices.Unsafe.SkipInit(out HOLM.Graphics.Range range);
			// IL cpblk instruction
			System.Runtime.CompilerServices.Unsafe.CopyBlock(ref range, *(int*)((byte*)ptr3 + 12), 32);
			std_002Evector_003CHOLM_003A_003AGraphics_003A_003ARange_002Cstd_003A_003Aallocator_003CHOLM_003A_003AGraphics_003A_003ARange_003E_0020_003E_002Eclear((vector_003CHOLM_003A_003AGraphics_003A_003ARange_002Cstd_003A_003Aallocator_003CHOLM_003A_003AGraphics_003A_003ARange_003E_0020_003E*)ptr);
			*(double*)P_0 = *(double*)(&range);
			*(double*)((byte*)P_0 + 8) = System.Runtime.CompilerServices.Unsafe.As<HOLM.Graphics.Range, double>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref range, 8));
			*(double*)((byte*)P_0 + 16) = System.Runtime.CompilerServices.Unsafe.As<HOLM.Graphics.Range, double>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref range, 16));
			*(double*)((byte*)P_0 + 24) = System.Runtime.CompilerServices.Unsafe.As<HOLM.Graphics.Range, double>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref range, 24));
		}
		else
		{
			// IL cpblk instruction
			System.Runtime.CompilerServices.Unsafe.CopyBlock(P_0, (byte*)P_0 + 32, 32);
		}
	}

	internal static ImageCodecInfo HOLM_002EGraphics_002E_003FA0xac910afd_002EGetImageEncoder(string imageType)
	{
		imageType = imageType.ToUpperInvariant();
		ImageCodecInfo[] imageEncoders = ImageCodecInfo.GetImageEncoders();
		int num = 0;
		if (0 < (nint)imageEncoders.LongLength)
		{
			do
			{
				ImageCodecInfo val = imageEncoders[num];
				if (!(val.FormatDescription == imageType))
				{
					num++;
					continue;
				}
				return val;
			}
			while (num < (nint)imageEncoders.LongLength);
		}
		return null;
	}

	internal static void HOLM_002EGraphics_002ESaveBitmap(Bitmap bitmap, string fname)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		EncoderParameters val = new EncoderParameters(1);
		val.Param[0] = new EncoderParameter(Encoder.Quality, 100L);
		if (fname.EndsWith("jpg", StringComparison.CurrentCultureIgnoreCase))
		{
			ImageCodecInfo val2 = HOLM_002EGraphics_002E_003FA0xac910afd_002EGetImageEncoder("JPEG");
			((Image)bitmap).Save(fname, val2, val);
		}
		else if (fname.EndsWith("png", StringComparison.CurrentCultureIgnoreCase))
		{
			ImageCodecInfo val3 = HOLM_002EGraphics_002E_003FA0xac910afd_002EGetImageEncoder("PNG");
			((Image)bitmap).Save(fname, val3, val);
		}
		else
		{
			((Image)bitmap).Save(fname, ImageFormat.Bmp);
		}
		((IDisposable)val.Param[0])?.Dispose();
		((IDisposable)val)?.Dispose();
	}

	internal unsafe static vector_003CHOLM_003A_003AGraphics_003A_003ARange_002Cstd_003A_003Aallocator_003CHOLM_003A_003AGraphics_003A_003ARange_003E_0020_003E* std_002Evector_003CHOLM_003A_003AGraphics_003A_003ARange_002Cstd_003A_003Aallocator_003CHOLM_003A_003AGraphics_003A_003ARange_003E_0020_003E_002E_007Bctor_007D(vector_003CHOLM_003A_003AGraphics_003A_003ARange_002Cstd_003A_003Aallocator_003CHOLM_003A_003AGraphics_003A_003ARange_003E_0020_003E* P_0)
	{
		void* ptr = @new(4u);
		_Aux_cont* ptr2 = (_Aux_cont*)ptr;
		_Aux_cont* ptr3;
		try
		{
			if (ptr != null)
			{
				*(int*)ptr = (int)P_0;
				ptr3 = (_Aux_cont*)ptr;
			}
			else
			{
				ptr3 = null;
			}
		}
		catch
		{
			//try-fault
			delete(ptr2, ptr);
			throw;
		}
		*(int*)P_0 = (int)ptr3;
		try
		{
			*(int*)((byte*)P_0 + 12) = 0;
			*(int*)((byte*)P_0 + 16) = 0;
			*(int*)((byte*)P_0 + 20) = 0;
			return P_0;
		}
		catch
		{
			//try-fault
			___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<_Vector_val_003CHOLM_003A_003AGraphics_003A_003ARange_002Cstd_003A_003Aallocator_003CHOLM_003A_003AGraphics_003A_003ARange_003E_0020_003E*, void>)(&std_002E_Vector_val_003CHOLM_003A_003AGraphics_003A_003ARange_002Cstd_003A_003Aallocator_003CHOLM_003A_003AGraphics_003A_003ARange_003E_0020_003E_002E_007Bdtor_007D), P_0);
			throw;
		}
	}

	internal unsafe static void std_002Evector_003CHOLM_003A_003AGraphics_003A_003ARange_002Cstd_003A_003Aallocator_003CHOLM_003A_003AGraphics_003A_003ARange_003E_0020_003E_002E_007Bdtor_007D(vector_003CHOLM_003A_003AGraphics_003A_003ARange_002Cstd_003A_003Aallocator_003CHOLM_003A_003AGraphics_003A_003ARange_003E_0020_003E* P_0)
	{
		try
		{
			vector_003CHOLM_003A_003AGraphics_003A_003ARange_002Cstd_003A_003Aallocator_003CHOLM_003A_003AGraphics_003A_003ARange_003E_0020_003E* ptr = (vector_003CHOLM_003A_003AGraphics_003A_003ARange_002Cstd_003A_003Aallocator_003CHOLM_003A_003AGraphics_003A_003ARange_003E_0020_003E*)((byte*)P_0 + 12);
			uint num = *(uint*)ptr;
			if (num != 0)
			{
				delete((void*)(int)num);
			}
			*(int*)ptr = 0;
			*(int*)((byte*)P_0 + 16) = 0;
			*(int*)((byte*)P_0 + 20) = 0;
		}
		catch
		{
			//try-fault
			___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<_Vector_val_003CHOLM_003A_003AGraphics_003A_003ARange_002Cstd_003A_003Aallocator_003CHOLM_003A_003AGraphics_003A_003ARange_003E_0020_003E*, void>)(&std_002E_Vector_val_003CHOLM_003A_003AGraphics_003A_003ARange_002Cstd_003A_003Aallocator_003CHOLM_003A_003AGraphics_003A_003ARange_003E_0020_003E_002E_007Bdtor_007D), P_0);
			throw;
		}
		delete((void*)(int)(*(uint*)P_0));
	}

	internal unsafe static void std_002Evector_003CHOLM_003A_003AGraphics_003A_003ARange_002Cstd_003A_003Aallocator_003CHOLM_003A_003AGraphics_003A_003ARange_003E_0020_003E_002Epush_back(vector_003CHOLM_003A_003AGraphics_003A_003ARange_002Cstd_003A_003Aallocator_003CHOLM_003A_003AGraphics_003A_003ARange_003E_0020_003E* P_0, HOLM.Graphics.Range* _Val)
	{
		uint num = *(uint*)((byte*)P_0 + 12);
		int num2 = ((num != 0) ? (*(int*)((byte*)P_0 + 20) - (int)num >> 5) : 0);
		int num3 = *(int*)((byte*)P_0 + 16);
		if ((uint)(num3 - (int)num >> 5) < (uint)num2)
		{
			HOLM.Graphics.Range* ptr = (HOLM.Graphics.Range*)num3;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out _Range_checked_iterator_tag _unnamed);
			// IL initblk instruction
			System.Runtime.CompilerServices.Unsafe.InitBlock(ref _unnamed, 0, 1);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out _Nonscalar_ptr_iterator_tag nonscalar_ptr_iterator_tag);
			_Nonscalar_ptr_iterator_tag _unnamed2 = nonscalar_ptr_iterator_tag;
			std_002E_Uninit_fill_n_003Cstruct_0020HOLM_003A_003AGraphics_003A_003ARange_0020_002A_002Cunsigned_0020int_002Cstruct_0020HOLM_003A_003AGraphics_003A_003ARange_002Cclass_0020std_003A_003Aallocator_003Cstruct_0020HOLM_003A_003AGraphics_003A_003ARange_003E_0020_003E(ptr, 1u, _Val, (allocator_003CHOLM_003A_003AGraphics_003A_003ARange_003E*)((byte*)P_0 + 8), _unnamed2, _unnamed);
			*(int*)((byte*)P_0 + 16) = (int)((byte*)ptr + 32);
			return;
		}
		HOLM.Graphics.Range* ptr2 = (HOLM.Graphics.Range*)num3;
		if ((nuint)(int)num > (nuint)ptr2)
		{
			_invalid_parameter_noinfo();
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _Vector_iterator_003CHOLM_003A_003AGraphics_003A_003ARange_002Cstd_003A_003Aallocator_003CHOLM_003A_003AGraphics_003A_003ARange_003E_0020_003E obj);
		*(int*)(&obj) = *(int*)P_0;
		System.Runtime.CompilerServices.Unsafe.As<_Vector_iterator_003CHOLM_003A_003AGraphics_003A_003ARange_002Cstd_003A_003Aallocator_003CHOLM_003A_003AGraphics_003A_003ARange_003E_0020_003E, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 4)) = (int)ptr2;
		_Vector_const_iterator_003CHOLM_003A_003AGraphics_003A_003ARange_002Cstd_003A_003Aallocator_003CHOLM_003A_003AGraphics_003A_003ARange_003E_0020_003E where = (_Vector_const_iterator_003CHOLM_003A_003AGraphics_003A_003ARange_002Cstd_003A_003Aallocator_003CHOLM_003A_003AGraphics_003A_003ARange_003E_0020_003E)obj;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _Vector_iterator_003CHOLM_003A_003AGraphics_003A_003ARange_002Cstd_003A_003Aallocator_003CHOLM_003A_003AGraphics_003A_003ARange_003E_0020_003E obj2);
		std_002Evector_003CHOLM_003A_003AGraphics_003A_003ARange_002Cstd_003A_003Aallocator_003CHOLM_003A_003AGraphics_003A_003ARange_003E_0020_003E_002Einsert(P_0, &obj2, where, _Val);
	}

	internal unsafe static void std_002Evector_003CHOLM_003A_003AGraphics_003A_003ARange_002Cstd_003A_003Aallocator_003CHOLM_003A_003AGraphics_003A_003ARange_003E_0020_003E_002Eclear(vector_003CHOLM_003A_003AGraphics_003A_003ARange_002Cstd_003A_003Aallocator_003CHOLM_003A_003AGraphics_003A_003ARange_003E_0020_003E* P_0)
	{
		HOLM.Graphics.Range* ptr = (HOLM.Graphics.Range*)(int)(*(uint*)((byte*)P_0 + 16));
		if ((nuint)(*(int*)((byte*)P_0 + 12)) > (nuint)ptr)
		{
			_invalid_parameter_noinfo();
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _Vector_iterator_003CHOLM_003A_003AGraphics_003A_003ARange_002Cstd_003A_003Aallocator_003CHOLM_003A_003AGraphics_003A_003ARange_003E_0020_003E obj);
		*(int*)(&obj) = *(int*)P_0;
		System.Runtime.CompilerServices.Unsafe.As<_Vector_iterator_003CHOLM_003A_003AGraphics_003A_003ARange_002Cstd_003A_003Aallocator_003CHOLM_003A_003AGraphics_003A_003ARange_003E_0020_003E, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 4)) = (int)ptr;
		_Vector_const_iterator_003CHOLM_003A_003AGraphics_003A_003ARange_002Cstd_003A_003Aallocator_003CHOLM_003A_003AGraphics_003A_003ARange_003E_0020_003E last_arg = (_Vector_const_iterator_003CHOLM_003A_003AGraphics_003A_003ARange_002Cstd_003A_003Aallocator_003CHOLM_003A_003AGraphics_003A_003ARange_003E_0020_003E)obj;
		HOLM.Graphics.Range* ptr2 = (HOLM.Graphics.Range*)(int)(*(uint*)((byte*)P_0 + 12));
		if ((nuint)ptr2 > (nuint)(*(int*)((byte*)P_0 + 16)))
		{
			_invalid_parameter_noinfo();
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _Vector_iterator_003CHOLM_003A_003AGraphics_003A_003ARange_002Cstd_003A_003Aallocator_003CHOLM_003A_003AGraphics_003A_003ARange_003E_0020_003E obj2);
		*(int*)(&obj2) = *(int*)P_0;
		System.Runtime.CompilerServices.Unsafe.As<_Vector_iterator_003CHOLM_003A_003AGraphics_003A_003ARange_002Cstd_003A_003Aallocator_003CHOLM_003A_003AGraphics_003A_003ARange_003E_0020_003E, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj2, 4)) = (int)ptr2;
		_Vector_const_iterator_003CHOLM_003A_003AGraphics_003A_003ARange_002Cstd_003A_003Aallocator_003CHOLM_003A_003AGraphics_003A_003ARange_003E_0020_003E first_arg = (_Vector_const_iterator_003CHOLM_003A_003AGraphics_003A_003ARange_002Cstd_003A_003Aallocator_003CHOLM_003A_003AGraphics_003A_003ARange_003E_0020_003E)obj2;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _Vector_iterator_003CHOLM_003A_003AGraphics_003A_003ARange_002Cstd_003A_003Aallocator_003CHOLM_003A_003AGraphics_003A_003ARange_003E_0020_003E obj3);
		std_002Evector_003CHOLM_003A_003AGraphics_003A_003ARange_002Cstd_003A_003Aallocator_003CHOLM_003A_003AGraphics_003A_003ARange_003E_0020_003E_002Eerase(P_0, &obj3, first_arg, last_arg);
	}

	internal unsafe static void std_002E_Vector_val_003CHOLM_003A_003AGraphics_003A_003ARange_002Cstd_003A_003Aallocator_003CHOLM_003A_003AGraphics_003A_003ARange_003E_0020_003E_002E_007Bdtor_007D(_Vector_val_003CHOLM_003A_003AGraphics_003A_003ARange_002Cstd_003A_003Aallocator_003CHOLM_003A_003AGraphics_003A_003ARange_003E_0020_003E* P_0)
	{
		delete((void*)(int)(*(uint*)P_0));
	}

	internal unsafe static _Vector_iterator_003CHOLM_003A_003AGraphics_003A_003ARange_002Cstd_003A_003Aallocator_003CHOLM_003A_003AGraphics_003A_003ARange_003E_0020_003E* std_002Evector_003CHOLM_003A_003AGraphics_003A_003ARange_002Cstd_003A_003Aallocator_003CHOLM_003A_003AGraphics_003A_003ARange_003E_0020_003E_002Einsert(vector_003CHOLM_003A_003AGraphics_003A_003ARange_002Cstd_003A_003Aallocator_003CHOLM_003A_003AGraphics_003A_003ARange_003E_0020_003E* P_0, _Vector_iterator_003CHOLM_003A_003AGraphics_003A_003ARange_002Cstd_003A_003Aallocator_003CHOLM_003A_003AGraphics_003A_003ARange_003E_0020_003E* P_1, _Vector_const_iterator_003CHOLM_003A_003AGraphics_003A_003ARange_002Cstd_003A_003Aallocator_003CHOLM_003A_003AGraphics_003A_003ARange_003E_0020_003E _Where, HOLM.Graphics.Range* _Val)
	{
		int num = *(int*)((byte*)P_0 + 16);
		int num2 = *(int*)((byte*)P_0 + 12);
		int off;
		if (((num - num2) & -32) == 0)
		{
			off = 0;
		}
		else
		{
			HOLM.Graphics.Range* ptr = (HOLM.Graphics.Range*)num2;
			if ((nuint)ptr > (nuint)num)
			{
				_invalid_parameter_noinfo();
			}
			System.Runtime.CompilerServices.Unsafe.SkipInit(out _Vector_iterator_003CHOLM_003A_003AGraphics_003A_003ARange_002Cstd_003A_003Aallocator_003CHOLM_003A_003AGraphics_003A_003ARange_003E_0020_003E obj);
			*(int*)(&obj) = *(int*)P_0;
			if ((byte)((*(int*)(&_Where) != 0) ? 1 : 0) == 0 || !(*(int*)(&_Where) == *(int*)(&obj)))
			{
				_invalid_parameter_noinfo();
			}
			off = (int)((nint)System.Runtime.CompilerServices.Unsafe.As<_Vector_const_iterator_003CHOLM_003A_003AGraphics_003A_003ARange_002Cstd_003A_003Aallocator_003CHOLM_003A_003AGraphics_003A_003ARange_003E_0020_003E, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref _Where, 4)) - (nint)ptr >> 5);
		}
		std_002Evector_003CHOLM_003A_003AGraphics_003A_003ARange_002Cstd_003A_003Aallocator_003CHOLM_003A_003AGraphics_003A_003ARange_003E_0020_003E_002E_Insert_n(P_0, _Where, 1u, _Val);
		HOLM.Graphics.Range* ptr2 = (HOLM.Graphics.Range*)(int)(*(uint*)((byte*)P_0 + 12));
		if ((nuint)ptr2 > (nuint)(*(int*)((byte*)P_0 + 16)))
		{
			_invalid_parameter_noinfo();
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _Vector_iterator_003CHOLM_003A_003AGraphics_003A_003ARange_002Cstd_003A_003Aallocator_003CHOLM_003A_003AGraphics_003A_003ARange_003E_0020_003E obj2);
		*(int*)(&obj2) = *(int*)P_0;
		System.Runtime.CompilerServices.Unsafe.As<_Vector_iterator_003CHOLM_003A_003AGraphics_003A_003ARange_002Cstd_003A_003Aallocator_003CHOLM_003A_003AGraphics_003A_003ARange_003E_0020_003E, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj2, 4)) = (int)ptr2;
		_Vector_iterator_003CHOLM_003A_003AGraphics_003A_003ARange_002Cstd_003A_003Aallocator_003CHOLM_003A_003AGraphics_003A_003ARange_003E_0020_003E obj3 = obj2;
		std_002E_Vector_const_iterator_003CHOLM_003A_003AGraphics_003A_003ARange_002Cstd_003A_003Aallocator_003CHOLM_003A_003AGraphics_003A_003ARange_003E_0020_003E_002E_002B_003D((_Vector_const_iterator_003CHOLM_003A_003AGraphics_003A_003ARange_002Cstd_003A_003Aallocator_003CHOLM_003A_003AGraphics_003A_003ARange_003E_0020_003E*)(&obj3), off);
		// IL cpblk instruction
		System.Runtime.CompilerServices.Unsafe.CopyBlock(P_1, ref obj3, 8);
		return P_1;
	}

	internal unsafe static _Vector_iterator_003CHOLM_003A_003AGraphics_003A_003ARange_002Cstd_003A_003Aallocator_003CHOLM_003A_003AGraphics_003A_003ARange_003E_0020_003E* std_002Evector_003CHOLM_003A_003AGraphics_003A_003ARange_002Cstd_003A_003Aallocator_003CHOLM_003A_003AGraphics_003A_003ARange_003E_0020_003E_002Eerase(vector_003CHOLM_003A_003AGraphics_003A_003ARange_002Cstd_003A_003Aallocator_003CHOLM_003A_003AGraphics_003A_003ARange_003E_0020_003E* P_0, _Vector_iterator_003CHOLM_003A_003AGraphics_003A_003ARange_002Cstd_003A_003Aallocator_003CHOLM_003A_003AGraphics_003A_003ARange_003E_0020_003E* P_1, _Vector_const_iterator_003CHOLM_003A_003AGraphics_003A_003ARange_002Cstd_003A_003Aallocator_003CHOLM_003A_003AGraphics_003A_003ARange_003E_0020_003E _First_arg, _Vector_const_iterator_003CHOLM_003A_003AGraphics_003A_003ARange_002Cstd_003A_003Aallocator_003CHOLM_003A_003AGraphics_003A_003ARange_003E_0020_003E _Last_arg)
	{
		_Vector_const_iterator_003CHOLM_003A_003AGraphics_003A_003ARange_002Cstd_003A_003Aallocator_003CHOLM_003A_003AGraphics_003A_003ARange_003E_0020_003E obj = _First_arg;
		*(int*)P_1 = 0;
		if (P_0 == null || (uint)(*(int*)((byte*)P_0 + 12)) > (uint)System.Runtime.CompilerServices.Unsafe.As<_Vector_const_iterator_003CHOLM_003A_003AGraphics_003A_003ARange_002Cstd_003A_003Aallocator_003CHOLM_003A_003AGraphics_003A_003ARange_003E_0020_003E, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref _First_arg, 4)) || (uint)System.Runtime.CompilerServices.Unsafe.As<_Vector_const_iterator_003CHOLM_003A_003AGraphics_003A_003ARange_002Cstd_003A_003Aallocator_003CHOLM_003A_003AGraphics_003A_003ARange_003E_0020_003E, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref _First_arg, 4)) > (uint)(*(int*)((byte*)P_0 + 16)))
		{
			_invalid_parameter_noinfo();
		}
		*(int*)P_1 = *(int*)P_0;
		*(int*)((byte*)P_1 + 4) = System.Runtime.CompilerServices.Unsafe.As<_Vector_const_iterator_003CHOLM_003A_003AGraphics_003A_003ARange_002Cstd_003A_003Aallocator_003CHOLM_003A_003AGraphics_003A_003ARange_003E_0020_003E, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 4));
		_Vector_const_iterator_003CHOLM_003A_003AGraphics_003A_003ARange_002Cstd_003A_003Aallocator_003CHOLM_003A_003AGraphics_003A_003ARange_003E_0020_003E obj2 = _Last_arg;
		if ((uint)(*(int*)((byte*)P_0 + 12)) > (uint)System.Runtime.CompilerServices.Unsafe.As<_Vector_const_iterator_003CHOLM_003A_003AGraphics_003A_003ARange_002Cstd_003A_003Aallocator_003CHOLM_003A_003AGraphics_003A_003ARange_003E_0020_003E, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref _Last_arg, 4)) || (uint)System.Runtime.CompilerServices.Unsafe.As<_Vector_const_iterator_003CHOLM_003A_003AGraphics_003A_003ARange_002Cstd_003A_003Aallocator_003CHOLM_003A_003AGraphics_003A_003ARange_003E_0020_003E, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref _Last_arg, 4)) > (uint)(*(int*)((byte*)P_0 + 16)))
		{
			_invalid_parameter_noinfo();
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _Vector_iterator_003CHOLM_003A_003AGraphics_003A_003ARange_002Cstd_003A_003Aallocator_003CHOLM_003A_003AGraphics_003A_003ARange_003E_0020_003E obj3);
		*(int*)(&obj3) = *(int*)P_0;
		uint num = *(uint*)P_1;
		if ((byte)((num != 0) ? 1 : 0) == 0 || !(num == (uint)(*(int*)(&obj3))))
		{
			_invalid_parameter_noinfo();
		}
		uint num2 = *(uint*)((byte*)P_1 + 4);
		if (!(num2 == (uint)System.Runtime.CompilerServices.Unsafe.As<_Vector_const_iterator_003CHOLM_003A_003AGraphics_003A_003ARange_002Cstd_003A_003Aallocator_003CHOLM_003A_003AGraphics_003A_003ARange_003E_0020_003E, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj2, 4))))
		{
			HOLM.Graphics.Range* ptr = (HOLM.Graphics.Range*)(int)(*(uint*)((byte*)P_0 + 16));
			HOLM.Graphics.Range* ptr2 = (HOLM.Graphics.Range*)(int)num2;
			HOLM.Graphics.Range* ptr3 = (HOLM.Graphics.Range*)(((nint)((byte*)ptr - System.Runtime.CompilerServices.Unsafe.As<_Vector_const_iterator_003CHOLM_003A_003AGraphics_003A_003ARange_002Cstd_003A_003Aallocator_003CHOLM_003A_003AGraphics_003A_003ARange_003E_0020_003E, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj2, 4))) >> 5) * 32 + (byte*)ptr2);
			HOLM.Graphics.Range* ptr4 = (HOLM.Graphics.Range*)(int)System.Runtime.CompilerServices.Unsafe.As<_Vector_const_iterator_003CHOLM_003A_003AGraphics_003A_003ARange_002Cstd_003A_003Aallocator_003CHOLM_003A_003AGraphics_003A_003ARange_003E_0020_003E, uint>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj2, 4));
			if ((HOLM.Graphics.Range*)System.Runtime.CompilerServices.Unsafe.As<_Vector_const_iterator_003CHOLM_003A_003AGraphics_003A_003ARange_002Cstd_003A_003Aallocator_003CHOLM_003A_003AGraphics_003A_003ARange_003E_0020_003E, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj2, 4)) != ptr)
			{
				HOLM.Graphics.Range* ptr5 = (HOLM.Graphics.Range*)((byte*)ptr2 - System.Runtime.CompilerServices.Unsafe.As<_Vector_const_iterator_003CHOLM_003A_003AGraphics_003A_003ARange_002Cstd_003A_003Aallocator_003CHOLM_003A_003AGraphics_003A_003ARange_003E_0020_003E, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj2, 4)));
				do
				{
					// IL cpblk instruction
					System.Runtime.CompilerServices.Unsafe.CopyBlock((byte*)ptr5 + (nuint)ptr4, ptr4, 32);
					ptr4 = (HOLM.Graphics.Range*)((byte*)ptr4 + 32);
				}
				while (ptr4 != ptr);
			}
			*(int*)((byte*)P_0 + 16) = (int)ptr3;
		}
		return P_1;
	}

	internal unsafe static HOLM.Graphics.Range* std_002Evector_003CHOLM_003A_003AGraphics_003A_003ARange_002Cstd_003A_003Aallocator_003CHOLM_003A_003AGraphics_003A_003ARange_003E_0020_003E_002E_Ufill(vector_003CHOLM_003A_003AGraphics_003A_003ARange_002Cstd_003A_003Aallocator_003CHOLM_003A_003AGraphics_003A_003ARange_003E_0020_003E* P_0, HOLM.Graphics.Range* _Ptr, uint _Count, HOLM.Graphics.Range* _Val)
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _Range_checked_iterator_tag _unnamed);
		// IL initblk instruction
		System.Runtime.CompilerServices.Unsafe.InitBlock(ref _unnamed, 0, 1);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _Nonscalar_ptr_iterator_tag nonscalar_ptr_iterator_tag);
		_Nonscalar_ptr_iterator_tag _unnamed2 = nonscalar_ptr_iterator_tag;
		std_002E_Uninit_fill_n_003Cstruct_0020HOLM_003A_003AGraphics_003A_003ARange_0020_002A_002Cunsigned_0020int_002Cstruct_0020HOLM_003A_003AGraphics_003A_003ARange_002Cclass_0020std_003A_003Aallocator_003Cstruct_0020HOLM_003A_003AGraphics_003A_003ARange_003E_0020_003E(_Ptr, _Count, _Val, (allocator_003CHOLM_003A_003AGraphics_003A_003ARange_003E*)((byte*)P_0 + 8), _unnamed2, _unnamed);
		return (HOLM.Graphics.Range*)((int)(_Count * 32) + (byte*)_Ptr);
	}

	internal unsafe static void std_002Evector_003CHOLM_003A_003AGraphics_003A_003ARange_002Cstd_003A_003Aallocator_003CHOLM_003A_003AGraphics_003A_003ARange_003E_0020_003E_002E_Insert_n(vector_003CHOLM_003A_003AGraphics_003A_003ARange_002Cstd_003A_003Aallocator_003CHOLM_003A_003AGraphics_003A_003ARange_003E_0020_003E* P_0, _Vector_const_iterator_003CHOLM_003A_003AGraphics_003A_003ARange_002Cstd_003A_003Aallocator_003CHOLM_003A_003AGraphics_003A_003ARange_003E_0020_003E _Where, uint _Count, HOLM.Graphics.Range* _Val)
	{
		int num = (int)stackalloc byte[__CxxQueryExceptionSize()];
		uint num2 = *(uint*)((byte*)P_0 + 12);
		int num3 = ((num2 != 0) ? (*(int*)((byte*)P_0 + 20) - (int)num2 >> 5) : 0);
		if (_Count == 0)
		{
			return;
		}
		int num4 = *(int*)((byte*)P_0 + 16);
		int num5 = num4 - (int)num2 >> 5;
		if ((uint)(134217727 - num5) < _Count)
		{
			std_002Evector_003CHOLM_003A_003AGraphics_003A_003ARange_002Cstd_003A_003Aallocator_003CHOLM_003A_003AGraphics_003A_003ARange_003E_0020_003E_002E_Xlen();
		}
		if ((uint)num3 < (uint)((int)_Count + num5))
		{
			uint num6 = (uint)num3 >> 1;
			uint num7 = ((134217727 - num6 >= (uint)num3) ? (num6 + (uint)num3) : 0u);
			uint num8 = num7;
			if (num7 < (uint)((int)_Count + num5))
			{
				num8 = _Count + (uint)num5;
			}
			HOLM.Graphics.Range* ptr = std_002Eallocator_003CHOLM_003A_003AGraphics_003A_003ARange_003E_002Eallocate((allocator_003CHOLM_003A_003AGraphics_003A_003ARange_003E*)((byte*)P_0 + 8), num8);
			uint num9 = (uint)(System.Runtime.CompilerServices.Unsafe.As<_Vector_const_iterator_003CHOLM_003A_003AGraphics_003A_003ARange_002Cstd_003A_003Aallocator_003CHOLM_003A_003AGraphics_003A_003ARange_003E_0020_003E, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref _Where, 4)) - *(int*)((byte*)P_0 + 12) >> 5);
			int num10 = 0;
			try
			{
				std_002Evector_003CHOLM_003A_003AGraphics_003A_003ARange_002Cstd_003A_003Aallocator_003CHOLM_003A_003AGraphics_003A_003ARange_003E_0020_003E_002E_Ufill(P_0, (HOLM.Graphics.Range*)((int)(num9 * 32) + (byte*)ptr), _Count, _Val);
				num10 = 1;
				std_002Evector_003CHOLM_003A_003AGraphics_003A_003ARange_002Cstd_003A_003Aallocator_003CHOLM_003A_003AGraphics_003A_003ARange_003E_0020_003E_002E_Umove_003Cstruct_0020HOLM_003A_003AGraphics_003A_003ARange_0020_002A_003E(P_0, (HOLM.Graphics.Range*)(int)(*(uint*)((byte*)P_0 + 12)), (HOLM.Graphics.Range*)(int)System.Runtime.CompilerServices.Unsafe.As<_Vector_const_iterator_003CHOLM_003A_003AGraphics_003A_003ARange_002Cstd_003A_003Aallocator_003CHOLM_003A_003AGraphics_003A_003ARange_003E_0020_003E, uint>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref _Where, 4)), ptr);
				num10 = 2;
				std_002Evector_003CHOLM_003A_003AGraphics_003A_003ARange_002Cstd_003A_003Aallocator_003CHOLM_003A_003AGraphics_003A_003ARange_003E_0020_003E_002E_Umove_003Cstruct_0020HOLM_003A_003AGraphics_003A_003ARange_0020_002A_003E(P_0, (HOLM.Graphics.Range*)(int)System.Runtime.CompilerServices.Unsafe.As<_Vector_const_iterator_003CHOLM_003A_003AGraphics_003A_003ARange_002Cstd_003A_003Aallocator_003CHOLM_003A_003AGraphics_003A_003ARange_003E_0020_003E, uint>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref _Where, 4)), (HOLM.Graphics.Range*)(int)(*(uint*)((byte*)P_0 + 16)), (HOLM.Graphics.Range*)((int)((num9 + _Count) * 32) + (byte*)ptr));
			}
			catch when (((Func<bool>)delegate
			{
				// Could not convert BlockContainer to single expression
				uint exceptionCode = (uint)Marshal.GetExceptionCode();
				return (byte)__CxxExceptionFilter((void*)Marshal.GetExceptionPointers(), null, 0, null) != 0;
			}).Invoke())
			{
				uint num11 = 0u;
				__CxxRegisterExceptionObject((void*)Marshal.GetExceptionPointers(), (void*)num);
				try
				{
					try
					{
						if (1 < num10)
						{
						}
						if (0 < num10)
						{
						}
						std_002Eallocator_003CHOLM_003A_003AGraphics_003A_003ARange_003E_002Edeallocate((allocator_003CHOLM_003A_003AGraphics_003A_003ARange_003E*)((byte*)P_0 + 8), ptr, num8);
						_CxxThrowException(null, null);
					}
					catch when (((Func<bool>)delegate
					{
						// Could not convert BlockContainer to single expression
						num11 = (uint)__CxxDetectRethrow((void*)Marshal.GetExceptionPointers());
						return (byte)num11 != 0;
					}).Invoke())
					{
					}
					if (num11 != 0)
					{
						throw;
					}
				}
				finally
				{
					__CxxUnregisterExceptionObject((void*)num, (int)num11);
				}
			}
			num2 = *(uint*)((byte*)P_0 + 12);
			_Count = (uint)(*(int*)((byte*)P_0 + 16) - (int)num2 >> 5) + _Count;
			if (num2 != 0)
			{
				delete((void*)(int)num2);
			}
			*(int*)((byte*)P_0 + 20) = (int)((int)(num8 * 32) + (byte*)ptr);
			*(int*)((byte*)P_0 + 16) = (int)((int)(_Count * 32) + (byte*)ptr);
			*(int*)((byte*)P_0 + 12) = (int)ptr;
			return;
		}
		if ((uint)(num4 - System.Runtime.CompilerServices.Unsafe.As<_Vector_const_iterator_003CHOLM_003A_003AGraphics_003A_003ARange_002Cstd_003A_003Aallocator_003CHOLM_003A_003AGraphics_003A_003ARange_003E_0020_003E, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref _Where, 4)) >> 5) < _Count)
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out HOLM.Graphics.Range range);
			// IL cpblk instruction
			System.Runtime.CompilerServices.Unsafe.CopyBlock(ref range, _Val, 32);
			std_002Evector_003CHOLM_003A_003AGraphics_003A_003ARange_002Cstd_003A_003Aallocator_003CHOLM_003A_003AGraphics_003A_003ARange_003E_0020_003E_002E_Umove_003Cstruct_0020HOLM_003A_003AGraphics_003A_003ARange_0020_002A_003E(P_0, (HOLM.Graphics.Range*)(int)System.Runtime.CompilerServices.Unsafe.As<_Vector_const_iterator_003CHOLM_003A_003AGraphics_003A_003ARange_002Cstd_003A_003Aallocator_003CHOLM_003A_003AGraphics_003A_003ARange_003E_0020_003E, uint>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref _Where, 4)), (HOLM.Graphics.Range*)num4, (HOLM.Graphics.Range*)(int)(_Count * 32 + (uint)System.Runtime.CompilerServices.Unsafe.As<_Vector_const_iterator_003CHOLM_003A_003AGraphics_003A_003ARange_002Cstd_003A_003Aallocator_003CHOLM_003A_003AGraphics_003A_003ARange_003E_0020_003E, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref _Where, 4))));
			try
			{
				num4 = *(int*)((byte*)P_0 + 16);
				std_002Evector_003CHOLM_003A_003AGraphics_003A_003ARange_002Cstd_003A_003Aallocator_003CHOLM_003A_003AGraphics_003A_003ARange_003E_0020_003E_002E_Ufill(P_0, (HOLM.Graphics.Range*)num4, _Count - (uint)(num4 - System.Runtime.CompilerServices.Unsafe.As<_Vector_const_iterator_003CHOLM_003A_003AGraphics_003A_003ARange_002Cstd_003A_003Aallocator_003CHOLM_003A_003AGraphics_003A_003ARange_003E_0020_003E, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref _Where, 4)) >> 5), &range);
			}
			catch when (((Func<bool>)delegate
			{
				// Could not convert BlockContainer to single expression
				uint exceptionCode = (uint)Marshal.GetExceptionCode();
				return (byte)__CxxExceptionFilter((void*)Marshal.GetExceptionPointers(), null, 0, null) != 0;
			}).Invoke())
			{
				uint num11 = 0u;
				__CxxRegisterExceptionObject((void*)Marshal.GetExceptionPointers(), (void*)num);
				try
				{
					try
					{
						_CxxThrowException(null, null);
					}
					catch when (((Func<bool>)delegate
					{
						// Could not convert BlockContainer to single expression
						num11 = (uint)__CxxDetectRethrow((void*)Marshal.GetExceptionPointers());
						return (byte)num11 != 0;
					}).Invoke())
					{
					}
					if (num11 != 0)
					{
						throw;
					}
				}
				finally
				{
					__CxxUnregisterExceptionObject((void*)num, (int)num11);
				}
			}
			int num12 = (int)(_Count * 32);
			*(int*)((byte*)P_0 + 16) += num12;
			HOLM.Graphics.Range* ptr2 = (HOLM.Graphics.Range*)(*(int*)((byte*)P_0 + 16) - num12);
			HOLM.Graphics.Range* ptr3 = (HOLM.Graphics.Range*)(int)System.Runtime.CompilerServices.Unsafe.As<_Vector_const_iterator_003CHOLM_003A_003AGraphics_003A_003ARange_002Cstd_003A_003Aallocator_003CHOLM_003A_003AGraphics_003A_003ARange_003E_0020_003E, uint>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref _Where, 4));
			if ((HOLM.Graphics.Range*)System.Runtime.CompilerServices.Unsafe.As<_Vector_const_iterator_003CHOLM_003A_003AGraphics_003A_003ARange_002Cstd_003A_003Aallocator_003CHOLM_003A_003AGraphics_003A_003ARange_003E_0020_003E, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref _Where, 4)) != ptr2)
			{
				do
				{
					// IL cpblk instruction
					System.Runtime.CompilerServices.Unsafe.CopyBlock(ptr3, ref range, 32);
					ptr3 = (HOLM.Graphics.Range*)((byte*)ptr3 + 32);
				}
				while (ptr3 != ptr2);
			}
			return;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out HOLM.Graphics.Range range2);
		// IL cpblk instruction
		System.Runtime.CompilerServices.Unsafe.CopyBlock(ref range2, _Val, 32);
		HOLM.Graphics.Range* ptr4 = (HOLM.Graphics.Range*)num4;
		int num13 = (int)(_Count * 32);
		HOLM.Graphics.Range* ptr5 = (HOLM.Graphics.Range*)((byte*)ptr4 - num13);
		*(int*)((byte*)P_0 + 16) = (int)std_002Evector_003CHOLM_003A_003AGraphics_003A_003ARange_002Cstd_003A_003Aallocator_003CHOLM_003A_003AGraphics_003A_003ARange_003E_0020_003E_002E_Umove_003Cstruct_0020HOLM_003A_003AGraphics_003A_003ARange_0020_002A_003E(P_0, ptr5, ptr4, (HOLM.Graphics.Range*)num4);
		stdext_002E_Unchecked_move_backward_003Cstruct_0020HOLM_003A_003AGraphics_003A_003ARange_0020_002A_002Cstruct_0020HOLM_003A_003AGraphics_003A_003ARange_0020_002A_003E((HOLM.Graphics.Range*)(int)System.Runtime.CompilerServices.Unsafe.As<_Vector_const_iterator_003CHOLM_003A_003AGraphics_003A_003ARange_002Cstd_003A_003Aallocator_003CHOLM_003A_003AGraphics_003A_003ARange_003E_0020_003E, uint>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref _Where, 4)), ptr5, ptr4);
		HOLM.Graphics.Range* ptr6 = (HOLM.Graphics.Range*)(num13 + System.Runtime.CompilerServices.Unsafe.As<_Vector_const_iterator_003CHOLM_003A_003AGraphics_003A_003ARange_002Cstd_003A_003Aallocator_003CHOLM_003A_003AGraphics_003A_003ARange_003E_0020_003E, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref _Where, 4)));
		HOLM.Graphics.Range* ptr7 = (HOLM.Graphics.Range*)(int)System.Runtime.CompilerServices.Unsafe.As<_Vector_const_iterator_003CHOLM_003A_003AGraphics_003A_003ARange_002Cstd_003A_003Aallocator_003CHOLM_003A_003AGraphics_003A_003ARange_003E_0020_003E, uint>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref _Where, 4));
		if ((HOLM.Graphics.Range*)System.Runtime.CompilerServices.Unsafe.As<_Vector_const_iterator_003CHOLM_003A_003AGraphics_003A_003ARange_002Cstd_003A_003Aallocator_003CHOLM_003A_003AGraphics_003A_003ARange_003E_0020_003E, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref _Where, 4)) != ptr6)
		{
			do
			{
				// IL cpblk instruction
				System.Runtime.CompilerServices.Unsafe.CopyBlock(ptr7, ref range2, 32);
				ptr7 = (HOLM.Graphics.Range*)((byte*)ptr7 + 32);
			}
			while (ptr7 != ptr6);
		}
	}

	internal unsafe static void std_002Evector_003CHOLM_003A_003AGraphics_003A_003ARange_002Cstd_003A_003Aallocator_003CHOLM_003A_003AGraphics_003A_003ARange_003E_0020_003E_002E_Xlen()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj);
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D(&obj, (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_0BD_0040OLBABOEK_0040vector_003F_0024DMT_003F_0024DO_003F5too_003F5long_003F_0024AA_0040));
		try
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out length_error length_error);
			std_002Eexception_002E_007Bctor_007D((exception*)(&length_error));
			try
			{
				*(int*)(&length_error) = (int)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_7logic_error_0040std_0040_00406B_0040);
				std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref length_error, 12)), &obj);
			}
			catch
			{
				//try-fault
				___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<exception*, void>)(&std_002Eexception_002E_007Bdtor_007D), &length_error);
				throw;
			}
			try
			{
				*(int*)(&length_error) = (int)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_7length_error_0040std_0040_00406B_0040);
			}
			catch
			{
				//try-fault
				___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<logic_error*, void>)(&std_002Elogic_error_002E_007Bdtor_007D), &length_error);
				throw;
			}
			_CxxThrowException(&length_error, (_s__ThrowInfo*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _TI3_003FAVlength_error_0040std_0040_0040));
			return;
		}
		catch
		{
			//try-fault
			___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), &obj);
			throw;
		}
	}

	internal unsafe static void std_002Eallocator_003CHOLM_003A_003AGraphics_003A_003ARange_003E_002Edeallocate(allocator_003CHOLM_003A_003AGraphics_003A_003ARange_003E* P_0, HOLM.Graphics.Range* _Ptr, uint __unnamed001)
	{
		delete(_Ptr);
	}

	internal unsafe static HOLM.Graphics.Range* std_002Eallocator_003CHOLM_003A_003AGraphics_003A_003ARange_003E_002Eallocate(allocator_003CHOLM_003A_003AGraphics_003A_003ARange_003E* P_0, uint _Count)
	{
		uint num = _Count;
		if (_Count == 0)
		{
			num = 0u;
		}
		else if (uint.MaxValue / _Count < 32)
		{
			sbyte* ptr = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out bad_alloc bad_alloc);
			std_002Eexception_002E_007Bctor_007D((exception*)(&bad_alloc), &ptr);
			try
			{
				*(int*)(&bad_alloc) = (int)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_7bad_alloc_0040std_0040_00406B_0040);
			}
			catch
			{
				//try-fault
				___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<exception*, void>)(&std_002Eexception_002E_007Bdtor_007D), &bad_alloc);
				throw;
			}
			_CxxThrowException(&bad_alloc, (_s__ThrowInfo*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _TI2_003FAVbad_alloc_0040std_0040_0040));
		}
		return (HOLM.Graphics.Range*)@new(num * 32);
	}

	internal unsafe static _Vector_const_iterator_003CHOLM_003A_003AGraphics_003A_003ARange_002Cstd_003A_003Aallocator_003CHOLM_003A_003AGraphics_003A_003ARange_003E_0020_003E* std_002E_Vector_const_iterator_003CHOLM_003A_003AGraphics_003A_003ARange_002Cstd_003A_003Aallocator_003CHOLM_003A_003AGraphics_003A_003ARange_003E_0020_003E_002E_002B_003D(_Vector_const_iterator_003CHOLM_003A_003AGraphics_003A_003ARange_002Cstd_003A_003Aallocator_003CHOLM_003A_003AGraphics_003A_003ARange_003E_0020_003E* P_0, int _Off)
	{
		if ((byte)((*(int*)P_0 != 0) ? 1 : 0) == 0)
		{
			_invalid_parameter_noinfo();
		}
		uint num = *(uint*)P_0;
		_Container_base_aux* ptr = (_Container_base_aux*)((num == 0) ? 0 : ((int)(*(uint*)(int)num)));
		uint num2 = (uint)(_Off * 32);
		uint num3 = (uint)(*(int*)((byte*)P_0 + 4)) + num2;
		if (num3 <= (uint)(*(int*)((byte*)ptr + 16)))
		{
			_Container_base_aux* ptr2 = (_Container_base_aux*)((num == 0) ? 0 : ((int)(*(uint*)(int)num)));
			if (num3 >= (uint)(*(int*)((byte*)ptr2 + 12)))
			{
				goto IL_004c;
			}
		}
		_invalid_parameter_noinfo();
		goto IL_004c;
		IL_004c:
		*(int*)((byte*)P_0 + 4) += (int)num2;
		return P_0;
	}

	internal unsafe static HOLM.Graphics.Range* std_002Evector_003CHOLM_003A_003AGraphics_003A_003ARange_002Cstd_003A_003Aallocator_003CHOLM_003A_003AGraphics_003A_003ARange_003E_0020_003E_002E_Umove_003Cstruct_0020HOLM_003A_003AGraphics_003A_003ARange_0020_002A_003E(vector_003CHOLM_003A_003AGraphics_003A_003ARange_002Cstd_003A_003Aallocator_003CHOLM_003A_003AGraphics_003A_003ARange_003E_0020_003E* P_0, HOLM.Graphics.Range* _First, HOLM.Graphics.Range* _Last, HOLM.Graphics.Range* _Ptr)
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _Range_checked_iterator_tag _unnamed);
		// IL initblk instruction
		System.Runtime.CompilerServices.Unsafe.InitBlock(ref _unnamed, 0, 1);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _Nonscalar_ptr_iterator_tag nonscalar_ptr_iterator_tag);
		_Nonscalar_ptr_iterator_tag _unnamed2 = nonscalar_ptr_iterator_tag;
		return std_002E_Uninit_copy_003Cstruct_0020HOLM_003A_003AGraphics_003A_003ARange_0020_002A_002Cstruct_0020HOLM_003A_003AGraphics_003A_003ARange_0020_002A_002Cclass_0020std_003A_003Aallocator_003Cstruct_0020HOLM_003A_003AGraphics_003A_003ARange_003E_0020_003E(_First, _Last, _Ptr, (allocator_003CHOLM_003A_003AGraphics_003A_003ARange_003E*)((byte*)P_0 + 8), _unnamed2, _unnamed);
	}

	internal unsafe static HOLM.Graphics.Range* stdext_002E_Unchecked_move_backward_003Cstruct_0020HOLM_003A_003AGraphics_003A_003ARange_0020_002A_002Cstruct_0020HOLM_003A_003AGraphics_003A_003ARange_0020_002A_003E(HOLM.Graphics.Range* _First, HOLM.Graphics.Range* _Last, HOLM.Graphics.Range* _Dest)
	{
		HOLM.Graphics.Range* result = (HOLM.Graphics.Range*)((byte*)_Dest - ((nint)((byte*)_Last - (nuint)_First) >> 5) * 32);
		HOLM.Graphics.Range* ptr = _Last;
		if (_First != _Last)
		{
			HOLM.Graphics.Range* ptr2 = (HOLM.Graphics.Range*)((byte*)_Dest - (nuint)_Last);
			do
			{
				ptr = (HOLM.Graphics.Range*)((byte*)ptr - 32);
				// IL cpblk instruction
				System.Runtime.CompilerServices.Unsafe.CopyBlock((byte*)ptr2 + (nuint)ptr, ptr, 32);
			}
			while (ptr != _First);
		}
		return result;
	}

	internal unsafe static void std_002E_Uninit_fill_n_003Cstruct_0020HOLM_003A_003AGraphics_003A_003ARange_0020_002A_002Cunsigned_0020int_002Cstruct_0020HOLM_003A_003AGraphics_003A_003ARange_002Cclass_0020std_003A_003Aallocator_003Cstruct_0020HOLM_003A_003AGraphics_003A_003ARange_003E_0020_003E(HOLM.Graphics.Range* _First, uint _Count, HOLM.Graphics.Range* _Val, allocator_003CHOLM_003A_003AGraphics_003A_003ARange_003E* _Al, _Nonscalar_ptr_iterator_tag __unnamed004, _Range_checked_iterator_tag __unnamed005)
	{
		int num = (int)stackalloc byte[__CxxQueryExceptionSize()];
		HOLM.Graphics.Range* ptr = _First;
		try
		{
			while (0 < _Count)
			{
				void* ptr2 = _First;
				HOLM.Graphics.Range* ptr3 = _First;
				if (_First != null)
				{
					// IL cpblk instruction
					System.Runtime.CompilerServices.Unsafe.CopyBlock(_First, _Val, 32);
					HOLM.Graphics.Range* ptr4 = _First;
				}
				else
				{
					HOLM.Graphics.Range* ptr4 = null;
				}
				_Count--;
				_First = (HOLM.Graphics.Range*)((byte*)_First + 32);
			}
		}
		catch when (((Func<bool>)delegate
		{
			// Could not convert BlockContainer to single expression
			uint exceptionCode = (uint)Marshal.GetExceptionCode();
			return (byte)__CxxExceptionFilter((void*)Marshal.GetExceptionPointers(), null, 0, null) != 0;
		}).Invoke())
		{
			uint num2 = 0u;
			__CxxRegisterExceptionObject((void*)Marshal.GetExceptionPointers(), (void*)num);
			try
			{
				try
				{
					for (; ptr != _First; ptr = (HOLM.Graphics.Range*)((byte*)ptr + 32))
					{
					}
					_CxxThrowException(null, null);
				}
				catch when (((Func<bool>)delegate
				{
					// Could not convert BlockContainer to single expression
					num2 = (uint)__CxxDetectRethrow((void*)Marshal.GetExceptionPointers());
					return (byte)num2 != 0;
				}).Invoke())
				{
				}
				if (num2 != 0)
				{
					throw;
				}
			}
			finally
			{
				__CxxUnregisterExceptionObject((void*)num, (int)num2);
			}
		}
	}

	internal unsafe static HOLM.Graphics.Range* std_002E_Uninit_copy_003Cstruct_0020HOLM_003A_003AGraphics_003A_003ARange_0020_002A_002Cstruct_0020HOLM_003A_003AGraphics_003A_003ARange_0020_002A_002Cclass_0020std_003A_003Aallocator_003Cstruct_0020HOLM_003A_003AGraphics_003A_003ARange_003E_0020_003E(HOLM.Graphics.Range* _First, HOLM.Graphics.Range* _Last, HOLM.Graphics.Range* _Dest, allocator_003CHOLM_003A_003AGraphics_003A_003ARange_003E* _Al, _Nonscalar_ptr_iterator_tag __unnamed004, _Range_checked_iterator_tag __unnamed005)
	{
		int num = (int)stackalloc byte[__CxxQueryExceptionSize()];
		HOLM.Graphics.Range* ptr = _Dest;
		try
		{
			while (_First != _Last)
			{
				void* ptr2 = _Dest;
				HOLM.Graphics.Range* ptr3 = _Dest;
				if (_Dest != null)
				{
					// IL cpblk instruction
					System.Runtime.CompilerServices.Unsafe.CopyBlock(_Dest, _First, 32);
					HOLM.Graphics.Range* ptr4 = _Dest;
				}
				else
				{
					HOLM.Graphics.Range* ptr4 = null;
				}
				_Dest = (HOLM.Graphics.Range*)((byte*)_Dest + 32);
				_First = (HOLM.Graphics.Range*)((byte*)_First + 32);
			}
		}
		catch when (((Func<bool>)delegate
		{
			// Could not convert BlockContainer to single expression
			uint exceptionCode = (uint)Marshal.GetExceptionCode();
			return (byte)__CxxExceptionFilter((void*)Marshal.GetExceptionPointers(), null, 0, null) != 0;
		}).Invoke())
		{
			uint num2 = 0u;
			__CxxRegisterExceptionObject((void*)Marshal.GetExceptionPointers(), (void*)num);
			try
			{
				try
				{
					for (; ptr != _Dest; ptr = (HOLM.Graphics.Range*)((byte*)ptr + 32))
					{
					}
					_CxxThrowException(null, null);
				}
				catch when (((Func<bool>)delegate
				{
					// Could not convert BlockContainer to single expression
					num2 = (uint)__CxxDetectRethrow((void*)Marshal.GetExceptionPointers());
					return (byte)num2 != 0;
				}).Invoke())
				{
				}
				if (num2 != 0)
				{
					throw;
				}
			}
			finally
			{
				__CxxUnregisterExceptionObject((void*)num, (int)num2);
			}
		}
		return _Dest;
	}

	internal unsafe static void _003FA0x5305ceb3_002E_003F_003F__E_003FA0x5305ceb3_0040HEXSTRINGARRAY_0040MiscHelper_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EMiscHelper_002E_003FA0x5305ceb3_002EHEXSTRINGARRAY), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01GBGANLPD_00400_003F_0024AA_0040));
		try
		{
			std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x5305ceb3_002EHEXSTRINGARRAY, 28)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01HIHLOKLC_00401_003F_0024AA_0040));
			try
			{
				std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x5305ceb3_002EHEXSTRINGARRAY, 56)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01FDFGLJHB_00402_003F_0024AA_0040));
				try
				{
					std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x5305ceb3_002EHEXSTRINGARRAY, 84)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01EKENIIDA_00403_003F_0024AA_0040));
					try
					{
						std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x5305ceb3_002EHEXSTRINGARRAY, 112)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01FAMBOPH_00404_003F_0024AA_0040));
						try
						{
							std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x5305ceb3_002EHEXSTRINGARRAY, 140)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01BMBHCPLG_00405_003F_0024AA_0040));
							try
							{
								std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x5305ceb3_002EHEXSTRINGARRAY, 168)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01DHDKHMHF_00406_003F_0024AA_0040));
								try
								{
									std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x5305ceb3_002EHEXSTRINGARRAY, 196)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01COCBENDE_00407_003F_0024AA_0040));
									try
									{
										std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x5305ceb3_002EHEXSTRINGARRAY, 224)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01KJLJFBPL_00408_003F_0024AA_0040));
										try
										{
											std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x5305ceb3_002EHEXSTRINGARRAY, 252)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01LAKCGALK_00409_003F_0024AA_0040));
											try
											{
												std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x5305ceb3_002EHEXSTRINGARRAY, 280)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01FHEEJDEE_0040A_003F_0024AA_0040));
												try
												{
													std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x5305ceb3_002EHEXSTRINGARRAY, 308)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01HMGJMAIH_0040B_003F_0024AA_0040));
													try
													{
														std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x5305ceb3_002EHEXSTRINGARRAY, 336)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01GFHCPBMG_0040C_003F_0024AA_0040));
														try
														{
															std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x5305ceb3_002EHEXSTRINGARRAY, 364)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01CKDDGHAB_0040D_003F_0024AA_0040));
															try
															{
																std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x5305ceb3_002EHEXSTRINGARRAY, 392)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01DDCIFGEA_0040E_003F_0024AA_0040));
																try
																{
																	std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x5305ceb3_002EHEXSTRINGARRAY, 420)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01BIAFAFID_0040F_003F_0024AA_0040));
																}
																catch
																{
																	//try-fault
																	___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x5305ceb3_002EHEXSTRINGARRAY, 392)));
																	throw;
																}
															}
															catch
															{
																//try-fault
																___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x5305ceb3_002EHEXSTRINGARRAY, 364)));
																throw;
															}
														}
														catch
														{
															//try-fault
															___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x5305ceb3_002EHEXSTRINGARRAY, 336)));
															throw;
														}
													}
													catch
													{
														//try-fault
														___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x5305ceb3_002EHEXSTRINGARRAY, 308)));
														throw;
													}
												}
												catch
												{
													//try-fault
													___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x5305ceb3_002EHEXSTRINGARRAY, 280)));
													throw;
												}
											}
											catch
											{
												//try-fault
												___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x5305ceb3_002EHEXSTRINGARRAY, 252)));
												throw;
											}
										}
										catch
										{
											//try-fault
											___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x5305ceb3_002EHEXSTRINGARRAY, 224)));
											throw;
										}
									}
									catch
									{
										//try-fault
										___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x5305ceb3_002EHEXSTRINGARRAY, 196)));
										throw;
									}
								}
								catch
								{
									//try-fault
									___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x5305ceb3_002EHEXSTRINGARRAY, 168)));
									throw;
								}
							}
							catch
							{
								//try-fault
								___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x5305ceb3_002EHEXSTRINGARRAY, 140)));
								throw;
							}
						}
						catch
						{
							//try-fault
							___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x5305ceb3_002EHEXSTRINGARRAY, 112)));
							throw;
						}
					}
					catch
					{
						//try-fault
						___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x5305ceb3_002EHEXSTRINGARRAY, 84)));
						throw;
					}
				}
				catch
				{
					//try-fault
					___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x5305ceb3_002EHEXSTRINGARRAY, 56)));
					throw;
				}
			}
			catch
			{
				//try-fault
				___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x5305ceb3_002EHEXSTRINGARRAY, 28)));
				throw;
			}
		}
		catch
		{
			//try-fault
			___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EMiscHelper_002E_003FA0x5305ceb3_002EHEXSTRINGARRAY));
			throw;
		}
		_atexit_m((delegate*<void>)(&_003FA0x5305ceb3_002E_003F_003F__F_003FA0x5305ceb3_0040HEXSTRINGARRAY_0040MiscHelper_0040HOLM_0040_0040YMXXZ));
	}

	internal unsafe static void _003FA0x5305ceb3_002E_003F_003F__F_003FA0x5305ceb3_0040HEXSTRINGARRAY_0040MiscHelper_0040HOLM_0040_0040YMXXZ()
	{
		__ehvec_dtor(System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EMiscHelper_002E_003FA0x5305ceb3_002EHEXSTRINGARRAY), 28u, 16, (delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D));
	}

	internal unsafe static void _003FA0x5305ceb3_002E_003F_003F__E_003FA0x5305ceb3_0040HOLM_WINDOW_FPGA_CTRL_0040MiscHelper_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EMiscHelper_002E_003FA0x5305ceb3_002EHOLM_WINDOW_FPGA_CTRL), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_0BD_0040CPFABDBC_0040HOLMFpgaController_003F_0024AA_0040));
		_atexit_m((delegate*<void>)(&_003FA0x5305ceb3_002E_003F_003F__F_003FA0x5305ceb3_0040HOLM_WINDOW_FPGA_CTRL_0040MiscHelper_0040HOLM_0040_0040YMXXZ));
	}

	internal unsafe static void _003FA0x5305ceb3_002E_003F_003F__F_003FA0x5305ceb3_0040HOLM_WINDOW_FPGA_CTRL_0040MiscHelper_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EMiscHelper_002E_003FA0x5305ceb3_002EHOLM_WINDOW_FPGA_CTRL));
	}

	internal unsafe static void _003FA0x5305ceb3_002E_003F_003F__E_003FA0x5305ceb3_0040HOLM_WINDOW_DSPreLab_0040MiscHelper_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EMiscHelper_002E_003FA0x5305ceb3_002EHOLM_WINDOW_DSPreLab), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_08LKNALPII_0040DSPreLab_003F_0024AA_0040));
		_atexit_m((delegate*<void>)(&_003FA0x5305ceb3_002E_003F_003F__F_003FA0x5305ceb3_0040HOLM_WINDOW_DSPreLab_0040MiscHelper_0040HOLM_0040_0040YMXXZ));
	}

	internal unsafe static void _003FA0x5305ceb3_002E_003F_003F__F_003FA0x5305ceb3_0040HOLM_WINDOW_DSPreLab_0040MiscHelper_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EMiscHelper_002E_003FA0x5305ceb3_002EHOLM_WINDOW_DSPreLab));
	}

	internal unsafe static void _003FA0x5305ceb3_002E_003F_003F__E_003FA0x5305ceb3_0040HOLM_WINDOW_DSPreLab_DEMO_0040MiscHelper_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EMiscHelper_002E_003FA0x5305ceb3_002EHOLM_WINDOW_DSPreLab_DEMO), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_0BA_0040MFILEGDE_0040DEMO_003F5_003F9_003F5DSPreLab_003F_0024AA_0040));
		_atexit_m((delegate*<void>)(&_003FA0x5305ceb3_002E_003F_003F__F_003FA0x5305ceb3_0040HOLM_WINDOW_DSPreLab_DEMO_0040MiscHelper_0040HOLM_0040_0040YMXXZ));
	}

	internal unsafe static void _003FA0x5305ceb3_002E_003F_003F__F_003FA0x5305ceb3_0040HOLM_WINDOW_DSPreLab_DEMO_0040MiscHelper_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EMiscHelper_002E_003FA0x5305ceb3_002EHOLM_WINDOW_DSPreLab_DEMO));
	}

	internal static void _003FA0x5305ceb3_002E_003F_003F__E_003FA0x5305ceb3_0040PI_0040Math_0040HOLM_0040_0040YMXXZ()
	{
		HOLM_002EMath_002E_003FA0x5305ceb3_002EPI = Math.Acos(-1.0);
	}

	internal static void _003FA0x5305ceb3_002E_003F_003F__E_003FA0x5305ceb3_0040PI_F_0040Math_0040HOLM_0040_0040YMXXZ()
	{
		HOLM_002EMath_002E_003FA0x5305ceb3_002EPI_F = (float)Math.Acos(-1.0);
	}

	internal static void _003FA0x5305ceb3_002E_003F_003F__E_003FA0x5305ceb3_0040TWOPI_0040Math_0040HOLM_0040_0040YMXXZ()
	{
		HOLM_002EMath_002E_003FA0x5305ceb3_002ETWOPI = HOLM_002EMath_002E_003FA0x5305ceb3_002EPI * 2.0;
	}

	internal static void _003FA0x5305ceb3_002E_003F_003F__E_003FA0x5305ceb3_0040HALFPI_0040Math_0040HOLM_0040_0040YMXXZ()
	{
		HOLM_002EMath_002E_003FA0x5305ceb3_002EHALFPI = HOLM_002EMath_002E_003FA0x5305ceb3_002EPI * 0.5;
	}

	internal static void _003FA0x5305ceb3_002E_003F_003F__E_003FA0x5305ceb3_0040SQRT2_0040Math_0040HOLM_0040_0040YMXXZ()
	{
		HOLM_002EMath_002E_003FA0x5305ceb3_002ESQRT2 = Math.Sqrt(2.0);
	}

	internal static void _003FA0x5305ceb3_002E_003F_003F__E_003FA0x5305ceb3_0040SQRT2_F_0040Math_0040HOLM_0040_0040YMXXZ()
	{
		HOLM_002EMath_002E_003FA0x5305ceb3_002ESQRT2_F = (float)Math.Sqrt(2.0);
	}

	internal static void _003FA0x5305ceb3_002E_003F_003F__E_003FA0x5305ceb3_0040RadToDeg_0040Math_0040HOLM_0040_0040YMXXZ()
	{
		HOLM_002EMath_002E_003FA0x5305ceb3_002ERadToDeg = 180.0 / HOLM_002EMath_002E_003FA0x5305ceb3_002EPI;
	}

	internal static void _003FA0x5305ceb3_002E_003F_003F__E_003FA0x5305ceb3_0040RadToDeg_F_0040Math_0040HOLM_0040_0040YMXXZ()
	{
		HOLM_002EMath_002E_003FA0x5305ceb3_002ERadToDeg_F = (float)(180.0 / (double)HOLM_002EMath_002E_003FA0x5305ceb3_002EPI_F);
	}

	internal static void _003FA0x5305ceb3_002E_003F_003F__E_003FA0x5305ceb3_0040DegToRad_0040Math_0040HOLM_0040_0040YMXXZ()
	{
		HOLM_002EMath_002E_003FA0x5305ceb3_002EDegToRad = HOLM_002EMath_002E_003FA0x5305ceb3_002EPI / 180.0;
	}

	internal static void _003FA0x5305ceb3_002E_003F_003F__E_003FA0x5305ceb3_0040DegToRad_F_0040Math_0040HOLM_0040_0040YMXXZ()
	{
		HOLM_002EMath_002E_003FA0x5305ceb3_002EDegToRad_F = HOLM_002EMath_002E_003FA0x5305ceb3_002EPI_F / 180f;
	}

	internal static double HOLM_002EGuiHelper_002ESetNumericUpDownValue(NumericUpDown updown, double value)
	{
		decimal minimum = updown.Minimum;
		if (value < decimal.ToDouble(minimum))
		{
			value = decimal.ToDouble(updown.Minimum);
		}
		decimal maximum = updown.Maximum;
		if (value > decimal.ToDouble(maximum))
		{
			value = decimal.ToDouble(updown.Maximum);
		}
		decimal value2 = new decimal(value);
		updown.Value = value2;
		return value;
	}

	internal static string HOLM_002EGuiHelper_002EDigitsString(double @in, int digits)
	{
		if (@in != 0.0)
		{
			double num = HOLM_002EMath_002ENegPow10(HOLM_002EMath_002EToIntFloor(Math.Log10(Math.Abs(@in))) - digits);
			return (Math.Floor(@in / num + 0.5) * num).ToString("G");
		}
		return "0";
	}

	internal unsafe static void std_002Elocale_002Efacet_002E_Register(locale.facet* P_0)
	{
		std_002Elocale_002Efacet_002Efacet_Register_m(P_0);
	}

	internal unsafe static void _003FA0x49785d99_002E_003F_003F__E_003FA0x49785d99_0040HEXSTRINGARRAY_0040MiscHelper_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EMiscHelper_002E_003FA0x49785d99_002EHEXSTRINGARRAY), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01GBGANLPD_00400_003F_0024AA_0040));
		try
		{
			std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x49785d99_002EHEXSTRINGARRAY, 28)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01HIHLOKLC_00401_003F_0024AA_0040));
			try
			{
				std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x49785d99_002EHEXSTRINGARRAY, 56)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01FDFGLJHB_00402_003F_0024AA_0040));
				try
				{
					std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x49785d99_002EHEXSTRINGARRAY, 84)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01EKENIIDA_00403_003F_0024AA_0040));
					try
					{
						std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x49785d99_002EHEXSTRINGARRAY, 112)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01FAMBOPH_00404_003F_0024AA_0040));
						try
						{
							std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x49785d99_002EHEXSTRINGARRAY, 140)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01BMBHCPLG_00405_003F_0024AA_0040));
							try
							{
								std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x49785d99_002EHEXSTRINGARRAY, 168)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01DHDKHMHF_00406_003F_0024AA_0040));
								try
								{
									std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x49785d99_002EHEXSTRINGARRAY, 196)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01COCBENDE_00407_003F_0024AA_0040));
									try
									{
										std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x49785d99_002EHEXSTRINGARRAY, 224)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01KJLJFBPL_00408_003F_0024AA_0040));
										try
										{
											std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x49785d99_002EHEXSTRINGARRAY, 252)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01LAKCGALK_00409_003F_0024AA_0040));
											try
											{
												std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x49785d99_002EHEXSTRINGARRAY, 280)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01FHEEJDEE_0040A_003F_0024AA_0040));
												try
												{
													std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x49785d99_002EHEXSTRINGARRAY, 308)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01HMGJMAIH_0040B_003F_0024AA_0040));
													try
													{
														std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x49785d99_002EHEXSTRINGARRAY, 336)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01GFHCPBMG_0040C_003F_0024AA_0040));
														try
														{
															std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x49785d99_002EHEXSTRINGARRAY, 364)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01CKDDGHAB_0040D_003F_0024AA_0040));
															try
															{
																std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x49785d99_002EHEXSTRINGARRAY, 392)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01DDCIFGEA_0040E_003F_0024AA_0040));
																try
																{
																	std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x49785d99_002EHEXSTRINGARRAY, 420)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01BIAFAFID_0040F_003F_0024AA_0040));
																}
																catch
																{
																	//try-fault
																	___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x49785d99_002EHEXSTRINGARRAY, 392)));
																	throw;
																}
															}
															catch
															{
																//try-fault
																___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x49785d99_002EHEXSTRINGARRAY, 364)));
																throw;
															}
														}
														catch
														{
															//try-fault
															___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x49785d99_002EHEXSTRINGARRAY, 336)));
															throw;
														}
													}
													catch
													{
														//try-fault
														___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x49785d99_002EHEXSTRINGARRAY, 308)));
														throw;
													}
												}
												catch
												{
													//try-fault
													___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x49785d99_002EHEXSTRINGARRAY, 280)));
													throw;
												}
											}
											catch
											{
												//try-fault
												___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x49785d99_002EHEXSTRINGARRAY, 252)));
												throw;
											}
										}
										catch
										{
											//try-fault
											___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x49785d99_002EHEXSTRINGARRAY, 224)));
											throw;
										}
									}
									catch
									{
										//try-fault
										___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x49785d99_002EHEXSTRINGARRAY, 196)));
										throw;
									}
								}
								catch
								{
									//try-fault
									___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x49785d99_002EHEXSTRINGARRAY, 168)));
									throw;
								}
							}
							catch
							{
								//try-fault
								___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x49785d99_002EHEXSTRINGARRAY, 140)));
								throw;
							}
						}
						catch
						{
							//try-fault
							___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x49785d99_002EHEXSTRINGARRAY, 112)));
							throw;
						}
					}
					catch
					{
						//try-fault
						___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x49785d99_002EHEXSTRINGARRAY, 84)));
						throw;
					}
				}
				catch
				{
					//try-fault
					___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x49785d99_002EHEXSTRINGARRAY, 56)));
					throw;
				}
			}
			catch
			{
				//try-fault
				___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x49785d99_002EHEXSTRINGARRAY, 28)));
				throw;
			}
		}
		catch
		{
			//try-fault
			___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EMiscHelper_002E_003FA0x49785d99_002EHEXSTRINGARRAY));
			throw;
		}
		_atexit_m((delegate*<void>)(&_003FA0x49785d99_002E_003F_003F__F_003FA0x49785d99_0040HEXSTRINGARRAY_0040MiscHelper_0040HOLM_0040_0040YMXXZ));
	}

	internal unsafe static void _003FA0x49785d99_002E_003F_003F__F_003FA0x49785d99_0040HEXSTRINGARRAY_0040MiscHelper_0040HOLM_0040_0040YMXXZ()
	{
		__ehvec_dtor(System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EMiscHelper_002E_003FA0x49785d99_002EHEXSTRINGARRAY), 28u, 16, (delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D));
	}

	internal unsafe static void _003FA0x49785d99_002E_003F_003F__E_003FA0x49785d99_0040HOLM_WINDOW_FPGA_CTRL_0040MiscHelper_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EMiscHelper_002E_003FA0x49785d99_002EHOLM_WINDOW_FPGA_CTRL), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_0BD_0040CPFABDBC_0040HOLMFpgaController_003F_0024AA_0040));
		_atexit_m((delegate*<void>)(&_003FA0x49785d99_002E_003F_003F__F_003FA0x49785d99_0040HOLM_WINDOW_FPGA_CTRL_0040MiscHelper_0040HOLM_0040_0040YMXXZ));
	}

	internal unsafe static void _003FA0x49785d99_002E_003F_003F__F_003FA0x49785d99_0040HOLM_WINDOW_FPGA_CTRL_0040MiscHelper_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EMiscHelper_002E_003FA0x49785d99_002EHOLM_WINDOW_FPGA_CTRL));
	}

	internal unsafe static void _003FA0x49785d99_002E_003F_003F__E_003FA0x49785d99_0040HOLM_WINDOW_DSPreLab_0040MiscHelper_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EMiscHelper_002E_003FA0x49785d99_002EHOLM_WINDOW_DSPreLab), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_08LKNALPII_0040DSPreLab_003F_0024AA_0040));
		_atexit_m((delegate*<void>)(&_003FA0x49785d99_002E_003F_003F__F_003FA0x49785d99_0040HOLM_WINDOW_DSPreLab_0040MiscHelper_0040HOLM_0040_0040YMXXZ));
	}

	internal unsafe static void _003FA0x49785d99_002E_003F_003F__F_003FA0x49785d99_0040HOLM_WINDOW_DSPreLab_0040MiscHelper_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EMiscHelper_002E_003FA0x49785d99_002EHOLM_WINDOW_DSPreLab));
	}

	internal unsafe static void _003FA0x49785d99_002E_003F_003F__E_003FA0x49785d99_0040HOLM_WINDOW_DSPreLab_DEMO_0040MiscHelper_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EMiscHelper_002E_003FA0x49785d99_002EHOLM_WINDOW_DSPreLab_DEMO), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_0BA_0040MFILEGDE_0040DEMO_003F5_003F9_003F5DSPreLab_003F_0024AA_0040));
		_atexit_m((delegate*<void>)(&_003FA0x49785d99_002E_003F_003F__F_003FA0x49785d99_0040HOLM_WINDOW_DSPreLab_DEMO_0040MiscHelper_0040HOLM_0040_0040YMXXZ));
	}

	internal unsafe static void _003FA0x49785d99_002E_003F_003F__F_003FA0x49785d99_0040HOLM_WINDOW_DSPreLab_DEMO_0040MiscHelper_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EMiscHelper_002E_003FA0x49785d99_002EHOLM_WINDOW_DSPreLab_DEMO));
	}

	internal static void _003FA0x49785d99_002E_003F_003F__E_003FA0x49785d99_0040PI_0040Math_0040HOLM_0040_0040YMXXZ()
	{
		HOLM_002EMath_002E_003FA0x49785d99_002EPI = Math.Acos(-1.0);
	}

	internal static void _003FA0x49785d99_002E_003F_003F__E_003FA0x49785d99_0040PI_F_0040Math_0040HOLM_0040_0040YMXXZ()
	{
		HOLM_002EMath_002E_003FA0x49785d99_002EPI_F = (float)Math.Acos(-1.0);
	}

	internal static void _003FA0x49785d99_002E_003F_003F__E_003FA0x49785d99_0040TWOPI_0040Math_0040HOLM_0040_0040YMXXZ()
	{
		HOLM_002EMath_002E_003FA0x49785d99_002ETWOPI = HOLM_002EMath_002E_003FA0x49785d99_002EPI * 2.0;
	}

	internal static void _003FA0x49785d99_002E_003F_003F__E_003FA0x49785d99_0040HALFPI_0040Math_0040HOLM_0040_0040YMXXZ()
	{
		HOLM_002EMath_002E_003FA0x49785d99_002EHALFPI = HOLM_002EMath_002E_003FA0x49785d99_002EPI * 0.5;
	}

	internal static void _003FA0x49785d99_002E_003F_003F__E_003FA0x49785d99_0040SQRT2_0040Math_0040HOLM_0040_0040YMXXZ()
	{
		HOLM_002EMath_002E_003FA0x49785d99_002ESQRT2 = Math.Sqrt(2.0);
	}

	internal static void _003FA0x49785d99_002E_003F_003F__E_003FA0x49785d99_0040SQRT2_F_0040Math_0040HOLM_0040_0040YMXXZ()
	{
		HOLM_002EMath_002E_003FA0x49785d99_002ESQRT2_F = (float)Math.Sqrt(2.0);
	}

	internal static void _003FA0x49785d99_002E_003F_003F__E_003FA0x49785d99_0040RadToDeg_0040Math_0040HOLM_0040_0040YMXXZ()
	{
		HOLM_002EMath_002E_003FA0x49785d99_002ERadToDeg = 180.0 / HOLM_002EMath_002E_003FA0x49785d99_002EPI;
	}

	internal static void _003FA0x49785d99_002E_003F_003F__E_003FA0x49785d99_0040RadToDeg_F_0040Math_0040HOLM_0040_0040YMXXZ()
	{
		HOLM_002EMath_002E_003FA0x49785d99_002ERadToDeg_F = (float)(180.0 / (double)HOLM_002EMath_002E_003FA0x49785d99_002EPI_F);
	}

	internal static void _003FA0x49785d99_002E_003F_003F__E_003FA0x49785d99_0040DegToRad_0040Math_0040HOLM_0040_0040YMXXZ()
	{
		HOLM_002EMath_002E_003FA0x49785d99_002EDegToRad = HOLM_002EMath_002E_003FA0x49785d99_002EPI / 180.0;
	}

	internal static void _003FA0x49785d99_002E_003F_003F__E_003FA0x49785d99_0040DegToRad_F_0040Math_0040HOLM_0040_0040YMXXZ()
	{
		HOLM_002EMath_002E_003FA0x49785d99_002EDegToRad_F = HOLM_002EMath_002E_003FA0x49785d99_002EPI_F / 180f;
	}

	internal static void _003FA0x49785d99_002E_003F_003F__E_003FA0x49785d99_0040MILLISEC_TO_CM_0040Measure_0040HOLM_0040_0040YMXXZ()
	{
		HOLM_002EMeasure_002E_003FA0x49785d99_002EMILLISEC_TO_CM = HOLM_002EMeasure_002E_003FA0x49785d99_002ESEC_TO_CM / 1000.0;
	}

	internal static void _003FA0x49785d99_002E_003F_003F__E_003FA0x49785d99_0040MICROSEC_TO_CM_0040Measure_0040HOLM_0040_0040YMXXZ()
	{
		HOLM_002EMeasure_002E_003FA0x49785d99_002EMICROSEC_TO_CM = HOLM_002EMeasure_002E_003FA0x49785d99_002EMILLISEC_TO_CM / 1000.0;
	}

	internal unsafe static void HOLM_002EMeasure_002ESmoothingImpulseWindow_002ESetFrequency(SmoothingImpulseWindow* P_0, double freq_in)
	{
		*(double*)((byte*)P_0 + 8) = freq_in;
		HOLM_002EMeasure_002ESmoothingImpulseWindow_002EUpdateConstants(P_0);
	}

	internal unsafe static int HOLM_002EMeasure_002EMeasurementCore_002EGetSamplerate(MeasurementCore* P_0)
	{
		return *(int*)((byte*)P_0 + 64);
	}

	internal unsafe static double HOLM_002EMeasure_002EMeasurementCore_002EGetIFracOffset(MeasurementCore* P_0)
	{
		return *(double*)((byte*)P_0 + 400);
	}

	internal unsafe static int HOLM_002EMeasure_002EMeasurementCore_002EGetImpulseWindowEnd(MeasurementCore* P_0)
	{
		return *(int*)((byte*)P_0 + 84);
	}

	internal unsafe static int HOLM_002EMeasure_002EMeasurementCore_002EGetImpulseWindowEndDelta(MeasurementCore* P_0)
	{
		return *(int*)((byte*)P_0 + 96);
	}

	[return: MarshalAs(UnmanagedType.U1)]
	internal unsafe static bool HOLM_002EMeasure_002EMeasurementCore_002EGetImpulseWindowLockStart(MeasurementCore* P_0)
	{
		return ((byte*)P_0)[90] != 0;
	}

	internal unsafe static double HOLM_002EMeasure_002EMeasurementCore_002EGetSmoothNOct(MeasurementCore* P_0)
	{
		return *(double*)((byte*)P_0 + 264);
	}

	[return: MarshalAs(UnmanagedType.U1)]
	internal unsafe static bool HOLM_002EMeasure_002EMeasurementCore_002EGetImpulseWindowEnabled(MeasurementCore* P_0)
	{
		return HOLM_002EMeasure_002EConfigCtrl_002EGetEnabled((ConfigCtrl*)((byte*)P_0 + 136), (EnabledEnum)1);
	}

	[return: MarshalAs(UnmanagedType.U1)]
	internal unsafe static bool HOLM_002EMeasure_002EMeasurementCore_002EGetSmoothingEnabled(MeasurementCore* P_0)
	{
		return HOLM_002EMeasure_002EConfigCtrl_002EGetEnabled((ConfigCtrl*)((byte*)P_0 + 136), (EnabledEnum)2);
	}

	[return: MarshalAs(UnmanagedType.U1)]
	internal unsafe static bool HOLM_002EMeasure_002EMeasurementCore_002EGetSmoothingComplex(MeasurementCore* P_0)
	{
		return HOLM_002EMeasure_002EConfigCtrl_002EGetEnabled((ConfigCtrl*)((byte*)P_0 + 136), (EnabledEnum)3);
	}

	internal unsafe static SignalType HOLM_002EMeasure_002EMeasurementCore_002EGetSignalType(MeasurementCore* P_0)
	{
		return *(SignalType*)((byte*)P_0 + 176);
	}

	internal unsafe static double HOLM_002EMeasure_002EMeasurementCore_002EGetSignalTypeFactor1(MeasurementCore* P_0)
	{
		return *(double*)((byte*)P_0 + 184);
	}

	internal static Color HOLM_002EMeasureGraphics_002EBrighter(Color color)
	{
		int num = color.ToArgb();
		int num2 = ((num >> 16) & 0xFF) << 1;
		int num3 = ((num >> 8) & 0xFF) << 1;
		int num4 = (num & 0xFF) << 1;
		int num5 = ((num2 > 255) ? (num2 - 255) : 0);
		int num6 = ((num3 > 255) ? (num3 - 255) : 0);
		int num7 = ((num4 > 255) ? (num4 - 255) : 0) + num6 + num5;
		if (num7 > 0)
		{
			int num8 = num7 / 2;
			num2 = num8 + num2;
			num3 = num8 + num3;
			num4 = num8 + num4;
		}
		if (num2 > 255)
		{
			num2 = 255;
		}
		if (num3 > 255)
		{
			num3 = 255;
		}
		if (num4 > 255)
		{
			num4 = 255;
		}
		return Color.FromArgb(num2, num3, num4);
	}

	internal unsafe static vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E* std_002Evector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E_002E_007Bctor_007D(vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E* P_0)
	{
		void* ptr = @new(4u);
		_Aux_cont* ptr2 = (_Aux_cont*)ptr;
		_Aux_cont* ptr3;
		try
		{
			if (ptr != null)
			{
				*(int*)ptr = (int)P_0;
				ptr3 = (_Aux_cont*)ptr;
			}
			else
			{
				ptr3 = null;
			}
		}
		catch
		{
			//try-fault
			delete(ptr2, ptr);
			throw;
		}
		*(int*)P_0 = (int)ptr3;
		try
		{
			*(int*)((byte*)P_0 + 12) = 0;
			*(int*)((byte*)P_0 + 16) = 0;
			*(int*)((byte*)P_0 + 20) = 0;
			return P_0;
		}
		catch
		{
			//try-fault
			___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<_Vector_val_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E*, void>)(&std_002E_Vector_val_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E_002E_007Bdtor_007D), P_0);
			throw;
		}
	}

	internal unsafe static void std_002Evector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E_002Epush_back(vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E* P_0, int* _Val)
	{
		uint num = *(uint*)((byte*)P_0 + 12);
		int num2 = ((num != 0) ? (*(int*)((byte*)P_0 + 20) - (int)num >> 2) : 0);
		int num3 = *(int*)((byte*)P_0 + 16);
		if ((uint)(num3 - (int)num >> 2) < (uint)num2)
		{
			int* ptr = (int*)num3;
			*ptr = *_Val;
			*(int*)((byte*)P_0 + 16) = (int)(ptr + 1);
			return;
		}
		int* ptr2 = (int*)num3;
		if ((nuint)(int)num > (nuint)ptr2)
		{
			_invalid_parameter_noinfo();
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _Vector_iterator_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E obj);
		*(int*)(&obj) = *(int*)P_0;
		System.Runtime.CompilerServices.Unsafe.As<_Vector_iterator_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 4)) = (int)ptr2;
		_Vector_const_iterator_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E where = (_Vector_const_iterator_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E)obj;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _Vector_iterator_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E obj2);
		std_002Evector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E_002Einsert(P_0, &obj2, where, _Val);
	}

	internal unsafe static _Vector_iterator_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E* std_002Evector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E_002Einsert(vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E* P_0, _Vector_iterator_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E* P_1, _Vector_const_iterator_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E _Where, int* _Val)
	{
		int num = *(int*)((byte*)P_0 + 16);
		int num2 = *(int*)((byte*)P_0 + 12);
		int off;
		if (((num - num2) & -4) == 0)
		{
			off = 0;
		}
		else
		{
			int* ptr = (int*)num2;
			if ((nuint)ptr > (nuint)num)
			{
				_invalid_parameter_noinfo();
			}
			System.Runtime.CompilerServices.Unsafe.SkipInit(out _Vector_iterator_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E obj);
			*(int*)(&obj) = *(int*)P_0;
			if ((byte)((*(int*)(&_Where) != 0) ? 1 : 0) == 0 || !(*(int*)(&_Where) == *(int*)(&obj)))
			{
				_invalid_parameter_noinfo();
			}
			off = (int)((nint)System.Runtime.CompilerServices.Unsafe.As<_Vector_const_iterator_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref _Where, 4)) - (nint)ptr >> 2);
		}
		std_002Evector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E_002E_Insert_n(P_0, _Where, 1u, _Val);
		int* ptr2 = (int*)(int)(*(uint*)((byte*)P_0 + 12));
		if ((nuint)ptr2 > (nuint)(*(int*)((byte*)P_0 + 16)))
		{
			_invalid_parameter_noinfo();
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _Vector_iterator_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E obj2);
		*(int*)(&obj2) = *(int*)P_0;
		System.Runtime.CompilerServices.Unsafe.As<_Vector_iterator_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj2, 4)) = (int)ptr2;
		_Vector_iterator_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E obj3 = obj2;
		std_002E_Vector_const_iterator_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E_002E_002B_003D((_Vector_const_iterator_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E*)(&obj3), off);
		// IL cpblk instruction
		System.Runtime.CompilerServices.Unsafe.CopyBlock(P_1, ref obj3, 8);
		return P_1;
	}

	internal unsafe static int* std_002Evector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E_002E_Ufill(vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E* P_0, int* _Ptr, uint _Count, int* _Val)
	{
		uint num = _Count;
		int* ptr = _Ptr;
		if (0 < _Count)
		{
			do
			{
				*ptr = *_Val;
				num--;
				ptr++;
			}
			while (num != 0);
		}
		return (int*)((int)(_Count * 4) + (byte*)_Ptr);
	}

	internal unsafe static basic_ostream_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_0020_003E.sentry* std_002Ebasic_ostream_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_0020_003E_002Esentry_002E_007Bctor_007D(basic_ostream_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_0020_003E.sentry* P_0, basic_ostream_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_0020_003E* _Ostr)
	{
		*(int*)P_0 = (int)_Ostr;
		if (std_002Ebasic_ios_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_0020_003E_002Erdbuf((basic_ios_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_0020_003E*)(*(int*)(*(int*)_Ostr + 4) + (byte*)_Ostr)) != null)
		{
			int num = *(int*)P_0;
			std_002Ebasic_streambuf_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_0020_003E_002E_Lock(std_002Ebasic_ios_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_0020_003E_002Erdbuf((basic_ios_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_0020_003E*)(*(int*)(*(int*)num + 4) + num)));
		}
		try
		{
			if (std_002Eios_base_002Egood((ios_base*)(*(int*)(*(int*)_Ostr + 4) + (byte*)_Ostr)) && std_002Ebasic_ios_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_0020_003E_002Etie((basic_ios_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_0020_003E*)(*(int*)(*(int*)_Ostr + 4) + (byte*)_Ostr)) != null)
			{
				std_002Ebasic_ostream_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_0020_003E_002Eflush(std_002Ebasic_ios_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_0020_003E_002Etie((basic_ios_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_0020_003E*)(*(int*)(*(int*)_Ostr + 4) + (byte*)_Ostr)));
			}
			((byte*)P_0)[4] = (std_002Eios_base_002Egood((ios_base*)(*(int*)(*(int*)_Ostr + 4) + (byte*)_Ostr)) ? ((byte)1) : ((byte)0));
			return P_0;
		}
		catch
		{
			//try-fault
			___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_ostream_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_0020_003E._Sentry_base*, void>)(&std_002Ebasic_ostream_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_0020_003E_002E_Sentry_base_002E_007Bdtor_007D), P_0);
			throw;
		}
	}

	internal unsafe static void std_002Ebasic_ostream_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_0020_003E_002Esentry_002E_007Bdtor_007D(basic_ostream_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_0020_003E.sentry* P_0)
	{
		try
		{
			if (!std_002Euncaught_exception())
			{
				std_002Ebasic_ostream_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_0020_003E_002E_Osfx((basic_ostream_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_0020_003E*)(int)(*(uint*)P_0));
			}
		}
		catch
		{
			//try-fault
			___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_ostream_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_0020_003E._Sentry_base*, void>)(&std_002Ebasic_ostream_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_0020_003E_002E_Sentry_base_002E_007Bdtor_007D), P_0);
			throw;
		}
		int num = *(int*)P_0;
		if (std_002Ebasic_ios_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_0020_003E_002Erdbuf((basic_ios_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_0020_003E*)(*(int*)(*(int*)num + 4) + num)) != null)
		{
			num = *(int*)P_0;
			std_002Ebasic_streambuf_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_0020_003E_002E_Unlock(std_002Ebasic_ios_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_0020_003E_002Erdbuf((basic_ios_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_0020_003E*)(*(int*)(*(int*)num + 4) + num)));
		}
	}

	internal unsafe static int* std_002Eallocator_003Cint_003E_002Eallocate(allocator_003Cint_003E* P_0, uint _Count)
	{
		uint num = _Count;
		if (_Count == 0)
		{
			num = 0u;
		}
		else if (uint.MaxValue / _Count < 4)
		{
			sbyte* ptr = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out bad_alloc bad_alloc);
			std_002Eexception_002E_007Bctor_007D((exception*)(&bad_alloc), &ptr);
			try
			{
				*(int*)(&bad_alloc) = (int)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_7bad_alloc_0040std_0040_00406B_0040);
			}
			catch
			{
				//try-fault
				___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<exception*, void>)(&std_002Eexception_002E_007Bdtor_007D), &bad_alloc);
				throw;
			}
			_CxxThrowException(&bad_alloc, (_s__ThrowInfo*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _TI2_003FAVbad_alloc_0040std_0040_0040));
		}
		return (int*)@new(num << 2);
	}

	internal unsafe static void std_002Evector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E_002E_Insert_n(vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E* P_0, _Vector_const_iterator_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E _Where, uint _Count, int* _Val)
	{
		int num = (int)stackalloc byte[__CxxQueryExceptionSize()];
		uint num2 = *(uint*)((byte*)P_0 + 12);
		int num3 = ((num2 != 0) ? (*(int*)((byte*)P_0 + 20) - (int)num2 >> 2) : 0);
		if (_Count == 0)
		{
			return;
		}
		int num4 = *(int*)((byte*)P_0 + 16);
		int num5 = num4 - (int)num2 >> 2;
		if ((uint)(1073741823 - num5) < _Count)
		{
			std_002Evector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E_002E_Xlen();
		}
		if ((uint)num3 < (uint)((int)_Count + num5))
		{
			uint num6 = (uint)num3 >> 1;
			uint num7 = ((1073741823 - num6 >= (uint)num3) ? (num6 + (uint)num3) : 0u);
			uint num8 = num7;
			if (num7 < (uint)((int)_Count + num5))
			{
				num8 = _Count + (uint)num5;
			}
			int* ptr = std_002Eallocator_003Cint_003E_002Eallocate((allocator_003Cint_003E*)((byte*)P_0 + 8), num8);
			uint num9 = (uint)(System.Runtime.CompilerServices.Unsafe.As<_Vector_const_iterator_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref _Where, 4)) - *(int*)((byte*)P_0 + 12) >> 2);
			int num10 = 0;
			try
			{
				std_002Evector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E_002E_Ufill(P_0, (int*)((int)(num9 * 4) + (byte*)ptr), _Count, _Val);
				num10 = 1;
				std_002Evector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E_002E_Umove_003Cint_0020_002A_003E(P_0, (int*)(int)(*(uint*)((byte*)P_0 + 12)), (int*)(int)System.Runtime.CompilerServices.Unsafe.As<_Vector_const_iterator_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E, uint>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref _Where, 4)), ptr);
				num10 = 2;
				std_002Evector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E_002E_Umove_003Cint_0020_002A_003E(P_0, (int*)(int)System.Runtime.CompilerServices.Unsafe.As<_Vector_const_iterator_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E, uint>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref _Where, 4)), (int*)(int)(*(uint*)((byte*)P_0 + 16)), (int*)((int)((num9 + _Count) * 4) + (byte*)ptr));
			}
			catch when (((Func<bool>)delegate
			{
				// Could not convert BlockContainer to single expression
				uint exceptionCode = (uint)Marshal.GetExceptionCode();
				return (byte)__CxxExceptionFilter((void*)Marshal.GetExceptionPointers(), null, 0, null) != 0;
			}).Invoke())
			{
				uint num11 = 0u;
				__CxxRegisterExceptionObject((void*)Marshal.GetExceptionPointers(), (void*)num);
				try
				{
					try
					{
						if (1 < num10)
						{
						}
						if (0 < num10)
						{
						}
						std_002Eallocator_003Cint_003E_002Edeallocate((allocator_003Cint_003E*)((byte*)P_0 + 8), ptr, num8);
						_CxxThrowException(null, null);
					}
					catch when (((Func<bool>)delegate
					{
						// Could not convert BlockContainer to single expression
						num11 = (uint)__CxxDetectRethrow((void*)Marshal.GetExceptionPointers());
						return (byte)num11 != 0;
					}).Invoke())
					{
					}
					if (num11 != 0)
					{
						throw;
					}
				}
				finally
				{
					__CxxUnregisterExceptionObject((void*)num, (int)num11);
				}
			}
			num2 = *(uint*)((byte*)P_0 + 12);
			_Count = (uint)(*(int*)((byte*)P_0 + 16) - (int)num2 >> 2) + _Count;
			if (num2 != 0)
			{
				delete((void*)(int)num2);
			}
			*(int*)((byte*)P_0 + 20) = (int)((int)(num8 * 4) + (byte*)ptr);
			*(int*)((byte*)P_0 + 16) = (int)((int)(_Count * 4) + (byte*)ptr);
			*(int*)((byte*)P_0 + 12) = (int)ptr;
			return;
		}
		if ((uint)(num4 - System.Runtime.CompilerServices.Unsafe.As<_Vector_const_iterator_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref _Where, 4)) >> 2) < _Count)
		{
			int num12 = *_Val;
			std_002Evector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E_002E_Umove_003Cint_0020_002A_003E(P_0, (int*)(int)System.Runtime.CompilerServices.Unsafe.As<_Vector_const_iterator_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E, uint>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref _Where, 4)), (int*)num4, (int*)(int)(_Count * 4 + (uint)System.Runtime.CompilerServices.Unsafe.As<_Vector_const_iterator_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref _Where, 4))));
			try
			{
				num4 = *(int*)((byte*)P_0 + 16);
				std_002Evector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E_002E_Ufill(P_0, (int*)num4, _Count - (uint)(num4 - System.Runtime.CompilerServices.Unsafe.As<_Vector_const_iterator_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref _Where, 4)) >> 2), &num12);
			}
			catch when (((Func<bool>)delegate
			{
				// Could not convert BlockContainer to single expression
				uint exceptionCode = (uint)Marshal.GetExceptionCode();
				return (byte)__CxxExceptionFilter((void*)Marshal.GetExceptionPointers(), null, 0, null) != 0;
			}).Invoke())
			{
				uint num11 = 0u;
				__CxxRegisterExceptionObject((void*)Marshal.GetExceptionPointers(), (void*)num);
				try
				{
					try
					{
						_CxxThrowException(null, null);
					}
					catch when (((Func<bool>)delegate
					{
						// Could not convert BlockContainer to single expression
						num11 = (uint)__CxxDetectRethrow((void*)Marshal.GetExceptionPointers());
						return (byte)num11 != 0;
					}).Invoke())
					{
					}
					if (num11 != 0)
					{
						throw;
					}
				}
				finally
				{
					__CxxUnregisterExceptionObject((void*)num, (int)num11);
				}
			}
			int num13 = (int)(_Count * 4);
			*(int*)((byte*)P_0 + 16) += num13;
			int* ptr2 = (int*)(*(int*)((byte*)P_0 + 16) - num13);
			int* ptr3 = (int*)(int)System.Runtime.CompilerServices.Unsafe.As<_Vector_const_iterator_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E, uint>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref _Where, 4));
			if ((int*)System.Runtime.CompilerServices.Unsafe.As<_Vector_const_iterator_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref _Where, 4)) != ptr2)
			{
				do
				{
					*ptr3 = num12;
					ptr3++;
				}
				while (ptr3 != ptr2);
			}
			return;
		}
		int num14 = *_Val;
		int* ptr4 = (int*)num4;
		int num15 = (int)(_Count * 4);
		int* ptr5 = (int*)((byte*)ptr4 - num15);
		*(int*)((byte*)P_0 + 16) = (int)std_002Evector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E_002E_Umove_003Cint_0020_002A_003E(P_0, ptr5, ptr4, (int*)num4);
		stdext_002E_Unchecked_move_backward_003Cint_0020_002A_002Cint_0020_002A_003E((int*)(int)System.Runtime.CompilerServices.Unsafe.As<_Vector_const_iterator_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E, uint>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref _Where, 4)), ptr5, ptr4);
		int* ptr6 = (int*)(num15 + System.Runtime.CompilerServices.Unsafe.As<_Vector_const_iterator_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref _Where, 4)));
		int* ptr7 = (int*)(int)System.Runtime.CompilerServices.Unsafe.As<_Vector_const_iterator_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E, uint>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref _Where, 4));
		if ((int*)System.Runtime.CompilerServices.Unsafe.As<_Vector_const_iterator_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E, int>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref _Where, 4)) != ptr6)
		{
			do
			{
				*ptr7 = num14;
				ptr7++;
			}
			while (ptr7 != ptr6);
		}
	}

	internal unsafe static void std_002Evector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E_002E_Xlen()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj);
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D(&obj, (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_0BD_0040OLBABOEK_0040vector_003F_0024DMT_003F_0024DO_003F5too_003F5long_003F_0024AA_0040));
		try
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out length_error length_error);
			std_002Eexception_002E_007Bctor_007D((exception*)(&length_error));
			try
			{
				*(int*)(&length_error) = (int)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_7logic_error_0040std_0040_00406B_0040);
				std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref length_error, 12)), &obj);
			}
			catch
			{
				//try-fault
				___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<exception*, void>)(&std_002Eexception_002E_007Bdtor_007D), &length_error);
				throw;
			}
			try
			{
				*(int*)(&length_error) = (int)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_7length_error_0040std_0040_00406B_0040);
			}
			catch
			{
				//try-fault
				___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<logic_error*, void>)(&std_002Elogic_error_002E_007Bdtor_007D), &length_error);
				throw;
			}
			_CxxThrowException(&length_error, (_s__ThrowInfo*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _TI3_003FAVlength_error_0040std_0040_0040));
			return;
		}
		catch
		{
			//try-fault
			___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), &obj);
			throw;
		}
	}

	internal unsafe static void std_002Ebasic_ostream_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_0020_003E_002E_Sentry_base_002E_007Bdtor_007D(basic_ostream_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_0020_003E._Sentry_base* P_0)
	{
		int num = *(int*)P_0;
		if (std_002Ebasic_ios_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_0020_003E_002Erdbuf((basic_ios_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_0020_003E*)(*(int*)(*(int*)num + 4) + num)) != null)
		{
			num = *(int*)P_0;
			std_002Ebasic_streambuf_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_0020_003E_002E_Unlock(std_002Ebasic_ios_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_0020_003E_002Erdbuf((basic_ios_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_0020_003E*)(*(int*)(*(int*)num + 4) + num)));
		}
	}

	internal unsafe static _Vector_const_iterator_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E* std_002E_Vector_const_iterator_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E_002E_002B_003D(_Vector_const_iterator_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E* P_0, int _Off)
	{
		if ((byte)((*(int*)P_0 != 0) ? 1 : 0) == 0)
		{
			_invalid_parameter_noinfo();
		}
		uint num = *(uint*)P_0;
		_Container_base_aux* ptr = (_Container_base_aux*)((num == 0) ? 0 : ((int)(*(uint*)(int)num)));
		uint num2 = (uint)(_Off * 4);
		uint num3 = (uint)(*(int*)((byte*)P_0 + 4)) + num2;
		if (num3 <= (uint)(*(int*)((byte*)ptr + 16)))
		{
			_Container_base_aux* ptr2 = (_Container_base_aux*)((num == 0) ? 0 : ((int)(*(uint*)(int)num)));
			if (num3 >= (uint)(*(int*)((byte*)ptr2 + 12)))
			{
				goto IL_004b;
			}
		}
		_invalid_parameter_noinfo();
		goto IL_004b;
		IL_004b:
		*(int*)((byte*)P_0 + 4) += (int)num2;
		return P_0;
	}

	internal unsafe static ctype_003Cwchar_t_003E* std_002Euse_facet_003Cclass_0020std_003A_003Actype_003Cwchar_t_003E_0020_003E(locale* _Loc)
	{
		bool flag = false;
		int num = 0;
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
			RuntimeHelpers.PrepareConstrainedRegions();
			try
			{
			}
			finally
			{
				std_002E_Lockit_002E_Lockit_ctor(num);
				flag = true;
			}
			locale.facet* ptr = _003F_Psave_0040_003F_0024_Facetptr_0040V_003F_0024ctype_0040_W_0040std_0040_0040_0040std_0040_00402PBVfacet_0040locale_00402_0040B;
			uint num2 = std_002Elocale_002Eid_002E_002EI((locale.id*)(int)System.Runtime.CompilerServices.Unsafe.As<locale.id*, uint>(ref __imp__003Fid_0040_003F_0024ctype_0040_W_0040std_0040_00402V0locale_00402_0040A));
			locale.facet* ptr2 = std_002Elocale_002E_Getfacet(_Loc, num2);
			if (ptr2 == null)
			{
				if (ptr != null)
				{
					ptr2 = ptr;
				}
				else
				{
					if (std_002Ectype_003Cwchar_t_003E_002E_Getcat(&ptr, _Loc) == uint.MaxValue)
					{
						System.Runtime.CompilerServices.Unsafe.SkipInit(out bad_cast bad_cast);
						std_002Ebad_cast_002E_007Bctor_007D(&bad_cast, (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_08EPJLHIJG_0040bad_003F5cast_003F_0024AA_0040));
						_CxxThrowException(&bad_cast, (_s__ThrowInfo*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _TI2_003FAVbad_cast_0040std_0040_0040));
					}
					ptr2 = ptr;
					_003F_Psave_0040_003F_0024_Facetptr_0040V_003F_0024ctype_0040_W_0040std_0040_0040_0040std_0040_00402PBVfacet_0040locale_00402_0040B = ptr;
					locale.facet* intPtr = ptr;
					std_002Elocale_002Efacet_002E_Incref(ptr);
					std_002Elocale_002Efacet_002E_Register(intPtr);
				}
			}
			return (ctype_003Cwchar_t_003E*)ptr2;
		}
		finally
		{
			if (flag)
			{
				std_002E_Lockit_002E_Lockit_dtor(num);
			}
		}
	}

	internal unsafe static basic_ostream_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_0020_003E* std_002Eoperator_003C_003C_003Cwchar_t_002Cstruct_0020std_003A_003Achar_traits_003Cwchar_t_003E_0020_003E(basic_ostream_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_0020_003E* _Ostr, char* _Val)
	{
		int num = (int)stackalloc byte[__CxxQueryExceptionSize()];
		int num2 = 0;
		int num3 = (int)std_002Echar_traits_003Cwchar_t_003E_002Elength(_Val);
		int num4 = ((std_002Eios_base_002Ewidth((ios_base*)(*(int*)(*(int*)_Ostr + 4) + (byte*)_Ostr)) > 0 && std_002Eios_base_002Ewidth((ios_base*)(*(int*)(*(int*)_Ostr + 4) + (byte*)_Ostr)) > num3) ? (std_002Eios_base_002Ewidth((ios_base*)(*(int*)(*(int*)_Ostr + 4) + (byte*)_Ostr)) - num3) : 0);
		int num5 = num4;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_ostream_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_0020_003E.sentry sentry);
		std_002Ebasic_ostream_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_0020_003E_002Esentry_002E_007Bctor_007D(&sentry, _Ostr);
		try
		{
			if (System.Runtime.CompilerServices.Unsafe.As<basic_ostream_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_0020_003E.sentry, byte>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref sentry, 4)) == 0)
			{
				num2 = 4;
			}
			else
			{
				try
				{
					if ((std_002Eios_base_002Eflags((ios_base*)(*(int*)(*(int*)_Ostr + 4) + (byte*)_Ostr)) & 0x1C0) != 64)
					{
						while (0 < num5)
						{
							ushort num6 = std_002Ebasic_streambuf_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_0020_003E_002Esputc(std_002Ebasic_ios_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_0020_003E_002Erdbuf((basic_ios_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_0020_003E*)(*(int*)(*(int*)_Ostr + 4) + (byte*)_Ostr)), std_002Ebasic_ios_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_0020_003E_002Efill((basic_ios_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_0020_003E*)(*(int*)(*(int*)_Ostr + 4) + (byte*)_Ostr)));
							ushort num7 = ushort.MaxValue;
							if (std_002Echar_traits_003Cwchar_t_003E_002Eeq_int_type(&num7, &num6))
							{
								num2 |= 4;
								break;
							}
							num5--;
						}
						if (num2 != 0)
						{
							goto IL_0117;
						}
					}
					if (std_002Ebasic_streambuf_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_0020_003E_002Esputn(std_002Ebasic_ios_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_0020_003E_002Erdbuf((basic_ios_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_0020_003E*)(*(int*)(*(int*)_Ostr + 4) + (byte*)_Ostr)), _Val, num3) != num3)
					{
						num2 = 4;
					}
					else
					{
						while (0 < num5)
						{
							ushort num8 = std_002Ebasic_streambuf_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_0020_003E_002Esputc(std_002Ebasic_ios_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_0020_003E_002Erdbuf((basic_ios_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_0020_003E*)(*(int*)(*(int*)_Ostr + 4) + (byte*)_Ostr)), std_002Ebasic_ios_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_0020_003E_002Efill((basic_ios_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_0020_003E*)(*(int*)(*(int*)_Ostr + 4) + (byte*)_Ostr)));
							ushort num9 = ushort.MaxValue;
							if (std_002Echar_traits_003Cwchar_t_003E_002Eeq_int_type(&num9, &num8))
							{
								num2 |= 4;
								break;
							}
							num5--;
						}
					}
					goto IL_0117;
					IL_0117:
					std_002Eios_base_002Ewidth((ios_base*)(*(int*)(*(int*)_Ostr + 4) + (byte*)_Ostr), 0);
				}
				catch when (((Func<bool>)delegate
				{
					// Could not convert BlockContainer to single expression
					uint exceptionCode = (uint)Marshal.GetExceptionCode();
					return (byte)__CxxExceptionFilter((void*)Marshal.GetExceptionPointers(), null, 0, null) != 0;
				}).Invoke())
				{
					uint num10 = 0u;
					__CxxRegisterExceptionObject((void*)Marshal.GetExceptionPointers(), (void*)num);
					try
					{
						try
						{
							std_002Ebasic_ios_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_0020_003E_002Esetstate((basic_ios_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_0020_003E*)(*(int*)(*(int*)_Ostr + 4) + (byte*)_Ostr), 4, true);
							goto end_IL_014e;
						}
						catch when (((Func<bool>)delegate
						{
							// Could not convert BlockContainer to single expression
							num10 = (uint)__CxxDetectRethrow((void*)Marshal.GetExceptionPointers());
							return (byte)num10 != 0;
						}).Invoke())
						{
						}
						if (num10 != 0)
						{
							throw;
						}
						end_IL_014e:;
					}
					finally
					{
						__CxxUnregisterExceptionObject((void*)num, (int)num10);
					}
				}
			}
			std_002Ebasic_ios_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_0020_003E_002Esetstate((basic_ios_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_0020_003E*)(*(int*)(*(int*)_Ostr + 4) + (byte*)_Ostr), num2, false);
		}
		catch
		{
			//try-fault
			___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_ostream_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_0020_003E.sentry*, void>)(&std_002Ebasic_ostream_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_0020_003E_002Esentry_002E_007Bdtor_007D), &sentry);
			throw;
		}
		try
		{
			if (!std_002Euncaught_exception())
			{
				std_002Ebasic_ostream_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_0020_003E_002E_Osfx((basic_ostream_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_0020_003E*)(int)(*(uint*)(&sentry)));
			}
		}
		catch
		{
			//try-fault
			___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_ostream_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_0020_003E._Sentry_base*, void>)(&std_002Ebasic_ostream_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_0020_003E_002E_Sentry_base_002E_007Bdtor_007D), &sentry);
			throw;
		}
		if (std_002Ebasic_ios_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_0020_003E_002Erdbuf((basic_ios_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_0020_003E*)(*(int*)(*(int*)(int)(*(uint*)(&sentry)) + 4) + *(int*)(&sentry))) != null)
		{
			std_002Ebasic_streambuf_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_0020_003E_002E_Unlock(std_002Ebasic_ios_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_0020_003E_002Erdbuf((basic_ios_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_0020_003E*)(*(int*)(*(int*)(int)(*(uint*)(&sentry)) + 4) + *(int*)(&sentry))));
		}
		return _Ostr;
	}

	internal unsafe static basic_ostream_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_0020_003E* std_002Eoperator_003C_003C_003Cwchar_t_002Cstruct_0020std_003A_003Achar_traits_003Cwchar_t_003E_0020_003E(basic_ostream_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_0020_003E* _Ostr, sbyte* _Val)
	{
		int num = (int)stackalloc byte[__CxxQueryExceptionSize()];
		int num2 = 0;
		sbyte* ptr = _Val;
		if (*_Val != 0)
		{
			do
			{
				ptr++;
			}
			while (*ptr != 0);
		}
		int num3 = (int)(ptr - (nuint)_Val);
		int num4 = ((std_002Eios_base_002Ewidth((ios_base*)(*(int*)(*(int*)_Ostr + 4) + (byte*)_Ostr)) > 0 && std_002Eios_base_002Ewidth((ios_base*)(*(int*)(*(int*)_Ostr + 4) + (byte*)_Ostr)) > num3) ? (std_002Eios_base_002Ewidth((ios_base*)(*(int*)(*(int*)_Ostr + 4) + (byte*)_Ostr)) - num3) : 0);
		int num5 = num4;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_ostream_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_0020_003E.sentry sentry);
		std_002Ebasic_ostream_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_0020_003E_002Esentry_002E_007Bctor_007D(&sentry, _Ostr);
		try
		{
			if (System.Runtime.CompilerServices.Unsafe.As<basic_ostream_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_0020_003E.sentry, byte>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref sentry, 4)) == 0)
			{
				num2 = 4;
			}
			else
			{
				try
				{
					System.Runtime.CompilerServices.Unsafe.SkipInit(out locale locale);
					locale* loc = std_002Eios_base_002Egetloc((ios_base*)(*(int*)(*(int*)_Ostr + 4) + (byte*)_Ostr), &locale);
					ctype_003Cwchar_t_003E* ptr2;
					try
					{
						ptr2 = std_002Euse_facet_003Cclass_0020std_003A_003Actype_003Cwchar_t_003E_0020_003E(loc);
					}
					catch
					{
						//try-fault
						___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<locale*, void>)(&std_002Elocale_002E_007Bdtor_007D), &locale);
						throw;
					}
					std_002Elocale_002E_007Bdtor_007D(&locale);
					if ((std_002Eios_base_002Eflags((ios_base*)(*(int*)(*(int*)_Ostr + 4) + (byte*)_Ostr)) & 0x1C0) != 64)
					{
						while (0 < num5)
						{
							ushort num6 = std_002Ebasic_streambuf_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_0020_003E_002Esputc(std_002Ebasic_ios_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_0020_003E_002Erdbuf((basic_ios_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_0020_003E*)(*(int*)(*(int*)_Ostr + 4) + (byte*)_Ostr)), std_002Ebasic_ios_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_0020_003E_002Efill((basic_ios_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_0020_003E*)(*(int*)(*(int*)_Ostr + 4) + (byte*)_Ostr)));
							ushort num7 = ushort.MaxValue;
							if (std_002Echar_traits_003Cwchar_t_003E_002Eeq_int_type(&num7, &num6))
							{
								num2 |= 4;
								break;
							}
							num5--;
						}
					}
					while (num2 == 0)
					{
						if (0 < num3)
						{
							ushort num8 = std_002Ebasic_streambuf_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_0020_003E_002Esputc(std_002Ebasic_ios_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_0020_003E_002Erdbuf((basic_ios_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_0020_003E*)(*(int*)(*(int*)_Ostr + 4) + (byte*)_Ostr)), std_002Ectype_003Cwchar_t_003E_002Ewiden(ptr2, *_Val));
							ushort num9 = ushort.MaxValue;
							if (std_002Echar_traits_003Cwchar_t_003E_002Eeq_int_type(&num9, &num8))
							{
								num2 = 4;
							}
							num3--;
							_Val++;
							continue;
						}
						while (0 < num5)
						{
							ushort num10 = std_002Ebasic_streambuf_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_0020_003E_002Esputc(std_002Ebasic_ios_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_0020_003E_002Erdbuf((basic_ios_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_0020_003E*)(*(int*)(*(int*)_Ostr + 4) + (byte*)_Ostr)), std_002Ebasic_ios_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_0020_003E_002Efill((basic_ios_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_0020_003E*)(*(int*)(*(int*)_Ostr + 4) + (byte*)_Ostr)));
							ushort num11 = ushort.MaxValue;
							if (std_002Echar_traits_003Cwchar_t_003E_002Eeq_int_type(&num11, &num10))
							{
								num2 |= 4;
								break;
							}
							num5--;
						}
						break;
					}
					std_002Eios_base_002Ewidth((ios_base*)(*(int*)(*(int*)_Ostr + 4) + (byte*)_Ostr), 0);
				}
				catch when (((Func<bool>)delegate
				{
					// Could not convert BlockContainer to single expression
					uint exceptionCode = (uint)Marshal.GetExceptionCode();
					return (byte)__CxxExceptionFilter((void*)Marshal.GetExceptionPointers(), null, 0, null) != 0;
				}).Invoke())
				{
					uint num12 = 0u;
					__CxxRegisterExceptionObject((void*)Marshal.GetExceptionPointers(), (void*)num);
					try
					{
						try
						{
							std_002Ebasic_ios_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_0020_003E_002Esetstate((basic_ios_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_0020_003E*)(*(int*)(*(int*)_Ostr + 4) + (byte*)_Ostr), 4, true);
							goto end_IL_01b6;
						}
						catch when (((Func<bool>)delegate
						{
							// Could not convert BlockContainer to single expression
							num12 = (uint)__CxxDetectRethrow((void*)Marshal.GetExceptionPointers());
							return (byte)num12 != 0;
						}).Invoke())
						{
						}
						if (num12 != 0)
						{
							throw;
						}
						end_IL_01b6:;
					}
					finally
					{
						__CxxUnregisterExceptionObject((void*)num, (int)num12);
					}
				}
			}
			std_002Ebasic_ios_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_0020_003E_002Esetstate((basic_ios_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_0020_003E*)(*(int*)(*(int*)_Ostr + 4) + (byte*)_Ostr), num2, false);
		}
		catch
		{
			//try-fault
			___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_ostream_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_0020_003E.sentry*, void>)(&std_002Ebasic_ostream_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_0020_003E_002Esentry_002E_007Bdtor_007D), &sentry);
			throw;
		}
		try
		{
			if (!std_002Euncaught_exception())
			{
				std_002Ebasic_ostream_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_0020_003E_002E_Osfx((basic_ostream_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_0020_003E*)(int)(*(uint*)(&sentry)));
			}
		}
		catch
		{
			//try-fault
			___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_ostream_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_0020_003E._Sentry_base*, void>)(&std_002Ebasic_ostream_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_0020_003E_002E_Sentry_base_002E_007Bdtor_007D), &sentry);
			throw;
		}
		if (std_002Ebasic_ios_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_0020_003E_002Erdbuf((basic_ios_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_0020_003E*)(*(int*)(*(int*)(int)(*(uint*)(&sentry)) + 4) + *(int*)(&sentry))) != null)
		{
			std_002Ebasic_streambuf_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_0020_003E_002E_Unlock(std_002Ebasic_ios_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_0020_003E_002Erdbuf((basic_ios_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_0020_003E*)(*(int*)(*(int*)(int)(*(uint*)(&sentry)) + 4) + *(int*)(&sentry))));
		}
		return _Ostr;
	}

	internal unsafe static int* std_002Evector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E_002E_Umove_003Cint_0020_002A_003E(vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E* P_0, int* _First, int* _Last, int* _Ptr)
	{
		uint num = (uint)((nint)((byte*)_Last - (nuint)_First) >> 2);
		int num2 = (int)(num * 4);
		byte* result = num2 + (byte*)_Ptr;
		if (num != 0)
		{
			memmove_s(_Ptr, (uint)num2, _First, (uint)num2);
		}
		return (int*)result;
	}

	internal unsafe static int* stdext_002E_Unchecked_move_backward_003Cint_0020_002A_002Cint_0020_002A_003E(int* _First, int* _Last, int* _Dest)
	{
		int num = (int)((nint)((byte*)_Last - (nuint)_First) >> 2);
		int num2 = num * 4;
		int* ptr = (int*)((byte*)_Dest - num2);
		if (num > 0)
		{
			memmove_s(ptr, (uint)num2, _First, (uint)num2);
		}
		return ptr;
	}

	internal unsafe static void _003FA0xdb52cc09_002E_003F_003F__E_003FA0xdb52cc09_0040HEXSTRINGARRAY_0040MiscHelper_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EMiscHelper_002E_003FA0xdb52cc09_002EHEXSTRINGARRAY), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01GBGANLPD_00400_003F_0024AA_0040));
		try
		{
			std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0xdb52cc09_002EHEXSTRINGARRAY, 28)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01HIHLOKLC_00401_003F_0024AA_0040));
			try
			{
				std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0xdb52cc09_002EHEXSTRINGARRAY, 56)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01FDFGLJHB_00402_003F_0024AA_0040));
				try
				{
					std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0xdb52cc09_002EHEXSTRINGARRAY, 84)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01EKENIIDA_00403_003F_0024AA_0040));
					try
					{
						std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0xdb52cc09_002EHEXSTRINGARRAY, 112)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01FAMBOPH_00404_003F_0024AA_0040));
						try
						{
							std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0xdb52cc09_002EHEXSTRINGARRAY, 140)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01BMBHCPLG_00405_003F_0024AA_0040));
							try
							{
								std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0xdb52cc09_002EHEXSTRINGARRAY, 168)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01DHDKHMHF_00406_003F_0024AA_0040));
								try
								{
									std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0xdb52cc09_002EHEXSTRINGARRAY, 196)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01COCBENDE_00407_003F_0024AA_0040));
									try
									{
										std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0xdb52cc09_002EHEXSTRINGARRAY, 224)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01KJLJFBPL_00408_003F_0024AA_0040));
										try
										{
											std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0xdb52cc09_002EHEXSTRINGARRAY, 252)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01LAKCGALK_00409_003F_0024AA_0040));
											try
											{
												std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0xdb52cc09_002EHEXSTRINGARRAY, 280)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01FHEEJDEE_0040A_003F_0024AA_0040));
												try
												{
													std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0xdb52cc09_002EHEXSTRINGARRAY, 308)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01HMGJMAIH_0040B_003F_0024AA_0040));
													try
													{
														std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0xdb52cc09_002EHEXSTRINGARRAY, 336)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01GFHCPBMG_0040C_003F_0024AA_0040));
														try
														{
															std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0xdb52cc09_002EHEXSTRINGARRAY, 364)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01CKDDGHAB_0040D_003F_0024AA_0040));
															try
															{
																std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0xdb52cc09_002EHEXSTRINGARRAY, 392)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01DDCIFGEA_0040E_003F_0024AA_0040));
																try
																{
																	std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0xdb52cc09_002EHEXSTRINGARRAY, 420)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01BIAFAFID_0040F_003F_0024AA_0040));
																}
																catch
																{
																	//try-fault
																	___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0xdb52cc09_002EHEXSTRINGARRAY, 392)));
																	throw;
																}
															}
															catch
															{
																//try-fault
																___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0xdb52cc09_002EHEXSTRINGARRAY, 364)));
																throw;
															}
														}
														catch
														{
															//try-fault
															___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0xdb52cc09_002EHEXSTRINGARRAY, 336)));
															throw;
														}
													}
													catch
													{
														//try-fault
														___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0xdb52cc09_002EHEXSTRINGARRAY, 308)));
														throw;
													}
												}
												catch
												{
													//try-fault
													___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0xdb52cc09_002EHEXSTRINGARRAY, 280)));
													throw;
												}
											}
											catch
											{
												//try-fault
												___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0xdb52cc09_002EHEXSTRINGARRAY, 252)));
												throw;
											}
										}
										catch
										{
											//try-fault
											___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0xdb52cc09_002EHEXSTRINGARRAY, 224)));
											throw;
										}
									}
									catch
									{
										//try-fault
										___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0xdb52cc09_002EHEXSTRINGARRAY, 196)));
										throw;
									}
								}
								catch
								{
									//try-fault
									___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0xdb52cc09_002EHEXSTRINGARRAY, 168)));
									throw;
								}
							}
							catch
							{
								//try-fault
								___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0xdb52cc09_002EHEXSTRINGARRAY, 140)));
								throw;
							}
						}
						catch
						{
							//try-fault
							___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0xdb52cc09_002EHEXSTRINGARRAY, 112)));
							throw;
						}
					}
					catch
					{
						//try-fault
						___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0xdb52cc09_002EHEXSTRINGARRAY, 84)));
						throw;
					}
				}
				catch
				{
					//try-fault
					___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0xdb52cc09_002EHEXSTRINGARRAY, 56)));
					throw;
				}
			}
			catch
			{
				//try-fault
				___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0xdb52cc09_002EHEXSTRINGARRAY, 28)));
				throw;
			}
		}
		catch
		{
			//try-fault
			___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EMiscHelper_002E_003FA0xdb52cc09_002EHEXSTRINGARRAY));
			throw;
		}
		_atexit_m((delegate*<void>)(&_003FA0xdb52cc09_002E_003F_003F__F_003FA0xdb52cc09_0040HEXSTRINGARRAY_0040MiscHelper_0040HOLM_0040_0040YMXXZ));
	}

	internal unsafe static void _003FA0xdb52cc09_002E_003F_003F__F_003FA0xdb52cc09_0040HEXSTRINGARRAY_0040MiscHelper_0040HOLM_0040_0040YMXXZ()
	{
		__ehvec_dtor(System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EMiscHelper_002E_003FA0xdb52cc09_002EHEXSTRINGARRAY), 28u, 16, (delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D));
	}

	internal unsafe static void _003FA0xdb52cc09_002E_003F_003F__E_003FA0xdb52cc09_0040HOLM_WINDOW_FPGA_CTRL_0040MiscHelper_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EMiscHelper_002E_003FA0xdb52cc09_002EHOLM_WINDOW_FPGA_CTRL), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_0BD_0040CPFABDBC_0040HOLMFpgaController_003F_0024AA_0040));
		_atexit_m((delegate*<void>)(&_003FA0xdb52cc09_002E_003F_003F__F_003FA0xdb52cc09_0040HOLM_WINDOW_FPGA_CTRL_0040MiscHelper_0040HOLM_0040_0040YMXXZ));
	}

	internal unsafe static void _003FA0xdb52cc09_002E_003F_003F__F_003FA0xdb52cc09_0040HOLM_WINDOW_FPGA_CTRL_0040MiscHelper_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EMiscHelper_002E_003FA0xdb52cc09_002EHOLM_WINDOW_FPGA_CTRL));
	}

	internal unsafe static void _003FA0xdb52cc09_002E_003F_003F__E_003FA0xdb52cc09_0040HOLM_WINDOW_DSPreLab_0040MiscHelper_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EMiscHelper_002E_003FA0xdb52cc09_002EHOLM_WINDOW_DSPreLab), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_08LKNALPII_0040DSPreLab_003F_0024AA_0040));
		_atexit_m((delegate*<void>)(&_003FA0xdb52cc09_002E_003F_003F__F_003FA0xdb52cc09_0040HOLM_WINDOW_DSPreLab_0040MiscHelper_0040HOLM_0040_0040YMXXZ));
	}

	internal unsafe static void _003FA0xdb52cc09_002E_003F_003F__F_003FA0xdb52cc09_0040HOLM_WINDOW_DSPreLab_0040MiscHelper_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EMiscHelper_002E_003FA0xdb52cc09_002EHOLM_WINDOW_DSPreLab));
	}

	internal unsafe static void _003FA0xdb52cc09_002E_003F_003F__E_003FA0xdb52cc09_0040HOLM_WINDOW_DSPreLab_DEMO_0040MiscHelper_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EMiscHelper_002E_003FA0xdb52cc09_002EHOLM_WINDOW_DSPreLab_DEMO), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_0BA_0040MFILEGDE_0040DEMO_003F5_003F9_003F5DSPreLab_003F_0024AA_0040));
		_atexit_m((delegate*<void>)(&_003FA0xdb52cc09_002E_003F_003F__F_003FA0xdb52cc09_0040HOLM_WINDOW_DSPreLab_DEMO_0040MiscHelper_0040HOLM_0040_0040YMXXZ));
	}

	internal unsafe static void _003FA0xdb52cc09_002E_003F_003F__F_003FA0xdb52cc09_0040HOLM_WINDOW_DSPreLab_DEMO_0040MiscHelper_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EMiscHelper_002E_003FA0xdb52cc09_002EHOLM_WINDOW_DSPreLab_DEMO));
	}

	internal static void DeleteCliArray(object[] a)
	{
		if (a == null)
		{
			return;
		}
		int num = 0;
		if (0 >= (nint)a.LongLength)
		{
			return;
		}
		do
		{
			if (a[num] is IDisposable disposable)
			{
				disposable.Dispose();
			}
			a[num] = null;
			num++;
		}
		while (num < (nint)a.LongLength);
	}

	internal unsafe static basic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E* HOLM_002EMiscHelper_002EStringToStdW(basic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E* P_0, string s)
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out uint num);
		try
		{
			num = 0u;
			std_002Ebasic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E_002E_007Bctor_007D(P_0, (uint)s.Length, ' ');
			num = 1u;
			int num2 = 0;
			if (0 < s.Length)
			{
				do
				{
					*std_002Ebasic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E_002E_005B_005D(P_0, (uint)num2) = s[num2];
					num2++;
				}
				while (num2 < s.Length);
			}
			return P_0;
		}
		catch
		{
			//try-fault
			if ((num & (true ? 1u : 0u)) != 0)
			{
				num &= 0xFFFFFFFEu;
				___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E_002E_007Bdtor_007D), P_0);
			}
			throw;
		}
	}

	internal unsafe static basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* HOLM_002EMiscHelper_002EStringToStd(basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* P_0, string s)
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out uint num);
		try
		{
			num = 0u;
			std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D(P_0, (uint)s.Length, 32);
			num = 1u;
			int num2 = 0;
			if (0 < s.Length)
			{
				do
				{
					sbyte b = (sbyte)s[num2];
					*global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_005B_005D(P_0, (uint)num2) = b;
					num2++;
				}
				while (num2 < s.Length);
			}
			return P_0;
		}
		catch
		{
			//try-fault
			if ((num & (true ? 1u : 0u)) != 0)
			{
				num &= 0xFFFFFFFEu;
				___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), P_0);
			}
			throw;
		}
	}

	internal unsafe static basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* HOLM_002EMiscHelper_002EGetTmpDirSimple(basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* P_0)
	{
		uint num = 0u;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _0024ArrayType_0024_0024_0024BY0MI_0040_W _0024ArrayType_0024_0024_0024BY0MI_0040_W);
		GetTempPathW(200u, (char*)(&_0024ArrayType_0024_0024_0024BY0MI_0040_W));
		System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E obj);
		basic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E* ptr = std_002Ebasic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E_002E_007Bctor_007D(&obj, (char*)(&_0024ArrayType_0024_0024_0024BY0MI_0040_W));
		try
		{
			try
			{
				HOLM_002EWStringToString(P_0, ptr);
				num = 1u;
			}
			catch
			{
				//try-fault
				___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E_002E_007Bdtor_007D), &obj);
				throw;
			}
			std_002Ebasic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E_002E_007Bdtor_007D(&obj);
			return P_0;
		}
		catch
		{
			//try-fault
			if ((num & (true ? 1u : 0u)) != 0)
			{
				num &= 0xFFFFFFFEu;
				___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), P_0);
			}
			throw;
		}
	}

	internal unsafe static void HOLM_002EMiscHelper_002ESafeDelDir(string path)
	{
		try
		{
			if (Directory.Exists(path))
			{
				Directory.Delete(path, recursive: true);
			}
		}
		catch (Exception ex)
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj);
			std_002Ebasic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D(&obj, 3, 1);
			try
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj2);
				basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* ptr = HOLM_002EMiscHelper_002EStringToStd(&obj2, ex.ToString());
				try
				{
					System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj3);
					basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* ptr2 = HOLM_002EMiscHelper_002EStringToStd(&obj3, path);
					try
					{
						std_002Eoperator_003C_003C_003Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_0020_003E(std_002Eoperator_003C_003C_003Cchar_002Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_002Cclass_0020std_003A_003Aallocator_003Cchar_003E_0020_003E(std_002Eoperator_003C_003C_003Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_0020_003E(std_002Eoperator_003C_003C_003Cchar_002Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_002Cclass_0020std_003A_003Aallocator_003Cchar_003E_0020_003E(std_002Eoperator_003C_003C_003Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_0020_003E(std_002Eoperator_003C_003C_003Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_0020_003E((basic_ostream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 8)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_08KFJDDMMO_0040WARNING_003F5_003F_0024AA_0040)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_0N_0040FCFFPKBK_0040SafeDelDir_003F3_003F5_003F_0024AA_0040)), ptr2), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_0N_0040ONLOMIOH_0040_003F6Exception_003F3_003F5_003F_0024AA_0040)), ptr), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01EEMJAFIK_0040_003F6_003F_0024AA_0040));
					}
					catch
					{
						//try-fault
						___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), &obj3);
						throw;
					}
					std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D(&obj3);
				}
				catch
				{
					//try-fault
					___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), &obj2);
					throw;
				}
				std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D(&obj2);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj4);
				basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* ptr3 = std_002Ebasic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002Estr(&obj, &obj4);
				try
				{
					HOLM_002ELogging_002EHolmLogger_002ELogText(ptr3);
				}
				catch
				{
					//try-fault
					___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), &obj4);
					throw;
				}
				std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D(&obj4);
			}
			catch
			{
				//try-fault
				___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E__vbaseDtor), &obj);
				throw;
			}
			std_002Ebasic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E__vbaseDtor(&obj);
		}
	}

	[return: MarshalAs(UnmanagedType.U1)]
	internal unsafe static bool HOLM_002EMiscHelper_002EOpenFileWithProcess(string path)
	{
		bool result = false;
		try
		{
			ProcessStartInfo startInfo = new ProcessStartInfo(path);
			Process process = Process.Start(startInfo);
			startInfo = null;
			Process process2 = process;
			IDisposable disposable = process;
			((IDisposable)process)?.Dispose();
			process = null;
			result = true;
		}
		catch (Exception ex)
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj);
			std_002Ebasic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D(&obj, 3, 1);
			try
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj2);
				basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* ptr = HOLM_002EMiscHelper_002EStringToStd(&obj2, ex.ToString());
				try
				{
					System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj3);
					basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* ptr2 = HOLM_002EMiscHelper_002EStringToStd(&obj3, path);
					try
					{
						std_002Eoperator_003C_003C_003Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_0020_003E(std_002Eoperator_003C_003C_003Cchar_002Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_002Cclass_0020std_003A_003Aallocator_003Cchar_003E_0020_003E(std_002Eoperator_003C_003C_003Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_0020_003E(std_002Eoperator_003C_003C_003Cchar_002Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_002Cclass_0020std_003A_003Aallocator_003Cchar_003E_0020_003E(std_002Eoperator_003C_003C_003Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_0020_003E(std_002Eoperator_003C_003C_003Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_0020_003E((basic_ostream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 8)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_08KFJDDMMO_0040WARNING_003F5_003F_0024AA_0040)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_0BG_0040CKFOKDON_0040OpenFileWithProcess_003F3_003F5_003F_0024AA_0040)), ptr2), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_0N_0040ONLOMIOH_0040_003F6Exception_003F3_003F5_003F_0024AA_0040)), ptr), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01EEMJAFIK_0040_003F6_003F_0024AA_0040));
					}
					catch
					{
						//try-fault
						___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), &obj3);
						throw;
					}
					std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D(&obj3);
				}
				catch
				{
					//try-fault
					___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), &obj2);
					throw;
				}
				std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D(&obj2);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj4);
				basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* ptr3 = std_002Ebasic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002Estr(&obj, &obj4);
				try
				{
					HOLM_002ELogging_002EHolmLogger_002ELogText(ptr3);
				}
				catch
				{
					//try-fault
					___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), &obj4);
					throw;
				}
				std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D(&obj4);
			}
			catch
			{
				//try-fault
				___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E__vbaseDtor), &obj);
				throw;
			}
			std_002Ebasic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E__vbaseDtor(&obj);
		}
		return result;
	}

	[return: MarshalAs(UnmanagedType.U1)]
	internal unsafe static bool HOLM_002EMiscHelper_002EMigrateAppDataDir_CommonToUser(string oldAppName)
	{
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Invalid comparison between Unknown and I4
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d0: Invalid comparison between Unknown and I4
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		bool result = false;
		string fullName = Directory.GetParent(Application.UserAppDataPath).FullName;
		string text = string.Concat(Directory.GetParent(Directory.GetParent(Application.CommonAppDataPath).FullName).FullName + "\\", oldAppName);
		if (Directory.Exists(text) && (nint)Directory.GetFiles(text).LongLength > 0)
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj);
			std_002Ebasic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D(&obj, 3, 1);
			try
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj2);
				basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* ptr = HOLM_002EMiscHelper_002EStringToStd(&obj2, string.Concat(string.Concat("MigrateAppDataDir_CommonToUser: " + text, " -> "), fullName));
				try
				{
					std_002Eoperator_003C_003C_003Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_0020_003E(std_002Eoperator_003C_003C_003Cchar_002Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_002Cclass_0020std_003A_003Aallocator_003Cchar_003E_0020_003E(std_002Eoperator_003C_003C_003Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_0020_003E((basic_ostream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 8)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_08ECDPJEFA_0040INFO_003F5_003F5_003F5_003F5_003F_0024AA_0040)), ptr), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01EEMJAFIK_0040_003F6_003F_0024AA_0040));
				}
				catch
				{
					//try-fault
					___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), &obj2);
					throw;
				}
				std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D(&obj2);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj3);
				basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* ptr2 = std_002Ebasic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002Estr(&obj, &obj3);
				try
				{
					HOLM_002ELogging_002EHolmLogger_002ELogText(ptr2);
				}
				catch
				{
					//try-fault
					___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), &obj3);
					throw;
				}
				std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D(&obj3);
			}
			catch
			{
				//try-fault
				___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E__vbaseDtor), &obj);
				throw;
			}
			std_002Ebasic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E__vbaseDtor(&obj);
			if ((nint)Directory.GetFiles(text).LongLength > 0)
			{
				try
				{
					HOLM_002ELogging_002EHolmLogger_002EStop();
					Sleep(500u);
					Directory.Delete(fullName, recursive: true);
					Directory.Move(text, fullName);
					Directory.Delete(Directory.GetParent(Application.CommonAppDataPath).FullName, recursive: true);
					HOLM_002ELogging_002EHolmLogger_002EStart();
					result = true;
					MessageBox.Show(string.Concat(string.Concat(string.Concat("The application data directory has been moved!\n" + "\nSource:\n", text), "\n\nDestination:\n"), fullName), "Information", (MessageBoxButtons)0, (MessageBoxIcon)64);
				}
				catch (IOException ex)
				{
					DialogResult val = MessageBox.Show(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat("Could not move data directory when migrating!\n" + "\nSource:\n", text), "\n\nDestination:\n"), fullName), "\n\n Error: "), ex.Message), "Warning", (MessageBoxButtons)2, (MessageBoxIcon)48);
					HOLM_002ELogging_002EHolmLogger_002EStart();
					if ((int)val == 3)
					{
						throw ex;
					}
					if ((int)val == 4)
					{
						result = HOLM_002EMiscHelper_002EMigrateAppDataDir_CommonToUser(oldAppName);
					}
				}
			}
		}
		else
		{
			HOLM_002EMiscHelper_002ESafeDelDir(Directory.GetParent(Application.CommonAppDataPath).FullName);
		}
		return result;
	}

	internal static string HOLM_002EMiscHelper_002EGetAppDataDirectory()
	{
		return Directory.GetParent(Application.UserAppDataPath).FullName;
	}

	internal unsafe static void HOLM_002EMiscHelper_002ERemoveAppVersionDirectory()
	{
		string userAppDataPath = Application.UserAppDataPath;
		try
		{
			Directory.Delete(userAppDataPath);
		}
		catch (Exception ex)
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj);
			std_002Ebasic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D(&obj, 3, 1);
			try
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj2);
				basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* ptr = HOLM_002EMiscHelper_002EStringToStd(&obj2, ex.ToString());
				try
				{
					std_002Eoperator_003C_003C_003Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_0020_003E(std_002Eoperator_003C_003C_003Cchar_002Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_002Cclass_0020std_003A_003Aallocator_003Cchar_003E_0020_003E(std_002Eoperator_003C_003C_003Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_0020_003E(std_002Eoperator_003C_003C_003Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_0020_003E((basic_ostream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 8)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_08ECDPJEFA_0040INFO_003F5_003F5_003F5_003F5_003F_0024AA_0040)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_0DE_0040OKEFBIAF_0040MiscHelper_003F3_003F3RemoveAppVersionDire_0040)), ptr), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01EEMJAFIK_0040_003F6_003F_0024AA_0040));
				}
				catch
				{
					//try-fault
					___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), &obj2);
					throw;
				}
				std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D(&obj2);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj3);
				basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* ptr2 = std_002Ebasic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002Estr(&obj, &obj3);
				try
				{
					HOLM_002ELogging_002EHolmLogger_002ELogText(ptr2);
				}
				catch
				{
					//try-fault
					___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), &obj3);
					throw;
				}
				std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D(&obj3);
			}
			catch
			{
				//try-fault
				___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E__vbaseDtor), &obj);
				throw;
			}
			std_002Ebasic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E__vbaseDtor(&obj);
		}
	}

	internal unsafe static void _003FA0xf6a6d558_002E_003F_003F__E_003FA0xf6a6d558_0040HEXSTRINGARRAY_0040MiscHelper_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EMiscHelper_002E_003FA0xf6a6d558_002EHEXSTRINGARRAY), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01GBGANLPD_00400_003F_0024AA_0040));
		try
		{
			std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0xf6a6d558_002EHEXSTRINGARRAY, 28)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01HIHLOKLC_00401_003F_0024AA_0040));
			try
			{
				std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0xf6a6d558_002EHEXSTRINGARRAY, 56)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01FDFGLJHB_00402_003F_0024AA_0040));
				try
				{
					std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0xf6a6d558_002EHEXSTRINGARRAY, 84)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01EKENIIDA_00403_003F_0024AA_0040));
					try
					{
						std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0xf6a6d558_002EHEXSTRINGARRAY, 112)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01FAMBOPH_00404_003F_0024AA_0040));
						try
						{
							std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0xf6a6d558_002EHEXSTRINGARRAY, 140)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01BMBHCPLG_00405_003F_0024AA_0040));
							try
							{
								std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0xf6a6d558_002EHEXSTRINGARRAY, 168)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01DHDKHMHF_00406_003F_0024AA_0040));
								try
								{
									std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0xf6a6d558_002EHEXSTRINGARRAY, 196)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01COCBENDE_00407_003F_0024AA_0040));
									try
									{
										std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0xf6a6d558_002EHEXSTRINGARRAY, 224)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01KJLJFBPL_00408_003F_0024AA_0040));
										try
										{
											std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0xf6a6d558_002EHEXSTRINGARRAY, 252)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01LAKCGALK_00409_003F_0024AA_0040));
											try
											{
												std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0xf6a6d558_002EHEXSTRINGARRAY, 280)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01FHEEJDEE_0040A_003F_0024AA_0040));
												try
												{
													std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0xf6a6d558_002EHEXSTRINGARRAY, 308)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01HMGJMAIH_0040B_003F_0024AA_0040));
													try
													{
														std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0xf6a6d558_002EHEXSTRINGARRAY, 336)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01GFHCPBMG_0040C_003F_0024AA_0040));
														try
														{
															std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0xf6a6d558_002EHEXSTRINGARRAY, 364)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01CKDDGHAB_0040D_003F_0024AA_0040));
															try
															{
																std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0xf6a6d558_002EHEXSTRINGARRAY, 392)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01DDCIFGEA_0040E_003F_0024AA_0040));
																try
																{
																	std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0xf6a6d558_002EHEXSTRINGARRAY, 420)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01BIAFAFID_0040F_003F_0024AA_0040));
																}
																catch
																{
																	//try-fault
																	___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0xf6a6d558_002EHEXSTRINGARRAY, 392)));
																	throw;
																}
															}
															catch
															{
																//try-fault
																___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0xf6a6d558_002EHEXSTRINGARRAY, 364)));
																throw;
															}
														}
														catch
														{
															//try-fault
															___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0xf6a6d558_002EHEXSTRINGARRAY, 336)));
															throw;
														}
													}
													catch
													{
														//try-fault
														___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0xf6a6d558_002EHEXSTRINGARRAY, 308)));
														throw;
													}
												}
												catch
												{
													//try-fault
													___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0xf6a6d558_002EHEXSTRINGARRAY, 280)));
													throw;
												}
											}
											catch
											{
												//try-fault
												___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0xf6a6d558_002EHEXSTRINGARRAY, 252)));
												throw;
											}
										}
										catch
										{
											//try-fault
											___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0xf6a6d558_002EHEXSTRINGARRAY, 224)));
											throw;
										}
									}
									catch
									{
										//try-fault
										___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0xf6a6d558_002EHEXSTRINGARRAY, 196)));
										throw;
									}
								}
								catch
								{
									//try-fault
									___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0xf6a6d558_002EHEXSTRINGARRAY, 168)));
									throw;
								}
							}
							catch
							{
								//try-fault
								___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0xf6a6d558_002EHEXSTRINGARRAY, 140)));
								throw;
							}
						}
						catch
						{
							//try-fault
							___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0xf6a6d558_002EHEXSTRINGARRAY, 112)));
							throw;
						}
					}
					catch
					{
						//try-fault
						___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0xf6a6d558_002EHEXSTRINGARRAY, 84)));
						throw;
					}
				}
				catch
				{
					//try-fault
					___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0xf6a6d558_002EHEXSTRINGARRAY, 56)));
					throw;
				}
			}
			catch
			{
				//try-fault
				___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0xf6a6d558_002EHEXSTRINGARRAY, 28)));
				throw;
			}
		}
		catch
		{
			//try-fault
			___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EMiscHelper_002E_003FA0xf6a6d558_002EHEXSTRINGARRAY));
			throw;
		}
		_atexit_m((delegate*<void>)(&_003FA0xf6a6d558_002E_003F_003F__F_003FA0xf6a6d558_0040HEXSTRINGARRAY_0040MiscHelper_0040HOLM_0040_0040YMXXZ));
	}

	internal unsafe static void _003FA0xf6a6d558_002E_003F_003F__F_003FA0xf6a6d558_0040HEXSTRINGARRAY_0040MiscHelper_0040HOLM_0040_0040YMXXZ()
	{
		__ehvec_dtor(System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EMiscHelper_002E_003FA0xf6a6d558_002EHEXSTRINGARRAY), 28u, 16, (delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D));
	}

	internal unsafe static void _003FA0xf6a6d558_002E_003F_003F__E_003FA0xf6a6d558_0040HOLM_WINDOW_FPGA_CTRL_0040MiscHelper_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EMiscHelper_002E_003FA0xf6a6d558_002EHOLM_WINDOW_FPGA_CTRL), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_0BD_0040CPFABDBC_0040HOLMFpgaController_003F_0024AA_0040));
		_atexit_m((delegate*<void>)(&_003FA0xf6a6d558_002E_003F_003F__F_003FA0xf6a6d558_0040HOLM_WINDOW_FPGA_CTRL_0040MiscHelper_0040HOLM_0040_0040YMXXZ));
	}

	internal unsafe static void _003FA0xf6a6d558_002E_003F_003F__F_003FA0xf6a6d558_0040HOLM_WINDOW_FPGA_CTRL_0040MiscHelper_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EMiscHelper_002E_003FA0xf6a6d558_002EHOLM_WINDOW_FPGA_CTRL));
	}

	internal unsafe static void _003FA0xf6a6d558_002E_003F_003F__E_003FA0xf6a6d558_0040HOLM_WINDOW_DSPreLab_0040MiscHelper_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EMiscHelper_002E_003FA0xf6a6d558_002EHOLM_WINDOW_DSPreLab), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_08LKNALPII_0040DSPreLab_003F_0024AA_0040));
		_atexit_m((delegate*<void>)(&_003FA0xf6a6d558_002E_003F_003F__F_003FA0xf6a6d558_0040HOLM_WINDOW_DSPreLab_0040MiscHelper_0040HOLM_0040_0040YMXXZ));
	}

	internal unsafe static void _003FA0xf6a6d558_002E_003F_003F__F_003FA0xf6a6d558_0040HOLM_WINDOW_DSPreLab_0040MiscHelper_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EMiscHelper_002E_003FA0xf6a6d558_002EHOLM_WINDOW_DSPreLab));
	}

	internal unsafe static void _003FA0xf6a6d558_002E_003F_003F__E_003FA0xf6a6d558_0040HOLM_WINDOW_DSPreLab_DEMO_0040MiscHelper_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EMiscHelper_002E_003FA0xf6a6d558_002EHOLM_WINDOW_DSPreLab_DEMO), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_0BA_0040MFILEGDE_0040DEMO_003F5_003F9_003F5DSPreLab_003F_0024AA_0040));
		_atexit_m((delegate*<void>)(&_003FA0xf6a6d558_002E_003F_003F__F_003FA0xf6a6d558_0040HOLM_WINDOW_DSPreLab_DEMO_0040MiscHelper_0040HOLM_0040_0040YMXXZ));
	}

	internal unsafe static void _003FA0xf6a6d558_002E_003F_003F__F_003FA0xf6a6d558_0040HOLM_WINDOW_DSPreLab_DEMO_0040MiscHelper_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EMiscHelper_002E_003FA0xf6a6d558_002EHOLM_WINDOW_DSPreLab_DEMO));
	}

	internal static string HOLM_002ENetwork_002EIntBytesSizeToString(int size)
	{
		string result = null;
		if (size < 1000)
		{
			int num = size;
			result = num.ToString("F0") + "b";
		}
		else if (size < 1000000)
		{
			result = (size / 1000).ToString("F0") + "kb";
		}
		else if (size < 1000000000)
		{
			result = (size / 1000000).ToString("F0") + "Mb";
		}
		return result;
	}

	internal unsafe static void _003FA0x3a8cae5d_002E_003F_003F__E_003FA0x3a8cae5d_0040HEXSTRINGARRAY_0040MiscHelper_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EMiscHelper_002E_003FA0x3a8cae5d_002EHEXSTRINGARRAY), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01GBGANLPD_00400_003F_0024AA_0040));
		try
		{
			std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x3a8cae5d_002EHEXSTRINGARRAY, 28)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01HIHLOKLC_00401_003F_0024AA_0040));
			try
			{
				std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x3a8cae5d_002EHEXSTRINGARRAY, 56)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01FDFGLJHB_00402_003F_0024AA_0040));
				try
				{
					std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x3a8cae5d_002EHEXSTRINGARRAY, 84)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01EKENIIDA_00403_003F_0024AA_0040));
					try
					{
						std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x3a8cae5d_002EHEXSTRINGARRAY, 112)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01FAMBOPH_00404_003F_0024AA_0040));
						try
						{
							std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x3a8cae5d_002EHEXSTRINGARRAY, 140)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01BMBHCPLG_00405_003F_0024AA_0040));
							try
							{
								std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x3a8cae5d_002EHEXSTRINGARRAY, 168)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01DHDKHMHF_00406_003F_0024AA_0040));
								try
								{
									std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x3a8cae5d_002EHEXSTRINGARRAY, 196)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01COCBENDE_00407_003F_0024AA_0040));
									try
									{
										std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x3a8cae5d_002EHEXSTRINGARRAY, 224)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01KJLJFBPL_00408_003F_0024AA_0040));
										try
										{
											std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x3a8cae5d_002EHEXSTRINGARRAY, 252)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01LAKCGALK_00409_003F_0024AA_0040));
											try
											{
												std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x3a8cae5d_002EHEXSTRINGARRAY, 280)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01FHEEJDEE_0040A_003F_0024AA_0040));
												try
												{
													std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x3a8cae5d_002EHEXSTRINGARRAY, 308)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01HMGJMAIH_0040B_003F_0024AA_0040));
													try
													{
														std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x3a8cae5d_002EHEXSTRINGARRAY, 336)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01GFHCPBMG_0040C_003F_0024AA_0040));
														try
														{
															std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x3a8cae5d_002EHEXSTRINGARRAY, 364)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01CKDDGHAB_0040D_003F_0024AA_0040));
															try
															{
																std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x3a8cae5d_002EHEXSTRINGARRAY, 392)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01DDCIFGEA_0040E_003F_0024AA_0040));
																try
																{
																	std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x3a8cae5d_002EHEXSTRINGARRAY, 420)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01BIAFAFID_0040F_003F_0024AA_0040));
																}
																catch
																{
																	//try-fault
																	___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x3a8cae5d_002EHEXSTRINGARRAY, 392)));
																	throw;
																}
															}
															catch
															{
																//try-fault
																___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x3a8cae5d_002EHEXSTRINGARRAY, 364)));
																throw;
															}
														}
														catch
														{
															//try-fault
															___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x3a8cae5d_002EHEXSTRINGARRAY, 336)));
															throw;
														}
													}
													catch
													{
														//try-fault
														___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x3a8cae5d_002EHEXSTRINGARRAY, 308)));
														throw;
													}
												}
												catch
												{
													//try-fault
													___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x3a8cae5d_002EHEXSTRINGARRAY, 280)));
													throw;
												}
											}
											catch
											{
												//try-fault
												___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x3a8cae5d_002EHEXSTRINGARRAY, 252)));
												throw;
											}
										}
										catch
										{
											//try-fault
											___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x3a8cae5d_002EHEXSTRINGARRAY, 224)));
											throw;
										}
									}
									catch
									{
										//try-fault
										___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x3a8cae5d_002EHEXSTRINGARRAY, 196)));
										throw;
									}
								}
								catch
								{
									//try-fault
									___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x3a8cae5d_002EHEXSTRINGARRAY, 168)));
									throw;
								}
							}
							catch
							{
								//try-fault
								___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x3a8cae5d_002EHEXSTRINGARRAY, 140)));
								throw;
							}
						}
						catch
						{
							//try-fault
							___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x3a8cae5d_002EHEXSTRINGARRAY, 112)));
							throw;
						}
					}
					catch
					{
						//try-fault
						___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x3a8cae5d_002EHEXSTRINGARRAY, 84)));
						throw;
					}
				}
				catch
				{
					//try-fault
					___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x3a8cae5d_002EHEXSTRINGARRAY, 56)));
					throw;
				}
			}
			catch
			{
				//try-fault
				___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x3a8cae5d_002EHEXSTRINGARRAY, 28)));
				throw;
			}
		}
		catch
		{
			//try-fault
			___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EMiscHelper_002E_003FA0x3a8cae5d_002EHEXSTRINGARRAY));
			throw;
		}
		_atexit_m((delegate*<void>)(&_003FA0x3a8cae5d_002E_003F_003F__F_003FA0x3a8cae5d_0040HEXSTRINGARRAY_0040MiscHelper_0040HOLM_0040_0040YMXXZ));
	}

	internal unsafe static void _003FA0x3a8cae5d_002E_003F_003F__F_003FA0x3a8cae5d_0040HEXSTRINGARRAY_0040MiscHelper_0040HOLM_0040_0040YMXXZ()
	{
		__ehvec_dtor(System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EMiscHelper_002E_003FA0x3a8cae5d_002EHEXSTRINGARRAY), 28u, 16, (delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D));
	}

	internal unsafe static void _003FA0x3a8cae5d_002E_003F_003F__E_003FA0x3a8cae5d_0040HOLM_WINDOW_FPGA_CTRL_0040MiscHelper_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EMiscHelper_002E_003FA0x3a8cae5d_002EHOLM_WINDOW_FPGA_CTRL), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_0BD_0040CPFABDBC_0040HOLMFpgaController_003F_0024AA_0040));
		_atexit_m((delegate*<void>)(&_003FA0x3a8cae5d_002E_003F_003F__F_003FA0x3a8cae5d_0040HOLM_WINDOW_FPGA_CTRL_0040MiscHelper_0040HOLM_0040_0040YMXXZ));
	}

	internal unsafe static void _003FA0x3a8cae5d_002E_003F_003F__F_003FA0x3a8cae5d_0040HOLM_WINDOW_FPGA_CTRL_0040MiscHelper_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EMiscHelper_002E_003FA0x3a8cae5d_002EHOLM_WINDOW_FPGA_CTRL));
	}

	internal unsafe static void _003FA0x3a8cae5d_002E_003F_003F__E_003FA0x3a8cae5d_0040HOLM_WINDOW_DSPreLab_0040MiscHelper_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EMiscHelper_002E_003FA0x3a8cae5d_002EHOLM_WINDOW_DSPreLab), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_08LKNALPII_0040DSPreLab_003F_0024AA_0040));
		_atexit_m((delegate*<void>)(&_003FA0x3a8cae5d_002E_003F_003F__F_003FA0x3a8cae5d_0040HOLM_WINDOW_DSPreLab_0040MiscHelper_0040HOLM_0040_0040YMXXZ));
	}

	internal unsafe static void _003FA0x3a8cae5d_002E_003F_003F__F_003FA0x3a8cae5d_0040HOLM_WINDOW_DSPreLab_0040MiscHelper_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EMiscHelper_002E_003FA0x3a8cae5d_002EHOLM_WINDOW_DSPreLab));
	}

	internal unsafe static void _003FA0x3a8cae5d_002E_003F_003F__E_003FA0x3a8cae5d_0040HOLM_WINDOW_DSPreLab_DEMO_0040MiscHelper_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EMiscHelper_002E_003FA0x3a8cae5d_002EHOLM_WINDOW_DSPreLab_DEMO), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_0BA_0040MFILEGDE_0040DEMO_003F5_003F9_003F5DSPreLab_003F_0024AA_0040));
		_atexit_m((delegate*<void>)(&_003FA0x3a8cae5d_002E_003F_003F__F_003FA0x3a8cae5d_0040HOLM_WINDOW_DSPreLab_DEMO_0040MiscHelper_0040HOLM_0040_0040YMXXZ));
	}

	internal unsafe static void _003FA0x3a8cae5d_002E_003F_003F__F_003FA0x3a8cae5d_0040HOLM_WINDOW_DSPreLab_DEMO_0040MiscHelper_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EMiscHelper_002E_003FA0x3a8cae5d_002EHOLM_WINDOW_DSPreLab_DEMO));
	}

	internal static void _003FA0x3a8cae5d_002E_003F_003F__E_003FA0x3a8cae5d_0040PI_0040Math_0040HOLM_0040_0040YMXXZ()
	{
		HOLM_002EMath_002E_003FA0x3a8cae5d_002EPI = Math.Acos(-1.0);
	}

	internal static void _003FA0x3a8cae5d_002E_003F_003F__E_003FA0x3a8cae5d_0040PI_F_0040Math_0040HOLM_0040_0040YMXXZ()
	{
		HOLM_002EMath_002E_003FA0x3a8cae5d_002EPI_F = (float)Math.Acos(-1.0);
	}

	internal static void _003FA0x3a8cae5d_002E_003F_003F__E_003FA0x3a8cae5d_0040TWOPI_0040Math_0040HOLM_0040_0040YMXXZ()
	{
		HOLM_002EMath_002E_003FA0x3a8cae5d_002ETWOPI = HOLM_002EMath_002E_003FA0x3a8cae5d_002EPI * 2.0;
	}

	internal static void _003FA0x3a8cae5d_002E_003F_003F__E_003FA0x3a8cae5d_0040HALFPI_0040Math_0040HOLM_0040_0040YMXXZ()
	{
		HOLM_002EMath_002E_003FA0x3a8cae5d_002EHALFPI = HOLM_002EMath_002E_003FA0x3a8cae5d_002EPI * 0.5;
	}

	internal static void _003FA0x3a8cae5d_002E_003F_003F__E_003FA0x3a8cae5d_0040SQRT2_0040Math_0040HOLM_0040_0040YMXXZ()
	{
		HOLM_002EMath_002E_003FA0x3a8cae5d_002ESQRT2 = Math.Sqrt(2.0);
	}

	internal static void _003FA0x3a8cae5d_002E_003F_003F__E_003FA0x3a8cae5d_0040SQRT2_F_0040Math_0040HOLM_0040_0040YMXXZ()
	{
		HOLM_002EMath_002E_003FA0x3a8cae5d_002ESQRT2_F = (float)Math.Sqrt(2.0);
	}

	internal static void _003FA0x3a8cae5d_002E_003F_003F__E_003FA0x3a8cae5d_0040RadToDeg_0040Math_0040HOLM_0040_0040YMXXZ()
	{
		HOLM_002EMath_002E_003FA0x3a8cae5d_002ERadToDeg = 180.0 / HOLM_002EMath_002E_003FA0x3a8cae5d_002EPI;
	}

	internal static void _003FA0x3a8cae5d_002E_003F_003F__E_003FA0x3a8cae5d_0040RadToDeg_F_0040Math_0040HOLM_0040_0040YMXXZ()
	{
		HOLM_002EMath_002E_003FA0x3a8cae5d_002ERadToDeg_F = (float)(180.0 / (double)HOLM_002EMath_002E_003FA0x3a8cae5d_002EPI_F);
	}

	internal static void _003FA0x3a8cae5d_002E_003F_003F__E_003FA0x3a8cae5d_0040DegToRad_0040Math_0040HOLM_0040_0040YMXXZ()
	{
		HOLM_002EMath_002E_003FA0x3a8cae5d_002EDegToRad = HOLM_002EMath_002E_003FA0x3a8cae5d_002EPI / 180.0;
	}

	internal static void _003FA0x3a8cae5d_002E_003F_003F__E_003FA0x3a8cae5d_0040DegToRad_F_0040Math_0040HOLM_0040_0040YMXXZ()
	{
		HOLM_002EMath_002E_003FA0x3a8cae5d_002EDegToRad_F = HOLM_002EMath_002E_003FA0x3a8cae5d_002EPI_F / 180f;
	}

	internal static void _003FA0x3a8cae5d_002E_003F_003F__E_003FA0x3a8cae5d_0040MILLISEC_TO_CM_0040Measure_0040HOLM_0040_0040YMXXZ()
	{
		HOLM_002EMeasure_002E_003FA0x3a8cae5d_002EMILLISEC_TO_CM = HOLM_002EMeasure_002E_003FA0x3a8cae5d_002ESEC_TO_CM / 1000.0;
	}

	internal static void _003FA0x3a8cae5d_002E_003F_003F__E_003FA0x3a8cae5d_0040MICROSEC_TO_CM_0040Measure_0040HOLM_0040_0040YMXXZ()
	{
		HOLM_002EMeasure_002E_003FA0x3a8cae5d_002EMICROSEC_TO_CM = HOLM_002EMeasure_002E_003FA0x3a8cae5d_002EMILLISEC_TO_CM / 1000.0;
	}

	internal static void _003FA0x3a8cae5d_002E_003F_003F__E_003FA0x3a8cae5d_0040RunOnceCustomNewHandlerInt_0040Mem_0040_0040YMXXZ()
	{
		Mem_002E_003FA0x3a8cae5d_002ERunOnceCustomNewHandlerInt = Mem_002ECustomNewHandlerInt();
	}

	internal unsafe static void HOLM_002EMeasure_002EMeasurementImporter_002E_007Bdtor_007D(MeasurementImporter* P_0)
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)((byte*)P_0 + 4));
	}

	internal unsafe static void _003FA0x42c1a45b_002E_003F_003F__E_003FA0x42c1a45b_0040HEXSTRINGARRAY_0040MiscHelper_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EMiscHelper_002E_003FA0x42c1a45b_002EHEXSTRINGARRAY), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01GBGANLPD_00400_003F_0024AA_0040));
		try
		{
			std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x42c1a45b_002EHEXSTRINGARRAY, 28)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01HIHLOKLC_00401_003F_0024AA_0040));
			try
			{
				std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x42c1a45b_002EHEXSTRINGARRAY, 56)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01FDFGLJHB_00402_003F_0024AA_0040));
				try
				{
					std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x42c1a45b_002EHEXSTRINGARRAY, 84)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01EKENIIDA_00403_003F_0024AA_0040));
					try
					{
						std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x42c1a45b_002EHEXSTRINGARRAY, 112)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01FAMBOPH_00404_003F_0024AA_0040));
						try
						{
							std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x42c1a45b_002EHEXSTRINGARRAY, 140)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01BMBHCPLG_00405_003F_0024AA_0040));
							try
							{
								std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x42c1a45b_002EHEXSTRINGARRAY, 168)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01DHDKHMHF_00406_003F_0024AA_0040));
								try
								{
									std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x42c1a45b_002EHEXSTRINGARRAY, 196)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01COCBENDE_00407_003F_0024AA_0040));
									try
									{
										std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x42c1a45b_002EHEXSTRINGARRAY, 224)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01KJLJFBPL_00408_003F_0024AA_0040));
										try
										{
											std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x42c1a45b_002EHEXSTRINGARRAY, 252)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01LAKCGALK_00409_003F_0024AA_0040));
											try
											{
												std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x42c1a45b_002EHEXSTRINGARRAY, 280)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01FHEEJDEE_0040A_003F_0024AA_0040));
												try
												{
													std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x42c1a45b_002EHEXSTRINGARRAY, 308)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01HMGJMAIH_0040B_003F_0024AA_0040));
													try
													{
														std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x42c1a45b_002EHEXSTRINGARRAY, 336)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01GFHCPBMG_0040C_003F_0024AA_0040));
														try
														{
															std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x42c1a45b_002EHEXSTRINGARRAY, 364)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01CKDDGHAB_0040D_003F_0024AA_0040));
															try
															{
																std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x42c1a45b_002EHEXSTRINGARRAY, 392)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01DDCIFGEA_0040E_003F_0024AA_0040));
																try
																{
																	std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x42c1a45b_002EHEXSTRINGARRAY, 420)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01BIAFAFID_0040F_003F_0024AA_0040));
																}
																catch
																{
																	//try-fault
																	___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x42c1a45b_002EHEXSTRINGARRAY, 392)));
																	throw;
																}
															}
															catch
															{
																//try-fault
																___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x42c1a45b_002EHEXSTRINGARRAY, 364)));
																throw;
															}
														}
														catch
														{
															//try-fault
															___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x42c1a45b_002EHEXSTRINGARRAY, 336)));
															throw;
														}
													}
													catch
													{
														//try-fault
														___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x42c1a45b_002EHEXSTRINGARRAY, 308)));
														throw;
													}
												}
												catch
												{
													//try-fault
													___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x42c1a45b_002EHEXSTRINGARRAY, 280)));
													throw;
												}
											}
											catch
											{
												//try-fault
												___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x42c1a45b_002EHEXSTRINGARRAY, 252)));
												throw;
											}
										}
										catch
										{
											//try-fault
											___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x42c1a45b_002EHEXSTRINGARRAY, 224)));
											throw;
										}
									}
									catch
									{
										//try-fault
										___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x42c1a45b_002EHEXSTRINGARRAY, 196)));
										throw;
									}
								}
								catch
								{
									//try-fault
									___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x42c1a45b_002EHEXSTRINGARRAY, 168)));
									throw;
								}
							}
							catch
							{
								//try-fault
								___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x42c1a45b_002EHEXSTRINGARRAY, 140)));
								throw;
							}
						}
						catch
						{
							//try-fault
							___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x42c1a45b_002EHEXSTRINGARRAY, 112)));
							throw;
						}
					}
					catch
					{
						//try-fault
						___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x42c1a45b_002EHEXSTRINGARRAY, 84)));
						throw;
					}
				}
				catch
				{
					//try-fault
					___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x42c1a45b_002EHEXSTRINGARRAY, 56)));
					throw;
				}
			}
			catch
			{
				//try-fault
				___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x42c1a45b_002EHEXSTRINGARRAY, 28)));
				throw;
			}
		}
		catch
		{
			//try-fault
			___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EMiscHelper_002E_003FA0x42c1a45b_002EHEXSTRINGARRAY));
			throw;
		}
		_atexit_m((delegate*<void>)(&_003FA0x42c1a45b_002E_003F_003F__F_003FA0x42c1a45b_0040HEXSTRINGARRAY_0040MiscHelper_0040HOLM_0040_0040YMXXZ));
	}

	internal unsafe static void _003FA0x42c1a45b_002E_003F_003F__F_003FA0x42c1a45b_0040HEXSTRINGARRAY_0040MiscHelper_0040HOLM_0040_0040YMXXZ()
	{
		__ehvec_dtor(System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EMiscHelper_002E_003FA0x42c1a45b_002EHEXSTRINGARRAY), 28u, 16, (delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D));
	}

	internal unsafe static void _003FA0x42c1a45b_002E_003F_003F__E_003FA0x42c1a45b_0040HOLM_WINDOW_FPGA_CTRL_0040MiscHelper_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EMiscHelper_002E_003FA0x42c1a45b_002EHOLM_WINDOW_FPGA_CTRL), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_0BD_0040CPFABDBC_0040HOLMFpgaController_003F_0024AA_0040));
		_atexit_m((delegate*<void>)(&_003FA0x42c1a45b_002E_003F_003F__F_003FA0x42c1a45b_0040HOLM_WINDOW_FPGA_CTRL_0040MiscHelper_0040HOLM_0040_0040YMXXZ));
	}

	internal unsafe static void _003FA0x42c1a45b_002E_003F_003F__F_003FA0x42c1a45b_0040HOLM_WINDOW_FPGA_CTRL_0040MiscHelper_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EMiscHelper_002E_003FA0x42c1a45b_002EHOLM_WINDOW_FPGA_CTRL));
	}

	internal unsafe static void _003FA0x42c1a45b_002E_003F_003F__E_003FA0x42c1a45b_0040HOLM_WINDOW_DSPreLab_0040MiscHelper_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EMiscHelper_002E_003FA0x42c1a45b_002EHOLM_WINDOW_DSPreLab), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_08LKNALPII_0040DSPreLab_003F_0024AA_0040));
		_atexit_m((delegate*<void>)(&_003FA0x42c1a45b_002E_003F_003F__F_003FA0x42c1a45b_0040HOLM_WINDOW_DSPreLab_0040MiscHelper_0040HOLM_0040_0040YMXXZ));
	}

	internal unsafe static void _003FA0x42c1a45b_002E_003F_003F__F_003FA0x42c1a45b_0040HOLM_WINDOW_DSPreLab_0040MiscHelper_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EMiscHelper_002E_003FA0x42c1a45b_002EHOLM_WINDOW_DSPreLab));
	}

	internal unsafe static void _003FA0x42c1a45b_002E_003F_003F__E_003FA0x42c1a45b_0040HOLM_WINDOW_DSPreLab_DEMO_0040MiscHelper_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EMiscHelper_002E_003FA0x42c1a45b_002EHOLM_WINDOW_DSPreLab_DEMO), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_0BA_0040MFILEGDE_0040DEMO_003F5_003F9_003F5DSPreLab_003F_0024AA_0040));
		_atexit_m((delegate*<void>)(&_003FA0x42c1a45b_002E_003F_003F__F_003FA0x42c1a45b_0040HOLM_WINDOW_DSPreLab_DEMO_0040MiscHelper_0040HOLM_0040_0040YMXXZ));
	}

	internal unsafe static void _003FA0x42c1a45b_002E_003F_003F__F_003FA0x42c1a45b_0040HOLM_WINDOW_DSPreLab_DEMO_0040MiscHelper_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EMiscHelper_002E_003FA0x42c1a45b_002EHOLM_WINDOW_DSPreLab_DEMO));
	}

	internal static void _003FA0x42c1a45b_002E_003F_003F__E_003FA0x42c1a45b_0040PI_0040Math_0040HOLM_0040_0040YMXXZ()
	{
		HOLM_002EMath_002E_003FA0x42c1a45b_002EPI = Math.Acos(-1.0);
	}

	internal static void _003FA0x42c1a45b_002E_003F_003F__E_003FA0x42c1a45b_0040PI_F_0040Math_0040HOLM_0040_0040YMXXZ()
	{
		HOLM_002EMath_002E_003FA0x42c1a45b_002EPI_F = (float)Math.Acos(-1.0);
	}

	internal static void _003FA0x42c1a45b_002E_003F_003F__E_003FA0x42c1a45b_0040TWOPI_0040Math_0040HOLM_0040_0040YMXXZ()
	{
		HOLM_002EMath_002E_003FA0x42c1a45b_002ETWOPI = HOLM_002EMath_002E_003FA0x42c1a45b_002EPI * 2.0;
	}

	internal static void _003FA0x42c1a45b_002E_003F_003F__E_003FA0x42c1a45b_0040HALFPI_0040Math_0040HOLM_0040_0040YMXXZ()
	{
		HOLM_002EMath_002E_003FA0x42c1a45b_002EHALFPI = HOLM_002EMath_002E_003FA0x42c1a45b_002EPI * 0.5;
	}

	internal static void _003FA0x42c1a45b_002E_003F_003F__E_003FA0x42c1a45b_0040SQRT2_0040Math_0040HOLM_0040_0040YMXXZ()
	{
		HOLM_002EMath_002E_003FA0x42c1a45b_002ESQRT2 = Math.Sqrt(2.0);
	}

	internal static void _003FA0x42c1a45b_002E_003F_003F__E_003FA0x42c1a45b_0040SQRT2_F_0040Math_0040HOLM_0040_0040YMXXZ()
	{
		HOLM_002EMath_002E_003FA0x42c1a45b_002ESQRT2_F = (float)Math.Sqrt(2.0);
	}

	internal static void _003FA0x42c1a45b_002E_003F_003F__E_003FA0x42c1a45b_0040RadToDeg_0040Math_0040HOLM_0040_0040YMXXZ()
	{
		HOLM_002EMath_002E_003FA0x42c1a45b_002ERadToDeg = 180.0 / HOLM_002EMath_002E_003FA0x42c1a45b_002EPI;
	}

	internal static void _003FA0x42c1a45b_002E_003F_003F__E_003FA0x42c1a45b_0040RadToDeg_F_0040Math_0040HOLM_0040_0040YMXXZ()
	{
		HOLM_002EMath_002E_003FA0x42c1a45b_002ERadToDeg_F = (float)(180.0 / (double)HOLM_002EMath_002E_003FA0x42c1a45b_002EPI_F);
	}

	internal static void _003FA0x42c1a45b_002E_003F_003F__E_003FA0x42c1a45b_0040DegToRad_0040Math_0040HOLM_0040_0040YMXXZ()
	{
		HOLM_002EMath_002E_003FA0x42c1a45b_002EDegToRad = HOLM_002EMath_002E_003FA0x42c1a45b_002EPI / 180.0;
	}

	internal static void _003FA0x42c1a45b_002E_003F_003F__E_003FA0x42c1a45b_0040DegToRad_F_0040Math_0040HOLM_0040_0040YMXXZ()
	{
		HOLM_002EMath_002E_003FA0x42c1a45b_002EDegToRad_F = HOLM_002EMath_002E_003FA0x42c1a45b_002EPI_F / 180f;
	}

	internal static void _003FA0x42c1a45b_002E_003F_003F__E_003FA0x42c1a45b_0040MILLISEC_TO_CM_0040Measure_0040HOLM_0040_0040YMXXZ()
	{
		HOLM_002EMeasure_002E_003FA0x42c1a45b_002EMILLISEC_TO_CM = HOLM_002EMeasure_002E_003FA0x42c1a45b_002ESEC_TO_CM / 1000.0;
	}

	internal static void _003FA0x42c1a45b_002E_003F_003F__E_003FA0x42c1a45b_0040MICROSEC_TO_CM_0040Measure_0040HOLM_0040_0040YMXXZ()
	{
		HOLM_002EMeasure_002E_003FA0x42c1a45b_002EMICROSEC_TO_CM = HOLM_002EMeasure_002E_003FA0x42c1a45b_002EMILLISEC_TO_CM / 1000.0;
	}

	internal unsafe static void HOLM_002EMeasureGraphics_002EResponseGuiCallback(basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* status)
	{
		string text = new string(std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002Ec_str(status));
		if (std_002Eoperator_003D_003D_003Cchar_002Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_002Cclass_0020std_003A_003Aallocator_003Cchar_003E_0020_003E(status, (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01LFCBOECM_0040_003F4_003F_0024AA_0040)))
		{
			ResponseGui.form.statusLabel.Text = ResponseGui.form.statusLabel.Text + "|";
		}
		else if (std_002Eoperator_003D_003D_003Cchar_002Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_002Cclass_0020std_003A_003Aallocator_003Cchar_003E_0020_003E(status, (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01EFFIKLCJ_0040n_003F_0024AA_0040)))
		{
			ResponseGui.form.statusLabel.Text = ResponseGui.form.statusLabel.Text + "\n";
			((Control)ResponseGui.form.warningPanel).Visible = false;
		}
		else if (std_002Eoperator_003D_003D_003Cchar_002Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_002Cclass_0020std_003A_003Aallocator_003Cchar_003E_0020_003E(status, (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_0BH_0040DEIBABBD_0040Playing_003F5and_003F5Recording_003F3_003F_0024AA_0040)))
		{
			if (HOLM_002EMeasureGraphics_002E_003FA0x42c1a45b_002EfResponseGuiCallbackDoEvents)
			{
				((Control)ResponseGui.form.abortButton).Enabled = true;
			}
			ResponseGui.form.statusLabel.Text = string.Concat(ResponseGui.form.statusLabel.Text, "- " + "Playing and Recording: ");
		}
		else if (std_002Eoperator_0021_003D_003Cchar_002Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_002Cclass_0020std_003A_003Aallocator_003Cchar_003E_0020_003E(status, (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01JOAMLHOP_0040_003F9_003F_0024AA_0040)))
		{
			((Control)ResponseGui.form.abortButton).Enabled = false;
			if (HOLM_002EMeasureGraphics_002E_003FA0x42c1a45b_002EfResponseGuiCallbackReset)
			{
				HOLM_002EMeasureGraphics_002E_003FA0x42c1a45b_002EfResponseGuiCallbackReset = false;
				ResponseGui.form.statusLabel.Text = string.Concat("- " + text, "\n");
			}
			else
			{
				ResponseGui.form.statusLabel.Text = string.Concat(ResponseGui.form.statusLabel.Text, string.Concat("- " + text, "\n"));
			}
		}
		if (HOLM_002EMeasureGraphics_002E_003FA0x42c1a45b_002EfResponseGuiCallbackDoEvents)
		{
			Application.DoEvents();
		}
	}

	internal static void _003FA0x6df59541_002E_003F_003F__E_003FA0x6df59541_0040PI_0040Math_0040HOLM_0040_0040YMXXZ()
	{
		HOLM_002EMath_002E_003FA0x6df59541_002EPI = Math.Acos(-1.0);
	}

	internal static void _003FA0x6df59541_002E_003F_003F__E_003FA0x6df59541_0040PI_F_0040Math_0040HOLM_0040_0040YMXXZ()
	{
		HOLM_002EMath_002E_003FA0x6df59541_002EPI_F = (float)Math.Acos(-1.0);
	}

	internal static void _003FA0x6df59541_002E_003F_003F__E_003FA0x6df59541_0040TWOPI_0040Math_0040HOLM_0040_0040YMXXZ()
	{
		HOLM_002EMath_002E_003FA0x6df59541_002ETWOPI = HOLM_002EMath_002E_003FA0x6df59541_002EPI * 2.0;
	}

	internal static void _003FA0x6df59541_002E_003F_003F__E_003FA0x6df59541_0040HALFPI_0040Math_0040HOLM_0040_0040YMXXZ()
	{
		HOLM_002EMath_002E_003FA0x6df59541_002EHALFPI = HOLM_002EMath_002E_003FA0x6df59541_002EPI * 0.5;
	}

	internal static void _003FA0x6df59541_002E_003F_003F__E_003FA0x6df59541_0040SQRT2_0040Math_0040HOLM_0040_0040YMXXZ()
	{
		HOLM_002EMath_002E_003FA0x6df59541_002ESQRT2 = Math.Sqrt(2.0);
	}

	internal static void _003FA0x6df59541_002E_003F_003F__E_003FA0x6df59541_0040SQRT2_F_0040Math_0040HOLM_0040_0040YMXXZ()
	{
		HOLM_002EMath_002E_003FA0x6df59541_002ESQRT2_F = (float)Math.Sqrt(2.0);
	}

	internal static void _003FA0x6df59541_002E_003F_003F__E_003FA0x6df59541_0040RadToDeg_0040Math_0040HOLM_0040_0040YMXXZ()
	{
		HOLM_002EMath_002E_003FA0x6df59541_002ERadToDeg = 180.0 / HOLM_002EMath_002E_003FA0x6df59541_002EPI;
	}

	internal static void _003FA0x6df59541_002E_003F_003F__E_003FA0x6df59541_0040RadToDeg_F_0040Math_0040HOLM_0040_0040YMXXZ()
	{
		HOLM_002EMath_002E_003FA0x6df59541_002ERadToDeg_F = (float)(180.0 / (double)HOLM_002EMath_002E_003FA0x6df59541_002EPI_F);
	}

	internal static void _003FA0x6df59541_002E_003F_003F__E_003FA0x6df59541_0040DegToRad_0040Math_0040HOLM_0040_0040YMXXZ()
	{
		HOLM_002EMath_002E_003FA0x6df59541_002EDegToRad = HOLM_002EMath_002E_003FA0x6df59541_002EPI / 180.0;
	}

	internal static void _003FA0x6df59541_002E_003F_003F__E_003FA0x6df59541_0040DegToRad_F_0040Math_0040HOLM_0040_0040YMXXZ()
	{
		HOLM_002EMath_002E_003FA0x6df59541_002EDegToRad_F = HOLM_002EMath_002E_003FA0x6df59541_002EPI_F / 180f;
	}

	internal static void _003FA0x6df59541_002E_003F_003F__E_003FA0x6df59541_0040MILLISEC_TO_CM_0040Measure_0040HOLM_0040_0040YMXXZ()
	{
		HOLM_002EMeasure_002E_003FA0x6df59541_002EMILLISEC_TO_CM = HOLM_002EMeasure_002E_003FA0x6df59541_002ESEC_TO_CM / 1000.0;
	}

	internal static void _003FA0x6df59541_002E_003F_003F__E_003FA0x6df59541_0040MICROSEC_TO_CM_0040Measure_0040HOLM_0040_0040YMXXZ()
	{
		HOLM_002EMeasure_002E_003FA0x6df59541_002EMICROSEC_TO_CM = HOLM_002EMeasure_002E_003FA0x6df59541_002EMILLISEC_TO_CM / 1000.0;
	}

	internal unsafe static void _003FA0x6df59541_002E_003F_003F__E_003FA0x6df59541_0040HEXSTRINGARRAY_0040MiscHelper_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EMiscHelper_002E_003FA0x6df59541_002EHEXSTRINGARRAY), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01GBGANLPD_00400_003F_0024AA_0040));
		try
		{
			std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x6df59541_002EHEXSTRINGARRAY, 28)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01HIHLOKLC_00401_003F_0024AA_0040));
			try
			{
				std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x6df59541_002EHEXSTRINGARRAY, 56)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01FDFGLJHB_00402_003F_0024AA_0040));
				try
				{
					std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x6df59541_002EHEXSTRINGARRAY, 84)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01EKENIIDA_00403_003F_0024AA_0040));
					try
					{
						std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x6df59541_002EHEXSTRINGARRAY, 112)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01FAMBOPH_00404_003F_0024AA_0040));
						try
						{
							std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x6df59541_002EHEXSTRINGARRAY, 140)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01BMBHCPLG_00405_003F_0024AA_0040));
							try
							{
								std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x6df59541_002EHEXSTRINGARRAY, 168)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01DHDKHMHF_00406_003F_0024AA_0040));
								try
								{
									std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x6df59541_002EHEXSTRINGARRAY, 196)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01COCBENDE_00407_003F_0024AA_0040));
									try
									{
										std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x6df59541_002EHEXSTRINGARRAY, 224)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01KJLJFBPL_00408_003F_0024AA_0040));
										try
										{
											std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x6df59541_002EHEXSTRINGARRAY, 252)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01LAKCGALK_00409_003F_0024AA_0040));
											try
											{
												std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x6df59541_002EHEXSTRINGARRAY, 280)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01FHEEJDEE_0040A_003F_0024AA_0040));
												try
												{
													std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x6df59541_002EHEXSTRINGARRAY, 308)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01HMGJMAIH_0040B_003F_0024AA_0040));
													try
													{
														std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x6df59541_002EHEXSTRINGARRAY, 336)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01GFHCPBMG_0040C_003F_0024AA_0040));
														try
														{
															std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x6df59541_002EHEXSTRINGARRAY, 364)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01CKDDGHAB_0040D_003F_0024AA_0040));
															try
															{
																std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x6df59541_002EHEXSTRINGARRAY, 392)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01DDCIFGEA_0040E_003F_0024AA_0040));
																try
																{
																	std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x6df59541_002EHEXSTRINGARRAY, 420)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01BIAFAFID_0040F_003F_0024AA_0040));
																}
																catch
																{
																	//try-fault
																	___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x6df59541_002EHEXSTRINGARRAY, 392)));
																	throw;
																}
															}
															catch
															{
																//try-fault
																___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x6df59541_002EHEXSTRINGARRAY, 364)));
																throw;
															}
														}
														catch
														{
															//try-fault
															___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x6df59541_002EHEXSTRINGARRAY, 336)));
															throw;
														}
													}
													catch
													{
														//try-fault
														___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x6df59541_002EHEXSTRINGARRAY, 308)));
														throw;
													}
												}
												catch
												{
													//try-fault
													___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x6df59541_002EHEXSTRINGARRAY, 280)));
													throw;
												}
											}
											catch
											{
												//try-fault
												___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x6df59541_002EHEXSTRINGARRAY, 252)));
												throw;
											}
										}
										catch
										{
											//try-fault
											___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x6df59541_002EHEXSTRINGARRAY, 224)));
											throw;
										}
									}
									catch
									{
										//try-fault
										___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x6df59541_002EHEXSTRINGARRAY, 196)));
										throw;
									}
								}
								catch
								{
									//try-fault
									___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x6df59541_002EHEXSTRINGARRAY, 168)));
									throw;
								}
							}
							catch
							{
								//try-fault
								___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x6df59541_002EHEXSTRINGARRAY, 140)));
								throw;
							}
						}
						catch
						{
							//try-fault
							___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x6df59541_002EHEXSTRINGARRAY, 112)));
							throw;
						}
					}
					catch
					{
						//try-fault
						___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x6df59541_002EHEXSTRINGARRAY, 84)));
						throw;
					}
				}
				catch
				{
					//try-fault
					___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x6df59541_002EHEXSTRINGARRAY, 56)));
					throw;
				}
			}
			catch
			{
				//try-fault
				___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x6df59541_002EHEXSTRINGARRAY, 28)));
				throw;
			}
		}
		catch
		{
			//try-fault
			___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EMiscHelper_002E_003FA0x6df59541_002EHEXSTRINGARRAY));
			throw;
		}
		_atexit_m((delegate*<void>)(&_003FA0x6df59541_002E_003F_003F__F_003FA0x6df59541_0040HEXSTRINGARRAY_0040MiscHelper_0040HOLM_0040_0040YMXXZ));
	}

	internal unsafe static void _003FA0x6df59541_002E_003F_003F__F_003FA0x6df59541_0040HEXSTRINGARRAY_0040MiscHelper_0040HOLM_0040_0040YMXXZ()
	{
		__ehvec_dtor(System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EMiscHelper_002E_003FA0x6df59541_002EHEXSTRINGARRAY), 28u, 16, (delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D));
	}

	internal unsafe static void _003FA0x6df59541_002E_003F_003F__E_003FA0x6df59541_0040HOLM_WINDOW_FPGA_CTRL_0040MiscHelper_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EMiscHelper_002E_003FA0x6df59541_002EHOLM_WINDOW_FPGA_CTRL), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_0BD_0040CPFABDBC_0040HOLMFpgaController_003F_0024AA_0040));
		_atexit_m((delegate*<void>)(&_003FA0x6df59541_002E_003F_003F__F_003FA0x6df59541_0040HOLM_WINDOW_FPGA_CTRL_0040MiscHelper_0040HOLM_0040_0040YMXXZ));
	}

	internal unsafe static void _003FA0x6df59541_002E_003F_003F__F_003FA0x6df59541_0040HOLM_WINDOW_FPGA_CTRL_0040MiscHelper_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EMiscHelper_002E_003FA0x6df59541_002EHOLM_WINDOW_FPGA_CTRL));
	}

	internal unsafe static void _003FA0x6df59541_002E_003F_003F__E_003FA0x6df59541_0040HOLM_WINDOW_DSPreLab_0040MiscHelper_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EMiscHelper_002E_003FA0x6df59541_002EHOLM_WINDOW_DSPreLab), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_08LKNALPII_0040DSPreLab_003F_0024AA_0040));
		_atexit_m((delegate*<void>)(&_003FA0x6df59541_002E_003F_003F__F_003FA0x6df59541_0040HOLM_WINDOW_DSPreLab_0040MiscHelper_0040HOLM_0040_0040YMXXZ));
	}

	internal unsafe static void _003FA0x6df59541_002E_003F_003F__F_003FA0x6df59541_0040HOLM_WINDOW_DSPreLab_0040MiscHelper_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EMiscHelper_002E_003FA0x6df59541_002EHOLM_WINDOW_DSPreLab));
	}

	internal unsafe static void _003FA0x6df59541_002E_003F_003F__E_003FA0x6df59541_0040HOLM_WINDOW_DSPreLab_DEMO_0040MiscHelper_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EMiscHelper_002E_003FA0x6df59541_002EHOLM_WINDOW_DSPreLab_DEMO), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_0BA_0040MFILEGDE_0040DEMO_003F5_003F9_003F5DSPreLab_003F_0024AA_0040));
		_atexit_m((delegate*<void>)(&_003FA0x6df59541_002E_003F_003F__F_003FA0x6df59541_0040HOLM_WINDOW_DSPreLab_DEMO_0040MiscHelper_0040HOLM_0040_0040YMXXZ));
	}

	internal unsafe static void _003FA0x6df59541_002E_003F_003F__F_003FA0x6df59541_0040HOLM_WINDOW_DSPreLab_DEMO_0040MiscHelper_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EMiscHelper_002E_003FA0x6df59541_002EHOLM_WINDOW_DSPreLab_DEMO));
	}

	internal unsafe static ResponseSaveOpenWave* HOLM_002EMeasure_002EResponseSaveOpenWave_002E_007Bctor_007D(ResponseSaveOpenWave* P_0)
	{
		HOLM_002EMeasure_002EResponse_002E_007Bctor_007D((Response*)P_0);
		try
		{
			*(int*)P_0 = (int)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_7ResponseSaveOpenWave_0040Measure_0040HOLM_0040_00406B_0040);
			ResponseSaveOpenWave* ptr = (ResponseSaveOpenWave*)((byte*)P_0 + 152);
			std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)ptr);
			try
			{
				ResponseSaveOpenWave* ptr2 = (ResponseSaveOpenWave*)((byte*)P_0 + 180);
				std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)ptr2);
				try
				{
					ResponseSaveOpenWave* ptr3 = (ResponseSaveOpenWave*)((byte*)P_0 + 208);
					std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)ptr3);
					try
					{
						((byte*)P_0)[149] = 0;
						std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_003D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)ptr, (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_0L_0040EPCLHKDP_0040Signal_003F4wav_003F_0024AA_0040));
						std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_003D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)ptr2, (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_0O_0040CNJLHMKD_0040Recording_003F4wav_003F_0024AA_0040));
						std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_003D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)ptr3, (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_0BA_0040JCHFLDBK_0040Correlation_003F4wav_003F_0024AA_0040));
						((byte*)P_0)[148] = 1;
						return P_0;
					}
					catch
					{
						//try-fault
						___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), (byte*)P_0 + 208);
						throw;
					}
				}
				catch
				{
					//try-fault
					___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), (byte*)P_0 + 180);
					throw;
				}
			}
			catch
			{
				//try-fault
				___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), (byte*)P_0 + 152);
				throw;
			}
		}
		catch
		{
			//try-fault
			___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<Response*, void>)(&HOLM_002EMeasure_002EResponse_002E_007Bdtor_007D), P_0);
			throw;
		}
	}

	[return: MarshalAs(UnmanagedType.U1)]
	internal unsafe static bool HOLM_002EMeasure_002EResponseSaveOpenWave_002ESaveSignal(ResponseSaveOpenWave* P_0, int corrM, basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* filename, PCMGenerator* pcmgen, WaveFormat waveformat, [MarshalAs(UnmanagedType.U1)] bool fInverse)
	{
		bool result;
		try
		{
			int num = (*(int*)((byte*)pcmgen + 4) = 1 << corrM);
			((delegate* unmanaged[Thiscall, Thiscall]<IntPtr, void>)(int)(*(uint*)(*(int*)pcmgen + 8)))((nint)pcmgen);
			if (num != *(int*)((byte*)P_0 + 88))
			{
				uint num2 = *(uint*)((byte*)P_0 + 84);
				if (num2 != 0)
				{
					delete_005B_005D((void*)(int)num2);
				}
				uint num3 = *(uint*)((byte*)P_0 + 104);
				if (num3 != 0)
				{
					delete_005B_005D((void*)(int)num3);
				}
				uint num4 = (((uint)num > 1073741823u) ? uint.MaxValue : ((uint)(num << 2)));
				*(int*)((byte*)P_0 + 84) = (int)new_005B_005D(num4);
				uint num5 = (((uint)num > 1073741823u) ? uint.MaxValue : ((uint)(num << 2)));
				*(int*)((byte*)P_0 + 104) = (int)new_005B_005D(num5);
			}
			if (((delegate* unmanaged[Thiscall, Thiscall]<IntPtr, byte>)(int)(*(uint*)(*(int*)pcmgen + 12)))((nint)pcmgen) != 0 || num != *(int*)((byte*)P_0 + 88) || (PCMGenerator*)(*(int*)((byte*)P_0 + 80)) != pcmgen)
			{
				int num6 = 0;
				if (0 < num)
				{
					ResponseSaveOpenWave* ptr = (ResponseSaveOpenWave*)((byte*)P_0 + 84);
					do
					{
						*(float*)(num6 * 4 + *(int*)ptr) = HOLM_002EPAudioII_002EPCMGenerator_002EAmplitude(pcmgen);
						num6++;
					}
					while (num6 < num);
				}
				*(int*)((byte*)P_0 + 80) = (int)pcmgen;
			}
			*(int*)((byte*)P_0 + 88) = num;
			if (((byte*)P_0)[148] != 0)
			{
				uint num7 = (uint)(num * 2);
				float* ptr2 = (float*)new_005B_005D((num7 > 1073741823) ? uint.MaxValue : (num7 << 2));
				int num8 = 0;
				if (0 < num * 2)
				{
					int num9 = num / -2;
					int num10 = num9;
					int num11 = num9 << 2;
					do
					{
						if (num10 >= 0 && num10 < num)
						{
							*(float*)(num8 * 4 + (byte*)ptr2) = *(float*)(*(int*)((byte*)P_0 + 84) + num11);
						}
						else
						{
							*(float*)(num8 * 4 + (byte*)ptr2) = 0f;
						}
						num8++;
						num10++;
						num11 += 4;
					}
					while (num8 < num * 2);
				}
				if (fInverse)
				{
					uint num12 = (uint)(num * 2);
					float* ptr3 = (float*)new_005B_005D((num12 > 1073741823) ? uint.MaxValue : (num12 << 2));
					HOLM_002EAnalyze_002EInverseSequence_003Cfloat_002Cfloat_003E(ptr2, ptr3, num * 2);
					System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj);
					std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D(&obj, (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_0BL_0040PBIMMPON_0040Inverse_003F5measurement_003F5signal_003F_0024AA_0040));
					try
					{
						int num13 = *(int*)((byte*)HOLM_002EPAudioII_002EStream() + 16);
						result = HOLM_002EWaveImExport_002EArrayWaveExport(ptr3, num * 2, num13, filename, waveformat, &obj, true) == num;
					}
					catch
					{
						//try-fault
						___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), &obj);
						throw;
					}
					std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D(&obj);
					delete_005B_005D(ptr3);
				}
				else
				{
					System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj2);
					std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D(&obj2, (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_0BD_0040PNKKKLDB_0040Measurement_003F5signal_003F_0024AA_0040));
					try
					{
						int num14 = *(int*)((byte*)HOLM_002EPAudioII_002EStream() + 16);
						result = HOLM_002EWaveImExport_002EArrayWaveExport(ptr2, num * 2, num14, filename, waveformat, &obj2, false) == num;
					}
					catch
					{
						//try-fault
						___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), &obj2);
						throw;
					}
					std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D(&obj2);
				}
				delete_005B_005D(ptr2);
			}
			else if (fInverse)
			{
				float* ptr4 = (float*)new_005B_005D(((uint)num > 1073741823u) ? uint.MaxValue : ((uint)(num << 2)));
				HOLM_002EAnalyze_002EInverseSequence_003Cfloat_002Cfloat_003E((float*)(int)(*(uint*)((byte*)P_0 + 84)), ptr4, num);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj3);
				std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D(&obj3, (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_0BL_0040PBIMMPON_0040Inverse_003F5measurement_003F5signal_003F_0024AA_0040));
				try
				{
					int num15 = *(int*)((byte*)HOLM_002EPAudioII_002EStream() + 16);
					result = HOLM_002EWaveImExport_002EArrayWaveExport(ptr4, num, num15, filename, waveformat, &obj3, true) == num;
				}
				catch
				{
					//try-fault
					___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), &obj3);
					throw;
				}
				std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D(&obj3);
				delete_005B_005D(ptr4);
			}
			else
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj4);
				std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D(&obj4, (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_0BD_0040PNKKKLDB_0040Measurement_003F5signal_003F_0024AA_0040));
				try
				{
					int num16 = *(int*)((byte*)HOLM_002EPAudioII_002EStream() + 16);
					result = HOLM_002EWaveImExport_002EArrayWaveExport((float*)(int)(*(uint*)((byte*)P_0 + 84)), num, num16, filename, waveformat, &obj4, false) == num;
				}
				catch
				{
					//try-fault
					___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), &obj4);
					throw;
				}
				std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D(&obj4);
			}
		}
		catch
		{
			//try-fault
			___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), filename);
			throw;
		}
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D(filename);
		return result;
	}

	internal unsafe static void HOLM_002EMeasure_002EResponseSaveOpenWave_002EDebugRecording(ResponseSaveOpenWave* P_0, float* pcm, int L)
	{
		if (((byte*)P_0)[149] == 0)
		{
			return;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj);
		std_002Ebasic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D(&obj, 3, 1);
		try
		{
			std_002Eoperator_003C_003C_003Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_0020_003E(std_002Eoperator_003C_003C_003Cchar_002Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_002Cclass_0020std_003A_003Aallocator_003Cchar_003E_0020_003E(std_002Eoperator_003C_003C_003Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_0020_003E(std_002Eoperator_003C_003C_003Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_0020_003E((basic_ostream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 8)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_08ECDPJEFA_0040INFO_003F5_003F5_003F5_003F5_003F_0024AA_0040)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_0CJ_0040BNLHIIEM_0040ResponseSaveOpenWave_003F3_003F3DebugRecor_0040)), (basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)((byte*)P_0 + 180)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01EEMJAFIK_0040_003F6_003F_0024AA_0040));
			System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj2);
			basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* ptr = std_002Ebasic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002Estr(&obj, &obj2);
			try
			{
				HOLM_002ELogging_002EHolmLogger_002ELogText(ptr);
			}
			catch
			{
				//try-fault
				___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), &obj2);
				throw;
			}
			std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D(&obj2);
		}
		catch
		{
			//try-fault
			___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E__vbaseDtor), &obj);
			throw;
		}
		std_002Ebasic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E__vbaseDtor(&obj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj3);
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D(&obj3, (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_09JAHJEAMH_0040Recording_003F_0024AA_0040));
		try
		{
			int num = *(int*)((byte*)HOLM_002EPAudioII_002EStream() + 16);
			HOLM_002EWaveImExport_002EArrayWaveExport(pcm, L, num, (basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)((byte*)P_0 + 180), *(WaveFormat*)((byte*)P_0 + 144), &obj3, false);
		}
		catch
		{
			//try-fault
			___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), &obj3);
			throw;
		}
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D(&obj3);
	}

	internal unsafe static void HOLM_002EMeasure_002EResponseSaveOpenWave_002EDebugOutput(ResponseSaveOpenWave* P_0, float* pcm, int L)
	{
		if (((byte*)P_0)[149] == 0)
		{
			return;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj);
		std_002Ebasic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D(&obj, 3, 1);
		try
		{
			std_002Eoperator_003C_003C_003Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_0020_003E(std_002Eoperator_003C_003C_003Cchar_002Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_002Cclass_0020std_003A_003Aallocator_003Cchar_003E_0020_003E(std_002Eoperator_003C_003C_003Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_0020_003E(std_002Eoperator_003C_003C_003Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_0020_003E((basic_ostream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 8)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_08ECDPJEFA_0040INFO_003F5_003F5_003F5_003F5_003F_0024AA_0040)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_0CG_0040OJEHCAND_0040ResponseSaveOpenWave_003F3_003F3DebugOutpu_0040)), (basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)((byte*)P_0 + 152)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01EEMJAFIK_0040_003F6_003F_0024AA_0040));
			System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj2);
			basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* ptr = std_002Ebasic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002Estr(&obj, &obj2);
			try
			{
				HOLM_002ELogging_002EHolmLogger_002ELogText(ptr);
			}
			catch
			{
				//try-fault
				___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), &obj2);
				throw;
			}
			std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D(&obj2);
		}
		catch
		{
			//try-fault
			___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E__vbaseDtor), &obj);
			throw;
		}
		std_002Ebasic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E__vbaseDtor(&obj);
		float num = *(float*)((byte*)HOLM_002EPAudioII_002EStream() + 32);
		if (num == 1f)
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj3);
			std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D(&obj3, (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_06PFDLEJLJ_0040Output_003F_0024AA_0040));
			try
			{
				int num2 = *(int*)((byte*)HOLM_002EPAudioII_002EStream() + 16);
				HOLM_002EWaveImExport_002EArrayWaveExport(pcm, L, num2, (basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)((byte*)P_0 + 152), *(WaveFormat*)((byte*)P_0 + 144), &obj3, false);
			}
			catch
			{
				//try-fault
				___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), &obj3);
				throw;
			}
			std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D(&obj3);
			return;
		}
		float* ptr2 = (float*)new_005B_005D(((uint)L > 1073741823u) ? uint.MaxValue : ((uint)(L << 2)));
		float num3 = *(float*)((byte*)HOLM_002EPAudioII_002EStream() + 32);
		if (0 < L)
		{
			float* ptr3 = ptr2;
			int num4 = (int)((byte*)pcm - (nuint)ptr2);
			int num5 = L;
			do
			{
				*ptr3 = (float)((double)(*(float*)(num4 + (byte*)ptr3)) * (double)num3);
				ptr3++;
				num5--;
			}
			while (num5 != 0);
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj4);
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D(&obj4, (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_0BD_0040PNGABND_0040Output_003F5with_003F5volume_003F_0024AA_0040));
		try
		{
			int num6 = *(int*)((byte*)HOLM_002EPAudioII_002EStream() + 16);
			HOLM_002EWaveImExport_002EArrayWaveExport(ptr2, L, num6, (basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)((byte*)P_0 + 152), *(WaveFormat*)((byte*)P_0 + 144), &obj4, false);
		}
		catch
		{
			//try-fault
			___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), &obj4);
			throw;
		}
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D(&obj4);
		delete_005B_005D(ptr2);
	}

	internal unsafe static void HOLM_002EMeasure_002EResponseSaveOpenWave_002EDebugCorrelation(ResponseSaveOpenWave* P_0, double* pcm, int L)
	{
		if (((byte*)P_0)[149] == 0)
		{
			return;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj);
		std_002Ebasic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D(&obj, 3, 1);
		try
		{
			std_002Eoperator_003C_003C_003Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_0020_003E(std_002Eoperator_003C_003C_003Cchar_002Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_002Cclass_0020std_003A_003Aallocator_003Cchar_003E_0020_003E(std_002Eoperator_003C_003C_003Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_0020_003E(std_002Eoperator_003C_003C_003Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_0020_003E((basic_ostream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 8)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_08ECDPJEFA_0040INFO_003F5_003F5_003F5_003F5_003F_0024AA_0040)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_0CL_0040MIMNMAEA_0040ResponseSaveOpenWave_003F3_003F3DebugCorre_0040)), (basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)((byte*)P_0 + 208)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01EEMJAFIK_0040_003F6_003F_0024AA_0040));
			System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj2);
			basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* ptr = std_002Ebasic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002Estr(&obj, &obj2);
			try
			{
				HOLM_002ELogging_002EHolmLogger_002ELogText(ptr);
			}
			catch
			{
				//try-fault
				___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), &obj2);
				throw;
			}
			std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D(&obj2);
		}
		catch
		{
			//try-fault
			___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E__vbaseDtor), &obj);
			throw;
		}
		std_002Ebasic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E__vbaseDtor(&obj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj3);
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D(&obj3, (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_0M_0040MJCOOAJL_0040Correlation_003F_0024AA_0040));
		try
		{
			int num = *(int*)((byte*)HOLM_002EPAudioII_002EStream() + 16);
			HOLM_002EWaveImExport_002EArrayWaveExport(pcm, L, num, (basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)((byte*)P_0 + 208), *(WaveFormat*)((byte*)P_0 + 144), &obj3, false);
		}
		catch
		{
			//try-fault
			___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), &obj3);
			throw;
		}
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D(&obj3);
	}

	internal unsafe static void _003FA0x3d5e82b5_002E_003F_003F__E_003FA0x3d5e82b5_0040HEXSTRINGARRAY_0040MiscHelper_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EMiscHelper_002E_003FA0x3d5e82b5_002EHEXSTRINGARRAY), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01GBGANLPD_00400_003F_0024AA_0040));
		try
		{
			std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x3d5e82b5_002EHEXSTRINGARRAY, 28)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01HIHLOKLC_00401_003F_0024AA_0040));
			try
			{
				std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x3d5e82b5_002EHEXSTRINGARRAY, 56)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01FDFGLJHB_00402_003F_0024AA_0040));
				try
				{
					std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x3d5e82b5_002EHEXSTRINGARRAY, 84)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01EKENIIDA_00403_003F_0024AA_0040));
					try
					{
						std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x3d5e82b5_002EHEXSTRINGARRAY, 112)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01FAMBOPH_00404_003F_0024AA_0040));
						try
						{
							std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x3d5e82b5_002EHEXSTRINGARRAY, 140)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01BMBHCPLG_00405_003F_0024AA_0040));
							try
							{
								std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x3d5e82b5_002EHEXSTRINGARRAY, 168)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01DHDKHMHF_00406_003F_0024AA_0040));
								try
								{
									std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x3d5e82b5_002EHEXSTRINGARRAY, 196)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01COCBENDE_00407_003F_0024AA_0040));
									try
									{
										std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x3d5e82b5_002EHEXSTRINGARRAY, 224)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01KJLJFBPL_00408_003F_0024AA_0040));
										try
										{
											std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x3d5e82b5_002EHEXSTRINGARRAY, 252)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01LAKCGALK_00409_003F_0024AA_0040));
											try
											{
												std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x3d5e82b5_002EHEXSTRINGARRAY, 280)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01FHEEJDEE_0040A_003F_0024AA_0040));
												try
												{
													std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x3d5e82b5_002EHEXSTRINGARRAY, 308)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01HMGJMAIH_0040B_003F_0024AA_0040));
													try
													{
														std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x3d5e82b5_002EHEXSTRINGARRAY, 336)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01GFHCPBMG_0040C_003F_0024AA_0040));
														try
														{
															std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x3d5e82b5_002EHEXSTRINGARRAY, 364)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01CKDDGHAB_0040D_003F_0024AA_0040));
															try
															{
																std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x3d5e82b5_002EHEXSTRINGARRAY, 392)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01DDCIFGEA_0040E_003F_0024AA_0040));
																try
																{
																	std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x3d5e82b5_002EHEXSTRINGARRAY, 420)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01BIAFAFID_0040F_003F_0024AA_0040));
																}
																catch
																{
																	//try-fault
																	___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x3d5e82b5_002EHEXSTRINGARRAY, 392)));
																	throw;
																}
															}
															catch
															{
																//try-fault
																___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x3d5e82b5_002EHEXSTRINGARRAY, 364)));
																throw;
															}
														}
														catch
														{
															//try-fault
															___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x3d5e82b5_002EHEXSTRINGARRAY, 336)));
															throw;
														}
													}
													catch
													{
														//try-fault
														___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x3d5e82b5_002EHEXSTRINGARRAY, 308)));
														throw;
													}
												}
												catch
												{
													//try-fault
													___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x3d5e82b5_002EHEXSTRINGARRAY, 280)));
													throw;
												}
											}
											catch
											{
												//try-fault
												___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x3d5e82b5_002EHEXSTRINGARRAY, 252)));
												throw;
											}
										}
										catch
										{
											//try-fault
											___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x3d5e82b5_002EHEXSTRINGARRAY, 224)));
											throw;
										}
									}
									catch
									{
										//try-fault
										___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x3d5e82b5_002EHEXSTRINGARRAY, 196)));
										throw;
									}
								}
								catch
								{
									//try-fault
									___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x3d5e82b5_002EHEXSTRINGARRAY, 168)));
									throw;
								}
							}
							catch
							{
								//try-fault
								___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x3d5e82b5_002EHEXSTRINGARRAY, 140)));
								throw;
							}
						}
						catch
						{
							//try-fault
							___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x3d5e82b5_002EHEXSTRINGARRAY, 112)));
							throw;
						}
					}
					catch
					{
						//try-fault
						___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x3d5e82b5_002EHEXSTRINGARRAY, 84)));
						throw;
					}
				}
				catch
				{
					//try-fault
					___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x3d5e82b5_002EHEXSTRINGARRAY, 56)));
					throw;
				}
			}
			catch
			{
				//try-fault
				___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0x3d5e82b5_002EHEXSTRINGARRAY, 28)));
				throw;
			}
		}
		catch
		{
			//try-fault
			___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EMiscHelper_002E_003FA0x3d5e82b5_002EHEXSTRINGARRAY));
			throw;
		}
		_atexit_m((delegate*<void>)(&_003FA0x3d5e82b5_002E_003F_003F__F_003FA0x3d5e82b5_0040HEXSTRINGARRAY_0040MiscHelper_0040HOLM_0040_0040YMXXZ));
	}

	internal unsafe static void _003FA0x3d5e82b5_002E_003F_003F__F_003FA0x3d5e82b5_0040HEXSTRINGARRAY_0040MiscHelper_0040HOLM_0040_0040YMXXZ()
	{
		__ehvec_dtor(System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EMiscHelper_002E_003FA0x3d5e82b5_002EHEXSTRINGARRAY), 28u, 16, (delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D));
	}

	internal unsafe static void _003FA0x3d5e82b5_002E_003F_003F__E_003FA0x3d5e82b5_0040HOLM_WINDOW_FPGA_CTRL_0040MiscHelper_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EMiscHelper_002E_003FA0x3d5e82b5_002EHOLM_WINDOW_FPGA_CTRL), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_0BD_0040CPFABDBC_0040HOLMFpgaController_003F_0024AA_0040));
		_atexit_m((delegate*<void>)(&_003FA0x3d5e82b5_002E_003F_003F__F_003FA0x3d5e82b5_0040HOLM_WINDOW_FPGA_CTRL_0040MiscHelper_0040HOLM_0040_0040YMXXZ));
	}

	internal unsafe static void _003FA0x3d5e82b5_002E_003F_003F__F_003FA0x3d5e82b5_0040HOLM_WINDOW_FPGA_CTRL_0040MiscHelper_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EMiscHelper_002E_003FA0x3d5e82b5_002EHOLM_WINDOW_FPGA_CTRL));
	}

	internal unsafe static void _003FA0x3d5e82b5_002E_003F_003F__E_003FA0x3d5e82b5_0040HOLM_WINDOW_DSPreLab_0040MiscHelper_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EMiscHelper_002E_003FA0x3d5e82b5_002EHOLM_WINDOW_DSPreLab), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_08LKNALPII_0040DSPreLab_003F_0024AA_0040));
		_atexit_m((delegate*<void>)(&_003FA0x3d5e82b5_002E_003F_003F__F_003FA0x3d5e82b5_0040HOLM_WINDOW_DSPreLab_0040MiscHelper_0040HOLM_0040_0040YMXXZ));
	}

	internal unsafe static void _003FA0x3d5e82b5_002E_003F_003F__F_003FA0x3d5e82b5_0040HOLM_WINDOW_DSPreLab_0040MiscHelper_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EMiscHelper_002E_003FA0x3d5e82b5_002EHOLM_WINDOW_DSPreLab));
	}

	internal unsafe static void _003FA0x3d5e82b5_002E_003F_003F__E_003FA0x3d5e82b5_0040HOLM_WINDOW_DSPreLab_DEMO_0040MiscHelper_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EMiscHelper_002E_003FA0x3d5e82b5_002EHOLM_WINDOW_DSPreLab_DEMO), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_0BA_0040MFILEGDE_0040DEMO_003F5_003F9_003F5DSPreLab_003F_0024AA_0040));
		_atexit_m((delegate*<void>)(&_003FA0x3d5e82b5_002E_003F_003F__F_003FA0x3d5e82b5_0040HOLM_WINDOW_DSPreLab_DEMO_0040MiscHelper_0040HOLM_0040_0040YMXXZ));
	}

	internal unsafe static void _003FA0x3d5e82b5_002E_003F_003F__F_003FA0x3d5e82b5_0040HOLM_WINDOW_DSPreLab_DEMO_0040MiscHelper_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EMiscHelper_002E_003FA0x3d5e82b5_002EHOLM_WINDOW_DSPreLab_DEMO));
	}

	internal unsafe static int HOLM_002EVersion_002EVersionNumber(basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* line)
	{
		int result;
		try
		{
			int num = (int)std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002Efind_last_of(line, 58, std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002Elength(line));
			int num2 = 0;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj);
			std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D(&obj, (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_00CNPNBAHC_0040_003F_0024AA_0040));
			try
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj2);
				std_002Ebasic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D(&obj2, 3, 1);
				try
				{
					System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj3);
					std_002Ebasic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D(&obj3, 3, 1);
					try
					{
						bool flag = false;
						uint num3 = (uint)(num + 1);
						if (num3 < std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002Elength(line))
						{
							uint num4 = num3 - 1;
							do
							{
								if (*global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_005B_005D(line, num3) >= 48 && *global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_005B_005D(line, num3) <= 57)
								{
									num2++;
									flag = true;
								}
								else
								{
									switch (num2)
									{
									case 1:
									{
										sbyte* ptr3 = global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_005B_005D(line, num4);
										std_002Eoperator_003C_003C_003Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_0020_003E(std_002Eoperator_003C_003C_003Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_0020_003E((basic_ostream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj2, 8)), 48), *ptr3);
										break;
									}
									case 2:
									{
										sbyte* ptr = global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_005B_005D(line, num4);
										sbyte* ptr2 = global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_005B_005D(line, num4 - 1);
										std_002Eoperator_003C_003C_003Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_0020_003E(std_002Eoperator_003C_003C_003Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_0020_003E((basic_ostream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj2, 8)), *ptr2), *ptr);
										break;
									}
									}
									num2 = 0;
									if (!flag)
									{
										goto IL_00f9;
									}
								}
								if (*global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_005B_005D(line, num3) != 32 && *global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_005B_005D(line, num3) != 9 && *global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_005B_005D(line, num3) != 58)
								{
									sbyte* ptr4 = global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_005B_005D(line, num3);
									std_002Eoperator_003C_003C_003Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_0020_003E((basic_ostream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj3, 8)), *ptr4);
								}
								goto IL_00f9;
								IL_00f9:
								num3++;
								num4++;
							}
							while (num3 < std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002Elength(line));
							switch (num2)
							{
							case 1:
							{
								sbyte* ptr7 = global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_005B_005D(line, std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002Elength(line) - 1);
								std_002Eoperator_003C_003C_003Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_0020_003E(std_002Eoperator_003C_003C_003Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_0020_003E((basic_ostream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj2, 8)), 48), *ptr7);
								break;
							}
							case 2:
							{
								sbyte* ptr5 = global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_005B_005D(line, std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002Elength(line) - 1);
								sbyte* ptr6 = global::_003CModule_003E.std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_005B_005D(line, std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002Elength(line) - 2);
								std_002Eoperator_003C_003C_003Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_0020_003E(std_002Eoperator_003C_003C_003Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_0020_003E((basic_ostream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj2, 8)), *ptr6), *ptr5);
								break;
							}
							}
						}
						System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj4);
						basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* ptr8 = std_002Ebasic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002Estr(&obj2, &obj4);
						try
						{
							result = atoi(std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002Edata(ptr8));
						}
						catch
						{
							//try-fault
							___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), &obj4);
							throw;
						}
						std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D(&obj4);
					}
					catch
					{
						//try-fault
						___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E__vbaseDtor), &obj3);
						throw;
					}
					std_002Ebasic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E__vbaseDtor(&obj3);
				}
				catch
				{
					//try-fault
					___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E__vbaseDtor), &obj2);
					throw;
				}
				std_002Ebasic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E__vbaseDtor(&obj2);
			}
			catch
			{
				//try-fault
				___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), &obj);
				throw;
			}
			std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D(&obj);
		}
		catch
		{
			//try-fault
			___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), line);
			throw;
		}
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D(line);
		return result;
	}

	internal unsafe static int HOLM_002EVersion_002EVersionNumber(string line)
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj);
		basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* ptr = &obj;
		basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* line2 = HOLM_002EMiscHelper_002EStringToStd(&obj, line);
		return HOLM_002EVersion_002EVersionNumber(line2);
	}

	internal static string HOLM_002EVersion_002EVersionString(int vn)
	{
		string text = "";
		int num = vn / 1000000;
		int num2 = num;
		text = string.Concat(text, num2 + ".");
		vn = num * -1000000 + vn;
		int num3 = vn / 10000;
		int num4 = num3;
		text = string.Concat(text, num4 + ".");
		vn = num3 * -10000 + vn;
		int num5 = vn / 100;
		int num6 = num5;
		text = string.Concat(text, num6 + ".");
		vn = num5 * -100 + vn;
		int num7 = vn;
		return text + num7;
	}

	internal unsafe static int HOLM_002EVersion_002EWWWVersion(string url)
	{
		int result = -1;
		try
		{
			result = HOLM_002EVersion_002EVersionNumber(new WebClient().DownloadString(url));
		}
		catch (Exception ex)
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj);
			std_002Ebasic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D(&obj, 3, 1);
			try
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj2);
				basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* ptr = HOLM_002EMiscHelper_002EStringToStd(&obj2, ex.ToString());
				try
				{
					std_002Eoperator_003C_003C_003Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_0020_003E(std_002Eoperator_003C_003C_003Cchar_002Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_002Cclass_0020std_003A_003Aallocator_003Cchar_003E_0020_003E(std_002Eoperator_003C_003C_003Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_0020_003E(std_002Eoperator_003C_003C_003Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_0020_003E((basic_ostream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 8)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_08ECDPJEFA_0040INFO_003F5_003F5_003F5_003F5_003F_0024AA_0040)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_0BJ_0040GMEPPIOJ_0040WWWVersion_003F_0024CI_003F_0024CJ_003F5Exception_003F3_003F6_003F_0024AA_0040)), ptr), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01EEMJAFIK_0040_003F6_003F_0024AA_0040));
				}
				catch
				{
					//try-fault
					___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), &obj2);
					throw;
				}
				std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D(&obj2);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj3);
				basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* ptr2 = std_002Ebasic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002Estr(&obj, &obj3);
				try
				{
					HOLM_002ELogging_002EHolmLogger_002ELogText(ptr2);
				}
				catch
				{
					//try-fault
					___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), &obj3);
					throw;
				}
				std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D(&obj3);
			}
			catch
			{
				//try-fault
				___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E__vbaseDtor), &obj);
				throw;
			}
			std_002Ebasic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E__vbaseDtor(&obj);
		}
		return result;
	}

	internal unsafe static int HOLM_002EVersion_002EFileVersion(string path)
	{
		int result = -1;
		if (File.Exists(path))
		{
			try
			{
				result = HOLM_002EVersion_002EVersionNumber(File.ReadAllText(path));
			}
			catch (Exception ex)
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj);
				std_002Ebasic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D(&obj, 3, 1);
				try
				{
					System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj2);
					basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* ptr = HOLM_002EMiscHelper_002EStringToStd(&obj2, ex.ToString());
					try
					{
						std_002Eoperator_003C_003C_003Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_0020_003E(std_002Eoperator_003C_003C_003Cchar_002Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_002Cclass_0020std_003A_003Aallocator_003Cchar_003E_0020_003E(std_002Eoperator_003C_003C_003Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_0020_003E(std_002Eoperator_003C_003C_003Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_0020_003E((basic_ostream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj, 8)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_08ECDPJEFA_0040INFO_003F5_003F5_003F5_003F5_003F_0024AA_0040)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_0BK_0040JLCOCJIJ_0040FileVersion_003F_0024CI_003F_0024CJ_003F5Exception_003F3_003F6_003F_0024AA_0040)), ptr), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01EEMJAFIK_0040_003F6_003F_0024AA_0040));
					}
					catch
					{
						//try-fault
						___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), &obj2);
						throw;
					}
					std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D(&obj2);
					System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj3);
					basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* ptr2 = std_002Ebasic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002Estr(&obj, &obj3);
					try
					{
						HOLM_002ELogging_002EHolmLogger_002ELogText(ptr2);
					}
					catch
					{
						//try-fault
						___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), &obj3);
						throw;
					}
					std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D(&obj3);
				}
				catch
				{
					//try-fault
					___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E__vbaseDtor), &obj);
					throw;
				}
				std_002Ebasic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E__vbaseDtor(&obj);
			}
		}
		return result;
	}

	internal static string HOLM_002EVersion_002EApplicationVersionString()
	{
		return Application.ProductVersion.ToString().Replace(", ", ".");
	}

	internal unsafe static int HOLM_002EVersion_002EApplicationVersion()
	{
		string s = Application.ProductVersion.ToString().Replace(", ", ".");
		System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E obj);
		basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* ptr = &obj;
		basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* line = HOLM_002EMiscHelper_002EStringToStd(&obj, s);
		return HOLM_002EVersion_002EVersionNumber(line);
	}

	internal unsafe static basic_ostream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E* std_002Eoperator_003C_003C_003Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_0020_003E(basic_ostream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E* _Ostr, sbyte _Ch)
	{
		int num = (int)stackalloc byte[__CxxQueryExceptionSize()];
		int num2 = 0;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out basic_ostream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E.sentry sentry);
		std_002Ebasic_ostream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E_002Esentry_002E_007Bctor_007D(&sentry, _Ostr);
		try
		{
			if (System.Runtime.CompilerServices.Unsafe.As<basic_ostream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E.sentry, bool>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref sentry, 4)))
			{
				int num3 = ((std_002Eios_base_002Ewidth((ios_base*)(*(int*)(*(int*)_Ostr + 4) + (byte*)_Ostr)) > 1) ? (std_002Eios_base_002Ewidth((ios_base*)(*(int*)(*(int*)_Ostr + 4) + (byte*)_Ostr)) - 1) : 0);
				try
				{
					if ((std_002Eios_base_002Eflags((ios_base*)(*(int*)(*(int*)_Ostr + 4) + (byte*)_Ostr)) & 0x1C0) == 64)
					{
						goto IL_0093;
					}
					while (num2 == 0)
					{
						if (0 < num3)
						{
							int num4 = std_002Ebasic_streambuf_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E_002Esputc(std_002Ebasic_ios_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E_002Erdbuf((basic_ios_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E*)(*(int*)(*(int*)_Ostr + 4) + (byte*)_Ostr)), std_002Ebasic_ios_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E_002Efill((basic_ios_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E*)(*(int*)(*(int*)_Ostr + 4) + (byte*)_Ostr)));
							int num5 = -1;
							if (std_002Echar_traits_003Cchar_003E_002Eeq_int_type(&num5, &num4))
							{
								num2 = 4;
							}
							num3--;
							continue;
						}
						goto IL_0093;
					}
					goto end_IL_003e;
					IL_0093:
					int num6 = std_002Ebasic_streambuf_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E_002Esputc(std_002Ebasic_ios_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E_002Erdbuf((basic_ios_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E*)(*(int*)(*(int*)_Ostr + 4) + (byte*)_Ostr)), _Ch);
					int num7 = -1;
					if (std_002Echar_traits_003Cchar_003E_002Eeq_int_type(&num7, &num6))
					{
						num2 = 4;
					}
					while (num2 == 0 && 0 < num3)
					{
						int num8 = std_002Ebasic_streambuf_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E_002Esputc(std_002Ebasic_ios_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E_002Erdbuf((basic_ios_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E*)(*(int*)(*(int*)_Ostr + 4) + (byte*)_Ostr)), std_002Ebasic_ios_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E_002Efill((basic_ios_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E*)(*(int*)(*(int*)_Ostr + 4) + (byte*)_Ostr)));
						int num9 = -1;
						if (std_002Echar_traits_003Cchar_003E_002Eeq_int_type(&num9, &num8))
						{
							num2 = 4;
						}
						num3--;
					}
					end_IL_003e:;
				}
				catch when (((Func<bool>)delegate
				{
					// Could not convert BlockContainer to single expression
					uint exceptionCode = (uint)Marshal.GetExceptionCode();
					return (byte)__CxxExceptionFilter((void*)Marshal.GetExceptionPointers(), null, 0, null) != 0;
				}).Invoke())
				{
					uint num10 = 0u;
					__CxxRegisterExceptionObject((void*)Marshal.GetExceptionPointers(), (void*)num);
					try
					{
						try
						{
							std_002Ebasic_ios_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E_002Esetstate((basic_ios_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E*)(*(int*)(*(int*)_Ostr + 4) + (byte*)_Ostr), 4, true);
							goto end_IL_011b;
						}
						catch when (((Func<bool>)delegate
						{
							// Could not convert BlockContainer to single expression
							num10 = (uint)__CxxDetectRethrow((void*)Marshal.GetExceptionPointers());
							return (byte)num10 != 0;
						}).Invoke())
						{
						}
						if (num10 != 0)
						{
							throw;
						}
						end_IL_011b:;
					}
					finally
					{
						__CxxUnregisterExceptionObject((void*)num, (int)num10);
					}
				}
			}
			std_002Eios_base_002Ewidth((ios_base*)(*(int*)(*(int*)_Ostr + 4) + (byte*)_Ostr), 0);
			std_002Ebasic_ios_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E_002Esetstate((basic_ios_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E*)(*(int*)(*(int*)_Ostr + 4) + (byte*)_Ostr), num2, false);
		}
		catch
		{
			//try-fault
			___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_ostream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E.sentry*, void>)(&std_002Ebasic_ostream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E_002Esentry_002E_007Bdtor_007D), &sentry);
			throw;
		}
		try
		{
			if (!std_002Euncaught_exception())
			{
				std_002Ebasic_ostream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E_002E_Osfx((basic_ostream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E*)(int)(*(uint*)(&sentry)));
			}
		}
		catch
		{
			//try-fault
			___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_ostream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E._Sentry_base*, void>)(&std_002Ebasic_ostream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E_002E_Sentry_base_002E_007Bdtor_007D), &sentry);
			throw;
		}
		if (std_002Ebasic_ios_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E_002Erdbuf((basic_ios_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E*)(*(int*)(*(int*)(int)(*(uint*)(&sentry)) + 4) + *(int*)(&sentry))) != null)
		{
			std_002Ebasic_streambuf_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E_002E_Unlock(std_002Ebasic_ios_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E_002Erdbuf((basic_ios_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E*)(*(int*)(*(int*)(int)(*(uint*)(&sentry)) + 4) + *(int*)(&sentry))));
		}
		return _Ostr;
	}

	internal static void _003FA0xf2abb64d_002E_003F_003F__E_003FA0xf2abb64d_0040PI_0040Math_0040HOLM_0040_0040YMXXZ()
	{
		HOLM_002EMath_002E_003FA0xf2abb64d_002EPI = Math.Acos(-1.0);
	}

	internal static void _003FA0xf2abb64d_002E_003F_003F__E_003FA0xf2abb64d_0040PI_F_0040Math_0040HOLM_0040_0040YMXXZ()
	{
		HOLM_002EMath_002E_003FA0xf2abb64d_002EPI_F = (float)Math.Acos(-1.0);
	}

	internal static void _003FA0xf2abb64d_002E_003F_003F__E_003FA0xf2abb64d_0040TWOPI_0040Math_0040HOLM_0040_0040YMXXZ()
	{
		HOLM_002EMath_002E_003FA0xf2abb64d_002ETWOPI = HOLM_002EMath_002E_003FA0xf2abb64d_002EPI * 2.0;
	}

	internal static void _003FA0xf2abb64d_002E_003F_003F__E_003FA0xf2abb64d_0040HALFPI_0040Math_0040HOLM_0040_0040YMXXZ()
	{
		HOLM_002EMath_002E_003FA0xf2abb64d_002EHALFPI = HOLM_002EMath_002E_003FA0xf2abb64d_002EPI * 0.5;
	}

	internal static void _003FA0xf2abb64d_002E_003F_003F__E_003FA0xf2abb64d_0040SQRT2_0040Math_0040HOLM_0040_0040YMXXZ()
	{
		HOLM_002EMath_002E_003FA0xf2abb64d_002ESQRT2 = Math.Sqrt(2.0);
	}

	internal static void _003FA0xf2abb64d_002E_003F_003F__E_003FA0xf2abb64d_0040SQRT2_F_0040Math_0040HOLM_0040_0040YMXXZ()
	{
		HOLM_002EMath_002E_003FA0xf2abb64d_002ESQRT2_F = (float)Math.Sqrt(2.0);
	}

	internal static void _003FA0xf2abb64d_002E_003F_003F__E_003FA0xf2abb64d_0040RadToDeg_0040Math_0040HOLM_0040_0040YMXXZ()
	{
		HOLM_002EMath_002E_003FA0xf2abb64d_002ERadToDeg = 180.0 / HOLM_002EMath_002E_003FA0xf2abb64d_002EPI;
	}

	internal static void _003FA0xf2abb64d_002E_003F_003F__E_003FA0xf2abb64d_0040RadToDeg_F_0040Math_0040HOLM_0040_0040YMXXZ()
	{
		HOLM_002EMath_002E_003FA0xf2abb64d_002ERadToDeg_F = (float)(180.0 / (double)HOLM_002EMath_002E_003FA0xf2abb64d_002EPI_F);
	}

	internal static void _003FA0xf2abb64d_002E_003F_003F__E_003FA0xf2abb64d_0040DegToRad_0040Math_0040HOLM_0040_0040YMXXZ()
	{
		HOLM_002EMath_002E_003FA0xf2abb64d_002EDegToRad = HOLM_002EMath_002E_003FA0xf2abb64d_002EPI / 180.0;
	}

	internal static void _003FA0xf2abb64d_002E_003F_003F__E_003FA0xf2abb64d_0040DegToRad_F_0040Math_0040HOLM_0040_0040YMXXZ()
	{
		HOLM_002EMath_002E_003FA0xf2abb64d_002EDegToRad_F = HOLM_002EMath_002E_003FA0xf2abb64d_002EPI_F / 180f;
	}

	internal unsafe static void _003FA0xf2abb64d_002E_003F_003F__E_003FA0xf2abb64d_0040HEXSTRINGARRAY_0040MiscHelper_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EMiscHelper_002E_003FA0xf2abb64d_002EHEXSTRINGARRAY), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01GBGANLPD_00400_003F_0024AA_0040));
		try
		{
			std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0xf2abb64d_002EHEXSTRINGARRAY, 28)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01HIHLOKLC_00401_003F_0024AA_0040));
			try
			{
				std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0xf2abb64d_002EHEXSTRINGARRAY, 56)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01FDFGLJHB_00402_003F_0024AA_0040));
				try
				{
					std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0xf2abb64d_002EHEXSTRINGARRAY, 84)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01EKENIIDA_00403_003F_0024AA_0040));
					try
					{
						std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0xf2abb64d_002EHEXSTRINGARRAY, 112)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01FAMBOPH_00404_003F_0024AA_0040));
						try
						{
							std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0xf2abb64d_002EHEXSTRINGARRAY, 140)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01BMBHCPLG_00405_003F_0024AA_0040));
							try
							{
								std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0xf2abb64d_002EHEXSTRINGARRAY, 168)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01DHDKHMHF_00406_003F_0024AA_0040));
								try
								{
									std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0xf2abb64d_002EHEXSTRINGARRAY, 196)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01COCBENDE_00407_003F_0024AA_0040));
									try
									{
										std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0xf2abb64d_002EHEXSTRINGARRAY, 224)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01KJLJFBPL_00408_003F_0024AA_0040));
										try
										{
											std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0xf2abb64d_002EHEXSTRINGARRAY, 252)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01LAKCGALK_00409_003F_0024AA_0040));
											try
											{
												std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0xf2abb64d_002EHEXSTRINGARRAY, 280)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01FHEEJDEE_0040A_003F_0024AA_0040));
												try
												{
													std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0xf2abb64d_002EHEXSTRINGARRAY, 308)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01HMGJMAIH_0040B_003F_0024AA_0040));
													try
													{
														std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0xf2abb64d_002EHEXSTRINGARRAY, 336)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01GFHCPBMG_0040C_003F_0024AA_0040));
														try
														{
															std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0xf2abb64d_002EHEXSTRINGARRAY, 364)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01CKDDGHAB_0040D_003F_0024AA_0040));
															try
															{
																std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0xf2abb64d_002EHEXSTRINGARRAY, 392)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01DDCIFGEA_0040E_003F_0024AA_0040));
																try
																{
																	std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0xf2abb64d_002EHEXSTRINGARRAY, 420)), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_01BIAFAFID_0040F_003F_0024AA_0040));
																}
																catch
																{
																	//try-fault
																	___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0xf2abb64d_002EHEXSTRINGARRAY, 392)));
																	throw;
																}
															}
															catch
															{
																//try-fault
																___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0xf2abb64d_002EHEXSTRINGARRAY, 364)));
																throw;
															}
														}
														catch
														{
															//try-fault
															___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0xf2abb64d_002EHEXSTRINGARRAY, 336)));
															throw;
														}
													}
													catch
													{
														//try-fault
														___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0xf2abb64d_002EHEXSTRINGARRAY, 308)));
														throw;
													}
												}
												catch
												{
													//try-fault
													___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0xf2abb64d_002EHEXSTRINGARRAY, 280)));
													throw;
												}
											}
											catch
											{
												//try-fault
												___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0xf2abb64d_002EHEXSTRINGARRAY, 252)));
												throw;
											}
										}
										catch
										{
											//try-fault
											___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0xf2abb64d_002EHEXSTRINGARRAY, 224)));
											throw;
										}
									}
									catch
									{
										//try-fault
										___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0xf2abb64d_002EHEXSTRINGARRAY, 196)));
										throw;
									}
								}
								catch
								{
									//try-fault
									___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0xf2abb64d_002EHEXSTRINGARRAY, 168)));
									throw;
								}
							}
							catch
							{
								//try-fault
								___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0xf2abb64d_002EHEXSTRINGARRAY, 140)));
								throw;
							}
						}
						catch
						{
							//try-fault
							___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0xf2abb64d_002EHEXSTRINGARRAY, 112)));
							throw;
						}
					}
					catch
					{
						//try-fault
						___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0xf2abb64d_002EHEXSTRINGARRAY, 84)));
						throw;
					}
				}
				catch
				{
					//try-fault
					___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0xf2abb64d_002EHEXSTRINGARRAY, 56)));
					throw;
				}
			}
			catch
			{
				//try-fault
				___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref HOLM_002EMiscHelper_002E_003FA0xf2abb64d_002EHEXSTRINGARRAY, 28)));
				throw;
			}
		}
		catch
		{
			//try-fault
			___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D), System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EMiscHelper_002E_003FA0xf2abb64d_002EHEXSTRINGARRAY));
			throw;
		}
		_atexit_m((delegate*<void>)(&_003FA0xf2abb64d_002E_003F_003F__F_003FA0xf2abb64d_0040HEXSTRINGARRAY_0040MiscHelper_0040HOLM_0040_0040YMXXZ));
	}

	internal unsafe static void _003FA0xf2abb64d_002E_003F_003F__F_003FA0xf2abb64d_0040HEXSTRINGARRAY_0040MiscHelper_0040HOLM_0040_0040YMXXZ()
	{
		__ehvec_dtor(System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EMiscHelper_002E_003FA0xf2abb64d_002EHEXSTRINGARRAY), 28u, 16, (delegate*<void*, void>)(delegate*<basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*, void>)(&std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D));
	}

	internal unsafe static void _003FA0xf2abb64d_002E_003F_003F__E_003FA0xf2abb64d_0040HOLM_WINDOW_FPGA_CTRL_0040MiscHelper_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EMiscHelper_002E_003FA0xf2abb64d_002EHOLM_WINDOW_FPGA_CTRL), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_0BD_0040CPFABDBC_0040HOLMFpgaController_003F_0024AA_0040));
		_atexit_m((delegate*<void>)(&_003FA0xf2abb64d_002E_003F_003F__F_003FA0xf2abb64d_0040HOLM_WINDOW_FPGA_CTRL_0040MiscHelper_0040HOLM_0040_0040YMXXZ));
	}

	internal unsafe static void _003FA0xf2abb64d_002E_003F_003F__F_003FA0xf2abb64d_0040HOLM_WINDOW_FPGA_CTRL_0040MiscHelper_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EMiscHelper_002E_003FA0xf2abb64d_002EHOLM_WINDOW_FPGA_CTRL));
	}

	internal unsafe static void _003FA0xf2abb64d_002E_003F_003F__E_003FA0xf2abb64d_0040HOLM_WINDOW_DSPreLab_0040MiscHelper_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EMiscHelper_002E_003FA0xf2abb64d_002EHOLM_WINDOW_DSPreLab), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_08LKNALPII_0040DSPreLab_003F_0024AA_0040));
		_atexit_m((delegate*<void>)(&_003FA0xf2abb64d_002E_003F_003F__F_003FA0xf2abb64d_0040HOLM_WINDOW_DSPreLab_0040MiscHelper_0040HOLM_0040_0040YMXXZ));
	}

	internal unsafe static void _003FA0xf2abb64d_002E_003F_003F__F_003FA0xf2abb64d_0040HOLM_WINDOW_DSPreLab_0040MiscHelper_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EMiscHelper_002E_003FA0xf2abb64d_002EHOLM_WINDOW_DSPreLab));
	}

	internal unsafe static void _003FA0xf2abb64d_002E_003F_003F__E_003FA0xf2abb64d_0040HOLM_WINDOW_DSPreLab_DEMO_0040MiscHelper_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EMiscHelper_002E_003FA0xf2abb64d_002EHOLM_WINDOW_DSPreLab_DEMO), (sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003F_003F_C_0040_0BA_0040MFILEGDE_0040DEMO_003F5_003F9_003F5DSPreLab_003F_0024AA_0040));
		_atexit_m((delegate*<void>)(&_003FA0xf2abb64d_002E_003F_003F__F_003FA0xf2abb64d_0040HOLM_WINDOW_DSPreLab_DEMO_0040MiscHelper_0040HOLM_0040_0040YMXXZ));
	}

	internal unsafe static void _003FA0xf2abb64d_002E_003F_003F__F_003FA0xf2abb64d_0040HOLM_WINDOW_DSPreLab_DEMO_0040MiscHelper_0040HOLM_0040_0040YMXXZ()
	{
		std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D((basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref HOLM_002EMiscHelper_002E_003FA0xf2abb64d_002EHOLM_WINDOW_DSPreLab_DEMO));
	}

	internal static void _003FA0xf2abb64d_002E_003F_003F__E_003FA0xf2abb64d_0040RunOnceCustomNewHandlerInt_0040Mem_0040_0040YMXXZ()
	{
		Mem_002E_003FA0xf2abb64d_002ERunOnceCustomNewHandlerInt = Mem_002ECustomNewHandlerInt();
	}

	internal unsafe static void HOLM_002ECallback(float* dBNow, float* dBSlow, float* dBPeak, int nch)
	{
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		FormVUMeter vUForm = VUMeterCtrl.GetVUForm();
		int num = decimal.ToInt32(vUForm.minDBUpDown.Value);
		int num2 = ((Control)vUForm.panel1).Height - 2;
		int num3 = ((Control)vUForm.panel1).Width - 2;
		SolidBrush val = new SolidBrush(((Control)vUForm).ForeColor);
		Pen val2 = new Pen(((Control)vUForm).ForeColor, 2f);
		Graphics val3 = ((Control)vUForm.scalePanel).CreateGraphics();
		Color backColor = ((Control)vUForm.scalePanel).BackColor;
		val3.Clear(backColor);
		int num4 = ((Control)vUForm.scalePanel).Height - 2;
		int num5 = num;
		int num6 = 10;
		if (num > -11)
		{
			num6 = 1;
		}
		else if (num > -51)
		{
			num6 = 5;
		}
		if (num <= 0)
		{
			float num7 = num;
			float num8 = num3;
			int num9 = num4 - 5;
			do
			{
				int num10 = (int)((1.0 - (double)(float)num5 / (double)num7) * (double)num8 + 20.0);
				if (num5 == 0)
				{
					val3.DrawString(0.ToString(), ((Control)vUForm.scalePanel).Font, (Brush)(object)val, (float)(num10 - 5), 0f);
				}
				else
				{
					int num11 = num5;
					val3.DrawString(num11.ToString(), ((Control)vUForm.scalePanel).Font, (Brush)(object)val, (float)(num10 - 10), 0f);
				}
				val3.DrawLine(val2, num10, num9, num10, num4);
				num5 = num6 + num5;
			}
			while (num5 <= 0);
		}
		int num12 = 0;
		if (0 < nch)
		{
			float* ptr = dBSlow;
			float* ptr2 = (float*)((byte*)dBNow - (nuint)dBSlow);
			float* ptr3 = (float*)((byte*)dBPeak - (nuint)dBSlow);
			while (num12 < 4)
			{
				float num13 = *(float*)((byte*)ptr2 + (nuint)ptr);
				float num14 = *ptr;
				float num15 = *(float*)((byte*)ptr3 + (nuint)ptr);
				float num7 = num;
				float num16 = (float)(1.0 - (double)num13 / (double)num7);
				if (num16 < 0f)
				{
					num16 = 0f;
				}
				else if (num16 > 1f)
				{
					num16 = 1f;
				}
				float num17 = (float)(1.0 - (double)num14 / (double)num7);
				if (num17 < 0f)
				{
					num17 = 0f;
				}
				else if (num17 > 1f)
				{
					num17 = 1f;
				}
				float num18 = (float)(1.0 - (double)num15 / (double)num7);
				if (num18 < 0f)
				{
					num18 = 0f;
				}
				else if (num18 > 1f)
				{
					num18 = 1f;
				}
				Graphics val4 = ((Control)vUForm.panels[num12]).CreateGraphics();
				float num8 = num3;
				int num19 = HOLM_002EMath_002EToIntRound((double)num8 * (double)num16);
				Color color = ((!((double)num16 > 0.999)) ? Color.Blue : Color.Red);
				val.Color = color;
				val4.FillRectangle((Brush)(object)val, 0, 0, num19, num2);
				int num20 = HOLM_002EMath_002EToIntRound((double)num8 * (double)num17);
				Color color2 = ((!((double)num17 > 0.999)) ? Color.DarkBlue : Color.DarkRed);
				val.Color = color2;
				val4.FillRectangle((Brush)(object)val, num19, 0, num20 - num19, num2);
				Color controlLight = SystemColors.ControlLight;
				val.Color = controlLight;
				val4.FillRectangle((Brush)(object)val, num20, 0, num3 - num20, num2);
				int num21 = HOLM_002EMath_002EToIntRound((double)num8 * (double)num18);
				if ((double)num18 > 0.999)
				{
					Color red = Color.Red;
					val.Color = red;
					val4.FillRectangle((Brush)(object)val, num21 - 3, 0, 3, num2);
				}
				else
				{
					Color darkBlue = Color.DarkBlue;
					val.Color = darkBlue;
					val4.FillRectangle((Brush)(object)val, num21 - 1, 0, 2, num2);
				}
				val4.Flush();
				num12++;
				ptr++;
				if (num12 >= nch)
				{
					break;
				}
			}
		}
		((IDisposable)val)?.Dispose();
		((IDisposable)val2)?.Dispose();
	}

	internal static void HOLM_002EStatusCallback(StreamStatus status)
	{
		VUMeterCtrl.NewStreamStatus(status);
	}

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern void* _getFiberPtrId();

	[DllImport("", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
	[MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public static extern void _amsg_exit(int P_0);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public static extern void __security_init_cookie();

	[DllImport("", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
	[MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public static extern void Sleep(uint P_0);

	[DllImport("", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
	[MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public static extern void _003CCrtImplementationDetails_003E_002EThrowModuleLoadException(string P_0, Exception P_1);

	[DllImport("", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
	[MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public static extern void _003CCrtImplementationDetails_003E_002EThrowModuleLoadException(string P_0);

	[DllImport("", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
	[MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public static extern void _003CCrtImplementationDetails_003E_002EDoDllLanguageSupportValidation();

	[DllImport("", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
	[MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public static extern void _003CCrtImplementationDetails_003E_002EThrowNestedModuleLoadException(Exception P_0, Exception P_1);

	[DllImport("", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
	[MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public static extern void _003CCrtImplementationDetails_003E_002ERegisterModuleUninitializer(EventHandler P_0);

	[DllImport("", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
	[MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern void _003CCrtImplementationDetails_003E_002EDoCallBackInDefaultDomain(delegate* unmanaged[Stdcall, Stdcall]<void*, int> P_0, void* P_1);

	[DllImport("", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
	[MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public static extern void _cexit();

	[DllImport("", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
	[MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public static extern void terminate();

	[DllImport("", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
	[MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern void* _encode_pointer(void* P_0);

	[DllImport("", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
	[MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern void* _decode_pointer(void* P_0);

	[DllImport("", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
	[MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern void* _encoded_null();

	[DllImport("", CallingConvention = CallingConvention.ThisCall, SetLastError = true)]
	[MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern locale.facet* std_002Elocale_002Efacet_002E_Decref(locale.facet* P_0);

	[DllImport("", CallingConvention = CallingConvention.ThisCall, SetLastError = true)]
	[MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D(basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* P_0, basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* P_1);

	[DllImport("", CallingConvention = CallingConvention.ThisCall, SetLastError = true)]
	[MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern void std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bdtor_007D(basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* P_0);

	[DllImport("", CallingConvention = CallingConvention.ThisCall, SetLastError = true)]
	[MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern sbyte* std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002Ec_str(basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* P_0);

	[DllImport("", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
	[MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern void* @new(uint P_0);

	[DllImport("", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
	[MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern void delete(void* P_0);

	[DllImport("", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
	[MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern void delete_005B_005D(void* P_0);

	[DllImport("", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
	[MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public static extern void std_002E_Lockit_002E_Lockit_ctor(int P_0);

	[DllImport("", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
	[MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public static extern void std_002E_Lockit_002E_Lockit_dtor(int P_0);

	[DllImport("", CallingConvention = CallingConvention.ThisCall, SetLastError = true)]
	[MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern exception* std_002Eexception_002E_007Bctor_007D(exception* P_0, exception* P_1);

	[DllImport("", CallingConvention = CallingConvention.ThisCall, SetLastError = true)]
	[MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern void std_002Eexception_002E_007Bdtor_007D(exception* P_0);

	[DllImport("", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
	[MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public static extern void abort();

	[DllImport("", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
	[MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern int __FrameUnwindFilter(_EXCEPTION_POINTERS* P_0);

	[DllImport("", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
	[MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern uint std_002Echar_traits_003Cchar_003E_002Elength(sbyte* P_0);

	[DllImport("", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
	[MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	[return: MarshalAs(UnmanagedType.U1)]
	public unsafe static extern bool std_002Echar_traits_003Cchar_003E_002Eeq_int_type(int* P_0, int* P_1);

	[DllImport("", CallingConvention = CallingConvention.ThisCall, SetLastError = true)]
	[MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	[return: MarshalAs(UnmanagedType.U1)]
	public unsafe static extern bool std_002Eios_base_002Egood(ios_base* P_0);

	[DllImport("", CallingConvention = CallingConvention.ThisCall, SetLastError = true)]
	[MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern int std_002Eios_base_002Eflags(ios_base* P_0);

	[DllImport("", CallingConvention = CallingConvention.ThisCall, SetLastError = true)]
	[MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern int std_002Eios_base_002Ewidth(ios_base* P_0);

	[DllImport("", CallingConvention = CallingConvention.ThisCall, SetLastError = true)]
	[MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern int std_002Eios_base_002Ewidth(ios_base* P_0, int P_1);

	[DllImport("", CallingConvention = CallingConvention.ThisCall, SetLastError = true)]
	[MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern complex_003Cdouble_003E* std_002Ecomplex_003Cdouble_003E_002E_007Bctor_007D(complex_003Cdouble_003E* P_0, double* P_1, double* P_2);

	[DllImport("", CallingConvention = CallingConvention.ThisCall, SetLastError = true)]
	[MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern void std_002Ebasic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E__vbaseDtor(basic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* P_0);

	[DllImport("", CallingConvention = CallingConvention.ThisCall, SetLastError = true)]
	[MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D(basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* P_0, sbyte* P_1);

	[DllImport("", CallingConvention = CallingConvention.ThisCall, SetLastError = true)]
	[MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern void std_002Ebasic_ios_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E_002Esetstate(basic_ios_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E* P_0, int P_1, [MarshalAs(UnmanagedType.U1)] bool P_2);

	[DllImport("", CallingConvention = CallingConvention.ThisCall, SetLastError = true)]
	[MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern basic_streambuf_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E* std_002Ebasic_ios_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E_002Erdbuf(basic_ios_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E* P_0);

	[DllImport("", CallingConvention = CallingConvention.ThisCall, SetLastError = true)]
	[MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern basic_ostream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E* std_002Ebasic_ostream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E_002E_003C_003C(basic_ostream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E* P_0, int P_1);

	[DllImport("", CallingConvention = CallingConvention.ThisCall, SetLastError = true)]
	[MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern basic_ostream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E* std_002Ebasic_ostream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E_002Eflush(basic_ostream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E* P_0);

	[DllImport("", CallingConvention = CallingConvention.ThisCall, SetLastError = true)]
	[MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern basic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* std_002Ebasic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D(basic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* P_0, int P_1, int P_2);

	[DllImport("", CallingConvention = CallingConvention.ThisCall, SetLastError = true)]
	[MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* std_002Ebasic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002Estr(basic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* P_0, basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* P_1);

	[DllImport("", CallingConvention = CallingConvention.ThisCall, SetLastError = true)]
	[MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern int std_002Ebasic_streambuf_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E_002Esputc(basic_streambuf_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E* P_0, sbyte P_1);

	[DllImport("", CallingConvention = CallingConvention.ThisCall, SetLastError = true)]
	[MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern void std_002Ebasic_streambuf_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E_002E_Unlock(basic_streambuf_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E* P_0);

	[DllImport("", CallingConvention = CallingConvention.ThisCall, SetLastError = true)]
	[MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern sbyte std_002Ebasic_ios_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E_002Efill(basic_ios_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E* P_0);

	[DllImport("", CallingConvention = CallingConvention.ThisCall, SetLastError = true)]
	[MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern void std_002Ebasic_streambuf_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E_002E_Lock(basic_streambuf_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E* P_0);

	[DllImport("", CallingConvention = CallingConvention.ThisCall, SetLastError = true)]
	[MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern basic_ostream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E* std_002Ebasic_ios_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E_002Etie(basic_ios_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E* P_0);

	[DllImport("", CallingConvention = CallingConvention.ThisCall, SetLastError = true)]
	[MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern void std_002Ebasic_ostream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E_002E_Osfx(basic_ostream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E* P_0);

	[DllImport("", CallingConvention = CallingConvention.ThisCall, SetLastError = true)]
	[MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern int std_002Ebasic_streambuf_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E_002Esputn(basic_streambuf_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E* P_0, sbyte* P_1, int P_2);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern void HOLM_002ELogging_002EHolmLogger_002EInitialize(basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* P_0);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern void HOLM_002ELogging_002EHolmLogger_002ELogText(basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* P_0);

	[DllImport("", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
	[MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public static extern int __CxxQueryExceptionSize();

	[DllImport("", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
	[MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern int __CxxDetectRethrow(void* P_0);

	[DllImport("", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
	[MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern void __CxxUnregisterExceptionObject(void* P_0, int P_1);

	[DllImport("", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
	[MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern int __CxxExceptionFilter(void* P_0, void* P_1, int P_2, void* P_3);

	[DllImport("", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
	[MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern int __CxxRegisterExceptionObject(void* P_0, void* P_1);

	[DllImport("", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
	[MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	[return: MarshalAs(UnmanagedType.U1)]
	public static extern bool std_002Euncaught_exception();

	[DllImport("", CallingConvention = CallingConvention.ThisCall, SetLastError = true)]
	[MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern sbyte* std_002Eexception_002Ewhat(exception* P_0);

	[DllImport("", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
	[MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern basic_ostream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E* std_002Eoperator_003C_003C_003Cchar_002Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_002Cclass_0020std_003A_003Aallocator_003Cchar_003E_0020_003E(basic_ostream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E* P_0, basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* P_1);

	[DllImport("", CallingConvention = CallingConvention.ThisCall, SetLastError = true)]
	[MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern sbyte* std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002Edata(basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* P_0);

	[DllImport("", CallingConvention = CallingConvention.ThisCall, SetLastError = true)]
	[MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern basic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E* std_002Ebasic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E_002E_007Bctor_007D(basic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E* P_0, char* P_1);

	[DllImport("", CallingConvention = CallingConvention.ThisCall, SetLastError = true)]
	[MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern basic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E* std_002Ebasic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E_002E_007Bctor_007D(basic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E* P_0, basic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E* P_1);

	[DllImport("", CallingConvention = CallingConvention.ThisCall, SetLastError = true)]
	[MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern void std_002Ebasic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E_002E_007Bdtor_007D(basic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E* P_0);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public static extern double HOLM_002EMath_002EDBToAmplitude_003Cdouble_003E(double P_0);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern vector_003Cstd_003A_003Abasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002Cstd_003A_003Aallocator_003Cstd_003A_003Abasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_0020_003E_0020_003E* HOLM_002ETokenize(vector_003Cstd_003A_003Abasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002Cstd_003A_003Aallocator_003Cstd_003A_003Abasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_0020_003E_0020_003E* P_0, basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* P_1, basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* P_2);

	[DllImport("", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
	[MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public static extern double floor(double P_0);

	[DllImport("", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
	[MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public static extern void _invalid_parameter_noinfo();

	[DllImport("", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
	[MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern int atoi(sbyte* P_0);

	[DllImport("", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
	[MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* std_002Eoperator_002B_003Cchar_002Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_002Cclass_0020std_003A_003Aallocator_003Cchar_003E_0020_003E(basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* P_0, basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* P_1, sbyte* P_2);

	[DllImport("", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
	[MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern basic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E* std_002Eoperator_002B_003Cwchar_t_002Cstruct_0020std_003A_003Achar_traits_003Cwchar_t_003E_002Cclass_0020std_003A_003Aallocator_003Cwchar_t_003E_0020_003E(basic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E* P_0, basic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E* P_1, char* P_2);

	[DllImport("", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
	[MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* std_002Eoperator_002B_003Cchar_002Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_002Cclass_0020std_003A_003Aallocator_003Cchar_003E_0020_003E(basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* P_0, basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* P_1, basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* P_2);

	[DllImport("", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
	[MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern basic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E* std_002Eoperator_002B_003Cwchar_t_002Cstruct_0020std_003A_003Achar_traits_003Cwchar_t_003E_002Cclass_0020std_003A_003Aallocator_003Cwchar_t_003E_0020_003E(basic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E* P_0, basic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E* P_1, basic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E* P_2);

	[DllImport("", CallingConvention = CallingConvention.ThisCall, SetLastError = true)]
	[MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern complex_003Cdouble_003E* std_002Ecomplex_003Cdouble_003E_002E_003D(complex_003Cdouble_003E* P_0, double* P_1);

	[DllImport("", CallingConvention = CallingConvention.ThisCall, SetLastError = true)]
	[MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_003D(basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* P_0, basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* P_1);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern void HOLM_002EMeasure_002EApplyMinimumPhase(complex_003Cdouble_003E* P_0, int P_1, [MarshalAs(UnmanagedType.U1)] bool P_2, double P_3);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern void HOLM_002EMeasure_002EResponse_002ESetFilterLowpass(Response* P_0, double P_1);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern void HOLM_002EMeasure_002EResponse_002ESetFilterHighpass(Response* P_0, double P_1);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern void HOLM_002EMeasure_002EResponse_002ESetNofFilterTaps(Response* P_0, int P_1);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern void HOLM_002EMeasure_002EResponse_002EDisableFilterLowpass(Response* P_0);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern void HOLM_002EMeasure_002EResponse_002EDisableFilterHighpass(Response* P_0);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	[return: MarshalAs(UnmanagedType.U1)]
	public unsafe static extern bool HOLM_002EMeasure_002EOperation(basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* P_0, Measurement* P_1, Measurement* P_2, Measurement* P_3);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern MeasurementCore* HOLM_002EMeasure_002EMeasurementCore_002E_007Bctor_007D(MeasurementCore* P_0, basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* P_1);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern void HOLM_002EMeasure_002EMeasurementCore_002E_007Bdtor_007D(MeasurementCore* P_0);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern complex_003Cdouble_003E* HOLM_002EMeasure_002EMeasurementCore_002EGetF0(MeasurementCore* P_0);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern complex_003Cdouble_003E* HOLM_002EMeasure_002EMeasurementCore_002EGetF0Writeable(MeasurementCore* P_0);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern void HOLM_002EMeasure_002EMeasurementCore_002EF0Written(MeasurementCore* P_0);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern void HOLM_002EMeasure_002EMeasurementCore_002EAmplifyAbsolute(MeasurementCore* P_0, double P_1);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern void HOLM_002EMeasure_002EMeasurementCore_002EOffsetAbsolute(MeasurementCore* P_0, double P_1);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern void HOLM_002EMeasure_002EMeasurementCore_002ECopyAllFrom(MeasurementCore* P_0, MeasurementCore* P_1);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern void HOLM_002EMeasure_002EMeasurementCore_002ECopyFilterFrom(MeasurementCore* P_0, MeasurementCore* P_1);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern void HOLM_002EMeasure_002EMeasurementCore_002ECopyImpulseWindowFrom(MeasurementCore* P_0, MeasurementCore* P_1);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern void HOLM_002EMeasure_002EMeasurementCore_002ESetSmoothNOct(MeasurementCore* P_0, double P_1);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern void HOLM_002EMeasure_002EMeasurementCore_002ESetImpulseWindowEnabled(MeasurementCore* P_0, [MarshalAs(UnmanagedType.U1)] bool P_1);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern void HOLM_002EMeasure_002EMeasurementCore_002ESetSmoothingEnabled(MeasurementCore* P_0, [MarshalAs(UnmanagedType.U1)] bool P_1);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern void HOLM_002EMeasure_002EMeasurementCore_002ESetImpulseWindowEnd(MeasurementCore* P_0, int P_1);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern void HOLM_002EMeasure_002EMeasurement_002EInitializeDirac(Measurement* P_0, int P_1, int P_2, double P_3);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern void HOLM_002EMeasure_002EMeasurement_002EInitializeFreq(Measurement* P_0, complex_003Cdouble_003E* P_1, int P_2, int P_3, int P_4, SignalType P_5, double P_6, double P_7, [MarshalAs(UnmanagedType.U1)] bool P_8);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern void HOLM_002EMeasure_002EMeasurement_002EInitializeFilter(Measurement* P_0, FilterBasic* P_1);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	[return: MarshalAs(UnmanagedType.U1)]
	public unsafe static extern bool HOLM_002EMeasure_002EStitch(Measurement* P_0, Measurement* P_1, Measurement* P_2, double P_3, double P_4, [MarshalAs(UnmanagedType.U1)] bool P_5);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	[return: MarshalAs(UnmanagedType.U1)]
	public unsafe static extern bool HOLM_002EMeasure_002EQBoxFit(Measurement* P_0, double* P_1, double* P_2, double* P_3, double P_4, double P_5);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	[return: MarshalAs(UnmanagedType.U1)]
	public unsafe static extern bool HOLM_002EMeasure_002EMatch(Measurement* P_0, Measurement* P_1, double P_2, double P_3, [MarshalAs(UnmanagedType.U1)] bool P_4);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public static extern int HOLM_002EMath_002EToIntRound(double P_0);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public static extern double HOLM_002EMath_002EAmplitudeToDB_003Cdouble_003E(double P_0);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern complex_003Cdouble_003E* HOLM_002EMath_002EInverse_003Cdouble_003E(complex_003Cdouble_003E* P_0, complex_003Cdouble_003E* P_1);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern QBox* HOLM_002EFilter_002EQBox_002E_007Bctor_007D(QBox* P_0, double P_1, double P_2);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern double HOLM_002EFilter_002EQBox_002EAmplitude(QBox* P_0, double P_1);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public static extern void HOLM_002EFilter_002ECleanUp();

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public static extern void HOLM_002EPAudioII_002ECleanUp();

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern StreamInitializer* HOLM_002EPAudioII_002EStream();

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern void HOLM_002EPAudioII_002EStreamInitializer_002EStop(StreamInitializer* P_0);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* HOLM_002ELogging_002EGetDebugFlags(basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* P_0);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern complex_003Cdouble_003E* Mem_002EAllocateArray_003Cclass_0020std_003A_003Acomplex_003Cdouble_003E_0020_003E(uint P_0);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public static extern int Mem_002ECustomNewHandlerInt();

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern void Mem_002EFreeArray_003Cclass_0020std_003A_003Acomplex_003Cdouble_003E_0020_003E(complex_003Cdouble_003E** P_0, uint P_1);

	[DllImport("", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
	[MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public static extern double pow(double P_0, double P_1);

	[DllImport("", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
	[MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* std_002Eoperator_002B_003Cchar_002Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_002Cclass_0020std_003A_003Aallocator_003Cchar_003E_0020_003E(basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* P_0, sbyte* P_1, basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* P_2);

	[DllImport("", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
	[MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern double std_002Eabs_003Cdouble_003E(complex_003Cdouble_003E* P_0);

	[DllImport("", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
	[MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	[return: MarshalAs(UnmanagedType.U1)]
	public unsafe static extern bool std_002Eoperator_003D_003D_003Cchar_002Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_002Cclass_0020std_003A_003Aallocator_003Cchar_003E_0020_003E(basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* P_0, sbyte* P_1);

	[DllImport("", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
	[MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	[return: MarshalAs(UnmanagedType.U1)]
	public unsafe static extern bool std_002Eoperator_003D_003D_003Cwchar_t_002Cstruct_0020std_003A_003Achar_traits_003Cwchar_t_003E_002Cclass_0020std_003A_003Aallocator_003Cwchar_t_003E_0020_003E(basic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E* P_0, char* P_1);

	[DllImport("", CallingConvention = CallingConvention.ThisCall, SetLastError = true)]
	[MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_003D(basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* P_0, sbyte* P_1);

	[DllImport("", CallingConvention = CallingConvention.ThisCall, SetLastError = true)]
	[MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern basic_ostream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E* std_002Ebasic_ostream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E_002E_003C_003C(basic_ostream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_0020_003E* P_0, uint P_1);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern void HOLM_002EMeasure_002EResponse_002E_007Bdtor_007D(Response* P_0);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	[return: MarshalAs(UnmanagedType.U1)]
	public unsafe static extern bool HOLM_002EMeasure_002EResponse_002EMeasure(Response* P_0, int P_1, complex_003Cdouble_003E* P_2, int P_3, PCMGenerator* P_4);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	[return: MarshalAs(UnmanagedType.U1)]
	public unsafe static extern bool HOLM_002EMeasure_002EResponse_002EMeasureFiltered(Response* P_0, int P_1, complex_003Cdouble_003E* P_2, int P_3, PCMGenerator* P_4, Measurement* P_5);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern void HOLM_002EMeasure_002EResponse_002EPostInitializeMeasurement(Response* P_0, Measurement* P_1);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern int HOLM_002EMeasure_002EResponse_002EGetNofFilterTaps(Response* P_0);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern void HOLM_002EMeasure_002EResponse_002EUpdateFromPAudio(Response* P_0);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern double* HOLM_002EMeasure_002EMeasurementCore_002EGetA(MeasurementCore* P_0);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern void HOLM_002EMeasure_002EMeasurementCore_002EAmplify(MeasurementCore* P_0, double P_1);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern void HOLM_002EMeasure_002EMeasurementCore_002ESetImpulseWindowStart(MeasurementCore* P_0, int P_1, [MarshalAs(UnmanagedType.U1)] bool P_2);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern void HOLM_002EMeasure_002EMeasurementCore_002EPostInitSetDateNow(MeasurementCore* P_0);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern void HOLM_002EMeasure_002EMeasurementList_002ESetMAnalysis(MeasurementList* P_0, int P_1);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern double HOLM_002EMeasure_002EMeasurement_002EGetFreqPeak(Measurement* P_0, int P_1, [MarshalAs(UnmanagedType.U1)] bool P_2);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern double HOLM_002EMeasure_002EMeasurement_002EGetForgAvg(Measurement* P_0, double P_1, double P_2, [MarshalAs(UnmanagedType.U1)] bool P_3);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern void HOLM_002EMeasure_002EMeasurement_002EPostMeasureStandard(Measurement* P_0, int P_1, int P_2, int P_3, HOLM.Measure.ApplicationId P_4, [MarshalAs(UnmanagedType.U1)] bool P_5);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern void HOLM_002EMeasure_002EMeasurement_002EApplyHighpass(Measurement* P_0, int P_1, int P_2);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern Calibrator* HOLM_002EMeasure_002ECalibrator_002E_007Bctor_007D(Calibrator* P_0);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern void HOLM_002EMeasure_002ECalibrator_002E_007Bdtor_007D(Calibrator* P_0);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern void HOLM_002EMeasure_002ECalibrator_002EImport(Calibrator* P_0, Measurement* P_1, double P_2, double P_3);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	[return: MarshalAs(UnmanagedType.U1)]
	public unsafe static extern bool HOLM_002EMeasure_002ECalibrator_002EOpen(Calibrator* P_0, basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* P_1);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern void HOLM_002EMeasure_002ECalibrator_002ESave(Calibrator* P_0, basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* P_1);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern void HOLM_002EMeasure_002ECalibrator_002ESetActive(Calibrator* P_0, [MarshalAs(UnmanagedType.U1)] bool P_1);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public static extern float HOLM_002EMath_002EAmplitudeToDB_003Cfloat_003E(float P_0);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	[return: MarshalAs(UnmanagedType.U1)]
	public unsafe static extern bool HOLM_002EFilter_002EEffect_002EIsEnabled(Effect* P_0);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern double HOLM_002EFilter_002EEffectPass_002EGetFreqBand(EffectPass* P_0);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern double HOLM_002EFilter_002EEffectPass_002EGetFreqCenter(EffectPass* P_0);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern void HOLM_002EPAudioII_002EPCMGenerator_002ESetTriggerMode(PCMGenerator* P_0, [MarshalAs(UnmanagedType.U1)] bool P_1);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern SineSweepSingle* HOLM_002EPAudioII_002ESineSweepSingle_002E_007Bctor_007D(SineSweepSingle* P_0);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E* HOLM_002EPAudioII_002EGetOutDevices(vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E* P_0, PaApiType P_1);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern SquareNoise* HOLM_002EPAudioII_002ESquareNoise_002E_007Bctor_007D(SquareNoise* P_0);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern PaDeviceInfo* HOLM_002EPAudioII_002EGetDeviceInfo(int P_0);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* HOLM_002EPAudioII_002EGetHostApiName(basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* P_0, int P_1);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* HOLM_002EPAudioII_002EGetDeviceName(basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* P_0, int P_1, [MarshalAs(UnmanagedType.U1)] bool P_2);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public static extern int HOLM_002EPAudioII_002EChToChMask(int P_0);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E* HOLM_002EPAudioII_002EGetInDevices(vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E* P_0, PaApiType P_1);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	[return: MarshalAs(UnmanagedType.U1)]
	public static extern bool HOLM_002EPAudioII_002EPaInitializer_002EEnsureInitialized();

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	[return: MarshalAs(UnmanagedType.U1)]
	public static extern bool HOLM_002EPAudioII_002EPaInitializer_002EReInitialize();

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern void HOLM_002EPAudioII_002EStreamInitializer_002ESetOutDevice(StreamInitializer* P_0, int P_1, int P_2, [MarshalAs(UnmanagedType.U1)] bool P_3);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern void HOLM_002EPAudioII_002EStreamInitializer_002ESetInDevice(StreamInitializer* P_0, int P_1, int P_2, [MarshalAs(UnmanagedType.U1)] bool P_3);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern void HOLM_002EPAudioII_002EStreamInitializer_002ESetInInverted(StreamInitializer* P_0, [MarshalAs(UnmanagedType.U1)] bool P_1);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern void HOLM_002EPAudioII_002EStreamInitializer_002ESetOutVolume(StreamInitializer* P_0, float P_1);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern void HOLM_002EPAudioII_002EStreamInitializer_002ESetOutChMask(StreamInitializer* P_0, int P_1);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern int HOLM_002EPAudioII_002EStreamInitializer_002EGetOutChMask(StreamInitializer* P_0);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern void HOLM_002EPAudioII_002EStreamInitializer_002ESetSamplerate(StreamInitializer* P_0, int P_1);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern void HOLM_002EPAudioII_002EStreamInitializer_002EStart(StreamInitializer* P_0);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* HOLM_002EPAudioII_002EStreamInitializer_002EGetPaErrorText(StreamInitializer* P_0, basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* P_1);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern void HOLM_002EPAudioII_002EShowDeviceInfo(basic_stringstream_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* P_0);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern SineLogSweep* HOLM_002EPAudioII_002ESineLogSweep_002E_007Bctor_007D(SineLogSweep* P_0);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern double HOLM_002EPAudioII_002ESineLogSweep_002EGetHDTimeConstant(SineLogSweep* P_0);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	[return: MarshalAs(UnmanagedType.U1)]
	public static extern bool HOLM_002EPAudioII_002EIsChInMask(int P_0, int P_1);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public static extern WaveFormat HOLM_002EWaveImExport_002ENumberToWaveFormat(int P_0);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern void Mem_002EFreeArrayNoRef_003Cclass_0020std_003A_003Acomplex_003Cdouble_003E_0020_003E(complex_003Cdouble_003E* P_0, uint P_1);

	[DllImport("", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
	[MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern void _CxxThrowException(void* P_0, _s__ThrowInfo* P_1);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern int PaAsio_ShowControlPanel(int P_0, void* P_1);

	[DllImport("", CallingConvention = CallingConvention.ThisCall, SetLastError = true)]
	[MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern exception* std_002Eexception_002E_007Bctor_007D(exception* P_0, sbyte** P_1);

	[DllImport("", CallingConvention = CallingConvention.ThisCall, SetLastError = true)]
	[MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern exception* std_002Eexception_002E_007Bctor_007D(exception* P_0);

	[DllImport("", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
	[MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern int memmove_s(void* P_0, uint P_1, void* P_2, uint P_3);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public static extern double HOLM_002EMath_002ELog10Safe_003Cdouble_003E(double P_0);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public static extern double HOLM_002EMath_002ENegPow10(int P_0);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public static extern int HOLM_002EMath_002EPow10(int P_0);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public static extern int HOLM_002EMath_002EToIntFloor(double P_0);

	[DllImport("", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
	[MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public static extern double fabs(double P_0);

	[DllImport("", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
	[MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public static extern int abs(int P_0);

	[DllImport("", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
	[MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern uint std_002Echar_traits_003Cwchar_t_003E_002Elength(char* P_0);

	[DllImport("", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
	[MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	[return: MarshalAs(UnmanagedType.U1)]
	public unsafe static extern bool std_002Echar_traits_003Cwchar_t_003E_002Eeq_int_type(ushort* P_0, ushort* P_1);

	[DllImport("", CallingConvention = CallingConvention.ThisCall, SetLastError = true)]
	[MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern uint std_002Elocale_002Eid_002E_002EI(locale.id* P_0);

	[DllImport("", CallingConvention = CallingConvention.ThisCall, SetLastError = true)]
	[MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern void std_002Elocale_002Efacet_002E_Incref(locale.facet* P_0);

	[DllImport("", CallingConvention = CallingConvention.ThisCall, SetLastError = true)]
	[MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern void std_002Elocale_002E_007Bdtor_007D(locale* P_0);

	[DllImport("", CallingConvention = CallingConvention.ThisCall, SetLastError = true)]
	[MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern locale.facet* std_002Elocale_002E_Getfacet(locale* P_0, uint P_1);

	[DllImport("", CallingConvention = CallingConvention.ThisCall, SetLastError = true)]
	[MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	[return: MarshalAs(UnmanagedType.U2)]
	public unsafe static extern char std_002Ectype_003Cwchar_t_003E_002Ewiden(ctype_003Cwchar_t_003E* P_0, sbyte P_1);

	[DllImport("", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
	[MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern uint std_002Ectype_003Cwchar_t_003E_002E_Getcat(locale.facet** P_0, locale* P_1);

	[DllImport("", CallingConvention = CallingConvention.ThisCall, SetLastError = true)]
	[MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern locale* std_002Eios_base_002Egetloc(ios_base* P_0, locale* P_1);

	[DllImport("", CallingConvention = CallingConvention.ThisCall, SetLastError = true)]
	[MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern complex_003Cdouble_003E* std_002Ecomplex_003Cdouble_003E_002E_002B_003D(complex_003Cdouble_003E* P_0, complex_003Cdouble_003E* P_1);

	[DllImport("", CallingConvention = CallingConvention.ThisCall, SetLastError = true)]
	[MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern void std_002Ebasic_stringstream_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E_002E__vbaseDtor(basic_stringstream_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E* P_0);

	[DllImport("", CallingConvention = CallingConvention.ThisCall, SetLastError = true)]
	[MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern void std_002Ebasic_ios_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_0020_003E_002Esetstate(basic_ios_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_0020_003E* P_0, int P_1, [MarshalAs(UnmanagedType.U1)] bool P_2);

	[DllImport("", CallingConvention = CallingConvention.ThisCall, SetLastError = true)]
	[MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern basic_streambuf_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_0020_003E* std_002Ebasic_ios_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_0020_003E_002Erdbuf(basic_ios_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_0020_003E* P_0);

	[DllImport("", CallingConvention = CallingConvention.ThisCall, SetLastError = true)]
	[MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern basic_ostream_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_0020_003E* std_002Ebasic_ostream_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_0020_003E_002Eflush(basic_ostream_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_0020_003E* P_0);

	[DllImport("", CallingConvention = CallingConvention.ThisCall, SetLastError = true)]
	[MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern basic_stringstream_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E* std_002Ebasic_stringstream_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E_002E_007Bctor_007D(basic_stringstream_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E* P_0, int P_1, int P_2);

	[DllImport("", CallingConvention = CallingConvention.ThisCall, SetLastError = true)]
	[MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern basic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E* std_002Ebasic_stringstream_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E_002Estr(basic_stringstream_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E* P_0, basic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E* P_1);

	[DllImport("", CallingConvention = CallingConvention.ThisCall, SetLastError = true)]
	[MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern ushort std_002Ebasic_streambuf_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_0020_003E_002Esputc(basic_streambuf_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_0020_003E* P_0, [MarshalAs(UnmanagedType.U2)] char P_1);

	[DllImport("", CallingConvention = CallingConvention.ThisCall, SetLastError = true)]
	[MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern void std_002Ebasic_streambuf_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_0020_003E_002E_Unlock(basic_streambuf_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_0020_003E* P_0);

	[DllImport("", CallingConvention = CallingConvention.ThisCall, SetLastError = true)]
	[MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern void std_002Ebasic_streambuf_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_0020_003E_002E_Lock(basic_streambuf_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_0020_003E* P_0);

	[DllImport("", CallingConvention = CallingConvention.ThisCall, SetLastError = true)]
	[MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern basic_ostream_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_0020_003E* std_002Ebasic_ios_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_0020_003E_002Etie(basic_ios_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_0020_003E* P_0);

	[DllImport("", CallingConvention = CallingConvention.ThisCall, SetLastError = true)]
	[MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern void std_002Ebasic_ostream_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_0020_003E_002E_Osfx(basic_ostream_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_0020_003E* P_0);

	[DllImport("", CallingConvention = CallingConvention.ThisCall, SetLastError = true)]
	[MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern int std_002Ebasic_streambuf_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_0020_003E_002Esputn(basic_streambuf_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_0020_003E* P_0, char* P_1, int P_2);

	[DllImport("", CallingConvention = CallingConvention.ThisCall, SetLastError = true)]
	[MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	[return: MarshalAs(UnmanagedType.U2)]
	public unsafe static extern char std_002Ebasic_ios_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_0020_003E_002Efill(basic_ios_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_0020_003E* P_0);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern complex_003Cdouble_003E* HOLM_002EMeasure_002EMeasurementCore_002EGetF(MeasurementCore* P_0);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern double* HOLM_002EMeasure_002EMeasurementCore_002EGetI(MeasurementCore* P_0);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern float HOLM_002EMeasure_002EMeasurementCore_002EGetHDSmoothInterpolated(MeasurementCore* P_0, int P_1, float P_2);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern float* HOLM_002EMeasure_002EMeasurementCore_002EGetHDSmooth(MeasurementCore* P_0, int P_1);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* HOLM_002EMeasure_002EMeasurementCore_002EGetInfo(MeasurementCore* P_0, basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* P_1);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern int HOLM_002EMeasure_002EMeasurementCore_002EGetHDSize(MeasurementCore* P_0);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern double HOLM_002EMeasure_002EMeasurementCore_002EGetIInterpolated(MeasurementCore* P_0, double P_1);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	[return: MarshalAs(UnmanagedType.U1)]
	public unsafe static extern bool HOLM_002EMeasure_002EMeasurementCore_002ESafeN(MeasurementCore* P_0, double P_1);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern complex_003Cdouble_003E* HOLM_002EMeasure_002EMeasurementCore_002EGetFInterpolatedK(MeasurementCore* P_0, complex_003Cdouble_003E* P_1, double P_2);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern void HOLM_002EMeasure_002EMeasurementCore_002EUninitialize(MeasurementCore* P_0);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern void HOLM_002EMeasure_002EMeasurementCore_002EReset(MeasurementCore* P_0, basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* P_1);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern double HOLM_002EMeasure_002EMeasurementCore_002EWindowAmplitude(MeasurementCore* P_0, double P_1);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern void HOLM_002EMeasure_002EMeasurementCore_002ESetLowpassEnabled(MeasurementCore* P_0, [MarshalAs(UnmanagedType.U1)] bool P_1);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern void HOLM_002EMeasure_002EMeasurementCore_002ESetLowpass(MeasurementCore* P_0, double P_1, double P_2);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern void HOLM_002EMeasure_002EMeasurementCore_002ESetHighpassEnabled(MeasurementCore* P_0, [MarshalAs(UnmanagedType.U1)] bool P_1);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern void HOLM_002EMeasure_002EMeasurementCore_002ESetHighpass(MeasurementCore* P_0, double P_1, double P_2);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern void HOLM_002EMeasure_002EMeasurementCore_002ESetSmoothingComplex(MeasurementCore* P_0, [MarshalAs(UnmanagedType.U1)] bool P_1);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern void HOLM_002EMeasure_002EMeasurementCore_002ESetImpulseWindowLockStart(MeasurementCore* P_0, [MarshalAs(UnmanagedType.U1)] bool P_1);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	[return: MarshalAs(UnmanagedType.U1)]
	public unsafe static extern bool HOLM_002EMeasure_002EConfigCtrl_002EGetEnabled(ConfigCtrl* P_0, EnabledEnum P_1);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* HOLM_002EMeasure_002ESignalTypeToString(basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* P_0, SignalType P_1);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern MeasurementList* HOLM_002EMeasure_002EMeasurementList_002E_007Bctor_007D(MeasurementList* P_0, int P_1);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern void HOLM_002EMeasure_002EMeasurementList_002E_007Bdtor_007D(MeasurementList* P_0);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	[return: MarshalAs(UnmanagedType.U1)]
	public unsafe static extern bool HOLM_002EMeasure_002EMeasurementList_002EOpenTry(MeasurementList* P_0, basic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E* P_1, [MarshalAs(UnmanagedType.U1)] bool P_2);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	[return: MarshalAs(UnmanagedType.U1)]
	public unsafe static extern bool HOLM_002EMeasure_002EMeasurementList_002EOpenTryAppend(MeasurementList* P_0, basic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E* P_1);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern void HOLM_002EMeasure_002EMeasurementList_002ESave(MeasurementList* P_0, basic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E* P_1);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern void HOLM_002EMeasure_002EMeasurementList_002EClear(MeasurementList* P_0);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern void HOLM_002EMeasure_002EMeasurementList_002ERearange(MeasurementList* P_0);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern Measurement* HOLM_002EMeasure_002EMeasurementList_002ENo(MeasurementList* P_0, int P_1);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern void HOLM_002EMeasure_002EMeasurementList_002ESetNo(MeasurementList* P_0, Measurement* P_1, int P_2);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern int HOLM_002EMeasure_002EMeasurementList_002EGetSize(MeasurementList* P_0);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern double HOLM_002EMeasure_002EMeasurement_002EGetMaxImpulse(Measurement* P_0);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern double HOLM_002EMeasure_002EMeasurement_002EGetMinImpulse(Measurement* P_0);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern double HOLM_002EMeasure_002EMeasurement_002EGetMaxAbsImpulse(Measurement* P_0);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern void HOLM_002EMeasure_002EMeasurement_002ELocateImpulse(Measurement* P_0);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern void HOLM_002EMeasure_002EMeasurement_002EUseSuggestedImpulseWindowEnd(Measurement* P_0);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern double HOLM_002EMeasure_002EMeasurement_002EFrequencyValidityWithWindow(Measurement* P_0);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern void HOLM_002EMeasure_002EMeasurement_002EInvert(Measurement* P_0);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern SmoothingImpulseWindow* HOLM_002EMeasure_002ESmoothingImpulseWindow_002E_007Bctor_007D(SmoothingImpulseWindow* P_0, double P_1, int P_2, double P_3);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern double HOLM_002EMeasure_002ESmoothingImpulseWindow_002EAmplitude(SmoothingImpulseWindow* P_0, double P_1);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern double HOLM_002EMeasure_002ESmoothingImpulseWindow_002EGetMiddle(SmoothingImpulseWindow* P_0);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern void HOLM_002EMeasure_002ESmoothingImpulseWindow_002EUpdateConstants(SmoothingImpulseWindow* P_0);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* HOLM_002EMeasure_002EDistortionIndexToString(basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* P_0, int P_1);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern double HOLM_002EMath_002EPhase_003Cdouble_003E(complex_003Cdouble_003E* P_0);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public static extern int HOLM_002EMath_002ESign_003Cdouble_003E(double P_0);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern void HOLM_002ELogging_002EHolmLogger_002ELogText(basic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E* P_0);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern void* new_005B_005D(uint P_0);

	[DllImport("", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
	[MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern basic_ostream_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_0020_003E* std_002Eoperator_003C_003C_003Cwchar_t_002Cstruct_0020std_003A_003Achar_traits_003Cwchar_t_003E_002Cclass_0020std_003A_003Aallocator_003Cwchar_t_003E_0020_003E(basic_ostream_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_0020_003E* P_0, basic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E* P_1);

	[DllImport("", CallingConvention = CallingConvention.ThisCall, SetLastError = true)]
	[MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern bad_cast* std_002Ebad_cast_002E_007Bctor_007D(bad_cast* P_0, bad_cast* P_1);

	[DllImport("", CallingConvention = CallingConvention.ThisCall, SetLastError = true)]
	[MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern bad_cast* std_002Ebad_cast_002E_007Bctor_007D(bad_cast* P_0, sbyte* P_1);

	[DllImport("", CallingConvention = CallingConvention.ThisCall, SetLastError = true)]
	[MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern void std_002Ebad_cast_002E_007Bdtor_007D(bad_cast* P_0);

	[DllImport("", CallingConvention = CallingConvention.ThisCall, SetLastError = true)]
	[MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D(basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* P_0);

	[DllImport("", CallingConvention = CallingConvention.ThisCall, SetLastError = true)]
	[MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_007Bctor_007D(basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* P_0, uint P_1, sbyte P_2);

	[DllImport("", CallingConvention = CallingConvention.ThisCall, SetLastError = true)]
	[MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern sbyte* std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_005B_005D(basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* P_0, uint P_1);

	[DllImport("", CallingConvention = CallingConvention.ThisCall, SetLastError = true)]
	[MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern uint std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002Elength(basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* P_0);

	[DllImport("", CallingConvention = CallingConvention.ThisCall, SetLastError = true)]
	[MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern basic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E* std_002Ebasic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E_002E_007Bctor_007D(basic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E* P_0, uint P_1, [MarshalAs(UnmanagedType.U2)] char P_2);

	[DllImport("", CallingConvention = CallingConvention.ThisCall, SetLastError = true)]
	[MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern char* std_002Ebasic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E_002E_005B_005D(basic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E* P_0, uint P_1);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* HOLM_002EWStringToString(basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* P_0, basic_string_003Cwchar_t_002Cstd_003A_003Achar_traits_003Cwchar_t_003E_002Cstd_003A_003Aallocator_003Cwchar_t_003E_0020_003E* P_1);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public static extern void HOLM_002ELogging_002EHolmLogger_002EStop();

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public static extern void HOLM_002ELogging_002EHolmLogger_002EStart();

	[DllImport("", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
	[MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern uint GetTempPathW(uint P_0, char* P_1);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern MeasurementImporter* HOLM_002EMeasure_002EMeasurementImporter_002E_007Bctor_007D(MeasurementImporter* P_0);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern void HOLM_002EMeasure_002EMeasurementImporter_002EImport(MeasurementImporter* P_0, Measurement* P_1, basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* P_2, [MarshalAs(UnmanagedType.U1)] bool P_3);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern void HOLM_002EMeasure_002EMeasurementCore_002EInitializeImpulse(MeasurementCore* P_0, double* P_1, int P_2, int P_3, int P_4, int P_5, SignalType P_6, double P_7, double P_8, [MarshalAs(UnmanagedType.U1)] bool P_9);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern void HOLM_002EMeasure_002EMeasurementCore_002EOffset(MeasurementCore* P_0, double P_1);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern void HOLM_002EMeasure_002EMeasurementCore_002EPostInitSetOffset(MeasurementCore* P_0, double P_1);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern MeasurementExporter* HOLM_002EMeasure_002EMeasurementExporter_002E_007Bctor_007D(MeasurementExporter* P_0);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern void HOLM_002EMeasure_002EMeasurementExporter_002EExport(MeasurementExporter* P_0, Measurement* P_1, basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* P_2, double P_3, double P_4);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern void HOLM_002EMeasure_002EMeasurementExporter_002EExport(MeasurementExporter* P_0, Measurement* P_1, basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* P_2);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern void HOLM_002EMeasure_002EMeasurementExporter_002EExportImpulse(MeasurementExporter* P_0, Measurement* P_1, basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* P_2, int P_3, int P_4);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern void HOLM_002EMeasure_002EMeasurementExporter_002EExportImpulses(MeasurementExporter* P_0, MeasurementList* P_1, basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* P_2, int P_3, int P_4, int P_5);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern ImpulseImporter* HOLM_002EMeasure_002EImpulseImporter_002E_007Bctor_007D(ImpulseImporter* P_0);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	[return: MarshalAs(UnmanagedType.U1)]
	public unsafe static extern bool HOLM_002EMeasure_002EImpulseImporter_002EImportText(ImpulseImporter* P_0, Measurement* P_1, basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* P_2);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	[return: MarshalAs(UnmanagedType.U1)]
	public unsafe static extern bool HOLM_002EMeasure_002EImpulseImporter_002EImportWave(ImpulseImporter* P_0, Measurement* P_1, basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* P_2);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern int HOLM_002EAnalyze_002ELocateImpulse_003Cdouble_003E(double* P_0, int P_1, [MarshalAs(UnmanagedType.U1)] bool P_2, TZM P_3);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public static extern int HOLM_002EAnalyze_002ECommonPow2Length(int P_0, int P_1);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern void HOLM_002EAnalyze_002ECorrelateInTime_003Cdouble_002Cdouble_002Cdouble_003E(double* P_0, double* P_1, double* P_2, int P_3, double P_4);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern void HOLM_002EMath_002EArrayCircShift_003Cdouble_003E(double* P_0, int P_1, int P_2, [MarshalAs(UnmanagedType.U1)] bool P_3);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern WaveInfo HOLM_002EWaveImExport_002EWaveFileInfo(basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* P_0);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	[return: MarshalAs(UnmanagedType.U1)]
	public unsafe static extern bool HOLM_002EWaveImExport_002EWaveFileToArray_003Cdouble_003E(basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* P_0, double* P_1, uint P_2, double P_3);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	[return: MarshalAs(UnmanagedType.U1)]
	public unsafe static extern bool HOLM_002EWaveImExport_002EImpulseWaveExport(Measurement* P_0, basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* P_1, int P_2, int P_3, [MarshalAs(UnmanagedType.U1)] bool P_4, WaveFormat P_5);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern double* Mem_002EAllocateArray_003Cdouble_003E(uint P_0);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern double* Mem_002EAllocateArrayZeros_003Cdouble_003E(uint P_0);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern void Mem_002EFreeArray_003Cdouble_003E(double** P_0, uint P_1);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern void HOLM_002EMeasure_002EResponse_002EAbort(Response* P_0);

	[DllImport("", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
	[MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	[return: MarshalAs(UnmanagedType.U1)]
	public unsafe static extern bool std_002Eoperator_0021_003D_003Cchar_002Cstruct_0020std_003A_003Achar_traits_003Cchar_003E_002Cclass_0020std_003A_003Aallocator_003Cchar_003E_0020_003E(basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* P_0, sbyte* P_1);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern Response* HOLM_002EMeasure_002EResponse_002E_007Bctor_007D(Response* P_0);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern void HOLM_002EAnalyze_002EInverseSequence_003Cfloat_002Cfloat_003E(float* P_0, float* P_1, int P_2);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern float HOLM_002EPAudioII_002EPCMGenerator_002EAmplitude(PCMGenerator* P_0);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern int HOLM_002EWaveImExport_002EArrayWaveExport(float* P_0, int P_1, int P_2, basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* P_3, WaveFormat P_4, basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* P_5, [MarshalAs(UnmanagedType.U1)] bool P_6);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern int HOLM_002EWaveImExport_002EArrayWaveExport(double* P_0, int P_1, int P_2, basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* P_3, WaveFormat P_4, basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* P_5, [MarshalAs(UnmanagedType.U1)] bool P_6);

	[DllImport("", CallingConvention = CallingConvention.ThisCall, SetLastError = true)]
	[MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern sbyte* std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002E_005B_005D(basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* P_0, uint P_1);

	[DllImport("", CallingConvention = CallingConvention.ThisCall, SetLastError = true)]
	[MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern uint std_002Ebasic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E_002Efind_last_of(basic_string_003Cchar_002Cstd_003A_003Achar_traits_003Cchar_003E_002Cstd_003A_003Aallocator_003Cchar_003E_0020_003E* P_0, sbyte P_1, uint P_2);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern VUMeterInBuffer* HOLM_002EPAudioII_002EVUMeterInBuffer_002E_007Bctor_007D(VUMeterInBuffer* P_0, StreamInitializer* P_1, float P_2, float P_3);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern void HOLM_002EPAudioII_002EVUMeterInBuffer_002E_007Bdtor_007D(VUMeterInBuffer* P_0);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern void HOLM_002EPAudioII_002EVUMeterInBuffer_002EResetPeak(VUMeterInBuffer* P_0);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern void HOLM_002EPAudioII_002EStreamInitializer_002EAddStatusCallback(StreamInitializer* P_0, delegate* unmanaged[Cdecl, Cdecl]<StreamStatus, void> P_1);

	[MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
	[SuppressUnmanagedCodeSecurity]
	public unsafe static extern void HOLM_002EPAudioII_002EStreamInitializer_002ERemoveStatusCallback(StreamInitializer* P_0, delegate* unmanaged[Cdecl, Cdecl]<StreamStatus, void> P_1);
}
