﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGROTO.DAO
{
    internal class PNKVTPTDAO
    {
        DataConnection dc;
        SqlDataAdapter da;
        private static PNKVTPTDAO instance;
        private PNKVTPTDAO()
        {
            dc = new DataConnection();
        }
        public static PNKVTPTDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new PNKVTPTDAO();
                return instance;
            }
            set { instance = value; }
        }
        public DataTable HienThi()
        {
            SqlConnection con = dc.getConnect();
            con.Open();
            string sql = "SELECT * FROM PHIEUNHAPKHOVTPT";
            SqlCommand cmd = new SqlCommand(sql, con);
            da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
        
        public bool Them(string mnk)
        {
            string sql = "INSERT INTO PHIEUNHAPKHOVTPT (MaNKVTPT, NgayNhap) VALUES (@mank, GETDATE())";
            SqlConnection con = dc.getConnect();
            try
            {
                SqlCommand cmd = new SqlCommand(sql, con);
                
                con.Open();
                cmd.Parameters.AddWithValue("@mank", mnk);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
        public string LoadMPN()
        {
            SqlConnection con = dc.getConnect();
            con.Open();
            string sql = "SELECT COUNT(*) + 1 AS SO FROM PHIEUNHAPKHOVTPT";
            SqlCommand cmd = new SqlCommand(sql, con);
            DataTable dt = new DataTable();
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            string l = "1";
            foreach(DataRow dr in dt.Rows)
            {
                l = dr["SO"].ToString();
            }
            return "NK" + l;
        }
    }
}
