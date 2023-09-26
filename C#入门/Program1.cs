using System;
namespace oopo
{
    class program
    {
        class student
        {
            public string? name;
            private int _age;
            public int age
            {
                get
                {
                    return _age;
                }
                set
                {
                    if (value <= 150 && value >= 0)
                        _age = value;
                    else
                    {
                        Console.WriteLine("age must less than 150 and bigger than 0");
                    }
                }
            }
            private string _Sex;
            public string? Sex
            {
                set
                {
                    if (value == "man" || value == "woman")
                        _Sex = value;
                    else
                        Console.WriteLine("wrong");
                }
                get { return _Sex; }
            }
            private float _CSharpScore;
            public float CSharpScore
            {
                get
                {
                    return _CSharpScore;
                }
                set
                {
                    if (value <= 100 && value >= 0)
                        _CSharpScore = value;
                    else
                    {
                        Console.WriteLine("Score must less than 100 and bigger than 0");
                    }
                }
            }

            private float _UnityScore;
            public float UnityScore
            {
                get
                {
                    return _UnityScore;
                }
              set
                {
                    if (value <= 100 && value >= 0)
                        _UnityScore = value;
                    else
                    {
                        Console.WriteLine("Score must less than 100 and bigger than 0");
                    }
                }
            }
            public void Introduction()
            {
                Console.WriteLine("{0},{1},{2}", this.name, this.age, this.Sex);
            }
            public void Score()
            {
                float CSharpScort = this.CSharpScore;
                float UnityScort = this.UnityScore;
                Console.WriteLine(CSharpScort + UnityScort);
                Console.WriteLine((CSharpScort + UnityScort) / 2);
            }
        }
        class Program
        {
            static void Main()
            {
                student s1 = new student();
                s1.name = "咖喱蛋挞";
                s1.age = 160;
                s1.UnityScore = 11;
                s1.CSharpScore = 1;
                s1.Sex = "超人";
                s1.Introduction();
                s1.Score();
            }
        }
    }
}