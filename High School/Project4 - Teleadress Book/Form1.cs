using System;
using System.IO;
using System.Windows.Forms;

namespace Zadanie_6
{
    public partial class Form1 : Form
    {
        string otwórz;
        bool subitem;

        public Form1()
        {
            InitializeComponent();
        }

        private void updateStatusbar()
        {
            string temp;
            if (this.listView1.SelectedIndices.Count == 0) temp = "?/";
            else temp = (this.listView1.SelectedIndices[0] + 1) + "/";
            temp += this.listView1.Items.Count;
            status.Text = temp;
        }

        private void updateZapisz()
        {
            if (listView1.Items.Count > 0) zapiszToolStripButton.Enabled= zapiszToolStripMenuItem.Enabled = true;
            else zapiszToolStripButton.Enabled = zapiszToolStripMenuItem.Enabled = false;
        }

        private void updateEdytujAndUsuń()
        {
            if (listView1.SelectedIndices.Count > 0)
                usuńButton.Enabled = usuńKontaktToolStripMenuItem.Enabled = usuńToolStripButton.Enabled =
                usuńKontaktContextMenuStrip.Enabled =
                edytujButton.Enabled = edytujKontaktToolStripMenuItem.Enabled = edytujToolStripButton.Enabled =
                edytujKontaktContextMenuStrip.Enabled = true;
            else usuńButton.Enabled = usuńKontaktToolStripMenuItem.Enabled = usuńToolStripButton.Enabled =
                 usuńKontaktContextMenuStrip.Enabled =
                 edytujButton.Enabled = edytujKontaktToolStripMenuItem.Enabled = edytujToolStripButton.Enabled =
                 edytujKontaktContextMenuStrip.Enabled = false;
        }

        private void wyjścieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void inforamcjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Edytor kontaktów\nWersja 1.00\n(C) Martyna Kaźmierczak", "O programie", MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void usuńButton_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Czy napewno chcesz usunąć kontakt ?", "Ostrzeżenie", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)) == DialogResult.Yes)
                listView1.Items[listView1.SelectedIndices[0]].Remove();
            else listView1.Focus();
            updateStatusbar();
            updateZapisz();
        }

        private void dodajButton_Click(object sender, EventArgs e)
        {
            Form2 okno = new Form2();
            okno.Text = "Dodaj kontakt";
            if (okno.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ListViewItem temp = okno.getItem();
                if (listView1.SelectedIndices.Count == 0) listView1.Items.Add(temp);
                else listView1.Items.Insert(listView1.SelectedIndices[0], temp);
                updateZapisz();
                updateStatusbar();
            }
        }

        private void edytujButton_Click(object sender, EventArgs e)
        {
            Form2 okno = new Form2();
            okno.Text = "Edytuj kontakt";
            okno.setItem(listView1.Items[listView1.SelectedIndices[0]]);
            if (okno.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                listView1.Items[listView1.SelectedIndices[0]] = okno.getItem();
        }

        private void otwórzToolStripButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog1 = new OpenFileDialog())
                try
                {
                    openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                    openFileDialog1.DefaultExt = "csv";
                    openFileDialog1.Title = "Otwórz plik";
                    openFileDialog1.Filter = "Dokumenty tekstowe (*.csv) | *.csv";
                    if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        while (0 < listView1.Items.Count) listView1.Items[0].Remove();                        
                        FileStream src = new FileStream(openFileDialog1.FileName, FileMode.Open);
                        StreamReader reader = new StreamReader(src, System.Text.Encoding.Default);
                        int numerWiersza = 0;
                        bool sprawdzPoprawnośćPliku = true;
                        do
                        {
                            byte licznik = 0; 
                            string str = reader.ReadLine();
                            ListViewItem wiersz = new ListViewItem();
                            if (str != null)
                            {
                                if (sprawdzPoprawnośćPliku == true)
                                {
                                    string formatPliku = "Imię,Nazwisko,Adres,Numer telefonu,Adres e-mail";
                                    if (str.CompareTo(formatPliku) != 0)
                                    {
                                        MessageBox.Show("To nie jest poprawny plik z danymi programu", "Błąd odczytu pliku");
                                        src.Close();
                                        return;
                                    }
                                    else sprawdzPoprawnośćPliku = false;
                                }
                                else
                                {
                                    foreach (char x in str)
                                    {
                                        if (subitem == false)
                                        {
                                            if (x != ',') otwórz += x;
                                            else { wiersz.Text = otwórz; otwórz = null; subitem = true; licznik++; }
                                        }
                                        else
                                        {
                                            if (x != ',') otwórz += x;
                                            else { wiersz.SubItems.Add(otwórz); otwórz = null; licznik++; }
                                        }
                                    }
                                    wiersz.SubItems.Add(otwórz);
                                    otwórz = null;
                                    subitem = false;
                                    listView1.Items.Add(wiersz);
                                    licznik++;
                                    numerWiersza++;
                                    if (licznik != 5)
                                    {
                                        MessageBox.Show("Brak danych w jednej z kolumn wierszu nr: " + numerWiersza +
                                            ".\nWiersz zostanie usunięty!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        listView1.Items.Remove(wiersz);
                                    }
                                }
                            }
                            else break;
                        } while (true);
                    }
                }
                catch (Exception errorMsg) { MessageBox.Show(errorMsg.Message, "Błąd odczytu pliku", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            updateZapisz();
            updateStatusbar();
        }

        private void zapiszToolStripButton_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog1 = new SaveFileDialog())
                try
                {
                    saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                    saveFileDialog1.DefaultExt = "csv";
                    saveFileDialog1.Title = "Zapisz plik";
                    saveFileDialog1.FileName = "Bez nazwy";
                    saveFileDialog1.Filter = "Dokumenty tekstowe (*.csv)|*.csv";
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        FileStream destFS;
                        destFS = new FileStream(saveFileDialog1.FileName, FileMode.Create);
                        StreamWriter destSW = new StreamWriter(destFS, System.Text.Encoding.Default);
                        string wiersz = null, kolumny = null;
                        for (int i = 0; i < listView1.Columns.Count; i++)
                        {
                            if (i < listView1.Columns.Count - 1) kolumny += listView1.Columns[i].Text + ',';
                            else kolumny += listView1.Columns[i].Text;
                        } destSW.WriteLine(kolumny);

                        for (int i = 0; i < listView1.Items.Count; i++)
                        {
                            wiersz = listView1.Items[i].Text + ',';
                            for (int j = 1; j < 5; j++)
                            {
                                if (j < 4) wiersz += listView1.Items[i].SubItems[j].Text + ',';
                                else wiersz += listView1.Items[i].SubItems[j].Text;
                            } 
                            destSW.WriteLine(wiersz);
                        }
                        destSW.Close();
                    }
                }
                catch (Exception errorMsg)
                {
                    MessageBox.Show(errorMsg.Message, "Błąd odczytu pliku", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateStatusbar();
            updateEdytujAndUsuń();
        }
    }
}
