using System;
using System.ComponentModel.DataAnnotations.Schema;
namespace Dragons.Models{
    public class Dragon{

        public int DragonId{get;set;}
        public string Nombre{get;set;}
        public string Tipo{get;set;}
    }
}