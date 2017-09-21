using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Maid myHelper = new Maid();

            Washer myWasher = new Washer();
            List<Cloth> clothsToBeWashed = new List<Cloth>() { new Cloth(), new Cloth(),new Cloth()};
            myWasher.Complete += myHelper.MoveToDrier;
            myWasher.Load(clothsToBeWashed);
            myWasher.Start();
           // myWasher.Complete();
        }
    }


    public class Maid
    {
        public void MoveToDrier()
        {

            Console.WriteLine("Cloths moved to drier.");
            Console.ReadLine();
        }

    }
}
