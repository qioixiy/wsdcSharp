﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wsdcSharp
{
    class MySerialPort
    {
        static MySerialPort serialPort;
        public System.IO.Ports.SerialPort serialPortOrig;

        public List<byte> RecvBuffer;

        public MySerialPort()
        {
            serialPortOrig = new System.IO.Ports.SerialPort();
            serialPortOrig.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(DataReceived);
            RecvBuffer = new List<byte>();
        }
        public static MySerialPort Get()
        {
            if (serialPort == null)
            {
                serialPort = new MySerialPort();
            }
            return serialPort;
        }

        private int handleRecvBuffer()
        {
            return Protocal.ParserFrame(RecvBuffer);
        }

        private void DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            int i = serialPortOrig.ReadByte();

            Console.WriteLine("{0}", i);

            RecvBuffer.Add((byte)i);

            if (RecvBuffer.Count >= 6)
            {
                int ret = handleRecvBuffer();
                if (ret > 0)
                {
                    // handle
                    Console.Write("a frame");
                    RecvBuffer.RemoveRange(0, ret);
                }
                else
                {
                    ;
                }
            }
        }
        public bool SendFrame(Protocal.Frame frame)
        {
            List<byte> listByte = Protocal.FrameToListByte(frame);
            byte[] bytes = Protocal.ListByteToBytes(listByte);
            MySerialPort.Get().serialPortOrig.Write(bytes, 0, bytes.Length);
            return true;
        }

        public bool SendFrameTest()
        {
            byte[] bs = {System.Convert.ToByte('d'), System.Convert.ToByte('e')};
            Protocal.Frame frame = Protocal.MakeFrame(
                System.Convert.ToByte('a'),
                System.Convert.ToByte('b'),
                System.Convert.ToByte('c'), bs);
            
            return SendFrame(frame);
        }
    }
}
