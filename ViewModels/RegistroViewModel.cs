using System.Collections.ObjectModel;
using System.Text.RegularExpressions;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using RegistroEstudiantesMVVM.Models;

namespace RegistroEstudiantesMVVM.ViewModels;

public partial class RegistroViewModel : ObservableObject
{
    [ObservableProperty]
    [NotifyCanExecuteChangedFor(nameof(GuardarCommand))]
    private string nombre = string.Empty;

    [ObservableProperty]
    [NotifyCanExecuteChangedFor(nameof(GuardarCommand))]
    private string correo = string.Empty;

    [ObservableProperty]
    [NotifyCanExecuteChangedFor(nameof(GuardarCommand))]
    private string telefono = string.Empty;

    [ObservableProperty]
    [NotifyCanExecuteChangedFor(nameof(GuardarCommand))]
    private string carrera = string.Empty;

    [ObservableProperty]
    private DateTime fecha = DateTime.Now;

    public ObservableCollection<Estudiante> Estudiantes { get; } = new();

    private bool PuedeGuardar()
    {
        return !string.IsNullOrWhiteSpace(Nombre)
            && !string.IsNullOrWhiteSpace(Correo)
            && Regex.IsMatch(Correo.Trim(), @"^[^@\s]+@[^@\s]+\.[^@\s]+$")
            && !string.IsNullOrWhiteSpace(Telefono)
            && !string.IsNullOrWhiteSpace(Carrera);
    }

    [RelayCommand(CanExecute = nameof(PuedeGuardar))]
    private void Guardar()
    {
        Estudiantes.Add(new Estudiante
        {
            Nombre = Nombre.Trim(),
            Correo = Correo.Trim(),
            Telefono = Telefono.Trim(),
            Carrera = Carrera.Trim(),
            Fecha = Fecha
        });

        Nombre = string.Empty;
        Correo = string.Empty;
        Telefono = string.Empty;
        Carrera = string.Empty;
        Fecha = DateTime.Now;
    }
}
