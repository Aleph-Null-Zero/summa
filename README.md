# SUMMA - ERP Ultra Liviano

Este es el repositorio raíz de **SUMMA**, que agrupa dos proyectos principales:

- **backend**: API RESTful en .NET  
- **frontend**: Aplicación móvil/web en Flutter

---

## 📋 Descripción

SUMMA es una solución ligera y modular dirigida a microempresas y emprendedores que necesitan gestionar inventarios, ventas y reportes de forma ágil y eficiente.

- **Idea**: Facturación, inventario, contabilidad simplificada con UX muy amigable.

Un **ERP básico, accesible y simplificado** para negocios pequeños (1–10 empleados) que necesiten ayuda con:
- **Facturación**
- **Inventario**
- **Control de ingresos/gastos**
- **Reportes básicos contables**
- **Clientes y proveedores**

### Funcionalidades:
1. Crear productos/servicios
2. Registrar ventas y compras
3. Inventario básico (stock mínimo, alertas)
4. Clientes y proveedores
5. Reporte mensual de ganancias/pérdidas
6. Panel resumen con ingresos/gastos
7. Exportar a Excel o PDF

### 🎯 **Objetivo**
Desarrollar un **ERP ultra liviano** para **microempresas y emprendedores**, enfocado en:
- **Facturación**
- **Inventario**
- **Ingresos/gastos**
- **Reportes básicos**
- **Clientes/proveedores**
Con enfoque en:
- **UX extremadamente simple**
- **Accesibilidad móvil-first**
- **Multiplataforma con un solo código base**
- Mercado objetivo: LATAM y países emergentes

| Módulo | Funciones principales |
|----------------|-----------------------------------------------------------|
| **Auth** | Login/registro, token JWT, recuperación de sesión |
| **Dashboard** | Vista general: ingresos, ventas, productos más vendidos |
| **Ventas** | Crear ventas, listar ventas, ver detalles, imprimir PDF |
| **Inventario** | CRUD productos, stock actual, control de stock mínimo |
| **Reportes** | Ganancias/pérdidas, ventas por día/semana/mes |
| **Sync** | Guardar localmente cuando offline y sincronizar después |

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
├── summa-backend/          # Proyecto .NET (Web API)
│   └──                     # TODO
│   └── README.md           # Documentación específica del backend
│
└── summa-frontend/         # Proyecto Flutter
    ├── lib/
    │   ├── core/
    │   │   └── services/
    │   ├── features/
    │   │   ├── auth/
    │   │   ├── dashboard/
    │   │   ├── inventory/
    │   │   ├── sales/
    │   │   └── reports/
    │   │   └── sync/
    │   ├── models/
    │   ├── providers/
    ├── assets/             # Iconos, imágenes y fuentes
    └── README.md           # Documentación específica del frontend
```

---

## ⚙️ Prerrequisitos

- [.NET 7 SDK o superior](https://dotnet.microsoft.com/download)  
- [Flutter SDK (>= 3.0)](https://flutter.dev/docs/get-started/install)  
- Git  
- IDE recomendado:
  - Visual Studio Code (con extensiones de C# y Flutter)

---

## 🚀 Instalación y ejecución

### 1. Clonar el repositorio

```bash
git clone https://github.com/Aleph-Null-Zero/summa.git
cd summa
```

---

### 2. Backend (.NET)

TODO

---

### 3. Frontend (Flutter)

```bash
cd ../summa-frontend

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
  - Windows: `flutter build windows`
  - Linux: `flutter build linux`

---

## 🔗 Conexión Frontend–Backend

TODO

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

TODO