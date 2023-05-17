using System.Net.Http.Json;

namespace E4mini_Admin_tool
{
    public partial class Form1 : Form
    {
        FormValCr fvc = new FormValCr();
        FormTorgPar fTP = new FormTorgPar();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
      
        private void tprgPars_Click(object sender, EventArgs e)
        {
        
            fTP.Show();
        }

        private void mon_Click(object sender, EventArgs e)
        {
            //кнопка Создать новую валюту вызывает окно с вводом данных валюты
            fvc.Show();
        }
    }
}