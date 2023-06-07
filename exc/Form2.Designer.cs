namespace exc
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.laundry_dbDataSet = new exc.Laundry_dbDataSet();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pakaianBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pakaianTableAdapter = new exc.Laundry_dbDataSetTableAdapters.pakaianTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.laundry_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pakaianBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.laundry_dbDataSet, "layanan.id_layanan", true));
            this.textBox1.Location = new System.Drawing.Point(470, 102);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(217, 26);
            this.textBox1.TabIndex = 0;
            // 
            // laundry_dbDataSet
            // 
            this.laundry_dbDataSet.DataSetName = "Laundry_dbDataSet";
            this.laundry_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pakaianBindingSource, "id_pakaian", true));
            this.textBox2.Location = new System.Drawing.Point(470, 160);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(217, 26);
            this.textBox2.TabIndex = 1;
            // 
            // pakaianBindingSource
            // 
            this.pakaianBindingSource.DataMember = "pakaian";
            this.pakaianBindingSource.DataSource = this.laundry_dbDataSet;
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.laundry_dbDataSet, "pegawai.id_pegawai", true));
            this.textBox3.Location = new System.Drawing.Point(470, 212);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(217, 26);
            this.textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.laundry_dbDataSet, "pelanggan.id_pelanggan", true));
            this.textBox4.Location = new System.Drawing.Point(470, 283);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(217, 26);
            this.textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.laundry_dbDataSet, "transaksi.id_transaksi", true));
            this.textBox5.Location = new System.Drawing.Point(470, 350);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(217, 26);
            this.textBox5.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("ROG Fonts", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(185, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(383, 48);
            this.label1.TabIndex = 5;
            this.label1.Text = "Data Binding";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("ROG Fonts", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(146, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Layanan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("ROG Fonts", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(146, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "Pakaian";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("ROG Fonts", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(146, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "Pegawai";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("ROG Fonts", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(146, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 22);
            this.label5.TabIndex = 9;
            this.label5.Text = "Pelanggan";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("ROG Fonts", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(146, 350);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 22);
            this.label6.TabIndex = 10;
            this.label6.Text = "Transaksi";
            // 
            // pakaianTableAdapter
            // 
            this.pakaianTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 391);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 47);
            this.button1.TabIndex = 11;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.laundry_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pakaianBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label6;
        private Laundry_dbDataSet laundry_dbDataSet;
        private System.Windows.Forms.BindingSource pakaianBindingSource;
        private Laundry_dbDataSetTableAdapters.pakaianTableAdapter pakaianTableAdapter;
        private System.Windows.Forms.Button button1;
    }
}