using System;

namespace TetrisTime
{
    class TicTacToeProgramTime
    {
        static void Main(string[] args) //Program only runs the main function, which means any other part of the code need to be called
        {
            char TacPlayer = 'X';//Starts the process of creating a situation where X or O can be entered into the 2D Array. Function to switch players is down below.
            char[,] Tacboard = new char[3, 3]; //Creates a 2-D Array(!!)



            //-------------------------------------------------Game Intro and Instructions-----------------------------------------------------//
            Console.WriteLine("Welcome to Tic Tac Toe!!");
            Console.WriteLine("Press Enter to See How to Play!");
            Console.ReadLine();
            Console.Clear();


            Console.WriteLine(" 1 | 2 | 3 ");
            Console.WriteLine("---+---+---");
            Console.WriteLine(" 4 | 5 | 6 ");
            Console.WriteLine("---+---+---");
            Console.WriteLine(" 7 | 8 | 9 ");
            Console.WriteLine("Press the corresponding number to choose a space(Instrtuction: 1/3...Press Enter)");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine(" O |   |   ");
            Console.WriteLine("---+---+---");
            Console.WriteLine("   | X |   ");
            Console.WriteLine("---+---+---");
            Console.WriteLine(" X |   |   ");
            Console.WriteLine("Once you type in the number, press enter to fill in the space!(Instrtuction: 2/3...Press Enter)");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine(" O | X | O ");
            Console.WriteLine("---+---+---");
            Console.WriteLine(" O | X |   ");
            Console.WriteLine("---+---+---");
            Console.WriteLine(" X | X |   ");
            Console.WriteLine("First person to get three in a row wins, Press Enter to Play!(Instrtuction: 3/3...Press Enter)");
            Console.ReadLine();
            Console.Clear();

            //----------------------------------------------------------------------------------------------------------------------------------------//


            int movesPlayedSoFar = 0; //Creates a Counter that will be used to let the game know when the players tied
            //bool gamePlaying = true; //Bool for the game loop
            
            //Following three lines are counters initialized to keep track of the score as games are played
            int XWinNumber = 0;
            int YWinNumber = 0;
            int NumberOfTies = 0;

            while (true)
            {


                Console.Clear();

                PrintBoard(Tacboard); //Needed for the board, or any element on the board, to show up. "Print" isn't Pythons print, it's what you named the function below
                Console.Write("It's " + TacPlayer + "\'s Move!!");
                Console.WriteLine("Please Enter Your Space Number!!: ");
                Console.WriteLine("X's Current Score = " + XWinNumber + ". | Y's Current Score = " + YWinNumber + ". | The Current # of Ties = " + NumberOfTies + ".");
                int UserInput = 0; //Is here because the variable must be initialized outside of the try/except clause


                try
                {

                     UserInput = Convert.ToInt32(Console.ReadLine());
                    
                }

                catch (Exception) // Only need to put "Expection e" instead of "Exception" if you want to use the e to show the error message somehow
                
                {

                 

                }



                //The following series of if/else statements makes it so the user only has to press 1 button to input their move instead of having to know.. 
                //..how a 2D array works and putting in two values to do one move. The inner if/else statements are used to tell the game if a player tries..
                //.input into a spot that is already taken
                

                if (UserInput.Equals(1))  
                    
                {
                    if (Tacboard[0,0].Equals('X') || Tacboard[0, 0].Equals('0'))
                    {
                        SpotAlreadyTakenError();

                        continue;
                    }
                    else 
                    { 
                        Tacboard[0, 0] = TacPlayer;
                    
                    }

                    
                }
                else if (UserInput.Equals(2)) 
                {

                    if (Tacboard[0, 1].Equals('X') || Tacboard[0, 1].Equals('0'))
                    {
                        SpotAlreadyTakenError();
                        continue;
                    }
                    else
                    {
                        Tacboard[0, 1] = TacPlayer;
                    }
                }

                else if (UserInput.Equals(3))
                {

                    if (Tacboard[0, 2].Equals('X') || Tacboard[0, 2].Equals('0'))
                    {
                        SpotAlreadyTakenError();
                        continue;
                    }
                    else
                    {
                        Tacboard[0, 2] = TacPlayer;
                    }
                }

                else if (UserInput.Equals(4))
                {

                    if (Tacboard[1, 0].Equals('X') || Tacboard[1, 0].Equals('0'))
                    {
                        SpotAlreadyTakenError();
                        continue;
                    }
                    else
                    {
                        Tacboard[1, 0] = TacPlayer;
                    }
                }

                else if (UserInput.Equals(5))
                {

                    if (Tacboard[1, 1].Equals('X') || Tacboard[1, 1].Equals('0'))
                    {
                        SpotAlreadyTakenError();
                        continue;
                    }
                    else
                    {
                        Tacboard[1, 1] = TacPlayer;
                    }
                }

                else if (UserInput.Equals(6))
                {

                    if (Tacboard[1, 2].Equals('X') || Tacboard[1, 2].Equals('0'))
                    {
                        SpotAlreadyTakenError();
                        continue;
                    }
                    else
                    {
                        Tacboard[1, 2] = TacPlayer;
                    }
                }

                else if (UserInput.Equals(7))
                {

                    if (Tacboard[2, 0].Equals('X') || Tacboard[2, 0].Equals('0'))
                    {
                        SpotAlreadyTakenError();
                        continue;
                    }
                    else
                    {
                        Tacboard[2, 0] = TacPlayer;
                    }
                }

                else if (UserInput.Equals(8))
                {

                    if (Tacboard[2, 1].Equals('X') || Tacboard[2, 1].Equals('0'))
                    {
                        SpotAlreadyTakenError();
                        continue;
                    }
                    else
                    {
                        Tacboard[2, 1] = TacPlayer;
                    }
                }

                else if (UserInput.Equals(9))
                {

                    if (Tacboard[2, 2].Equals('X') || Tacboard[2, 2].Equals('0'))
                    {
                        SpotAlreadyTakenError();
                        continue;
                    }
                    else
                    {
                        Tacboard[2, 2] = TacPlayer;
                    }
                }

                
                else 
                {
                    Console.WriteLine("Invalid Entry. Please pick a number between 1 and 9(Please press Enter once to continue)");
                    Console.ReadLine();
                    continue;


                }

                //-------------------------------------------GAME WINNING LOGIC--------------------------------------------------------------//
                //(Self-Note)The first number of a 2D Array is the number of the row, the second number is the number of the column

                if (TacPlayer == Tacboard[0,0] && TacPlayer == Tacboard[0, 1] && TacPlayer == Tacboard[0, 2])//Straight Line Across for the First Row
                {

                    VictoryFunc(TacPlayer, movesPlayedSoFar = 0);

                    if (TacPlayer == 'X') 
                    {
                        XWinNumber += 1;
                    }

                    else 
                    
                    {

                        YWinNumber += 1;
                    }

                    Array.Clear(Tacboard, 0, Tacboard.Length);
                    continue;

                }

                if (TacPlayer == Tacboard[1, 0] && TacPlayer == Tacboard[1, 1] && TacPlayer == Tacboard[1, 2])//Straight Line Across for the Second Row
                {

                    VictoryFunc(TacPlayer, movesPlayedSoFar = 0);
                    if (TacPlayer == 'X')
                    {
                        XWinNumber += 1;
                    }

                    else

                    {

                        YWinNumber += 1;
                    }
                    Array.Clear(Tacboard, 0, Tacboard.Length);
                    continue;
                }

                if (TacPlayer == Tacboard[2, 0] && TacPlayer == Tacboard[2, 1] && TacPlayer == Tacboard[2, 2])//Straight Line Across for the Third Row
                {

                    VictoryFunc(TacPlayer, movesPlayedSoFar = 0);
                    if (TacPlayer == 'X')
                    {
                        XWinNumber += 1;
                    }

                    else

                    {

                        YWinNumber += 1;
                    }
                    Array.Clear(Tacboard, 0, Tacboard.Length);
                    continue;
                }

                if (TacPlayer == Tacboard[0, 0] && TacPlayer == Tacboard[1, 0] && TacPlayer == Tacboard[2, 0])//Straight Line Down for first column
                {

                    VictoryFunc(TacPlayer, movesPlayedSoFar = 0);
                    if (TacPlayer == 'X')
                    {
                        XWinNumber += 1;
                    }

                    else
                    {

                        YWinNumber += 1;
                    }
                    Array.Clear(Tacboard, 0, Tacboard.Length);
                    continue;
                }

                if (TacPlayer == Tacboard[0, 1] && TacPlayer == Tacboard[1, 1] && TacPlayer == Tacboard[2, 1])//Straight Line Down for Second column
                {

                    VictoryFunc(TacPlayer, movesPlayedSoFar = 0);
                    if (TacPlayer == 'X')
                    {
                        XWinNumber += 1;
                    }

                    else

                    {

                        YWinNumber += 1;
                    }
                    Array.Clear(Tacboard, 0, Tacboard.Length);
                    continue;
                }

                if (TacPlayer == Tacboard[0, 2] && TacPlayer == Tacboard[1, 2] && TacPlayer == Tacboard[2, 2])//Straight Line Down for Third column
                {

                    VictoryFunc(TacPlayer, movesPlayedSoFar = 0);
                    if (TacPlayer == 'X')
                    {
                        XWinNumber += 1;
                    }

                    else

                    {

                        YWinNumber += 1;
                    }
                    Array.Clear(Tacboard, 0, Tacboard.Length);
                    continue;
                }

                if (TacPlayer == Tacboard[0, 0] && TacPlayer == Tacboard[1, 1] && TacPlayer == Tacboard[2, 2])//Diagonal From the Top Left to the Bottom Right
                {

                    VictoryFunc(TacPlayer, movesPlayedSoFar = 0);
                    if (TacPlayer == 'X')
                    {
                        XWinNumber += 1;
                    }

                    else

                    {

                        YWinNumber += 1;
                    }
                    Array.Clear(Tacboard, 0, Tacboard.Length);
                    continue;
                }
                if (TacPlayer == Tacboard[0, 2] && TacPlayer == Tacboard[1, 1] && TacPlayer == Tacboard[2, 0])//Diagonal From the Bottom Left to the Top Right
                {

                    VictoryFunc(TacPlayer, movesPlayedSoFar = 0);
                    
                    if (TacPlayer == 'X')
                    {
                        XWinNumber += 1;
                    }

                    else
                    {

                        YWinNumber += 1;
                    }
                    Array.Clear(Tacboard, 0, Tacboard.Length);
                    continue;
                }
                //----------------------------------------------------------------------------------------------------------------------------------------//


                //-----------------------------------------------------GAME TYING LOGIC ------------------------------------------------------------------//

                movesPlayedSoFar += 1;

                if (movesPlayedSoFar == 9) 
                {
                    Console.WriteLine("You have Tied!");
                    Console.ReadKey();
                    movesPlayedSoFar = 0;
                    NumberOfTies += 1;
                    Array.Clear(Tacboard, 0, Tacboard.Length);
                    continue;
                    

                }
                //----------------------------------------------------------------------------------------------------------------------------------------//


                //Array.Clear(Tacboard, 0, Tacboard.Length); //This allows you to clear the Array as a possible way to start over without exiting the console


                TacPlayer = ChangeTurnFunc(TacPlayer);//This is the initialized version of the function that allows the game to change from 'X' to 'O' every turn



            }


        }

