/*!
The Apache License 2.0 License

Copyright (c) 2017 Dimitris Katikaridis <dkatikaridis@gmail.com>,Giannis Menekses <johnmenex@hotmail.com>

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in
all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
THE SOFTWARE.
*/
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace kagv {
    public partial class ACSAlgorithm : Form {
        public ACSAlgorithm() {
            InitializeComponent();
        }


        ProgressBar pb = new ProgressBar();
        Label pb_Label = new Label();
        Label pb_calculated = new Label();
        int _width;// = Size.Width;
        int _heigth;// = Size.Height;
        bool stopped = false;

        private void RunACS(double[,] Customers) {
            double BestLength = 0;
            int Iteration;
            double Sump;
            int nextmove = 0;
            double Length;


            double[,] h = null;
            double[,] CustomersDistance = null;
            double[,] t = null;

            int SizeCustomers = Customers.GetLength(0);

            try {
                h = new double[SizeCustomers, SizeCustomers];
                CustomersDistance = new double[SizeCustomers, SizeCustomers];
                t = new double[SizeCustomers, SizeCustomers];
            } catch (OutOfMemoryException z) {
                if (z != null) {
                    var totalGBRam = Convert.ToInt32((new Microsoft.VisualBasic.Devices.ComputerInfo().TotalPhysicalMemory / (Math.Pow(1024, 3))) + 0.5);
                    MessageBox.Show("The benchmark file is large for this system.\r\nYour declared arrays cant be declared in " + totalGBRam + " GBs of RAM\r\nOut of memory...Exiting application", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
            }



            int[] demand = new int[] {0,
19,
2,
12,
20,
6,
17,
8,
14,
2,
8,
5,
7,
22,
14,
17,
23,
15,
21,
2,
24,
10,
20,
6,
21,
10,
6,
13,
21,
24,
11,
16,
8,
11,
11,
22,
17,
22,
17,
8,
23,
5,
3,
18,
12};

            int sumdemand = demand.Sum();
            double extratrips = double.NaN;
            double Capacity = 100;
            extratrips =Math.Ceiling( sumdemand / Capacity);
            int vehiclesrequired=Convert.ToInt32(extratrips);


            double NearNb = 0;
            double t0 = 0;
            int[] BestTour = new int[SizeCustomers + vehiclesrequired];


            double[,] save = new double[SizeCustomers, SizeCustomers];

            for (int i = 0; i < SizeCustomers; i++)
                for (int j = 0; j < SizeCustomers; j++) {
                    h[i, j] = 0;

                    if (i == j)
                        CustomersDistance[i, j] = 1000000000000000000;
                    else {
                        double x0 = Customers[i, 1];
                        double y0 = Customers[i, 2];

                        double x1 = Customers[j, 1];
                        double y1 = Customers[j, 2];

                        double dX = x1 - x0;
                        double dY = y1 - y0;
                        double distance =(Math.Sqrt(dX * dX + dY * dY));
                        CustomersDistance[i, j] = distance;

                    }

                    
                    h[i, j] = 1 / CustomersDistance[i, j];
                }

            for (int i = 0; i < SizeCustomers; i++)
            {
                for (int j = 0; j < SizeCustomers; j++)
                {
                    save[i, j] = CustomersDistance[i, 0] + CustomersDistance[0, j] - CustomersDistance[i, j];
                }
            }

            double lamda = 2;


            int NumItsMax = Convert.ToInt32(NumIts.Value);
            Random rand = new Random();
            double m = Convert.ToDouble(Ants.Value);
            double q0 = Convert.ToDouble(q0value.Value);
            double b = Convert.ToDouble(bvalue.Value);
            double r = Convert.ToDouble(rvalue.Value);
            double x = Convert.ToDouble(xvalue.Value);
            double a = Convert.ToDouble(avalue.Value);
            double load = 0;



            int NextNode = 0;
            double[] results = new double[NumItsMax];

            BestLength = CustomersDistance[0,0];


            double min = 100000000;
            int Startingnode = 0;
            BestTour[0] = Startingnode;
            Startingnode = RandomNumber.Between(1, SizeCustomers - 1);
            List<int> NBUnvisited = new List<int>();
            BestTour[1] = Startingnode;
            load = load + demand[Startingnode];
            NearNb = NearNb + CustomersDistance[BestTour[0], BestTour[1]];

            for (int l = 0; l < SizeCustomers; l++) {
                NBUnvisited.Add(l);

            }
            NBUnvisited.Remove(0);
            NBUnvisited.Remove(Startingnode);

            if (load >= 100)
            {
                NextNode = 0;
                load = 0;
            }
            else
            {
                for (int i = 0; i < NBUnvisited.Count; i++)
                {

                    if (min > CustomersDistance[Startingnode, NBUnvisited[i]] && (load + demand[NBUnvisited[i]]) <= Capacity)
                    {
                        min = CustomersDistance[Startingnode, NBUnvisited[i]];
                        NextNode = NBUnvisited[i];
                    }
                    if (NextNode == Startingnode)
                    {

                        NextNode = 0;
                        load = 0;
                    }

                }
            }
            load = load + demand[NextNode];
            NearNb = NearNb + CustomersDistance[Startingnode, NextNode];
            NBUnvisited.Remove(NextNode);
            BestTour[2] = NextNode;
            Startingnode = NextNode;

            int count = 2;
            Boolean listempty = false;
            while (listempty == false) {
                count = count + 1;
                min = 100000000;
                if (load >= 100)
                {
                    NextNode = 0;
                    load = 0;
                }
                else
                {
                    for (int i = 0; i < NBUnvisited.Count; i++)
                    {

                        if (min > CustomersDistance[Startingnode, NBUnvisited[i]] && (load + demand[NBUnvisited[i]]) <= Capacity)
                        {
                            min = CustomersDistance[Startingnode, NBUnvisited[i]];
                            NextNode = NBUnvisited[i];
                        }

                    }
                    if(NextNode==Startingnode)
                    {

                        NextNode = 0;
                        load = 0;
                    }
                }
                load = load + demand[NextNode];
                NearNb = NearNb + CustomersDistance[Startingnode, NextNode];
                NBUnvisited.Remove(NextNode);
                BestTour[count] = NextNode;
                Startingnode = NextNode;
                if (NBUnvisited.Count == 0) {
                    listempty = true;
                }
            }




            for (int i = 0; i < SizeCustomers; i++) {

                for (int j = 0; j < SizeCustomers; j++) {


                    t0 = (1 / ((NearNb * SizeCustomers)));
                    t[i, j] = t0;

                }
            }


            Iteration = 1;
            double tmax = 0;
            tmax = (1 / ( (1 - r))) * (1 / NearNb);
            double tmin = 0;
            tmin = tmax*(1-Math.Pow(0.05,1/SizeCustomers))/((SizeCustomers/2-1)*Math.Pow(0.05,1/SizeCustomers));

          
            double[] TotalRandomLength = new double[500];
            for(int g=0;g<500;g++)
            {
                load = 0;
                double RandomLength = 0;
                List<int> RandomUnvisited = new List<int>();
                int Start = 0;
                int[] Randomtour = new int[SizeCustomers + vehiclesrequired];
                Randomtour[0] = Start;
                for (int l = 0; l < SizeCustomers; l++)
                {
                    RandomUnvisited.Add(l);

                }
                RandomUnvisited.Remove(Start);

                bool randomlistempty = false;
                int countrandom = 1;
                while(randomlistempty==false)
                {
                    int foundnode = 0;
                    for (int i = 0; i < RandomUnvisited.Count; i++)
                    {
                        int Next = RandomNumber.Between(0, RandomUnvisited.Count - 1);
                        if (load + demand[RandomUnvisited[Next]] <= 100)
                        {
                            foundnode = 1;
                            Randomtour[countrandom] = RandomUnvisited[Next];
                            load = load + demand[RandomUnvisited[Next]];
                            RandomUnvisited.Remove(RandomUnvisited[Next]);
                            RandomLength = RandomLength + CustomersDistance[Randomtour[countrandom - 1], Randomtour[countrandom]];
                            countrandom += 1;
                           
                            break;
                        }
                    }
                    if(foundnode==0)
                    {
                        load = 0;
                        Randomtour[countrandom] = 0;
                        RandomLength = RandomLength + CustomersDistance[Randomtour[countrandom - 1], Randomtour[countrandom]];
                        countrandom += 1;

                    }
                    if (RandomUnvisited.Count == 0)
                        randomlistempty = true;


                }


                TotalRandomLength[g] = RandomLength;
            }

            int meancount = 0;
            double DC = 0;
            for(int g=0;g<499;g++)
            {
                DC = DC + Math.Abs(TotalRandomLength[g]-TotalRandomLength[g+1]);
                meancount += 1;
            }

            DC = DC / meancount;

            double SDC = 0;
            for (int g = 0; g < 499; g++)
            {
                SDC = SDC + Math.Pow((TotalRandomLength[g] - TotalRandomLength[g + 1])-DC,2);
            }

            SDC = Math.Sqrt((SDC / meancount));


            double Temperature =0;
            Temperature = (DC + 3 * SDC) / (Math.Log(1 / 0.1));
            int[] activesolution = new int[SizeCustomers + vehiclesrequired];
            activesolution = BestTour;
            double activeLength = NearNb;

            while (Iteration < NumItsMax) {
                if (stopped)
                    return;
                int[] touriteration = new int[SizeCustomers + vehiclesrequired];
                double LengthIteration = Math.Pow(NearNb, 10);

                for (int k = 1; k < m + 1; k++) {
                    
                    load = 0;
                    int moves = 0;
                    int[] tour = new int[SizeCustomers + vehiclesrequired];
                    tour[moves] = 0;
                    moves += 1;
                    tour[moves] = RandomNumber.Between(1, SizeCustomers - 1);
                    load = load + demand[tour[moves]];
                    List<int> Unvisited = new List<int>();
                    for (int l = 0; l < SizeCustomers; l++)
                        Unvisited.Add(l);

                    Unvisited.Remove(tour[0]);
                    Unvisited.Remove(tour[1]);

                    for (int trip = 1; trip < SizeCustomers+vehiclesrequired-1; trip++) {
                        int c = tour[trip];

                        List<int> PossibleCustomers = new List<int>();
                        for(int i = 0; i < Unvisited.Count;i++)
                        {
                            if (load + demand[Unvisited.ElementAt(i)] <= Capacity) 
                            PossibleCustomers.Add(Unvisited.ElementAt(i));
                        }

                        if (PossibleCustomers.Count==0)
                        {
                            nextmove = 0;
                            
                        }
                        else if(c==0)
                        {
                            nextmove = PossibleCustomers[RandomNumber.Between(0, PossibleCustomers.Count-1)];
                        }
                        else
                        {
                            List<double> choice = new List<double>();

                            for (int i = 0; i < PossibleCustomers.Count; i++)
                            {
                                int j = PossibleCustomers.ElementAt(i);
                                choice.Add(Math.Pow(t[c, j], a) * Math.Pow(h[c, j], b)* Math.Pow(save[c, j], lamda));
                            }
                            double random1 = RandomNumber.DoubleBetween(0, 1);
                            if (random1 >= 1)
                                MessageBox.Show("error1");
                            if (random1 < q0)
                            {

                              double maxValue = choice.Max(); 
                              int maxIndex = choice.IndexOf(maxValue);
                              nextmove = PossibleCustomers.ElementAt(maxIndex);
                                
                            }
                            else
                            {
                                List<double> p = new List<double>();
                                p.Clear();
                                Sump = 0;
                                for (int i = 0; i < PossibleCustomers.Count; i++)
                                {
                                    int j = PossibleCustomers.ElementAt(i);
                                        Sump = Sump + (Math.Pow(t[c, j], a) * Math.Pow(h[c, j], b)* Math.Pow(save[c, j], lamda));
                                        p.Add((Math.Pow(t[c, j], a) * Math.Pow(h[c, j], b)* Math.Pow(save[c, j], lamda)));
                                    
                                }

                                double cumsum = 0;
                                double randomnum = RandomNumber.DoubleBetween(0, 1);
                                if (randomnum >= 1)
                                    MessageBox.Show("error1");
                                for (int i = 0; i < p.Count; i++)
                                {
                                    p[i] = p[i] / Sump;
                                    p[i] = cumsum + p[i];
                                    cumsum = p[i];
                                }
                                for (int j = 0; j < p.Count - 1; j++)
                                {
                                    if (randomnum >= p[j] && randomnum < p[j + 1])
                                    {
                                        nextmove = PossibleCustomers.ElementAt(j);
                                        break;
                                    }
                                }
                                if(nextmove==c)
                                {
                                    nextmove = PossibleCustomers[0];
                                }
                            }
                        }

                        if (nextmove == 0)
                        {
                            load = 0;
                            tour[trip + 1] = nextmove;

                        }
                        else
                        {

                            load = load + demand[nextmove];

                            tour[trip + 1] = nextmove;
                            Unvisited.Remove(tour[trip + 1]);
                        }


                            t[c, tour[trip + 1]] = Math.Max(t[c, tour[trip + 1]] * (1 - x) + x * t0, tmin);
                    }

                   

                    Length = 0;
                    for (int i = 0; i < tour.Length - 1; i++)
                        Length = Length + CustomersDistance[tour[i], tour[i + 1]];

                    if (Length < LengthIteration) {
                        touriteration = tour;
                        LengthIteration = Length;

                    }

                }



                List<int> custofveh = new List<int>();
                List<int> capofveh = new List<int>();
                int custuntilnow = 0;
                int capuntilnow = 0;
                

                for (int i = 1; i < touriteration.Length; i++)
                {

                    
                    if (touriteration[i] == 0)
                    {
                        custofveh.Add(custuntilnow);
                        capofveh.Add(capuntilnow);
                        capuntilnow = 0;
                        custuntilnow = 0;
                    }
                    else
                    {
                        custuntilnow += 1;
                        capuntilnow = capuntilnow + demand[touriteration[i]];
                    }
                    
                    
                }


                List<List<int>> vehicletours = new List<List<int>>();
                int veh = 0;
                vehicletours.Add(new List<int>());
                vehicletours[0].Add(0);

                for (int i=1;i<touriteration.Length-1;i++)
                {
                    if (touriteration[i] == 0)
                    {
                        vehicletours[veh].Add(0);
                        veh += 1;
                        vehicletours.Add( new List<int>());
                        vehicletours[veh].Add(0);
                    }
                    else
                    {
                        vehicletours[veh].Add(touriteration[i]);
                    }
                }
                vehicletours[vehiclesrequired-1].Add(0);

                List<int> LoadofVeh = new List<int>();
                for(int i = 0; i < vehiclesrequired; i++)
                {
                    int loadofvehicle = 0;
                    for(int j = 0; j < vehicletours[i].Count; j++)
                    {
                        loadofvehicle = loadofvehicle + demand[vehicletours[i][j]];
                    }
                    LoadofVeh.Add(loadofvehicle);
                }

                
                double Templength =Math.Pow(BestLength,10);
                bool foundswap = true;
                int tries = 0;

                do
                {

                    foundswap = false;
                    tries += 1;


                    int tour1;
                    int tour2;
                    do
                    {
                        tour1 = RandomNumber.Between(0, vehiclesrequired - 1);
                        tour2 = RandomNumber.Between(0, vehiclesrequired - 1);
                    } while (tour1 == tour2);


                    List<int> fromtour = new List<int>();
                    List<int> totour = new List<int>();

                    for(int i=0;i<vehicletours[tour1].Count;i++)
                    {
                        int temp = vehicletours[tour1][i];
                        fromtour.Add(temp);
                    }
                    for (int i = 0; i < vehicletours[tour2].Count; i++)
                    {
                        int temp = vehicletours[tour2][i];
                        totour.Add(temp);
                    }

                    double lengthtour1 = 0;
                    double lengthtour2 = 0;

                    for (int v = 0; v < fromtour.Count - 1; v++)
                    {
                        lengthtour1 = lengthtour1 + CustomersDistance[fromtour[v], fromtour[v + 1]];
                    }
                    for (int v = 0; v < totour.Count - 1; v++)
                    {
                        lengthtour2 = lengthtour2 + CustomersDistance[totour[v], totour[v + 1]];
                    }

                    for (int j = 1; j < vehicletours[tour1].Count-1; j++)
                    {
                        for (int l = 1; l < vehicletours[tour2].Count-1; l++)
                        {

                            if (LoadofVeh[tour2] - demand[totour[l]] + demand[fromtour[j]] <= Capacity && LoadofVeh[tour1] + demand[totour[l]] - demand[fromtour[j]] <= Capacity)
                            {
                                int temp = fromtour[j];
                                fromtour[j]= totour[l];
                                totour[l]=temp;

                                double newlengthtour1 = 0;
                                double newlengthtour2 = 0;

                                for (int v = 0; v < fromtour.Count - 1; v++)
                                {
                                    newlengthtour1 = newlengthtour1 + CustomersDistance[fromtour[v], fromtour[v + 1]];
                                }
                                for (int v = 0; v < totour.Count - 1; v++)
                                {
                                    newlengthtour2 = newlengthtour2 + CustomersDistance[totour[v], totour[v + 1]];
                                }

                                if (newlengthtour1 < lengthtour1 && newlengthtour2 < lengthtour2)
                                {
                                    List<int> temptour1 = new List<int>(fromtour);
                                    List<int> temptour2 = new List<int>(totour);
                                    vehicletours[tour1]= temptour1;
                                    vehicletours[tour2] = temptour2;

                                    LoadofVeh.Clear();

                                    for (int v = 0; v < vehiclesrequired; v++)
                                    {
                                        int loadofvehicle = 0;
                                        for (int z = 0; z < vehicletours[v].Count; z++)
                                        {
                                            loadofvehicle = loadofvehicle + demand[vehicletours[v][z]];
                                        }
                                        LoadofVeh.Add(loadofvehicle);
                                    }

                                    foundswap = true;
                                    tries = 0;

                                }

                                fromtour.Clear();
                                totour.Clear();

                                for (int i = 0; i < vehicletours[tour1].Count; i++)
                                {
                                    int temp2 = vehicletours[tour1][i];
                                    fromtour.Add(temp2);
                                }
                                for (int i = 0; i < vehicletours[tour2].Count; i++)
                                {
                                    int temp2 = vehicletours[tour2][i];
                                    totour.Add(temp2);
                                }

                            }

                            if (foundswap == true)
                            {
                                break;
                            }

                        }
                        if (foundswap == true)
                        {
                            break;
                        }
                    }


                } while (foundswap == true || tries<vehiclesrequired);


                LoadofVeh.Clear();

                for (int v = 0; v < vehiclesrequired; v++)
                {
                    int loadofvehicle = 0;
                    for (int z = 0; z < vehicletours[v].Count; z++)
                    {
                        loadofvehicle = loadofvehicle + demand[vehicletours[v][z]];
                    }
                    LoadofVeh.Add(loadofvehicle);
                }

                
                int counttrip = 0;
                for(int i = 0; i < vehiclesrequired; i++)
                {
                    touriteration[counttrip] = 0;
                    counttrip += 1;
                    for (int j = 1; j < vehicletours[i].Count-1; j++)
                    {
                        touriteration[counttrip] = vehicletours[i][j];

                            counttrip += 1;
                        
                        
                    }
                }
                LengthIteration = 0;

                for(int i = 0; i < touriteration.Length - 1; i++)
                {
                    LengthIteration = LengthIteration + CustomersDistance[touriteration[i],touriteration[i+1]];
                }



                int improve = 0;
                while (improve <= 500) {
                    double NewDistance = 0;
                    for (int i = 0; i < touriteration.Length - 1; i++)
                        NewDistance = NewDistance + CustomersDistance[touriteration[i], touriteration[i + 1]];
                    for (int i = 1; i < touriteration.Length - 2; i++)
                    {
                        if (touriteration[i] == 0)
                        {
                            continue;
                        }
                        for (int v = i + 1; v < touriteration.Length - 1; v++)
                        {
                            if (touriteration[v] == 0)
                                break;
                            int[] newroute = TwoOptSwap.OptSwap(touriteration, i, v);

                            double NewLength = 0;
                            for (int l = 0; l < touriteration.Length - 1; l++)
                                NewLength += CustomersDistance[newroute[l], newroute[l + 1]];

                            if (NewLength < NewDistance)
                            {
                                touriteration = newroute;
                                NewDistance = NewLength;
                                v = touriteration.Length - 1;
                                i = touriteration.Length - 2;
                                improve = 0;
                            }
                            else
                            {
                                improve++;
                            }


                        }
                    }

                }
                
                LengthIteration = 0;
                for (int i = 0; i < touriteration.Length - 1; i++)
                    LengthIteration = LengthIteration + CustomersDistance[touriteration[i], touriteration[i + 1]];

                if (LengthIteration < BestLength) {
                    BestLength = LengthIteration;
                    BestTour = touriteration;

                }

                if(activeLength>LengthIteration)
                {
                    activesolution = touriteration;
                    activeLength = LengthIteration;
                }
                else
                {
                    double C = (LengthIteration - activeLength);
                    
                    if(RandomNumber.DoubleBetween(0, 1)<Math.Exp(-C/Temperature))
                    {
                        activesolution = touriteration;
                        activeLength = LengthIteration;
                    }
                }

                Temperature = Temperature * 0.999;


                for (int i = 0; i < t.GetLength(0); i++)
                    for (int j = 0; j < t.GetLength(1); j++)
                        t[i, j] = Math.Max(t[i, j] * (1 - t[i,j]/(tmin+tmax)), tmin);


                tmax = (1 / ( (1 - r))) * (1 / BestLength);
                tmin = tmax * (1 - Math.Pow(0.05, 1 / SizeCustomers)) / ((SizeCustomers / 2 - 1) * Math.Pow(0.05, 1 / SizeCustomers));

                chart1.Series["Trip"].Points.Clear();

                for (int i = 0; i < activesolution.Length - 1; i++)
                   t[activesolution[i], activesolution[i + 1]] = Math.Min(t[activesolution[i], activesolution[i + 1]] + (t[activesolution[i], activesolution[i + 1]] /(tmax+tmin)) * (1 / activeLength), tmax);

                for (int i = 0; i < BestTour.Length; i++)
                    chart1.Series["Trip"].Points.AddXY(Customers[BestTour[i], 1], Customers[BestTour[i], 2]);

                results[Iteration] = BestLength;
                Iteration = Iteration + 1;

                pb_calculated.Text = "Current progress... " + ((100 * Iteration) / NumItsMax) + "%\nIterations occured: " + Iteration + "/" + NumItsMax;
                pb.PerformStep();
                Application.DoEvents();
            }

            pb_calculated.Text = "Calculation completed... " + ((100 * Iteration) / NumItsMax) + "%\nIterations occured: " + Iteration + "/" + NumItsMax;
            calc_stop_BTN.Enabled = false;
            ACS.Enabled = true;

            double minimum;
            minimum = Customers[BestTour[0], 2];
            for (int i = 1; i < BestTour.Length; i++) {
                if (minimum > Customers[BestTour[i], 2]) {
                    minimum = Customers[BestTour[i], 2];
                }
                chart1.Series["Trip"].Points.AddXY(Customers[BestTour[i], 1], Customers[BestTour[i], 2]);

            }
            tb_length.Text = Convert.ToString(BestLength);
            Application.DoEvents();
            if ((BestTour.Length - vehiclesrequired) != BestTour.Distinct().Count()) {
                tb_error.Text = Convert.ToString("Dublicates found");
            } else {
                tb_error.Text = Convert.ToString("No Error found");
            }

        }
        private double[,] ReadFile(string filename) {
            double[,] _Customers;

            //handle raw files from TCS website
            bool wasRAW = false;
            StreamReader _tmpReader = new StreamReader(filename);
            string filenameRAW = filename.Remove(filename.Length - 4) + "_fromRAW.txt"; //-4 to remove .txt extension
            if (_tmpReader.ReadLine().Contains("NAME :")) { // check if the file format is same as TCS website
                MessageBox.Show("RAW file selected...");
                wasRAW = true;
                StreamWriter _writer = new StreamWriter(filenameRAW);
                string curLine = _tmpReader.ReadLine();
                while (curLine[0] != '1')
                    curLine = _tmpReader.ReadLine();
                //start editing ,only when you reach the first coords
                do {

                    string newString = curLine.Remove(0, curLine.IndexOf(' ') + 1);
                    newString = newString.Replace(' ', ',');
                    _writer.WriteLine(newString);
                    curLine = _tmpReader.ReadLine();
                    if (curLine.Contains("EOF") || curLine == "" || curLine.Contains('\0')) {
                        break;
                    }
                } while (!_tmpReader.EndOfStream);
                _writer.Close();
                _tmpReader.Close();
                var lines = File.ReadAllLines(filenameRAW);
                File.WriteAllLines(filenameRAW, lines.Take(lines.Length));

            }
            //end of handling

            StreamReader streamReader;
            if (wasRAW)
                streamReader = new StreamReader(filenameRAW);
            else
                streamReader = new StreamReader(filename);

            int SizeCustomers = 0;
            do {
                if (streamReader.ReadLine() != "")
                    SizeCustomers++;
            } while (!streamReader.EndOfStream);

            streamReader.Close();

            _Customers = new double[SizeCustomers, 3];
            char delim = ',';

            string[] _line;
            string _line1;
            int k1 = 0;
            double mymin = 1000000000000000000;

            if (wasRAW)
                streamReader = new StreamReader(filenameRAW);
            else
                streamReader = new StreamReader(filename);
            do {
                _line1 = streamReader.ReadLine();
                if (_line1 != "") {
                    _line = _line1.Split(delim);
                    _Customers[k1, 0] = k1;
                    _Customers[k1, 1] = Convert.ToDouble(_line[0]);
                    _Customers[k1, 2] = Convert.ToDouble(_line[1]);
                    chart1.Series["Customers"].Points.AddXY(_Customers[k1, 1], _Customers[k1, 2]);
                    if (_Customers[k1, 2] < mymin)
                        mymin = _Customers[k1, 2];
                    k1++;

                }
            } while (!streamReader.EndOfStream);

            streamReader.Close();
            //fills Customers Array with data from an external txt
            chart1.ChartAreas[0].AxisY.Minimum = mymin;


            return _Customers;
        }
        
        private void ACS_Click(object sender, EventArgs e) {

            string filename = "";
            if (File.Exists("_tmpMap.txt"))
                filename = "_tmpMap.txt";
            else {
                openFileDialog1.Filter = "Text Files(*.txt)|*.txt";
                if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                    filename = openFileDialog1.FileName;
                } else
                    return;
            }
            pb.Value = 0;
            pb.Maximum = Convert.ToInt32(NumIts.Value);
            stopped = false;

            pb.Visible = true;
            pb_calculated.Visible = true;
            calc_stop_BTN.Enabled = true;
            ACS.Enabled = false;
            tb_length.Text = "";
            
            chart1.Size = new Size(600, (pb.Location.Y + pb.Size.Height) - 25);
            Size = new Size((chart1.Location.X + chart1.Width + 25), pb.Location.Y + pb.Size.Height + 50);

            


            RunACS(ReadFile(filename));


        }
   
        private void Ants_Load(object sender, EventArgs e) {

            _width = Size.Width;
            _heigth = Size.Height;
            foreach (var leg in chart1.Legends)
                leg.Enabled = false;

            calc_stop_BTN.Enabled = false;

            pb.Location = new Point(label8.Location.X, label8.Location.Y + 100);
            pb.Size = new Size(new Point(200, 30));
            pb.Step = 1;
            pb.Visible = false;
            Controls.Add(pb);


            pb_calculated.Text = "Current progress...\nIterations occured: ";
            pb_calculated.Location = new Point(pb.Location.X, pb.Location.Y - pb_calculated.Height - 5);
            pb_calculated.AutoSize = true;
            pb_calculated.Visible = false;
            Controls.Add(pb_calculated);
            pb_calculated.BringToFront();

            openFileDialog1.FileName = "";

            int offset = gb_parameters.Left;
            Width = gb_parameters.Location.X + gb_parameters.Size.Width + offset+offset; // we need the LEFT offset and the RIGHT offset to be the same

        }
        private void calc_stop_BTN_Click(object sender, EventArgs e) {
            var result = MessageBox.Show("Stop the calculations?",
                "Stop requested.",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.No)
                return;
            else {
                stopped = true;
                pb.ResetText();
                Size = new Size(_width, _heigth);
                ACS.Enabled = true;
                calc_stop_BTN.Enabled = false;
                foreach (var series in chart1.Series) {
                    series.Points.Clear();
                }
            }
        }

        private void ACSAlgorithm_FormClosing(object sender, FormClosingEventArgs e) {
            if (File.Exists("_tmpMap.txt"))
                File.Delete("_tmpMap.txt");
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
