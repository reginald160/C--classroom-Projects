using System;
namespace TimeTest
{
    public class Time
    {
        private int hour;
        private int minute;
        private int second;

        public void SetTime(int h, int m, int s)
        {
            if ((h >= 0 && h < 24) && (m >= 0 && m < 60) && (s >= 0 && s < 60)){
                hour = h;
                minute = m;
                second = s;
            } else {
                throw new ArgumentOutOfRangeException("Invalid inputs for hour/minute/second");
            }
        }

        public string ToUniversalTime()
        {
            return $"{hour:D2}:{minute:D2}:{second:D2}";
        }

        public override string ToString(){
            return string.Format("{0:D2}:{1:D2} {2}", ((hour == 0 || hour == 12) ? hour : (hour % 12)), minute, (hour < 12) ? "AM" : "PM");
        }
    }
}