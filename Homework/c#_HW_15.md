##### __ISTA322__ 
##### _C#_HW15__

## *Denis Licona*
###### *1 Mar 2020* 

1. What is the difference between a *property* and a *field*?
- a field is a variable of any type that is declared directly in the class while property is a member that provides a flexible mechanism to read, write or compute the value of a private field. In other words, properties expose fields. Properties provide a level of abstraction allowing you to change the fields while not affecting the external way they are accessed by the things that use your class.

2. What is the difference between a *property* and a *method*?
- Properties are basically information that an object has. Methods are what an object can do. Properties are a useful way of expressing a feature of an object, allowing get/set in a common way that can be used by APIs like data-binding, reflection and serialization. Methods are better for expressing things that either change the state, or which have an expectation of taking some time and not necessarily being reproducible.

3. What is your understanding of *encapsulation*?
- Encapsulation refers to an object's ability to hide data and behavior that are not necessary to its user. Encapsulation enables a group of properties, methods and other members to be considered a single unit or object. The benefits of encapsulation are: - Protection of data from accidental corruption; - Specification of the accessibility of each of the members of a class to the code outside the class; -Flexibility and extensibility of the code and reduction in complexity; - Lower coupling between objects and hence improvement in code maintainability Encapsulation is used to hide the values or state of a structured data object inside a class, preventing unauthorized parties' direct access to them.

4. Some languages are case insensitive, that is, an "a" and an "A" are considered to be the same letter. C# is case sensitive. What implications does this have regarding the naming of variables, methods, and other identifiers? Do you think that the difference in case in the initial character of two different identifiers is sufficient to distinguish them?
- No, it would allow for a simple capitalization mistake to cause an error in the programming and would be difficult to identify the error.

5. Give an example that is not in the book of an instance where you might want to use a read-only property. Give an example not in the book of an instance where you might want to use a write-only property.
- The value of a constant like PI. A password for an application.

6. Can you think of a reason why you might ever want to make getters and setters private? Give an example. Also, make a case why getters and setters should never be private.
- private getter for a password, private setter for a constant value. A good case for keeping accessors public would be to allow the ability to change private data members within a encapsulated program.

7. What are restrictions on the use of properties?
- You can assign a value through a property of a structure or class only after the structure or class has been initialized.
- You can’t use a property as a *ref* or an *out* argument to a method (although you can use a writable field as a ref or an out argument).
- A property can contain at most one *get* accessor and one *set* accessor. A property cannot contain other methods, fields, or properties.
- The *get* and *set* accessors cannot take any parameters. The data being assigned is passed to the set accessor automatically by using the value variable.
- You can’t declare properties by using *const*.

8. What is an *object initializer*? What is the syntax for an *object initializer*?
- Object initializers let you assign values to any accessible fields or properties of an object at creation time without having to invoke a constructor followed by lines of assignment statements.
-Example:
- public class Author
- {
    public string name { get; set;}} 
- Author Denis = new Author() 
    { name = "Denis Licona"} *Object initializer*