namespace responsi2024
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
            pictureBox1 = new PictureBox();
            lblLogo = new Label();
            lblKaryawan = new Label();
            tbNama = new TextBox();
            lblDep = new Label();
            cbDept = new ComboBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            btnInsert = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            dgvData = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            lblJabatan = new Label();
            tbJabatan = new TextBox();
            btnLoad = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(25, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(71, 58);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblLogo
            // 
            lblLogo.AutoSize = true;
            lblLogo.Location = new Point(111, 36);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(34, 15);
            lblLogo.TabIndex = 1;
            lblLogo.Text = "Logo";
            // 
            // lblKaryawan
            // 
            lblKaryawan.AutoSize = true;
            lblKaryawan.Location = new Point(75, 94);
            lblKaryawan.Name = "lblKaryawan";
            lblKaryawan.Size = new Size(99, 15);
            lblKaryawan.TabIndex = 2;
            lblKaryawan.Text = "Nama Karyawan :";
            // 
            // tbNama
            // 
            tbNama.Location = new Point(180, 91);
            tbNama.Name = "tbNama";
            tbNama.Size = new Size(175, 23);
            tbNama.TabIndex = 3;
            // 
            // lblDep
            // 
            lblDep.AutoSize = true;
            lblDep.Location = new Point(74, 128);
            lblDep.Name = "lblDep";
            lblDep.Size = new Size(91, 15);
            lblDep.TabIndex = 4;
            lblDep.Text = "Dep. Karyawan :";
            // 
            // cbDept
            // 
            cbDept.FormattingEnabled = true;
            cbDept.Location = new Point(180, 125);
            cbDept.Name = "cbDept";
            cbDept.Size = new Size(175, 23);
            cbDept.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(123, 90);
            label1.TabIndex = 6;
            label1.Text = "ID Departemen: \r\nHR: HR\r\nENG : Engineer\r\nDEV: Developer\r\nPM: Product Manager\r\nFIN: Finance";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(492, 61);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 126);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(76, 199);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(131, 32);
            btnInsert.TabIndex = 8;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(246, 199);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(131, 32);
            btnEdit.TabIndex = 9;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(411, 199);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(131, 32);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgvData
            // 
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new Point(75, 265);
            dgvData.Name = "dgvData";
            dgvData.RowTemplate.Height = 25;
            dgvData.Size = new Size(617, 150);
            dgvData.TabIndex = 11;
            dgvData.CellContentClick += dgvData_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(75, 241);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 12;
            label2.Text = "ID Karyawan: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(159, 241);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 13;
            label3.Click += label3_Click;
            // 
            // lblJabatan
            // 
            lblJabatan.AutoSize = true;
            lblJabatan.Location = new Point(76, 166);
            lblJabatan.Name = "lblJabatan";
            lblJabatan.Size = new Size(53, 15);
            lblJabatan.TabIndex = 14;
            lblJabatan.Text = "Jabatan :";
            // 
            // tbJabatan
            // 
            tbJabatan.Location = new Point(181, 158);
            tbJabatan.Name = "tbJabatan";
            tbJabatan.Size = new Size(174, 23);
            tbJabatan.TabIndex = 15;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(704, 415);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(75, 23);
            btnLoad.TabIndex = 16;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLoad);
            Controls.Add(tbJabatan);
            Controls.Add(lblJabatan);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dgvData);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnInsert);
            Controls.Add(groupBox1);
            Controls.Add(cbDept);
            Controls.Add(lblDep);
            Controls.Add(tbNama);
            Controls.Add(lblKaryawan);
            Controls.Add(lblLogo);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblLogo;
        private Label lblKaryawan;
        private TextBox tbNama;
        private Label lblDep;
        private ComboBox cbDept;
        private Label label1;
        private GroupBox groupBox1;
        private Button btnInsert;
        private Button btnEdit;
        private Button btnDelete;
        private DataGridView dgvData;
        private Label label2;
        private Label label3;
        private Label lblJabatan;
        private TextBox tbJabatan;
        private Button btnLoad;
    }
}
