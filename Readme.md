# BoilerPlate codebase to brush up C# concepts

Microsoft Documentation followed -> https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/

Using -> .Net 8.0 -> C# (language version 12)


## OOPS Concepts

### Inheritance concepts

* Single Inheritance (Ex- Parent - child)
* Multilevel Inheritance (Ex - Two classes extends same parent class)
* Hierarchical Inheritance (Ex - Grandparent - Parent - Child)
* Multi-Inheritance not supported but rather through Interface and Abstract classes

> Starting from C# 8.0 both abstraction and Interface can have default implemented methods 


### Abstract Classes

* Can contain both abstract methods (which must be implemented by derived classes) and fully implemented methods.
* Can have constructors, fields, and other member variables.
* Can provide a base class implementation that can be used by derived classes.
* Supports access modifiers (public, protected, private) for methods and properties.

### Interfaces

* Can have default method implementations starting from C# 8.0.
* Cannot have fields or member variables (except static fields).
* Cannot have constructors.
* Methods in interfaces are implicitly public and cannot have access modifiers (other than explicitly declared default implementations).


### Constructors

* There are two types of constructors - Normal (parameterized or parameterless) and Static constructors. Parameterless is just the other
name of default constructor. 
* Static constructors do not take parameters and if nothing is assigned , it assigns default values of variable types to the variables present
* Primary Constructor was introduced from C# 12.0 
* To call parent constructors from a child class, we need to use `base` keyword.
* To call primary constructor from a explicit constructor of a class , we can use the `this` keyword
* private constructors for not letting users to instantiate the class (Example - Math class)
* Static constructor - https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/static-constructors