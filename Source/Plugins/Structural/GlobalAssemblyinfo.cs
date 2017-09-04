#region Usings

using System.Reflection;
using NaroConstants.Names;

#endregion

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.

[assembly: AssemblyProduct("NaroCAD.Plugin.Structural of " + NaroAppConstantNames.AppName)]
[assembly: AssemblyCompany(NaroAppConstantNames.Website)]
[assembly: AssemblyCopyright("Copyright © Jörg Hoffmann <CyberDev@Web.de> 2010")]
[assembly: AssemblyTrademark("")]

#if DEBUG

[assembly: AssemblyConfiguration("Debug")]
#else
[assembly: AssemblyConfiguration("Release")]
#endif

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers 
// by using the '*' as shown below:
// [assembly: AssemblyVersion("1.0.*")]

[assembly: AssemblyVersion(NaroAppConstantNames.Version)]
[assembly: AssemblyFileVersion(NaroAppConstantNames.Version)]