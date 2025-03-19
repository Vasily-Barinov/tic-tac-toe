// initialize global variable
bool gameover = false;
string? input = "";

// draw board
char[,] board = new char[,]
{
    {'1', '2', '3'},
    {'4', '5', '6'},
    {'7', '8', '9'}
};

for (int i = 0; i < 3; i++)
{
    DrawLine();
    Console.WriteLine($"| {board[i, 0]} | {board[i, 1]} | {board[i, 2]} |");
    if (i is 2) DrawLine();
}


// add logic for 2 players
/*
  create a do-while iteration statement with expression (!gameover)
  
  prompt users 1 and 2 by turns to enter a number
  
  after each turn check for a win
  and if a win is present -> assign `gameover` to true
  
 */
int turn = 1;

do
{
    if ((turn % 2) == 1)
    {
        Console.WriteLine("Player 1 (X) turn");
        input = Console.ReadLine();
        
        switch (input)
        {
            case "1":
                board[0, 0] = 'X';
                break;
            case "2":
                board[0, 1] = 'X';
                break;
            case "3":
                board[0, 2] = 'X';
                break;
            case "4":
                board[1, 0] = 'X';
                break;
            case "5":
                board[1, 1] = 'X';
                break;
            case "6":
                board[1, 2] = 'X';
                break;
            case "7":
                board[2, 0] = 'X';
                break;
            case "8":
                board[2, 1] = 'X';
                break;
            case "9":
                board[2, 2] = 'X';
                break;
        }
    }
    else if ((turn % 2) == 0)
    {
        Console.WriteLine("Player 2 (0) turn");
        input = Console.ReadLine();
        
        switch (input)
        {
            case "1":
                board[0, 0] = 'O';
                break;
            case "2":
                board[0, 1] = 'O';
                break;
            case "3":
                board[0, 2] = 'O';
                break;
            case "4":
                board[1, 0] = 'O';
                break;
            case "5":
                board[1, 1] = 'O';
                break;
            case "6":
                board[1, 2] = 'O';
                break;
            case "7":
                board[2, 0] = 'O';
                break;
            case "8":
                board[2, 1] = 'O';
                break;
            case "9":
                board[2, 2] = 'O';
                break;
        }
    }

    for (int i = 0; i < 3; i++)
    {
        if (board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2])
        {
            gameover = true;
            if ((turn % 2) == 1)
            {
                Console.WriteLine("PLAYER 1 WINS");
            }
            else if ((turn % 2) == 0)
            {
                Console.WriteLine("PLAYER 2 WINS");
            }
        }
        else if (board[0, i] == board[1, i] && board[1, i] == board[2, i])
        {
            gameover = true;
            if ((turn % 2) == 1)
            {
                Console.WriteLine("PLAYER 1 WINS");
            }
            else if ((turn % 2) == 0)
            {
                Console.WriteLine("PLAYER 2 WINS");
            }
        }
        else if (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2])
        {
            gameover = true;
            if ((turn % 2) == 1)
            {
                Console.WriteLine("PLAYER 1 WINS");
            }
            else if ((turn % 2) == 0)
            {
                Console.WriteLine("PLAYER 2 WINS");
            }
            
            i = 3;
        }
        
        else if (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0])
        {
            gameover = true;
            if ((turn % 2) == 1)
            {
                Console.WriteLine("PLAYER 1 WINS");
            }
            else if ((turn % 2) == 0)
            {
                Console.WriteLine("PLAYER 2 WINS");
            }
            
            i = 3;
        }

    }
    
    turn++;

    if (turn == 10)
    {
        gameover = true;
        Console.WriteLine("It's a draw.");
    }

    if (gameover == false)
    {
        Console.Clear();
    }
    
    for (int i = 0; i < 3; i++)
    {
        DrawLine();
        Console.WriteLine($"| {board[i, 0]} | {board[i, 1]} | {board[i, 2]} |");
        if (i is 2) DrawLine();
    }
    
    
    
} while (!gameover);

// out add logic for 2 players




// method declaration
void DrawLine()
{
    Console.WriteLine("|---|---|---|");
}
