using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_2
{
    class Files
    {
        //Создание файла формата scv 
        internal static void CreateFile_SCV() 
        {
            string fileName = "praktika.csv";
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), fileName);

            if (File.Exists(filePath))
            {
                MessageBox.Show($"Файл {filePath} уже создан!");
            }
            else { 

                try
                {
                    using (FileStream fileStream = File.Create(filePath))
                    {
                        MessageBox.Show($"Файл {filePath} успешно создан.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при создании файла: {ex.Message}");
                }
            }
        }

        //Запись данных dataGridView1 в файл формата scv
        internal static void WriteToFile(string filePath, DataGridView dataGridView1) 
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    // Запись заголовков столбцов
                    for (int i = 0; i < dataGridView1.ColumnCount; i++)
                    {
                        writer.Write(dataGridView1.Columns[i].HeaderText);
                        writer.Write("\t");
                    }
                    writer.WriteLine();

                    // Запись данных строк
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        for (int i = 0; i < dataGridView1.ColumnCount; i++)
                        {
                            writer.Write(row.Cells[i].Value);
                            writer.Write("\t");
                        }
                        writer.WriteLine();
                    }
                }
                MessageBox.Show($"Данные успешно записаны в файл {filePath}.");       
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при записи в файл: {ex.Message}");
            }
        }

        //Чтение данных из файла
        internal static void ReadFromFile(DataGridView dataGridView1, string filePath)
        {
            //Очистка dataGridView1 перед запуском чтения
            dataGridView1.Rows.Clear();
            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    // Читаем заголовки столбцов
                    string headerLine = reader.ReadLine();
                    string[] headers = headerLine.Split('\t');

                    // Добавляем столбцы в dataGridView1
                    dataGridView1.ColumnCount = headers.Length;
                    for (int i = 0; i < headers.Length; i++)
                    {
                        dataGridView1.Columns[i].HeaderText = headers[i];
                        
                    }

                    // Читаем данные строк
                    while (!reader.EndOfStream)
                    {
                        string dataLine = reader.ReadLine();
                        string[] values = dataLine.Split('\t');

                        // Добавляем новую строку в dataGridView1                       
                         Upload _upload = new Upload();
                        _upload.region = values[0];

                        _upload.country = values[1];
                        _upload.theatres = Convert.ToDouble(values[2]);
                        _upload.cinema = Convert.ToDouble(values[3]);
                        _upload.stadium = Convert.ToDouble(values[4]);
                        Form1.list.Add(_upload);
                    }
                }

                Console.WriteLine($"Данные успешно считаны из файла {filePath}.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при чтении файла: {ex.Message}");
            }
        }
    }
}
