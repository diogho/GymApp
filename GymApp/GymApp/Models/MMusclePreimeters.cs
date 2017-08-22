using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite.Net.Attributes;

namespace GymApp.Models
{
    public class MMusclePreimeters
    {
        [PrimaryKey,AutoIncrement]
        public int IDMParameters { get; set; }
        public float Height { get; set; }
        public float Weight { get; set; }
        public float LeftBiceps { get; set; }
        public float RightBiceps { get; set; }
        public float Abdominal { get; set; }
        public float Back { get; set; }
        public float Gluteus { get; set; }
        public float LeftGastrocnemius { get; set; }
        public float RightGastrocnemius { get; set; }
        public float LeftLeg { get; set; }
        public float RightLeg { get; set; }
        public float Chest { get; set; }
        public float FCMax { get; set; }
        public float FCBasal { get; set; }
    }
}
