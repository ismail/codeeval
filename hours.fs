open System.IO

let sortHour (hour:string) =
    let l = hour.Split([|':'|])
    -1 * ((int l.[0])*60*60 + (int l.[1])*60 + (int l.[2]))

[<EntryPoint>]
let main args =
    let testCases = File.ReadLines(args.[0])
    for test in testCases do
        test.Split([|' '|])
        |> Seq.sortBy sortHour
        |> Seq.toArray
        |> String.concat " "
        |> printfn "%s"
    0
