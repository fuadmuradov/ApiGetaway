using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Reservation.API.Infrastructure;
using Reservation.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reservation.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservsController : ControllerBase
    {
        private readonly IReservationService reservationService;

        public ReservsController(IReservationService reservationService)
        {
            this.reservationService = reservationService;
        }

        [HttpGet("{reservnum}")]
        public ReservationDTO GetbyReservNum(int reservnum)
        {
            ReservationDTO reservation = reservationService.GetbyReservNumber(reservnum);
            return reservation;
        }
    }
}
