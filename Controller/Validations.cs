using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace eventure.Controller
{
    public class Validations
    {
        public static (bool isValid, string message) ValidateEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return (false, "Email is required.");

            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            if (!Regex.IsMatch(email, emailPattern))
                return (false, "Invalid email format.");

            return (true, string.Empty);
        }

        public static (bool isValid, string message) ValidatePassword(string password)
        {
            if (string.IsNullOrWhiteSpace(password))
                return (false, "Password is required.");

            if (password.Length < 8)
                return (false, "Password must be at least 8 characters long.");

            if (!Regex.IsMatch(password, @"[A-Z]"))
                return (false, "Password must contain at least one uppercase letter.");

            if (!Regex.IsMatch(password, @"[a-z]"))
                return (false, "Password must contain at least one lowercase letter.");

            if (!Regex.IsMatch(password, @"[0-9]"))
                return (false, "Password must contain at least one number.");

            if (!Regex.IsMatch(password, @"[!@#$%^&*(),.?\"":{}|<>]"))
                return (false, "Password must contain at least one special character.");

            return (true, string.Empty);
        }

        public static (bool isValid, string message) ValidateName(string name, string fieldName)
        {
            if (string.IsNullOrWhiteSpace(name))
                return (false, $"{fieldName} is required.");

            if (name.Length < 2)
                return (false, $"{fieldName} must be at least 2 characters long.");

            if (!Regex.IsMatch(name, @"^[a-zA-Z\s-']+$"))
                return (false, $"{fieldName} can only contain letters, spaces, hyphens, and apostrophes.");

            return (true, string.Empty);
        }

        public static (bool isValid, string message) ValidateUsername(string username)
        {
            if (string.IsNullOrWhiteSpace(username))
                return (false, "Username is required.");

            if (username.Length < 4)
                return (false, "Username must be at least 4 characters long.");

            if (!Regex.IsMatch(username, @"^[a-zA-Z0-9_-]+$"))
                return (false, "Username can only contain letters, numbers, underscores, and hyphens.");

            return (true, string.Empty);
        }
    }
}
