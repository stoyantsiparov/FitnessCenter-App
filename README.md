# 🏋️‍♂️ FitnessCenter-App

> A web-based business application designed for the comprehensive management of operational activities in a modern fitness and wellness center[cite: 1]. 

## 📖 Overview

This system centralizes the management of client registrations, membership purchases, and reservations for various activities like group workouts, sports events, and SPA procedures[cite: 1]. It serves both internal staff (administrators) and end-clients through a modern 24/7 self-service portal optimized for mobile devices[cite: 1].

## ✨ Key Features

*   **Identity & Security**: Secure user registration, authentication, and Role-Based Access Control (Admin, Member, User) using ASP.NET Core Identity[cite: 1].
*   **Membership Management**: Users can dynamically purchase subscription plans to upgrade their accounts to active "Member" status[cite: 1].
*   **Class & SPA Scheduling**: Automated reservation system for group training and SPA procedures that automatically tracks room capacity to prevent double-booking and over-filling[cite: 1].
*   **Fitness Events**: A module for users to track and register for external sports events, marathons, or camps[cite: 1].
*   **Admin Dashboard**: Provides administrators with full CRUD capabilities, master-detail views for tracking capacity, and interactive business analytics with CSV export options[cite: 1].
*   **Concurrency Control**: Implements optimistic concurrency control to prevent data conflicts when multiple administrators edit the same record simultaneously[cite: 1].

## 🛠 Tech Stack

**Back-end**
*   C# and ASP.NET Core MVC (version 8.0)[cite: 1].
*   Entity Framework Core using a Code-First approach[cite: 1].

**Database**
*   Microsoft SQL Server[cite: 1].
*   Automated AFTER INSERT and UPDATE SQL triggers for systemic operation logging[cite: 1].

**Front-end**
*   HTML5, CSS3, and JavaScript[cite: 1].
*   Bootstrap 5 for responsive, mobile-first design[cite: 1].
*   Chart.js for interactive business analytics[cite: 1].
*   DataTables for paginated, searchable data grids[cite: 1].
*   SweetAlert2 for interactive user notifications and modal confirmations[cite: 1].

## 🏛 Architecture

The application is built using an N-tier architecture based on the Model-View-Controller (MVC) pattern[cite: 1].

## 👨‍💻 Author

*   **Stoyan Georgiev Tsiparov** - *Business Informatics and Communications (4th Year)* - UNWE (University of National and World Economy)[cite: 1].
