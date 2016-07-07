open System.Collections.Generic
open System.IO

[<EntryPoint>]
let main(args) =    
    let testCases = File.ReadLines(args.[0])
    for test in testCases do
        let l = test.Split([|';'|]) |> Seq.toList
        let count = int l.[0]
        let nums = l.[1].Split([|','|])
        let dict = new Dictionary<string, int>()

        for i in nums.[0..(count-1)] do
            try
                dict.Add(i, 0)
            with
            | :? System.ArgumentException -> printfn "%s" i
    0

