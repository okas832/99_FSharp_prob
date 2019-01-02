let rec p01 lst =
  match lst with
  | [] -> failwith "Empty List" // No last element on Empty list
  | [x] -> x // if only one left, return that one
  | x :: xs -> p01 xs // more than two; keep call func with rest element


// test part
let print x = printfn "%d" x

let test_p01 = 
  print (p01 [1;3;5;7;9])
  print (p01 [8])
  try
    print (p01 [])
  with
    | Failure(msg) -> printfn "%s" msg

test_p01
