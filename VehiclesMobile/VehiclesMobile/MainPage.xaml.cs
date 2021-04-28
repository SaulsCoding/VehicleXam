using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Vehicles;

namespace VehiclesMobile
{
    public partial class MainPage : ContentPage
    {
        private Car _mazda323;
        public MainPage()
        {
            
            InitializeComponent();
            _mazda323 = new Car();
            _mazda323.Make = "Mazda";

            CarMakeLabel.Text = _mazda323.Make;
            
        }

        private void DriveFasterButton_Clicked(object sender, EventArgs e)
        {
            _mazda323.DriveFaster(50);
            CarSpeedLabel.Text = _mazda323.Speed.ToString();//Speed property that is an integer
        }

        
    }
}
