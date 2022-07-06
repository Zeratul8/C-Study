using System;
using System.Collections.Generic;
//문자열에서 검색하는 기능들, 링크, where등
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
//입출력 시스템
using System.IO;
//
using System.Runtime.Serialization.Formatters.Binary;
//데이터 관리(DataSet)
using System.Data;




class Program
{
    //0314e 데이터관리
    const string TableName = "클래스";
    static DataSet CreateDataSet()
    {
        DataSet ds = new DataSet();
        ds.Tables.Add(TableName);
        ds.Tables[TableName].Columns.Add("이름");
        ds.Tables[TableName].Columns.Add("속성");
        ds.Tables[TableName].Columns.Add("공격력");
        string[] str = new string[3];
        str[0] = "나이트";
        str[1] = "근거리";
        str[2] = "150";
        ds.Tables[TableName].Rows.Add(str);
        str[0] = "레인저";
        str[1] = "원거리";
        str[2] = "200";
        ds.Tables[TableName].Rows.Add(str);
        str[0] = "소서러";
        str[1] = "원거리";
        str[2] = "300";
        ds.Tables[TableName].Rows.Add(str);
        return ds;

    }
    static void Main()
    {
        //0314e 데이터관리
        DataSet ds = CreateDataSet();
        DataTable dt = ds.Tables[TableName];
        DataRow[] dr = dt.Select();
        for(int i =0; i<ds.Tables[TableName].Columns.Count; i++)
            Console.WriteLine(ds.Tables[TableName].Columns[i].ToString() + "\t");
        Console.WriteLine();
        //foreach(DataRow dr in dt.Rows)
        for(int i =0; i<dt.Rows.Count; i++)
        {
            for(int j =0; j<dt.Columns.Count; j++)
            {
                Console.WriteLine(dr[i][j]+"\t");
            }
        }
        Console.ReadKey();
    }

}
