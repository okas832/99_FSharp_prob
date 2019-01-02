let rec help_p5 lst res =
  match lst with
  | [] -> res
  | x :: xs -> help_p5 xs (x :: res)

let p5 lst =
  help_p5 lst []

// test part
let print_list lst = printfn "%A" lst

let test_p5 =
  print_list (p5 [1;3;5;7;9])
  print_list (p5 [8;6;4;2])
  print_list (p5 [1])
  print_list (p5 [])
