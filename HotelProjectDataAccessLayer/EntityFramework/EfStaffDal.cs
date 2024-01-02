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
    public class EfStaffDal:GenericRepository<Staff>, IStaffDal
    {
        public EfStaffDal(Context context):base(context)  
        {

        }
    }
}
