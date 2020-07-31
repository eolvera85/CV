using System;

namespace CV
{
    public static class Utilities
    {
        public static int GetAge(DateTime birthDate)
        {
            var today = DateTime.Today;

            var age = today.Year - birthDate.Year;

            if (birthDate.Date > today.AddYears(-age))
            {
                age--;
            }

            return age;
        }
    }
}
