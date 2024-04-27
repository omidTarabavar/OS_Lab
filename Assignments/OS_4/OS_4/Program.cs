using System.Net;
public class Program()
{
    static string GetParentDirectory(int level)
    {
        string path = Directory.GetCurrentDirectory();
        for (int i = 0; i < level; i++)
        {
            path = Directory.GetParent(path).FullName;
        }
        return path;
    }

    static void downloadFile(string url)
    {
        string destinationFolder = Path.Combine(GetParentDirectory(3), "downloads");

        // Create the directory if it doesn't exist
        if (!Directory.Exists(destinationFolder))
        {
            Directory.CreateDirectory(destinationFolder);
        }

        // Get the file name from the URL
        string fileName = Path.GetFileName(url);

        // Combine the destination folder and file name to get the full path
        string destinationPath = Path.Combine(destinationFolder, fileName);

        // Download the file
        using (WebClient client = new WebClient())
        {
            try
            {
                client.DownloadFile(url, destinationPath);
                Console.WriteLine($"File downloaded successfully to: {destinationPath}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error downloading file: {ex.Message}");
            }
        }
    }

    public static void Main(string[] args)
    {
        List<String> dlLinks = new List<String>();
        int choice = 0;
        do
        {
            choice = menu();

            switch (choice)
            {
                case 1:
                    {
                        Console.Write("\nEnter Download Link: ");
                        dlLinks.Add(Console.ReadLine());
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("\nLinks:\n");
                        foreach (String link in dlLinks)
                        {
                            Console.WriteLine($"{link}");
                        }

                        break;
                    }
                case 3:
                    {
                        download(dlLinks);
                        for (int i = 0; i < dlLinks.Count; i++)
                            dlLinks.RemoveAt(i);
                        break;
                    }
                case 4:
                    {
                        break;
                    }
            }
        } while (choice != 4);



    }
    static void download(List<String> dlLinks)
    {
        List<Task> downloadTasks = new List<Task>();
        foreach (String link in dlLinks)
        {
            downloadTasks.Add(Task.Run(() => downloadFile(link)));
        }

        Task.WaitAll(downloadTasks.ToArray());
        Console.WriteLine("All files downloaded successfully in Download folder");
    }
    static int menu()
    {
        Console.WriteLine("\n1- Add download link");
        Console.WriteLine("2- View download links");
        Console.WriteLine("3- Start download (will clear download list)");
        Console.WriteLine("4- Quit");

        Console.Write("\nChoose: ");

        return int.Parse(Console.ReadLine());
    }



}




