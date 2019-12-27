# HackerRank Day 12

### Objective

Today, we're delving into Inheritance.

### Task

You are given two classes, Person and Student, where Person is 
the base class and Student is the derived class. Completed code for 
Person and a declaration for Student are provided for you in the editor. 
Observe that Student inherits all the properties of Person.

Complete the Student Class by writing the following:

- A Student class constructor, which has 4 parameters:
  - A string, firstName.
  - A string, lastName.
  - An integer, id.
  - An integer array of test scores, scores.
- A char calculate() method that calculates a Student object's average and 
returns the grade character representative of their calculated average:

![](?raw=true)

### Input Format

The locked stub code in your editor calls your Student class constructor 
and passes it the necessary arguments. It also calls the calculate 
method (which takes no arguments).

You are not responsible for reading the following input from stdin:
The first line contains firstName, lastName, and id, respectively. 
The second line contains the number of test scores. The third line 
of space-separated integers describes scores.

### Constraints

- 1 <= |firstName|, |lastName| <= 10
- |id| = 7
- 0 <= score,average <= 100

### Output Format

This is handled by the locked stub code in your editor. Your output 
will be correct if your Student class constructor and calculate() 
method are properly implemented.
