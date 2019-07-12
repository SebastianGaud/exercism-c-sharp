using System;
using System.Linq;
using System.Text.RegularExpressions;

public class PhoneNumber
{
    public static string Clean(string phoneNumber)
    {
        var phone = new string(phoneNumber.Where(Char.IsDigit).ToArray()).RemoveAreaCodeIfPresent();
        return phone.IsValidPhoneNumber() ? phone : throw new ArgumentException();
    }

    
}


public static class PhoneNumberExtension
{
    public static bool IsValidPhoneNumber(this string phoneNumber) 
        => Regex.IsMatch(phoneNumber, @"^[2-9][0-9]{2}[2-9][0-9]{6}$");

    public static string RemoveAreaCodeIfPresent(this string phone) 
        => phone[0] == '1' ? phone.Substring(1, phone.Length - 1) : phone;
}