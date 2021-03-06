﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Windows.Forms.DataVisualization.Charting;
using System.Diagnostics;
using Microsoft.Office.Interop.Excel;

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
        public bool totalEvenimente;
        public bool amAfisatEvenimentePeriodice;
        public int index;

        public frmMain()
        {
            InitializeComponent();

            viewCurent = View.Main;

            clhData.Width = -1;
            clhDetalii.Width = 350;
            clhPerioada.Width =-1;
            clhSuma.Width = -2;

            pnlAdaugaNotita.Hide();
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
            totalEvenimente = true;
            amAfisatEvenimentePeriodice = false;

            afiseazaEvenimente();
            
            tmrEvenimente.Enabled = true;
        }


        public void verificaPerioadaEvenimente()
        {
            string mesaje = "";

            foreach (Eveniment ev in evenimente)
            {
                switch (ev.perioada)
                {
                    case PerioadaEveniment.Saptamanal:
                        if (Math.Abs((DateTime.Now - ev.data).Days) % 7 == 0)
                            mesaje += "A trecut o saptamana de cand: " + ev.detalii + "\n";
                        break;
                    case PerioadaEveniment.Lunar:
                        if (Math.Abs((DateTime.Now - ev.data).Days) % 30 == 0)
                            mesaje += "A trecut o luna de cand: " + ev.detalii + "\n";
                        break;
                    case PerioadaEveniment.OdataLaXZile:
                        if (Math.Abs((DateTime.Now - ev.data).Days) % ev.xZile == 0)
                            mesaje += "Au trecut " + ev.xZile + " de cand: " + ev.detalii + "\n";
                        break;
                }
            }

            if(mesaje != "")
                MessageBox.Show(mesaje, "Evenimente periodice");
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

        public DateTime getMinDate()
        {
            DateTime minData = DateTime.Now;

            foreach (Eveniment ev in evenimente)
                if (ev.data < minData)
                    minData = ev.data;

            return minData;
        }

        public DateTime getMaxDate()
        {
            DateTime maxData = DateTime.Now;

            foreach (Eveniment ev in evenimente)
                if (ev.data > maxData)
                    maxData = ev.data;

            return maxData;
        }

        private void afiseazaEvenimente()
        {
            double sumaSubtotal = 0, sumaTotal = 0;

            lstEvenimente.Items.Clear();

            foreach (Eveniment ev in evenimente)
            {
                if (totalEvenimente == false || (totalEvenimente == true && Math.Abs((DateTime.Now - ev.data).Days) <= 30))
                {
                    if ((ev.tipEveniment == TipEveniment.Cheltuiala && mnuAfiseazaCheltuieli.Checked == true) ||
                       (ev.tipEveniment == TipEveniment.Venit && mnuAfiseazaVenituri.Checked == true))
                    {
                        ListViewItem item = new ListViewItem(Convert.ToString(ev.data));

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

                pnlAdaugaNotita.Hide();
                pnlNotite.Hide();
                pnlMain.Hide();
                pnlGrafic.Hide();
                pnlAdaugaEveniment.Show();
            }
        }

        private void modificaEveniment()
        {
            if (lstEvenimente.SelectedItems.Count == 0)
                MessageBox.Show("Selectati o inregistrare pentru a o modifica", "Lista evenimente");
            else if (lstEvenimente.SelectedItems.Count > 1)
                MessageBox.Show("Selectati o singura inregistrare", "Lista evenimente");
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

                    pnlAdaugaNotita.Hide();
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
                    if (ev.data > dtpInceput.Value && ev.data < dtpSfarsit.Value)
                    {
                        if (ev.tipEveniment == TipEveniment.Cheltuiala)
                            chrGrafic.Series["Cheltuieli"].Points.AddXY(ev.data.Date, ev.suma);
                        else
                            chrGrafic.Series["Venituri"].Points.AddXY(ev.data.Date, ev.suma);
                    }
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
                    if (ev.data > dtpInceput.Value && ev.data < dtpSfarsit.Value)
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
        }

        private void afiseazaNotite()
        {
            lstNotite.Items.Clear();

            foreach (Notita not in notite)
            {
                if (not.expirat == false && not.data <= DateTime.Now)
                {
                    ListViewItem item = new ListViewItem(not.data + ": " + not.text);
                    
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
                ListViewItem item = new ListViewItem(not.data + ": " + not.text);

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


        // imi cer scuze ca am rearanjat codul dar imi era imposibil de citit, scuze
        private void btnAdaugaEveniment_Click(object sender, EventArgs e) {            
            Eveniment ev;
            try {
                if (modificare == false) {
                    ev = citesteEveniment(++maxIdEveniment);
                    evenimente.Add(ev);
                }
                else {
                    ev = citesteEveniment(evenimente[index].id);
                    evenimente[index] = ev;
                }
            }
            catch (InvalidEvenimentException iee) {
                MessageBox.Show(iee.Message, "Adauga eveniment");
                return;
            }

            amModificat = true;
            afiseazaEvenimente();

            viewCurent = View.Main;

            pnlAdaugaNotita.Hide();
            pnlNotite.Hide();
            pnlAdaugaEveniment.Hide();
            pnlGrafic.Hide();
            pnlMain.Show();
        }

        private Eveniment citesteEveniment(int id) {
            Eveniment ev = new Eveniment();
            ev.id = id;

            ev.data = dtpData.Value;

            double sumaOut;
            if (!Double.TryParse(txtSuma.Text, out sumaOut))
            {
                throw new InvalidEvenimentException("Suma lipseste sau este intr-un format incorect!");
            }
            ev.suma = sumaOut;

            if (cmbPerioada.SelectedItem == null)
            {
                throw new InvalidEvenimentException("Tip perioada neselectat!");
            }

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
                    int xZileOut; if (!int.TryParse(txtOdataLa.Text, out xZileOut))
                    {
                        throw new InvalidEvenimentException("Format incorect numar zile");
                    }
                    ev.xZile = xZileOut;
                    break;
                case "Alt tip":
                    ev.perioada = PerioadaEveniment.AltTip;
                    break;
                default:
                    throw new Exception("Alegeti o perioada");
            }

            if (cmbTipEveniment.SelectedItem == null)
            {
                throw new InvalidEvenimentException("Tip eveniment neselectat!");
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

            return ev;
        }


        private void mnuDeschide_Click(object sender, EventArgs e)
        {
            if (amModificat == true)
                if (MessageBox.Show("Daca redeschideti fisierul de evenimente veti pierde toate modificarile efectuate in sesiunea curenta. Doriti sa continuati?", "Modificari", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //test
                    viewCurent = View.Main;

                    pnlAdaugaNotita.Hide();
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
            if (modificare == false)
            {
                DialogResult dialogResult = MessageBox.Show("Eveniment nesalvat! Salvati evenimentul curent?",
                                                            "Adauga eveniment", MessageBoxButtons.YesNoCancel,
                                                            MessageBoxIcon.Question);
                if (dialogResult == DialogResult.No)
                {
                    viewCurent = View.Main;

                    pnlAdaugaNotita.Hide();
                    pnlNotite.Hide();
                    pnlAdaugaEveniment.Hide();
                    pnlGrafic.Hide();
                    pnlMain.Show();

                    afiseazaEvenimente();
                }
                else if (dialogResult == DialogResult.Yes)
                {
                    btnAdaugaEveniment_Click(null, null);
                }
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Eveniment nesalvat! Salvati evenimentul curent?",
                                                            "Modifica eveniment", MessageBoxButtons.YesNoCancel,
                                                            MessageBoxIcon.Question);
                if (dialogResult == DialogResult.No)
                {
                    viewCurent = View.Main;

                    pnlAdaugaNotita.Hide();
                    pnlNotite.Hide();
                    pnlAdaugaEveniment.Hide();
                    pnlGrafic.Hide();
                    pnlMain.Show();

                    afiseazaEvenimente();
                }
                else if (dialogResult == DialogResult.Yes)
                {
                    btnAdaugaEveniment_Click(null, null);
                }
            }
        }

        private void btnInapoiGrafic_Click(object sender, EventArgs e)
        {
            viewCurent = View.Main;

            pnlAdaugaNotita.Hide();
            pnlNotite.Hide();
            pnlGrafic.Hide();
            pnlAdaugaEveniment.Hide();
            pnlMain.Show();
        }

        private void btnInapoiNotite_Click(object sender, EventArgs e)
        {
            viewCurent = View.Main;

            pnlAdaugaNotita.Hide();
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
                    if (totalEvenimente == false || (totalEvenimente == true && Math.Abs((DateTime.Now - ev.data).Days) <= 30))
                    {
                        if ((ev.tipEveniment == TipEveniment.Cheltuiala && mnuAfiseazaCheltuieli.Checked == true) ||
                           (ev.tipEveniment == TipEveniment.Venit && mnuAfiseazaVenituri.Checked == true))
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
            dtpInceput.Value = getMinDate();
            dtpSfarsit.Value = getMaxDate();

            pnlAdaugaNotita.Hide();
            pnlNotite.Hide();
            pnlMain.Hide();
            pnlAdaugaEveniment.Hide();
            pnlGrafic.Show();
        }

        private void radValoriAbsolute_CheckedChanged(object sender, EventArgs e)
        {
            //deseneazaGrafic();
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
                lblNrNotiteNecitite.BringToFront();
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

            pnlAdaugaNotita.Hide();
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

            btnNotite.Visible = false;
            lblNrNotiteNecitite.Visible = false;

            viewCurent = View.Main;

            pnlAdaugaNotita.Hide();
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

            pnlAdaugaNotita.Hide();
            pnlMain.Hide();
            pnlGrafic.Hide();
            pnlAdaugaEveniment.Hide();
            pnlNotite.Show();
        }

        private void mnuAdaugaNotita_Click(object sender, EventArgs e)
        {
            viewCurent = View.AdaugaNotite;

            txtText.Text = "";
            dtpDataNotita.Value = DateTime.Now;

            pnlMain.Hide();
            pnlGrafic.Hide();
            pnlAdaugaEveniment.Hide();
            pnlNotite.Hide();
            pnlAdaugaNotita.Show();
        }

        private void btnAdaugaNotita_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtText.Text))
            {
                Notita not = new Notita();

                not.id = getMaxIdNotita();
                not.data = dtpDataNotita.Value;
                not.text = txtText.Text;
                not.expirat = false;

                notite.Add(not);

                viewCurent = View.Main;

                pnlAdaugaNotita.Hide();
                pnlNotite.Hide();
                pnlAdaugaEveniment.Hide();
                pnlGrafic.Hide();
                pnlMain.Show();
            }
            else
            {
                MessageBox.Show("Trebuie sa completati campul text!", "Adauga notita");
            }
        }

        private void mnuDespre_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\t\tSistem de gestiune al cheltuielilor v1.0 \n\n         Aceasta aplicatie ajuta utilizatorul sa isi gestioneze cu usurinta cheltuielile si veniturile.\n\nEchipa:\n- Razvan Dumitrescu\n- Andrei Iocin\n- Razvan Rebegea\n- Sorin Slavic", "Despre");
        }

        private void mnuTutorial_Click(object sender, EventArgs e)
        {
            Process.Start("tutorial.html");
        }

        private void mnuExportaExcel_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app  = new Microsoft.Office.Interop.Excel.Application(); 
            Microsoft.Office.Interop.Excel._Workbook workbook =  app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;                   
            
            app.Visible = false;
            
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            
            worksheet.Name = "Cheltuieli si venituri";

            for (int i = 0; i < lstEvenimente.Columns.Count; i++)
            {
                worksheet.Cells[1, i + 1] = lstEvenimente.Columns[i].Text;
                ((Range)worksheet.Cells[1, i + 1]).Style.HorizontalAlignment = HorizontalAlignment.Center;
                ((Range)worksheet.Cells[1, i + 1]).Font.Bold = true;
            }

            for (int i = 0; i < lstEvenimente.Items.Count; i++)
            {
                worksheet.Cells[i + 2, 1] = lstEvenimente.Items[i].SubItems[0].Text;
                worksheet.Cells[i + 2, 2] = lstEvenimente.Items[i].SubItems[1].Text;
                worksheet.Cells[i + 2, 3] = lstEvenimente.Items[i].SubItems[2].Text;
                worksheet.Cells[i + 2, 4] = lstEvenimente.Items[i].SubItems[3].Text;
            }

            ((Range)worksheet.Columns["A", Type.Missing]).ColumnWidth = 15;
            ((Range)worksheet.Columns["B", Type.Missing]).ColumnWidth = 64;
            ((Range)worksheet.Columns["C", Type.Missing]).ColumnWidth = 15;
            ((Range)worksheet.Columns["D", Type.Missing]).ColumnWidth = 15;

            workbook.SaveAs(System.Windows.Forms.Application.StartupPath + "\\" + "raport.xlsx", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            
            app.Quit();
        }

        private void btnExtinde_Click(object sender, EventArgs e)
        {
            if (totalEvenimente == true)
            {
                btnExtinde.Text = "Ultimele 30 zile";
                totalEvenimente = false;
            }
            else
            {
                btnExtinde.Text = "Toate evenimentele";
                totalEvenimente = true;
            }

            afiseazaEvenimente();
        }

        private void lstEvenimente_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (e.Column == 0)
            {
                sortezLista();
                afiseazaEvenimente();
            }
        }

        private void dtpInceput_ValueChanged(object sender, EventArgs e)
        {
            deseneazaGrafic();
        }

        private void dtpSfarsit_ValueChanged(object sender, EventArgs e)
        {
            deseneazaGrafic();
        }

        private void frmMain_Paint(object sender, PaintEventArgs e)
        {
            if (amAfisatEvenimentePeriodice == false)
            {
                amAfisatEvenimentePeriodice = true;
                verificaPerioadaEvenimente();
            }
        }

        private void btnInapoiAdaugaNotita_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtText.Text) || MessageBox.Show("Notita curenta nu va fi salvata! Sunteti sigur?",
                    "Adauga notita", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                viewCurent = View.Main;

                pnlAdaugaNotita.Hide();
                pnlNotite.Hide();
                pnlGrafic.Hide();
                pnlAdaugaEveniment.Hide();
                pnlMain.Show();
            }

        }
    }
}
