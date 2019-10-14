using System;

namespace WishShop
{
    public class Wish // : Object
    {
        public string Text { get; }
        public int Price { get; protected set; }
        // "Protected" allows any derived/sub/child classes to change that parent's property, field, etc.
        protected int _successPercentage = 90;

        public Wish(string text)
        {
            Text = text;
            Price = 10_000;
        }
        // You can override methods on C#'s built-in Object class 
        public override string ToString()
        {
            return $"The Wish is: {Text}. It costs {Price}";
        }

        // Make the method virtual so derived classes can modify it
        public virtual bool MakeWish(User user)
        {
            if (user.Money < Price)
            {
                throw new Exception("You don't have enough money to make this wish");
            }

            user.Money -= Price;

            bool isWishSuccessful = CalculateSuccess();

            Console.WriteLine("-----------------------------------------------------------");
            if (isWishSuccessful)
            {
                Console.WriteLine($"  Your Wish, '{Text},` was successful!");
            }
            else
            {
                Console.WriteLine($"  Sorry, your Wish, '{Text},` didn't work out!");
            }
            Console.WriteLine("-----------------------------------------------------------");

            return isWishSuccessful;
        }

        private bool CalculateSuccess()
        {
            return new Random().Next(1, 101) < _successPercentage;
        }
    }
}