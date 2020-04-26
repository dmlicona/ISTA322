##### __ISTA322__ 
##### ASP.NET MVC_Ch. 5

## *Denis Licona*
###### *10 Mar 2020* 

1. What is a *view engine*?
- View Engine is responsible for rendering the view into html form to the browser. 

2. What is *Razor*?
- Razor is the view engine responsible for incorporating data into HTML documents.

3. What do *views* do? List two specific things in your answer to this question.
- A view is responsible for the UI (user interface).
- The view displays the data coming from the model.
- A view is an HTML template which will be binding and displaying HTML controls with data.

4. How does Razor respond when it encounters statements that begin with the at character (@)? Be specific.
- You add code to a page using the @ character. The @ character starts inline expressions, single statement blocks, and multi-statement blocks. 

5. How does Razor respond when it encounters statements that begin with the at character followed by the colon (@:)? Be specific.
- The @: outputs a single line of content containing plain text or unmatched HTML tags.

6. Describe how you implement a standard formatting for all pages in an ASP.NET application.
- The RenderPage, RenderBody, and RenderSection methods tell ASP.NET where to insert page elements.

7. What is the difference in using Razor to interpolate data values as stand-alone HTML elements and as attributes to HTML elements. What is the similarity?
- Data attributes, which are attributes whose names are prefixed by data.

8. What is a *view start file* and where is it located?
- Search Results
Featured snippet from the web
- Viewstart.cshtml is used to place common UI logic across the Views in the folder, where it is located. This means, the views in a single folder which is having  Viewstart.cshtml will be rendered along with it. It execute the code inside this file before executing the code inside an individual view.,_ViewStart.cshtml.

9. What is a Razor *code block*? What is the syntax of a Razor code block?
- Code block is used to enclose C# code statements. It starts with @ (at) character and is enclosed by {} (curly braces). Unlike expressions, C# code inside code blocks is not rendered. The default language in a code block is C#, but we can transit back to HTML. HTML within a code block will be rendered as HTML.

10. Describe the different roles of action methods and views.
- Action methods output data to the view. Views display HTML.  

11. Describe the use of the *@using* statement. Give an example of how you would use it.
- It specifies the namespaces that should be searched for classes used in razor views. @model, applies scope to the view.