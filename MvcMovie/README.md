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
- [Docker Desktop](https://www.docker.com/products/docker-desktop/) (for running the PostgreSQL database in a container).


## How to Run Locally

1. Clone the repository:
   ```
   git clone https://github.com/RossaMania/MvcMovie.git

2. Open the project in Visual Studio.

3. Set up environment variables by creating a .env file in the root directory:

```
ASPNETCORE_ENVIRONMENT=Development
MVCMOVIE_CONNECTIONSTRING=Host=movies_db;Port=5432;Database=postgres;Username=postgres;Password=your_database_password_here
```

4. Ensure that .env is included in .gitignore to prevent it from being accidentally committed.

5. Build the project by selecting Build > Build Solution or pressing Ctrl+Shift+B.

6. Run the app without debugging by pressing Ctrl+F5 or via the Debug menu.

7. Access the app in your browser at https://localhost:<port_number>.

## Running with Docker

This project uses Docker to run the PostgreSQL database, making it easier to set up the environment and keep sensitive data secure.

1. Ensure Docker Desktop is installed and running.

2. Start the services using docker-compose:

```
docker-compose up -d --build
```

This will:

- Start the PostgreSQL database service in a Docker container.
- Start the ASP.NET Core app in a separate container, using the environment variables from your .env file.

3. Access the app on http://localhost:8081.


## Docker Compose Configuration

The docker-compose.yml file defines two services:

- mvcmovie: The ASP.NET Core MVC application.
- movies_db: The PostgreSQL database service.

## Environment Variables

The project uses the .env file to securely store and manage environment variables:

- ASPNETCORE_ENVIRONMENT: Defines the app environment (e.g., Development or Production).
- MVCMOVIE_CONNECTIONSTRING: Connection string for the PostgreSQL database.

## Database Connection String

After starting the PostgreSQL container, the app can use the connection string stored in appsettings.json or configured through environment variables for added security. In local development, you can also manage secrets with .NET User Secrets if you prefer.

## Using .NET User Secrets (Alternative to .env)

To store your connection string securely for local development, use .NET User Secrets:

```
dotnet user-secrets init
dotnet user-secrets set "ConnectionStrings:MvcMovieContext" "Host=localhost;Port=5433;Database=movies_db;Username=postgres;Password=your_database_password_here"
```

## Deployment

This project is set up to work with Docker and GitHub for deployment. To deploy securely:

- Use the .env file for sensitive information (e.g., database passwords) and exclude it from version control.
- Ensure your Docker and GitHub setups are configured to respect environment variables for production.

## Contributing

Feel free to fork the repository, open issues, or submit pull requests for any improvements or additional features!

## License

This project is part of the Microsoft Learn tutorials and is licensed under the MIT License.

