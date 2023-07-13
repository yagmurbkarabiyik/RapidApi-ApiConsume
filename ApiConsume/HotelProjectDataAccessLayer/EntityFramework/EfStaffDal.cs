using HotelProjectDataAccessLayer.Abstract;
using HotelProjectDataAccessLayer.Concrete;
using HotelProjectDataAccessLayer.Repositories;
using HotelProjectEntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProjectDataAccessLayer.EntityFramework
{
	public class EfStaffDal : GenericRepository<Staff>, IStaffDal
	{
		public EfStaffDal(Context context) : base(context)
		{

		}

        public int GetStaffCount()
        {
            using var context = new Context();  
            var value = context.Staffs.Count();
            return value;
        }

        public List<Staff> LastFourStaff()
        {
            using var context = new Context();
            var values = context.Staffs.OrderByDescending(x => x.StaffId).Take(4).ToList();   
            return values;  
        }
    }
}
