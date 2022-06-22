﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_booking_system.Admin
{
    public partial class Frm_AdminDashboard : Form
    {
        public Frm_AdminDashboard()
        {
            InitializeComponent();
            SwitchUserControl(new userCtrl_adminMenu());
        }

        #region Menu and panels navigations
        private void SwitchUserControl(UserControl userCtrl)
        {
            userCtrl.Dock = DockStyle.Fill;
            userCtrl.Show();
            panel_mainBackground.Controls.Clear();
            panel_mainBackground.Controls.Add(userCtrl);
        }
        private void btn_account_Click(object sender, EventArgs e)
        {
            SwitchUserControl(new userCtrl_AdminAccount());
        }

        private void btn_reservations_Click(object sender, EventArgs e)
        {
            SwitchUserControl(new userCtrl_adminReservations());
        }

        private void btn_services_Click(object sender, EventArgs e)
        {
            SwitchUserControl(new userCtrl_adminServices());
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            SwitchUserControl(new userCtrl_adminMenu());
        }
        #endregion

        #region Menu strips buttons
        private void btn_logout_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip_menu_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip_reservations_Click(object sender, EventArgs e)
        {
            SwitchUserControl(new userCtrl_adminReservations());

        }

        private void menuStrip_account_Click(object sender, EventArgs e)
        {
            SwitchUserControl(new userCtrl_AdminAccount());
        }

        private void menuStrip_logout_Click(object sender, EventArgs e)
        {
        }

        private void menuStrip_exit_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip_services_Click(object sender, EventArgs e)
        {
            SwitchUserControl(new userCtrl_adminServices());
        }


        #endregion

        
    }
}
