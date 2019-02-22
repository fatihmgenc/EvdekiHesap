using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvdekiHesap
{

    interface IObserver
    {
        void update();
    }


    interface ISubject
    {
        void AboneOl(IObserver a);
        void AboneCık(IObserver a);
        void GözlemciyeBildirim(string tür);
    }
    

}
