using System;
using DietProject.EntityLayer.Common;

namespace DietProject.EntityLayer.Entities
{
	public class UserInformation : BaseEntity
	{
		public double Length { get; set; } // Boy
		public double Weight { get; set; } // Kilo
		public double TargetWeight { get; set; } // Hedeflenen Kilogram
		public double DailyCalorieRequirement { get; set; } // Günlük kalori ihtiyacı
        public double DailyProteinRequirement { get; set; } // Günlük Protein İhtiyacı
        public double DailyFatRequirement { get; set; } // Günlük Yağ İhtiyacı
        public double DailyCarbonhydrateRequirement { get; set; } //Günlük Karbonhidrat İhtiyacı
		public string Gender { get; set; }
		public string Age { get; set; }
		public int AppUserId { get; set; }
		public AppUser? AppUser { get; set; }
    }
}

