open System.IO

[<EntryPoint>]
let main(args) =    
    let testCases = File.ReadLines(args.[0])
    for test in testCases do
        let l = test.Split([|','|]) |> Seq.toList
        let num = int(l.[0])
        let x = int(l.[1])
        let y = int(l.[2])
        if ((num >>> (x-1)) &&& 0x01) = ((num >>> (y-1)) &&& 0x01) then
            printfn "true"
        else
            printfn "false"
    0

