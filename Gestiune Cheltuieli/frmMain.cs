using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Windows.Forms.DataVisualization.Charting;

namespace Gestiune_Cheltuieli
{
    public partial class frmMain : Form
    {
        public View viewCurent;
        public List<Eveniment> evenimente;
        public List<Notita> notite;
        public int maxIdEveniment;
        public int maxIdNotita;
        public int nrNotiteNecitite;
        public bool amModificat;
        public bool modificare;
        public int index;

        public frmMain()
        {
            InitializeComponent();

            viewCurent = View.Main;

            clhData.Width = 70;
            clhDetalii.Width = 350;
            clhPerioada.Width = 100;
            clhSuma.Width = 100;

            pnlNotite.Hide();
            pnlGrafic.Hide();
            pnlAdaugaEveniment.Hide();
            pnlMain.Show();

            evenimente = EvenimentReader.citesteEvenimente("evenimente.xml");
            maxIdEveniment = getMaxIdEveniment();

            notite = NotitaReader.citesteNotite("notite.xml");
            maxIdNotita = getMaxIdNotita();

            amModificat = false;
            modificare = false;

            afiseazaEvenimente();

            tmrEvenimente.Enabled = true;
        }


        public int getMaxIdEveniment()
        {
            int id = 0;

            foreach (Eveniment e in evenimente)
                if (e.id > id)
                    id = e.id;

            return id;
        }

        public int getMaxIdNotita()
        {
            int id = 0;

            foreach (Notita n in notite)
                if (n.id > id)
                    id = n.id;

            return id;
        }

        private void afiseazaEvenimente()
        {
            double sumaSubtotal = 0, sumaTotal = 0;

            lstEvenimente.Items.Clear();

            foreach (Eveniment ev in evenimente)
            {
                if ((ev.tipEveniment == TipEveniment.Cheltuiala && mnuAfiseazaCheltuieli.Checked == true) ||
                   (ev.tipEveniment == TipEveniment.Venit && mnuAfiseazaVenituri.Checked == true))
                {
                    ListViewItem item = new ListViewItem(Convert.ToString(ev.data.Date));

                    item.UseItemStyleForSubItems = false;

                    item.Tag = (object)ev.id;

                    item.SubItems.Add(ev.detalii);

                    if (ev.perioada == PerioadaEveniment.OdataLaXZile)
                    {
                        item.SubItems.Add("odata la " + ev.xZile + " zile");
                    }
                    else
                    {
                        if (ev.perioada == PerioadaEveniment.Lunar)
                            item.SubItems.Add("lunar");
                        else if (ev.perioada == PerioadaEveniment.Saptamanal)
                            item.SubItems.Add("saptamanal");
                        else if (ev.perioada == PerioadaEveniment.AltTip)
                            item.SubItems.Add(" - ");
                    }

                    if (ev.tipEveniment == TipEveniment.Cheltuiala)
                        item.SubItems.Add(Convert.ToString(ev.suma), Color.Red, Color.White, lstEvenimente.Font);
                    else
                        item.SubItems.Add(Convert.ToString(ev.suma), Color.Green, Color.White, lstEvenimente.Font);

                    lstEvenimente.Items.Add(item);

                    if (ev.tipEveniment == TipEveniment.Cheltuiala)
                    {
                        sumaTotal -= ev.suma;

                        if (Math.Abs((DateTime.Now - ev.data).Days) <= 30)
                            sumaSubtotal -= ev.suma;
                    }
                    else
                    {
                        sumaTotal += ev.suma;

                        if (Math.Abs((DateTime.Now - ev.data).Days) <= 30)
                            sumaSubtotal += ev.suma;
                    }
                }

                if (sumaSubtotal > 0)
                    lblValoareSubtotal.ForeColor = Color.Lime;
                else if (sumaSubtotal == 0)
                    lblValoareSubtotal.ForeColor = Color.Blue;
                else
                    lblValoareSubtotal.ForeColor = Color.Red;

                lblValoareSubtotal.Text = Convert.ToString(sumaSubtotal);

                if (sumaTotal > 0)
                    lblValoareTotal.ForeColor = Color.Lime;
                else if (sumaTotal == 0)
                    lblValoareTotal.ForeColor = Color.Blue;
                else
                    lblValoareTotal.ForeColor = Color.Red;

                lblValoareTotal.Text = Convert.ToString(sumaTotal);
            }
        }

