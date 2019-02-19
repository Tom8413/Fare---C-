using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fare
{
    public partial class Form1 : Form
    {
        Amenities comfort;
        

        public Form1()
        {
            InitializeComponent();
            comfort = new Amenities(TransportOfEquipment.Checked, AirConditioningInTheCar.Checked, MusicInTheCar.Checked, (int)TotalNumberOfPeople.Value);

            Passengers[] whatAreTheyDoing = new Passengers[4];
            whatAreTheyDoing[0] = new Passengers() { Activity = "sing", Solution = "turns on the radio" };
            whatAreTheyDoing[1] = new Passengers() { Activity = "converse", Solution = "gives a topic" };
            whatAreTheyDoing[2] = new Passengers() { Activity = "vomit", Solution = "I will slow down a little" };
            whatAreTheyDoing[3] = new Passengers() { Activity = "eat", Solution = "stops" };
            carDriver = new Driver(whatAreTheyDoing);
        }

        private Driver carDriver;


        private void MusicInTheCar_CheckedChanged(object sender, EventArgs e)
        {
            comfort.Song = MusicInTheCar.Checked;
            ShowTotalCost();
        }

        private void ShowTotalCost()
        {
            decimal cost = comfort.TotalCostOfMusic() + comfort.TotalCostOfAirConditioning() + comfort.TotalCostOfEquipment() + (int)comfort.NumberOfPeople * 50;
            TotalCost.Text = cost.ToString("c");

        }

        private void TotalNumberOfPeople_ValueChanged(object sender, EventArgs e)
        {
            WhatPassengersCanDo.Visible = (TotalNumberOfPeople.Value != 0);
            comboBox1.Visible = (TotalNumberOfPeople.Value != 0);
            label4.Visible = (TotalNumberOfPeople.Value != 0);
            DriversAttention.Visible = (TotalNumberOfPeople.Value != 0);
            comfort.NumberOfPeople = (int)TotalNumberOfPeople.Value;
            ShowTotalCost();

        }

        private void AirConditioningInTheCar_CheckedChanged(object sender, EventArgs e)
        {
            comfort.AirConditioning = AirConditioningInTheCar.Checked;
            ShowTotalCost();
        }

        private void TransportOfEquipment_CheckedChanged(object sender, EventArgs e)
        {
            comfort.Equipment = TransportOfEquipment.Checked;
            ShowTotalCost();
        }


        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            carDriver.Checking = comboBox1.Text;
            DriversAttention.Text = carDriver.whatAreTheyDoingNow();
            if (comboBox1.Text == "vomit")
            {
                DriversAttention.Text = carDriver.Effect();
            }
            if (carDriver.turnOffTheRadio())
            {
                MusicInTheCar.Checked = false;
            };
        }
    }
}
