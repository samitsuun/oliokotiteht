using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oliokotiotorert
{
   public class timma
    {
        private int hour;
        private int minute;
        private int second;

        public timma()
        {
            hour = 1;
            minute = 2;
            second = 15;
        }

        public timma(int _hour, int _minute, int _second)
        {
            hour = _hour;
            minute = _minute;
            second = _second;
        }

        public int getHour()
        {
            return hour;
        }

        public int getMinute()
        {
            return minute;
        }

        public int getSecond()
        {
            return second;
        }

        public void setHour(int hour)
        {
            this.hour = hour;
        }

        public void SetMinute(int minute)
        {
            this.minute = minute;
        }

        public void SetSecond(int second)
        {
            this.second = second;
        }

        public void SetTime(int hour, int minute, int second)
        {
            this.hour = hour;
            this.minute = minute;
            this.second = second;
        }

        public string toString()
        {
            return String.Format("{0:00}/{1:00}/{2:00}", hour, minute, second);
        }

        public int NextSecond()
        {
            second = second + 1;
            return second;
        }

        public int PreviousSecond()
        {
            second = second - 1;
            return second;
        }
    }
}
