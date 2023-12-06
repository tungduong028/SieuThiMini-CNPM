using SieuThiMini.DAL;
using SieuThiMini.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SieuThiMini.BLL
{
    class HoaDonBLL
    {
        private HoaDonDAO DAO;
        private List<HoaDonDTO> listDTO;


        public HoaDonBLL()
        {
            this.DAO = new HoaDonDAO();
        }

        public List<HoaDonDTO> GetList()
        {
            listDTO = new List<HoaDonDTO>();
            listDTO = this.DAO.SelectAll();

            return listDTO;
        }
        public List<HoaDonDTO> GetListDeleted()
        {
            listDTO=new List<HoaDonDTO>();  
            listDTO = this.DAO.SelectAllDeleted();
            return listDTO;
        }
        public int Insert(HoaDonDTO dto)
        {
            return this.DAO.Insert(dto);
        }

      

        public int Delete(string dtoId)
        {
            return this.DAO.Delete(dtoId);
        }

        public int Update(string mahoadon)
        {
            return this.DAO.Restore(mahoadon);
        }
        public HoaDonDTO getHDByMaHD(string ma_hoa_don)
        {
            return this.DAO.getHDByMaHD(ma_hoa_don)[0];

        }

        

    }
}
