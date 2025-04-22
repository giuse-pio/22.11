namespace _22._11
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
            this.lblNuovaData = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblDiffDate = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.btmSomma = new System.Windows.Forms.Button();
            this.btmSottrai = new System.Windows.Forms.Button();
            this.txtGiorni = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNuovaData
            // 
            this.lblNuovaData.AutoSize = true;
            this.lblNuovaData.Location = new System.Drawing.Point(201, 273);
            this.lblNuovaData.Name = "lblNuovaData";
            this.lblNuovaData.Size = new System.Drawing.Size(0, 13);
            this.lblNuovaData.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(164, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 46);
            this.button1.TabIndex = 2;
            this.button1.Text = "calcola date";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblDiffDate
            // 
            this.lblDiffDate.AutoSize = true;
            this.lblDiffDate.Location = new System.Drawing.Point(391, 46);
            this.lblDiffDate.Name = "lblDiffDate";
            this.lblDiffDate.Size = new System.Drawing.Size(0, 13);
            this.lblDiffDate.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(38, 40);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(160, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(204, 40);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(160, 20);
            this.dateTimePicker2.TabIndex = 5;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(59, 208);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(160, 20);
            this.dateTimePicker3.TabIndex = 6;
            // 
            // btmSomma
            // 
            this.btmSomma.Location = new System.Drawing.Point(377, 182);
            this.btmSomma.Name = "btmSomma";
            this.btmSomma.Size = new System.Drawing.Size(100, 32);
            this.btmSomma.TabIndex = 7;
            this.btmSomma.Text = "Aggiungi Giorni";
            this.btmSomma.UseVisualStyleBackColor = true;
            this.btmSomma.Click += new System.EventHandler(this.btmSomma_Click);
            // 
            // btmSottrai
            // 
            this.btmSottrai.Location = new System.Drawing.Point(377, 220);
            this.btmSottrai.Name = "btmSottrai";
            this.btmSottrai.Size = new System.Drawing.Size(99, 32);
            this.btmSottrai.TabIndex = 8;
            this.btmSottrai.Text = "Sottrai Giorni";
            this.btmSottrai.UseVisualStyleBackColor = true;
            this.btmSottrai.Click += new System.EventHandler(this.btmSottrai_Click);
            // 
            // txtGiorni
            // 
            this.txtGiorni.Location = new System.Drawing.Point(242, 207);
            this.txtGiorni.Name = "txtGiorni";
            this.txtGiorni.Size = new System.Drawing.Size(110, 20);
            this.txtGiorni.TabIndex = 10;
            this.txtGiorni.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtGiorni_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(275, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Giorni";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 325);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGiorni);
            this.Controls.Add(this.lblNuovaData);
            this.Controls.Add(this.btmSottrai);
            this.Controls.Add(this.btmSomma);
            this.Controls.Add(this.dateTimePicker3);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblDiffDate);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNuovaData;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblDiffDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Button btmSomma;
        private System.Windows.Forms.Button btmSottrai;
        private System.Windows.Forms.TextBox txtGiorni;
        private System.Windows.Forms.Label label1;
    }
}

