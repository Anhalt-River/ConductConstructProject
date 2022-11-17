using System.ComponentModel.DataAnnotations;
using DnsClient;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;


namespace ConductingConstructionProjects.Models
{
    public class AuthPerson
    {
        [BsonIgnoreIfDefault]
        public ObjectId _id;

        [Required(ErrorMessage = "Логин должен быть установлен")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Длина логина должна быть не менее 2х и не более 50ти символов")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Аккаунт должен иметь пароль!")]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "Пароль должен содержать от 5 символов")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Почта должна быть указана")]
        [StringLength(55, MinimumLength = 8, ErrorMessage = "Почта не может быть столь малой")]
        public string Email { get; set; }

        public string Role { get; set; }
        public string FirstPhoneNum { get; set; }

        public void CloneFrom(AuthPerson person)
        {
            Login = person.Login;
            Password = person.Password;
            Role = person.Role;
            Email = person.Email;
            FirstPhoneNum = person.FirstPhoneNum;
        }
    }

    
}
