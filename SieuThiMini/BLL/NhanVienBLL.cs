using SieuThiMini.DAL;
using SieuThiMini.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SieuThiMini.BLL
{
    class NhanVienBLL
    {
        private NhanVienDAO DAO;
        private List<NhanVienDTO> listDTO;
      

        public NhanVienBLL()
        {
            this.DAO = new NhanVienDAO();
        }

        public List<NhanVienDTO> GetList()
        {
            listDTO = new List<NhanVienDTO>();
            listDTO = this.DAO.SelectAll();

            return listDTO;
        }

        public DataTable getNhanVien()
        {
            return this.DAO.getNhanVien();
        }

        public DataTable getDeletedNhanVien()
        {
            return this.DAO.getDeletedNhanVien();
        }

        public DataTable getDeletedNhanVienByKey(string key)
        {
            return this.DAO.getDeletedNhanVienByKey(key);
        }

        public int Insert(NhanVienDTO dto)
        {
            return this.DAO.Insert(dto);
        }

        public void Update(NhanVienDTO dto)
        {
            this.DAO.Update(dto);
        }

        public int Delete(string dtoId)
        {
            return this.DAO.Delete(dtoId);
        }

        public int Restore(string dtoId)
        {
            return this.DAO.Restore(dtoId);
        }

        public DataTable TimKiem(string key)
        {
            return this.DAO.TimKiem(key);
        }

		public NhanVienDTO getNVByMaNV(string ma_nhan_vien)
        {
            return this.DAO.getNVByMaNV(ma_nhan_vien)[0];
		}

        public NhanVienDTO getNVByTK(string ma_tai_khoan)
        {
            return this.DAO.getNVByMaTK(ma_tai_khoan)[0];
        }

        public List<NhanVienDTO> getNVByTaiKhoan(string ma_tai_khoan)
        {
            return this.DAO.getNVByMaTK(ma_tai_khoan);
        }

        public List<NhanVienDTO> getNVByNameNV(string ten_nhan_vien)
        {
            return this.DAO.getNVByNameNV(ten_nhan_vien);
		}

        public DataTable getTKByMaNV(string ma_nhan_vien)
        {
            return this.DAO.getTKByMaNV(ma_nhan_vien);
        }

    }
}
