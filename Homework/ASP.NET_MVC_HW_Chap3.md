##### __ISTA322__ 
##### ASP.NET MVC_Ch. 3

## *Denis Licona*
###### *3 Mar 2020* 

1. The book states, “Interactions with an MVC application follow a natural cycle of user actions and view
updates, where the view is assumed to be stateless.” What does it mean for the view to be *stateless*?
- Stateless means that it does not keep any memory of the past. Every transaction is performed as if it were being done for the very first time. The server-side controls are what makes them different in as far as being stateful and stateless.

2. The book identifies two kinds of *models*. Briefly describe each of them.
- View, data from controller to view. Domain, data on the business side.

3. Give an example of *separation of concerns* from your own life experience. This should be a simple, everyday example.
- Medical records is the model, audiology renders some part, or view, of my medical records, and my primary care provided controls incoming request, operations and selected views for me. 

4. What is a *view engine*?
- The view engine is responsible for creating HTML from your views.

5. The book notes that the three-tier structure, or *n-tier* model, is “the most widely used pattern for business applications.” Why do you think that this is true? An answer like, “Because it works well,” is not a sufficient answer to this question.
- In a model view the database and the model are collocated, creating overheard when processing requests from the (UI). On the other hand, in the three-tier pattern, all three elements provide a comprehensive program that receives, stores and displays data, making it easier to troubleshoot, test, and improve without negatively impacting business operations. 

6. This question requires some outside research. When we study UWP, you will see that the UWP design pattern is the *Model-View-ViewModel* (MVVM). What is the difference between MVC and MVVM that makes the first good for ASP.NET MVC and the second good for UWP?
- Model-View-ViewModel (MVVM) is a UI architectural design pattern for decoupling UI and non-UI code. With MVVM, you define your UI declaratively in XAML and use data binding markup to link it to other layers containing data and commands. MVC is an architectural pattern commonly used for developing user interfaces that divides an application into three interconnected parts Model, View and Controller.

7. Describe the two parts of the *dependency injection* (DI) design pattern.
- Dependency injection is a technique whereby one object supplies the dependencies of another object. Service and client. A "dependency" is an object that can be used, for example as a service. Instead of a client specifying which service it will use, something tells the client what service to use.

8. Give an example of *loose coupling* from your own life experience. This should be a simple, everyday example.
- Loose coupling refers to the ability for parts to change independently without affecting one another. Life example would be changing my shirt. 

9. What are the two types of testing discussed in the book?
- Integration and functional testing. Integration testing means checking if different modules are working fine when combined together as a group. Functional testing means testing a slice of functionality in the system (may interact with dependencies) to confirm that the code is doing the right things

10. What are the seven steps of the *test driven development* (TDD) workflow, as stated in the book?
* 1)Write a test
- 2)Run all tests and see if the new test fails
- 3)Write the code to pass test
- 4)Run test and confirm the test passes
- 5)Refactor code
- 6)Repeat all steps