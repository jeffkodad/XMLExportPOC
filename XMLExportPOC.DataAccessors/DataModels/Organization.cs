namespace XMLExportPOC.DataAccessors.DataModels
{
    public class Organization
    {
        public int Id { get; set; }

        public string DBA { get; set; }

        public int? PartyId { get; set; }

        public string OrgForm { get; set; }

        public int? TC_OrgForm { get; set; }

        public string FileName { get; set; }

    }

}
