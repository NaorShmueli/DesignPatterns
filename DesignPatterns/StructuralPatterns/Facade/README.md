# Facade

## Description

Facade is a structural design pattern that provides a simplified interface to a library, a framework, or any other complex set of classes.

## How Implement

 1. Check whether it’s possible to provide a simpler interface than what an existing subsystem already provides. You’re on the right track if this interface makes the client code independent from many of the subsystem’s classes.

 2. Declare and implement this interface in a new facade class. The facade should redirect the calls from the client code to appropriate objects of the subsystem. The facade should be responsible for initializing the subsystem and managing its further life cycle unless the client code already does this.

 3. To get the full benefit from the pattern, make all the client code communicate with the subsystem only via the facade. Now the client code is protected from any changes in the subsystem code. For example, when a subsystem gets upgraded to a new version, you will only need to modify the code in the facade.

 4. If the facade becomes too big, consider extracting part of its behavior to a new, refined facade class.

# Pros

 1. You can isolate your code from the complexity of a subsystem.

# Cons
 
 1. A facade can become a god object coupled to all classes of an app.

# Structure:

![Structure](https://github.com/NaorShmueli/DesignPatterns/blob/master/DesignPatterns/StructuralPatterns/Images/Facade.JPG?raw=true)

# Note

 ComplexSubSystem - Is the sub-system that we create Facade for it. 
 The sub-system contains a lot of object with init step, configurations and extra data.
 We not need all sub-system only a part of it in example only Encode method for file.
 So we create Facade that responsible for init object and communications with sub-system.

## Author

[@NaorShmueli](https://www.linkedin.com/in/naor-shmueli-681b06127)


