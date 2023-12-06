using SieuThiMini.DAL;
using SieuThiMini.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SieuThiMini.BLL
{
    class NhaCungCapBLL
    {
        private NhaCungCapDAO DAO;
        private List<NhaCungCapDTO> listDTO;


        public NhaCungCapBLL()
        {
            this.DAO = new NhaCungCapDAO();
        }

        public List<NhaCungCapDTO> GetList()
        {
            listDTO = new List<NhaCungCapDTO>();
            listDTO = this.DAO.SelectAll();

            return listDTO;
        }
        public List<NhaCungCapDTO> GetListDeleted()
        {
            listDTO = new List<NhaCungCapDTO>();
            listDTO = this.DAO.SelectAllDeleted();

            return listDTO;
        }

        public int Insert(NhaCungCapDTO dto)
        {
            return this.DAO.Insert(dto);
        }

        public void Update(NhaCungCapDTO dto)
        {
            this.DAO.Update(dto);
        }

        public int Delete(int dtoId)
        {
            return this.DAO.Delete(dtoId);
        }
        public void Restore(string dtoId)
        {
            this.DAO.Restore(dtoId);
        }
        public NhaCungCapDTO geNCCByMaNCC(string ma_ncc)
        {
            return this.DAO.geNCCByMaNCC(ma_ncc)[0];
        }

        public List<NhaCungCapDTO> getNCCByNameCC(string ten_ncc)
        {
            return this.DAO.getNCCByNameCC(ten_ncc);
        }

       
    }
}
