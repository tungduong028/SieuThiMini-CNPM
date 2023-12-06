using SieuThiMini.DTO;

using System.Collections.Generic;
using System.Data;

namespace SieuThiMini.DAL
{
    class TaiKhoanDAO: DataConection
    {
		public TaiKhoanDAO() { }
		public  List<TaiKhoanDTO> SelectAll()
		{
			List<TaiKhoanDTO> dtoList = new List<TaiKhoanDTO>();
			

			string queryStr = "select * from tai_khoan where trang_thai='1' and phan_quyen!=0";
			
			DataTable result = DataProvider.Instance.ExecuteQuery(queryStr);
			for (int i = 0; i < result.Rows.Count; i++)
			{
				DataRow datarow = result.Rows[i];

				
				int maTaiKhoan = int.Parse(datarow.ItemArray[0].ToString());
				string tenTaiKhoan = datarow.ItemArray[1].ToString();
				string matKhau = datarow.ItemArray[2].ToString();
				int maQuyen = int.Parse(datarow.ItemArray[3].ToString());
				string trangthai = datarow.ItemArray[4].ToString();

				TaiKhoanDTO dto = new TaiKhoanDTO(maTaiKhoan, tenTaiKhoan, matKhau, maQuyen, trangthai);
				dtoList.Add(dto);
			}

			return dtoList;
		}

		public DataTable getTaiKhoan()
		{
            string queryStr = "select * from tai_khoan where trang_thai = '1' and phan_quyen != '0'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(queryStr);
			return dt;
		}

        public DataTable getDeletedTaiKhoan()
        {
            string queryStr = "select * from tai_khoan where trang_thai = '0' and phan_quyen != '0'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(queryStr);
            return dt;
        }

        public DataTable findDeletedAcountWithKey(string key)
        {
            string queryStr = $"select * from tai_khoan where trang_thai = '0' and phan_quyen != '0' and (ma_tai_khoan LIKE '%{key}%' OR ten_tai_khoan LIKE '%{key}%')";
            DataTable dt = DataProvider.Instance.ExecuteQuery(queryStr);
            return dt;
        }

        public int Insert(TaiKhoanDTO target)
		{
			Moketnoi();
			string insertStr = $"insert into tai_khoan values ('', '{target.tenTaikhoan}', '{target.matKhau}', " +
															$"'{target.maQuyen}', '{target.trangThai}')";
			return DataProvider.Instance.ExecuteNonQuery(insertStr);
		}

		public void Update(TaiKhoanDTO target)
		{
			Moketnoi();
			string updateStr = "update tai_khoan set ";
			updateStr += $"ten_tai_khoan = '{target.tenTaikhoan}', ";
			updateStr += $"mat_khau = '{target.matKhau}', ";
			updateStr += $"phan_quyen = '{target.maQuyen}', ";
			updateStr += $"trang_thai = '{target.trangThai}' ";
			updateStr += $"where ma_tai_khoan='{target.maTaikhoan}'";

			DataProvider.Instance.ExecuteNonQuery(updateStr);
		}

		public int Delete(string id)
		{
			Moketnoi();
			string deleteStr = $"update tai_khoan set trang_thai='0' where ma_tai_khoan = '{id}'";

			return DataProvider.Instance.ExecuteNonQuery(deleteStr);
		}

        public int Restore(string id)
        {
            Moketnoi();
            string restoreStr = $"update tai_khoan set trang_thai='1' where ma_tai_khoan = '{id}'";

            return DataProvider.Instance.ExecuteNonQuery(restoreStr);
        }

        public DataTable TimKiem(string key)
		{
            string queryStr = $"select * from tai_khoan where trang_thai='1' AND phan_quyen!=0 AND (ma_tai_khoan LIKE '{key}' OR ten_tai_khoan LIKE '%{key}%')";
            DataTable dt = DataProvider.Instance.ExecuteQuery(queryStr);
			return dt;
        }

