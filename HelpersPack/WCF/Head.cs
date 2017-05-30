using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace HelpersPack.WCF
{

    [DataContract]
    public class Head
    {

        [DataMember]
        public string ClientSystem { get; set; }

        [DataMember]
        public string Token { get; set; }

        public Head()
        {

        }

    }

}
