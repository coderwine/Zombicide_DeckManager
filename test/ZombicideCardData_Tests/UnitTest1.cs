using Xunit;

namespace ZombicideCardData_Tests;

public class UnitTest1
{

    //! Data Tests
    [Fact]
    public void BlackPlague_Test()
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

    [Fact]
    public void AbominationPack_Test()
    {
        AbominationPack deck = new AbominationPack(
            87, EnemieActivation.Nothing, 0, EnemieActivation.Ablobination, 1, EnemieActivation.Ablobination, 1, EnemieActivation.Ablobination, 1,
            CardType.Abomination
        );

        BoxSet boxExpected = BoxSet.Abomination_Pack;
        BoxSet boxActual = deck.Box;
        EnemieActivation checkYellow = EnemieActivation.Ablobination;
        EnemieActivation actualYellow = deck.YellowAttack;

        Assert.Equal(boxExpected, boxActual);
        Assert.Equal(checkYellow, actualYellow);
    }

    [Fact]
    public void DeadEyeWalkers_Test()
    {
        DeadEyeWalkers deck = new DeadEyeWalkers(
            99, EnemieActivation.Dead_Eye_Walkers, 1, EnemieActivation.Dead_Eye_Walkers, 2, EnemieActivation.Dead_Eye_Walkers, 3, EnemieActivation.Dead_Eye_Walkers, 4, CardType.Dead_Eye_Walkers
        );

        BoxSet boxExpected = BoxSet.Dead_Eye_Walkers;
        BoxSet boxActual = deck.Box;
        EnemieActivation checkRed = EnemieActivation.Dead_Eye_Walkers;
        EnemieActivation actualRed = deck.RedAttack;

        Assert.Equal(boxExpected, boxActual);
        Assert.Equal(checkRed, actualRed);
    }

    [Fact]
    public void FriendsAndFoes_Test()
    {
        FriendsAndFoes deck = new FriendsAndFoes(
            253, EnemieActivation.Tainted_Abomination, 1, EnemieActivation.Tainted_Walker, 2, EnemieActivation.Tainted_Walker, 6, EnemieActivation.Tainted_Walker, 2, CardType.Abomination
        );

        int checkRedCt = 2;
        int actualRedCt = deck.RedAttackCount;

        Assert.Equal(checkRedCt, actualRedCt);
    }

    [Fact]
    public void GreenHorde_Test()
    {
        GreenHorde deck = new GreenHorde(
            167, EnemieActivation.Nothing, 0, EnemieActivation.Orc_Runner, 5, EnemieActivation.Orc_Walker, 6, EnemieActivation.Orc_Fatty, 3, CardType.Orc_Horde
        );

        int expectedID = 167;
        int actualID = deck.CardID;

        Assert.Equal(expectedID, actualID);
    }

    [Fact]
    public void Guestbox_Test()
    {
        Guestbox deck = new Guestbox(
            125, EnemieActivation.ToMeKuPa, 1, EnemieActivation.ToMeKuPa, 1, EnemieActivation.ToMeKuPa, 1, EnemieActivation.ToMeKuPa, 1, CardType.Necromancer, "Crtichlow"
        );

        string expectedGuest = "Crtichlow";
        string actualGuest = deck.GuestName;

        Assert.Equal(expectedGuest, actualGuest);
    }

    //TODO Paused here
    [Fact]
    public void KSExclusive_Test()
    {

    }

    [Fact]
    public void MurderOfCrows_Test()
    {

    }

    [Fact]
    public void NoRestForTheWicked_Test()
    {

    }

    [Fact]
    public void NPC_Test()
    {

    }

    [Fact]
    public void Promotional_Test()
    {

    }

    [Fact]
    public void RatKingSwampTroll_Tests()
    {

    }

    [Fact]
    public void Wulfsbug_Tests()
    {

    }

    //! REPO TESTS

}