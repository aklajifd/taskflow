# Taskflow

A full-stack task and project management web application built with C# and .NET.
This project is being built incrementally as part of a structured C# and .NET learning program.

## Tech Stack
- C# / .NET 9
- ASP.NET Core (coming soon)
- Entity Framework Core (coming soon)
- SQL Server (coming soon)

## Project Structure
Taskflow.Console/ — Console-based domain layer (current phase)
  Models/         — Core domain models (User, TaskItem)
  Interfaces/     — Contracts (IDescribable, ICompletable, IPermissioned, IEntity)
  Exceptions/     — Custom exceptions (InvalidEmailException, InvalidPriorityException)
  Repositories/   — Generic in-memory repository

## Current Status
Building and validating the core domain model before moving to ASP.NET Core.

## Roadmap
- [x] Core domain models
- [x] Interface-driven design
- [x] Input validation and exception handling
- [x] Generic repository pattern
- [ ] LINQ query layer
- [ ] ASP.NET Core Web API
- [ ] Entity Framework Core with SQL Server
- [ ] Authentication and Authorization
- [ ] Frontend