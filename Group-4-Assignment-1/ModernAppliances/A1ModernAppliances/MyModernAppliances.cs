using ModernAppliances.Entities;
using ModernAppliances.Entities.Abstract;
using ModernAppliances.Helpers;

namespace ModernAppliances
{
    /// <summary>
    /// Manager class for Modern Appliances
    /// </summary>
    /// <remarks>Author: Bhaumik Kalpesh Gohil, Harshil Vijayjumar Rathod, Kamalpreet Singh, Rudra Chiragkumar Patel </remarks>
    /// <remarks>Date:11-JUN-2024 </remarks>
    internal class MyModernAppliances : ModernAppliances
    {
        /// <summary>
        /// Option 1: Performs a checkout
        /// </summary>
        public override void Checkout()
        {
            // Write "Enter the item number of an appliance: "
            Console.WriteLine("Enter the item number of an appliance: ");

            // Create long variable to hold item number
            long itemNumber;

            // Get user input as string and assign to variable.
            string userInput = Console.ReadLine();

            // Convert user input from string to long and store as item number variable.
            itemNumber = long.Parse(userInput);

            // Create 'foundAppliance' variable to hold appliance with item number
            List<Appliance> found = new List<Appliance>();

            // Assign null to foundAppliance (foundAppliance may need to be set as nullable)
            
            // Loop through Appliances
            foreach(Appliance appliance in Appliances)
            {
            // Test appliance item number equals entered item number
                if (appliance.ItemNumber == itemNumber)
                {
                    // Assign appliance in list to foundAppliance variable
                    found.Add(appliance);
                    // Break out of loop (since we found what need to)
                    break;
                }
            }


            // Test appliance was not found (foundAppliance is null)
            if (found.Count == 0)
            {
                // Write "No appliances found with that item number."
                Console.WriteLine("No appliances found with that item number.");
                return;
            }

            // Otherwise (appliance was found)
            Appliance check = found[0];
            // Test found appliance is available
            if (check.IsAvailable)
            {
                check.Checkout();
                Console.WriteLine($"Appliance {itemNumber} has been checked out.");
            }
            else
            {
                Console.WriteLine("The appliance is not available to be checked out.");
            }
                    // Checkout found appliance

                    // Write "Appliance has been checked out."
                // Otherwise (appliance isn't available)
                    // Write "The appliance is not available to be checked out."
        }

        /// <summary>
        /// Option 2: Finds appliances
        /// </summary>
        public override void Find()
        {
            // Write "Enter brand to search for:"
            Console.WriteLine("Enter brand to search for: ");
            string userEnteredBrand;
            userEnteredBrand = Console.ReadLine();
            // Create string variable to hold entered brand
            // Get user input as string and assign to variable.
            // Create list to hold found Appliance objects
            List<Appliance> found = new List<Appliance>(); 

            // Iterate through loaded appliances
            foreach (var appliance in Appliances)
            {
                if (appliance.Brand == userEnteredBrand)
                {
                    found.Add(appliance);
                }
            }
            // Test current appliance brand matches what user entered
            // Add current appliance in list to found list


            // Display found appliances
            DisplayAppliancesFromList(found, 0);
        }

        /// <summary>
        /// Displays Refridgerators
        /// </summary>
        public override void DisplayRefrigerators()
        {
            // Write "Possible options:"
            Console.WriteLine("Possible options: ");

            // Write "0 - Any"
            Console.WriteLine("0 - Any\n2 - Double doors\n3 - three doors\n4 - Four doors ");
            // Write "2 - Double doors"
            // Write "3 - Three doors"
            // Write "4 - Four doors"

            // Write "Enter number of doors: "
            Console.WriteLine("Enter numbers of doors:");
            // Create variable to hold entered number of doors
            string enteredNumber;
            // Get user input as string and assign to variable
            string userInput = Console.ReadLine();
            // Convert user input from string to int and store as number of doors variable.
            int numberOfDoors = Convert.ToInt32(userInput);
            // Create list to hold found Appliance objects
            List<Appliance> found = new List<Appliance>(); 

            // Iterate/loop through Appliances
            foreach (var appliance in Appliances)
            {
                if (appliance is Refrigerator)
                {
                    Refrigerator refrigerator = (Refrigerator)appliance;
                    if (numberOfDoors == 0 || refrigerator.Doors == numberOfDoors)
                    {
                        found.Add(appliance);
                    }
                }
            }
                // Test that current appliance is a refrigerator
                    // Down cast Appliance to Refrigerator
                    // Refrigerator refrigerator = (Refrigerator) appliance;

                    // Test user entered 0 or refrigerator doors equals what user entered.
                        // Add current appliance in list to found list

            // Display found appliances
            DisplayAppliancesFromList(found, 0);
        }

