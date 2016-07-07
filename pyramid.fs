open System.Collections.Generic
open System.IO

let mutable a = [||]:int [][]

let value row column =
    a.[row].[column]

let rec f =
    let dict = new Dictionary<_,_>()

    fun row column -> 
        match dict.TryGetValue((row,column)) with
        | true, v -> v
        | false, _ ->
            let result = 
                if row = 0 then
                    value 0 column
                else
                    (value row column) + (max (f (row-1) column)  (f (row-1) (column+1)))
            dict.Add((row,column), result)
            result 

[<EntryPoint>]
let main args =
    let testCases = File.ReadLines(args.[0])
    let mutable rowindex = -1

    for test in testCases do
        let l = test.Split([|' '|]) 
                |> Seq.filter (fun x -> x <> "") 
                |> Seq.map int
                |> Seq.toArray

        a <- Array.append a [| l |]
        rowindex <- rowindex + 1

    a <- Array.rev a
    f rowindex 0 |> printfn "%d"
    0
