﻿using System;
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

                if (adam6060.Modbus().ReadCoilStatus(outindex, 6, out outbuffer))
                {

                    Program.AdamInputErrorRead = false;

                    if (outbuffer[0])
                        Program.AdamOutput1 = true;
                    else
                        Program.AdamOutput1 = false;

                    if (outbuffer[1])
                        Program.AdamOutput2 = true;
                    else
                        Program.AdamOutput2 = false;

                    if (outbuffer[2])
                        Program.AdamOutput3 = true;
                    else
                        Program.AdamOutput3 = false;

                    if (outbuffer[3])
                        Program.AdamOutput4 = true;
                    else
                        Program.AdamOutput4 = false;

                    if (outbuffer[4])
                        Program.AdamOutput5 = true;
                    else
                        Program.AdamOutput5 = false;

                    if (outbuffer[5])
                        Program.AdamOutput6 = true;
                    else
                        Program.AdamOutput6 = false;

                }
                else
                {
                    Program.AdamOutputErrorRead = true;
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


                if (adam6060.Modbus().ReadCoilStatus(inindex, 6, out inbuffer))
                {
                    Program.AdamInputErrorRead = false;
                    if (inbuffer[0])
                        Program.AdamInput1 = false;
                    else
                        Program.AdamInput1 = true;

                    if (inbuffer[1])
                        Program.AdamInput2 = false;
                    else
                        Program.AdamInput2 = true;

                    if (inbuffer[2])
                        Program.AdamInput3 = false;
                    else
                        Program.AdamInput3 = true;

                    if (inbuffer[3])
                        Program.AdamInput4 = false;
                    else
                        Program.AdamInput4 = true;

                    if (inbuffer[4])
                        Program.AdamInput5 = false;
                    else
                        Program.AdamInput5 = true;

                    if (inbuffer[5])
                        Program.AdamInput6 = false;
                    else
                        Program.AdamInput6 = true;
                }
                else
                {
                    Program.AdamInputErrorRead = true;
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
