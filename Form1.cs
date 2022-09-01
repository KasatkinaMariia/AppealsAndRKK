using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace AppealsAndRKK
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            WindowState = FormWindowState.Maximized;          
            InitializeComponent();
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private string ChooseFile()
        {
            OpenFileDialog OPF = new OpenFileDialog();
            OPF.Filter = "Файлы txt|*.txt";
            if (OPF.ShowDialog() == DialogResult.OK)
                return OPF.FileName;
            return "";
        }

        private void RKKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var fileName = ChooseFile();
            if (fileName != "")
                RKKFileName.Text = fileName;
        }

        private void AppealsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var fileName = ChooseFile();
            if (fileName != "")
                AppealFileName.Text = fileName;
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            DocumentsCalculator documentsCalculator = new DocumentsCalculator();
            try
            {
                Stopwatch timer = new Stopwatch();
                timer.Start();
                documentsCalculator.Calculate(RKKFileName.Text, AppealFileName.Text);
                var arrays = documentsCalculator.GetExecutorsDocumentsDictionary();

                dataGridView1.Rows.Clear();
                dataGridView1.Rows.Add(arrays.Count);

                for (int i = 0; i < arrays.Count; i++)
                {
                    for (int j = 0; j < arrays[i].Count; j++)
                        dataGridView1[j, i].Value = arrays[i][j];
                    dataGridView1.Rows[i].HeaderCell.Value = (i + 1).ToString();
                }

                documensTotal.Text = $"Не исполнено в срок {documentsCalculator.AppealsTotal + documentsCalculator.RKKTotal} документов, из них:";
                RKKTotalCount.Text = $"-количество неисполненных входящих документов: {documentsCalculator.RKKTotal};";
                AppealsTotalCount.Text = $"-количество неисполненных письменных обращений граждан: {documentsCalculator.AppealsTotal}.";
                timer.Stop();

                label5.Text = "Время работы алгоритма: " + timer.ElapsedMilliseconds;
            }
            catch
            {
                MessageBox.Show("Ошибка при открытии файла. Возможно указан неверный путь к файлу",
                                "Ошибка",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void SaveTxt(string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create);
            StreamWriter streamWriter = new StreamWriter(fs);
            streamWriter.WriteLine("Справка о неисполненных документах и обращениях граждан\n");
            streamWriter.WriteLine(documensTotal.Text);
            streamWriter.WriteLine(RKKTotalCount.Text);
            streamWriter.WriteLine(AppealsTotalCount.Text);
            streamWriter.WriteLine("Сортировка: {0}.", comboBox1.SelectedItem);
            streamWriter.WriteLine();

            streamWriter.Write(String.Format("{0, -8}", "№ п.п."));
            streamWriter.Write(String.Format("{0, -30}", "Ответственный исполнитель"));
            streamWriter.Write(String.Format("{0, -50}", "Количество неисполненных входящих документов"));
            streamWriter.Write(String.Format("{0, -60}", "Количество неисполненных письменных обращений граждан"));
            streamWriter.WriteLine(String.Format("{0, -50}", "Общее количество документов и обращений"));

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                streamWriter.Write(String.Format("{0, -8}", dataGridView1.Rows[i].HeaderCell.Value));
                streamWriter.Write(String.Format("{0, -30}", dataGridView1.Rows[i].Cells[0].Value));
                streamWriter.Write(String.Format("{0, -50}", dataGridView1.Rows[i].Cells[1].Value));
                streamWriter.Write(String.Format("{0, -60}", dataGridView1.Rows[i].Cells[2].Value));
                streamWriter.Write(String.Format("{0, -50}", dataGridView1.Rows[i].Cells[3].Value));
                streamWriter.WriteLine();
            }

            streamWriter.WriteLine("\nДата составления справки: " + DateTime.Today.ToShortDateString());
            streamWriter.Close();
            fs.Close();
        }

        private void txtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Файлы txt|*.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    SaveTxt(saveFileDialog.FileName);
                    MessageBox.Show("Файл успешно сохранен");
                }
                catch
                {
                    MessageBox.Show("Ошибка при сохранении файла!");
                }
            }
        }
       
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(comboBox1.SelectedItem)
            {
                case "по фамилии ответственного исполнителя":
                    dataGridView1.Sort(new NameComparer());
                    break;
                case "по количеству РКК":
                    dataGridView1.Sort(new RKKCountComparer());
                    break;
                case "по количеству обращений":
                    dataGridView1.Sort(new AppealsCountComparer());
                    break;
                case "по общему количеству документов":
                    dataGridView1.Sort(new TotalCountComparer());
                    break;
            }

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
                dataGridView1.Rows[i].HeaderCell.Value = (i + 1).ToString();
        }

        private void RKKFileName_Click(object sender, EventArgs e)
        {
            RKKToolStripMenuItem_Click(sender, e);
        }

        private void AppealFileName_Click(object sender, EventArgs e)
        {
            AppealsToolStripMenuItem_Click(sender, e);
        }
    }
}
