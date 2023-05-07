using System;
using Villa_API.Models;
using Villa_API.Models.DTO;

namespace Villa_API.Data
{
	public class VillaStore
	{
		public static List<VillaDTO> villaList = new List<VillaDTO>
			{
				new VillaDTO{Id=1, Name="Pool View", Occupancy=4,  SqureFeet=300},
				new VillaDTO{Id=2, Name="Beach Villa", Occupancy=5,  SqureFeet=400},
		};
	}
}

