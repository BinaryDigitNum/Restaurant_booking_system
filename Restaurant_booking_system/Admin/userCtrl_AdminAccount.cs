using Restaurant_booking_system.Interfaces;
using Restaurant_booking_system.Models;
using Restaurant_booking_system.Repositories;



namespace Restaurant_booking_system.Admin
{
    /// <summary>
    /// Admin dashboard needs some UI to indicate account has been created or not.
    /// It also needs extra textbox to double check the new user account password
    /// The buttons can be a little bit smaller
    /// </summary>
    public partial class userCtrl_AdminAccount : UserControl
    {
        private IAdminRepository _dataAccess;
        public userCtrl_AdminAccount()
        {
            InitializeComponent();
            _dataAccess = new AdminRepository(new BookingDataSetTableAdapters.adminTableAdapter());
        }

        private void userCtrl_AdminAccount_Load(object sender, EventArgs e)
        {
            dataGridView_adminAccounts.DataSource = _dataAccess.GetAll();

            cmb_permissions.DataSource = Enum.GetValues(typeof(Administrator.Permissions));

        }

        // This function need to be refactored
        private void btn_createNewAcc_Click(object sender, EventArgs e)
        {
            var username = txt_newAccName.Text;
            var password = txt_newAccPassword.Text;
            var reEnteredPassword = txt_newAccReEnteredPassword.Text;
            var permission = cmb_permissions.SelectedValue.ToString();

            // Check current logged in user permission
            if (Session.Session.LoggedInAdmin.Permission != Administrator.Permissions.CanReadnWrite.ToString())
            {
                lbl_accountOperationsStatus.Text = "You don't have permission to do this action !";
                lbl_accountOperationsStatus.ForeColor = Color.Red;
                return;
            }

            // Check for Null or Empty inputs
            if (string.IsNullOrEmpty(username)
                && string.IsNullOrEmpty(password)
                && string.IsNullOrEmpty(reEnteredPassword))
            {
                MessageBox.Show("Inputs can't be empty");
                txt_newAccName.Focus();
            }

            // Break causes if two passwords are not identical
            if (password != reEnteredPassword)
            {
                lbl_accountOperationsStatus.Text = "Passwords are not identical.";
                lbl_accountOperationsStatus.ForeColor = Color.Red;
            }


            var newAccount = new Administrator()
            {
                Id = Administrator.GenerateId(_dataAccess.GetAll()),
                Username = username,
                Password = password,
                Permission = permission
            };


            // Check if the account creation is successful or not
            if (!_dataAccess.Insert(newAccount))
            {

                MessageBox.Show("User cannot be created. Try again later.");
            }


            lbl_accountOperationsStatus.Text = "New user account has been successfully created. \nReload the table to see the account.";
            lbl_accountOperationsStatus.ForeColor = Color.Green;
            ClearInputs();

        }

        private void btn_reload_Click(object sender, EventArgs e)
        {
            dataGridView_adminAccounts.DataSource = _dataAccess.GetAll();
        }

        private void btn_cancelNewAcc_Click(object sender, EventArgs e)
        {
            txt_newAccName.Text = null;
            txt_newAccPassword.Text = null;
            ClearInputs();
        }

        private void btn_deleteAcc_Click(object sender, EventArgs e)
        {
            if (Session.Session.LoggedInAdmin.Permission != Administrator.Permissions.CanReadnWrite.ToString())
            {
                lbl_accountOperationsStatus.Text = "You don't have permission to do this action !";
                lbl_accountOperationsStatus.ForeColor = Color.Red;
                return;
            }

            if (!_dataAccess.Delete(txt_deleteAccUsername.Text, txt_deleteAccPassword.Text))
            {
                lbl_accountOperationsStatus.Text = "Account cannot be deleted";
                lbl_accountOperationsStatus.ForeColor = Color.Red;
            }

            lbl_accountOperationsStatus.Text = "Account has been deleted.";
            lbl_accountOperationsStatus.ForeColor = Color.Green;
            ClearInputs();

        }

        private void ClearInputs()
        {
            txt_deleteAccPassword.Text = String.Empty;
            txt_deleteAccUsername.Text = String.Empty;
            txt_newAccName.Text = String.Empty;
            txt_newAccPassword.Text = String.Empty;
            txt_newAccReEnteredPassword.Text = String.Empty;
        }
    }
}
