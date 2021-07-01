# Object initialization in C#

## Category

Language (C#)

## Description

- Q: What is the order in which the fields, properties and constructors are called in C#?
- A: Highlight the order of calling them by creating a short program.

## Recipe

- Create a C# Console Application.
- Create two classes. One should inherit the other one.
  - `Base` class
  - `Derived` class
- Create a `Trace` class.
  - Write a constructor that receives a text message and writes it in the console. This way we will know when the class is instantiated. It will be used later in the `Base` and `Derived` classes.
- In each class:
  - add a static field of type `Trace` and initialize it.
  - add a static property of type `Trace` and initialize it.
  - add an instance field of type `Trace` and initialize it.
  - add an instance property of type `Trace` and initialize it.
- In each class:
  - create a static constructor that writes a message to the console, to know when it was called.
  - create an instance constructor that writes a message to the console, to know when it was called.
- Run the application and observe the order in which the messages are displayed in the console.

