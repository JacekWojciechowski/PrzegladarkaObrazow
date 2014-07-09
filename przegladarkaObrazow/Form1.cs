using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Windows;
using System.Windows.Input;

namespace przegladarkaObrazow
{

   
    public partial class Form1 : Form
    {
        private string plik;
        public Form1(string []arg)
        {            
            InitializeComponent();
            foreach(string s in arg)      //zapisuje ścieżkę do otwieranego pliku
                plik += s;
        }



        public class Wczytaj
        {
            public  int licznikObrotu = 0;  //liczy ile razy obrócono zdjęcie
            private  List<string> lista;     //lista plików z obecnego folderu
            private int obecny;             //numer aktualnego pliku
            private DirectoryInfo pobierz;  //informacje o katalogu, w którym znajduje się otwarty plik
            private PictureBox box;         //picturebox, w którym wyświetlane jest zdjęcie
            private string sciezka;         //zmienna do przechowywania aktualnej sciezki do pliku
            
            //Właściwość pobierająca nazwę obecnego pliku do wyświetlenia w Form1.Text
            public string Tytul
            {
                get
                {
                    return lista[obecny];
                }
                
            }
        
            //wczytywanie listy plików bieżącego katalogu
            private void wczytajListe(OpenFileDialog otworz)
            {
                lista = new List<string>();
                pobierz = new DirectoryInfo(Path.GetDirectoryName(otworz.FileName).ToString());
                foreach (var fi in pobierz.EnumerateFiles("*.jpg")  //dopisywanie do listy plików rozszerzeń
                    .Concat(pobierz.EnumerateFiles("*.png"))
                    .Concat(pobierz.EnumerateFiles("*.tif"))
                    .Concat(pobierz.EnumerateFiles("*.bmp"))
                    .Concat(pobierz.EnumerateFiles("*.jpeg")))   
                {
                    lista.Add(fi.Name.ToString());      
                }
                for (int a = 0; a < lista.Count; a++) //pętla, która wyszukuje obecny plik i zapisuje jego indeks z listy
                {
                    if (lista[a] == otworz.SafeFileName)
                        obecny = a;
                }
            }
           
            //wyświetlenie aktualnego pliku
            public void aktualny(PictureBox ten)
            {
                box = ten;
                OpenFileDialog otworz = new OpenFileDialog();
                otworz.InitialDirectory = sciezka;
                otworz.Filter = "Obrazy|*.jpg;*.jpeg;*.png;*.tif;*.bmp" ;
                if (otworz.ShowDialog() == DialogResult.OK)
                {                   
                    wczytajListe(otworz);
                    sciezka = pobierz.FullName;
                    box.Image = Image.FromFile(pobierz.FullName + "\\" + lista[obecny]);
                }
             }

            //wyświetlenie pliku wybranego poza programem, np. w eksploratorze windows
            public void aktualnyWindows(string s, PictureBox ten)
            {
                sciezka = Path.GetDirectoryName(s);
                box = ten;
                OpenFileDialog otworz = new OpenFileDialog();
                otworz.FileName = s;              
                wczytajListe(otworz);                
                box.Image = Image.FromFile(pobierz.FullName + "\\" + lista[obecny]);
                
                
            }           

            //wyświetlenie następnego pliku z wczytanej listy
            public void nastepny()
            {
                if (obecny < lista.Count - 1)
                {
                    obecny++;
                    box.Image = Image.FromFile(pobierz.FullName + "\\" + lista[obecny]);
                }
                else
                {
                    obecny = 0;
                    box.Image = Image.FromFile(pobierz.FullName + "\\" + lista[obecny]);
                }
            }

            //wczytanie poprzedniego pliku z wczytanej listy
            public void poprzednie()
            {
                if (obecny > 0)
                {
                    obecny--;
                    box.Image = Image.FromFile(pobierz.FullName + "\\" + lista[obecny]);
                }
                else
                {
                    obecny = lista.Count-1;
                    box.Image = Image.FromFile(pobierz.FullName + "\\" + lista[obecny]);
                }
            }

            //obrócenie obrazu w lewo
            public void obrocLewo()
            {                
                if (licznikObrotu == 0)
                {
                    box.Image = Image.FromFile(pobierz.FullName + "\\" + lista[obecny]);
                    box.Image.RotateFlip(RotateFlipType.Rotate90FlipX);
                    licznikObrotu++;
                }
                else if (licznikObrotu == 1)
                {
                    box.Image = Image.FromFile(pobierz.FullName + "\\" + lista[obecny]);
                    box.Image.RotateFlip(RotateFlipType.Rotate180FlipX);
                    licznikObrotu++;
                }
                else if (licznikObrotu == 2)
                {
                    box.Image = Image.FromFile(pobierz.FullName + "\\" + lista[obecny]);
                    box.Image.RotateFlip(RotateFlipType.Rotate270FlipX);
                    licznikObrotu++;
                }
                else
                {
                    box.Image = Image.FromFile(pobierz.FullName + "\\" + lista[obecny]);
                    licznikObrotu = 0;
                }    
            }

