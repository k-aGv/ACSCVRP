using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using FDL.Library.Numeric;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void NumIts_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            double[,] Customers = new double[,] {{1, 11003.611100, 42102.500000},
{2, 11108.611100, 42373.888900},
{3, 11133.333300, 42885.833300},
{4, 11155.833300, 42712.500000},
{5, 11183.333300, 42933.333300},
{6, 11297.500000, 42853.333300},
{7, 11310.277800, 42929.444400},
{8, 11416.666700, 42983.333300},
{ 9, 11423.888900, 43000.277800},
{10, 11438.333300, 42057.222200},
{11, 11461.111100, 43252.777800},
{12, 11485.555600, 43187.222200},
{13, 11503.055600, 42855.277800},
{14, 11511.388900, 42106.388900},
{15, 11522.222200, 42841.944400},
{16, 11569.444400, 43136.666700},
{17, 11583.333300, 43150.000000},
{18, 11595.000000, 43148.055600},
{19, 11600.000000, 43150.000000},
{20, 11690.555600, 42686.666700},
{21, 11715.833300, 41836.111100},
{22, 11751.111100, 42814.444400},
{23, 11770.277800, 42651.944400},
{24, 11785.277800, 42884.444400},
{25, 11822.777800, 42673.611100},
{26, 11846.944400, 42660.555600},
{27, 11963.055600, 43290.555600},
{28, 11973.055600, 43026.111100},
{29, 12058.333300, 42195.555600},
{30, 12149.444400, 42477.500000},
{31, 12286.944400, 43355.555600},
{32, 12300.000000, 42433.333300},
{33, 12355.833300, 43156.388900},
{34, 12363.333300, 43189.166700},
{35, 12372.777800, 42711.388900},
{36, 12386.666700, 43334.722200},
{37, 12421.666700, 42895.555600},
{38, 12645.000000, 42973.333300}};
    int SizeCustomers;

            SizeCustomers = Customers.GetLength(0);

            for (int i = 0; i < SizeCustomers; i++)
            {
                chart1.Series["Customers"].Points.AddXY(Customers[i, 1], Customers[i, 2]);  
             }



            int NumItsMax;
            double m;
            double q0;
            double b;
            double r;
            double x;
            double a;
            double BestLength;
            int Iteration;
            double Sump;
            int nextmove=0;
            double Length;
            

            double[,] h = new double[SizeCustomers, SizeCustomers];
            double[,] CustomersDistance = new double[SizeCustomers, SizeCustomers];
            double[,] t = new double[SizeCustomers, SizeCustomers];
            double NearNb = 0;
            double t0=0;
            int[] BestTour = new int[SizeCustomers + 1];
            


            BestLength = 0;

            for (int i = 0; i < SizeCustomers; i++)
            {
       
                for (int j = 0; j < SizeCustomers; j++)
                {
                    h[i, j] = 0;
                    
                    if (i == j)
                    { CustomersDistance[i, j] = 1000000000000000000;
                    }
                    else
                    {
                        double x0 = Customers[i, 1];
                        double y0 = Customers[i, 2];

                        double x1 = Customers[j, 1];
                        double y1 = Customers[j, 2];

                        double dX = x1 - x0;
                        double dY = y1 - y0;
                        double distance = Math.Sqrt(dX * dX + dY * dY);
                        CustomersDistance[i, j] = distance;

                    }
                    h[i, j] = 1 / CustomersDistance[i, j];
                }
            }

          
            

            NumItsMax =Convert.ToInt32( NumIts.Value);
            Random rand = new Random();
            m =Convert.ToDouble(Ants.Value);
            q0 = Convert.ToDouble(q0value.Value);
            b = Convert.ToDouble(bvalue.Value);
            r = Convert.ToDouble(rvalue.Value);
            x = Convert.ToDouble(xvalue.Value);
            a = Convert.ToDouble(avalue.Value);




            int NextNode=0;
            double[] results = new double[NumItsMax];

            for (int i=0; i<SizeCustomers-1;i++)
            {
                BestLength = BestLength + CustomersDistance[i, i + 1];

            }


            double min = 100000000;
            int Startingnode = RandomNumber.Between(0,SizeCustomers-1);
            List<int> NBUnvisited = new List<int>();
            BestTour[0] = Startingnode;
            
            for (int l = 0; l < SizeCustomers; l++)
            {
                NBUnvisited.Add(l);
                
            }
            NBUnvisited.Remove(Startingnode);
            for (int i=0;i<NBUnvisited.Count;i++)
            {
                
                if(min>CustomersDistance[Startingnode, NBUnvisited[i]])
                {
                    min = CustomersDistance[Startingnode, NBUnvisited[i]];
                    NextNode = NBUnvisited[i];
                }

            }
            NearNb = NearNb + CustomersDistance[Startingnode, NextNode];
            NBUnvisited.Remove(NextNode);
            BestTour[1] = NextNode;
            Startingnode = NextNode;

            int count = 1;
            Boolean listempty = false;
            while (listempty == false)
            {
                count = count + 1;
                min = 100000000;
                for (int i = 0; i < NBUnvisited.Count; i++)
                {

                    if (min > CustomersDistance[Startingnode, NBUnvisited[i]])
                    {
                        min = CustomersDistance[Startingnode, NBUnvisited[i]];
                        NextNode = NBUnvisited[i];
                    }
                    
                }
                NearNb = NearNb + CustomersDistance[Startingnode, NextNode];
                NBUnvisited.Remove(NextNode);
                BestTour[count] = NextNode;
                Startingnode = NextNode;
                if(NBUnvisited.Count==0)
                {
                    listempty = true;
                }
            }
            BestTour[BestTour.Length - 1] = BestTour[0];
            NearNb = NearNb + CustomersDistance[BestTour[BestTour.Length - 2], BestTour[0]];



            for (int i = 0; i < SizeCustomers; i++)
            {

                for (int j = 0; j < SizeCustomers; j++)
                {

                    
                    t0 = (1 / ((NearNb * SizeCustomers)));
                    t[i, j] = t0;

                }
            }


            







            Iteration = 1;

            while (Iteration < NumItsMax) 
            {
                for(int k=1;k<m+1;k++)
                {
                    
                    int moves = 0;
                    int[] tour = new int[SizeCustomers + 1];
                    tour[moves] = RandomNumber.Between(0,SizeCustomers-1);
                    List<int> Unvisited = new List<int>();
                    for (int l=0;l<SizeCustomers;l++)
                    {
                        Unvisited.Add(l);
                        
                    }

                    Unvisited.Remove(tour[0]);

                   for(int trip=0;trip<SizeCustomers-1;trip++)
                    {
                        int c = tour[trip];

                        List<double> choice = new List<double>();

                        for(int i=0;i<Unvisited.Count;i++)
                        {
                            int j = Unvisited.ElementAt(i);
                            choice.Add(Math.Pow(t[c, j],a) * Math.Pow(h[c, j], b));
                        }
                        double random1 = RandomNumber.Between(0, 100);
                        random1 = random1 / 100;
                        if (random1< q0)
                        {
                            double maxValue = choice.Max();
                            int maxIndex = choice.IndexOf(maxValue);
                            nextmove = Unvisited.ElementAt(maxIndex);
                        }
                        else
                        {
                            List<double> p = new List<double>();
                            p.Clear();
                            Sump = 0;
                            for(int i=0;i<Unvisited.Count;i++)
                            {
                                int j = Unvisited.ElementAt(i);
                                Sump =Sump + (Math.Pow(t[c, j], a) * Math.Pow(h[c, j], b));
                                p.Add((Math.Pow(t[c, j], a) * Math.Pow(h[c, j], b)));
                            }

                            double cumsum = 0;
                            double randomnum = RandomNumber.Between(0, 100);
                            randomnum = randomnum / 100;
                            for (int i=0;i<p.Count ;i++)
                            {
                                p[i] = p[i] / Sump;
                                p[i] = cumsum + p[i];
                                cumsum = p[i];
                            }
                            for(int j=0;j<p.Count-1;j++)
                            {
                                if (randomnum >= p[j] && randomnum < p[j+1])
                                {
                                    nextmove = Unvisited.ElementAt(j);
                                    break;
                                }
                            }
                        }
                        tour[trip + 1] = nextmove;
                        Unvisited.Remove(tour[trip+1]);

                        


                        t[c, tour[trip + 1]] = t[c, tour[trip + 1]]*(1-x) + x * t0;
                    }

                    tour[tour.Length-1] = tour[0];

                    Length = 0;
                    for (int i = 0; i < tour.Length - 1; i++)
                    {
                        Length = Length + CustomersDistance[tour[i], tour[i + 1]];
                    }

                    /*
                    double BestDistance = 0;
                    Boolean improvement = true;
                    while(improvement==true)
                    {
                        improvement = false;
                        for (int i = 1; i < tour.Length - 2; i++)
                        {
                            BestDistance = BestDistance + CustomersDistance[tour[i], tour[i + 1]];
                        }

                        for(int i=1;i<tour.Length-2;i++)
                        {
                            for(int v=i+1;v<tour.Length-1;v++)
                            {
                                int[] newroute = new int[tour.Length - 2];
                                for(int l=1;l<i;l++)
                                {
                                    newroute[l - 1] = tour[l];
                                }
                                int eff = 0;
                                for(int l=i;l<v+1;l++)
                                {
                                    newroute[l - 1] = tour[v - eff];
                                    eff = eff + 1;
                                }
                                for(int l=v+1;l<tour.Length-2;l++)
                                {
                                    newroute[l - 1] = tour[l];
                                }

                                double newdistance = 0;
                                for (int l = 0; l < newroute.Length-1; l++)
                                {
                                    newdistance = newdistance + CustomersDistance[newroute[l], newroute[l + 1]];
                                }

                                if(newdistance<BestDistance)
                                {
                                    for (int l = 0; l < newroute.Length; l++)
                                        tour[l + 1] = newroute[l];
                                    improvement = true;
                                }


                            }
                        }



                    }




    */












                    Length = 0;
                    for(int i=0;i<tour.Length-1;i++)
                    {
                        Length = Length + CustomersDistance[tour[i], tour[i + 1]];
                    }

                    if(Length<BestLength)
                    {
                        BestLength = Length;
                        BestTour = tour;

                    }
                   
                }
                

                
                for(int i=0;i<t.GetLength(0);i++)
                {
                    for (int j = 0; j < t.GetLength(1); j++)
                    {
                        t[i, j] = t[i, j] *(1- r);

                    }

                }
                    
                for(int i=0;i<BestTour.Length-1;i++)
                {
                    t[BestTour[i], BestTour[i + 1]] = t[BestTour[i], BestTour[i + 1]] + r * (1 / BestLength);
                }

                results[Iteration] = BestLength;
                Iteration = Iteration + 1;

            }

            double minimum;
            minimum = Customers[BestTour[0], 2];
            for (int i=1;i<BestTour.Length;i++)
            {
                if(minimum>Customers[BestTour[i],2])
                {
                    minimum = Customers[BestTour[i], 2];
                }
            }

            chart1.ChartAreas[0].AxisY.Minimum = minimum;

            for (int i = 0; i < BestTour.Length; i++)
            {
                chart1.Series["Trip"].Points.AddXY(Customers[BestTour[i], 1], Customers[BestTour[i], 2]);
            }

            textBox1.Text = Convert.ToString(BestLength);

            if ((BestTour.Length-1) != BestTour.Distinct().Count())
            {
                textBox2.Text = Convert.ToString("Dublicates found");
            }
            else
            {
                textBox2.Text = Convert.ToString("No Error found");
            }

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