		public List<TaiKhoanDTO> getTKByMaTK(string ma_tai_khoan) { 
			List<TaiKhoanDTO> dtoList = new List<TaiKhoanDTO>();


			string queryStr = $"select * from tai_khoan where ma_tai_khoan='{ma_tai_khoan}'";

			DataTable result = DataProvider.Instance.ExecuteQuery(queryStr);
			for (int i = 0; i < result.Rows.Count; i++)
			{
				DataRow datarow = result.Rows[i];


				int maTaiKhoan = int.Parse(datarow.ItemArray[0].ToString());
				string tenTaiKhoan = datarow.ItemArray[1].ToString();
				string matKhau = datarow.ItemArray[2].ToString();
				int maQuyen = int.Parse(datarow.ItemArray[3].ToString());
				string trangthai = datarow.ItemArray[4].ToString();

				TaiKhoanDTO dto = new TaiKhoanDTO(maTaiKhoan, tenTaiKhoan, matKhau, maQuyen, trangthai);
				dtoList.Add(dto);
			}

			return dtoList;
		}

		public List<TaiKhoanDTO> getTKByQuyen(string ma_quyen)
		{
			List<TaiKhoanDTO> dtoList = new List<TaiKhoanDTO>();


			string queryStr = $"select * from tai_khoan where phan_quyen='{ma_quyen}'";

			DataTable result = DataProvider.Instance.ExecuteQuery(queryStr);
			for (int i = 0; i < result.Rows.Count; i++)
			{
				DataRow datarow = result.Rows[i];


				int maTaiKhoan = int.Parse(datarow.ItemArray[0].ToString());
				string tenTaiKhoan = datarow.ItemArray[1].ToString();
				string matKhau = datarow.ItemArray[2].ToString();
				int maQuyen = int.Parse(datarow.ItemArray[3].ToString());
				string trangthai = datarow.ItemArray[4].ToString();

				TaiKhoanDTO dto = new TaiKhoanDTO(maTaiKhoan, tenTaiKhoan, matKhau, maQuyen, trangthai);
				dtoList.Add(dto);
			}

			return dtoList;
		}


		public List<TaiKhoanDTO> getTKByNameTK(string ten_tai_khoan)
		{
			List<TaiKhoanDTO> dtoList = new List<TaiKhoanDTO>();


			string queryStr = $"select * from tai_khoan where ten_tai_khoan like '%{ten_tai_khoan}%'";

			DataTable result = DataProvider.Instance.ExecuteQuery(queryStr);
			for (int i = 0; i < result.Rows.Count; i++)
			{
				DataRow datarow = result.Rows[i];


				int maTaiKhoan = int.Parse(datarow.ItemArray[0].ToString());
				string tenTaiKhoan = datarow.ItemArray[1].ToString();
				string matKhau = datarow.ItemArray[2].ToString();
				int maQuyen = int.Parse(datarow.ItemArray[3].ToString());
				string trangthai = datarow.ItemArray[4].ToString();

				TaiKhoanDTO dto = new TaiKhoanDTO(maTaiKhoan, tenTaiKhoan, matKhau, maQuyen, trangthai);
				dtoList.Add(dto);
			}

			return dtoList;
		}

		public List<TaiKhoanDTO> SignIn(string ten_tai_khoan,string password)
		{
			List<TaiKhoanDTO> dtoList = new List<TaiKhoanDTO>();


			string queryStr = $"select * from tai_khoan where ten_tai_khoan='{ten_tai_khoan}' and mat_khau='{password}'";

			DataTable result = DataProvider.Instance.ExecuteQuery(queryStr);
			for (int i = 0; i < result.Rows.Count; i++)
			{
				DataRow datarow = result.Rows[i];


				int maTaiKhoan = int.Parse(datarow.ItemArray[0].ToString());
				string tenTaiKhoan = datarow.ItemArray[1].ToString();
				string matKhau = datarow.ItemArray[2].ToString();
				int maQuyen = int.Parse(datarow.ItemArray[3].ToString());
				string trangthai = datarow.ItemArray[4].ToString();

				TaiKhoanDTO dto = new TaiKhoanDTO(maTaiKhoan, tenTaiKhoan, matKhau, maQuyen, trangthai);
				dtoList.Add(dto);
			}

			return dtoList;
		}

	}
}
