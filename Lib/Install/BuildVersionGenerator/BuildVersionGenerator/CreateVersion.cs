using System;

namespace BuildVersionGenerator
{
    public class CreateVersion
    {
        private int LastDigit(int number)
        {
            return number % 10;
        }

        private int SecondLastDigit(int number)
        {
            return (number / 10) % 10;
        }

        private string LastTwoDigits(int number)
        {
            return this.SecondLastDigit(number) + this.LastDigit(number).ToString();
        }

        public string TodayVersion()
        {
            var result = "";
            result += this.LastTwoDigits(DateTime.Today.Year);
            result += this.LastTwoDigits(DateTime.Today.Month);
            result += this.LastTwoDigits(DateTime.Today.Day);
            return result;
        }
    }
}
