//Author: Justin Mikolajcik
//Description: A Friendly Game of Tic-Tac-Toe played in the terminal
using System;
using System.Collections.Generic;
internal class Program
{
    static void Main(string[] args)
    {   //Tic-Tac-Toe Program Main
        string turn = "x";
        int count = 0;
        List<string> vals = new List<string>{"1", "2", "3", "4", "5", "6","7", "8", "9"};
        //print the board
        printBoard(vals);
        //x starts and we enter the loop
        Console.WriteLine("x starts");
        while (!checkWin(vals)){

            if (turn == "x"){
            Console.WriteLine("Which spot do you want?");
            string choice = Console.ReadLine();
            int spot =int.Parse(choice);
            //checks of the spot is taken
            while(isTaken(vals,spot)){
                Console.WriteLine("Sorry, that spot is not available. Please choose another");
                choice = Console.ReadLine();
                spot =int.Parse(choice);
            }
            //adds x to the board in the selected spot
            addX(vals,spot);
            }
            else if (turn == "o"){
                Console.WriteLine("Which spot do you want?");
                string choice = Console.ReadLine();
                int spot =int.Parse(choice);
                while(isTaken(vals,spot)){
                Console.WriteLine("Sorry, that spot is not available. Please choose another");
                choice = Console.ReadLine();
                spot =int.Parse(choice);
            }
                addO(vals,spot);
            }
            //prints the board
            printBoard(vals);
            if (checkWin(vals)){Console.WriteLine($"Congrats! {turn} won!");}
            turn = switchTurn(turn);
            count++;
            if (count ==9){
                Console.WriteLine("Cats Game");
                System.Environment.Exit(1);
            }
            
            }
            
            
        

    }

    static bool isTaken(List<string> values, int spot){
        bool taken = false;
        if ((values[spot-1] == "x")||(values[spot-1] == "o")){
            taken = true;
        }
        return taken;
    }

    static string switchTurn(string currentTurn){
        if(currentTurn =="x"){
            currentTurn = "o";
        }
        else{currentTurn="x";}
        return currentTurn;
    }

    static void printBoard(List<string> vals){
        Console.WriteLine($"{vals[0]}|{vals[1]}|{vals[2]}");
        Console.WriteLine("-+-+-");
        Console.WriteLine($"{vals[3]}|{vals[4]}|{vals[5]}");
        Console.WriteLine("-+-+-");
        Console.WriteLine($"{vals[6]}|{vals[7]}|{vals[8]}");
    }
    static void addX(List<string> values, int spot){
        values[spot-1] = "x";
    }

    static void addO(List<string> values, int spot){
        values[spot-1] = "o";
    }

    static bool checkWin(List <string> values){
        bool win = false;
        if ((values[0] =="x" && values[1]=="x"&& values[2]== "x")
        ||(values[3] =="x" && values[4]=="x"&& values[5]== "x")
        ||(values[6] =="x" && values[7]=="x"&& values[8]== "x")
        ||(values[0] =="x" && values[3]=="x"&& values[6]== "x")
        ||(values[1] =="x" && values[4]=="x"&& values[7]== "x")
        ||(values[2] =="x" && values[5]=="x"&& values[8]== "x")
        ||(values[0] =="x" && values[4]=="x"&& values[8]== "x")
        ||(values[2] =="x" && values[4]=="x"&& values[6]== "x")){win = true;}
        else if ((values[0] =="o" && values[1]=="o"&& values[2]== "o")
        ||(values[3] =="o" && values[4]=="o"&& values[5]== "o")
        ||(values[6] =="o" && values[7]=="o"&& values[8]== "o")
        ||(values[0] =="o" && values[3]=="o"&& values[6]== "o")
        ||(values[1] =="o" && values[4]=="o"&& values[7]== "o")
        ||(values[2] =="o" && values[5]=="o"&& values[8]== "o")
        ||(values[0] =="o" && values[4]=="o"&& values[8]== "o")
        ||(values[2] =="o" && values[4]=="o"&& values[6]== "o")){win = true;}
        return win;
    }
}