﻿using RestWithASPNETUdemy.Model.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestWithASPNETUdemy.Model
{
    public class Book : BaseEntity
    {
        public string Author { get; set; }
        public string Title { get; set; }
        public DateTime LaunchDate { get; set; }
        public double Price { get; set; }

        public Book()
        {

        }
    }
}
