using System;
public class Vault
{
    private string storedPassword;

    public Vault(string password)
    {
        storedPassword = password;
    }

    public string GetPassword()
    {
        return storedPassword;
    }

    public void SetPassword(string password)
    {
        storedPassword = password;
    }

    public override string ToString()
    {
        return "Vault Password: " + storedPassword;
    }
}
