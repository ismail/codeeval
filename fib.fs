open System.IO

let rec fib = function
              |x when x=0 -> 0
              |x when x=1 -> 1
              |x -> fib(x-1) + fib(x-2)
    
[<EntryPoint>]
let main args =
    let testCases = File.ReadLines(args.[0])
    for test in testCases do
        fib (int test) |> printfn "%d"
    0
