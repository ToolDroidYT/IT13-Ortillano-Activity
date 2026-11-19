namespace Ortillano_Activity
{
    partial class Form1
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
            this.Btn_Submit = new System.Windows.Forms.Button();
            this.Btn_Print = new System.Windows.Forms.Button();
            this.Btn_Clear = new System.Windows.Forms.Button();
            this.label_salesPersonLegend = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_salesPersonInitial = new System.Windows.Forms.TextBox();
            this.textBox_AmountOfSale = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_Results = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn_Submit
            // 
            this.Btn_Submit.BackColor = System.Drawing.Color.PaleGreen;
            this.Btn_Submit.Location = new System.Drawing.Point(292, 195);
            this.Btn_Submit.Name = "Btn_Submit";
            this.Btn_Submit.Size = new System.Drawing.Size(75, 40);
            this.Btn_Submit.TabIndex = 0;
            this.Btn_Submit.Text = "Submit";
            this.Btn_Submit.UseVisualStyleBackColor = false;
            this.Btn_Submit.Click += new System.EventHandler(this.Btn_Submit_Click);
            // 
            // Btn_Print
            // 
            this.Btn_Print.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_Print.Location = new System.Drawing.Point(454, 195);
            this.Btn_Print.Name = "Btn_Print";
            this.Btn_Print.Size = new System.Drawing.Size(75, 40);
            this.Btn_Print.TabIndex = 1;
            this.Btn_Print.Text = "Print";
            this.Btn_Print.UseVisualStyleBackColor = false;
            this.Btn_Print.Click += new System.EventHandler(this.Btn_Print_Click);
            // 
            // Btn_Clear
            // 
            this.Btn_Clear.BackColor = System.Drawing.Color.LightCoral;
            this.Btn_Clear.Location = new System.Drawing.Point(373, 195);
            this.Btn_Clear.Name = "Btn_Clear";
            this.Btn_Clear.Size = new System.Drawing.Size(75, 40);
            this.Btn_Clear.TabIndex = 2;
            this.Btn_Clear.Text = "Clear";
            this.Btn_Clear.UseVisualStyleBackColor = false;
            this.Btn_Clear.Click += new System.EventHandler(this.Btn_Clear_Click);
            // 
            // label_salesPersonLegend
            // 
            this.label_salesPersonLegend.AutoSize = true;
            this.label_salesPersonLegend.Location = new System.Drawing.Point(290, 72);
            this.label_salesPersonLegend.Name = "label_salesPersonLegend";
            this.label_salesPersonLegend.Size = new System.Drawing.Size(77, 48);
            this.label_salesPersonLegend.TabIndex = 3;
            this.label_salesPersonLegend.Text = "D - Danielle\r\nE - Edward\r\nF - Fatima";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter Sales Person Intial:";
            // 
            // textBox_salesPersonInitial
            // 
            this.textBox_salesPersonInitial.Location = new System.Drawing.Point(292, 139);
            this.textBox_salesPersonInitial.Name = "textBox_salesPersonInitial";
            this.textBox_salesPersonInitial.Size = new System.Drawing.Size(237, 22);
            this.textBox_salesPersonInitial.TabIndex = 5;
            // 
            // textBox_AmountOfSale
            // 
            this.textBox_AmountOfSale.Location = new System.Drawing.Point(292, 167);
            this.textBox_AmountOfSale.Name = "textBox_AmountOfSale";
            this.textBox_AmountOfSale.Size = new System.Drawing.Size(237, 22);
            this.textBox_AmountOfSale.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(186, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Amount of Sale:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.89565F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(233, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Home Sales Tracking Application";
            // 
            // label_Results
            // 
            this.label_Results.AutoSize = true;
            this.label_Results.Location = new System.Drawing.Point(290, 251);
            this.label_Results.Name = "label_Results";
            this.label_Results.Size = new System.Drawing.Size(0, 16);
            this.label_Results.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_Results);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_AmountOfSale);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_salesPersonInitial);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_salesPersonLegend);
            this.Controls.Add(this.Btn_Clear);
            this.Controls.Add(this.Btn_Print);
            this.Controls.Add(this.Btn_Submit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Submit;
        private System.Windows.Forms.Button Btn_Print;
        private System.Windows.Forms.Button Btn_Clear;
        private System.Windows.Forms.Label label_salesPersonLegend;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_salesPersonInitial;
        private System.Windows.Forms.TextBox textBox_AmountOfSale;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_Results;
    }
}

