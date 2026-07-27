# FitnessCenter-App - Web-Based System for Fitness Center Management

FitnessCenter-App is a web-based business application designed for the comprehensive management of operational activities in a modern fitness and wellness center[cite: 1]. The platform serves users, active members, and administrators to seamlessly manage memberships, classes, events, and spa procedures through a 24/7 self-service portal[cite: 1].

## Features

### Membership Management
* 🏷 Browse available membership types (e.g., Basic, Student) with detailed information, pricing, and duration[cite: 1].
* 📋 Dynamically purchase subscription plans to upgrade your account to an active Member[cite: 1].
* 🛠 Administer membership types: Create, edit, or delete plans[cite: 1].

### Class Management
* 🔍 Search and filter fitness classes by keyword, duration, or sort by name and date[cite: 1].
* 📅 View rich class details including schedule, duration, capacity, and assigned instructor[cite: 1].
* ✅ Register or remove registrations for classes with automated capacity checks to prevent overfilling and double-booking[cite: 1].
* 🛠 Administer classes: Full CRUD operations for administrators[cite: 1].

### Fitness Event Management
* 🌟 Explore upcoming external sports events, camps, and marathons[cite: 1].
* 🗺 View precise locations, start dates, and end dates[cite: 1].
* ✅ Register for events or view completed ones[cite: 1].
* 🛠 Administer events: Create, read, update, and delete events[cite: 1].

### Spa Procedure Management
* 💆 Browse spa procedures (massages, saunas, therapies) with defined duration, capacity, and price[cite: 1].
* 🕒 Book appointments through a dedicated reservation system[cite: 1].
* 🛠 Administer spa procedures: Manage the spa catalog[cite: 1].

### Instructor Management
* 👩‍🏫 View detailed instructor profiles attached to specific training classes[cite: 1].
* 🛠 Administer instructors: Manage instructor records[cite: 1].

### User Management & Admin Dashboard
* 👥 View all registered clients and manage their roles (Admin, Member, User)[cite: 1].
* 🔒 Delete profiles and manage access rights[cite: 1].
* 📊 Access interactive business analytics, capacity graphs, and export data in CSV format[cite: 1].

## Technologies

#### Backend
* 🌐 C# and ASP.NET Core MVC (version 8.0) for API and business logic[cite: 1].
* 🛠 Entity Framework Core (Code-First approach) for database interactions[cite: 1].
* 📋 Model-View-Controller (MVC) architecture pattern with Dependency Injection[cite: 1].

#### Frontend
* 🎨 HTML5, CSS3, JavaScript, and Bootstrap 5 for a responsive, mobile-first design[cite: 1].
* 📈 Chart.js for interactive graphics, DataTables for paginated grids, and SweetAlert2 for notifications[cite: 1].

#### Database
* 💾 Microsoft SQL Server using relational schema and optimistic concurrency control[cite: 1].
* 📝 Automated AFTER INSERT and UPDATE SQL triggers for systemic operation logging[cite: 1].

## Installation
* Clone the repository:
```bash
git clone [https://github.com/stoyantsiparov/FitnessCenter-App.git](https://github.com/stoyantsiparov/FitnessCenter-App.git)
