using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegate
{
    public delegate void WasherStageHandler();

    public class Washer
    {
        public WasherStageHandler Complete;

        public int Capacity { get; set; }
        public void Load(List<Cloth> cloths)
        {


        }
        public void Start()
        {
            PreWash();
            Wash();
            Rinse();
            Spin();
        }

        private void PreWash()
        {
            FillWater();
            MixDetergent();
        }

        private void MixDetergent()
        {

        }

        private void FillWater()
        {

        }

        private void Wash()
        {
            Agitate();
            MoveCloths();
        }

        private void MoveCloths()
        {
           
        }

        private void Agitate()
        {
           
        }

        public void Rinse()
        {
            PurgeSoapWater();
            SprayFreshWater();
        }
        private void PurgeSoapWater()
        {

        }
        private void SprayFreshWater()
        {
            
        }

        private void Spin()
        {
            Squeeze();
            Twist();

            Complete();
        }

        private void Squeeze()
        {

        }

        private void Twist()
        {
           
        }

    }
}
