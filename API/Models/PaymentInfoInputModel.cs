using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
  public class PaymentInfoInputModel
  {
    public int IdProject { get; set; }
    public string CreditCardNumber { get; set; }
    public string Cvv { get; set; }
    public string ExpiresAT { get; set; }
    public string FullName { get; set; }
    public decimal Amount { get; set; }
  }
}