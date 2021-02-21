using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Warehouse_Core.Models
{
    class Log:BaseComponent
    {
        public void AddNewItemToLog()
        {

            this._mediator.AddNewItem(this, "Log");

        }
    }
}
