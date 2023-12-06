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
    class TaiKhoanBLL
    {
        private TaiKhoanDAO DAO;
        private List<TaiKhoanDTO> listDTO;


        public TaiKhoanBLL()
        {
            this.DAO = new TaiKhoanDAO();
        }

        public List<TaiKhoanDTO> GetList()
        {
            listDTO = new List<TaiKhoanDTO>();
            listDTO = this.DAO.SelectAll();

            return listDTO;
        }

        public DataTable getTaiKhoan()
        {
            return this.DAO.getTaiKhoan();
        }

        public DataTable getDeletedTaiKhoan()
        {
            return this.DAO.getDeletedTaiKhoan();
        }

        public DataTable findDeletedAcountWithKey(string key)
        {
            return this.DAO.findDeletedAcountWithKey(key);
        }

        public int Insert(TaiKhoanDTO dto)
        {
            return this.DAO.Insert(dto);
        }

        public void Update(TaiKhoanDTO dto)
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

        public List<TaiKhoanDTO> getTKByQuyen(string ma_quyen)
        {
            return this.DAO.getTKByQuyen(ma_quyen);
        }

        public TaiKhoanDTO getTKByMaTK(string ma_tai_khoan)
        {
            return this.DAO.getTKByMaTK(ma_tai_khoan)[0];
        }

        public List<TaiKhoanDTO> getTKByNameTK(string ten_tai_khoan)
        {
            return this.DAO.getTKByNameTK(ten_tai_khoan);
        }

        public TaiKhoanDTO SignIn(string ten_tai_khoan, string password)
        {
            return this.DAO.SignIn(ten_tai_khoan, password)[0];
        }
    }
}
