let rec p02 lst =
  match lst with
  | [] -> failwith "Empty List" // empty list
  | [x] ->failwith "Need element more than 1" // only one exist
  | [x; y] -> lst // two ; return itself
  | x :: xs -> p02 xs // rest ; keep call with rest list

// test part
let print_list x = printfn "%A" x

let test_p02 =
  print_list (p02 [1;3;5;7;9])
  print_list (p02 [6;8])
  try
    print_list (p02 [0])
  with
  | Failure(msg) -> printfn "%s" msg
  try
    print_list (p02 [])
  with
  | Failure(msg) -> printfn "%s" msg

test_p02
