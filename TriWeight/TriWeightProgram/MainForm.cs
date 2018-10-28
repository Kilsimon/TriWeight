using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        #region --- Trivet ---

        private void LoadAllTrivets()
        {
            twFamily.Nodes.Clear();
            //cbUserFamily.Items.Clear();
            //cbUserFamily.Items.Add("[-1] <None>");
            //cbWishFamily.Items.Clear();
            //cbEventFamily.Items.Clear();
            //cbResFamily.Items.Clear();
         //   cbConvFamily.Items.Clear();
        }

        private void ResetTrivet()
        {
            txtFamilyId.Text = "";
            txtFamilyName.Text = "";
            txtFamilyCreated.Text = "";
          //  chkFamilyActive.Checked = false;
          //  twFamilyMembers.Nodes.Clear();
          //  chkFamilyActive.Checked = true;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ResetTrivet();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            MessageBox.Show ("Problem saving Trivet");
        }

     /*   private void twFamily_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            twFamilyMembers.Nodes.Clear();
        }*/

        #endregion --- Trivet ---

        #region --- Company ---

        public void LoadAllCompanies()
        {
            twUsers.Nodes.Clear();
            List<CompanyClass> _company = CompanyClass.GetAllCompany();
            foreach (CompanyClass company in _company)
            {
                TreeNode tn = new TreeNode(company.CompanyName);
                tn.Tag = company;
                twUsers.Nodes.Add(tn);
            }
        }

        private void ResetUser()
        {
            txtUserId.Text = "";
            txtUserName.Text = "";
            textBox4.Text = "";
          //  txtUserPassword.Text = "";
          //  txtUserEMail.Text = "";
          //  cbUserFamily.SelectedIndex = -1;
          //  chkUserActive.Checked = true;
          //  chkUserIsFamilyAdmin.Checked = false;
          //  twUserAssociated.Nodes.Clear();
        }

        private void btnUserNew_Click(object sender, EventArgs e)
        {
            ResetUser();
            txtUserId.Text = Utils.GetNextId("Users").ToString();
        }

        private void btnUserSave_Click(object sender, EventArgs e)
        {
            CompanyClass uc = new CompanyClass();
            uc.CompanyID = System.Convert.ToInt32(txtUserId.Text);
            uc.CompanyName = txtUserName.Text;
            uc.CompanyCount = System.Convert.ToInt32(textBox4.Text);
            if(uc.SaveMe("") != true)
            {
                MessageBox.Show("Could not save");
            }
            ResetUser();
            LoadAllCompanies();
            LoadAllTrivets();
        }

        private void twUsers_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            CompanyClass uc =e.Node.Tag as CompanyClass;

            txtUserId.Text = uc.CompanyID.ToString();
            txtUserName.Text = uc.CompanyName;
            textBox4.Text = uc.CompanyCount.ToString(); 

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

        #endregion --- Company ---

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
            twWishItems.Nodes.Clear();
            List<DataClass> items = DataClass.GetAllData();
            foreach (DataClass dc in items)
            {

               TreeNode tn = new TreeNode(dc.DataID.ToString());
               tn.Tag = dc;
               twWishItems.Nodes.Add(tn);

            }
        }




         private void btnWishURL_Click(object sender, EventArgs e)
         {
             if (txtWishURL.Text != string.Empty)
             {
                 BrowserForm bf = new BrowserForm(txtWishURL.Text);
                 bf.ShowDialog();
             }            
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

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void chkUserIsFamilyAdmin_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label46_Click(object sender, EventArgs e)
        {

        }

        private void txtUserId_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEventNew_Click_1(object sender, EventArgs e)
        {
            txtEventId.Text = Utils.GetNextId("Event").ToString();
            textBox3.Text = Utils.GetNextId("Events").ToString();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEventId_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEventName_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpEventDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label74_Click(object sender, EventArgs e)
        {

        }

        private void txtEventsId_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void twEvents_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void txtEventAddGuest_TextChanged(object sender, EventArgs e)
        {

        }

        private void twEventGuests_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void chkWishActive_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
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

        private void txtWishDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnWishSave_Click_1(object sender, EventArgs e)
        {
            DataClass dc = new DataClass();
            dc.DataID = System.Convert.ToInt32(txtWishId.Text);
            dc.TrivetID = System.Convert.ToInt32(txtWishName.Text);
            dc.DataTime = dtpEventDate.Value;
            dc.DataWeight = System.Convert.ToInt32(txtWishURL.Text);
            if (dc.SaveMe("") != true)
            {
                MessageBox.Show("Could not save");
            }
        }

        private void btnWishNew_Click_1(object sender, EventArgs e)
        {
            txtWishId.Text = Utils.GetNextId("Wish").ToString();
        }

        private void twWishItems_AfterSelect(object sender, TreeViewEventArgs e)
        {
            twUsers.Nodes.Clear();
            List<CompanyClass> _users = CompanyClass.GetAllCompany();
            foreach (CompanyClass user in _users)
            {
                TreeNode tn = new TreeNode(user.CompanyName);
                tn.Tag = user;
                twUsers.Nodes.Add(tn);
            }
        }

        private void label75_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        #endregion --- Merge Templates ---

        private void btnLangSave_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtFamilyName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
