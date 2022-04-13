using Xunit;

namespace ZombicideCardData_Tests;

public class UnitTest1
{

    //! Data Tests
    [Fact] //* 1
    public void BlackPlague_Test()
    {
        BlackPlague deck = new BlackPlague(
            1, EnemyActivation.Nothing, 1, EnemyActivation.Runner, 2, EnemyActivation.Walker, 5, EnemyActivation.Fatty, 2, CardType.Standard_Zombies
        );

        BoxSet checkBoxExpected = BoxSet.Black_Plague;
        BoxSet checkBoxActual = deck.Box;
        EnemyActivation checkRedExpected = EnemyActivation.Fatty;
        EnemyActivation checkRedActual = deck.RedAttack;

        Assert.Equal(checkBoxExpected, checkBoxActual);
        Assert.Equal(checkRedExpected, checkRedActual);
    }

    [Fact] //* 2
    public void AbominationPack_Test()
    {
        AbominationPack deck = new AbominationPack(
            87, EnemyActivation.Nothing, 0, EnemyActivation.Ablobination, 1, EnemyActivation.Ablobination, 1, EnemyActivation.Ablobination, 1,
            CardType.Abomination
        );

        BoxSet boxExpected = BoxSet.Abomination_Pack;
        BoxSet boxActual = deck.Box;
        EnemyActivation checkYellow = EnemyActivation.Ablobination;
        EnemyActivation actualYellow = deck.YellowAttack;

        Assert.Equal(boxExpected, boxActual);
        Assert.Equal(checkYellow, actualYellow);
    }

    [Fact] //* 3
    public void DeadEyeWalkers_Test()
    {
        DeadEyeWalkers deck = new DeadEyeWalkers(
            99, EnemyActivation.Dead_Eye_Walkers, 1, EnemyActivation.Dead_Eye_Walkers, 2, EnemyActivation.Dead_Eye_Walkers, 3, EnemyActivation.Dead_Eye_Walkers, 4, CardType.Dead_Eye_Walkers
        );

        BoxSet boxExpected = BoxSet.Dead_Eye_Walkers;
        BoxSet boxActual = deck.Box;
        EnemyActivation checkRed = EnemyActivation.Dead_Eye_Walkers;
        EnemyActivation actualRed = deck.RedAttack;

        Assert.Equal(boxExpected, boxActual);
        Assert.Equal(checkRed, actualRed);
    }

    [Fact] //* 4
    public void FriendsAndFoes_Test()
    {
        FriendsAndFoes deck = new FriendsAndFoes(
            253, EnemyActivation.Tainted_Abomination, 1, EnemyActivation.Tainted_Walker, 2, EnemyActivation.Tainted_Walker, 6, EnemyActivation.Tainted_Walker, 2, CardType.Abomination
        );

        int checkRedCt = 2;
        int actualRedCt = deck.RedAttackCount;

        Assert.Equal(checkRedCt, actualRedCt);
    }

    [Fact] //* 5
    public void GreenHorde_Test()
    {
        GreenHorde deck = new GreenHorde(
            167, EnemyActivation.Nothing, 0, EnemyActivation.Orc_Runner, 5, EnemyActivation.Orc_Walker, 6, EnemyActivation.Orc_Fatty, 3, CardType.Orc_Horde
        );

        int expectedID = 167;
        int actualID = deck.CardID;

        Assert.Equal(expectedID, actualID);
    }

    [Fact] //* 6
    public void Guestbox_Test()
    {
        Guestbox deck = new Guestbox(
            125, EnemyActivation.ToMeKuPa, 1, EnemyActivation.ToMeKuPa, 1, EnemyActivation.ToMeKuPa, 1, EnemyActivation.ToMeKuPa, 1, CardType.Necromancer, "Crtichlow"
        );

        string expectedGuest = "Crtichlow";
        string actualGuest = deck.GuestName;

        Assert.Equal(expectedGuest, actualGuest);
    }

    [Fact] //* 7
    public void KSExclusive_Test()
    {
        KSExclusive deck = new KSExclusive(
            117, EnemyActivation.Nothing, 1, EnemyActivation.Abominalpha, 1, EnemyActivation.Abominalpha, 1, EnemyActivation.Abominalpha, 1, CardType.Abominalpha
        );

        EnemyActivation expected = EnemyActivation.Nothing;
        EnemyActivation actual = deck.BlueAttack;

        Assert.Equal(expected, actual);
    }

    [Fact] //* 8
    public void MurderOfCrows_Test()
    {

    }

    // [Fact] //* 9
    // public void NoRestForTheWicked_Test()
    // {

    // }

    // [Fact] //* 10
    // public void NPC_Test()
    // {

    // }

    // [Fact] //* 11
    // public void Promotional_Test()
    // {

    // }

    // [Fact] //* 12
    // public void RatKingSwampTroll_Tests()
    // {

    // }

    // [Fact] //* 13
    // public void Wulfsbug_Tests()
    // {

    // }

    //! REPO TESTS

}