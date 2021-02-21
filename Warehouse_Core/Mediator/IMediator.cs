using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Warehouse_Core.Mediator
{
   
      public interface IMediator
        {
        // void Notify(object sender, string ev);
        void AddNewItem(object item, string type);

        }
    
}
