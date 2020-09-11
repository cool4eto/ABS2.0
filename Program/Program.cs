using ABS.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Program
{
    public partial class Program : Form
    {
        private Button airportAdd;
        private RichTextBox txtConsole;
        private TextBox airportTextBox;
        private Label label1;
        private Label label2;
        private TextBox airlineTextBox;
        private Button airlineAdd;
        private Label label3;
        private ComboBox airlineCombo1;
        private Label label4;
        private Label label5;
        private ComboBox originAirportCombo1;
        private ComboBox destinationAirportCombo1;
        private Label label6;
        private Label label7;
        private DateTimePicker dateTimePicker1;
        private Label label8;
        private TextBox flightNameTextBox;
        private Button flightAdd;
        private Label label9;
        private ComboBox flightCombo1;
        private Label label10;
        private Label label11;
        private ComboBox airlineCombo2;
        private ComboBox seatClassCombo1;
        private Label label12;
        private NumericUpDown rowPicker;
        private NumericUpDown colPicker;
        private Label Rows;
        private Label Columns;
        private Button sectionAdd;
        private Label label13;
        private Label label14;
        private ComboBox destinationAirportCombo2;
        private ComboBox originAirportCombo2;
        private Label label15;
        private Button flightsFind;
        private Label label16;
        private ComboBox flightCombo2;
        private Label label17;
        private ComboBox seatCombo1;
        private Button seatBook;
        private Button sysDetails;
        SystemManager res = new SystemManager();
        public Program()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.airportAdd = new System.Windows.Forms.Button();
            this.txtConsole = new System.Windows.Forms.RichTextBox();
            this.airportTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.airlineTextBox = new System.Windows.Forms.TextBox();
            this.airlineAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.airlineCombo1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.originAirportCombo1 = new System.Windows.Forms.ComboBox();
            this.destinationAirportCombo1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.flightNameTextBox = new System.Windows.Forms.TextBox();
            this.flightAdd = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.flightCombo1 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.airlineCombo2 = new System.Windows.Forms.ComboBox();
            this.seatClassCombo1 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.rowPicker = new System.Windows.Forms.NumericUpDown();
            this.colPicker = new System.Windows.Forms.NumericUpDown();
            this.Rows = new System.Windows.Forms.Label();
            this.Columns = new System.Windows.Forms.Label();
            this.sectionAdd = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.destinationAirportCombo2 = new System.Windows.Forms.ComboBox();
            this.originAirportCombo2 = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.flightsFind = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.flightCombo2 = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.seatCombo1 = new System.Windows.Forms.ComboBox();
            this.seatBook = new System.Windows.Forms.Button();
            this.sysDetails = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.rowPicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colPicker)).BeginInit();
            this.SuspendLayout();
            // 
            // airportAdd
            // 
            this.airportAdd.Location = new System.Drawing.Point(220, 12);
            this.airportAdd.Name = "airportAdd";
            this.airportAdd.Size = new System.Drawing.Size(75, 23);
            this.airportAdd.TabIndex = 2;
            this.airportAdd.Text = "Add airport";
            this.airportAdd.UseVisualStyleBackColor = true;
            this.airportAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtConsole
            // 
            this.txtConsole.Location = new System.Drawing.Point(19, 657);
            this.txtConsole.Name = "txtConsole";
            this.txtConsole.Size = new System.Drawing.Size(450, 157);
            this.txtConsole.TabIndex = 3;
            this.txtConsole.Text = "";
            // 
            // airportTextBox
            // 
            this.airportTextBox.Location = new System.Drawing.Point(114, 13);
            this.airportTextBox.Name = "airportTextBox";
            this.airportTextBox.Size = new System.Drawing.Size(100, 20);
            this.airportTextBox.TabIndex = 4;
            this.airportTextBox.TextChanged += new System.EventHandler(this.airportTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "New airport name: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "New airline name: ";
            // 
            // airlineTextBox
            // 
            this.airlineTextBox.Location = new System.Drawing.Point(114, 44);
            this.airlineTextBox.Name = "airlineTextBox";
            this.airlineTextBox.Size = new System.Drawing.Size(100, 20);
            this.airlineTextBox.TabIndex = 7;
            // 
            // airlineAdd
            // 
            this.airlineAdd.Location = new System.Drawing.Point(221, 42);
            this.airlineAdd.Name = "airlineAdd";
            this.airlineAdd.Size = new System.Drawing.Size(75, 23);
            this.airlineAdd.TabIndex = 8;
            this.airlineAdd.Text = "Add airline";
            this.airlineAdd.UseVisualStyleBackColor = true;
            this.airlineAdd.Click += new System.EventHandler(this.airlineAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "New Flight";
            // 
            // airlineCombo1
            // 
            this.airlineCombo1.FormattingEnabled = true;
            this.airlineCombo1.Location = new System.Drawing.Point(114, 98);
            this.airlineCombo1.Name = "airlineCombo1";
            this.airlineCombo1.Size = new System.Drawing.Size(121, 21);
            this.airlineCombo1.TabIndex = 10;
            this.airlineCombo1.SelectedIndexChanged += new System.EventHandler(this.airlineCombo1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Airline: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Origin airport:";
            // 
            // originAirportCombo1
            // 
            this.originAirportCombo1.FormattingEnabled = true;
            this.originAirportCombo1.Location = new System.Drawing.Point(114, 128);
            this.originAirportCombo1.Name = "originAirportCombo1";
            this.originAirportCombo1.Size = new System.Drawing.Size(121, 21);
            this.originAirportCombo1.TabIndex = 13;
            // 
            // destinationAirportCombo1
            // 
            this.destinationAirportCombo1.FormattingEnabled = true;
            this.destinationAirportCombo1.Location = new System.Drawing.Point(114, 155);
            this.destinationAirportCombo1.Name = "destinationAirportCombo1";
            this.destinationAirportCombo1.Size = new System.Drawing.Size(121, 21);
            this.destinationAirportCombo1.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Destinationd airport:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Date:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(114, 190);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 226);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Flight name: ";
            // 
            // flightNameTextBox
            // 
            this.flightNameTextBox.Location = new System.Drawing.Point(114, 222);
            this.flightNameTextBox.Name = "flightNameTextBox";
            this.flightNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.flightNameTextBox.TabIndex = 19;
            // 
            // flightAdd
            // 
            this.flightAdd.Location = new System.Drawing.Point(241, 218);
            this.flightAdd.Name = "flightAdd";
            this.flightAdd.Size = new System.Drawing.Size(75, 23);
            this.flightAdd.TabIndex = 20;
            this.flightAdd.Text = "Add Flight";
            this.flightAdd.UseVisualStyleBackColor = true;
            this.flightAdd.Click += new System.EventHandler(this.flightAdd_Click_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 268);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "New Section";
            // 
            // flightCombo1
            // 
            this.flightCombo1.FormattingEnabled = true;
            this.flightCombo1.Location = new System.Drawing.Point(114, 319);
            this.flightCombo1.Name = "flightCombo1";
            this.flightCombo1.Size = new System.Drawing.Size(121, 21);
            this.flightCombo1.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 325);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Flight:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 296);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Airline: ";
            // 
            // airlineCombo2
            // 
            this.airlineCombo2.FormattingEnabled = true;
            this.airlineCombo2.Location = new System.Drawing.Point(114, 291);
            this.airlineCombo2.Name = "airlineCombo2";
            this.airlineCombo2.Size = new System.Drawing.Size(121, 21);
            this.airlineCombo2.TabIndex = 22;
            this.airlineCombo2.SelectedIndexChanged += new System.EventHandler(this.airlineCombo2_SelectedIndexChanged);
            // 
            // seatClassCombo1
            // 
            this.seatClassCombo1.FormattingEnabled = true;
            this.seatClassCombo1.Location = new System.Drawing.Point(114, 348);
            this.seatClassCombo1.Name = "seatClassCombo1";
            this.seatClassCombo1.Size = new System.Drawing.Size(121, 21);
            this.seatClassCombo1.TabIndex = 27;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 355);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "Seat class:";
            // 
            // rowPicker
            // 
            this.rowPicker.Location = new System.Drawing.Point(114, 375);
            this.rowPicker.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.rowPicker.Name = "rowPicker";
            this.rowPicker.Size = new System.Drawing.Size(120, 20);
            this.rowPicker.TabIndex = 28;
            this.rowPicker.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // colPicker
            // 
            this.colPicker.Location = new System.Drawing.Point(114, 401);
            this.colPicker.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.colPicker.Name = "colPicker";
            this.colPicker.Size = new System.Drawing.Size(120, 20);
            this.colPicker.TabIndex = 29;
            this.colPicker.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Rows
            // 
            this.Rows.AutoSize = true;
            this.Rows.Location = new System.Drawing.Point(12, 379);
            this.Rows.Name = "Rows";
            this.Rows.Size = new System.Drawing.Size(34, 13);
            this.Rows.TabIndex = 30;
            this.Rows.Text = "Rows";
            // 
            // Columns
            // 
            this.Columns.AutoSize = true;
            this.Columns.Location = new System.Drawing.Point(12, 404);
            this.Columns.Name = "Columns";
            this.Columns.Size = new System.Drawing.Size(47, 13);
            this.Columns.TabIndex = 31;
            this.Columns.Text = "Columns";
            // 
            // sectionAdd
            // 
            this.sectionAdd.Location = new System.Drawing.Point(249, 399);
            this.sectionAdd.Name = "sectionAdd";
            this.sectionAdd.Size = new System.Drawing.Size(75, 23);
            this.sectionAdd.TabIndex = 32;
            this.sectionAdd.Text = "Add Section";
            this.sectionAdd.UseVisualStyleBackColor = true;
            this.sectionAdd.Click += new System.EventHandler(this.sectionAdd_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(27, 467);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 13);
            this.label13.TabIndex = 33;
            this.label13.Text = "Available flights";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 498);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 13);
            this.label14.TabIndex = 34;
            this.label14.Text = "Origin airport:";
            // 
            // destinationAirportCombo2
            // 
            this.destinationAirportCombo2.FormattingEnabled = true;
            this.destinationAirportCombo2.Location = new System.Drawing.Point(114, 525);
            this.destinationAirportCombo2.Name = "destinationAirportCombo2";
            this.destinationAirportCombo2.Size = new System.Drawing.Size(121, 21);
            this.destinationAirportCombo2.TabIndex = 36;
            this.destinationAirportCombo2.SelectedIndexChanged += new System.EventHandler(this.destinationAirportCombo2_SelectedIndexChanged);
            // 
            // originAirportCombo2
            // 
            this.originAirportCombo2.FormattingEnabled = true;
            this.originAirportCombo2.Location = new System.Drawing.Point(114, 492);
            this.originAirportCombo2.Name = "originAirportCombo2";
            this.originAirportCombo2.Size = new System.Drawing.Size(121, 21);
            this.originAirportCombo2.TabIndex = 35;
            this.originAirportCombo2.SelectedIndexChanged += new System.EventHandler(this.originAirportCombo2_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 528);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(101, 13);
            this.label15.TabIndex = 37;
            this.label15.Text = "Destinationd airport:";
            // 
            // flightsFind
            // 
            this.flightsFind.Location = new System.Drawing.Point(249, 508);
            this.flightsFind.Name = "flightsFind";
            this.flightsFind.Size = new System.Drawing.Size(75, 23);
            this.flightsFind.TabIndex = 38;
            this.flightsFind.Text = "Find Flights";
            this.flightsFind.UseVisualStyleBackColor = true;
            this.flightsFind.Click += new System.EventHandler(this.flightsFind_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(12, 557);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(38, 13);
            this.label16.TabIndex = 39;
            this.label16.Text = "Flight: ";
            // 
            // flightCombo2
            // 
            this.flightCombo2.FormattingEnabled = true;
            this.flightCombo2.Location = new System.Drawing.Point(114, 553);
            this.flightCombo2.Name = "flightCombo2";
            this.flightCombo2.Size = new System.Drawing.Size(121, 21);
            this.flightCombo2.TabIndex = 40;
            this.flightCombo2.SelectedIndexChanged += new System.EventHandler(this.flightCombo2_SelectedIndexChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(12, 584);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(35, 13);
            this.label17.TabIndex = 41;
            this.label17.Text = "Seat: ";
            // 
            // seatCombo1
            // 
            this.seatCombo1.FormattingEnabled = true;
            this.seatCombo1.Location = new System.Drawing.Point(114, 580);
            this.seatCombo1.Name = "seatCombo1";
            this.seatCombo1.Size = new System.Drawing.Size(121, 21);
            this.seatCombo1.TabIndex = 42;
            this.seatCombo1.SelectedIndexChanged += new System.EventHandler(this.seatCombo1_SelectedIndexChanged);
            // 
            // seatBook
            // 
            this.seatBook.Location = new System.Drawing.Point(249, 557);
            this.seatBook.Name = "seatBook";
            this.seatBook.Size = new System.Drawing.Size(75, 23);
            this.seatBook.TabIndex = 43;
            this.seatBook.Text = "Book Seat";
            this.seatBook.UseVisualStyleBackColor = true;
            this.seatBook.Click += new System.EventHandler(this.seatBook_Click);
            // 
            // sysDetails
            // 
            this.sysDetails.Location = new System.Drawing.Point(176, 628);
            this.sysDetails.Name = "sysDetails";
            this.sysDetails.Size = new System.Drawing.Size(148, 23);
            this.sysDetails.TabIndex = 44;
            this.sysDetails.Text = "Display System Details";
            this.sysDetails.UseVisualStyleBackColor = true;
            this.sysDetails.Click += new System.EventHandler(this.sysDetails_Click);
            // 
            // Program
            // 
            this.ClientSize = new System.Drawing.Size(492, 824);
            this.Controls.Add(this.sysDetails);
            this.Controls.Add(this.seatBook);
            this.Controls.Add(this.seatCombo1);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.flightCombo2);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.flightsFind);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.destinationAirportCombo2);
            this.Controls.Add(this.originAirportCombo2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.sectionAdd);
            this.Controls.Add(this.Columns);
            this.Controls.Add(this.Rows);
            this.Controls.Add(this.colPicker);
            this.Controls.Add(this.rowPicker);
            this.Controls.Add(this.seatClassCombo1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.flightCombo1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.airlineCombo2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.flightAdd);
            this.Controls.Add(this.flightNameTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.destinationAirportCombo1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.originAirportCombo1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.airlineCombo1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.airlineAdd);
            this.Controls.Add(this.airlineTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.airportTextBox);
            this.Controls.Add(this.txtConsole);
            this.Controls.Add(this.airportAdd);
            this.Name = "Program";
            this.Load += new System.EventHandler(this.Program_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rowPicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colPicker)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Program());


            /*Console.WriteLine("Prepearing the system: ");
            SystemManager res = new SystemManager();
            res.CreateAirport("DEN");
            res.CreateAirport("DFW");
            res.CreateAirport("LON");
            res.CreateAirport("JPN");
            // Invalid.
            res.CreateAirport("DE");
            res.CreateAirport("DEH");
            res.CreateAirport("DEN");
            res.CreateAirport("NCE");
            // Invalid.
            res.CreateAirport("TRIord9");
            res.CreateAirport("DEN");

            res.CreateAirline("DELTA");
            res.CreateAirline("AMER");
            res.CreateAirline("JET");
            // Already exists.
            res.CreateAirline("DELTA");
            res.CreateAirline("SWEST");
            // Already exists.
            res.CreateAirline("AMER");
            res.CreateAirline("FRONT");
            // Invalid
            res.CreateAirline("FRONTIER");

            res.CreateFlight("DELTA", "DEN", "LON", 2009, 10, 10, "123");
            res.CreateFlight("DELTA", "DEN", "DEH", 2009, 8, 8, "567");
            // Invalid.
            res.CreateFlight("DELTA", "DEN", "NCE", 2010, 9, 8, "567");
            res.CreateFlight("JET", "LON", "DEN", 2009, 5, 7, "123");
            res.CreateFlight("AMER", "DEN", "LON", 2010, 10, 1, "123");
            res.CreateFlight("JET", "DEN", "LON", 2010, 6, 10, "786");
            res.CreateFlight("JET", "DEN", "LON", 2009, 1, 12, "909");
            // Create sections.
            res.CreateSection("JET", "123", 2, 2, SeatClass.Economy);
            // Invalid for me.
            res.CreateSection("JET", "123", 1, 3, SeatClass.Economy);
            res.CreateSection("JET", "123", 2, 3, SeatClass.First);
            res.CreateSection("DELTA", "123", 1, 1, SeatClass.Business);
            res.CreateSection("DELTA", "123", 1, 2, SeatClass.Economy);
            // Invalid.
            res.CreateSection("SWSERTT", "123", 5, 5, SeatClass.Economy);


            Console.WriteLine("\nSystem Details: \n");


            res.DisplaySystemDetails();

            res.FindAvailableFlights("DEN", "LON");


            res.BookSeat("DELTA", "123", SeatClass.Business, 1, "A");
            res.BookSeat("DELTA", "123", SeatClass.Economy, 1, "A");
            res.BookSeat("DELTA", "123", SeatClass.Economy, 1, "B");
            // Already booked.
            res.BookSeat("DELTA", "123", SeatClass.Business, 1, "A");
            Console.WriteLine("\nSystem Details: \n");

            res.DisplaySystemDetails();

            res.FindAvailableFlights("DEN", "LON");
            Console.ReadKey();*/
        }

        private void Program_Load(object sender, EventArgs e)
        {
            TextBoxWriter writer = new TextBoxWriter(txtConsole);
            System.Console.SetOut(writer);
            ComboBoxesFill();
        }

        private void ComboBoxesFill()
        {
            airlineCombo1.Items.Clear();
            originAirportCombo1.Items.Clear();
            destinationAirportCombo1.Items.Clear();

            airlineCombo2.Items.Clear();

            originAirportCombo2.Items.Clear();
            destinationAirportCombo2.Items.Clear();


            airlineCombo1.Items.AddRange(res.GetAirlines().ToArray());
            originAirportCombo1.Items.AddRange(res.GetAirports().ToArray());
            destinationAirportCombo1.Items.AddRange(res.GetAirports().ToArray());


            airlineCombo2.Items.AddRange(res.GetAirlines().ToArray());
            seatClassCombo1.DataSource = Enum.GetValues(typeof(SeatClass));

            originAirportCombo2.Items.AddRange(res.GetAirports().ToArray());
            destinationAirportCombo2.Items.AddRange(res.GetAirports().ToArray());

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtConsole.Clear();
            res.CreateAirport(airportTextBox.Text);
            ComboBoxesFill();
        }

        private void airportTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void airlineAdd_Click(object sender, EventArgs e)
        {
            txtConsole.Clear();
            res.CreateAirline(airlineTextBox.Text);
            ComboBoxesFill();
        }

        private void airlineCombo1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void flightAdd_Click_1(object sender, EventArgs e)
        {
            txtConsole.Clear();
            res.CreateFlight(airlineCombo1.Text, originAirportCombo1.Text, destinationAirportCombo1.Text, dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, dateTimePicker1.Value.Day, flightNameTextBox.Text);
        }

        private void sectionAdd_Click(object sender, EventArgs e)
        {
            txtConsole.Clear();
            SeatClass seatClass;
            Enum.TryParse(seatClassCombo1.SelectedValue.ToString(), out seatClass);
            res.CreateSection(airlineCombo2.Text, flightCombo1.Text, decimal.ToInt32(rowPicker.Value), decimal.ToInt32(rowPicker.Value), seatClass);
        }

        private void airlineCombo2_SelectedIndexChanged(object sender, EventArgs e)
        {
            flightCombo1.Items.Clear();
            flightCombo1.Items.AddRange(res.GetFlightsForAirline(airlineCombo2.Text).ToArray());
        }

        private void flightsFind_Click(object sender, EventArgs e)
        {
            txtConsole.Clear();
            res.FindAvailableFlights(originAirportCombo2.Text, destinationAirportCombo2.Text);
        }

        private void destinationAirportCombo2_SelectedIndexChanged(object sender, EventArgs e)
        {
            flightCombo2.Items.Clear();
            txtConsole.Clear();
            if (originAirportCombo2.SelectedIndex > -1)
                flightCombo2.Items.AddRange(res.FindAvailableFlights(originAirportCombo2.Text, destinationAirportCombo2.Text).ToArray());
        }

        private void originAirportCombo2_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtConsole.Clear();
            flightCombo2.Items.Clear();
            if (destinationAirportCombo2.SelectedIndex > -1)
                flightCombo2.Items.AddRange(res.FindAvailableFlights(originAirportCombo2.Text, destinationAirportCombo2.Text).ToArray());
        }

        private void seatCombo1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void flightCombo2_SelectedIndexChanged(object sender, EventArgs e)
        {
            seatCombo1.Items.AddRange(res.GetAvailableSeatsForFlight(flightCombo2.Text).ToArray());
        }

        private void seatBook_Click(object sender, EventArgs e)
        {
            txtConsole.Clear();
            try
            {
                if (string.IsNullOrEmpty(seatCombo1.Text))
                {
                    throw new Exception(ExceptionHelper.InvalidSeat);
                }
                string[] airlineAndFlight = flightCombo2.Text.Split(' ');

                string[] rowColClass = seatCombo1.Text.Split(' ');

                SeatClass seatClass;
                Enum.TryParse(rowColClass[2].ToString(), out seatClass);

                res.BookSeat(airlineAndFlight[0], airlineAndFlight[1], seatClass, int.Parse(rowColClass[0]), rowColClass[1]);

                seatCombo1.Items.Clear();
                seatCombo1.Text = "";
                seatCombo1.Items.AddRange(res.GetAvailableSeatsForFlight(flightCombo2.Text).ToArray());
                // If there are no more seats clear the combo for the flight
                if (seatCombo1.Items.Count == 0)
                {
                    flightCombo2.Items.Clear();
                    flightCombo2.Text = "";
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void sysDetails_Click(object sender, EventArgs e)
        {
            txtConsole.Clear();
            res.DisplaySystemDetails();
        }
    }
}
