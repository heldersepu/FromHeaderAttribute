using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[assembly: AssemblyTitle(Assemb.Title)]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct(Assemb.Title)]
[assembly: AssemblyCopyright("Copyright ©  2015")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]
[assembly: ComVisible(false)]
[assembly: Guid("fd1d8798-d568-490f-aa1d-663930625c4e")]

[assembly: AssemblyVersion(Assemb.Version)]
[assembly: AssemblyFileVersion(Assemb.Version)]
[assembly: AssemblyInformationalVersion(Assemb.Version)]

public struct Assemb
{
    public const string Title = @"FromHeaderAttribute";
    public const string Version = @"2.0.0.0";
}
