using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
  public class PaymentApprovedIntegrationEvent
  {
    public PaymentApprovedIntegrationEvent(int idProject)
    {
      idProject = idProject;
    }
    public int IdProject { get; set; }
  }
}