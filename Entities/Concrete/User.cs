﻿using System;
using System.Collections.Generic;
using System.Text;
using Core.Entity;

namespace Entities.Concrete
{
    public class User : IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string  LastName { get; set; }
        public string Email { get; set; }
        public string Passwd { get; set; }
    }
}