        private void adaugaEveniment()
        {
            if (viewCurent != View.AdaugaEveniment)
            {
                viewCurent = View.AdaugaEveniment;

                lblAdaugaEveniment.Text = "Adauga un eveniment nou";
                btnAdaugaEveniment.Text = "Adauga eveniment";

                dtpData.Value = DateTime.Now;
                txtSuma.Text = "";
                cmbPerioada.Text = "Alegeti o perioada...";
                txtOdataLa.Text = "";
                cmbTipEveniment.Text = "Alegeti tipul evenimentului...";
                txtDetalii.Text = "";

                txtOdataLa.Enabled = false;
                lblOdataLa.Enabled = false;

                modificare = false;

                pnlNotite.Hide();
                pnlMain.Hide();
                pnlGrafic.Hide();
                pnlAdaugaEveniment.Show();
            }
        }

        private void modificaEveniment()
        {
            if (lstEvenimente.SelectedItems.Count == 0)
                MessageBox.Show("Selectati o inregistrare pentru a o modifica", "Modificare eveniment");
            else if (lstEvenimente.SelectedItems.Count > 1)
                MessageBox.Show("Selectati o singura inregistrare", "Modificare eveniment");
            else
            {
                int idCurent = Convert.ToInt32(lstEvenimente.SelectedItems[0].Tag);

                index = 0;

                while (index < evenimente.Count && evenimente[index].id != idCurent)
                    index++;

                if (viewCurent != View.AdaugaEveniment)
                {
                    viewCurent = View.AdaugaEveniment;

                    lblAdaugaEveniment.Text = "Modifica un eveniment";
                    btnAdaugaEveniment.Text = "Modifica eveniment";

                    dtpData.Value = evenimente[index].data;
                    txtSuma.Text = Convert.ToString(evenimente[index].suma);

                    txtOdataLa.Text = "";
                    txtOdataLa.Enabled = false;
                    lblOdataLa.Enabled = false;

                    switch (evenimente[index].perioada)
                    {
                        case PerioadaEveniment.Lunar:
                            cmbPerioada.SelectedIndex = 0;
                            break;
                        case PerioadaEveniment.Saptamanal:
                            cmbPerioada.SelectedIndex = 1;
                            break;
                        case PerioadaEveniment.OdataLaXZile:
                            cmbPerioada.SelectedIndex = 2;
                            txtOdataLa.Text = Convert.ToString(evenimente[index].xZile);
                            txtOdataLa.Enabled = true;
                            lblOdataLa.Enabled = true;
                            break;
                        case PerioadaEveniment.AltTip:
                            cmbPerioada.SelectedIndex = 3;
                            break;
                    }

                    switch (evenimente[index].tipEveniment)
                    {
                        case TipEveniment.Cheltuiala:
                            cmbTipEveniment.SelectedIndex = 0;
                            break;
                        case TipEveniment.Venit:
                            cmbTipEveniment.SelectedIndex = 1;
                            break;
                    }

                    txtDetalii.Text = evenimente[index].detalii;

                    modificare = true;

                    pnlNotite.Hide();
                    pnlMain.Hide();
                    pnlGrafic.Hide();
                    pnlAdaugaEveniment.Show();
                }
            }
        }

        private void stergeEvenimente()
        {
            if (lstEvenimente.SelectedItems.Count > 0)
            {
                int idCurent;

                foreach (ListViewItem item in lstEvenimente.SelectedItems)
                {
                    idCurent = Convert.ToInt32(item.Tag);

                    for (int i = 0; i < evenimente.Count; i++)
                    {
                        if (evenimente[i].id == idCurent)
                            evenimente.RemoveAt(i--);
                    }
                }

                amModificat = true;

                afiseazaEvenimente();
            }
            else
                MessageBox.Show("Selectati cel putin o inregistrare pentru a fi stearsa", "Stergere eveniment");
        }

