using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonsterBase;

namespace MonsterBoss
{
    class Monster_Boss : Monster
    {
        protected override void Start()
        {
            base.Start();
            Console.WriteLine("보스몬스터 초기화!");
        }
        public override void InitStat()
        {
            m_Hp = 100;
            m_Atk = 50;
        }
    }
}
