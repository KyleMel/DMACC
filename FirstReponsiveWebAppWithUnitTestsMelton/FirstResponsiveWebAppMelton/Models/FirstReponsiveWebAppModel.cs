using System.ComponentModel.DataAnnotations;

namespace FirstResponsiveWebAppMelton.Models
{
    public class FirstReponsiveWebAppModel
    {
        [Required(ErrorMessage = "Please enter a name.")]
        public string? Name { get; set; }
        [Required(ErrorMessage = "Please enter a birthyear.")]
        public int BirthYear { get; set; }
        // Method to calculate age based on current year and birth year of user
        public static int AgeThisYear(int birthYear)
        {
            // Get the current year
            int currentYear = DateTime.Now.Year;
            if (birthYear <= 0 || birthYear > currentYear)
            {
                return -1; // Indicates an invalid birth year
            }
            return currentYear - birthYear;
        }
    }
}
