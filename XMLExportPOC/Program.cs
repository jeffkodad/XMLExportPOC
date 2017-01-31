using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XMLExportPOC.DataAccessors;

namespace XMLExportPOC
{
    public class Program : ServiceBase
    {
        private DatabaseAccessor _databaseAccessor;

        public DatabaseAccessor DatabaseAccessor
        {
            get { return _databaseAccessor ?? (_databaseAccessor = new DatabaseAccessor()); }
            set { _databaseAccessor = value; }
        }


        static void Main(string[] args)
        {
            var program = new Program();
        }

        public Program()
        {
            try
            {
                var party = DatabaseAccessor.GetParties();

                Console.WriteLine(party);

                DisplayMessageAndWait("Press any key to exit", CloseAppNow);

            }
            catch (Exception e)
            {

                throw;
            }
        }
    }
}
