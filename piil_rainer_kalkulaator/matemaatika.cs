using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace piil_rainer_kalkulaator
{
     class matemaatika
    {
        public float arv1;
        public float arv2;
        public float numberVastus;
        public string  vastus;

        public string liitmine()
        {
            numberVastus = arv1 + arv2;
            vastus = arv1.ToString().Replace(".", ",") + " + " + arv2.ToString().Replace(".", ",") + " = " + numberVastus.ToString().Replace(".", ",");
            return vastus;
        }
        public string lahutamine()
        {
            numberVastus = arv1 - arv2;
            vastus = arv1.ToString().Replace(".", ",") + " - " + arv2.ToString().Replace(".", ",") + " = " + numberVastus.ToString().Replace(".", ",");

            return vastus;
        }
        public string korrutamine()
        {
            numberVastus = arv1 * arv2;

            vastus = arv1.ToString().Replace(".", ",") + " * " + arv2.ToString().Replace(".", ",") + " = " + numberVastus.ToString().Replace(".", ",");

            return vastus;
        }
        public string jagamine()
        {
            numberVastus = arv1 / arv2;
            vastus = arv1.ToString().Replace(".", ",") + " / " + arv2.ToString().Replace(".", ",") + " = " + numberVastus.ToString().Replace(".", ",");

            return vastus;
        }
    }
}
