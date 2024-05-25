# BoilerPlate codebase to brush up C# concepts

## Inheritance concepts

* Single Inheritance
* Multilevel Inheritance
* Hierarchical Inheritance
* Multi-Inheritance not supported but rather through Interface and Abstract classes



## Abstract class and Interface

> Starting from C# 8.0 both abstraction and Interface can have deafult implemented methods 


### Abstract Classes:

* Can contain both abstract methods (which must be implemented by derived classes) and fully implemented methods.
* Can have constructors, fields, and other member variables.
* Can provide a base class implementation that can be used by derived classes.
* Supports access modifiers (public, protected, private) for methods and properties.

### Interfaces:

* Can have default method implementations starting from C# 8.0.
* Cannot have fields or member variables (except static fields).
* Cannot have constructors.
* Methods in interfaces are implicitly public and cannot have access modifiers (other than explicitly declared default implementations).
