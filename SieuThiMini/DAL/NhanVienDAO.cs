using SieuThiMini.DTO;
using System;
using System.Collections.Generic;
using System.Data;

namespace SieuThiMini.DAL
{
    class NhanVienDAO: DataConection
    {
		public NhanVienDAO() { }
		public List<NhanVienDTO> SelectAll()
		{
			List<NhanVienDTO> dtoList = new List<NhanVienDTO>();
			

			string queryStr = "select nhan_vien.*,tai_khoan.phan_quyen from nhan_vien,tai_khoan where nhan_vien.tai_khoan=tai_khoan.ma_tai_khoan and tai_khoan.phan_quyen!=0";
			
			DataTable result = DataProvider.Instance.ExecuteQuery(queryStr);
			for (int i = 0; i < result.Rows.Count; i++)
			{
				DataRow datarow = result.Rows[i];

				
				int maNhanVien = int.Parse(datarow.ItemArray[0].ToString());
				string tenNhanVien = datarow.ItemArray[1].ToString();
				DateTime ngaySinh = (DateTime)datarow.ItemArray[2];
				
				
				string sdt = datarow.ItemArray[3].ToString();
				string mail = datarow.ItemArray[4].ToString();
				int maTaikhoan=int.Parse(datarow.ItemArray[5].ToString());

				NhanVienDTO dto = new NhanVienDTO(maNhanVien, tenNhanVien, ngaySinh, sdt, mail, maTaikhoan);
				dtoList.Add(dto);
			}

			return dtoList;
		}

		public DataTable getNhanVien()
		{
			string queryStr = "SELECT ma_nhan_vien, ten_nhan_vien, ngay_sinh, sdt, mail, tai_khoan FROM nhan_vien WHERE trang_thai = '1'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(queryStr);
			return dt;
        }

        public DataTable getDeletedNhanVien()
        {
            string queryStr = "SELECT * FROM nhan_vien WHERE trang_thai = '0'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(queryStr);
            return dt;
        }

        public DataTable getDeletedNhanVienByKey(string key)
        {
            string queryStr = $"SELECT * FROM nhan_vien WHERE trang_thai = '0' AND (ma_nhan_vien LIKE '%{key}%' OR ten_nhan_vien LIKE '%{key}%')";
            DataTable dt = DataProvider.Instance.ExecuteQuery(queryStr);
            return dt;
        }

        public int Insert(NhanVienDTO target)
		{
			
			Moketnoi();
			string ngaySinh = target.ngaySinh.ToString("yyyy-MM-dd");
			string insertStr = $"insert into nhan_vien values ('', '{target.tenNhanvien}', '{ngaySinh}', " +
															$"'{target.sdt}', '{target.mail}','{target.maTaikhoan}', '1')";
			return DataProvider.Instance.ExecuteNonQuery(insertStr);
		}

		public void Update(NhanVienDTO target)
		{
			Moketnoi();
			string ngaySinh = target.ngaySinh.ToString("yyyy-MM-dd");

			string updateStr = "update nhan_vien set ";
			updateStr += $"ten_nhan_vien = '{target.tenNhanvien}', ";
			updateStr += $"ngay_sinh = '{ngaySinh}', ";
			updateStr += $"sdt = '{target.sdt}', ";
			updateStr += $"mail = '{target.mail}', ";
			updateStr += $"tai_khoan = '{target.maTaikhoan}' ";
			updateStr += $"where ma_nhan_vien='{target.maNhanvien}'";

			DataProvider.Instance.ExecuteNonQuery(updateStr);
		}
		public int Delete(string id)
		{
			Moketnoi();
			string deleteStr = $"update nhan_vien set trang_thai = '0' where ma_nhan_vien = '{id}'";

			return DataProvider.Instance.ExecuteNonQuery(deleteStr);
		}

        public int Restore(string id)
        {
            Moketnoi();
            string deleteStr = $"update nhan_vien set trang_thai = '1' where ma_nhan_vien = '{id}'";

            return DataProvider.Instance.ExecuteNonQuery(deleteStr);
        }

