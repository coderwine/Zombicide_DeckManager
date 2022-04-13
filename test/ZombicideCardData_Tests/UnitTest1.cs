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
        MurderOfCrows deck = new MurderOfCrows(
            105, EnemyActivation.Murder_of_Crows, 2, EnemyActivation.Murder_of_Crows, 3, EnemyActivation.Murder_of_Crows, 4, EnemyActivation.Murder_of_Crows, 5, CardType.Murder_of_Crows
        );

        EnemyActivation expected = EnemyActivation.Murder_of_Crows;
        EnemyActivation actual = deck.BlueAttack;
        Assert.Equal(expected, actual);
    }

    [Fact] //* 9
    public void NoRestForTheWicked_Test()
    {
        NoRestForTheWicked deck = new NoRestForTheWicked(
            221, EnemyActivation.Nothing, 0, EnemyActivation.Necromantic_Dragon, 1,
            EnemyActivation.Necromantic_Dragon, 1,
            EnemyActivation.Necromantic_Dragon, 1,
            CardType.Dragon
        );

        EnemyActivation expected = EnemyActivation.Necromantic_Dragon;
        EnemyActivation actual = deck.YellowAttack;

        Assert.Equal(expected, actual);
    }

    [Fact] //* 10
    public void NPC_Test()
    {
        NPC deck = new NPC(
            63, EnemyActivation.Nothing, 0, EnemyActivation.NPC, 4, EnemyActivation.NPC, 4, EnemyActivation.NPC, 5, CardType.NPC, 1
        );

        int expected = 1;
        int actual = deck.NPCBoxNumber;

        Assert.Equal(expected, actual);
    }

    [Fact] //* 11
    public void Promotional_Test()
    {
        Promotional deck = new Promotional(
            161, EnemyActivation.Erik_Summoner, 1,EnemyActivation.Erik_Summoner, 1,EnemyActivation.Erik_Summoner, 1, 
            EnemyActivation.Erik_Summoner, 1,CardType.Necromancer
        );

        EnemyActivation expected = EnemyActivation.Erik_Summoner;
        EnemyActivation actual = deck.BlueAttack;

        Assert.Equal(expected, actual);
    }

    [Fact] //* 12
    public void RatKingSwampTroll_Tests()
    {
        RatKingSwampTroll deck = new RatKingSwampTroll(
            351, EnemyActivation.Rat_King, 1,EnemyActivation.Rat_King, 2,EnemyActivation.Rat_King, 4,EnemyActivation.Rat_King, 6,
            CardType.Necromancer
        );

        CardType expected = CardType.Necromancer;
        CardType actual = deck.TypeOfEnemy;

        Assert.Equal(expected, actual);
    }

    [Fact] //* 13
    public void Wulfsbug_Tests()
    {
        Wulfsburg deck = new Wulfsburg(
            55, EnemyActivation.Wolvz, 1,
            EnemyActivation.Wolvz, 2,EnemyActivation.Wolvz, 3,EnemyActivation.Wolvz, 4,CardType.Zombie_Wolfz
        );

        int expected = 55;
        int actual = deck.CardID;

        Assert.Equal(expected, actual);
    }

    //! REPO TESTS

}