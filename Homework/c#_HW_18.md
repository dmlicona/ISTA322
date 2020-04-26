##### __ISTA322__ 
##### _C#_HW18__

## *Denis Licona*
###### *9 Mar 2020* 

1. You are building a help ticket system. You want to ensure that the older the ticket, the sooner it will be handled by the team. For example, a ticket submitted a week ago has a higher priority than a ticked just submitted. What kind of data structure would you use, and why?
- A Queue collection class, which is a a first-in, first-out data structure, with methods to add an item to one end of the queue, remove an item from the other end, and examine an item without removing it.

2. You are building a tracking system for seasonal agricultural farm labor. The labor requirements vary widely, depending on the season. Your requirement is that the newest hires are terminatedfirst, and that our more experienced hires are kept longer. What kind of data structure would you use, and why?
- A Stack collection class, where first-in, last-out data structure with methods to push an item onto the top of the stack, pop an item from the top of the stack and examine the item at the top of the stack without removing it.

3. You are building a transaction database. Your requirement is that the database adds data very quickly, and that deletions, updates, and searches happen infrequently. In other words, data is typically added in the order in which the transaction occurs. What kind of data structure would you use, and why?
- A List collection, because new items are added to the end containing a list of objects that can be accessed by index, as with an array, but with additional
methods with which to search the list and sort the contents of the list.

4. You are building an analytical database. Your requirement is that the database handle queries very quickly, but that the data never changes, i.e., there are no inserts, deletions, or updates. What kind of data structure would you use, and why?
- SortedList, they are always sorted based on the value of the keys using the bisection algorithm.

5. You are building a personnel directory, where searches are performed by last name, first name, middle name. What kind of data structure would you use, and why?
- Dictionary which is a collection of values that can be identified and retrieved by using keys rather than indexes and allows data to be saved as key value pairs.

6. You are building a username/password database. Your requirement is that updates happen frequently (when users change their passwords) and that searches (to authenticate users) happen extremely quickly. What kind of data structure would you use, and why?
- Dictionary which is a collection of values that can be identified and retrieved by using keys rather than indexes and allows data to be saved as key value pairs.

7. What is a *lambda expression?* Give an example. Why would we use a lambda expression?
- A lambda expression is an expression that returns a method. 
- Person match = personnel.Find((Person p) => { return p.ID == 3; }); Lambda expressions do not define a method name, and the return type (if any) is inferred from the context in which the lambda expression is used.

8. What is the difference between lambda expressions and anonymous methods? What are the advantages of each?
- Anonymous method, you must prefix it with the delegate keyword. Lambda expressions do not define a method name, and the return type (if any) is inferred from the context in which the lambda expression is used.