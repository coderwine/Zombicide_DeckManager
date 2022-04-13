using Xunit;

namespace ZombicideCardData_Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        BlackPlague deck = new BlackPlague(
            1, EnemieActivation.Nothing, 1, EnemieActivation.Runner, 2, EnemieActivation.Walker, 5, EnemieActivation.Fatty, 2, CardType.Standard_Zombies
        );

        BoxSet checkBoxExpected = BoxSet.Black_Plague;
        BoxSet checkBoxActual = deck.Box;
        EnemieActivation checkRedExpected = EnemieActivation.Fatty;
        EnemieActivation checkRedActual = deck.RedAttack;

        Assert.Equal(checkBoxExpected, checkBoxActual);
        Assert.Equal(checkRedExpected, checkRedActual);
    }
}