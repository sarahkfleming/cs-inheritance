using System;

namespace WishShop
{
    public class DiscountWish : Wish
    {
        // Below line is taking text input and passing it up to the constructor in the base/parent class
        public DiscountWish(string text) : base(text)
        {
            Price = 1_000;
            _successPercentage = 50;
        }
        
        public void IncreaseSuccessPercentage()
        {
            _successPercentage += 10;
            Price += 1_000;
        }
        
        public override bool MakeWish(User user)
        {
            Console.WriteLine();
            Console.WriteLine("This person chose to make a Discount Wish");
            return base.MakeWish(user);
        }
    }
}