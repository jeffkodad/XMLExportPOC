using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XMLExportPOC.DataAccessors.DataModels;

namespace XMLExportPOC.DataAccessors
{
    public class DatabaseAccessor
    {
        #region Fields

        internal XmlExportDbContext XMLExportDBContextInstance { get; set; }

        #endregion

        #region Properties



        #endregion

        #region Methods

        public Party GetPartyById(int partyId)
        {
            using (var db = CreateXmlExportDbContext())
            {
                return db.Party.FirstOrDefault(x => x.PartyId == partyId);
            }
        }

        public List<Party> GetParties()
        {
            using (var db = CreateXmlExportDbContext())
            {
                var list = db.Party.ToList();

                return new List<Party>();
            }
        }

        #endregion


        #region HelperMethods
        internal XmlExportDbContext CreateXmlExportDbContext()
        {
            return XMLExportDBContextInstance ?? CreateNewXMLExportDBContext();
        }

        private XmlExportDbContext CreateNewXMLExportDBContext()
        {
            var result = new XmlExportDbContext();

            return result;
        }

        #endregion
    }
}
