using TriWeightProgram;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BachelorWishList;

namespace Wishlist
{

    public partial class MainForm : Form
    {
        private TrivetClass _currentTrivet = null;
        private DataClass _currentData = null;
        private CompanyClass _currentCompany = null;
        private int txtWishId_TextChanged;

        public MainForm()
        {
            InitializeComponent();

            LoadAllTrivets();
            LoadAllCompanies();
            LoadAllData();

            TCPClass TCP = new TCPClass();
            TCP.TCPConnection();
            //txtConnectionString.Text = SetUpClass._dbcon;


         // cbTemplateLanguage.Items.Clear();


         // cbSituation.Items.Clear();


         // cbLanguageCode.Items.Clear();


        }

        #region --- Compnay ---

        private void LoadAllCompanies()
        {
            twCompany.Nodes.Clear();
            List<CompanyClass> _company = CompanyClass.GetAllCompany();
            foreach (CompanyClass company in _company)
            {
                TreeNode tn = new TreeNode(company.CompanyName + "      (" + company.CompanyCount + ") ");
                tn.Tag = company;
                twCompany.Nodes.Add(tn);
            }
        }

        private void ResetCompany()
        {
            txtCompanyId.Text = "";
            txtCompanyName.Text = "";
            txtCompanySize.Text = "";
        }

        //New Button Company - Adds the ID for Company automatically
        private void btnNewCompany_Click(object sender, EventArgs e)
        {
            txtCompanyId.Text = Utils.GetNextId("Company").ToString();
        }

        //Save Company - Also updates the TreeNode and Resets the textboxes so you can't overwrite the newly made entity. Pop-up box with if it saved or not
        private void btnSaveCompany_Click(object sender, EventArgs e)
        {
            CompanyClass cc = new CompanyClass();
            cc.CompanyID = System.Convert.ToInt32(txtCompanyId.Text);
            cc.CompanyName = txtCompanyName.Text;
            cc.CompanyCount = System.Convert.ToInt32(txtCompanySize.Text);
            if (cc.SaveMe("") != true)
            {
                MessageBox.Show("Could not save");
                
            } else
            {
                MessageBox.Show("Company Saved");
                LoadAllCompanies();
                ResetCompany();
            }
            
        }

        private void btnDeleteCompany_Click(object sender, EventArgs e)
        {

        }

        /*   private void twFamily_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
           {
               twFamilyMembers.Nodes.Clear();
           }*/

        #endregion --- Company ---

        #region --- Trivet ---

        public void LoadAllTrivets()
        {
            twTrivet.Nodes.Clear();
            List<TrivetClass> _trivet = TrivetClass.GetAllTrivet();
            foreach (TrivetClass trivet in _trivet)
            {
                TreeNode tn = new TreeNode(trivet.TrivetName + "     (" + trivet.TrivetType + ")");
                tn.Tag = trivet;
                twTrivet.Nodes.Add(tn);
            }
        }

        private void ResetTrivet()
        {
            txtTrivetId.Text = "";
            txtTrivetName.Text = "";
            textTrivetCount.Text = "";
          //  txtUserPassword.Text = "";
          //  txtUserEMail.Text = "";
          //  cbUserFamily.SelectedIndex = -1;
          //  chkUserActive.Checked = true;
          //  chkUserIsFamilyAdmin.Checked = false;
          //  twUserAssociated.Nodes.Clear();
        }

        //Ne
        private void btnNewTrivet_Click(object sender, EventArgs e)
        {
            txtTrivetId.Text = Utils.GetNextId("Trivet").ToString();
        }

        //Save Trivet
        private void btnSaveTrivet_Click(object sender, EventArgs e)
        {
            TrivetClass tc = new TrivetClass();
            tc.TrivetID = System.Convert.ToInt32(txtTrivetId.Text);
            tc.TrivetName = txtTrivetName.Text;
            tc.TrivetType = System.Convert.ToInt32(textTrivetCount.Text);
            if (tc.SaveMe("") != true)
            {
                MessageBox.Show("Could not save");
            }
            else
            {
                MessageBox.Show("Trivet Saved");
                ResetTrivet();
                LoadAllTrivets();
            }
        }

        private void twUsers_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            CompanyClass uc =e.Node.Tag as CompanyClass;

            txtTrivetId.Text = uc.CompanyID.ToString();
            txtTrivetName.Text = uc.CompanyName;
            textTrivetCount.Text = uc.CompanyCount.ToString(); 

         //   twUserAssociated.Nodes.Clear();
        }

