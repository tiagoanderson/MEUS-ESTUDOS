namespace Calculadora
{
    class Impostos
    {
        public double Proventos = 0;
        public double Descontos = 0;
        public double ValorDepen;
        public double ValorDeducao;
        public double QtdDepend;
        public double ValorInss;
        public double ValorIr;
        public double ValorBaseInss;
        public double ValorBaseIr;
        public double faixa1;
        public double faixa2;
        public double faixa3;
        public double faixa4;
        public double ValorFaixa7_5 = 1100.00;
        public double ValorFaixa9 = 1103.48;
        public double ValorFaixa12 = 1101.73;
        public double ValorFaixa14 = 3128.34;
        public double ValorBase;



        public Impostos()
        {
        }






        // atribiur valor QtdDepente

        public void QtdDependente(double qtddependete)
        {
            QtdDepend = qtddependete;
        }





        public void VLProventos(double proventos) => Proventos = proventos;


        public void VLDesconto(double descontos) => Descontos = descontos;


        // atribuir valor BaseInss
        public void VLBaseInss() => ValorBaseInss = Proventos - Descontos;

        // calculo do imposto

        public void VLInss()
        {
            if (ValorBaseInss <= 1100.00)

            {
                ValorFaixa7_5 = ValorBaseInss;
                faixa1 = (ValorFaixa7_5 / 100 * 7.5);
                ValorInss = faixa1;
                faixa2 = 0;
                faixa3 = 0;
                faixa4 = 0;
                ValorFaixa9 = 0;
                ValorFaixa12 = 0;
                ValorFaixa14 = 0;

            }

            else if (ValorBaseInss >= 1100.01 && ValorBaseInss <= 2203.48)
            {
                //faixa1
                faixa1 = ValorFaixa7_5 / 100 * 7.5;

                //faixa2
                ValorFaixa9 = ValorBaseInss - ValorFaixa7_5;
                faixa2 = ValorFaixa9 / 100 * 9;
                //ValorInss e zerando faixas 
                ValorInss = faixa2 + faixa1;
                faixa3 = 0;
                faixa4 = 0;
                ValorFaixa12 = 0;
                ValorFaixa14 = 0;

            }

            else if (ValorBaseInss >= 2203.49 && ValorBaseInss <= 3305.22)
            {

                //faixa1
                faixa1 = ValorFaixa7_5 / 100 * 7.5;

                //faixa2
                faixa2 = (ValorFaixa9) / 100 * 9;

                //faixa3
                ValorFaixa12 = ValorBaseInss - (ValorFaixa7_5 + ValorFaixa9);
                faixa3 = ValorFaixa12 / 100 * 12;

                //ValorInss e zerando faixas 
                ValorInss = faixa3 + faixa2 + faixa1;
                faixa4 = 0;
                ValorFaixa14 = 0;


            }




            else if (ValorBaseInss >= 3305.23 && ValorBaseInss <= 6433.57)
            {
                //faixa1
                faixa1 = ValorFaixa7_5 / 100 * 7.5;

                //faixa2
                faixa2 = (ValorFaixa9) / 100 * 9;

                //faixa3
                faixa3 = ValorFaixa12 / 100 * 12;

                //faixa4
                ValorFaixa14 = ValorBaseInss - (ValorFaixa7_5 + ValorFaixa9 + ValorFaixa12);
                faixa4 = ValorFaixa14 / 100 * 14;
                //ValorInss e zerando faixas 
                ValorInss = faixa4 + faixa3 + faixa2 + faixa1;


            }



            else
            {

                //faixa1
                faixa1 = ValorFaixa7_5 / 100 * 7.5;

                //faixa2
                faixa2 = (ValorFaixa9) / 100 * 9;

                //faixa3
                faixa3 = ValorFaixa12 / 100 * 12;

                //faixa4
                faixa4 = ValorFaixa14 / 100 * 14;
                //ValorInss e zerando faixas 
                ValorInss = faixa4 + faixa3 + faixa2 + faixa1;




            }




        }














    }





}












