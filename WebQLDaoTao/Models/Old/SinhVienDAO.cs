using System;
using System.Collections.Generic;

using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
namespace WebQLDaoTao.Models
{
    public class SinhVienDAO
    {
        public int Insert(string masv, string hosv, string tensv, Boolean gioitinh, DateTime ngaysinh, string noisinh, string
        diachi, string makh)
        {
            SqlConnection conn = new
            SqlConnection(ConfigurationManager.ConnectionStrings["WebQLDaoTao_ConStr"].ConnectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into sinhvien (masv, hosv, tensv, gioitinh, ngaysinh, noisinh, diachi, makh) values(@masv, @hosv, @tensv, @gioitinh, @ngaysinh, @noisinh, @diachi, @makh)",
        conn);
            cmd.Parameters.AddWithValue("@masv", masv);
            cmd.Parameters.AddWithValue("@hosv", hosv);
            cmd.Parameters.AddWithValue("@tensv", tensv);
            cmd.Parameters.AddWithValue("@gioitinh", gioitinh);
            cmd.Parameters.AddWithValue("@ngaysinh", ngaysinh);
            cmd.Parameters.AddWithValue("@noisinh", noisinh);
            cmd.Parameters.AddWithValue("@diachi", diachi);
            cmd.Parameters.AddWithValue("@makh", makh);
            return cmd.ExecuteNonQuery();
        }
        public List<SinhVien> getAll()
        {
            List<SinhVien> dsSinhVien = new List<SinhVien>();
            SqlConnection conn = new
            SqlConnection(ConfigurationManager.ConnectionStrings["WebQLDaoTao_ConStr"].ConnectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from SinhVien", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                SinhVien sv = new SinhVien
                {
                    MaSV = dr["MaSV"].ToString(),
                    HoSV = dr["Hosv"].ToString(),
                    TenSV = dr["Tensv"].ToString(),
                    GioiTinh = Boolean.Parse(dr["gioitinh"].ToString()),
                    NgaySinh = DateTime.Parse(dr["ngaysinh"].ToString()),
                    NoiSinh = dr["noisinh"].ToString(),
                    DiaChi = dr["diachi"].ToString(),
                    MaKH = dr["Makh"].ToString()
                };

                //add vao dsSinhVien
                dsSinhVien.Add(sv);
            }
            return dsSinhVien;
        }
        public int Update(string masv, string hosv, string tensv, Boolean gioitinh, DateTime ngaysinh, string noisinh, string
        diachi, string makh)
        {
            SqlConnection conn = new
            SqlConnection(ConfigurationManager.ConnectionStrings["WebQLDaoTao_ConStr"].ConnectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("update sinhvien set hosv=@hosv, tensv=@tensv, gioitinh=@gioitinh, ngaysinh = @ngaysinh, noisinh = @noisinh, diachi = @diachi, makh = @makh where masv = @masv", conn);
            cmd.Parameters.AddWithValue("@masv", masv);
            cmd.Parameters.AddWithValue("@hosv", hosv);
            cmd.Parameters.AddWithValue("@tensv", tensv);
            cmd.Parameters.AddWithValue("@gioitinh", gioitinh);
            cmd.Parameters.AddWithValue("@ngaysinh", ngaysinh);
            cmd.Parameters.AddWithValue("@noisinh", noisinh);
            cmd.Parameters.AddWithValue("@diachi", diachi);
            cmd.Parameters.AddWithValue("@makh", makh);
            return cmd.ExecuteNonQuery();
        }
        public int Delete(string masv)
        {
            SqlConnection conn = new
            SqlConnection(ConfigurationManager.ConnectionStrings["WebQLDaoTao_ConStr"].ConnectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("delete from sinhvien where masv=@masv", conn);
            cmd.Parameters.AddWithValue("@masv", masv);
            return cmd.ExecuteNonQuery();
        }
    }
}