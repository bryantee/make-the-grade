# Object-oriented Programming
## Pillars of OOP
1. *Encapsulation* - Hide details of our code; access modifiers, etc
2. *Inheritance* - Reuse code across similar classes
3. *Polymorphism* - Objects of same type that can behave differently

*Notes: Encapsulation and Polymorphism probably most important and used. Inheritance less so.*

### Inheritance
- Use `base` keyword to _pass_ along objects to parent constructor. "Chains" constructors.
- Everything in C# derives from `Object` class.
- Abstract classes - Let's us define classes with abstract methods, properties and default method implementations. These methods can be overriden by implementation class.
- Interfaces - Defines abstractions only _but_ classes can implement multiple interfaces.

### Polymorphism
- Keywords
    - `override`
    - `virtual`

### Other details
- `using` keywords useful for auto-handling classes that implement `IDisposable` for auto-cleanup.
