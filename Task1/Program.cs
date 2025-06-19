/*
 Задание 1
Создайте класс Human, который будет содержать
информацию о человеке.
С помощью механизма наследования, реализуйте класс
Builder (содержит информацию о строителе), класс Sailor
(содержит информацию о моряке), класс Pilot (содержит
информацию о летчике).
Каждый из классов должен содержать необходимые
для работы методы.
 */
using System.Reflection.Metadata;

namespace Task1
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            Human Bob = new Builder(
                "Bob",
                "Attack helicopter",
                "Project manager",
                new DateTime(2023, 1, 9, 0, 0, 0, DateTimeKind.Utc),
                "Building a house"
            );
            Bob.Show();
            //
            Human Nammy = new Sailor(
                "Nammy",
                "Male",
                "Captain",
                new DateTime(1999, 1, 5, 0, 0, 0, DateTimeKind.Utc),
                true,
                "Odessa - SanFrancisco");
            Nammy.Show();

            Human Dandy = new Pilot(
                "Dandy",
                "Female",
                "Captain",
                new DateTime(1939, 1, 5, 0, 0, 0, DateTimeKind.Utc),
                1234,
                false
                ); 


            Dandy.Show();
              
                
                
 
        }
    }
}
