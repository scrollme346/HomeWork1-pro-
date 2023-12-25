public class MusiclyInst
{
    public string? nameInstr {  get; set; } 
    public string? soundInstr { get; set; }
}

public class Skripka : MusiclyInst
{
    public Skripka(string _nameInstr, string _soundInstr)
    {
        nameInstr = _nameInstr;
        soundInstr = _soundInstr;
    }

    public void Sound()
    {
        Console.WriteLine($"Инструмент выдает такой звук: {soundInstr}");
    }
    
    public void Show()
    {
        Console.WriteLine($"Название инструмента: {nameInstr}");
    }
    public void Desc()
    {
        Console.WriteLine($"\nОписание инструмента: {nameInstr} - струнный инструмент с четырьмя струнами, играется с помощью смычка."); ;
    }

    public void History()
    {
        Console.WriteLine($"\nИстория: Скрипка появилась в XVI веке в Италии. Мастера, такие как Амати и Страдивари, усовершенствовали её форму.\nС течением времени стала ключевым инструментом в классической музыке и других жанрах.");
    }
}

public class Trombon : MusiclyInst//наследуемся от музинструментов
{
    public Trombon(string _nameInstr, string _soundInstr)
    {
        nameInstr = _nameInstr;
        soundInstr = _soundInstr;
    }
    public void Sound()
    {
        Console.WriteLine($"Инструмент выдает такой звук: {soundInstr}");
    }

    public void Show()
    {
        Console.WriteLine($"\n\nНазвание инструмента: {nameInstr}");
    }
    public void Desc()
    {
        Console.WriteLine($"\nОписание инструмента: {nameInstr} - медный духовой инструмент с выдвижной трубой и кольцом для руки.\nИспользуется в оркестровой, духовой и джазовой музыке.");
    }

    public void History()
    {
        Console.WriteLine($"\nИстория: {nameInstr} - появился в XVI веке как медный духовой инструмент с раздвижными трубками для изменения высоты звука.\nОн прошел через изменения в дизайне, став важным элементом оркестровой и джазовой музыки.\nСегодня тромбон используется в различных жанрах, выделяясь своим характерным звучанием.");
    }
}

public class Ukylele : MusiclyInst
{
    public Ukylele(string _nameInstr, string _soundInstr)
    {
        nameInstr = _nameInstr;
        soundInstr = _soundInstr;
    }

    public void Sound()
    {
        Console.WriteLine($"Инструмент выдает такой звук: {soundInstr}");
    }

    public void Show()
    {
        Console.WriteLine($"\n\nНазвание инструмента: {nameInstr}");
    }
    public void Desc()
    {
        Console.WriteLine($"\nОписание инструмента: {nameInstr} — маленький струнный инструмент с четырьмя струнами, создающий яркие и веселые звуки.\nЧасто используется в Гавайской музыке и легко обучается новичкам.");
    }

    public void History()
    {
        Console.WriteLine($"\nИстория: {nameInstr} - появилось на Гавайях в конце 19 века, развиваясь из португальского инструмента брагинья.\nСлово \"укеле\" на гавайском означает \"прыгающая блоха\".\nИнструмент быстро стал модным в США и Европе благодаря своему уникальному звучанию и компактности.");
    }
}

public class Violanchel : MusiclyInst
{
    public Violanchel(string _nameInstr, string _soundInstr)
    {
        nameInstr = _nameInstr;
        soundInstr = _soundInstr;
    }

    public void Sound()
    {
        Console.WriteLine($"Инструмент выдает такой звук: {soundInstr}");
    }

    public void Show()
    {
        Console.WriteLine($"\n\nНазвание инструмента: {nameInstr}");
    }
    public void Desc()
    {
        Console.WriteLine($"\nОписание инструмента: {nameInstr} - струнный инструмент с четырьмя струнами, играется смычком. Используется в оркестрах, камерной музыке и соло.");
    }

    public void History()
    {
        Console.WriteLine($"\nИстория: {nameInstr} - струнный инструмент, появившийся в XVI веке в Италии.\nСледуя эволюции под руководством мастеров, стала неотъемлемой частью оркестровой музыки.\nСегодня используется в различных жанрах благодаря своему глубокому и могучему звучанию.");
    }

}
class Program
{
    static void Main()
    {
        Skripka skripka = new Skripka("Скрипка", "Скрип Скрип");
        skripka.Show();
        skripka.Sound();
        skripka.Desc();
        skripka.History();

        Trombon trombon = new Trombon("Тромбон", "Тром-бом-бом");
        trombon.Show(); trombon.Sound(); trombon.Desc(); trombon.History();       //вызываем методы имя звук описание и история

        Ukylele ukylele = new Ukylele("Укулеле", "ля-ля-ля");
        ukylele.Show(); ukylele.Sound(); ukylele.Desc(); ukylele.History();

        Violanchel violanchel = new Violanchel("Виоланчель", "чель-чель-чель");
        violanchel.Show(); violanchel.Sound(); violanchel.Desc(); violanchel.History();
    }
}
