# Adapter

Also known as: Wrapper

## Description

Adapter is a structural design pattern that allows objects with incompatible interfaces to collaborate.

## How Implement

 1. Make sure that you have at least two classes with incompatible interfaces:
      * A useful service class, which you can’t change (often 3rd-party, legacy or with lots of existing dependencies).
      * One or several client classes that would benefit from using the service class.
 2. Declare the client interface and describe how clients communicate with the service.

 3. Create the adapter class and make it follow the client interface. Leave all the methods empty for now.

 4. Add a field to the adapter class to store a reference to the service object. The common practice is to initialize this field via the constructor, but sometimes it’s more convenient to pass it to the adapter when calling its methods.

 5. One by one, implement all methods of the client interface in the adapter class. The adapter should delegate most of the real work to the service object, handling only the interface or data format conversion.

 6. Clients should use the adapter via the client interface. This will let you change or extend the adapters without affecting the client code.

# Pros

 1. Single Responsibility Principle. You can separate the interface or data conversion code from the primary business logic of the program.
 2. Open/Closed Principle. You can introduce new types of adapters into the program without breaking the existing client code, as long as they work with the adapters through the client interface.


# Cons
 
 1. The overall complexity of the code increases because you need to introduce a set of new interfaces and classes. Sometimes it’s simpler just to change the service class so that it matches the rest of your code.

# Structure:

![Structure](https://github.com/NaorShmueli/DesignPatterns/blob/master/DesignPatterns/StructuralPatterns/Images/Adapter.JPG?raw=true)

## Author

[@NaorShmueli](https://www.linkedin.com/in/naor-shmueli-681b06127)