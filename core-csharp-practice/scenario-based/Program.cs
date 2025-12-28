using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("🐍 SNAKE & LADDER GAME 🪜\n");

        // ---------- PLAYER COUNT ----------
        int playerCount;
        do
        {
            Console.Write("Enter number of players(2 to 4): ");
            playerCount = int.Parse(Console.ReadLine());
        }
        while(playerCount < 2 || playerCount > 4);

        // ---------- PLAYER DATA ----------
        string[] players = new string[playerCount];
        int[] positions = new int[playerCount];

        for(int i = 0; i < playerCount; i++)
        {
            Console.Write($"Enter name of Player {i + 1}: ");
            players[i] = Console.ReadLine();
            positions[i] = 0;
        }

        // ---------- SNAKES(start → end) ----------
        int[] snakeStart = { 99, 70, 52, 25 };
        int[] snakeEnd   = { 54, 55, 42, 2 };

        // ---------- LADDERS(start → end) ----------
        int[] ladderStart = { 6, 11, 46, 60 };
        int[] ladderEnd   = { 25, 40, 90, 85 };

        bool gameOver = false;

        // ---------- GAME LOOP ----------
        while(!gameOver)
        {
            for(int i = 0; i < playerCount; i++)
            {
                Console.WriteLine($"\n🎯 {players[i]}'s Turn(Press Enter)");
                Console.ReadLine();

                int dice = RollDice();
                int oldPos = positions[i];

                int newPos = MovePlayer(oldPos, dice);
//          check snake or ladder
                string message;
                newPos = ApplySnakeOrLadder(
                            newPos,
                            snakeStart, snakeEnd,
                            ladderStart, ladderEnd,
                            out message);

                positions[i] = newPos;

                Console.WriteLine($"Dice Value : {dice}");
                Console.WriteLine($"Position   : {oldPos} → {newPos}");

                if(message != "")
                {
                    Console.WriteLine(message);
                }
//         check win
                if(CheckWin(newPos))
                {
                    Console.WriteLine($"\n🏆 {players[i]} WON THE GAME!");
                    gameOver = true;
                    break;
                }
            }
        }

        Console.WriteLine("\nGame Over");
    }

    // ---------- ROLL DICE ----------
    static int RollDice()
    {
        Random random = new Random();
        return random.Next(1, 7);
    }

    // ---------- MOVE PLAYER ----------
    static int MovePlayer(int currentPosition, int diceValue)
    {
        int nextPosition = currentPosition + diceValue;

        // ternary operator
        nextPosition = nextPosition > 100 ? currentPosition : nextPosition;

        return nextPosition;
    }

    // ---------- SNAKE OR LADDER USING ARRAYS ----------
    static int ApplySnakeOrLadder(
        int position,
        int[] snakeStart, int[] snakeEnd,
        int[] ladderStart, int[] ladderEnd,
        out string message)
    {
        message = "";

        // check snakes
        for(int i = 0; i < snakeStart.Length; i++)
        {
            if(position == snakeStart[i])
            {
                message = "🐍 Snake bite!";
                return snakeEnd[i];
            }
        }

        // check ladders
        for(int i = 0; i < ladderStart.Length; i++)
        {
            if(position == ladderStart[i])
            {
                message = "🪜 Ladder climbed!";
                return ladderEnd[i];
            }
        }

        return position;
    }

    // ---------- CHECK WIN ----------
    static bool CheckWin(int position)
    {
        return position == 100;
    }
}
