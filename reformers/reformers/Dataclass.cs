using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace reformers
{
    class Dataclass
    {
        public static ArrayList username= new ArrayList();
        public static ArrayList contactno = new ArrayList();
        public static ArrayList email = new ArrayList();
        public static ArrayList cnic = new ArrayList();
        public static ArrayList age = new ArrayList();
        public static ArrayList gender = new ArrayList();
        public static ArrayList profession = new ArrayList();
        public static ArrayList address = new ArrayList();
        public static ArrayList skill = new ArrayList();
        public static ArrayList join = new ArrayList();
        public static ArrayList donate = new ArrayList();

        private static List<Volunteer> vol = new List<Volunteer>();

        internal static List<Volunteer> Vol
        {
            get { return Dataclass.vol; }
            set { Dataclass.vol = value; }
        }
        public static void ADDvolunteer(Volunteer v)
        {

            Dataclass.Vol.Add(v);

        }
        public static List<Volunteer> SHOWALL()
        {
            return Vol;
        }

        private static List<Donor> don = new List<Donor>();

        internal static List<Donor> Don
        {
            get { return Dataclass.don; }
            set { Dataclass.don = value; }
        }
        public static void ADDdonor(Donor d)
        {

            Dataclass.Don.Add(d);

        }
        public static List<Donor> SHOW()
        {
            return Don;
        }
        
        

    }
}
