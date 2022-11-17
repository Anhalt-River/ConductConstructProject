using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ConductingConstructionProjects.Models.Projects
{
    public class Document
    {
        [BsonIgnoreIfDefault]
        public ObjectId _id;
        public byte[] Attachment { get; set; }
        public string Description { get; set; } //Наименование нормативного акта

        public Document()
        {
            Attachment = null;
            Description = null;

        }
    }
}
