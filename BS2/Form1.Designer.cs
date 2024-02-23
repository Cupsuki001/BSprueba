namespace BS2
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
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            MSKcarnt = new MaskedTextBox();
            TXBnom = new TextBox();
            TXBapell = new TextBox();
            MSKacum = new MaskedTextBox();
            MSKexam = new MaskedTextBox();
            TXBfinal = new TextBox();
            groupBox1 = new GroupBox();
            TXBrefresc = new Button();
            BTNbase = new Button();
            BTNsalir = new Button();
            BTNcalc = new Button();
            LBLres = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7 });
            dataGridView1.Location = new Point(45, 169);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(734, 267);
            dataGridView1.TabIndex = 0;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // Column1
            // 
            Column1.HeaderText = "Carnet";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Nombre";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Apellido";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Acumulado";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "Examen";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 125;
            // 
            // Column6
            // 
            Column6.HeaderText = "Nota final";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 125;
            // 
            // Column7
            // 
            Column7.HeaderText = "id";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.Width = 125;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 31);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 1;
            label1.Text = "Carnet";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(227, 31);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 2;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(390, 31);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 3;
            label3.Text = "Apellido";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(543, 31);
            label4.Name = "label4";
            label4.Size = new Size(85, 20);
            label4.TabIndex = 4;
            label4.Text = "Acumulado";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(705, 31);
            label5.Name = "label5";
            label5.Size = new Size(61, 20);
            label5.TabIndex = 5;
            label5.Text = "Examen";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(854, 31);
            label6.Name = "label6";
            label6.Size = new Size(75, 20);
            label6.TabIndex = 6;
            label6.Text = "Nota final";
            // 
            // MSKcarnt
            // 
            MSKcarnt.Location = new Point(45, 97);
            MSKcarnt.Margin = new Padding(3, 4, 3, 4);
            MSKcarnt.Mask = "9999";
            MSKcarnt.Name = "MSKcarnt";
            MSKcarnt.Size = new Size(114, 27);
            MSKcarnt.TabIndex = 7;
            MSKcarnt.ValidatingType = typeof(int);
            // 
            // TXBnom
            // 
            TXBnom.Location = new Point(198, 97);
            TXBnom.Margin = new Padding(3, 4, 3, 4);
            TXBnom.Name = "TXBnom";
            TXBnom.Size = new Size(114, 27);
            TXBnom.TabIndex = 8;
            TXBnom.KeyPress += TXBnom_KeyPress;
            // 
            // TXBapell
            // 
            TXBapell.Location = new Point(367, 97);
            TXBapell.Margin = new Padding(3, 4, 3, 4);
            TXBapell.Name = "TXBapell";
            TXBapell.Size = new Size(114, 27);
            TXBapell.TabIndex = 9;
            TXBapell.KeyPress += TXBapell_KeyPress;
            // 
            // MSKacum
            // 
            MSKacum.Location = new Point(529, 97);
            MSKacum.Margin = new Padding(3, 4, 3, 4);
            MSKacum.Mask = "99";
            MSKacum.Name = "MSKacum";
            MSKacum.Size = new Size(114, 27);
            MSKacum.TabIndex = 10;
            MSKacum.ValidatingType = typeof(int);
            // 
            // MSKexam
            // 
            MSKexam.Location = new Point(682, 95);
            MSKexam.Margin = new Padding(3, 4, 3, 4);
            MSKexam.Mask = "99";
            MSKexam.Name = "MSKexam";
            MSKexam.Size = new Size(114, 27);
            MSKexam.TabIndex = 11;
            MSKexam.ValidatingType = typeof(int);
            // 
            // TXBfinal
            // 
            TXBfinal.Location = new Point(832, 95);
            TXBfinal.Margin = new Padding(3, 4, 3, 4);
            TXBfinal.Name = "TXBfinal";
            TXBfinal.Size = new Size(114, 27);
            TXBfinal.TabIndex = 12;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.LightGray;
            groupBox1.Controls.Add(TXBrefresc);
            groupBox1.Controls.Add(BTNbase);
            groupBox1.Controls.Add(BTNsalir);
            groupBox1.Controls.Add(BTNcalc);
            groupBox1.Location = new Point(807, 169);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(174, 267);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Opciones";
            // 
            // TXBrefresc
            // 
            TXBrefresc.Location = new Point(43, 219);
            TXBrefresc.Name = "TXBrefresc";
            TXBrefresc.Size = new Size(94, 29);
            TXBrefresc.TabIndex = 3;
            TXBrefresc.Text = "Refrescar";
            TXBrefresc.UseVisualStyleBackColor = true;
            TXBrefresc.Click += TXBrefresc_Click;
            // 
            // BTNbase
            // 
            BTNbase.Location = new Point(25, 181);
            BTNbase.Margin = new Padding(3, 4, 3, 4);
            BTNbase.Name = "BTNbase";
            BTNbase.Size = new Size(126, 31);
            BTNbase.TabIndex = 2;
            BTNbase.Text = "Ver base actual";
            BTNbase.UseVisualStyleBackColor = true;
            BTNbase.Click += BTNbase_Click;
            // 
            // BTNsalir
            // 
            BTNsalir.Location = new Point(43, 128);
            BTNsalir.Margin = new Padding(3, 4, 3, 4);
            BTNsalir.Name = "BTNsalir";
            BTNsalir.Size = new Size(86, 31);
            BTNsalir.TabIndex = 1;
            BTNsalir.Text = "Salir";
            BTNsalir.UseVisualStyleBackColor = true;
            BTNsalir.Click += BTNsalir_Click;
            // 
            // BTNcalc
            // 
            BTNcalc.Location = new Point(43, 60);
            BTNcalc.Margin = new Padding(3, 4, 3, 4);
            BTNcalc.Name = "BTNcalc";
            BTNcalc.Size = new Size(86, 31);
            BTNcalc.TabIndex = 0;
            BTNcalc.Text = "Calcular";
            BTNcalc.UseVisualStyleBackColor = true;
            BTNcalc.Click += BTNcalc_Click;
            // 
            // LBLres
            // 
            LBLres.AutoSize = true;
            LBLres.Location = new Point(1005, 96);
            LBLres.Name = "LBLres";
            LBLres.Size = new Size(17, 20);
            LBLres.TabIndex = 14;
            LBLres.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1138, 471);
            Controls.Add(LBLres);
            Controls.Add(groupBox1);
            Controls.Add(TXBfinal);
            Controls.Add(MSKexam);
            Controls.Add(MSKacum);
            Controls.Add(TXBapell);
            Controls.Add(TXBnom);
            Controls.Add(MSKcarnt);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private MaskedTextBox MSKcarnt;
        private TextBox TXBnom;
        private TextBox TXBapell;
        private MaskedTextBox MSKacum;
        private MaskedTextBox MSKexam;
        private TextBox TXBfinal;
        private GroupBox groupBox1;
        private Button BTNsalir;
        private Button BTNcalc;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        public Button BTNbase;
        private DataGridViewTextBoxColumn Column7;
        private Button TXBrefresc;
        private Label LBLres;
    }
}