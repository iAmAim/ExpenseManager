using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Xml;
using System.Xml.Linq;

namespace WindowsFormsApplication1
{
    public partial class EntryForm : Form
    {

        public EntryForm()
        {
              InitializeComponent();
            //SelectedRange.start.ToString()
          
            int year = monthCalendar1.SelectionRange.Start.Year;
            int day = monthCalendar1.SelectionRange.Start.Day;
            int month = monthCalendar1.SelectionRange.Start.Month;
        }

        /*   Constructor that invokes Edit Form    */
        public EntryForm(string[] data )
        {
               InitializeComponent();
               this.dateTextBox.Text = data[0];
               this.NameBox.Text = data[1];
               this.DescriptionBox.Text = data[2];
               this.PriceBox.Text = data[3];
        }

        private void SaveForm() { }


        private void PickDate(object sender, DateRangeEventArgs e)
        {
            this.dateTextBox.Text = monthCalendar1.SelectionRange.Start.ToString();
            this.monthCalendar1.Hide();    
        }

        private void ClickDateButton(object sender, EventArgs e)
        {       
            this.monthCalendar1.Show();
            this.monthCalendar1.Focus();
            //Console.WriteLine("monthcalendar1 is focused:{0}", this.monthCalendar1.ContainsFocus);
        }

       /* private void monthCalendar1_LostFocus(object sender, System.EventArgs e)
        {
            this.monthCalendar1.Hide();
        }
        */

        private void monthCalendar1_Leave(object sender, EventArgs e)
        {
            this.monthCalendar1.Hide();
        }

        public void SaveButtonClick(object sender, EventArgs e)
        {
            /* This should be handled by Validating?? not sure why Price is not validated
             when save button is clicked.*/
            if (ValidateName() && ValidatePrice())
            {
                string date = dateTextBox.Text;
                string name = NameBox.Text;
                string price = PriceBox.Text;
                string description = DescriptionBox.Text;

                XDocument doc = MainForm.xdata;
                if (!MainForm.isEdit)
                {                 
                    MainForm.currentProductId++;
                    string currentIndex = MainForm.currentProductId.ToString();

                    XElement Product = new XElement("Product", new XAttribute("id", currentIndex),
                        new XElement("Date", date),
                        new XElement("Name", name),
                        new XElement("Description", description),
                        new XElement("Price", price)
                        );
                    doc.Root.Add(Product);

                }
                else
                {
                    /*Enter edit code here*/
                    EditNodeAndSave(date, name, description, price);

                }

                doc.Save(MainForm.xmlFile);
                
                MainForm.DisplayData(MainForm.xmlFile);
                this.Close();
            }
            else
            {
                MessageBox.Show("Please complete the field(s) with errors.");
            }
            
        }


        private void EditNodeAndSave(string date,string name,string description,string price)
        {

            var prices = from p in MainForm.xdata.Descendants("Product")
                         where p.Attribute("id").Value == MainForm.data[4]
                         select p;
                              foreach(XElement elem in prices){
                                  elem.Element("Date").SetValue(date);
                                  elem.Element("Name").SetValue(name);
                                  elem.Element("Description").SetValue(description);
                                  elem.Element("Price").SetValue(price);
                              }   
        }

        //*vvvvvvvvvvvvvvvvvvvvvvvvvvvvvvv Input Validation Methods vvvvvvvvvvvvvvvvvvvvvvvvvvvvv*//

        private void Name_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
           
            ValidateName();
                
        }
            private bool ValidateName()
            {
                bool bStatus = true;
                if (NameBox.Text == "")
                {
                    NameErrorProvider.SetError(NameBox, "Please enter Item Name to Continue");
                    NameValidation.Text = NameErrorProvider.GetError(NameBox); 
                    bStatus = false;
                }
                else
                {
                    NameErrorProvider.SetError(NameBox, "");
                    this.NameValidation.Text = "";
                }
                return bStatus;
            }

          private void Price_Validating(object sender, System.ComponentModel.CancelEventArgs e)
          {
              ValidatePrice();
          }
            private bool ValidatePrice()
            {
                bool bStatus = true;
                if (PriceBox.Text == "")
                {
                    PriceErrorProvider.SetError(PriceBox, "Please enter Price to continue.");
                    PriceValidation.Text = PriceErrorProvider.GetError(PriceBox);                  
                    bStatus = false;
                }
                else
                {
                    PriceErrorProvider.SetError(PriceBox, "");
                    double num;
                    if (!Double.TryParse(PriceBox.Text, out  num))
                    {
                        PriceErrorProvider.SetError(PriceBox, "Please enter Price as a number");
                        PriceValidation.Text = PriceErrorProvider.GetError(PriceBox);
                        bStatus = false;
                    }
                    else
                    {
                        double temp = Convert.ToDouble(PriceBox.Text);
                        PriceErrorProvider.SetError(PriceBox, "");
                        this.PriceValidation.Text = "";
                    }
                }

                return bStatus;
            }


            private void AddForm_Load(object sender, EventArgs e)
            {

                this.DateButton.Select();
                this.DateButton.Focus();             
            }

            private void NameBox_TextChanged(object sender, EventArgs e)
            {

            }

            private void NameBox_Validated(object sender, EventArgs e)
            {
                this.NameErrorProvider.SetError(this.NameBox,string.Empty);
            }

            private void PriceBox_Validated(object sender, EventArgs e)
            {
                this.NameErrorProvider.SetError(this.PriceBox, string.Empty);
            }

        

        //*^^^^^^^^^^^^^^^^^^^^^^^^^^^ Input Validation Methods ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^*//
     
    }




}

