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
        public static ArrayList id = new ArrayList();
        public static ArrayList id1 = new ArrayList();
        public static ArrayList name = new ArrayList();
        public static ArrayList contact = new ArrayList();
        public static ArrayList email1 = new ArrayList();
        public static ArrayList cnic1 = new ArrayList();
        public static ArrayList age1 = new ArrayList();
        public static ArrayList gender1 = new ArrayList();
        public static ArrayList profession1 = new ArrayList();
        public static ArrayList address1 = new ArrayList();
        public static ArrayList suggestion = new ArrayList();
        public static ArrayList yourname = new ArrayList();
        public static ArrayList email2 = new ArrayList();

        private static List<Suggestions> sug = new List<Suggestions>();

        internal static List<Suggestions> Sug
        {
            get { return Dataclass.sug; }
            set { Dataclass.sug = value; }
        }

        public static void ADDsuggestion(Suggestions s)
        {

            Dataclass.Sug.Add(s);

        }
        public static List<Suggestions> SHOWall()
        {
            return Sug;
        }


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
