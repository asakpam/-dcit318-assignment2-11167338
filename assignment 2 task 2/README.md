# Abstract Classes and Methods Demo - Shape Area Calculator

This C# console application demonstrates the concepts of abstract classes and methods using a shape area calculator.

## Project Structure

- **Shape** (Abstract Base Class): Contains an abstract `GetArea()` method that must be implemented by derived classes
- **Circle** (Derived Class): Implements `GetArea()` to calculate the area of a circle using π × r²
- **Rectangle** (Derived Class): Implements `GetArea()` to calculate the area of a rectangle using length × width

## Key Concepts Demonstrated

1. **Abstract Classes**: The Shape class cannot be instantiated directly and serves as a template
2. **Abstract Methods**: The `GetArea()` method must be implemented by all derived classes
3. **Method Overriding**: Derived classes provide their own implementation of the abstract method
4. **Polymorphism**: The same method call produces different results based on the object type
5. **Virtual Methods**: The base class also contains a virtual method that can be overridden

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
Abstract Classes and Methods Demo - Shape Area Calculator
========================================================

Calculating areas using abstract methods:
----------------------------------------
Circle with radius 5:
Area: 78.54

Rectangle with length 4 and width 6:
Area: 24.00

Demonstrating Polymorphism with Shape Array:
============================================
Shape 1: Circle with radius 5:
Area: 78.54
Shape 2: Rectangle with length 4 and width 6:
Area: 24.00

Press any key to exit...
```

## Learning Objectives

- Understand how abstract classes work in C#
- Learn how to use the `abstract` keyword for classes and methods
- See how abstract methods force derived classes to provide implementations
- Practice creating class hierarchies with abstract base classes
- Understand the difference between abstract and virtual methods

## Code Features

- **Abstract Base Class**: Shape class with abstract GetArea() method
- **Constructor Parameters**: Circle and Rectangle classes accept dimensions in their constructors
- **Method Overriding**: Both derived classes override the abstract method
- **Polymorphism**: Array of Shape objects demonstrates runtime polymorphism
- **Formatted Output**: Areas are displayed with 2 decimal places 