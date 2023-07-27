using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmFeedingApp
{
    public class AnimalManager
    {

        List<FarmAnimal> animals;
        string file = "SavedAnimals.txt";


        //dictionary of the species and breeds.
        Dictionary<string, string[]> animalsDictionary = new Dictionary<string, string[]>()
        {
            {"Chicken", new string[]{"Brown", "Silkie" } } ,
            {"Duck", new string[]{"Pekin", "Silver Bantam" } } ,
            {"Alpaca", new string[]{"Suri", "Huacaya" } } ,
            {"Goat", new string[]{"Nubian", "Pygmy" } }
        };

        //parallel list for animals food weight and cost
        List<int> foodWeight = new List<int>()
        {
            20, 1, 25, 20
        };
        List<float> foodPrice = new List<float>()
        {
            33.05f, 8.49f, 50f, 37.70f
        };




        public AnimalManager()
        {
            this.animals = new List<FarmAnimal>();

        }
        public List<FarmAnimal> GetAnimals()
        {

            return this.animals;

        }

        public void SaveAnimals()
        {
            File.WriteAllText(file, String.Empty);

            foreach (FarmAnimal animal in animals)
            {

                string animalData = animal.GetSpecies()+ "," + animal.GetBreed() + "," + animal.GetName() +"," + animal.GetDOB().Day +"#"  +animal.GetDOB().Month + "#" + animal.GetDOB().Year + "," ;
                if (animal.GetConsumptions().Count > 0)
                {
                    foreach (float consumption in animal.GetConsumptions())
                    {
                        animalData += consumption + "#";
                    }

                }

                animalData = animalData.Remove(animalData.Length -1, 1);

                File.AppendAllText(file,animalData + Environment.NewLine);
            }

            

        }

        public List<string> GetSpecies()
        {
            List<string> species = new List<string>();

            foreach (KeyValuePair<string, string[]> speciesObject in animalsDictionary)
            {
                species.Add(speciesObject.Key);
            }
            return species;
        }
        public List<string> GetBreeds(string species)
        {
            List<string> breeds = new List<string>();

            foreach (string breed in animalsDictionary[species])
            {
                breeds.Add(breed);

            }
            return breeds;
        }

        

        public void LoadAnimals()
        {
            // To read a text file line by line
            if (File.Exists(file))
            {
                // Store each line in array of strings
                string[] lines = File.ReadAllLines(file);

                foreach (string ln in lines)
                {
                    //tokenise stored data
                    string[] tokens = ln.Split(',');
                    if (tokens.Length > 1)
                    {
                        string speices = tokens[0];
                        string breed = tokens[1];
                        string name = tokens[2];
                        string[] dateTokens = tokens[3].Split('#');
                        string[] consumptionTokens = tokens[4].Split('#');

                        animals.Add(new FarmAnimal(speices, breed, name, new DateTime(Convert.ToInt32(dateTokens[2]), Convert.ToInt32(dateTokens[1]), Convert.ToInt32(dateTokens[0]))));

                        foreach (string token in consumptionTokens)
                        {
                            animals[animals.Count - 1].AddDailyConsumption((float)Convert.ToDouble(token));
                        }
                    }
                   


                }
            }

        }


        // adding farm animals to a list
        public void AddAnimal(FarmAnimal newAnimal)
        {

            animals.Add(newAnimal);

        }
        

        //Adds a consumption to the most recently added animal
        public void AddConsumption(float consumption)
        {
            animals[animals.Count - 1].AddDailyConsumption(consumption);

        }
        //adds consumption to a selected animal
        public void AddConsumption(float consumption, string selectedAnimal)
        {
            animals[SearchAnimalIndex(selectedAnimal)].AddDailyConsumption(consumption);

        }

        //calculates the food consumed be each species type
        public List<float> CalculateSpeciesFoodConsumption()
        {
            List<float> speciesConsumption = new List<float>() {0, 0, 0 ,0 };
            
            foreach (FarmAnimal farmAnimal in animals)
            {

         
                    speciesConsumption[FindSpeciesIndex(farmAnimal.GetSpecies()) ] += farmAnimal.WeeklyFoodConsumption();
           
            }
           
            return speciesConsumption;
        }

        //finds the index value of a species
        public int FindSpeciesIndex(string species)
        {
            int speciesConter = 0;


            foreach (KeyValuePair<string, string[]> animalType in animalsDictionary)
            {
                
                if (species == animalType.Key)
                {
                    
                    break;
                }
                speciesConter++;
            }

            return speciesConter;
        }




        //return a list of total cost for each species consumption

        public List<float> CalculateSpeciesConsumptionCost()
        {

            List<float> speciesConsumptionCost = new List<float>() { 0, 0, 0, 0 };

            int index = 0;

            foreach (float consumption in CalculateSpeciesFoodConsumption())
            {

                speciesConsumptionCost[index] += CalculateSpeciesFoodConsumption()[index] * foodPrice[index]/foodWeight[index];

                index++;
            }


            return speciesConsumptionCost;
            
        }
        
        public string SpeciesConsumptionCostSummary()
        {
            string costSummary = "";
            int index = 0;
            

            foreach (KeyValuePair<string, string[]> animalType in animalsDictionary)
            {

                costSummary += $" {animalType.Key} Total consumption cost: {CalculateSpeciesConsumptionCost()[index]}\n";

                index++;

            }

            costSummary += "\n\n Total consumption cost: " + CalculateSpeciesConsumptionCost().Sum();      
            return costSummary;
        }
        public string SpeciesConsumptionSummarys()
        {
            string costSummary = "";
            int index = 0;
            

            foreach (KeyValuePair<string, string[]> animalType in animalsDictionary)
            {

                costSummary += $"{animalType.Key} Total consumption cost: {CalculateSpeciesFoodConsumption()[index]}\n";

                index++;
                

            }
            costSummary += "\n\n Total consumption: " + CalculateSpeciesFoodConsumption().Sum();
            return costSummary;
        }
      
        private int SearchAnimalIndex(string selectedAnimal)
        {
            int index = 0;
            foreach (FarmAnimal animal in animals)
            {
                if (animal.GetName().Equals(selectedAnimal))
                {
                    return index;
                }
                index++;
            }
            return -1;

        }
        public string RecentAnimalSummary()
        {
            return animals[animals.Count - 1].AnimalSummary();

        }

        public string AnimalSummary(string selectedAnimal)
        {

            return animals[SearchAnimalIndex(selectedAnimal)].AnimalSummary();

        }


 

    }
}
