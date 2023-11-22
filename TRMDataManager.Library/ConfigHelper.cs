using System;
using System.Configuration;

namespace TRMDataManager.Library
{
    public class ConfigHelper
    {
        // TODO - move this from config to API
        public static decimal GetTaxRate()
        {

            string rateText = ConfigurationManager.AppSettings["taxRate"];

            bool isValidTaxRaate = Decimal.TryParse(rateText, out decimal output);

            if (!isValidTaxRaate)
            {
                throw new ConfigurationErrorsException("The tax rate is not set up properly");
            }

            return output;
        }
    }
}

