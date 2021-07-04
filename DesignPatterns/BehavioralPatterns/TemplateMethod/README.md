# Template Method

## Description

Template Method is a behavioral design pattern that defines the skeleton of an algorithm in the superclass but lets subclasses override specific steps of the algorithm without changing its structure.

## How Implement

 1. Analyze the target algorithm to see whether you can break it into steps. Consider which steps are common to all subclasses and which ones will always be unique.

 2. Create the abstract base class and declare the template method and a set of abstract methods representing the algorithm’s steps. Outline the algorithm’s structure in the template method by executing corresponding steps. Consider making the template method final to prevent subclasses from overriding it.

 3. It’s okay if all the steps end up being abstract. However, some steps might benefit from having a default implementation. Subclasses don’t have to implement those methods.

 4. Think of adding hooks between the crucial steps of the algorithm.

 5. For each variation of the algorithm, create a new concrete subclass. It must implement all of the abstract steps, but may also override some of the optional ones.

# Pros

 1. You can let clients override only certain parts of a large algorithm, making them less affected by changes that happen to other parts of the algorithm.
 2. You can pull the duplicate code into a superclass.



# Cons

 1. Some clients may be limited by the provided skeleton of an algorithm.
 2. You might violate the Liskov Substitution Principle by suppressing a default step implementation via a subclass.
 3. Template methods tend to be harder to maintain the more steps they have.

# Structure:

![Structure](https://github.com/NaorShmueli/DesignPatterns/blob/master/DesignPatterns/BehavioralPatterns/Images/TemplateMethod.JPG?raw=true)

## Authors

[@NaorShmueli](https://www.linkedin.com/in/naor-shmueli-681b06127)
