open System
open System.IO

[<EntryPoint>]
let main args =
    let testCases = File.ReadLines(args.[0])
    for test in testCases do
        let l = test.Split([|','|]) |> Seq.toArray
        let removals = [|for c in l.[1].Trim() -> c|]
        
        [|for c in l.[0] -> c|]
        |> Array.filter (fun x -> not (removals |> Array.contains x))
        |> String
        |> printfn "%s"

    0