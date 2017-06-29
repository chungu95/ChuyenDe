

using System;

namespace TestChuyenDe.function
{
    class DateConverter
    {
        public static string GetCurrentDateString()
        {
            DateTime currentDate = DateTime.Today;
            string dateString = currentDate.Day + "-" + currentDate.Month + "-" + currentDate.Year;
            return dateString;
        }

        public static DateTime LayNgayDenHan(int KyHan)
        {
            return DateTime.Today.AddMonths(KyHan); 
        }

        public static string DateToString(DateTime date)
        {
            return date.ToString("dd-MM-yyyy"); 
        }
    }
}
