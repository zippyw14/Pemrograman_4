﻿namespace imput_data_mahasiswa
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
            this.btnSimpan = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnTampilkanData = new System.Windows.Forms.Button();
            this.txtNim = new System.Windows.Forms.TextBox();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.txtKelas = new System.Windows.Forms.TextBox();
            this.txtNilai = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.lvwMahasiswa = new System.Windows.Forms.ListView();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(35, 203);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(75, 23);
            this.btnSimpan.TabIndex = 0;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nim";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Kelas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nilai";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lvwMahasiswa);
            this.groupBox1.Controls.Add(this.btnHapus);
            this.groupBox1.Controls.Add(this.btnTampilkanData);
            this.groupBox1.Location = new System.Drawing.Point(303, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(485, 332);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Daftar Mahasiswa";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(112, 26);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(113, 23);
            this.btnHapus.TabIndex = 12;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnTampilkanData
            // 
            this.btnTampilkanData.Location = new System.Drawing.Point(0, 26);
            this.btnTampilkanData.Name = "btnTampilkanData";
            this.btnTampilkanData.Size = new System.Drawing.Size(106, 23);
            this.btnTampilkanData.TabIndex = 11;
            this.btnTampilkanData.Text = "Tampailkan Data";
            this.btnTampilkanData.UseVisualStyleBackColor = true;
            this.btnTampilkanData.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtNim
            // 
            this.txtNim.Location = new System.Drawing.Point(116, 62);
            this.txtNim.Name = "txtNim";
            this.txtNim.Size = new System.Drawing.Size(100, 20);
            this.txtNim.TabIndex = 6;
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(116, 91);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(169, 20);
            this.txtNama.TabIndex = 7;
            this.txtNama.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtKelas
            // 
            this.txtKelas.Location = new System.Drawing.Point(116, 120);
            this.txtKelas.Name = "txtKelas";
            this.txtKelas.Size = new System.Drawing.Size(100, 20);
            this.txtKelas.TabIndex = 8;
            this.txtKelas.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtNilai
            // 
            this.txtNilai.Location = new System.Drawing.Point(116, 154);
            this.txtNilai.Name = "txtNilai";
            this.txtNilai.Size = new System.Drawing.Size(100, 20);
            this.txtNilai.TabIndex = 9;
            this.txtNilai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNilai_KeyPress);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(141, 203);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lvwMahasiswa
            // 
            this.lvwMahasiswa.HideSelection = false;
            this.lvwMahasiswa.Location = new System.Drawing.Point(7, 67);
            this.lvwMahasiswa.Name = "lvwMahasiswa";
            this.lvwMahasiswa.Size = new System.Drawing.Size(472, 259);
            this.lvwMahasiswa.TabIndex = 13;
            this.lvwMahasiswa.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtNilai);
            this.Controls.Add(this.txtKelas);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.txtNim);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSimpan);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnTampilkanData;
        private System.Windows.Forms.TextBox txtNim;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.TextBox txtKelas;
        private System.Windows.Forms.TextBox txtNilai;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ListView lvwMahasiswa;
    }
}

