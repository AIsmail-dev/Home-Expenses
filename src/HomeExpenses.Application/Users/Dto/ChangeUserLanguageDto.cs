using System.ComponentModel.DataAnnotations;

namespace HomeExpenses.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}