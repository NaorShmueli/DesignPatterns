# Abstract Factory

## Description

Abstract Factory is a creational design pattern that lets you produce families of related objects without specifying their concrete classes.

## How Implement

 1. Map out a matrix of distinct product types versus variants of these products.

 2. Declare abstract product interfaces for all product types. Then make all concrete product classes implement these interfaces.

 3. Declare the abstract factory interface with a set of creation methods for all abstract products.

 4. Implement a set of concrete factory classes, one for each product variant.

 5. Create factory initialization code somewhere in the app. It should instantiate one of the concrete factory classes, depending on the application configuration or the current environment. Pass this factory object to all classes that construct products.

 6. Scan through the code and find all direct calls to product constructors. Replace them with calls to the appropriate creation method on the factory object.

# Pros

 1. You can be sure that the products you’re getting from a factory are compatible with each other.
 2. You avoid tight coupling between concrete products and client code.
 3. Single Responsibility Principle. You can extract the product creation code into one place, making the code easier to support.
 4. Open/Closed Principle. You can introduce new variants of products without breaking existing client code.

# Cons
 1. The code may become more complicated than it should be, since a lot of new interfaces and classes are introduced along with the pattern.

# Structure:

![Structure](https://github.com/NaorShmueli/DesignPatterns/blob/master/DesignPatterns/CreationalPatterns/Images/AbstractFactory.JPG?raw=true)

## Author

[@NaorShmueli](https://www.linkedin.com/in/naor-shmueli-681b06127)
