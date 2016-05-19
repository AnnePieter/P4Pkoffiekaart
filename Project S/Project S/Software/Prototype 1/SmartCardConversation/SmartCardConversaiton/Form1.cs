using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibLogicalAccess;
using System.Data.OleDb;

namespace SmartCardConversaiton
{
    public partial class Kaartlezer : Form
    {
        public Kaartlezer()
        {
            InitializeComponent();  
        }

        
        public string RegistratiePasID()
        {

            //Kijk of lezer connected is
            IReaderProvider readerProvider = new PCSCReaderProvider();

            //Lezen uit kaart object
            IReaderUnit readerUnit = readerProvider.CreateReaderUnit();

            //Als USB connectie er is
            if (readerUnit.ConnectToReader())
            {    materialLabel1.Text = "STATUS: READING";            
                string ManNummer = "Pas niet in gebruik";
                //Wacht 15 seconden op een kaart
                Console.WriteLine("Bied uw kaart aan aan de lezer");
                
                if (readerUnit.WaitInsertion(1500000))
                {
                    //Als er connectie met een kaart is
                    if (readerUnit.Connect())
                    {                        
                        //Pak chip uit de kaart
                        chip chip = readerUnit.GetSingleChip();

                        //Schrijf chip type
                        ManNummer = readerUnit.GetNumber(chip);
                        readerUnit.Disconnect();

                    }
                }

                //Disconnect met USB
                readerUnit.Disconnect();
                if (ManNummer == "")
                {
                    //Geef Error terug (vang op in andere methodes!)
                    MessageBox.Show("Kaart is niet goed uitgelezen!!!");
                    return "Error";
                }
                else
                {
                    //Geef nummer terug van kaart
                    return ManNummer;
                }

            }
            return "Reader niet gevonden";
        }

        //Lees pas uit en toon gegevens gebruiker
        public void LeesGegevensUitDB()
        {

            //Connectiestring naar DB
            string ConnectionString =
            @"Provider=Microsoft.Jet.OLEDB.4.0;" +
            @"Data Source=MiFareKaarten.mdb;" +
            @"User ID=;Password=;";

            //Pak registratiepas nummer uit functie
            string RegistratiePasNummer = RegistratiePasID();

            //Toon output
            Console.WriteLine("UW ID IS:" + RegistratiePasNummer);

            //Als we geen error terugkrijgen uit functie
            if (RegistratiePasNummer != "Error")
            {
                //Maak strings voor output en query
                string ReturnDBData = "SELECT * FROM MiFareDB WHERE KaartNummer = '" + RegistratiePasNummer + "'";
                string Voornaam = "";
                string Achternaam = "";
                string Punten = "";
                //Nieuwe OleDB connectie
                OleDbConnection connection = new OleDbConnection(ConnectionString);
                //Maak connectie en voer query uit
                using (OleDbCommand command = new OleDbCommand(ReturnDBData, connection))
                {
                    //Error als er geen gegevens inkomen
                    ReturnDBData = "User not found";
                    //Open connectie
                    connection.Open();
                    //Voer leesquery uit
                    OleDbDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        //Schrijf gegevens uit database naar strings
                        Voornaam = reader[1].ToString();
                        Achternaam = reader[2].ToString();
                        Punten = reader[3].ToString();
                    }
                    //Sluit reader
                    reader.Close();
                    //Geef messagebox met gegevens en punten van gebruiker
                    MessageBox.Show(String.Format("Deze pas is van: {0} {1}. Deze gebruiker heeft: {2} punten.", Voornaam, Achternaam, Punten));
                }
            }
        }

        
        //Lees pas uit en toon gegevens over pas (ManNummer, Chiptype)
        public void LeesPasUit()
        {

            Console.WriteLine("Begin met uitlezen van pas");

            //Kijk of lezer connected is
            IReaderProvider readerProvider = new PCSCReaderProvider();


            //Lezen uit kaart object
            IReaderUnit readerUnit = readerProvider.CreateReaderUnit();

            //Als USB connectie er is
            if (readerUnit.ConnectToReader())
            {
                //Wacht 15 seconden op een kaart
                if (readerUnit.WaitInsertion(1500000))
                {
                    Console.WriteLine("Plaats uw kaart");
                    //Als er connectie met een kaart is
                    if (readerUnit.Connect())
                    {

                        //Schrijf connectie
                        Console.WriteLine("CONNECTIE");

                        //Pak chip uit de kaart
                        chip chip = readerUnit.GetSingleChip();

                        //Schrijf chip type
                        Console.WriteLine("Card type: {0}", chip.Type);

                        ////Schrijf manufacture nummer
                        Console.WriteLine("Card unique Manu Number: {0}", readerUnit.GetNumber(chip));
                        string deLijn = readerUnit.GetNumber(chip);


                        //Wat sudo code om t kijken of chip naar chip.commands luistert van MiFare (Werkt)
                        //if (chip is IDESFireChip)
                        //{
                        //    ICommands cmd = chip.Commands;
                        //    if (cmd is IDESFireEV1Commands)
                        //    {
                        //        Console.WriteLine("Mifare YUPPP");
                        //    }
                        //}

                        //Netjes disconnecten
                        readerUnit.Disconnect();
                    }


                    //Remove kaart message
                    Console.WriteLine("Remove card");

                }

                //Disconnect met USB
                readerUnit.Disconnect();
            }
            

        }


