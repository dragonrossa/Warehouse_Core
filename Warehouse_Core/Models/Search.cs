using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Warehouse_Core.Models
{
    class Search:BaseComponent
    {
        public void AddNewItemToSearch()
        {
         
            this._mediator.AddNewItem(this,"Search");

        }
    }
}
