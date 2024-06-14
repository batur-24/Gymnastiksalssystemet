using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gymnastiksalssystemet
{
    internal class Booking
    {
        private List<Booking> bookings;
        public int Id { get; set; }
        public int HallID { get; set; }
        public DateTime BookingTime { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }


      
        public Booking()
        {
            bookings  = new List<Booking>();
        }

        public void Removebooking(string booking)
        {
            bookings.RemoveAll(id  => booking == booking);
        }
        public void AddBooking(Booking booking)
        {
            bookings.Add(booking);
        }
        
        public Booking(int eid, int ehallID, DateTime edateTime, DateTime estart, DateTime eend)
        {
            Id = eid;
            HallID = ehallID;
            BookingTime = edateTime;
            Start = estart;
            End = eend;
        }

        public override string ToString()
        {
            return $"ID: {Id}, HallID: {HallID}, Date: {BookingTime.ToShortDateString()}, Start: {Start.ToShortTimeString()}, End: {End.ToShortTimeString()}";
        }



    }
}
