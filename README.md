# Prueba linktic
Prueba técnica linktic.com
Paquetes Utilizados
Entity Framework Core (EF Core):
System.IdentityModel.Tokens.Jwt
MudBlazor
Microsoft.EntityFrameworkCore.SqlServer
Microsoft.EntityFrameworkCore.Tools

Utilizado para la creación y gestión de la base de datos con enfoque Code First.
Blazor:

System.Net.Http
CurrieTechnologies.Razor.SweetAlert2
Para la creación de componentes interactivos y alertas personalizadas.
Inyección de Dependencias:

Servicios configurados en el Program.cs para inyectar repositorios y contextos de datos.
Arquitectura de la Aplicación
Estructura del Proyecto:

Orders.Backend: Proyecto ASP.NET Core para el backend.
Orders.Frontend: Aplicación Blazor WebAssembly para el frontend.
Orders.Shared: Biblioteca de clases compartidas.

Capas de la Aplicación:

Backend:
Se utiliza 
DataContext: Configuración del contexto de datos y las entidades.
Controladores: Gestión de rutas API para las entidades.
Repositorios: Implementación de patrones de repositorio genérico y Unit of Work para la gestión de datos.
Seeder: Clase para alimentar la base de datos con datos iniciales.

Frontend:

Componentes Blazor: Implementación de componentes para CRUD de entidades como Productos 

Patrones Utilizados:

Repository Pattern: Para la abstracción de operaciones de datos.
Unit of Work: Para gestionar transacciones de múltiples repositorios.
Inyección de Dependencias: Para la gestión de dependencias en toda la aplicación.
Model-View-ViewModel (MVVM): En la organización de componentes Blazor.
Base de Datos:

Utiliza SQL Server
Migraciones: Gestión de cambios en el esquema de base de datos mediante migraciones de EF Core.
add-migration db_Inicial
update-database
Seguridad:

Autenticación y Autorización:
Implementación de autenticación basada en JWT para asegurar las API y la aplicación Blazor.
Configuración de políticas y roles para controlar el acceso a diferentes partes de la aplicación.
Gestión de Usuarios y Roles:
Registro, login, y logout de usuarios.
Confirmación de cuentas por email.
Recuperación de contraseñas.
Creación y administración de roles y permisos.
