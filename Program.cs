using DesafioPOO.Models;

Console.WriteLine("IPHONE \n___________________");
Iphone iphone = new("961232132", "11.0", "11111111", 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Sudoku");

Console.WriteLine("\n");

Console.WriteLine("NOKIA \n___________________");
Nokia nokia = new("12384134", "Tijolão", "2222222", 64);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Jogo da Velha");