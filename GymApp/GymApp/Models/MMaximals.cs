using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite.Net.Attributes;

namespace GymApp.Models
{
    class MMaximals
    {
        [PrimaryKey,AutoIncrement]
        public int IDMaximal { get; set; }
        public int Id_Client { get; set; }
        public DateTime DateMaximale { get; set; }
        public int Exercice { get; set; }
    }
}
