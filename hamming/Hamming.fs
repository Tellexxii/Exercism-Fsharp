module Hamming


let listComparer list1 list2 = Array.map2 (fun x y -> x = y) list1 list2
let booleans = listComparer ("AAB".ToCharArray()) ("ABB".ToCharArray())

//let distance (strand1: string) (strand2: string): int option = failwith "You need to implement this function."
