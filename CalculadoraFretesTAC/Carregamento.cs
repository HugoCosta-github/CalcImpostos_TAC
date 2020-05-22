

namespace CalculadoraFretesTAC
{
    class Carregamento
    {
        public double Valor { get; set; }
        public int Km { get; set; }
        public double Frete { get; set; }


        public Carregamento()
        {

        }
        public Carregamento(double valor, int km)
        {
            Valor = valor;
            Km = km;
        }


        public double CalcularFrete()
        {
            if (Km <= 90)
            {
                Frete = 380;
                if (Valor > 45000.00)
                {
                    Frete = Valor * 0.009;
                }
            }
            else if ((Km > 90) && (Km <= 110))
            {
                Frete = 410;
                if (Valor > 45000.00)
                {
                    Frete = Valor * 0.01;
                }
            }
            else if ((Km > 110) && (Km <= 140))
            {
                Frete = 440;
                if (Valor > 45000.00)
                {
                    Frete = Valor * 0.011;
                }
            }
            else if ((Km > 140) && (Km <= 170))
            {
                Frete = 470;
                if (Valor > 45000.00)
                {
                    Frete = Valor * 0.012;
                }
            }
            else if ((Km > 170) && (Km <= 200))
            {
                Frete = 500;
                if (Valor > 45000.00)
                {
                    Frete = Valor * 0.013;
                }
            }
            else if ((Km > 200) && (Km <= 201))
            {
                Frete = Km * 2.5;
                if (Valor > 45000.00)
                {
                    Frete = Valor * 0.014;
                }
            }
            else if ((Km > 201) && (Km <= 230))
            {
                Frete = Km * 2.5;
                if (Valor > 45000.00)
                {
                    Frete = Valor * 0.015;
                }
            }
            else if ((Km > 230) && (Km <= 260))
            {
                Frete = Km * 2.5;
                if (Valor > 45000.00)
                {
                    Frete = Valor * 0.016;
                }
            }
            else if ((Km > 260) && (Km <= 290))
            {
                Frete = Km * 2.5;
                if (Valor > 45000.00)
                {
                    Frete = Valor * 0.017;
                }
            }
            else if ((Km > 290) && (Km <= 291))
            {
                Frete = Km * 2.4;
                if (Valor > 45000.00)
                {
                    Frete = Valor * 0.018;
                }
            }
            else if ((Km > 291) && (Km <= 310))
            {
                Frete = Km * 2.4;
                if (Valor > 45000.00)
                {
                    Frete = Valor * 0.019;
                }
            }
            else if ((Km > 310) && (Km <= 340))
            {
                Frete = Km * 2.4;
                if (Valor > 45000.00)
                {
                    Frete = Valor * 0.02;
                }
            }
            else if ((Km > 340) && (Km <= 370))
            {
                Frete = Km * 2.4;
                if (Valor > 45000.00)
                {
                    Frete = Valor * 0.021;
                }
            }
            else if ((Km > 370) && (Km <= 430))
            {
                Frete = Km * 2.4;
                if (Valor > 45000.00)
                {
                    Frete = Valor * 0.022;
                }
            }
            else
            {
                Frete = Km * 2.2;
            }
            return Frete;
        }
    }
}
