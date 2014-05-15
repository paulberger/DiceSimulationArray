//Paul Berger Week 3 Individual Assignment

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Dice_Simulation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //declare an array
            int[] ResultsArray;

        //Event handler for exit button
        private void btnExit_Click(object sender, EventArgs e)
        {
            //closes the program
            this.Close();
        }

        
        //Event handler for the write button
        private void btnWrite_Click(object sender, EventArgs e)
        {

                //add total to the results file
                try
                {
                    // Declare an output variable
                    StreamWriter outputResults;

                    // open the file to store to
                    outputResults = File.CreateText("Results.txt");
            
                    //declare a counter to iterate 100 times
                    int count = 0;

                    //create a random number generator
                    Random randomNumber = new Random();
                    
                    while (count <= 99)
                    {
                                               
                        
                
                        //declare variables and pick random die values and total
                        int Face1 = randomNumber.Next(6) + 1;
                        int Face2 = randomNumber.Next(6) + 1;

                        //Display the value of each die in the associated label display
                        lbxDie1.Text = Face1.ToString();
                        lbxDie2.Text = Face2.ToString();

                        //declare variable and add the dice together
                        int dieTotal = Face1 + Face2;

                        //display the total in the label display
                        lbxTotal.Text = dieTotal.ToString();

                        // write to the file
                        outputResults.WriteLine(dieTotal.ToString());

                        //advance the counter
                        count = count + 1;
                    
                    }
                    //close the file
                    outputResults.Close();
                }
                catch (Exception ex) //for any errors writing to the file
                {
                    MessageBox.Show(ex.Message);
                }       

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            rtbxResults.Clear();
            rtbxFrequency.Clear();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            //clear the results box
            rtbxResults.Clear();
            
            //create an array object
            ResultsArray = new int[100];
            
            //try block to verify the file exists
            try
            {
                //declare a variable to hold the dice total
                string resultTotal;

                //delare a stream reader variable
                StreamReader inputResults;

                //open the file
                inputResults = File.OpenText("Results.txt");

                //clear the results list box
                rtbxResults.Clear();

                //declare a counter
                int addIndex = 0;
                
                //read the contents of the results file and write to the array
                while (addIndex < 100 && !inputResults.EndOfStream)
                {
                    //get the entries
                    resultTotal = inputResults.ReadLine();

                    //add the elements to the array
                    ResultsArray[addIndex] = int.Parse(resultTotal);
                    
                    //increase index
                    addIndex ++;
                    
                }

                //close the file
                inputResults.Close();

                //display the elements of the array in the results box
                foreach (int value in ResultsArray)
                {
                    rtbxResults.AppendText(value.ToString() + "\r");
                }

            }
            catch (Exception ex)
            {
                //display an error message
                MessageBox.Show(ex.Message);
            }
        }

        private void btnFrequency_Click(object sender, EventArgs e)
        {
             
            //clear the frequency box
            rtbxFrequency.Clear();
            
            //declare variables
            int twos = 0, threes = 0, fours = 0, fives = 0, sixes = 0, sevens = 0, eights = 0, nines = 0, tens = 0, elevens = 0, twelves = 0;

            //read from the array
            for (int index = 0; index < 100; index ++)
            {
                //declare a holder for the array index element
                int indexValue = ResultsArray[index];

                //determine frequencies
                if (indexValue == 2)
                {
                    twos = twos + 1;
                }

                else
                {
                    if (indexValue == 3)
                    {
                        threes = threes + 1;
                    }

                    else
                    {
                        if (indexValue == 4)
                        {
                            fours = fours + 1;
                        }

                        else
                        {
                            if (indexValue == 5)
                            {
                                fives = fives + 1;
                            }

                            else
                            {
                                if (indexValue == 6)
                                {
                                    sixes = sixes + 1;
                                }

                                else
                                {
                                    if (indexValue == 7)
                                    {
                                        sevens = sevens + 1;
                                    }

                                    else
                                    {
                                        if (indexValue == 8)
                                        {
                                            eights = eights + 1;
                                        }

                                        else
                                        {
                                            if (indexValue == 9)
                                            {
                                                nines = nines + 1;
                                            }

                                            else
                                            {
                                                if (indexValue == 10)
                                                {
                                                    tens = tens + 1;
                                                }
                                                else
                                                {
                                                    if (indexValue == 11)
                                                    {
                                                        elevens = elevens + 1;
                                                    }

                                                    else
                                                    {
                                                        twelves = twelves + 1;

                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
                
            //write elements to frequency box
                rtbxFrequency.AppendText(twos.ToString() + " Twos rolled." + "\r");
                rtbxFrequency.AppendText(threes.ToString() + " Threes rolled." + "\r");
                rtbxFrequency.AppendText(fours.ToString() + " Fours rolled." + "\r");
                rtbxFrequency.AppendText(fives.ToString() + " Fives rolled." + "\r");
                rtbxFrequency.AppendText(sixes.ToString() + " Sixes rolled." + "\r");
                rtbxFrequency.AppendText(sevens.ToString() + " Sevens rolled." + "\r");
                rtbxFrequency.AppendText(eights.ToString() + " Eights rolled." + "\r");
                rtbxFrequency.AppendText(nines.ToString() + " Nines rolled." + "\r");
                rtbxFrequency.AppendText(tens.ToString() + " Tens rolled." + "\r");
                rtbxFrequency.AppendText(elevens.ToString() + " Elevens rolled." + "\r");
                rtbxFrequency.AppendText(twelves.ToString() + " Twelves rolled." + "\r");
                
            
        }
    }
}
