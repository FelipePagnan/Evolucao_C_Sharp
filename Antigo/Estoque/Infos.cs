using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque
{
    class Infos
    {
        public string nome;

        //anti erro, ou era pra ser
        public string item0 = "nada";
        public int quant0 = 0;

        public string item1, item2, item3, item4, item5, 
            item6, item7, item8, item9, item10, item11, 
            item12, item13, item14, item15, item16, item17, 
            item18, item19, item20;

        public int quant1, quant2, quant3, quant4, quant5, 
            quant6, quant7, quant8, quant9, quant10, quant11, 
            quant12, quant13, quant14, quant15, quant16, quant17, 
            quant18, quant19, quant20;

        //guias de - +
        public int guiaAdd;
        public int guiaSub;

        //removendo item, zerando
        public double removerItem(int idR)
        {

            if(idR == 1)
            {
                quant1 = quant1 * 0;
                return quant1;
            }
            else if(idR == 2)
            {
                quant2 = quant2 * 0;
                return quant2;
            }
            else if(idR == 3)
            {
                quant3 = quant3 * 0;
                return quant3;
            }
            else if(idR == 4)
            {
                quant4 = quant4 * 0;
                return quant4;
            }
            else if(idR == 5)
            {
                quant5 = quant5 * 0;
                return quant5;
            }
            else if(idR == 6)
            {
                quant6 = quant6 * 0;
                return quant6;
            }
            else if(idR == 7)
            {
                quant7 = quant7 * 0;
                return quant7;
            }
            else if(idR == 8)
            {
                quant8 = quant8 * 0;
                return quant8;
            }
            else if(idR == 9)
            {
                quant9 = quant9 * 0;
                return quant9;
            }
            else if(idR == 10)
            {
                quant10 = quant10 * 0;
                return quant10;
            }
            else if(idR == 11)
            {
                quant11 = quant11 * 0;
                return quant11;
            }
            else if(idR == 12)
            {
                quant12 = quant12 * 0;
                return quant12;
            }
            else if(idR == 13)
            {
                quant13 = quant13 * 0;
                return quant13;
            }
            else if(idR == 14)
            {
                quant14 = quant14 * 0;
                return quant14;
            }
            else if(idR == 15)
            {
                quant15 = quant15 * 0;
                return quant15;
            }
            else if(idR == 16)
            {
                quant16 = quant16 * 0;
                return quant16;
            }
            else if(idR == 17)
            {
                quant17 = quant17 * 0;
                return quant17;
            }
            else if(idR == 18)
            {
                quant18 = quant18 * 0;
                return quant18;
            }
            else if(idR == 19)
            {
                quant19 = quant19 * 0;
                return quant19;
            }
            else if(idR == 20)
            {
                quant20 = quant20* 0;
                return quant20;
            }
            else
            {
                quant0 = quant0 * 0;
                return quant0;
            }

        }

        //atualização de valores do estoque

        //adicição de item
        public double addItem(int idC)
        {
            if(guiaAdd == 1)
            {
                quant1 = quant1 + idC;
                return quant1;
            }
            else if (guiaAdd == 2)
            {
                quant2 = quant2 + idC;
                return quant2;
            }
            else if (guiaAdd == 3)
            {
                quant3 = quant3 + idC;
                return quant3;
            }
            else if (guiaAdd == 4)
            {
                quant4 = quant4 + idC;
                return quant4;
            }
            else if (guiaAdd == 5)
            {
                quant5 = quant5 + idC;
                return quant5;
            }
            else if (guiaAdd == 6)
            {
                quant6 = quant6 + idC;
                return quant6;
            }
            else if (guiaAdd == 7)
            {
                quant7 = quant7 + idC;
                return quant7;
            }
            else if (guiaAdd == 8)
            {
                quant8 = quant8 + idC;
                return quant8;
            }
            else if (guiaAdd == 9)
            {
                quant9 = quant9 + idC;
                return quant9;
            }
            else if (guiaAdd == 10)
            {
                quant10 = quant10 + idC;
                return quant10;
            }
            else if (guiaAdd == 11)
            {
                quant11 = quant11 + idC;
                return quant11;
            }
            else if (guiaAdd == 12)
            {
                quant12 = quant12 + idC;
                return quant12;
            }
            else if (guiaAdd == 13)
            {
                quant13 = quant13 + idC;
                return quant13;
            }
            else if (guiaAdd == 14)
            {
                quant14 = quant14 + idC;
                return quant14;
            }
            else if (guiaAdd == 15)
            {
                quant15 = quant15 + idC;
                return quant15;
            }
            else if (guiaAdd == 16)
            {
                quant16 = quant16 + idC;
                return quant16;
            }
            else if (guiaAdd == 17)
            {
                quant17 = quant17 + idC;
                return quant17;
            }
            else if (guiaAdd == 18)
            {
                quant18 = quant18 + idC;
                return quant18;
            }
            else if (guiaAdd == 19)
            {
                quant19 = quant19 + idC;
                return quant19;
            }
            else if (guiaAdd == 20)
            {
                quant20 = quant20 + idC;
                return quant20;
            }
            else
            {
                quant0 = quant0 + idC;
                return quant0;
            }
        }


        //subtração de item
        
        public double subItem(int idS)
        {
            if(guiaSub == 1)
            {
                quant1 = quant1 - idS;
                if(quant1 <= 0)
                {
                    quant1 = quant1 * 0;
                    return quant1;
                }
                else
                {
                    return quant1;
                }
            }
            else if (guiaSub == 2)
            {
                quant2 = quant2 - idS;
                if (quant2 <= 0)
                {
                    quant2 = quant2 * 0;
                    return quant2;
                }
                else
                {
                    return quant2;
                }
            }
            else if (guiaSub == 3)
            {
                quant3 = quant3 - idS;
                if (quant3 <= 0)
                {
                    quant3 = quant3 * 0;
                    return quant3;
                }
                else
                {
                    return quant3;
                }
            }
            else if (guiaSub == 4)
            {
                quant4 = quant4 - idS;
                if (quant4 <= 0)
                {
                    quant4 = quant4 * 0;
                    return quant4;
                }
                else
                {
                    return quant4;
                }
            }
            else if (guiaSub == 5)
            {
                quant5 = quant5 - idS;
                if (quant5 <= 0)
                {
                    quant5 = quant5 * 0;
                    return quant5;
                }
                else
                {
                    return quant5;
                }
            }
            else if (guiaSub == 6)
            {
                quant6 = quant6 - idS;
                if (quant6 <= 0)
                {
                    quant6 = quant6 * 0;
                    return quant6;
                }
                else
                {
                    return quant6;
                }
            }
            else if (guiaSub == 7)
            {
                quant7 = quant7 - idS;
                if (quant7 <= 0)
                {
                    quant7 = quant7 * 0;
                    return quant7;
                }
                else
                {
                    return quant7;
                }
            }
            else if (guiaSub == 8)
            {
                quant8 = quant8 - idS;
                if (quant8 <= 0)
                {
                    quant8 = quant8 * 0;
                    return quant8;
                }
                else
                {
                    return quant8;
                }
            }
            else if (guiaSub == 9)
            {
                quant9 = quant9 - idS;
                if (quant9 <= 0)
                {
                    quant9 = quant9 * 0;
                    return quant9;
                }
                else
                {
                    return quant9;
                }
            }
            else if (guiaSub == 10)
            {
                quant10 = quant10 - idS;
                if (quant10 <= 0)
                {
                    quant10 = quant10 * 0;
                    return quant10;
                }
                else
                {
                    return quant10;
                }
            }
            else if (guiaSub == 11)
            {
                quant11 = quant11 - idS;
                if (quant11 <= 0)
                {
                    quant11 = quant11 * 0;
                    return quant1;
                }
                else
                {
                    return quant11;
                }
            }
            else if (guiaSub == 12)
            {
                quant12 = quant12 - idS;
                if (quant12 <= 0)
                {
                    quant12 = quant12 * 0;
                    return quant12;
                }
                else
                {
                    return quant12;
                }
            }
            else if (guiaSub == 13)
            {
                quant13 = quant13 - idS;
                if (quant13 <= 0)
                {
                    quant13 = quant13 * 0;
                    return quant13;
                }
                else
                {
                    return quant13;
                }
            }
            else if (guiaSub == 14)
            {
                quant14 = quant14 - idS;
                if (quant14 <= 0)
                {
                    quant14 = quant14 * 0;
                    return quant14;
                }
                else
                {
                    return quant14;
                }
            }
            else if (guiaSub == 15)
            {
                quant15 = quant15 - idS;
                if (quant15 <= 0)
                {
                    quant15 = quant15 * 0;
                    return quant15;
                }
                else
                {
                    return quant15;
                }
            }
            else if (guiaSub == 16)
            {
                quant16 = quant16 - idS;
                if (quant16 <= 0)
                {
                    quant16 = quant16 * 0;
                    return quant16;
                }
                else
                {
                    return quant16;
                }
            }
            else if (guiaSub == 17)
            {
                quant17 = quant17 - idS;
                if (quant17 <= 0)
                {
                    quant17 = quant17 * 0;
                    return quant17;
                }
                else
                {
                    return quant17;
                }
            }
            else if (guiaSub == 18)
            {
                quant18 = quant18 - idS;
                if (quant18 <= 0)
                {
                    quant18 = quant18 * 0;
                    return quant18;
                }
                else
                {
                    return quant18;
                }
            }
            else if (guiaSub == 19)
            {
                quant19 = quant19 - idS;
                if (quant19 <= 0)
                {
                    quant19 = quant19 * 0;
                    return quant19;
                }
                else
                {
                    return quant19;
                }
            }
            else if (guiaSub == 20)
            {
                quant20 = quant20 - idS;
                if (quant20 <= 0)
                {
                    quant20 = quant20 * 0;
                    return quant20;
                }
                else
                {
                    return quant20;
                }
            }
            else
            {
                quant0 = quant0 * 0;
                return quant0;
            }
        }


    }
}
