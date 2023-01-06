using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Rafael_Cartsys.src.Shared
{
  internal class ValidaEmail
  {
    public static bool ValidarEmail(string strEmail)
    {
      string strModelo = "^([0-9a-zA-Z]([-.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
      if (Regex.IsMatch(strEmail, strModelo))
      {
        return true;
      }
      else
      {
        return false;
      }
    }
  }
}
