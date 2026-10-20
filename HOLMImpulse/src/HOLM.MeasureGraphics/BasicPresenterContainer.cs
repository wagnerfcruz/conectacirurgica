using System.Runtime.CompilerServices;
using HOLM.Measure;
using std;

namespace HOLM.MeasureGraphics;

internal abstract class BasicPresenterContainer
{
	public virtual BasicMeasurementPresenter[] GetPresenters()
	{
		return null;
	}

	public unsafe double GetMaxPlotImpulse()
	{
		BasicMeasurementPresenter[] presenters = GetPresenters();
		int num = presenters.Length;
		double num2 = -10000.0;
		int num3 = 0;
		if (0 < num)
		{
			do
			{
				BasicMeasurementPresenter basicMeasurementPresenter = presenters[num3];
				if (basicMeasurementPresenter.fDataAssigned)
				{
					Measurement* measPtr = basicMeasurementPresenter.measPtr;
					if (((byte*)measPtr)[28] != 0 && basicMeasurementPresenter.fPlot && global::_003CModule_003E.HOLM_002EMeasure_002EMeasurement_002EGetMaxImpulse(measPtr) > num2)
					{
						num2 = global::_003CModule_003E.HOLM_002EMeasure_002EMeasurement_002EGetMaxImpulse(presenters[num3].measPtr);
					}
				}
				num3++;
			}
			while (num3 < num);
		}
		return num2;
	}

	public unsafe double GetMinPlotImpulse()
	{
		BasicMeasurementPresenter[] presenters = GetPresenters();
		int num = presenters.Length;
		double num2 = 10000.0;
		int num3 = 0;
		if (0 < num)
		{
			do
			{
				BasicMeasurementPresenter basicMeasurementPresenter = presenters[num3];
				if (basicMeasurementPresenter.fDataAssigned)
				{
					Measurement* measPtr = basicMeasurementPresenter.measPtr;
					if (((byte*)measPtr)[28] != 0 && basicMeasurementPresenter.fPlot && global::_003CModule_003E.HOLM_002EMeasure_002EMeasurement_002EGetMinImpulse(measPtr) < num2)
					{
						num2 = global::_003CModule_003E.HOLM_002EMeasure_002EMeasurement_002EGetMinImpulse(presenters[num3].measPtr);
					}
				}
				num3++;
			}
			while (num3 < num);
		}
		return num2;
	}

	public unsafe vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E* GetPlotVector(vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E* P_0)
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out uint num);
		try
		{
			num = 0u;
			global::_003CModule_003E.std_002Evector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E_002E_007Bctor_007D(P_0);
			num = 1u;
			BasicMeasurementPresenter[] presenters = GetPresenters();
			int num2 = (int)((nint)presenters.LongLength - 1);
			int num3 = num2;
			if (num3 >= 0)
			{
				do
				{
					BasicMeasurementPresenter basicMeasurementPresenter = presenters[num3];
					if (basicMeasurementPresenter.fDataAssigned && ((byte*)basicMeasurementPresenter.measPtr)[28] != 0 && basicMeasurementPresenter.fPlot && basicMeasurementPresenter.fBehind)
					{
						global::_003CModule_003E.std_002Evector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E_002Epush_back(P_0, &num3);
					}
					num3--;
				}
				while (num3 >= 0);
			}
			int num4 = num2;
			if (num4 >= 0)
			{
				do
				{
					BasicMeasurementPresenter basicMeasurementPresenter2 = presenters[num4];
					if (basicMeasurementPresenter2.fDataAssigned && ((byte*)basicMeasurementPresenter2.measPtr)[28] != 0 && basicMeasurementPresenter2.fPlot && !basicMeasurementPresenter2.fBehind)
					{
						global::_003CModule_003E.std_002Evector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E_002Epush_back(P_0, &num4);
					}
					num4--;
				}
				while (num4 >= 0);
			}
			return P_0;
		}
		catch
		{
			//try-fault
			if ((num & (true ? 1u : 0u)) != 0)
			{
				num &= 0xFFFFFFFEu;
				global::_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E*, void>)(&global::_003CModule_003E.std_002Evector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E_002E_007Bdtor_007D), P_0);
			}
			throw;
		}
	}

	public unsafe vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E* GetPlotWindowsVector(vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E* P_0)
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out uint num);
		try
		{
			num = 0u;
			global::_003CModule_003E.std_002Evector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E_002E_007Bctor_007D(P_0);
			num = 1u;
			BasicMeasurementPresenter[] presenters = GetPresenters();
			int num2 = (int)((nint)presenters.LongLength - 1);
			int num3 = num2;
			if (num3 >= 0)
			{
				do
				{
					BasicMeasurementPresenter basicMeasurementPresenter = presenters[num3];
					if (basicMeasurementPresenter.fDataAssigned)
					{
						Measurement* measPtr = basicMeasurementPresenter.measPtr;
						if (((byte*)measPtr)[28] != 0 && basicMeasurementPresenter.fPlot && global::_003CModule_003E.HOLM_002EMeasure_002EConfigCtrl_002EGetEnabled((ConfigCtrl*)((byte*)measPtr + 136), (EnabledEnum)1) && presenters[num3].fBehind)
						{
							global::_003CModule_003E.std_002Evector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E_002Epush_back(P_0, &num3);
						}
					}
					num3--;
				}
				while (num3 >= 0);
			}
			int num4 = num2;
			if (num4 >= 0)
			{
				do
				{
					BasicMeasurementPresenter basicMeasurementPresenter2 = presenters[num4];
					if (basicMeasurementPresenter2.fDataAssigned)
					{
						Measurement* measPtr2 = basicMeasurementPresenter2.measPtr;
						if (((byte*)measPtr2)[28] != 0 && basicMeasurementPresenter2.fPlot && global::_003CModule_003E.HOLM_002EMeasure_002EConfigCtrl_002EGetEnabled((ConfigCtrl*)((byte*)measPtr2 + 136), (EnabledEnum)1) && !presenters[num4].fBehind)
						{
							global::_003CModule_003E.std_002Evector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E_002Epush_back(P_0, &num4);
						}
					}
					num4--;
				}
				while (num4 >= 0);
			}
			return P_0;
		}
		catch
		{
			//try-fault
			if ((num & (true ? 1u : 0u)) != 0)
			{
				num &= 0xFFFFFFFEu;
				global::_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E*, void>)(&global::_003CModule_003E.std_002Evector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E_002E_007Bdtor_007D), P_0);
			}
			throw;
		}
	}

	public unsafe Measurement* GetPresenterMeas(int index)
	{
		return GetPresenters()[index].measPtr;
	}

	public BasicPresenterContainer()
	{
	}
}
