using System;   // Console, Random use karne ke liye

class SnakeLadder
{
    static void Main()
    {
        Console.WriteLine("Snake & Ladder Game\n"); // game title

        int playerCount;

        // valid players(2 to 4) lene ke liye
        do
        {
            Console.Write("Enter number of players(2 to 4): ");
            playerCount = int.Parse(Console.ReadLine());
        }
        while(playerCount < 2 || playerCount > 4);

        // players ke name store karne ke liye
        string[] players = new string[playerCount];

        // players ki position store karne ke liye
        int[] positions = new int[playerCount];

        // players ka data lene ke liye loop
        for(int i = 0; i < playerCount; i++)
        {
            Console.Write("Enter player name: ");
            players[i] = Console.ReadLine();
            positions[i] = 0; // starting position
        }

        // snakes ke start aur end points
        int[] snakeStart = { 99, 70, 52, 25 };
        int[] snakeEnd   = { 54, 55, 42, 2 };

        // ladders ke start aur end points
        int[] ladderStart = { 6, 11, 46, 60 };
        int[] ladderEnd   = { 25, 40, 90, 85 };

        bool gameOver = false; // game chal rahi hai ya nahi

        // game tab tak chalegi jab tak koi jeete nahi
        while(!gameOver)
        {
            // har player ka turn
            for(int i = 0; i < playerCount; i++)
            {
                Console.WriteLine("\n" + players[i] + "'s turn");
                Console.ReadLine(); // enter press karne ke liye

                int dice = RollDice(); // dice roll
                int oldPos = positions[i];

                // dice ke according move
                int newPos = MovePlayer(oldPos, dice);

                string message;

                // snake ya ladder check
                newPos = ApplySnakeOrLadder(
                            newPos,
                            snakeStart, snakeEnd,
                            ladderStart, ladderEnd,
                            out message);

                positions[i] = newPos; // position update

                Console.WriteLine("Dice : " + dice);
                Console.WriteLine("Position : " + oldPos + " -> " + newPos);

                if(message != "")
                {
                    Console.WriteLine(message); // snake/ladder message
                }

                // win condition check
                if(CheckWin(newPos))
                {
                    Console.WriteLine(players[i] + " WON THE GAME");
                    gameOver = true; // game end
                    break; // loop stop
                }
            }
        }

        Console.WriteLine("Game Over");
    }

    // dice ka random number generate karne ke liye
    static int RollDice()
    {
        Random r = new Random();
        return r.Next(1, 7); // 1 to 6
    }

    // player ko move karne ke liye
    static int MovePlayer(int currentPosition, int diceValue)
    {
        int nextPosition = currentPosition + diceValue;

        // agar 100 se aage chala gaya to wahi rukega
        nextPosition = nextPosition > 100 ? currentPosition : nextPosition;

        return nextPosition;
    }

    // snake ya ladder check karne ke liye
    static int ApplySnakeOrLadder(
        int position,
        int[] snakeStart, int[] snakeEnd,
        int[] ladderStart, int[] ladderEnd,
        out string message)
    {
        message = "";

        // snake check
        for(int i = 0; i < snakeStart.Length; i++)
        {
            if(position == snakeStart[i])
            {
                message = "Snake bite";
                return snakeEnd[i];
            }
        }

        // ladder check
        for(int i = 0; i < ladderStart.Length; i++)
        {
            if(position == ladderStart[i])
            {
                message = "Ladder climb";
                return ladderEnd[i];
            }
        }

        return position; // no snake no ladder
    }

    // jeetne ki condition check
    static bool CheckWin(int position)
    {
        return position == 100;
    }
}
