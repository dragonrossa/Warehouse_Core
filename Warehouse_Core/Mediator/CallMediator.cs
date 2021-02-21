using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Warehouse_Core.Models;

namespace Warehouse_Core.Mediator
{
    class CallMediator
    {
        public Admin component1 = new Admin();
        public Log component2 = new Log();
        public Procurement component3 = new Procurement();
        public Search component4 = new Search();
        public Storage component5 = new Storage();
        public Store component6 = new Store();
        public Supplier component7 = new Supplier();
        public Models.Task component8 = new Models.Task();
        public Transfer component9 = new Transfer();
        public User component10 = new User();


    }
}
