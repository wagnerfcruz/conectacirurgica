using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.VisualC;

namespace std;

[StructLayout(LayoutKind.Sequential, Size = 4)]
[NativeCppClass]
[DebugInfoInPDB]
[MiscellaneousBits(64)]
internal struct locale
{
	[StructLayout(LayoutKind.Sequential, Size = 4)]
	[CLSCompliant(false)]
	[NativeCppClass]
	[DebugInfoInPDB]
	[MiscellaneousBits(64)]
	public struct id
	{
	}

	[StructLayout(LayoutKind.Sequential, Size = 8)]
	[MiscellaneousBits(64)]
	[DebugInfoInPDB]
	[NativeCppClass]
	[CLSCompliant(false)]
	public struct facet
	{
	}
}
