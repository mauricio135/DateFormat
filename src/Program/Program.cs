using System;

namespace Program
{
     public class Program
    {
        public static String ChangeFormat(String year)
        {
            if (string.IsNullOrEmpty(year))
            {
                return "";
            }
            else
            {
                int FirstSeparator = year.IndexOf('/');
                if (FirstSeparator == -1)
                {
                    return "";
                }
                else
                {
                    string day = year.Substring(0, FirstSeparator);
                    int SecondSeparator = year.IndexOf('/', FirstSeparator + 1);
                    if (SecondSeparator == -1)
                    {
                        return "";
                    }
                    else
                    {
                        string month = year.Substring(FirstSeparator + 1, SecondSeparator - (FirstSeparator + 1));
                        string yearNumber = year.Substring(SecondSeparator + 1);
                        if ((Int32.Parse(day) > 31) || (Int32.Parse(month) > 12))
                        {
                            return string.Empty;
                        }
                        return yearNumber + '-' + month + '-' + day;
                    }
                }
                //return year.Substring(6) + "-" + year.Substring(3, 2) + "-" + year.Substring(0, 2);
            }
        }

        public static void Main(string[] args)
        {
            string testDate = "10/11/1977";
            Console.WriteLine("{0} se convierte a: {1} ", testDate, ChangeFormat(testDate));
        }
    }
}
