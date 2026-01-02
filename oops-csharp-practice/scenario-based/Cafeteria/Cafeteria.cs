using System;

// Handles cafeteria food data and related logic
class Cafeteria
{
    // List of available food items
    private string[] foodMenu =
    {
        "Veg Sandwich",
        "Cheese Burger",
        "Pasta",
        "Pizza Slice",
        "French Fries",
        "Cold Coffee",
        "Tea",
        "Samosa",
        "Noodles",
        "Fruit Juice"
    };

    // Shows food menu
    public void PrintMenu()
    {
        Console.WriteLine("\n--- FOOD MENU ---");

        for (int pos = 0; pos < foodMenu.Length; pos++)
        {
            Console.WriteLine($"{pos}. {foodMenu[pos]}");
        }
    }

    // Returns food item using index
    public string FetchItemByNumber(int foodIndex)
    {
        if (foodIndex < 0 || foodIndex >= foodMenu.Length)
        {
            return "Invalid Food Choice";
        }

        return foodMenu[foodIndex];
    }
}
