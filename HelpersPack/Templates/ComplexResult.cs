using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpersPack.Templates
{

    public class ComplexResult<T, T2>
    {

        public T Result { get; set; }
        
        public T2 Data { get; set; }

        public ComplexResult()
        {

        }

        public ComplexResult(T result, T2 data) : this()
        {
            Result = result;
            Data = data;
        }

    }

}
