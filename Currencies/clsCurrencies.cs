using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Bank_Managment_System.Currencies
{
    public class clsCurrencies
    {
        public string Country { get; set; } 
        public string Code { get; set; }
        public string Name { get; set; }
        public decimal Rate { get; set; }

        
        public static List<clsCurrencies> GetCountriesWithRates()
        {
            List<clsCurrencies> transferLogs = new List<clsCurrencies>();

            string filePath = " E:/programming Advices/14-C# level 1/Bank Managment System/Files/Currencies.txt";
            if (File.Exists(filePath))
            {
                var lines = File.ReadAllLines(filePath);

                foreach (var line in lines)
                {
                    var data = line.Split(',');

                    if (data.Length == 4)
                    {
                        transferLogs.Add(new clsCurrencies
                        {
                            Country = data[0],
                            Code = data[1],
                            Name = data[2],
                            Rate = decimal.Parse(data[3]),
                       
                        });
                    }
                }
            }

            return transferLogs;
        }

        public static bool IsCurrencyexists(string CurrencyResult)
        {
            

            string filePath = " E:/programming Advices/14-C# level 1/Bank Managment System/Files/Currencies.txt";
            var CurrenciesLin = File.ReadAllLines(filePath);
            foreach (var line in CurrenciesLin)
            {
                var CurrencytData = line.Split(',');
                if (CurrencytData[0] == CurrencyResult || CurrencytData[1]==CurrencyResult)
                {
                    return true;
                }
            }

            return false;

          
        }


    }
}
