﻿using System.Reflection;

// Allgemeine Informationen über eine Assembly werden über die folgenden 
// Attribute gesteuert. Ändern Sie diese Attributwerte, um die Informationen zu ändern,
// die einer Assembly zugeordnet sind.
#if !DEBUG
[assembly: AssemblyConfiguration("Release")]
#else
[assembly: AssemblyConfiguration("")]
#endif
[assembly: AssemblyCompany("Fubar Development Junker")]
[assembly: AssemblyCopyright("Copyright © 2015 Fubar Development Junker")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Versionsinformationen für eine Assembly bestehen aus den folgenden vier Werten:
//
//      Hauptversion
//      Nebenversion 
//      Buildnummer
//      Revision
//
// Sie können alle Werte angeben oder die standardmäßigen Build- und Revisionsnummern 
// übernehmen, indem Sie "*" eingeben:
// [assembly: AssemblyVersion("1.0.*")]
#if !CUSTOM_ASSEMBLY_VERSION
[assembly: AssemblyVersion("0.1.*")]
#endif
[assembly: AssemblyFileVersion("0.1.0")]
[assembly: AssemblyInformationalVersion("0.1.0")]