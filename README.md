# 🔐 Password Manager API

![.NET 8](https://img.shields.io/badge/.NET-8.0-blue)  ![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)  ![Swagger](https://img.shields.io/badge/API-Documented-brightgreen)

A secure and scalable RESTful API built using **ASP.NET Core (.NET 8)** to manage user credentials, profiles, and service providers.

## 🚀 Features

- ✅ **User Authentication & Verification**
- 🔐 **JWT Token Generation**
- 📧 **OTP-based Email Verification**
- 🔄 **Password Reset via OTP**
- 👤 **Profile Management (Image, Name, Email, etc.)**
- 🏢 **Provider Management (Add / Update / Retrieve)**
- 📋 **Lookup System (Nationality, Role, Category, etc.)**
- 📦 **Seeded Initial Data**
- 📨 **SMTP Email Service Integration**

## 🧱 Project Structure

```bash
PasswordManagerAPI/
├── Controllers/              # RESTful API Endpoints
├── DTOs/                     # Data Transfer Objects
│   ├── LookupDTO/
│   ├── ProviderDTO/
│   └── UserProfileDTO/
├── Entitys/                  # Domain models (User, Profile, LookupItem, etc.)
├── Context/                  # Database context (EF Core)
├── Interfaces/               # Service contracts
├── Services/                 # Business logic implementation
├── Helpers/                  # Hashing & JWT token utilities
├── Migrations/               # EF Core database migrations
├── appsettings.json          # Configuration settings
├── Program.cs                # Startup configuration
└── README.md                 # Project documentation
```


## 🛠️ Setup & Installation

### Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0) or later
- SQL Server (or LocalDB)
- A code editor or IDE (e.g., Visual Studio, VS Code)

### Steps

1. **Clone the repository:**

   ```bash
   git clone https://github.com/your-username/PasswordManagerAPI.git
   cd PasswordManagerAPI
   ```

2. **Restore dependencies:**

   ```bash
   dotnet restore
   ```

3. **Apply database migrations:**

   ```bash
   dotnet ef database update
   ```

4. **Run the application:**

   ```bash
   dotnet run
   ```

5. **Access the API via:**

   ```
   http://localhost:5226
   ```

6. **Open Swagger UI for Testing:**

   ```
   http://localhost:5226/swagger
   ```

## 🌐 API Endpoints

| Method | Endpoint            | Description                      |
|--------|---------------------|----------------------------------|
| POST   | `/api/UserAuthentication/SignUp`       | Register a new user             |
| POST   | `/api/UserAuthentication/SignIn`       | Authenticate user and get OTP   |
| POST   | `/api/UserAuthentication/Verification`| Verify email with OTP           |
| POST   | `/api/UserAuthentication/SendOTP`     | Resend OTP                      |
| POST   | `/api/UserAuthentication/ResetPersonPassword` | Reset password using OTP |
| POST   | `/api/UserProfile/GetUserProfile`     | Get user profile                |
| POST   | `/api/UserProfile/UpdateUserProfile`  | Update user profile             |
| POST   | `/api/UserProfile/UpdateImageProfile`  | Upload/update profile image     |
| POST   | `/api/Provider/CreateUpdateProvider`   | Add or update provider info     |
| GET    | `/api/Provider/GetProvider`          | Retrieve all providers         |
| GET    | `/api/Provider/GetProviderDetails`   | Retrieve specific provider     |

### ✅ Sample Request Example

#### Sign Up (POST)

```http
POST /api/UserAuthentication/SignUp
Content-Type: application/json

{
  "username": "ahmad",
  "password": "aaaa@123",
  "email": "ahmad@example.com"
}
```

#### Response

```json
"Verification Your Email By OTP Code"
```

## 📦 DTOs Overview

| DTO Class                   | Purpose                             |
|----------------------------|--------------------------------------|
| `SignUpInputDTO`            | Input for user registration          |
| `SignInInputDTO`            | Input for user login                 |
| `VerificationInputDTO`      | OTP verification                     |
| `ResetPersonPasswordInputDTO`| Reset password request data           |
| `ProfileDTO`               | User profile details                 |
| `UpdateProfileDTO`         | Input for updating user profile      |
| `CreateUpdateProviderDTO`  | Add or edit provider                 |
| `ProviderDTO`              | Output for provider list             |
| `ProviderDetailsDTO`       | Detailed provider information        |
| `LookupItemDTO`            | Lookup item response                 |

## 🧠 Business Logic

- **Services:** Encapsulate business rules and operations.
- **Interfaces:** Define contracts for dependency injection.
- **Helpers:** Includes hashing utilities and JWT generation/validation.

## 📂 Data Layer

- **`PasswordManagerDbContext`**: Entity Framework Core context.
- **SQL Server:** Uses seeded lookup values and user tables.
- **Migrations:** Fully configured with initial seeding of roles, categories, nationalities, etc.

## 🔐 Security

- **SHA-384 Hashing:** For secure storage of emails, usernames, and passwords.
- **JWT Tokens:** Stateless authentication with role-based access.
- **OTP via SMTP:** Temporary codes sent via email for sign-in and reset.

## 📖 API Documentation

- 🐳 **Swagger UI**:
  Access the interactive API docs at:
  [http://localhost:5226/swagger](http://localhost:5226/swagger)

- 📬 **Postman Collection**:
  Import our Postman collection to quickly test the API:
  👉 [Download Postman Collection](docs/PasswordManagerAPI.postman_collection.json)

![Swagger UI Screenshot](docs/swagger-screenshot.png)

## 📝 Technologies Used

- **ASP.NET Core 8**
- **C#**
- **Entity Framework Core**
- **SQL Server**
- **JWT Authentication**
- **SMTP Email Service**
- **SendGrid**
- **Swagger / Swashbuckle**
- **Postman**
- **EF Core Migrations with Seeding**


