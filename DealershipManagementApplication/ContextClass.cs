using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealershipManagementApplication
{
   public class ContextClass
    {

       private IPageState currentState;

        public ContextClass(IPageState state)
        {
            this.currentState = state;
        }

         public IPageState State
        {
            get
            {
                return currentState;
            }
            set { currentState = value; }
        }
 
        public void Request()
        {
            currentState.Handle(this);
        }
}


}
