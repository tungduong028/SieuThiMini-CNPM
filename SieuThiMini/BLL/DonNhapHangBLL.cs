using SieuThiMini.DAL;
using SieuThiMini.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SieuThiMini.BLL
{
    class DonNhapHangBLL
    {
        private DonNhapHangDAO DAO;
        private List<DonNhapHangDTO> listDTO;


        public DonNhapHangBLL()
        {
            this.DAO = new DonNhapHangDAO();
        }

        public List<DonNhapHangDTO> GetList()
        {
            listDTO = new List<DonNhapHangDTO>();
            listDTO = this.DAO.SelectAll();

            return listDTO;
        }
        public List<DonNhapHangDTO> GetListDeleted()
        {
            listDTO = new List<DonNhapHangDTO>();
            listDTO = this.DAO.SelectAllDeleted();

            return listDTO;
        }
        public int Insert(DonNhapHangDTO dto)
        {
            return this.DAO.Insert(dto);
        }

        public int Update(string maDonNh)
        {
            return this.DAO.Restore(maDonNh);
        }

        public int Delete(string dtoId)
        {
            return this.DAO.Delete(dtoId);
        }


        public DonNhapHangDTO getDNHByMaDNH(string ma_don_nh)
        {
            return this.DAO.getDNHByMaDNH(ma_don_nh)[0];

        }

        

    }
}
