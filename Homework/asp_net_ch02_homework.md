## Name: C#SBS Ch02 Homework

## Author: Derek Cobb

## Date: August 15, 2019

--------------------------------------------------------------------------------------

Read chapter 2, pages 1 - 31 in the Pro ASP.NET MVC 5 book.
Discussion Questions
Answer the discussion questions in writing for chapter 2.

--1. Describe what a controller does in the MVC design pattern.
(pg6/31)
Handles incoming requests (controllers are just C# classes

--2. What is the ASP.NET MVC convention in naming controllers? What does HomeController.cs do?
(pg6/31)
Controller classes contain a name followed by the word *Controller*. The *HomeController.cs* is the
default controller that is used in MVC applications.

--3. What is the name of the routing configuration file? Where is it located?
(pg8/31)
The ASP.NET routing system, located on the HomeController.


--4. What is Razor? How does Razor treat an expression beginning with the at symbol (@)?
(pg11)
A view engine, which processes the contents of views and generates HTML that is sent to the browser.
The @ symbol tells the Razor engine not to produce a layout

--5. How do View methods work?


--6. What is the purpose of MVC models?
(pg13)
The model is the representation of the real world objects, processes, and rules that define the subject, 
known as the domain, of the application. The model, often referred to as a domain model, contains the C# 
objects (known as domain objects) that make up the universe of the application and the
methods that manipulate them.

--7. What is a strongly typed view and why do we use strongly typed views?
(pg14)
A strongly typed view is intended to render a specific model type, and if I specify the type I want to work with (the
GuestResponse class in the PartyInvites.Models namespace in this case), MVC can create some helpful shortcuts to make it
easier.

--8. What is the purpose of setting a start page URL?


--9. Describe the differences between HTTP GET and HTTP POST.
(pg16)
HTTP GET request is what a browser issues normally each time someone
clicks a link. This version of the action will be responsible for displaying the initial blank form when someone first visits
HTTP POST requests: By default, forms rendered using Html.BeginForm() are submitted by
the browser as a POST request. This version of the action will be responsible for receiving submitted data and deciding
what to do with it.


--10. Describe the two approaches to validation in web applications.


--11. What is the role of Cascading Style Sheets (CSS) in web development?