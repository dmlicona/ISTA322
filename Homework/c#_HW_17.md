##### __ISTA322__ 
##### _C#_HW17__

## *Denis Licona*
###### *8 Mar 2020* 

1. What is a type parameter?
A type parameter, also known as a type variable, is an identifier that specifies a generic type name. Generic is a class which allows the user to define classes and methods with the placeholder.

2. What does a type parameter do?
- The type parameters can be used to declare the return type and act as placeholders for the types of the arguments passed to the generic method, which are known as actual type arguments. 

3. How many type parameters can a generic class have?
- A generic class can have multiple type parameters.

4. What is the difference between a generic class and a generalized class?
- a generic class defines a template that is then used by the compiler to generate new type-specific classes on demand and a generalized class takes parameters that can be cast to different types.

5. What is a constraint? How do you specify a constraint?
- By using a constraint, you can limit the type parameters of a generic class to those that implement a particular set of interfaces and therefore provide the methods defined by those interfaces. Constraints inform the compiler about the capabilities a type argument must have. Without any constraints, the type argument could be any type. Constraints are specified by using the *where* contextual keyword.

6. What is a generic method? How do you define a generic method?
- With a generic method, you can specify the types of the parameters and the return type by using a type parameter like that used when you define a generic class. You define generic methods by using the same type parameter syntax you use when you create generic classes.
GenericList<float> list1 = new GenericList<float>();
GenericList<ExampleClass> list2 = new GenericList<ExampleClass>();
GenericList<ExampleStruct> list3 = new GenericList<ExampleStruct>();

7. What do we mean when we say that a generic type interface is invariant?
- The IWrapper interface is said to be invariant. You cannot assign an IWrapper object to a reference of type IWrapper, even if type A is derived from type B. By default, C# implements this restriction to ensure the type safety of your code. Means that you can use only the type originally specified; so an invariant generic type parameter is neither covariant nor contravariant.

8. What do we mean when we say that a generic type interface is covariant?
- You can assign a derived object to a base reference as long as there is a valid conversion from type A to type B, or type A derives from type B. Enables you to use a more derived type than originally specified.

9. Does covariance work with value types? Does it work with reference types?
- Covariance works only with reference types. This is because value types cannot form inheritance hierarchies.

10. What do we mean when we say that a generic type interface is contravariant?
- Enables you to use a more generic (less derived) type than originally specified. Contravariance follows a similar principle to covariance except that it works in the opposite direction; it enables you to use a generic interface to reference an object of type B through a reference to type A as long as type B derives from type A.