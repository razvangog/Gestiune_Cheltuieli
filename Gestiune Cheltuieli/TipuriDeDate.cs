using System;

namespace Gestiune_Cheltuieli
{
    public enum View
    {
        Main,
        AdaugaEveniment,
        Grafic,
        Notite,
        AdaugaNotite
    };

    public enum PerioadaEveniment
    {
        Lunar,
        Saptamanal,
        OdataLaXZile,
        AltTip
    };

    public enum TipEveniment
    {
        Cheltuiala,
        Venit
    };

    public struct Eveniment
    {
        public int id;
        public DateTime data;
        public double suma;
        public PerioadaEveniment perioada;
        public int xZile;
        public TipEveniment tipEveniment;
        public string detalii;
    };

    public struct Notita
    {
        public int id;
        public DateTime data;
        public string text;
        public bool expirat;
    };
}