        /// <summary>
        /// Displays Vacuums
        /// </summary>
        /// <param name="grade">Grade of vacuum to find (or null for any grade)</param>
        /// <param name="voltage">Vacuum voltage (or 0 for any voltage)</param>
        public override void DisplayVacuums()
        {
            // Write "Possible options:"
            Console.WriteLine("Possible options: ");

            Console.WriteLine("0 - Any\n1 - residential\n2 - Commercial");
            // Write "0 - Any"
            // Write "1 - Residential"
            // Write "2 - Commercial"

            // Write "Enter grade:"
            Console.WriteLine("Enter grade:");


            // Get user input as string and assign to variable
            string userInputGrade = Console.ReadLine();

            // Create grade variable to hold grade to find (Any, Residential, or Commercial)
            string grade;

            // Test input is "0"
            if (userInputGrade == "0")
            {
                grade = "Any";
            }
            else if (userInputGrade == "1")
            {
                grade = "Residential";
            }
            else if (userInputGrade == "2")
            {
                grade = "Commercial";
            }
            else
            {
                Console.WriteLine("Invalid Option");
                return;
            }

            // Assign "Any" to grade
            // Test input is "1"
            // Assign "Residential" to grade
            // Test input is "2"
            // Assign "Commercial" to grade
            // Otherwise (input is something else)
            // Write "Invalid option."

            // Return to calling (previous) method
            // return;

            // Write "Possible options:"
            Console.WriteLine("Possible options:");

            // Write "0 - Any"
            Console.WriteLine("0 - Any\n1 - 18 Volt\n2 - 24 Volt");
            // Write "1 - 18 Volt"
            // Write "2 - 24 Volt"

            // Write "Enter voltage:"
            Console.WriteLine("Enter voltage:");


            // Get user input as string
            string userInputVoltage = Console.ReadLine();
            // Create variable to hold voltage
            short Voltage;

            // Test input is "0"
            if (userInputVoltage == "0")
            {
                Voltage = 0;
            } 
            else if (userInputVoltage == "1")
            {
                Voltage = 18;
            }
            else if (userInputVoltage == "2")
            {
                Voltage = 24;
            }
            else
            {
                Console.WriteLine("Invalid option.");
                return;
            }
            // Assign 0 to voltage
            // Test input is "1"
            // Assign 18 to voltage
            // Test input is "2"
            // Assign 24 to voltage
            // Otherwise
            // Write "Invalid option."
            // Return to calling (previous) method
            // return;


            // Create found variable to hold list of found appliances.
            List<Appliance> found = new List<Appliance>();
            // Loop through Appliances

            foreach (var appliance in Appliances)
            {
                if (appliance is Vacuum)
                {
                    Vacuum vacuum = (Vacuum)appliance;
                    if ((grade == "Any" || grade == vacuum.Grade) && (Voltage == 0 || Voltage == vacuum.BatteryVoltage))
                    {
                        found.Add(vacuum);
                    }
                }
            }
            // Check if current appliance is vacuum
            // Down cast current Appliance to Vacuum object
            // Vacuum vacuum = (Vacuum)appliance;
         
            // Test grade is "Any" or grade is equal to current vacuum grade and voltage is 0 or voltage is equal to current vacuum voltage
            // Add current appliance in list to found list

            // Display found appliances
            DisplayAppliancesFromList(found, 0);
        }

        /// <summary>
        /// Displays microwaves
        /// </summary>
        public override void DisplayMicrowaves()
        {
            // Write "Possible options:"
            Console.WriteLine("Possible options:");

            // Write "0 - Any"
            Console.WriteLine("0 - Any\n1 - Kitchen\n2 - Work site");
            // Write "1 - Kitchen"
            // Write "2 - Work site"

            // Write "Enter room type:"
            Console.WriteLine("Enter room type:");
            // Get user input as string and assign to variable
            string userInput = Console.ReadLine();
            // Create character variable that holds room type
            char roomType;
            // Test input is "0"

            if (userInput == "0")
            {
                roomType = 'A';
            }
            else if (userInput == "1")
            {
                roomType = 'K';
            }
            else if (userInput == "2")
            {
                roomType = 'W';
            }
            else
            {
                Console.WriteLine("Invalid Option.");
                return;
            }
            // Assign 'A' to room type variable
            // Test input is "1"
            // Assign 'K' to room type variable
            // Test input is "2"
            // Assign 'W' to room type variable
            // Otherwise (input is something else)
            // Write "Invalid option."
            // Return to calling method
            // return;

            // Create variable that holds list of 'found' appliances
            List<Appliance> found = new List<Appliance>();
            // Loop through Appliances
            foreach (var appliance in Appliances)
            {
                if (appliance is Microwave)
                {
                    Microwave microwave = (Microwave)appliance;
                    if(roomType == 'A' || roomType == microwave.RoomType)
                    {
                        found.Add(microwave);
                    }
                }
            }
                // Test current appliance is Microwave
                    // Down cast Appliance to Microwave

                    // Test room type equals 'A' or microwave room type
                        // Add current appliance in list to found list

            // Display found appliances
            DisplayAppliancesFromList(found, 0);
        }

