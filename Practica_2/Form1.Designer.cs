
namespace Practica_2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Region = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Country = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Theatres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cinema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stadium = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateFile = new System.Windows.Forms.Button();
            this.BttnWriteToFile = new System.Windows.Forms.Button();
            this.ClearDataGrid = new System.Windows.Forms.Button();
            this.Add_entry = new System.Windows.Forms.Button();
            this.BttnReadFromFile = new System.Windows.Forms.Button();
            this.BttnEditor = new System.Windows.Forms.Button();
            this.CountryMaxStadium = new System.Windows.Forms.Button();
            this.CinemaTheatres = new System.Windows.Forms.Button();
            this.TheatresMoreCinema = new System.Windows.Forms.Button();
            this.BttnDrawChart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 403);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "Считать из БД";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Region,
            this.Country,
            this.Theatres,
            this.Cinema,
            this.Stadium});
            this.dataGridView1.Location = new System.Drawing.Point(4, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(903, 385);
            this.dataGridView1.TabIndex = 1;
            // 
            // Region
            // 
            this.Region.HeaderText = "Region";
            this.Region.MinimumWidth = 6;
            this.Region.Name = "Region";
            this.Region.Width = 125;
            // 
            // Country
            // 
            this.Country.HeaderText = "Country";
            this.Country.MinimumWidth = 6;
            this.Country.Name = "Country";
            this.Country.Width = 125;
            // 
            // Theatres
            // 
            this.Theatres.HeaderText = "Theatres";
            this.Theatres.MinimumWidth = 6;
            this.Theatres.Name = "Theatres";
            this.Theatres.Width = 125;
            // 
            // Cinema
            // 
            this.Cinema.HeaderText = "Cinema";
            this.Cinema.MinimumWidth = 6;
            this.Cinema.Name = "Cinema";
            this.Cinema.Width = 125;
            // 
            // Stadium
            // 
            this.Stadium.HeaderText = "Stadium";
            this.Stadium.MinimumWidth = 6;
            this.Stadium.Name = "Stadium";
            this.Stadium.Width = 125;
            // 
            // CreateFile
            // 
            this.CreateFile.Location = new System.Drawing.Point(773, 404);
            this.CreateFile.Name = "CreateFile";
            this.CreateFile.Size = new System.Drawing.Size(134, 49);
            this.CreateFile.TabIndex = 2;
            this.CreateFile.Text = "Создать CSV";
            this.CreateFile.UseVisualStyleBackColor = true;
            this.CreateFile.Click += new System.EventHandler(this.CreateFile_Click);
            // 
            // BttnWriteToFile
            // 
            this.BttnWriteToFile.Location = new System.Drawing.Point(773, 572);
            this.BttnWriteToFile.Name = "BttnWriteToFile";
            this.BttnWriteToFile.Size = new System.Drawing.Size(134, 49);
            this.BttnWriteToFile.TabIndex = 3;
            this.BttnWriteToFile.Text = "Запись в файл";
            this.BttnWriteToFile.UseVisualStyleBackColor = true;
            this.BttnWriteToFile.Click += new System.EventHandler(this.BttnWriteToFile_Click);
            // 
            // ClearDataGrid
            // 
            this.ClearDataGrid.Location = new System.Drawing.Point(12, 573);
            this.ClearDataGrid.Name = "ClearDataGrid";
            this.ClearDataGrid.Size = new System.Drawing.Size(134, 48);
            this.ClearDataGrid.TabIndex = 4;
            this.ClearDataGrid.Text = "Очистить таблицу";
            this.ClearDataGrid.UseVisualStyleBackColor = true;
            this.ClearDataGrid.Click += new System.EventHandler(this.ClearDataGrid_Click);
            // 
            // Add_entry
            // 
            this.Add_entry.Location = new System.Drawing.Point(633, 571);
            this.Add_entry.Name = "Add_entry";
            this.Add_entry.Size = new System.Drawing.Size(134, 50);
            this.Add_entry.TabIndex = 5;
            this.Add_entry.Text = "Добавить запись";
            this.Add_entry.UseVisualStyleBackColor = true;
            this.Add_entry.Click += new System.EventHandler(this.Add_entry_Click);
            // 
            // BttnReadFromFile
            // 
            this.BttnReadFromFile.Location = new System.Drawing.Point(493, 571);
            this.BttnReadFromFile.Name = "BttnReadFromFile";
            this.BttnReadFromFile.Size = new System.Drawing.Size(134, 50);
            this.BttnReadFromFile.TabIndex = 6;
            this.BttnReadFromFile.Text = "Читать файл";
            this.BttnReadFromFile.UseVisualStyleBackColor = true;
            this.BttnReadFromFile.Click += new System.EventHandler(this.BttnReadFromFile_Click);
            // 
            // BttnEditor
            // 
            this.BttnEditor.Location = new System.Drawing.Point(353, 571);
            this.BttnEditor.Name = "BttnEditor";
            this.BttnEditor.Size = new System.Drawing.Size(134, 48);
            this.BttnEditor.TabIndex = 7;
            this.BttnEditor.Text = "Удалить запись";
            this.BttnEditor.UseVisualStyleBackColor = true;
            this.BttnEditor.Click += new System.EventHandler(this.BttnEditor_Click);
            // 
            // CountryMaxStadium
            // 
            this.CountryMaxStadium.Location = new System.Drawing.Point(298, 403);
            this.CountryMaxStadium.Name = "CountryMaxStadium";
            this.CountryMaxStadium.Size = new System.Drawing.Size(134, 48);
            this.CountryMaxStadium.TabIndex = 8;
            this.CountryMaxStadium.Text = "Max Стадионы по стране";
            this.CountryMaxStadium.UseVisualStyleBackColor = true;
            this.CountryMaxStadium.Click += new System.EventHandler(this.CountryMaxStadium_Click);
            // 
            // CinemaTheatres
            // 
            this.CinemaTheatres.Location = new System.Drawing.Point(438, 403);
            this.CinemaTheatres.Name = "CinemaTheatres";
            this.CinemaTheatres.Size = new System.Drawing.Size(134, 48);
            this.CinemaTheatres.TabIndex = 9;
            this.CinemaTheatres.Text = "Кино&&Театры>0.30";
            this.CinemaTheatres.UseVisualStyleBackColor = true;
            this.CinemaTheatres.Click += new System.EventHandler(this.CinemaTheatres_Click);
            // 
            // TheatresMoreCinema
            // 
            this.TheatresMoreCinema.Location = new System.Drawing.Point(354, 457);
            this.TheatresMoreCinema.Name = "TheatresMoreCinema";
            this.TheatresMoreCinema.Size = new System.Drawing.Size(165, 47);
            this.TheatresMoreCinema.TabIndex = 10;
            this.TheatresMoreCinema.Text = "Театры>Кинотеатров";
            this.TheatresMoreCinema.UseVisualStyleBackColor = true;
            this.TheatresMoreCinema.Click += new System.EventHandler(this.TheatresMoreCinema_Click);
            // 
            // BttnDrawChart
            // 
            this.BttnDrawChart.Location = new System.Drawing.Point(773, 487);
            this.BttnDrawChart.Name = "BttnDrawChart";
            this.BttnDrawChart.Size = new System.Drawing.Size(134, 47);
            this.BttnDrawChart.TabIndex = 11;
            this.BttnDrawChart.Text = "Перейти к графику";
            this.BttnDrawChart.UseVisualStyleBackColor = true;
            this.BttnDrawChart.Click += new System.EventHandler(this.BttnDrawChart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 633);
            this.Controls.Add(this.BttnDrawChart);
            this.Controls.Add(this.TheatresMoreCinema);
            this.Controls.Add(this.CinemaTheatres);
            this.Controls.Add(this.CountryMaxStadium);
            this.Controls.Add(this.BttnEditor);
            this.Controls.Add(this.BttnReadFromFile);
            this.Controls.Add(this.Add_entry);
            this.Controls.Add(this.ClearDataGrid);
            this.Controls.Add(this.BttnWriteToFile);
            this.Controls.Add(this.CreateFile);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Region;
        private System.Windows.Forms.DataGridViewTextBoxColumn Country;
        private System.Windows.Forms.DataGridViewTextBoxColumn Theatres;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cinema;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stadium;
        private System.Windows.Forms.Button CreateFile;
        private System.Windows.Forms.Button BttnWriteToFile;
        private System.Windows.Forms.Button ClearDataGrid;
        private System.Windows.Forms.Button Add_entry;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BttnReadFromFile;
        private System.Windows.Forms.Button BttnEditor;
        private System.Windows.Forms.Button CountryMaxStadium;
        private System.Windows.Forms.Button CinemaTheatres;
        private System.Windows.Forms.Button TheatresMoreCinema;
        private System.Windows.Forms.Button BttnDrawChart;
    }
}

