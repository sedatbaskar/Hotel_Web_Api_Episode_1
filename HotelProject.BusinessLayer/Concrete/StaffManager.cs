using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using HotelProjectDataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Concrete
{
    public class StaffManager : IStaffService
    {
        private readonly ISatffDal _staffDall;

        public StaffManager(ISatffDal staffDall)
        {
            _staffDall = staffDall;
        }

        public void TDelete(Staff t)
        {
            _staffDall.Delete(t);
        }

        public Staff TGetByID(int id)
        {
            return _staffDall.GetByID(id);
        }

        public List<Staff> TGetList()
        {
           return _staffDall.GetList();
        }

        public void TInsert(Staff t)
        {
            _staffDall.Insert(t);
        }

        public void TUpdate(Staff t)
        {
            _staffDall.Update(t);
        }
    }
}
