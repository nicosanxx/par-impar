using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace par_impar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_numbr.Text != "")
            {
                int numero = Convert.ToInt32(txt_numbr.Text);
                int resto;
                resto = numero % 2;
                
    
                
                if (resto == 0)
                {

                    lb_result.Text = "Par";


                }

                else
                {

                    lb_result.Text = "Impar";
                }
            }
            else
                
            {

                    MessageBox.Show("Favor Preencher Corretamente", "ATENÇÃO!!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }




                
            
        }
    }
}
