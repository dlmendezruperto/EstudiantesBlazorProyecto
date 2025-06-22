# 📚 Aplicación de Registro de Estudiantes (Blazor Server) hecho por Diana Ruperto

Este proyecto permite registrar y visualizar estudiantes usando Blazor Server, .NET 8 y Entity Framework Core.

## 🚀 Tecnologías
- .NET 8
- Blazor Server
- Entity Framework Core
- SQL Server
- Visual Studio

## 📦 Requisitos
- Visual Studio con .NET 8
- SQL Server o SQL Express
- Navegador web

## 🔧 Instalación
1. Clona este repositorio o descomprime el ZIP.
2. Abre el proyecto en Visual Studio.
3. Verifica la conexión en `appsettings.json`.
4. Ejecuta el script `BaseDatos.sql` para crear la tabla.
5. Ejecuta el proyecto (`F5` o `Ctrl + F5`).

## 📂 Estructura

raiz → Components
  → Layout (MainLayout.razor, NavMenu.razor)
  → Pages (Estudiantes.razor, Home.razor)
raiz → wwwroot
  → css (app.css)
  → bootstrap (bootstrap.min.css)
raiz → Program.cs

- `Models/Estudiante.cs`: modelo del estudiante
- `Pages/Estudiantes.razor`: formulario y listado
- `Data/AppDbContext.cs`: contexto de EF Core

## 📌 Datos de prueba
Vienen en la carpeta de Scripts
