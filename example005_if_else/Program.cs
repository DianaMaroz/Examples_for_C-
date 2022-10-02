Console.WriteLine("Введите имя пользователя:");

string username = GetUsername();
if (username.ToLower() == "маша")
{
    Console.WriteLine("Ура, это же МАША!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);

}

static string NewMethod()
{
    string GetUsername()
    {
        return Console.ReadLine();
    }

    string username = GetUsername();
    return username;
}

static string GetUsername()
{
    return NewMethod();
}