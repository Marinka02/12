namespace _12
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.contextMenuStrip1out = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.сбросToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxS = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxV = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.contextMenuStrip1in = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.чтоВводитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сбросToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.contextMenuStrip2out = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxSum = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.contextMenuStrip2in = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.чтоВводитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxChislo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.настройкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.действияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рассчитатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сбросToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.рассчитатьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.сбросToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.textBoxProiz = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.contextMenuStrip1out.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.contextMenuStrip1in.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.contextMenuStrip2out.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.contextMenuStrip2in.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(383, 201);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(375, 168);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Задание 1";
            this.toolTip1.SetToolTip(this.tabPage1, "Даны три точки A, B, C на числовой оси. Найти длины отрезков AC и BC и их сумму.");
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Enter += new System.EventHandler(this.tabPage1_Enter);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 134);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(362, 27);
            this.button2.TabIndex = 4;
            this.button2.Text = "Рассчитать";
            this.toolTip1.SetToolTip(this.button2, "Рассчитать длину отрезов ac, bc и сумму длин этих отрезков");
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.рассчитатьToolStripMenuItem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.ContextMenuStrip = this.contextMenuStrip1out;
            this.groupBox2.Controls.Add(this.textBoxS);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBoxV);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(190, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(178, 122);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Результат";
            // 
            // contextMenuStrip1out
            // 
            this.contextMenuStrip1out.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сбросToolStripMenuItem3});
            this.contextMenuStrip1out.Name = "contextMenuStrip1out";
            this.contextMenuStrip1out.Size = new System.Drawing.Size(110, 26);
            // 
            // сбросToolStripMenuItem3
            // 
            this.сбросToolStripMenuItem3.Name = "сбросToolStripMenuItem3";
            this.сбросToolStripMenuItem3.Size = new System.Drawing.Size(109, 22);
            this.сбросToolStripMenuItem3.Text = "Сброс";
            this.сбросToolStripMenuItem3.Click += new System.EventHandler(this.сбросToolStripMenuItem3_Click);
            // 
            // textBoxS
            // 
            this.textBoxS.Location = new System.Drawing.Point(98, 57);
            this.textBoxS.Name = "textBoxS";
            this.textBoxS.ReadOnly = true;
            this.textBoxS.Size = new System.Drawing.Size(74, 26);
            this.textBoxS.TabIndex = 9;
            this.toolTip1.SetToolTip(this.textBoxS, "Длина отрезка bc");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "S =";
            // 
            // textBoxV
            // 
            this.textBoxV.Location = new System.Drawing.Point(98, 25);
            this.textBoxV.Name = "textBoxV";
            this.textBoxV.ReadOnly = true;
            this.textBoxV.Size = new System.Drawing.Size(74, 26);
            this.textBoxV.TabIndex = 7;
            this.toolTip1.SetToolTip(this.textBoxV, "Длина отрезка ас");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "V =";
            // 
            // groupBox1
            // 
            this.groupBox1.ContextMenuStrip = this.contextMenuStrip1in;
            this.groupBox1.Controls.Add(this.textBoxC);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxB);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxA);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(178, 122);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Исходные данные";
            // 
            // contextMenuStrip1in
            // 
            this.contextMenuStrip1in.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.чтоВводитьToolStripMenuItem,
            this.сбросToolStripMenuItem2});
            this.contextMenuStrip1in.Name = "contextMenuStrip1in";
            this.contextMenuStrip1in.Size = new System.Drawing.Size(146, 48);
            // 
            // чтоВводитьToolStripMenuItem
            // 
            this.чтоВводитьToolStripMenuItem.Name = "чтоВводитьToolStripMenuItem";
            this.чтоВводитьToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.чтоВводитьToolStripMenuItem.Text = "Что вводить?";
            this.чтоВводитьToolStripMenuItem.Click += new System.EventHandler(this.чтоВводитьToolStripMenuItem_Click);
            // 
            // сбросToolStripMenuItem2
            // 
            this.сбросToolStripMenuItem2.Name = "сбросToolStripMenuItem2";
            this.сбросToolStripMenuItem2.Size = new System.Drawing.Size(145, 22);
            this.сбросToolStripMenuItem2.Text = "Сброс";
            this.сбросToolStripMenuItem2.Click += new System.EventHandler(this.сбросToolStripMenuItem2_Click);
            // 
            // textBoxC
            // 
            this.textBoxC.Location = new System.Drawing.Point(98, 89);
            this.textBoxC.Name = "textBoxC";
            this.textBoxC.Size = new System.Drawing.Size(74, 26);
            this.textBoxC.TabIndex = 3;
            this.toolTip1.SetToolTip(this.textBoxC, "Точка на числовой оси");
            this.textBoxC.TextChanged += new System.EventHandler(this.textBoxC_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "c =";
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(98, 57);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(74, 26);
            this.textBoxB.TabIndex = 2;
            this.toolTip1.SetToolTip(this.textBoxB, "Точка на числовой оси");
            this.textBoxB.TextChanged += new System.EventHandler(this.textBoxB_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "b =";
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(98, 25);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(74, 26);
            this.textBoxA.TabIndex = 1;
            this.toolTip1.SetToolTip(this.textBoxA, "Точка на числовой оси");
            this.textBoxA.TextChanged += new System.EventHandler(this.textBoxA_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "a =";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(375, 168);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Задание 2";
            this.toolTip1.SetToolTip(this.tabPage2, "С начала суток прошло N секунд (N — целое). Найти количество полных минут, прошед" +
        "ших сначала последнего часа.");
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Enter += new System.EventHandler(this.tabPage2_Enter);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 134);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(363, 27);
            this.button1.TabIndex = 4;
            this.button1.Text = "Рассчитать";
            this.toolTip1.SetToolTip(this.button1, "Рассчитать количество минут, прошедших с начала последнего часа.");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.рассчитатьToolStripMenuItem1_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.ContextMenuStrip = this.contextMenuStrip2out;
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.textBoxProiz);
            this.groupBox4.Controls.Add(this.textBoxSum);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Location = new System.Drawing.Point(190, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(179, 122);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Результат";
            // 
            // contextMenuStrip2out
            // 
            this.contextMenuStrip2out.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3});
            this.contextMenuStrip2out.Name = "contextMenuStrip2";
            this.contextMenuStrip2out.Size = new System.Drawing.Size(110, 26);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(109, 22);
            this.toolStripMenuItem3.Text = "Сброс";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // textBoxSum
            // 
            this.textBoxSum.Location = new System.Drawing.Point(90, 25);
            this.textBoxSum.Name = "textBoxSum";
            this.textBoxSum.ReadOnly = true;
            this.textBoxSum.Size = new System.Drawing.Size(74, 26);
            this.textBoxSum.TabIndex = 5;
            this.toolTip1.SetToolTip(this.textBoxSum, "Количество полных минут, прошедших сначала последнего часа");
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 20);
            this.label8.TabIndex = 4;
            this.label8.Text = "Сумма=";
            // 
            // groupBox3
            // 
            this.groupBox3.ContextMenuStrip = this.contextMenuStrip2in;
            this.groupBox3.Controls.Add(this.textBoxChislo);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(178, 122);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Исходные данные";
            // 
            // contextMenuStrip2in
            // 
            this.contextMenuStrip2in.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.чтоВводитьToolStripMenuItem1,
            this.toolStripMenuItem2});
            this.contextMenuStrip2in.Name = "contextMenuStrip1";
            this.contextMenuStrip2in.Size = new System.Drawing.Size(146, 48);
            // 
            // чтоВводитьToolStripMenuItem1
            // 
            this.чтоВводитьToolStripMenuItem1.Name = "чтоВводитьToolStripMenuItem1";
            this.чтоВводитьToolStripMenuItem1.Size = new System.Drawing.Size(145, 22);
            this.чтоВводитьToolStripMenuItem1.Text = "Что вводить?";
            this.чтоВводитьToolStripMenuItem1.Click += new System.EventHandler(this.чтоВводитьToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(145, 22);
            this.toolStripMenuItem2.Text = "Сброс";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // textBoxChislo
            // 
            this.textBoxChislo.Location = new System.Drawing.Point(98, 58);
            this.textBoxChislo.Name = "textBoxChislo";
            this.textBoxChislo.Size = new System.Drawing.Size(74, 26);
            this.textBoxChislo.TabIndex = 3;
            this.toolTip1.SetToolTip(this.textBoxChislo, "Количество секунд, прошедших с начала суток");
            this.textBoxChislo.TextChanged += new System.EventHandler(this.textBoxSec_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Число=";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.настройкаToolStripMenuItem,
            this.действияToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(403, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // настройкаToolStripMenuItem
            // 
            this.настройкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.настройкаToolStripMenuItem.Name = "настройкаToolStripMenuItem";
            this.настройкаToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.настройкаToolStripMenuItem.Text = "Файл";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // действияToolStripMenuItem
            // 
            this.действияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.рассчитатьToolStripMenuItem,
            this.сбросToolStripMenuItem,
            this.toolStripMenuItem1,
            this.рассчитатьToolStripMenuItem1,
            this.сбросToolStripMenuItem1});
            this.действияToolStripMenuItem.Name = "действияToolStripMenuItem";
            this.действияToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.действияToolStripMenuItem.Text = "Действия";
            // 
            // рассчитатьToolStripMenuItem
            // 
            this.рассчитатьToolStripMenuItem.Name = "рассчитатьToolStripMenuItem";
            this.рассчитатьToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.рассчитатьToolStripMenuItem.Text = "Рассчитать(задание 1)";
            this.рассчитатьToolStripMenuItem.Click += new System.EventHandler(this.рассчитатьToolStripMenuItem_Click);
            // 
            // сбросToolStripMenuItem
            // 
            this.сбросToolStripMenuItem.Name = "сбросToolStripMenuItem";
            this.сбросToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.сбросToolStripMenuItem.Text = "Сброс(задание 1)";
            this.сбросToolStripMenuItem.Click += new System.EventHandler(this.сбросToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(192, 6);
            // 
            // рассчитатьToolStripMenuItem1
            // 
            this.рассчитатьToolStripMenuItem1.Name = "рассчитатьToolStripMenuItem1";
            this.рассчитатьToolStripMenuItem1.Size = new System.Drawing.Size(195, 22);
            this.рассчитатьToolStripMenuItem1.Text = "Рассчитать(задание 2)";
            this.рассчитатьToolStripMenuItem1.Click += new System.EventHandler(this.рассчитатьToolStripMenuItem1_Click);
            // 
            // сбросToolStripMenuItem1
            // 
            this.сбросToolStripMenuItem1.Name = "сбросToolStripMenuItem1";
            this.сбросToolStripMenuItem1.Size = new System.Drawing.Size(195, 22);
            this.сбросToolStripMenuItem1.Text = "Сброс(задание 2)";
            this.сбросToolStripMenuItem1.Click += new System.EventHandler(this.сбросToolStripMenuItem1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabelDate,
            this.toolStripStatusLabelTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 240);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(403, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(52, 17);
            this.toolStripStatusLabel1.Text = "Задание";
            // 
            // toolStripStatusLabelDate
            // 
            this.toolStripStatusLabelDate.Name = "toolStripStatusLabelDate";
            this.toolStripStatusLabelDate.Size = new System.Drawing.Size(32, 17);
            this.toolStripStatusLabelDate.Text = "Дата";
            // 
            // toolStripStatusLabelTime
            // 
            this.toolStripStatusLabelTime.Name = "toolStripStatusLabelTime";
            this.toolStripStatusLabelTime.Size = new System.Drawing.Size(42, 17);
            this.toolStripStatusLabelTime.Text = "Время";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textBoxProiz
            // 
            this.textBoxProiz.Location = new System.Drawing.Point(90, 58);
            this.textBoxProiz.Name = "textBoxProiz";
            this.textBoxProiz.ReadOnly = true;
            this.textBoxProiz.Size = new System.Drawing.Size(74, 26);
            this.textBoxProiz.TabIndex = 6;
            this.toolTip1.SetToolTip(this.textBoxProiz, "Количество полных минут, прошедших сначала последнего часа");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Произв=";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 262);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Практическая работа № 12";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.contextMenuStrip1out.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.contextMenuStrip1in.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.contextMenuStrip2out.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.contextMenuStrip2in.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelDate;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelTime;
        private System.Windows.Forms.ToolStripMenuItem настройкаToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ToolStripMenuItem действияToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBoxC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxS;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripMenuItem рассчитатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сбросToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem рассчитатьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem сбросToolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1in;
        private System.Windows.Forms.ToolStripMenuItem сбросToolStripMenuItem2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1out;
        private System.Windows.Forms.ToolStripMenuItem сбросToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2out;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2in;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem чтоВводитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem чтоВводитьToolStripMenuItem1;
        private System.Windows.Forms.TextBox textBoxChislo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxSum;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxProiz;
    }
}