        public DataTable TimKiem(string key)
		{
            Moketnoi();
            string queryStr = $"SELECT * FROM nhan_vien WHERE trang_thai = '1' AND (ma_nhan_vien LIKE '%{key}%' OR ten_nhan_vien LIKE '%{key}%')";

            return DataProvider.Instance.ExecuteQuery(queryStr);
        }

		public List<NhanVienDTO> getNVByMaNV(string ma_nhan_vien)
		{
			List<NhanVienDTO> dtoList = new List<NhanVienDTO>();


			string queryStr = $"select * from nhan_vien where ma_nhan_vien='{ma_nhan_vien}'";

			DataTable result = DataProvider.Instance.ExecuteQuery(queryStr);
			for (int i = 0; i < result.Rows.Count; i++)
			{
				DataRow datarow = result.Rows[i];


				int maNhanVien = int.Parse(datarow.ItemArray[0].ToString());
				string tenNhanVien = datarow.ItemArray[1].ToString();
				DateTime ngaySinh = (DateTime)datarow.ItemArray[2];


				string sdt = datarow.ItemArray[3].ToString();
				string mail = datarow.ItemArray[4].ToString();
				int maTaikhoan = int.Parse(datarow.ItemArray[5].ToString());

				NhanVienDTO dto = new NhanVienDTO(maNhanVien, tenNhanVien, ngaySinh, sdt, mail, maTaikhoan);
				dtoList.Add(dto);
			}

			return dtoList;
		}

		public List<NhanVienDTO> getNVByNameNV(string ten_nhan_vien)
		{
			List<NhanVienDTO> dtoList = new List<NhanVienDTO>();


			string queryStr = $"select * from nhan_vien where ten_nhan_vien like '%{ten_nhan_vien}%'";

			DataTable result = DataProvider.Instance.ExecuteQuery(queryStr);
			for (int i = 0; i < result.Rows.Count; i++)
			{
				DataRow datarow = result.Rows[i];


				int maNhanVien = int.Parse(datarow.ItemArray[0].ToString());
				string tenNhanVien = datarow.ItemArray[1].ToString();
				DateTime ngaySinh = (DateTime)datarow.ItemArray[2];


				string sdt = datarow.ItemArray[3].ToString();
				string mail = datarow.ItemArray[4].ToString();
				int maTaikhoan = int.Parse(datarow.ItemArray[5].ToString());

				NhanVienDTO dto = new NhanVienDTO(maNhanVien, tenNhanVien, ngaySinh, sdt, mail, maTaikhoan);
				dtoList.Add(dto);
			}

			return dtoList;
		}

		public List<NhanVienDTO> getNVByMaTK(string ma_tai_khoan)
		{
			List<NhanVienDTO> dtoList = new List<NhanVienDTO>();


			string queryStr = $"select * from nhan_vien where tai_khoan='{ma_tai_khoan}'";

			DataTable result = DataProvider.Instance.ExecuteQuery(queryStr);
			for (int i = 0; i < result.Rows.Count; i++)
			{
				DataRow datarow = result.Rows[i];


				int maNhanVien = int.Parse(datarow.ItemArray[0].ToString());
				string tenNhanVien = datarow.ItemArray[1].ToString();
				DateTime ngaySinh = (DateTime)datarow.ItemArray[2];


				string sdt = datarow.ItemArray[3].ToString();
				string mail = datarow.ItemArray[4].ToString();
				int maTaikhoan = int.Parse(datarow.ItemArray[5].ToString());

				NhanVienDTO dto = new NhanVienDTO(maNhanVien, tenNhanVien, ngaySinh, sdt, mail, maTaikhoan);
				dtoList.Add(dto);
			}

			return dtoList;
		}

        public DataTable getTKByMaNV(string ma_nhan_vien)
        {
            string queryStr = $"select tai_khoan from nhan_vien where ma_nhan_vien = '{ma_nhan_vien}'";
            return DataProvider.Instance.ExecuteQuery(queryStr);
        }

    }
}
