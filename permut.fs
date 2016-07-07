open System.IO

let rec insertions x = function
    | []             -> [[x]]
    | (y :: ys) as l -> (x::l)::(List.map (fun x -> y::x) (insertions x ys))

let rec permutations = function
    | []      -> seq [ [] ]
    | x :: xs -> Seq.concat (Seq.map (insertions x) (permutations xs))

[<EntryPoint>]
let main args =
    let testCases = File.ReadLines(args.[0])
    for test in testCases do
        [for c in test -> c]
        |> permutations
        |> Seq.sort
        |> Seq.map (fun x -> x |> Seq.toArray |> System.String)
        |> String.concat ","
        |> printfn "%s"
    0
