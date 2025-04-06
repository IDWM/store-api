# Store API

## Descripción

Store API es una API RESTful desarrollada en .NET 9.0 que proporciona endpoints para la gestión de tiendas y productos. 
La aplicación permite crear tiendas, listar todas las tiendas disponibles, crear productos asociados a tiendas específicas
y consultar productos por su identificador.

## Tecnologías necesarias

- .NET 9.0 SDK
- SQLite

### Paquetes principales

- Microsoft.EntityFrameworkCore
- Microsoft.EntityFrameworkCore.Sqlite
- AutoMapper
- Bogus

## Pasos de ejecución

### Instalación

1. Restaura los paquetes NuGet:

   ```bash
   dotnet restore
   ```

2. Ejecuta la aplicación:

   ```bash
   dotnet run
   ```

La aplicación iniciará y estará disponible en `http://localhost:5000/api`.

### Migraciones de base de datos

La aplicación ejecutará automáticamente las migraciones y poblará la base de datos con datos semilla al iniciar. No es necesario ejecutar comandos de migración manualmente.

## Pruebas con Postman

Se incluye una colección de Postman (`Store API Testing.postman_collection.json`) con ejemplos 
de todas las peticiones disponibles y tests automatizados.

Para usar la colección:

1. Importa la colección en Postman
2. Ejecuta las peticiones en el orden establecido, ya que utilizan variables de colección para mantener los IDs de tiendas y productos entre peticiones