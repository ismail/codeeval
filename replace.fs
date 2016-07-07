open System.IO

[<EntryPoint>]
let main args =
    let testCases = File.ReadLines(args.[0])
    let mutable input = ""
    let mutable replacements = []
    for test in testCases do
        input <- test.Split([|';'|]).[0]
        let subs = test.Split([|';'|]).[1].Split([|','|])
        let mutable i = 0
        while i < subs.Length do
            if not (List.contains subs.[i] replacements) then
                printfn "%s -> %s" subs.[i] subs.[i+1]
                input <- input.Replace(subs.[i], subs.[i+1])
                replacements <- List.append replacements [subs.[i+1]]
            else
                printfn "Won't do %s -> %s" subs.[i] subs.[i+1]
            i <- i+2
    printfn "%s" input
    0
