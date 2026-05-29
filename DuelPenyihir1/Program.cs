Wizard wizardA = new Wizard("Asep", 20);
Wizard wizardB = new Wizard("Joo", 24);

Console.WriteLine("Permainan Dimulai...\n");
wizardA.ShowStats();
wizardB.ShowStats();

wizardA.Attack(wizardB);
wizardB.Attack(wizardA);
wizardB.Attack(wizardA);
wizardA.Attack(wizardB);

Console.WriteLine("Permainan berakhir\n");
wizardA.ShowStats();
wizardB.ShowStats();

public class Wizard
{
    //deklarasi field
    public string Name;
    public int Energi;
    public int Damage;

    //deklarasi constructor
    public Wizard(string nama, int damage)
    {
        Name = nama;
        Energi = 100;
        Damage = damage;

    }

    public void ShowStats()
    {
        Console.WriteLine("Statistik Wizard");
        Console.WriteLine($"Nama: {Name}, Energi: {Energi} \n");
    }

    public void Attack(Wizard wizardLawanOBJ)
    {
        //mengurangi energi wizarLawanOBJ sebesar damage
        wizardLawanOBJ.Energi -= Damage;
        Console.WriteLine($"{Name} menyerang {wizardLawanOBJ.Name}");
        Console.WriteLine($"sisa energi {wizardLawanOBJ.Name} adalah {wizardLawanOBJ.Energi}");
    }

}