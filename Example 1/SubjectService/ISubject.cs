using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern.Example_1.Interface
{
    public interface ISubject
    {
        void DoAction();
    }


    public class Subject : ISubject
    {
        public void DoAction()
        {
            Console.WriteLine("ISubject.Subject.DoAction ........Run");
        }
    }

}
