Author: Adam Campeau --0085438
Purpose: Creation of ASP.net Core MVC Application
Project Title: The Cookie Jar Store
Latest revision: 10/14/2021

Research: -Look into company; "The Cookie Jar Store".
	  -Assess company history, background, location, and product line.
	  -Begin high-level design of cataloging application to be written 
	   in Microsoft's ASP.net Core MVC using VS 2019.


v1.0 Development process overview:

1. Add a model

Classes are added for managing cookie jars in a database. 
The app's model classes use Entity Framework Core (EF Core) to work with the database. 
EF Core is an object-relational mapper (O/RM) that simplifies data access. 
You write the model classes first, and EF Core creates the database.
The model classes are known as POCO classes (from "Plain-Old CLR Objects") because they don't have a dependency on EF Core. 
They define the properties of the data that are stored in the database.

-Add a folder named Models.

-Add a class to the Models folder named CookieJars.cs

-Add NuGet packages and EF tools

-Add a database context class

-Add a database connection string

-Register the database context

-Scaffold the jars model

-Create the initial database schema

 (Issue encountered: database context conflict 

	-error- 

	"More than one DbContext was found. Specify which one to use. 
	Use the '-Context' parameter for PowerShell commands and the '--context' parameter for dotnet commands."

	-Investigation required. Cannot properly instantiate database.

	Follow-up: DB creation commands adjusted to accommmodate context added to support user account authorization
			-Cookie Jars database successfully created 
	)

2. Scaffold Razor Pages

-Update site _Layout.cshtml

3. Seed the database

-Create SeedData class
-Create db connection string
-Add the seed initializer

4. Update the pages

-Update .cshtml generated code
-Enhance page styling
-Add route template

5. Add new field

-Create new database field - Rating (1-5 Poor:Excellent)
-Rating to be used to capture overall feedback from customers on products

6. Add validation

-Add validation rules to the book model
-Add DataType Attributes
-Apply database migrations
