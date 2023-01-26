string[] lines = System.IO.File.ReadAllLines(@"lines.txt");

int count = 0;
foreach(string line in lines) {
    if(line.Length <= 3) {
        count++;
    }
}

int start = 0;
Console.Write("[");
foreach(string line in lines) {
    if(line.Length <= 3) {
        start++;
        Console.Write(start == count ? $"{line}]" : $"{line}, ");
    }
}