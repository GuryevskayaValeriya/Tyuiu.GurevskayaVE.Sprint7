
namespace Tyuiu.GurevskayaVE.Sprint7.Project.V12
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.groupBoxIn_GVE = new System.Windows.Forms.GroupBox();
            this.dataGridViewIn_GVE = new System.Windows.Forms.DataGridView();
            this.saveFileDialog_GVE = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog_GVE = new System.Windows.Forms.OpenFileDialog();
            this.toolTip_GVE = new System.Windows.Forms.ToolTip(this.components);
            this.buttonOpen_GVE = new System.Windows.Forms.Button();
            this.buttonInfo_GVE = new System.Windows.Forms.Button();
            this.buttonStat_GVE = new System.Windows.Forms.Button();
            this.buttonSave_GVE = new System.Windows.Forms.Button();
            this.buttonFirma_GVE = new System.Windows.Forms.Button();
            this.buttonSortAlp_GVE = new System.Windows.Forms.Button();
            this.buttonSortData_GVE = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxFind_GVE = new System.Windows.Forms.TextBox();
            this.panelTop = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panelLeft.SuspendLayout();
            this.groupBoxIn_GVE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIn_GVE)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.Controls.Add(this.groupBoxIn_GVE);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 127);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(837, 492);
            this.panelLeft.TabIndex = 1;
            // 
            // groupBoxIn_GVE
            // 
            this.groupBoxIn_GVE.Controls.Add(this.dataGridViewIn_GVE);
            this.groupBoxIn_GVE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxIn_GVE.Location = new System.Drawing.Point(0, 0);
            this.groupBoxIn_GVE.Name = "groupBoxIn_GVE";
            this.groupBoxIn_GVE.Size = new System.Drawing.Size(837, 492);
            this.groupBoxIn_GVE.TabIndex = 0;
            this.groupBoxIn_GVE.TabStop = false;
            this.groupBoxIn_GVE.Text = "Ввод данных";
            // 
            // dataGridViewIn_GVE
            // 
            this.dataGridViewIn_GVE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIn_GVE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewIn_GVE.Location = new System.Drawing.Point(3, 18);
            this.dataGridViewIn_GVE.Name = "dataGridViewIn_GVE";
            this.dataGridViewIn_GVE.RowHeadersWidth = 51;
            this.dataGridViewIn_GVE.RowTemplate.Height = 24;
            this.dataGridViewIn_GVE.Size = new System.Drawing.Size(831, 471);
            this.dataGridViewIn_GVE.TabIndex = 0;
            // 
            // openFileDialog_GVE
            // 
            this.openFileDialog_GVE.FileName = "openFileDialog1";
            // 
            // buttonOpen_GVE
            // 
            this.buttonOpen_GVE.BackColor = System.Drawing.Color.Transparent;
            this.buttonOpen_GVE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOpen_GVE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpen_GVE.ForeColor = System.Drawing.Color.White;
            this.buttonOpen_GVE.Image = global::Tyuiu.GurevskayaVE.Sprint7.Project.V12.Properties.Resources.folder_add;
            this.buttonOpen_GVE.Location = new System.Drawing.Point(13, 13);
            this.buttonOpen_GVE.Name = "buttonOpen_GVE";
            this.buttonOpen_GVE.Size = new System.Drawing.Size(75, 75);
            this.buttonOpen_GVE.TabIndex = 1;
            this.toolTip_GVE.SetToolTip(this.buttonOpen_GVE, "Открыть файл");
            this.buttonOpen_GVE.UseVisualStyleBackColor = false;
            this.buttonOpen_GVE.Click += new System.EventHandler(this.buttonOpen_GVE_Click);
            this.buttonOpen_GVE.MouseEnter += new System.EventHandler(this.buttonOpen_GVE_MouseEnter);
            // 
            // buttonInfo_GVE
            // 
            this.buttonInfo_GVE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInfo_GVE.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonInfo_GVE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonInfo_GVE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInfo_GVE.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonInfo_GVE.Image = global::Tyuiu.GurevskayaVE.Sprint7.Project.V12.Properties.Resources.information;
            this.buttonInfo_GVE.Location = new System.Drawing.Point(1027, 12);
            this.buttonInfo_GVE.Name = "buttonInfo_GVE";
            this.buttonInfo_GVE.Size = new System.Drawing.Size(75, 75);
            this.buttonInfo_GVE.TabIndex = 0;
            this.toolTip_GVE.SetToolTip(this.buttonInfo_GVE, "Информация о программе");
            this.buttonInfo_GVE.UseVisualStyleBackColor = false;
            this.buttonInfo_GVE.Click += new System.EventHandler(this.buttonInfo_GVE_Click);
            this.buttonInfo_GVE.MouseEnter += new System.EventHandler(this.buttonInfo_GVE_MouseEnter);
            // 
            // buttonStat_GVE
            // 
            this.buttonStat_GVE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStat_GVE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(180)))), ((int)(((byte)(213)))));
            this.buttonStat_GVE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonStat_GVE.Enabled = false;
            this.buttonStat_GVE.Location = new System.Drawing.Point(972, 145);
            this.buttonStat_GVE.Name = "buttonStat_GVE";
            this.buttonStat_GVE.Size = new System.Drawing.Size(130, 60);
            this.buttonStat_GVE.TabIndex = 2;
            this.buttonStat_GVE.Text = "Статистика";
            this.toolTip_GVE.SetToolTip(this.buttonStat_GVE, "Открыть окно со статистикой");
            this.buttonStat_GVE.UseVisualStyleBackColor = false;
            this.buttonStat_GVE.Click += new System.EventHandler(this.buttonStat_GVE_Click);
            // 
            // buttonSave_GVE
            // 
            this.buttonSave_GVE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave_GVE.BackColor = System.Drawing.Color.Pink;
            this.buttonSave_GVE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSave_GVE.Enabled = false;
            this.buttonSave_GVE.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave_GVE.Location = new System.Drawing.Point(955, 536);
            this.buttonSave_GVE.Name = "buttonSave_GVE";
            this.buttonSave_GVE.Size = new System.Drawing.Size(147, 71);
            this.buttonSave_GVE.TabIndex = 5;
            this.buttonSave_GVE.Text = "Сохранить";
            this.toolTip_GVE.SetToolTip(this.buttonSave_GVE, "Сохранить измененный csv файл");
            this.buttonSave_GVE.UseVisualStyleBackColor = false;
            this.buttonSave_GVE.Click += new System.EventHandler(this.buttonSave_GVE_Click);
            // 
            // buttonFirma_GVE
            // 
            this.buttonFirma_GVE.BackColor = System.Drawing.Color.MistyRose;
            this.buttonFirma_GVE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFirma_GVE.Location = new System.Drawing.Point(845, 12);
            this.buttonFirma_GVE.Name = "buttonFirma_GVE";
            this.buttonFirma_GVE.Size = new System.Drawing.Size(162, 39);
            this.buttonFirma_GVE.TabIndex = 3;
            this.buttonFirma_GVE.Text = "Открыть фирмы";
            this.toolTip_GVE.SetToolTip(this.buttonFirma_GVE, "Открыть окно с фирмами");
            this.buttonFirma_GVE.UseVisualStyleBackColor = false;
            this.buttonFirma_GVE.Click += new System.EventHandler(this.buttonFirma_GVE_Click);
            // 
            // buttonSortAlp_GVE
            // 
            this.buttonSortAlp_GVE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSortAlp_GVE.BackColor = System.Drawing.Color.PaleVioletRed;
            this.buttonSortAlp_GVE.Cursor = System.Windows.Forms.Cursors.PanNorth;
            this.buttonSortAlp_GVE.Enabled = false;
            this.buttonSortAlp_GVE.Location = new System.Drawing.Point(972, 229);
            this.buttonSortAlp_GVE.Name = "buttonSortAlp_GVE";
            this.buttonSortAlp_GVE.Size = new System.Drawing.Size(130, 60);
            this.buttonSortAlp_GVE.TabIndex = 3;
            this.buttonSortAlp_GVE.Text = "Отсортировать по алфавиту";
            this.buttonSortAlp_GVE.UseVisualStyleBackColor = false;
            this.buttonSortAlp_GVE.Click += new System.EventHandler(this.buttonSortAlp_GVE_Click);
            // 
            // buttonSortData_GVE
            // 
            this.buttonSortData_GVE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSortData_GVE.BackColor = System.Drawing.Color.HotPink;
            this.buttonSortData_GVE.Cursor = System.Windows.Forms.Cursors.PanSouth;
            this.buttonSortData_GVE.Enabled = false;
            this.buttonSortData_GVE.Location = new System.Drawing.Point(972, 295);
            this.buttonSortData_GVE.Name = "buttonSortData_GVE";
            this.buttonSortData_GVE.Size = new System.Drawing.Size(130, 60);
            this.buttonSortData_GVE.TabIndex = 4;
            this.buttonSortData_GVE.Text = "Отсортировать по году выпуска";
            this.buttonSortData_GVE.UseVisualStyleBackColor = false;
            this.buttonSortData_GVE.Click += new System.EventHandler(this.buttonSortData_GVE_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxFind_GVE);
            this.groupBox1.Location = new System.Drawing.Point(108, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(190, 74);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Поиск по названию";
            // 
            // textBoxFind_GVE
            // 
            this.textBoxFind_GVE.Location = new System.Drawing.Point(6, 26);
            this.textBoxFind_GVE.Name = "textBoxFind_GVE";
            this.textBoxFind_GVE.Size = new System.Drawing.Size(100, 22);
            this.textBoxFind_GVE.TabIndex = 0;
            this.textBoxFind_GVE.TextChanged += new System.EventHandler(this.textBoxFind_GVE_TextChanged);
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.buttonFirma_GVE);
            this.panelTop.Controls.Add(this.groupBox1);
            this.panelTop.Controls.Add(this.buttonOpen_GVE);
            this.panelTop.Controls.Add(this.buttonInfo_GVE);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1114, 127);
            this.panelTop.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1114, 619);
            this.Controls.Add(this.buttonSave_GVE);
            this.Controls.Add(this.buttonSortData_GVE);
            this.Controls.Add(this.buttonSortAlp_GVE);
            this.Controls.Add(this.buttonStat_GVE);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 7 | Проект | Вариант 12 | Гурьевская В.Е.";
            this.panelLeft.ResumeLayout(false);
            this.groupBoxIn_GVE.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIn_GVE)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.GroupBox groupBoxIn_GVE;
        private System.Windows.Forms.DataGridView dataGridViewIn_GVE;
        private System.Windows.Forms.SaveFileDialog saveFileDialog_GVE;
        private System.Windows.Forms.OpenFileDialog openFileDialog_GVE;
        private System.Windows.Forms.ToolTip toolTip_GVE;
        private System.Windows.Forms.Button buttonStat_GVE;
        private System.Windows.Forms.Button buttonSortAlp_GVE;
        private System.Windows.Forms.Button buttonSortData_GVE;
        private System.Windows.Forms.Button buttonSave_GVE;
        private System.Windows.Forms.Button buttonInfo_GVE;
        private System.Windows.Forms.Button buttonOpen_GVE;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxFind_GVE;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button buttonFirma_GVE;
    }
}

