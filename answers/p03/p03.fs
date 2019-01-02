let first_elem lst =
  match lst with
  | [] -> failwith "Out of Bound"
  | x :: xs -> x

let rest_elem lst =
  match lst with
  | [] -> failwith "Out of Bound"
  | x :: xs -> xs

let rec p03 lst n =
  match n with
  | n when n <= 0 -> failwith "No negative on Index"
  | 1 -> first_elem lst
  | _ -> p03 (rest_elem lst) (n - 1)

// test part
let print x = printfn "%d" x

let test_p03 =
  print (p03 [1;3;5;7;9] 3)
  print (p03 [2;4;6;8] 1)
  // out of bound test
  try
    print (p03 [2;4;6;8] 5)
  with
  | Failure(msg) -> printfn "%s" msg
  try
    print (p03 [2;4;6;8] -1)
  with
  | Failure(msg) -> printfn "%s" msg

test_p03
