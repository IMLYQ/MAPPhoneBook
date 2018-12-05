using System.ComponentModel.DataAnnotations;

namespace MAPPhoneBook.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}