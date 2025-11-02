using System;
using System.IO.Ports;
using System.Threading;
using System.Text;

public class Logical_Name
{
    // Main method
    public static void Main(string[] args)

    {
        logicalName();
    }

    // Delay function
    public static void Wait(TimeSpan delayTime)
    {
        DateTime startTime = DateTime.Now;
        while (DateTime.Now - startTime < delayTime)
        {
            // Do nothing
        }
    }


    public static void logicalName()
    {
        // Set up the serial port connection
        SerialPort serialPort = new SerialPort("COM1", 9600, Parity.None, 8, StopBits.One);
        serialPort.ReadTimeout = 6000;
        serialPort.WriteTimeout = 6000;

        TimeSpan delay = TimeSpan.FromSeconds(5);

        serialPort.Open();
        Console.WriteLine("starting...");

        // Selective access request commands begin

        // Send a DLMS/COSEM protocol request
        byte[] request = new byte[] { 0x7E, 0xA0, 0x20, 0x03, 0x03, 0x93, 0xFE, 0xC9, 0x81, 0x80, 0x14, 0x05, 0x02,
        0x05, 0x00, 0x06, 0x02, 0x05, 0x00, 0x07, 0x04, 0x00, 0x00, 0x00, 0x01, 0x08, 0x04, 0x00, 0x00, 0x00,
        0x01, 0x7F, 0x65, 0x7E };

        // Send the message to the metering device
        serialPort.Write(request, 0, request.Length);

        Console.WriteLine("req : " + BitConverter.ToString(request) + " sent ");

        // Wait for 5 seconds
        Wait(delay);


        // Getting response
        byte[] response = new byte[1024];
        Console.WriteLine("Waiting...");

        // Read the response data into the byte array
        int bytesRead = serialPort.Read(response, 0, response.Length);

        // Print the response data as a hexadecimal string
        string responseHex = BitConverter.ToString(response, 0, bytesRead);
        Console.WriteLine("Response: " + responseHex + Environment.NewLine);

        // Selective access request commands end


        // Association request commands begin

        // Send a DLMS/COSEM protocol request
        byte[] request2 = new byte[] { 0x7E, 0xA0, 0x44, 0x03, 0x03, 0x10, 0x65, 0x94, 0xE6,
        0xE6, 0x00, 0x60, 0x36, 0xA1, 0x09, 0x06, 0x07, 0x60, 0x85, 0x74, 0x05, 0x08,
        0x01, 0x01, 0x8A, 0x02, 0x07, 0x80, 0x8B, 0x07, 0x60, 0x85, 0x74, 0x05, 0x08,
        0x02, 0x01, 0xAC, 0x0A, 0x80, 0x08, 0x31, 0x32, 0x33, 0x34, 0x35, 0x36, 0x37,
        0x38, 0xBE, 0x10, 0x04, 0x0E, 0x01, 0x00, 0x00, 0x00, 0x06, 0x5F, 0x1F, 0x04,
        0x00, 0xFF, 0xFF, 0xFF, 0x04, 0xFD, 0x1F, 0xA1, 0x7E };

        serialPort.Write(request2, 0, request2.Length);

        Console.WriteLine("req : " + BitConverter.ToString(request2) + " sent ");

        // Wait for 5 seconds
        Wait(delay);

        // Getting response
        byte[] response1 = new byte[1024];
        Console.WriteLine("Waiting...");

        // Read the response data into the byte array
        int bytesRead1 = serialPort.Read(response1, 0, response1.Length);

        // Print the response data as a hexadecimal string
        string responseHex1 = BitConverter.ToString(response1, 0, bytesRead1);
        Console.WriteLine("Response: " + responseHex1 + Environment.NewLine);

        // Association request commands end


        // Get1 request command begin

        // Send a DLMS/COSEM protocol request
        byte[] request3 = new byte[] { 0x7E, 0xA0, 0x19, 0x03, 0x03, 0x32, 0xEC, 0xC8, 0xE6, 0xE6, 0x00,
        0xC0, 0x01, 0x41, 0x00, 0x01, 0x00, 0x00, 0x2A, 0x00, 0x00, 0xFF, 0x01, 0x00, 0x61, 0x38, 0x7E };

        serialPort.Write(request3, 0, request3.Length);

        Console.WriteLine("req : " + BitConverter.ToString(request3) + " sent ");

        // Wait for 5 seconds
        Wait(delay);

        // Getting response
        byte[] response2 = new byte[1024];
        Console.WriteLine("Waiting...");

        // Read the response data into the byte array
        int bytesRead2 = serialPort.Read(response2, 0, response2.Length);

        // Print the response data as a hexadecimal string
        string responseHex2 = BitConverter.ToString(response2, 0, bytesRead2);
        Console.WriteLine("Response: " + responseHex2 + Environment.NewLine);

        // Get1 request command end 


        // Get2 request command begin

        // Send a DLMS/COSEM protocol request
        byte[] request4 = new byte[] { 0x7E, 0xA0, 0x19, 0x03, 0x03, 0x54, 0xDC, 0xCE, 0xE6, 0xE6, 0x00, 0xC0,
        0x01, 0x41, 0x00, 0x01, 0x00, 0x00, 0x2A, 0x00, 0x00, 0xFF, 0x02, 0x00, 0x09, 0x12, 0x7E };

        serialPort.Write(request4, 0, request4.Length);

        Console.WriteLine("req : " + BitConverter.ToString(request4) + " sent ");

        // Wait for 5 seconds
        Wait(delay);

        // Getting response
        byte[] response3 = new byte[1024];
        Console.WriteLine("Waiting...");

        // Read the response data into the byte array
        int bytesRead3 = serialPort.Read(response3, 0, response3.Length);

        // Print the response data as a hexadecimal string
        string responseHex3 = BitConverter.ToString(response3, 0, bytesRead3);
        Console.WriteLine("Response: " + responseHex3 + Environment.NewLine);

        // Get2 request command end 


        // Release request command begin

        // Send a DLMS/COSEM protocol request
        byte[] request5 = new byte[] { 0x7E, 0xA0, 0x07, 0x03, 0x03, 0x53, 0x80, 0xD7, 0x7E };

        serialPort.Write(request5, 0, request5.Length);

        Console.WriteLine("req : " + BitConverter.ToString(request5) + " sent ");

        // Wait for 5 seconds
        Wait(delay);

        // Getting response   
        byte[] response4 = new byte[1024];
        Console.WriteLine("Waiting...");

        // Read the response data into the byte array
        int bytesRead4 = serialPort.Read(response4, 0, response4.Length);

        // Print the response data as a hexadecimal string
        string responseHex4 = BitConverter.ToString(response4, 0, bytesRead4);
        Console.WriteLine("Response: " + responseHex4 + Environment.NewLine);

        // Release request command end


        // Close the serial port connection
        serialPort.Close();
    }
}





