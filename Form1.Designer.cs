namespace DbHomework
{
    partial class hospitalTxt
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
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.dataGridView6 = new System.Windows.Forms.DataGridView();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(113, 456);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(301, 27);
            this.textBox3.TabIndex = 22;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(113, 554);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(301, 27);
            this.textBox4.TabIndex = 23;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(113, 370);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(301, 27);
            this.textBox5.TabIndex = 24;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 456);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "PatientName";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 370);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "ClinicName";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 561);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 27;
            this.label5.Text = "PatientId";
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(456, 295);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowHeadersWidth = 51;
            this.dataGridView4.RowTemplate.Height = 29;
            this.dataGridView4.Size = new System.Drawing.Size(300, 188);
            this.dataGridView4.TabIndex = 28;
            this.dataGridView4.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView4_CellContentClick);
            // 
            // dataGridView5
            // 
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Location = new System.Drawing.Point(626, 554);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.RowHeadersWidth = 51;
            this.dataGridView5.RowTemplate.Height = 29;
            this.dataGridView5.Size = new System.Drawing.Size(300, 188);
            this.dataGridView5.TabIndex = 29;
            // 
            // dataGridView6
            // 
            this.dataGridView6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView6.Location = new System.Drawing.Point(820, 295);
            this.dataGridView6.Name = "dataGridView6";
            this.dataGridView6.RowHeadersWidth = 51;
            this.dataGridView6.RowTemplate.Height = 29;
            this.dataGridView6.Size = new System.Drawing.Size(300, 188);
            this.dataGridView6.TabIndex = 30;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(467, 801);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(146, 54);
            this.button7.TabIndex = 31;
            this.button7.Text = "Display Clinic";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(467, 977);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(146, 54);
            this.button8.TabIndex = 32;
            this.button8.Text = "Search Patient";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(674, 801);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(146, 54);
            this.button9.TabIndex = 33;
            this.button9.Text = "Display Patient";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(674, 977);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(146, 54);
            this.button10.TabIndex = 34;
            this.button10.Text = "Insert Patient";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(467, 896);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(146, 54);
            this.button6.TabIndex = 35;
            this.button6.Text = "Update Patient";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(674, 896);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(146, 54);
            this.button11.TabIndex = 36;
            this.button11.Text = "Delete Patient";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // hospitalTxt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1308, 1055);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.dataGridView6);
            this.Controls.Add(this.dataGridView5);
            this.Controls.Add(this.dataGridView4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Name = "hospitalTxt";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label3;
        private Label label4;
        private Label label5;
        private DataGridView dataGridView4;
        private DataGridView dataGridView5;
        private DataGridView dataGridView6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button6;
        private Button button11;
    }
}