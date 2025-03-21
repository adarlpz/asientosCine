internal class Program {
    private static void Main(string[] args) {
        char[,] asientos = new char[10, 10];
        for (int f = 0; f < 10; f++) {
            for (int c = 0; c < 10; c++) {
                asientos[f, c] = 'L';
            }
        }

        void mostrarAsientos() {
            for (char letra = 'A'; letra < 'A' + 10; letra++) {
                Console.Write("  " + letra);
            }
            Console.WriteLine();
            for (int f = 0; f < 10; f++) {
                Console.Write(f);
                for (int c = 0; c < 10; c++) {
                    Console.Write(" " + asientos[f, c] + " ");
                }
                Console.WriteLine();
            }
        }
        mostrarAsientos();

        while (true) {
            Console.WriteLine();
            Console.Write("Que asiento quieres reservar? ");
            string asiento = Console.ReadLine();
            char fila = asiento[0];
            char columna = asiento[1];

            if (new[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J" }.Contains(fila.ToString().ToUpper()))
            { //intercambio
                char temp = fila;
                fila = columna;
                columna = temp;
            }
            int nuevaFila = fila - '0';
            int nuevaColumna = columna - 'A';

            asientos[nuevaFila, nuevaColumna] = 'X';

            mostrarAsientos();
        }
    }
}
