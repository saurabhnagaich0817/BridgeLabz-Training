using System;

public class CrackerUtilityImpl : ICracker
{
    private char[] allowedChars = { 'a', 'b', 'c', '1', '2' };
    private Vault secureVault;
    private bool isCracked;
    private int tryCount;
    private Random rng = new Random();

    public CrackerUtilityImpl()
    {
        secureVault = new Vault("");
    }

    // ---------- OPTION 1 ----------
    public void CrackUserPassword(string userPassword)
    {
        secureVault.SetPassword(userPassword);
        BeginCracking(userPassword.Length);
    }

    // ---------- OPTION 2 ----------
    public void CrackRandomPassword(int size)
    {
        string generatedPwd = CreateRandomPassword(size);
        secureVault.SetPassword(generatedPwd);

        Console.WriteLine("Randomly Generated Password: " + generatedPwd);
        BeginCracking(size);
    }

    // ---------- COMMON ----------
    private void BeginCracking(int size)
    {
        isCracked = false;
        tryCount = 0;

        char[] guessArray = new char[size];
        GenerateCombinations(0, guessArray);

        Console.WriteLine("Total Attempts: " + tryCount);
    }

    // ---------- BACKTRACKING ----------
    private void GenerateCombinations(int position, char[] guessArray)
    {
        if (isCracked)
            return;

        if (position == guessArray.Length)
        {
            tryCount++;
            string attempt = new string(guessArray);
            Console.WriteLine("Trying: " + attempt);

            if (attempt.Equals(secureVault.GetPassword()))
            {
                Console.WriteLine("\nPassword Cracked: " + attempt);
                isCracked = true;
            }
            return;
        }

        for (int i = 0; i < allowedChars.Length; i++)
        {
            guessArray[position] = allowedChars[i];
            GenerateCombinations(position + 1, guessArray);
            guessArray[position] = '\0'; // backtrack
        }
    }

    // ---------- RANDOM PASSWORD ----------
    private string CreateRandomPassword(int size)
    {
        char[] tempPwd = new char[size];

        for (int i = 0; i < size; i++)
        {
            tempPwd[i] = allowedChars[rng.Next(allowedChars.Length)];
        }

        return new string(tempPwd);
    }
}
