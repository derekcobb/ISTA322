## Name: C#SBS Ch15 Homework

## Author: Derek Cobb

## Date: August 19, 2019

--------------------------------------------------------------------------------------

Read chapter 15, pages 350 - 367 in the C# Step by Step book.
1.2 Discussion Questions
Answer the discussion questions in writing.
1. What is the difference between a property and a field?
Fields are private and properties are public.

2. What is the difference between a property and a method?

Properties are a useful way of expressing a feature of an object, allowing get/set in a common way that can be used by APIs like data building
Methods are better for expressing things that either change the state or which have an expectation of taking some time and not necessarily being reproducible.
Properties are like this : int delta { ....} which has implementation but does not take any properties
Methods are like this: int beta (Charlie) {......} which has paramters and implementation

3. What is your understanding of encapsulation?
An object's ability to hide data and behavior that are not necessary to its user.
A property is an encapsulated variable. A field is just a plain variable.

4. Some languages are case insensitive, that is, an `a" and an \A" are considered to be the same letter.
C# is case sensitive. What implications does this have regarding the naming of variables, methods,
and other identifers? Do you think that the difference in case in the initial character of two different
identifers is sufficient to distinguish them>
Makes debugging by others hard. Mistakes can be made with just distinguishing by capitalization of the first letter.

Capitalization is not enough to distinguish variables.

5. Give an example that is not in the book of an instance where you might want to use a read-only
property. Give an example not in the book of an instance where you might want to use s write-only
property.
Use a read-only property for serial number for example.
Use write-only property for password.

6. Can you think of a reason why you might ever want to make getters and setters private? Give an
example. Also, make a case why getters and setters should never be private.
To prevent future public acces.
You could just use a private field.

7. What are restrictions on the use of properties?

-- A property cannot be passed via ref or out parameter to a method
-- You cannot overload a property
-- A property should not alter the state of the underlying variable when the get accessor is called

8. What is an object initializer? What is the syntax for an object initializer?
The object initializer is the easiest and fastest way to assign values of an object's properties and fields.
When you create an object and initialize the values from the properties as parameters
Syntax of object initialization: string sentence = new {"This is a sentence."};