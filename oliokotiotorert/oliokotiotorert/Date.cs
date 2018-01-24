using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oliokotiotorert
{
    class Date
    {
        private int day;
        private int month;
        private int year;

        public Date()
        {
            day = 13;
            month = 11;
            year = 1995;
        }

        public Date(int _day, int _month, int _year)
        {
            day = _day;
            month = _month;
            year = _year;
        }

        public int getDay()
        {
            return day;
        }

        public int getMonth()
        {
            return month;
        }

        public int getYear()
        {
            return year;
        }

        public void setDay(int day)
        {
            this.day = day;
        }

        public void setMonth(int month)
        {
            this.month = month;
        }

        public void setYear(int year)
        {
            this.year = year;
        }

        public void setDate(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }

        public string toString()
        {
            return String.Format("{0:00}/{1:00}/{2:0000}", day, month, year);
        }
    }
}
