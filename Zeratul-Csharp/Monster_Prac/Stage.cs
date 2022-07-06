using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonsterBase;
using MonsterBoss;
public class Stage
{
    protected List<Monster> m_MobList = new List<Monster>();
    public void Start()
    {
        m_MobList.Add(new Monster());
        m_MobList.Add(new Monster());
        m_MobList.Add(new Monster_Boss());
    }
    public void DrawMonster()
    {
        for(int i = 0; i< m_MobList.Count; i++)
        {
            Monster tmp = m_MobList[i];
            tmp.Info();
        }
    }
    public bool CheckClear()
    {
        for(int i = 0; i< m_MobList.Count; i++)
        {
            Monster tmp = m_MobList[i];
            if (tmp.IsLive())
                return false;
        }
        return true;
    }
}
