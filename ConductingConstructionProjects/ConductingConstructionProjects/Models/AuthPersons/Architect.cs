namespace ConductingConstructionProjects.Models.AuthPersons
{
    public class Architect : UnityOfPersons
    {
        public string Org_Name { get; set; }
        public int InEter_RegNum { get; set; }
        public int Tax_IdNum { get; set; }

        public int KPP { get; set; }
        public string Address { get; set; }
        public string Director_Name { get; set; }
        public string MainEngineer_Name { get; set; }
    }

}
