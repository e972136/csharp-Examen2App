using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;


namespace examen2.ViewModels
{
    internal partial class AreaRectanguloView : ObservableObject
    {

        [ObservableProperty]
        private String? baseRectangulo;

        [ObservableProperty]
        private String? alturaRectangulo;

        [ObservableProperty]
        private String? respuesta;

        [RelayCommand]
        public void Calcular()
        {
            if (BaseRectangulo == null || !double.TryParse(BaseRectangulo, out double b))
            {
                Respuesta = "Problema con la base";
                return;
            }

            if (AlturaRectangulo == null || !double.TryParse(AlturaRectangulo, out double a))
            {
                Respuesta = "Problema con la altura";
                return;
            }

            Respuesta = (b*a) + "";

        }

        [RelayCommand]
        public void Limpiar()
        {
            BaseRectangulo = "";
            AlturaRectangulo = "";
            Respuesta = "";
        }
    }
}
