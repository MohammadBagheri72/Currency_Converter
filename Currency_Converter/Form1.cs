using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ServiceLayer.Services;
using DomainClass.Currencis_Class;
using ServiceLayer.Repositoris;

namespace Currency_Converter
{
    public partial class frmmain : Form
    {
        public frmmain()
        {
            InitializeComponent();
        }
        ICurrency_Rep currencuservice = new Currency_Service();
        ICurrencyConverter_Rep currencyconvert = new CurrencyConverter_Service();
        public void DataLoad()
        {
            dgcurrencis.DataSource = currencuservice.GetAllCurrencis();
            cmbstart.DataSource = currencuservice.GetAllCurrencis();
            cmbstart.DisplayMember = "Name";
            cmbstart2.DataSource = currencuservice.GetAllCurrencis();
            cmbstart2.DisplayMember = "Name";
            cmbend.DataSource = currencuservice.GetAllCurrencis();
            cmbend.DisplayMember = "Name";
            cmbend2.DataSource = currencuservice.GetAllCurrencis();
            cmbend2.DisplayMember = "Name";
            dgconfig.DataSource = currencyconvert.GetAllConfig();
            
        }
        private void frmmain_Load(object sender, EventArgs e)
        {
            DataLoad();
        }

        private void btnAddCurrency_Click(object sender, EventArgs e)
        {
            Currencis currency = new Currencis(); 
            currency.Name = txtcurrency.Text;
          if(  currencuservice.AddCurrency(currency) == 0)
            {
                DataLoad();
            }else if(currencuservice.AddCurrency(currency) == 1)
            {
                MessageBox.Show("The Currency is Inuse...");
            }
            else
            {
                MessageBox.Show("Cant Added ...");
            }

            txtcurrency.Clear();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                var id = dgcurrencis.SelectedCells[0].Value.ToString();
                if (id != null)
                {
                    if (currencuservice.DeleteCurrency(id))
                    {
                        DataLoad();
                    }
                    else
                    {
                        MessageBox.Show("have a problem");
                    }
                }
               
            }
            catch 
            {

                MessageBox.Show("please select a row ...");
            }
       
        }

        private void btnconfig_Click(object sender, EventArgs e)
        {
            var convers = Tuple.Create(cmbstart.Text, cmbend.Text, double.Parse(txtamont.Text));
            var convers2 = Tuple.Create(cmbend.Text, cmbstart.Text, 1 / double.Parse(txtamont.Text));
            int res = currencyconvert.UpdateConfiguration(convers);
            if(res == 0)
            {
                DataLoad();
                int res2 = currencyconvert.UpdateConfiguration(convers2);
                if(res2 == 0)
                {
                    DataLoad();
                }
            }else if (res == 1)
            {
                MessageBox.Show("cinfig inuse ...");
            }
            else
            {
                MessageBox.Show("can not added ...");
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            currencyconvert.ClearConfiguration();
            DataLoad();
        }

        private void btnconvert_Click(object sender, EventArgs e)
        {
            
         var res= currencyconvert.BFSConvert(currencyconvert.GetAllConfig(),cmbstart2.Text, cmbend2.Text, double.Parse(txtcount.Text));
            txtrout.Text = res.Rout.ToString();
            txtres.Text = res.Amount.ToString();
        }
    }
}