        /// <summary>
        /// Displays dishwashers
        /// </summary>
        public override void DisplayDishwashers()
        {
            // Write "Possible options:"
            Console.WriteLine("Possible options:");

            // Write "0 - Any"
            Console.WriteLine("1 - Quietest\n2 - Quieter\n3 - Quiet\n4 - Moderate");
            // Write "1 - Quietest"
            // Write "2 - Quieter"
            // Write "3 - Quiet"
            // Write "4 - Moderate"

            // Write "Enter sound rating:"
            Console.WriteLine("Enter sound rating:");
            // Get user input as string and assign to variable
            string userInput = Console.ReadLine();
            // Create variable that holds sound rating
            string soundRating;

            // Test input is "0"
            if (userInput == "0")
            {
                soundRating = "Any";
            }
            else if (userInput == "1")
            {
                soundRating = "Qt";
            }
            else if (userInput == "2")
            {
                soundRating = "Qr";
            }
            else if (userInput == "3")
            {
                soundRating = "Qu";
            }
            else if (userInput == "4")
            {
                soundRating = "M";
            }
            else
            {
                Console.WriteLine("Invalid option.");
                return;
            }
            // Assign "Any" to sound rating variable
            // Test input is "1"
            // Assign "Qt" to sound rating variable
            // Test input is "2"
            // Assign "Qr" to sound rating variable
            // Test input is "3"
            // Assign "Qu" to sound rating variable
            // Test input is "4"
            // Assign "M" to sound rating variable
            // Otherwise (input is something else)
            // Write "Invalid option."
            // Return to calling method

            // Create variable that holds list of found appliances
            List<Appliance> found = new List<Appliance>();
            // Loop through Appliances
            foreach (var appliance in Appliances)
            {
                if (appliance is Dishwasher)
                {
                    Dishwasher dishwasher = (Dishwasher)appliance;
                    if (soundRating == "Any" || dishwasher.SoundRating == soundRating)
                    {
                        found.Add(dishwasher);
                    }
                }
            }
                // Test if current appliance is dishwasher
                    // Down cast current Appliance to Dishwasher

                    // Test sound rating is "Any" or equals soundrating for current dishwasher
                        // Add current appliance in list to found list

            // Display found appliances (up to max. number inputted)
            DisplayAppliancesFromList(found, 0);
        }

        /// <summary>
        /// Generates random list of appliances
        /// </summary>
        public override void RandomList()
        {
            // Write "Appliance Types"
            Console.WriteLine("Appliance Types");

            // Write "0 - Any"
            Console.WriteLine("0 - Any");
            Console.WriteLine("1 - Refrigerators");
            Console.WriteLine("2 - Vacuums");
            Console.WriteLine("3 - Microwaves");
            Console.WriteLine("4 - Dishwashers");
            // Write "1 – Refrigerators"
            // Write "2 – Vacuums"
            // Write "3 – Microwaves"
            // Write "4 – Dishwashers"

            // Write "Enter type of appliance:"
            Console.WriteLine("Enter type of appliance");

            // Get user input as string and assign to appliance type variable
            string userInputType = Console.ReadLine();
            // Write "Enter number of appliances: "

            Console.WriteLine("Enter number of appliances: ");
            // Get user input as string and assign to variable
            string numberOfAppliancesInput = Console.ReadLine();
            // Convert user input from string to int
            int userInputNumberOfAppliances = Convert.ToInt32(numberOfAppliancesInput);

            // Create variable to hold list of found appliances
            List<Appliance> found = new List<Appliance>();

            // Loop through appliances
            foreach (Appliance appliance in Appliances)
            {
                if (userInputType == "0")
                {
                    found.Add(appliance);
                }
                else if (userInputType == "1" && appliance is Refrigerator)
                {
                    found.Add(appliance);
                }
                else if (userInputType == "2" && appliance is Vacuum)
                {
                    found.Add(appliance);
                }
                else if (userInputType == "3" && appliance is Microwave)
                {
                    found.Add(appliance);
                }
                else if (userInputType == "4" && appliance is Dishwasher)
                {
                    found.Add(appliance);
                }
            }
            // Test inputted appliance type is "0"
                    // Add current appliance in list to found list
                // Test inputted appliance type is "1"
                    // Test current appliance type is Refrigerator
                        // Add current appliance in list to found list
                // Test inputted appliance type is "2"
                    // Test current appliance type is Vacuum
                        // Add current appliance in list to found list
                // Test inputted appliance type is "3"
                    // Test current appliance type is Microwave
                        // Add current appliance in list to found list
                // Test inputted appliance type is "4"
                    // Test current appliance type is Dishwasher
                        // Add current appliance in list to found list

            // Randomize list of found appliances
            found.Sort(new RandomComparer());

            // Display found appliances (up to max. number inputted)
            DisplayAppliancesFromList(found, userInputNumberOfAppliances);
        }
    }
}
