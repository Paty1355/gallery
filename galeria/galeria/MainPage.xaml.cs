using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace galeria
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        int i = 1;
        private void poprzedni (object sender, EventArgs e)
        {
            i++;
            if (i == 4) i = 1;
            adres(i);
        }
        private void nastepny (object sender, EventArgs e)
        {
            i--;
            if (i == 0) i = 3;
            adres(i);
        }
        private void adres (int i)
        {
            string adres = "kot" + i.ToString() + ".jpg";
            img.Source = ImageSource.FromFile(adres);
        }
        private void which_picture(object sender,EventArgs e)
        {
            if(ktore.Text != string.Empty && ktore.Text != "." && ktore.Text != ",")
            {
                int a = Int32.Parse(ktore.Text);
                if (a == 1 || a == 2 || a == 3) adres(a);
            }
        }
        private void switch_background(object sender, EventArgs e)
        {
            if(zmiana.IsToggled == true)
            {
                bg.BackgroundColor = Color.Blue;
            }
            else
            {
                bg.BackgroundColor = Color.FromHex("00796B");
            }
        }
    }
}
