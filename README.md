# F# Mutable Variable Bug

This repository demonstrates a common mistake when using mutable variables in F# functions.  The issue is that mutable variables passed as arguments to a function are not updated within the function's scope if the function doesn't modify them explicitly.

## Bug Description

The `bug.fs` file contains a simple function that adds two numbers.  However, when the mutable variables are updated *after* calling the function, the function still uses the original values.

## Solution

The `bugSolution.fs` file corrects the issue by either explicitly passing updated values as parameters or using the mutable variables outside of function calls. See the comments in the solution file for more details.