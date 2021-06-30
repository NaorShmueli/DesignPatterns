# Iterator

## Description

Iterator is a behavioral design pattern that lets you traverse elements of a collection without exposing its underlying representation (list, stack, tree, etc.).

## How Implement

 1. Declare the iterator interface. At the very least, it must have a method for fetching the next element from a collection. But for the sake of convenience you can add a couple of other methods, such as fetching the previous element, tracking the current position, and checking the end of the iteration.

 2. Declare the collection interface and describe a method for fetching iterators. The return type should be equal to that of the iterator interface. You may declare similar methods if you plan to have several distinct groups of iterators.

 3. Implement concrete iterator classes for the collections that you want to be traversable with iterators. An iterator object must be linked with a single collection instance. Usually, this link is established via the iterator’s constructor.

 4. Implement the collection interface in your collection classes. The main idea is to provide the client with a shortcut for creating iterators, tailored for a particular collection class. The collection object must pass itself to the iterator’s constructor to establish a link between them.

 5. Go over the client code to replace all of the collection traversal code with the use of iterators. The client fetches a new iterator object each time it needs to iterate over the collection elements.

# Pros

 1. Single Responsibility Principle. You can clean up the client code and the collections by extracting bulky traversal algorithms into separate classes.
 2. Open/Closed Principle. You can implement new types of collections and iterators and pass them to existing code without breaking anything.
 3. You can iterate over the same collection in parallel because each iterator object contains its own iteration state.
 4. For the same reason, you can delay an iteration and continue it when needed.

# Cons

 1. Applying the pattern can be an overkill if your app only works with simple collections.
 2. Using an iterator may be less efficient than going through elements of some specialized collections directly.

# Structure:

![Structure](https://github.com/NaorShmueli/DesignPatterns/blob/master/DesignPatterns/BehavioralPatterns/Images/Iterator.JPG?raw=true)

## Authors

[@NaorShmueli](https://www.linkedin.com/in/naor-shmueli-681b06127)
