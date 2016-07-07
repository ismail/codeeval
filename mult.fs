[<EntryPoint>]
let main(args) =    
    for i in [1..12] do
        for j in [1..12] do
            printf "%4d" (i*j)
        printfn ""
    0

