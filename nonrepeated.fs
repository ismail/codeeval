open System.IO

[<EntryPoint>]
let main args =
    let testCases = File.ReadLines(args.[0])
    for test in testCases do
        test
        |> Seq.countBy id
        |> Seq.filter (fun (x,y) -> y=1)
        |> Seq.head
        |> (fun (x,y) -> x)
        |> printfn "%c"
    0
