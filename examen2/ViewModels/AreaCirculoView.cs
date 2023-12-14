using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace examen2.ViewModels
{
    internal partial class AreaCirculoView: ObservableObject
    {
        [ObservableProperty]
        private String? radio;

        [ObservableProperty]
        private String? respuesta;

        [RelayCommand]
        public void Calcular()
        {
            if(Radio == null || !double.TryParse(Radio, out double r))
            {
                Respuesta = "Problema con el Radio";
                return;
            }

            Respuesta = (r * r * Math.PI) + "";

        }

        [RelayCommand]
        public void Limpiar()
        {
            Radio = "";
            Respuesta = "";           
        }    

    }
}
