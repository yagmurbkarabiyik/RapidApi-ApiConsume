using HotelProject.BusinessLayer.Abstract;
using HotelProjectDataAccessLayer.Abstract;
using HotelProjectEntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Concrete
{
	public class StaffManagaer : IStaffService
	{
		private readonly IStaffDal _staffDal;

		public StaffManagaer(IStaffDal staffDal)
		{
			_staffDal = staffDal;
		}

		public void TDelete(Staff t)
		{
			_staffDal.Delete(t);	
		}

		public Staff TGetById(int id)
		{
			return _staffDal.GetById(id);
		}

		public List<Staff> TGetList()
		{
			return _staffDal.GetList();
		}

        public int TGetStaffCount()
        {
            return _staffDal.GetStaffCount();
        }

        public void TInsert(Staff t)
		{
			_staffDal.Insert(t);	
		}

        public List<Staff> TLastFourStaff()
        {
          return _staffDal.LastFourStaff();
        }

        public void TUpdate(Staff t)
		{
			_staffDal.Update(t);
		}
	}
}
