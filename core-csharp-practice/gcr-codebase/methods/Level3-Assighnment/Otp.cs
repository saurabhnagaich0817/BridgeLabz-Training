using System;

class OTPGenerator
{
    static void Main()
    {
        int[] otp = new int[10];

        // Generate 10 OTPs
        for(int i = 0; i < otp.Length; i++)
        {
            otp[i] = GenerateOTP();
        }

        Console.WriteLine("Generated OTPs:");
        foreach(int otp in otp)
        {
            Console.WriteLine(otp);
        }

        // Check uniqueness
        bool isUnique = CheckUniqueOTP(otp);

        Console.WriteLine("\nAre all OTPs unique? " + isUnique);
    }

    // a. Method to generate 6-digit OTP
    public static int GenerateOTP()
    {
        Random random = new Random();
        return random.Next(100000, 1000000); // 6-digit OTP
    }

    // c. Method to check OTP uniqueness
    public static bool CheckUniqueOTP(int[] otp)
    {
        for(int i = 0; i < otp.Length; i++)
        {
            for(int j = i + 1; j < otp.Length; j++)
            {
                if(otp[i] == otp[j])
                {
                    return false;
                }
            }
        }
        return true;
    }
}
