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
install-package Ardalis.Specification

Infrastructure
Install-Package Microsoft.EntityFrameworkCore.Tools
Install-Package Microsoft.EntityFrameworkCore.SqlServer
Install-Package Microsoft.AspNetCore.Identity
Install-Package Microsoft.AspNetCore.Identity.EntityFrameworkCore

Add-Migration InitialIdentityModel -context AppIdentityDbContext -OutputDir "Identity/Migrations"
Update-Database -context AppIdentityDbContext

Add-Migration Initial -context ShopContext -OutputDir "Data/Migrations"
Update-Database -context ShopContext

Add-Migration BasketCreate -context ShopContext -OutputDir "Data/Migrations"
Update-Database -context ShopContext
UI layer



## SEED DATA ##
## 2'si 1 Arada ##
LENOVO IDEAPAD C340 CORE İ3 10110U 2.1GHZ-4GB-128GB SSD-14"-INT-TOUCH-W10
TeoriV2-106778-8_small.jpg
4599	

LENOVO YOGA C940 CORE İ7 1065G7 1.3GHZ-16GB RAM-512GB SSD-14''-INT-TOUCH-W10
TeoriV2-105261-7_small.jpg
13999

HP ENVY X360 13-AR0003NT AMD RYZEN 5 3500U 2.1GHZ-8GB-512GB SSD-13.3"-AMD-W10
TeoriV2-104421-2_small.jpg
7899

## Laptop ##
LENOVO IDEAPAD L3 CORE İ5 10210U 1.6GHZ-4GB-256GB SSD-15.6"-MX130 2GB-W10
TeoriV2-107814-1_small.jpg
4499

MACBOOK PRO TOUCH BAR CORE İ5 2.0GHZ-16GB-1TB SSD-RETINA 13"-INT-SILVER
TeoriV2-107655-1_small.jpg
17599

ASUS X509JB CORE İ5 1035G1 1.0GHZ-8GB RAM-256GB SSD-15.6"-MX110 2GB-W10
TeoriV2-106885-1_small.jpg
5299

LENOVO IDEAPAD S340 CORE İ5 10210U 1.6GHZ-8GB-512GB SSD-15.6"-MX250 2GB-W10
TeoriV2-106777-1_small.jpg
6199

HP 15-DA1116NT CORE İ5 8265U 1.6GHZ-8GB-1TB+128GB SSD-15.6"-MX110 2GB-W10
TeoriV2-106571-1_small.jpg
5599

DELL XPS 13 7390 CORE İ7 10510U 1.8GHZ-16GB RAM-512 SSD-INT-13.3"W10 PRO
TeoriV2-105824-2_small.jpg
15973

ASUS X509FB CORE İ5 8265U 1.6GHZ-8GB RAM-256GB SSD-15.6"-MX110 2GB-W10
TeoriV2-105445-8_small.jpg
5043

## Oyun Bilgisayarı
ASUS A15 TUF FA506IU AMD R7 4800H 2.9GHZ-16GB-512GB SSD-15.6''-GTX1660TI 6GB-W10
TeoriV2-107585-2_small.jpg
10218

MSI GF75 CORE İ7 10750H 2.6GHZ-16GB-256GB SSD+ 1TB HDD-17.3"-GTX1650 4GB-W10
TeoriV2-106836_small.jpg
13583

HP PAVILION 15-CX0039NT CORE İ5 8300H 2.3GHZ-16GB-512SSD-15.6"-GTX1050TI 4GB-W10
TeoriV2-104420-1_small.jpg
7499

LENOVO LEGION Y740 CORE İ7 9750H 2.6GHZ-32GB-1TB+1TB SSD-17.3"-RTX2070 8GB-W10
TeoriV2-103978-1_small.jpg
19999