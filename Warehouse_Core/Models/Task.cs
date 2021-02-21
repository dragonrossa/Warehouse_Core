using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Warehouse_Core.Models
{
    class Task:BaseComponent
    {
        public void AddNewItemToTask()
        {

            this._mediator.AddNewItem(this, "Task");

        }
    }
}
