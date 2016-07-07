open System.IO

[<EntryPoint>]
let main args =
    let testCases = File.ReadLines(args.[0]) |> Seq.toList
    let count = int testCases.[0]
    testCases
    |> List.sortBy (fun elem -> -1*elem.Length) 
    |> List.iteri (fun i x -> if (i < count) then printfn "%s" x)
    0
