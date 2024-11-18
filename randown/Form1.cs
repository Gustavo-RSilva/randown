using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace randown
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnM_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int[] numeros = new int[10];
            Random random = new Random();
            for (int i = 0; i <10; i++)
            {
                numeros[i] = random.Next(1,100);
                
                
            }
            Array.Sort(numeros);
            foreach (int ordem in numeros) 
            {
                listBox1.Items.Add(ordem);

            }
        }
    }
}
