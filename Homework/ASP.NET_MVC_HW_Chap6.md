##### __ISTA322__ 
##### ASP.NET MVC_Ch. 6

## *Denis Licona*
###### *10 Mar 2020* 

1. What is the primary idea that underlies *Dependency Injection*?
- It allows the creation of dependent objects outside of a class and provides those objects to a class through different ways, aka loose coupling. Loose Coupling means reducing dependencies of a class that use a different class directly. Dependency Injection (DI, wikipedia) is a design pattern that reduces hard-coded dependencies between your classes by injecting these dependencies at run-time, instead of during design-time. Technically, Dependency Injection is a mechanism that allows the implementation of another, more high-level, design pattern called Inversion of Control (IoC, wikipedia). The purpose of both patterns is to reduce hard-coded dependencies (or ‘coupling’) between your classes.

2. Describe the role of *interfaces* in implementing a dependency injection container.
- Allows the constructor to access the application’s repository through the interface without having any need to know which implementation class has been configured. (pg 204)

3. List the three stages of building basic Ninject functionality, and briefly define each stage.
- First stage: Prepare Ninject for use by creating an instance of a Ninject kernel, which is the object that is responsible for resolving dependencies and creating new objects. When creating an object, you use the kernel instead of the NEW keyword.
- Second stage: Configure the Ninject kernel so that it understands which implementation objects are to be used for each interface. 
- Third stage: Use Ninject to create and object, which is done through the kernel Get method. 

4. What is the purpose of a *custom dependency resolver*?
- This can be done by implementing the IDependencyResolver interface and registering an instance of the interface on application startup.

5. What is the purpose of *conditional binding*? Describe how it works.
- Data-binding expressions are contained within <%# and %> delimiters and use the Eval and Bind functions. you can call any publicly scoped code within the <%# and %> delimiters to execute that code and return a value during page processing.

6. Why is setting the *object scope* important when using dependency injection?
- To ensure decoupling is accomplished.

7. Briefly describe the *Test Driven Development* approach in developing an application.
- the core idea is that you write the tests for a feature before implementing the feature itself. Writing the tests first makes you think more carefully about the specification you are implementing and how you will know that a feature has been implemented correctly. Rather than diving into the implementation detail, TDD makes you consider what the measures of success or failure will be in advance.

8. Consider the Assert class. How do you access the methods of that class?
- Within the method body, methods defined by the Assert class are used to compare the expected result of a test with what actually happened.

9. Why is it useful to *mock objects* when developing software?
- Mocking is a process used in unit testing when the unit being tested has external dependencies. The purpose of mocking is to isolate and focus on the code being tested and not on the behavior or state of external dependencies.

10. Briefly describe the two main issues that arise when attempting to do Unit Tests without the aid of some sort of mocking library.
- It leads to creating implementation classes for every kind of test you want to run.