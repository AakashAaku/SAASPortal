# Faculty-Student Assignment & Assessment Portal Documentation - SAASPortal

## Table of Contents
1. [Introduction](#introduction)
2. [Objective](#objective)
3. [Key Skills to Evaluate](#key-skills-to-evaluate)
4. [Functional Requirements](#functional-requirements)
   - [Faculty Interface](#faculty-interface)
   - [Student Interface](#student-interface)
5. [Technical Requirements](#technical-requirements)
   - [Backend](#backend)
   - [Frontend](#frontend)
   - [CI/CD](#ci-cd)
   - [Unit Testing](#unit-testing)
   - [Bonus Features](#bonus-features)
6. [Installation and Setup](#installation-and-setup)
7. [Usage](#usage)
8. [Conclusion](#conclusion)

## Introduction
The Faculty-Student Assignment & Assessment Portal is a full-stack web application designed to facilitate the interaction between faculty and students in an educational environment. This application allows faculty to create assignments and assessments, while students can submit their work and view their performance metrics.

## Objective
The primary objective of this application is to provide a robust platform that supports:
- Role-based logins for faculty and students
- Creation and submission of assignments
- Grading and assessment creation
- Visualization of performance metrics

## Key Skills to Evaluate
The development of this application will evaluate the following key skills:
- Database Design (MS SQL Server with stored procedures only)
- RESTful API Design (for AJAX/front-end or service consumption)
- N-Tier Project Architecture
- ORM with Dapper
- Frontend Frameworks (Bootstrap, jQuery, or similar)
- Data Visualization (Power BI embedded, Chart.js, or similar)
- CI/CD (GitHub Actions or Azure DevOps pipelines)
- Unit Testing
- (Bonus) Integration with any AI tool/service (e.g., OpenAI for auto-assessment feedback)

## Functional Requirements

### Faculty Interface
1. **Secure login and role-based access**
2. **Dashboard with:**
   - Student listing (retrieve from DB)
   - Create Assignments
     - Title, Description, Due Date/Time, File Upload
   - Create Assessments
     - Linked to Assignments
     - Multiple grading criteria (e.g., Clarity, Completeness)
     - Score range per criterion (e.g., 1-10)
     - Remarks entry
   - View performance charts of all students (line chart, pie chart)

### Student Interface
1. **Secure login and role-based access**
2. **Dashboard with:**
   - View Assignments
     - Submit before deadline (upload file or link)
   - View Graded Assessments
     - See criteria, score, remarks
   - Visualized performance (individual)

## Technical Requirements

### Backend
1. **.NET Core (v6 or above)**
2. **MVC Architecture**
3. **Use Dapper for data access (via stored procedures only)**
4. **SQL Server for database**
5. **Authentication via Identity or custom role management**

### Frontend
1. **Use Bootstrap or any UI Framework**
2. **AJAX calls for dynamic content (jQuery/Fetch)**
3. **Chart.js / Power BI / Any visualization tool**

### CI/CD
1. **Code must be hosted on GitHub or any online repository**
2. **Include:**
   - Build pipeline (unit tests required)
   - Release pipeline (optional: deploy to Azure Web App or IIS)

### Unit Testing
- Write tests for service and data layers  

### Bonus Features
- Optional integration with AI tool
  - Example: Use OpenAI API to auto-generate feedback on assignments

## Installation and Setup
1. Clone the repository from GitHub.
2. Open the solution in Visual Studio.
3. Restore NuGet packages.
4. Configure the database connection string in `appsettings.json`.
5. Run database migrations to set up the schema.
6. Start the application using IIS Express or Kestrel.

## Usage
1. **Faculty Login:** Navigate to the faculty login page and enter credentials.
2. **Student Login:** Navigate to the student login page and enter credentials.
3. **Dashboard Navigation:** Use the dashboard to create assignments, view students, and assess performance metrics.
4. **Assignment Submission:** Students can view assignments and submit their work before the deadline.
5. **Performance Visualization:** Both faculty and students can view performance metrics through visualized charts.

## Conclusion
The Faculty-Student Assignment & Assessment Portal is designed to streamline the assignment and assessment process in educational institutions. By leveraging modern web technologies and best practices, this application aims to enhance the learning experience for both faculty and students.
