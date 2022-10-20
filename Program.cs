//N. Harrison Wilkins
//10-19-2022
//GitHub Project Part 8 - GUESS IT
//The user will be be able to choose between an easy, medium, and hard mode.
//easy mode allows 1-10, medium mode allows 1-50, and hard mode allows 1-100 for the user to choose from
//PEER REVIEW IS IN README

Console.Clear();

//VARIABLES REGARDING THE GAME BELOW
string gameStart, option, defaultNumber;

int easyNum, medNum, hardNum, guess, tries;
guess = 0;
tries = 0;

bool correctGuess = false;
bool parseNum = false;
bool isNum;

Random rnd = new Random();


//GAME INTRODUCTION BEFORE DIFFICULTY OPTION
do{
    Console.WriteLine("GREETINGS! CHOOSE \"EASY\" \"MEDIUM\" OR \"HARD\" TO GET STARTED!");
    option = Console.ReadLine().ToUpper();
//VALIDATE OPTIONS TO ONLY ACCEPT "EASY" "MEDIUM" OR "HARD"
    while(option != "EASY" && option != "MEDIUM" && option != "HARD"){
        Console.WriteLine("THAT'S NOT AN ANSWER I WAS TAUGHT TO ACCEPT. TRY AGAIN.");
        Console.ReadLine().ToUpper();
    }
 //EASY OPTION BELOW
    if(option == "EASY"){
        Console.WriteLine("GO AHEAD AND GIVE ME A NUMBER 1-10!");
        easyNum = rnd.Next(1,11);
        tries = 0;

        while(!correctGuess){
            parseNum = false;
            
        while(!parseNum){
            defaultNumber = Console.ReadLine();
        isNum = Int32.TryParse(defaultNumber, out guess);

        if(isNum == true){
            parseNum = true;
            tries++;
        }else{
            Console.WriteLine("THAT'S NOT AN ANSWER I WAS TAUGHT TO ACCEPT. TRY AGAIN.");
        }
        if(guess > easyNum){
            Console.WriteLine("THAT WASN'T IT! LOWER.");
        }
        else if(guess < easyNum){
            Console.WriteLine("THAT WASN'T IT! HIGHER.");
        }else{
            correctGuess = true;
            Console.WriteLine("GREAT JOB! IT TOOK YOU "+tries+" TRIES TO ANSWER.");
        }
        }
        }
    }
//MEDIUM OPTION BELOW
    else if(option == "MEDIUM"){
        Console.WriteLine("GO AHEAD AND GIVE ME A NUMBER 1-50!");
        medNum = rnd.Next(1,51);
        tries = 0;
        while(!correctGuess){
            parseNum = false;
        while(!parseNum){
            defaultNumber = Console.ReadLine();
        isNum = Int32.TryParse(defaultNumber, out guess);

        if(isNum == true){
            parseNum = true;
            tries++;
        }else{
            Console.WriteLine("THAT'S NOT AN ANSWER I WAS TAUGHT TO ACCEPT. TRY AGAIN.");
        }
        if(guess > medNum){
            Console.WriteLine("THAT WASN'T IT! LOWER.");
        }
        else if(guess < medNum){
            Console.WriteLine("THAT WASN'T IT! HIGHER.");
        }else{
            correctGuess = true;
            Console.WriteLine("GREAT JOB! IT TOOK YOU "+tries+" TRIES TO ANSWER.");
        }
        }
        }
    }
//HARD OPTION BELOW
    else if(option == "HARD"){
        Console.WriteLine("GO AHEAD AND GIVE ME A NUMBER 1-100!");
        hardNum = rnd.Next(1,101);
            tries = 0;
        while(!correctGuess){
            parseNum = false;
        while(!parseNum){
            defaultNumber = Console.ReadLine();
        isNum = Int32.TryParse(defaultNumber, out guess);

        if(isNum == true){
            parseNum = true;
            tries++;
        }else{
            Console.WriteLine("THAT'S NOT AN ANSWER I WAS TAUGHT TO ACCEPT. TRY AGAIN.");
        }
        if(guess > hardNum){
            Console.WriteLine("THAT WASN'T IT! LOWER.");
        }
        else if(guess < hardNum){
            Console.WriteLine("THAT WASN'T IT! HIGHER.");
        }else{
            correctGuess = true;
            Console.WriteLine("GREAT JOB! IT TOOK YOU "+tries+" TRIES TO ANSWER.");
        }
        }    
    }
}
Console.WriteLine("GREAT JOB! TYPE \"Y\" TO PLAY AGAIN, OR ENTER ANY KEY TO EXIT");
}while(Console.ReadLine().ToUpper() == "Y");
