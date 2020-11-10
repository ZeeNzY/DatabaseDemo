using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseDemo.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DatabaseDemo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        void SignInProcedure(Object sender, EventArgs e)
        {
            // User user = new User(Entry_Username.Text, Entry_Password.Text);
            // if (user.CheckInformation())
            //  {
            //      DisplayAlert("");
            //  }
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            User user = new User(UsernameEntry.Text, PasswordEntry.Text);
            if (user.CheckInformation())
            {
                DisplayAlert("Login", "Login Success.", "Okay");
                App.UserDatabase.SaveUser(user);
            }
            else
            {
                DisplayAlert("Login", "Login unsuccessfull.", "Okay");
            }
           // {
           //     Username = UsernameEntry.Text,
           //     Password = PasswordEntry.Text
           // };
          //  DisplayAlert("Login","Login Success.", "Okay");
        }
    }

}