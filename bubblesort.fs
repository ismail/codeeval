open System
open System.IO

[<EntryPoint>]
let main args =
    let testCases = File.ReadLines(args.[0])
    for test in testCases do
        let l = test.Split([|'|'|]) |> Seq.toArray
        let mutable numbers = l.[0].Trim().Split([|' '|]) |> Seq.map int |> Seq.toArray 
        let count = uint64 (l.[1].Trim())
        let mutable pass = 0UL
        let mutable cont = true

        while (pass < count) && cont do
            cont <- false
            for i in [0..numbers.Length-2] do
                if numbers.[i+1] < numbers.[i] then
                    let temp = numbers.[i]
                    numbers.[i] <- numbers.[i+1]
                    numbers.[i+1] <- temp
                    cont <- true
            pass <- pass+1UL

        numbers
        |> Array.map string
        |> String.concat " "
        |> printfn "%s"
    0
