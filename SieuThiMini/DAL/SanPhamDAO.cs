using SieuThiMini.DTO;

using System.Collections.Generic;
using System.Data;

namespace SieuThiMini.DAL
{
    class SanPhamDAO: DataConection
    {
		public SanPhamDAO() { }
		public  List<SanPhamDTO> SelectAll()
		{
			List<SanPhamDTO> dtoList = new List<SanPhamDTO>();
			

			string queryStr = "select * from san_pham";
			
			DataTable result = DataProvider.Instance.ExecuteQuery(queryStr);
			for (int i = 0; i < result.Rows.Count; i++)
			{
				DataRow datarow = result.Rows[i];

				
				int maSanpham = int.Parse(datarow.ItemArray[0].ToString());
				string tenSanpham = datarow.ItemArray[1].ToString();
				int soLuong = int.Parse(datarow.ItemArray[2].ToString());
				int gia = int.Parse(datarow.ItemArray[3].ToString());
                int gianhap = int.Parse(datarow.ItemArray[4].ToString());
                int maLoai = int.Parse(datarow.ItemArray[5].ToString());
                string trangThai = datarow.ItemArray[6].ToString();
                SanPhamDTO dto = new SanPhamDTO(maSanpham,tenSanpham,soLuong,gia,gianhap,maLoai,trangThai);
                dtoList.Add(dto);
            }
            return dtoList;
        }
        public int Insert(SanPhamDTO target)
        {
            Moketnoi();
			string insertStr = $"insert into san_pham values ('', '{target.tenSanpham}', '{target.soLuong}', " +
															$"'{target.gia}','{target.gianhap}', '{target.maLoai}','1')";
			return DataProvider.Instance.ExecuteNonQuery(insertStr);
		}

		public  void Update(SanPhamDTO target)
		{
			Moketnoi();
			string updateStr = "update san_pham set ";
			updateStr += $"ten_san_pham = '{target.tenSanpham}', ";
			updateStr += $"so_luong = '{target.soLuong}', ";
			updateStr += $"gia = '{target.gia}', ";
            updateStr += $"gia_nhap = '{target.gianhap}', ";
            updateStr += $"ma_loai = '{target.maLoai}' ";
			updateStr += $"where ma_san_pham='{target.maSanpham}'";

			DataProvider.Instance.ExecuteNonQuery(updateStr);
		}

		public void UpdateSoLuong(int maSanpham,int soLuong)
		{
			Moketnoi();
			string updateStr = "update san_pham set ";
			updateStr += $"so_luong = '{soLuong}' ";
			updateStr += $"where ma_san_pham='{maSanpham}'";

			DataProvider.Instance.ExecuteNonQuery(updateStr);
		}
        
        public int Delete(int id)
        {
            Moketnoi();
            string deleteStr = $"update san_pham set trang_thai='0' where ma_san_pham = '{id}'";

            return DataProvider.Instance.ExecuteNonQuery(deleteStr);
        }

        public int Restore(int id)
        {
            Moketnoi();
            string updateStr = $"update san_pham set trang_thai='1' where ma_san_pham = '{id}'";
            return DataProvider.Instance.ExecuteNonQuery(updateStr);
        }

        public List<SanPhamDTO> getSPByLoaiSP(int ma_loai)
		{
			List<SanPhamDTO> dtoList = new List<SanPhamDTO>();


			string queryStr = $"select * from san_pham where ma_loai='{ma_loai}'";

			DataTable result = DataProvider.Instance.ExecuteQuery(queryStr);
			for (int i = 0; i < result.Rows.Count; i++)
			{
				DataRow datarow = result.Rows[i];


				int maSanpham = int.Parse(datarow.ItemArray[0].ToString());
				string tenSanpham = datarow.ItemArray[1].ToString();
				int soLuong = int.Parse(datarow.ItemArray[2].ToString());
				int gia = int.Parse(datarow.ItemArray[3].ToString());
                int gianhap = int.Parse(datarow.ItemArray[4].ToString());
                int maLoai = int.Parse(datarow.ItemArray[5].ToString());
                string trangThai = datarow.ItemArray[6].ToString();
                SanPhamDTO dto = new SanPhamDTO(maSanpham, tenSanpham, soLuong, gia, gianhap, maLoai, trangThai);
                dtoList.Add(dto);
			}

			return dtoList;
		}
        
