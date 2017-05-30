using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpersPack
{

    public static class ExceptionHelper
    {

        public static List<string> GetInnerMessages(Exception exception)
        {
            var retVal = new List<string>();

            try
            {
                foreach (var oneInnerException in EnumInnerExceptions(exception))
                {
                    retVal.Add(string.Format("{0} >> {1}", oneInnerException.Message, oneInnerException.StackTrace));
                }
            }
            catch (Exception ex)
            {
                // hi hey hello!
            }

            return retVal;
        }

        public static List<Exception> EnumInnerExceptions(Exception exception)
        {
            var retVal = new List<Exception>();

            var excToCheck = new Queue<Exception>();

            if (exception.InnerException != null)
            {
                excToCheck.Enqueue(exception.InnerException);
            }

            while (excToCheck.Count > 0)
            {
                var currentException = excToCheck.Dequeue();
                retVal.Add(currentException);


                if (currentException.InnerException != null)
                {
                    excToCheck.Enqueue(currentException.InnerException);
                }

            }


            return retVal;
        }

    }

}
