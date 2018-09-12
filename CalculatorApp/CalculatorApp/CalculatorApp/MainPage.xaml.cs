using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CalculatorApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public void ButtonClicked(object sender, System.EventArgs e)
        {
            switch (((Button)sender).Text)
            {
                case "+":
                    this.lblResult.Text = (double.Parse(this.txtX.Text) + double.Parse(this.txtY.Text)).ToString();
                    break;
                case "-":
                    lblResult.Text = (string)(double.Parse(txtX.Text) - double.Parse(txtY.Text)).ToString();
                    break;
                case "*":
                    lblResult.Text = (string)(double.Parse(txtX.Text) * double.Parse(txtY.Text)).ToString();
                    break;
                case "/":
                    lblResult.Text = (double.Parse(txtX.Text) / double.Parse(txtY.Text)).ToString();
                    break;
            }
        }
    }

}
