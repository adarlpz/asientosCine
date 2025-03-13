char[,] asientos = new char[10, 10];

for (char letra = 'A'; letra < 'A' + 10; letra++) {
    Console.Write("  " + letra);
}
Console.WriteLine();

for (int f = 0; f < 10; f++) {
    Console.Write(f);
    for (int c = 0; c < 10; c++) {
        asientos[f, c] = 'L';
        Console.Write(" " + asientos[f, c] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();
Console.Write("Que asiento quieres reservar?");

string asiento = Console.ReadLine();

char fila = asiento[0];
char columna = asiento[1];

