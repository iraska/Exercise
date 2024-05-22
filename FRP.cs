// Code challenge - write code to implement the game rules

/*
- You must use either the do-while statement or the while statement as an outer game loop.
- The hero and the monster will start with 10 health points.
- All attacks will be a value between 1 and 10.
- The hero will attack first.
- Print the amount of health the monster lost and their remaining health.
- If the monster's health is greater than 0, it can attack the hero.
- Print the amount of health the hero lost and their remaining health.
- Continue this sequence of attacking until either the monster's health or hero's health is zero or less.
- Print the winner.
*/

int heroHP = 10, monsterHP = 10;

Random dice = new Random();

do
{
    int roll = dice.Next(1, 11);
    monsterHP -= roll;
    Console.WriteLine($"Monster was damaged and lost {roll} health and now has {monsterHP} health.");

    if (monsterHP <= 0) continue;

    roll = dice.Next(1, 11);
    heroHP -= roll;
    Console.WriteLine($"Hero was damaged and lost {roll} health and now has {heroHP} health.");

} while (heroHP > 0 && monsterHP > 0);

Console.WriteLine(heroHP > monsterHP ? "Hero wins!" : "Monster wins!");
