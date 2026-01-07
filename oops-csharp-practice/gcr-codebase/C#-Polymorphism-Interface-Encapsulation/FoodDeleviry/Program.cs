class Program
{
    static void Main(string[] args)
    {
        // Create food items
        FoodItem veg1 = new VegItem("Paneer Butter Masala", 200, 2);
        FoodItem nonVeg1 = new NonVegItem("Chicken Biryani", 300, 1);

        // Array of food items
        FoodItem[] menu = { veg1, nonVeg1 };

        Console.WriteLine("----- Online Food Delivery -----\n");

        foreach (var item in menu)
        {
            item.GetItemDetails();

            double totalPrice = item.CalculateTotalPrice();
            double discount = 0;

            if (item is IDiscountable discountableItem)
            {
                discount = discountableItem.ApplyDiscount();
                Console.WriteLine(discountableItem.GetDiscountDetails());
            }

            double finalPrice = totalPrice - discount;
            Console.WriteLine($"Total Price: {totalPrice}, Discount: {discount}, Final Price: {finalPrice}\n");
        }
    }
}
