﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars.Navigation;
using icerberg;
using DevExpress.Xpo;
using DevExpress.XtraBars.Docking2010.Views;


namespace icerberg
{
    public partial class Main : DevExpress.XtraBars.Ribbon.RibbonForm
    {

        public Main()
        {
            InitializeComponent();
        }

        private void btn_NewEmployee_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        { 
            //DataConnection dc = new DataConnection();
            //NavigationPage emp_masterlistpage = new NavigationPage();
            //navigationFrame.Controls.Add(emp_masterlistpage);
            //navigationFrame.Pages.Add(emp_masterlistpage);
            //xUC_EmployeeMasterlist emplist = new xUC_EmployeeMasterlist();
            //emplist.Dock = DockStyle.Fill;
            //emp_masterlistpage.Controls.Add(emplist);
            //navigationFrame.SelectedPage = emp_masterlistpage;

        }
        static string ConvertStringArrayToString(string[] array)
        {
            // Concatenate all the elements into a StringBuilder.
            StringBuilder builder = new StringBuilder();
            foreach (string value in array)
            {
                builder.Append(value);
                builder.Append('.');
            }
            return builder.ToString();
        }

        private void btn_ServerConnection_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            foreach (BaseDocument bsDc in tabbedView1.Documents)
            {
                if (bsDc.Control.Name == "ServerSettingsPage")
                {
                    tabbedView1.Controller.Activate(bsDc);
                    return;
                }
            }
            var nwDc = tabbedView1.AddDocument(new xUC_ServerSettings());
            nwDc.Control.Name = "ServerSettingsPage";
            nwDc.Caption = "ServerSettingsPage";
            tabbedView1.Controller.Activate(nwDc);



            //if (tabbedView1.Documents.Count() == 0)
            //{
            //    xUC_ServerSettings ServerSettingsPage = new xUC_ServerSettings();
            //    ServerSettingsPage.Name = "ServerSettingsPage";
            //    tabbedView1.AddDocument(ServerSettingsPage);
            //    tabbedView1.ActivateDocument(ServerSettingsPage);
            //    tabbedView1.ActiveDocument.Caption = "Server Settings ";
            //    MessageBox.Show(tabbedView1.Documents.Count.ToString());
            //}
            //else
            //{
            //    XtraUserControl doc = tabbedView1.Documents.OfType<XtraUserControl>().First(d => d.ControlName.ToString() == "ServerSettingsPage");

            //    if (doc != null)
            //    {
            //        tabbedView1.ActivateDocument(doc);
            //    }
            //    else
            //    {
            //        xUC_ServerSettings ServerSettingsPage = new xUC_ServerSettings();
            //        ServerSettingsPage.Name = "ServerSettingsPage";
            //        tabbedView1.AddDocument(ServerSettingsPage);
            //        tabbedView1.ActivateDocument(ServerSettingsPage);
            //        tabbedView1.ActiveDocument.Caption = "Server Settings ";
            //        MessageBox.Show(tabbedView1.Documents.Count.ToString());

            //    }
            //}


            //MessageBox.Show(tabbedView1.ActiveDocument.Control.Name.ToString());
            

        }

        private void tabbedView1_DocumentActivated(object sender, DevExpress.XtraBars.Docking2010.Views.DocumentEventArgs e)
        {
            
        }

        private void tabbedView1_DocumentAdded(object sender, DevExpress.XtraBars.Docking2010.Views.DocumentEventArgs e)
        {
           
        }

        private void btn_list_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            foreach (BaseDocument bsDc in tabbedView1.Documents)
            {
                if (bsDc.Control.Name == "EmployeeList")
                {
                    tabbedView1.Controller.Activate(bsDc);
                    return;
                }
            }
            var nwDc = tabbedView1.AddDocument(new xUC_EmployeeList());
            nwDc.Control.Name = "EmployeeList";
            nwDc.Caption = "EmployeeList";
            tabbedView1.Controller.Activate(nwDc);
        }
    }
}