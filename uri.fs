open System
open System.IO

[<EntryPoint>]
let main(args) =    
    let testCases = File.ReadLines(args.[0])
    for test in testCases do
        let l = test.Split([|';'|]) |> Seq.toList
        let a = Uri.TryCreate(l.[0], UriKind.RelativeOrAbsolute)
        let b = Uri.TryCreate(l.[1], UriKind.RelativeOrAbsolute)

        if a=b then
            printfn "True"
        else
            printfn "False"
    0
