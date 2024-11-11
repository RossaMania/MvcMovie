# MvcMovie - ASP.NET Core MVC Tutorial Project

This project is part of the **ASP.NET Core MVC** tutorial on Microsoft Learn. It showcases web development using ASP.NET Core with MVC (Model-View-Controller) architecture.

## Project Overview

The MvcMovie app is a simple web application that allows users to manage and display movie data. Throughout the development process, the following key skills were applied:

- Creating a web application with ASP.NET Core MVC.
- Scaffolding a model and integrating with a database.
- Implementing search functionality and data validation.

## Key Features

- **Movie Management**: Add, edit, and delete movie records.
- **Search**: Filter movies by name, genre, and release date.
- **Validation**: Form validation for user input on movie entries.
  
This project serves as a practical implementation of ASP.NET Core MVC web development, using controllers and views for UI rendering.

## Prerequisites

To run this project locally, ensure you have the following installed:

- [Visual Studio 2022](https://visualstudio.microsoft.com/) with the **ASP.NET and web development** workload.
- [.NET 8.0 (LTS)](https://dotnet.microsoft.com/en-us/download/dotnet/8.0).

## How to Run Locally

1. Clone the repository:
   ```
   git clone https://github.com/RossaMania/MvcMovie.git

2. Open the project in Visual Studio.

3. Build the project by selecting Build > Build Solution or pressing Ctrl+Shift+B.

4. Run the app without debugging by pressing Ctrl+F5 or via the Debug menu.

5. Access the app in your browser at https://localhost:<port_number>.

## Deployment
This project has been deployed using GitHub, and you can access the latest version from the repository.

### Setting Up the PostgreSQL Database

This project uses a PostgreSQL database running in a Docker container. To start the container, run the following command (replacing `{your_password_here}` with your own secure password):

```bash
docker run -d --rm -e POSTGRES_PASSWORD={your_password_here} -v ./data:/var/lib/postgresql/data -p 5433:5432 --name movies_db postgres:15-alpine
```

### Notes
- Ensure Docker is installed and running on your machine.
- The above command maps your database to port 5433 on localhost. Port 5433 on your localhost is mapped to the container’s port 5432.
- Important: For security, do not include your actual password in this file or in any code you commit to version control.

### Setting Up Your Connection String

After starting the PostgreSQL container, add your connection string to the application’s configuration. If you’re developing locally, use .NET User Secrets to securely store your connection string:

```bash
dotnet user-secrets set "ConnectionStrings:MvcMovieContext" "Host=localhost;Port=5433;Database=movies_db;Username=postgres;Password={your_password_here}"
```

## Contributing
Feel free to fork the repository, open issues, or submit pull requests for any improvements or additional features!

## License
This project is part of the Microsoft Learn tutorials and is licensed under the MIT License.
