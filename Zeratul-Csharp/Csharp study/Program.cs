using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_study
{
    //2월 18일 구조체와 클래스의 차이
    struct Monster
    {
        public int hp;
    }
    class Hero
    {
        public int hp;
    }


    //0302a 대리자 선언 및 활용
    delegate int TestDelegate(int a, int b);
    class Calculator
    {
        public int Plus(int a, int b) { return a + b; }
        public int Minus(int a, int b) { return a - b; }
        public int Multiply(int a, int b) { return a * b; }
    }


    //0302b 대리자+일반화 선언 및 활용
    delegate T TestDelegate<T>(T a, T b);
    class Calculator
    {
        public int Plus(int a, int b) { return a + b; }
        public float Plus(float a, float b) { return a + b; }
        public int Minus(int a, int b) { return a - b; }
        public float Minus(float a, float b) { return a - b; }
        public int Multiply(int a, int b) { return a * b; }
        public float Multiply(float a, float b) { return a * b; }

    }



    //0304b SortedList 활용
    class SortedListGenericClass
    {
        public void TestStortedListGeneric()
        {
            SortedList<int, string> colorSort = new SortedList<int, string>();
            colorSort.Add(1, "Red");
            colorSort.Add(3, "Green");
            colorSort.Add(2, "Blue");
            foreach (KeyValuePair<int, string> color in colorSort)
                Console.WriteLine("Key {0} Color {1}", color.Key, color.Value);
            Console.WriteLine("현재 리스트 크기: {0}", colorSort.Capacity);
            colorSort.TrimExcess();
            Console.WriteLine("현재 리스트 크기: {0}, 요소의 갯수 : {1}", colorSort.Capacity, colorSort.Count);
            colorSort.Remove(2);
            colorSort.TrimExcess();
            Console.WriteLine("현재 리스트 크기: {0}, 요소의 갯수 : {1}", colorSort.Capacity, colorSort.Count);
        }

    }


    //0304d 이중연결 리스트 활용2
    class LinkedListGenericClass
    {
        public LinkedListGenericClass() { }
        public void TestLinkedListGeneric()
        {
            LinkedList<int> linkedList = new LinkedList<int>();
            linkedList.AddFirst(1);
            LinkedListNode<int> firstNode = linkedList.First;
            LinkedListNode<int> currentNode = linkedList.AddAfter(firstNode, 3);
            currentNode = linkedList.AddBefore(currentNode, 2);
            Console.WriteLine("첫번째 노드의 값 : {0}", currentNode.Previous.Value);
            Console.WriteLine("두번째 노드의 값 : {0}", currentNode.Value);
            Console.WriteLine("세번째 노드의 값 : {0}", currentNode.Next.Value);

        }
    }


    //0304f 제너릭리스트 활용3
    class ListGenericClass
    {
        public ListGenericClass() { }
        public void TestListGeneric()
        {
            List<string> list = new List<string>();
            list.Add("트럼프");
            list.Add("오바마");
            list.Add("힐러리");
            for (int i = 0; i < list.Count; i++)
                Console.WriteLine("{0}, {1} 대통령", i, list[i]);
            Console.WriteLine("컬렉션의 현재 배열 크기 {0}", list.Capacity);
            Console.WriteLine("컬렉션에 저장된 요소 갯수 {0}", list.Count);
            list.Insert(1, "부시");
            Console.WriteLine("리스트 1번째 대통령 {0}", list[1]);
            list.RemoveAt(1);
            Console.WriteLine("리스트 1번째 대통령 {0}", list[1]);
        }
    }

    class Program
    {
        //0223c
        //value값을 reference타입으로 지정하기(out), 값을 받아오는것만 가능
        static void Add(int c, int d, out int sum)
        {
            sum = c + d;
        }
        //reference타입 변수활용(ref), 값을 받아오고 넣기 둘다 가능
        static void Increment(ref int num)
        {
            num++;
        }


        //0223d Swap함수 만들기
        static void Swap(ref int num1, ref int num2)
        {
            int temp = 0;
            temp = num1;
            num1 = num2;
            num2 = temp;
        }

        //0223e 클래스배열 선언
        class Point
        {
            private int x, y;
            public Point(int _x, int _y)
            {
                x = _x;
                y = _y;
            }
            public void Print()
            {
                System.Console.WriteLine("({0}, {1})", x, y);
            }
        }


        //0225a 포켓몬
        class PocketMon
        {
            private string kind;
            private string name;
            public PocketMon(string kind, string name)
            {
                this.kind = kind;
                this.name = name;
            }
            public void PrintPocketMon()
            {
                Console.WriteLine("종류 : {0} / 이름 : {1}", kind, name);
            }

        }


        //0225b 배열 출력
        static void PrintArray(string[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                //삼항 연산자 활용, 맨 마지막 배열 이후에는 공백이 들어가지 않음
                Console.Write(arr[i] + "{0}", i < arr.Length - 1 ? " " : "");
            }
            Console.WriteLine();
        }


        //0225c 일반화 메서드 선언
        static void Print<T>(T value)
        {
            Console.WriteLine(value);
        }


        //0225d 일반화 클래스 선언
        static void Print<T>(T value)
        {
            Console.WriteLine(value);
        }


        //0225e 일반화 함수 활용
        static void Print<T>(T value)
        {
            Console.WriteLine(value);
        }
        static void CopyArray<T>(T[] src, T[] dest)
        {
            src.CopyTo(dest, 0);
        }


        //0225f Delegate(대리자)활용하기
        delegate int TestDelegate(int a, int b);
        public static int Plus(int a, int b) { return a + b; }
        public static int Minus(int a, int b) { return a - b; }



        //0302a 대리자 선언 및 활용
        public static void Calculator(int a, int b, TestDelegate callback)
        {
            Console.WriteLine(callback(a, b));
        }


        //0302b 대리자+일반화 선언 및 활용
        public static void Calculator<T>(T a, T b, TestDelegate<T> callback)
        {
            Console.WriteLine(callback(a, b));
        }


        //0304a Dictionary 활용
        public static void TestDictionary()
        {
            Dictionary<string, string> genDic = new Dictionary<string, string>();
            genDic.Add("txt", "notepad.exe");
            genDic.Add("bmp", "paint.exe");
            genDic.Add("mp3", "wmplayer.exe");
            Console.WriteLine("[Dictonary]");
            foreach (KeyValuePair<string, string> kvp in genDic)
            {
                Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
            }
        }


        //0304c 이중연결List 활용
        public static void TestLinkedList()
        {
            LinkedList<string> genLL = new LinkedList<string>();
            genLL.AddLast("4등");
            genLL.AddFirst("1등");
            genLL.AddAfter(genLL.Find("1등"), "2등");
            genLL.AddBefore(genLL.Find("4등"), "3등");
            Console.WriteLine("[LinkedList]");
            genLL.Remove("1등");
            foreach (string str in genLL)
                Console.WriteLine("VAlue = {0}", str);
        }


        //0304e 제너릭리스트
        public static void TestList()
        {
            List<string> genList = new List<string>();
            genList.Add("한국");
            genList.Add("중국");
            genList.Add("일본");
            genList.Remove("일본");
            Console.WriteLine("[List]");
            foreach (string str in genList)
                Console.WriteLine("Value = {0}", str);
            Console.WriteLine();
        }



        //0307a 상속클래스
        class BaseClass
        {
            //virtual - 가상 메소드, 자식클래스마다 조금씩 다른 기능으로 정의할때 사용, 메소드에만 가능
            public virtual void Method1()
            {
                Console.WriteLine("부모클래스 - Method1");
            }
            //일반적인 메소드
            public void Method2()
            {
                Console.WriteLine("부모클래스 - Method2");
            }
        }
        class DerivedClass : BaseClass
        {
            //override - 부모클래스에 virtual로 선언된 메소드를 수정해서 정의
            public override void Method1()
            {
                Console.WriteLine("자식클래스 - Method1");
            }
            //new - 한정자, 부모클래스에 virtual로 선언된 메소드를 무시하고 새로 정의
            public new void Method2()
            {
                Console.WriteLine("자식클래스- Method2");
            }
        }
        //상속의 메인 개념!!
        public static void TestCars2()
        {
            Console.WriteLine("\nTestCars2");
            Console.WriteLine("-----------");
            //부모클래스객체<Car>를 자식클래스(ConvertibleCar, Minivan)로 선언가능하므로 배열선언가능
            //var : 대입되었을때 자료형 자동결정
            var cars = new List<Car> { new Car(), new ConvertibleCar(), new Minivan() };
            /*foreach(var car in cars)
            {
                car.DescribeCar();
                Console.WriteLine("-----------");
            }*/
            //for문으로 변환
            for (int i = 0; i < 3; i++)
            {
                cars[i].DescribeCar();
                Console.WriteLine("-----------");
            }
        }
        public static void TestCars3()
        {
            Console.WriteLine("\nTestCars3");
            Console.WriteLine("-----------");
            ConvertibleCar car2 = new ConvertibleCar();
            Minivan car3 = new Minivan();
            car2.ShowDetails();
            car3.ShowDetails();
        }

        //0307b 상속클래스
        public static void TestCars1()
        {
            Console.WriteLine("\nTestCars1");
            Console.WriteLine("-----------");

            Car car1 = new Car();
            car1.DescribeCar();
            Console.WriteLine("-----------");

            //부모클래스에 virtual로 정의된 메소드는 new 한정자로 수정 불가능
            ConvertibleCar car2 = new ConvertibleCar();
            car2.DescribeCar();
            Console.WriteLine("-----------");

            //부모클래스에 virtual로 정의된 메소드 override로 수정
            Minivan car3 = new Minivan();
            car3.DescribeCar();
            Console.WriteLine("-----------");
        }


        //0308d 추상(abstract)클래스
        abstract class Abstract
        {
            protected int x = 10;
            public abstract int X { get; set; }
            public virtual void func() { Console.WriteLine("가상 클래스 선언"); }
            public void func2() { Console.WriteLine("일반 메소드 호출"); }
        }
        class General : Abstract
        {
            public override int X
            {
                get { return x + 20; }
                set { x = value; }
            }
            public override void func()
            {
                base.func();
                Console.WriteLine("추상화 클래스 구현");
            }
        }


        //0308e 추상(abstract)클래스
        abstract class Animal
        {
            public abstract void Bark();
            public abstract void Attack();
        }
        class Cat : Animal
        {
            public Cat() { Console.WriteLine("나는 고양이입니다."); }
            public override void Bark() { Console.WriteLine("야옹"); }
            public override void Attack() { Console.WriteLine("할퀴기"); }
        }
        class Dog : Animal
        {
            public Dog() { Console.WriteLine("나는 개입니다."); }
            public override void Bark() { Console.WriteLine("멍멍"); }
            public override void Attack() { Console.WriteLine("물기"); }
        }
        class Bird : Animal
        {
            public Bird() { Console.WriteLine("나는 새입니다."); }
            public override void Bark() { Console.WriteLine("짹짹"); }
            public override void Attack() { Console.WriteLine("쪼기"); }
        }


        //0309a 테란
        enum Unit
        {
            MARINE,
            REAPER,
            BANSHEE
        }


        //0310a 파일입력
        private static void FileRead(string filename)
        {
            //@: 그냥 따옴표 안에 쓰면 \가 특수문자취급되지만 @이후에 쓰면 특수문자없이 취급됨
            string path = @"c:\test\" + filename;
            FileStream file = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader sr = new StreamReader(file);
            string readText = sr.ReadToEnd();
            sr.Close();
            file.Close();
            /*TextReader tr = new StreamReader(path);
            //텍스트를 전부다 읽어오기
            string readText = tr.ReadToEnd();
            tr.Close();*/
            Console.WriteLine(readText);
        }


        //0310b 파일 생성하기
        public static byte[] WriteStringBytes(string str, FileStream fs)
        {
            //유니코드 문자열(string)을 byte배열로 받아오기
            byte[] bytestr = new UTF8Encoding(true).GetBytes(str);
            //바이트배열을 처음부터(0), (바이트로 읽어온 문자열 길이)까지 적어넣는다
            fs.Write(bytestr, 0, bytestr.Length);
            return bytestr;
        }
        private static void Fileread(string filename)
        {
            string path = @"c:\test\" + filename + ".txt";
            string outstr = "안녕하세요 SBS 게임 아카데미 입니다.";
            byte[] readbyte = new byte[1024];
            FileStream file = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            WriteStringBytes(outstr, file);
            file.Seek(0, SeekOrigin.Begin);
            UTF8Encoding utf8 = new UTF8Encoding(true);
            file.Read(readbyte, 0, readbyte.Length);
            //byte배열을 다시 유니코드 문자열(string)으로 출력하기
            Console.WriteLine(utf8.GetString(readbyte));
            file.Close();
        }


        //0310c 바이너리 파일
        private static void FileCreate(string filename)
        {
            string path = @"c:\test\" + filename;
            FileStream file = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            BinaryWriter bw = new BinaryWriter(file);
            bw.Write(int.MaxValue);
            bw.Write(double.MaxValue);
            bw.Write("안녕하세요 SBS 게임 아카데미 입니다.");
            file.Seek(0, SeekOrigin.Begin);
            BinaryReader br = new BinaryReader(file);
            Console.WriteLine("File size : {0} bytes", br.BaseStream.Length);
            Console.WriteLine(br.ReadInt32());
            Console.WriteLine(br.ReadInt64());
            Console.WriteLine(br.ReadString());
            file.Close();
        }


        //0310d 직렬화 파일 생성
        //Serailizable : 직렬화, 직렬화가 가능한 클래스 선언시 사용
        [Serializable]
        class student
        {
            public int num { get; set; }
            public string name { get; set; }
        }
        private static void FileCreate(string filename)
        {
            string path = @"c:\test\" + filename;
            student me = new student() { num = 1, name = "민수" };
            FileStream file = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);
            //바이너리 직렬화
            BinaryFormatter bf = new BinaryFormatter();
            //직렬화
            bf.Serialize(file, me);
            file.Close();
            file = new FileStream(path, FileMode.Open, FileAccess.Read);
            //역직렬화
            var result = (student)bf.Deserialize(file);
            file.Close();
            Console.WriteLine("번호 {0}, 이름 : {1}", result.num, result.name);
        }


        //0310e 직렬화 파일 생성(배열)
        //Serailizable : 직렬화, 직렬화가 가능한 클래스 선언시 사용
        [Serializable]
        class student
        {
            public int num { get; set; }
            public string name { get; set; }
        }
        private static void FileCreate(string filename)
        {
            string path = @"c:\test\" + filename;
            List<student> stdList = new List<student>()
        {
            new student() {num = 1, name = "민수"},
            new student() {num = 2, name = "수지"},
            new student() {num = 3, name = "설현"}
        };
            FileStream file = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);
            //바이너리 직렬화
            BinaryFormatter bf = new BinaryFormatter();
            //직렬화
            bf.Serialize(file, stdList);
            file.Close();
            file = new FileStream(path, FileMode.Open, FileAccess.Read);
            //역직렬화
            var result = (List<student>)bf.Deserialize(file);
            file.Close();
            for (int i = 0; i < result.Count; i++)
                Console.WriteLine("번호 {0}, 이름 : {1}", result[i].num, result[i].name);
        }


        //0310f 파일정보 확인하기
        private static void FileInfo()
        {
            FileInfo file = new FileInfo(@"c:\test\test.txt");
            if (file.Exists)
            {
                //파일정보
                Console.WriteLine(file.Name);//파일명
                Console.WriteLine(file.FullName);//파일경로
                Console.WriteLine(file.Extension);//파일확장자
                Console.WriteLine(file.Length);//바이트
                Console.WriteLine(file.CreationTime);//파일생성시간
                Console.WriteLine(file.LastAccessTime);//파일 마지막 실행시간
                Console.WriteLine(file.DirectoryName);//파일이 포함된 경로
                Console.WriteLine(file.Attributes);//
            }
            else
            {
                Console.WriteLine("해당 파일이 존재하지 않습니다.");
            }
        }


        //0310g 파일 삭제하기
        private static void FileDelete(string filename)
        {
            string path = @"c:\test\" + filename;
            FileInfo file = new FileInfo(path);
            if (file.Exists)
            {
                file.Delete();
                Console.WriteLine("삭제완료");
            }
            else
            {
                Console.WriteLine("파일이 존재하지 않습니다.");
            }
        }

        //0310h 파일 저장
        private static void FileSave(string filename, string text)
        {
            string path = string.Format(@"c:\test\{0}", filename);
            FileInfo file = new FileInfo(path);
            if (file.Exists)
            {
                Console.WriteLine("같은 파일이 존재합니다. 덮어씌웁니까? (y, n)");
                string result = Console.ReadLine();
                if (result == "yes")
                {
                    StreamWriter writer = file.CreateText();
                    writer.WriteLine(text);
                    writer.Close();
                }
                else
                {
                    int count = 0;
                    FileInfo tmpFile = null;
                    //파일명 중복검사 후 count를 늘려가며 파일명 바꾸기
                    do
                    {
                        path = string.Format(@"c:\test\" + filename + "_사본{0}", count);
                        tmpFile = new FileInfo(path);
                        count++;
                    } while (tmpFile.Exists);
                    //파일 생성
                    StreamWriter writer = tmpFile.CreateText();
                    writer.WriteLine(text);
                    writer.Close();
                    Console.WriteLine("복사본{0} 생성완료", count - 1);
                }


            }
            else
            {
                StreamWriter writer = file.CreateText();
                writer.WriteLine(text);
                writer.Close();
                Console.WriteLine("생성완료");
            }
        }


        //0310i 폴더 생성,삭제
        private static void CreateDirectory()
        {
            string path = @"c:\test\Testdirectory";
            try
            {
                DirectoryInfo dinfo = new DirectoryInfo(path);
                dinfo.Create();
                Console.WriteLine("폴더 생성 완료");
                //true면 삭제, false면 삭제안함
                //dinfo.Delete(true);
                //Console.WriteLine("폴더 삭제 완료");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }


        //0311a 폴더확인 후 파일 읽어오기
        private static void GetFiles()
        {
            string path = @"c:\test\Testdirectory";
            try
            {
                DirectoryInfo dinfo = new DirectoryInfo(path);
                //디렉토리 유무확인
                if (dinfo.Exists)
                {
                    //디렉토리에 있는 파일정보 받아오기
                    FileInfo[] files = dinfo.GetFiles("*.txt", SearchOption.TopDirectoryOnly);
                    for (int i = 0; i < files.Length; i++)
                    {
                        Console.WriteLine(files[i].ToString());
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }


        //0311b 폴더확인 후 내부 폴더 경로 확인
        private static void GetFiles()
        {
            string path = @"c:\test\Testdirectory";
            try
            {
                DirectoryInfo dinfo = new DirectoryInfo(path);
                //디렉토리 유무확인
                if (dinfo.Exists)
                {
                    //디렉토리내부의 디렉토리 경로 확인
                    DirectoryInfo[] subdinfo = dinfo.GetDirectories();
                    for (int i = 0; i < subdinfo.Length; i++)
                    {
                        Console.WriteLine(subdinfo[i].FullName);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }


        //0311d 무명메소드
        delegate int MyDelegate(int a, int b);


        //0311e 무명람다식
        delegate int MyDelegate(int a, int b);
        delegate void MyDelegate2(int a, int b);
        delegate void PrintDelegate();


        //0311f 람다+디렉토리 혼합
        static void GetFiles()
        {
            string path = @"c:\test\Testdirectory";
            try
            {
                DirectoryInfo dinfo = new DirectoryInfo(path);
                if (dinfo.Exists)
                {
                    FileInfo[] files = dinfo.GetFiles("*.*", SearchOption.TopDirectoryOnly);
                    string[] filestr = new string[files.Length];
                    for (int i = 0; i < files.Length; i++)
                        filestr[i] = files[i].ToString();
                    string[] exts = new[] { ".bmp", ".txt", ".gif" };
                    string[] result = filestr.Where((s) => exts.Contains(Path.GetExtension(s), StringComparer.OrdinalIgnoreCase);).ToArray();
                    for (int i = 0; i < result.Length; i++)
                        Console.WriteLine(result[i]);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }


        //0311f Func 대리자 : 반환값이 있는경우에 쉽게 대리자 선언가능
        public static string UpperCaseString(string inputString)
        {
            return inputString.ToUpper();
        }
        public static string DrawMessage()
        {
            return "안녕하세용";
        }


        //0311h Action 대리자 : 반환값이 없는경우에 쉽게 대리자 선언가능
        public static void UpperCaseString(string inputString)
        {
            Console.WriteLine(inputString.ToUpper());
        }
        public static void Sum(int a, int b)
        {
            Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
        }


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


        //#region ~ #endregion 활용해서 영역 구분하기
        #region Constants and Fields
        //무조건 private
        private int hp;
        private char[] name;
        #endregion
        #region Public Properties
        #endregion
        #region Public Methods and Operators
        #endregion
        #region Methods
        void Calculation()
        {

        }
        #endregion
        #region Call by Unity
        //unity기능들
        #endregion



        static void Main(string[] args)
        {
            //2월 18일
            Console.WriteLine("int형의 크기 :" + sizeof(int) + " 최소 값 : " + int.MinValue + " 최대 값 : " + int.MaxValue);
            Console.WriteLine("long형의 크기 :" + sizeof(long) + " 최소 값 : " + long.MinValue + " 최대 값 : " + long.MaxValue);
            //Console.ReadKey();

            /*구조체(값형식)변수선언*/
            Monster mon;
            /*클래스(참조형식), 힙메모리 선언, C언어 포인터에 해당*/
            Hero hero = new Hero();  /*   new "classname"(); : 생성자    */
            mon.hp = 100;
            hero.hp = 1000;



            //2월 21일
            char ch = 'B';
            Console.WriteLine("char형의 크기 : " + sizeof(char));
            Console.WriteLine("char 변수 ch의 값 : " + ch);
            Console.ReadKey();

            int num1 = 10;
            int num2 = 20;
            Console.WriteLine("{0} * {1} = {2}", num1, num2, num1 * num2);


            string str = "hello";
            char[] chArr = new char[] { 'w', 'o', 'r', 'l', 'd' };
            string str2 = new string(chArr);
            string str3 = new string(chArr, 2, 3);
            string str4 = new string('w', 4);
            Console.WriteLine(str);
            Console.WriteLine(str2);
            Console.WriteLine(str3);
            Console.WriteLine(str4);
            Console.WriteLine(str + str2);


            char[] chArr = new char[] { 'h', 'e', 'l', 'l', 'o' };
            string str1 = new string(chArr);
            string str2 = "hello";
            string str3 = "world";
            Console.WriteLine(str1 == str2);
            //주소끼리의 비교(ReferenceEquals(a,b))
            Console.WriteLine(string.ReferenceEquals(str1, str2));
            Console.WriteLine(str1.CompareTo(str3));


            //1~1000번까지 아이템명 파일 만들기
            for (int i = 0; i < 1000; i++)
            {
                string str1 = string.Format("item_{0:0000}.dat", i);
                Console.WriteLine(str1);
            }


            //string 기능들 활용하기
            string str = "     world";
            string str2 = "HELLO";
            //부분 문자열삽입
            Console.WriteLine(str.Insert(1, "Hello"));
            //문자열 길이가 최소 10이 될수 있게 앞쪽에 공백추가
            Console.WriteLine(str.PadLeft(10));
            //문자열 길이가 최소 10이 될수 있게 앞쪽에 '*'추가
            Console.WriteLine(str.PadLeft(10, '*'));
            //문자열 길이가 최소 10이 될수 있게 뒤쪽에 공백추가
            Console.WriteLine(str.PadRight(10));
            //문자열 길이가 최소 10이 될수 있게 뒤쪽에 '*'추가
            Console.WriteLine(str.PadRight(10, '*'));
            //인덱스 4부터 부분 문자열 제거
            Console.WriteLine(str.Remove(4));
            //인덱스 4부터 2개의 부분 문자 제거
            Console.WriteLine(str.Remove(4, 2));
            //소문자를 대문자로
            Console.WriteLine(str.ToUpper());
            //대문자를 소문자로
            Console.WriteLine(str2.ToLower());
            //문자열 앞뒤 공백 제거
            Console.WriteLine(str.Trim());


            //문자열을 정수로 변환하기
            int num;
            string strnum = "456";
            num = int.Parse(strnum);
            Console.WriteLine("변환한 숫자 : {0}", num);
            num = int.Parse(Console.ReadLine());
            Console.WriteLine("입력한 숫자 : {0}", num);



            //2월 22일
            //예외처리하기
            string str = null;
            int num = 0;
            bool isTry = false;
            do
            {
                isTry = false;
                try
                {
                    str = Console.ReadLine();
                    num = int.Parse(str);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    isTry = true;
                }
            } while (isTry);
            Console.WriteLine("변환된 값 : " + num);


            //0222a, 클래스 활용
            Point a = new Point(5, 4);
            Point b = new Point();
            Console.WriteLine("a.x : {0} a.y : {1} b.x : {2} b.y : {3}", a.x, a.y, b.x, b.y);


            //0222b,public으로 class 함수를 선언했을때 발생하는일
            Hero myhero = new Hero();
            //public으로 선언된 hp에 접근하여 의도하지 않은 작업 수행
            myhero.hp -= 1200;
            Console.WriteLine("현재HP : " + myhero.hp);

            //0222c,private로 생성된 hp를 의도한 public함수 기능으로 작동시키기
            Hero myhero = new Hero();
            if (myhero.GetHP() - 300 > 0)
                myhero.SetHP(myhero.GetHP() - 300);
            Console.WriteLine("현재 HP : " + myhero.GetHP());

            //0222d Get Set 한줄로 선언된 함수 사용
            Hero myhero = new Hero();
            if (myhero.HP - 300 > 0)
                myhero.HP = (myhero.HP - 300);



            //2월 23일
            //0223a Damage주기
            Hero myhero = new Hero();
            myhero.Damage(120);
            Console.WriteLine("현재 HP : " + myhero.GetHP());


            //0223b 정적선언(static)의 필요성
            Student std1 = new Student();
            Student std2 = new Student();
            //static 정적 선언 property 사용법
            Student.m_schoolName = "서울대학교";
            std1.NAME = "홍길동";
            std2.NAME = "아무개";
            Student.IntroMyUniv();
            std1.Intro();
            std2.Intro();

            //0223c value값을 call by reference 함수로 활용(ref-값을 넣고 받기가능, out-값을 받아오기만 가능)
            int num1 = 10, num2 = 20, num = 10;
            int sum;
            Add(num1, num2, out sum);
            Console.WriteLine(num);
            Increment(ref num);
            Console.WriteLine(sum);
            Console.WriteLine(num);

            //0223d Swap함수 만들기
            int num1 = 1, num2 = 2;
            Console.WriteLine("전 : {0}, {1}", num1, num2);
            Swap(ref num1, ref num2);
            Console.WriteLine("후 : {0}, {1}", num1, num2);

            //foreach 반복문
            string str = "Hello World";
            foreach (char c in str)
            {
                Console.Write(c);
            }
            Console.WriteLine("");
            int i = 0;
            int[] arr = new int[] { 10, 20, 30, 40, 50 };

            //foreach를 for반복문으로 전환
            foreach (int n in arr)
            {
                Console.WriteLine("arr[{0}] : {1}", i, n);
                i++;
            }
            for (int j = 0; j < arr.Length; j++)
            {
                Console.WriteLine("arr[{0}] : {1}", j, arr[j]);
            }

            string[] arr1 = new string[] { "Hello", "sbs", "game", "Academy" };

            for (int k = 0; k < arr1.Length; i++)
                Console.WriteLine("{0}", arr[k]);
            Console.WriteLine();
            //foreach보다 for문 사용을 권장하는이유
            //처리방식이 for랑 다름, foreach는 기존 선언한 힙메모리만큼 더 만들어서 복제해서 처리함
            foreach (string s in arr1)
                Console.WriteLine("{0}", s);
            Console.WriteLine();

            //0223e 클래스 배열 선언
            Point[] arr = new Point[3] { new Point(1, 1), new Point(2, 2), new Point(3, 3) };

            foreach (Point pt in arr)
            {
                pt.Print();
            }
            Console.WriteLine();
            //for문으로 전환
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i].Print();
            }



            //2월 24일
            //0224a 섭씨 화씨 전환
            int select = 0;
            while (true)
            {
                Change temp1 = new Change();
                Console.WriteLine("1. F로 변환 2. C로 변환");
                select = int.Parse(Console.ReadLine());
                if (select == 1)
                {
                    float temp = float.Parse(Console.ReadLine());
                    temp1.cngf(ref temp);
                    Console.WriteLine("{0:F2}F", temp);
                }
                else if (select == 2)
                {
                    float temp = float.Parse(Console.ReadLine());
                    temp1.cngc(ref temp);
                    Console.WriteLine("{0:F2}C", temp);
                }
                else
                {
                    Console.WriteLine("다시입력하세요");
                }
            }


            //0224b int 배열 인덱스 활용 정보변경
            TempRecord temp = new TempRecord();
            temp[3] = 58.3F;
            temp[5] = 60.1F;
            for (int i = 0; i < temp.Length; i++)
                System.Console.WriteLine("tempRecord[{0}] = {1}", i, temp[i]);

            //0224c string 인덱스와 예외처리
            DayCollection week = new DayCollection();
            Console.WriteLine(week["Fri"]);
            //예외처리 확인을 위한 입력
            Console.WriteLine(week["Made-up day"]);


            //배열의 선언
            int[] array = new int[5];
            int[] array2 = new int[] { 1, 2, 3, 4, 5 };
            //아래방식은 할당 안하게 되는 실수가 많아서 비추천
            int[] array3 = { 1, 2, 3, 4, 5 };
            //2차원 배열 선언
            int[,] map = new int[3, 5];
            //아래방식은 할당 안하게 되는 실수가 많아서 비추천
            int[,] map2 = { { 1, 2, 3 }, { 4, 5, 6 } };
            //3차원 배열 선언
            //int[,,] map = new int[5,5,5];
            //가변배열 선언, 행마다 열 갯수가 다를때 선언
            int[][] jaggedArray = new int[2][];
            jaggedArray[0] = new int[4] { 1, 2, 3, 4 };
            jaggedArray[1] = new int[3] { 5, 6, 7 };


            //2차원 배열
            int i = 0;
            int[,] array = new int[2, 3]
            {
                {1,2,3 },
                {4,5,6 }
            };
            foreach (int num in array)
            {
                Console.Write(num + " ");
                i++;
                //행 바뀌면 줄 바꾸기, GetLength: 0이면 행의갯수, 1이면 열의 갯수를 가져옴
                if (i % array.GetLength(1) == 0)
                    Console.WriteLine();
            }
            //for문으로 변경
            for (int j = 0; j < 2; j++)
            {
                for (int k = 0; k < 3; k++)
                {
                    Console.Write(array[j, k] + " ");
                }
                Console.WriteLine();
            }



            //2월 25일
            //가변배열 for문 돌리기!
            string[][] jagged_str = new string[3][]
            {
                new string [3] {"SBS", "Game", "Academy"},
                new string[2] {"강남역", "12번출구로"},
                new string[]{"나오시면", "금방", "찾으실", "수", "있습니다.", "!!"}
            };
            foreach (string[] jagged in jagged_str)
            {
                foreach (string str_element in jagged)
                {
                    Console.Write(str_element + " ");
                }
                Console.WriteLine();
            }
            //for문으로 변경
            for (int i = 0; i < jagged_str.GetLength(0); i++)
            {
                for (int j = 0; j < jagged_str[i].Length; j++)
                {
                    Console.Write(jagged_str[i][j] + " ");
                }
                Console.WriteLine();
            }


            //0225a 포켓몬, class를 통한 배열 변수 만들어서 활용하기
            PocketMon[] pomon = new PocketMon[4];
            pomon[0] = new PocketMon("불", "파이리");
            pomon[1] = new PocketMon("물", "꼬부기");
            pomon[2] = new PocketMon("풀", "이상해씨");
            pomon[3] = new PocketMon("전기", "피카츄");
            foreach (PocketMon po in pomon)
            {
                po.PrintPocketMon();
            }
            //for문으로 변경
            for (int i = 0; i < pomon.Length; i++)
            {
                pomon[i].PrintPocketMon();
                //Console.WriteLine();
            }


            //0225b 배열 출력
            string[] weekDays = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };
            PrintArray(weekDays);


            //Array.Copy 기능 활용으로 배열 값을 다른배열 원하는 위치에 복사하기
            int[] orgArr = new int[] { -1, -3, -5, -7, -9 };
            int[] copyArr = new int[] { 2, 4, 6, 8, 10 };
            Array.Copy(orgArr, 0, copyArr, 1, 3);
            for (int i = 0; i < copyArr.Length; i++)
            {
                Console.WriteLine("copyArr[{0}] = {1}", i, copyArr[i]);
            }


            //(자료형[])배열이름.Clone 기능 활용으로 배열을 다른배열에 복사하기
            int[] orgArr = new int[] { 10, 20, 30, 40 };
            int[] copyArr = (int[])orgArr.Clone();
            for (int i = 0; i < copyArr.Length; i++)
            {
                Console.WriteLine("copyArr[{0}] = {1}", i, copyArr[i]);
            }


            //0225c 일반화 함수 만들기
            string name = "Zeratul";
            int age = 123;
            float height = 172.2f;
            double weight = 76.3d;
            Print(name);
            Print(age);
            Print<float>(height);
            Print<double>(weight);


            //0225d 일반화 클래스 선언 예시
            List<int> list1 = new List<int>();
            List<float> list2 = new List<float>();
            List<string> list3 = new List<string>();
            list1.InitArray(0, 58);
            list1.InitArray(1, 30);
            list2.InitArray(0, 75.2f);
            list2.InitArray(1, 65.5f);
            list3.InitArray(0, "아무개");
            list3.InitArray(1, "홍길동");
            for (int i = 0; i < list1.Length; i++)
            {
                Print("이름 : " + list3.GetValue(i));
                Print("나이 : " + list1.GetValue(i));
                Print("몸무게 : " + list2.GetValue(i));
            }


            //0225e 일반화 함수 활용
            int[] srcInt = { 1, 2, 3, 4, 5 };
            int[] tagInt = new int[srcInt.Length];
            string[] srcStr = { "hello", "sbs", "game", "academy" };
            string[] tagStr = new string[srcStr.Length];
            CopyArray(srcInt, tagInt);
            CopyArray(srcStr, tagStr);
            for (int i = 0; i < srcInt.Length; i++) Print(tagInt[i]);
            for (int i = 0; i < srcStr.Length; i++) Print(tagStr[i]);


            //0225f Delegate(대리자)활용하기, C언어 함수포인터와 유사
            TestDelegate calculate;
            calculate = new TestDelegate(Plus);
            int result = calculate(20, 30);
            Console.WriteLine(result);
            calculate = new TestDelegate(Minus);
            result = calculate(30, 20);
            Console.WriteLine(result);

            //3월 2일
            //0302a 대리자 선언 및 활용
            Calculator cal = new Calculator();

            Calculator(10, 20, cal.Plus);
            Calculator(20, 10, cal.Minus);
            Calculator(10, 20, cal.Multiply);


            //0302b 대리자+일반화 선언 및 활용
            Calculator cal = new Calculator();

            Calculator(10, 20, cal.Plus);
            Calculator(54.6f, 96.32f, cal.Plus);
            Calculator(200.5f, 120.10f, cal.Minus);
            Calculator(36.5f, 42.3f, cal.Multiply);



            //3월 3일
            //list, 배열과 비슷하게 사용가능
            ArrayList list = new ArrayList();
            list.Add(10);
            list.Add(20);
            list.Add(30);
            list.RemoveAt(1);
            list.Insert(1, 36.5f);
            list.Add("SBS 게임 아카데미");
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }


            //Queue, 격투게임 커맨드 등에서 활용가능
            Queue que = new Queue();
            que.Enqueue(10);
            que.Enqueue(20);
            que.Enqueue(30);
            que.Dequeue();
            que.Enqueue(4.4);
            que.Dequeue();
            que.Enqueue("ABC");
            //for문 사용불가능, que.Dequeue를 하게되면 저장된 값이 하나씩 나와서 count가 계속 변함
            while (que.Count > 0)
            {
                Console.WriteLine(que.Dequeue());
            }

            //stack
            Stack stack = new Stack();
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
            stack.Pop();
            stack.Push(4.4);
            stack.Pop();
            stack.Push("ABC");
            //for문 사용불가능, que와 마찬가지
            while (stack.Count > 0)
            {
                Console.WriteLine(stack.Pop());
            }


            //Hashtable, key와 data 한쌍으로 저장해야함, 데이터 색인시 유용
            Hashtable ht = new Hashtable();
            //ht.Add로도 추가는 가능하지만, key가 똑같으면 오류로 프로그램 동작을 안함.
            //따라서 containskey로 키 값이 있는지 검사 후 넣는 방식을 추천함.
            //ht.Add("오렌지", "banana");
            if (!ht.ContainsKey("오렌지"))
                ht.Add("오렌지", "orange");
            else
                Console.WriteLine("이미 등록된 key입니다.");
            if (ht.ContainsKey("오렌지"))
                Console.WriteLine(ht["오렌지"]);


            //Hashtable key값들 출력하기
            Hashtable ht = new Hashtable();
            ht.Add("오렌지", "orange");
            ht.Add("바나나", "banana");
            ht.Add("사과", "apple");
            //hashtable의 key값 반복은 foreach씀. for문 변경이 매우 복잡
            foreach (string key in ht.Keys)
            {
                Console.WriteLine(key);
            }
            //for문으로 변경
            var enumerator = ht.Keys.GetEnumerator();
            for (int i = 0; i < ht.Keys.Count; i++)
            {
                enumerator.MoveNext();
                var result = enumerator.Current;
                Console.WriteLine(result);
            }


            //Hashtable key와 값 출력하기
            Hashtable ht = new Hashtable();
            if (!ht.ContainsKey("오렌지"))
                ht.Add("오렌지", "orange");
            if (!ht.ContainsKey("바나나"))
                ht.Add("바나나", "banana");
            if (!ht.ContainsKey("사과"))
                ht.Add("사과", "apple");
            foreach (string s in ht.Keys)
            {
                Console.WriteLine(s);
                Console.WriteLine(ht[s]);
            }
            Console.WriteLine(ht["오렌지"]);
            Console.WriteLine(ht["바나나"]);
            Console.WriteLine(ht["사과"]);


            //3월 4일
            //0304a Dictionary활용
            TestDictionary();


            //0304b SortedList 활용
            SortedListGenericClass sortedList = new SortedListGenericClass();
            sortedList.TestStortedListGeneric();


            //이중연결List, 단일연결과의 차이는 Next와 Prev 앞뒤로 연결되어있음, 중간삽입용이
            LinkedList<int> linkedList = new LinkedList<int>();
            linkedList.AddFirst(1);
            linkedList.AddAfter(linkedList.First, 3);
            //중간삽입
            linkedList.AddBefore(linkedList.Find(3), 2);
            Console.WriteLine(linkedList.First.Value);
            Console.WriteLine(linkedList.Last.Value);


            //0304c 이중연결List 활용
            TestLinkedList();


            //0304d 이중연결List 활용2
            LinkedListGenericClass testLList = new LinkedListGenericClass();
            testLList.TestLinkedListGeneric();


            //0304e 제너릭리스트
            TestList();


            //0304f 제너릭리스트 활용3
            ListGenericClass testList = new ListGenericClass();
            testList.TestListGeneric();


            //3월 7일
            //0307a 상속클래스
            BaseClass bc = new BaseClass();
            DerivedClass dc = new DerivedClass();
            BaseClass bcdc = new DerivedClass();
            bc.Method1();
            bc.Method2();
            dc.Method1();
            dc.Method2();
            //부모클래스를 자식클래스로 선언했을때, virtual로 작성된 메소드는 override된 메소드가 호출됨!
            bcdc.Method1();
            bcdc.Method2();
            Console.ReadKey();


            //0307b 상속클래스
            TestCars1();
            TestCars2();
            TestCars3();



            //3월 8일
            //0308a 도형
            double r = 3.0, h = 5.0;
            Shape c = new Circle(r);
            Shape s = new Sphere(r);
            Shape l = new Cylinder(r, h);
            Console.WriteLine("원의 면적    = {0:F2}", c.Area());
            Console.WriteLine("구의 면적    = {0:F2}", s.Area());
            Console.WriteLine("원통의 면적  = {0:F2}", l.Area());


            //0308b 캐릭터 전투태세
            Character[] characters = new Character[2];

            characters[0] = new Knight();
            characters[1] = new Archer();

            for (int i = 0; i < characters.Length; i++)
            {
                Console.WriteLine(characters[i].ToString());
                characters[i].ReadyToBattle();
            }


            //0308c 상속 예제 동물
            Animal ani = new Animal();
            Cat cat = new Cat();
            Dog dog = new Dog();
            ani.Bark();
            cat.Bark();
            dog.Bark();
            List<Animal> listAni = new List<Animal>() { new Animal(), new Cat(), new Dog() };
            for (int i = 0; i < listAni.Count; i++)
            {
                listAni[i].Attack();
            }


            //0308d 추상(abstract)클래스, 형태만 정의하고 세부내용을 자식클래스에서 override로 재정의
            //추상클래스는 인스턴스 불가
            //Abstract ab = new Abstract();
            General gn = new General();
            Console.WriteLine("프로퍼티 x의 값 : " + gn.X);
            gn.func();
            gn.func2();


            //0308e 추상클래스
            Bird bird = new Bird();
            Cat cat = new Cat();
            Dog dog = new Dog();
            bird.Bark();
            cat.Bark();
            dog.Bark();
            List<Animal> listAni = new List<Animal>() { new Bird(), new Cat(), new Dog() };
            for (int i = 0; i < listAni.Count; i++)
            {
                listAni[i].Attack();
            }


            //3월 9일
            //0309a 테란
            List<Terran> terran = new List<Terran>() { new Marine(), new Reaper(), new Banshee() };
            for (int i = 0; i < terran.Count; i++)
            {
                terran[i].UnitInfo();
            }
            terran[(int)Unit.MARINE].move(10, 50);
            terran[(int)Unit.MARINE].attack();
            terran[(int)Unit.REAPER].move(100, 200);
            terran[(int)Unit.REAPER].attack();
            terran[(int)Unit.BANSHEE].move(50, 250);
            terran[(int)Unit.BANSHEE].attack();


            //0309b 인터페이스
            MultiInheritance mi = new MultiInheritance();
            interA interface1 = mi;
            interB interface2 = mi;
            interC interface3 = mi;
            interface1.a();
            interface2.b();
            interface3.c();
            mi.a();
            mi.b();
            mi.c();


            //0309c 인터페이스 예제
            Car mycar = new Car();
            mycar.Gear(3);
            mycar.Volume(5);
            //mycar.Off();
            CarControl carCon = mycar;
            AudioControl audioCon = mycar;
            carCon.Off();
            audioCon.Off();



            //0309d 오름차순 내림차순 정렬
            List<Student> tmpList = new List<Student>() { new Student() { m_num = 1, m_name = "민수"},
                                                      new Student() { m_num = 2, m_name = "수지"},
                                                      new Student() { m_num = 3, m_name = "설현"} };
            StudentList stdList = new StudentList();
            for (int i = 0; i < tmpList.Count; i++)
                stdList.Add(tmpList[i]);
            stdList.SortDescending();
            for (int i = 0; i < stdList.Count; i++)
                Console.WriteLine("번호 : {0}, 이름 : {1}", stdList.m_list[i].m_num, stdList.m_list[i].m_name);
            Console.WriteLine();
            stdList.SortAscending();
            for (int i = 0; i < stdList.Count; i++)
                Console.WriteLine("번호 : {0}, 이름 : {1}", stdList.m_list[i].m_num, stdList.m_list[i].m_name);


            //0310a 파일입력
            Console.WriteLine("읽어올 파일 이름을 입력해 주세요");
            string filename = Console.ReadLine();
            FileRead(filename);


            //0310b 파일 생성하기
            Console.WriteLine("파일 이름을 입력해 주세요");
            string filename = Console.ReadLine();
            Fileread(filename);


            //0310c 바이너리 파일 생성하기
            Console.WriteLine("파일 이름을 입력해 주세요");
            string filename = Console.ReadLine();
            FileCreate(filename);


            //0310d 직렬화 파일 생성
            Console.WriteLine("생성할 파일 이름을 이력해 주세요");
            string filename = Console.ReadLine();
            FileCreate(filename);


            //0310e 직렬화 파일 생성(배열)
            Console.WriteLine("생성할 파일 이름을 이력해 주세요");
            string filename = Console.ReadLine();
            FileCreate(filename);


            //0310f 파일정보 확인하기
            FileInfo();


            //0310g 파일 삭제하기
            Console.WriteLine("삭제할 파일 이름을 입력해 주세요");
            string filename = Console.ReadLine();
            FileDelete(filename);


            //0310h 파일 저장
            Console.WriteLine("파일 이름을 입력해 주세요");
            string filename = Console.ReadLine();
            FileSave(filename, "Hi");


            //0310i 폴더 생성,삭제
            CreateDirectory();



            //3월 11일
            //0311a 폴더확인 후 파일 읽어오기
            GetFiles();


            //0311b 폴더확인 후 내부 폴더 경로 확인
            GetFiles();


            //0311c 무명형식
            //읽기전용, 초기화 불가, 주로 DB에서 데이터 검색해서 전달할때 쓰임
            var temp = new { age = 11, name = "민수" };
            Console.WriteLine("이름: {0}, 나이 : {1}", temp.name, temp.age);
            var tempArray = new
            {
                Int = new int[] { 100, 200, 300, 400 },
                Float = new float[] { 0.5f, 1.5f, 2.5f }
            };
            for (int i = 0; i < tempArray.Int.Length; i++)
                Console.WriteLine("tempArray.Int[{0}] : {1}", i, tempArray.Int[i]);
            for (int i = 0; i < tempArray.Float.Length; i++)
                Console.WriteLine("tempArray.Float[{0}] : {1}", i, tempArray.Float[i]);


            //0311d 무명메소드
            MyDelegate Add = delegate (int a, int b)
            {
                return a + b;
            };
            MyDelegate Multi = delegate (int a, int b)
            {
                return a * b;
            };
            Console.WriteLine(Add(100, 200));
            Console.WriteLine(Multi(20, 50));


            //0311e 무명람다식
            //함수 내용이 한줄일때만 이렇게
            MyDelegate Add = (a, b) => a + b;
            MyDelegate Multi = (a, b) => a * b;
            //한줄이 아니면 =>이후 중괄호 써서 똑같이 코딩
            MyDelegate2 Compare = (a, b) =>
            {
                if (a > b)
                    Console.WriteLine("{0} > {1}", a, b);
                else if (a < b)
                    Console.WriteLine("{0} < {1}", a, b);
                else
                    Console.WriteLine("{0} == {1}", a, b);
            };
            PrintDelegate Message = () => Console.WriteLine("안녕하세용");
            Console.WriteLine(Add(100, 200));
            Console.WriteLine(Multi(20, 50));
            Message();
            Compare(30, 60);
            Compare(60, 30);
            Compare(100, 100);


            //0311f 람다+디렉토리 혼합
            GetFiles();


            //0311f Func 대리자 : 반환값이 있는경우에 쉽게 대리자 선언가능
            Func<string, string> func01 = UpperCaseString;
            Func<string> func02 = DrawMessage;
            string name = "Zeratul";
            Console.WriteLine(func01(name));
            Console.WriteLine(func02());


            //0311g Func 대리자
            Func<string> Print = () => "안녕하세용";
            Func<int, int, int> Add = (a, b) => a + b;
            Func<int, int, int> Mul = (a, b) => a * b;
            Func<double, double> FtoC = (F) => (F - 32) * 5 / 9;
            Func<double, double> CtoF = (C) => (C * 9 / 5) + 32;

            Console.WriteLine("Func Print 값 : {0}", Print());
            Console.WriteLine("Func Add 값 : {0}", Add(10, 20));
            Console.WriteLine("Func Mul 값 : {0}", Mul(10, 20));
            Console.WriteLine("Func FtoC 값 : {0}", FtoC(132.5d));
            Console.WriteLine("Func CtoF 값 : {0}", CtoF(36.5d));


            //0311h Action 대리자 : 반환값이 없는경우에 쉽게 대리자 선언가능
            Action<string> func01 = UpperCaseString;
            Action<int, int> func02 = Sum;
            string name = "Zeratul";
            func01(name);
            func02(20, 30);


            //3월 14일
            //0314a,b 싱글턴
            Sington.Instance.Drawmessage();
            TestSingleton.Instance.DrawMessage();


            //0314c 싱글턴 예제
            Stage stage = new Stage();
            stage.CreateMonsters();
            MonsterManager.Instance.DrawMonstersInfo();
            Console.WriteLine("stage Clear : {0}", stage.IsClear());


            //0314d StringBuilder, 문자열 관리 기능들
            string str = "hello";
            //if(str == "hello") heap메모리에 hello를 계속 생성누적시켜서 퍼포먼스 저하의 원인이 됨
            //if(str.Equals("hello")) 로 문자열 검사해야 heap메모리 누적을 안함

            StringBuilder sb = new StringBuilder("안녕하세요!");
            Console.WriteLine(sb);
            sb.Append(" SBS 게임 아카데미 입니다.");
            Console.WriteLine("Append() : {0}", sb);
            sb.AppendFormat("이름은 {0}이고 나이는 {1}살 입니다.", "Zeratul", 26);
            Console.WriteLine("AppendFormat() : {0}", sb);
            //remove(a, b); 문자열[a]부터 b갯수 만큼 삭제
            sb.Remove(0, 6);
            Console.WriteLine("Remove() : {0}", sb);
            //insert(a, "str"); 문자열[a]부터 str삽입
            sb.Insert(12, " 강남지점");
            Console.WriteLine("Insert() : {0}", sb);
            //Replace("str1", "str2"); str1을 지우고 str2를 삽입
            sb.Replace("강남지점", "신촌지점");
            Console.WriteLine("Replace() : {0}", sb);
            //Clear(); 문자열 전체 삭제
            sb.Clear();
            Console.WriteLine("Clear() : {0}", sb);

            //0314e 데이터관리
            DataSet ds = CreateDataSet();
            DataTable dt = ds.Tables[TableName];
            DataRow[] dr = dt.Select();
            for (int i = 0; i < ds.Tables[TableName].Columns.Count; i++)
                Console.WriteLine(ds.Tables[TableName].Columns[i].ToString() + "\t");
            Console.WriteLine();
            //foreach(DataRow dr in dt.Rows)
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    Console.WriteLine(dr[i][j] + "\t");
                }
            }

        }
    }
}


//2월 22일 namespace활용
namespace A
{
    class Point
    {
        private int x, y;
        public Point(int _x, int _y)
        {
            x = _x;
            y = _y;
        }
    }
}
namespace B
{
    class Point
    {
        private int x, y;
        public Point(int _x, int _y)
        {
            x = _x;
            y = _y;
        }
    }
}
namespace C
{
    class Program
    {
        static void main(string[] args)
        {
            A.Point point1 = new A.Point(2, 3);
            B.Point point2 = new B.Point(4, 5);
        }
    }
}

//0222a, 클래스, 접근 지정자, 생성자 등
class Point
{
    public int x;
    public int y;
    //접근자 지정을 하지 않으면 디폴트 값은 private
    int z;
    public Point()
    {
        x = 0;
        y = 0;
    }
    public Point(int x, int y)
    {
        //this : 처음 생성된 변수를 지칭함. 그냥 x로 입력하면 매개변수x가 지칭됨
        this.x = x;
        this.y = y;
    }
    //소멸자 : 클래스 이름 앞에 ~가 붙고 중복정의 불가, 소멸되는 시점에 자동호출, C#에서는 쓸일없음..
    ~Point()
    {
        x = 0;
        y = 0;
    }
}

//0222b, public으로 class 함수를 선언, hero hp와 레벨업시 max hp로 회복되는것만 설정
class Hero
{
    //C언어 #define활용하듯 C#에서 상수값 선언
    private const int MAX_HP = 500;
    public int hp = 0;
    public Hero()
    {
        hp = MAX_HP;
    }
    public void LevelUp()
    {
        hp = MAX_HP;
    }

}

//0222c, private으로 함수를 선언, public은 본인이 의도하고자 하는 기능만 생성!(예외처리도 가능)
class Hero
{
    private const int MAX_HP = 500;
    private int hp = 0;
    //private로 선언된 hp를 외부에서 값을 전달받기위한 Get함수, 한줄로 적어도됨
    public int GetHP() { return hp; }
    //private로 선언된 hp를 외부에서 값을 조정하기 위한 Set함수, 한줄로 적어도됨
    public void SetHP(int hp) { this.hp = hp; }
    public Hero()
    {
        hp = MAX_HP;
    }
    public void LevelUp()
    {
        hp = MAX_HP;
    }

}

 //0222d Get Set 한줄로 선언하기
class Hero
{
    private const int MAX_HP = 500;
    private int hp = 0;
    //Get, Set함수 한줄로 선언하기
    public int HP { get { return hp; } set { hp = value; } }
    public Hero()
    {
        hp = MAX_HP;
    }
    public void LevelUp()
    {
        hp = MAX_HP;
    }
}


//0223a Damage 함수
class Hero
{
    private const int Max_HP = 500;
    private int hp = 0;
    public int GetHP() { return hp; }
    public Hero()
    {
        hp = Max_HP;
    }
    public void LevelUP()
    {
        hp = Max_HP;
    }
    public void Damage(int dmg)
    {
        if (hp - dmg > 0) hp -= dmg;
        else { hp = 0; }
    }
}


//0223b 정적 선언
class Student
    {
        private string m_name;
        //static : 정적 선언, 선언과 동시에 메모리 확보, 생성자로 생성시 하나의 공통된 값을 지정할때 주로 씀
        public static string m_schoolName;
        public string NAME { get { return m_name; } set { m_name = value; } }
        public void Intro()
        {
            Console.WriteLine("{0}에 다니는 {1}입니다.", m_schoolName, m_name);
        }
        //static 선언을 햇기에 new로 생성해야하는 변수가 있는 경우 활용 불가
        public static void IntroMyUniv()
        {
            Console.WriteLine("우리학교는 {0} 입니다.", m_schoolName);
        }
    }


//0224a 섭씨 화씨변환
class Change
{
    public float cngf(ref float temp)
    {
        temp = temp * 9 / 5 + 32;
        return temp;
    }
    public float cngc(ref float temp)
    {
        temp = (temp - 32) * 5 / 9;
        return temp;
    }
}


//0224b int 배열 인덱스 활용 클래스 정보변경
class TempRecord
{
    private float[] temps = new float[10] { 56.2F, 56.7F, 56.5F, 56.9F, 58.8F, 61.3F, 65.9F, 62.1F, 59.2F, 57.5F };
    public int Length { get { return temps.Length; } }
    public float this[int index]
    {
        get { return temps[index]; }
        set { temps[index] = value; }
    }
}


//0224c string 인덱스와 예외 처리(오류메세지 출력)
class DayCollection
{
    string[] days = { "Sun", "Mon", "Tues", "Wed", "Thurs", "Fri", "Sat" };
    private int GetDay(string testday)
    {
        for (int j = 0; j < days.Length - 1; j++)
        {
            if (days[j] == testday)
            {
                return j;
            }
        }
        throw new ArgumentOutOfRangeException(testday, "testday must be in the form");
    }
    public int this[string day]
    {
        get { return (GetDay(day)); }
    }
}


//0225d 일반화 클래스 선언
class List<T>
{
    private T[] arr;
    public List() { arr = new T[2]; }
    public int Length { get { return arr.Length; } }
    public void InitArray(int index, T value) { arr[index] = value; }
    public T GetValue(int index) { return arr[index]; }
}



//0307b 상속클래스
class Car
{
    public virtual void DescribeCar()
    {
        Console.WriteLine("4개의 휠이 달린 바퀴와 엔진이 있습니다.");
        ShowDetails();
    }
    public virtual void ShowDetails()
    {
        Console.WriteLine("4명의 사람을 태울 수 있습니다.");
    }
}
class ConvertibleCar : Car
{
    public new void ShowDetails()
    {
        Console.WriteLine("지붕이 열립니다.");
    }
}
class Minivan : Car
{
    public override void ShowDetails()
    {
        Console.WriteLine("7명을 태울 수 있습니다.");
    }
}


//0308a 도형
public class Shape
{
    public const double PI = Math.PI;
    //protected : 
    protected double x, y;
    //생성자는 상속되지 않음!
    public Shape(double x, double y)
    {
        this.x = x;
        this.y = y;
    }
    public virtual double Area()
    {
        return x * y;
    }
}
public class Circle : Shape
{
    public Circle(double r) : base(r, 0) { }
    public override double Area()
    {
        return PI * x * x;
    }
}
class Sphere : Shape
{
    public Sphere(double r) : base(r, 0) { }
    public override double Area()
    {
        return 4 * PI * x * x;
    }
}
class Cylinder : Shape
{
    public Cylinder(double r, double h) : base(r, h) { }
    public override double Area()
    {
        return 2 * PI * x * x + 2 * PI * x * y;
    }
}


//0308b 캐릭터 전투태세
//클래스, 구조체는 모두 암묵적으로 Object를 상속받고있음!
//구조체는 상속이 안되고, 클래스만 상속가능
public class Character
{
    public virtual void ReadyToBattle()
    {
        Console.WriteLine("전투태세를 취합니다.");
    }
}
public class Knight : Character
{
    public override void ReadyToBattle()
    {
        Console.WriteLine("기사 : 칼을 뽑아 전투태세를 취합니다.");
    }
    //ToString() : Object에 선언된 가상함수, 
    public override string ToString()
    {
        return "기사 클래스";
    }
}
public class Archer : Character
{
    public override void ReadyToBattle()
    {
        Console.WriteLine("궁수 : 활을 뽑아 전투태세를 취합니다.");
    }
    public override string ToString()
    {
        return "궁수 클래스";
    }
}


//0308c 상속 예제 동물
class Animal
{
    public Animal() { Console.WriteLine("나는 동물입니다."); }
    public virtual void Bark() { Console.WriteLine("울음 소리를 냅니다."); }
    public virtual void Attack() { Console.WriteLine("공격을 시작합니다."); }
}
class Cat : Animal
{
    public Cat() { Console.WriteLine("나는 고양이입니다."); }
    public override void Bark() { Console.WriteLine("야옹"); }
    public override void Attack() { Console.WriteLine("할퀴기"); }
}
class Dog : Animal
{
    public Dog() { Console.WriteLine("나는 개입니다."); }
    public new void Bark() { Console.WriteLine("멍멍"); }
    public new void Attack() { Console.WriteLine("물기"); }
}


//0309a 테란
abstract class Terran
{
    public string m_name { get; set; }
    public void UnitInfo()
    {
        Console.WriteLine("나는 {0}입니다.", m_name);
    }
    public abstract void move(int x, int y);
    public abstract void attack();
}
class Marine : Terran
{
    public Marine() { m_name = "해병"; }
    public override void move(int x, int y)
    {
        Console.WriteLine("{0}이 [{1},{2}]로 이동합니다.", m_name, x, y);
    }
    public override void attack()
    {
        Console.WriteLine("{0}이 소총으로 공격합니다.", m_name);
    }
}
class Reaper : Terran
{
    public Reaper() { m_name = "사신"; }
    public override void move(int x, int y)
    {
        Console.WriteLine("{0}이 [{1},{2}]로 추진기로 빠르게 이동합니다.", m_name, x, y);
    }
    public override void attack()
    {
        Console.WriteLine("{0}이 가우스 권총으로 공격합니다.", m_name);
    }
}
class Banshee : Terran
{
    public Banshee() { m_name = "밴시"; }
    public override void move(int x, int y)
    {
        Console.WriteLine("{0}이 [{1},{2}]로 비행하여 이동합니다.", m_name, x, y);
    }
    public override void attack()
    {
        Console.WriteLine("{0}이 로켓포으로 공격합니다.", m_name);
    }
}


//0309b 인터페이스, 추상클래스처럼 반드시 재정의해야함, override는 쓰지않음
interface interA
{
    void a();
}
interface interB
{
    void b();
}
//인터페이스에 인터페이스 상속 가능
interface interC : interA
{
    void c();
}
class MultiInheritance : interB, interC
{
    public void a() { Console.WriteLine("a 메소드 호출"); }
    public void b() { Console.WriteLine("b 메소드 호출"); }
    public void c() { Console.WriteLine("c 메소드 호출"); }
}


//0309c 인터페이스 예제
interface CarControl
{
    void Gear(int i);
    void Off();
}
interface AudioControl
{
    void Volume(int i);
    void Off();
}
public class Car : CarControl, AudioControl
{
    public void Gear(int i)
    {
        Console.WriteLine("현재 기어는 {0}입니다.", i);
    }
    public void Volume(int i)
    {
        Console.WriteLine("현재 볼륨은 {0}입니다.", i);
    }
    //Off라는 공통된 이름의 함수를 하나로 정의가능
    /*public void Off()
    {
        Console.WriteLine("시동을 껐습니다.");
    }*/
    void CarControl.Off()
    {
        Console.WriteLine("자동차 시동을 끕니다.");
    }
    void AudioControl.Off()
    {
        Console.WriteLine("오디오 전원을 끕니다.");
    }
}


//0309d 오름차순 내림차순 정렬
public class Student
{
    public int m_num { get; set; }
    public string m_name { get; set; }
}

public class StudentList
{
    public List<Student> m_list = new List<Student>();
    Ascending m_sortAscending = new Ascending();
    Descending m_sortDescending = new Descending();
    public int Count { get { return m_list.Count; } }
    public void Add(Student friend) { m_list.Add(friend); }
    public void Clear() { m_list.Clear(); }
    public void SortAscending() { m_list.Sort(m_sortAscending); }
    public void SortDescending() { m_list.Sort(m_sortDescending); }
    public class Ascending : IComparer, IComparer<Student>
    {
        public int Compare(Student x, Student y) { return x.m_num.CompareTo(y.m_num); }
        public int Compare(object x, object y) { return Compare((Student)x, (Student)y); }
    }
    public class Descending : IComparer, IComparer<Student>
    {
        public int Compare(Student x, Student y) { return y.m_num.CompareTo(x.m_num); }
        public int Compare(object x, object y) { return Compare((Student)x, (Student)y); }
    }

}


//0314a 싱글턴, 내부에서 하나만 인스턴스 되고 외부에서 인스턴스 불가능, 생성한 메소드를 클래스명.프로퍼티.메소드 로 바로 사용가능
class Sington
{
    private static Sington _instance = null;
    private Sington() { }
    public static Sington Instance
    {
        get
        {
            if (_instance == null)
                _instance = new Sington();
            return _instance;
        }
    }
    public void Drawmessage()
    {
        Console.WriteLine("하이용");
    }
}


//0314b 싱글턴활용, 엄밀히 따지면 싱글턴이 아니지만, 사용법이 같고 암묵적으로 상속받는 자식클래스 인스턴스를 하지 않음
//대부분 이런방식으로 Singleton을 미리 만들어두고, 필요할때 매니저클래스등에 상속시켜서 씀
public class Singleton<T> where T : class, new()//일반화의경우 where로 T의 범위 제한 가능
{
    public static T Instance { get; private set; }
    static Singleton()
    {
        if (Singleton<T>.Instance == null)
            Singleton<T>.Instance = new T();
    }
}
class TestSingleton : Singleton<TestSingleton>
{
    public void DrawMessage()
    {
        Console.WriteLine("하이용");
    }
}


//0314c 싱글턴 예제
//몬스터 정보 클래스
public class Monster
{
    public int m_hp { get; set; }
    public int m_def { get; set; }
    public int m_Atk { get; set; }
    public bool m_isAlive { get; set; }
    public void InitMonster()
    {
        m_hp = 100;
        m_def = 20;
        m_Atk = 150;
        m_isAlive = true;
    }
    public void MonsterInfo()
    {
        Console.WriteLine("HP : {0}", m_hp);
        Console.WriteLine("Def : {0}", m_def);
        Console.WriteLine("Atk : {0}", m_Atk);
        Console.WriteLine();
    }
}

//몬스터 매니저 클래스(싱글턴)
class MonsterManager : Singleton<MonsterManager>
{
    List<Monster> m_monList = new List<Monster>();
    public int Count { get { return m_monList.Count; } }
    public void Add(Monster mon) { m_monList.Add(mon); }
    public bool Remove(Monster mon) { return m_monList.Remove(mon); }
    public void RemoveAll() { m_monList.RemoveAll(element => element.m_isAlive == true); }
    public void Clear() { m_monList.Clear(); }
    public Monster GetMonster(int idx)
    {
        return m_monList[idx];
    }
    public void InitMonsters()
    {
        for (int i = 0; i < m_monList.Count; i++)
        {
            m_monList[i].InitMonster();
        }
    }
    public void DrawMonstersInfo()
    {
        for (int i = 0; i < m_monList.Count; i++)
        {
            m_monList[i].MonsterInfo();
        }
        Console.WriteLine();
    }

}

//스테이지 클래스
public class Stage
{
    const int MONSTER_MAX = 10;
    public void CreateMonsters()
    {
        for (int i = 0; i < MONSTER_MAX; i++)
        {
            MonsterManager.Instance.Add(new Monster());
        }
        MonsterManager.Instance.InitMonsters();
    }
    public bool IsClear()
    {
        for (int i = 0; i < MonsterManager.Instance.Count; i++)
        {
            Monster mon = null;
            if ((mon = MonsterManager.Instance.GetMonster(i)) != null)
            {
                if (mon.m_isAlive) return false;
            }
        }
        return true;
    }
}