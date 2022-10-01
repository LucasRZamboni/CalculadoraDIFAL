using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIFAL
{
    class calculos
    {

        public static void Cálculo5()
        {
            Global.pre_difal = Global.valor_icms * Global.calculo5;
            Global.difal = Global.pre_difal;
        }
        public static void Cálculo6()
        {
            Global.pre_difal = Global.valor_icms * Global.calculo6;
            Global.difal = Global.pre_difal;
        }
        public static void Cálculo6rj()
        {
            Global.pre_difal = Global.valor_icms * Global.calculo6;
            Global.valor_fcp = Global.valor_icms * Global.fcp2;
            Global.difal = Global.pre_difal + Global.valor_fcp;
        }
        public static void Cálculo10()
        {
            Global.pre_difal = Global.valor_icms * Global.calculo10;
            Global.difal = Global.pre_difal;
        }
        public static void Cálculo10pi()
        {
            Global.pre_difal = Global.valor_icms * Global.calculo10;
            Global.valor_fcp = Global.valor_icms * Global.fcp1;
            Global.difal = Global.pre_difal + Global.valor_fcp;
        }
        public static void Cálculo11()
        {
            Global.pre_difal = Global.valor_icms * Global.calculo11;
            Global.difal = Global.pre_difal;
        }

        public static void Cálculo12_18()
        {
            /*
            Global.icms_interestadual = Global.valor_icms * Global.aliq_calculo12;
            Global.base_calculo1 = Global.valor_icms - Global.icms_interestadual;
            Global.base_calculo2 = Global.base_calculo1 / (1 - Global.calculo18);
            Global.icms_interno = Global.base_calculo2 * Global.calculo18;
            Global.difal =  Global.icms_interno - Global.icms_interestadual;
            */

            Global.icms_interestadual = Global.valor_icms * Global.calculo12;
            Global.valor_fcp = Global.fcp2 * Global.valor_icms;
            Global.pre_difal = Global.icms_interestadual;
            Global.difal = Global.icms_interestadual - Global.valor_fcp;
        }
        public static void Cálculo7_17()
        {
            /*
             Global.icms_interestadual = Global.valor_icms * Global.calculo7;
             Global.base_calculo1 = Global.valor_icms - Global.icms_interestadual;
             Global.base_calculo2 = Global.base_calculo1 / (1 - Global.calculo17);
             Global.icms_interno = Global.base_calculo2 * Global.calculo17;
             Global.difal =  Global.icms_interno - Global.icms_interestadual;
            */

            Global.base_prtilha = Global.valor_icms / (1 - (Global.calculo17 + Global.fcp3));
            Global.icms_interestadual = Global.valor_icms * Global.calculo7;
            Global.difal = (Global.base_prtilha * (Global.calculo17 + Global.fcp3)) - Global.icms_interestadual - Global.fcp3;

            Global.pre_difal = Global.icms_interestadual;
            Global.valor_fcp = Global.fcp3;

        }
        public static void Cálculo7_18()
        {
            /*
             Global.icms_interestadual = Global.valor_icms * Global.calculo7;
             Global.base_calculo1 = Global.valor_icms - Global.icms_interestadual;
             Global.base_calculo2 = Global.base_calculo1 / (1 - Global.calculo17);
             Global.icms_interno = Global.base_calculo2 * Global.calculo17;
             Global.difal =  Global.icms_interno - Global.icms_interestadual;
            */

            Global.base_prtilha = Global.valor_icms / (1 - (Global.calculo18 + Global.fcp3));
            Global.icms_interestadual = Global.valor_icms * Global.calculo7;
            Global.difal = (Global.base_prtilha * (Global.calculo18 + Global.fcp3)) - Global.icms_interestadual - Global.fcp3;

            Global.pre_difal = Global.icms_interestadual;
            Global.valor_fcp = Global.fcp3;

        }

        public static void Cálculomg()
        {
            
            Global.icms_interestadual = Global.valor_icms * Global.aliq_interestadual;
            Global.base_prtilha = Global.valor_icms / (1 - (Global.calculo18 + Global.fcp3));
            Global.difal = (Global.base_prtilha * (Global.calculo18 + Global.fcp3)) - Global.icms_interestadual - Global.fcp3;
            Global.pre_difal = Global.icms_interestadual;
            

            

        }
    }
}
