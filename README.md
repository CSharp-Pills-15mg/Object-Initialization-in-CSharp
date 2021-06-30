# Object initialization in C#

## Question

Sometimes (not very often), the order in which the fields, properties and constructors are initialized/called is important. In this C# Pill I will try to answer this question:

- What is the order in which the fields, properties and constructors are initialized/called in C#?

## Plan

We'll create a Base and a Derived class, each one with fields, properties and constructors, both static and instance and we'll highlight the order in which they are initialized.