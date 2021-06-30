# Command

Also known as: Action, Transaction


## Description

Command is a behavioral design pattern that turns a request into a stand-alone object that contains all information about the request. This transformation lets you pass requests as a method arguments, delay or queue a request’s execution, and support undoable operations.

## How Implement

 1. Declare the command interface with a single execution method.

 2. Start extracting requests into concrete command classes that implement the command interface. Each class must have a set of fields for storing the request arguments along with a reference to the actual receiver object. All these values must be initialized via the command’s constructor.

 3. Identify classes that will act as senders. Add the fields for storing commands into these classes. Senders should communicate with their commands only via the command interface. Senders usually don’t create command objects on their own, but rather get them from the client code.

 4. Change the senders so they execute the command instead of sending a request to the receiver directly.

 5. The client should initialize objects in the following order:
      * Create receivers.
      * Create commands, and associate them with receivers if needed.
      * Create senders, and associate them with specific commands.

# Pros

  1. Single Responsibility Principle. You can decouple classes that invoke operations from classes that perform these operations.
  2. Open/Closed Principle. You can introduce new commands into the app without breaking existing client code.
  3. You can implement undo/redo.
  4. You can implement deferred execution of operations.
  5. You can assemble a set of simple commands into a complex one.

# Cons
 1. The code may become more complicated since you’re introducing a whole new layer between senders and receivers.

# Structure:

![Structure](https://github.com/NaorShmueli/DesignPatterns/blob/master/DesignPatterns/BehavioralPatterns/Images/Command.JPG?raw=true)

## Authors

[@NaorShmueli](https://www.linkedin.com/in/naor-shmueli-681b06127)
