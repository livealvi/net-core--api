﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Villa_API.Models.DTO
{
    public class VillaDTO
    {
        public int ID { get; set; }
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
        public string Details { get; set; }
        [Required]
        public double Rate { get; set; }
        public int Occupancy { get; set; }
        public int SqureFeet { get; set; }
        public string ImageURL { get; set; }
        public string Amenity { get; set; }
    }
}

