using Kovacs_Barna_triatlon;

List<Eredmenyek> eredmeny = [
    new Eredmenyek() //1
     {
         Nev = "Ábrahám Richárd",
         Szulev = 1998,
         Rajtszam = "159",
         Nem = "f",
         Kategoria = "16-17",
         Uszasido = new TimeOnly(00,24,03),
         Elsoido = new TimeOnly(00,01,54),
         Kerekparido = new TimeOnly(00,45,15),
         Masodikido = new TimeOnly(00,01,15),
         Futasido = new TimeOnly(00,25,15)

     },
    new Eredmenyek() //2
     {
         Nev = "Ábrahám Richárd",
         Szulev = 1998,
         Rajtszam = "159",
         Nem = "f",
         Kategoria = "16-17",
         Uszasido = new TimeOnly(00,24,03),
         Elsoido = new TimeOnly(00,01,54),
         Kerekparido = new TimeOnly(00,45,15),
         Masodikido = new TimeOnly(00,01,15),
         Futasido = new TimeOnly(00,25,15)

     }
    new Eredmenyek() //3
     {
         Nev = "Ábrahám Richárd",
         Szulev = 1998,
         Rajtszam = "159",
         Nem = "f",
         Kategoria = "16-17",
         Uszasido = new TimeOnly(00,24,03),
         Elsoido = new TimeOnly(00,01,54),
         Kerekparido = new TimeOnly(00,45,15),
         Masodikido = new TimeOnly(00,01,15),
         Futasido = new TimeOnly(00,25,15)

     },
     new Eredmenyek() //4
     {
         Nev = "Ábrahám Richárd",
         Szulev = 1998,
         Rajtszam = "159",
         Nem = "f",
         Kategoria = "elit junior",
         Uszasido = new TimeOnly(00,24,03),
         Elsoido = new TimeOnly(00,01,54),
         Kerekparido = new TimeOnly(00,45,15),
         Masodikido = new TimeOnly(00,01,15),
         Futasido = new TimeOnly(00,25,15)

     },
     new Eredmenyek() //5
     {
         Nev = "Ábrahám Richárd",
         Szulev = 1998,
         Rajtszam = "159",
         Nem = "f",
         Kategoria = "elit junior",
         Uszasido = new TimeOnly(00,24,03),
         Elsoido = new TimeOnly(00,01,54),
         Kerekparido = new TimeOnly(00,45,15),
         Masodikido = new TimeOnly(00,01,15),
         Futasido = new TimeOnly(00,25,15)

     },
    ];

Console.WriteLine($"A versenyt {eredmeny.Count} fő fejezte be");
int ej = 0;
for ( int i = 0; i < eredmeny.Count; i++)
{
    if (eredmeny.Kategoria = "elit junior")
    {
        ej++;
    }
}
