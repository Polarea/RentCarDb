using RentCar.Common.Enums;
using RentCar.Common.Interfaces;

namespace RentCar.Common.Classes
{
	public class Booking : IBooking
	{
		public int Id { get; set; }
		public int IPersonId { get; set; }
		public int VehicleId { get; set; }
		public int KmRented { get; set; }
		public int KmReturned { get; set; }
		public DateTime DateRented { get; set; }
		public DateTime DateReturned { get; set; }
		public double TotalCost { get; set; }
		public BookingStatuses BookingStatus { get; set; }

		public Booking(int bookingId, int vehicleId, int customerId, int kmRented)
		{
			Id = bookingId;
			IPersonId = customerId;
			VehicleId = vehicleId;
			KmRented = kmRented;
			DateRented = DateTime.Today;
			BookingStatus = BookingStatuses.open;
		}

		public void CloseBooking(double priceKm, double priceDay, int kmReturned)
		{
			KmReturned = (kmReturned <= KmRented) ? KmRented : kmReturned;
			DateReturned = DateTime.Today;
			int totalKm = KmReturned - KmRented;
			int totalDays = DateReturned.Day - DateRented.Day;
			TotalCost = (double)((totalKm * priceKm) + (totalDays * priceDay));
			BookingStatus = BookingStatuses.closed;
		}

	}
}
