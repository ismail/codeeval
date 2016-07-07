open System.IO

[<EntryPoint>]
let main(args) =    
    let testCases = File.ReadLines(args.[0])
    for test in testCases do
        let l = test.Split([|','|]) |> Seq.map int |> Seq.toList
        let mutable maxSum = 0
        let mutable currentMaxSum = 0
        
        for i in seq {0..(l.Length - 1)} do
            currentMaxSum <- currentMaxSum + l.[i]
            if currentMaxSum > maxSum then
                maxSum <- currentMaxSum
            
            if currentMaxSum < 0 then
                currentMaxSum <- 0

        if maxSum > 0 then
            printfn "%d" maxSum
        else
            l
            |> List.max
            |> printfn "%d"
    0
