using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpersPack.Interfaces
{
    public interface IAuditable
    {

        bool IsAudit { get; set; } // == true if this is audit entry for example if it used in one application and changes should be done only inside this application

        int? IdAudited { get; set; } // id of not audit item from which this one derives

        int? IdOwner { get; set; } // owner of this audited entry for example UserId if is related to user :) 
         
    }
}