            //obrócenie obrazu w prawo
            public void obrocPrawo()
            {
                if (licznikObrotu == 0)
                {
                    box.Image = Image.FromFile(pobierz.FullName + "\\" + lista[obecny]);
                    box.Image.RotateFlip(RotateFlipType.Rotate270FlipX);
                    licznikObrotu = 3;
                }
                else if (licznikObrotu == 1)
                {
                    box.Image = Image.FromFile(pobierz.FullName + "\\" + lista[obecny]);                   
                    licznikObrotu = 0; ;
                }
                else if (licznikObrotu == 2)
                {
                    box.Image = Image.FromFile(pobierz.FullName + "\\" + lista[obecny]);
                    box.Image.RotateFlip(RotateFlipType.Rotate90FlipX);
                    licznikObrotu = 1;
                }
                else if (licznikObrotu == 3)
                {
                    box.Image = Image.FromFile(pobierz.FullName + "\\" + lista[obecny]);
                    box.Image.RotateFlip(RotateFlipType.Rotate180FlipX);
                    licznikObrotu = 2;
                }
                else
                {
                    box.Image = Image.FromFile(pobierz.FullName + "\\" + lista[obecny]);
                    licznikObrotu = 0;
                }
            }
            
        }

        //POCZĄTEK PROGRAMU

        Wczytaj obraz = new Wczytaj();  //tworzymy obiekt klasy Wczytaj
        bool PokazWlaczony = false;     // zmienna, która sprawdza, czy pokaz slajdów jest wł/wył
        

        private void btnWczytaj_Click(object sender, EventArgs e)
        {
            obraz.licznikObrotu = 0;
            obraz.aktualny(pictureBox);
            btnNastepne.Enabled = true;
            btnPoprzednie.Enabled = true;
            btnObrotLewo.Enabled = true;
            btnObrocPrawo.Enabled = true;
            btnPokazSlajdow.Enabled = true;
            this.Text = obraz.Tytul + " - Przegladarka Zdjęć";
        }


        private void btnNastepne_Click(object sender, EventArgs e)
        {
            obraz.licznikObrotu = 0;
            obraz.nastepny();
            this.Text = obraz.Tytul + " - Przegladarka Zdjęć";
        }

        private void btnPoprzednie_Click(object sender, EventArgs e)
        {
            obraz.licznikObrotu = 0;
            obraz.poprzednie();
            this.Text = obraz.Tytul + " - Przegladarka Zdjęć";
        }

        private void btnObrotLewo_Click(object sender, EventArgs e)
        {
            obraz.obrocLewo();
        }

        private void btnObrocPrawo_Click(object sender, EventArgs e)
        {
            obraz.obrocPrawo();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (plik != null)    //sprawdzamy, czy nie otwarto pliku poza programem, np. eksplorator windows
            {
                obraz.licznikObrotu = 0;
                btnNastepne.Enabled = true;
                btnPoprzednie.Enabled = true;
                btnObrotLewo.Enabled = true;
                btnObrocPrawo.Enabled = true;
                btnPokazSlajdow.Enabled = true;
                obraz.aktualnyWindows(plik, pictureBox);
                this.Text = obraz.Tytul + " - Przegladarka Zdjęć";
            }              
         }        

        //metoda do obługi klawiatury - zdarzenie z Form1_KeyDown
        private void Klawiatura_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Space)
                {
                    panel2.Focus();
                    btnNastepne_Click(sender, e);
                }
                else  if (e.KeyCode == Keys.Oemcomma)
                {    
                    btnPoprzednie_Click(sender, e);
                    btnPoprzednie.Focus();
                    
                }
                else if (e.KeyCode == Keys.OemPeriod)
                {
                    btnNastepne_Click(sender, e);
                    btnNastepne.Focus();
                }
                else if (e.KeyCode == Keys.N)
                {
                    btnObrotLewo_Click(sender, e);
                    btnObrotLewo.Focus();
                }
                else if (e.KeyCode == Keys.M)
                {
                    btnObrocPrawo_Click(sender, e);
                    btnObrocPrawo.Focus();
                }
                else if (e.KeyCode == Keys.Enter)
                {
                    btnWczytaj.Focus();
                    btnWczytaj_Click(sender, e);
                }
                else if (e.KeyCode == Keys.ShiftKey)
                    btnPokazSlajdow_Click(sender, e);
                else if (e.KeyCode == Keys.Escape)
                    Application.Exit();
            }
            catch (Exception)
            {
                MessageBox.Show("Musisz najpierw wczytać zdjęcie!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           

        }

        //Timer do pokazu slajdów
        private void timer1_Tick(object sender, EventArgs e)
        {
            obraz.licznikObrotu = 0;
            obraz.nastepny();
            this.Text = obraz.Tytul + " - Przegladarka Zdjęć";
        }

        private void btnPokazSlajdow_Click(object sender, EventArgs e)
        { 
            if (!PokazWlaczony)
            {                
                comboCzas.Visible = true;
                comboCzas.Focus();
                btnPokazSlajdow.Image = global::przegladarkaObrazow.Properties.Resources.stop;
                timer1.Interval = Convert.ToInt32(comboCzas.Text)*1000;
                timer1.Enabled = true;
                PokazWlaczony = true;
            }
            else
            {
                comboCzas.Visible = false;
                btnPokazSlajdow.Image = global::przegladarkaObrazow.Properties.Resources.play;
                timer1.Enabled = false;
                PokazWlaczony = false;
            }
        }

        //zmiana czasu wyświetlania zdjęcia w comboBoxsie
        private void comboCzas_SelectedIndexChanged(object sender, EventArgs e)
        {
            timer1.Interval = Convert.ToInt32(comboCzas.Text) * 1000;
        }

        
     
        


        

       

      


        

     

       


       
    }
}
