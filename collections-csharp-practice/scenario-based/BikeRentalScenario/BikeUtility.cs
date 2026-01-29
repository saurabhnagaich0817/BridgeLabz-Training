using System.Collections.Generic;
public class BikeUtility
{
    public void AddBikeDetails(string model, string brand, int pricePerDay)
    {
        int key = Program.bikeDetails.Count + 1;
        Bike bike = new Bike{Model = model,Brand = brand,PricePerDay = pricePerDay };
       Program.bikeDetails.Add(key, bike);
    }
    public SortedDictionary<string, List<Bike>> GroupBikesByBrand()
    {
        SortedDictionary<string, List<Bike>> groupedBikes =new SortedDictionary<string, List<Bike>>();
       foreach (var item in Program.bikeDetails)
        {   
            Bike bike = item.Value;
            if (!groupedBikes.ContainsKey(bike.Brand))
            {
                groupedBikes[bike.Brand] = new List<Bike>();
            }
             groupedBikes[bike.Brand].Add(bike);
        }
        return groupedBikes;
    }
}
