using System.Net;
using System.Net.Sockets;

class Client
{
    static void Main(string[] args)
    {
        IPEndPoint ipEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8000);
        Socket clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        try
        {
            clientSocket.Connect(ipEndPoint);
            Console.WriteLine("Connected to server");

            // Send a file to the server
            Console.Write("Enter the file path to send to the server: ");
            string fileToSend = Console.ReadLine();

            if (File.Exists(fileToSend))
            {
                SendFile(clientSocket, fileToSend);
                Console.WriteLine("File sent to server: " + fileToSend);
            }
            else
            {
                Console.WriteLine("File not found: " + fileToSend);
            }

            // Receive a file from the server
            byte[] buffer = new byte[1024];
            int bytesReceived = clientSocket.Receive(buffer);
            string fileName = System.Text.Encoding.ASCII.GetString(buffer, 0, bytesReceived);

            bytesReceived = clientSocket.Receive(buffer);
            long fileSize = BitConverter.ToInt64(buffer, 0);

            Console.WriteLine("Receiving file from server: " + fileName + " (" + fileSize + " bytes)");

            using (FileStream fileStream = new FileStream(fileName, FileMode.Create))
            {
                ReceiveFile(clientSocket, fileStream, fileSize);
            }

            Console.WriteLine("File received from server: " + fileName);

            clientSocket.Shutdown(SocketShutdown.Both);
            clientSocket.Close();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    static void SendFile(Socket socket, string filePath)
    {
        FileInfo fileInfo = new FileInfo(filePath);
        string fileName = fileInfo.Name;
        long fileSize = fileInfo.Length;

        // Send the file name and size
        byte[] fileNameBytes = System.Text.Encoding.ASCII.GetBytes(fileName);
        socket.Send(fileNameBytes);
        socket.Send(BitConverter.GetBytes(fileSize));

        // Send the file data
        using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
        {
            byte[] fileData = new byte[1024];
            int bytesRead;
            long totalBytesSent = 0;

            while ((bytesRead = fileStream.Read(fileData, 0, fileData.Length)) > 0)
            {
                socket.Send(fileData, bytesRead, SocketFlags.None);
                totalBytesSent += bytesRead;
            }

            Console.WriteLine("Total bytes sent: " + totalBytesSent);
        }
    }

    static void ReceiveFile(Socket socket, FileStream fileStream, long fileSize)
    {
        byte[] buffer = new byte[1024];
        long totalBytesReceived = 0;
        int bytesRead;

        while (totalBytesReceived < fileSize)
        {
            bytesRead = socket.Receive(buffer);
            fileStream.Write(buffer, 0, bytesRead);
            totalBytesReceived += bytesRead;
        }

        Console.WriteLine("Total bytes received: " + totalBytesReceived);
    }
}