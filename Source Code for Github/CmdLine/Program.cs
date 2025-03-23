using Microsoft.VisualBasic;
using System.Diagnostics;
using YoutubeDLSharp;
using YoutubeDLSharp.Options;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Text;
using System.IO;

//Ajouts a faire : ajouter SSH

class ConsoleApp
{
    static void Main(string[] args)
    {
        string username = "default";
        Console.Title = ">_ CmdLine Project";
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine("  /$$$$$$                    /$$/$$      /$$                  \r\n /$$__  $$                  | $| $$     |__/                  \r\n| $$  \\__//$$$$$$/$$$$  /$$$$$$| $$      /$$/$$$$$$$  /$$$$$$ \r\n| $$     | $$_  $$_  $$/$$__  $| $$     | $| $$__  $$/$$__  $$\r\n| $$     | $$ \\ $$ \\ $| $$  | $| $$     | $| $$  \\ $| $$$$$$$$\r\n| $$    $| $$ | $$ | $| $$  | $| $$     | $| $$  | $| $$_____/\r\n|  $$$$$$| $$ | $$ | $|  $$$$$$| $$$$$$$| $| $$  | $|  $$$$$$$\r\n \\______/|__/ |__/ |__/\\_______|________|__|__/  |__/\\_______/\r\n                                                              \r\n                                                              \r\n                                                              ");
        Console.WriteLine(">_ CmdLine, simpler & better than CMD");
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine(DateTime.UtcNow);
        Console.WriteLine("_____________________________________________");
        Console.ForegroundColor = ConsoleColor.White;



        void commands()
        {
            Console.Write(username + "@cmdline >>");
            string cmd = Console.ReadLine();

            switch (cmd)
            {
                case "user":
                    Console.BackgroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("username.change - Change Username");
                    Console.WriteLine("username.reset - Reset username");
                    Console.BackgroundColor = ConsoleColor.Black;
                    break;
                case "username.change":
                    Console.Write("New username: ");
                    username = Console.ReadLine();
                    if (username == "")
                    {
                        Console.WriteLine("Username cannot be empty");
                        username = ("default");
                        return;
                    }

                    Console.WriteLine("Username changed to: " + username);
                    break;
                case "help":
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine(">_Appearance");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine("color - Change Text Color");
                    Console.WriteLine("color.help - Help color command");
                    Console.WriteLine("color.reset - Reset Text Color");
                    Console.WriteLine("set.title_window - Set Title for CmdLine Window");
                    Console.WriteLine("reset.title_window - Reset Title for CmdLine Window");
                    Console.WriteLine("background.change - Change Background Color");
                    Console.WriteLine("background.reset - Reset Color Background");
                    Console.WriteLine("-------------------------------------");
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine(">_Tools");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine("youtube.download - Download YouTube video");
                    Console.WriteLine("snake.game - Play Snake");
                    Console.WriteLine("-------------------------------------");
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine(">_Terminal");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine("text_echo - Echo Text");
                    Console.WriteLine("files.all_show - Show all files on all disks");
                    Console.WriteLine("user - Show Username commands");
                    Console.WriteLine("username.change - Change Username");
                    Console.WriteLine("username.reset - Reset username");
                    Console.WriteLine("help - Show all commands");
                    Console.WriteLine("exit - Exit CmdLine");
                    Console.WriteLine("clear - Clear Console");
                    Console.WriteLine("open - Open File");
                    Console.WriteLine("create.text - Create Notes");
                    Console.WriteLine("calc - Calculator");
                    Console.WriteLine("cmdline.reset - Reset CmdLine Terminal");
                    Console.WriteLine("remove - Remove file");
                    Console.WriteLine("time.clear - Update time");
                    Console.WriteLine("cmd.your commands - Execute CMD command");
                    Console.WriteLine("powershell - Execute PowerShell command");
                    Console.WriteLine("notes_view - View notes file");
                    Console.WriteLine("notes_clear - Clear notes file");
                    Console.WriteLine("notes_delete - Delete notes file");
                    Console.WriteLine(">_IDE Commands");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("-------------------------------------");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Python Commands :");
                    Console.WriteLine("create.py_file - Create a python file");
                    Console.WriteLine("run.py_file - Run a python file");
                    Console.WriteLine("clear.py_file - Clear a python file");
                    Console.WriteLine("delete.py_file - Delete a python file");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("-------------------------------------");
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("C# Commands :");
                    Console.WriteLine("create.cs_file - Create a C# file");
                    Console.WriteLine("open.cs_file - Modify C# File");
                    Console.WriteLine("Invalid | run.cs_file - Run a C# file");
                    Console.WriteLine("clear.cs_file - Clear a C# file");
                    Console.WriteLine("delete.cs_file - Delete a C# file");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("-------------------------------------");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Magenta;
                    Console.WriteLine(">_Others");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.WriteLine("discord - Join Discord Server");
                    Console.WriteLine("matrix - Matrix Effect");
                    Console.WriteLine("about - Show About");
                    Console.WriteLine("system.info - View System Info");
                    Console.WriteLine("date - Show Date");
                    Console.WriteLine("github - Open CmdLine project");
                    Console.BackgroundColor = ConsoleColor.Black;
                    break;
                case "exit":
                    Environment.Exit(0);
                    break;
                case "about":
                    Console.WriteLine("Version - v1.6");
                    Console.WriteLine("Creator - Saysaa");
                    Console.WriteLine("Build - 2025-006");
                    Console.WriteLine("Fact - Created with C#");
                    Console.WriteLine("This is a official version, is not modded version");
                    break;
                case "date":
                    Console.WriteLine(DateAndTime.DateString);
                    break;
                case "github":
                    string github = "https://github.com/saysaa/CmdLine";
                    try
                    {
                        Process.Start(new ProcessStartInfo
                        {
                            FileName = github,
                            UseShellExecute = true
                        });
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Open URL error ! -> " + ex.Message);
                    }
                    break;
                case "text_echo":
                    Console.Write("-> ");
                    string text = Console.ReadLine();
                    Console.WriteLine(text);
                    break;
                case "system.info":
                    Environment.OSVersion.ToString();
                    Console.WriteLine("OS Version: " + Environment.OSVersion);
                    Environment.ProcessorCount.ToString();
                    Console.WriteLine("Processor Count: " + Environment.ProcessorCount);
                    Environment.UserName.ToString();
                    Console.WriteLine("Username: " + Environment.UserName);
                    Environment.MachineName.ToString();
                    Console.WriteLine("Machine Name: " + Environment.MachineName);
                    Environment.Version.ToString();
                    Console.WriteLine("Version: " + Environment.Version);
                    Environment.CurrentDirectory.ToString();
                    Console.WriteLine("Current Directory: " + Environment.CurrentDirectory);
                    Environment.SystemDirectory.ToString();
                    Console.WriteLine("System Directory: " + Environment.SystemDirectory);
                    break;
                case "open":
                    Console.Write("Enter Path ->");
                    try
                    {
                        string appOpen = Console.ReadLine();
                        Process.Start(appOpen);
                        Console.WriteLine("Was opened without problem");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Failed to open file -> " + ex.Message);
                    }
                    break;
                case "clear":
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("  /$$$$$$                      /$$ /$$       /$$                    \r\n /$$__  $$                    | $$| $$      |__/                    \r\n| $$  \\__/ /$$$$$$/$$$$   /$$$$$$$| $$       /$$ /$$$$$$$   /$$$$$$ \r\n| $$      | $$_  $$_  $$ /$$__  $$| $$      | $$| $$__  $$ /$$__  $$\r\n| $$      | $$ \\ $$ \\ $$| $$  | $$| $$      | $$| $$  \\ $$| $$$$$$$$\r\n| $$    $$| $$ | $$ | $$| $$  | $$| $$      | $$| $$  | $$| $$_____/\r\n|  $$$$$$/| $$ | $$ | $$|  $$$$$$$| $$$$$$$$| $$| $$  | $$|  $$$$$$$\r\n \\______/ |__/ |__/ |__/ \\_______/|________/|__/|__/  |__/ \\_______/\r\n                                                                    \r\n                                                                    \r\n                                                                    ");
                    Console.WriteLine(">_ CmdLine, simpler & better than CMD");
                    Console.WriteLine(DateTime.UtcNow);
                    Console.WriteLine("_____________________________________________");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Black;
                    break;
                case "discord":
                    string discord = "https://discord.gg/CCdndVMUxr";
                    try
                    {
                        Process.Start(new ProcessStartInfo
                        {
                            FileName = discord,
                            UseShellExecute = true
                        });
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Open URL error ! -> " + ex.Message);
                    }
                    break;
                case "easteregg":
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("You found the easter egg commands <3");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("my first C# project is CmdLine");
                    break;
                case "calc":
                    Console.Write("Enter first number : ");
                    double num1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter second number : ");
                    double num2 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter operator : ");
                    string op = Console.ReadLine();
                    double result = 0;
                    switch (op)
                    {
                        case "+":
                            result = num1 + num2;
                            break;
                        case "-":
                            result = num1 - num2;
                            break;
                        case "*":
                            result = num1 * num2;
                            break;
                        case "/":
                            result = num1 / num2;
                            break;
                        default:
                            Console.WriteLine("Invalid operator");
                            break;
                    }
                    Console.WriteLine("Result : " + result);
                    break;
                case "remove":
                    Console.Write("Enter file path : ");
                    string path = Console.ReadLine();
                    File.Delete(path);
                    Console.WriteLine("File deleted successfully");
                    break;
                case "color":
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Help ? Execute command : color.help");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("-> ");
                    string colorfont = Console.ReadLine();
                    if (Enum.TryParse(colorfont, true, out ConsoleColor color))
                    {
                        Console.ForegroundColor = color;
                    }
                    else
                    {
                        Console.WriteLine("Invalid color");
                    }
                    break;
                case "color.help":
                    Console.WriteLine("red\r\nblue\r\ngreen\r\nyellow\r\nmagenta\r\ngrey\r\ncyan\r\nwhite\r\nDarkBlue\r\nDarkCyan\r\nDarkYellow\r\nDarkRed\r\nDarkGreen\r\nDarkMagenta\r\nDarkGrey\r\n");
                    break;
                case "color.reset":
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case "username.reset":
                    username = "default";
                    break;
                case "set.title_window":
                    Console.Write("-> ");
                    string title_window = Console.ReadLine();
                    Console.Title = title_window;
                    break;
                case "reset.title_window":
                    Console.Title = ("CmdLine Project");
                    break;
                case "background.change":
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Help ? Execute command : color.help");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("-> ");
                    string bgColor = Console.ReadLine();
                    if (Enum.TryParse(bgColor, true, out ConsoleColor bgColorEnum))
                    {
                        Console.BackgroundColor = bgColorEnum;
                    }
                    else
                    {
                        Console.WriteLine("Invalid color");
                    }
                    break;
                case "youtube.download":
                    Console.Write("Enter YouTube URL: ");
                    string url = Console.ReadLine();
                    Console.WriteLine("•\t160 : 144p - mp4\r\n•\t278 : 144p - webm\r\n•\t133 : 240p - mp4\r\n•\t242 : 240p - webm\r\n•\t134 : 360p - mp4\r\n•\t18  : 360p - mp4\r\n•\t243 : 360p - webm\r\n•\t135 : 480p - mp4\r\n•\t244 : 480p - webm\r\n•\t136 : 720p - mp4\r\n•\t247 : 720p - webm\r\n•\t298 : 720p60 - mp4\r\n•\t302 : 720p60 - webm\r\n•\t137 : 1080p - mp4\r\n•\t248 : 1080p - webm\r\n•\t299 : 1080p60 - mp4\r\n•\t303 : 1080p60 - webm\r\n•\t271 : 1440p - webm\r\n•\t308 : 1440p60 - webm\r\n•\t313 : 2160p - webm\r\n•\t315 : 2160p60 - webm•\t140 : m4a - audio only\r\n•\t251 : webm - audio only");
                    Console.Write("Enter format ID for video -> ");
                    string videoFormatId = Console.ReadLine();
                    Console.Write("Enter format ID for audio (e.g., 140 for m4a) -> ");
                    string audioFormatId = Console.ReadLine();
                    Console.Write("Enter download path: ");
                    string downloadPath = Console.ReadLine();
                    DownloadYouTubeVideo(url, videoFormatId, audioFormatId, downloadPath).Wait();
                    break;
                case "time.clear":
                    Console.WriteLine(DateTime.UtcNow);
                    break;
                case "snake.game":
                    SnakeGameProject.snake();
                    break;
                case "matrix":
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.CursorVisible = false;
                    Random random = new Random();
                    int width, height;
                    width = Console.WindowWidth;
                    height = Console.WindowHeight;
                    char[] chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789".ToCharArray();
                    int[] y = new int[width];

                    for (int i = 0; i < width; i++)
                    {
                        y[i] = random.Next(height);
                    }

                    while (true)
                    {
                        for (int x = 0; x < width; x++)
                        {
                            Console.SetCursorPosition(x, y[x]);
                            Console.Write(chars[random.Next(chars.Length)]);
                            y[x] = (y[x] + 1) % height;
                        }
                        Thread.Sleep(50);
                    }
                case "files.all_show":
                    ListAllFiles();
                    break;

                case "cmdline.reset":
                    Console.Clear();
                    Console.WriteLine("CmdLine will be reset...");
                    Thread.Sleep(1500);
                    Console.WriteLine("reset in progress...");
                    Thread.Sleep(1000);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Reset - Program.cs ");
                    Thread.Sleep(2000);
                    Console.WriteLine("Reset - CmdLine.pdb ");
                    Thread.Sleep(1000);
                    Console.WriteLine("Reset - CmdLine.runtimeconfig.json ");
                    Thread.Sleep(1000);
                    Console.WriteLine("Reset - Newtonsoft.Json.dll ");
                    Thread.Sleep(900);
                    Console.WriteLine("Reset - YoutubeDLSharp.dll ");
                    Thread.Sleep(700);
                    Console.WriteLine("Reset - CmdLine.deps.json ");
                    Thread.Sleep(400);
                    Console.WriteLine("Reset - CmdLine.dll ");
                    Thread.Sleep(920);
                    Console.ForegroundColor = ConsoleColor.White;
                    Thread.Sleep(2000);
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("CmdLine as been reset. Reboot");
                    Thread.Sleep(2000);
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Clear();
                    break;
                case "background.reset":
                    Console.BackgroundColor = ConsoleColor.Black;
                    break;
                case "":
                    Console.Write("");
                    break;
                case "create.text":
                    Console.Write("Notes -> ");
                    string notes = Console.ReadLine();
                    Console.Write("Enter a filename -> ");
                    string filename_txt = Console.ReadLine();
                    string path_notes = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), filename_txt, ".txt");
                    File.WriteAllText(path_notes, notes);
                    Console.WriteLine("Saved to Desktop");
                    break;

                case "notes_view":
                    Console.Write("Enter Path -> ");
                    string inputPath_view = Console.ReadLine();
                    if (!File.Exists(inputPath_view))
                    {
                        Console.WriteLine("File not found");
                        break;
                    }
                    string path2 = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), inputPath_view);
                    string readText = File.ReadAllText(path2);
                    Console.WriteLine(readText);
                    break;

                case "notes_clear":
                    Console.Write("Enter Path -> ");
                    string inputPath_clear = Console.ReadLine();
                    if (!File.Exists(inputPath_clear))
                    {
                        Console.WriteLine("File not found");
                        break;
                    }
                    string path3 = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), inputPath_clear);
                    File.WriteAllText(path3, string.Empty);
                    Console.WriteLine("Notes Cleared");
                    break;

                case "notes_delete":
                    Console.Write("Enter Path -> ");
                    string inputPath_delete = Console.ReadLine();
                    if (!File.Exists(inputPath_delete))
                    {
                        Console.WriteLine("File not found");
                        break;
                    }
                    string path4 = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), inputPath_delete);
                    File.Delete(path4);
                    Console.WriteLine("Notes Deleted");
                    break;

                // Python Commands
                case "create.py_file":
                    Console.Write("Enter File Name -> ");
                    string fileName = Console.ReadLine();
                    string path5 = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), fileName + ".py");
                    File.Create(path5);
                    Console.WriteLine("Python File Created -- Path : Desktop");
                    break;

                case "run.py_file":
                    Console.Write("Enter Path Name -> ");
                    string fileName_run = Console.ReadLine();
                    string path6 = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), fileName_run);
                    var processInfo = new System.Diagnostics.ProcessStartInfo("python", path6)
                    {
                        RedirectStandardError = true,
                        UseShellExecute = false
                    };
                    var process = System.Diagnostics.Process.Start(processInfo);
                    string error = process.StandardError.ReadToEnd();
                    process.WaitForExit();
                    if (!string.IsNullOrEmpty(error))
                    {
                        Console.WriteLine("Error: " + error);
                    }
                    break;

                case "clear.py_file":
                    Console.Write("Enter Path -> ");
                    string inputPath_clear_py = Console.ReadLine();
                    if (!File.Exists(inputPath_clear_py))
                    {
                        Console.WriteLine("File not found");
                        break;
                    }
                    string path7 = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), inputPath_clear_py);
                    File.WriteAllText(path7, string.Empty);
                    Console.WriteLine("Python File Cleared");
                    break;

                case "delete.py_file":
                    Console.Write("Enter Path -> ");
                    string inputPath_delete_py = Console.ReadLine();
                    if (!File.Exists(inputPath_delete_py))
                    {
                        Console.WriteLine("File not found");
                        break;
                    }
                    string path8 = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), inputPath_delete_py);
                    File.Delete(path8);
                    Console.WriteLine("Python File Deleted");
                    break;

                // C# Commands

                case "create.cs_file":
                    Console.Write("Enter File Name -> ");
                    string fileName_cs = Console.ReadLine();
                    string path9 = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), fileName_cs + ".cs");
                    File.Create(path9);
                    Console.WriteLine("C# File Created -- Path : Desktop");
                    break;

                case "open.cs_file":
                    Console.Write("Enter path name -> ");
                    string fileName_open_cs = Console.ReadLine();
                    string path17 = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), fileName_open_cs);
                    if (File.Exists(path17))
                    {
                        using (FileStream fs = File.Open(path17, FileMode.Open, FileAccess.ReadWrite))
                        using (StreamReader reader = new StreamReader(fs))
                        using (StreamWriter writer = new StreamWriter(fs))
                        {
                            Console.WriteLine("Current content:");
                            Console.WriteLine(reader.ReadToEnd());
                            Console.WriteLine("Enter new content:");
                            string newContent = Console.ReadLine();
                            fs.SetLength(0); // Clear the file
                            writer.Write(newContent);
                            Console.WriteLine("File updated.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("File not found.");
                    }
                    break;


                case "run.cs_file":
                    Console.Write("Enter Path Name -> ");
                    string fileName_run_cs = Console.ReadLine();
                    string path10 = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), fileName_run_cs);
                    if (File.Exists(path10))
                    {
                        string projectDirectory = Path.GetDirectoryName(path10);
                        string projectFile = Directory.GetFiles(projectDirectory, "*.csproj", SearchOption.AllDirectories).FirstOrDefault();
                        if (projectFile != null)
                        {
                            var processInfo_cs = new System.Diagnostics.ProcessStartInfo("dotnet", $"run --project \"{projectFile}\"")
                            {
                                RedirectStandardError = true,
                                RedirectStandardOutput = true,
                                UseShellExecute = false
                            };
                            var process_cs = System.Diagnostics.Process.Start(processInfo_cs);
                            string output_cs = process_cs.StandardOutput.ReadToEnd();
                            string error_cs = process_cs.StandardError.ReadToEnd();
                            process_cs.WaitForExit();
                            if (!string.IsNullOrEmpty(error_cs))
                            {
                                Console.WriteLine("Error: " + error_cs);
                            }
                            else
                            {
                                Console.WriteLine(output_cs);
                            }
                        }
                        else
                        {
                            Console.WriteLine("No project file found in the directory.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Project file not found.");
                    }
                    break;



                case "clear.cs_file":
                    Console.Write("Enter Path -> ");
                    string inputPath_clear_cs = Console.ReadLine();
                    if (!File.Exists(inputPath_clear_cs))
                    {
                        Console.WriteLine("File not found");
                        break;
                    }
                    string path11 = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), inputPath_clear_cs);
                    File.WriteAllText(path11, string.Empty);
                    Console.WriteLine("C# File Cleared");
                    break;

                case "delete.cs_file":
                    Console.Write("Enter Path -> ");
                    string inputPath_delete_cs = Console.ReadLine();
                    if (!File.Exists(inputPath_delete_cs))
                    {
                        Console.WriteLine("File not found");
                        break;
                    }
                    string path12 = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), inputPath_delete_cs);
                    File.Delete(path12);
                    Console.WriteLine("C# File Deleted");
                    break;

                case "powershell":
                    Console.Write("Enter PowerShell command: ");
                    string psCommand = Console.ReadLine();
                    ExecutePowerShellCommand(psCommand);
                    break;
                default:
                    if (cmd.StartsWith("cmd."))
                    {
                        string command = cmd.Substring(4);
                        ExecuteCommand(command);
                    }
                    else
                    {
                        Console.WriteLine("Invalid Command. Write -> help");
                    }
                    break;

            }
        }

        async Task DownloadYouTubeVideo(string url, string videoFormatId, string audioFormatId, string downloadPath)
        {
            var ytdl = new YoutubeDL
            {
                YoutubeDLPath = "C:\\Users\\grima\\Desktop\\CmdLine\\yt-dlp.exe", // Update this path to the location of yt-dlp.exe
                FFmpegPath = "C:\\Users\\grima\\Desktop\\CmdLine\\ffmpeg-7.1-essentials_build\\ffmpeg-7.1-essentials_build\\bin\\ffmpeg.exe" // Update this path to the location of ffmpeg.exe if needed
            };
            var options = new OptionSet
            {
                Output = Path.Combine(downloadPath, "%(title)s.%(ext)s"),
                Format = $"{videoFormatId}+{audioFormatId}"
            };
            var result = await ytdl.RunVideoDownload(url, overrideOptions: options);
            if (result.Success)
            {
                Console.WriteLine("Download completed successfully.");
            }
            else
            {
                Console.WriteLine("Download failed: " + string.Join(Environment.NewLine, result.ErrorOutput));
                Console.WriteLine("Available formats:");
                var formatResult = await ytdl.RunVideoDataFetch(url);
                if (formatResult.Success)
                {
                    foreach (var format in formatResult.Data.Formats)
                    {
                        Console.WriteLine($"{format.FormatId}: {format.FormatNote} - {format.Extension} - {format.Resolution}");
                    }
                }
                else
                {
                    Console.WriteLine("Failed to fetch available formats: " + string.Join(Environment.NewLine, formatResult.ErrorOutput));
                }
            }
        }

        static void ExecutePowerShellCommand(string command)
        {
            try
            {
                ProcessStartInfo processInfo = new ProcessStartInfo("powershell.exe", "-Command " + command)
                {
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };
                Process process = Process.Start(processInfo);
                process.WaitForExit();
                string output = process.StandardOutput.ReadToEnd();
                Console.WriteLine(output);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error executing PowerShell command: " + ex.Message);
            }
        }

        static void ExecuteCommand(string command)
        {
            try
            {
                ProcessStartInfo processInfo = new ProcessStartInfo("cmd.exe", "/c " + command)
                {
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };
                Process process = Process.Start(processInfo);
                process.WaitForExit();
                string output = process.StandardOutput.ReadToEnd();
                Console.WriteLine(output);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error executing command: " + ex.Message);
            }
        }


        static void ListAllFiles()
        {
            foreach (var drive in DriveInfo.GetDrives())
            {
                if (drive.IsReady)
                {
                    Console.WriteLine($"Drive: {drive.Name}");
                    try
                    {
                        foreach (var file in Directory.GetFiles(drive.Name, "*.*", SearchOption.AllDirectories))
                        {
                            Console.WriteLine(file);
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error accessing files on drive {drive.Name}: {ex.Message}");
                    }
                }
            }
        }

        while (true)
        {
            commands();
        }
    }
}
class SnakeGameProject
{
    public static void snake()
    {
        Console.CursorVisible = false;
        int width = 40;
        int height = 20;
        int score = 0;
        int snakeLength = 3;
        int fruitX = 0;
        int fruitY = 0;
        bool gameOver = false;
        Random random = new Random();
        List<int[]> snake = new List<int[]>();
        for (int i = 0; i < snakeLength; i++)
        {
            snake.Add(new int[] { width / 2, height / 2 });
        }
        char direction = 'R';

        void Draw()
        {
            StringBuilder output = new StringBuilder();
            for (int i = 0; i < width + 2; i++) output.Append("#");
            output.AppendLine();
            for (int i = 0; i < height; i++)
            {
                output.Append("#");
                for (int j = 0; j < width; j++)
                {
                    if (snake.Any(s => s[0] == j && s[1] == i))
                    {
                        output.Append("O");
                    }
                    else if (fruitX == j && fruitY == i)
                    {
                        output.Append("F");
                    }
                    else
                    {
                        output.Append(" ");
                    }
                }
                output.AppendLine("#");
            }
            for (int i = 0; i < width + 2; i++) output.Append("#");
            output.AppendLine();
            output.AppendLine("Score: " + score);
            Console.SetCursorPosition(0, 0);
            Console.Write(output.ToString());
        }

        void GenerateFruit()
        {
            fruitX = random.Next(0, width);
            fruitY = random.Next(0, height);
        }

        void Update()
        {
            int[] head = snake[0];
            int[] newHead = new int[2];
            Array.Copy(head, newHead, 2);
            switch (direction)
            {
                case 'U': newHead[1]--; break;
                case 'D': newHead[1]++; break;
                case 'L': newHead[0]--; break;
                case 'R': newHead[0]++; break;
            }
            if (newHead[0] < 0 || newHead[0] >= width || newHead[1] < 0 || newHead[1] >= height || snake.Any(s => s[0] == newHead[0] && s[1] == newHead[1]))
            {
                gameOver = true;
                return;
            }
            snake.Insert(0, newHead);
            if (newHead[0] == fruitX && newHead[1] == fruitY)
            {
                score++;
                GenerateFruit();
            }
            else
            {
                snake.RemoveAt(snake.Count - 1);
            }
        }

        GenerateFruit();
        while (!gameOver)
        {
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo key = Console.ReadKey(true);
                switch (key.Key)
                {
                    case ConsoleKey.UpArrow: if (direction != 'D') direction = 'U'; break;
                    case ConsoleKey.DownArrow: if (direction != 'U') direction = 'D'; break;
                    case ConsoleKey.LeftArrow: if (direction != 'R') direction = 'L'; break;
                    case ConsoleKey.RightArrow: if (direction != 'L') direction = 'R'; break;
                }
            }
            Update();
            Draw();
            Thread.Sleep(100);
        }
        Console.Clear();
        Console.WriteLine("Game Over! Score: " + score);
    }
}