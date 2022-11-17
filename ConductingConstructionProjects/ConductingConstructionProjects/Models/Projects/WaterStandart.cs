namespace ConductingConstructionProjects.Models.Projects
{
    public class WaterStandart
    {
        public int[] LowDiameter = new int[2];
        public string JustifyLowDiameter { get; set; }
        public int EfficiencyBOS { get; set; } = new int();
        public string JustifyEfficiencyBOS { get; set; }
        public string JustifyCountKOS { get; set; }

        public int[] CountsKOS = new int[2];

        public int[] EfficiencyKOS = new int[2];
        public string JustifyEfficiencyKOS { get; set; }                          
        public int Estimate { get; set; } = new int();
        public string JustifyEstimate { get; set; }
        public int Period { get; set; } = new int();
        public string JustifyPeriod { get; set; }
        public WaterStandart()
        {
            JustifyLowDiameter = "Диаметр (мм) трубопровода и протяженность линейного объекта(м)";
            JustifyEfficiencyBOS = "Производительность БОС, м3/ сут";
            JustifyEfficiencyKOS = "Производительность КНС (м3/ ч)";
            JustifyCountKOS = "Кол.-во (шт) КНС";
            JustifyEstimate = "Сметная стоимость работ, тыс. руб.";
            JustifyPeriod = "Срок разработки проектной документации, месяцев";
        }

    }
}
