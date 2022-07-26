Console.WriteLine("Введите слова через запятую");
string s = Console.ReadLine();
string[] str = s.Split(',');
string[] result = new string[str.Length];

for (int i = 0; i < str.Length; i++)
{
    if (str[i].Length <= 3)
    {
        result[i] = str[i];
    }
}