using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite.Net.Attributes;

namespace GymApp.Models
{
    public class MPhysical_Evaluation
    {
        [PrimaryKey,AutoIncrement]
        public int IDPEvaluation { get; set; }
        public float PushUps { get; set; }
        public float BoxJump { get; set; }
        public float JumpwithoutImpulse { get; set; }
        public float Abdominal { get; set; }
        public float PullUps { get; set; }
        public float Fondos { get; set; }
        public float CoopersTest { get; set; }
        public float LegerTest { get; set; }
        public float WellsTest { get; set; }
        public float TestOfMile { get; set; }
        public float IMC { get; set; }
        public float StateCondition { get; set; }

    }
}
