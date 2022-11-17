using System.ComponentModel.DataAnnotations;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;


namespace ConductingConstructionProjects.Models
{
    public class SimplePerson
    {
        [BsonIgnoreIfDefault]
        public ObjectId _id;

        public string Login { get; set; }

        [Required(ErrorMessage = "Аккаунт должен иметь пароль!")]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "Пароль должен содержать от 5 символов")]
        public string Password { get; set; }

        public string Email { get; set; }


        public string FirstPhoneNum { get; set; }

    }
}
