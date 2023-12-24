// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var steps = 8;
var path = "UDDDUDUU";

var response = countingValleys(steps, path);

Console.WriteLine(response);

static int countingValleys(int steps, string path)
{
    if (steps < 2 || string.IsNullOrWhiteSpace(path) || steps != path.Length)
    {
        return 0;
    }
    var stepCounter = 0;
    var valleysCounter = 0;

    for (int i = 0; i < steps; i++)
    {
        if (path[i] == 'U')
        {
            stepCounter = stepCounter + 1;
            if (stepCounter == 0)
            {
                valleysCounter = valleysCounter + 1;

            }
        }
        if (path[i] == 'D')
        {
            stepCounter = stepCounter - 1;
        }
    }

    return valleysCounter;
}


Console.ReadLine();