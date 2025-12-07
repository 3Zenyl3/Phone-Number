public class PhoneNumber
{
    public static string Clean(string phoneNumber)
    {
        if (phoneNumber[0] == '+')
        {
            phoneNumber = phoneNumber.Substring(1);
        } 
        if (phoneNumber[0] == '1')
        {
            phoneNumber = phoneNumber.Substring(1);
        } 
        string res = "";
        string check = "0123456789";
        for (int i = 0; i < phoneNumber.Length; i++)
        {
            if (check.Contains(phoneNumber[i]))
            {
                res+= phoneNumber[i]; 
            }
        }
        if (res.Length != 10 || res[0]<'2'|| res[3]<'2')
            throw new ArgumentException();
        return res; 
    }
}
