using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Models;

namespace API.Services
{
  public interface IPaymentService
  {
    Task<bool> Process(PaymentInfoInputModel paymentInfoInputModel);
  }
}