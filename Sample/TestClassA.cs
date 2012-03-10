using System;
using Clover.Copyer;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Collections.Generic;

namespace Copyer
{
    public class TestClassA : TestClass
    {
       
        public DateTime LogTime { get; set; }
        public string AppName { get; set; }
        public string Server { get; set; }
        public string IPAddress { get; set; }
        public string Type { get; set; }
        public string Class { get; set; }
        public string dIpAddress { get; set; }

        //public StructE X1 { get; set; }
        //public StructE? X2 { get; set; }
        public int? LogId { get; set; }

        public int A { get; set; }
        public bool B { get; set; }
        public decimal C { get; set; }
        public string D { get; set; }
        public DateTime E { get; set; }
        public TestClassB TestClassB { get; set; }
        public EnumC F { get; set; }
        public int[] B1 { get; set; }
        public List<string> B2 { get; set; }

        public List<TestClassC> B3 { get; set; }
        public Dictionary<int, int> B4 { get; set; }

        public List<Dictionary<string, int>> B5 { get; set; }
        public Dictionary<int, TestClassC> B6 { get; set; }
        public Dictionary<int, List<int>> B7 { get; set; }
        public Dictionary<int, List<TestClassC>> B8 { get; set; }
        public Dictionary<int, Dictionary<TestClassC, string>> B9 { get; set; }

        public HashSet<TestClassC> B10 { get; set; }

        public Queue<int> B11 { get; set; }
        public Stack<int> B12 { get; set; }
        public TestClassA B13 { get; set; }



        public KeyValuePair<int, int> C1 { get; set; }

        public Exception D1 { get; set; }

        public UInt16 A1 { get; set; }
        public UInt32 A2 { get; set; }
        public UInt64 A3 { get; set; }
        public Int16 A4 { get; set; }
        public Int32 A5 { get; set; }
        public Int64 A6 { get; set; }
        public float A7 { get; set; }
        public double A8 { get; set; }
        public char A9 { get; set; }
        public byte A10 { get; set; }
        public Guid A11 { get; set; }
        public SByte A12 { get; set; }
        public Single A13 { get; set; }
        public TimeSpan A14 { get; set; }
        //  public object Test { get; set; }
    }
    public class TestClass
    {
        public int Id { get; set; }
        public bool Female { get; set; }
    }

    public class TestClassB
    {
        public int BB { get; set; }
        public bool BC { get; set; }


        //   public IList BD { get; set; }
    }

    public class TestClassC
    {
        public int BB1 { get; set; }
        public bool BC1 { get; set; }
        public TestClassC BC2 { get; set; }
        public TestClassB BC3 { get; set; }
        public TestClassA BC4 { get; set; }

        //   public IList BD { get; set; }
    }
    public enum EnumC
    {
        Default = 0,
        Test = 1,
    }
    public struct StructE
    {
        public DateTime A { get; set; }
        public string B { get; set; }
        public int D { get; set; }
        public object o { get; set; }
    }
}
