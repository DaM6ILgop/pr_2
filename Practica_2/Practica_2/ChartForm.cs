using System;
using System.Windows.Forms;




namespace Practica_2
{
    public partial class ChartForm : Form
    {
        private DataGridView dataGridView;

        //Запись формы в текущем месте 
        Form1 form1;

        public ChartForm(DataGridView dataGridView, Form1 form1)
        {
            InitializeComponent();

            this.dataGridView = dataGridView;

            //Установка переданного значения Form1 в локальную переменную
            this.form1 = form1;
        }
        
       

        private void BttnReturn_Click(object sender, EventArgs e)
        {
            form1.Show();
            this.Close();
        }

        private void SaveChartDOCX_Click(object sender, EventArgs e){}

        private void ChartForm_Load(object sender, EventArgs e)
        {
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;

            // Вызываем метод LoadDataFromDataGridView, передавая объект dataGridView1
            //Отрисовка графика при загрузке формы
            DataChartForm.LoadDataFromDataGridView(dataGridView, chart1);
        }
    }
}
