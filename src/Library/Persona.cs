using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class Persona
    {
        public int Edad {get;}
        public string Name{get;}
        
        public Persona(int edad, string name)
        {
            this.Name=name;
            this.Edad=edad;
        }
    }
}