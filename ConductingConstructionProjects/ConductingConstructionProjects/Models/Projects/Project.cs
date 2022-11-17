using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using ConductingConstructionProjects.Models.Projects;
using ConductingConstructionProjects.Models.AuthPersons;

namespace ConductingConstructionProjects.Models.Projects
{
    public class Project
    {
        [BsonIgnoreIfDefault]
        public ObjectId _id;

        public string Name { get; set; }
        public List<DocCell> Docs { get; set; }

        public string Architect { get; set; }         
        public string Builder { get; set; }
        public string Consumer { get; set; }
        public string Branch { get; set; }
        public bool Status { get; set; }

        public GasStandart GasStandart { get; set; }
        public WaterStandart WaterStandart { get; set; }

        public bool PlanConfirmed { get; set; } = false;

        public Project()
        {
            Status = false;
            Docs = new List<DocCell>();
            GasStandart = new GasStandart();
            WaterStandart = new WaterStandart();
        }
        public void CloneFrom(UseProject project)
        {
            Docs = project.Docs;
            Architect = project.Architect;
            Builder = project.Builder;
            Consumer = project.Consumer;
            Branch = project.Branch;
            Status = project.Status;
            GasStandart = project.GasStandart;
            WaterStandart = project.WaterStandart;
        }
    }
}
