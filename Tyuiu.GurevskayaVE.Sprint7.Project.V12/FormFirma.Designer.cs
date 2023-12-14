
namespace Tyuiu.GurevskayaVE.Sprint7.Project.V12
{
    partial class FormFirma
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewInFirma_GVE = new System.Windows.Forms.DataGridView();
            this.buttonBrowser_GVE = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInFirma_GVE)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewInFirma_GVE
            // 
            this.dataGridViewInFirma_GVE.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewInFirma_GVE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInFirma_GVE.Location = new System.Drawing.Point(12, 13);
            this.dataGridViewInFirma_GVE.Name = "dataGridViewInFirma_GVE";
            this.dataGridViewInFirma_GVE.RowHeadersWidth = 51;
            this.dataGridViewInFirma_GVE.RowTemplate.Height = 24;
            this.dataGridViewInFirma_GVE.Size = new System.Drawing.Size(640, 338);
            this.dataGridViewInFirma_GVE.TabIndex = 0;
            // 
            // buttonBrowser_GVE
            // 
            this.buttonBrowser_GVE.Location = new System.Drawing.Point(13, 358);
            this.buttonBrowser_GVE.Name = "buttonBrowser_GVE";
            this.buttonBrowser_GVE.Size = new System.Drawing.Size(161, 45);
            this.buttonBrowser_GVE.TabIndex = 2;
            this.buttonBrowser_GVE.Text = "Открыть браузер";
            this.buttonBrowser_GVE.UseVisualStyleBackColor = true;
            this.buttonBrowser_GVE.Click += new System.EventHandler(this.buttonBrowser_GVE_Click);
            // 
            // FormFirma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 412);
            this.Controls.Add(this.buttonBrowser_GVE);
            this.Controls.Add(this.dataGridViewInFirma_GVE);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormFirma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Фирмы";
            this.Load += new System.EventHandler(this.FormFirma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInFirma_GVE)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewInFirma_GVE;
        private System.Windows.Forms.Button buttonBrowser_GVE;
    }
}