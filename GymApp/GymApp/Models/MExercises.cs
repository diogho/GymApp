using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite.Net.Attributes;

namespace GymApp.Models
{
    public class MExercises
    {
        [PrimaryKey,AutoIncrement]
        public int IDExercise { get; set; }
        public float Pressplano { get; set; }
        public float PoleaAlta { get; set; }
        public float PresionHombro { get; set; }
        public float PecFly { get; set; }
        public float EspaldaIso { get; set; }
        public float Espalda_4 { get; set; }
        public float Remo { get; set; }
        public float HipAdduction { get; set; }
        public float HipAbduction { get; set; }
        public float LegExtension { get; set; }
        public float LegCurl { get; set; }
        public float PredicatorBiceps { get; set; }
        public float BicepsMancuerna { get; set; }
        public float TricepsMancuernaPatada { get; set; }
        public float VuelosLaterales { get; set; }
        public float VuelosFrontalesBarra { get; set; }
        public float SentadillaBarra { get; set; }
        public float TijerasBarra { get; set; }
        public float Prensa { get; set; }
        public float PantorrillaPrensa { get; set; }
        public float PressMilitarInclinadoMancuerna { get; set; }
        public float PressMilitarPlanoMancuerna { get; set; }
        public float TricepsPolea { get; set; }
        public float BicepsPolea { get; set; }
    }
}
