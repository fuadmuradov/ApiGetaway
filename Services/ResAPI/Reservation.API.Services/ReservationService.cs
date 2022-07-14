using Reservation.API.Infrastructure;
using Reservation.API.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reservation.API.Services
{
    public class ReservationService : IReservationService
    {
        public ReservationDTO GetbyReservNumber(int reservNum)
        {
            return new ReservationDTO()
            {
                Id = (new Random().Next(100)),
                ReservNumber = reservNum,
                CheckinDate = DateTime.Now.AddDays(10),
                CheckoutDate = DateTime.Now.AddDays(15),
                ReservDate = DateTime.Now

            };
        }
    }
}
