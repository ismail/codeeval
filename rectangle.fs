open System.IO

[<EntryPoint>]
let main(args) =    
    let testCases = File.ReadLines(args.[0])
    for test in testCases do
        let l = test.Split([|','|]) |> Seq.toList

        let l1'x = l.[0]
        let l1'y = l.[1]
        let r1'x = l.[2]
        let r1'y = l.[3]
        let l2'x = l.[4]
        let l2'y = l.[5]
        let r2'x = l.[6]
        let r2'y = l.[7]

        if (l1'x > r2'x || l2'x > r1'x) || (l1'y < r2'y || l2'y < r1'y) then
            printfn "False"
        else
            printfn "True"
    0
