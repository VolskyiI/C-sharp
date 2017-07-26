using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_5
{
    class Time
    {
        int hour;
        int minute;

        public Time()
        {

        }

        public Time(int h, int m)
        {
            Hour = h;
            Minute = m;
        }

        public int Hour { get => hour; set => hour = value; }
        public int Minute { get => minute; set => minute = value; }

        public override string ToString()
        {
            return string.Format("{0} hours {1} minutes", Hour, Minute);
        }

        public static implicit operator Time(int minute)
        {

            return new Time((int)(minute / 60), minute % 60);

        }

        //public static implicit operator int(Time t1)
        //{
        //    return 60 * t1.Hour + t1.Minute;
        //}


        public Time ConvertFromIntToTime(int time)
        {
            if (time < 0)
            {
                throw new InvalidTimeFormatException("Час не може бути менше нуля");
            }
            else
            {
                return time;
            }
        }
    }
}





    



    
