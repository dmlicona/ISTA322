##### __ISTA322__ 
##### ASP.NET MVC_Ch. 2

## *Denis Licona*
###### *26 Feb 2020* 

1. Describe what a *controller* does in the MVC design pattern.
- It handles any incoming URL request and controls the information. It is the link between a user and the system. It provides the user with input by arranging for relevant views to present themselves in appropriate places on the screen.

2. What is the ASP.NET MVC convention in naming controllers? What does *HomeController.cs* do?
- In ASP.NET MVC, every controller class name must end with a word "Controller".
- HomeController.cs is the default controller for home page. 

3. What is the name of the routing configuration file? Where is it located?
- It is the Route.Config.cs file located in the App_Start Folder.

4. What is *Razor*? How does Razor treat an expression beginning with the at symbol (@)?
- Razor is a markup syntax that lets you embed server-based code into web pages using C# and VB.Net. It is not a programming language. It is a server side markup language. It processes the contents of views and generates HTML that is sent to the browser. With Razor syntax you can begin a bit of C# code by using the ‘@’ sign and the Razor parse will automatically switch into parsing this statement, this foreach statement, as a bit of C# code.

5. How do *View methods* work?
- The *view* handles the app's data presentation and user interaction. A view is an HTML template with embedded Razor markup. Razor markup is code that interacts with HTML markup to produce a webpage that's sent to the client.

6. What is the purpose of MVC *models*?
- The MVC Model contains all application logic (business logic, validation logic, and data access logic), except pure view and controller logic. With MVC, models both hold and manipulate application data.

7. What is a *strongly typed view* and why do we use strongly typed views?

- Strongly typed views are used for rendering specific types of model objects, instead of using the general ViewData structure. 

8. What is the purpose of setting a start page URL?
- To represent the startup page that will load automatically every time you open the URL. Your "Homepage". 

9. Describe the differences between *HTTP GET* and *HTTP POST*.
- GET: is what the browser issues normally each time someone clicks a link
- POST: receives the submitted data and decides what to do with it

10. Describe the two approaches to *validation* in web applications.
- User's input can be validated on the server and on the client (web browser). Thus we have server-side and client-side validation. 
- In the _server-side validation_, information is being sent to the server and validated using one of server-side languages. If the validation fails, the response is then sent back to the client, page that contains the web form is refreshed and a feedback is shown. This method is secure because it will work even if JavaScript is turned off in the browser and it can’t be easily bypassed by malicious users. On the other hand, users will have to fill in the information without getting a response until they submit the form. This results in a slow response from the server.
-For better user experience, however, you might consider using _client-side validation_. This type of validation is done on the client using script languages such as JavaScript. By using script languages user’s input can be validated as they type. This means a more responsive, visually rich validation.

11. What is the role of *Cascading Style Sheets* (CSS) in web development?
- CSS is the artist that adds styling like font size, colors, positioning. It describes the presentation of web pages. 