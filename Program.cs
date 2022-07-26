void methodArray (string [] array){
     string[] newarr = new string[array.Length];
     for (int i=0; i<array.Length; i++){      
        if(array[i].Length<=3){
        newarr[i]=array[i];;
        Console.WriteLine(newarr[i]); 
        }
     }
        Console.WriteLine(); 
}

void Print(string [] Array){
    for (int i=0; i<Array.Length; i++){
        Console.WriteLine(Array[i]);
    }
    Console.WriteLine();
}

Console.WriteLine("Введите слова через запятую");
string s = Console.ReadLine();
string[] str = s.Split(',');

Print(str);
methodArray(str);