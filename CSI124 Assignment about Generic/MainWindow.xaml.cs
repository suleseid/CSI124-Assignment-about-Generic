using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CSI124_Assignment_about_Generic
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        TeamRoster<FootballPlayer> seahowks = new TeamRoster<FootballPlayer>();
        TeamRoster<BaseBallPlayer> mariners = new TeamRoster<BaseBallPlayer>();
        

        public MainWindow()
        {
            // b = 6
            // a = 8

            // temp = a; temp = 6
            // a = b  a = b ; a = 8;
            // b = temp ; b = 6

            // a = 8
            // b = 6

            string name1 = "Bander";
            string name2 = "Sam";

            string temp = name1;
            name1 = name2;
            name2 = temp;

            // name1 = Sam
            // name2 = Bander

            FootballPlayer p1 = new FootballPlayer();
            FootballPlayer p2 = new FootballPlayer();
            BaseBallPlayer p3 = new BaseBallPlayer("w", "6", 5, 12);
            int a = 6;
            int b = 8;

            ChangeA(a);

            Swap(ref a, ref b);
            Swap(ref p1, ref p2);

            // value and reference

        }
        // Generic Method
        public void Swap<T>(ref T t1, ref T t2)
        {
            T temp = t1;
            t1 = t2;
            t2 = temp;
        }

        public void ChangeA(int a)
        {
            a = 10;
        }
        public void AssingPlayersToTeamRoster()
        {
            InitializeComponent();
            seahowks.AddPlayer(new FootballPlayer("Bander", "10", 1000000000, 30000000));
            seahowks.AddPlayer(new FootballPlayer("Will", "7", 10000, 10));

            MessageBox.Show(seahowks.TeamSalary().ToString());

            mariners.AddPlayer(new BaseBallPlayer("Sam", "8", 10000000, 80000));
        }
        public void Example()
        {

            // Boxing ( box and unbox )
            //Player player = new FootballPlayer("Will", "7", 19);

            // Casting in programming means converting from one type to another

            int age = (int)54.7; // Explict Casting
            double alsoAge = 54; // Implicit Casting

            //FootballPlayer teamPlayers = (FootballPlayer)player;


            // object
            // player
            // football player

            //FootballPlayer fbPlayer = new FootballPlayer("Zack", "7", 2000);

            // Boxing - We box an instance up as an object
            //object fbObject = fbPlayer;

            //FootballPlayer playerObject = fbObject as FootballPlayer;

            object number = 5;
            FootballPlayer playerObject = number as FootballPlayer;

            if (playerObject == null)
            {
                MessageBox.Show("Number was not a football player");
            }
        }
    
    }
}
