﻿using System;
using System.Collections.Generic;

namespace EsencialPractica
{
    class Program
    {
        //Para tipos referencia
        public class Coordenates { public int x; public int y; };

        static void Main(string[] args)
        {
            /*** Tipos valor y tipos referencia ***/
            #region tipos valor
            bool value = false;
            bool newValue = value;

            value = true;

            Console.WriteLine("value {0}", value); //true
            Console.WriteLine("newValue {0}", newValue); //false
            #endregion

            #region tipos referencia
            Coordenates coordA = new Coordenates();
            coordA.x = 1;
            coordA.y = 50;

            Coordenates coordB = coordA;
            Console.WriteLine("coordB.x {0}", coordB.x); //1
            Console.WriteLine("coordB.y {0}", coordB.y); //50
            coordA.x = 100;
            Console.WriteLine("coordB.x {0}", coordB.x); //100 - se ha copiado la ref a coordA, por lo tanto el valor sera el mismo que coordA.x
            Console.WriteLine("coordB.y {0}", coordB.y); //50
            #endregion

            #region ref
            int myNumber = 10;
            AddTen(ref myNumber); //se tiene que incluir la palabra reserv. ref en donde se invoca el metodo y en la declaracion del metodo
            Console.WriteLine("myNumber {0}", myNumber); //20
            #endregion

            /*** Tipos genericos ***/
            #region tipos genericos
            var nameList = new List<string>(); //requiere using System.Collections.Generic;
            nameList.Add("Name");
            Console.WriteLine("nameList {0}", nameList[0].ToString());
            #endregion

            #region crear clase generica
            var str = new Concat<int>();
            str.Add(5);
            str.Add(9);
            Console.WriteLine("str {0}", str.result); //59

            var strBool = new Concat<bool>();
            strBool.Add(false);
            strBool.Add(true);
            Console.WriteLine("str {0}", strBool.result); //falsetrue
            #endregion

            /*** Tipos anonimos ***/
            #region anonimos
            #endregion

        }

        //Para ref
        static void AddTen(ref int number)
        {
            number += 10;
        }
    }
}
