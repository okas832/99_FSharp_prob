let list_last lst =
  lst |> List.last

let list_rm_last lst =
  lst |> List.rev |> List.tail

let rec p06 lst =
  match lst with
  | [] -> true
  | [x] -> true
  | x :: xs when x = list_last xs -> p06 (list_rm_last xs)
  | _ -> false

// test part
let print_bool b =
  printfn "%b" b

let test_p06 =
  print_bool (p06 [1;3;5;3;1])
  print_bool (p06 [1;3;5;3;2])
  print_bool (p06 [1])
  print_bool (p06 [])

