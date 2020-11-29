using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class ComPort
    {
        //static SerialPort port = connectToPort();
        static void logicFunc()
        {
            SerialPort port = connectToPort();
            if (port != null)
            {
                //Thread.Sleep(1000);
                string a = read(port, 'a', 3).ToString();

                port.Close();
            }
        }
        static char[] read(SerialPort port, char startByte, int count)
        {
            char[] ch = new char[count];
            if (port.IsOpen)
            {
                int buferSize = port.BytesToRead;
                bool startRead = false;
                int a = 0;
                for (int i = 0; i < buferSize; ++i)
                {
                    //  читаем по одному байту
                    char bt = (char)port.ReadByte();
                    if (bt == startByte)
                    {
                        startRead = true;
                    }
                    if (startRead)
                    {
                        if (a < count)
                        {
                            ch[a] = bt;
                            a++;
                        }
                    }
                }
            }
            return ch;
        }

        internal bool waitForPayment()
        {
            int i = 60;
            while(i > 0)
            { 
                Thread.Sleep(2000);
                //if(read(port, 'b', 3)[0] == '1'){
                return true;
                //}
               
            }
            return false;
        }

        internal bool writePrice(string price, char way)
        {
            //SerialPort port = connectToPort();
            int controlSum = 0;
            string str = "aa" + price + "w" + way;
            for (int i = 0; i < str.Length; i++)
            {
                controlSum = controlSum + (int)str[i];
            }
            str = str + (char)controlSum;
            //write(port, str);
            //read(port, 'a', 3);
            //if(read(port, 'a', 3)[0] = '1'){
            return true;
        //}
        //else
            //{
          //      return false;
            //}
        }
        static void write(SerialPort port, string toCOM)
        {
            try
            {
                port.Write(toCOM);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        static SerialPort connectToPort()
        {
            SerialPort port = new SerialPort();
            string[] ports = SerialPort.GetPortNames();
            if (ports.Length != 0)
            {
                try
                {
                    port.PortName = "COM7";
                    port.BaudRate = 9600;
                    port.DataBits = 8;
                    port.Parity = System.IO.Ports.Parity.None;
                    port.StopBits = System.IO.Ports.StopBits.One;
                    port.ReadTimeout = 1000;
                    port.WriteTimeout = 1000;
                    port.Open();
                    return port;
                }
                catch (Exception e)
                {
                    sendErrorToLogFile("ERROR: невозможно открыть порт:" + e.ToString());
                    return null;
                }
            }
            sendErrorToLogFile("No COMPort");
            return null;
        }
        static void sendErrorToLogFile(string txt)
        {

            using (StreamWriter sw = new StreamWriter("log.txt", true))
            {
                sw.WriteLine(txt);
            }
        }
    }
}
