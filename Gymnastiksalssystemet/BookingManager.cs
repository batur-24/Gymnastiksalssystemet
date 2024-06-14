using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace Gymnastiksalssystemet
{
    internal class BookingManager
    {
        private string hall { get; set; }
        private DayOfWeek DayOfWeek { get; set; }
        private string bookingTime { get; set; }
        private string full { get; set; }
        private string empty { get; set; }

        public BookingManager(DayOfWeek edayOfWeek, string ebookingTime)
        {
            DayOfWeek = edayOfWeek;
            bookingTime = ebookingTime;
       
        }

        
        
        
        
        

    



    }
}
