using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomInterface
{
    interface IPointy
    {
        //  Свойство,  доступное  для  чтения  и  для  записи,
        //  в  этом  интерфейсе  может  выглядеть  так:
        //  retVal  PropName  {  get;  set;  }
        //  а  свойство,  доступное  только  для  записи - так:
        //  retVal  PropName  {  set;  }
        byte Points { get; }
    }
}
