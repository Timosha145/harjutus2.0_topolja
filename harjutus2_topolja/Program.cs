using harjutus2_topolja;
using System.Text;

List<Tootaja> tootajad = new List<Tootaja>();
List<Tootaja> tootajad2 = new List<Tootaja>();
List<Opilane> opilased = new List<Opilane>();
List<Opilane> opilased2 = new List<Opilane>();
List<Kutsekooliopilane> kutsekooliopilased = new List<Kutsekooliopilane>();
List<Kutsekooliopilane> kutsekooliopilased2 = new List<Kutsekooliopilane>();

Tootaja tootaja = new Tootaja("tootaja", "TTHK", "õpetaja", "Egor", 1991, Isik.sugu.Mees, 500, 1100, 20);
tootaja.print_Info();
Opilane opilane = new Opilane("opilane", "Topor", "9B", "õpilane", "Boris", 2006, Isik.sugu.Mees, 0, 0, 0);
opilane.print_Info();
Kutsekooliopilane kutsekooliopilane = new Kutsekooliopilane("kutsekooliopilane", 60, "Tallinn", 450, 3, 4.5, "THK", "tarkvara arendaja", "MEHpv22", "Luda", 2004, Isik.sugu.Naine, 0, 0, 0);
kutsekooliopilane.print_Info();

tootajad.Add(tootaja);
opilased.Add(opilane);
kutsekooliopilased.Add(kutsekooliopilane);

StreamWriter tofile = new StreamWriter(@"..\..\..\info.txt", false);
foreach (Tootaja item in tootajad)
{
    Console.WriteLine(item.nimi);
    tofile.WriteLine($"{item.kesOn}, {item.asutus}, {item.amet}, {item.nimi}, {item.synniaasta}, {item.Sugu}, {item.maksuvaba}, {item.palk}, {item.tulumaks}, ");
}
foreach (Opilane item in opilased)
{
    Console.WriteLine(item.nimi);
    tofile.WriteLine($"{item.kesOn}, {item.koolinimi}, {item.klass}, {item.spetsialiseerumine}, {item.nimi}, {item.synniaasta}, {item.Sugu}, {item.maksuvaba}, {item.palk}, {item.tulumaks}, ");
}
foreach (Kutsekooliopilane item in kutsekooliopilased)
{
    Console.WriteLine(item.nimi);
    tofile.WriteLine($"{item.kesOn}, {item.toetussumma}, {item.elamiskoht}, {item.perepalk}, {item.lastearv}, {item.keskhinne}, {item.oppeasutus}, {item.eriala}, {item.kursus}, {item.nimi}, {item.synniaasta}, {item.Sugu}, {item.maksuvaba}, {item.palk}, {item.tulumaks}, ");
}
tofile.Close();

StreamReader sr = new StreamReader(@"..\..\..\info.txt");
string text;
while ((text = sr.ReadLine()) != null)
{
    string[] rida = text.Split(", ");
    if (rida[0]=="tootaja")
    {
        tootajad2.Add(new Tootaja(rida[0], rida[1], rida[2], rida[3], int.Parse(rida[4]), TextToSugu(rida[5]), double.Parse(rida[6]), double.Parse(rida[7]), double.Parse(rida[8])));
        Console.WriteLine("see on tootaja");
    }
    else if (rida[0] == "opilane")
    {
        opilased2.Add(new Opilane(rida[0], rida[1], rida[2], rida[3], rida[4], int.Parse(rida[5]), TextToSugu(rida[6]), double.Parse(rida[7]), double.Parse(rida[8]), double.Parse(rida[9])));
        Console.WriteLine("see on õpilane");
    }
    else if (rida[0] == "kutsekooliopilane")
    {
        kutsekooliopilased2.Add(new Kutsekooliopilane(rida[0], double.Parse(rida[1]), rida[2], double.Parse(rida[3]), int.Parse(rida[4]), double.Parse(rida[5]), rida[6], rida[7], rida[8], rida[9], int.Parse(rida[10]), TextToSugu(rida[11]), double.Parse(rida[12]), double.Parse(rida[13]), double.Parse(rida[14])));
        Console.WriteLine("see on kutsekooliõpilane");
    }
}
sr.Close();

foreach (var item in tootajad2)
{
    Console.Write($"{item.kesOn}, {item.asutus}, {item.amet}, {item.nimi}, {item.synniaasta}, {item.Sugu}, {item.maksuvaba}, {item.palk}, {item.tulumaks}");
}
Console.WriteLine();  
foreach (var item in opilased2)
{
    Console.Write($"{item.kesOn}, {item.koolinimi}, {item.klass}, {item.spetsialiseerumine}, {item.nimi}, {item.synniaasta}, {item.Sugu}, {item.maksuvaba}, {item.palk}, {item.tulumaks}, ");
}
Console.WriteLine();
foreach (var item in kutsekooliopilased2)
{
    Console.Write($"{item.kesOn}, {item.toetussumma}, {item.elamiskoht}, {item.perepalk}, {item.lastearv}, {item.keskhinne}, {item.oppeasutus}, {item.eriala}, {item.kursus}, {item.nimi}, {item.synniaasta}, {item.Sugu}, {item.maksuvaba}, {item.palk}, {item.tulumaks}, ");
}
Isik.sugu TextToSugu(string andmed)
{
    switch (andmed) 
    {
        case "Naine": return Isik.sugu.Naine;
        default: return Isik.sugu.Mees;
    }
}