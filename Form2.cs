using System.ComponentModel;

namespace HistoryApp
{
    public partial class Form2 : Form
    {
        private bool isDragging = false;
        private Point offset;

        PictureBox? pictureBox1;
        PictureBox? pictureBox2;
        PictureBox? pictureBox3;
        PictureBox? pictureBox4;
        PictureBox? pictureBox5;
        PictureBox? pictureBox6;
        PictureBox? pictureBox7;
        PictureBox? pictureBox8;
        PictureBox? pictureBox9;
        PictureBox? pictureBox10;
        PictureBox? pictureBox11;
        PictureBox? pictureBox12;
        PictureBox? pictureBox13;
        PictureBox? pictureBox14;
        PictureBox? pictureBox15;
        PictureBox? pictureBox16;
        PictureBox? pictureBox17;
        PictureBox? pictureBox18;
        PictureBox? pictureBox19;
        PictureBox? pictureBox20;
        PictureBox? pictureBox21;
        PictureBox? pictureBox22;
        PictureBox? pictureBox23;

        public Form2()
        {

            InitializeComponent();
            InitializePictureBoxes();

            this.WindowState = FormWindowState.Maximized;

            panel2.Paint += Panel1_Paint!;
            panel2.MouseDown += PanelMouseDown!;
            panel2.MouseMove += PanelMouseMove!;
            panel2.MouseUp += PanelMouseUp!;
        }

