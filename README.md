# Assignment 1

## Problems

**!!! DO NOT USE LOOPS, MUTABLE VARIABLES, PATTERN MATCHING OR LIBRARY FUNCTIONS. ONLY RECURSION IS ALLOWED.!!!**
- Allowed functions: `List.head`, `List.tail`, `List.isEmpty`

### Problem 1

The formula for the `n`th [Tribonacci numbers](https://mathworld.wolfram.com/TribonacciNumber.html) `T_n` is defined as follows:

- `T_0 = 0`
- `T_1 = 1`
- `T_2 = 1`
- `T_n = T_{n-1} + T_{n-2} + T_{n-3}`

Your task is to implement a recursive function `tribn` which accepts an integer `n` (you may assume that `n >= 0`), and computes the `n`th Tribonacci number (don’t worry about efficiency, only about making the definition as simple as possible).

### Problem 2

A more efficient version of the function for computing Tribonacci numbers can be defined by following three steps:

1. Implement a function which takes a list of integers and adds the sum of the top four elements to the head of the list (e.g., in F#, 1::1::1::[] should become 3::1::1::1::[]).
2. Implement a recursive function which computes the `n`th Tribonacci number in linear time. This function may use a linear amount of space to compute its result, but the number of recursive calls it makes must be linear in `n`.

Your task is to follow the three steps above, in order to implement the recursive function `tribn2` in F#.
- Hint: Try to define auxiliary functions first before taking on `tribn2` function. You do not have to use auxiliary functions in your `tribn2`, but they provide an insight on how to implement the `tribn2` function.

### Problem 3

Write a function `last` that returns the last element of a list. Your function may assume that the list is non-empty.

### Problem 4

Write a function `fourth int list -> int` that takes an `int list` and returns the fourth element of that list, if such an element exists. If the list has fewer than four elements, return 0.

### Problem 5

Write a function `everyfourth : int list -> int list` that takes an `int list` and returns every fourth element of that list, if such an element exists. If the list has fewer than four elements, return empty list.

### Problem 6

Write a function `take : int -> int list -> int list` such that `take n lst` returns the first `n` elements of `lst`. If `lst` has fewer than `n` elements, return all of them.

### Problem 7

Write a function `drop : int -> int list -> int list` such that `drop n lst` returns all but the first `n` elements of `lst`. If `lst` has fewer than `n` elements, return the empty list.

## Test

Press **Run** button to execute and test your program.

- Or run `make test` command in the command line to verify the correctness of your program.

## Submission

- Commit & push all changes that to the corresponding assignment repository on GitHub, using the **Repl.it** interface - **Version control** tab.
  - Make sure that you committed changes to following files:
    - ...
- Submit the link of the assignment GitHub repository in the corresponding assignment submission the Blackboard.
  - Open corresponding assignment on the Blackboard
  - In **Assignment Submission** section, press **Write Submission** button
  - Paste your assignment repository link in the **Text Submission** box
  - Submit the assignment

### Before You Submit

You are required to test that your submission works properly before submission. Make sure that your program compiles without errors. Once you have verified that the submission is correct, you can submit your work.

### Coding Style

In any programming project, matching the existing coding style is important. Having different coding styles intermixed leads to confusion and bugs. Students are required to follow the particular existing coding style that maintains the indentation style in `.fs` and `.fsx` files using spaces, not tabs.

In particular, pay close attention to function declarations and how the function name begins the line after the function return type. For helper functions which are limited in scope to a specific file, you must declare the function as `static` in the same file in which it is used.

*Indentation*: The indentation style for your work have to be 4 spaces. Many students are taught to use tabs for indentation, which can make code very hard to read, especially when there are several levels of indentation.

For additional information, see [F# style guide](https://docs.microsoft.com/en-us/dotnet/fsharp/style-guide/) or [A comprehensive guide to F# Formatting Conventions](https://github.com/fsprojects/fantomas/blob/master/docs/FormattingConventions.md)
