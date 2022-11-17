using ConductingConstructionProjects.Models.Projects;
using ConductingConstructionProjects.Models.AuthPersons;

namespace ConductingConstructionProjects.Models.Projects
{
    public class DocCell
    {

        public Document CotroledDoc { get; set; } //Сам файл
        public bool Requirement { get; set; }  //Требование к наличию этого файла
        public bool Status { get; set; } //Статус заполнения ячейки документа

        public DocCell()
        {
            CotroledDoc = new Document();
            Status = false;
            Requirement = false;
        }
    }
}
