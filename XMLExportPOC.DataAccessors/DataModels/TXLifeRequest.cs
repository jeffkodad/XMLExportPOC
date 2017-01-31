namespace XMLExportPOC.DataAccessors.DataModels
{
    public class TXLifeRequest
    {
        public int TXLifeRequestId { get; set; }

        public string PollNumber { get; set; }

        public string TransType { get; set; }

        public int? TC_TransType { get; set; }

        public long? TransRefGUID { get; set; }

        public string TransExeDate { get; set; }

        public string TransExeTime { get; set; }

        public string FileName { get; set; }

    }

}
