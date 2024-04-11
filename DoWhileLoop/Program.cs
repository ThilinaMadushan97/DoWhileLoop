Random radm = new Random();

int curent = 0;
int indx = 0;

do
{
    curent = radm.Next(1,15);
    indx++;
    Console.WriteLine($"{indx} - {curent}");

}
while (curent < 7);
