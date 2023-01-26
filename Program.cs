string[] lines = System.IO.File.ReadAllLines(@"lines.txt");

int count = 0;
foreach(string line in lines) {
    if(line.Length <= 3) {
        count++;
    }
}

string[] newLines = new string[count];

int start = 0;
foreach(string line in lines) {
    if(line.Length <= 3) {
        newLines[start] = line;
        start++;
    }
}

Console.Write("[");
for(int i = 0; i < count; i++) {
    Console.Write(i == count - 1 ? $"{newLines[i]}]" : $"{newLines[i]}, ");
}