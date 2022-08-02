using System.Text;
using TextCopy;

class Program
{
    static void Main(string[] args)
    {
        bool isDouble = double.TryParse(args[0], out double timeDiff);
        if (!isDouble)
            return;

        string date = DateTime.Now.AddHours(timeDiff).ToString();

        StringBuilder sb = new();
        sb.AppendLine($"$Env:GIT_COMMITTER_DATE=\"{date}\"");
        //sb.AppendLine($"$Env:GIT_AUTHOR_DATE=\"{date}\"");
        if (args.Length > 1)
        {
            sb.Append($" git commit -a -m \"{args[1]}\"  --date=\"{date}\" ");
        }
        ClipboardService.SetText(sb.ToString());
        Console.WriteLine($"code copied");
    }
}