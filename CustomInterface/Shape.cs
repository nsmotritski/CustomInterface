﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomInterface
{
    //  Абстрактный  базовый  класс  иерархии.
    abstract class Shape
    {
        public Shape(string name = "NoName")
        { PetName = name; }
        public string PetName { get; set; }
        //  Единственный  виртуальный  метод,
        public abstract void Draw();
    }
}
