using System;
namespace TimeTest2
{
    public class Time
    {
        private int hour;
        private int minute;
        private int second;

        public Time(int hour = 0, int minute = 0, int second = 0)
        {
            this.hour = hour;
            this.minute = minute;
            this.second = second;
        }

        
        public int Hour
        {
            get { return hour; }
            set { 
                if ((value >= 0) && (value < 24))
                {
                    hour = value;
                } else {
                    throw new ArgumentOutOfRangeException("Invalid value given: Hour 0 - 23");
                }
            }
        }

        public int Minute
        {
            get { return minute; }
            set
            {
                if ((value >= 0) && (value < 60))
                {
                    minute = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Invalid value given: minute 0 - 59");
                }
            }
        }


        public int Second
        {
            get { return second; }
            set
            {
                if ((value >= 0) && (value < 60))
                {
                    second = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Invalid value given: second 0 - 59");
                }
            }
        }
        
        
        public void SetTime(int h, int m, int s)
        {
            Hour = h;
            Minute = m;
            Second = s;
        }


        public override string ToString(){
            return $"{Hour:D2}:{Minute:D2}:{Second:D2}";
        }


    }
}