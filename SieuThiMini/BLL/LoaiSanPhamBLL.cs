﻿using SieuThiMini.DAL;
using SieuThiMini.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SieuThiMini.BLL
{
    class LoaiSanPhamBLL
    {
        private LoaiSanPhamDAO DAO;
        private List<LoaiSanPhamDTO> listDTO;
      

        public LoaiSanPhamBLL()
        {
            this.DAO = new LoaiSanPhamDAO();
        }

        public List<LoaiSanPhamDTO> GetList()
        {
            listDTO = new List<LoaiSanPhamDTO>();
            listDTO = this.DAO.SelectAll();

            return listDTO;
        }
        public List<LoaiSanPhamDTO> GetList0()
        {
            listDTO = new List<LoaiSanPhamDTO>();
            listDTO = this.DAO.SelectAll0();

            return listDTO;
        }
        public int Insert(LoaiSanPhamDTO dto)
        {
            return this.DAO.Insert(dto);
        }

        public void Update(LoaiSanPhamDTO dto)
        {
            this.DAO.Update(dto);
        }

        public int Delete(int dtoId)
        {
            return this.DAO.Delete(dtoId);
        }

        public void Restore(int id)
        {
            this.DAO.Restore(id);
        }

        public List<LoaiSanPhamDTO> getLoaiSPByNCC(int ma_ncc)
        {
            return this.DAO.getLoaiSPByNCC(ma_ncc);
        }
        public List<LoaiSanPhamDTO> timkiem(string timkiem)
        {
            return this.DAO.timkiem(timkiem);
        }
        public List<LoaiSanPhamDTO> timkiem0(string timkiem)
        {
            return this.DAO.timkiem0(timkiem);
        }
        public LoaiSanPhamDTO getLoaiSPByMaLoai(int ma_loai)
        {
            return this.DAO.getLoaiSPByMaLoai(ma_loai)[0];

        }
        public List<LoaiSanPhamDTO> getLoaiSPByML(int ma_loai)
        {
            return this.DAO.getLoaiSPByMaLoai(ma_loai);

        }

        public List<LoaiSanPhamDTO> getLoaiSPByNameLoaiSP(string ten_loai_san_pham)
        {
            return this.DAO.getLoaiSPByNameLoaiSP(ten_loai_san_pham);
        }
    }
}
