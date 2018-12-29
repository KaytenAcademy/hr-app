using System.ComponentModel.DataAnnotations;

namespace HR.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}