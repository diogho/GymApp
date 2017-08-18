﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite.Net.Attributes;

namespace GymApp.Models
{
    class MClient
    {
        [PrimaryKey, AutoIncrement]
        public int IDClient { get; set; }
        public int Document { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthdate { get; set; }
        public int Group { get; set; }


    }
}
