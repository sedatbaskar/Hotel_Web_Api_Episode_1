using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelProject.EntityLayer.Concrete;
using HotelProjectDataAccessLayer.Abstract;
using HotelProjectDataAccessLayer.Concrete;
using HotelProjectDataAccessLayer.Repositories;

namespace HotelProjectDataAccessLayer.EntityFramework
{
    internal class EfStaffDal:GenericRepository<Staff>, ISatffDal
    {
        public EfStaffDal(Context context):base(context)  
        {

        }
    }
}
