using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Gymnastiksalssystemet
{
    internal class Gruppe
    {
        public int Id { get; set; }
        public int HallID { get; set; }
        public string GrupName { get; set; }
        public string GrupAge { get; set; }
        public int GrupMember { get; set; }

        public Gruppe(int eid, int ehallID, string egrupName, string egrupAge, int egrupMember)
        {
            Id = eid;
            HallID = ehallID;
            GrupName = egrupName;
            GrupAge = egrupAge;
            GrupMember = egrupMember;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"{Id} - {HallID}-{GrupAge}-{GrupName}-{GrupMember}");

        }

    }
}
