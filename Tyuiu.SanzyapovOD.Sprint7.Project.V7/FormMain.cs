using System.ComponentModel;
using System;
using Tyuiu.SanzyapovOD.Sprint7.Project.V7.Lib;
using System.Windows.Forms.DataVisualization.Charting;

namespace Tyuiu.SanzyapovOD.Sprint7.Project.V7
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

        }
        static int rows;
        static int columns;
        static string openFilePath;
        DataService ds = new DataService();

        public static string[,] LoadFromFileData(string filePath)
        {
            string FileData = File.ReadAllText(filePath);
            FileData = FileData.Replace('\n', '\r');
            string[] lines = FileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);
            rows = lines.Length;
            columns = lines[0].Split(';').Length;
            string[,] arrayValues = new string[rows, columns];
            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = line_r[c];
                }
            }
            return arrayValues;
        }
        public void buttonOpenBase_SOD_Click_1(object sender, EventArgs e)
        {
            openFileDialogMain_SOD.ShowDialog();
            openFilePath = openFileDialogMain_SOD.FileName;
            string[,] arrayValues = new string[rows, columns];
            arrayValues = LoadFromFileData(openFilePath);
            arrayValues = ds.GetBase(openFilePath);
            buttonViewBase_SOD.Enabled = true;
        }
        public void buttonSave_SOD_Click(object sender, EventArgs e)
        {
            saveFileDialogMain_SOD.FileName = "Home_Base.csv";
            saveFileDialogMain_SOD.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMain_SOD.ShowDialog();
            string path = saveFileDialogMain_SOD.FileName;
            FileInfo fileInfo = new FileInfo(path);
            bool FileExists = fileInfo.Exists;
            if (FileExists)
            {
                File.Delete(path);
            }
            int rows = dataGridViewBase_SOD.RowCount;
            int columns = dataGridViewBase_SOD.ColumnCount;
            string str = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewBase_SOD.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewBase_SOD.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }
        public void buttonDelete_SOD_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewBase_SOD.CurrentRow.Index >= 0)
                {
                    int a = dataGridViewBase_SOD.CurrentRow.Index;
                    dataGridViewBase_SOD.Rows.Remove(dataGridViewBase_SOD.Rows[a]);
                    if (dataGridViewBase_SOD.Rows.Count == 1)
                    {
                        dataGridViewBase_SOD.Rows.Clear();
                    }
                }
                if (dataGridViewBase_SOD.Rows.Count <= 1)
                {
                    buttonDelete_SOD.Enabled = false;
                    buttonFind_SOD.Enabled = false;
                }
                if (dataGridViewBase_SOD.Rows.Count > 1)
                {
                    buttonDelete_SOD.Enabled = true;
                }
            }
            catch
            {
                MessageBox.Show("Ошибка при удалении комплектующего", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void buttonAdd_SOD_Click(object sender, EventArgs e)
        {
            FormAdd formAdd = new FormAdd(this);
            formAdd.ShowDialog();
        }
        public void buttonViewBase_SOD_Click(object sender, EventArgs e)
        {
            dataGridViewBase_SOD.ColumnCount = columns;
            dataGridViewBase_SOD.RowCount = rows;
            dataGridViewBase_SOD.Rows[0].ReadOnly = true;
            dataGridViewBase_SOD.Columns[0].ReadOnly = true;
            string[,] arrayValues = new string[rows, columns];
            arrayValues = LoadFromFileData(openFilePath);
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewBase_SOD.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            arrayValues = ds.GetBase(openFilePath);
            buttonFind_SOD.Enabled = true;
            buttonDelete_SOD.Enabled = true;
            buttonSave_SOD.Enabled = true;
            buttonArea_SOD.Enabled = true;
            buttonKids_SOD.Enabled = true;
            buttonEdit_SOD.Enabled = true;
            buttonAdd_SOD.Enabled = true;
            buttonAreaGr_SOD.Enabled = true;
            buttonMin_SOD.Enabled = true;
            buttonAverage_SOD.Enabled = true;
            buttonMax_SOD.Enabled = true;
            buttonFilterCansel_SOD.Enabled = true;
            buttonFilter_SOD.Enabled = true;
            textBoxFind_SOD.Enabled = true;
            textBoxMax_SOD.Enabled = true;
            textBoxMin_SOD.Enabled = true;
            textBoxAverage_SOD.Enabled = true;
            comboBoxFilter_SOD.Enabled = true;


        }
        private void buttonHelp_SOD_Click(object sender, EventArgs e)
        {
            FormHelp formHelp = new FormHelp();
            formHelp.ShowDialog();
        }
        private void buttonFind_SOD_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < dataGridViewBase_SOD.RowCount; i++)
                {
                    dataGridViewBase_SOD.Rows[i].Selected = false;
                    for (int j = 0; j < dataGridViewBase_SOD.ColumnCount; j++)
                        if (dataGridViewBase_SOD.Rows[i].Cells[j].Value != null)
                            if (dataGridViewBase_SOD.Rows[i].Cells[j].Value.ToString().Contains(textBoxFind_SOD.Text))
                            {
                                dataGridViewBase_SOD.Rows[i].Selected = true;
                                break;
                            }
                }
            }
            catch
            {
                MessageBox.Show("Ошибка поиска", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonArea_SOD_Click(object sender, EventArgs e)
        {
            dataGridViewBase_SOD.Sort(dataGridViewBase_SOD.Columns[3], ListSortDirection.Descending);
        }
        private void buttonKids_SOD_Click(object sender, EventArgs e)
        {
            dataGridViewBase_SOD.Sort(dataGridViewBase_SOD.Columns[4], ListSortDirection.Descending);
        }
        private void buttonAreaGr_SOD_Click(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            Series series = new Series();
            series.ChartType = SeriesChartType.Area;


            foreach (DataGridViewRow row in dataGridViewBase_SOD.Rows)
            {

                double area = Convert.ToDouble(row.Cells[2].Value);
                int roomCount = Convert.ToInt32(row.Cells[3].Value);
                series.Points.AddXY(roomCount, area);
            }
            chart1.Series.Add(series);
            chart1.Show();
        }
        public void FormMain_Load(object sender, EventArgs e)
        {

        }
        private void buttonEdit_SOD_Click(object sender, EventArgs e)
        {
            try
            {
                int a = dataGridViewBase_SOD.CurrentRow.Index;
                FormEdit fed = new FormEdit(this);
                fed.textBoxPadik_SOD.Text = dataGridViewBase_SOD.Rows[a].Cells[0].Value.ToString();
                fed.textBoxAppartament_SOD.Text = dataGridViewBase_SOD.Rows[a].Cells[1].Value.ToString();
                fed.textBoxRooms_SOD.Text = dataGridViewBase_SOD.Rows[a].Cells[2].Value.ToString();
                fed.textBoxTotalArea_SOD.Text = dataGridViewBase_SOD.Rows[a].Cells[3].Value.ToString();
                fed.comboBoxKids_SOD.Text = dataGridViewBase_SOD.Rows[a].Cells[4].Value.ToString();
                fed.comboBoxDebt_SOD.Text = dataGridViewBase_SOD.Rows[a].Cells[5].Value.ToString();
                fed.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Ошибка при редактировании комплектующего", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonMin_SOD_Click(object sender, EventArgs e)
        {
            double minValue = double.MaxValue;
            foreach (DataGridViewRow row in dataGridViewBase_SOD.Rows)
            {
                if (row.Cells[3].Value != null && row.Cells[3].Value != DBNull.Value)
                {
                    double cellValue = Convert.ToDouble(row.Cells[3].Value);
                    if (cellValue < minValue)
                    {
                        minValue = cellValue;
                    }
                }
            }
            textBoxMin_SOD.Text = minValue.ToString();
        }
        private void buttonAverage_SOD_Click(object sender, EventArgs e)
        {
            double sum = 0;
            int count = 0;

            foreach (DataGridViewRow row in dataGridViewBase_SOD.Rows)
            {
                // Проверка, что значение в ячейке не является пустым или нулевым
                if (row.Cells[3].Value != null && row.Cells[3].Value != DBNull.Value)
                {
                    double cellValue = Convert.ToDouble(row.Cells[3].Value);
                    sum += cellValue;
                    count++;
                }
            }

            double average = sum / count;
            textBoxAverage_SOD.Text = Convert.ToString(Math.Round(average, 2));
        }
        private void buttonMax_SOD_Click(object sender, EventArgs e)
        {
            double maxValue = double.MinValue;
            foreach (DataGridViewRow row in dataGridViewBase_SOD.Rows)
            {
                if (row.Cells[3].Value != null && row.Cells[3].Value != DBNull.Value)
                {
                    double cellValue = Convert.ToDouble(row.Cells[3].Value);
                    if (cellValue > maxValue)
                    {
                        maxValue = cellValue;
                    }
                }
            }
            textBoxMax_SOD.Text = maxValue.ToString();
        }
        private void buttonFilter_SOD_Click(object sender, EventArgs e)
        {
            string filterValue = comboBoxFilter_SOD.SelectedItem.ToString();
            foreach (DataGridViewRow row in dataGridViewBase_SOD.Rows)
            {
                string cellValue = row.Cells[5].Value.ToString();
                if (cellValue == filterValue)
                {
                    row.Visible = true;
                }
                else
                {
                    row.Visible = false;
                }
            }

        }

        private void buttonFilterCansel_SOD_Click(object sender, EventArgs e)
        {
            string filterValue = comboBoxFilter_SOD.SelectedItem.ToString();
            foreach (DataGridViewRow row in dataGridViewBase_SOD.Rows)
            {
                string cellValue = row.Cells[5].Value.ToString();
                if (cellValue == filterValue)
                {
                    row.Visible = true;
                }
                else
                {
                    row.Visible = true;
                }
            }
        }
    }
}


