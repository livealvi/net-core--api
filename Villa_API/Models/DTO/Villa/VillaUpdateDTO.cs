﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Villa_API.Models.DTO
{
    public class VillaUpdateDTO
    {
        [Required]
        public int ID { get; set; }
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
        [Required]
        public string Details { get; set; }
        [Required]
        public double Rate { get; set; }
        [Required]
        public int Occupancy { get; set; }
        [Required]
        public int SqureFeet { get; set; }
        [Required]
        public string ImageURL { get; set; }
        [Required]
        public string Amenity { get; set; }
    }
}

