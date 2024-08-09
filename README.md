# NumberApp

NumberApp is a simple ASP.NET Core MVC web application that allows users to input a number, process it, and display the results.

## Features

- Input a number `n` into a client input field
- Stores `n` in a database
- Returns `n * 2` to the client for display
- Stores `(n * 2)^2` in the database
- Returns `(n * 2)^2` to the client for display

## Getting Started

These instructions will help you set up and run the project locally.

### Prerequisites

- [.NET Core SDK](https://dotnet.microsoft.com/download) (version 7.0 or later)
- [Entity Framework Core](https://docs.microsoft.com/en-us/ef/core/)
- [SQLite](https://www.sqlite.org/download.html) (for the database)

### Installing

1. Clone the repository:

```bash
git clone https://github.com/yourusername/repository-name.git
cd repository-name
2. Restore dependencies:
dotnet restore

3. Apply migrations and update the database:
dotnet ef database update

4. Run the application:
dotnet run

5. Open your browser and navigate to http://localhost:5000/Number.


###Usage
Enter a number in the input field.
Click "Submit" to see the results.
The application will display the results of n * 2 and (n * 2)^2.