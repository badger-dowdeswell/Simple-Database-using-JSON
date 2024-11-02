# Simple Database for Visual Studio C# projects using JSON

Otago Polytechnic Auckland International Campus Studio 2 projects often need a simple database to persist data such as customer and product information.

This project demonstrates how to build a custom class to manage each database table in a way similiar to how an SQL client might manage a database. However, the tables are
stored as separate Java Script Object Notation (JSON) format text files.  

JSON is an open standard file format that uses human-readable text to store information as data objects consisting of attribute–value pairs and arrays. You can read more about the JSON standard on Wikipedia: https://en.wikipedia.org/wiki/JSON

## Installing the JSON Serializer components into Visual Studio
The application reads and writes JSON-form files using an Visual Studio package that is not installed automatically.

- Open your Simple_Database project in Visual Studio.
- Use the menu to access Tools > NuGet Package Manager > Package Manager Console to open the Package Manager Console window.
