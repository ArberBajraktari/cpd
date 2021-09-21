using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Homework
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void AddButton_Clicked(System.Object sender, System.EventArgs e)
        {
            Result.Text =( int.Parse(Entry1.Text) + int.Parse(Entry2.Text)).ToString();
        }
    }
}




