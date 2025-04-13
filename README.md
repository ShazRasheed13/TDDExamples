# Introduction
In TDD, you follow a simple Red-Green-Refactor cycle:

Write a failing test (Red) - Write a test case that fails because the feature is not implemented yet.
Make the test pass (Green) - Write just enough code to pass the test.
Refactor the code (Refactor) - Refactor the code to improve its structure while ensuring all tests still pass.

# TDD Example questions
Problem 1: FizzBuzz
Objective: Write a program that prints numbers from 1 to 100. But for multiples of 3, print "Fizz" instead of the number, and for multiples of 5, print "Buzz." For numbers which are multiples of both 3 and 5, print "FizzBuzz."

Steps:

Write a test case to check if the program returns "Fizz" for multiples of 3.
Write the code to make the test pass.
Add a test case to check if the program returns "Buzz" for multiples of 5.
Write the code to make the test pass.
Add a test case to check if the program returns "FizzBuzz" for multiples of both 3 and 5.
Write the code to make the test pass.
Add a test case to check if the program returns the number for non-multiples of 3 or 5.
Refactor the code.

Problem 2: String Calculator
Objective: Write a simple string calculator that can take a string of numbers separated by commas and return their sum. For example, the string "1,2,3" should return 6.

Steps:

Write a test case for an empty string to return 0.
Write the code to make the test pass.
Add a test case for a single number, e.g., "1" to return 1.
Write the code to make the test pass.
Add a test case for two numbers, e.g., "1,2" to return 3.
Write the code to make the test pass.
Add a test case to handle an unknown number of numbers, e.g., "1,2,3,4,5".
Write the code to make the test pass.
Add a test case to handle invalid input, e.g., "1,,2" or "abcd".
Refactor the code.

