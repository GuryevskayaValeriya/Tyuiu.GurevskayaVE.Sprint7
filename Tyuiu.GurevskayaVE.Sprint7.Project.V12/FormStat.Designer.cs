
namespace Tyuiu.GurevskayaVE.Sprint7.Project.V12
{
    partial class FormStat
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
            this.panelLeft_GVE = new System.Windows.Forms.Panel();
            this.buttonSredOZU_GVE = new System.Windows.Forms.Button();
            this.textBoxSredOZU_GVE = new System.Windows.Forms.TextBox();
            this.panelLeft_GVE.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeft_GVE
            // 
            this.panelLeft_GVE.Controls.Add(this.buttonSredOZU_GVE);
            this.panelLeft_GVE.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_GVE.Location = new System.Drawing.Point(0, 0);
            this.panelLeft_GVE.Name = "panelLeft_GVE";
            this.panelLeft_GVE.Size = new System.Drawing.Size(134, 603);
            this.panelLeft_GVE.TabIndex = 0;
            // 
            // buttonSredOZU_GVE
            // 
            this.buttonSredOZU_GVE.Font = new System.Drawing.Font("Corbel", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSredOZU_GVE.Location = new System.Drawing.Point(12, 12);
            this.buttonSredOZU_GVE.Name = "buttonSredOZU_GVE";
            this.buttonSredOZU_GVE.Size = new System.Drawing.Size(105, 94);
            this.buttonSredOZU_GVE.TabIndex = 0;
            this.buttonSredOZU_GVE.Text = "Среднее значение объема памяти";
            this.buttonSredOZU_GVE.UseVisualStyleBackColor = true;
            this.buttonSredOZU_GVE.Click += new System.EventHandler(this.buttonSredOZU_GVE_Click);
            // 
            // textBoxSredOZU_GVE
            // 
            this.textBoxSredOZU_GVE.Location = new System.Drawing.Point(149, 48);
            this.textBoxSredOZU_GVE.Name = "textBoxSredOZU_GVE";
            this.textBoxSredOZU_GVE.ReadOnly = true;
            this.textBoxSredOZU_GVE.Size = new System.Drawing.Size(100, 22);
            this.textBoxSredOZU_GVE.TabIndex = 1;
            // 
            // FormStat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 603);
            this.Controls.Add(this.textBoxSredOZU_GVE);
            this.Controls.Add(this.panelLeft_GVE);
            this.Name = "FormStat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Статистические данные";
            this.panelLeft_GVE.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelLeft_GVE;
        private System.Windows.Forms.Button buttonSredOZU_GVE;
        private System.Windows.Forms.TextBox textBoxSredOZU_GVE;
    }
}