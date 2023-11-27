using System;
using DietProject.EntityLayer.Common;

namespace DietProject.EntityLayer.Entities
{
	public class UserInformation : BaseEntity
	{
		public int Length { get; set; } // Boy
		public int Weight { get; set; } // Kilo
		public int TargetWeight { get; set; } // Hedeflenen Kilogram
		public int DailyCalorieRequirement { get; set; } // Günlük kalori ihtiyacı
        public int DailyProteinRequirement { get; set; } // Günlük Protein İhtiyacı
        public int DailyFatRequirement { get; set; } // Günlük Yağ İhtiyacı
        public int DailyCarbonhydrateRequirement { get; set; } //Günlük Karbonhidrat İhtiyacı
		public bool Gender { get; set; }
		public string Age { get; set; }
		public int AppUserId { get; set; }
		public AppUser AppUser { get; set; }
    }
}

