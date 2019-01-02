let rec help_p04 lst n =
  match lst with
  | [] -> n
  | x :: xs -> help_p04 xs (n + 1)

let p04 lst =
  help_p04 lst 0

// test part
let print x = printfn "%d" x

let test_p04 =
  print (p04 [1;3;5;7;9])
  print (p04 [2])
  print (p04 [])

test_p04
