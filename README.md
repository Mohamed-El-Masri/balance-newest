# Balance Real Estate Platform

## Overview

**Balance** is a comprehensive real estate management and showcase platform, supporting both Arabic and English, built on a robust N-tier architecture using ASP.NET Core Web API. The system is designed for scalability, security, and flexibility, enabling users to browse and interact with real estate projects and units, while providing administrators and employees with powerful management and analytics tools.

---

## 🛡️ User Roles

1. **User**
   - Has a personal profile.
   - Can view projects and units of interest or marked as favorites.
   - Favorites are stored in local storage for guests and in the database for registered users.
   - Can submit interest requests for projects/units.

2. **Admin**
   - Full control over the platform and all content visible to users.
   - Manages users (add, remove, promote, assign roles).
   - Manages all projects and units (CRUD, assign to employees, control visibility).
   - Manages dynamic content (About, Contact, Hero Section, etc.).
   - Adds notes and tasks for employees, with real-time and email notifications.
   - The primary Super Admin cannot be deleted or demoted.

3. **Employee**
   - Manages only the projects and units assigned by the admin.
   - Views notes and tasks relevant to them.
   - Receives notifications for assignments and tasks.
   - Can update task statuses (seen, completed, etc.).

---

## 🏛️ N-tier Architecture & Folder Structure

The project follows a clean, layered N-tier architecture, with each layer having a clear responsibility and separation of concerns:

### 1. **Presentation Layer** (`/Presentation`)
- **Purpose:** Exposes the RESTful Web API endpoints (Controllers) for all features (authentication, projects, units, users, notifications, etc.).
- **Tech:** ASP.NET Core Web API, Swagger for documentation.

### 2. **Application Layer** (`/Application`)
- **Purpose:** Contains business logic, use cases, service interfaces, DTOs, validation, and orchestrates workflows between layers.
- **Responsibilities:**
  - Application services (e.g., ProjectService, UserService, NotificationService)
  - DTOs and ViewModels
  - Input validation and mapping
  - Authorization policies

### 3. **Domain Layer** (`/Domain`)
- **Purpose:** Contains core business entities, enums, value objects, and domain logic.
- **Responsibilities:**
  - Entities (Project, Unit, User, ContentComponent, etc.)
  - Enums (ProjectType, ProjectStatus, etc.)
  - Domain events and business rules

### 4. **Infrastructure Layer** (`/Infrastructure`)
- **Purpose:** Implements external integrations and cross-cutting concerns.
- **Responsibilities:**
  - Cloudinary integration for image uploads
  - Email/SMS/SignalR notification providers
  - Third-party authentication (Google OAuth, etc.)
  - Localization resources

### 5. **Persistence Layer** (`/Persistence`)
- **Purpose:** Handles data access, repositories, and database context.
- **Responsibilities:**
  - Entity Framework Core DbContext
  - Repository implementations (ProjectRepository, UserRepository, etc.)
  - Unit of Work pattern
  - Database migrations and seed data

### 6. **Shared Kernel** (`/Shared`)
- **Purpose:** Common utilities, base classes, and cross-layer contracts.

#### Example Folder Structure
```
Balance/
├── Presentation/
│   └── Controllers/
├── Application/
│   ├── Services/
│   ├── DTOs/
│   └── Interfaces/
├── Domain/
│   ├── Entities/
│   ├── Enums/
│   └── ValueObjects/
├── Infrastructure/
│   ├── Cloudinary/
│   ├── Notifications/
│   └── Localization/
├── Persistence/
│   ├── DbContext/
│   ├── Repositories/
│   └── Migrations/
├── Shared/
│   └── Extensions/
├── appsettings.json
├── Program.cs
└── ...
```

---

## ⚙️ Technical Features & API Endpoints

- **Authentication & Authorization**
  - JWT-based authentication for API security
  - Role-based access control (User, Admin, Employee)
  - Google OAuth integration
  - Mandatory phone and email for registration (multiple phone numbers supported)

- **User Profile & Favorites**
  - Profile management (view/edit personal info, add multiple phones)
  - Favorites management (projects/units), synced between local storage and DB

- **Projects & Units Management**
  - CRUD operations for projects and units
  - Filtering and searching (by region, city, district, type, status, etc.)
  - Assigning projects/units to employees
  - Marking featured projects for homepage
  - Control visibility (active/inactive)

- **Dynamic Content Management**
  - Hero section, About, Contact, and other sections are editable via admin dashboard
  - Content stored in ContentComponent entities

- **Interest Requests**
  - Users/guests can submit interest in projects/units
  - Requests are stored and trigger notifications to relevant admins/employees
  - Form adapts based on user authentication status

- **Tasks & Notes**
  - Admins can assign tasks to employees (with status tracking)
  - Notes per project/unit, visible only to assigned staff
  - Real-time (SignalR) and email notifications

- **Analytics & Dashboard**
  - Admin dashboard with analytics, user/project/unit management, and content control
  - Employee dashboard with assigned items, tasks, and notes

- **Localization**
  - Full support for Arabic and English (UI and data)
  - Language toggle endpoint and resource management

- **Media & Cloudinary**
  - Image upload and management via Cloudinary
  - Support for project/unit images, icons, and video links (YouTube)

---

## 🗺️ API User Journey (End-to-End)

### 1. **Guest User**
- Browses homepage (hero, featured projects, about, map)
- Views all projects with advanced filtering and pagination
- Can add projects/units to favorites (local storage)
- Can submit interest requests (must provide name, phone, email)
- Can register (phone/email/username required, Google OAuth supported)

### 2. **Registered User**
- Has a profile (can edit info, add phones)
- Favorites are synced to their account
- Can submit interest with minimal input (phone only)
- Can view all their favorite and interested projects/units

### 3. **Employee**
- Logs in to a dedicated dashboard
- Sees only assigned projects/units
- Views and updates tasks and notes
- Receives notifications for assignments and interest requests

### 4. **Admin**
- Logs in to the admin dashboard
- Full control: manage users, roles, projects, units, content, analytics
- Assigns projects/units/tasks to employees
- Adds notes and tasks (with status tracking)
- Manages dynamic content (hero, about, contact, etc.)
- Cannot delete/demote the primary Super Admin
- Receives and manages all notifications

---

## 🚀 Getting Started

1. Ensure SQL Server is installed and accessible.
2. Configure `appsettings.json` for DB and Cloudinary.
3. Run database migrations (`dotnet ef database update`).
4. Launch the API (`dotnet run` or via Visual Studio).
5. Access Swagger UI for API exploration and testing.
6. Register an admin user and begin system configuration.

---

## 📝 Additional Notes
- **Seed Data:** Initial projects, units, and content are seeded on first run.
- **Validation:** All endpoints use DTO validation and error handling.
- **Security:** JWT, role-based policies, and secure password storage.
- **Notifications:** Real-time (SignalR) and email for all relevant events.
- **Extensibility:** The architecture supports easy addition of new features and integrations.

---


