using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalloVererbung.WinformsGUI
{
    delegate void EinfacherDelegate();
    delegate void DeleMitPara(string textZeug);
    delegate long CalcDele(int a, int b);

    class HalloDelegate
    {
        private int _myProperty;

        public HalloDelegate()
        {
            EinfacherDelegate meinDele = EinfacheMethode;
            Action meinDeleAlsAction = EinfacheMethode;
            Action meinDeleAlsAction2 = () => { Console.WriteLine("Hallo"); };

            DeleMitPara meinDeleMitPara = MethodeMitPara;
            Action<string> meinDeleMitParaAlsAction = MethodeMitPara;
            DeleMitPara meinDeleMitPara2 = x => Console.WriteLine(x);

            CalcDele meinCalc = Minus;
            long rsult = meinCalc.Invoke(4, 5);
            Func<int, int, long> calcFunc = Sum;
            CalcDele meinCalc2 = (x, y) => { return x / y; };
            CalcDele meinCalc3 = (x, y) => x / y;

            List<string> texte = new List<string>();


            var result = texte.Where(Filter);
            var result2 = texte.Where(x => x.StartsWith("b")).OrderBy(x => x.Length).Take(3);

        }

        private bool Filter(string arg)
        {
            if (arg.StartsWith("b"))
                return true;
            else
                return false;
        }

        public void EinfacheMethode()
        {
            Console.WriteLine("Hallo");
        }

        public void MethodeMitPara(string txt)
        {
            Console.WriteLine(txt);
        }

        public long Sum(int a, int b)
        {
            return a + b;
        }

        public long Minus(int a, int b)
        {
            return a - b;
        }
    }
}
