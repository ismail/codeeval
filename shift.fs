open System.IO

[<EntryPoint>]
let main args =
    let testCases = File.ReadLines(args.[0])
    for test in testCases do
        let l = test.Split([|','|]) |> Seq.map int |> Seq.toList
        let i = l.[0]
        let j = l.[1]
        let mutable mult = 2
        while j*mult < i do
            mult <- mult + 1 
        printfn "%d" (j*mult)
    0
