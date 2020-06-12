Application Core types
* Entities (business model classes that are persisted)
* Interfaces
* Services
* DTOs

Infrastructure types
* EF Core types (DbContext, Migration)
* Data access implementation types (Repositories)
* Infrastructure-specific services (for example, FileLogger or SmtpNotifier)

UI layer types
* Controllers
* Filters
* Views
* ViewModels
* Startup

== Packages ==
Application Core

Infrastructure
Install-Package Microsoft.EntityFrameworkCore.Tools
Install-Package Microsoft.EntityFrameworkCore.SqlServer
Install-Package Microsoft.AspNetCore.Identity
Install-Package Microsoft.AspNetCore.Identity.EntityFrameworkCore

Add-Migration InitialIdentityModel -context AppIdentityDbContext -OutputDir "Identity/Migrations"
Update-Database -context AppIdentityDbContext

Add-Migration Initial -context ShopContext -OutputDir "Data/Migrations"
Update-Database -context ShopContext

UI layer