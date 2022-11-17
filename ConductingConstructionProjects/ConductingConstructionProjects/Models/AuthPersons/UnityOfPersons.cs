using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace ConductingConstructionProjects.Models.AuthPersons
{
    public class UnityOfPersons
    {
        [BsonIgnoreIfDefault]
        public ObjectId _id;
        public string Login { get; set; }

        public void CreateInfo(string login)
        {
            Login = login;
        }
    }
}
