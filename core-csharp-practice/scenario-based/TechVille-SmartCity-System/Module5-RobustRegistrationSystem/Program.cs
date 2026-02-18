using System;
using Module5_RobustRegistrationSystem.Services;
using Module5_RobustRegistrationSystem.Exceptions;
using Module5_RobustRegistrationSystem.Logging;

namespace Module5_RobustRegistrationSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            RegistrationService service = new RegistrationService();

            try
            {
                var citizen = service.RegisterCitizen();
                Console.WriteLine($"Citizen Registered: {citizen.Name}");
            }
            catch (InvalidAgeException ex)
            {
                Console.WriteLine(ex.Message);
                ErrorLogger.Log(ex.Message);
            }
            catch (DuplicateCitizenException ex)
            {
                Console.WriteLine(ex.Message);
                ErrorLogger.Log(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unexpected Error");
                ErrorLogger.Log(ex.Message);
            }
            finally
            {
                Console.WriteLine("Registration attempt finished.");
            }

            Console.ReadKey();
        }
    }
}
