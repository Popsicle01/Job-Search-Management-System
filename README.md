# Job-Search-Management-System

A **Full-Stack Job Search Application** built with:
- **Frontend:** Angular
- **Backend:** .NET Core Web API
- **Database:** MySQL
- **Deployment:** Docker & Docker Compose

## Features
✅ Search jobs by **title, location, and level**  
✅ Apply for a job using **name and email**  
✅ REST API backend with **.NET Core**  
✅ Database managed with **MySQL**  

---

## 🛠️ Project Structure
JobSearchApp/
│── backend/                    # .NET Core Backend
│   ├── Controllers/JobsController.cs
│   ├── Services/JobService.cs
│   ├── Models/Job.cs, Application.cs
│   ├── Data/AppDbContext.cs
│   ├── Program.cs, Startup.cs, appsettings.json
│── frontend/                    # Angular Frontend
│   ├── src/app/
│   │   ├── components/job-list/job-list.component.ts
│   │   ├── components/job-list/job-list.component.html
│   │   ├── components/job-list/job-list.component.css
│   │   ├── services/job.service.ts
│   │   ├── app.module.ts
│   │   ├── app.component.ts
│   │   ├── app.component.html
│   ├── package.json
│   ├── angular.json
│── database/                   # MySQL Schema
│   ├── schema.sql
│── docker-compose.yml          # Docker for Backend + MySQL
│── README.md
