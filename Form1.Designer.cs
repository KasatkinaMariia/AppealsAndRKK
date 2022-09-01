
namespace AppealsAndRKK
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.responsibleExecutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RKKCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AppealsCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calculateBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RKKFileName = new System.Windows.Forms.Label();
            this.AppealFileName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.AppealsTotalCount = new System.Windows.Forms.Label();
            this.RKKTotalCount = new System.Windows.Forms.Label();
            this.documensTotal = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьДанныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RKKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обращенияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьВФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.responsibleExecutor,
            this.RKKCount,
            this.AppealsCount,
            this.TotalAmount});
            this.dataGridView1.Location = new System.Drawing.Point(0, 164);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(800, 263);
            this.dataGridView1.TabIndex = 0;
            // 
            // responsibleExecutor
            // 
            this.responsibleExecutor.HeaderText = "Ответственный исполнитель";
            this.responsibleExecutor.MinimumWidth = 6;
            this.responsibleExecutor.Name = "responsibleExecutor";
            this.responsibleExecutor.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // RKKCount
            // 
            this.RKKCount.HeaderText = "Количество неисполненных входящих документов";
            this.RKKCount.MinimumWidth = 6;
            this.RKKCount.Name = "RKKCount";
            this.RKKCount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // AppealsCount
            // 
            this.AppealsCount.HeaderText = "Количество неисполненных письменных обращений граждан";
            this.AppealsCount.MinimumWidth = 6;
            this.AppealsCount.Name = "AppealsCount";
            this.AppealsCount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // TotalAmount
            // 
            this.TotalAmount.HeaderText = "Общее количество документов и обращений";
            this.TotalAmount.MinimumWidth = 6;
            this.TotalAmount.Name = "TotalAmount";
            this.TotalAmount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // calculateBtn
            // 
            this.calculateBtn.Location = new System.Drawing.Point(12, 116);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(263, 29);
            this.calculateBtn.TabIndex = 1;
            this.calculateBtn.Text = "Рассчитать количество документов";
            this.calculateBtn.UseVisualStyleBackColor = true;
            this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "РКК:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Обращения:";
            // 
            // RKKFileName
            // 
            this.RKKFileName.AutoSize = true;
            this.RKKFileName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.RKKFileName.Location = new System.Drawing.Point(142, 43);
            this.RKKFileName.Name = "RKKFileName";
            this.RKKFileName.Size = new System.Drawing.Size(117, 20);
            this.RKKFileName.TabIndex = 5;
            this.RKKFileName.Text = "Выберите файл";
            this.RKKFileName.Click += new System.EventHandler(this.RKKFileName_Click);
            // 
            // AppealFileName
            // 
            this.AppealFileName.AutoSize = true;
            this.AppealFileName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AppealFileName.Location = new System.Drawing.Point(142, 80);
            this.AppealFileName.Name = "AppealFileName";
            this.AppealFileName.Size = new System.Drawing.Size(117, 20);
            this.AppealFileName.TabIndex = 6;
            this.AppealFileName.Text = "Выберите файл";
            this.AppealFileName.Click += new System.EventHandler(this.AppealFileName_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label5.Location = new System.Drawing.Point(0, 430);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Время работы алгоритма:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.AppealsTotalCount);
            this.panel1.Controls.Add(this.RKKTotalCount);
            this.panel1.Controls.Add(this.documensTotal);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.RKKFileName);
            this.panel1.Controls.Add(this.AppealFileName);
            this.panel1.Controls.Add(this.calculateBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 158);
            this.panel1.TabIndex = 9;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "по фамилии ответственного исполнителя",
            "по количеству РКК",
            "по количеству обращений",
            "по общему количеству документов"});
            this.comboBox1.Location = new System.Drawing.Point(431, 120);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(357, 28);
            this.comboBox1.TabIndex = 15;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(311, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Сортировка по";
            // 
            // AppealsTotalCount
            // 
            this.AppealsTotalCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AppealsTotalCount.AutoSize = true;
            this.AppealsTotalCount.Location = new System.Drawing.Point(280, 90);
            this.AppealsTotalCount.Name = "AppealsTotalCount";
            this.AppealsTotalCount.Size = new System.Drawing.Size(0, 20);
            this.AppealsTotalCount.TabIndex = 13;
            // 
            // RKKTotalCount
            // 
            this.RKKTotalCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RKKTotalCount.AutoSize = true;
            this.RKKTotalCount.Location = new System.Drawing.Point(280, 70);
            this.RKKTotalCount.Name = "RKKTotalCount";
            this.RKKTotalCount.Size = new System.Drawing.Size(0, 20);
            this.RKKTotalCount.TabIndex = 12;
            // 
            // documensTotal
            // 
            this.documensTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.documensTotal.AutoSize = true;
            this.documensTotal.Location = new System.Drawing.Point(280, 43);
            this.documensTotal.Name = "documensTotal";
            this.documensTotal.Size = new System.Drawing.Size(0, 20);
            this.documensTotal.TabIndex = 11;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.загрузитьДанныеToolStripMenuItem,
            this.сохранитьВФайлToolStripMenuItem});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // загрузитьДанныеToolStripMenuItem
            // 
            this.загрузитьДанныеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RKKToolStripMenuItem,
            this.обращенияToolStripMenuItem});
            this.загрузитьДанныеToolStripMenuItem.Name = "загрузитьДанныеToolStripMenuItem";
            this.загрузитьДанныеToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.загрузитьДанныеToolStripMenuItem.Text = "Загрузить данные";
            // 
            // RKKToolStripMenuItem
            // 
            this.RKKToolStripMenuItem.Name = "RKKToolStripMenuItem";
            this.RKKToolStripMenuItem.Size = new System.Drawing.Size(175, 26);
            this.RKKToolStripMenuItem.Text = "РКК";
            this.RKKToolStripMenuItem.Click += new System.EventHandler(this.RKKToolStripMenuItem_Click);
            // 
            // обращенияToolStripMenuItem
            // 
            this.обращенияToolStripMenuItem.Name = "обращенияToolStripMenuItem";
            this.обращенияToolStripMenuItem.Size = new System.Drawing.Size(175, 26);
            this.обращенияToolStripMenuItem.Text = "Обращения";
            this.обращенияToolStripMenuItem.Click += new System.EventHandler(this.AppealsToolStripMenuItem_Click);
            // 
            // сохранитьВФайлToolStripMenuItem
            // 
            this.сохранитьВФайлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtToolStripMenuItem});
            this.сохранитьВФайлToolStripMenuItem.Name = "сохранитьВФайлToolStripMenuItem";
            this.сохранитьВФайлToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.сохранитьВФайлToolStripMenuItem.Text = "Сохранить в файл";
            // 
            // txtToolStripMenuItem
            // 
            this.txtToolStripMenuItem.Name = "txtToolStripMenuItem";
            this.txtToolStripMenuItem.Size = new System.Drawing.Size(112, 26);
            this.txtToolStripMenuItem.Text = ".txt";
            this.txtToolStripMenuItem.Click += new System.EventHandler(this.txtToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Name = "Form1";
            this.Text = "Неисполненные документы и обращения";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button calculateBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label RKKFileName;
        private System.Windows.Forms.Label AppealFileName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьДанныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RKKToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обращенияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьВФайлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem txtToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label AppealsTotalCount;
        private System.Windows.Forms.Label RKKTotalCount;
        private System.Windows.Forms.Label documensTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn responsibleExecutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn RKKCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn AppealsCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalAmount;
    }
}

