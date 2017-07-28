﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace snqxap
{
    class Fairy
    {
        public string name;
        public double pow;
        public double hit;
        public double dodge;
        public double armor;
        public double critharm;
        public double grow;
        public int type;
        public string source;

        public int level;
        public int skilllevel;
        public int star;

        public double powbuff;
        public double hitbuff;
        public double dodgebuff;
        public double armorbuff;
        public double critharmbuff;

        enum ratio1 { pow = 7, hit = 25, dodge = 20, armor = 5, critharm = 10 };
       

        public void calcfairybuff()
        {
            if (this.star == 0||this.level==0)
                return;
            double[] ratio2 = { 0.076, 0.252, 0.202, 0.05, 0.101 };
             double[] starratio = { 0.4, 0.5, 0.6,  0.8,  1 };
             this.powbuff = Convert.ToInt16(Math.Ceiling(this.pow * (double)ratio1.pow / 100) + Math.Ceiling(this.pow * (double)ratio2[0] * (this.level - 1) * this.grow / 10000) * starratio[this.star - 1]);
             this.hitbuff = Convert.ToInt16(Math.Ceiling(this.hit * (double)ratio1.hit / 100) + Math.Ceiling(this.hit * (double)ratio2[1] * (this.level - 1) * this.grow / 10000) * starratio[this.star - 1]);
             this.dodgebuff = Convert.ToInt16(Math.Ceiling(this.dodge * (double)ratio1.dodge / 100) + Math.Ceiling(this.dodge * (double)ratio2[2] * (this.level - 1) * this.grow / 10000) * starratio[this.star - 1]);
             this.armorbuff = Convert.ToInt16(Math.Ceiling(this.armor * (double)ratio1.armor / 100) + Math.Ceiling(this.armor * (double)ratio2[3] * (this.level - 1) * this.grow / 10000) * starratio[this.star - 1]);
             this.critharmbuff = Convert.ToInt16(Math.Ceiling(this.critharm * (double)ratio1.critharm / 100) + Math.Ceiling(this.critharm * (double)ratio2[4] * (this.level - 1) * this.grow / 10000) * starratio[this.star - 1]);
        }
    }

    class FairyTalent
    {
        public string name;
        /// <summary>
        /// 1:4 6 8 9 10 2:2 4 6 8 10 3:3 5 7 9 10
        /// </summary>
        public int rateswitch;
    }
}
