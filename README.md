# 📚 Aplicación de Registro de Estudiantes (Blazor Server)

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

raiz/
├── Components/
│   ├── Layout/
│   │   ├── MainLayout.razor         # Solo estructura del layout
│   │   ├── MainLayout.razor.css    # Estilos específicos
│   │   └── NavMenu.razor          #Barra de navegación
│   └── Pages/
│   │   ├── Estudiantes.razor  #Donde está el formulario
│   │   └── Home.razor          #Página de inicio
│   ├── _Imports.razor          #Barra de navegación
│   ├── App.razor
│   └── Routes.razor          #Solo lógica de enrutamiento
├── wwwroot/
│   ├── css/
│   │   └── app.css                # Estilos globales
│   └── bootstrap/
│       └── bootstrap.min.css
└── Program.cs                # Configuración principal de la aplicación Blazor Server

- `Models/Estudiante.cs`: modelo del estudiante
- `Pages/Estudiantes.razor`: formulario y listado
- `Data/AppDbContext.cs`: contexto de EF Core

## 📌 Datos de prueba
Vienen en la carpeta de Scripts
