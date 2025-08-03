# Animal Inheritance and Method Overriding Demo

This C# console application demonstrates the concepts of inheritance and method overriding using a simple animal hierarchy.

## Project Structure

- **Animal** (Base Class): Contains a virtual `MakeSound()` method that prints "Some generic sound"
- **Dog** (Derived Class): Inherits from Animal and overrides `MakeSound()` to print "Bark"
- **Cat** (Derived Class): Inherits from Animal and overrides `MakeSound()` to print "Meow"

## Key Concepts Demonstrated

1. **Inheritance**: Dog and Cat classes inherit from the Animal base class
2. **Method Overriding**: The `MakeSound()` method is overridden in derived classes
3. **Virtual Methods**: The base class method is marked as `virtual` to allow overriding

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
Some generic sound
Bark
Meow
```

## Learning Objectives

- Understand how inheritance works in C#
- Learn how to use the `virtual` and `override` keywords
- Practice creating class hierarchies
- See method overriding in action

## Code Features

- **Base Class**: Animal class with virtual MakeSound() method
- **Derived Classes**: Dog and Cat classes that override the MakeSound() method
- **Simple Demo**: Creates instances and calls MakeSound() on each 