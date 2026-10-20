using System.Runtime.CompilerServices;
using std;

namespace HOLM.MeasureGraphics;

internal abstract class AbstractFilterPresenterContainer
{
	public virtual AbstractFilterPresenter[] GetPresenters()
	{
		return null;
	}

	public unsafe vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E* GetPlotVector(vector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E* P_0)
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out uint num);
		try
		{
			num = 0u;
			global::_003CModule_003E.std_002Evector_003Cint_002Cstd_003A_003Aallocator_003Cint_003E_0020_003E_002E_007Bctor_007D(P_0);
			num = 1u;
			AbstractFilterPresenter[] presenters = GetPresenters();
			int num2 = (int)((nint)presenters.LongLength - 1);
			int num3 = num2;
			if (num3 >= 0)
			{
				do
				{
					AbstractFilterPresenter abstractFilterPresenter = presenters[num3];
					if (abstractFilterPresenter.fFilterAssigned && abstractFilterPresenter.fPlot && abstractFilterPresenter.fBehind)
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
					AbstractFilterPresenter abstractFilterPresenter2 = presenters[num4];
					if (abstractFilterPresenter2.fFilterAssigned && abstractFilterPresenter2.fPlot && !abstractFilterPresenter2.fBehind)
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

	public AbstractFilterPresenterContainer()
	{
	}
}
