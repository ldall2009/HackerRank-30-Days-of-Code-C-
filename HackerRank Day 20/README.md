# HackerRank Day 20

### Objective

Today, we're discussing a simple sorting algorithm called Bubble Sort.

Consider the following version of Bubble Sort:

`for (int i = 0; i < n; i++) {
    // Track number of elements swapped during a single array traversal
    int numberOfSwaps = 0;
    
    for (int j = 0; j < n - 1; j++) {
        // Swap adjacent elements if they are in decreasing order
        if (a[j] > a[j + 1]) {
            swap(a[j], a[j + 1]);
            numberOfSwaps++;
        }
    }
    
    // If no elements were swapped during a traversal, array is sorted
    if (numberOfSwaps == 0) {
        break;
    }
}`

### Task

Given an array, a, of size n distinct elements, sort the array in ascending 
order using the Bubble Sort algorithm above. Once sorted, print the 
following 3 lines:

- Array is sorted in numSwaps swaps.
  where numSwaps is the number of swaps that took place.
- First Element: firstElement
  where firstElement is the first element in the sorted array.
- Last Element: lastElement
  where lastElement is the last element in the sorted array.

### Input Format

The first line contains an integer, n, denoting the number of elements in array a.
The second line contains n space-separated integers describing the respective values 
of a_0, a_1, ... , a_(n-1).

### Constraints

- 2 <= n <= 600
- 1 <= a_i <= 2 * 10^6, where 0 <= i < n.

### Output Format

Print the following three lines of output:

- `Array is sorted in numSwaps swaps.`
  where numSwaps is the number of swaps that took place.
- `First Element: firstElement`
  where firstElement is the first element in the sorted array.
- `Last Element: lastElement`
  where lastElement is the last element in the sorted array.