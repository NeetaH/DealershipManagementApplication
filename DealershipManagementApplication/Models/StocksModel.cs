using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealershipManagementApplication.Models
{
    public class StocksModel : BaseModel
    {
        private string _StockName;
        public string StockName
        {
            get { return _StockName; }
            set { _StockName = value; }
        }
    }
}
