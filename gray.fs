open System
open System.IO

let grayToBinary32 value =
     let mutable result = value
     result <- result ^^^ (result >>> 16)
     result <- result ^^^ (result >>> 8)
     result <- result ^^^ (result >>> 4)
     result <- result ^^^ (result >>> 2)
     result <- result ^^^ (result >>> 1)
     result

let binaryToInt (value:string) =
    let len = value.Trim().Length
    let mutable result = 0
    let mutable index = len - 1

    for c in value.Trim() do
        if c='1' then
            result <- result + (pown 2 index)
        index <- index - 1
    result

[<EntryPoint>]
let main(args) =
    let testCases = File.ReadLines(args.[0])
    for test in testCases do
        test.Split([|'|'|])
        |> Seq.map binaryToInt
        |> Seq.map grayToBinary32
        |> Seq.map string
        |> Seq.toArray
        |> String.concat " | "
        |> printfn "%s"
    0

