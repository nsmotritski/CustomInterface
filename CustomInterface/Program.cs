using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****  Fun  with  Interfaces  *****\n");
            //  Создать  массив  элементов  Shape.
            Shape[] myShapes = {  new  Hexagon(),  new  Circle(), new  Triangle("Joe"),  new  Circle("JoJo")};
            for (int i = 0; i < myShapes.Length; i++)
            {
                //  Вспомните,  что  базовый  класс  Shape  определяет  абстрактный
                //  член  Draw(),  поэтому  все  фигуры  знают,  как  себя  рисовать.
                myShapes[i].Draw();
                //  У  каких  фигур  есть  вершины?
                if (myShapes[i] is IPointy)
                    Console.WriteLine("->  Points:  {0}", ((IPointy)myShapes[i]).Points);
                else
                    Console.WriteLine("->  {0}\'s  notpointy!", myShapes[i].PetName);
                //  Можно  ли  нарисовать  эту  фигуру  в  трехмерном  виде?
                if (myShapes[i] is IDraw3D)
                    DrawIn3D((IDraw3D)myShapes[i]);
                Console.WriteLine();
            }
            //  Получить  первый  элемент,  имеющий  вершины.
            //  Для  безопасности  не  помешает  проверить  firstPointyItem  на  предмет  null.
            IPointy firstPointyItem = FindFirstPointyShape(myShapes);
            Console.WriteLine("The  item has  {0}  points", firstPointyItem.Points);
            Console.ReadLine();
        }
        //  Будет  рисовать  любую  фигуру,  поддерживающую  IDraw3D.
        static void DrawIn3D(IDraw3D itf3d)
        {
            Console.WriteLine("->  Drawing  IDraw3D  compatible  type");
            itf3d.Draw3D();
        }
        //  Этот  метод  возвращает  из  массива  первый  объект,
        //  который  реализует  интерфейс  IPointy.
        static IPointy FindFirstPointyShape(Shape[] shapes)
        {
            foreach (Shape s in shapes)
            {
                if (s is IPointy)
                    return s as IPointy;
            }
            return null;
        }
    }
}
