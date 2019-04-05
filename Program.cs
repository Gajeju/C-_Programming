using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._11_Fraction //분수
{
    class Fraction
    {
        public int numerator;
        public int denominator;

        public Fraction(int n)  //한 개의 정수를 받아 초기화하는 생성자
        {
            numerator = 1;
            denominator = n;
        }

        public Fraction(int d, int n)  //두 개의 정수를 받아 초기화하는 생성자
        {
            numerator = d;
            denominator = n;
        }

        public override string ToString()   //하나의 분수를 분자/분모 형태로 변환하는 ToString() 메소드
        {
            return (this.numerator + " / " + this.denominator);
        }

        public void Max()                  //최대공약수
        {
            int temp;

            while (denominator != 0)
            {
                temp = denominator;
                denominator = numerator % denominator;
                numerator = temp;
            }

            Console.WriteLine("최대공약수 :" + numerator);
        }

        public void Irreducible()               //기약분수
        {
            int temp;
            int a = numerator;
            int b = denominator;

            while (denominator != 0)
            {
                temp = denominator;
                denominator = numerator % denominator;
                numerator = temp;
            }
            Console.WriteLine(a/numerator + " / " + b/numerator);
        }

        class test
        {
            static void Main(string[] args)
            {
                Fraction a = new Fraction(16,24);
                a.ToString();
                Console.WriteLine(a.ToString());
                a.Max();
                Fraction b= new Fraction(16, 24);
                b.Irreducible();
            }
        }
    }
}
