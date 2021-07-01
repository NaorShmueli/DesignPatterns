# Memento

Also known as: Snapshot

## Description

Memento is a behavioral design pattern that lets you save and restore the previous state of an object without revealing the details of its implementation.

## How Implement

 1. Determine what class will play the role of the originator. It’s important to know whether the program uses one central object of this type or multiple smaller ones.

 2. Create the memento class. One by one, declare a set of fields that mirror the fields declared inside the originator class.

 3. Make the memento class immutable. A memento should accept the data just once, via the constructor. The class should have no setters.

 4. If your programming language supports nested classes, nest the memento inside the originator. If not, extract a blank interface from the memento class and make all other objects use it to refer to the memento. You may add some metadata operations to the interface, but nothing that exposes the originator’s state.

 5. Add a method for producing mementos to the originator class. The originator should pass its state to the memento via one or multiple arguments of the memento’s constructor.
    The return type of the method should be of the interface you extracted in the previous step (assuming that you extracted it at all). Under the hood, the memento-producing method should work directly with the memento class.

 6. Add a method for restoring the originator’s state to its class. It should accept a memento object as an argument. If you extracted an interface in the previous step, make it the type of the parameter. In this case, you need to typecast the incoming object to the memento class, since the originator needs full access to that object.

 7. The caretaker, whether it represents a command object, a history, or something entirely different, should know when to request new mementos from the originator, how to store them and when to restore the originator with a particular memento.

 8. The link between caretakers and originators may be moved into the memento class. In this case, each memento must be connected to the originator that had created it. The restoration method would also move to the memento class. However, this would all make sense only if the memento class is nested into originator or the originator class provides sufficient setters for overriding its state.

# Pros

 1. You can produce snapshots of the object’s state without violating its encapsulation.
 2. You can simplify the originator’s code by letting the caretaker maintain the history of the originator’s state.

# Cons

 1. The app might consume lots of RAM if clients create mementos too often.
 2. Caretakers should track the originator’s lifecycle to be able to destroy obsolete mementos.
 3. Most dynamic programming languages, such as PHP, Python and JavaScript, can’t guarantee that the state within the memento stays untouched.

# Structure:

![Structure](https://github.com/NaorShmueli/DesignPatterns/blob/master/DesignPatterns/BehavioralPatterns/Images/Memento.JPG?raw=true)

## Authors

[@NaorShmueli](https://www.linkedin.com/in/naor-shmueli-681b06127)
