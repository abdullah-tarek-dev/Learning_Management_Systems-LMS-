# Learning Management System (LMS)

## Project Overview

This project is a Learning Management System (LMS) built using ASP.NET Core Web API and Clean Architecture.

The purpose of this project is to practice and apply modern .NET backend development concepts including:

* Clean Architecture
* ASP.NET Core Web API
* Entity Framework Core
* PostgreSQL
* ASP.NET Core Identity
* JWT Authentication
* Repository Pattern
* Dependency Injection
* CQRS
* Validation
* Logging

---

# Solution Structure

```text
LMS
│
├── LMS.API
├── LMS.Application
├── LMS.Domain
└── LMS.Infrastructure
```

---

# Architecture

The project follows Clean Architecture principles.

## Dependencies

```text
API
 ↓
Application
 ↓
Domain

Infrastructure
 ↓
Application
 ↓
Domain
```

### Rule

Dependencies always point inward toward the Domain layer.

---

# Projects Description

## LMS.API

Responsible for:

* Controllers
* Middleware
* Dependency Injection Registration
* Swagger Configuration
* Authentication & Authorization

---

## LMS.Application

Responsible for:

* DTOs
* Interfaces
* Business Logic
* CQRS Commands & Queries
* Validators

---

## LMS.Domain

Responsible for:

* Entities
* Enums
* Domain Rules

This layer does not depend on any other layer.

---

## LMS.Infrastructure

Responsible for:

* Database Access
* Entity Framework Core
* PostgreSQL Integration
* Repositories
* External Services

Current Folder Structure:

```text
Infrastructure
│
└── Persistence
    └── AppDbContext.cs
```

---

# Database

Database Provider:

```text
PostgreSQL
```

Database Name:

```text
LMSDb
```

---

# Installed Packages

## Infrastructure

### Entity Framework Core

```powershell
Install-Package Microsoft.EntityFrameworkCore -Version 8.0.8
```

Used for:

* ORM
* Database Access
* Change Tracking

---

### EF Core Design

```powershell
Install-Package Microsoft.EntityFrameworkCore.Design -Version 8.0.8
```

Used for:

* Migrations

---

### EF Core Tools

```powershell
Install-Package Microsoft.EntityFrameworkCore.Tools -Version 8.0.8
```

Used for:

* Migration Commands

---

### PostgreSQL Provider

```powershell
Install-Package Npgsql.EntityFrameworkCore.PostgreSQL -Version 8.0.4
```

Used for:

* Connecting EF Core with PostgreSQL

---

### ASP.NET Core Identity

```powershell
Install-Package Microsoft.AspNetCore.Identity.EntityFrameworkCore -Version 8.0.8
```

Used for:

* Users Management
* Roles
* Password Hashing
* Authentication

---

## API

### Swagger

```powershell
Install-Package Swashbuckle.AspNetCore
```

Used for:

* API Documentation
* Endpoint Testing

---

### JWT Authentication

```powershell
Install-Package Microsoft.AspNetCore.Authentication.JwtBearer -Version 8.0.8
```

Used for:

* JWT Token Authentication

---

# Current Progress

Completed:

* Create Solution
* Create Clean Architecture Projects
* Configure Project References
* Create Infrastructure Layer
* Create Persistence Folder
* Install Core Packages
* Initialize Git Repository

In Progress:

* Configure PostgreSQL Connection
* Create AppDbContext
* Register DbContext
* Create First Entity
* Create Initial Migration

---

# Next Steps

1. Configure PostgreSQL Connection String
2. Create AppDbContext
3. Register DbContext in Program.cs
4. Create Student Entity
5. Create Initial Migration
6. Update Database
7. Implement Repository Pattern
8. Build Student CRUD APIs
9. Add Identity & JWT Authentication
10. Add Validation
11. Add CQRS
12. Add Logging
13. Add Unit Testing

---

# Author

Abdullah Tarek
.NET Backend Developer Journey
