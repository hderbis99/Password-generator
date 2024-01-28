using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Generator_Hasel_Graficzny
{
    public partial class Generator_V2 : Form
    {
        public Generator_V2()
        {
            InitializeComponent();
        }

        private void Button_Gen_Click(object sender, EventArgs e)
        {
            TxtOne.Text = GenRandom();

            if (chBOne.Checked)
            {
                // Jeżeli checkBox kilknięty to zapisz hasło do pliku.
                SaveToFile(TxtOne.Text, TxtTwo.Text);
            }
        }
        static string GenRandom()
        {
            Random random = new Random();
            const string znaki = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()_+";
            char[] losoweZnaki = new char[15];

            for (int i = 0; i < 15; i++)
            {
                int indeks = random.Next(znaki.Length);
                losoweZnaki[i] = znaki[indeks];
            }

            return new string(losoweZnaki);
        }

        private void chBOne_CheckedChanged(object sender, EventArgs e)
        {
            /*
            string katalogProgramu = AppDomain.CurrentDomain.BaseDirectory;
            string sciezkaDoPliku = Path.Combine(katalogProgramu, "MojPlik.txt");
            */
        }
        private void SaveToFile(string txt, string label)
        {
            try
            {
                // Uzyskaj dynamiczną ścieżkę do katalogu, w którym znajduje się program
                string katalogProgramu = AppDomain.CurrentDomain.BaseDirectory;

                // Utwórz pełną ścieżkę do pliku w katalogu programu
                string sciezkaDoPliku = Path.Combine(katalogProgramu, "Hasla.txt");

                // Utwórz tekst do zapisu, dodając etykietę obok hasła (jeśli etykieta nie jest pusta)
                string tekstDoZapisu = label.Length > 0 ? $"{txt} /{label}" : txt;

                // Zapisz tekst do pliku (dodaj do istniejącej zawartości)
                File.AppendAllText(sciezkaDoPliku, tekstDoZapisu + Environment.NewLine);

                MessageBox.Show("Hasło zostało zapisane do pliku: " + sciezkaDoPliku, "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił błąd podczas zapisu do pliku: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            UsunOstatniaPozycjeZPliku();
        }

        private void btn_Delete_All_Click(object sender, EventArgs e)
        {
            UsunWszystkoZPliku();
        }
        private void UsunOstatniaPozycjeZPliku()
        {
            try
            {
                string katalogProgramu = AppDomain.CurrentDomain.BaseDirectory;
                string sciezkaDoPliku = Path.Combine(katalogProgramu, "Hasla.txt");

                if (File.Exists(sciezkaDoPliku))
                {
                    string[] lines = File.ReadAllLines(sciezkaDoPliku);

                    if (lines.Length > 0)
                    {
                        // Usuń ostatnią pozycję z pliku
                        Array.Resize(ref lines, lines.Length - 1);

                        // Nadpisz plik aktualną zawartością
                        File.WriteAllLines(sciezkaDoPliku, lines);

                        MessageBox.Show("Ostatnia pozycja została usunięta z pliku.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Plik jest pusty.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Plik nie istnieje.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił błąd podczas usuwania ostatniej pozycji z pliku: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UsunWszystkoZPliku()
        {
            try
            {
                string katalogProgramu = AppDomain.CurrentDomain.BaseDirectory;
                string sciezkaDoPliku = Path.Combine(katalogProgramu, "Hasla.txt");

                if (File.Exists(sciezkaDoPliku))
                {
                    // Usuń całą zawartość pliku
                    File.WriteAllText(sciezkaDoPliku, "");

                    MessageBox.Show("Wszystkie pozycje zostały usunięte z pliku.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Plik nie istnieje.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił błąd podczas usuwania wszystkich pozycji z pliku: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }   
}
