﻿using HotelProjectEntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProjectDataAccessLayer.Abstract
{
    public interface IBookingDal : IGenericDal<Booking>
    {
        void BookingStatusChangeApproved(Booking booking);
        void BookingStatusChangeApproved2(int id);
        int GetBookingCount();
        List<Booking> GetLastFiveBookings();
        void BookingStatusChangeApproved3(int id);
        void BookingStatusChangeCancelled(int id); 
        void BookingStatusChangeWait(int id); 
    }
}
