# HackerRank Day 13

### Objective

Today, we're taking what we learned yesterday about 
Inheritance and extending it to Abstract Classes.

### Task

Given a Book class and a Solution class, write a MyBook class that does the
following:

- Inherits from Book
- Has a parameterized constructor taking these 3 parameters:
  - A string, title.
  - A string, author.
  - An integer, price.
- Implements the book class' abstract display() method so it prints
these 3 lines:
  - Title: a space, and then the current instance's title.
  - Author: a space, and then the current instance's author.
  - Price: a space, and then the current instance's price. 

### Input Format

You are not responsible for reading any input from stdin. 
The Solution class creates a Book object and calls the MyBook 
class constructor (passing it the necessary arguments). It then 
calls the display method on the Book object.

### Output Format

The void display() method should print and label the respective title, 
author, and price of the MyBook object's instance (with each value on 
its own line).
