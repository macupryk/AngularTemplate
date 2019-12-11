using System.ComponentModel.DataAnnotations;

namespace AngularProject.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}