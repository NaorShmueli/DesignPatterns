# Factory Method

Also known as: Virtual Constructor


## Description

Factory Method is a creational design pattern that provides an interface for creating objects in a superclass, but allows subclasses to alter the type of objects that will be created.

## How Implement

 1. Make all products follow the same interface. This interface should declare methods that make sense in every product.

 2 .Add an empty factory method inside the creator class. The return type of the method should match the common product interface.

 3. In the creator’s code find all references to product constructors. One by one, replace them with calls to the factory method, while extracting the product creation code into the factory method.
    You might need to add a temporary parameter to the factory method to control the type of returned product.
    At this point, the code of the factory method may look pretty ugly. It may have a large switch operator that picks which product class to instantiate. But don’t worry, we’ll fix it soon enough.

 4. Now, create a set of creator subclasses for each type of product listed in the factory method. Override the factory method in the subclasses and extract the appropriate bits of construction code from the base method.

 5. If there are too many product types and it doesn’t make sense to create subclasses for all of them, you can reuse the control parameter from the base class in subclasses.
    For instance, imagine that you have the following hierarchy of classes: the base Mail class with a couple of subclasses: AirMail and GroundMail; the Transport classes are Plane, Truck and Train. While the AirMail class only uses Plane objects, GroundMail may work with both Truck and Train objects. You can create a new subclass (say TrainMail) to handle both cases, but there’s another option. The client code can pass an argument to the factory method of the GroundMail class to control which product it wants to receive.

 6. If, after all of the extractions, the base factory method has become empty, you can make it abstract. If there’s something left, you can make it a default behavior of the method.

# Pros

 1. You avoid tight coupling between the creator and the concrete products.
 2. Single Responsibility Principle. You can move the product creation code into one place in the program, making the code easier to support.
 3. Open/Closed Principle. You can introduce new types of products into the program without breaking existing client code.

# Cons
 1.   The code may become more complicated since you need to introduce a lot of new subclasses to implement the pattern. The best case scenario is when you’re introducing the pattern into an existing hierarchy of creator classes.

# Structure:

![Structure](https://github.com/NaorShmueli/DesignPatterns/blob/master/DesignPatterns/CreationalPatterns/Images/FactoryMethod.JPG?raw=true)

# Notes:

 * Abstract Factory pattern defers creation of product objects to the ConcreteFactory subclass. 
   Since a client is expecting Factory class (which is the parent of ConcreteFactory subclasses) as a method parameter; 
   based on the instance of ConcreteFactory passed, corresponding product instance is created. 
   So Abstract Factory creates product instances by calling factory methods on a ConcreteFactory instance passed at runtime. 
   Hence this is object design pattern. Typically these Concrete factories are Singletons.

 * Factory method happens at the class level however. A new ConcreteFactory class has to be created to instantiate a ConcreteProduct. 
   This ConcreteFactory extends Factory class which has a create() method returning Product. 
   ConcreteFactory overrides create() method defined in the Factory parent class.

 * Yes Factory method is parameterized but in AbstractFactory you will be able to call methods on a ConcreteFactory passed 
   thus enabling you to switch to a different ConcreteFactory at runtime. 
   But in Factory since create() is part of the class, 
   if you want to create concrete products you have to create ConcreteFactory which extends the parent Factory class.

 * I will try to answer your question but let's take a step back. 
   The motivation to apply these patterns is different. 
   In AbstractFactory you want to be able to create multiple families of products but in Factory you are providing 
   hooks for subclasses (Concrete factories) to be able to create ConcreteProduct