﻿using ClosedXML.Excel;
using QLGROTO.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLGROTO
{
    public partial class DSPNKVTPT : Form
    {
        int flag;
        public DSPNKVTPT()
        {
            InitializeComponent();
            HienThi();
        }
        public void HienThi()
        {
            phieunhapvtptdtgrid.DataSource = PNKVTPTDAO.Instance.HienThi();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void xemctbtn_Click(object sender, EventArgs e)
        {
            CHITIETPNK c = new CHITIETPNK();
            c.maphieunhap = phieunhapvtptdtgrid.CurrentRow.Cells[0].Value.ToString();
            c.ngaynhap = phieunhapvtptdtgrid.CurrentRow.Cells[1].Value.ToString();
            c.ShowDialog();
        }

        private void xuatbtn_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx" })
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (XLWorkbook workbook = new XLWorkbook())
                        {
                            workbook.Worksheets.Add(phieunhapvtptdtgrid.DataSource as DataTable, "PNKVTPT");

                            workbook.SaveAs(saveFileDialog.FileName);


                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Xuất file không thành công!");
                    }
                }
            }
        }

        private void timtheomaradio_CheckedChanged(object sender, EventArgs e)
        {
            flag = 1;
        }

     
        private void timkiembtn_Click(object sender, EventArgs e)
        {
            string s = timkiemtxtbox.Text;
            
            if (!string.IsNullOrEmpty(s))
            {
                if (flag == 1)
                    phieunhapvtptdtgrid.DataSource = PNKVTPTDAO.Instance.TimKiemTheoMa(s);
                
            }
            else
                HienThi();
        }

        private void DSPNKVTPT_Load(object sender, EventArgs e)
        {

        }
    }
}
