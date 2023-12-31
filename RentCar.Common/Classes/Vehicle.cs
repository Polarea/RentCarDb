﻿using RentCar.Common.Enums;
using RentCar.Common.Interfaces;

namespace RentCar.Common.Classes
{
	public abstract class Vehicle
	{
		public int Id { get; set; }
		public VehicleStatuses VehicleStatus { get; set; }
		public VehicleTypes VehicleType { get; set; }
		public string Brand { get; set; }
		public string RegNo { get; set; }
		public int Odometer { get; set; }
		public double PriceKm { get; set; }
		public double PriceDay { get; set; }

		protected Vehicle(int id, string regNo, string brand, int odometer, VehicleTypes vehicleTypes,
			double priceKm, double priceDay)
		{
			(Id, RegNo, Brand, Odometer, VehicleStatus, VehicleType, PriceKm, PriceDay) =
				(id, regNo, brand, odometer, VehicleStatuses.Available, vehicleTypes, priceKm, priceDay);
		}
	}
}
