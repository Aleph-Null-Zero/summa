# ERP Ultra Liviano

Este es el repositorio raíz de **ERP Ultra Liviano**, que agrupa dos proyectos principales:

- **backend**: API RESTful en .NET  
- **frontend**: Aplicación móvil/web en Flutter

---

## 📋 Descripción

ERP Ultra Liviano es una solución ligera y modular dirigida a microempresas y emprendedores que necesitan gestionar inventarios, ventas y reportes de forma ágil y eficiente.

- El **backend** expone endpoints REST para:
  - Autenticación y autorización
  - Gestión de usuarios
  - Productos e inventarios
  - Transacciones y reportes
- El **frontend** ofrece:
  - Interfaz responsive para web y móvil
  - Gestión de sesiones con Riverpod
  - Sincronización offline con Hive

---

## 🗂️ Estructura del repositorio

```plaintext
/
├── backend/                # Proyecto .NET (Web API)
│   ├── src/
│   │   ├── Controllers/
│   │   ├── Models/
│   │   ├── Services/
│   │   ├── Data/           # Contexto de EF Core y migraciones
│   │   └── Program.cs
│   ├── backend.sln
│   └── README.md           # Documentación específica del backend
│
└── frontend/               # Proyecto Flutter
    ├── lib/
    │   ├── core/
    │   │   ├── constants.dart
    │   │   └── services/
    │   │       ├── api_service.dart
    │   │       └── sync_service.dart
    │   ├── features/
    │   │   ├── auth/
    │   │   │   └── auth_screen.dart
    │   │   ├── dashboard/
    │   │   ├── inventario/
    │   │   ├── ventas/
    │   │   └── reportes/
    │   ├── models/
    │   ├── providers/
    │   └── main.dart
    ├── assets/             # Iconos, imágenes y fuentes
    ├── pubspec.yaml
    └── README.md           # Documentación específica del frontend
```

---

## ⚙️ Prerrequisitos

- [.NET 7 SDK o superior](https://dotnet.microsoft.com/download)  
- [Flutter SDK (>= 3.0)](https://flutter.dev/docs/get-started/install)  
- Git  
- IDE recomendado:
  - Visual Studio 2022+ (con extensiones de C#)
  - Visual Studio Code (con extensiones de C# y Flutter)

---

## 🚀 Instalación y ejecución

### 1. Clonar el repositorio

```bash
git clone https://github.com/tu-usuario/erp-ultra-liviano.git
cd erp-ultra-liviano
```

---

### 2. Backend (.NET)

```bash
cd backend

# Restaurar paquetes
dotnet restore

# Aplicar migraciones (opcional)
dotnet ef database update

# Ejecutar la API en modo desarrollo
dotnet run
```

- **URLs por defecto**
  - HTTPS: `https://localhost:5001`
  - HTTP:  `http://localhost:5000`

> Ajusta `appsettings.Development.json` para modificar cadenas de conexión y otros parámetros.

---

### 3. Frontend (Flutter)

```bash
cd ../frontend

# Instalar dependencias
flutter pub get

# Ejecutar en web
flutter run -d chrome

# Ejecutar en dispositivo móvil
flutter run
```

- **Web**: disponible en `http://localhost:<puerto>/`
- **Build de producción**:
  - Web: `flutter build web`
  - Android: `flutter build apk`
  - iOS:     `flutter build ios`

---

## 🔗 Conexión Frontend–Backend

1. En `frontend/lib/core/constants.dart`, define la URL base de la API:
   ```dart
   const String apiBaseUrl = 'https://localhost:5001/api';
   ```
2. Habilita CORS en `backend/src/Program.cs`:
   ```csharp
   builder.Services.AddCors(options =>
   {
       options.AddPolicy("AllowAll", policy =>
           policy.AllowAnyOrigin()
                 .AllowAnyHeader()
                 .AllowAnyMethod());
   });

   app.UseCors("AllowAll");
   ```

---

## 🤝 Contribuciones

1. Haz un _fork_ del repositorio.
2. Crea una rama nueva:
   ```bash
   git checkout -b feature/nombre-feature
   ```
3. Realiza tus cambios y haz commit:
   ```bash
   git commit -m "Descripción clara del cambio"
   ```
4. Empuja tu rama y abre un _pull request_.

Por favor, sigue las guías de estilo de C# y Dart/Flutter.

---

## 📄 Licencia

Este proyecto está bajo la Licencia MIT.  
Consulta el archivo [LICENSE](LICENSE) para más detalles.
