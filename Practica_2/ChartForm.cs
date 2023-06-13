using System;
using System.Windows.Forms;

using System.Windows.Forms.DataVisualization.Charting;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;

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
        
        private void BttnShowChart_Click(object sender, EventArgs e)
        {
            // Вызываем метод LoadDataFromDataGridView, передавая объект dataGridView1
            DataChartForm.LoadDataFromDataGridView(dataGridView, chart1);
        }

        private void BttnReturn_Click(object sender, EventArgs e)
        {
            form1.Show();
            this.Close();
        }

        private void SaveChartDOCX_Click(object sender, EventArgs e)
        {
            /*// Создаем документ Word
            using (WordprocessingDocument doc = WordprocessingDocument.Create("CHART.docx", WordprocessingDocumentType.Document))
            {
                // Добавляем раздел в документ
                MainDocumentPart mainPart = doc.AddMainDocumentPart();
                mainPart.Document = new Document();

                // Добавляем область для рисования графика
                Drawing drawing = new Drawing();
                mainPart.Document.Body.Append(drawing);

                // Получаем изображение графика
                using (var stream = new System.IO.MemoryStream())
                {
                    chart1.SaveImage(stream, ChartImageFormat.Png);

                    // Создаем элемент для изображения
                    var imagePart = mainPart.AddImagePart(ImagePartType.Png);
                    imagePart.FeedData(stream);

                    // Создаем элемент для изображения и добавляем ссылку на него
                    var element = new DrawingElement(new DW.Picture(
                        new DW.NonVisualPictureProperties(
                            new DW.NonVisualDrawingProperties()
                            {
                                Id = 1,
                                Name = "Chart"
                            },
                            new DW.NonVisualPictureDrawingProperties()),
                        new DW.BlipFill(
                            new DW.Blip()
                            {
                                Embed = mainPart.GetIdOfPart(imagePart),
                                CompressionState = DW.BlipCompressionValues.Print
                            },
                            new DW.Stretch(new DW.FillRectangle())),
                        new DW.ShapeProperties(new A.Transform2D(new A.Offset() { X = 0, Y = 0 }, new A.Extents() { Cx = 9144000, Cy = 4572000 }), new A.PresetGeometry(new A.AdjustValueList()) { Preset = A.ShapeTypeValues.Rectangle })));

                    // Добавляем элемент в область рисования
                    drawing.Append(element);
                }

                // Сохраняем документ
                mainPart.Document.Save();
            }

            MessageBox.Show("График успешно сохранен в файле CHART.docx");*/

        }
    }
}
