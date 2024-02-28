using DergiBiraz.Core.Utilities.Result.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DergiBiraz.Core.Utilities.Business
{
    public class BusinessRules
    {
        public static Task<IResult> Run(params Task<IResult>[] logics)
        {
            foreach (var logic in logics) //Bütün metotları gez
            {
                if (!logic.Result.Success) //Metot sonucu başarılı değilse
                {
                    return logic; //Başarısız olan metotdu gönder
                }

            }
            return null; //Bütün metotlar başarılı ise null değer gönder.
        }
    }
}
