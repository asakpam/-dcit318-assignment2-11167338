# Abstract Classes and Methods Demo - Shape Area Calculator

This C# console application demonstrates the concepts of abstract classes and methods using a shape area calculator.

## Project Structure

- **Shape** (Abstract Base Class): Contains an abstract `GetArea()` method that must be implemented by derived classes
- **Circle** (Derived Class): Implements `GetArea()` to calculate the area of a circle using π × r²
- **Rectangle** (Derived Class): Implements `GetArea()` to calculate the area of a rectangle using length × width

## Key Concepts Demonstrated

1. **Abstract Classes**: The Shape class cannot be instantiated directly and serves as a template
2. **Abstract Methods**: The `GetArea()` method must be implemented by all derived classes
3. **Method Implementation**: Derived classes provide their own implementation of the abstract method

## How to Run

1. Make sure you have .NET 8.0 or later installed
2. Open a terminal in the project directory
3. Run the following commands:

```bash
dotnet restore
dotnet build
dotnet run
```

## Expected Output

```
Circle area: 78.54
Rectangle area: 24.00
```

## Learning Objectives

- Understand how abstract classes work in C#
- Learn how to use the `abstract` keyword for classes and methods
- See how abstract methods force derived classes to provide implementations
- Practice creating class hierarchies with abstract base classes

## Code Features

- **Abstract Base Class**: Shape class with abstract GetArea() method
- **Simple Implementation**: Both derived classes implement the abstract method
- **Basic Demo**: Creates instances and displays their areas 