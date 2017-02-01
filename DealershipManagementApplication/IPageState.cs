using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace DealershipManagementApplication
{
  public  interface IPageState
    {
        void Handle(ContextClass context);
    }

}
