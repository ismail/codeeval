open System
open System.IO

let rec comb n l = 
    match n, l with
    | 0, _ -> [[]]
    | _, [] -> []
    | k, (x::xs) -> List.map ((@) [x]) (comb (k-1) xs) @ comb k xs

[<EntryPoint>]
let main args =
    let testCases = File.ReadLines(args.[0])
    for test in testCases do
        let numbers = test.Split([|';'|]).[0].Split([|','|]) |> Seq.map int |> Seq.toList
        let sum = test.Split([|';'|]).[1] |> int

        comb 2 numbers
        |> List.filter (fun l -> List.sum l = sum)
        |> List.map (fun l -> sprintf "%d,%d" l.[0] l.[1])
        |> String.concat ";"
        |> (fun x -> match x with
                     |"" -> printfn "NULL"
                     |x ->  printfn "%s" x)
    0
