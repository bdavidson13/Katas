//If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
//Finish the solution so that it returns the sum of all the multiples of 3 or 5 below the number passed in.
//Note: If the number is a multiple of both 3 and 5, only count it once

open System
//do the max - 1 because the solution wants everything below the number given but not including it
let createList max = [1 .. (max - 1)]

[<EntryPoint>]
let main argv =
        
    let x = createList 10 |> List.filter (fun x -> x % 3 = 0 || x % 5 = 0) |> List.sum
    Console.WriteLine(x)
    Console.ReadKey()
    0 // return an integer exit code
