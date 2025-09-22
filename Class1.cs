using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Construction
{
    public class Builder
    {
        ///Должен рассчитывать количество рулонов обоев, которое подходит для оклейки комнаты с определенными характеристиками
        public int PasteWallpaper(double roomLength, double roomWidth, double roomHeigth, double windowHeigth, double windowWidth, 
            double doorHeigth, double doorWidth, double WPwidth)
        {
            double result = 0;
            int perem = 0;
            double WPlength = 10.5;
            result = ((((roomHeigth * roomLength) * 2) + ((roomHeigth * roomWidth) * 2)) -
                ((windowHeigth * windowWidth) + (doorHeigth * doorWidth))) / (WPlength * WPwidth);
            ///Округление в большую сторону
            perem = (int)result;
            if (perem < result)
            {
                perem += 1;
            }
            return perem;
        }

        ///Должен рассчитать какое количество метров линолеума нужно закупить для покрытия пола в комнате определенной характеристики
        public double LayLinoleum(double roomLength, double roomWidth, double linoWidth)
        {
            double result = 0;
            result = (roomLength * roomWidth) / linoWidth;
            return result;
        }

        ///Должен рассчитать какое количество банок водоэмульсионной краски необходимое для покраски потолка комнаты
        public int CeilingPainting(double roomLength, double roomWidth, double paintСonsumption, double Vbanki)
        {
            int result = 0;
            double perem = 0;
            perem = ((roomLength * roomWidth) * paintСonsumption) / Vbanki;
            result = (int)perem;
            if (result < perem)
            {
                result += 1;
            }
            return result;
        }
    }
}
