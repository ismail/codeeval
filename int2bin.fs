open System
open System.IO

[<EntryPoint>]
let main(args) =    
    let testCases = File.ReadLines(args.[0])
    for test in testCases do
        let mutable value = int test
        let mutable l = List.empty<int>
        if value = 0 then
            printfn "0"
        else
            while value > 0 do
                let x = value%2
                l <- [x] @ l
                value <- value/2
            [for a in l -> printf "%d" a]
            printf "\n"
    0
