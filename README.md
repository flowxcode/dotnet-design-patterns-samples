# Samples of .NET design patterns

fork started to be all around patterns for C#.
current state of the art is the implementation for current use case of generating patterns:

master branch is now featuring this case.

  * [Generating patterns](#generating)
    * [Builder](#builder)
    * [Singleton](#singleton)
    * [Prototype](#prototype)
    * [Null Object](#null-object)
    * [Object Pool](#object-pool)
    * [Factory Method](#factory-method)
    * [Abstract Factory](#abstract-factory)
  * [Structural patterns](#structural)
    * [Proxy](#proxy)
    * [Bridge](#bridge)
    * [Facade](#facade)
    * [Adapter](#adapter)
    * [Flyweight](#flyweight)
    * [Decorator](#decorator)
    * [Composite](#composite)
    * [Specification](#specification)

## Generating
## [Builder](https://github.com/AliakseiFutryn/dotnet-design-patterns-samples/blob/master/Generating/Builder)

* The builder pattern is responsible for separating constructing of large object from his representation. It means, that you can receive different representation after the similar construction process. [wiki](https://en.wikipedia.org/wiki/Builder_pattern)
  * This pattern is recommended in the following cases:
    * You should construct a large object with many different properties.
    * You should construct one object from another.
    
## [Singleton](https://github.com/AliakseiFutryn/dotnet-design-patterns-samples/blob/master/Generating/Singleton)

* This is a generating pattern, which provides you with guarantee, that this object is only one in the one-thread application and has global access point. [wiki](https://en.wikipedia.org/wiki/Singleton_pattern)
  * This pattern is recommended in the following cases:
    * You need an instace of an object, which has a single representation withit a system.
    * You need an access to some resource, which is used by different parts of our application like a unity container.

## [Prototype](https://github.com/AliakseiFutryn/dotnet-design-patterns-samples/blob/master/Generating/Prototype)
* This is a generating patter, which is used when the type of objects to create is determined by a prototypical instance, which is cloned to produce new objects. [wiki](https://en.wikipedia.org/wiki/Prototype_pattern)
  * This pattern is recommended in the following cases:
    * When you need to avoid subclasses of an object creator in the client application, like the abstract factory pattern does.
    * When you should avoid the inherent cost of creating a new object in the standard way (e.g., using the 'new' keyword) when it is prohibitively expensive for a given application.

## [Null Object](https://github.com/AliakseiFutryn/dotnet-design-patterns-samples/blob/master/Generating/NullObject)
* This is a generating patter, instead of using a null reference to convey absence of an object (for instance, a non-existent customer), one uses an object which implements the expected interface, but whose method body is empty. The advantage of this approach over a working default implementation is that a Null Object is very predictable and has no side effects: it does nothing. [wiki](https://en.wikipedia.org/wiki/Null_Object_pattern)
  * This pattern is recommended in the following cases:
    * When you have many objects, which implement special interface and you have to perform some action without any errors.
    * This pattern can also be used to act as a stub for testing, if a certain feature such as a database is not available for testing.

## [Object Pool](https://github.com/AliakseiFutryn/dotnet-design-patterns-samples/blob/master/Generating/ObjectPool)
* The object pool design pattern creates a set of objects that may be reused. When a new object is needed, it is requested from the pool. If a previously prepared object is available it is returned immediately, avoiding the instantiation cost. If no objects are present in the pool, a new item is created and returned. [wiki](https://en.wikipedia.org/wiki/Object_pool_pattern)
  * This pattern is recommended in the following cases:
    * You shoul work with a large number of objects that are particularly expensive to instantiate and each object is only needed for a short period of time.
    * You want to improve performance of some piece of code, where you have many objects, which you can reuse.
* As well you can find a perfect example of object pool pattern from Googler [here](http://stackoverflow.com/questions/2510975/c-sharp-object-pooling-pattern-implementation) (answer with number five).
  
## [Factory Method](https://github.com/AliakseiFutryn/dotnet-design-patterns-samples/blob/master/Generating/FactoryMethod)
* This is a generating pattern, it defines an interface for creating objects, however leaves the decision of which class should be created to subclasses. In conclusion, factory method allow class to delegate an instantiation to subclasses. [wiki](https://en.wikipedia.org/wiki/Factory_method_pattern)
  * This pattern is recommended in the following cases:
    * The object's creation leads to a significant duplication of code.
    * The object's creation does not provide a sufficient level of abstraction.
    * The object's creation requires information not accessible to the composing object.

##  [Abstract Factory](https://github.com/AliakseiFutryn/dotnet-design-patterns-samples/blob/master/Generating/AbstractFactory)
* This is a generating pattern and it represents the strategy for creating a family of dependent or related objects. [wiki](https://en.wikipedia.org/wiki/Abstract_factory_pattern)
  * This pattern is recommended in the following cases:
    * You have to create many different objects and they inherited from the similar class or they have lots of similar properties.
    * You want to change behavior of your code by using different classes which implement a similar interface.
