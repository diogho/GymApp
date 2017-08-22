using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite.Net.Attributes;

namespace GymApp.Models
{
    public class MScreeningSheet
    {
        [PrimaryKey,AutoIncrement]
        public int IDScreening { get; set; }
        public int ID_Person { get; set; }
        public DateTime DateScreening { get; set; }
        public string DateScreeningEdit {
            get
            {
                return DateScreening.ToString("dd/MM/yyyy");
            }
        }
        public int ID_MuscleParameters { get; set; }
        public int ID_PhysicalEvaluation { get; set; }
    }
}
