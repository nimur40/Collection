﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Person(string name,int id) 
        {
            Id = id;
            Name = name;
        }
    }
}
