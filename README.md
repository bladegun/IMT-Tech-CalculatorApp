# Calculator App

This repository contains a solution file with two .NET 8 projects.


## DecimalCalculator

This project contains a `Calculator` class that accepts `System.Decimal` values and returns the result as `System.Decimal`. The `Calculator` class can perform:

- Add
- Subtract
- Multiply
- Divide


## DoubleCalculator

This project contains a `Calculator` class that accepts `System.Double` values and returns the result as `System.Double`. The `Calculator` class can perform:

- Add
- Subtract
- Multiply
- Divide


## Requirement

- Move the `Calculator` class from both projects into a library.
- Refactor the code so that there is only one `Calculator` class in this library.
- This `Calculator` class must be able to accept and return both `System.Decimal` values and `System.Double` values.
- Modify `DecimalCalculator` and `DoubleCalculator` projects to use the `Calculator` class from this library.
- All decimal literals specified in `Console.WriteLine(...)` statements in `DecimalCalculator` project should remain as it is.
- All double literals specified in `Console.WriteLine(...)` statements in `DoubleCalculator` project should remain as it is.
