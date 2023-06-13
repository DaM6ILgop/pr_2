using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_2
{
    public partial class Add_Item : Form
    {
        Form1 form1;

        public Add_Item(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void BttnAddItem_Click(object sender, EventArgs e)
        {
            Upload upload = new Upload();

            upload.region = textBox1.Text;
            upload.country = textBox2.Text;
            double theatresValue;
            if (double.TryParse(textBox3.Text, out theatresValue))
            {
                upload.theatres = theatresValue;
            }
            else
            {
                MessageBox.Show("В ходе преобразования значений что-то пошло не так!");
                return;
            }
            double cinemaValue;
            if (double.TryParse(textBox4.Text, out cinemaValue))
            {
                upload.cinema = cinemaValue;
            }
            else
            {
                MessageBox.Show("В ходе преобразования значений что-то пошло не так!");
                return;
            }
            double stadiumValue;
            if (double.TryParse(textBox5.Text, out stadiumValue))
            {
                upload.stadium = stadiumValue;
            }
            else
            {
                MessageBox.Show("В ходе преобразования значений что-то пошло не так!");
                return;
            }

            /*Form1 = Application.OpenForms.OfType<Form1>().FirstOrDefault();*/
            Form1.list.Add(upload);
            form1.RefreshDataGrid();
            form1.Show();
            this.Hide();
        }

        private void BttnReturn_Click(object sender, EventArgs e)
        {
            form1.Show();
            this.Close();
        }
    }
}
