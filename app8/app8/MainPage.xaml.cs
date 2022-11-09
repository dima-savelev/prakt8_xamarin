using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace app8
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            dateBirth.MaximumDate = DateTime.Now.Date;
        }

        private void dateBirth_DateSelected(object sender, DateChangedEventArgs e)
        {
            int age = DateTime.Now.Year - dateBirth.Date.Year;
            ageText.Text = "Возраст - " + age.ToString();
        }

        private async void addPhoto_Clicked(object sender, EventArgs e)
        {
            try
            {
                var options = new PickOptions
                {
                    PickerTitle = "Выберите картинку",
                    FileTypes = FilePickerFileType.Images,
                };
                var result = await FilePicker.PickAsync(options);
                image.ImageSource = result.FullPath;
            }
            catch { };
        }
    }
}
