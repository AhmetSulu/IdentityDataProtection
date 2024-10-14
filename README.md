# IdentityDataProtection

IdentityDataProtection is a .NET 8.0 project that demonstrates user management and data protection using ASP.NET Core Identity and Entity Framework Core. The project includes user registration with email and password validation, and password encryption.

## Table of Contents

- [Features](#features)
- [Technologies](#technologies)
- [Getting Started](#getting-started)
- [Contributing](#contributing)
- [License](#license)
- [Contact](#contact)

## Features

- User registration with email and password validation.
- Password encryption.
- User authentication.

## Technologies

- .NET 8.0
- ASP.NET Core Identity
- Entity Framework Core
- SQL Server

## Getting Started

### Prerequisites

- [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) or any other compatible database

### Installation

1. **Clone the Repository**:
   ```bash
   https://github.com/AhmetSulu/IdentityDataProtection.git
   
2.  **Navigate to the Project Directory**:
    ```bash
    cd IdentityDataProtection

3. Update the database connection string in `appsettings.json`:
   ```bash
   "ConnectionStrings": {
    "DefaultConnection": "Server=your_server;Database=SurvivorDb;User Id=your_user;Password=your_password;"
    }


4. Apply the migrations and update the database:
   ```bash
    dotnet ef add-migration xxxx, update-database

   
## Contributing

Contributions are welcome! Please open an issue or submit a pull request for any changes.

1. Fork the repository.
2. Create a new branch (`git checkout -b feature/your-feature`).
3. Commit your changes (`git commit -am 'Add some feature'`).
4. Push to the branch (`git push origin feature/your-feature`).
5. Create a new Pull Request.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## Contact

For any questions or support, please email [your-email@example.com](ahmet.sulu1993@gmail.com)

    
