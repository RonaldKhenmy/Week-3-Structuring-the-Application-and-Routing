using MvcProduct.Interfaces;
namespace MvcProduct.Services
{
    public class DaysPurchased : IDaysPurchased
    { 
        public int CalculateDays (DateTime purchaseDate)
        {
            //Measures the distance by days.
            return (DateTime.Now - purchaseDate).Days;
        }
    }
}
