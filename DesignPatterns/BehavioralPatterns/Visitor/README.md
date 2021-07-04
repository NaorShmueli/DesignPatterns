# Visitor

## Description

Visitor is a behavioral design pattern that lets you separate algorithms from the objects on which they operate.

## How Implement

 1. Declare the visitor interface with a set of “visiting” methods, one per each concrete element class that exists in the program.

 2. Declare the element interface. If you’re working with an existing element class hierarchy, add the abstract “acceptance” method to the base class of the hierarchy. This method should accept a visitor object as an argument.

 3. Implement the acceptance methods in all concrete element classes. These methods must simply redirect the call to a visiting method on the incoming visitor object which matches the class of the current element.

 4. The element classes should only work with visitors via the visitor interface. Visitors, however, must be aware of all concrete element classes, referenced as parameter types of the visiting methods.

 5. For each behavior that can’t be implemented inside the element hierarchy, create a new concrete visitor class and implement all of the visiting methods.
    You might encounter a situation where the visitor will need access to some private members of the element class. In this case, you can either make these fields or methods public, violating the element’s encapsulation, or nest the visitor class in the element class. The latter is only possible if you’re lucky to work with a programming language that supports nested classes.

 6. The client must create visitor objects and pass them into elements via “acceptance” methods.

# Pros

 1. Open/Closed Principle. You can introduce a new behavior that can work with objects of different classes without changing these classes.
 2. Single Responsibility Principle. You can move multiple versions of the same behavior into the same class.
 3. A visitor object can accumulate some useful information while working with various objects. This might be handy when you want to traverse some complex object structure, such as an object tree, and apply the visitor to each object of this structure.




# Cons

  1. You need to update all visitors each time a class gets added to or removed from the element hierarchy.
  2. Visitors might lack the necessary access to the private fields and methods of the elements that they’re supposed to work with.

# Structure:

![Structure](https://github.com/NaorShmueli/DesignPatterns/blob/master/DesignPatterns/BehavioralPatterns/Images/Visitor.JPG?raw=true)

## Authors

[@NaorShmueli](https://www.linkedin.com/in/naor-shmueli-681b06127)
