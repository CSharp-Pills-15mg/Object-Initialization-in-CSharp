# Object initialization in C#

## Preparation Recipe

- Create a C# Console Application.
- Create two classes. One should inherit the other one.
  - `Base` class
  - `Derived` class
- Create a `Dummy` struct.
  - Write a constructor that receives a text message and writes it in the console. This way we will know when the class is instantiated. It will be used later in the `Base` and `Derived` classes.
  
    ```csharp
    internal struct Dummy
    {
        public Dummy(string message)
        {
            Console.WriteLine(message);
        }
    }
    ```
- In each class:
  - add a static field of type `Dummy` and initialize it.
  - add a static property of type `Dummy` and initialize it.
  - add an instance field of type `Dummy` and initialize it.
  - add an instance property of type `Dummy` and initialize it.
- In each class:
  - create a static constructor that writes a message to the console, to know when it was called.
  - create an instance constructor that writes a message to the console, to know when it was called.
- Run the application and observe the order in which the messages are displayed in the console.

