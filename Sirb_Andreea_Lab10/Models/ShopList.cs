using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Sirb_Andreea_Lab10.Models
{

   // clasa defineste un model ShopList care va fi folosit pentru a salva fiecare lista de
   // cumparaturi in aplicatia noastra
    public class ShopList
    {
        //Proprietatea ID este marcata ca fiind PrimaryKey si AutoIncrement 
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        
    }
}
