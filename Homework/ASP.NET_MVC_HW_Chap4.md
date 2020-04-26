##### __ISTA322__ 
##### ASP.NET MVC_Ch. 4

## *Denis Licona*
###### *4 Mar 2020* 

1. Using *automatic properties* is a shortcut that avoids several explicit steps. List the steps that the use of automatic properties avoids.
- Assigns a value to or retrieve a value from a backing field without including any additional logic.(get, set).

2. Using the *object initializer* syntax is a shortcut that avoids several explicit steps. List the steps that the use of object initializers avoids.
- Object initializers let you assign values to any accessible fields or properties of an object at creation time without having to invoke a constructor followed by lines of assignment statements.

3. What is the purpose of creating *extension methods*?
- Extension methods enable you to add methods to existing types without creating a new derived type, recompiling, or otherwise modifying the original type.

4. What is the one feature of extension methods that will always allow you to identify a method as an extension method?
- The this keyword in front of the first parameter marks an extension method.

5. How do you create an extension method that filters the results returned by the method on a user specified criterion?
- By using an interface.

6. Explain the syntax of a *lambda expression*. The term "lambda expression" originates in the lambda calculus developed by the mathematician Alonzo Church in the 1930's. There is a class of programming languages that are based on the fundamental ideas of lambda calculus.
- The ‘=>’ is the lambda operator which is used in all lambda expressions. The Lambda expression is divided into two parts, the left side is the input and the right is the expression. The Lambda Expressions can be of two types: 1) __Expression Lambda__: Consists of the input and the expression. Syntax: input => expression; 2) __Statement Lambda__: Consists of the input and a set of statements to be executed. Syntax: input => { statements };

7. This will require some outside research. What is the distinction between an anonymously typed variable and a dynamically typed variable?
- Anonymous types provide a convenient way to encapsulate a set of read-only properties into a single object without having to explicitly define a type first. The type is a static type, but an object of type dynamic bypasses static type checking. Dynamic declarations are resolved at run-time, var declarations are resolved at compile-time.

8. You are having a discussion about C# with a friend of yours that uses another language. You are telling him about C#'s LINQ library. How would you describe to him the difference between LINQ's SQL-like notation and LINQ's dot notation?
- The SQL notation is similar to an SQL query (from, where, orderby, select, ect) and dot is using lambda syntax.

9. What, exactly, does the *await* keyword do?
- The await operator is applied to a task in an asynchronous method to insert a suspension point in the execution of the method until the awaited task completes.

10. What is the connection between await and the async keywords?
- Await can only be used in an asynchronous method modified by the async keyword. Such a method, defined by using the async modifier and usually containing one or more await expressions, is referred to as an async method.