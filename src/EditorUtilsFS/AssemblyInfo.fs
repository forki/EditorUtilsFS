﻿namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("EditorUtilsFS")>]
[<assembly: AssemblyProductAttribute("fsldb")>]
[<assembly: AssemblyDescriptionAttribute("An F# binding to the C ABI for LevelDB. ")>]
[<assembly: AssemblyVersionAttribute("1.0")>]
[<assembly: AssemblyFileVersionAttribute("1.0")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "1.0"
