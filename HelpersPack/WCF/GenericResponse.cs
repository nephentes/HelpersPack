using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace HelpersPack.WCF
{
    [DataContract]
    [KnownType(typeof(Tuple<double, double>))]
    public class GenericResponse<T>
    {

        [DataMember]
        public bool isOk { get; set; }

        [DataMember]
        public string resultCode { get; set; }

        [DataMember]
        public string message { get; set; }

        [DataMember]
        public T data { get; set; }

        [DataMember]
        public object aux { get; set; }

        [XmlIgnore]
        public List<ValidationResult> invalid { get; set; }

        [DataMember]
        public List<string> validationErrors
        {
            get
            {
                return invalid.Select(i => i.ErrorMessage).ToList();
            }

            set
            {

            }
        }

        public GenericResponse(T _data)
        {
            isOk = true;
            data = _data;
            invalid = new List<ValidationResult>();
        }



        public bool IsValid { get; }

        public void Add(object detail)
        {

        }

    }
}
