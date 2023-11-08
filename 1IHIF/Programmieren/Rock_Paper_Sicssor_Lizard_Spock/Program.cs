const int Rock = 1;
const int Paper = 2;
const int Scissors = 3;
const int Lizard = 4;
const int Spock = 5;

const int Draw = 0;
const int Player1Win = 1;
const int Player2Win = 2;

Console.Write("Player 1, choose 1 Rock, 2 Paper, 3 Scissors, 4 Lizard, 5 Spock: ");
int player1 = int.Parse(Console.ReadLine()!);
Console.Clear();
Console.Write("Player 2, choose 1 Rock, 2 Paper, 3 Scissors, 4 Lizard, 5 Spock: ");
int player2 = int.Parse(Console.ReadLine()!);
int winner = Draw;

switch (player1)
{
    case Rock:
        switch (player2)
        {
            case Scissors:
            case Lizard:
                winner = Player1Win;
                break;
            case Paper:
            case Spock:
                winner = Player2Win;
                break;
            default:
                winner = Draw;
                break;
        }
        break;

    case Paper:
        switch (player2)
        {
            case Rock:
            case Spock:
                winner = Player1Win;
                break;
            case Scissors:
            case Lizard:
                winner = Player2Win;
                break;
            default:
                winner = Draw;
                break;
        }
        break;

    case Scissors:
        switch (player2)
        {
            case Paper:
            case Lizard:
                winner = Player1Win;
                break;
            case Rock:
            case Spock:
                winner = Player2Win;
                break;
            default:
                winner = Draw;
                break;
        }
        break;

    case Lizard:
        switch (player2)
        {
            case Spock:
            case Paper:
                winner = Player1Win;
                break;
            case Rock:
            case Scissors:
                winner = Player2Win;
                break;
            default:
                winner = Draw;
                break;
        }
        break;

    case Spock:
        switch (player2)
        {
            case Scissors:
            case Rock:
                winner = Player1Win;
                break;
            case Paper:
            case Lizard:
                winner = Player2Win;
                break;
            default:
                winner = Draw;
                break;
        }
        break;
    default:
        winner = Draw;
        break;
}

Console.WriteLine("The winner is Player " + winner);
