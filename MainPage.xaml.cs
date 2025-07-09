using AppIntegradora10A.Views;

namespace AppIntegradora10A
{
    public partial class MainPage : ContentPage
    {
        private object emailEntry;

        public MainPage()
        {
            InitializeComponent();
             
        }


        private async void OnAddProduct_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddProductPage());
        }

        private async void OnListProduct_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ListProductPage());
        }
        //AUTHENTICACION 
       /* private async void OnLogin_Clicked(object sender, EventArgs e)
        {
            string email = emailEntry.Text;
            string password = passwordEntry.Text;

            if (string.IsNullOrEmpty(email))
            {
                await DisplayAlert("AVISO", "Debe escribir un correo electronico", "OK");
                return;
            }

            if (string.IsNullOrEmpty(password))
            {
                await DisplayAlert("Aviso", "Debe escribir la contraseña", "OK");
                return;
            }

            //Validar la longitud de la contraseña

            if (password.Length < 6)
            {
                await DisplayAlert("ERROR", "La contrase;a debe contener minimo seis caracteres", "OK");
                return;
            }

            var authService = new FirebaseAuthService();
            var user = await authService.SignInWithEmailAndPasswordAsync(email, password);

            if (user != null)
            {
                await DisplayAlert("Exito", $"Bienvenido, {user.Email}", "OK");
                //Guardar token: user.IdToken

                //await Navigation.PushAsync(new Inicio());
            }
            else
            {
                await DisplayAlert("Error", "Credenciales incorrectas", "OK");
            }
        }



        private async void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
        {
            string email = emailEntry.Text;
            string password = passwordEntry.Text;

            var authService = new FirebaseAuthService();
            var user = await authService.RegisterWithEmalAndPasswordAsync(email, password);

            if (user != null)
            {
                await DisplayAlert("Registro exitoso", $"Cuenta creada para:{user.Email}", "OK");
                //Guardar token o redirigir a la siguiente pantalla
            }
            else
            {
                await DisplayAlert("Error", "No se pudo registrar. Verifica los datos.", "OK");
            }
        } */














    }


}



