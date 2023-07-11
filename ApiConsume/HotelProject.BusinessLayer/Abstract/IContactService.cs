using HotelProjectDataAccessLayer.Abstract;
using HotelProjectDataAccessLayer.Concrete;
using HotelProjectEntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Abstract
{
    public interface IContactService : IGenericDal<Contact>
    {
        void TInsert(Contact contact);
        public int TGetContactCount();
    }
}
