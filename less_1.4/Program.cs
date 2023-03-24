Console.Write("Введите имя пользователя");
string username = Console.ReadLine();

if(username.ToLower() == "egor")
{
  Console.WriteLine("Дoбрый день, мой Господин!");
}
else
{
  Console.Write("Привет, ");
  Console.WriteLine(username);
}