        public void KenPuntToe(string Mod)
        {
            Boolean Error = false;
            Boolean ErrorPunten = false;
            if(Mod == "+" && tbAantalPuntjes.Text == "")
            {
                Error = true;
                MessageBox.Show("Voeg aub een getal in!!");
                return;
            }
            //Pak ManID van pas
            string registratiePas = RegistratiePasID();
            //Kijk of error terugkomt
            if (registratiePas == "Error")
            {
                //Error, doe niks
            }
            else
            {
                //Schrijf registratie ID
                Console.WriteLine("Registratie voor " + registratiePas);
                //Maak booleans voor error catching
                
                //Maak standaard int voor Punten (voor return)
                int PuntAantal = 0;
                //Maak connectiestring
                string ConnectionString =
                @"Provider=Microsoft.Jet.OLEDB.4.0;" +
                @"Data Source=MiFareKaarten.mdb;" +
                @"User ID=;Password=;";
                //Maak query aan en strings om te vullen
                string ReturnDBData = "SELECT Punten, Voornaam FROM MiFareDB WHERE KaartNummer = '" + registratiePas + "'";
                string Punten = "";
                string Voornaam = "";
                //Int om te rekenen met punten
                int ToevoegenPunten = 0;
                //Connectie naar DB
                OleDbConnection connection = new OleDbConnection(ConnectionString);
                using (OleDbCommand commando = new OleDbCommand(ReturnDBData, connection))
                {
                    connection.Open();
                    OleDbDataReader reader = commando.ExecuteReader();

                    while (reader.Read())
                    {
                        //Vul strings met gegevens uit DB
                        Punten = reader[0].ToString();
                        Voornaam = reader[1].ToString();
                        Console.WriteLine(Punten);
                    }
                    reader.Close();
                }
                try
                {
                    //Probeer punten te converten
                    PuntAantal = Convert.ToInt32(Punten);
                }
                catch (Exception)
                {
                    //Fout op conversion --> Kaart issues
                    MessageBox.Show("Kaart niet goed uitgelezen");
                }
                
                //Als er punten toegevoegd moeten worden
                if (Mod == "+")
                {
                    try
                    {
                        ToevoegenPunten = Convert.ToInt32(tbAantalPuntjes.Text);
                        PuntAantal +=ToevoegenPunten;
                    }
                    catch (Exception)
                    {
                        Error = true;
                        MessageBox.Show("Voeg aub een getal in!!");
                    }
                }

                else
                {          
                    
                    //Kijk of punten niet negatief worden
                    if (PuntAantal < 10)
                    {
                        //Anders error
                        ErrorPunten = true;
                        MessageBox.Show("Helaas heeft u niet genoeg punten om koffie te kopen.");
                    }
                    else
                    {   
                        //Niet +? Dan -!
                        PuntAantal -= 10;
                    }
                    
                }
                //Geen error?
                if (!ErrorPunten)
                {
                    //Nieuwe database command
                    OleDbCommand command = new OleDbCommand();
                    //Maak update commando aan
                    command.CommandType = CommandType.Text;
                    command.CommandText = "UPDATE MiFareDB SET Punten=@Punten where KaartNummer = '" + registratiePas + "'";
                    command.Parameters.AddWithValue("@Punten", PuntAantal);
                    command.Connection = connection;
                    command.ExecuteNonQuery();
                    connection.Close();
                    //Error
                    if (Error)
                    {
                        MessageBox.Show("Database error");
                    }
                    else
                    {
                        //Als +, geef bijhorende zin
                        if (Mod == "+")
                        {
                            MessageBox.Show("Punten voor " + Voornaam + " zijn toegekend! Aantal punten is nu: " + PuntAantal);
                        }
                        //Als -, geef bijhorende zin
                        else
                        {
                            MessageBox.Show(Voornaam + " heeft betaald met zijn punten! Aantal punten is nu: " + PuntAantal);
                        }

                    }
                }
            }

        }
        //LeesPasUit Knop
        
        //LeesGegevensUit Knop
        
        //PuntGeven
       
        //KoffieKopen
        

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            materialLabel1.Text = "STATUS: READING";
            this.Refresh();
            LeesPasUit();
            materialLabel1.Text = "STATUS: IDLE";
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            materialLabel1.Text = "STATUS: READING";
            this.Refresh();
            LeesGegevensUitDB();
            materialLabel1.Text = "STATUS: IDLE";
        }

        private void materialRaisedButton3_Click(object sender, EventArgs e)
        {
            materialLabel1.Text = "STATUS: READING";
            this.Refresh();
            KenPuntToe("+");
            materialLabel1.Text = "STATUS: IDLE";
        }

        private void materialRaisedButton4_Click(object sender, EventArgs e)
        {
            materialLabel1.Text = "STATUS: READING";
            this.Refresh();
            KenPuntToe("-");
            materialLabel1.Text = "STATUS: IDLE";
        }
    }
}

