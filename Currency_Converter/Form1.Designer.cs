namespace Currency_Converter
{
    partial class frmmain
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
            this.btnAddCurrency = new System.Windows.Forms.Button();
            this.txtcurrency = new System.Windows.Forms.TextBox();
            this.dgcurrencis = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbstart = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbend = new System.Windows.Forms.ComboBox();
            this.txtamont = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnconfig = new System.Windows.Forms.Button();
            this.dgconfig = new System.Windows.Forms.DataGridView();
            this.btnclear = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbstart2 = new System.Windows.Forms.ComboBox();
            this.cmbend2 = new System.Windows.Forms.ComboBox();
            this.btnconvert = new System.Windows.Forms.Button();
            this.txtres = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btndelete = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtcount = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtrout = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgcurrencis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgconfig)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddCurrency
            // 
            this.btnAddCurrency.Location = new System.Drawing.Point(822, 15);
            this.btnAddCurrency.Name = "btnAddCurrency";
            this.btnAddCurrency.Size = new System.Drawing.Size(103, 35);
            this.btnAddCurrency.TabIndex = 0;
            this.btnAddCurrency.Text = "AddCurrency";
            this.btnAddCurrency.UseVisualStyleBackColor = true;
            this.btnAddCurrency.Click += new System.EventHandler(this.btnAddCurrency_Click);
            // 
            // txtcurrency
            // 
            this.txtcurrency.Location = new System.Drawing.Point(680, 15);
            this.txtcurrency.Multiline = true;
            this.txtcurrency.Name = "txtcurrency";
            this.txtcurrency.Size = new System.Drawing.Size(136, 35);
            this.txtcurrency.TabIndex = 1;
            // 
            // dgcurrencis
            // 
            this.dgcurrencis.AllowUserToAddRows = false;
            this.dgcurrencis.AllowUserToDeleteRows = false;
            this.dgcurrencis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgcurrencis.Location = new System.Drawing.Point(680, 56);
            this.dgcurrencis.Name = "dgcurrencis";
            this.dgcurrencis.ReadOnly = true;
            this.dgcurrencis.Size = new System.Drawing.Size(245, 138);
            this.dgcurrencis.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "StartNode";
            // 
            // cmbstart
            // 
            this.cmbstart.FormattingEnabled = true;
            this.cmbstart.Location = new System.Drawing.Point(60, 15);
            this.cmbstart.Name = "cmbstart";
            this.cmbstart.Size = new System.Drawing.Size(121, 21);
            this.cmbstart.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "EndNode";
            // 
            // cmbend
            // 
            this.cmbend.FormattingEnabled = true;
            this.cmbend.Location = new System.Drawing.Point(242, 15);
            this.cmbend.Name = "cmbend";
            this.cmbend.Size = new System.Drawing.Size(121, 21);
            this.cmbend.TabIndex = 4;
            // 
            // txtamont
            // 
            this.txtamont.Location = new System.Drawing.Point(407, 12);
            this.txtamont.Multiline = true;
            this.txtamont.Name = "txtamont";
            this.txtamont.Size = new System.Drawing.Size(100, 38);
            this.txtamont.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(369, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Amont";
            // 
            // btnconfig
            // 
            this.btnconfig.Location = new System.Drawing.Point(519, 12);
            this.btnconfig.Name = "btnconfig";
            this.btnconfig.Size = new System.Drawing.Size(75, 38);
            this.btnconfig.TabIndex = 6;
            this.btnconfig.Text = "Config";
            this.btnconfig.UseVisualStyleBackColor = true;
            this.btnconfig.Click += new System.EventHandler(this.btnconfig_Click);
            // 
            // dgconfig
            // 
            this.dgconfig.AllowUserToAddRows = false;
            this.dgconfig.AllowUserToDeleteRows = false;
            this.dgconfig.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgconfig.Location = new System.Drawing.Point(11, 56);
            this.dgconfig.Name = "dgconfig";
            this.dgconfig.ReadOnly = true;
            this.dgconfig.Size = new System.Drawing.Size(583, 167);
            this.dgconfig.TabIndex = 7;
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(600, 56);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(75, 167);
            this.btnclear.TabIndex = 8;
            this.btnclear.Text = "Clear Config";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "StartNode";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(187, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "EndNode";
            // 
            // cmbstart2
            // 
            this.cmbstart2.FormattingEnabled = true;
            this.cmbstart2.Location = new System.Drawing.Point(60, 243);
            this.cmbstart2.Name = "cmbstart2";
            this.cmbstart2.Size = new System.Drawing.Size(121, 21);
            this.cmbstart2.TabIndex = 11;
            // 
            // cmbend2
            // 
            this.cmbend2.FormattingEnabled = true;
            this.cmbend2.Location = new System.Drawing.Point(242, 243);
            this.cmbend2.Name = "cmbend2";
            this.cmbend2.Size = new System.Drawing.Size(121, 21);
            this.cmbend2.TabIndex = 12;
            // 
            // btnconvert
            // 
            this.btnconvert.Location = new System.Drawing.Point(557, 244);
            this.btnconvert.Name = "btnconvert";
            this.btnconvert.Size = new System.Drawing.Size(143, 23);
            this.btnconvert.TabIndex = 13;
            this.btnconvert.Text = "Convert";
            this.btnconvert.UseVisualStyleBackColor = true;
            this.btnconvert.Click += new System.EventHandler(this.btnconvert_Click);
            // 
            // txtres
            // 
            this.txtres.Location = new System.Drawing.Point(90, 270);
            this.txtres.Name = "txtres";
            this.txtres.Size = new System.Drawing.Size(273, 20);
            this.txtres.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 272);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "AmontResult";
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(680, 200);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(245, 23);
            this.btndelete.TabIndex = 16;
            this.btndelete.Text = "DeleteCurrency";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(369, 246);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Count";
            // 
            // txtcount
            // 
            this.txtcount.Location = new System.Drawing.Point(407, 241);
            this.txtcount.Name = "txtcount";
            this.txtcount.Size = new System.Drawing.Size(125, 20);
            this.txtcount.TabIndex = 17;
            this.txtcount.Text = "1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 298);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "RoutResult";
            // 
            // txtrout
            // 
            this.txtrout.Location = new System.Drawing.Point(90, 298);
            this.txtrout.Name = "txtrout";
            this.txtrout.Size = new System.Drawing.Size(273, 20);
            this.txtrout.TabIndex = 14;
            // 
            // frmmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 336);
            this.Controls.Add(this.txtcount);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.txtrout);
            this.Controls.Add(this.txtres);
            this.Controls.Add(this.btnconvert);
            this.Controls.Add(this.cmbend2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbstart2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.dgconfig);
            this.Controls.Add(this.btnconfig);
            this.Controls.Add(this.txtamont);
            this.Controls.Add(this.cmbend);
            this.Controls.Add(this.cmbstart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgcurrencis);
            this.Controls.Add(this.txtcurrency);
            this.Controls.Add(this.btnAddCurrency);
            this.Name = "frmmain";
            this.Text = "CurrencyConverter";
            this.Load += new System.EventHandler(this.frmmain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgcurrencis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgconfig)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddCurrency;
        private System.Windows.Forms.TextBox txtcurrency;
        private System.Windows.Forms.DataGridView dgcurrencis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbstart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbend;
        private System.Windows.Forms.TextBox txtamont;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnconfig;
        private System.Windows.Forms.DataGridView dgconfig;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbstart2;
        private System.Windows.Forms.ComboBox cmbend2;
        private System.Windows.Forms.Button btnconvert;
        private System.Windows.Forms.TextBox txtres;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtcount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtrout;
    }
}