        static char ChangeTurnFunc(char PlayingPlayer)
        {

            if (PlayingPlayer == 'X')
            {

                return 'O';

            }

            else
            {
                return 'X';

            }



        }

        static int VictoryFunc(char Player, int movesPlayedSoFar) 
        {
            Console.WriteLine(Player + " has won the game!!");
            Console.ReadKey();

            return movesPlayedSoFar;

        }

        static void SpotAlreadyTakenError() 
        
        {
            Console.WriteLine("This Spot is already taken! Press Enter to Try Again");
            Console.ReadLine();

        }

        static void PrintBoard(char[, ] Tacboard) 
        {
            Console.WriteLine("  |Tic|Tac|Toe|");
            
            for (int TacRow = 0; TacRow < 3; TacRow++)
            {
                Console.Write("  | ");


                for (int TacCol = 0; TacCol < 3; TacCol++)
                {
                    Console.Write(Tacboard[TacRow, TacCol]); // Printing the gameboard(2D Array) using the loop variables
                    Console.Write(" | ");

                }
                Console.WriteLine();

            }


        }
    }


    /*Console.WriteLine(); //The first test board 
           Console.WriteLine();
           Console.WriteLine(" " +Tacboard[0,0] + "| |  ");
           Console.WriteLine("--+-+--");
           Console.WriteLine("  | |  ");
           Console.WriteLine("--+-+--");
           Console.WriteLine("  | |" + Tacboard[2, 2] + " "); */

    //Console.WriteLine("Your row: " + row + ", Your col: " + col); //Test to see if Row and Col selection work

}
