//------------------------------
//   DO NOT MODIFY THIS FILE
//------------------------------
module Test

open System
open Expecto
open Expecto.Impl
open Expecto.Logging
open Expecto.Logging.Message
open Assignment

let tests =
  testList "Tests" [
    testCase "p1" (fun () ->
        Expect.equal (tribn 0) 0 "tribn(0) = 0"
        Expect.equal (tribn 3) 2 "tribn(0) = 2"
        Expect.equal (tribn 14) 1705 "tribn(14) = 1705"
        Expect.equal (tribn -1) 0 "tribn(-1) = 0"
    );
    testCase "p2" (fun () ->
        Expect.equal (tribn2 0) 0 "tribn2(0) = 0"
        Expect.equal (tribn2 3) 2 "tribn2(0) = 2"
        Expect.equal (tribn2 14) 1705 "tribn2(14) = 1705"
        Expect.equal (tribn2 -1) 0 "tribn2(-1) = 0"
        Expect.equal (tribn2 37) 2082876103 "tribn2(37) = 2082876103"
    );
    testCase "p3" (fun () ->
        Expect.equal (last [1;2;3;4;5]) 5 "last [1;2;3;4;5] = 5"
    );
    testCase "p4" (fun () ->
        Expect.equal (fourth [1;2;3;4;5]) 4 "fourth [1;2;3;4;5] = 4"
        Expect.equal (fourth [1;2]) 0 "fourth [1;2] = 0"
        Expect.equal (fourth List.empty<int>) 0 "fourth [] = 0"
    );
    testCase "p5" (fun () ->
        Expect.equal (everyfourth [1..13]) [4;8;12] "everyfourth [1..13] = [4;8;12]"
        Expect.equal (everyfourth [1;2;3]) [] "everyfourth [1;2;3] = []"
        Expect.equal (everyfourth List.empty<int>) [] "everyfourth [] = []"
    );
    testCase "p6" (fun () ->
        Expect.equal (take 3 [1..10]) [1;2;3] "take 3 [1..10] = [1;2;3]"
        Expect.equal (take 0 [1..10]) [] "take 0 [1..10] = []"
        Expect.equal (take 3 List.empty<int>) [] "take 3 [] = []"
        Expect.equal (take 100 [1..10]) [1..10] "take 100 [1..10] = [1..10]"
    );
    testCase "p7" (fun () ->
        Expect.equal (drop 3 [1..10]) [4..10] "drop 3 [1..10] = [4..10]"
        Expect.equal (drop 0 [1..10]) [1..10] "drop 0 [1..10] = []"
        Expect.equal (drop 3 List.empty<int>) [] "drop 3 [] = []"
        Expect.equal (drop 100 [1..10]) [] "drop 100 [1..10] = []"
    );
  ]

[<EntryPoint>]
let main args =
  let customFail = { TestPrinters.defaultPrinter with
                        failed = fun n m d ->
                            let lines = m.Split('\n')
                            let res = Array.tryFindIndex (fun (s:string) -> s.Contains("tests.fs")) lines
                            let i = if res.IsNone then 3 else res.Value
                            let newmsg = lines.[0..i] |> Array.fold (fun r s -> r + s + "\n") ""
                            async {
                              do! logger.log LogLevel.Error (
                                    eventX "{testName} failed in {duration}. {message}"
                                    >> setField "testName" n
                                    >> setField "duration" d
                                    >> setField "message" (newmsg.TrimEnd('\n')))
                            }
                    }
  let config = [
    Printer customFail
  ]
  runTestsWithCLIArgs config args tests
