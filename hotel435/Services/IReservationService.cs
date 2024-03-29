﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using hotel435.Models;

namespace hotel435.Services
{
    public interface IReservationService : IDbOperationsBase<Reservation>
    {
        Reservation GetReservationByConfirmationNumber(string confirmationNumber);
        Task RemoveReservationByConfirmationNumber(string confirmationNumber);
    }
}
