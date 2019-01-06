using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;




namespace CurrTracker
{
    public partial class MainWindow : Form
    {
        //common fields
        //expose them so that they may be used
        public static Dictionary<string, string> currencyDictionary = GuiElements.LoadCurrencyCombo(); //the definitions
        public static CurrencyModel currModel;  //actual ex rates pair
        public static string relativeDir = System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        public static string fileName = "data.txt";
        public static string correctPath = Path.Combine(relativeDir, fileName);
        

        public MainWindow()
        {
            InitializeComponent();
            ApiHelper.InitializeClient(); //this allows us to make calls to the internet, like a browser but for the app
            
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            PopulateCurrencyCombo();


            if (File.Exists(correctPath) && ReadFromFileToCurrModel())
            {

                if (UpdateOrNot())
                {
                    currModel = null;
                    await StartUpRefreshRates();
                }
                else
                {
                    //nothing, load from file
                }
            }
            else
            {
                currModel = null;
                await StartUpRefreshRates();
            }

            //default loads
            exRateBox.Text = "1";

            //await StartUpRefreshRates();
            this.FormClosing += this.Form1_FormClosing; //**subscribe; i.e. run Form1_Formclosing on closing the form https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.form.formclosing?redirectedfrom=MSDN&view=netframework-4.7.2
            // https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/events/how-to-subscribe-to-and-unsubscribe-from-events
        }

        private void PopulateCurrencyCombo()
        {
            CurrencyDrop.Items.Clear();

            foreach (KeyValuePair<string, string> entry in currencyDictionary)
            {
                //CurrencyDrop.Items.Add(entry.Value);

                CurrencyDrop.Items.Add(entry.Key.Substring(3, 3) + " " + entry.Value);
            }

        }
        private void CurrencyDrop_SelectedIndexChanged(object sender, EventArgs e)
        {
            string myKey = "";
            string searchText = ("USD" + CurrencyDrop.SelectedItem.ToString().Substring(0, 3));
            if (currencyDictionary.TryGetValue(searchText, out myKey))
            {
                label3.Text = CurrencyDrop.SelectedItem.ToString().Substring(0, 3);
                label4.Text = CurrencyDrop.SelectedItem.ToString().Substring(0, 3);
            }

            //var myKey = currencyDictionary.FirstOrDefault(entry => entry.Value == CurrencyDrop.SelectedItem.ToString()).Key;
            // the above lambda is find the first entry within the dict that matches the dropdown, and return that key, if 
            // if not return default (which i set to nil)
            //CurrencyDrop.SelectedItem.ToString() because without ToString it is just an object
            pairBox.Text = myKey;
            exRateBox.Text = currModel.Quotes[searchText].ToString(); //ToString to conver the double to string

            //calculate values
            calcUsdInValues();
            calcInputValues();
        }

        public async Task StartUpRefreshRates()
        {
            currModel = await CurrProcessor.UpdateCurrency(); 

        }

        private void usdinValues_TextChanged(object sender, EventArgs e)
        {
           
            if (CorrectInput(usdinValues))
            {
                calcUsdInValues();
            }
        }

        private void calcUsdInValues()
        {
            var calc = decimal.Parse(usdinValues.Text) * decimal.Parse(exRateBox.Text);
            outputValues.Text = calc.ToString("#,##0.00");

        }


        private void inputValues_TextChanged(object sender, EventArgs e)
        {
           
            if (CorrectInput(inputValues))
            {
                calcInputValues();
            }
        }

        private void calcInputValues()
        {
            var calc = decimal.Parse(inputValues.Text) / decimal.Parse(exRateBox.Text);
            usdoutValues.Text = calc.ToString("#,##0.00");

        }



        private static bool CorrectInput(TextBox userInput)
        { 
            if (decimal.TryParse(userInput.Text, out decimal dec))
            {
                return true;
            }
            else
            {
                userInput.Text = "0";
                return false;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //run on form close
            WriteStateIntoFile();

            const string message =
                "Are you sure that you would like to close the form?";
            const string caption = "Form Closing";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            // If the no button was pressed ...
            if (result == DialogResult.No)
            {
                // cancel the closure of the form.
                e.Cancel = true;
            }
        }


        private static bool UpdateOrNot()
        {
            // First make a System.DateTime equivalent to the UNIX Epoch which starts in 1970.  
            // https://social.technet.microsoft.com/wiki/contents/articles/22173.convert-datetime-received-in-json-to-a-net-datetime.aspx
            System.DateTime newTime = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
            int lastDateYear = newTime.AddMilliseconds(currModel.Timestamp).ToLocalTime().Year; 
            int lastDateMonth = newTime.AddMilliseconds(currModel.Timestamp).ToLocalTime().Month; 
            int lastDateDay = newTime.AddMilliseconds(currModel.Timestamp).ToLocalTime().Day;

            int todayDateYear = newTime.AddMilliseconds(DateTimeOffset.UtcNow.ToUnixTimeMilliseconds()).ToLocalTime().Year;
            int todayDateMonth = newTime.AddMilliseconds(DateTimeOffset.UtcNow.ToUnixTimeMilliseconds()).ToLocalTime().Month;
            int todayDateDay = newTime.AddMilliseconds(DateTimeOffset.UtcNow.ToUnixTimeMilliseconds()).ToLocalTime().Day;

            if (todayDateYear == lastDateYear)
            {
                if (todayDateMonth == lastDateMonth)
                {
                    if (todayDateDay == lastDateDay)
                    { 
                        return false; // no need refresh
                    }
                    else
                    {
                        return true;
                    }
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return true;
            }
        }

        public static void WriteStateIntoFile()
        {

            if (!File.Exists(correctPath)) //if file doesn't exist
            {
                File.WriteAllText(correctPath, JsonConvert.SerializeObject(currModel));
            }
            else
            {
                File.WriteAllText(correctPath, JsonConvert.SerializeObject(currModel));
            }
        }

        public static bool ReadFromFileToCurrModel()
        {
            //https://stackoverflow.com/questions/38179819/read-json-data-from-text-file-c-sharp
            //https://stackoverflow.com/questions/31774795/deserialize-json-from-file-in-c-sharp
            currModel = JsonConvert.DeserializeObject<CurrencyModel>(File.ReadAllText(correctPath));
            if (currModel == null)
            {
                return false;
            }
            else
            {
                return true;
            }

        }


        private void exRateBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
