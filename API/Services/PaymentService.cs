using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Models;

namespace API.Services
{
  public class PaymentService : IPaymentService
  {
    public async Task<bool> Process(PaymentInfoInputModel paymentInfoInputModel)
    {
      return await Task.FromResult(true);
    }
  }
}