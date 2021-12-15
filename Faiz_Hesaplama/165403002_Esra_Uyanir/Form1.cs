using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _165403002_Esra_Uyanir
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
         
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            if (comboBox1.SelectedIndex == 0 || comboBox1.SelectedIndex == 1)
            {
                comboBox2.Items.Add("3");
                comboBox2.Items.Add("6");
                comboBox2.Items.Add("9");
                comboBox2.Items.Add("12");
                comboBox2.Items.Add("18");
                comboBox2.Items.Add("24");
            }
            if (comboBox1.SelectedIndex == 2)
            {
                comboBox2.Items.Add("12");
                comboBox2.Items.Add("24");
                comboBox2.Items.Add("36");
                comboBox2.Items.Add("48");
                comboBox2.Items.Add("60");
            }
        }
        
        
        private void button1_Click(object sender, EventArgs e)
        {
            double anapara, faiz, ayliktkst, faiztutar, taksitanapara;
            int vade;

            anapara = double.Parse(textBox2.Text);
            faiz = double.Parse(textBox3.Text);
            vade = int.Parse(comboBox2.Text);
            faiz = faiz / 100;  //faizimizin yüzdesini aldık

            int x = 0;

            ayliktkst = anapara * ((faiz * Math.Pow((faiz + 1), vade)) / (Math.Pow((1 + faiz), vade) - 1));

            dataGridView1.RowCount = vade;

            for (int i = 0; i < vade; i++)
            {
                x = x + 1;

                faiztutar = anapara * faiz;
                taksitanapara = ayliktkst - faiztutar;
                anapara = anapara - taksitanapara;

                dataGridView1.Rows[i].Cells[0].Value = x;
                dataGridView1.Rows[i].Cells[1].Value = Math.Round(ayliktkst, 2);
                dataGridView1.Rows[i].Cells[2].Value = Math.Round(taksitanapara, 2);
                dataGridView1.Rows[i].Cells[3].Value = Math.Round(faiztutar, 2);
                dataGridView1.Rows[i].Cells[4].Value = Math.Round(anapara, 2);

            }

        }
    }
}
