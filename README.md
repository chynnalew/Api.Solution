<div align="center">

[![Language][language-shield]][language-url]
[![Language][languageH-shield]][languageH-url]
[![Language][languageC-shield]][languageC-url]
[![MIT License][license-shield]][license-url]

# BookAPI

</div>

#### an ASP.NET Core Book API

#### Created By: Chynna Lew and Paige Tiedeman

## Technologies Used

* C#
* .NET 5
* NuGet
* ASP.NET Core
* Entity Framework Core
* MySql
* MySql Workbench
* PostMan
* Swagger

## Description

This application is a template for ASP.NET Core API creation with swagger

## Setup and Usage Instructions

### Technology Requirements

* Download and install [.NET 5](https://dotnet.microsoft.com/download/dotnet/5.0)
* Download and install a code text editor. Ex: [VS Code](https://code.visualstudio.com/)
* Download, install, and complete setup for [MySql Community Server](https://dev.mysql.com/downloads/file/?id=484914) and [MySql Workbench](https://dev.mysql.com/downloads/file/?id=484391).

### Installation

* Clone [this](https://github.com/chynnalew/API.Solution) repository, or download and open the Zip on your local machine
* Open the BookAPI.Solution folder in your preferred text editor
* To install required packages, navigate to API.Solution/BookAPI in the terminal and type the following commands:
  - dotnet add package Microsoft.EntityFrameworkCore -v 5.0.0
  - dotnet add package Pomelo.EntityFrameworkCore.MySql -v 5.0.0-alpha.2
  - dotnet add package Microsoft.EntityFrameworkCore.Proxies -v 5.0.0
  - dotnet tool install --global dotnet-ef --version 3.0.0
* Create a file named "appsettings.json" in the BookAPI directory
  - add the following code to the appsettings.json file:
```
{
  "Logging": {
    "LogLevel": {
      "Default": "Warning",
      "System": "Information",
      "Microsoft": "Information"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=book_api;uid=root;pwd=[YOUR-PASSWORD-HERE];"
  }
}
```
  - replace [YOUR-PASSWORD-HERE] with your unique MySql password
* Launch the MySql server:
  - In the terminal, run the command `$ mySql -uroot -p[YOUR-PASSWORD-HERE]`, replacing [YOUR-PASSWORD-HERE] with your unique MySql password
* To Import the required BookAPI database:
  - In the terminal, navigate to API.Solution/BookAPI and run the command:
    - dotnet ef database update
* To Make Changes to the API Database:
  - If you would like to change the database, make changes in the proper models files, then run the following commands in the terminal navigated to API.Solution/BookAPI:
    - `dotnet ef migrations add YourDescriptionHere`
    - `dotnet ef database update`
* To Restore, build, and launch the API project:
  - Navigate to the API.Solution/BookAPI folder in the command line or terminal
    - Run the command `$ dotnet restore` to restore the project dependencies
    - Run the command `$ dotnet build` to build and compile the project
    - Run the command `$ dotnet run` to build and compile the project
    - The ASP.NET Core MVC is viewable in the browser at http://localhost:5000 
    - Open postman 
    - If the styling is not appearing in the browser, open http://localhost:5000 in an incognito browser

## Review API Endpoints

Base URL: `http://localhost:5000`

#### HTTP Requests
```
GET /api/BooksAPIs
POST /api/BooksAPIs
GET /api/BooksAPIs/{id}
PUT /api/BooksAPIs/{id}
DELETE /api/BooksAPIs/{id}
```
#### Path Parameters
| Parameter | Type | Description |  
| :---: | :---: | --- |
| Title | string | Returns anybooks by title |  
| Author | string | Returns any books by author name |  
| Genre | string | Returns any books by genre name |  
| Rating | int | Returns any books with that number rating |     

#### Example Query
```
http://localhost:5000/api/BookAPIs?title=Harry%20Potter
```

#### Sample JSON
```
    {
      "bookId": 0,
      "title": "Harry Potter",
      "author": "J. K. Rowling",
      "genre": "Fantasy",
      "rating": 8,
      "read": true
    }
```

#### Swagger Instructions
This API uses [Swagger](https://swagger.io/tools/swagger-ui/) REST API Documentation
- Navigate to the following url to access Swagger:
  - NOTE: the program must be running to access Swagger
```
http://localhost:5000/index.html
```
The "BookAPIs" tab contains example GET, POST, PUT, and DELETE queries
- To Test a query, find the tab for the query type and click the "Try It Out" button located in the top right corner of the card
  - This will allow inputs in the tab's form fields
  - Enter your query in the form field(s) and click the "Execute" button to view the server responses

## Known Bugs

* none at this time

### License

[MIT License](https://opensource.org/licenses/MIT)
Copyright 2021 Chynna Lew, Paige Tiedeman

## Support and contact details

* [Chynna Lew](github.com/chynnalew) <ChynnaLew@yahoo.com>
* [Paige Tiedeman](github.com/paigetiedeman)  


[license-shield]: https://img.shields.io/badge/License-MIT-blue
[license-url]: https://opensource.org/licenses/MIT
[language-shield]: https://img.shields.io/badge/Language-C%23-green
[language-url]: https://docs.microsoft.com/en-us/dotnet/csharp/
[LanguageH-shield]: https://img.shields.io/badge/Language-HTML-red
[LanguageH-url]: https://developer.mozilla.org/en-US/docs/Web/HTML
[LanguageC-shield]: https://img.shields.io/badge/Language-CSS-blueviolet
[LanguageC-url]: https://developer.mozilla.org/en-US/docs/Web/CSS