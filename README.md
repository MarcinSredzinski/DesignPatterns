# DesignPatterns
Examples for design patterns, "antipatterns" and other usefull code snippets

## Basics

## Creational patterns

### Singleton
This controversial pattern, also considered an "antipattern" by some, is born from a rather simple concept of having
only one instance of a class. To achieve this goal, we used to create a class with private constructor. 
Then we added a static method, which would create new instance only once and then return the same instance 
of the class every time it was called. 
Now there is a better approach available to us - using dependency injection in asp.net core, we can add singletons to 
the service collection and then inject them into our classes. This way we can have a single instance of a class, 
reused across the whole project.

#### Sources
https://www.pentalog.com/blog/design-patterns/singleton-design-pattern/ 
https://stackoverflow.com/questions/137975/what-are-drawbacks-or-disadvantages-of-singleton-pattern

### Factory method   
Creational design pattern providing an interface for creating objects, while allowing the subclasses to define 
the type of objects that will be created. 
Participants: 
- Product - an abstraction over the objects the factory method creates, 
- Concrete Product - implementation of the Product abstraction, 
- Creator - declares the factory method which will return an object of type Product. It may have other, common functionality as well as
default implementation of factory method returning a default Concrete Product object, 
- Concrete Creator - presents a concrete implementation of Creator, overriding the factory method to return an instance of a Concrete Product. 

#### Code: 
BusinessLibrary/FactoryMethodExample

#### Sources: 
https://www.dofactory.com/net/factory-method-design-pattern
https://refactoring.guru/design-patterns/factory-method


## Behavioral patterns

### Command pattern
This pattern turns a request into a stand-alone object containing all necessary information about the request. As a result, this object can be 
passed as a method argument, queued or undone. 
Participants: 
- Command interface,
- Concrete command,
- Invoker,
- Client,
- Receiver

### Observer pattern
Behavioral pattern useful when multiple objects(Subscribers) may be interested in changes of a state of a single object(Publisher).


- 
## Data access patterns (From Patterns of Enterprise Application Architecture)  

### Repository pattern 
Repository pattern serves two main purposes:
- to create an abstraction over the data layer, allowing to easier test and potentially switch persistance providers, 
- to centralise the handling of the domain objects, 
It is one of the Domain-Driven Design patterns, intended to keep persistence concerns outside of the system's domain model. You define one or more 
abstractions on the persistence, usually by defining interfaces, that present the operations 
done on the data store and then create adapters - concrete implementations of the interfaces, depending on the specific persistance 
providers(in this example over the in memory database).

#### Sources
https://learn.microsoft.com/en-us/dotnet/architecture/microservices/microservice-ddd-cqrs-patterns/infrastructure-persistence-layer-design 

### Unit of work 
This design pattern has one main focus: to assure, when using multiple repositories, the same context is used for all of them. 
The unit of work class needs just a property for each repository and a Save method. Each repository instance needs to be instantiated using the same instance of DB context. 
Thanks to this, the save is done once for each "unit". Assuming we want to create a client with his orders as an atomic operation, using the unit of work pattern 
we can assure the client will be created only when the orders are created
(as oposed to calling separately orders repository and clients repository and calling save on both of them). This helps with the data consistence. 
Then the save is done on both sets of data. This comes in handy especially for more complex scenarios,
when there are multiple calls to different repositories as a part of a single flow. Using unit of work makes sure that all the operations done on the multiple repositories 
will be completed in a single transaction. 

#### Sources
https://learn.microsoft.com/en-us/dotnet/architecture/microservices/microservice-ddd-cqrs-patterns/infrastructure-persistence-layer-design 

