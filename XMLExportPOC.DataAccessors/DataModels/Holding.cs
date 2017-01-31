namespace XMLExportPOC.DataAccessors.DataModels
{
    public class Holding
    {
        public int Id { get; set; }

        public string PollNumber { get; set; }

        public string HoldingTypeCode { get; set; }

        public string HoldingStatus { get; set; }

        public long? TC_HoldingTypeCode { get; set; }

        public string AsOfDate { get; set; }

        public string FileName { get; set; }

        public long? TC_HoldingStatus { get; set; }

    }

}
