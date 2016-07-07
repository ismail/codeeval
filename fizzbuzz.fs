open System
open System.IO

[<EntryPoint>]
let main args =
    let testCases = File.ReadLines(args.[0])
    for test in testCases do
        let l = test.Split([|' '|]) |> Seq.map int |> Seq.toList
        let (a, b, n) = (l.[0], l.[1], l.[2])

        [1..n]
        |> Seq.map (function
            |x when x%a=0 && x%b=0 -> "FB"
            |x when x%a=0 -> "F"
            |x when x%b=0 -> "B"
            |x -> string x)
        |> Seq.iter (printf "%s ")
        printf "\n"
    0
