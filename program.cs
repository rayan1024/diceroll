Console.Clear();
#nullable disable

// Dice Roll Simulator

// Function that rolls dice

static string roll2dice () {
    Random rnd = new Random(); // Random function for genrating random numbers
    int roll1 = rnd.Next(1, 7);
    int roll2 = rnd.Next(1, 7);
    int sum = roll1 + roll2;
    return $"{roll1}, {roll2} (sum: {sum})";
}

Console.WriteLine("\nWelcome to the Dice Roll Simulator Application\n");
string choice;

bool loop = true;
while (loop) {// Using a loop to run the program until exit
    Console.WriteLine("1. Roll dice once");
    Console.WriteLine("2. Roll dice 5 times");
    Console.WriteLine("3. Roll dice 'n' times");
    Console.WriteLine("4. Roll dice until two 1's");
    Console.WriteLine("5. Exit");
    Console.Write("Enter choice: ");
    // Get user input
    choice = Console.ReadLine();

    if (choice == "1") {
        Console.WriteLine(roll2dice());
    } 
    else if (choice == "2") {
        // For loop to generate random numbers 5 times
        for (int i = 1; i <= 5; i++) {
            roll2dice();
        }
    } 
    else if (choice == "3") {
        int n;
        Console.Write("Enter the number of times to roll the dice: ");
        //Getting input from user to roll dice preferred number of times
        n = int.Parse(Console.ReadLine());
        // Using a loop to generate random number according to user input
        for (int i = 1; i <= n; i++) {
            roll2dice();
        }
    }  
    // else if (choice == "4") {
    //     int rollCount = 0;
    //     // Generate random numbers until both dice will get 1
    //     do {
    //         roll2dice();
    //         //increase the number of roll count until the random number is generated 1 for both dice
    //         rollCount++;
    //     } 
    //     while (roll1 != 1 || roll2 != 1);
    //     Console.WriteLine($"SNAKE EYES! It took {rollCount} to get.");
    // } 
    else if (choice == "5") {
        Console.WriteLine("Exiting program.");
        loop = false;
    } 
    else {
        Console.WriteLine("Invalid choice.");
    }
}
