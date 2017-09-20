using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfServiceBillet
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IServiceBillet
    {
        /// <summary>
        /// Bil priser
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        int GetBilPrisØresund();

        [OperationContract]
        int GetBilPrisØresundBroBizz();

        [OperationContract]
        int GetBilPrisStorebælt();

        [OperationContract]
        int GetBilPrisStorebæltBroBizz();

        /// <summary>
        /// MC priser
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        [OperationContract]
        int GetMCPrisØresund();

        [OperationContract]
        int GetMCPrisØresundBroBizz();

        [OperationContract]
        int GetMCPrisStorebælt();

        [OperationContract]
        int GetMCPrisStorebæltBroBizz();

        /// <summary>
        /// Default methods
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
