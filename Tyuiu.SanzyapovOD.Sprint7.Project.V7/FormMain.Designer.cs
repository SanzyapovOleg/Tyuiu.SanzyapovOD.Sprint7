namespace Tyuiu.SanzyapovOD.Sprint7.Project.V7
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;
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
        #endregion
        #region Код, автоматически созданный конструктором форм Windows
        /// Требуемый метод для поддержки конструктора — не изменяйте
        /// содержимое этого метода с помощью редактора кода.
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            toolStripMenuItem6 = new ToolStripMenuItem();
            openFileDialogMain_SOD = new OpenFileDialog();
            saveFileDialogMain_SOD = new SaveFileDialog();
            groupBoxHelper_SOD = new GroupBox();
            buttonHelp_SOD = new Button();
            buttonOpenBase_SOD = new Button();
            buttonSave_SOD = new Button();
            dataGridViewBase_SOD = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            groupBoxButtons_BDA = new GroupBox();
            buttonEdit_SOD = new Button();
            buttonViewBase_SOD = new Button();
            buttonAdd_SOD = new Button();
            buttonDelete_SOD = new Button();
            panel3 = new Panel();
            panel4 = new Panel();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            toolTipInfo_SOD = new ToolTip(components);
            buttonFind_SOD = new Button();
            buttonArea_SOD = new Button();
            buttonKids_SOD = new Button();
            buttonMin_SOD = new Button();
            buttonAverage_SOD = new Button();
            buttonMax_SOD = new Button();
            buttonFilter_SOD = new Button();
            buttonFilterCansel_SOD = new Button();
            groupBoxFunctions_BDA = new GroupBox();
            comboBoxFilter_SOD = new ComboBox();
            textBoxAverage_SOD = new TextBox();
            textBoxMax_SOD = new TextBox();
            textBoxMin_SOD = new TextBox();
            label2 = new Label();
            label1 = new Label();
            textBoxFind_SOD = new TextBox();
            buttonAreaGr_SOD = new Button();
            panel2 = new Panel();
            groupBoxHelper_SOD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBase_SOD).BeginInit();
            groupBoxButtons_BDA.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            groupBoxFunctions_BDA.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // toolStripMenuItem6
            // 
            toolStripMenuItem6.Name = "toolStripMenuItem6";
            toolStripMenuItem6.Size = new Size(32, 19);
            // 
            // openFileDialogMain_SOD
            // 
            openFileDialogMain_SOD.FileName = "openFileDialog1";
            // 
            // groupBoxHelper_SOD
            // 
            groupBoxHelper_SOD.BackColor = Color.Transparent;
            groupBoxHelper_SOD.BackgroundImage = (Image)resources.GetObject("groupBoxHelper_SOD.BackgroundImage");
            groupBoxHelper_SOD.Controls.Add(buttonHelp_SOD);
            groupBoxHelper_SOD.Controls.Add(buttonOpenBase_SOD);
            groupBoxHelper_SOD.Controls.Add(buttonSave_SOD);
            groupBoxHelper_SOD.Dock = DockStyle.Top;
            groupBoxHelper_SOD.FlatStyle = FlatStyle.Flat;
            groupBoxHelper_SOD.Location = new Point(0, 0);
            groupBoxHelper_SOD.Name = "groupBoxHelper_SOD";
            groupBoxHelper_SOD.Size = new Size(1324, 80);
            groupBoxHelper_SOD.TabIndex = 1;
            groupBoxHelper_SOD.TabStop = false;
            // 
            // buttonHelp_SOD
            // 
            buttonHelp_SOD.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_SOD.BackColor = Color.Transparent;
            buttonHelp_SOD.BackgroundImage = (Image)resources.GetObject("buttonHelp_SOD.BackgroundImage");
            buttonHelp_SOD.BackgroundImageLayout = ImageLayout.Zoom;
            buttonHelp_SOD.Cursor = Cursors.Help;
            buttonHelp_SOD.FlatAppearance.BorderSize = 0;
            buttonHelp_SOD.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonHelp_SOD.FlatStyle = FlatStyle.Flat;
            buttonHelp_SOD.Location = new Point(1257, 9);
            buttonHelp_SOD.Name = "buttonHelp_SOD";
            buttonHelp_SOD.Size = new Size(67, 62);
            buttonHelp_SOD.TabIndex = 4;
            toolTipInfo_SOD.SetToolTip(buttonHelp_SOD, "Информация о программе");
            buttonHelp_SOD.UseVisualStyleBackColor = false;
            buttonHelp_SOD.Click += buttonHelp_SOD_Click;
            // 
            // buttonOpenBase_SOD
            // 
            buttonOpenBase_SOD.BackgroundImage = (Image)resources.GetObject("buttonOpenBase_SOD.BackgroundImage");
            buttonOpenBase_SOD.BackgroundImageLayout = ImageLayout.Zoom;
            buttonOpenBase_SOD.FlatAppearance.BorderSize = 0;
            buttonOpenBase_SOD.FlatAppearance.MouseDownBackColor = Color.White;
            buttonOpenBase_SOD.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonOpenBase_SOD.FlatStyle = FlatStyle.Flat;
            buttonOpenBase_SOD.Location = new Point(0, 9);
            buttonOpenBase_SOD.Name = "buttonOpenBase_SOD";
            buttonOpenBase_SOD.Size = new Size(75, 66);
            buttonOpenBase_SOD.TabIndex = 2;
            toolTipInfo_SOD.SetToolTip(buttonOpenBase_SOD, "Открыть файл");
            buttonOpenBase_SOD.UseVisualStyleBackColor = true;
            buttonOpenBase_SOD.Click += buttonOpenBase_SOD_Click_1;
            // 
            // buttonSave_SOD
            // 
            buttonSave_SOD.BackgroundImage = (Image)resources.GetObject("buttonSave_SOD.BackgroundImage");
            buttonSave_SOD.BackgroundImageLayout = ImageLayout.Zoom;
            buttonSave_SOD.Enabled = false;
            buttonSave_SOD.FlatAppearance.BorderSize = 0;
            buttonSave_SOD.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonSave_SOD.FlatStyle = FlatStyle.Flat;
            buttonSave_SOD.Location = new Point(81, 9);
            buttonSave_SOD.Name = "buttonSave_SOD";
            buttonSave_SOD.Size = new Size(72, 66);
            buttonSave_SOD.TabIndex = 3;
            toolTipInfo_SOD.SetToolTip(buttonSave_SOD, "Сохранить файл");
            buttonSave_SOD.UseVisualStyleBackColor = true;
            buttonSave_SOD.Click += buttonSave_SOD_Click;
            // 
            // dataGridViewBase_SOD
            // 
            dataGridViewBase_SOD.AllowDrop = true;
            dataGridViewBase_SOD.AllowUserToAddRows = false;
            dataGridViewBase_SOD.AllowUserToOrderColumns = true;
            dataGridViewBase_SOD.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewBase_SOD.BackgroundColor = SystemColors.Control;
            dataGridViewBase_SOD.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBase_SOD.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column6, Column7 });
            dataGridViewBase_SOD.GridColor = SystemColors.Control;
            dataGridViewBase_SOD.Location = new Point(0, 0);
            dataGridViewBase_SOD.MinimumSize = new Size(100, 50);
            dataGridViewBase_SOD.Name = "dataGridViewBase_SOD";
            dataGridViewBase_SOD.RowHeadersVisible = false;
            dataGridViewBase_SOD.Size = new Size(984, 436);
            dataGridViewBase_SOD.TabIndex = 3;
            // 
            // Column1
            // 
            Column1.HeaderText = "Номер подъезда";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Номер квартиры";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Количество комнат";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Общая площадь";
            Column4.Name = "Column4";
            // 
            // Column6
            // 
            Column6.HeaderText = "Есть ли дети";
            Column6.Name = "Column6";
            // 
            // Column7
            // 
            Column7.HeaderText = "Есть ли задолженность";
            Column7.Name = "Column7";
            // 
            // groupBoxButtons_BDA
            // 
            groupBoxButtons_BDA.BackColor = Color.Transparent;
            groupBoxButtons_BDA.BackgroundImage = (Image)resources.GetObject("groupBoxButtons_BDA.BackgroundImage");
            groupBoxButtons_BDA.BackgroundImageLayout = ImageLayout.Stretch;
            groupBoxButtons_BDA.Controls.Add(buttonEdit_SOD);
            groupBoxButtons_BDA.Controls.Add(buttonViewBase_SOD);
            groupBoxButtons_BDA.Controls.Add(buttonAdd_SOD);
            groupBoxButtons_BDA.Controls.Add(buttonDelete_SOD);
            groupBoxButtons_BDA.FlatStyle = FlatStyle.Flat;
            groupBoxButtons_BDA.Location = new Point(0, 663);
            groupBoxButtons_BDA.Name = "groupBoxButtons_BDA";
            groupBoxButtons_BDA.Size = new Size(1324, 65);
            groupBoxButtons_BDA.TabIndex = 4;
            groupBoxButtons_BDA.TabStop = false;
            // 
            // buttonEdit_SOD
            // 
            buttonEdit_SOD.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonEdit_SOD.BackColor = Color.Transparent;
            buttonEdit_SOD.BackgroundImage = Properties.Resources._8696059;
            buttonEdit_SOD.BackgroundImageLayout = ImageLayout.Zoom;
            buttonEdit_SOD.Enabled = false;
            buttonEdit_SOD.FlatAppearance.BorderSize = 0;
            buttonEdit_SOD.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonEdit_SOD.FlatStyle = FlatStyle.Flat;
            buttonEdit_SOD.Location = new Point(1249, 3);
            buttonEdit_SOD.Name = "buttonEdit_SOD";
            buttonEdit_SOD.Size = new Size(75, 62);
            buttonEdit_SOD.TabIndex = 7;
            toolTipInfo_SOD.SetToolTip(buttonEdit_SOD, "Редактировать строчку");
            buttonEdit_SOD.UseVisualStyleBackColor = false;
            buttonEdit_SOD.Click += buttonEdit_SOD_Click;
            // 
            // buttonViewBase_SOD
            // 
            buttonViewBase_SOD.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonViewBase_SOD.BackColor = Color.Transparent;
            buttonViewBase_SOD.BackgroundImage = (Image)resources.GetObject("buttonViewBase_SOD.BackgroundImage");
            buttonViewBase_SOD.BackgroundImageLayout = ImageLayout.Zoom;
            buttonViewBase_SOD.Enabled = false;
            buttonViewBase_SOD.FlatAppearance.BorderSize = 0;
            buttonViewBase_SOD.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonViewBase_SOD.FlatStyle = FlatStyle.Flat;
            buttonViewBase_SOD.Location = new Point(0, 3);
            buttonViewBase_SOD.Name = "buttonViewBase_SOD";
            buttonViewBase_SOD.Size = new Size(75, 62);
            buttonViewBase_SOD.TabIndex = 1;
            toolTipInfo_SOD.SetToolTip(buttonViewBase_SOD, "Подтвердить открытие файла для работы с ним");
            buttonViewBase_SOD.UseVisualStyleBackColor = false;
            buttonViewBase_SOD.Click += buttonViewBase_SOD_Click;
            // 
            // buttonAdd_SOD
            // 
            buttonAdd_SOD.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonAdd_SOD.BackColor = Color.Transparent;
            buttonAdd_SOD.BackgroundImage = (Image)resources.GetObject("buttonAdd_SOD.BackgroundImage");
            buttonAdd_SOD.BackgroundImageLayout = ImageLayout.Zoom;
            buttonAdd_SOD.Enabled = false;
            buttonAdd_SOD.FlatAppearance.BorderSize = 0;
            buttonAdd_SOD.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonAdd_SOD.FlatStyle = FlatStyle.Flat;
            buttonAdd_SOD.Location = new Point(1087, 3);
            buttonAdd_SOD.Name = "buttonAdd_SOD";
            buttonAdd_SOD.Size = new Size(75, 62);
            buttonAdd_SOD.TabIndex = 5;
            toolTipInfo_SOD.SetToolTip(buttonAdd_SOD, "Добавить строчку");
            buttonAdd_SOD.UseVisualStyleBackColor = false;
            buttonAdd_SOD.Click += buttonAdd_SOD_Click;
            // 
            // buttonDelete_SOD
            // 
            buttonDelete_SOD.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonDelete_SOD.BackColor = Color.Transparent;
            buttonDelete_SOD.BackgroundImage = Properties.Resources._13110746;
            buttonDelete_SOD.BackgroundImageLayout = ImageLayout.Zoom;
            buttonDelete_SOD.Enabled = false;
            buttonDelete_SOD.FlatAppearance.BorderSize = 0;
            buttonDelete_SOD.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonDelete_SOD.FlatStyle = FlatStyle.Flat;
            buttonDelete_SOD.Location = new Point(1168, 3);
            buttonDelete_SOD.Name = "buttonDelete_SOD";
            buttonDelete_SOD.Size = new Size(75, 62);
            buttonDelete_SOD.TabIndex = 4;
            toolTipInfo_SOD.SetToolTip(buttonDelete_SOD, "Удалить выделенную строчку");
            buttonDelete_SOD.UseVisualStyleBackColor = false;
            buttonDelete_SOD.Click += buttonDelete_SOD_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(dataGridViewBase_SOD);
            panel3.Location = new Point(340, 80);
            panel3.Name = "panel3";
            panel3.Size = new Size(984, 436);
            panel3.TabIndex = 6;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            panel4.Controls.Add(chart1);
            panel4.Location = new Point(0, 517);
            panel4.Name = "panel4";
            panel4.Size = new Size(1324, 140);
            panel4.TabIndex = 7;
            // 
            // chart1
            // 
            chart1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(162, 0);
            chart1.MaximumSize = new Size(1000, 140);
            chart1.Name = "chart1";
            chart1.Size = new Size(1000, 140);
            chart1.TabIndex = 0;
            chart1.Visible = false;
            // 
            // toolTipInfo_SOD
            // 
            toolTipInfo_SOD.AutoPopDelay = 5000;
            toolTipInfo_SOD.BackColor = SystemColors.GradientActiveCaption;
            toolTipInfo_SOD.InitialDelay = 1000;
            toolTipInfo_SOD.IsBalloon = true;
            toolTipInfo_SOD.ReshowDelay = 100;
            toolTipInfo_SOD.ToolTipIcon = ToolTipIcon.Info;
            toolTipInfo_SOD.ToolTipTitle = "Подсказка";
            // 
            // buttonFind_SOD
            // 
            buttonFind_SOD.BackgroundImage = (Image)resources.GetObject("buttonFind_SOD.BackgroundImage");
            buttonFind_SOD.BackgroundImageLayout = ImageLayout.Zoom;
            buttonFind_SOD.Cursor = Cursors.Hand;
            buttonFind_SOD.Enabled = false;
            buttonFind_SOD.FlatAppearance.BorderSize = 0;
            buttonFind_SOD.FlatAppearance.MouseOverBackColor = SystemColors.Control;
            buttonFind_SOD.FlatStyle = FlatStyle.Flat;
            buttonFind_SOD.Location = new Point(288, 29);
            buttonFind_SOD.Name = "buttonFind_SOD";
            buttonFind_SOD.Size = new Size(29, 26);
            buttonFind_SOD.TabIndex = 7;
            toolTipInfo_SOD.SetToolTip(buttonFind_SOD, "Выполнить поиск по заданному параметру");
            buttonFind_SOD.UseVisualStyleBackColor = true;
            buttonFind_SOD.Click += buttonFind_SOD_Click;
            // 
            // buttonArea_SOD
            // 
            buttonArea_SOD.Enabled = false;
            buttonArea_SOD.Location = new Point(9, 74);
            buttonArea_SOD.Name = "buttonArea_SOD";
            buttonArea_SOD.Size = new Size(296, 40);
            buttonArea_SOD.TabIndex = 8;
            buttonArea_SOD.Text = "Площади";
            toolTipInfo_SOD.SetToolTip(buttonArea_SOD, "Отсортировать в порядке убывания по столбцу \"Общая площадь\"");
            buttonArea_SOD.UseVisualStyleBackColor = true;
            buttonArea_SOD.Click += buttonArea_SOD_Click;
            // 
            // buttonKids_SOD
            // 
            buttonKids_SOD.Enabled = false;
            buttonKids_SOD.Location = new Point(9, 120);
            buttonKids_SOD.Name = "buttonKids_SOD";
            buttonKids_SOD.Size = new Size(296, 40);
            buttonKids_SOD.TabIndex = 9;
            buttonKids_SOD.Text = "Наличию детей";
            toolTipInfo_SOD.SetToolTip(buttonKids_SOD, "Отсортировать в порядке убывания по столбцу \"Есть ли дети\"");
            buttonKids_SOD.UseVisualStyleBackColor = true;
            buttonKids_SOD.Click += buttonKids_SOD_Click;
            // 
            // buttonMin_SOD
            // 
            buttonMin_SOD.Enabled = false;
            buttonMin_SOD.Location = new Point(9, 166);
            buttonMin_SOD.Name = "buttonMin_SOD";
            buttonMin_SOD.Size = new Size(153, 40);
            buttonMin_SOD.TabIndex = 13;
            buttonMin_SOD.Text = "Найти минимальную площадь";
            toolTipInfo_SOD.SetToolTip(buttonMin_SOD, "Находит минимальную площадь в таблице");
            buttonMin_SOD.UseVisualStyleBackColor = true;
            buttonMin_SOD.Click += buttonMin_SOD_Click;
            // 
            // buttonAverage_SOD
            // 
            buttonAverage_SOD.Enabled = false;
            buttonAverage_SOD.Location = new Point(9, 258);
            buttonAverage_SOD.Name = "buttonAverage_SOD";
            buttonAverage_SOD.Size = new Size(153, 40);
            buttonAverage_SOD.TabIndex = 14;
            buttonAverage_SOD.Text = "Найти среднее значение площадей";
            toolTipInfo_SOD.SetToolTip(buttonAverage_SOD, "Находит среднюю площадь в таблице");
            buttonAverage_SOD.UseVisualStyleBackColor = true;
            buttonAverage_SOD.Click += buttonAverage_SOD_Click;
            // 
            // buttonMax_SOD
            // 
            buttonMax_SOD.Enabled = false;
            buttonMax_SOD.Location = new Point(9, 212);
            buttonMax_SOD.Name = "buttonMax_SOD";
            buttonMax_SOD.Size = new Size(153, 40);
            buttonMax_SOD.TabIndex = 15;
            buttonMax_SOD.Text = "Найти максимальное значение площади";
            toolTipInfo_SOD.SetToolTip(buttonMax_SOD, "Находит максимальную площадь в таблице");
            buttonMax_SOD.UseVisualStyleBackColor = true;
            buttonMax_SOD.Click += buttonMax_SOD_Click;
            // 
            // buttonFilter_SOD
            // 
            buttonFilter_SOD.Enabled = false;
            buttonFilter_SOD.Location = new Point(9, 304);
            buttonFilter_SOD.Name = "buttonFilter_SOD";
            buttonFilter_SOD.Size = new Size(153, 40);
            buttonFilter_SOD.TabIndex = 22;
            buttonFilter_SOD.Text = "Фильтрация по задолженности";
            toolTipInfo_SOD.SetToolTip(buttonFilter_SOD, "Выберите один из вариантов справа");
            buttonFilter_SOD.UseVisualStyleBackColor = true;
            buttonFilter_SOD.Click += buttonFilter_SOD_Click;
            // 
            // buttonFilterCansel_SOD
            // 
            buttonFilterCansel_SOD.Enabled = false;
            buttonFilterCansel_SOD.Location = new Point(9, 350);
            buttonFilterCansel_SOD.Name = "buttonFilterCansel_SOD";
            buttonFilterCansel_SOD.Size = new Size(296, 40);
            buttonFilterCansel_SOD.TabIndex = 24;
            buttonFilterCansel_SOD.Text = "Отменить фильтрацию";
            toolTipInfo_SOD.SetToolTip(buttonFilterCansel_SOD, "Отмена фильтрации таблицы");
            buttonFilterCansel_SOD.UseVisualStyleBackColor = true;
            buttonFilterCansel_SOD.Click += buttonFilterCansel_SOD_Click;
            // 
            // groupBoxFunctions_BDA
            // 
            groupBoxFunctions_BDA.Controls.Add(buttonFilterCansel_SOD);
            groupBoxFunctions_BDA.Controls.Add(comboBoxFilter_SOD);
            groupBoxFunctions_BDA.Controls.Add(buttonFilter_SOD);
            groupBoxFunctions_BDA.Controls.Add(textBoxAverage_SOD);
            groupBoxFunctions_BDA.Controls.Add(textBoxMax_SOD);
            groupBoxFunctions_BDA.Controls.Add(textBoxMin_SOD);
            groupBoxFunctions_BDA.Controls.Add(buttonMax_SOD);
            groupBoxFunctions_BDA.Controls.Add(buttonAverage_SOD);
            groupBoxFunctions_BDA.Controls.Add(buttonMin_SOD);
            groupBoxFunctions_BDA.Controls.Add(label2);
            groupBoxFunctions_BDA.Controls.Add(label1);
            groupBoxFunctions_BDA.Controls.Add(buttonKids_SOD);
            groupBoxFunctions_BDA.Controls.Add(buttonArea_SOD);
            groupBoxFunctions_BDA.Controls.Add(buttonFind_SOD);
            groupBoxFunctions_BDA.Controls.Add(textBoxFind_SOD);
            groupBoxFunctions_BDA.Controls.Add(buttonAreaGr_SOD);
            groupBoxFunctions_BDA.Location = new Point(0, 0);
            groupBoxFunctions_BDA.Name = "groupBoxFunctions_BDA";
            groupBoxFunctions_BDA.Size = new Size(340, 436);
            groupBoxFunctions_BDA.TabIndex = 2;
            groupBoxFunctions_BDA.TabStop = false;
            // 
            // comboBoxFilter_SOD
            // 
            comboBoxFilter_SOD.DropDownWidth = 137;
            comboBoxFilter_SOD.Enabled = false;
            comboBoxFilter_SOD.Font = new Font("Segoe UI", 16.5F);
            comboBoxFilter_SOD.FormattingEnabled = true;
            comboBoxFilter_SOD.IntegralHeight = false;
            comboBoxFilter_SOD.Items.AddRange(new object[] { "Есть", "Нет" });
            comboBoxFilter_SOD.Location = new Point(168, 304);
            comboBoxFilter_SOD.Name = "comboBoxFilter_SOD";
            comboBoxFilter_SOD.Size = new Size(137, 38);
            comboBoxFilter_SOD.TabIndex = 23;
            comboBoxFilter_SOD.Text = "Есть";
            // 
            // textBoxAverage_SOD
            // 
            textBoxAverage_SOD.Enabled = false;
            textBoxAverage_SOD.Location = new Point(168, 258);
            textBoxAverage_SOD.Multiline = true;
            textBoxAverage_SOD.Name = "textBoxAverage_SOD";
            textBoxAverage_SOD.ReadOnly = true;
            textBoxAverage_SOD.Size = new Size(137, 40);
            textBoxAverage_SOD.TabIndex = 21;
            // 
            // textBoxMax_SOD
            // 
            textBoxMax_SOD.Enabled = false;
            textBoxMax_SOD.Location = new Point(168, 212);
            textBoxMax_SOD.Multiline = true;
            textBoxMax_SOD.Name = "textBoxMax_SOD";
            textBoxMax_SOD.ReadOnly = true;
            textBoxMax_SOD.Size = new Size(137, 40);
            textBoxMax_SOD.TabIndex = 19;
            // 
            // textBoxMin_SOD
            // 
            textBoxMin_SOD.Enabled = false;
            textBoxMin_SOD.Location = new Point(168, 166);
            textBoxMin_SOD.Multiline = true;
            textBoxMin_SOD.Name = "textBoxMin_SOD";
            textBoxMin_SOD.ReadOnly = true;
            textBoxMin_SOD.Size = new Size(137, 40);
            textBoxMin_SOD.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(120, 58);
            label2.Name = "label2";
            label2.Size = new Size(93, 15);
            label2.TabIndex = 12;
            label2.Text = "Сортировка по:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(109, 16);
            label1.Name = "label1";
            label1.Size = new Size(104, 15);
            label1.TabIndex = 11;
            label1.Text = "Текстовый поиск:";
            // 
            // textBoxFind_SOD
            // 
            textBoxFind_SOD.Enabled = false;
            textBoxFind_SOD.Location = new Point(12, 32);
            textBoxFind_SOD.Name = "textBoxFind_SOD";
            textBoxFind_SOD.Size = new Size(270, 23);
            textBoxFind_SOD.TabIndex = 6;
            // 
            // buttonAreaGr_SOD
            // 
            buttonAreaGr_SOD.Enabled = false;
            buttonAreaGr_SOD.Location = new Point(9, 396);
            buttonAreaGr_SOD.Name = "buttonAreaGr_SOD";
            buttonAreaGr_SOD.Size = new Size(296, 40);
            buttonAreaGr_SOD.TabIndex = 3;
            buttonAreaGr_SOD.Text = "Вывести график полезной площади относительно количества комнат";
            buttonAreaGr_SOD.UseVisualStyleBackColor = true;
            buttonAreaGr_SOD.Click += buttonAreaGr_SOD_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBoxFunctions_BDA);
            panel2.Location = new Point(0, 80);
            panel2.Name = "panel2";
            panel2.Size = new Size(340, 436);
            panel2.TabIndex = 5;
            // 
            // FormMain
            // 
            ClientSize = new Size(1324, 728);
            Controls.Add(groupBoxButtons_BDA);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(groupBoxHelper_SOD);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Домоуправление";
            Load += FormMain_Load;
            groupBoxHelper_SOD.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewBase_SOD).EndInit();
            groupBoxButtons_BDA.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            groupBoxFunctions_BDA.ResumeLayout(false);
            groupBoxFunctions_BDA.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelTop_SOD;
        private System.Windows.Forms.MenuStrip menuStrip_SOD;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьКакToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выйтиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog_SOD;
        private System.Windows.Forms.SaveFileDialog saveFileDialog_SOD;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView_SOD;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberEntrance;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApartamentNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomsNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalArea;
        private System.Windows.Forms.DataGridViewTextBoxColumn Debt;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberFamilyMembers;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.OpenFileDialog openFileDialogMain_SOD;
        private System.Windows.Forms.SaveFileDialog saveFileDialogMain_SOD;
        private System.Windows.Forms.GroupBox groupBoxHelper_SOD;
        private System.Windows.Forms.Button buttonHelp_SOD;
        private System.Windows.Forms.Button buttonOpenBase_SOD;
        private System.Windows.Forms.Button buttonSave_SOD;
        public System.Windows.Forms.DataGridView dataGridViewBase_SOD;
        private System.Windows.Forms.GroupBox groupBoxButtons_BDA;
        private System.Windows.Forms.Button buttonViewBase_SOD;
        private System.Windows.Forms.Button buttonAdd_SOD;
        private System.Windows.Forms.Button buttonDelete_SOD;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button buttonEdit_SOD;
        private System.Windows.Forms.ToolTip toolTipInfo_SOD;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private GroupBox groupBoxFunctions_BDA;
        private Button buttonFilterCansel_SOD;
        private ComboBox comboBoxFilter_SOD;
        private Button buttonFilter_SOD;
        private TextBox textBoxAverage_SOD;
        private TextBox textBoxMax_SOD;
        private TextBox textBoxMin_SOD;
        private Button buttonMax_SOD;
        private Button buttonAverage_SOD;
        private Button buttonMin_SOD;
        private Label label2;
        private Label label1;
        private Button buttonKids_SOD;
        private Button buttonArea_SOD;
        private Button buttonFind_SOD;
        private TextBox textBoxFind_SOD;
        private Button buttonAreaGr_SOD;
        private Panel panel2;
    }
}
