open System
open System.IO

[<EntryPoint>]
let main args =
    let testCases = File.ReadLines(args.[0])
    for test in testCases do
        let l = test.Split([|';'|])
        let s1 = Set.ofSeq (l.[0].Split([|','|]))
        let s2 = Set.ofSeq (l.[1].Split([|','|]))
        Set.intersect s1 s2
        |> Set.fold (fun l se -> se::l) []
        |> List.sort
        |> String.concat ","
        |> printfn "%s"
    0
