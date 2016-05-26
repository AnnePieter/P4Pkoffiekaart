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

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int login = 0;
        public string RegistratiePasID()
        {

            //Kijk of lezer connected is
            IReaderProvider readerProvider = new PCSCReaderProvider();

            //Lezen uit kaart object
            IReaderUnit readerUnit = readerProvider.CreateReaderUnit();

            //Als USB connectie er is
            if (readerUnit.ConnectToReader())
            {

                string ManNummer = "Pas niet in gebruik";
                //Wacht 15 seconden op een kaart
                Console.WriteLine("Bied uw kaart aan aan de lezer");
                try {
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
                catch(Exception)
                {

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
                    label1.Text = Voornaam + Achternaam;
                    label2.Text = Punten;
                    //Sluit reader
                    reader.Close();
                    //Geef messagebox met gegevens en punten van gebruiker
                    MessageBox.Show(String.Format("Deze pas is van: {0} {1}. Deze gebruiker heeft: {2} punten.", Voornaam, Achternaam, Punten));
                }
            }
        }


        //Lees pas uit en toon gegevens over pas (ManNummer, Chiptype)
        public void Login()
        {
            Console.WriteLine("Begin met uitlezen van pas");

            //Kijk of lezer connected is
            IReaderProvider readerProvider = new PCSCReaderProvider();


            //Lezen uit kaart object
            IReaderUnit readerUnit = readerProvider.CreateReaderUnit();

            //Als USB connectie er is
            if (readerUnit.ConnectToReader())
            {
                try
                {
                    //Wacht 15 seconden op een kaart
                    if (readerUnit.WaitInsertion(1500000))
                    {
                        Console.WriteLine("Plaats uw kaart");

                        //Als er connectie met een kaart is
                        try
                        {
                            if (readerUnit.Connect())
                            {

                                //Schrijf connectie
                                Console.WriteLine("CONNECTIE");

                                //Pak chip uit de kaart
                                chip chip = readerUnit.GetSingleChip();

                                if (chip.Type == "")
                                {
                                    login = 1;
                                }
                                else
                                {
                                    return;
                                }
                                    //Schrijf chip type
                                    Console.WriteLine("Card type: {0}", chip.Type);

                                ////Schrijf manufacture nummer
                                Console.WriteLine("Card unique Manu Number: {0}", readerUnit.GetNumber(chip));
                                string deLijn = readerUnit.GetNumber(chip);

                                //Netjes disconnecten
                                readerUnit.Disconnect();
                            }
                        }
                        catch (Exception)
                        {

                        }


                        //Remove kaart message
                        Console.WriteLine("Remove card");

                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Geen kaartlezer aangesloten");
                }

                //Disconnect met USB
                readerUnit.Disconnect();
            }



        }


        public void VoegToe(string Mod)
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
            if (Mod == "telefoon")
            {
                //Maak strings voor output en query
                string ReturnDBData = "UPDATE MiFareDB SET telefoon = '"+ RegistratiePasID() +"' WHERE KaartNummer = '" + RegistratiePasNummer + "'";
                //Nieuwe OleDB connectie
                OleDbConnection connection = new OleDbConnection(ConnectionString);
                //Maak connectie en voer query uit
                using (OleDbCommand command = new OleDbCommand(ReturnDBData, connection))
                {
                    //Error als er geen gegevens inkomen
                    ReturnDBData = "User not found";
                    //Open connectie
                    connection.Open();
                    command.ExecuteNonQuery();
                }

            }
            else if (Mod == "bankpas")
            {
                //Maak strings voor output en query
                string ReturnDBData = "UPDATE MiFareDB SET bankpas = '" + RegistratiePasID() + "' WHERE KaartNummer = '" + RegistratiePasNummer + "'";
                //Nieuwe OleDB connectie
                OleDbConnection connection = new OleDbConnection(ConnectionString);
                //Maak connectie en voer query uit
                using (OleDbCommand command = new OleDbCommand(ReturnDBData, connection))
                {
                    //Error als er geen gegevens inkomen
                    ReturnDBData = "User not found";
                    //Open connectie
                    connection.Open();
                    command.ExecuteNonQuery();
                }

            }
            if (Mod == "ov")
            {
                //Maak strings voor output en query
                string ReturnDBData = "UPDATE MiFareDB SET ov = '" + RegistratiePasID() + "' WHERE KaartNummer = '" + RegistratiePasNummer + "'";
                //Nieuwe OleDB connectie
                OleDbConnection connection = new OleDbConnection(ConnectionString);
                //Maak connectie en voer query uit
                using (OleDbCommand command = new OleDbCommand(ReturnDBData, connection))
                {
                    //Error als er geen gegevens inkomen
                    ReturnDBData = "User not found";
                    //Open connectie
                    connection.Open();
                    command.ExecuteNonQuery();
                }

            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Refresh();
            Login();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(login == 1)
            {
                login = 0;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (login == 1)
            {
                VoegToe("telefoon");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (login == 1)
            {
                VoegToe("bankpas");
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (login == 1)
            {
                VoegToe("ov");
            }

        }
    }
}
