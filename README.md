# DesignPatterns
Examples for design patterns, "antipatterns" and other usefull code snippets

## Basics

### Singleton
This controversial pattern, also considered an "antipattern" by some, is born from a rather simple concept of having
only one instance of a class. To achieve this goal, we used to create a class with private constructor. 
Then we added a static method, which would create new instance only once and then return the same instance 
of the class every time it was called. 
Now there is a better approach available to us - using dependency injection in asp.net core, we can add singletons to 
the service collection and then inject them into our classes. This way we can have a single instance of a class, 
reused across the whole project.