using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace AppAutentificacion10A
{
    public class FirebaseAuthService
    {
        private readonly string apiKey = "AIzaSyBsVUW3yuMCvUyb_Mb10XlVm4osZSth8tM";

        public async Task<FirebaseAuthResponse?> SignInWithEmailAndPasswordAsync(string email, string password)


        {

            var httpClien = new HttpClient();

            var requestBody = new
            {
                email,
                password,
                returnSecureToken = true



            };

            string json = JsonSerializer.Serialize(requestBody);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            string url = $"https://identitytoolkit.googleapis.com/v1/accounts:signInWithPassword?key=[API_KEY]={apiKey}";



            var response = await httpClien.PostAsync(url, content);

            if (response.IsSuccessStatusCode)

            {
                string result = await response.Content.ReadAsStringAsync();
                var authData = JsonSerializer.Deserialize<FirebaseAuthResponse>(result);
                return authData;

            }


            else
            {
                string error = await response.Content.ReadAsStringAsync();
                Console.WriteLine("Error: " + error);
                return null;
            }






        }



        public async Task<FirebaseAuthResponse?> RegisterWithEmalAndPasswordAsync(string email, string password)

        {
            var httpClien = new HttpClient();

            var requestBody = new
            {
                email,
                password,
                returnSecureToken = true



            };

            string json = JsonSerializer.Serialize(requestBody);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            string url = $"https://identitytoolkit.googleapis.com/v1/accounts:signUp?key=[API_KEY]={apiKey}";


            var response = await httpClien.PostAsync(url, content);


            if (response.IsSuccessStatusCode)

            {
                string result = await response.Content.ReadAsStringAsync();
                var authData = JsonSerializer.Deserialize<FirebaseAuthResponse?>(result);
                return authData;


            }

            else
            {
                string error = await response.Content.ReadAsStringAsync();
                Console.WriteLine("Error al registrar: " + error);
                return null;



            }






        }






    }




}