open System.IO

[<EntryPoint>]
let main args =
    let testCases = File.ReadLines(args.[0])
    for test in testCases do
        test.Split([|' '|])
        |> Seq.toList
        |> List.rev 
        |> String.concat  " " 
        |> printfn "%s"
    0
