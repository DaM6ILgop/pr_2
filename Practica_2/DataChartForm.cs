using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Practica_2
{
    class DataChartForm
    {
        
        public static void LoadDataFromDataGridView(DataGridView dataGridView, Chart chart)
        {
            chart.Series.Clear();
            if (dataGridView.Rows.Count > 0)
            {
                foreach (DataGridViewColumn column in dataGridView.Columns)
                {
                    if (column.Name != "Region" && column.Name != "Country")
                    {
                        Series series = new Series(column.Name);
                        series.ChartType = SeriesChartType.Column;

                        foreach (DataGridViewRow row in dataGridView.Rows)
                        {
                            // Проверка таблицы на NULL
                            string country = row.Cells["Country"].Value != null ? row.Cells["Country"].Value.ToString() : string.Empty;

                            double value = Convert.ToDouble(row.Cells[column.Name].Value);
                            series.Points.AddXY(country, value);
                        }

                        chart.Series.Add(series);
                    }
                }
            }
            else {
                MessageBox.Show("График не может быть заполнен! /nТаблица пуста");
            }

            chart.Legends.Clear();
            chart.ChartAreas[0].AxisX.Interval = 1;
        }

    }
}
