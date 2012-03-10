using System;
using Clover.Copyer;
using System.Data.SqlClient;
using System.Data;

namespace Copyer
{
    // delegate long Square(int input);
    class Program
    {
        static void Main(string[] args1)
        {
            //范例一  在两个对象直接拷贝属性
            ClassA target = new ClassA();
            ClassB source = new ClassB() { A = "AA", B = 2, C = DateTime.Now };

            //复制代码
            CopyHelper<ClassB, ClassA>.Copy(source, target);

            Console.WriteLine(target.A);
            Console.WriteLine(target.B);
            Console.WriteLine(target.C);


            //范例二  从IDataReader中读取属性
            string connString = "Data Source=192.168.83.50;Initial Catalog=Northwind;Persist Security Info=True;";
       

            for (int i = 0; i < 1; i++)
            {

                using (SqlConnection conn = new SqlConnection(connString))
                {
                    SqlCommand command = new SqlCommand();
                    command.Connection = conn;
                    command.CommandText = "select top 1000 * from cLog";
                    conn.Open();
                    IDataReader reader = command.ExecuteReader();
                    var list = CopyHelper<TestClassA>.Copy(reader);
                    foreach (var item in list)
                    {
                        Console.Write(item.LogId + "---");
                        Console.Write(item.LogTime + "---");
                        Console.Write(item.AppName + "---");
                        Console.Write(item.Server + "---");
                        Console.Write(item.IPAddress + " ");
                        Console.WriteLine();
                    }
                }

            }
        }
    }

    public sealed class ClassA
    {

        public string A { get; set; }
        public int B { get; set; }
        public string Title { get; set; }
        public int Id { get; set; }
        public DateTime C { get; set; }

    }
    public sealed class ClassB
    {
        public string A { get; set; }
        public int B { get; set; }
        public DateTime C { get; set; }
    }
}