      /*  private void btnUserAddAssociated_Click(object sender, EventArgs e)
        {
            if (txtUserAssociated.Text != string.Empty)
            {
                CompanyClass uc = CompanyClass.GetCompanyByCompanyID(System.Convert.ToInt32(txtUserAssociated.Text));
                if (uc.CompanyID > -1)
                {
                    TreeNode tn = new TreeNode(uc.CompanyName);
                    tn.Tag = uc;
                    twUserAssociated.Nodes.Add(tn);
                    txtUserAssociated.Text = "";
                }
            }
        }

        private void btnUserRemoveAssociated_Click(object sender, EventArgs e)
        {
            if (twUserAssociated.SelectedNode != null)
                twUserAssociated.Nodes.Remove(twUserAssociated.SelectedNode);
        }*/

        #endregion --- Trivet ---

        #region --- Data ---

        //Combi af Trivet og Company

       /* private void cbWishUser_SelectedIndexChanged(object sender, EventArgs e)
        {            
            int id=Utils.ExtractRecord(cbWishUser.Text);
            _currentData = DataClass.GetDataByDataID(id);
            LoadAllData();
         //   ResetWish();
            
        }*/

        private void LoadAllData()
        {
            twDataItems.Nodes.Clear();
            List<DataClass> items = DataClass.GetAllData();
            foreach (DataClass dc in items)
            {
               TreeNode tn = new TreeNode(CompanyClass.GetCompanyNameByCompanyIDAsString(DataClass.GetCompanyIDFromDataIDAsString(dc.DataID)) + dc.DataWeight.ToString() + "g " + dc.DataTime);
               tn.Tag = dc;
               twDataItems.Nodes.Add(tn);

            }
        }

        private void LoadSomeData(String s)
        {
            twDataItems.Nodes.Clear();
            List<DataClass> items = DataClass.GetSomeData(CompanyClass.GetAllCompanyWithName(s));
            foreach (DataClass dc in items)
            {
                TreeNode tn = new TreeNode(CompanyClass.GetCompanyNameByCompanyIDAsString(DataClass.GetCompanyIDFromDataIDAsString(dc.DataID)) + dc.DataWeight.ToString() + "g " + dc.DataTime);
                tn.Tag = dc;
                twDataItems.Nodes.Add(tn);
            }
        }

        private void btnNewData_Click(object sender, EventArgs e)
        {
            txtDataId.Text = Utils.GetNextId("Data").ToString();
        }

        private void btnDataSave_click(object sender, EventArgs e)
        {
            DataClass dc = new DataClass();
            dc.DataID = System.Convert.ToInt32(txtDataId.Text);
            dc.TrivetID = System.Convert.ToInt32(textDataTrivetId.Text);
            dc.CompanyID = System.Convert.ToInt32(textBoxDataCompanyId.Text);
            dc.DataTime = System.Convert.ToDateTime(txtDataTime.Text);
            dc.DataWeight = System.Convert.ToInt32(txtDataWeight.Text);
            dc.DataState = System.Convert.ToInt32(txtDataState.Text);
            if (dc.SaveMe("") != true)
            {
                MessageBox.Show("Could not save");
            } else
            {
                MessageBox.Show("Data Saved");
                LoadAllData();
            }
        }

        //Not Used
        private void btnWishURL_Click(object sender, EventArgs e)
         {
             if (txtDataState.Text != string.Empty)
             {
                 BrowserForm bf = new BrowserForm(txtDataState.Text);
                 bf.ShowDialog();
             }            
         }

        private void buttonSearchData_Click(object sender, EventArgs e)
        {
            LoadSomeData(textBoxDataSearch.Text);
            labelShowCompanyName.Text = textBoxDataSearch.Text;
        }

        #endregion --- Data ---

        #region --- Merge Templates ---

        /*   private void ResetTemplate()
           {
               txtTemplateId.Text = "";
               txtTemplateName.Text = "";
               cbTemplateLanguage.SelectedIndex = -1;
               txtTemplateSubject.Text = "";
               rtbBody.Text = "";
               cbSituation.SelectedIndex = -1;
               chkTemplateActive.Checked = true;
           }*/

        //Ikke Brugt
        private void btnEventNew_Click_1(object sender, EventArgs e)
        {
        }

        private void cbWishUser_SelectedIndexChanged_1(object sender, EventArgs e)
        {
          /*  twUsers.Nodes.Clear();
            List<UserClass> _users = UserClass.GetAllUsers();
            foreach (UserClass user in _users)
            {
                TreeNode tn = new TreeNode(user.UserFirstName + " (" + user.UserEmail + ")");
                tn.Tag = user;
                twUsers.Nodes.Add(tn);
            }*/
        }

        private void twWishItems_AfterSelect(object sender, TreeViewEventArgs e)
        {
            twTrivet.Nodes.Clear();
            List<CompanyClass> _users = CompanyClass.GetAllCompany();
            foreach (CompanyClass user in _users)
            {
                TreeNode tn = new TreeNode(user.CompanyName);
                tn.Tag = user;
                twTrivet.Nodes.Add(tn);
            }
        }





        #endregion --- Merge Templates ---

    }
}
