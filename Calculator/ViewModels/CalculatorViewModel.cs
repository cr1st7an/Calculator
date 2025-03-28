using Calculator.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Calculator.ViewModels
{
    public partial class CalculatorViewModel : ObservableObject
    {
        private readonly Operation _operation = new();

        // Propiedades para los números de entrada
        [ObservableProperty]
        private string numero1;

        [ObservableProperty]
        private string numero2;

        // Propiedad para el resultado
        [ObservableProperty]
        private string resultado;

        // Comando para la suma
        [RelayCommand]
        private void Sumar()
        {
            try
            {
                int num1 = ValidarYConvertirNumero(Numero1);
                int num2 = ValidarYConvertirNumero(Numero2);
                Resultado = _operation.Sumar(num1, num2).ToString();
            }
            catch (Exception ex)
            {
                Resultado = $"Error: {ex.Message}";
            }
        }

        // Comando para la resta
        [RelayCommand]
        private void Restar()
        {
            try
            {
                int num1 = ValidarYConvertirNumero(Numero1);
                int num2 = ValidarYConvertirNumero(Numero2);
                Resultado = _operation.Restar(num1, num2).ToString();
            }
            catch (Exception ex)
            {
                Resultado = $"Error: {ex.Message}";
            }
        }

        // Comando para la multiplicación
        [RelayCommand]
        private void Multiplicar()
        {
            try
            {
                int num1 = ValidarYConvertirNumero(Numero1);
                int num2 = ValidarYConvertirNumero(Numero2);
                Resultado = _operation.Multiplicar(num1, num2).ToString();
            }
            catch (Exception ex)
            {
                Resultado = $"Error: {ex.Message}";
            }
        }

        // Comando para la división
        [RelayCommand]
        private void Dividir()
        {
            try
            {
                int num1 = ValidarYConvertirNumero(Numero1);
                int num2 = ValidarYConvertirNumero(Numero2);
                Resultado = _operation.Dividir(num1, num2).ToString();
            }
            catch (Exception ex)
            {
                Resultado = $"Error: {ex.Message}";
            }
        }

        // Método de validación y conversión
        private int ValidarYConvertirNumero(string textoNumero)
        {
            if (!int.TryParse(textoNumero, out int numero))
                throw new ArgumentException("Por favor, introduce un número válido.");

            if (!_operation.EsMultiploDe5(numero))
                throw new ArgumentException($"El número {numero} no es múltiplo de 5.");

            return numero;
        }
    }
}
