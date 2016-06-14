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
        private void Form1_Load(object sender, EventArgs e)
        {
            Timer timer = new Timer();
            timer.Interval = (1000);
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            this.Refresh();
        }
        public int login = 0;
        string username;
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
                string ReturnDBData = "SELECT * FROM MiFareDB WHERE KaartNummer = '" + username + "'";
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


                        label1.Text = Voornaam + Achternaam;
                        label2.Text = Punten;
                        label3.Text = reader[4].ToString();
                        label4.Text = reader[5].ToString();
                        label5.Text = reader[6].ToString();
                        
                    }
                    //Sluit reader
                    reader.Close();
                }
            }
        }


        //Lees pas uit en toon gegevens over pas (ManNummer, Chiptype)
        public void Login()
        {

            string ConnectionString =
            @"Provider=Microsoft.Jet.OLEDB.4.0;" +
            @"Data Source=MiFareKaarten.mdb;" +
            @"User ID=;Password=;";

            //Maak strings voor output en query
            string ReturnDBData = "SELECT KaartNummer FROM MiFareDB";
            //Nieuwe OleDB connectie
            OleDbConnection connection = new OleDbConnection(ConnectionString);
            //Maak connectie en voer query uit
            using (OleDbCommand command = new OleDbCommand(ReturnDBData, connection))
            {
                //Error als er geen gegevens inkomen
                //Open connectie
                connection.Open();
                command.ExecuteNonQuery();


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

                                    if (chip.Type == "DESFire")
                                    {
                                        login = 1;
                                        username = RegistratiePasID();
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
                string ReturnDBData = "UPDATE MiFareDB SET Telefoon = '"+ RegistratiePasID() +"' WHERE KaartNummer = '" + username + "'";
                //Nieuwe OleDB connectie
                OleDbConnection connection = new OleDbConnection(ConnectionString);
                //Maak connectie en voer query uit
                using (OleDbCommand command = new OleDbCommand(ReturnDBData, connection))
                {
                    //Error als er geen gegevens inkomen
                    //Open connectie
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }

            }
            else if (Mod == "bankpas")
            {
                //Maak strings voor output en query
                string ReturnDBData = "UPDATE MiFareDB SET Bankpas = '" + RegistratiePasID() + "' WHERE KaartNummer = '" +username + "'";
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
                    connection.Close();
                }

            }
            if (Mod == "ov")
            {
                //Maak strings voor output en query
                string ReturnDBData = "UPDATE MiFareDB SET OV = '" + RegistratiePasID() + "' WHERE KaartNummer = '" + username + "'";
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
                    connection.Close();
                }

            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Refresh();
            Login();
            LeesGegevensUitDB();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(login == 1)
            {
                login = 0;
                label1.Text = "naam";
                label2.Text = "punten";
                label3.Text = "telefoon";
                label4.Text = "bankpas";
                label5.Text = "OV";

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (login == 1)
            {
                VoegToe("telefoon");
                LeesGegevensUitDB();
                this.Refresh();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (login == 1)
            {
                VoegToe("bankpas");
                LeesGegevensUitDB();
                this.Refresh();
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (login == 1)
            {
                VoegToe("ov");
                LeesGegevensUitDB();
                this.Refresh();
            }

        }
    }
}
