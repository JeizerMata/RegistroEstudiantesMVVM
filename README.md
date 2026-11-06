# Registro de Estudiantes - MVVM (.NET MAUI)

Aplicación .NET MAUI que implementa el patrón de arquitectura **MVVM** (Model-View-ViewModel) para registrar estudiantes y mostrarlos en un `CollectionView`.

## Diagrama MVVM

```
┌─────────────────────────────────────────────────────────────┐
│                        VIEW (XAML)                          │
│  RegistroPage.xaml                                          │
│  ┌─────────────────────────────────────────────────────┐    │
│  │ Entry ──── {Binding Nombre}                         │    │
│  │ Entry ──── {Binding Correo}                         │    │
│  │ Entry ──── {Binding Telefono}                       │    │
│  │ Entry ──── {Binding Carrera}                        │    │
│  │ DatePicker {Binding Fecha}                          │    │
│  │ Button ─── {Binding GuardarCommand}                 │    │
│  │ CollectionView ── {Binding Estudiantes}             │    │
│  └─────────────────────────────────────────────────────┘    │
│         │ x:DataType (compiled bindings)                    │
│         ▼                                                   │
│ ┌───────────────────────────────────────────────────────┐   │
│ │              VIEWMODEL (C#)                           │   │
│ │  RegistroViewModel : ObservableObject                 │   │
│ │  ┌─────────────────────────────────────────────────┐  │   │
│ │  │ [ObservableProperty] Nombre, Correo, etc.       │  │   │
│ │  │ [RelayCommand] Guardar() + CanExecute           │  │   │
│ │  │ ObservableCollection<Estudiante> Estudiantes    │  │   │
│ │  └─────────────────────────────────────────────────┘  │   │
│ │         │                                             │   │
│ │         ▼                                             │   │
│ │ ┌─────────────────────────────────────────────────┐   │   │
│ │ │              MODEL (C#)                         │   │   │
│ │ │  Estudiante                                     │   │   │
│ │ │  - Nombre, Correo, Telefono, Carrera, Fecha     │   │   │
│ │ └─────────────────────────────────────────────────┘   │   │
│ └───────────────────────────────────────────────────────┘   │
└─────────────────────────────────────────────────────────────┘
```

## Estructura del Proyecto

```
RegistroEstudiantesMVVM/
├── Models/
│   └── Estudiante.cs          # Modelo de datos
├── ViewModels/
│   └── RegistroViewModel.cs   # Lógica con CommunityToolkit.Mvvm
├── Views/
│   └── RegistroPage.xaml/.cs  # Vista con compiled bindings
├── MauiProgram.cs             # Inyección de dependencias
└── App.xaml.cs                # Punto de entrada
```

## Capturas

### Formulario de Registro
*(Captura del formulario vacío con los campos Nombre, Correo, Teléfono, Carrera y Fecha)*

### Lista de Estudiantes
*(Captura con estudiantes registrados en el CollectionView)*

## Tecnologías

- .NET MAUI (.NET 10)
- CommunityToolkit.Mvvm 8.4.0
- Compiled Bindings (x:DataType)
- CollectionView con ObservableCollection
