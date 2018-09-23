using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Advantech.Adam;
using Advantech.Common;
using Advantech.Protocol;
using System.Net.Sockets;

namespace SistemaParqueoSalida
{
    class AdamDevice
    {
        var int i = 0;
        var String adamOutput = "AdamOutput" + i;
        var String adaminbuffer = "AdamInput" + i;
        
        public bool connectAdam(AdamSocket adam6060, string ip, int port)
        {

            if (adam6060.Connected)
            {
                return true;
            }

            else if (adam6060.Connect(ip, ProtocolType.Tcp, port))
            {

                return true;

            }
            else
            {
                return false;
            }

        }

        public void AdamWrite(AdamSocket adam6060, int relay, bool status)
        {
            //rl goes starting at 17, true is on, false is off
            adam6060.Modbus().ForceSingleCoil(relay, status);
        }


        public void AdamOutputRead(AdamSocket adam6060)
        {


            int outindex = 17;
            bool[] outbuffer;
            try

            {
                Program.AdamOutputErrorRead = false;
                if (adam6060.Modbus().ReadCoilStatus(outindex, 6, out outbuffer))
                {

                    

                
                while i != 6 {
                if (outbuffer[i]){
                        Program.Adam = true;
                    else
                        Program.Adam = false;
                 }
                    else
                {
                    Program.AdamOutputErrorRead = true;
                }
                     i++;
                 }

                }
                


            }
            catch
            {
                Program.AdamOutputErrorRead = true;
            }
            //read ouput

        }
        public void AdamInputRead(AdamSocket adam6060)
        {

            int inindex = 1;
            bool[] inbuffer;
            try

            {
                Program.AdamInputErrorRead = false;

                if (adam6060.Modbus().ReadCoilStatus(inindex, 6, out inbuffer))
                {
                    
                    if (inbuffer[i]){
                        Program.Adam = true;
                    else
                        Program.Adam = false;
                 }
                    else
                {
                    Program.AdamInputErrorRead = true;
                }
                     i++;
                 }
                }
                }
               

            }
            catch
            {
                Program.AdamInputErrorRead = true;
            }
            //read ouput and input
        }

        public bool AdamDisconnect(AdamSocket adam6060)
        {

            if (adam6060.Connected)
            {
                adam6060.Disconnect();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
