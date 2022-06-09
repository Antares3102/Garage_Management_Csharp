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
        public DataTable TimKiemTheoMa(string s)
        {
            SqlConnection con = dc.getConnect();
            con.Open();
            string sql = "SELECT * FROM PHIEUNHAPKHOVTPT WHERE MaNKVTPT LIKE CONCAT('%', @ten, '%')";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@ten", s);
            DataTable dt = new DataTable();
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
        public DataTable TimKiemTheoKhoangNgay(int tbd, int tkt, int nbd, int nkt)
        {
            SqlConnection con = dc.getConnect();
            con.Open();
            string sql = "SELECT * FROM PHIEUNHAPKHOVTPT WHERE (MONTH(NgayNhap) BETWEEN &tbd AND @tkt) " +
                "AND (YEAR(NgayNhap) BETWEEN @nbd AND @nkt)";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@tbd", tbd);
            cmd.Parameters.AddWithValue("@tkt", tkt);
            cmd.Parameters.AddWithValue("@nbd", nbd);
            cmd.Parameters.AddWithValue("@nkt", nkt);
            DataTable dt = new DataTable();
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
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
            SqlDataReader dr = cmd.ExecuteReader();
            string l = "";
            if (dr.Read())
                l = dr["SO"].ToString();
            return "NK" + l;
        }
    }
}
