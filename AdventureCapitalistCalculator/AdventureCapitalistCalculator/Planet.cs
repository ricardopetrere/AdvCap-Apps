using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdventureCapitalistCalculator
{
    class Planet
    {
        //levels
        long numAngels;
        int upgradeIndexUpTo;
        List<int> upgradeIndexBonus;
        int angelUpgradeIndexUpTo;
        List<int> angelUpgradeIndexBonus;
        List<int> managersBought;
        bool noSingles;
        bool noTens;
        int triples;
        int flux;
        int bonusAngelEffectiveness;
        int bonusMultiplier;
        List<int> megaTicket;
    }

    /*
    Planeta Terra em JSON:
    
    "earth": {
  "levels": {
    "Lemon": 1550,
    "Newspaper": 850,
    "Carwash": 800,
    "Pizza": 900,
    "Donut": 900,
    "Shrimp": 800,
    "Hockey": 900,
    "Movies": 1000,
    "Bank": 1100,
    "Oil": 1200
  },
  "numAngels": 707868000000000000,
  "upgradeIndexUpTo": 70,
  "upgradeIndexBonus": [
  ],
  "angelUpgradeIndexUpTo": 22,
  "angelUpgradeIndexBonus": [
  ],
  "managersBought": [
    2,
    4,
    6,
    8,
    10,
    12,
    14,
    16,
    18
  ], 
  "noSingles": true,
  "noTens": false,
  "triples": 0,
  "flux": 0,
  "bonusAngelEffectiveness": 2,
  "bonusMultiplier": 0,
  "megaTicket": [
  ]
}
     */
}
