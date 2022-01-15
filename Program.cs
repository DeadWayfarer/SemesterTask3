using Newtonsoft.Json.Linq;

string line;
string result = "";
while ((line = Console.ReadLine()) != "")
{
    var data = line.Split(" ");
    var pupil = data[0];
    var marks = data.Skip(1)
                    .Select(x => int.Parse(x));
    var avgMark = marks.Average();
    avgMark = Math.Round(avgMark, 2);

    result += $"{pupil} ср. оценка - {avgMark}\n";
}
Console.WriteLine(result);
