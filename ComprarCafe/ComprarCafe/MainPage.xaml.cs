using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ComprarCafe
{
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public int Quantidade { get; set; }
        public Double Total { get; set; }
        public Double ValoUnitario { get; set; }

        public MainPage()
        {
            InitializeComponent();
            this.Quantidade = 0;
            this.ValoUnitario = 5; 
            this.Total = 0; 
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            var pressed = button.Text;
            if(pressed == "-")
            {
                if(this.Quantidade > 0)
                {
                    this.Quantidade--;
                }
            } else
            {
                this.Quantidade++;
            }
            this.Total = this.Quantidade * this.ValoUnitario;
            label_mainpage_total.Text = "Total: R$ " + Total.ToString();
            label_mainpage_qtd.Text = "Quantidade: " + Quantidade.ToString();
        }
    }
}
