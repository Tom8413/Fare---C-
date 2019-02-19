using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fare
{
    class Amenities
    {
        public bool Equipment { get; set; }
        public int NumberOfPeople { get; set; }
        public bool AirConditioning { get; set; }
        public bool Song { get; set; }

        public Amenities(bool equipment, bool airConditioning, bool song, int numberOfPeople)
        {
            Equipment = equipment;
            NumberOfPeople = numberOfPeople;
            AirConditioning = airConditioning;
            Song = song;
        }
        public decimal TotalCostOfEquipment()
        {
            decimal CostOfEquipmentInTheCar;
            if (Equipment && NumberOfPeople != 0)
            {
                CostOfEquipmentInTheCar = 50 / NumberOfPeople;
            }
            else
                CostOfEquipmentInTheCar = 0;
            return CostOfEquipmentInTheCar;

        }
        public decimal TotalCostOfAirConditioning()
        {
            decimal CostOfAirConditioning;
            if (AirConditioning && (NumberOfPeople <= 3) && NumberOfPeople != 0)
            {
                CostOfAirConditioning = 30 / NumberOfPeople;

            }
            else
                CostOfAirConditioning = 0;
            return CostOfAirConditioning;


        }
        public decimal TotalCostOfMusic()
        {
            decimal CostOfMusicInTheCar;
            if (Song && NumberOfPeople != 0)
            {
                CostOfMusicInTheCar = 40 / NumberOfPeople;
            }
            else
                CostOfMusicInTheCar = 0;
            return CostOfMusicInTheCar;

        }

    }
}
