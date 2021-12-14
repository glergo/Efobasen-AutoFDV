namespace Efobasen_AutoFDV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label_logo = new System.Windows.Forms.Label();
            this.btn_hent_fdv = new System.Windows.Forms.Button();
            this.btn_om_autofdv = new System.Windows.Forms.Button();
            this.groupBoxelnr = new System.Windows.Forms.GroupBox();
            this.textBox_elnr = new System.Windows.Forms.TextBox();
            this.groupBoxelnr.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_logo
            // 
            this.label_logo.AutoSize = true;
            this.label_logo.Font = new System.Drawing.Font("Segoe UI Emoji", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_logo.Location = new System.Drawing.Point(32, 9);
            this.label_logo.Name = "label_logo";
            this.label_logo.Size = new System.Drawing.Size(704, 106);
            this.label_logo.TabIndex = 0;
            this.label_logo.Text = "Efobasen AutoFDV";
            // 
            // btn_hent_fdv
            // 
            this.btn_hent_fdv.Location = new System.Drawing.Point(42, 202);
            this.btn_hent_fdv.Name = "btn_hent_fdv";
            this.btn_hent_fdv.Size = new System.Drawing.Size(172, 34);
            this.btn_hent_fdv.TabIndex = 2;
            this.btn_hent_fdv.Text = "Hent FDV";
            this.btn_hent_fdv.UseVisualStyleBackColor = true;
            this.btn_hent_fdv.Click += new System.EventHandler(this.btn_hent_fdv_Click);
            // 
            // btn_om_autofdv
            // 
            this.btn_om_autofdv.Location = new System.Drawing.Point(543, 202);
            this.btn_om_autofdv.Name = "btn_om_autofdv";
            this.btn_om_autofdv.Size = new System.Drawing.Size(158, 34);
            this.btn_om_autofdv.TabIndex = 3;
            this.btn_om_autofdv.Text = "Om AutoFDV";
            this.btn_om_autofdv.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_om_autofdv.UseVisualStyleBackColor = true;
            this.btn_om_autofdv.Click += new System.EventHandler(this.btn_om_autofdv_Click);
            // 
            // groupBoxelnr
            // 
            this.groupBoxelnr.Controls.Add(this.textBox_elnr);
            this.groupBoxelnr.Location = new System.Drawing.Point(42, 118);
            this.groupBoxelnr.Name = "groupBoxelnr";
            this.groupBoxelnr.Size = new System.Drawing.Size(665, 78);
            this.groupBoxelnr.TabIndex = 1;
            this.groupBoxelnr.TabStop = false;
            this.groupBoxelnr.Text = "El nummer";
            // 
            // textBox_elnr
            // 
            this.textBox_elnr.Location = new System.Drawing.Point(6, 30);
            this.textBox_elnr.Name = "textBox_elnr";
            this.textBox_elnr.Size = new System.Drawing.Size(653, 31);
            this.textBox_elnr.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 249);
            this.Controls.Add(this.btn_om_autofdv);
            this.Controls.Add(this.btn_hent_fdv);
            this.Controls.Add(this.groupBoxelnr);
            this.Controls.Add(this.label_logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Efobasen AutoFDV";
            this.groupBoxelnr.ResumeLayout(false);
            this.groupBoxelnr.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label_logo;
        private Button btn_hent_fdv;
        private Button btn_om_autofdv;
        private GroupBox groupBoxelnr;
        private TextBox textBox_elnr;
    }
}