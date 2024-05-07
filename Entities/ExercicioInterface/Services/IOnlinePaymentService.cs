using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimeiroProjeto.Entities.ExercicioInterface.Services
{
    public interface IOnlinePaymentService
    {
        double Fee(double amount);
        double Interest(double amount, int months);
    }
}