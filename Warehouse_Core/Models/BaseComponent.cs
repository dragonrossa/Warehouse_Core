using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Warehouse_Core.Mediator;

namespace Warehouse_Core.Models
{
   public class BaseComponent
    {
        protected IMediator _mediator;

        public BaseComponent(IMediator mediator = null)
        {
            this._mediator = mediator;
        }

        public void SetMediator(IMediator mediator)
        {
            this._mediator = mediator;
        }
    }
}
