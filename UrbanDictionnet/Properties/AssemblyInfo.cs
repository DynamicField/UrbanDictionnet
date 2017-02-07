using System.Reflection;
using System.Runtime.InteropServices;

// THIS FILE IS USING VERY NICE COMMENTS !!!!!! v1.0

// Les informations générales relatives à un assembly dépendent de
// l'ensemble d'attributs suivant. Changez les valeurs de ces attributs pour modifier les informations
// associées à un assembly.
[assembly: AssemblyTitle("UrbanDictionnet")] // the title
[assembly: AssemblyDescription("An async API wrapper for urban dictionary that can search for words and get a random one as well as it can vote on a definition")] // the god damn description
[assembly: AssemblyConfiguration("")] // WE DONT CARE
[assembly: AssemblyCompany("")] // WE DONT CARE
[assembly: AssemblyProduct("UrbanDictionnet")] // my product <3
[assembly: AssemblyCopyright("Copyright © 2017")] // no
[assembly: AssemblyTrademark("")] // :tm:
[assembly: AssemblyCulture("")] // ITS EN US
// L'affectation de la valeur false à ComVisible rend les types invisibles dans cet assembly
// aux composants COM. Si vous devez accéder à un type dans cet assembly à partir de
// COM, affectez la valeur true à l'attribut ComVisible sur ce type.
[assembly: ComVisible(false)] // wtf

// Le GUID suivant est pour l'ID de la typelib si ce projet est exposé à COM
[assembly: Guid("18689676-50f8-499d-9f79-85664a456c3a")] // lol

// Les informations de version pour un assembly se composent des quatre valeurs suivantes :
//
//      Version principale
//      Version secondaire
//      Numéro de build
//      Révision
//
// Vous pouvez spécifier toutes les valeurs ou indiquer les numéros de build et de révision par défaut
// en utilisant '*', comme indiqué ci-dessous :
// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion(Versions.Version)] // VERSION
[assembly: AssemblyFileVersion(Versions.Version)] // useless
/// <summary>
/// Blah
/// </summary>
internal static class Versions
{
    internal const string Version = "1.3.4.0"; // laziness
}
