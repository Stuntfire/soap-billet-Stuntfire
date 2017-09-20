using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using BilletSystemDLL;

namespace WcfServiceBillet
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IServiceBillet
    {
        /// <summary>
        /// Oplyser prisen for en bil over Storebælt u. Brobizz.
        /// </summary>
        /// <returns></returns>
        public int GetBilPrisStorebælt()
        {
            var bilStorebæltBroBizz = new Bil("AB34567", DateTime.Now, false, "Storebælt");
            return bilStorebæltBroBizz.Pris();
        }

        /// <summary>
        /// Bil metoder.
        /// </summary>
        /// <returns></returns>
        public int GetBilPrisStorebæltBroBizz()
        {
            var bilStorebæltBroBizz = new Bil("AB34567", DateTime.Now, true, "Storebælt");
            return bilStorebæltBroBizz.Pris();
        }

        public int GetBilPrisØresund()
        {
            var bilØresundBroBizz = new Bil("AB34567", DateTime.Now, false, "Øresund");
            return bilØresundBroBizz.Pris();
        }

        public int GetBilPrisØresundBroBizz()
        {
            var bilØresundBroBizz = new Bil("AB34567", DateTime.Now, true, "Øresund");
            return bilØresundBroBizz.Pris();
        }

        /// <summary>
        /// MC metoder.
        /// </summary>
        /// <returns></returns>
        public int GetMCPrisØresund()
        {
            var mcØresund = new MC("AB34567", DateTime.Now, false, "Øresund");
            return mcØresund.Pris();
        }

        public int GetMCPrisØresundBroBizz()
        {
            var mcØresundBroBizz = new MC("AB34567", DateTime.Now, true, "Øresund");
            return mcØresundBroBizz.Pris();
        }

        public int GetMCPrisStorebælt()
        {
            var mcPrisStorebælt = new MC("AB34567", DateTime.Now, false, "Storebælt");
            return mcPrisStorebælt.Pris();
        }

        public int GetMCPrisStorebæltBroBizz()
        {
            var mcPrisStorebælt = new MC("AB34567", DateTime.Now, true, "Storebælt");
            return mcPrisStorebælt.Pris();
        }

        /// <summary>
        /// Default metoder.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

    }
}
