﻿using HotelProject.Business.Abstract;
using HotelProject.DataAccess.Abstract;
using HotelProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Business.Concrete
{
    public class StaffManager : IStaffService
    {
        private readonly IStaffDal _staffDal;

        public StaffManager(IStaffDal staffDal)
        {
            _staffDal = staffDal;
        }
        public void TInsert(Staff t)
        {
            _staffDal.Insert(t);
        }

        public void TUpdate(Staff t)
        {
            _staffDal.Update(t);
        }
        public void TDelete(Staff t)
        {
            _staffDal.Delete(t);
        }

        public Staff TGetByID(int id)
        {
            return _staffDal.GetByID(id);
        }

        public List<Staff> TGetList()
        {
            return _staffDal.Getlist();
        }


    }
}