		public List<SanPhamDTO> getSPByMaSp(string ma_san_pham)
		{
			List<SanPhamDTO> dtoList = new List<SanPhamDTO>();


			string queryStr = $"select * from san_pham where ma_san_pham='{ma_san_pham}'";

			DataTable result = DataProvider.Instance.ExecuteQuery(queryStr);
			for (int i = 0; i < result.Rows.Count; i++)
			{
				DataRow datarow = result.Rows[i];


				int maSanpham = int.Parse(datarow.ItemArray[0].ToString());
				string tenSanpham = datarow.ItemArray[1].ToString();
				int soLuong = int.Parse(datarow.ItemArray[2].ToString());
				int gia = int.Parse(datarow.ItemArray[3].ToString());
                int gianhap = int.Parse(datarow.ItemArray[3].ToString());
                int maLoai = int.Parse(datarow.ItemArray[4].ToString());
                string trangThai = datarow.ItemArray[6].ToString();
                SanPhamDTO dto = new SanPhamDTO(maSanpham, tenSanpham, soLuong, gia, gianhap, maLoai, trangThai);
                dtoList.Add(dto);
			}

			return dtoList;
		}
        public List<SanPhamDTO> Timkiem(string value)
        {
            List<SanPhamDTO> dtoList = new List<SanPhamDTO>();


            string queryStr = $"select * from san_pham where ma_san_pham='{value}' and trang_thai = 1 or ma_loai ='{value}' and trang_thai = 1 or ten_san_pham like '%{value}%' and trang_thai = 1";

            DataTable result = DataProvider.Instance.ExecuteQuery(queryStr);
            for (int i = 0; i < result.Rows.Count; i++)
            {
                DataRow datarow = result.Rows[i];


                int maSanpham = int.Parse(datarow.ItemArray[0].ToString());
                string tenSanpham = datarow.ItemArray[1].ToString();
                int soLuong = int.Parse(datarow.ItemArray[2].ToString());
                int gia = int.Parse(datarow.ItemArray[3].ToString());
                int gianhap = int.Parse(datarow.ItemArray[4].ToString());
                int maLoai = int.Parse(datarow.ItemArray[5].ToString());
                string trangThai = datarow.ItemArray[6].ToString();
                SanPhamDTO dto = new SanPhamDTO(maSanpham, tenSanpham, soLuong, gia, gianhap, maLoai, trangThai);
                dtoList.Add(dto);
            }

            return dtoList;
        }
        public List<SanPhamDTO> getSPByNameSp(string ten_san_pham)
		{
			List<SanPhamDTO> dtoList = new List<SanPhamDTO>();


			string queryStr = $"select * from san_pham where ten_san_pham like '%{ten_san_pham}%'";

			DataTable result = DataProvider.Instance.ExecuteQuery(queryStr);
			for (int i = 0; i < result.Rows.Count; i++)
			{
				DataRow datarow = result.Rows[i];


				int maSanpham = int.Parse(datarow.ItemArray[0].ToString());
				string tenSanpham = datarow.ItemArray[1].ToString();
				int soLuong = int.Parse(datarow.ItemArray[2].ToString());
				int gia = int.Parse(datarow.ItemArray[3].ToString());
                int gianhap = int.Parse(datarow.ItemArray[3].ToString());
                int maLoai = int.Parse(datarow.ItemArray[4].ToString());
                string trangThai = datarow.ItemArray[6].ToString();
                SanPhamDTO dto = new SanPhamDTO(maSanpham, tenSanpham, soLuong, gia, gianhap, maLoai, trangThai);
                dtoList.Add(dto);
			}

			return dtoList;
		}

	}
}
