﻿using DoAn_PTUDTTHD.Models;
using DoAn_PTUDTTHD.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DoAn_PTUDTTHD.Controllers
{
    public class NguoiDungController : ApiController
    {
        NguoiDungRepository nguoiDungRepository = new NguoiDungRepository();
        HoaDonRepository hoaDonRepository = new HoaDonRepository();

        //get all
        public IEnumerable<NguoiDung> Get()
        {
            return nguoiDungRepository.findAll();
        }
        //find by cmnd
        public NguoiDung Get(string CMND)
        {
            return nguoiDungRepository.findByCMND(CMND);
        }
        //login
        public NguoiDung Post(string username, string password)
        {
            return nguoiDungRepository.auth(username, password);
        }
        //find by id
        public NguoiDung Get(int id)
        {
            return nguoiDungRepository.findById(id);
        }

        //Nộp Phạt
        [HttpGet]
        [Route("api/NguoiDung/NopPhat")]
        public bool Post([FromBody] HoaDon hoaDon)
        {
            return hoaDonRepository.addHoaDon(hoaDon);
        }

    }
}
