﻿namespace UI
{
    partial class QUANLYTIENCONG
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
            this.QLTCTienCong_Gr = new System.Windows.Forms.GroupBox();
            this.TienCong_TextBox = new System.Windows.Forms.TextBox();
            this.NoiDung_TextBox = new System.Windows.Forms.TextBox();
            this.MaTienCong_Textbox = new System.Windows.Forms.TextBox();
            this.TienCong_Label = new System.Windows.Forms.Label();
            this.NoiDung_Label = new System.Windows.Forms.Label();
            this.MaTienCong_Label = new System.Windows.Forms.Label();
            this.QLTCTuyChinh_Gr = new System.Windows.Forms.GroupBox();
            this.DeleteTienCong_Button = new System.Windows.Forms.Button();
            this.EditTienCong_Button = new System.Windows.Forms.Button();
            this.AddTienCong_Button = new System.Windows.Forms.Button();
            this.QLTCDanhSach_Gr = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.QuanLyTienCong_Title = new System.Windows.Forms.Label();
            this.QLTCTienCong_Gr.SuspendLayout();
            this.QLTCTuyChinh_Gr.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // QLTCTienCong_Gr
            // 
            this.QLTCTienCong_Gr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.QLTCTienCong_Gr.Controls.Add(this.TienCong_TextBox);
            this.QLTCTienCong_Gr.Controls.Add(this.NoiDung_TextBox);
            this.QLTCTienCong_Gr.Controls.Add(this.MaTienCong_Textbox);
            this.QLTCTienCong_Gr.Controls.Add(this.TienCong_Label);
            this.QLTCTienCong_Gr.Controls.Add(this.NoiDung_Label);
            this.QLTCTienCong_Gr.Controls.Add(this.MaTienCong_Label);
            this.QLTCTienCong_Gr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QLTCTienCong_Gr.Location = new System.Drawing.Point(3, 55);
            this.QLTCTienCong_Gr.Name = "QLTCTienCong_Gr";
            this.QLTCTienCong_Gr.Size = new System.Drawing.Size(338, 193);
            this.QLTCTienCong_Gr.TabIndex = 0;
            this.QLTCTienCong_Gr.TabStop = false;
            this.QLTCTienCong_Gr.Text = "Tiền công";
            this.QLTCTienCong_Gr.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // TienCong_TextBox
            // 
            this.TienCong_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TienCong_TextBox.Location = new System.Drawing.Point(134, 142);
            this.TienCong_TextBox.Name = "TienCong_TextBox";
            this.TienCong_TextBox.Size = new System.Drawing.Size(192, 26);
            this.TienCong_TextBox.TabIndex = 5;
            // 
            // NoiDung_TextBox
            // 
            this.NoiDung_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NoiDung_TextBox.Location = new System.Drawing.Point(134, 91);
            this.NoiDung_TextBox.Name = "NoiDung_TextBox";
            this.NoiDung_TextBox.Size = new System.Drawing.Size(192, 26);
            this.NoiDung_TextBox.TabIndex = 4;
            // 
            // MaTienCong_Textbox
            // 
            this.MaTienCong_Textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MaTienCong_Textbox.Location = new System.Drawing.Point(134, 39);
            this.MaTienCong_Textbox.Name = "MaTienCong_Textbox";
            this.MaTienCong_Textbox.Size = new System.Drawing.Size(192, 26);
            this.MaTienCong_Textbox.TabIndex = 3;
            // 
            // TienCong_Label
            // 
            this.TienCong_Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TienCong_Label.AutoSize = true;
            this.TienCong_Label.Location = new System.Drawing.Point(21, 144);
            this.TienCong_Label.Name = "TienCong_Label";
            this.TienCong_Label.Size = new System.Drawing.Size(78, 20);
            this.TienCong_Label.TabIndex = 2;
            this.TienCong_Label.Text = "Tiền công";
            // 
            // NoiDung_Label
            // 
            this.NoiDung_Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.NoiDung_Label.AutoSize = true;
            this.NoiDung_Label.Location = new System.Drawing.Point(21, 93);
            this.NoiDung_Label.Name = "NoiDung_Label";
            this.NoiDung_Label.Size = new System.Drawing.Size(72, 20);
            this.NoiDung_Label.TabIndex = 1;
            this.NoiDung_Label.Text = "Nội dung";
            // 
            // MaTienCong_Label
            // 
            this.MaTienCong_Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.MaTienCong_Label.AutoSize = true;
            this.MaTienCong_Label.Location = new System.Drawing.Point(21, 41);
            this.MaTienCong_Label.Name = "MaTienCong_Label";
            this.MaTienCong_Label.Size = new System.Drawing.Size(100, 20);
            this.MaTienCong_Label.TabIndex = 0;
            this.MaTienCong_Label.Text = "Mã tiền công";
            // 
            // QLTCTuyChinh_Gr
            // 
            this.QLTCTuyChinh_Gr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.QLTCTuyChinh_Gr.Controls.Add(this.DeleteTienCong_Button);
            this.QLTCTuyChinh_Gr.Controls.Add(this.EditTienCong_Button);
            this.QLTCTuyChinh_Gr.Controls.Add(this.AddTienCong_Button);
            this.QLTCTuyChinh_Gr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QLTCTuyChinh_Gr.Location = new System.Drawing.Point(356, 55);
            this.QLTCTuyChinh_Gr.Name = "QLTCTuyChinh_Gr";
            this.QLTCTuyChinh_Gr.Size = new System.Drawing.Size(182, 193);
            this.QLTCTuyChinh_Gr.TabIndex = 1;
            this.QLTCTuyChinh_Gr.TabStop = false;
            this.QLTCTuyChinh_Gr.Text = "Tùy chỉnh";
            this.QLTCTuyChinh_Gr.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // DeleteTienCong_Button
            // 
            this.DeleteTienCong_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteTienCong_Button.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.DeleteTienCong_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteTienCong_Button.Location = new System.Drawing.Point(22, 136);
            this.DeleteTienCong_Button.Name = "DeleteTienCong_Button";
            this.DeleteTienCong_Button.Size = new System.Drawing.Size(134, 39);
            this.DeleteTienCong_Button.TabIndex = 2;
            this.DeleteTienCong_Button.Text = "Xóa tiền công";
            this.DeleteTienCong_Button.UseVisualStyleBackColor = false;
            // 
            // EditTienCong_Button
            // 
            this.EditTienCong_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.EditTienCong_Button.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.EditTienCong_Button.CausesValidation = false;
            this.EditTienCong_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditTienCong_Button.Location = new System.Drawing.Point(22, 85);
            this.EditTienCong_Button.Name = "EditTienCong_Button";
            this.EditTienCong_Button.Size = new System.Drawing.Size(134, 39);
            this.EditTienCong_Button.TabIndex = 1;
            this.EditTienCong_Button.Text = "Sửa tiền công";
            this.EditTienCong_Button.UseVisualStyleBackColor = false;
            // 
            // AddTienCong_Button
            // 
            this.AddTienCong_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.AddTienCong_Button.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.AddTienCong_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddTienCong_Button.Location = new System.Drawing.Point(22, 33);
            this.AddTienCong_Button.Name = "AddTienCong_Button";
            this.AddTienCong_Button.Size = new System.Drawing.Size(134, 39);
            this.AddTienCong_Button.TabIndex = 0;
            this.AddTienCong_Button.Text = "Thêm tiền công";
            this.AddTienCong_Button.UseVisualStyleBackColor = false;
            // 
            // QLTCDanhSach_Gr
            // 
            this.QLTCDanhSach_Gr.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.QLTCDanhSach_Gr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QLTCDanhSach_Gr.Location = new System.Drawing.Point(3, 254);
            this.QLTCDanhSach_Gr.Name = "QLTCDanhSach_Gr";
            this.QLTCDanhSach_Gr.Size = new System.Drawing.Size(535, 280);
            this.QLTCDanhSach_Gr.TabIndex = 2;
            this.QLTCDanhSach_Gr.TabStop = false;
            this.QLTCDanhSach_Gr.Text = "Danh sách";
            this.QLTCDanhSach_Gr.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.QuanLyTienCong_Title);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(535, 47);
            this.panel1.TabIndex = 3;
            // 
            // QuanLyTienCong_Title
            // 
            this.QuanLyTienCong_Title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.QuanLyTienCong_Title.AutoSize = true;
            this.QuanLyTienCong_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuanLyTienCong_Title.ForeColor = System.Drawing.Color.White;
            this.QuanLyTienCong_Title.Location = new System.Drawing.Point(128, 7);
            this.QuanLyTienCong_Title.Name = "QuanLyTienCong_Title";
            this.QuanLyTienCong_Title.Size = new System.Drawing.Size(309, 31);
            this.QuanLyTienCong_Title.TabIndex = 0;
            this.QuanLyTienCong_Title.Text = "QUẢN LÝ TIỀN CÔNG";
            this.QuanLyTienCong_Title.Click += new System.EventHandler(this.QuanLyTienCong_Title_Click);
            // 
            // QUANLYTIENCONG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 554);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.QLTCDanhSach_Gr);
            this.Controls.Add(this.QLTCTuyChinh_Gr);
            this.Controls.Add(this.QLTCTienCong_Gr);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "QUANLYTIENCONG";
            this.ShowIcon = false;
            this.Text = "Tiền công";
            this.QLTCTienCong_Gr.ResumeLayout(false);
            this.QLTCTienCong_Gr.PerformLayout();
            this.QLTCTuyChinh_Gr.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox QLTCTienCong_Gr;
        private System.Windows.Forms.GroupBox QLTCTuyChinh_Gr;
        private System.Windows.Forms.GroupBox QLTCDanhSach_Gr;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label QuanLyTienCong_Title;
        private System.Windows.Forms.TextBox TienCong_TextBox;
        private System.Windows.Forms.TextBox NoiDung_TextBox;
        private System.Windows.Forms.TextBox MaTienCong_Textbox;
        private System.Windows.Forms.Label TienCong_Label;
        private System.Windows.Forms.Label NoiDung_Label;
        private System.Windows.Forms.Label MaTienCong_Label;
        private System.Windows.Forms.Button AddTienCong_Button;
        private System.Windows.Forms.Button DeleteTienCong_Button;
        private System.Windows.Forms.Button EditTienCong_Button;
    }
}