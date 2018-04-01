namespace MyProject
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.FCFS = new System.Windows.Forms.RadioButton();
            this.SJFP = new System.Windows.Forms.RadioButton();
            this.SJFNP = new System.Windows.Forms.RadioButton();
            this.PP = new System.Windows.Forms.RadioButton();
            this.RR = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ProcessName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProcessArrivaltime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProcessBurstTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProcessPriority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PNP = new System.Windows.Forms.RadioButton();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Number of Process";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(43, 71);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // FCFS
            // 
            this.FCFS.AutoSize = true;
            this.FCFS.Location = new System.Drawing.Point(56, 215);
            this.FCFS.Name = "FCFS";
            this.FCFS.Size = new System.Drawing.Size(51, 17);
            this.FCFS.TabIndex = 2;
            this.FCFS.TabStop = true;
            this.FCFS.Text = "FCFS";
            this.FCFS.UseVisualStyleBackColor = true;
            this.FCFS.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // SJFP
            // 
            this.SJFP.AutoSize = true;
            this.SJFP.Location = new System.Drawing.Point(56, 238);
            this.SJFP.Name = "SJFP";
            this.SJFP.Size = new System.Drawing.Size(101, 17);
            this.SJFP.TabIndex = 3;
            this.SJFP.TabStop = true;
            this.SJFP.Text = "SJF ( premptive)";
            this.SJFP.UseVisualStyleBackColor = true;
            this.SJFP.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // SJFNP
            // 
            this.SJFNP.AutoSize = true;
            this.SJFNP.Location = new System.Drawing.Point(55, 261);
            this.SJFNP.Name = "SJFNP";
            this.SJFNP.Size = new System.Drawing.Size(125, 17);
            this.SJFNP.TabIndex = 4;
            this.SJFNP.TabStop = true;
            this.SJFNP.Text = "SJF ( non premptive )";
            this.SJFNP.UseVisualStyleBackColor = true;
            this.SJFNP.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // PP
            // 
            this.PP.AutoSize = true;
            this.PP.Location = new System.Drawing.Point(56, 285);
            this.PP.Name = "PP";
            this.PP.Size = new System.Drawing.Size(116, 17);
            this.PP.TabIndex = 5;
            this.PP.TabStop = true;
            this.PP.Text = "priority ( premptive )";
            this.PP.UseVisualStyleBackColor = true;
            this.PP.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // RR
            // 
            this.RR.AutoSize = true;
            this.RR.Location = new System.Drawing.Point(56, 327);
            this.RR.Name = "RR";
            this.RR.Size = new System.Drawing.Size(41, 17);
            this.RR.TabIndex = 6;
            this.RR.TabStop = true;
            this.RR.Text = "RR";
            this.RR.UseVisualStyleBackColor = true;
            this.RR.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProcessName,
            this.ProcessArrivaltime,
            this.ProcessBurstTime,
            this.ProcessPriority});
            this.dataGridView1.Location = new System.Drawing.Point(274, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(440, 207);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ProcessName
            // 
            this.ProcessName.HeaderText = "Process ID";
            this.ProcessName.Name = "ProcessName";
            // 
            // ProcessArrivaltime
            // 
            this.ProcessArrivaltime.HeaderText = "Arrival Time";
            this.ProcessArrivaltime.Name = "ProcessArrivaltime";
            // 
            // ProcessBurstTime
            // 
            this.ProcessBurstTime.HeaderText = "CPU Burst";
            this.ProcessBurstTime.Name = "ProcessBurstTime";
            // 
            // ProcessPriority
            // 
            this.ProcessPriority.HeaderText = "Priority";
            this.ProcessPriority.Name = "ProcessPriority";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(43, 107);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 8;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(274, 370);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Run";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Brown;
            this.label2.Location = new System.Drawing.Point(12, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Choose A scheduling Algorithm";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(149, 344);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 347);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Quantum";
            // 
            // PNP
            // 
            this.PNP.AutoSize = true;
            this.PNP.Location = new System.Drawing.Point(58, 308);
            this.PNP.Name = "PNP";
            this.PNP.Size = new System.Drawing.Size(137, 17);
            this.PNP.TabIndex = 13;
            this.PNP.TabStop = true;
            this.PNP.Text = "priority ( non premptive )";
            this.PNP.UseVisualStyleBackColor = true;
            this.PNP.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(614, 336);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(467, 339);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Average Waiting Time ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(420, 370);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(781, 405);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.PNP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.RR);
            this.Controls.Add(this.PP);
            this.Controls.Add(this.SJFNP);
            this.Controls.Add(this.SJFP);
            this.Controls.Add(this.FCFS);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton FCFS;
        private System.Windows.Forms.RadioButton SJFP;
        private System.Windows.Forms.RadioButton SJFNP;
        private System.Windows.Forms.RadioButton PP;
        private System.Windows.Forms.RadioButton RR;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProcessName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProcessArrivaltime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProcessBurstTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProcessPriority;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton PNP;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}

