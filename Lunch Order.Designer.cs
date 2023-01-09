namespace WindowsFormsApp1
{
    partial class Form1
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
            this.Hamburger = new System.Windows.Forms.RadioButton();
            this.Pizza = new System.Windows.Forms.RadioButton();
            this.SaladButton = new System.Windows.Forms.RadioButton();
            this.HamburgerBox = new System.Windows.Forms.GroupBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.PizzaBox = new System.Windows.Forms.GroupBox();
            this.SaladBox = new System.Windows.Forms.GroupBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.MainCourseBox = new System.Windows.Forms.GroupBox();
            this.Order = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.subT = new System.Windows.Forms.TextBox();
            this.tax = new System.Windows.Forms.TextBox();
            this.cost = new System.Windows.Forms.TextBox();
            this.MoneyBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.HamburgerBox.SuspendLayout();
            this.PizzaBox.SuspendLayout();
            this.SaladBox.SuspendLayout();
            this.MainCourseBox.SuspendLayout();
            this.MoneyBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Hamburger
            // 
            this.Hamburger.AutoSize = true;
            this.Hamburger.Location = new System.Drawing.Point(6, 21);
            this.Hamburger.Name = "Hamburger";
            this.Hamburger.Size = new System.Drawing.Size(96, 20);
            this.Hamburger.TabIndex = 0;
            this.Hamburger.TabStop = true;
            this.Hamburger.Text = "Hamburger";
            this.Hamburger.UseVisualStyleBackColor = true;
            this.Hamburger.CheckedChanged += new System.EventHandler(this.Hamburger_CheckedChanged);
            // 
            // Pizza
            // 
            this.Pizza.AutoSize = true;
            this.Pizza.Location = new System.Drawing.Point(6, 48);
            this.Pizza.Name = "Pizza";
            this.Pizza.Size = new System.Drawing.Size(60, 20);
            this.Pizza.TabIndex = 1;
            this.Pizza.TabStop = true;
            this.Pizza.Text = "Pizza";
            this.Pizza.UseVisualStyleBackColor = true;
            this.Pizza.CheckedChanged += new System.EventHandler(this.Pizza_CheckedChanged);
            // 
            // SaladButton
            // 
            this.SaladButton.AutoSize = true;
            this.SaladButton.Location = new System.Drawing.Point(6, 73);
            this.SaladButton.Name = "SaladButton";
            this.SaladButton.Size = new System.Drawing.Size(64, 20);
            this.SaladButton.TabIndex = 2;
            this.SaladButton.TabStop = true;
            this.SaladButton.Text = "Salad";
            this.SaladButton.UseVisualStyleBackColor = true;
            this.SaladButton.CheckedChanged += new System.EventHandler(this.SaladButton_CheckedChanged);
            // 
            // HamburgerBox
            // 
            this.HamburgerBox.Controls.Add(this.checkBox3);
            this.HamburgerBox.Controls.Add(this.PizzaBox);
            this.HamburgerBox.Controls.Add(this.checkBox2);
            this.HamburgerBox.Controls.Add(this.checkBox1);
            this.HamburgerBox.Location = new System.Drawing.Point(552, 62);
            this.HamburgerBox.Name = "HamburgerBox";
            this.HamburgerBox.Size = new System.Drawing.Size(200, 140);
            this.HamburgerBox.TabIndex = 3;
            this.HamburgerBox.TabStop = false;
            this.HamburgerBox.Text = "Add-On Items:";
            this.HamburgerBox.Visible = false;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(7, 83);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(103, 20);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "French Fries";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // PizzaBox
            // 
            this.PizzaBox.Controls.Add(this.SaladBox);
            this.PizzaBox.Controls.Add(this.checkBox4);
            this.PizzaBox.Controls.Add(this.checkBox5);
            this.PizzaBox.Controls.Add(this.checkBox6);
            this.PizzaBox.Location = new System.Drawing.Point(0, 0);
            this.PizzaBox.Name = "PizzaBox";
            this.PizzaBox.Size = new System.Drawing.Size(200, 140);
            this.PizzaBox.TabIndex = 4;
            this.PizzaBox.TabStop = false;
            this.PizzaBox.Text = "Add-On Items:";
            this.PizzaBox.Visible = false;
            this.PizzaBox.Enter += new System.EventHandler(this.PizzaBox_Enter);
            // 
            // SaladBox
            // 
            this.SaladBox.Controls.Add(this.checkBox7);
            this.SaladBox.Controls.Add(this.checkBox8);
            this.SaladBox.Controls.Add(this.checkBox9);
            this.SaladBox.Location = new System.Drawing.Point(0, 0);
            this.SaladBox.Name = "SaladBox";
            this.SaladBox.Size = new System.Drawing.Size(200, 140);
            this.SaladBox.TabIndex = 10;
            this.SaladBox.TabStop = false;
            this.SaladBox.Text = "Add-On Items:";
            this.SaladBox.Visible = false;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(7, 83);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(100, 20);
            this.checkBox7.TabIndex = 2;
            this.checkBox7.Text = "Breadsticks";
            this.checkBox7.UseVisualStyleBackColor = true;
            this.checkBox7.CheckedChanged += new System.EventHandler(this.checkBox7_CheckedChanged);
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(7, 55);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(93, 20);
            this.checkBox8.TabIndex = 1;
            this.checkBox8.Text = "Bacon Bits";
            this.checkBox8.UseVisualStyleBackColor = true;
            this.checkBox8.CheckedChanged += new System.EventHandler(this.checkBox8_CheckedChanged);
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Location = new System.Drawing.Point(7, 27);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(82, 20);
            this.checkBox9.TabIndex = 0;
            this.checkBox9.Text = "Croutons";
            this.checkBox9.UseVisualStyleBackColor = true;
            this.checkBox9.CheckedChanged += new System.EventHandler(this.checkBox9_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(7, 83);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(67, 20);
            this.checkBox4.TabIndex = 2;
            this.checkBox4.Text = "Olives";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(7, 55);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(84, 20);
            this.checkBox5.TabIndex = 1;
            this.checkBox5.Text = "Sausage";
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(7, 27);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(92, 20);
            this.checkBox6.TabIndex = 0;
            this.checkBox6.Text = "Pepperoni";
            this.checkBox6.UseVisualStyleBackColor = true;
            this.checkBox6.CheckedChanged += new System.EventHandler(this.checkBox6_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(7, 55);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(174, 20);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Ketchup, Mustard, & Mayo";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(7, 27);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(169, 20);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Lettuce, Tomato, & Onion";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // MainCourseBox
            // 
            this.MainCourseBox.Controls.Add(this.Hamburger);
            this.MainCourseBox.Controls.Add(this.Pizza);
            this.MainCourseBox.Controls.Add(this.SaladButton);
            this.MainCourseBox.Location = new System.Drawing.Point(42, 62);
            this.MainCourseBox.Name = "MainCourseBox";
            this.MainCourseBox.Size = new System.Drawing.Size(200, 129);
            this.MainCourseBox.TabIndex = 3;
            this.MainCourseBox.TabStop = false;
            this.MainCourseBox.Text = "Main Course";
            // 
            // Order
            // 
            this.Order.Location = new System.Drawing.Point(644, 289);
            this.Order.Name = "Order";
            this.Order.Size = new System.Drawing.Size(108, 39);
            this.Order.TabIndex = 4;
            this.Order.Text = "Place Order";
            this.Order.UseVisualStyleBackColor = true;
            this.Order.Click += new System.EventHandler(this.Order_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(644, 381);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // subT
            // 
            this.subT.Enabled = false;
            this.subT.Location = new System.Drawing.Point(151, 34);
            this.subT.Name = "subT";
            this.subT.Size = new System.Drawing.Size(100, 22);
            this.subT.TabIndex = 6;
            // 
            // tax
            // 
            this.tax.Enabled = false;
            this.tax.Location = new System.Drawing.Point(151, 68);
            this.tax.Name = "tax";
            this.tax.Size = new System.Drawing.Size(100, 22);
            this.tax.TabIndex = 7;
            // 
            // cost
            // 
            this.cost.Enabled = false;
            this.cost.Location = new System.Drawing.Point(151, 105);
            this.cost.Name = "cost";
            this.cost.Size = new System.Drawing.Size(100, 22);
            this.cost.TabIndex = 8;
            // 
            // MoneyBox
            // 
            this.MoneyBox.Controls.Add(this.label3);
            this.MoneyBox.Controls.Add(this.label2);
            this.MoneyBox.Controls.Add(this.label1);
            this.MoneyBox.Controls.Add(this.subT);
            this.MoneyBox.Controls.Add(this.cost);
            this.MoneyBox.Controls.Add(this.tax);
            this.MoneyBox.Location = new System.Drawing.Point(48, 238);
            this.MoneyBox.Name = "MoneyBox";
            this.MoneyBox.Size = new System.Drawing.Size(257, 155);
            this.MoneyBox.TabIndex = 9;
            this.MoneyBox.TabStop = false;
            this.MoneyBox.Text = "OrderTotal";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Subtotal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tax";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Order Total";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MoneyBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Order);
            this.Controls.Add(this.MainCourseBox);
            this.Controls.Add(this.HamburgerBox);
            this.Name = "Form1";
            this.Text = "LunchOrder";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.HamburgerBox.ResumeLayout(false);
            this.HamburgerBox.PerformLayout();
            this.PizzaBox.ResumeLayout(false);
            this.PizzaBox.PerformLayout();
            this.SaladBox.ResumeLayout(false);
            this.SaladBox.PerformLayout();
            this.MainCourseBox.ResumeLayout(false);
            this.MainCourseBox.PerformLayout();
            this.MoneyBox.ResumeLayout(false);
            this.MoneyBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton Hamburger;
        private System.Windows.Forms.RadioButton Pizza;
        private System.Windows.Forms.RadioButton SaladButton;
        private System.Windows.Forms.GroupBox HamburgerBox;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox MainCourseBox;
        private System.Windows.Forms.Button Order;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox subT;
        private System.Windows.Forms.TextBox tax;
        private System.Windows.Forms.TextBox cost;
        private System.Windows.Forms.GroupBox MoneyBox;
        private System.Windows.Forms.GroupBox PizzaBox;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.GroupBox SaladBox;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

