using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomInterface
{
    class ThreeDCircle : Circle
    {
        //  Скрыть  поле  shapeName,  определенное  выше  в  иерархии,
        protected new string shapeName;
        //  Скрыть  любую  реализацию  Draw(),  находящуюся  выше  в  иерархии,
        public new void Draw()
        {
            Console.WriteLine("Drawing  а  3D  Circle");
        }
    }
}
