using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace IBLab1
{
    public class Password
    {
        private string? _password;

        public string? Value
        {
            get
            {
                if (this._password == "")
                    return _password;

                Regex regex = new Regex(@"^\$2[abyx]\$\d{2}\$[./A-Za-z0-9]{53}$"); ;
                bool isBcryptHash = regex.IsMatch(_password);
                if (isBcryptHash)
                    return _password;

                string salt = BCrypt.Net.BCrypt.GenerateSalt();
                return BCrypt.Net.BCrypt.HashPassword(_password, salt);
            }
            set
            {
                _password = value;
            }
        }

        public bool IsPasswordCorrespondsRestriction
        {
            get
            {
                bool hasDigit = Regex.IsMatch(_password, "[0-9]");
                bool hasPunctuation = Regex.IsMatch(_password, "[.,;:!?'\"-]");
                bool hasMathSymbols = Regex.IsMatch(_password, "[+\\-*/=]");

                return hasPunctuation && hasDigit && hasMathSymbols;
            }
        }

        public bool IsSamePassword(Password otherPassword)
        {
            try
            {
                return BCrypt.Net.BCrypt.Verify(otherPassword._password, Value);
            }
            catch
            {
                return false;
            }
        }

        public bool IsSamePassword(string otherPassword)
        {
            try
            {
                return BCrypt.Net.BCrypt.Verify(_password, otherPassword);
            }
            catch
            {
                return false;
            }
        }

    }
}
