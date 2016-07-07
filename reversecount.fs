open System
open System.IO

[<EntryPoint>]
let main args =
    let testCases = File.ReadLines(args.[0])
    for test in testCases do
        let l = test.Split([|';'|]) |> Seq.toList
        let count = int l.[1]
        let numbers = l.[0].Split([|','|]) |> Seq.toArray
        let mutable result = [||]: string array

        for i in [0..count..numbers.Length] do
            let high = 
                if i+count > numbers.Length then
                    numbers.Length-1
                else
                    i+count-1

            let sub = numbers.[i..high]
            if sub.Length < count then
                result <- Array.append result sub
            else
                result <- Array.append result (sub |> Array.rev)

        result
        |> String.concat ","
        |> printfn "%s"
    0
