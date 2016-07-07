open System
open System.IO

[<EntryPoint>]
let main args =
    let testCases = File.ReadLines(args.[0])
    let mutable result = 0
    for test in testCases do
        let x = int test-1
        let mutable l = [||]: bool array
        
        for i in seq {0..x} do
            l <- Array.append l [|true|]
        
        for i in seq {2..(int (sqrt (float x)))} do
            if l.[i] then
                for j in seq {(pown i 2)..i..x} do
                    l.[j] <- false
        
        let mutable result = [||]: string array
        for i in seq {2..(Array.length l)-1} do
            if l.[i] then
                result <- Array.append result [|string i|]

        result
        |> String.concat ","
        |> printfn "%s"
    0
