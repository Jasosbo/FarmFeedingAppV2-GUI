﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmFeedingApp
{
    public class FarmAnimal
    {
        //atributes
        private string species;
        private string breed;
        private string name;
        private DateTime dob;
        private List<float> foodConsumed;


        //methods/functions

        //constructs a farm animal object
        public FarmAnimal(string species, string breed,string name, DateTime dob)
        {
            this.species = species;
            this.breed = breed;
            this.name = name;   
            this.dob = dob; 
            this.foodConsumed = new List<float>();
        }

        //return species 

        public string GetSpecies()
        { 
            return species;
        }

        public string GetBreed()
        { 
            return breed;
        }

        public string GetName()
        {
            return name;
        }

        public DateTime GetDOB()
        {
            return dob;

        }
        public List<float> GetConsumptions()
        {
            return foodConsumed;
        }

        // add daily consumption to consumption list
        public void AddDailyConsumption(float dailyConsumption)
        {

            foodConsumed.Add(dailyConsumption); 

        }

        //Calculate animals food consumption over the week
        public float WeeklyFoodConsumption()
        {
            float sumConsumption = 0;

            foreach (float consumption in foodConsumed)
            {
            
                sumConsumption += consumption;
            }

            return sumConsumption;
            
            
        }
        float weight = 20f;
        float cost = 33.05f;

        //Calculate animals food cost over a week
        public float WeeklyFoodCost(float weight, float cost)
        {

            //retrieve cost per kg
            


            //calculate cost per unit
            float costPerUnit = cost/ weight;

            //calculate weekly cost - multiply cost per gram by the sumConsumption
            return (float)Math.Round(WeeklyFoodConsumption() * costPerUnit, 2);


        }
        public string ConsumptionBreakdown()
        {
            string consumptionBreakdown = "";
            int dayCounter = 1;
            foreach (float consumption in foodConsumed)
            {

                consumptionBreakdown += $"Day {dayCounter}: {consumption}\n";
                dayCounter++;
            }
            return consumptionBreakdown;
        }

       

        public string AnimalSummary()
        {


            return "----- Aniaml Summary-----\n" +
             $"Species:{species}\n" +
             $"Breeds:{breed}\n" +
             $"Name:{name}\n" +
             $"Date of Birth:{dob.ToString("d", CultureInfo.GetCultureInfo("es-ES"))}\n" +
             ConsumptionBreakdown() +
             $"Weekly Food Consumption: {WeeklyFoodConsumption()}g\n" +
             "Weekly Food Cost: $"+WeeklyFoodCost(weight,cost); 


        }

       


    }
}
