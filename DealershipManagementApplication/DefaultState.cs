using DealershipManagementApplication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealershipManagementApplication
{
    public class DefaultState : IPageState
    {
        private static DefaultState instance;

        public void Handle(ContextClass context)
        {
           // Console.WriteLine(this.GetType().Name + ": DefaultState");
        }

        public static DefaultState Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DefaultState();
                }
                return instance;
            }
            set { instance = value; }
        }
    }


     public class SelectState : IPageState
    {
        private static SelectState instance;

        public void Handle(ContextClass context)
        {
             // Console.WriteLine(this.GetType().Name + ": SelectState");
        }

        public static SelectState Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SelectState();
                }

                return instance;
            }
            set { instance = value; }
        }

    }
}