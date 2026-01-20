using System;
public class CrackerMain
{
    static void Main()
    {
        CrackerUtilityImpl crackerUtil = new CrackerUtilityImpl();
        CrackerMenu menuUI = new CrackerMenu(crackerUtil);
        menuUI.ShowMenu();
    }
}
