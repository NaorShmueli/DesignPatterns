# Decorator

Also known as: Wrapper

## Description

Decorator is a structural design pattern that lets you attach new behaviors to objects by placing these objects inside special wrapper objects that contain the behaviors.

## How Implement

 1. Make sure your business domain can be represented as a primary component with multiple optional layers over it.

 2. Figure out what methods are common to both the primary component and the optional layers. Create a component interface and declare those methods there.

 3. Create a concrete component class and define the base behavior in it.

 4. Create a base decorator class. It should have a field for storing a reference to a wrapped object. The field should be declared with the component interface type to allow linking to concrete components as well as decorators. The base decorator must delegate all work to the wrapped object.

 5. Make sure all classes implement the component interface.

 6. Create concrete decorators by extending them from the base decorator. A concrete decorator must execute its behavior before or after the call to the parent method (which always delegates to the wrapped object).

 7. The client code must be responsible for creating decorators and composing them in the way the client needs.

# Pros

 1. You can extend an object’s behavior without making a new subclass.
 2. You can add or remove responsibilities from an object at runtime.
 3. You can combine several behaviors by wrapping an object into multiple decorators.
 4. Single Responsibility Principle. You can divide a monolithic class that implements many possible variants of behavior into several smaller classes.

# Cons
 
 1. It’s hard to remove a specific wrapper from the wrappers stack.
 2. It’s hard to implement a decorator in such a way that its behavior doesn’t depend on the order in the decorators stack.
 3. The initial configuration code of layers might look pretty ugly.

# Structure:

![Structure](https://github.com/NaorShmueli/DesignPatterns/blob/master/DesignPatterns/StructuralPatterns/Images/Decorator.JPG?raw=true)

## Author

[@NaorShmueli](https://www.linkedin.com/in/naor-shmueli-681b06127)