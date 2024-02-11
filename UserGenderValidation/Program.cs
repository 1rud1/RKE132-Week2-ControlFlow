// See https://aka.ms/new-console-template for more information

//rakendus küsib valida tema sugu (m/f)
//rakendus küsib kasutajal sisestada tema perekonnanime
//lähtiudes kasutaja valikust, rakendus tervitab kasutajat järgmiselt:
//"Welcome, Mr. [kasutaja perekonnanimi] / "Welcome, Ms. [kasutaja perekonnan

Console.WriteLine("Please, select your gender (m/f):");

char userGender = Char.Parse(Console.ReadLine());//loeb consoolist maha andmeid (sõne) formaadis

Console.WriteLine("Please, enter your name:");
string userLastName = Console.ReadLine();


if(userGender == 'm')
{
    Console.WriteLine($"Welcome, Mr. {userLastName}!");
}
else if(userGender == 'f')
{
    Console.WriteLine($"Welcome, Ms. {userLastName}!");
}
else
{
    Console.WriteLine($"Welcome, {userLastName}!");
}



