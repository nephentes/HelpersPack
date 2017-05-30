using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;


namespace HelpersPack.WCF
{

    [DataContract]
    public class GenericRequest<T>
    {

        [DataMember]
        public Head Header { get; set; }

        [DataMember]
        [Required]
        public T Data { get; set; }

        public GenericRequest()
        {

        }

        public GenericRequest(T data) : this()
        {
            Data = data;
        }

    }

    [DataContract]
    public class GenericRequest<T, T2>
    {

        [DataMember]
        public Head Header { get; set; }

        [DataMember]
        [Required]
        public T Data { get; set; }

        [DataMember]
        [Required]
        public T2 Arguments { get; set; }

        public GenericRequest()
        {

        }

        public GenericRequest(T data, T2 args) : this()
        {
            Data = data;
            Arguments = args;
        }

    }

}
