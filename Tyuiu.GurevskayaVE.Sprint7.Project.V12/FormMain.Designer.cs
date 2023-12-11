
namespace Tyuiu.GurevskayaVE.Sprint7.Project.V12
{
    partial class FormMain
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonInfo_GVE = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.button4);
            this.panelTop.Controls.Add(this.button3);
            this.panelTop.Controls.Add(this.buttonInfo_GVE);
            this.panelTop.Controls.Add(this.button1);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1089, 135);
            this.panelTop.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // buttonInfo_GVE
            // 
            this.buttonInfo_GVE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInfo_GVE.Image = global::Tyuiu.GurevskayaVE.Sprint7.Project.V12.Properties.Resources.information;
            this.buttonInfo_GVE.Location = new System.Drawing.Point(977, 12);
            this.buttonInfo_GVE.Name = "buttonInfo_GVE";
            this.buttonInfo_GVE.Size = new System.Drawing.Size(100, 75);
            this.buttonInfo_GVE.TabIndex = 1;
            this.buttonInfo_GVE.UseVisualStyleBackColor = true;
            this.buttonInfo_GVE.Click += new System.EventHandler(this.buttonInfo_GVE_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(107, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(211, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 535);
            this.Controls.Add(this.panelTop);
            this.Name = "FormAbout";
            this.Text = "Спринт 7 | Проект | Вариант 12 | Гурьевская В.Е.";
            this.panelTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonInfo_GVE;
        private System.Windows.Forms.Button button1;
    }
}