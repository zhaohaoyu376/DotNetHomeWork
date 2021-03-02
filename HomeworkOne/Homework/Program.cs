using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.AccessControl;

namespace HomeworkOne
{
    /// <summary>
    /// 实现计算器功能
    /// </summary>
    class Maths
    {
        private int numOne;
        private int numTwo;
        private string symbol;


        public int NumOne
        {
            get
            {
                return numOne;
            }
            set
            {
                if(value==null)
                {
                    Console.WriteLine("输入有误");
                }
                else
                {
                    numOne = value;
                }
            }
        }

        public string Symbol
        {
            get
            {
                return symbol;
            }
            set
            {
                if (value == "+" || value == "-" || value == "*" || value == "/" || value == "%" || value == "^")
                {
                    symbol = value;
                }
                else
                {
                    Console.WriteLine("输入有误");
                    this.symbol = Console.ReadLine();
                }
            }
        }

        public int NumTwo
        {
            get
            {
                return numTwo;
            }
            set
            {
                numTwo = value;
            }
        }

        private double content;
        public void Calculate(int numOne, string symbol, int numTwo)
        {
            switch (symbol)
            {
                case "+":
                    content = numOne + numTwo;
                    Console.WriteLine("{0}", content);
                    break;
                case "-":
                    content = numOne - numTwo;
                    Console.WriteLine("{0}", content);
                    break;
                case "*":
                    content = numOne * numTwo;
                    Console.WriteLine("{0}", content);
                    break;
                case "/":
                    if (numTwo == 0)
                    {
                        Console.WriteLine("输入有误");
                    }
                    else
                    {
                        content = numOne / numTwo;
                        Console.WriteLine("{0}", content);
                    }
                    break;
                case "%":
                    if(numTwo == 0)
                    {
                        Console.WriteLine("输入有误");
                    }
                    if(numTwo > numOne)
                    {
                        Console.WriteLine("输入有误");
                    }
                    else
                    {
                        content = numOne % numTwo;
                        Console.WriteLine("{0}", content);
                    }
                    break;
                case "^":
                    content = Math.Pow(numOne, numTwo);
                    Console.WriteLine("{0}", content);
                    break;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Maths maths = new Maths();
            Console.WriteLine("输入数");
            maths.NumOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("输入运算符");
            maths.Symbol = Console.ReadLine();
            Console.WriteLine("输入数");
            maths.NumTwo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("结果");
            maths.Calculate(maths.NumOne, maths.Symbol, maths.NumTwo);
            Console.ReadLine();
        }
    
    }
}