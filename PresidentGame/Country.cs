using System;
using System.Collections.Generic;

namespace PresidentGame
{
    public class Country
    {
        public string name;
        float taxPercentage = 0;

        int healthCareMoney;
        int defenceMoney;

        List<string> defence = new List<string>();

        public void DefenceInvest()
        {
            //Om man betalar så kan man lägga till vapen i defenceList

        }

    }
}
