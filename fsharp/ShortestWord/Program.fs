open System

[<EntryPoint>]
let main argv =
    let testString = "This is a test string"
    testString.Split ' ' |> Array.sortBy (fun x -> x.Length)
    |> fun arr -> Console.WriteLine(arr.[0].Length)
    Console.ReadKey()    
    0 // return an integer exit code
