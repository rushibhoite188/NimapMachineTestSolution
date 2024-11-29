## Project Title
Nimap Machine Test: Product and Category Management


## Task Overview -
-This project implements a CRUD (Create, Read, Update, Delete) functionality for Product and Category management using ASP.NET MVC and Entity Framework Code-First 
 approach. It includes server-side pagination for displaying the Product list efficiently.
 
---

## Requirements
1. Category Master:
   - Implement CRUD operations for Categories.
   
2. Product Master:
   - Implement CRUD operations for Products.
   - Products are linked to Categories.

3. Product List Display:
   - Display a paginated list of Products with the following columns:
     - ProductId
     - ProductName
     - CategoryId
     - CategoryName

4. Use Code first Approach:
   - Use Entity Framework Code-First Approach.
   - We can Avoid using scaffolding for the implementation.

---

## Technologies Used
- Language: C#
- Framework: ASP.NET MVC 5
- ORM: Entity Framework Code-First Approach ( using Migration cammands in Package  Manager Console Automatically Create Database and Tables )
- Frontend: HTML, CSS, Bootstrap (for Attractive UI)
- Tools: Visual Studio .

---

3. Server-Side Pagination:
   - Products are displayed with efficient server-side pagination for better performance.

---
## Project Setup Instructions
- Clone the Repository: https://github.com/rushibhoite188/NimapMachineTestSolution
- Open in Visual Studio:
- Open the .sln file in Visual Studio.

## Database Setup:

- Update the connection string in the Web.config file.
- Use the following commands in the Package Manager Console:
{
- Enable-Migrations
- Add-Migration InitialCreate
- Update-Database
}

## Run the Application:

- Build the project.
- Press F5 or run the project to start the web application.
- Use the navigation menu to access Products and Categories.


## Here Above All Information About My Task. ##
 Thank you.

 
