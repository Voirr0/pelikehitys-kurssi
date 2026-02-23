using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ruoka_annos
{
    

    enum Pääraaka_aine
    {
        nautaa,
        kanaa,
        kasviksia
        
    }

    enum Lisuke
    {
        perunaa,
        riisiä,
        pastaa,
    }

    enum Kastike
    {
        curry,
        hapanimelä,
        pippuri,
        chili
    }
    internal class ateria
    {
        public Pääraaka_aine pääaine;
        public Lisuke lisuke;
        public Kastike kastike;

    }
}
