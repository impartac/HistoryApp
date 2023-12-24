﻿namespace HistoryApp
{
    public class Data
    {

        public static string[] FIO = new string[] { "Михаил Федорович Романов", "Алексей Михайлович Романов", "Фёдор Алексеевич Романов",
        "Софья Алексеевна Романова","Иван Алексеевич Романов" , "Пётр Великий Романов", "Екатерина Алексеевна Романовна",
        "Петр Алексеевич Романов", "Анна Иоанновна Романова" ,"Иван Антонович Романов", "Елизавета Петровна Романова",
        "Пётр Федорович Романов", "Екатерина Алексеевна Романова", "Павел Петрович Романов", "Александр Павлович Романов",
        "Николай Павлович Романов", "Александр Николаевич Романов", "Александр Александрович Романов",
        "Николай Александрович Романов"};

        static Human[] rulers = new Human[]
        {
            new Human("Михаил","Федорович","Романов",new Time(1596,1645),new string[] {"Первый царь из династии Романовых, положивший конец Смутному времени"}),
            new Human("Алексей","Михайлович","Романов",new Time(1629,1676),new string[] {"Ввод подушного налога и заложение основ централизованного Российского государства"}),
            new Human("Фëдор", "Алексеевич","Романов" ,new Time(1661,1682),new string[] {"Как последний царь Российской династии в прямой мужской линии, большая часть власти была в руках его сестры Софьи"}),
            new Human("Софья", "Алексеевна", "Романова",new Time(1657,1704),new string[] {"Она никогда официально не занимала царствующего положения, была регентом при малолетних братьях Петре и Иване"}),
            new Human("Иван", "Алексеевич", "Романов",new Time(1666,1696),new string[] {"Слабый здоровьем и с ограниченными полномочиями при совместном правлении с Петром I"}),
            new Human("Петр","Алексеевич","Романов",new Time(1672,1725),new string[] {"Обширными реформами, строительством Санкт-Петербурга и утверждением России как великой державы"}),
            new Human("Екатерина", "Алексеевна", "Романовна",new Time(1684,1727),new string[] {"Провела ряд административных и финансовых реформ для укрепления и стабилизации Российской империи"}),
            new Human("Петр", "Алексеевич", "Романов",new Time(1715,1730),new string[] {"Умер в раннем возрасте, после чего в России начались споры о наследнике престола"}),
            new Human("Анна", "Иоанновна", "Романова",new Time(1693,1740),new string[] {"Усилением влияния дворянства и бюрократии"}),
            new Human("Иван","Антонович", "Романов",new Time(1740,1764),new string[] {"Был свергнут Елизаветой Петровной вскоре после восшествия на трон и провел большую часть жизни в заключении"}),
            new Human("Елизавета", "Петровна", "Романова",new Time(1709,1762),new string[] {"Чередой реформ, развитием искусств и культуры, а также участием в Семилетней войне"}),
            new Human("Пётр","Федорович", "Романов",new Time(1728,1762),new string[] {"Был свергнут в результате дворцового переворота, организованного его супругой Екатериной II, и скончался в течение недолгого времени после отречения"}),
            new Human("Екатерина", "Алексеевна", "Романова",new Time(1729,1796),new string[] {"Провела широкие политические, социальные и культурные реформы, расширяла территориальные границы, улучшала образование и культуру, а также активно поддерживала просвещенный абсолютизм и взаимодействие с Европой"}),
            new Human("Павел", "Петрович", "Романов",new Time(1754,1801),new string[] {" Внедрил «Устав благочиния», старался ограничить влияние дворянства, был убит в результате заговора"}),
            new Human("Александр", "Павлович", "Романов",new Time(1777,1825),new string[] {"Ключевая роль в поражении Наполеона, вступление в Священный союз, относительно либеральное начало правления, сменяемое более консервативным курсом"}),
            new Human("Николай", "Павлович", "Романов",new Time(1796,1855),new string[] {"Жесткое подавление восстания декабристов, политика официализма, участие в Крымской войне, поражение в которой подорвало имперский авторитет"}),
            new Human("Александр","Николаевич", "Романов",new Time(1818,1881),new string[] {"Освобождение крепостных (1861 год), попытки реформирования государства, убийство террористами народовольцами"}),
            new Human("Александр", "Александрович", "Романов",new Time(1845,894),new string[] {"Реакционная политика и укрепление самодержавия, национализм и политика русификации"}),
            new Human("Николай", "Александрович", "Романов",new Time(1868,1918),new string[] {"Вхождение Российской империи в Первую мировую войну, революционные потрясения, отречение и расстрел всей семьи"}),
        };
        static Human[][] childrens = new Human[][]
        {
            new Human[] {rulers[1]},
            new Human[] {rulers[2],rulers[3],rulers[4],rulers[5]},
            new Human[] {new Human()},/* no */
            new Human[] {new Human()},/* no */
            new Human[] {rulers[8]}, /* Екатерина Ивановна */
            new Human[] {rulers[10]},/* Алексей Петрович, Анна Петровна */
            new Human[] {rulers[10] },/* Алексей Петрович, Анна Петровна */
            new Human[] { new Human()},/* no */
            new Human[] {new Human()},/* no */
            new Human[] {new Human()},/* no */
            new Human[] {new Human()},/* no */
            new Human[] {rulers[13]},
            new Human[] {rulers[13]},
            new Human[] {rulers[14],rulers[15]},
            new Human[] {new Human()},/* no */
            new Human[] {rulers[16]},
            new Human[] {rulers[17]},
            new Human[] {rulers[18]},
            new Human[] {new Human()},/* no */
        };
        static Human[][] spouses = new Human[][]
        {
            new Human[] {new Human("Мария Владимировна Долгорукова"),new Human("Евдокия Лукьяновна Стрешнева") },
            new Human[] {new Human("Мария Ильинична Милославская"),new Human("Наталья Кирилловна Нарышкина") },
            new Human[] {new Human()},/* no */
            new Human[] {new Human()},/* no */
            new Human[] {new Human("Прасковья Федоровна Салтыкова") },
            new Human[] {new Human("Евдокия Федоровна Лопухина"), new Human("Екатерина Алексеевна Романова") },/* Алексей Петрович, Анна Петровна */
            new Human[] {rulers[10] },/* Алексей Петрович, Анна Петровна */
            new Human[] { new Human("Петр Алексеевич Романов") },
            new Human[] {new Human()},/* no */
            new Human[] {new Human("Фридрих Вильгельм -")},
            new Human[] {new Human()},/* no */
            new Human[] {new Human()},/* no */
            new Human[] {new Human("Екатерина Алексеевна Романова") },
            new Human[] {new Human("Петр Федорович Романов") },
            new Human[] {new Human("Мария Федоровна Романова") },
            new Human[] {new Human ("Александра Федоровна Романова") },
            new Human[] {new Human ("Мария Александровна Романова") },
            new Human[] {new Human("Мария Федоровна Романова") },
            new Human[] {new Human("Александра Федоровна Романова") }
        };
        static Time[] gov = new Time[]
        {
            new Time (1613,1645),
            new Time (1645,1676),
            new Time (1676,1682),
            new Time (1682,1689),
            new Time (1682,1696),
            new Time (1682,1725),
            new Time (1725,1727),
            new Time (1727,1730),
            new Time (1730,1740),
            new Time (1740,1741),
            new Time (1741,1761),
            new Time (1761,1762),
            new Time (1762,1796),
            new Time (1796,1801),
            new Time (1801,1825),
            new Time (1825,1855),
            new Time (1855,1881),
            new Time (1881,1894),
            new Time (1894,1917)
        };
        static string[] num = new string[] 
        {
            "","","","","",
            "I","I","II","","VI",
            "","III","II","I","I",
            "I","II","III","II"
        };
        public static Dictionary<string, Ruler> GetData() 
        {
            Dictionary<string, Ruler> allrulers = new Dictionary<string, Ruler>();
            for (int i = 0; i < 19; i++) 
            {
                allrulers.Add(FIO[i], new Ruler(rulers[i], spouses[i], childrens[i], gov[i], num[i]));
            } 
            return allrulers;
        }
    }
}