        private void sortezLista()
        {
            evenimente.Sort(delegate(Eveniment a, Eveniment b) { return a.data.CompareTo(b.data); });
        }

        private void deseneazaGrafic()
        {
            sortezLista();

            if (radValoriAbsolute.Checked == true)
            {
                chrGrafic.Series["Cheltuieli"].ChartType = SeriesChartType.Column;
                chrGrafic.Series["Venituri"].ChartType = SeriesChartType.Column;

                chrGrafic.Series["Cheltuieli"].IsValueShownAsLabel = true;
                chrGrafic.Series["Venituri"].IsValueShownAsLabel = true;

                chrGrafic.Series["Cheltuieli"].Points.Clear();
                chrGrafic.Series["Venituri"].Points.Clear();

                foreach (Eveniment ev in evenimente)
                {
                    if (ev.tipEveniment == TipEveniment.Cheltuiala)
                        chrGrafic.Series["Cheltuieli"].Points.AddXY(ev.data.Date, ev.suma);
                    else
                        chrGrafic.Series["Venituri"].Points.AddXY(ev.data.Date, ev.suma);
                }
            }
            else
            {
                chrGrafic.Series["Cheltuieli"].ChartType = SeriesChartType.Line;
                chrGrafic.Series["Venituri"].ChartType = SeriesChartType.Line;

                chrGrafic.Series["Cheltuieli"].IsValueShownAsLabel = true;
                chrGrafic.Series["Venituri"].IsValueShownAsLabel = true;

                chrGrafic.Series["Cheltuieli"].Points.Clear();
                chrGrafic.Series["Venituri"].Points.Clear();

                double valCheltuieli = 0, valVenituri = 0;

                foreach (Eveniment ev in evenimente)
                {
                    if (ev.tipEveniment == TipEveniment.Cheltuiala)
                    {
                        valCheltuieli += ev.suma;
                        chrGrafic.Series["Cheltuieli"].Points.AddXY(ev.data.Date, valCheltuieli);
                    }
                    else
                    {
                        valVenituri += ev.suma;
                        chrGrafic.Series["Venituri"].Points.AddXY(ev.data.Date, valVenituri);
                    }
                }
            }
        }

        private void afiseazaNotite()
        {
            lstNotite.Items.Clear();

            foreach (Notita not in notite)
            {
                if (not.expirat == false && not.data.Day <= DateTime.Now.Day)
                {
                    ListViewItem item = new ListViewItem(not.data.Day + ": " + not.text);

                    item.Tag = (object)not.id;

                    lstNotite.Items.Add(item);
                }
            }
        }

        private void afiseazaToateNotite()
        {
            lstNotite.Items.Clear();

            foreach (Notita not in notite)
            {
                ListViewItem item = new ListViewItem(not.data.Day + ": " + not.text);

                if (not.expirat == true)
                    item.ForeColor = Color.Red;
                else
                    item.ForeColor = Color.Lime;
                
                lstNotite.Items.Add(item);
            }
        }


        private void mnuAdauga_Click(object sender, EventArgs e)
        {
            adaugaEveniment();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            adaugaEveniment();
        }


        private void mnuModifica_Click(object sender, EventArgs e)
        {
            modificaEveniment();
        }

        private void btnSageataDreapta_Click(object sender, EventArgs e)
        {
            modificaEveniment();
        }


        private void mnuSterge_Click(object sender, EventArgs e)
        {
            stergeEvenimente();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            stergeEvenimente();
        }


