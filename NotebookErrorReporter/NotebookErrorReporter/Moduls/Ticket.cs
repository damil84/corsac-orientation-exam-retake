namespace NotebookErrorReporter.Moduls
{
    public class Ticket
    {
        public int Id { get; set; }
        public string Reporter { get; set; }
        public string Manufacturer { get; set; }
        public int SerialNumber { get; set; }
        public string Description { get; set; }
        public string ReportedAt { get; set; }
    }
}