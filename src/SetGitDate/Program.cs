using System.Text;
using TextCopy;

class Program
{
    static void Main(string[] args)
    {
        bool isInt = int.TryParse(args[0], out int timeDiff);
        if (!isInt)
            return;

        string date = DateTime.Now.AddHours(timeDiff).ToString();

        StringBuilder sb = new();
        sb.AppendLine($"$Env:GIT_COMMITTER_DATE=\"{date}\"");
        sb.AppendLine($"$Env:GIT_AUTHOR_DATE=\"{date}\"");
        if (args.Length > 1)
        {
            sb.Append($" git commit -a -m \"{args[1]}\"");
        }
        ClipboardService.SetText(sb.ToString());
        Console.WriteLine($"code copied");
    }
}