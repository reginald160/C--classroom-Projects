using System;

namespace test2 {
    public class Time1 {
        private int hour;
        private int minute;
        private int second;

        public Time1(){
            hour = 0;
            minute = 0;
            second = 0;
        }

        public Time1(Time1 time): this(time.hour, time.minute, time.second)
        {

        }

        public void SetTime (int h, int m, int s) {
            if ((h >= 0 && h < 24) && (m >= 0 && m < 60) && (s >= 0 && s < 60)) {
                hour = h;
                minute = m;
                second = s;
            } else {
                throw new ArgumentOutOfRangeException ("Incorrect value passed to hour");
            }
        }

        public string ToUniversalString () {
            return $"{hour:D2} : {minute:D2} : {second:D2}";
        }

        public override string ToString () {
            return string.Format ("{0}:{1:D2}:{2:D2} {3}", (hour == 0 || hour == 12) ? 12 : hour % 12, minute, second, (hour < 12) ? "AM" : "PM");
        }
    }
}