        private void PanelMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                Point cursor = Cursor.Position;
                offset = new Point(cursor.X - panel2.Left, cursor.Y - panel2.Top);
            }
        }

        private void PanelMouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point cursor = Cursor.Position;
                panel2.Left = cursor.X - offset.X;
                panel2.Top = cursor.Y - offset.Y;
            }
        }

        private void PanelMouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
            }
        }

        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            e.Graphics.Clear(Color.Transparent); // Установите цвет фона, если нужно

            // Отрисовка изображения с учетом обрезки окантовки
            e.Graphics.DrawImage(pictureBox.Image, new Rectangle(0, 0, pictureBox.Width, pictureBox.Height));
        }

        private PictureBox CreatePictureBox(int width, int height, int x, int y, string imageName, EventHandler Click)
        {
            PictureBox pictureBox = new PictureBox();
            pictureBox.Size = new Size(width, height);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.Location = new Point(x + 1000, y + 1000); // Adjust the location as needed
            pictureBox.Image = Image.FromFile($"../../../img/{imageName}");
            pictureBox.Cursor = Cursors.Hand;
            pictureBox.Click += Click;
            pictureBox.Paint += pictureBox_Paint;
            panel2.Controls.Add(pictureBox);

            return pictureBox;
        }


        private void DrawLineBetweenPictureBoxes(PictureBox pictureBox1, PictureBox pictureBox2, PaintEventArgs e)
        {
            using (Pen pen = new Pen(Color.Brown, 4.5f))
            {
                // Calculate the center points of the PictureBoxes
                Point center1 = new Point(pictureBox1.Left + pictureBox1.Width / 2, pictureBox1.Top + pictureBox1.Height / 2);
                Point center2 = new Point(pictureBox2.Left + pictureBox2.Width / 2, pictureBox2.Top + pictureBox2.Height / 2);

                // Draw a line connecting the centers
                e.Graphics.DrawLine(pen, center1, center2);
            }
        }

        private void InitializePictureBoxes()
        {
            pictureBox1 = CreatePictureBox(150, 150, 900, 50, "1.JPG", (object sender, EventArgs e) =>
            {
                MessageBox.Show("   - Дети: Алексей Михайлович\r\n   " +
                "- Жена: Мария Владимировна Долгорукова, Евдокия Лукьяновна Стрешнева\r\n   " +
                "- Братья и сестры: нет\r\n   " +
                "- Запомнился: как первый царь из династии Романовых, положивший конец Смутному времени.", "Михаил Федорович Романов (1613-1645)");
            });

            pictureBox2 = CreatePictureBox(150, 150, 900, 250, "2.JPG", (object sender, EventArgs e) =>
            {
                MessageBox.Show("    - Дети: Фëдор Алексеевич, Софья Алексеевна, Иван V Алексеевич, Пётр I Алексеевич и другие.\r\n   " +
                "- Жёны: Мария Ильинична Милославская, Наталья Кирилловна Нарышкина\r\n   " +
                "- Братья и сестры: нет\r\n   " +
                "- Запомнился: Ввод подушного налога и заложение основ централизованного Российского государства.\r\n", "Алексей Михайлович Романов (1645-1676)");
            });

            pictureBox3 = CreatePictureBox(150, 150, 1150, 450, "3.JPG", (object sender, EventArgs e) =>
            {
                MessageBox.Show("    - Дети: нет\r\n   " +
                "- Жена: Агафья Семеновна Грушицкая (умерла до вступления Фёдора на трон), Марфа Апраксина\r\n   " +
                "- Братья и сестры: Софья Алексеевна, Иван V Алексеевич, Петр I Алексеевич и другие\r\n   " +
                "- Запомнился: Как последний царь Российской династии в прямой мужской линии, большая часть власти была в руках его сестры Софьи.", "Фёдор Алексеевич Романов (1676-1682)");
            });

            pictureBox4 = CreatePictureBox(150, 150, 900, 450, "4.JPG", (object sender, EventArgs e) =>
            {
                MessageBox.Show("Oна никогда официально не занимала царствующего положения, была регентом при малолетних братьях Петре и Иване.",
                "Софья Алексеевна Романова (1682-1689)");
            });

            pictureBox5 = CreatePictureBox(150, 150, 1400, 450, "5.JPG", (object sender, EventArgs e) =>
            {
                MessageBox.Show("    - Дети: Анна Ивановна, Екатерина Ивановна и другие\r\n   " +
                "- Жена: Прасковья Федоровна Салтыкова\r\n   " +
                "- Братья и сестры: Федор Алексеевич, Софья Алексеевна, Петр I Алексеевич\r\n   " +
                "- Запомнился: Слабый здоровьем и с ограниченными полномочиями при совместном правлении с Петром I.", "Иван V Алексеевич Романов (1682-1696)");
            });

            //pictureBox5 = CreatePictureBox(200, 200, 800, 600, "4.JPG", (object sender, EventArgs e) => { MessageBox.Show(""); });
            pictureBox6 = CreatePictureBox(150, 150, 400, 450, "6.JPG", (object sender, EventArgs e) =>
            {
                MessageBox.Show("   - Дети: Алексей Петрович, Анна Петровна, Елизавета Петровна и другие.\r\n   " +
                "- Жёны: Евдокия Лопухина, Екатерина I Алексеевна\r\n   " +
                "- Братья и сестры: Софья Алексеевна, Федор Алексеевич, Иван IV Алексеевич\r\n   " +
                "- Запомнился: Обширными реформами, строительством Санкт-Петербурга и утверждением России как великой державы.", "Пётр I Великий Романов (1682-1725)");
            });

            pictureBox7 = CreatePictureBox(150, 150, 650, 450, "7.JPG", (object sender, EventArgs e) =>
            {
                MessageBox.Show("    - Дети: Алексей Петрович, Анна Петровна, Елизавета Петровна и другие.\r\n   " +
                "- Муж: Петр I Алексеевич \r\n   " +
                "- Братья и сестры: нет\r\n   " +
                "- Запомнилась: провела ряд административных и финансовых реформ для укрепления и стабилизации Российской империи.", "Екатерина I Алексеевна Романовна (1725-1727)");
            });

            pictureBox8 = CreatePictureBox(150, 150, 200, 650, "8.JPG", (object sender, EventArgs e) =>
            {
                MessageBox.Show("    - Дети: Наталья Алексеевна, Пётр II.\r\n   " +
                "- Жена: Шарлотта Кристина София Брауншвейг-Вольфенбюттельская  \r\n   " +
                "- Братья и сестры: нет по материнской линии\r\n   " +
                "- Запомнился: Бежал из России, вынесен смертный приговор судом, в составе которого были первые вельможи Российской империи.", "Алексей Петрович Романов");
            });
            pictureBox9 = CreatePictureBox(150, 150, 200, 850, "9.JPG", (object sender, EventArgs e) =>
            {
                MessageBox.Show("    - Дети: нет.\r\n   " +
                "- Жена: нет \r\n   " +
                "- Братья и сестры: Наталья Алексеевна\r\n   " +
                "- Запомнился: Умер в раннем возрасте, после чего в России начались споры о наследнике престола.", "Петр II Алексеевич Романов(1727 - 1730)");
            });
            pictureBox10 = CreatePictureBox(150, 150, 1650, 650, "10.JPG", (object sender, EventArgs e) =>
            {
                MessageBox.Show("    - Дети: нет.\r\n   " +
                "- Муж: Фридрих Вильгельм, герцог Курляндский \r\n   " +
                "- Братья и сестры: Екатерина Иоанновна\r\n   " +
                "- Запомнилась: Усилением влияния дворянства и бюрократии.", "Анна Иоанновна Романова (1730-1740)");
            });
            pictureBox11 = CreatePictureBox(150, 150, 1450, 650, "11.JPG", (object sender, EventArgs e) =>
            {
                MessageBox.Show("    - Дети: Анна Леопольдовна.\r\n   " +
                "- Муж: Карл Леопольд Мекленбург-Шверинский \r\n   " +
                "- Братья и сестры: Анна Иоанновна",
                 "Екатерина Иоанновна Романовна");
            });
            pictureBox12 = CreatePictureBox(150, 150, 1450, 850, "12.JPG", (object sender, EventArgs e) =>
            {
                MessageBox.Show("    - Дети: Иван VI и другие.\r\n   " +
                "- Муж: Антон Ульрих Брауншвейгский \r\n   " +
                "- Братья и сестры: нет",
                 "Анна Леопольдовна");
            });
            pictureBox13 = CreatePictureBox(150, 150, 1450, 1050, "13.JPG", (object sender, EventArgs e) =>
            {
                MessageBox.Show("    - Дети: нет.\r\n   " +
                "- Жена: нет \r\n   " +
                "- Братья и сестры: Елизавета Антоновна, Пётр Антонович, Екатерина Антоновна, Алексей Антонович\r\n   " +
                "- Запомнилсь: Усилением влияния дворянства и бюрократии.", "Иван VI Антонович Романов (1740-1741)");
            });
            pictureBox14 = CreatePictureBox(150, 150, 450, 650, "14.JPG", (object sender, EventArgs e) =>
            {
                MessageBox.Show("    - Дети: нет.\r\n   " +
                "- Муж: нет \r\n   " +
                "- Братья и сестры: Анна Петровна\r\n   " +
                "- Запомнилась: Чередой реформ, развитием искусств и культуры, а также участием в Семилетней войне.", "Елизавета Петровна Романова (1741-1761)");
            });
            pictureBox15 = CreatePictureBox(150, 150, 650, 650, "15.JPG", (object sender, EventArgs e) =>
            {
                MessageBox.Show("    - Дети: ПетрIII.\r\n   " +
                "- Муж: Карл Фридрих Гольштейн-Готторпский \r\n   " +
                "- Братья и сестры: Елизавета Петровна\r\n   "
                , "Анна Петровна");
            });
            pictureBox16 = CreatePictureBox(150, 150, 550, 850, "16.JPG", (object sender, EventArgs e) =>
            {
                MessageBox.Show("    - Дети: Павел I Петрович, Анна Петровна.\r\n   " +
                "- Жена: Екатерина II Алексеевна. \r\n   " +
                "- Братья и сестры: нет\r\n   " +
                "- Запомнился: Был свергнут в результате дворцового переворота, организованного его супругой Екатериной II, и скончался в течение недолгого времени после отречения.", "Пётр III Федорович Романов(1761 - 1762)");
            });
            pictureBox17 = CreatePictureBox(150, 150, 750, 850, "17.JPG", (object sender, EventArgs e) =>
            {
                MessageBox.Show("    - Дети: Анна Петровна, Алексей Григорьевич Бобринский, Павел I, Безымянный, Елизавета Григорьевна Тёмкина.\r\n   " +
                "- Муж: Петр III Федорович \r\n   " +
                "- Братья и сестры: нет\r\n   " +
                "- Запомнилась: провела широкие политические, социальные и культурные реформы, расширяла территориальные границы, улучшала образование и культуру, а также активно поддерживала просвещенный абсолютизм и взаимодействие с Европой.", "Екатерина II Алексеевна Романова (1762-1796)");
            });
            pictureBox18 = CreatePictureBox(150, 150, 650, 1050, "18.JPG", (object sender, EventArgs e) =>
            {
                MessageBox.Show("    -Дети: Александр I, Николай I и другие.\r\n   " +
                "- Жена: Мария Федоровна.\r\n   " +
                "- Братья и сестры: Анна Петровна\r\n   " +
                "- Запомнился: Внедрил «Устав благочиния», старался ограничить влияние дворянства, был убит в результате заговора.", "Павел I Петрович Романов (1796-1801)");
            });
            pictureBox19 = CreatePictureBox(150, 150, 550, 1250, "19.JPG", (object sender, EventArgs e) =>
            {
                MessageBox.Show("    -Дети: нет\r\n   " +
                "- Жена: Елизавета Алексеевна.\r\n   " +
                "- Братья и сестры: Николай I и другие.\r\n   " +
                "- Запомнился: Ключевая роль в поражении Наполеона, вступление в Священный союз, относительно либеральное начало правления, сменяемое более консервативным курсом.", "Александр I Павлович Романов (1801-1825)");
            });
            pictureBox20 = CreatePictureBox(150, 150, 750, 1250, "20.JPG", (object sender, EventArgs e) =>
            {
                MessageBox.Show("    -Дети: Александр II и другие.\r\n   " +
                "- Жена: Александра Федоровна.\r\n   " +
                "- Братья и сестры: Александр I и другие.\r\n   " +
                "- Запомнился: Жесткое подавление восстания декабристов, политика официализма, участие в Крымской войне, поражение в которой подорвало имперский авторитет.\r\n", "Николай I Павлович Романов (1825-1855)");
            });
            pictureBox21 = CreatePictureBox(150, 150, 750, 1450, "21.JPG", (object sender, EventArgs e) =>
            {
                MessageBox.Show("    -Дети: Александр III и другие.\r\n   " +
                "- Жена: Мария Александровна.\r\n   " +
                "- Братья и сестры: Александра Николаевна, Ольга Николаевна, Михаил Николаевич, Константин Николаевич и другие.\r\n   " +
                "- Запомнился: Жесткое подавление восстания декабристов, политика официализма, участие в Крымской войне, поражение в которой подорвало имперский авторитет.\r\n", "Александр II Николаевич Романов (1855-1881)");
            });
            pictureBox22 = CreatePictureBox(150, 150, 750, 1650, "22.JPG", (object sender, EventArgs e) =>
            {
                MessageBox.Show("    -Дети: Николай II и другие.\r\n   " +
                "- Жена: Мария Федоровна.\r\n   " +
                "- Братья и сестры: Борис Александрович Юрьевский, Георгий Александрович Юрьевский и другие.\r\n   " +
                "- Запомнился: Реакционная политика и укрепление самодержавия, национализм и политика русификации.\r\n", "Александр III Александрович Романов (1881-1894)");
            });
            pictureBox23 = CreatePictureBox(150, 150, 750, 1850, "23.JPG", (object sender, EventArgs e) =>
            {
                MessageBox.Show("    - Дети: Алексей, Ольга, Татьяна, Мария и Анастасия.\r\n   " +
                "- Жена: Александра Федоровна.\r\n   " +
                "- Братья и сестры: Георгий Александрович, Александр Александрович, Ксения Александровна, Ольга Александровна, Михаил Александрович.\r\n   " +
                "- Запомнился: Вхождение Российской империи в Первую мировую войну, революционные потрясения, отречение и расстрел всей семьи.\r\n", "Николай II Александрович Романов(1894 - 1917)");
            });

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
            DrawLineBetweenPictureBoxes(pictureBox1, pictureBox2, e);
            DrawLineBetweenPictureBoxes(pictureBox2, pictureBox3, e);
            DrawLineBetweenPictureBoxes(pictureBox2, pictureBox4, e);
            DrawLineBetweenPictureBoxes(pictureBox2, pictureBox5, e);
            DrawLineBetweenPictureBoxes(pictureBox2, pictureBox6, e);
            DrawLineBetweenPictureBoxes(pictureBox6, pictureBox7, e);
            DrawLineBetweenPictureBoxes(pictureBox6, pictureBox8, e);
            DrawLineBetweenPictureBoxes(pictureBox8, pictureBox9, e);
            DrawLineBetweenPictureBoxes(pictureBox5, pictureBox10, e);
            DrawLineBetweenPictureBoxes(pictureBox5, pictureBox11, e);
            DrawLineBetweenPictureBoxes(pictureBox11, pictureBox12, e);
            DrawLineBetweenPictureBoxes(pictureBox12, pictureBox13, e);
            DrawLineBetweenPictureBoxes(pictureBox6, pictureBox14, e);
            DrawLineBetweenPictureBoxes(pictureBox7, pictureBox14, e);
            DrawLineBetweenPictureBoxes(pictureBox7, pictureBox15, e);
            DrawLineBetweenPictureBoxes(pictureBox6, pictureBox15, e);
            DrawLineBetweenPictureBoxes(pictureBox15, pictureBox16, e);
            DrawLineBetweenPictureBoxes(pictureBox16, pictureBox17, e);
            DrawLineBetweenPictureBoxes(pictureBox16, pictureBox18, e);
            DrawLineBetweenPictureBoxes(pictureBox17, pictureBox18, e);
            DrawLineBetweenPictureBoxes(pictureBox18, pictureBox19, e);
            DrawLineBetweenPictureBoxes(pictureBox18, pictureBox20, e);
            DrawLineBetweenPictureBoxes(pictureBox20, pictureBox21, e);
            DrawLineBetweenPictureBoxes(pictureBox21, pictureBox22, e);
            DrawLineBetweenPictureBoxes(pictureBox22, pictureBox23, e);
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
