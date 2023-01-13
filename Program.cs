using System;

class TicTacToe
{
    static char[] board = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
    static int player = 1;

    static void Main(string[] args)
    {
        int choice;
        char mark;
        do
        {
            Console.Clear();
            Console.WriteLine("Player 1: X and Player 2: O");
            Console.WriteLine("\n");
            DrawBoard();
            player = (player % 2) != 0 ? 1 : 2;
            Console.WriteLine("Player {0}, enter a number:  ", player);
            choice = int.Parse(Console.ReadLine());
            mark = (player == 1) ? 'X' : 'O';
            if (PlaceMark(choice, mark) && CheckForWin(mark))
            {
                Console.WriteLine("Player {0} wins!", player);
                Console.ReadLine();
                Environment.Exit(0);
            }
            player++;
        } while (true);
    }

    private static bool CheckForWin(char mark)
    {
        if ((board[0] == mark && board[1] == mark && board[2] == mark) ||
            (board[3] == mark && board[4] == mark && board[5] == mark) ||
            (board[6] == mark && board[7] == mark && board[8] == mark) ||
            (board[0] == mark && board[3] == mark && board[6] == mark) ||
            (board[1] == mark && board[4] == mark && board[7] == mark) ||
            (board[2] == mark && board[5] == mark && board[8] == mark) ||
            (board[0] == mark && board[4] == mark && board[8] == mark) ||
            (board[2] == mark && board[4] == mark && board[6] == mark))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    private static bool PlaceMark(int choice, char mark)
    {
        if (board[choice - 1] == 'X' || board[choice - 1] == 'O')
        {
            Console.WriteLine("Sorry the row {0} is already marked with {1}", choice, board[choice - 1]);
            Console.WriteLine("\n");
            Console.WriteLine("Please wait 2 second board is loading again.....");
            Console.ReadLine();
            return false;
        }
        else
        {
            board[choice - 1] = mark;
            return true;
        }
    }
    private static void DrawBoard()
    {
        Console.WriteLine("     |     |      ");
        Console.WriteLine("  {0}  |  {1}  |  {2}", board[0], board[1], board[2]);
        Console.WriteLine("_____|_____|_____ ");
        Console.WriteLine("     |     |      ");
        Console.WriteLine("  {0}  |  {1}  |  {2}", board[3], board[4], board[5]);
        Console.WriteLine("_____|_____|_____ ");
        Console.WriteLine("     |     |      ");
        Console.WriteLine("  {0}  |  {1}  |  {2}", board[6], board[7], board[8]);
        Console.WriteLine("     |     |      ");
    }
}

