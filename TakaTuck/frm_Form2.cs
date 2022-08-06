
namespace TakaTuck
{

    internal class Order_Form : Form2
    {
        const double price_pizza1 = 750;
        const double price_pizza2 = 850;
        const double price_pizza3 = 550;
        const double price_pizza4 = 650;
        const double price_pizza5 = 800;
        const double price_shaw1 = 200;
        const double price_shaw2 = 250;
        const double price_shaw3 = 100;
        const double price_shaw4 = 120;
        const double price_shaw5 = 170;
        const double price_burger1 = 300;
        const double price_burger2 = 350;
        const double price_burger4 = 450;
        const double price_burger5 = 480;

        private Label label2;
        private Label label1;
        private Label label3;
        private CheckBox chk_pizza5;
        private CheckBox chk_pizza4;
        private CheckBox chk_pizza3;
        private CheckBox chk_pizza2;
        private CheckBox chk_shaw5;
        private CheckBox chk_burger1;
        private CheckBox chk_shaw4;
        private CheckBox chk_shaw3;
        const double price_burger3 = 400;
        private CheckBox chk_shaw2;
        private CheckBox chk_shaw1;
        private CheckBox chk_burger3;
        private CheckBox chk_burger2;
        private CheckBox chk_burger5;
        private CheckBox chk_burger4;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label txt_payment;
        private Label label8;
        private Label txt_total;
        private Label label10;
        private Label txt_change;
        private TextBox txt_name;
        private Button button3;
        private Button button4;
        private TextBox txt_number;
        private TextBox txt_address;
        private Label label12;
        private TextBox txt_shaw1;
        private TextBox txt_shaw2;
        private TextBox txt_shaw3;
        private TextBox txt_shaw4;
        private TextBox txt_shaw5;
        private TextBox txt_pizza5;
        private TextBox txt_pizza4;
        private TextBox txt_pizza3;
        private TextBox txt_pizza2;
        private TextBox txt_pizza1;
        private Label label13;
        private TextBox txt_brgr5;
        private TextBox txt_brgr4;
        private TextBox txt_brgr3;
        private TextBox txt_brgr2;
        private TextBox txt_brgr1;
        private Label label14;
        private ComboBox cmb_payment;
        private CheckBox chk_pizza1;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Order_Form));
            this.label2 = new System.Windows.Forms.Label();
            this.chk_pizza1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chk_pizza5 = new System.Windows.Forms.CheckBox();
            this.chk_pizza4 = new System.Windows.Forms.CheckBox();
            this.chk_pizza3 = new System.Windows.Forms.CheckBox();
            this.chk_pizza2 = new System.Windows.Forms.CheckBox();
            this.chk_shaw5 = new System.Windows.Forms.CheckBox();
            this.chk_burger1 = new System.Windows.Forms.CheckBox();
            this.chk_shaw4 = new System.Windows.Forms.CheckBox();
            this.chk_shaw3 = new System.Windows.Forms.CheckBox();
            this.chk_shaw2 = new System.Windows.Forms.CheckBox();
            this.chk_shaw1 = new System.Windows.Forms.CheckBox();
            this.chk_burger3 = new System.Windows.Forms.CheckBox();
            this.chk_burger2 = new System.Windows.Forms.CheckBox();
            this.chk_burger5 = new System.Windows.Forms.CheckBox();
            this.chk_burger4 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_payment = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_total = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_change = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.txt_number = new System.Windows.Forms.TextBox();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_shaw1 = new System.Windows.Forms.TextBox();
            this.txt_shaw2 = new System.Windows.Forms.TextBox();
            this.txt_shaw3 = new System.Windows.Forms.TextBox();
            this.txt_shaw4 = new System.Windows.Forms.TextBox();
            this.txt_shaw5 = new System.Windows.Forms.TextBox();
            this.txt_pizza5 = new System.Windows.Forms.TextBox();
            this.txt_pizza4 = new System.Windows.Forms.TextBox();
            this.txt_pizza3 = new System.Windows.Forms.TextBox();
            this.txt_pizza2 = new System.Windows.Forms.TextBox();
            this.txt_pizza1 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_brgr5 = new System.Windows.Forms.TextBox();
            this.txt_brgr4 = new System.Windows.Forms.TextBox();
            this.txt_brgr3 = new System.Windows.Forms.TextBox();
            this.txt_brgr2 = new System.Windows.Forms.TextBox();
            this.txt_brgr1 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cmb_payment = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Sitka Banner", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(55, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pizza";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // chk_pizza1
            // 
            this.chk_pizza1.AutoSize = true;
            this.chk_pizza1.BackColor = System.Drawing.Color.Transparent;
            this.chk_pizza1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chk_pizza1.ForeColor = System.Drawing.Color.Black;
            this.chk_pizza1.Location = new System.Drawing.Point(7, 63);
            this.chk_pizza1.Name = "chk_pizza1";
            this.chk_pizza1.Size = new System.Drawing.Size(147, 20);
            this.chk_pizza1.TabIndex = 2;
            this.chk_pizza1.Text = "Neapolitan Pizza.";
            this.chk_pizza1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.chk_pizza1.UseVisualStyleBackColor = false;
            this.chk_pizza1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Sitka Banner", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(400, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Burger";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Sitka Banner", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(205, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "Shawarma";
            // 
            // chk_pizza5
            // 
            this.chk_pizza5.AutoSize = true;
            this.chk_pizza5.BackColor = System.Drawing.Color.Transparent;
            this.chk_pizza5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chk_pizza5.Location = new System.Drawing.Point(9, 183);
            this.chk_pizza5.Name = "chk_pizza5";
            this.chk_pizza5.Size = new System.Drawing.Size(133, 20);
            this.chk_pizza5.TabIndex = 5;
            this.chk_pizza5.Text = "California Pizza";
            this.chk_pizza5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.chk_pizza5.UseVisualStyleBackColor = false;
            this.chk_pizza5.CheckedChanged += new System.EventHandler(this.chk_pizza5_CheckedChanged);
            // 
            // chk_pizza4
            // 
            this.chk_pizza4.AutoSize = true;
            this.chk_pizza4.BackColor = System.Drawing.Color.Transparent;
            this.chk_pizza4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chk_pizza4.ForeColor = System.Drawing.Color.Black;
            this.chk_pizza4.Location = new System.Drawing.Point(7, 153);
            this.chk_pizza4.Name = "chk_pizza4";
            this.chk_pizza4.Size = new System.Drawing.Size(113, 20);
            this.chk_pizza4.TabIndex = 6;
            this.chk_pizza4.Text = "Greek Pizza.";
            this.chk_pizza4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.chk_pizza4.UseVisualStyleBackColor = false;
            this.chk_pizza4.CheckedChanged += new System.EventHandler(this.chk_pizza4_CheckedChanged);
            // 
            // chk_pizza3
            // 
            this.chk_pizza3.AutoSize = true;
            this.chk_pizza3.BackColor = System.Drawing.Color.Transparent;
            this.chk_pizza3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chk_pizza3.ForeColor = System.Drawing.Color.Black;
            this.chk_pizza3.Location = new System.Drawing.Point(7, 123);
            this.chk_pizza3.Name = "chk_pizza3";
            this.chk_pizza3.Size = new System.Drawing.Size(122, 20);
            this.chk_pizza3.TabIndex = 7;
            this.chk_pizza3.Text = "Sicilian Pizza.";
            this.chk_pizza3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.chk_pizza3.UseVisualStyleBackColor = false;
            this.chk_pizza3.CheckedChanged += new System.EventHandler(this.chk_pizza3_CheckedChanged);
            // 
            // chk_pizza2
            // 
            this.chk_pizza2.AutoSize = true;
            this.chk_pizza2.BackColor = System.Drawing.Color.Transparent;
            this.chk_pizza2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chk_pizza2.ForeColor = System.Drawing.Color.Black;
            this.chk_pizza2.Location = new System.Drawing.Point(7, 93);
            this.chk_pizza2.Name = "chk_pizza2";
            this.chk_pizza2.Size = new System.Drawing.Size(128, 20);
            this.chk_pizza2.TabIndex = 8;
            this.chk_pizza2.Text = "Chicago Pizza.";
            this.chk_pizza2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.chk_pizza2.UseVisualStyleBackColor = false;
            this.chk_pizza2.CheckedChanged += new System.EventHandler(this.chk_pizza2_CheckedChanged);
            // 
            // chk_shaw5
            // 
            this.chk_shaw5.AutoSize = true;
            this.chk_shaw5.BackColor = System.Drawing.Color.Transparent;
            this.chk_shaw5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chk_shaw5.Location = new System.Drawing.Point(186, 181);
            this.chk_shaw5.Name = "chk_shaw5";
            this.chk_shaw5.Size = new System.Drawing.Size(152, 20);
            this.chk_shaw5.TabIndex = 9;
            this.chk_shaw5.Text = "HomeMade Shaw-";
            this.chk_shaw5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.chk_shaw5.UseVisualStyleBackColor = false;
            this.chk_shaw5.CheckedChanged += new System.EventHandler(this.chk_shaw5_CheckedChanged);
            // 
            // chk_burger1
            // 
            this.chk_burger1.AutoSize = true;
            this.chk_burger1.BackColor = System.Drawing.Color.Transparent;
            this.chk_burger1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chk_burger1.Location = new System.Drawing.Point(381, 67);
            this.chk_burger1.Name = "chk_burger1";
            this.chk_burger1.Size = new System.Drawing.Size(113, 20);
            this.chk_burger1.TabIndex = 10;
            this.chk_burger1.Text = "Lentil Burger";
            this.chk_burger1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.chk_burger1.UseVisualStyleBackColor = false;
            this.chk_burger1.CheckedChanged += new System.EventHandler(this.chk_burger1_CheckedChanged);
            // 
            // chk_shaw4
            // 
            this.chk_shaw4.AutoSize = true;
            this.chk_shaw4.BackColor = System.Drawing.Color.Transparent;
            this.chk_shaw4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chk_shaw4.Location = new System.Drawing.Point(187, 151);
            this.chk_shaw4.Name = "chk_shaw4";
            this.chk_shaw4.Size = new System.Drawing.Size(125, 20);
            this.chk_shaw4.TabIndex = 11;
            this.chk_shaw4.Text = "Oven Roasted";
            this.chk_shaw4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.chk_shaw4.UseVisualStyleBackColor = false;
            this.chk_shaw4.CheckedChanged += new System.EventHandler(this.chk_shaw4_CheckedChanged);
            // 
            // chk_shaw3
            // 
            this.chk_shaw3.AutoSize = true;
            this.chk_shaw3.BackColor = System.Drawing.Color.Transparent;
            this.chk_shaw3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chk_shaw3.Location = new System.Drawing.Point(187, 121);
            this.chk_shaw3.Name = "chk_shaw3";
            this.chk_shaw3.Size = new System.Drawing.Size(139, 20);
            this.chk_shaw3.TabIndex = 12;
            this.chk_shaw3.Text = "Keto Beef Shaw-";
            this.chk_shaw3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.chk_shaw3.UseVisualStyleBackColor = false;
            this.chk_shaw3.CheckedChanged += new System.EventHandler(this.chk_shaw3_CheckedChanged);
            // 
            // chk_shaw2
            // 
            this.chk_shaw2.AutoSize = true;
            this.chk_shaw2.BackColor = System.Drawing.Color.Transparent;
            this.chk_shaw2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chk_shaw2.Location = new System.Drawing.Point(186, 91);
            this.chk_shaw2.Name = "chk_shaw2";
            this.chk_shaw2.Size = new System.Drawing.Size(143, 20);
            this.chk_shaw2.TabIndex = 13;
            this.chk_shaw2.Text = "Mushroom Shaw-";
            this.chk_shaw2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.chk_shaw2.UseVisualStyleBackColor = false;
            this.chk_shaw2.CheckedChanged += new System.EventHandler(this.chk_shaw2_CheckedChanged);
            // 
            // chk_shaw1
            // 
            this.chk_shaw1.AutoSize = true;
            this.chk_shaw1.BackColor = System.Drawing.Color.Transparent;
            this.chk_shaw1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chk_shaw1.Location = new System.Drawing.Point(187, 61);
            this.chk_shaw1.Name = "chk_shaw1";
            this.chk_shaw1.Size = new System.Drawing.Size(127, 20);
            this.chk_shaw1.TabIndex = 14;
            this.chk_shaw1.Text = "Chicken Shaw-";
            this.chk_shaw1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.chk_shaw1.UseVisualStyleBackColor = false;
            this.chk_shaw1.CheckedChanged += new System.EventHandler(this.chk_shaw1_CheckedChanged);
            // 
            // chk_burger3
            // 
            this.chk_burger3.AutoSize = true;
            this.chk_burger3.BackColor = System.Drawing.Color.Transparent;
            this.chk_burger3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chk_burger3.Location = new System.Drawing.Point(381, 123);
            this.chk_burger3.Name = "chk_burger3";
            this.chk_burger3.Size = new System.Drawing.Size(107, 20);
            this.chk_burger3.TabIndex = 15;
            this.chk_burger3.Text = "Potato Corn";
            this.chk_burger3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.chk_burger3.UseVisualStyleBackColor = false;
            this.chk_burger3.CheckedChanged += new System.EventHandler(this.chk_burger3_CheckedChanged);
            // 
            // chk_burger2
            // 
            this.chk_burger2.AutoSize = true;
            this.chk_burger2.BackColor = System.Drawing.Color.Transparent;
            this.chk_burger2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chk_burger2.Location = new System.Drawing.Point(382, 93);
            this.chk_burger2.Name = "chk_burger2";
            this.chk_burger2.Size = new System.Drawing.Size(114, 20);
            this.chk_burger2.TabIndex = 16;
            this.chk_burger2.Text = "Lamb Burger";
            this.chk_burger2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.chk_burger2.UseVisualStyleBackColor = false;
            this.chk_burger2.CheckedChanged += new System.EventHandler(this.chk_burger2_CheckedChanged);
            // 
            // chk_burger5
            // 
            this.chk_burger5.AutoSize = true;
            this.chk_burger5.BackColor = System.Drawing.Color.Transparent;
            this.chk_burger5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chk_burger5.Location = new System.Drawing.Point(382, 183);
            this.chk_burger5.Name = "chk_burger5";
            this.chk_burger5.Size = new System.Drawing.Size(113, 20);
            this.chk_burger5.TabIndex = 17;
            this.chk_burger5.Text = "Pizza Burger";
            this.chk_burger5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.chk_burger5.UseVisualStyleBackColor = false;
            this.chk_burger5.CheckedChanged += new System.EventHandler(this.chk_burger5_CheckedChanged);
            // 
            // chk_burger4
            // 
            this.chk_burger4.AutoSize = true;
            this.chk_burger4.BackColor = System.Drawing.Color.Transparent;
            this.chk_burger4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chk_burger4.Location = new System.Drawing.Point(381, 153);
            this.chk_burger4.Name = "chk_burger4";
            this.chk_burger4.Size = new System.Drawing.Size(125, 20);
            this.chk_burger4.TabIndex = 18;
            this.chk_burger4.Text = "Butter Chicken";
            this.chk_burger4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.chk_burger4.UseVisualStyleBackColor = false;
            this.chk_burger4.CheckedChanged += new System.EventHandler(this.chk_burger4_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Sitka Banner", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(12, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 28);
            this.label4.TabIndex = 19;
            this.label4.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Sitka Banner", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(12, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 28);
            this.label5.TabIndex = 20;
            this.label5.Text = "Ph.No";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Sitka Banner", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label6.Location = new System.Drawing.Point(12, 319);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 28);
            this.label6.TabIndex = 21;
            this.label6.Text = "Address";
            // 
            // txt_payment
            // 
            this.txt_payment.AutoSize = true;
            this.txt_payment.BackColor = System.Drawing.Color.Transparent;
            this.txt_payment.Font = new System.Drawing.Font("Sitka Banner", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_payment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txt_payment.Location = new System.Drawing.Point(375, 211);
            this.txt_payment.Name = "txt_payment";
            this.txt_payment.Size = new System.Drawing.Size(141, 28);
            this.txt_payment.TabIndex = 22;
            this.txt_payment.Text = "Payment method";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Sitka Banner", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label8.Location = new System.Drawing.Point(340, 268);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 28);
            this.label8.TabIndex = 23;
            this.label8.Text = "Total";
            // 
            // txt_total
            // 
            this.txt_total.AutoSize = true;
            this.txt_total.BackColor = System.Drawing.Color.Transparent;
            this.txt_total.Font = new System.Drawing.Font("Sitka Banner", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_total.ForeColor = System.Drawing.Color.Black;
            this.txt_total.Location = new System.Drawing.Point(472, 268);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(52, 28);
            this.txt_total.TabIndex = 24;
            this.txt_total.Text = "Pizza";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Sitka Banner", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label10.Location = new System.Drawing.Point(340, 296);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 28);
            this.label10.TabIndex = 25;
            this.label10.Text = "Change";
            // 
            // txt_change
            // 
            this.txt_change.AutoSize = true;
            this.txt_change.BackColor = System.Drawing.Color.Transparent;
            this.txt_change.Font = new System.Drawing.Font("Sitka Banner", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_change.ForeColor = System.Drawing.Color.Black;
            this.txt_change.Location = new System.Drawing.Point(472, 296);
            this.txt_change.Name = "txt_change";
            this.txt_change.Size = new System.Drawing.Size(52, 28);
            this.txt_change.TabIndex = 26;
            this.txt_change.Text = "Pizza";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(113, 268);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(100, 23);
            this.txt_name.TabIndex = 28;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(205, 386);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 31);
            this.button3.TabIndex = 30;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(374, 386);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(92, 31);
            this.button4.TabIndex = 31;
            this.button4.Text = "Total\r\n";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txt_number
            // 
            this.txt_number.Location = new System.Drawing.Point(113, 297);
            this.txt_number.Name = "txt_number";
            this.txt_number.Size = new System.Drawing.Size(100, 23);
            this.txt_number.TabIndex = 32;
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(113, 326);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(100, 23);
            this.txt_address.TabIndex = 33;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Sitka Banner", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(340, 30);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 28);
            this.label12.TabIndex = 34;
            this.label12.Text = "Qty";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // txt_shaw1
            // 
            this.txt_shaw1.ForeColor = System.Drawing.Color.Blue;
            this.txt_shaw1.Location = new System.Drawing.Point(340, 61);
            this.txt_shaw1.Name = "txt_shaw1";
            this.txt_shaw1.Size = new System.Drawing.Size(30, 23);
            this.txt_shaw1.TabIndex = 35;
            // 
            // txt_shaw2
            // 
            this.txt_shaw2.ForeColor = System.Drawing.Color.Blue;
            this.txt_shaw2.Location = new System.Drawing.Point(340, 91);
            this.txt_shaw2.Name = "txt_shaw2";
            this.txt_shaw2.Size = new System.Drawing.Size(30, 23);
            this.txt_shaw2.TabIndex = 36;
            // 
            // txt_shaw3
            // 
            this.txt_shaw3.ForeColor = System.Drawing.Color.Blue;
            this.txt_shaw3.Location = new System.Drawing.Point(340, 120);
            this.txt_shaw3.Name = "txt_shaw3";
            this.txt_shaw3.Size = new System.Drawing.Size(30, 23);
            this.txt_shaw3.TabIndex = 37;
            // 
            // txt_shaw4
            // 
            this.txt_shaw4.ForeColor = System.Drawing.Color.Blue;
            this.txt_shaw4.Location = new System.Drawing.Point(340, 149);
            this.txt_shaw4.Name = "txt_shaw4";
            this.txt_shaw4.Size = new System.Drawing.Size(30, 23);
            this.txt_shaw4.TabIndex = 38;
            // 
            // txt_shaw5
            // 
            this.txt_shaw5.ForeColor = System.Drawing.Color.Blue;
            this.txt_shaw5.Location = new System.Drawing.Point(340, 178);
            this.txt_shaw5.Name = "txt_shaw5";
            this.txt_shaw5.Size = new System.Drawing.Size(30, 23);
            this.txt_shaw5.TabIndex = 39;
            // 
            // txt_pizza5
            // 
            this.txt_pizza5.ForeColor = System.Drawing.Color.Blue;
            this.txt_pizza5.Location = new System.Drawing.Point(150, 180);
            this.txt_pizza5.Name = "txt_pizza5";
            this.txt_pizza5.Size = new System.Drawing.Size(30, 23);
            this.txt_pizza5.TabIndex = 45;
            // 
            // txt_pizza4
            // 
            this.txt_pizza4.ForeColor = System.Drawing.Color.Blue;
            this.txt_pizza4.Location = new System.Drawing.Point(150, 151);
            this.txt_pizza4.Name = "txt_pizza4";
            this.txt_pizza4.Size = new System.Drawing.Size(30, 23);
            this.txt_pizza4.TabIndex = 44;
            // 
            // txt_pizza3
            // 
            this.txt_pizza3.ForeColor = System.Drawing.Color.Blue;
            this.txt_pizza3.Location = new System.Drawing.Point(150, 122);
            this.txt_pizza3.Name = "txt_pizza3";
            this.txt_pizza3.Size = new System.Drawing.Size(30, 23);
            this.txt_pizza3.TabIndex = 43;
            // 
            // txt_pizza2
            // 
            this.txt_pizza2.ForeColor = System.Drawing.Color.Blue;
            this.txt_pizza2.Location = new System.Drawing.Point(150, 93);
            this.txt_pizza2.Name = "txt_pizza2";
            this.txt_pizza2.Size = new System.Drawing.Size(30, 23);
            this.txt_pizza2.TabIndex = 42;
            // 
            // txt_pizza1
            // 
            this.txt_pizza1.ForeColor = System.Drawing.Color.Blue;
            this.txt_pizza1.Location = new System.Drawing.Point(150, 63);
            this.txt_pizza1.Name = "txt_pizza1";
            this.txt_pizza1.Size = new System.Drawing.Size(30, 23);
            this.txt_pizza1.TabIndex = 41;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Sitka Banner", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(150, 32);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 28);
            this.label13.TabIndex = 40;
            this.label13.Text = "Qty";
            // 
            // txt_brgr5
            // 
            this.txt_brgr5.ForeColor = System.Drawing.Color.Blue;
            this.txt_brgr5.Location = new System.Drawing.Point(504, 178);
            this.txt_brgr5.Name = "txt_brgr5";
            this.txt_brgr5.Size = new System.Drawing.Size(30, 23);
            this.txt_brgr5.TabIndex = 51;
            // 
            // txt_brgr4
            // 
            this.txt_brgr4.ForeColor = System.Drawing.Color.Blue;
            this.txt_brgr4.Location = new System.Drawing.Point(504, 149);
            this.txt_brgr4.Name = "txt_brgr4";
            this.txt_brgr4.Size = new System.Drawing.Size(30, 23);
            this.txt_brgr4.TabIndex = 50;
            this.txt_brgr4.TextChanged += new System.EventHandler(this.textBox15_TextChanged);
            // 
            // txt_brgr3
            // 
            this.txt_brgr3.ForeColor = System.Drawing.Color.Blue;
            this.txt_brgr3.Location = new System.Drawing.Point(504, 120);
            this.txt_brgr3.Name = "txt_brgr3";
            this.txt_brgr3.Size = new System.Drawing.Size(30, 23);
            this.txt_brgr3.TabIndex = 49;
            // 
            // txt_brgr2
            // 
            this.txt_brgr2.ForeColor = System.Drawing.Color.Blue;
            this.txt_brgr2.Location = new System.Drawing.Point(504, 91);
            this.txt_brgr2.Name = "txt_brgr2";
            this.txt_brgr2.Size = new System.Drawing.Size(30, 23);
            this.txt_brgr2.TabIndex = 48;
            // 
            // txt_brgr1
            // 
            this.txt_brgr1.ForeColor = System.Drawing.Color.Blue;
            this.txt_brgr1.Location = new System.Drawing.Point(504, 61);
            this.txt_brgr1.Name = "txt_brgr1";
            this.txt_brgr1.Size = new System.Drawing.Size(30, 23);
            this.txt_brgr1.TabIndex = 47;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Sitka Banner", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(504, 30);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(39, 28);
            this.label14.TabIndex = 46;
            this.label14.Text = "Qty";
            // 
            // cmb_payment
            // 
            this.cmb_payment.FormattingEnabled = true;
            this.cmb_payment.Location = new System.Drawing.Point(385, 242);
            this.cmb_payment.Name = "cmb_payment";
            this.cmb_payment.Size = new System.Drawing.Size(121, 23);
            this.cmb_payment.TabIndex = 52;
            this.cmb_payment.SelectedIndexChanged += new System.EventHandler(this.cmb_payment_SelectedIndexChanged);
            // 
            // Order_form
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(602, 434);
            this.Controls.Add(this.cmb_payment);
            this.Controls.Add(this.txt_brgr5);
            this.Controls.Add(this.txt_brgr4);
            this.Controls.Add(this.txt_brgr3);
            this.Controls.Add(this.txt_brgr2);
            this.Controls.Add(this.txt_brgr1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txt_pizza5);
            this.Controls.Add(this.txt_pizza4);
            this.Controls.Add(this.txt_pizza3);
            this.Controls.Add(this.txt_pizza2);
            this.Controls.Add(this.txt_pizza1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txt_shaw5);
            this.Controls.Add(this.txt_shaw4);
            this.Controls.Add(this.txt_shaw3);
            this.Controls.Add(this.txt_shaw2);
            this.Controls.Add(this.txt_shaw1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.txt_number);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.txt_change);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_total);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_payment);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chk_burger4);
            this.Controls.Add(this.chk_burger5);
            this.Controls.Add(this.chk_burger2);
            this.Controls.Add(this.chk_burger3);
            this.Controls.Add(this.chk_shaw1);
            this.Controls.Add(this.chk_shaw2);
            this.Controls.Add(this.chk_shaw3);
            this.Controls.Add(this.chk_shaw4);
            this.Controls.Add(this.chk_burger1);
            this.Controls.Add(this.chk_shaw5);
            this.Controls.Add(this.chk_pizza2);
            this.Controls.Add(this.chk_pizza3);
            this.Controls.Add(this.chk_pizza4);
            this.Controls.Add(this.chk_pizza5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chk_pizza1);
            this.Controls.Add(this.label2);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Order_form";
            this.Text = "Order Now";
            this.Load += new System.EventHandler(this.frm_Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {
                 }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_pizza1.Checked == true)
            {
                txt_pizza1.Enabled = true;
                txt_pizza1.Text = "";
                txt_pizza1.Focus();
            }
            else
            {
                txt_pizza1.Enabled = false;
                txt_pizza1.Text = "0";
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void frm_Form2_Load(object sender, EventArgs e)
        {
            cmb_payment.Items.Add(" ");
            cmb_payment.Items.Add(" Cash On Delivery ");
            cmb_payment.Items.Add(" Cash ");
            EnableTextBoxes();

        }
        private void EnableTextBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Enabled = false;
                    else
                        func(control.Controls);
            };
            func(Controls);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult iexit;
            iexit = MessageBox.Show("Confirm you want to exit the system.", "Ordering system", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (iexit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void chk_pizza2_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_pizza2.Checked == true)
            {
                txt_pizza2.Enabled = true;
                txt_pizza2.Text = "";
                txt_pizza2.Focus();
            }
            else
            {
                txt_pizza2.Enabled = false;
                txt_pizza2.Text = "0";
            }
        }

        private void chk_pizza3_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_pizza3.Checked == true)
            {
                txt_pizza3.Enabled = true;
                txt_pizza3.Text = "";
                txt_pizza3.Focus();
            }
            else
            {
                txt_pizza3.Enabled = false;
                txt_pizza3.Text = "0";
            }
        }

        private void chk_pizza4_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_pizza4.Checked == true)
            {
                txt_pizza4.Enabled = true;
                txt_pizza4.Text = "";
                txt_pizza4.Focus();
            }
            else
            {
                txt_pizza4.Enabled = false;
                txt_pizza4.Text = "0";
            }
        }

        private void chk_pizza5_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_pizza5.Checked == true)
            {
                txt_pizza5.Enabled = true;
                txt_pizza5.Text = "";
                txt_pizza5.Focus();
            }
            else
            {
                txt_pizza5.Enabled = false;
                txt_pizza5.Text = "0";
            }
        }

        private void chk_shaw1_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_shaw1.Checked == true)
            {
                txt_shaw1.Enabled = true;
                txt_shaw1.Text = "";
                txt_shaw1.Focus();
            }
            else
            {
                txt_shaw1.Enabled = false;
                txt_shaw1.Text = "0";
            }
        }

        private void chk_shaw3_CheckedChanged(object sender, EventArgs e)
        {

            if (chk_shaw3.Checked == true)
            {
                txt_shaw3.Enabled = true;
                txt_shaw3.Text = "";
                txt_shaw3.Focus();
            }
            else
            {
                txt_shaw3.Enabled = false;
                txt_shaw3.Text = "0";
            }
        }

        private void chk_shaw4_CheckedChanged(object sender, EventArgs e)
        {

            if (chk_shaw4.Checked == true)
            {
                txt_shaw4.Enabled = true;
                txt_shaw4.Text = "";
                txt_shaw4.Focus();
            }
            else
            {
                txt_shaw4.Enabled = false;
                txt_shaw4.Text = "0";
            }
        }

        private void chk_shaw2_CheckedChanged(object sender, EventArgs e)
        {

            if (chk_shaw2.Checked == true)
            {
                txt_shaw2.Enabled = true;
                txt_shaw2.Text = "";
                txt_shaw2.Focus();
            }
            else
            {
                txt_shaw2.Enabled = false;
                txt_shaw2.Text = "0";
            }
        }

        private void chk_shaw5_CheckedChanged(object sender, EventArgs e)
        {

            if (chk_shaw5.Checked == true)
            {
                txt_shaw5.Enabled = true;
                txt_shaw5.Text = "";
                txt_shaw5.Focus();
            }
            else
            {
                txt_shaw5.Enabled = false;
                txt_shaw5.Text = "0";
            }
        }

        private void chk_burger1_CheckedChanged(object sender, EventArgs e)
        {

            if (chk_burger1.Checked == true)
            {
                txt_brgr1.Enabled = true;
                txt_brgr1.Text = "";
                txt_brgr1.Focus();
            }
            else
            {
                txt_brgr1.Enabled = false;
                txt_brgr1.Text = "0";
            }
        }

        private void chk_burger2_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_burger2.Checked == true)
            {
                txt_brgr2.Enabled = true;
                txt_brgr2.Text = "";
                txt_brgr2.Focus();
            }
            else
            {
                txt_brgr2.Enabled = false;
                txt_brgr2.Text = "0";
            }
        }

        private void chk_burger3_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_burger3.Checked == true)
            {
                txt_brgr3.Enabled = true;
                txt_brgr3.Text = "";
                txt_brgr3.Focus();
            }
            else
            {
                txt_brgr3.Enabled = false;
                txt_brgr3.Text = "0";
            }
        }

        private void chk_burger4_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_burger4.Checked == true)
            {
                txt_brgr4.Enabled = true;
                txt_brgr4.Text = "";
                txt_brgr4.Focus();
            }
            else
            {
                txt_brgr4.Enabled = false;
                txt_brgr4.Text = "0";
            }
        }

        private void chk_burger5_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_burger5.Checked == true)
            {
                txt_brgr5.Enabled = true;
                txt_brgr5.Text = "";
                txt_brgr5.Focus();
            }
            else
            {
                txt_brgr5.Enabled = false;
                txt_brgr5.Text = "0";
            }
        }

        private void cmb_payment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_payment.Text == "Cash")
            {
                txt_payment.Enabled = true;
                txt_payment.Text = "";
                txt_payment.Focus();
            }
            else if (cmb_payment.Text == "Cash On Delivery")
            {
                txt_name.Enabled = true;
                txt_address.Enabled = true;
                txt_number.Enabled = true;
                txt_name.Text = "";
                txt_number.Text = "";
                txt_address.Text = "";
                txt_name.Focus();
                txt_address.Focus();
                txt_number.Focus();

            }
            else
            {
                txt_payment.Enabled = false;
                txt_payment.Text = "0";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double[] itemcost = new double[100];
            itemcost[0] = Convert.ToDouble(txt_pizza1.Text) * price_pizza1;
            itemcost[1] = Convert.ToDouble(txt_pizza2.Text) * price_pizza2;
            itemcost[2] = Convert.ToDouble(txt_pizza3.Text) * price_pizza3;
            itemcost[3] = Convert.ToDouble(txt_pizza4.Text) * price_pizza4;
            itemcost[4] = Convert.ToDouble(txt_pizza5.Text) * price_pizza5;
            itemcost[5] = Convert.ToDouble(txt_brgr1.Text) * price_burger1;
            itemcost[6] = Convert.ToDouble(txt_brgr2.Text) * price_burger2;
            itemcost[7] = Convert.ToDouble(txt_brgr3.Text) * price_burger3;
            itemcost[8] = Convert.ToDouble(txt_brgr4.Text) * price_burger4;
            itemcost[9] = Convert.ToDouble(txt_brgr5.Text) * price_burger5;
            itemcost[10] = Convert.ToDouble(txt_shaw1.Text) * price_shaw1;
            itemcost[11] = Convert.ToDouble(txt_shaw2.Text) * price_shaw2;
            itemcost[12] = Convert.ToDouble(txt_shaw3.Text) * price_shaw3;
            itemcost[13] = Convert.ToDouble(txt_shaw4.Text) * price_shaw4;
            itemcost[14] = Convert.ToDouble(txt_shaw5.Text) * price_shaw5;
            double payment, cost, total;
            if (cmb_payment.Text == "Cash")
            {
               
                total = itemcost[0] + itemcost[1] + itemcost[2] + itemcost[3] + itemcost[4] + itemcost[5] + itemcost[6] + itemcost[7] + itemcost[8] + itemcost[9] + itemcost[10] + itemcost[11] + itemcost[12] + itemcost[13] + itemcost[14];
            txt_total.Text = Convert.ToString(total);
                payment = Convert.ToInt32(txt_payment.Text);
                cost = payment - total;
                txt_change.Text = Convert.ToString(cost);
            }
            else
            {
                total = itemcost[0] + itemcost[1] + itemcost[2] + itemcost[3] + itemcost[4] + itemcost[5] + itemcost[6] + itemcost[7] + itemcost[8] + itemcost[9] + itemcost[10] + itemcost[11] + itemcost[12] + itemcost[13] + itemcost[14];
                txt_total.Text = Convert.ToString(total);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}