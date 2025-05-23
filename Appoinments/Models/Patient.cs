﻿using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appoinments.Models
{
    public class Patient
    {
        [PrimaryKey,AutoIncrement]
        public int Id { get; set; }

        public int UserId { get; set; }

        public string Name { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string PhoneNumber { get; set; }

        public string Address { get; set; }

    }
}
