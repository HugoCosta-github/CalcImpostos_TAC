

namespace CalculadoraFretesTAC
{
    class Carregamento
    {
        public double Valor { get; set; }
        public int Km { get; set; }
        public string TipoFrete { get; set; }
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
            {
                if(TipoFrete == "TAC")
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
                    else if ((Km > 200) && (Km <= 230))
                    {
                        Frete = Km * 2.5;
                        if (Valor > 45000.00)
                        {
                            Frete = Valor * 0.014;
                        }
                    }
                    else if ((Km > 230) && (Km <= 260))
                    {
                        Frete = Km * 2.5;
                        if (Valor > 45000.00)
                        {
                            Frete = Valor * 0.015;
                        }
                    }
                    else if ((Km > 260) && (Km <= 290))
                    {
                        Frete = Km * 2.5;
                        if (Valor > 45000.00)
                        {
                            Frete = Valor * 0.016;
                        }
                    }
                    else if ((Km > 290) && (Km <= 310))
                    {
                        Frete = Km * 2.5;
                        if (Valor > 45000.00)
                        {
                            Frete = Valor * 0.017;
                        }
                    }
                    else if ((Km > 310) && (Km <= 340))
                    {
                        Frete = Km * 2.4;
                        if (Valor > 45000.00)
                        {
                            Frete = Valor * 0.018;
                        }
                    }
                    else if ((Km > 340) && (Km <= 370))
                    {
                        Frete = Km * 2.4;
                        if (Valor > 45000.00)
                        {
                            Frete = Valor * 0.019;
                        }
                    }
                    else if ((Km > 370) && (Km <= 450))
                    {
                        Frete = Km * 2.4;
                        if (Valor > 45000.00)
                        {
                            Frete = Valor * 0.02;
                        }
                    }
                    else
                    {
                        Frete = Km * 2.2;
                    }
                    
                }
                else
                {
                    if (Km <= 90)
                    {
                        Frete = 399;
                        if (Valor > 45000.00)
                        {
                            Frete = Valor * 0.0095;
                        }
                    }
                    else if ((Km > 90) && (Km <= 110))
                    {
                        Frete = 430.50;
                        if (Valor > 45000.00)
                        {
                            Frete = Valor * 0.0105;
                        }
                    }
                    else if ((Km > 110) && (Km <= 140))
                    {
                        Frete = 462;
                        if (Valor > 45000.00)
                        {
                            Frete = Valor * 0.0115;
                        }
                    }
                    else if ((Km > 140) && (Km <= 170))
                    {
                        Frete = 493.50;
                        if (Valor > 45000.00)
                        {
                            Frete = Valor * 0.0125;
                        }
                    }
                    else if ((Km > 170) && (Km <= 200))
                    {
                        Frete = 525;
                        if (Valor > 45000.00)
                        {
                            Frete = Valor * 0.0135;
                        }
                    }
                    else if ((Km > 200) && (Km <= 230))
                    {
                        Frete = Km * 2.62;
                        if (Valor > 45000.00)
                        {
                            Frete = Valor * 0.0145;
                        }
                    }
                    else if ((Km > 230) && (Km <= 260))
                    {
                        Frete = Km * 2.62;
                        if (Valor > 45000.00)
                        {
                            Frete = Valor * 0.0155;
                        }
                    }
                    else if ((Km > 260) && (Km <= 290))
                    {
                        Frete = Km * 2.62;
                        if (Valor > 45000.00)
                        {
                            Frete = Valor * 0.0165;
                        }
                    }
                    else if ((Km > 290) && (Km <= 310))
                    {
                        Frete = Km * 2.52;
                        if (Valor > 45000.00)
                        {
                            Frete = Valor * 0.0175;
                        }
                    }
                    else if ((Km > 310) && (Km <= 340))
                    {
                        Frete = Km * 2.52;
                        if (Valor > 45000.00)
                        {
                            Frete = Valor * 0.0185;
                        }
                    }
                    else if ((Km > 340) && (Km <= 370))
                    {
                        Frete = Km * 2.52;
                        if (Valor > 45000.00)
                        {
                            Frete = Valor * 0.0195;
                        }
                    }
                    else if ((Km > 370) && (Km <= 450))
                    {
                        Frete = Km * 2.52;
                        if (Valor > 45000.00)
                        {
                            Frete = Valor * 0.0205;
                        }
                    }
                    else
                    {
                        Frete = Km * 2.2;
                    }
                }
                return Frete;
            }
            
        }
    }
}
