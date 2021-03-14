module Assignment

// Problem 1
let rec tribn n =
    // write your code here
  if (n = -1 || n = 0) then 0
  elif (n = 1 || n = 2) then 1
  else tribn(n-1) + tribn(n-2) + tribn(n-3)

// Problem 2
let tribn2 n =
    // write your code here
  0

// Problem 3
let rec last lst =
    // write your code here 
  let h = List.head lst
  let t = List.tail lst
  if List.isEmpty t
  then h
  else last t

// Problem 4
let fourth (lst:int list) =
    // write your code here
  if List.isEmpty lst then 0
  else if List.isEmpty (List.tail lst) then 0
  else if List.isEmpty (List.tail lst |> List.tail) then 0
  else if List.isEmpty (List.tail lst |> List.tail |> List.tail) then 0
  else List.tail lst |> List.tail |> List.tail |> List.head
  
// Problem 5
let rec everyfourth (lst:int list) =
    // write your code here
    if List.isEmpty lst then []
    else if List.head lst % 4 = 0
    then List.head lst :: everyfourth (List.tail lst)
    else everyfourth (List.tail lst)

// Problem 6
let rec take n (lst:int list) =
    // write your code here
    if List.isEmpty lst then []
    else if n <> 0
    then List.head lst :: take (n-1) (List.tail lst)
    else take n (List.tail lst)

// Problem 7
let rec drop n (lst:int list) =
    // write your code here
    if List.isEmpty lst then []
    else if n <> 0
    then drop (n-1) (List.tail lst)
    else List.head lst :: drop n (List.tail lst)
    
