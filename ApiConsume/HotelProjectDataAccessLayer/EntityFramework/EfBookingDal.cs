﻿using HotelProjectDataAccessLayer.Abstract;
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
    public class EfBookingDal : GenericRepository<Booking>, IBookingDal
    {
        public EfBookingDal(Context context) : base(context)
        {
        }

        public void BookingStatusChangeApproved(Booking booking)
        {
            var context = new Context();
            var values = context.Bookings.Where(x => x.BookingId == booking.BookingId).FirstOrDefault();
            values.Status = "Approved!";
            context.SaveChanges();  

        }

        public void BookingStatusChangeApproved2(int id)
        {
            var context = new Context();
            var values = context.Bookings.Find(id);
            values.Status = "Approved!";
            context.SaveChanges();
        }
    }
}