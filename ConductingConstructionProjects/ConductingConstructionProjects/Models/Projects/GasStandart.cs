namespace ConductingConstructionProjects.Models.Projects
{
    public class GasStandart
    {
        public int[] LowDiameter = new int[2];
        public string JustifyLowDiameter { get; set; }
        public int InputDiameter { get; set; } = new int();
        public string JustifyInputDiameter { get; set; }
        public int Estimate { get; set; } = new int();
        public string JustifyEstimate { get; set; }
        public int Period { get; set; } = new int();
        public string JustifyPeriod { get; set; }

        public GasStandart()
        {
            JustifyLowDiameter = "Диаметр (мм) трубопровода и протяженность линейного объекта(м)";
            JustifyInputDiameter = "Диаметр (мм) трубопровода и протяженность линейного объекта(м)";
            JustifyEstimate = "Сметная стоимость работ, тыс. руб.";
            JustifyPeriod = "Срок разработки проектной документации, месяцев";
        }

    }
}
