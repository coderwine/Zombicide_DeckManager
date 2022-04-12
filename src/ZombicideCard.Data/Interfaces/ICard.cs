using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// namespace ZombicideCard.Data.Interfaces
// {
    public interface ICard
    {
        int CardID { get; set; }
        string BlueAttack { get; set; }
        int BlueAttackCount { get; set;}
        string YellowAttack { get; set; }
        int YellowAttackCount { get; set;}
        string OrangeAttack { get; set; }
        int OrangeAttackCount { get; set;}
        string RedAttack { get; set; }
        int RedAttackCount { get; set;}
        string TypeOfEnemy { get; set; }
        string Box { get; }

    }
// }