// SIMULATOR
public class Logical_Name_Simulator
{

    // Main method
    public static void Logical_Name_Simulator_Main()
    {
        LogicalNameSimulator();
    }

    // Simulate the conversation between the device and the program
    public static void LogicalNameSimulator()
    {
        // Frame 1
        byte[] sendFrame1 = new byte[]
        {
            0x7E, 0xA0, 0x20, 0x03, 0x03, 0x93, 0xFE, 0xC9, 0x81, 0x80, 0x14, 0x05, 0x02, 0x05,
            0x00, 0x06, 0x02, 0x05, 0x00, 0x07, 0x04, 0x00, 0x00, 0x00, 0x01, 0x08, 0x04, 0x00,
            0x00, 0x00, 0x01, 0x7F, 0x65, 0x7E
        };

        byte[] receiveFrame1 = new byte[]
        {
            0x7E, 0xA0, 0x20, 0x03, 0x03, 0x73, 0xF0, 0x2E, 0x81, 0x80, 0x14, 0x05, 0x02, 0x05,
            0x00, 0x06, 0x02, 0x05, 0x00, 0x07, 0x04, 0x00, 0x00, 0x00, 0x01, 0x08, 0x04, 0x00,
            0x00, 0x00, 0x01, 0x7F, 0x65, 0x7E
        };

        // Frame 2
        byte[] sendFrame2 = new byte[]
        {
            0x7E, 0xA0, 0x44, 0x03, 0x03, 0x10, 0x65, 0x94, 0xE6, 0xE6, 0x00, 0x60, 0x36, 0xA1,
            0x09, 0x06, 0x07, 0x60, 0x85, 0x74, 0x05, 0x08, 0x01, 0x01, 0x8A, 0x02, 0x07, 0x80,
            0x8B, 0x07, 0x60, 0x85, 0x74, 0x05, 0x08, 0x02, 0x01, 0xAC, 0x0A, 0x80, 0x08, 0x31,
            0x32, 0x33, 0x34, 0x35, 0x36, 0x37, 0x38, 0xBE, 0x10, 0x04, 0x0E, 0x01, 0x00, 0x00,
            0x00, 0x06, 0x5F, 0x1F, 0x04, 0x00, 0xFF, 0xFF, 0xFF, 0x04, 0xFD, 0x1F, 0xA1, 0x7E
        };

        byte[] receiveFrame2 = new byte[]
        {
            0x7E, 0xA0, 0x37, 0x03, 0x03, 0x30, 0xEF, 0xCA, 0xE6, 0xE7, 0x00, 0x61, 0x29, 0xA1,
            0x09, 0x06, 0x07, 0x60, 0x85, 0x74, 0x05, 0x08, 0x01, 0x01, 0xA2, 0x03, 0x02, 0x01,
            0x00, 0xA3, 0x05, 0xA1, 0x03, 0x02, 0x01, 0x00, 0xBE, 0x10, 0x04, 0x0E, 0x08, 0x00,
            0x06, 0x5F, 0x1F, 0x04, 0x00, 0x40, 0x1E, 0x1D, 0x04, 0xFD, 0x00, 0x07, 0xAD, 0x12,
            0x7E

        };

        // Frame 3
        byte[] sendFrame3 = new byte[]
        {
            0x7E, 0xA0, 0x19, 0x03, 0x03, 0x32, 0xEC, 0xC8, 0xE6, 0xE6, 0x00, 0xC0, 0x01, 0x41,
            0x00, 0x01, 0x00, 0x00, 0x2A, 0x00, 0x00, 0xFF, 0x01, 0x00, 0x61, 0x38, 0x7E
        };

        byte[] receiveFrame3 = new byte[]
        {
            0x7E, 0xA0, 0x18, 0x03, 0x03, 0x52, 0x51, 0xB7, 0xE6, 0xE7, 0x00, 0xC4, 0x01, 0x41,
            0x00, 0x09, 0x06, 0x00, 0x00, 0x2A, 0x00, 0x00, 0xFF, 0x36, 0xF5, 0x7E
        };

        // Frame 4
        byte[] sendFrame4 = new byte[]
        {
            0x7E, 0xA0, 0x19, 0x03, 0x03, 0x54, 0xDC, 0xCE, 0xE6, 0xE6, 0x00, 0xC0, 0x01, 0x41,
            0x00, 0x01, 0x00, 0x00, 0x2A, 0x00, 0x00, 0xFF, 0x02, 0x00, 0x09, 0x12, 0x7E
        };

        byte[] receiveFrame4 = new byte[]
        {
            0x7E, 0xA0, 0x22, 0x03, 0x03, 0x74, 0x39, 0x63, 0xE6, 0xE7, 0x00, 0xC4, 0x01, 0x41,
            0x00, 0x09, 0x10, 0x53, 0x4B, 0x51, 0x30, 0x30, 0x33, 0x30, 0x37, 0x30, 0x30, 0x32,
            0x30, 0x30, 0x30, 0x30, 0x33, 0xE2, 0x8A, 0x7E
        };

        // Frame 5
        byte[] sendFrame5 = new byte[]
        {
            0x7E, 0xA0, 0x07, 0x03, 0x03, 0x53, 0x80, 0xD7, 0x7E
        };

        byte[] receiveFrame5 = new byte[]
        {
            0x7E, 0xA0, 0x07, 0x03, 0x03, 0x73, 0x82, 0xF6, 0x7E
        };

        // Simulate Send and receive frames with translation
        SendFrame(sendFrame1);
        Delay(2000); // Delay for 2 seconds
        ReceiveFrame(receiveFrame1);
        Console.WriteLine(TranslateDLMSFrame(receiveFrame1));

        Delay(2000); // Delay for 2 seconds

        SendFrame(sendFrame2);
        Delay(2000); // Delay for 2 seconds
        ReceiveFrame(receiveFrame2);
        Console.WriteLine(TranslateDLMSFrame(receiveFrame2));
        Delay(2000); // Delay for 2 seconds

        SendFrame(sendFrame3);
        Delay(2000); // Delay for 2 seconds
        ReceiveFrame(receiveFrame3);
        Console.WriteLine(TranslateDLMSFrame(receiveFrame3));
        Delay(2000); // Delay for 2 seconds

        SendFrame(sendFrame4);
        Delay(2000); // Delay for 2 seconds
        ReceiveFrame(receiveFrame4);
        Console.WriteLine(TranslateDLMSFrame(receiveFrame4));
        Delay(2000); // Delay for 2 seconds

        SendFrame(sendFrame5);
        Delay(2000); // Delay for 2 seconds
        ReceiveFrame(receiveFrame5);
        Console.WriteLine(TranslateDLMSFrame(receiveFrame5));


        // Translation method
        string TranslateDLMSFrame(byte[] frame)
        {
            StringBuilder translation = new StringBuilder();
            translation.Append("\nDLMS Frame Translation:   ");

            // Extract the control field from the frame
            byte controlField = frame[5];

            if (controlField == 0x73)
            {
                // Check if it is the first frame or last frame
                if (frame[6] == 0xF0)
                {
                    translation.AppendLine("ESTABLISHING DATA LINK LAYER CONNECTION");
                }
                else
                {
                    translation.AppendLine("REALEASE DLL ASSOCIATION");
                }
            }

            else if (controlField == 0x30)
            {
                translation.AppendLine("ESTABLISHING APPLICATION ASSOCIATION");
            }

            else if (controlField == 0x52)
            {
                translation.AppendLine("GET COSEM LOGICAL DEVICE NAME");
            }

            else if (controlField == 0x74)
            {
                translation.AppendLine("COSEM LOGICAL DEVICE NAME : SKQ0030700200003");
            }

            else
            {
                translation.AppendLine("UNKNOWN FRAME TYPE !!!");
            }

            return translation.ToString();
        }
    }

    // Simulate sending a frame
    public static void SendFrame(byte[] frame)
    {
        Console.WriteLine("Sending frame: " + BitConverter.ToString(frame));
    }

    // Simulate receiving a frame
    public static void ReceiveFrame(byte[] frame)
    {
        Console.WriteLine("Receiving frame: " + BitConverter.ToString(frame));
    }

    // Delay function
    public static void Delay(int milliseconds)
    {
        Thread.Sleep(milliseconds);
    }
}