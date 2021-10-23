namespace Projektni_Zadatak_03_Vjezbe.Models
{
    public class Column
    {
        public string Name { get; set; }
        public string DataType { get; set; }
        public override string ToString() => $"{Name} ({DataType})";
    }
}
