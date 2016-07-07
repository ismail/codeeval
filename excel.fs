open System
open System.IO

[<EntryPoint>]
let main args =
    let l1  = seq {65..65+25}
              |> Seq.map (fun elem -> Convert.ToString (char elem))

    let l2 = seq {for a in l1 do for b in l1 -> sprintf "%s%s" a b}
    let l3 = seq {for a in l1 do for b in l1 do for c in l1 -> sprintf "%s%s%s" a b c}

    let l = [l1; l2; l3]
            |> Seq.concat
            |> Seq.toList

    let testCases = File.ReadLines(args.[0])
    for test in testCases do
        let index = test
                    |> int
        printfn "%s" l.[index-1]
    0
