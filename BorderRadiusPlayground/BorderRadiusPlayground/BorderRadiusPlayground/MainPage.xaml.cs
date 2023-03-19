using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BorderRadiusPlayground
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        void ChangeCornerRadius(float topLeft, float topRight, float bottomLeft, float bottomRight)
        {
            Playground.CornerRadius = new CornerRadius(topLeft, topRight, bottomLeft, bottomRight);
        }
        public void CornerOneChanged(object sender, EventArgs e)
        {
            float ratio = (float)Playground.WidthRequest / (float)TopLeft.Maximum;
            ChangeCornerRadius((float)TopLeft.Value*ratio, (float)TopRight.Value * ratio, (float)BottomLeft.Value * ratio, (float)BottomRight.Value * ratio);
            //Playground.CornerRadius = e.NewSliderValue;
        }
        public void CornerTwoChanged(object sender, EventArgs e)
        {

        }
        public void CornerThreeChanged(object sender, EventArgs e)
        {

        }
        public void CornerFourChanged(object sender, EventArgs e)
        {

        }
    }
}
