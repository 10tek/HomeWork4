using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4
{
    public enum CarCondition
    {
        New,
        OnRun,
        Emergency
    }

    public partial class Car
    {
        public void Show()
        {
            Console.WriteLine($"Model: {Model}, Release year: {_releaseYear}, Price: {Price}");
        }

        public void Init()
        {
            int tmpYear;
            double tmpPrice;
            Console.Write("Model: ");
            Model = Console.ReadLine();
            Console.Write("Release year: ");
            int.TryParse(Console.ReadLine(),out tmpYear);
            _releaseYear = tmpYear;
            Console.Write("Price($): ");
            double.TryParse(Console.ReadLine(), out tmpPrice);
            Price = tmpPrice;
        }
    }
}
