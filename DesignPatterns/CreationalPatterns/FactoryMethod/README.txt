Abstract Factory pattern defers creation of product objects to the ConcreteFactory subclass. 
Since a client is expecting Factory class (which is the parent of ConcreteFactory subclasses) as a method parameter; 
based on the instance of ConcreteFactory passed, corresponding product instance is created. 
So Abstract Factory creates product instances by calling factory methods on a ConcreteFactory instance passed at runtime. 
Hence this is object design pattern. Typically these Concrete factories are Singletons.

Factory method happens at the class level however. A new ConcreteFactory class has to be created to instantiate a ConcreteProduct. 
This ConcreteFactory extends Factory class which has a create() method returning Product. 
ConcreteFactory overrides create() method defined in the Factory parent class.

Aswering the comment:

Yes Factory method is parameterized but in AbstractFactory you will be able to call methods on a ConcreteFactory passed 
thus enabling you to switch to a different ConcreteFactory at runtime. 
But in Factory since create() is part of the class, 
if you want to create concrete products you have to create ConcreteFactory which extends the parent Factory class.

I will try to answer your question but let's take a step back. 
The motivation to apply these patterns is different. 
In AbstractFactory you want to be able to create multiple families of products but in Factory you are providing 
hooks for subclasses (Concrete factories) to be able to create ConcreteProduct