class BillHelper
{
    // Input empty hai ya nahi
    public static bool IsInvalid(string value)
    {
        return string.IsNullOrWhiteSpace(value);
    }

    // Amount nikalta hai string se
    public static int FetchNumber(string text)
    {
        if (string.IsNullOrWhiteSpace(text))
            return 0;

        string digits = "";

        foreach (char ch in text)
        {
            if (char.IsDigit(ch))
                digits += ch;
        }

        int amount;
        return int.TryParse(digits, out amount) ? amount : 0;
    }
}
