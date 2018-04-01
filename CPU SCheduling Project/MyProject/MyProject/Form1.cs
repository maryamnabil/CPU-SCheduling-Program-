using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProject
{ 
    public partial class Form1 : Form
    {
        public static int currentTime = 0;
        int btime = 0,min=0,L=1;
        int mode;
        Process[] processArray;
        int Quantum;
        double AvgWT;
        int t1, t2;
        int NumberOfProcess;

        public Form1()
        {
            InitializeComponent();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void StartScheduling()
        {
            switch (mode)
            {
                case 0: fcfs(); break;
                case 1: sjfp(); break;
                case 2: sjfnp(); break;
                case 3: prp(); break;
                case 4: prnp(); break;
                case 5: rr(); break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
    
            processArray = new Process[NumberOfProcess];
            for (int i = 0; i < NumberOfProcess; i++)
            {
                String name = dataGridView1.Rows[i].Cells[0].Value.ToString();
                int arrivalTime = Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value.ToString());
                int cpuBurst = Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value.ToString());
                int priority = Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value.ToString());
                processArray[i] = new Process(name, arrivalTime, cpuBurst, priority);
            }

            StartScheduling();
            label4.Visible = true;
            textBox3.Text =Convert.ToString(AvgWT);
            textBox3.Visible = true;
            button1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            NumberOfProcess = Convert.ToInt32(textBox1.Text);
            for (int i = 0; i < NumberOfProcess; i++)
            {
                String [] data = { "Process " + (i + 1).ToString()};

                dataGridView1.Rows.Add(data);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label3.Visible = false;
            textBox2.Visible = false;
            label4.Visible = false;
            textBox3.Visible = false;
            button1.Visible = false;

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            label3.Visible = true;
            textBox2.Visible = true;
            mode = 5;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            label3.Visible = false;
            textBox2.Visible = false;
            mode = 4;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            label3.Visible = false;
            textBox2.Visible = false;
            mode = 3;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label3.Visible = false;
            textBox2.Visible = false;
            mode = 2;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label3.Visible = false;
            textBox2.Visible = false;
            mode = 1; 
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label3.Visible = false;
            textBox2.Visible = false;
                mode = 0;
        }

        //fcfs
        private void fcfs()
        {
            Process temp;
            for (int k = 0; k < NumberOfProcess; k++)
            {
                for (int i = k + 1; i < NumberOfProcess; i++)
                {

                    if (processArray[k].arrivalTime > processArray[i].arrivalTime || (processArray[k].arrivalTime == processArray[i].arrivalTime && processArray[k].brust > processArray[i].brust))
                    {
                        temp = processArray[i];
                        processArray[i] = processArray[k];
                        processArray[k] = temp;
                    }
                }
            }
            int clock = 0, totalwait = 0;
            for (int i = 0; i < NumberOfProcess; i++)
            {
                if (processArray[i].arrivalTime > clock)
                {
                    processArray[i].start = processArray[i].arrivalTime;
                    //clock += processArray[i].start - processArray[i].arrivalTime;
                    clock += processArray[i].brust;
                }
                else
                {
                    if (i > 0)
                        processArray[i].start = processArray[i - 1].end;
                    clock += processArray[i].brust;
                }
                if (processArray[i].start > processArray[i].arrivalTime)
                    processArray[i].wait = processArray[i].start - processArray[i].arrivalTime;
                else processArray[i].wait = 0;
                processArray[i].end = processArray[i].start + processArray[i].brust;
                totalwait += processArray[i].wait;
            }
            AvgWT = (double)totalwait / (double)NumberOfProcess;
        }



        // SJF NON Pre
        private void sjfnp()
        {
            Process temp;
            for (int k = 0; k < NumberOfProcess; k++)
            {
                for (int i = k + 1; i < NumberOfProcess; i++)
                {
                    if ( (processArray[k].arrivalTime > processArray[i].arrivalTime) || (processArray[k].arrivalTime == processArray[i].arrivalTime && processArray[k].brust > processArray[i].brust))
                    {
                        temp = processArray[i];
                        processArray[i] = processArray[k];
                        processArray[k] = temp;
                    }
                }
            }
            for (int k = 0; k < NumberOfProcess-1; k++)
            {
                btime = btime + processArray[k].brust;
                min = processArray[L].brust;
                for (int i = k + 1; i < NumberOfProcess; i++)
                {
                    if (btime >= processArray[i].arrivalTime && processArray[i].brust < min)
                    {
                        temp = processArray[i];
                        processArray[i] = processArray[L];
                        processArray[L] = temp;
                    }
                }
                L++;
            }

     
            int clock = 0, totalwait = 0;
            for (int i = 0; i < NumberOfProcess; i++)
            {
                if (processArray[i].arrivalTime > clock)
                {
                    processArray[i].start = processArray[i].arrivalTime;
                    clock += processArray[i].start - processArray[i].arrivalTime;
                    clock += processArray[i].brust;
                }
                else
                {
                    if (i > 0)
                        processArray[i].start = processArray[i - 1].end;
                    clock += processArray[i].brust;
                }
                if (processArray[i].start > processArray[i].arrivalTime)
                    processArray[i].wait = processArray[i].start - processArray[i].arrivalTime;
                else processArray[i].wait = 0;
                processArray[i].end = processArray[i].start + processArray[i].brust;
                totalwait += processArray[i].wait;
            }
            AvgWT = (double)totalwait / (double)NumberOfProcess;
        }

        //Priority Non P

        private void prnp()
        {
            Process temp;
            for (int k = 0; k < NumberOfProcess; k++)
            {
                for (int i = k + 1; i < NumberOfProcess; i++)
                {
                    if ((processArray[k].arrivalTime > processArray[i].arrivalTime) || (processArray[k].arrivalTime == processArray[i].arrivalTime && processArray[k].priority > processArray[i].priority))
                    {
                        temp = processArray[i];
                        processArray[i] = processArray[k];
                        processArray[k] = temp;
                    }
                }
            }
            for (int k = 0; k < NumberOfProcess - 1; k++)
            {
                btime = btime + processArray[k].priority;
                min = processArray[L].priority;
                for (int i = k + 1; i < NumberOfProcess; i++)
                {
                    if (btime >= processArray[i].arrivalTime && processArray[i].priority < min)
                    {
                        temp = processArray[i];
                        processArray[i] = processArray[L];
                        processArray[L] = temp;
                    }
                }
                L++;
            }


            int clock = 0, totalwait = 0;
            for (int i = 0; i < NumberOfProcess; i++)
            {
                if (processArray[i].arrivalTime > clock)
                {
                    processArray[i].start = processArray[i].arrivalTime;
                    clock += processArray[i].start - processArray[i].arrivalTime;
                    clock += processArray[i].brust;
                }
                else
                {
                    if (i > 0)
                        processArray[i].start = processArray[i - 1].end;
                    clock += processArray[i].brust;
                }
                if (processArray[i].start > processArray[i].arrivalTime)
                    processArray[i].wait = processArray[i].start - processArray[i].arrivalTime;
                else processArray[i].wait = 0;
                processArray[i].end = processArray[i].start + processArray[i].brust;
                totalwait += processArray[i].wait;
            }
            AvgWT = (double)totalwait / (double)NumberOfProcess;
        }


        // R R 
        void rr() {}


        private void sjfp()
        {
            Process temp;
            for (int k = 0; k <NumberOfProcess; k++)
            {
                for (int i = k + 1; i < NumberOfProcess; i++)
                {
                    if (processArray[k].arrivalTime >= processArray[i].arrivalTime && processArray[k].brust > processArray[i].brust)
                    {
                        temp = processArray[i];
                        processArray[i] = processArray[k];
                        processArray[k] = temp;
                    }
                }
            }
            int clock = 0, totalwait = 0;
            for (int i = 0; i < NumberOfProcess; i++)
            {
                for (int j = 0; j < NumberOfProcess; j++)
                {
                    Process temp2;
                    processArray[i].remaintime = clock - processArray[i].end;
                    if (processArray[i].remaintime > processArray[j].brust)
                    {
                        temp2 = processArray[i];
                        processArray[i] = processArray[j];
                        processArray[j] = temp2;
                    }
                    if (processArray[i].arrivalTime > clock)
                    {
                        processArray[i].start = processArray[i].arrivalTime;
                        clock += processArray[i].start - processArray[i].arrivalTime;
                        processArray[i].end = clock + processArray[i].brust;
                        clock += processArray[i].brust;
                    }
                    else
                    {
                        if (i > 0)
                            processArray[i].start = processArray[i - 1].end;
                        clock += processArray[i].brust;
                    }
                    if (processArray[i].start > processArray[i].arrivalTime)
                        processArray[i].wait = processArray[i].start - processArray[i].arrivalTime;
                    else processArray[i].wait = 0;
                    totalwait += processArray[i].wait;
                    int t = processArray[i].brust - processArray[i].remaintime;
                   
                }
            }
            AvgWT = (double)totalwait / (double)NumberOfProcess;
        }

// priority P

        private void prp()
        {
            Process temp;
            for (int k = 0; k < NumberOfProcess; k++)
            {
                for (int i = k + 1; i < NumberOfProcess; i++)
                {
                    if (processArray[k].priority > processArray[i].priority)
                    {
                        temp = processArray[i];
                        processArray[i] = processArray[k];
                        processArray[k] = temp;
                    }
                }
            }
            int clock = 0, totalwait = 0;
            for (int i = 0; i < NumberOfProcess; i++)
            {
                for (int j = 0; j < NumberOfProcess; j++)
                {
                    Process temp2;
                    processArray[i].remaintime = clock - processArray[i].end;
                    if (processArray[i].remaintime > processArray[j].brust)
                    {
                        temp2 = processArray[i];
                        processArray[i] = processArray[j];
                        processArray[j] = temp2;
                    }
                    if (processArray[i].arrivalTime > clock)
                    {
                        processArray[i].start = processArray[i].arrivalTime;
                        clock += processArray[i].start - processArray[i].arrivalTime;
                        processArray[i].end = clock + processArray[i].brust;
                        clock += processArray[i].brust;
                    }
                    else
                    {
                        if (i > 0)
                            processArray[i].start = processArray[i - 1].end;
                        clock += processArray[i].brust;
                    }
                    if (processArray[i].start > processArray[i].arrivalTime)
                        processArray[i].wait = processArray[i].start - processArray[i].arrivalTime;
                    else processArray[i].wait = 0;
                    processArray[i].end = processArray[i].start + processArray[i].brust;
                    totalwait += processArray[i].wait;
                    int t = processArray[i].brust - processArray[i].remaintime;
                }
            }
            AvgWT = (double)totalwait / (double) NumberOfProcess;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Reset() {
            for (int i = 0; i < NumberOfProcess; i++) {
                processArray[i] = null;
        
        }
            dataGridView1.Rows.Clear();
            mode=0;
            Quantum=0;
            AvgWT=0.0;
            t1 = 0; t2 = 0;
            NumberOfProcess=0;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Reset();
        }

    }

    class Process
    {
        
        public Process(string name, int arrivalTime, int brust, int priority)
        {
            this.name = name;
            this.arrivalTime = arrivalTime;
            this.brust = brust;
            this.priority = priority;
        }

        public Process(int burstTime)
        {
            this.remaintime = burstTime;
            this.brust = burstTime;
        }


        public Process(){ }
        public string name;
        public int arrivalTime;
        public int brust;
        public int remaintime;
        public int priority;
        public int wait;
        public int end;
        public int start;
        public int ranQuantums = 0;
        public int id;

    }
}
