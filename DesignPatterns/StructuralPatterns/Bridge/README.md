# Bridge

## Description

Bridge is a structural design pattern that lets you split a large class or a set of closely related classes into two separate hierarchies—abstraction and implementation—which can be developed independently of each other.

## How Implement

 1. Identify the orthogonal dimensions in your classes. These independent concepts could be: abstraction/platform, domain/infrastructure, front-end/back-end, or interface/implementation.

 2. See what operations the client needs and define them in the base abstraction class.

 3. Determine the operations available on all platforms. Declare the ones that the abstraction needs in the general implementation interface.

 4. For all platforms in your domain create concrete implementation classes, but make sure they all follow the implementation interface.

 5. Inside the abstraction class, add a reference field for the implementation type. The abstraction delegates most of the work to the implementation object that’s referenced in that field.

 6. If you have several variants of high-level logic, create refined abstractions for each variant by extending the base abstraction class.

 7. The client code should pass an implementation object to the abstraction’s constructor to associate one with the other. After that, the client can forget about the implementation and work only with the abstraction object.

# Pros

 1. You can create platform-independent classes and apps.
 2. The client code works with high-level abstractions. It isn’t exposed to the platform details.
 3. Open/Closed Principle. You can introduce new abstractions and implementations independently from each other.
 4.Single Responsibility Principle. You can focus on high-level logic in the abstraction and on platform details in the implementation.

# Cons
 
 1. You might make the code more complicated by applying the pattern to a highly cohesive class.

# Structure:

![Structure](https://github.com/NaorShmueli/DesignPatterns/blob/master/DesignPatterns/StructuralPatterns/Images/Bridge.JPG?raw=true)


# Note
##Adapter vs Bridge pattern
###Key differences:

 1. Bridge makes them work before they are.
    Adapter makes things work after they're designed; 
    
 2. Bridge is designed up-front to let the abstraction and the implementation vary independently. 
    Adapter is retrofitted to make unrelated classes work together.

## Author

[@NaorShmueli](https://www.linkedin.com/in/naor-shmueli-681b06127)