using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assesment_1_github
{
    public partial class CONVERTER : Form
    {
        public CONVERTER()
        {
            InitializeComponent();
        }
        double converter_result;
        //arry to stor the results for the covertion 
        double[] results = new double[4];
     
        //Centmeter to 
        private void CMtoIN_Button_Click(object sender, EventArgs e)
        {
            const double CMtoIN = 0.3937;
            
            if (! double.TryParse(CEtoIN_Input.Text, out converter_result))
            {   //
                MessageBox.Show("Please enter a valid number");
                // gets rid of anything in the input
                CEtoIN_Input.Clear();
                CEtoIN_Input.Focus();
                // gets rid of anything in the output
                CEtoIN_Ouput.Clear();

            }
             else
            {
                // doing the maths for the conversion
                converter_result = CMtoIN * double.Parse(CEtoIN_Input.Text);
                //printing the result ouit for the user
                CEtoIN_Ouput.Text = converter_result.ToString();
                // storing the result of the conversion in an arry
                results[0] = converter_result;
                
               
            }

        }
        //
        private void CNtoFE_Button_Click(object sender, EventArgs e)
        {   // variable used to calculate the conversion
            double CEtoFE = 0.0328;

            if (!double.TryParse(CEtoFE_Input.Text, out converter_result))
            {   // desplays Message to the user leting them know they have tryed to brake my app!!
                MessageBox.Show("Please enter a valid number");
                // gets rid of anything in the input
                CEtoFE_Input.Clear();
                CEtoFE_Input.Focus();
                // gets rid of anything in the output
                CEtoFE_Output.Clear();

            }
            else
            {    // doing the maths for the conversion
                converter_result = CEtoFE * double.Parse(CEtoFE_Input.Text);
                //printing the result ouit for the user
                CEtoFE_Output.Text = converter_result.ToString();
                // storing the result of the conversion in an arry
                results[1] = converter_result;
            }

        }
        //
        private void CltoFahbutton_Click(object sender, EventArgs e)
        {  // variable used to calculate the conversion
            double CELtoFA = 1.8 ;
             
            if (!double.TryParse(CELtoFA_Input.Text, out converter_result))
            { // desplays Message to the user leting them know they have tryed to brake my app!!
                MessageBox.Show("Please enter a valid number");
                // gets rid of anything in the input
                CELtoFA_Input.Clear();
                CELtoFA_Input.Focus();
                // gets rid of anything in the output
                CELtoFA_Output.Clear();

            }
            else
            {
                // doing the maths for the conversion
                converter_result = CELtoFA * double.Parse(CELtoFA_Input.Text) + 32;
                //printing the result ouit for the user
                CELtoFA_Output.Text = converter_result.ToString();
                // storing the result of the conversion in an arry
                results[2] = converter_result;
            }
        }
        //
        private void MEtoFE_Button_Click(object sender, EventArgs e)
        {
            // variable used to calculate the conversion
            double MEtoFE = 3.2808;
            if (!double.TryParse(MEtoFE_Input.Text, out converter_result))
            {  // desplays Message to the user leting them know they have tryed to brake my app!!
                MessageBox.Show("Please enter a valid number");
                MEtoFE_Input.Clear();
                MEtoFE_Input.Focus();
                // gets rid of anything in the output
                MEtoFE_Output.Clear();

            }
            else
            {
                // doing the maths for the conversion
                converter_result = MEtoFE * double.Parse(MEtoFE_Input.Text);
                //printing the result ouit for the user
                MEtoFE_Output.Text = converter_result.ToString();
                // storing the result of the conversion in an arry
                results[3] = converter_result;
            }

        }
        //
        private void KItoMI_Button_Click(object sender, EventArgs e)
        {
            // variable used to calculate the conversion
            double KItoMI = 0.6213 ;

            if (!double.TryParse(KItoMI_Input.Text, out converter_result))
            { // desplays Message to the user leting them know they have tryed to brake my app!!
                MessageBox.Show("Please enter a valid number");
                // gets rid of anything in the input
                KItoMI_Input.Clear();
                KItoMI_Input.Focus();
                // gets rid of anything in the output
                KItoMI_Output.Clear();

            }
            else
            {
                // doing the maths for the conversion
                converter_result = KItoMI * double.Parse(KItoMI_Input.Text);
                //printing the result ouit for the user
                KItoMI_Output.Text = converter_result.ToString();
                // storing the result of the conversion in an arry
                results[4] = converter_result;
            }
        }
        //  exits app when the exit button is pressed
        private void EXIT_PROGRAM_Click(object sender, EventArgs e)
        {
            // exits aplication 
            Application.Exit();
        }
    }
}