        private void btnAdaugaEveniment_Click(object sender, EventArgs e)
        {
            if (modificare == false)
            {
                try
                {
                    Eveniment ev = new Eveniment();

                    ev.id = ++maxIdEveniment;

                    ev.data = dtpData.Value;
                    ev.suma = Convert.ToDouble(txtSuma.Text);

                    switch (cmbPerioada.SelectedItem.ToString())
                    {
                        case "Lunar":
                            ev.perioada = PerioadaEveniment.Lunar;
                            break;
                        case "Saptamanal":
                            ev.perioada = PerioadaEveniment.Saptamanal;
                            break;
                        case "Odata la n zile":
                            ev.perioada = PerioadaEveniment.OdataLaXZile;
                            ev.xZile = Convert.ToInt32(txtOdataLa.Text);
                            break;
                        case "Alt tip":
                            ev.perioada = PerioadaEveniment.AltTip;
                            break;
                        default:
                            throw new Exception("Alegeti o perioada");
                    }

                    switch (cmbTipEveniment.SelectedItem.ToString())
                    {
                        case "Cheltuiala":
                            ev.tipEveniment = TipEveniment.Cheltuiala;
                            break;
                        case "Venit":
                            ev.tipEveniment = TipEveniment.Venit;
                            break;
                    }

                    ev.detalii = txtDetalii.Text;

                    evenimente.Add(ev);

                    amModificat = true;

                    afiseazaEvenimente();

                    viewCurent = View.Main;

                    pnlNotite.Hide();
                    pnlAdaugaEveniment.Hide();
                    pnlGrafic.Hide();
                    pnlMain.Show();
                }
                catch (Exception exceptie)
                {
                    --maxIdEveniment;

                    MessageBox.Show(exceptie.Message, "Atentie");
                }
            }
            else
            {
                try
                {
                    Eveniment ev = new Eveniment();

                    ev.id = evenimente[index].id;

                    ev.data = dtpData.Value;
                    ev.suma = Convert.ToDouble(txtSuma.Text);

                    switch (cmbPerioada.SelectedItem.ToString())
                    {
                        case "Lunar":
                            ev.perioada = PerioadaEveniment.Lunar;
                            break;
                        case "Saptamanal":
                            ev.perioada = PerioadaEveniment.Saptamanal;
                            break;
                        case "Odata la n zile":
                            ev.perioada = PerioadaEveniment.OdataLaXZile;
                            ev.xZile = Convert.ToInt32(txtOdataLa.Text);
                            break;
                        case "Alt tip":
                            ev.perioada = PerioadaEveniment.AltTip;
                            break;
                        default:
                            throw new Exception("Alegeti o perioada");
                    }

                    switch (cmbTipEveniment.SelectedItem.ToString())
                    {
                        case "Cheltuiala":
                            ev.tipEveniment = TipEveniment.Cheltuiala;
                            break;
                        case "Venit":
                            ev.tipEveniment = TipEveniment.Venit;
                            break;
                    }

                    ev.detalii = txtDetalii.Text;

                    evenimente[index] = ev;

                    amModificat = true;

                    afiseazaEvenimente();

                    viewCurent = View.Main;

                    pnlNotite.Hide();
                    pnlAdaugaEveniment.Hide();
                    pnlGrafic.Hide();
                    pnlMain.Show();
                }
                catch (Exception exceptie)
                {
                    --maxIdEveniment;

                    MessageBox.Show(exceptie.Message, "Atentie");
                }
            }
        }


