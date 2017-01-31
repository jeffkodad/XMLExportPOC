namespace XMLExportPOC.DataAccessors.DataModels
{
    public class Party
    {
        public int PartyId { get; set; }

        public string PartyTypeCode { get; set; }

        public string FullName { get; set; }

        public int? GovtIDTC { get; set; }

        public string GovtID { get; set; }

        public int? OrganizationTC { get; set; }

        public string ResidentState { get; set; }

        public string ResidentCountry { get; set; }

        public long? TC_PartyTypeCode { get; set; }

    }
}
