## Name: C#SBS Ch14 Homework

## Author: Derek Cobb

## Date: August 13, 2019

--------------------------------------------------------------------------------------
Read chapter 14, pages 315 - 335 in the C# Step by Step book.
1.2 Discussion Questions
Answer the discussion questions in writing.

--1. What is the difference between a managed resource and an unmanaged resource?
(pgs 316-318/https://stackoverflow.com/questions/3607213/what-is-meant-by-managed-vs-unmanaged-resources-in-net)
A managed resource is data the garbage collector knows how to clean up and an unmanaged resource is data
the garbage collector won't know how to clean up. 
(Class) Common Language Runtime = virtual machine that runs the CIL

--2. When is memory for an object (reference type) allocated? When is the memory deallocated?
(pg316)
Memory is allocated for an object when the 'new' keyword is used to create a new instance of an object.
Memory is deallocated when the object is no longer needed/is no longer in use.
(Mr. Carter) Whenever the garbage collector runds


--3. What is a destructor?
(pg 317)
A destructor is a special method that the CLR calls after the reference to an object has disappeared, to reallocate
resources

--4. What is the difference in syntax between a constructor and a destructor?
(pg317) The syntax for writing a constructor does not have a return value
The syntax for writing a destructor is using a tilde (~)followed by the name of the class.


--5. Give some examples of scarce resources. Why would you want to manage scarce resources?
(pg 321)
Scarce resources such as memory, database connections, or file handles need to be managed because they contain valuable
space that needs to be released as soon as possible.


--6. What is exception-safe disposal?
(pg 322)
A less-than-ideal disposal method that is called within a finally block to ensure that a disposal method (like *Close*) is
called regardless of whether there is an exception
(Mr Carter) If your program blows up you want to make sure everything still shuts down properly

--7. How do you think that the using statement works for resource management? Give an informal, English
language, explanation of how it works.
(pgs 323-324)
It immediately disposes an object once used freeing resource management to mangaged other data.
(Class) Even if an exception is thrown, resources will still be freed up.

--8. What ill effects could result from attempting to dispose of a resource more than once?
(Me) Something you don't won't disposed of could be disposed or the program could crash,
(pg 331)
if you fail to dispose of an object, you run the risk of losing data (if you fail to close a
file correctly, for example, any data buffered in memory but not yet written to disk could be
lost)
(pg 330)
Waste of processing time
(pg 328)
However, you might also fi nd that this is the case in more substantial applications with classes that
consume scarce resources, and unless you take the necessary steps to provide a means of disposal, the
objects that your applications create might retain their resources until the application fi nishes. If the
resource is a fi le, this could prevent other users from being able to access that fi le; if the resource is a
database connection, your application could prevent other users from being able to connect to the
same database. Ideally, you want to free resources as soon as you have finished using them rather than
wait for the application to terminate.
(Mr. Carter) You don't know. Usually nothing.

--9. We will look at threads later in the term. For now, what is your understanding of how threads interact
with resource management? A good guess is a sufficient answer to this question.
The thread guides the garbage disposal.
(Mr. Carter) A second process all accessing the same resource; thread of execution, 

--10. Why does the book recommend not attempting to force the garbage collector? Are their any exceptions
to this recommendation?
There is a chance you will lose data you do not want to lose if forced.
(Mr. Carter) This is something you do not have to worry about. Unless you lose a lot of memory on the heap, which
is highly unlikely.