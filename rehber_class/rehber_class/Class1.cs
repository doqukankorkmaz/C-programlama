using MySql.Data.MySqlClient;
using Org.BouncyCastle.Ocsp;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace rehber_class
{
    internal class INIKaydet
    {
        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);
        public INIKaydet(string dosyaYolu)
        {
            DOSYAYOLU = dosyaYolu;
        }
        private string DOSYAYOLU = String.Empty;
        public string Varsayilan { get; set; }
        public string Oku(string bolum, string ayaradi)
        {
            Varsayilan = Varsayilan ?? String.Empty;
            StringBuilder StrBuild = new StringBuilder(256);
            GetPrivateProfileString(bolum, ayaradi, Varsayilan, StrBuild, 255, DOSYAYOLU);
            return StrBuild.ToString();
        }
        public long Yaz(string bolum, string ayaradi, string deger)
        {
            return WritePrivateProfileString(bolum, ayaradi, deger, DOSYAYOLU);
        }
    }

    internal class rehber
    {
        string sunucu;
        string kullaniciad;
        string sifre;
        string veritabani;
        string server;
        string database;
        string uid;
        string pwd;

        public string Sunucu { get { return sunucu; } set { sunucu = value; } }
        public string kullaniciAd { get { return kullaniciad; } set { kullaniciad = value; } }
        public string Sifre { get { return sifre; } set { sifre = value; } }
        public string veriTabani { get { return veritabani; } set { veritabani = value; } }
        public string Server { get { return server; } set { server = value; } }
        public string Database { get { return database; } set { database = value; } }
        public string Uid { get { return uid; } set { uid = value; } }
        public string Pwd { get { return pwd; } set { pwd = value; } }
    }
    internal class rehbersinif
    {
        MySqlConnection baglan = new MySqlConnection(
            "server='localhost';" +
            "Database='user';" +
            "Uid='root';" +
            "Pwd='123456';");
        public void kullanicigiris(rehber giris)
        {
            baglan.Open();
            string sql = $"select * from kullanici where kullaniciad='{giris.kullaniciAd}' and sifre='{giris.Sifre}'";
            MySqlCommand komut = new MySqlCommand(sql, baglan);
            MySqlDataReader oku = komut.ExecuteReader();
            if (oku.Read())
            {
                Form2 frm = new Form2();
                frm.Show();

            }
            else
            {
                MessageBox.Show("Hatalı kullanıcı adı veya şifre");
            }
        }



        public static bool baglantikontrol(string server, string database, string username, string password)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection(
                $"server='{server}';" +
                $"Database='{database}';" +
                $"Uid='{username}';" +
                $"Pwd='{password}';");
                connection.Open();
                connection.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool tablo_olustur(string server, string database, string username, string password)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection(
                $"server='{server}';" +
                $"Database='{database}';" +
                $"Uid='{username}';" +
                $"Pwd='{password}';");
                string sql = "create table if not exists rehber (numara int, ad varchar(20), soyad varchar(20), adres varchar(50))";
                connection.Open();
                MySqlCommand command = new MySqlCommand(sql, connection);
                command.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }


    }
 



    public class MyDatabaseClass
    {
        private readonly string _server;
        private readonly string _database;
        private readonly string _uid;
        private readonly string _pwd;

        public MyDatabaseClass(string server, string database, string uid, string pwd)
        {
            _server = server;
            _database = database;
            _uid = uid;
            _pwd = pwd;
        }

        public DataTable GetRehber()
        {
            string connectionString = $"server='{_server}';" +
                                       $"Database='{_database}';" +
                                       $"Uid='{_uid}';" +
                                       $"Pwd='{_pwd}';";

            string sql = "select * from rehber";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(sql, connection))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
        }
    }


    

}
