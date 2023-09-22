/*
 ###############################################################################################################
 # I used nested loops to build the shape of a chessboard.                                                     #                                               
 # The reason is because the board is a two-dimensional pattern.It consists of rows and columns.               #
 # And to represent it programmatically,I had to understand how matrices, algorithms, and coordinates work.    #
 # It may be complicated, but it is worth it.                                                                  #
 ###############################################################################################################
*/
using System.Diagnostics.Metrics;

namespace ChessBoard
{
    internal class Program
    {
        static void Main(string[] args)
        {  // "◻︎"; /*\u25A1*/ Here is an example of using ASCII code for square symbols, which is another alternative to using.
           //"◼︎"; /*\u25A0*/
            
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("Part1\n\nWelcome to the game. \nPlease enter the board size.");
            int size = int.Parse(Console.ReadLine());

            for (int i = 0; i < size; i++) // In order to print rows
            {
                for (int j = 0; j < size; j++) // In order to print columns
                    //In each loop, the number of columns and rows is replaced by the variable "Size" entered by the user
                   
                    if ((i+j) % 2 == 0)
                    //In short, this line is used to check whether the sum of row and column value is an even number or not.
                    //If the condition is true (remainder equals zero), the code inside the conditional statement will be executed ◻︎.
                    {
                        Console.Write("◻︎");
                    }
                    else
                    {
                        Console.Write("◼︎");
                    }
                Console.WriteLine();

            }
            //In this part, I will ask the user to select characters for the boxes.
            Console.WriteLine("\n\n\nPart2\n\n");
            
            Console.WriteLine("Welcome to the game. \nPlease enter the board size.");
            int size1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the black square symbol");
            string blackSquareSymbols = Console.ReadLine();

            Console.WriteLine("Enter the white square symbol");
            string whiteSquareSymbols = Console.ReadLine();
           
            for (int row = 0; row < size1; row++)
            {
                for (int col = 0; col < size1; col++)

                    if ((row + col) % 2 == 0)
                    {
                        Console.Write(whiteSquareSymbols);

                    }
                    else
                    {
                        Console.Write(blackSquareSymbols);
                    }
                Console.WriteLine();
            }

            //In this part, I will ask the user to use Emoji characters for the boxes.
            Console.WriteLine("\n\n\nPart3\n\n");

            Console.WriteLine("Welcome to the game. \nPlease enter the board size.");
            
            int size2 = int.Parse(Console.ReadLine());
            string one = "\u2764";
            string two = "\uD83D\uDD25";
            //Here I just gave an example of the options,
            //but it will not work in the real way because I did not want the code to be long.
            Console.WriteLine("Please choose the emoji number");
            Console.WriteLine($"1) For white Square  Heart {one} \n2) For black quare fire {two} ");
            string blackSquareEmoji = Console.ReadLine();
            string whiteSquareSEmoji = Console.ReadLine();

            for (int row1 = 0; row1 < size2; row1++)
            {
                for (int col1 = 0; col1 < size2; col1++)

                    if ((row1 + col1) % 2 == 0)
                    {
                        Console.Write(one);
                    }
                    else
                    {
                        Console.Write(two);
                    }
                Console.WriteLine();
            }
            //In this part, I will ask the user to moves an piece to any square he chooses.

            /*
           # ########################################################################################################### #
           # Using LINQ and Char.IsDigit to filter out non-digit characters from the input string.                       #                                                                            
           # After searching a little, I discovered more than one method, for example, a two-dimensional Array           #                            
           # but what came to my mind is that it is possible to use an easier method, which is to delete the letter from #                                    
           # the value that the user entered and rely on the number only.                                                #
           #  This is what you will discover if you write only the movement number without a letter                      #
           # ########################################################################################################### #
          */
            Console.WriteLine("\n\nPart4\n\nMoves an piece to any square.\nEnter square name as an example: A3");
            string position = Console.ReadLine();
            //Then, i convert the filtered characters back to a string and parse it as an integer
            string numberString = new string(position.Where(c => Char.IsDigit(c)).ToArray());
            int column2 = int.Parse(numberString);
            int row2 = int.Parse(numberString);
            for (int i = 1; i <= 10; i++) //Here I entered or assumed the size of the chessboard directly by giving it a value of 10
            {
                for (int j = 1; j <= 10; j++)
                {
                    //Here i put the condition If the resulting number string is not empty
                    if (i == row2 && j == column2 && !string.IsNullOrEmpty(numberString))
                    {
                        Console.Write("♜");
                    }
                    else if ((i + j) % 2 == 0)
                    {
                        Console.Write("◼︎");
                    }
                    else
                    {
                        Console.Write("◻︎");
                    }
                }
                Console.WriteLine(); 
        }
            //Here is a second method that relies on converting the square name into ASCII code,
            //and then comparing it with the coordinates of the chessboard

            Console.WriteLine("\n\nPart5\n\nEnter square name as an example: A3");
            string position2 = Console.ReadLine();

            //The first character of the position string is extracted using position[0]. This character represents the column letter.
            //'A' it is lile benchmark 
            //The letter 'A' is subtracted from the extracted character to get the column number.
            //This is done by subtracting the ASCII value of 'A' from the ASCII value of the extracted character.
            //For example, if the user enters 'B', the calculation would be: 'B' - 'A' + 1 = 2.
           
            int column3 = position2[0] - 'A' + 1;
            //This line essentially converts the column letter into a numerical value
            
            //The Substring(1) method is used to extract the remaining characters of the position string,
            //which represent the row number.
            int row3 = int.Parse(position2.Substring(1));

            for (int a = 1; a <= 10; a++)
            {
                for (int b = 1; b <= 10; b++)
                {
                    if (a == row3 && b == column3)
                    {
                        Console.Write("X"); //Here I used the symbol X to represent the figure that will move on the chessboard.
                    }
                    else if ((a + b) % 2 == 0)
                    {
                        Console.Write("◼︎");
                    }
                    else
                    {
                        Console.Write("◻︎");
                    }
                }
                Console.WriteLine();
            }
        }
}
}
