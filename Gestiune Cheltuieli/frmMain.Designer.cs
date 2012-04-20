namespace Gestiune_Cheltuieli
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.btnExtinde = new System.Windows.Forms.Button();
            this.lblNrNotiteNecitite = new System.Windows.Forms.Label();
            this.btnNotite = new System.Windows.Forms.Button();
            this.lblSageataDreapta = new System.Windows.Forms.Label();
            this.lblMinus = new System.Windows.Forms.Label();
            this.lblPlus = new System.Windows.Forms.Label();
            this.btnSageataDreapta = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.lblValoareTotal = new System.Windows.Forms.Label();
            this.lblValoareSubtotal = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lstEvenimente = new System.Windows.Forms.ListView();
            this.clhData = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhDetalii = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhPerioada = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhSuma = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mnuMeniu = new System.Windows.Forms.MenuStrip();
            this.mnuFisier = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDeschide = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSalveaza = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSeparatorFisier = new System.Windows.Forms.ToolStripSeparator();
            this.mnuExportaExcel = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSeparatorFisier2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuIesire = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEveniment = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAdauga = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuModifica = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSterge = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSeparatorEveniment = new System.Windows.Forms.ToolStripSeparator();
            this.mnuAfiseazaCheltuieli = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAfiseazaVenituri = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNotite = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAdaugaNotita = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAfiseazaToate = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGrafic = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAfiseazaGrafic = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSalveazaGrafic = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAjutor = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTutorial = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSeparatorAjutor = new System.Windows.Forms.ToolStripSeparator();
            this.mnuDespre = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFiltru = new System.Windows.Forms.ToolStripTextBox();
            this.mnuFiltruLabel = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlAdaugaEveniment = new System.Windows.Forms.Panel();
            this.btnInapoiAdaugaEveniment = new System.Windows.Forms.Button();
            this.lblAdaugaEveniment = new System.Windows.Forms.Label();
            this.txtDetalii = new System.Windows.Forms.TextBox();
            this.cmbTipEveniment = new System.Windows.Forms.ComboBox();
            this.txtOdataLa = new System.Windows.Forms.TextBox();
            this.cmbPerioada = new System.Windows.Forms.ComboBox();
            this.txtSuma = new System.Windows.Forms.TextBox();
            this.lblDetalii = new System.Windows.Forms.Label();
            this.lblTipEveniment = new System.Windows.Forms.Label();
            this.lblOdataLa = new System.Windows.Forms.Label();
            this.lblPerioada = new System.Windows.Forms.Label();
            this.lblSuma = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.btnAdaugaEveniment = new System.Windows.Forms.Button();
            this.pnlGrafic = new System.Windows.Forms.Panel();
            this.grpPerioadaAfisata = new System.Windows.Forms.GroupBox();
            this.dtpSfarsit = new System.Windows.Forms.DateTimePicker();
            this.lblSfarsit = new System.Windows.Forms.Label();
            this.lblInceput = new System.Windows.Forms.Label();
            this.dtpInceput = new System.Windows.Forms.DateTimePicker();
            this.btnInapoiGrafic = new System.Windows.Forms.Button();
            this.grpTipGrafic = new System.Windows.Forms.GroupBox();
            this.radValoriCumulative = new System.Windows.Forms.RadioButton();
            this.radValoriAbsolute = new System.Windows.Forms.RadioButton();
            this.chrGrafic = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dlgSalveazaGrafic = new System.Windows.Forms.SaveFileDialog();
            this.tmrEvenimente = new System.Windows.Forms.Timer(this.components);
            this.pnlNotite = new System.Windows.Forms.Panel();
            this.btnAmCitit = new System.Windows.Forms.Button();
            this.btnInapoiNotite = new System.Windows.Forms.Button();
            this.lstNotite = new System.Windows.Forms.ListView();
            this.pnlAdaugaNotita = new System.Windows.Forms.Panel();
            this.dtpDataNotita = new System.Windows.Forms.DateTimePicker();
            this.btnInapoiAdaugaNotita = new System.Windows.Forms.Button();
            this.lblAdaugaNotita = new System.Windows.Forms.Label();
            this.txtText = new System.Windows.Forms.TextBox();
            this.lblText = new System.Windows.Forms.Label();
            this.lblDataNotita = new System.Windows.Forms.Label();
            this.btnAdaugaNotita = new System.Windows.Forms.Button();
            this.pnlMain.SuspendLayout();
            this.mnuMeniu.SuspendLayout();
            this.pnlAdaugaEveniment.SuspendLayout();
            this.pnlGrafic.SuspendLayout();
            this.grpPerioadaAfisata.SuspendLayout();
            this.grpTipGrafic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrGrafic)).BeginInit();
            this.pnlNotite.SuspendLayout();
            this.pnlAdaugaNotita.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.btnExtinde);
            this.pnlMain.Controls.Add(this.lblNrNotiteNecitite);
            this.pnlMain.Controls.Add(this.btnNotite);
            this.pnlMain.Controls.Add(this.lblSageataDreapta);
            this.pnlMain.Controls.Add(this.lblMinus);
            this.pnlMain.Controls.Add(this.lblPlus);
            this.pnlMain.Controls.Add(this.btnSageataDreapta);
            this.pnlMain.Controls.Add(this.btnMinus);
            this.pnlMain.Controls.Add(this.btnPlus);
            this.pnlMain.Controls.Add(this.lblValoareTotal);
            this.pnlMain.Controls.Add(this.lblValoareSubtotal);
            this.pnlMain.Controls.Add(this.lblTotal);
            this.pnlMain.Controls.Add(this.lblSubtotal);
            this.pnlMain.Controls.Add(this.lstEvenimente);
            this.pnlMain.Location = new System.Drawing.Point(12, 30);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(770, 530);
            this.pnlMain.TabIndex = 0;
            // 
            // btnExtinde
            // 
            this.btnExtinde.Location = new System.Drawing.Point(634, 408);
            this.btnExtinde.Name = "btnExtinde";
            this.btnExtinde.Size = new System.Drawing.Size(127, 26);
            this.btnExtinde.TabIndex = 14;
            this.btnExtinde.Text = "Toate evenimentele";
            this.btnExtinde.UseVisualStyleBackColor = true;
            this.btnExtinde.Click += new System.EventHandler(this.btnExtinde_Click);
            // 
            // lblNrNotiteNecitite
            // 
            this.lblNrNotiteNecitite.AutoSize = true;
            this.lblNrNotiteNecitite.BackColor = System.Drawing.Color.Red;
            this.lblNrNotiteNecitite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNrNotiteNecitite.ForeColor = System.Drawing.Color.White;
            this.lblNrNotiteNecitite.Location = new System.Drawing.Point(748, 113);
            this.lblNrNotiteNecitite.Name = "lblNrNotiteNecitite";
            this.lblNrNotiteNecitite.Size = new System.Drawing.Size(24, 16);
            this.lblNrNotiteNecitite.TabIndex = 13;
            this.lblNrNotiteNecitite.Text = "10";
            this.lblNrNotiteNecitite.Visible = false;
            // 
            // btnNotite
            // 
            this.btnNotite.BackColor = System.Drawing.Color.Transparent;
            this.btnNotite.Location = new System.Drawing.Point(637, 119);
            this.btnNotite.Name = "btnNotite";
            this.btnNotite.Size = new System.Drawing.Size(124, 23);
            this.btnNotite.TabIndex = 12;
            this.btnNotite.Text = "Aveti x notite!";
            this.btnNotite.UseVisualStyleBackColor = false;
            this.btnNotite.Visible = false;
            this.btnNotite.Click += new System.EventHandler(this.btnNotite_Click);
            // 
            // lblSageataDreapta
            // 
            this.lblSageataDreapta.AutoSize = true;
            this.lblSageataDreapta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSageataDreapta.Location = new System.Drawing.Point(677, 88);
            this.lblSageataDreapta.Name = "lblSageataDreapta";
            this.lblSageataDreapta.Size = new System.Drawing.Size(68, 20);
            this.lblSageataDreapta.TabIndex = 11;
            this.lblSageataDreapta.Text = "Modifica";
            // 
            // lblMinus
            // 
            this.lblMinus.AutoSize = true;
            this.lblMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinus.Location = new System.Drawing.Point(677, 50);
            this.lblMinus.Name = "lblMinus";
            this.lblMinus.Size = new System.Drawing.Size(57, 20);
            this.lblMinus.TabIndex = 10;
            this.lblMinus.Text = "Sterge";
            // 
            // lblPlus
            // 
            this.lblPlus.AutoSize = true;
            this.lblPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlus.Location = new System.Drawing.Point(677, 12);
            this.lblPlus.Name = "lblPlus";
            this.lblPlus.Size = new System.Drawing.Size(65, 20);
            this.lblPlus.TabIndex = 9;
            this.lblPlus.Text = "Adauga";
            // 
            // btnSageataDreapta
            // 
            this.btnSageataDreapta.BackColor = System.Drawing.Color.Gold;
            this.btnSageataDreapta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSageataDreapta.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSageataDreapta.Location = new System.Drawing.Point(634, 80);
            this.btnSageataDreapta.Name = "btnSageataDreapta";
            this.btnSageataDreapta.Size = new System.Drawing.Size(37, 32);
            this.btnSageataDreapta.TabIndex = 8;
            this.btnSageataDreapta.Text = ">";
            this.btnSageataDreapta.UseVisualStyleBackColor = false;
            this.btnSageataDreapta.Click += new System.EventHandler(this.btnSageataDreapta_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.BackColor = System.Drawing.Color.Red;
            this.btnMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinus.ForeColor = System.Drawing.SystemColors.Window;
            this.btnMinus.Location = new System.Drawing.Point(634, 42);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(37, 32);
            this.btnMinus.TabIndex = 7;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = false;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.BackColor = System.Drawing.Color.Lime;
            this.btnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlus.ForeColor = System.Drawing.SystemColors.Window;
            this.btnPlus.Location = new System.Drawing.Point(634, 4);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(37, 32);
            this.btnPlus.TabIndex = 6;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = false;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // lblValoareTotal
            // 
            this.lblValoareTotal.AutoSize = true;
            this.lblValoareTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValoareTotal.Location = new System.Drawing.Point(634, 508);
            this.lblValoareTotal.Name = "lblValoareTotal";
            this.lblValoareTotal.Size = new System.Drawing.Size(19, 20);
            this.lblValoareTotal.TabIndex = 5;
            this.lblValoareTotal.Text = "0";
            // 
            // lblValoareSubtotal
            // 
            this.lblValoareSubtotal.AutoSize = true;
            this.lblValoareSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValoareSubtotal.Location = new System.Drawing.Point(634, 459);
            this.lblValoareSubtotal.Name = "lblValoareSubtotal";
            this.lblValoareSubtotal.Size = new System.Drawing.Size(19, 20);
            this.lblValoareSubtotal.TabIndex = 4;
            this.lblValoareSubtotal.Text = "0";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(634, 486);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(45, 16);
            this.lblTotal.TabIndex = 3;
            this.lblTotal.Text = "Total: ";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.Location = new System.Drawing.Point(634, 437);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(63, 16);
            this.lblSubtotal.TabIndex = 2;
            this.lblSubtotal.Text = "Subtotal: ";
            // 
            // lstEvenimente
            // 
            this.lstEvenimente.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clhData,
            this.clhDetalii,
            this.clhPerioada,
            this.clhSuma});
            this.lstEvenimente.FullRowSelect = true;
            this.lstEvenimente.GridLines = true;
            this.lstEvenimente.Location = new System.Drawing.Point(3, 3);
            this.lstEvenimente.Name = "lstEvenimente";
            this.lstEvenimente.Size = new System.Drawing.Size(625, 524);
            this.lstEvenimente.TabIndex = 0;
            this.lstEvenimente.UseCompatibleStateImageBehavior = false;
            this.lstEvenimente.View = System.Windows.Forms.View.Details;
            this.lstEvenimente.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lstEvenimente_ColumnClick);
            // 
            // clhData
            // 
            this.clhData.Text = "Data";
            this.clhData.Width = 71;
            // 
            // clhDetalii
            // 
            this.clhDetalii.Text = "Detalii";
            this.clhDetalii.Width = 346;
            // 
            // clhPerioada
            // 
            this.clhPerioada.Text = "Perioada";
            this.clhPerioada.Width = 105;
            // 
            // clhSuma
            // 
            this.clhSuma.Text = "Suma";
            this.clhSuma.Width = 98;
            // 
            // mnuMeniu
            // 
            this.mnuMeniu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFisier,
            this.mnuEveniment,
            this.mnuNotite,
            this.mnuGrafic,
            this.mnuAjutor,
            this.mnuFiltru,
            this.mnuFiltruLabel});
            this.mnuMeniu.Location = new System.Drawing.Point(0, 0);
            this.mnuMeniu.Name = "mnuMeniu";
            this.mnuMeniu.Size = new System.Drawing.Size(794, 27);
            this.mnuMeniu.TabIndex = 1;
            this.mnuMeniu.Text = "menuStrip1";
            // 
            // mnuFisier
            // 
            this.mnuFisier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDeschide,
            this.mnuSalveaza,
            this.mnuSeparatorFisier,
            this.mnuExportaExcel,
            this.mnuSeparatorFisier2,
            this.mnuIesire});
            this.mnuFisier.Name = "mnuFisier";
            this.mnuFisier.Size = new System.Drawing.Size(46, 23);
            this.mnuFisier.Text = "Fisier";
            // 
            // mnuDeschide
            // 
            this.mnuDeschide.Name = "mnuDeschide";
            this.mnuDeschide.Size = new System.Drawing.Size(151, 22);
            this.mnuDeschide.Text = "Deschide";
            this.mnuDeschide.Click += new System.EventHandler(this.mnuDeschide_Click);
            // 
            // mnuSalveaza
            // 
            this.mnuSalveaza.Name = "mnuSalveaza";
            this.mnuSalveaza.Size = new System.Drawing.Size(151, 22);
            this.mnuSalveaza.Text = "Salveaza";
            this.mnuSalveaza.Click += new System.EventHandler(this.mnuSalveaza_Click);
            // 
            // mnuSeparatorFisier
            // 
            this.mnuSeparatorFisier.Name = "mnuSeparatorFisier";
            this.mnuSeparatorFisier.Size = new System.Drawing.Size(148, 6);
            // 
            // mnuExportaExcel
            // 
            this.mnuExportaExcel.Name = "mnuExportaExcel";
            this.mnuExportaExcel.Size = new System.Drawing.Size(151, 22);
            this.mnuExportaExcel.Text = "Exporta Excel...";
            this.mnuExportaExcel.Click += new System.EventHandler(this.mnuExportaExcel_Click);
            // 
            // mnuSeparatorFisier2
            // 
            this.mnuSeparatorFisier2.Name = "mnuSeparatorFisier2";
            this.mnuSeparatorFisier2.Size = new System.Drawing.Size(148, 6);
            // 
            // mnuIesire
            // 
            this.mnuIesire.Name = "mnuIesire";
            this.mnuIesire.Size = new System.Drawing.Size(151, 22);
            this.mnuIesire.Text = "Iesire";
            this.mnuIesire.Click += new System.EventHandler(this.mnuIesire_Click);
            // 
            // mnuEveniment
            // 
            this.mnuEveniment.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAdauga,
            this.mnuModifica,
            this.mnuSterge,
            this.mnuSeparatorEveniment,
            this.mnuAfiseazaCheltuieli,
            this.mnuAfiseazaVenituri});
            this.mnuEveniment.Name = "mnuEveniment";
            this.mnuEveniment.Size = new System.Drawing.Size(75, 23);
            this.mnuEveniment.Text = "Eveniment";
            // 
            // mnuAdauga
            // 
            this.mnuAdauga.Name = "mnuAdauga";
            this.mnuAdauga.Size = new System.Drawing.Size(168, 22);
            this.mnuAdauga.Text = "Adauga...";
            this.mnuAdauga.Click += new System.EventHandler(this.mnuAdauga_Click);
            // 
            // mnuModifica
            // 
            this.mnuModifica.Name = "mnuModifica";
            this.mnuModifica.Size = new System.Drawing.Size(168, 22);
            this.mnuModifica.Text = "Modifica...";
            this.mnuModifica.Click += new System.EventHandler(this.mnuModifica_Click);
            // 
            // mnuSterge
            // 
            this.mnuSterge.Name = "mnuSterge";
            this.mnuSterge.Size = new System.Drawing.Size(168, 22);
            this.mnuSterge.Text = "Sterge";
            this.mnuSterge.Click += new System.EventHandler(this.mnuSterge_Click);
            // 
            // mnuSeparatorEveniment
            // 
            this.mnuSeparatorEveniment.Name = "mnuSeparatorEveniment";
            this.mnuSeparatorEveniment.Size = new System.Drawing.Size(165, 6);
            // 
            // mnuAfiseazaCheltuieli
            // 
            this.mnuAfiseazaCheltuieli.Checked = true;
            this.mnuAfiseazaCheltuieli.CheckOnClick = true;
            this.mnuAfiseazaCheltuieli.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnuAfiseazaCheltuieli.Name = "mnuAfiseazaCheltuieli";
            this.mnuAfiseazaCheltuieli.Size = new System.Drawing.Size(168, 22);
            this.mnuAfiseazaCheltuieli.Text = "Afiseaza cheltuieli";
            this.mnuAfiseazaCheltuieli.Click += new System.EventHandler(this.mnuAfiseazaCheltuieli_Click);
            // 
            // mnuAfiseazaVenituri
            // 
            this.mnuAfiseazaVenituri.Checked = true;
            this.mnuAfiseazaVenituri.CheckOnClick = true;
            this.mnuAfiseazaVenituri.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnuAfiseazaVenituri.Name = "mnuAfiseazaVenituri";
            this.mnuAfiseazaVenituri.Size = new System.Drawing.Size(168, 22);
            this.mnuAfiseazaVenituri.Text = "Afiseaza venituri";
            this.mnuAfiseazaVenituri.Click += new System.EventHandler(this.mnuAfiseazaVenituri_Click);
            // 
            // mnuNotite
            // 
            this.mnuNotite.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAdaugaNotita,
            this.mnuAfiseazaToate});
            this.mnuNotite.Name = "mnuNotite";
            this.mnuNotite.Size = new System.Drawing.Size(52, 23);
            this.mnuNotite.Text = "Notite";
            // 
            // mnuAdaugaNotita
            // 
            this.mnuAdaugaNotita.Name = "mnuAdaugaNotita";
            this.mnuAdaugaNotita.Size = new System.Drawing.Size(147, 22);
            this.mnuAdaugaNotita.Text = "Adauga...";
            this.mnuAdaugaNotita.Click += new System.EventHandler(this.mnuAdaugaNotita_Click);
            // 
            // mnuAfiseazaToate
            // 
            this.mnuAfiseazaToate.Name = "mnuAfiseazaToate";
            this.mnuAfiseazaToate.Size = new System.Drawing.Size(147, 22);
            this.mnuAfiseazaToate.Text = "Afiseaza toate";
            this.mnuAfiseazaToate.Click += new System.EventHandler(this.mnuAfiseazaToate_Click);
            // 
            // mnuGrafic
            // 
            this.mnuGrafic.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAfiseazaGrafic,
            this.mnuSalveazaGrafic});
            this.mnuGrafic.Name = "mnuGrafic";
            this.mnuGrafic.Size = new System.Drawing.Size(50, 23);
            this.mnuGrafic.Text = "Grafic";
            // 
            // mnuAfiseazaGrafic
            // 
            this.mnuAfiseazaGrafic.Name = "mnuAfiseazaGrafic";
            this.mnuAfiseazaGrafic.Size = new System.Drawing.Size(151, 22);
            this.mnuAfiseazaGrafic.Text = "Afiseaza grafic";
            this.mnuAfiseazaGrafic.Click += new System.EventHandler(this.mnuAfiseazaGrafic_Click);
            // 
            // mnuSalveazaGrafic
            // 
            this.mnuSalveazaGrafic.Name = "mnuSalveazaGrafic";
            this.mnuSalveazaGrafic.Size = new System.Drawing.Size(151, 22);
            this.mnuSalveazaGrafic.Text = "Salveaza grafic";
            this.mnuSalveazaGrafic.Click += new System.EventHandler(this.mnuSalveazaGrafic_Click);
            // 
            // mnuAjutor
            // 
            this.mnuAjutor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTutorial,
            this.mnuSeparatorAjutor,
            this.mnuDespre});
            this.mnuAjutor.Name = "mnuAjutor";
            this.mnuAjutor.Size = new System.Drawing.Size(52, 23);
            this.mnuAjutor.Text = "Ajutor";
            // 
            // mnuTutorial
            // 
            this.mnuTutorial.Name = "mnuTutorial";
            this.mnuTutorial.Size = new System.Drawing.Size(115, 22);
            this.mnuTutorial.Text = "Tutorial";
            this.mnuTutorial.Click += new System.EventHandler(this.mnuTutorial_Click);
            // 
            // mnuSeparatorAjutor
            // 
            this.mnuSeparatorAjutor.Name = "mnuSeparatorAjutor";
            this.mnuSeparatorAjutor.Size = new System.Drawing.Size(112, 6);
            // 
            // mnuDespre
            // 
            this.mnuDespre.Name = "mnuDespre";
            this.mnuDespre.Size = new System.Drawing.Size(115, 22);
            this.mnuDespre.Text = "Despre";
            this.mnuDespre.Click += new System.EventHandler(this.mnuDespre_Click);
            // 
            // mnuFiltru
            // 
            this.mnuFiltru.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuFiltru.BackColor = System.Drawing.SystemColors.Window;
            this.mnuFiltru.Name = "mnuFiltru";
            this.mnuFiltru.Size = new System.Drawing.Size(200, 23);
            this.mnuFiltru.TextChanged += new System.EventHandler(this.mnuFiltru_TextChanged);
            // 
            // mnuFiltruLabel
            // 
            this.mnuFiltruLabel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuFiltruLabel.Name = "mnuFiltruLabel";
            this.mnuFiltruLabel.Size = new System.Drawing.Size(49, 23);
            this.mnuFiltruLabel.Text = "Filtru:";
            // 
            // pnlAdaugaEveniment
            // 
            this.pnlAdaugaEveniment.Controls.Add(this.btnInapoiAdaugaEveniment);
            this.pnlAdaugaEveniment.Controls.Add(this.lblAdaugaEveniment);
            this.pnlAdaugaEveniment.Controls.Add(this.txtDetalii);
            this.pnlAdaugaEveniment.Controls.Add(this.cmbTipEveniment);
            this.pnlAdaugaEveniment.Controls.Add(this.txtOdataLa);
            this.pnlAdaugaEveniment.Controls.Add(this.cmbPerioada);
            this.pnlAdaugaEveniment.Controls.Add(this.txtSuma);
            this.pnlAdaugaEveniment.Controls.Add(this.lblDetalii);
            this.pnlAdaugaEveniment.Controls.Add(this.lblTipEveniment);
            this.pnlAdaugaEveniment.Controls.Add(this.lblOdataLa);
            this.pnlAdaugaEveniment.Controls.Add(this.lblPerioada);
            this.pnlAdaugaEveniment.Controls.Add(this.lblSuma);
            this.pnlAdaugaEveniment.Controls.Add(this.lblData);
            this.pnlAdaugaEveniment.Controls.Add(this.dtpData);
            this.pnlAdaugaEveniment.Controls.Add(this.btnAdaugaEveniment);
            this.pnlAdaugaEveniment.Location = new System.Drawing.Point(12, 30);
            this.pnlAdaugaEveniment.Name = "pnlAdaugaEveniment";
            this.pnlAdaugaEveniment.Size = new System.Drawing.Size(770, 530);
            this.pnlAdaugaEveniment.TabIndex = 2;
            // 
            // btnInapoiAdaugaEveniment
            // 
            this.btnInapoiAdaugaEveniment.Location = new System.Drawing.Point(3, 3);
            this.btnInapoiAdaugaEveniment.Name = "btnInapoiAdaugaEveniment";
            this.btnInapoiAdaugaEveniment.Size = new System.Drawing.Size(62, 24);
            this.btnInapoiAdaugaEveniment.TabIndex = 14;
            this.btnInapoiAdaugaEveniment.Text = "<< Inapoi";
            this.btnInapoiAdaugaEveniment.UseVisualStyleBackColor = true;
            this.btnInapoiAdaugaEveniment.Click += new System.EventHandler(this.btnInapoiAdaugaEveniment_Click);
            // 
            // lblAdaugaEveniment
            // 
            this.lblAdaugaEveniment.AutoSize = true;
            this.lblAdaugaEveniment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdaugaEveniment.Location = new System.Drawing.Point(312, 78);
            this.lblAdaugaEveniment.Name = "lblAdaugaEveniment";
            this.lblAdaugaEveniment.Size = new System.Drawing.Size(195, 20);
            this.lblAdaugaEveniment.TabIndex = 13;
            this.lblAdaugaEveniment.Text = "Adauga un eveniment nou";
            // 
            // txtDetalii
            // 
            this.txtDetalii.Location = new System.Drawing.Point(224, 269);
            this.txtDetalii.Multiline = true;
            this.txtDetalii.Name = "txtDetalii";
            this.txtDetalii.Size = new System.Drawing.Size(373, 110);
            this.txtDetalii.TabIndex = 12;
            // 
            // cmbTipEveniment
            // 
            this.cmbTipEveniment.FormattingEnabled = true;
            this.cmbTipEveniment.Items.AddRange(new object[] {
            "Cheltuiala",
            "Venit"});
            this.cmbTipEveniment.Location = new System.Drawing.Point(223, 242);
            this.cmbTipEveniment.Name = "cmbTipEveniment";
            this.cmbTipEveniment.Size = new System.Drawing.Size(374, 21);
            this.cmbTipEveniment.TabIndex = 11;
            this.cmbTipEveniment.Text = "Alegeti tipul evenimentului...";
            // 
            // txtOdataLa
            // 
            this.txtOdataLa.Location = new System.Drawing.Point(224, 215);
            this.txtOdataLa.Name = "txtOdataLa";
            this.txtOdataLa.Size = new System.Drawing.Size(373, 20);
            this.txtOdataLa.TabIndex = 10;
            // 
            // cmbPerioada
            // 
            this.cmbPerioada.FormattingEnabled = true;
            this.cmbPerioada.Items.AddRange(new object[] {
            "Lunar",
            "Saptamanal",
            "Odata la n zile",
            "Alt tip"});
            this.cmbPerioada.Location = new System.Drawing.Point(223, 187);
            this.cmbPerioada.Name = "cmbPerioada";
            this.cmbPerioada.Size = new System.Drawing.Size(374, 21);
            this.cmbPerioada.TabIndex = 9;
            this.cmbPerioada.Text = "Alegeti o perioada...";
            this.cmbPerioada.SelectedIndexChanged += new System.EventHandler(this.cmbPerioada_SelectedIndexChanged);
            // 
            // txtSuma
            // 
            this.txtSuma.Location = new System.Drawing.Point(224, 157);
            this.txtSuma.Name = "txtSuma";
            this.txtSuma.Size = new System.Drawing.Size(373, 20);
            this.txtSuma.TabIndex = 8;
            // 
            // lblDetalii
            // 
            this.lblDetalii.AutoSize = true;
            this.lblDetalii.Location = new System.Drawing.Point(178, 272);
            this.lblDetalii.Name = "lblDetalii";
            this.lblDetalii.Size = new System.Drawing.Size(39, 13);
            this.lblDetalii.TabIndex = 7;
            this.lblDetalii.Text = "Detalii:";
            // 
            // lblTipEveniment
            // 
            this.lblTipEveniment.AutoSize = true;
            this.lblTipEveniment.Location = new System.Drawing.Point(140, 245);
            this.lblTipEveniment.Name = "lblTipEveniment";
            this.lblTipEveniment.Size = new System.Drawing.Size(77, 13);
            this.lblTipEveniment.TabIndex = 6;
            this.lblTipEveniment.Text = "Tip eveniment:";
            // 
            // lblOdataLa
            // 
            this.lblOdataLa.AutoSize = true;
            this.lblOdataLa.Location = new System.Drawing.Point(167, 218);
            this.lblOdataLa.Name = "lblOdataLa";
            this.lblOdataLa.Size = new System.Drawing.Size(50, 13);
            this.lblOdataLa.TabIndex = 5;
            this.lblOdataLa.Text = "Odata la:";
            // 
            // lblPerioada
            // 
            this.lblPerioada.AutoSize = true;
            this.lblPerioada.Location = new System.Drawing.Point(165, 190);
            this.lblPerioada.Name = "lblPerioada";
            this.lblPerioada.Size = new System.Drawing.Size(52, 13);
            this.lblPerioada.TabIndex = 4;
            this.lblPerioada.Text = "Perioada:";
            // 
            // lblSuma
            // 
            this.lblSuma.AutoSize = true;
            this.lblSuma.Location = new System.Drawing.Point(180, 160);
            this.lblSuma.Name = "lblSuma";
            this.lblSuma.Size = new System.Drawing.Size(37, 13);
            this.lblSuma.TabIndex = 3;
            this.lblSuma.Text = "Suma:";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(184, 129);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(33, 13);
            this.lblData.TabIndex = 2;
            this.lblData.Text = "Data:";
            // 
            // dtpData
            // 
            this.dtpData.Location = new System.Drawing.Point(223, 126);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(374, 20);
            this.dtpData.TabIndex = 1;
            // 
            // btnAdaugaEveniment
            // 
            this.btnAdaugaEveniment.Location = new System.Drawing.Point(352, 385);
            this.btnAdaugaEveniment.Name = "btnAdaugaEveniment";
            this.btnAdaugaEveniment.Size = new System.Drawing.Size(117, 31);
            this.btnAdaugaEveniment.TabIndex = 0;
            this.btnAdaugaEveniment.Text = "Adauga eveniment";
            this.btnAdaugaEveniment.UseVisualStyleBackColor = true;
            this.btnAdaugaEveniment.Click += new System.EventHandler(this.btnAdaugaEveniment_Click);
            // 
            // pnlGrafic
            // 
            this.pnlGrafic.Controls.Add(this.grpPerioadaAfisata);
            this.pnlGrafic.Controls.Add(this.btnInapoiGrafic);
            this.pnlGrafic.Controls.Add(this.grpTipGrafic);
            this.pnlGrafic.Controls.Add(this.chrGrafic);
            this.pnlGrafic.Location = new System.Drawing.Point(12, 30);
            this.pnlGrafic.Name = "pnlGrafic";
            this.pnlGrafic.Size = new System.Drawing.Size(770, 530);
            this.pnlGrafic.TabIndex = 3;
            // 
            // grpPerioadaAfisata
            // 
            this.grpPerioadaAfisata.Controls.Add(this.dtpSfarsit);
            this.grpPerioadaAfisata.Controls.Add(this.lblSfarsit);
            this.grpPerioadaAfisata.Controls.Add(this.lblInceput);
            this.grpPerioadaAfisata.Controls.Add(this.dtpInceput);
            this.grpPerioadaAfisata.Location = new System.Drawing.Point(151, 12);
            this.grpPerioadaAfisata.Name = "grpPerioadaAfisata";
            this.grpPerioadaAfisata.Size = new System.Drawing.Size(318, 72);
            this.grpPerioadaAfisata.TabIndex = 3;
            this.grpPerioadaAfisata.TabStop = false;
            this.grpPerioadaAfisata.Text = "Perioada afisata";
            // 
            // dtpSfarsit
            // 
            this.dtpSfarsit.Location = new System.Drawing.Point(82, 46);
            this.dtpSfarsit.Name = "dtpSfarsit";
            this.dtpSfarsit.Size = new System.Drawing.Size(227, 20);
            this.dtpSfarsit.TabIndex = 3;
            this.dtpSfarsit.ValueChanged += new System.EventHandler(this.dtpSfarsit_ValueChanged);
            // 
            // lblSfarsit
            // 
            this.lblSfarsit.AutoSize = true;
            this.lblSfarsit.Location = new System.Drawing.Point(16, 46);
            this.lblSfarsit.Name = "lblSfarsit";
            this.lblSfarsit.Size = new System.Drawing.Size(60, 13);
            this.lblSfarsit.TabIndex = 2;
            this.lblSfarsit.Text = "Data sfarsit";
            // 
            // lblInceput
            // 
            this.lblInceput.AutoSize = true;
            this.lblInceput.Location = new System.Drawing.Point(8, 21);
            this.lblInceput.Name = "lblInceput";
            this.lblInceput.Size = new System.Drawing.Size(68, 13);
            this.lblInceput.TabIndex = 1;
            this.lblInceput.Text = "Data inceput";
            // 
            // dtpInceput
            // 
            this.dtpInceput.Location = new System.Drawing.Point(82, 20);
            this.dtpInceput.Name = "dtpInceput";
            this.dtpInceput.Size = new System.Drawing.Size(227, 20);
            this.dtpInceput.TabIndex = 0;
            this.dtpInceput.ValueChanged += new System.EventHandler(this.dtpInceput_ValueChanged);
            // 
            // btnInapoiGrafic
            // 
            this.btnInapoiGrafic.Location = new System.Drawing.Point(3, 3);
            this.btnInapoiGrafic.Name = "btnInapoiGrafic";
            this.btnInapoiGrafic.Size = new System.Drawing.Size(62, 24);
            this.btnInapoiGrafic.TabIndex = 2;
            this.btnInapoiGrafic.Text = "<< Inapoi";
            this.btnInapoiGrafic.UseVisualStyleBackColor = true;
            this.btnInapoiGrafic.Click += new System.EventHandler(this.btnInapoiGrafic_Click);
            // 
            // grpTipGrafic
            // 
            this.grpTipGrafic.Controls.Add(this.radValoriCumulative);
            this.grpTipGrafic.Controls.Add(this.radValoriAbsolute);
            this.grpTipGrafic.Location = new System.Drawing.Point(479, 12);
            this.grpTipGrafic.Name = "grpTipGrafic";
            this.grpTipGrafic.Size = new System.Drawing.Size(118, 73);
            this.grpTipGrafic.TabIndex = 1;
            this.grpTipGrafic.TabStop = false;
            this.grpTipGrafic.Text = "Tip grafic";
            // 
            // radValoriCumulative
            // 
            this.radValoriCumulative.AutoSize = true;
            this.radValoriCumulative.Location = new System.Drawing.Point(7, 46);
            this.radValoriCumulative.Name = "radValoriCumulative";
            this.radValoriCumulative.Size = new System.Drawing.Size(105, 17);
            this.radValoriCumulative.TabIndex = 1;
            this.radValoriCumulative.Text = "Valori cumulative";
            this.radValoriCumulative.UseVisualStyleBackColor = true;
            this.radValoriCumulative.CheckedChanged += new System.EventHandler(this.radValoriCumulative_CheckedChanged);
            // 
            // radValoriAbsolute
            // 
            this.radValoriAbsolute.AutoSize = true;
            this.radValoriAbsolute.Checked = true;
            this.radValoriAbsolute.Location = new System.Drawing.Point(7, 20);
            this.radValoriAbsolute.Name = "radValoriAbsolute";
            this.radValoriAbsolute.Size = new System.Drawing.Size(94, 17);
            this.radValoriAbsolute.TabIndex = 0;
            this.radValoriAbsolute.TabStop = true;
            this.radValoriAbsolute.Text = "Valori absolute";
            this.radValoriAbsolute.UseVisualStyleBackColor = true;
            this.radValoriAbsolute.CheckedChanged += new System.EventHandler(this.radValoriAbsolute_CheckedChanged);
            // 
            // chrGrafic
            // 
            chartArea2.Name = "ChartArea1";
            this.chrGrafic.ChartAreas.Add(chartArea2);
            legend2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend2.IsTextAutoFit = false;
            legend2.Name = "Legend1";
            this.chrGrafic.Legends.Add(legend2);
            this.chrGrafic.Location = new System.Drawing.Point(13, 91);
            this.chrGrafic.Name = "chrGrafic";
            this.chrGrafic.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chrGrafic.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Red,
        System.Drawing.Color.Lime};
            series3.BorderWidth = 2;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Cheltuieli";
            series3.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series3.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series4.BorderWidth = 2;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "Venituri";
            series4.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series4.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.chrGrafic.Series.Add(series3);
            this.chrGrafic.Series.Add(series4);
            this.chrGrafic.Size = new System.Drawing.Size(743, 422);
            this.chrGrafic.TabIndex = 0;
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title2.Name = "ttlTitluGrafic";
            title2.Text = "Evolutia cheltuielilor/veniturilor";
            this.chrGrafic.Titles.Add(title2);
            // 
            // dlgSalveazaGrafic
            // 
            this.dlgSalveazaGrafic.FileName = "grafic";
            this.dlgSalveazaGrafic.Title = "Salveaza grafic";
            // 
            // tmrEvenimente
            // 
            this.tmrEvenimente.Interval = 10000;
            this.tmrEvenimente.Tick += new System.EventHandler(this.tmrEvenimente_Tick);
            // 
            // pnlNotite
            // 
            this.pnlNotite.Controls.Add(this.btnAmCitit);
            this.pnlNotite.Controls.Add(this.btnInapoiNotite);
            this.pnlNotite.Controls.Add(this.lstNotite);
            this.pnlNotite.Location = new System.Drawing.Point(12, 30);
            this.pnlNotite.Name = "pnlNotite";
            this.pnlNotite.Size = new System.Drawing.Size(770, 530);
            this.pnlNotite.TabIndex = 4;
            // 
            // btnAmCitit
            // 
            this.btnAmCitit.Location = new System.Drawing.Point(663, 4);
            this.btnAmCitit.Name = "btnAmCitit";
            this.btnAmCitit.Size = new System.Drawing.Size(93, 32);
            this.btnAmCitit.TabIndex = 4;
            this.btnAmCitit.Text = "Am citit notitele";
            this.btnAmCitit.UseVisualStyleBackColor = true;
            this.btnAmCitit.Click += new System.EventHandler(this.btnAmCitit_Click);
            // 
            // btnInapoiNotite
            // 
            this.btnInapoiNotite.Location = new System.Drawing.Point(3, 3);
            this.btnInapoiNotite.Name = "btnInapoiNotite";
            this.btnInapoiNotite.Size = new System.Drawing.Size(62, 24);
            this.btnInapoiNotite.TabIndex = 3;
            this.btnInapoiNotite.Text = "<< Inapoi";
            this.btnInapoiNotite.UseVisualStyleBackColor = true;
            this.btnInapoiNotite.Click += new System.EventHandler(this.btnInapoiNotite_Click);
            // 
            // lstNotite
            // 
            this.lstNotite.FullRowSelect = true;
            this.lstNotite.Location = new System.Drawing.Point(13, 42);
            this.lstNotite.Name = "lstNotite";
            this.lstNotite.Size = new System.Drawing.Size(743, 471);
            this.lstNotite.TabIndex = 0;
            this.lstNotite.UseCompatibleStateImageBehavior = false;
            this.lstNotite.View = System.Windows.Forms.View.List;
            // 
            // pnlAdaugaNotita
            // 
            this.pnlAdaugaNotita.Controls.Add(this.dtpDataNotita);
            this.pnlAdaugaNotita.Controls.Add(this.btnInapoiAdaugaNotita);
            this.pnlAdaugaNotita.Controls.Add(this.lblAdaugaNotita);
            this.pnlAdaugaNotita.Controls.Add(this.txtText);
            this.pnlAdaugaNotita.Controls.Add(this.lblText);
            this.pnlAdaugaNotita.Controls.Add(this.lblDataNotita);
            this.pnlAdaugaNotita.Controls.Add(this.btnAdaugaNotita);
            this.pnlAdaugaNotita.Location = new System.Drawing.Point(12, 30);
            this.pnlAdaugaNotita.Name = "pnlAdaugaNotita";
            this.pnlAdaugaNotita.Size = new System.Drawing.Size(770, 530);
            this.pnlAdaugaNotita.TabIndex = 5;
            // 
            // dtpDataNotita
            // 
            this.dtpDataNotita.Location = new System.Drawing.Point(208, 180);
            this.dtpDataNotita.Name = "dtpDataNotita";
            this.dtpDataNotita.Size = new System.Drawing.Size(374, 20);
            this.dtpDataNotita.TabIndex = 16;
            // 
            // btnInapoiAdaugaNotita
            // 
            this.btnInapoiAdaugaNotita.Location = new System.Drawing.Point(3, 4);
            this.btnInapoiAdaugaNotita.Name = "btnInapoiAdaugaNotita";
            this.btnInapoiAdaugaNotita.Size = new System.Drawing.Size(62, 24);
            this.btnInapoiAdaugaNotita.TabIndex = 29;
            this.btnInapoiAdaugaNotita.Text = "<< Inapoi";
            this.btnInapoiAdaugaNotita.UseVisualStyleBackColor = true;
            this.btnInapoiAdaugaNotita.Click += new System.EventHandler(this.btnInapoiAdaugaNotita_Click);
            // 
            // lblAdaugaNotita
            // 
            this.lblAdaugaNotita.AutoSize = true;
            this.lblAdaugaNotita.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdaugaNotita.Location = new System.Drawing.Point(332, 132);
            this.lblAdaugaNotita.Name = "lblAdaugaNotita";
            this.lblAdaugaNotita.Size = new System.Drawing.Size(122, 20);
            this.lblAdaugaNotita.TabIndex = 28;
            this.lblAdaugaNotita.Text = "Adauga o notita";
            // 
            // txtText
            // 
            this.txtText.Location = new System.Drawing.Point(208, 206);
            this.txtText.Multiline = true;
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(373, 110);
            this.txtText.TabIndex = 27;
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(170, 209);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(31, 13);
            this.lblText.TabIndex = 22;
            this.lblText.Text = "Text:";
            // 
            // lblDataNotita
            // 
            this.lblDataNotita.AutoSize = true;
            this.lblDataNotita.Location = new System.Drawing.Point(169, 186);
            this.lblDataNotita.Name = "lblDataNotita";
            this.lblDataNotita.Size = new System.Drawing.Size(33, 13);
            this.lblDataNotita.TabIndex = 17;
            this.lblDataNotita.Text = "Data:";
            // 
            // btnAdaugaNotita
            // 
            this.btnAdaugaNotita.Location = new System.Drawing.Point(336, 322);
            this.btnAdaugaNotita.Name = "btnAdaugaNotita";
            this.btnAdaugaNotita.Size = new System.Drawing.Size(117, 31);
            this.btnAdaugaNotita.TabIndex = 15;
            this.btnAdaugaNotita.Text = "Adauga notita";
            this.btnAdaugaNotita.UseVisualStyleBackColor = true;
            this.btnAdaugaNotita.Click += new System.EventHandler(this.btnAdaugaNotita_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 572);
            this.Controls.Add(this.pnlAdaugaEveniment);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlAdaugaNotita);
            this.Controls.Add(this.pnlNotite);
            this.Controls.Add(this.pnlGrafic);
            this.Controls.Add(this.mnuMeniu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.mnuMeniu;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistem de gestiune al cheltuielilor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmMain_Paint);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.mnuMeniu.ResumeLayout(false);
            this.mnuMeniu.PerformLayout();
            this.pnlAdaugaEveniment.ResumeLayout(false);
            this.pnlAdaugaEveniment.PerformLayout();
            this.pnlGrafic.ResumeLayout(false);
            this.grpPerioadaAfisata.ResumeLayout(false);
            this.grpPerioadaAfisata.PerformLayout();
            this.grpTipGrafic.ResumeLayout(false);
            this.grpTipGrafic.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrGrafic)).EndInit();
            this.pnlNotite.ResumeLayout(false);
            this.pnlAdaugaNotita.ResumeLayout(false);
            this.pnlAdaugaNotita.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.MenuStrip mnuMeniu;
        private System.Windows.Forms.ToolStripMenuItem mnuFisier;
        private System.Windows.Forms.ToolStripMenuItem mnuDeschide;
        private System.Windows.Forms.ToolStripMenuItem mnuSalveaza;
        private System.Windows.Forms.ToolStripSeparator mnuSeparatorFisier;
        private System.Windows.Forms.ToolStripMenuItem mnuIesire;
        private System.Windows.Forms.ToolStripMenuItem mnuEveniment;
        private System.Windows.Forms.ToolStripMenuItem mnuAdauga;
        private System.Windows.Forms.ToolStripMenuItem mnuAjutor;
        private System.Windows.Forms.ToolStripMenuItem mnuTutorial;
        private System.Windows.Forms.ToolStripSeparator mnuSeparatorAjutor;
        private System.Windows.Forms.ToolStripMenuItem mnuDespre;
        private System.Windows.Forms.ToolStripMenuItem mnuGrafic;
        private System.Windows.Forms.ToolStripMenuItem mnuAfiseazaGrafic;
        private System.Windows.Forms.ToolStripMenuItem mnuSalveazaGrafic;
        private System.Windows.Forms.ToolStripMenuItem mnuAfiseazaCheltuieli;
        private System.Windows.Forms.ToolStripMenuItem mnuAfiseazaVenituri;
        private System.Windows.Forms.ToolStripSeparator mnuSeparatorEveniment;
        private System.Windows.Forms.ToolStripMenuItem mnuExportaExcel;
        private System.Windows.Forms.ToolStripSeparator mnuSeparatorFisier2;
        private System.Windows.Forms.ToolStripTextBox mnuFiltru;
        private System.Windows.Forms.ToolStripMenuItem mnuFiltruLabel;
        private System.Windows.Forms.ListView lstEvenimente;
        private System.Windows.Forms.ColumnHeader clhData;
        private System.Windows.Forms.ColumnHeader clhDetalii;
        private System.Windows.Forms.ColumnHeader clhPerioada;
        private System.Windows.Forms.ColumnHeader clhSuma;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblValoareTotal;
        private System.Windows.Forms.Label lblValoareSubtotal;
        private System.Windows.Forms.Panel pnlAdaugaEveniment;
        private System.Windows.Forms.Button btnAdaugaEveniment;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblOdataLa;
        private System.Windows.Forms.Label lblPerioada;
        private System.Windows.Forms.Label lblSuma;
        private System.Windows.Forms.Label lblTipEveniment;
        private System.Windows.Forms.Label lblDetalii;
        private System.Windows.Forms.TextBox txtDetalii;
        private System.Windows.Forms.ComboBox cmbTipEveniment;
        private System.Windows.Forms.TextBox txtOdataLa;
        private System.Windows.Forms.ComboBox cmbPerioada;
        private System.Windows.Forms.TextBox txtSuma;
        private System.Windows.Forms.Label lblAdaugaEveniment;
        private System.Windows.Forms.Button btnInapoiAdaugaEveniment;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnSageataDreapta;
        private System.Windows.Forms.Label lblSageataDreapta;
        private System.Windows.Forms.Label lblMinus;
        private System.Windows.Forms.Label lblPlus;
        private System.Windows.Forms.ToolStripMenuItem mnuSterge;
        private System.Windows.Forms.ToolStripMenuItem mnuModifica;
        private System.Windows.Forms.Panel pnlGrafic;
        private System.Windows.Forms.GroupBox grpTipGrafic;
        private System.Windows.Forms.RadioButton radValoriCumulative;
        private System.Windows.Forms.RadioButton radValoriAbsolute;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrGrafic;
        private System.Windows.Forms.Button btnInapoiGrafic;
        private System.Windows.Forms.SaveFileDialog dlgSalveazaGrafic;
        private System.Windows.Forms.Timer tmrEvenimente;
        private System.Windows.Forms.Button btnNotite;
        private System.Windows.Forms.Label lblNrNotiteNecitite;
        private System.Windows.Forms.Panel pnlNotite;
        private System.Windows.Forms.Button btnInapoiNotite;
        private System.Windows.Forms.ListView lstNotite;
        private System.Windows.Forms.Button btnAmCitit;
        private System.Windows.Forms.ToolStripMenuItem mnuNotite;
        private System.Windows.Forms.ToolStripMenuItem mnuAdaugaNotita;
        private System.Windows.Forms.ToolStripMenuItem mnuAfiseazaToate;
        private System.Windows.Forms.Panel pnlAdaugaNotita;
        private System.Windows.Forms.Button btnInapoiAdaugaNotita;
        private System.Windows.Forms.Label lblAdaugaNotita;
        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Label lblDataNotita;
        private System.Windows.Forms.DateTimePicker dtpDataNotita;
        private System.Windows.Forms.Button btnAdaugaNotita;
        private System.Windows.Forms.Button btnExtinde;
        private System.Windows.Forms.GroupBox grpPerioadaAfisata;
        private System.Windows.Forms.DateTimePicker dtpSfarsit;
        private System.Windows.Forms.Label lblSfarsit;
        private System.Windows.Forms.Label lblInceput;
        private System.Windows.Forms.DateTimePicker dtpInceput;

    }
}

