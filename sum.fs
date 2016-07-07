open System.IO

[<EntryPoint>]
let main args =
    let testCases = File.ReadLines(args.[0])
    let mutable result = 0
    for test in testCases do
        [for c in test -> int c - 48] |> List.sum |> printfn "%d"
    0
