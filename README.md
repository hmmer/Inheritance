#### Understanding Inheritance and its concepts Interface and Abstraction

### Inheritance
```
Inheritance is a feature of object-oriented programming language 
which simply allows for the creation of a new class from an existing class 
by inheriting its attributes and behaviors while having the ability to have its own.
```

### Abstraction
```
In abstract class, abstract behaviors and attributes SHOULD BE inherited 
by child classes to give the definition.
An abstract class can have regular and virtual behaviors.
An abstract class cannot be initiated, it can only be inherited.
```

### Interface
```
The interface is similar to an abstract class but the difference is
it CAN NOT have any pre-written behaviors and attributes
it can only have empty signatures which NEED to be defined by child classes.
```

## Other Information

•	The interface is cheaper to use as far as the CPU is concerned.

•	An abstract class can have abstract, virtual, and regular behaviors. 

•	Abstract behaviors aren't defined in the abstract class (only signature), they must be defined in the child classes.

•	Virtual behaviors can be defined in the abstract class they MAY override the definition in the child classes.

•	Override keyword is used to write the definition of the abstract and virtual behaviors in the child classes.

•	If all the behaviors and properties are abstract in a class then it is better to use interface instead of abstract class.
