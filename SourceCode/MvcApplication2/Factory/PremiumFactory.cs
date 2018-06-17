using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MvcApplication2.Interface;
using MvcApplication2.Service;

namespace MvcApplication2.Factory
{
    public static class PremiumFactory
    {
        public static IPremium GetInstance(int gender)
        {
            if (gender == 1)
                return new PremiumMaleService();
            else if (gender == 2)
                return new PremiumFemaleService();
            else
               throw new Exception("Invalid gender type");
        }
    }
}