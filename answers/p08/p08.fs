let p08 lst =
  let rec help_p08 lst res =
    if List.isEmpty(lst) then List.rev(res)
    elif List.exists (fun elem -> elem = (List.head lst)) res then help_p08 (List.tail lst) res
    else help_p08 (List.tail lst) ((List.head lst) :: res)
  help_p08 lst []

// test_part
let print_lst lst = printfn "%A" lst

let test_p08 =
  print_lst (p08 [1;1;3;4;3;3;1;2])
  print_lst (p08 [1;2;3;4])
  print_lst (p08 [])

test_p08
