using ProxyPattern.Example_1.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern.Example_1.Proxsy
{
    public class Proxsy : ISubject
    {
        private Subject _subject;
        public void DoAction()
        {
            if (_subject == null)
            {
                _subject = new Subject();
            }
            _subject.DoAction();
         }
    }
}
