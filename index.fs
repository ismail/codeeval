open System.IO

[<EntryPoint>]
let main(args) =    
    let testCases = File.ReadLines(args.[0])
    for test in testCases do
        let l = test.Split([|' '|]) |> Seq.toList
        let index = int l.[l.Length-1]
        if index - 1 <= l.Length then
            printfn "%s" l.[l.Length - index - 1]
    0

