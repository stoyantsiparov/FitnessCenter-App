# Bachelors-FitnessCenter-App - Web-Based System for Fitness Center Management

Bachelors-FitnessCenter-App is a web-based business application designed for the comprehensive management of operational activities in a modern fitness and wellness center. The platform serves users, active members, and administrators to seamlessly manage memberships, classes, events, and spa procedures through a 24/7 self-service portal.

## Features

### Membership Management
* 🏷 Browse available membership types (e.g., Basic, Student) with detailed information, pricing, and duration.
* 📋 Dynamically purchase subscription plans to upgrade your account to an active Member.
* 🛠 Administer membership types: Create, edit, or delete plans.

### Class Management
* 🔍 Search and filter fitness classes by keyword, duration, or sort by name and date.
* 📅 View rich class details including schedule, duration, capacity, and assigned instructor.
* ✅ Register or remove registrations for classes with automated capacity checks to prevent overfilling and double-booking.
* 🛠 Administer classes: Full CRUD operations for administrators.

### Fitness Event Management
* 🌟 Explore upcoming external sports events, camps, and marathons.
* 🗺 View precise locations, start dates, and end dates.
* ✅ Register for events or view completed ones.
* 🛠 Administer events: Create, read, update, and delete events.

### Spa Procedure Management
* 💆 Browse spa procedures (massages, saunas, therapies) with defined duration, capacity, and price.
* 🕒 Book appointments through a dedicated reservation system.
* 🛠 Administer spa procedures: Manage the spa catalog.

### Instructor Management
* 👩‍🏫 View detailed instructor profiles attached to specific training classes.
* 🛠 Administer instructors: Manage instructor records.

### User Management & Admin Dashboard
* 👥 View all registered clients and manage their roles (Admin, Member, User).
* 🔒 Delete profiles and manage access rights.
* 📊 Access interactive business analytics, capacity graphs, and export data in CSV format.

## Technologies

#### Backend
* 🌐 C# and ASP.NET Core MVC (version 8.0) for API and business logic.
* 🛠 Entity Framework Core (Code-First approach) for database interactions.
* 📋 Model-View-Controller (MVC) architecture pattern with Dependency Injection.

#### Frontend
* 🎨 HTML5, CSS3, JavaScript, and Bootstrap 5 for a responsive, mobile-first design.
* 📈 Chart.js for interactive graphics, DataTables for paginated grids, and SweetAlert2 for notifications.

#### Database
* 💾 Microsoft SQL Server using relational schema and optimistic concurrency control.
* 📝 Automated AFTER INSERT and UPDATE SQL triggers for systemic operation logging.

## Installation
* Clone the repository:
```bash
git clone [https://github.com/stoyantsiparov/Bachelors-FitnessCenter-App.git](https://github.com/stoyantsiparov/Bachelors-FitnessCenter-App.git)
