using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Auto_TransportationClient.Logic;

public class Validation
{
    public bool ValidatePhone(string str)
    {
        Regex tel_pattern = new Regex(@"^[+]?[0-9]{6,12}$");

        return tel_pattern.IsMatch(str);
    }

    public bool ValidateEmail(string email)
    {
        Regex emailPattern = new Regex(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$");

        return emailPattern.IsMatch(email);
    }
}