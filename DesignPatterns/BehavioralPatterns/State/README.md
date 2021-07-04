# State

## Description

State is a behavioral design pattern that lets an object alter its behavior when its internal state changes. It appears as if the object changed its class.

## How Implement

 1. Decide what class will act as the context. It could be an existing class which already has the state-dependent code; or a new class, if the state-specific code is distributed across multiple classes.

 2. Declare the state interface. Although it may mirror all the methods declared in the context, aim only for those that may contain state-specific behavior.

 3. For every actual state, create a class that derives from the state interface. Then go over the methods of the context and extract all code related to that state into your newly created class.
    While moving the code to the state class, you might discover that it depends on private members of the context. There are several workarounds:

      * Make these fields or methods public.
      * Turn the behavior you’re extracting into a public method in the context and call it from the state class. This way is ugly but quick, and you can always fix it later.
      * Nest the state classes into the context class, but only if your programming language supports nesting classes.

 4. In the context class, add a reference field of the state interface type and a public setter that allows overriding the value of that field.

 5. Go over the method of the context again and replace empty state conditionals with calls to corresponding methods of the state object.

 6. To switch the state of the context, create an instance of one of the state classes and pass it to the context. You can do this within the context itself, or in various states, or in the client. Wherever this is done, the class becomes dependent on the concrete state class that it instantiates.

# Pros

 1. Single Responsibility Principle. Organize the code related to particular states into separate classes.
 2.  Open/Closed Principle. Introduce new states without changing existing state classes or the context.
 3. Simplify the code of the context by eliminating bulky state machine conditionals.


# Cons

  1. Applying the pattern can be overkill if a state machine has only a few states or rarely changes.

# Structure:

![Structure](https://github.com/NaorShmueli/DesignPatterns/blob/master/DesignPatterns/BehavioralPatterns/Images/State.JPG?raw=true)

## Authors

[@NaorShmueli](https://www.linkedin.com/in/naor-shmueli-681b06127)
