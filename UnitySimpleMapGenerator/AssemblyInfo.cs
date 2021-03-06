// -----------------------------------------------------------------------
// <copyright file="AssemblyInfo.cs" company="Taffer">
// Use this code for whatever you want, just don't blame me if it breaks.
// </copyright>
// -----------------------------------------------------------------------

using System;
using System.Reflection;
using System.Runtime.CompilerServices;

// Information about this assembly is defined by the following attributes. 
// Change them to the values specific to your project.

[assembly: AssemblyTitle("UnitySimpleMapGenerator")]
[assembly: AssemblyDescription("A Unity3D port of Baran Kahyaoglu's Map Generator - http://www.barankahyaoglu.com/blog/page/MapGenerator.aspx")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("Taffer")]
[assembly: AssemblyProduct("")]
[assembly: AssemblyCopyright("Free to use, copy, fork, etc. but don't blame me if it breaks.")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// The assembly version has the format "{Major}.{Minor}.{Build}.{Revision}".
// The form "{Major}.{Minor}.*" will automatically update the build and revision,
// and "{Major}.{Minor}.{Build}.*" will update just the revision.

[assembly: AssemblyVersion("1.0.*")]

// The following attributes are used to specify the signing key for the assembly, 
// if desired. See the Mono documentation for more information about signing.

//[assembly: AssemblyDelaySign(false)]
//[assembly: AssemblyKeyFile("")]

// Must be false due to UnityEngine.
[assembly: CLSCompliant(false)]
