# Proxy

## Description

Proxy is a structural design pattern that lets you provide a substitute or placeholder for another object. A proxy controls access to the original object, allowing you to perform something either before or after the request gets through to the original object.

## How Implement

 1. If there’s no pre-existing service interface, create one to make proxy and service objects interchangeable. Extracting the interface from the service class isn’t always possible, because you’d need to change all of the service’s clients to use that interface. Plan B is to make the proxy a subclass of the service class, and this way it’ll inherit the interface of the service.

 2. Create the proxy class. It should have a field for storing a reference to the service. Usually, proxies create and manage the whole life cycle of their services. On rare occasions, a service is passed to the proxy via a constructor by the client.

 3. Implement the proxy methods according to their purposes. In most cases, after doing some work, the proxy should delegate the work to the service object.

 4. Consider introducing a creation method that decides whether the client gets a proxy or a real service. This can be a simple static method in the proxy class or a full-blown factory method.

 5. Consider implementing lazy initialization for the service object.

# Pros

 1. You can control the service object without clients knowing about it.
 2. You can manage the lifecycle of the service object when clients don’t care about it.
 3. The proxy works even if the service object isn’t ready or is not available.
 4. Open/Closed Principle. You can introduce new proxies without changing the service or clients.

<div style={color:'red'}> # Cons</div>
 
 1. The code may become more complicated since you need to introduce a lot of new classes.
 2. The response from the service might get delayed.

# Structure:

![Structure](https://github.com/NaorShmueli/DesignPatterns/blob/master/DesignPatterns/StructuralPatterns/Images/Proxy.JPG?raw=true)

# Note
## Proxy vs Adapter
### Key differences:

 1. Proxy provides the same interface
    Adapter provides a different interface to its subject. 
 2. Adapter is meant to change the interface of an existing object

## Author

[@NaorShmueli](https://www.linkedin.com/in/naor-shmueli-681b06127)