        private void mnuDeschide_Click(object sender, EventArgs e)
        {
            if (amModificat == true)
                if (MessageBox.Show("Daca redeschideti fisierul de evenimente veti pierde toate modificarile efectuate in sesiunea curenta. Doriti sa continuati?", "Modificari", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    viewCurent = View.Main;

                    pnlNotite.Hide();
                    pnlAdaugaEveniment.Hide();
                    pnlGrafic.Hide();
                    pnlMain.Show();

                    evenimente = EvenimentReader.citesteEvenimente("evenimente.xml");
                    maxIdEveniment = getMaxIdEveniment();

                    amModificat = false;
                    modificare = false;

                    afiseazaEvenimente();
                }
        }

        private void mnuSalveaza_Click(object sender, EventArgs e)
        {
            EvenimentWriter.scrieEvenimente("evenimente.xml", evenimente);
        }


        private void mnuAfiseazaCheltuieli_Click(object sender, EventArgs e)
        {
            afiseazaEvenimente();
        }

        private void mnuAfiseazaVenituri_Click(object sender, EventArgs e)
        {
            afiseazaEvenimente();
        }


        private void btnInapoiAdaugaEveniment_Click(object sender, EventArgs e)
        {
            viewCurent = View.Main;

            pnlNotite.Hide();
            pnlAdaugaEveniment.Hide();
            pnlGrafic.Hide();
            pnlMain.Show();

            afiseazaEvenimente();
        }

        private void btnInapoiGrafic_Click(object sender, EventArgs e)
        {
            viewCurent = View.Main;

            pnlNotite.Hide();
            pnlGrafic.Hide();
            pnlAdaugaEveniment.Hide();
            pnlMain.Show();
        }

        private void btnInapoiNotite_Click(object sender, EventArgs e)
        {
            viewCurent = View.Main;

            pnlNotite.Hide();
            pnlGrafic.Hide();
            pnlAdaugaEveniment.Hide();
            pnlMain.Show();
        }

        private void mnuIesire_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (amModificat == true)
                if (MessageBox.Show("Doriti sa salvati modificarile?", "Modificari", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    EvenimentWriter.scrieEvenimente("evenimente.xml", evenimente);

            NotitaWriter.scrieNotite("notite.xml", notite);
        }


        private void mnuFiltru_TextChanged(object sender, EventArgs e)
        {
            if (mnuFiltru.Text == "")
                afiseazaEvenimente();
            else
            {
                double sumaSubtotal = 0, sumaTotal = 0;

                lstEvenimente.Items.Clear();

                foreach (Eveniment ev in evenimente)
                {
                    if (ev.detalii.Contains(mnuFiltru.Text) == true)
                    {
                        ListViewItem item = new ListViewItem(Convert.ToString(ev.data.Date));

                        item.UseItemStyleForSubItems = false;

                        item.Tag = (object)ev.id;

                        item.SubItems.Add(ev.detalii);

                        if (ev.perioada == PerioadaEveniment.OdataLaXZile)
                        {
                            item.SubItems.Add("odata la " + ev.xZile + " zile");
                        }
                        else
                        {
                            if (ev.perioada == PerioadaEveniment.Lunar)
                                item.SubItems.Add("lunar");
                            else if (ev.perioada == PerioadaEveniment.Saptamanal)
                                item.SubItems.Add("saptamanal");
                            else if (ev.perioada == PerioadaEveniment.AltTip)
                                item.SubItems.Add(" - ");
                        }

                        if (ev.tipEveniment == TipEveniment.Cheltuiala)
                            item.SubItems.Add(Convert.ToString(ev.suma), Color.Red, Color.White, lstEvenimente.Font);
                        else
                            item.SubItems.Add(Convert.ToString(ev.suma), Color.Green, Color.White, lstEvenimente.Font);

                        lstEvenimente.Items.Add(item);

                        if (ev.tipEveniment == TipEveniment.Cheltuiala)
                        {
                            sumaTotal -= ev.suma;

                            if (Math.Abs((DateTime.Now - ev.data).Days) <= 30)
                                sumaSubtotal -= ev.suma;
                        }
                        else
                        {
                            sumaTotal += ev.suma;

                            if (Math.Abs((DateTime.Now - ev.data).Days) <= 30)
                                sumaSubtotal += ev.suma;
                        }
                    }

                    if (sumaSubtotal > 0)
                        lblValoareSubtotal.ForeColor = Color.Lime;
                    else if (sumaSubtotal == 0)
                        lblValoareSubtotal.ForeColor = Color.Blue;
                    else
                        lblValoareSubtotal.ForeColor = Color.Red;

                    lblValoareSubtotal.Text = Convert.ToString(sumaSubtotal);

                    if (sumaTotal > 0)
                        lblValoareTotal.ForeColor = Color.Lime;
                    else if (sumaTotal == 0)
                        lblValoareTotal.ForeColor = Color.Blue;
                    else
                        lblValoareTotal.ForeColor = Color.Red;

                    lblValoareTotal.Text = Convert.ToString(sumaTotal);
                }
            }
        }

        private void cmbPerioada_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPerioada.SelectedItem.ToString() == "Odata la n zile")
            {
                txtOdataLa.Enabled = true;
                lblOdataLa.Enabled = true;
            }
            else
            {
                txtOdataLa.Enabled = false;
                lblOdataLa.Enabled = false;
            }
        }


