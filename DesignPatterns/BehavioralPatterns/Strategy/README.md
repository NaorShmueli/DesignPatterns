# Strategy

## Description

Strategy is a behavioral design pattern that lets you define a family of algorithms, put each of them into a separate class, and make their objects interchangeable.

## How Implement

 1. In the context class, identify an algorithm that’s prone to frequent changes. It may also be a massive conditional that selects and executes a variant of the same algorithm at runtime.

 2. Declare the strategy interface common to all variants of the algorithm.

 3. One by one, extract all algorithms into their own classes. They should all implement the strategy interface.

 4. In the context class, add a field for storing a reference to a strategy object. Provide a setter for replacing values of that field. The context should work with the strategy object only via the strategy interface. The context may define an interface which lets the strategy access its data.

 5. Clients of the context must associate it with a suitable strategy that matches the way they expect the context to perform its primary job.

# Pros

 1. You can swap algorithms used inside an object at runtime.
 2. You can isolate the implementation details of an algorithm from the code that uses it.
 3. You can replace inheritance with composition.
 4. Open/Closed Principle. You can introduce new strategies without having to change the context.



# Cons

 1. If you only have a couple of algorithms and they rarely change, there’s no real reason to overcomplicate the program with new classes and interfaces that come along with the pattern.
 2. Clients must be aware of the differences between strategies to be able to select a proper one.
 3. A lot of modern programming languages have functional type support that lets you implement different versions of an algorithm inside a set of anonymous functions. Then you could use these functions exactly as you’d have used the strategy objects, but without bloating your code with extra classes and interfaces.

# Structure:

![Structure](https://github.com/NaorShmueli/DesignPatterns/blob/master/DesignPatterns/BehavioralPatterns/Images/Strategy.JPG?raw=true)

## Authors

[@NaorShmueli](https://www.linkedin.com/in/naor-shmueli-681b06127)
