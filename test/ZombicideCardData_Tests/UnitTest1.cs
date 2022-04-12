using Xunit;

namespace ZombicideCardData_Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        BlackPlagueEnemyDeck deck = new BlackPlagueEnemyDeck(
            1, "Nothing", 1, "Runner", 2, "Walker", 5, "Fatty", 2, "Standard Zombies"
        );

        string checkBoxExpected = "Black Plague";
        string checkBoxActual = deck.Box;
        string checkRedExpected = "Fatty";
        string checkRedActual = deck.RedAttack;

        Assert.Equal(checkBoxExpected, checkBoxActual);
        Assert.Equal(checkRedExpected, checkRedActual);
    }
}