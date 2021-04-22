using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace T1S3AndresRamos
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1(String user, String password)
        {
            InitializeComponent();
        }
        private void TextChanged(object sender, TextChangedEventArgs e)
        {
            txtNotaParcial1.Text = ((float.Parse("0" + txtNotaSeguimiento1.Text) * 0.3) + (float.Parse("0" + txtNotaExamen1.Text) * 0.2)).ToString();
            txtNotaParcial2.Text = ((float.Parse("0" + txtNotaSeguimiento2.Text) * 0.3) + (float.Parse("0" + txtNotaExamen1.Text) * 0.2)).ToString();
            txtNotaFinal.Text = (float.Parse("0" + txtNotaParcial1.Text) + float.Parse("0" + txtNotaParcial2.Text)).ToString();
        }
    }
}