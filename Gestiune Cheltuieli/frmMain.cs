using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Gestiune_Cheltuieli
{
    public partial class frmMain : Form
    {
        View viewCurent;
        public List<Eveniment> evenimente;

        public frmMain()
        {
            InitializeComponent();

            viewCurent = View.Main;

            clhData.Width = 70;
            clhDetalii.Width = 350;
            clhPerioada.Width = 100;
            clhSuma.Width = 100;

            pnlAdaugaEveniment.Hide();
            pnlMain.Show();

            evenimente = EvenimentReader.citesteEvenimente("evenimente.xml");

            afiseazaEvenimente();
        }

        public void afiseazaEvenimente()
        {
            double sumaSubtotal = 0, sumaTotal = 0;

            lstEvenimente.Items.Clear();

            foreach (Eveniment ev in evenimente)
            {
                ListViewItem item = new ListViewItem(Convert.ToString(ev.data.Date));

                item.UseItemStyleForSubItems = false;

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

                if(ev.tipEveniment == TipEveniment.Cheltuiala)
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

        private void mnuAdauga_Click(object sender, EventArgs e)
        {
            if (viewCurent != View.AdaugaEveniment)
            {
                viewCurent = View.AdaugaEveniment;

                dtpData.Value = DateTime.Now;
                txtSuma.Text = "";
                cmbPerioada.Text = "Alegeti o perioada...";
                txtOdataLa.Text = "";
                cmbTipEveniment.Text = "Alegeti tipul evenimentului...";
                txtDetalii.Text = "";

                txtOdataLa.Enabled = false;
                lblOdataLa.Enabled = false;

                pnlMain.Hide();
                pnlAdaugaEveniment.Show();
            }
        }

        private void btnAdaugaEveniment_Click(object sender, EventArgs e)
        {
            Eveniment ev = new Eveniment();

            try
            {
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

                afiseazaEvenimente();

                viewCurent = View.Main;

                pnlAdaugaEveniment.Hide();
                pnlMain.Show();
            }
            catch(Exception exceptie)
            {
                MessageBox.Show(exceptie.Message);
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

        private void btnInapoi_Click(object sender, EventArgs e)
        {
            viewCurent = View.Main;

            pnlAdaugaEveniment.Hide();
            pnlMain.Show();

            afiseazaEvenimente();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (viewCurent != View.AdaugaEveniment)
            {
                viewCurent = View.AdaugaEveniment;

                dtpData.Value = DateTime.Now;
                txtSuma.Text = "";
                cmbPerioada.Text = "Alegeti o perioada...";
                txtOdataLa.Text = "";
                cmbTipEveniment.Text = "Alegeti tipul evenimentului...";
                txtDetalii.Text = "";

                txtOdataLa.Enabled = false;
                lblOdataLa.Enabled = false;

                pnlMain.Hide();
                pnlAdaugaEveniment.Show();
            }
        }

        private void salveazaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EvenimentWriter.scrieEvenimente("evenimente.xml", evenimente);
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
