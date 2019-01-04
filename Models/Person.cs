﻿using System;
using EtbSomalia.Extensions;

namespace EtbSomalia.Models
{
    public class Person
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public bool AgeEstimate { get; set; }
        public PersonAddress Address { get; set; }

        public Person()
        {
            Id = 0;
            Name = "";
            Gender = "";
            DateOfBirth = DateTime.Now;
            AgeEstimate = false;
        }

        public Person Save(){
            SqlServerConnection conn = new SqlServerConnection();
            Id = conn.SqlServerUpdate("INSERT INTO Person(ps_name, ps_gender, ps_dob, ps_estimate) output INSERTED.ps_idnt VALUES ('" + Name + "', '" + Gender + "', getdate(), 1)");

            return this;

        }
    }
}
