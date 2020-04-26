using System;

namespace cssb_ex08.FireArm_Properties
{
    class Firearms1 // Firearms class
    {
        //class properties
        public static string type { get; set; }
        public static string caliber { get; set; }
        public static string sound { get; set; }
        public static int count = 0;

        //class constructor
        public Firearms1(string Type, string Caliber, string Sound)
        {
            type = Type;
            caliber = Caliber;
            sound = Sound;
            count++;
        }
        public override string ToString()
        {
            return ($"I am a {type}, and I go {sound} with a {caliber} round, and we have {count} firearms.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is C Sharp quiz 8");
            Firearms1 pistol = new Firearms1("pistol", "9mm", "pop");
            Console.WriteLine(pistol);
            Firearms1 rifle = new Firearms1("rifle", "7.62", "bang");
            Console.WriteLine(rifle);
            Firearms1 shotgun = new Firearms1("shotgun", "12 gauge", "bang");
            Console.WriteLine(shotgun);
        }
    }
}