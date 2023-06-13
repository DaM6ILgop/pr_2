using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace Practica_2
{
    public partial class Form1 : Form
    {
        //Путь к файлу
        internal static string filePath = @"C:\Users\Lenovo\Desktop\2 КУРС -2 СЕМЕСТР\Учебная практика\Practica_2\bin\Debug\praktika.csv";
        
        //List объектов upload. Хранит данные, которые добавляет пользователь из формы Add_Item
        internal static List<Upload> list = new List<Upload>();

        

        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        /*//Метод для передачи значений dataGridView1 в форму добавления записи
        private void OpenAddItemForm()
        {
            Add_Item addItemForm = new Add_Item(this);
            
        }*/

        //Функция чтения из БД
        private void button1_Click(object sender, EventArgs e)
        {

            string connectionString = @"provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Lenovo\Desktop\2 КУРС -2 СЕМЕСТР\Учебная практика\Practica_2\bin\Debug\ForSCV_File.mdb";
            
                // Создание объекта подключения
                OleDbConnection connection = new OleDbConnection(connectionString);
                // Открытие соединения
                connection.Open();

                // Выполнение запроса
                string query = "SELECT * FROM Таблица1";
                OleDbCommand command = new OleDbCommand(query, connection);
                OleDbDataReader reader = command.ExecuteReader();
                
                //Очистка формы перед чтением данных
                dataGridView1.Rows.Clear();

                if (reader.HasRows == false){
                    MessageBox.Show("Данные не были считаны", "Ошибка!");
                }
                else { 

                     //Записываем данные в таблицу
                     while (reader.Read())
                     {
                        // Получение данных из результатов запроса                    
                        dataGridView1.Rows.Add(reader["Регионы"], reader["Страны"], reader["Театры"], reader["Кинотеатры"], reader["Стадионы"]);
                   
                     }
                }

                // Закрытие объектов чтения и команды
                reader.Close();
                connection.Close();     
        }


        //Кнопка создания SCV файла 
        private void CreateFile_Click(object sender, EventArgs e)
        {
            Files.CreateFile_SCV();
        }


        //Кнопка добавления в файл 
        private void BttnWriteToFile_Click(object sender, EventArgs e)
        {
            Files.WriteToFile(filePath, dataGridView1);
        }


        //Вызов чтения данных из файла при запуске программы
        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshDataGrid();
        }


        //Кнопка очистки dataGridView1
        private void ClearDataGrid_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            list.Clear();
        }


        //Обновление таблицы через лист
        public void RefreshDataGrid()
        {
            dataGridView1.Rows.Clear();
            foreach (Upload upload in list)
            {
                dataGridView1.Rows.Add(upload.region, upload.country, upload.theatres, upload.cinema, upload.stadium);
            }
        }


        //Вызов формы для добавления записи без использования БД
        private void Add_entry_Click(object sender, EventArgs e)
        {
            Add_Item add = new Add_Item(this);
            add.Show();
            this.Hide();
        }


        private void BttnReadFromFile_Click(object sender, EventArgs e)
        {
            if (File.Exists(filePath))
            {
                // Вызываем метод чтения файла
                Files.ReadFromFile(dataGridView1, filePath);
                RefreshDataGrid();
            }
            else
            {
                MessageBox.Show("Файл не найден!");
            }
        }

        private void BttnEditor_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                //Индекс выбранного поля
                int selectedIndex = dataGridView1.SelectedRows[0].Index;
               
                if (selectedIndex >= 0 && selectedIndex < list.Count)
                {
                    // Удаление выбранной записи из List
                    list.RemoveAt(selectedIndex);

                    // Удаление выбранной записи в dataGridView1
                    dataGridView1.Rows.RemoveAt(selectedIndex);
                }
            }
        }

        private void CountryMaxStadium_Click(object sender, EventArgs e)
        {
            string maxAttendanceCountry = "";
            double maxAttendance = 0.0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                double attendance = Convert.ToDouble(row.Cells["Stadium"].Value);

                if (attendance > maxAttendance)
                {
                    maxAttendance = attendance;
                    maxAttendanceCountry = row.Cells["Country"].Value.ToString();
                }
            }

            if (maxAttendanceCountry != "")
            {
                MessageBox.Show($"Страна с наибольшей посещаемостью стадионов: {maxAttendanceCountry}");
            }
            else
            {
                MessageBox.Show("Нет данных о посещаемости стадионов.");
            }
        }

        private void CinemaTheatres_Click(object sender, EventArgs e)
        {
            string countriesText = "";

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                double theaterAttendance = Convert.ToDouble(row.Cells["Theatres"].Value);
                double cinemaAttendance = Convert.ToDouble(row.Cells["Cinema"].Value);

                if (theaterAttendance > 0.30 || cinemaAttendance > 0.30)
                {
                    string country = row.Cells["Country"].Value.ToString();
                    countriesText += country + ", ";
                }
            }

            if (!string.IsNullOrEmpty(countriesText))
            {
                countriesText = countriesText.TrimEnd(',', ' '); // Удаляем последнюю запятую и пробел
                MessageBox.Show($"Страны с посещением театров или кинотеатров выше 30%: {countriesText}");
            }
            else
            {
                MessageBox.Show("Нет стран, удовлетворяющих условию.");
            }
        }

        private void TheatresMoreCinema_Click(object sender, EventArgs e)
        {
            string countriesText = "";
            bool foundCountries = false;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                double theaterAttendance = Convert.ToDouble(row.Cells["Theatres"].Value);
                double cinemaAttendance = Convert.ToDouble(row.Cells["Cinema"].Value);

                string country = row.Cells["Country"].Value?.ToString();

                if (theaterAttendance > cinemaAttendance)
                {
                    countriesText += country + "\n";
                    foundCountries = true;
                }
            }

            if (foundCountries)
            {
                MessageBox.Show($"Страны, где посещение театров превышает посещение кинотеатров: {countriesText}");
            }
            else
            {
                MessageBox.Show("Нет стран, где посещение театров превышает посещение кинотеатров.");
            }
        }

       

        private void BttnDrawChart_Click(object sender, EventArgs e)
        {
            ChartForm chartForm = new ChartForm(dataGridView1, this);

            chartForm.Show();
            this.Hide();
        }
    }
}
