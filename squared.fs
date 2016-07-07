open System.IO

let mutable result = [||] : (int * int) []

let rec B (n:int) (x:int) (y: int) : ((int*int) []) =
    if x > y then
        let value = (pown x 2) + (pown y 2)
        if value < n then
            B n x (y+1) |> ignore
        elif value > n then
            B n (x-1) y |> ignore
        else
            result <- Array.append result [|(x,y)|]
            B n (x-1) (y+1) |> ignore
    result

[<EntryPoint>]
let main args =
    let testCases = File.ReadLines(args.[0]) |> Seq.toArray
    let cases = int testCases.[0]
    for test in testCases.[1..cases] do
        result <- [||]
        let n = int test
        let x = int (sqrt (float n))
        let y = 0

        if n = 0 then
            printfn "1"
        else
            B n x y
            |> Array.length
            |> printfn "%d"
    
    0
