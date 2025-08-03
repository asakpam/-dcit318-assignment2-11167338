# Interface Demo - IMovable Implementation

This C# console application demonstrates the concepts of interfaces using a simple vehicle movement system.

## Project Structure

- **IMovable** (Interface): Defines a contract with a `Move()` method that implementing classes must provide
- **Car** (Class): Implements `IMovable` and prints "Car is moving" when `Move()` is called
- **Bicycle** (Class): Implements `IMovable` and prints "Bicycle is moving" when `Move()` is called

## Key Concepts Demonstrated

1. **Interfaces**: IMovable interface defines a contract that classes must follow
2. **Interface Implementation**: Car and Bicycle classes implement the IMovable interface
3. **Method Implementation**: Each class provides its own implementation of the `Move()` method

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
Car is moving
Bicycle is moving
```

## Learning Objectives

- Understand how interfaces work in C#
- Learn how to define interfaces using the `interface` keyword
- See how classes implement interfaces using the `:` syntax
- Practice creating contracts that multiple classes can implement

## Code Features

- **Interface Definition**: IMovable interface with Move() method
- **Simple Implementation**: Both classes implement the required Move() method
- **Basic Demo**: Creates instances and calls Move() on each 