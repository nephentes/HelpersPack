using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpersPack.Generics
{

    public class GenericEventArgs<T> : EventArgs
    {

        public T Data { get; set; }

        public GenericEventArgs() : base()
        {

        }

        public GenericEventArgs(T data) : this()
        {
            Data = data;
        }


    }


    public class GenericEventArgs<T1, T2> : EventArgs
    {

        /// <summary>
        /// Main Data
        /// </summary>
        public T1 Data { get; set; }

        /// <summary>
        /// Auxiliary
        /// </summary>
        public T2 Aux { get; set; }

        public GenericEventArgs() : base()
        {

        }

        public GenericEventArgs(T1 data) : this()
        {
            Data = data;
        }

        public GenericEventArgs(T1 data, T2 aux) : this(data)
        {
            Aux = aux;
        }

    }

}
