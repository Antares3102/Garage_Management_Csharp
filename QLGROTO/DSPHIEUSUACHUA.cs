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
    public partial class DSPHIEUSUACHUA : Form
    {
        int flag;
        public DSPHIEUSUACHUA()
        {
            InitializeComponent();
            HienThi();
        }
        public void HienThi()
        {
            pscdtgrid.DataSource = PHIEUSUACHUADAO.Instance.HienThi();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      

        private void DSPHIEUSUACHUA_Load(object sender, EventArgs e)
        {
            
        }

        private void xembtn_Click(object sender, EventArgs e)
        {
            CHITIETPSC t = new CHITIETPSC();
            t.tongtien = pscdtgrid.CurrentRow.Cells["TongTien"].Value.ToString();
            t.ngaysua = pscdtgrid.CurrentRow.Cells["NgaySuaChua"].Value.ToString();
            t.bienso = pscdtgrid.CurrentRow.Cells["BienSo"].Value.ToString();
            t.mapsc = pscdtgrid.CurrentRow.Cells["MaPSC"].Value.ToString();
            t.ShowDialog();
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
                            workbook.Worksheets.Add(pscdtgrid.DataSource as DataTable, "PHIEUSUACHUA");

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

        private void mapscradio_CheckedChanged(object sender, EventArgs e)
        {
            flag = 1;
        }

        private void khoangngayradio_CheckedChanged(object sender, EventArgs e)
        {
            flag = 2;
        }

        private void timkiembtn_Click(object sender, EventArgs e)
        {
            string s = timkiemtxtbox.Text;
            int tbd = tudtpicker.Value.Month;
            int nbd = tudtpicker.Value.Year;
            int tkt = dendtpicker.Value.Month;
            int nkt = dendtpicker.Value.Year;
            if (!string.IsNullOrEmpty(s))
            {
                if (flag == 1)
                    pscdtgrid.DataSource = PHIEUSUACHUADAO.Instance.TimKiemTheoMa(s);
                else if (flag == 2)
                    pscdtgrid.DataSource = PHIEUSUACHUADAO.Instance.TimKiemTheoKhoangNgay(tbd, nbd, tkt, nkt);

            }
            else
                HienThi();

        }
    }
}
