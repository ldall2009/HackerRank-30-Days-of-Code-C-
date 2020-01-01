# HackerRank Day 17

### Objective

Yesterday's challenge taught you to manage exceptional situations by using 
try and catch blocks. In today's challenge, you're going to practice throwing 
and propagating an exception.

### Task

Write a Calculator class with a single method: int power(int,int). The 
power method takes two integers, n and p, as parameters and returns the 
integer result of n^p. If either n or p is negative, then the method must 
throw an exception with the message: `n and p should be non-negative`.

### Input Format

Input from stdin is handled for you by the locked stub code in your editor. 
The first line contains an integer, T, the number of test cases. Each 
of the T subsequent lines describes a test case in 2 space-separated 
integers denoting n and p, respectively.

### Output Format

Output to stdout is handled for you by the locked stub code in your 
editor. There are T lines of output, where each line contains the result 
of n^p as calculated by your Calculator class' power method.