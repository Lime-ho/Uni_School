using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Dohune.Helpers
{
    public class ReceiptHelpers
    {

        public int bugerPrice(string bugerName, string singleOrsingle)
        {
            int price = 0;
            if(bugerName == "치즈버거")
            {
                if(singleOrsingle == "single")
                {
                    price = 3500;
                }
                else
                {
                    price = 6000;
                }
            }
            else if(bugerName == "치킨버거")
            {
                if (singleOrsingle == "single")
                {
                    price = 4300;
                }
                else
                {
                    price = 6500;
                }
            }
            else if (bugerName == "상하이버거")
            {
                if (singleOrsingle == "single")
                {
                    price = 6000;
                }
                else
                {
                    price = 7800;
                }
            }
            else if (bugerName == "새우버거")
            {
                if (singleOrsingle == "single")
                {
                    price = 6600;
                }
                else
                {
                    price = 9100;
                }
            }
            else if (bugerName == "더블쿼터버거")
            {
                if (singleOrsingle == "single")
                {
                    price = 8200;
                }
                else
                {
                    price = 10400;
                }
            }
            else if (bugerName == "베이컨토마토버거")
            {
                if (singleOrsingle == "single")
                {
                    price = 6600;
                }
                else
                {
                    price = 8700;
                }
            }
            else if (bugerName == "빅맥버거")
            {
                if (singleOrsingle == "single")
                {
                    price = 6000;
                }
                else
                {
                    price = 7800;
                }
            }
            else if (bugerName == "1955버거")
            {
                if (singleOrsingle == "single")
                {
                    price = 7200;
                }
                else
                {
                    price = 8800;
                }
            }
            else if (bugerName == "불고기버거")
            {
                if (singleOrsingle == "single")
                {
                    price = 3600;
                }
                else
                {
                    price = 5800;
                }
            }

            return price;
        }


        public int dessertPrice(string dessertName)
        {
            int price = 0;
            if(dessertName == "감자튀김")
            {
                price = 2800;
            }
            else if(dessertName == "맥윙")
            {
                price = 4000;
            }
            else if (dessertName == "치즈스틱")
            {
                price = 3300;
            }
            else if (dessertName == "비프 스낵랩")
            {
                price = 3200;
            }
            else if (dessertName == "치킨 스낵랩")
            {
                price = 3500;
            }
            else if (dessertName == "오레오 맥플러리")
            {
                price = 3700;
            }

            return price;
        }

        public int drinkPrice(string drinkName) 
        {
            int price = 0;
            if(drinkName == "바닐라쉐이크")
            {
                price = 3500;
            }
            else if(drinkName == "아메리카노")
            {
                price = 1500;
            }
            else if (drinkName == "콜라")
            {
                price = 1500;
            }
            return price;
        }
    }
}