        private void mnuSalveazaGrafic_Click(object sender, EventArgs e)
        {
            dlgSalveazaGrafic.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif|Png Image|*.png";
            dlgSalveazaGrafic.ShowDialog();

            if (dlgSalveazaGrafic.FileName != "")
            {
                switch (dlgSalveazaGrafic.FilterIndex)
                {
                    case 1:
                        chrGrafic.SaveImage(dlgSalveazaGrafic.FileName, ImageFormat.Jpeg);
                        break;
                    case 2:
                        chrGrafic.SaveImage(dlgSalveazaGrafic.FileName, ImageFormat.Bmp);
                        break;
                    case 3:
                        chrGrafic.SaveImage(dlgSalveazaGrafic.FileName, ImageFormat.Gif);
                        break;
                    case 4:
                        chrGrafic.SaveImage(dlgSalveazaGrafic.FileName, ImageFormat.Png);
                        break;
                }
            }
        }

        private void mnuAfiseazaGrafic_Click(object sender, EventArgs e)
        {
            viewCurent = View.Grafic;

            deseneazaGrafic();

            pnlNotite.Hide();
            pnlMain.Hide();
            pnlAdaugaEveniment.Hide();
            pnlGrafic.Show();
        }

        private void radValoriAbsolute_CheckedChanged(object sender, EventArgs e)
        {
            deseneazaGrafic();
        }

        private void radValoriCumulative_CheckedChanged(object sender, EventArgs e)
        {
            deseneazaGrafic();
        }

        private void tmrEvenimente_Tick(object sender, EventArgs e)
        {
            nrNotiteNecitite = 0;

            foreach (Notita not in notite)
            {
                if (not.expirat == false)
                    nrNotiteNecitite ++;
            }

            if (nrNotiteNecitite > 0)
            {
                btnNotite.Text = "Aveti " + nrNotiteNecitite + " notite!";
                lblNrNotiteNecitite.Text = Convert.ToString(nrNotiteNecitite);
                btnNotite.Visible = true;
                lblNrNotiteNecitite.Visible = true;
            }
            else
            {
                btnNotite.Visible = false;
                lblNrNotiteNecitite.Visible = false;
            }
        }

        private void btnNotite_Click(object sender, EventArgs e)
        {
            viewCurent = View.Notite;

            afiseazaNotite();

            btnAmCitit.Visible = true;

            pnlMain.Hide();
            pnlGrafic.Hide();
            pnlAdaugaEveniment.Hide();
            pnlNotite.Show();
        }

        private void btnAmCitit_Click(object sender, EventArgs e)
        {
            int idCurent;

            foreach (ListViewItem item in lstNotite.Items)
            {
                idCurent = Convert.ToInt32(item.Tag);

                for (int i = 0; i < notite.Count; i++)
                {
                    if (notite[i].id == idCurent)
                    {
                        Notita not = new Notita();

                        not.id = notite[i].id;
                        not.data = notite[i].data;
                        not.text = notite[i].text;
                        not.expirat = true;

                        notite[i] = not;
                    }
                }
            }

            viewCurent = View.Main;

            pnlNotite.Hide();
            pnlGrafic.Hide();
            pnlAdaugaEveniment.Hide();
            pnlMain.Show();
        }

        private void mnuAfiseazaToate_Click(object sender, EventArgs e)
        {
            viewCurent = View.Notite;

            afiseazaToateNotite();

            btnAmCitit.Visible = false;

            pnlMain.Hide();
            pnlGrafic.Hide();
            pnlAdaugaEveniment.Hide();
            pnlNotite.Show();
        }
    }
}
