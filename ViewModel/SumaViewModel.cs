using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Windows.Input;

namespace SumaAppMvvm.ViewModels;

public partial class SumaViewModel : ObservableObject
{
    [ObservableProperty]
    private string numero1;

    [ObservableProperty]
    private string numero2;

    [ObservableProperty]
    private string resultado;

    [RelayCommand]
    private void Sumar()
    {
        if (string.IsNullOrWhiteSpace(Numero1) || string.IsNullOrWhiteSpace(Numero2))
        {
            Resultado = "Debe ingresar ambos números.";
            return;
        }

        if (double.TryParse(Numero1, out double n1) && double.TryParse(Numero2, out double n2))
        {
            Resultado = $"Resultado: {n1 + n2}";
        }
        else
        {
            Resultado = "Ingrese solo valores numéricos válidos.";
        }
    }

    [RelayCommand]
    private void Limpiar()
    {
        Numero1 = string.Empty;
        Numero2 = string.Empty;
        Resultado = string.Empty;
    }
}
