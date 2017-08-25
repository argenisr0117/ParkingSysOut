using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaParqueoSalida
{
    class ChooseInputOuputAdam
    {
        public bool CheckInputLoopSalida()
        {
            if (Program.LoopSalidaInput == "1")
            {
                return Program.AdamInput1;
            }

            else if (Program.LoopSalidaInput == "2")
            {
                return Program.AdamInput2;
            }

            else if (Program.LoopSalidaInput == "3")
            {
                return Program.AdamInput3;
            }

            else if (Program.LoopSalidaInput == "4")
            {
                return Program.AdamInput4;
            }

            else if (Program.LoopSalidaInput == "5")
            {
                return Program.AdamInput5;
            }

            else
            {
                return Program.AdamInput6;
            }
        }

        public int CheckOutputAbrirBrazo()
        {
            if (Program.AbrirBrazoOutput == "1")
            {
                return 1;
            }

            else if (Program.AbrirBrazoOutput == "2")
            {
                return 2;
            }

            else if (Program.AbrirBrazoOutput == "3")
            {
                return 3;
            }

            else if (Program.AbrirBrazoOutput == "4")
            {
                return 4;
            }

            else if (Program.AbrirBrazoOutput == "5")
            {
                return 5;
            }

            else
            {
                return 6;
            }


        }
    }
}
