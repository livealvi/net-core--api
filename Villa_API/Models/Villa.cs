﻿using System;
namespace Villa_API.Models
{
	public class VillaDTO
	{
		public int Id { get; set; }
		public string Name { get; set; }
        public int Occupancy { get; set; }
        public int SqureFeet { get; set; }
        public DateTime CreatedDate { get; set; }
	}
}

